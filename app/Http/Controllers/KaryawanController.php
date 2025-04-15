<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;  // Mengimpor kelas Request untuk menangani permintaan HTTP.
use Illuminate\Support\Facades\DB;  // Mengimpor DB untuk menjalankan query database langsung.
use App\Models\Karyawan;  // Mengimpor model Karyawan untuk berinteraksi dengan tabel 'tbl_karyawan'.
use App\Exports\KaryawanExports;  // Mengimpor kelas ekspor untuk mengekspor data karyawan ke Excel.
use Maatwebsite\Excel\Facades\Excel;  // Mengimpor kelas Excel untuk ekspor ke file Excel.
use PDF;  // Mengimpor kelas PDF untuk menghasilkan file PDF.

class KaryawanController extends Controller
{
    // Fungsi untuk menampilkan data karyawan dan data departemen
    public function index()
    {
        // Mengambil data karyawan dan menggabungkannya dengan nama departemen
        $data = DB::select('
            SELECT KR.id As id, Kr.NIK as NIK, KR.Nama as Nama, KR.Alamat as Alamat, DP.Dept as Dept, DP.id as id_Dept
            FROM tbl_karyawan AS KR
            JOIN tbl_dept as DP ON KR.id_Dept = DP.id
        ');

        // Mengambil semua data departemen
        $dataDept = DB::select('
            SELECT *
            FROM tbl_dept
        ');

        // Mengembalikan tampilan 'welcome' dengan data karyawan dan departemen
        return view('welcome', compact('data','dataDept'));
    }

    // Fungsi untuk menyimpan data karyawan baru
    public function store(Request $request)
    {
        // Validasi data yang dikirimkan dalam request
        $validatedData = $request->validate([
            'NIK' => 'required',  // NIK harus diisi
            'Nama' => 'required',  // Nama harus diisi
            'Alamat' => 'required',  // Alamat harus diisi
            'id_Dept' => 'required',  // id_Dept harus diisi
        ]);

        // Membuat data karyawan baru berdasarkan data yang sudah divalidasi
        Karyawan::Create($validatedData);

        // Setelah data berhasil disimpan, arahkan kembali ke halaman utama
        return redirect()-> route('index');
    }

    // Fungsi untuk memperbarui data karyawan
    public function update(Request $request, $id)
    {
        // Validasi data yang dikirimkan dalam request
        $validatedData = $request->validate([
            'NIK' => 'required',  // NIK harus diisi
            'Nama' => 'required',  // Nama harus diisi
            'Alamat' => 'required',  // Alamat harus diisi
            'id_Dept' => 'required',  // id_Dept harus diisi
        ]);
        
        // Mencari data karyawan berdasarkan id
        $data = Karyawan::find($id);
        // Memperbarui data karyawan dengan data yang sudah divalidasi
        $data->update($validatedData);

        // Setelah data berhasil diperbarui, arahkan kembali ke halaman utama
        return redirect()->route('index');
    }

    // Fungsi untuk menghapus data karyawan
    public function destroy($id)
    {
        // Mencari data karyawan berdasarkan id
        $data = Karyawan::find($id);
        // Menghapus data karyawan yang ditemukan
        $data->delete();

        // Setelah data berhasil dihapus, arahkan kembali ke halaman utama
        return redirect()-> route('index');
    }

    // Fungsi untuk mengekspor data karyawan ke file Excel
    public function export() 
    {
        // Mengunduh file Excel yang berisi data karyawan
        return Excel::download(new KaryawanExports, 'karyawan.xlsx');
    }

    // Fungsi untuk mengekspor data karyawan ke PDF dengan layout vertikal
    public function exportPDFVertikal()
    {
        // Mengambil semua data karyawan
        $dataKaryawan = Karyawan::all();
        // Mengatur jumlah baris per kolom (untuk pemisahan data dalam kolom)
        $rowsPerColumn = 20;
        // Memecah data karyawan menjadi beberapa bagian (chunk) berdasarkan jumlah baris per kolom
        $columnsData = $dataKaryawan->chunk($rowsPerColumn);

        // Menghasilkan PDF dengan layout vertikal (portrait)
        $pdf = PDF::loadView('karyawan_vertikal', compact('columnsData'))
                ->setPaper('a4', 'portrait');

        // Mengunduh PDF yang sudah dibuat
        return $pdf->download('karyawan_vertikal.pdf');
    }

    // Fungsi untuk mengekspor data karyawan ke PDF dengan layout horizontal
    public function exportPDFHorizontal()
    {
        // Mengambil semua data karyawan
        $dataKaryawan = Karyawan::all();

        // Menghasilkan PDF dengan layout horizontal (landscape)
        $pdf = PDF::loadView('karyawan_horizontal', compact('dataKaryawan'))
                ->setPaper('a4', 'landscape');

        // Mengunduh PDF yang sudah dibuat
        return $pdf->download('karyawan_horizontal.pdf');
    }

}
