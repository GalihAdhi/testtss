<?php

namespace Database\Seeders;

use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;


class AllSeed extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        $Karywan_seed = [
            [
                'NIK' => '9001',
                'Nama' => 'Andi',
                'Alamat' => 'Kudus',
                'Id_Dept' => '3',
            ],
            [
                'NIK' => '9002',
                'Nama' => 'Ammar',
                'Alamat' => 'Kudus',
                'Id_Dept' => '5',
            ],
            [
                'NIK' => '9003',
                'Nama' => 'Beni',
                'Alamat' => 'Semarang',
                'Id_Dept' => '4',
            ],
            [
                'NIK' => '9004',
                'Nama' => 'Bagus',
                'Alamat' => 'Kudus',
                'Id_Dept' => '1',
            ],
            [
                'NIK' => '9005',
                'Nama' => 'Chika',
                'Alamat' => 'Pati',
                'Id_Dept' => '3',
            ],
            [
                'NIK' => '9006',
                'Nama' => 'Doni',
                'Alamat' => 'Semarang',
                'Id_Dept' => '3',
            ],
            [
                'NIK' => '9007',
                'Nama' => 'Ega',
                'Alamat' => 'Kudus',
                'Id_Dept' => '6',
            ],
            [
                'NIK' => '9008',
                'Nama' => 'Ferry',
                'Alamat' => 'Kudus',
                'Id_Dept' => '2',
            ],
        ];

        $Dept_seed = [
            [
                'Dept' => 'HR',
            ],
            [
                'Dept' => 'Marketing',
            ],
            [
                'Dept' => 'Kalkulasi',
            ],
            [
                'Dept' => 'QA',
            ],
            [
                'Dept' => 'Produksi',
            ],
            [
                'Dept' => 'IT',
            ],
            
        ];


        DB::table('tbl_karyawan')->insert($Karywan_seed);
        DB::table('tbl_dept')->insert($Dept_seed);
    }
}
