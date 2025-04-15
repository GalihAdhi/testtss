using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Reporting.WinForms;

namespace tssNEW
{
    public partial class Form1 : Form
    {
        long selectedID = -1;
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=;database=tss;");
        Dictionary<string, long> deptMap = new Dictionary<string, long>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDepartemen();
            ReadIndex();
            LoadReport();
        }

        void LoadDepartemen()
        {
            deptMap.Clear();
            comboboxDept.Items.Clear();

            conn.Open();
            string query = "SELECT id, Dept FROM tbl_dept";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string namaDept = reader["Dept"].ToString();
                long idDept = Convert.ToInt64(reader["id"]);
                deptMap[namaDept] = idDept;
                comboboxDept.Items.Add(namaDept);
            }
            conn.Close();

            if (comboboxDept.Items.Count > 0)
                comboboxDept.SelectedIndex = 0;
        }

        void ReadIndex()
        {
            string query = @"
                SELECT k.id, k.NIK, k.Nama, k.Alamat, d.Dept AS Departemen 
                FROM tbl_karyawan k
                JOIN tbl_dept d ON k.Id_Dept = d.id";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewIndex.DataSource = dt;
        }

        private void dataGridViewIndex_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedID = Convert.ToInt64(dataGridViewIndex.Rows[e.RowIndex].Cells["id"].Value);
                textBoxNIK.Text = dataGridViewIndex.Rows[e.RowIndex].Cells["NIK"].Value.ToString();
                textBoxNama.Text = dataGridViewIndex.Rows[e.RowIndex].Cells["Nama"].Value.ToString();
                textBoxAlamat.Text = dataGridViewIndex.Rows[e.RowIndex].Cells["Alamat"].Value.ToString();
                comboboxDept.SelectedItem = dataGridViewIndex.Rows[e.RowIndex].Cells["Departemen"].Value.ToString();
            }
        }

        void ClearInput()
        {
            textBoxNIK.Clear();
            textBoxNama.Clear();
            textBoxAlamat.Clear();
            if (comboboxDept.Items.Count > 0)
                comboboxDept.SelectedIndex = 0;
            selectedID = -1;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO tbl_karyawan (NIK, Nama, Alamat, Id_Dept) VALUES (@NIK, @Nama, @Alamat, @Id_Dept)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NIK", int.Parse(textBoxNIK.Text));
                cmd.Parameters.AddWithValue("@Nama", textBoxNama.Text);
                cmd.Parameters.AddWithValue("@Alamat", textBoxAlamat.Text);
                cmd.Parameters.AddWithValue("@Id_Dept", deptMap[comboboxDept.SelectedItem.ToString()]);
                cmd.ExecuteNonQuery();
                conn.Close();

                ReadIndex();
                ClearInput();
                MessageBox.Show("Data karyawan ditambahkan.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error tambah: " + ex.Message);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (selectedID == -1)
            {
                MessageBox.Show("Pilih data dahulu.");
                return;
            }

            conn.Open();
            string query = "UPDATE tbl_karyawan SET NIK=@NIK, Nama=@Nama, Alamat=@Alamat, Id_Dept=@Id_Dept WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@NIK", int.Parse(textBoxNIK.Text));
            cmd.Parameters.AddWithValue("@Nama", textBoxNama.Text);
            cmd.Parameters.AddWithValue("@Alamat", textBoxAlamat.Text);
            cmd.Parameters.AddWithValue("@Id_Dept", deptMap[comboboxDept.SelectedItem.ToString()]);
            cmd.Parameters.AddWithValue("@id", selectedID);
            cmd.ExecuteNonQuery();
            conn.Close();

            ReadIndex();
            ClearInput();
            MessageBox.Show("Data karyawan diupdate.");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectedID == -1)
            {
                MessageBox.Show("Pilih data dahulu.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Yakin hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                conn.Open();
                string query = "DELETE FROM tbl_karyawan WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", selectedID);
                cmd.ExecuteNonQuery();
                conn.Close();

                ReadIndex();
                ClearInput();
                MessageBox.Show("Data dihapus.");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);

                // Header
                for (int i = 1; i <= dataGridViewIndex.Columns.Count; i++)
                {
                    excelApp.Cells[1, i] = dataGridViewIndex.Columns[i - 1].HeaderText;
                }

                // Data
                for (int i = 0; i < dataGridViewIndex.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewIndex.Columns.Count; j++)
                    {
                        var value = dataGridViewIndex.Rows[i].Cells[j].Value;
                        if (value != null)
                        {
                            excelApp.Cells[i + 2, j + 1] = value.ToString();
                        }
                    }
                }

                SaveFileDialog saveDialog = new SaveFileDialog
                {
                    Filter = "Excel files (*.xlsx)|*.xlsx",
                    Title = "Simpan File Excel",
                    FileName = "DataKaryawan.xlsx"
                };

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    excelApp.ActiveWorkbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                excelApp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal export: " + ex.Message);
            }
        }

        void LoadReport()
        {
            try
            {
                conn.Open();
                string query = @"SELECT k.NIK, k.Nama, k.Alamat, d.Dept AS Departemen 
                         FROM tbl_karyawan k
                         JOIN tbl_dept d ON k.Id_Dept = d.id";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataSet2 ds = new DataSet2();
                adapter.Fill(ds, "KaryawanTable");

                reportViewer1.Reset();
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", ds.Tables["KaryawanTable"]));
                reportViewer1.LocalReport.ReportEmbeddedResource = "tssNEW.Report2.rdlc";
                reportViewer1.RefreshReport();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat laporan: " + ex.Message);
            }
        }


        private void reportViewer1_Load(object sender, EventArgs e) { }
    }
}
