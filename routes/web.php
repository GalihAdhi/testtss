<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\KaryawanController; // Mengimpor controller yang mengatur semua logika karyawan

// Route untuk menampilkan halaman utama aplikasi yang berisi daftar karyawan
Route::get('/', [KaryawanController::class, 'index'])->name('index');

// Route untuk menyimpan data karyawan baru ke database
// Metode ini dipanggil dari form tambah data
Route::post('/tambah-karyawan', [KaryawanController::class, 'store'])->name('tambahKaryawan');

// Route untuk mengedit atau mengupdate data karyawan berdasarkan ID yang dikirim
// Dijalankan saat form edit disubmit
Route::post('/edit-karyawan/{id}', [KaryawanController::class, 'update'])->name('editKaryawan');

// Route untuk menghapus data karyawan berdasarkan ID
Route::delete('/delete-karyawan/{id}', [KaryawanController::class, 'destroy'])->name('destroyKaryawan');

// Route untuk mengekspor semua data karyawan ke dalam file Excel (.xlsx)
Route::get('/export', [KaryawanController::class, 'export'])->name('export');

// Route untuk mengekspor data karyawan dalam bentuk PDF dengan layout horizontal (menyamping)
Route::get('/export-pdf-horizontal', [KaryawanController::class, 'exportPDFHorizontal'])->name('exportHorizontal');

// Route untuk mengekspor data karyawan dalam bentuk PDF dengan layout vertikal (kebawah)
Route::get('/export-pdf-vertikal', [KaryawanController::class, 'exportPDFVertikal'])->name('exportVertikal');
