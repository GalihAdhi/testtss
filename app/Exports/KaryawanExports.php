<?php

namespace App\Exports;

use App\Models\Karyawan;  // Mengimpor model Karyawan untuk berinteraksi dengan tabel karyawan.
use Maatwebsite\Excel\Concerns\FromCollection;  // Mengimpor interface FromCollection yang memungkinkan ekspor data dari koleksi.
use Illuminate\Support\Facades\DB;  // Mengimpor DB untuk menjalankan query database langsung.
use Maatwebsite\Excel\Concerns\WithHeadings;  // Mengimpor interface WithHeadings untuk menetapkan judul kolom pada file Excel yang dihasilkan.

class KaryawanExports implements FromCollection, WithHeadings
{
    // Fungsi ini digunakan untuk mengambil data yang akan diekspor ke dalam file Excel
    public function collection()
    {
        // Menjalankan query SQL untuk mengambil data karyawan dan departemen yang bergabung melalui JOIN
        $data = DB::select('
            SELECT Kr.NIK as NIK, KR.Nama as Nama, KR.Alamat as Alamat, DP.Dept as Dept
            FROM tbl_karyawan AS KR
            JOIN tbl_dept as DP ON KR.id_Dept = DP.id
        ');

        // Mengembalikan data dalam bentuk koleksi Laravel
        return collect($data); 
    }

    // Fungsi ini menetapkan judul kolom yang akan ditampilkan di file Excel
    public function headings(): array
    {
        // Menyediakan nama kolom untuk file Excel
        return ['NIK', 'Nama', 'Alamat', 'Dept'];
    }
}
