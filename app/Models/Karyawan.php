<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;
use Illuminate\Database\Eloquent\Factories\HasFactory;

class Karyawan extends Model
{
    use HasFactory;

    protected $table = "tbl_karyawan";

    protected $fillable = [
        'Nama',
        'NIK',
        'Alamat',
        'id_Dept',
    ];
}
