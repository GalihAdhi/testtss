namespace tssNEW
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabelKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new tssNEW.DataSet1();
            this.karyawanTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new tssNEW.DataSet2();
            this.dataGridViewIndex = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.textBoxNIK = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.comboboxDept = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.karyawanTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.karyawanTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.karyawanTableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabelKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanTableBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelKBindingSource
            // 
            this.tabelKBindingSource.DataMember = "TabelK";
            this.tabelKBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // karyawanTableBindingSource1
            // 
            this.karyawanTableBindingSource1.DataMember = "KaryawanTable";
            this.karyawanTableBindingSource1.DataSource = this.dataSet2BindingSource;
            // 
            // dataSet2BindingSource
            // 
            this.dataSet2BindingSource.DataSource = this.dataSet2;
            this.dataSet2BindingSource.Position = 0;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewIndex
            // 
            this.dataGridViewIndex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIndex.Location = new System.Drawing.Point(16, 151);
            this.dataGridViewIndex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewIndex.Name = "dataGridViewIndex";
            this.dataGridViewIndex.RowHeadersWidth = 51;
            this.dataGridViewIndex.RowTemplate.Height = 24;
            this.dataGridViewIndex.Size = new System.Drawing.Size(772, 238);
            this.dataGridViewIndex.TabIndex = 0;
            this.dataGridViewIndex.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewIndex_CellContentClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(224, 122);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(143, 122);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.AccessibleName = "";
            this.btnCreate.Location = new System.Drawing.Point(16, 122);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(121, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Add Karyawan";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // textBoxNIK
            // 
            this.textBoxNIK.Location = new System.Drawing.Point(16, 21);
            this.textBoxNIK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNIK.Name = "textBoxNIK";
            this.textBoxNIK.Size = new System.Drawing.Size(120, 22);
            this.textBoxNIK.TabIndex = 3;
            this.textBoxNIK.Text = "NIK";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(16, 62);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(120, 22);
            this.textBoxNama.TabIndex = 3;
            this.textBoxNama.Text = "Nama";
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(172, 22);
            this.textBoxAlamat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(121, 22);
            this.textBoxAlamat.TabIndex = 3;
            this.textBoxAlamat.Text = "Alamat";
            // 
            // comboboxDept
            // 
            this.comboboxDept.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboboxDept.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboboxDept.FormattingEnabled = true;
            this.comboboxDept.Location = new System.Drawing.Point(172, 62);
            this.comboboxDept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboboxDept.Name = "comboboxDept";
            this.comboboxDept.Size = new System.Drawing.Size(121, 24);
            this.comboboxDept.TabIndex = 4;
            this.comboboxDept.Text = "Dept";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(520, 395);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(123, 23);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(665, 395);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.karyawanTableBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "tssNEW.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(311, 15);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(477, 130);
            this.reportViewer1.TabIndex = 6;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // karyawanTableBindingSource
            // 
            this.karyawanTableBindingSource.DataMember = "KaryawanTable";
            this.karyawanTableBindingSource.DataSource = this.dataSet2BindingSource;
            // 
            // karyawanTableBindingSource2
            // 
            this.karyawanTableBindingSource2.DataMember = "KaryawanTable";
            this.karyawanTableBindingSource2.DataSource = this.dataSet2;
            // 
            // dataSet2BindingSource1
            // 
            this.dataSet2BindingSource1.DataSource = this.dataSet2;
            this.dataSet2BindingSource1.Position = 0;
            // 
            // karyawanTableBindingSource3
            // 
            this.karyawanTableBindingSource3.DataMember = "KaryawanTable";
            this.karyawanTableBindingSource3.DataSource = this.dataSet2BindingSource1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.comboboxDept);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.textBoxNIK);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridViewIndex);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanTableBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewIndex;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox textBoxNIK;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.ComboBox comboboxDept;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource karyawanTableBindingSource;
        private System.Windows.Forms.BindingSource dataSet2BindingSource;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource karyawanTableBindingSource1;
        private System.Windows.Forms.BindingSource karyawanTableBindingSource2;
        private System.Windows.Forms.BindingSource dataSet2BindingSource1;
        private System.Windows.Forms.BindingSource karyawanTableBindingSource3;
        private System.Windows.Forms.BindingSource tabelKBindingSource;
        private DataSet1 dataSet1;
    }
}

