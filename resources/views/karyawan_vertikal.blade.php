<!DOCTYPE html>  <!-- Mendeklarasikan tipe dokumen HTML -->
<html>
<head>
    <style>
        /* Mengatur gaya global untuk body halaman */
        body {
            font-family: DejaVu Sans, sans-serif; /* Mengatur jenis font untuk teks dalam body */
            font-size: 10pt; /* Mengatur ukuran font menjadi 10pt */
            margin: 20px; /* Memberikan margin 20px di semua sisi halaman */
            border: 1px solid transparent;  /* Membuat border halaman transparan, tidak terlihat */
        }

        /* Container untuk menampung kolom-kolom yang akan ditampilkan */
        .container {
            display: flex; /* Menggunakan model layout flexbox untuk container */
            /* Flexbox membuat elemen di dalamnya bisa disusun secara fleksibel */
        }

        /* Setiap kolom dalam container akan diberi margin kanan */
        .column {
            margin-right: 40px; /* Memberikan jarak 40px antara kolom satu dengan kolom lainnya */
        }

        /* Menambahkan jarak bawah pada tiap item dalam kolom */
        .item {
            margin-bottom: 10px; /* Memberikan jarak 10px di bawah tiap item */
        }

        /* Gaya untuk label di dalam item, membuatnya lebih menonjol */
        .label {
            font-weight: bold; /* Membuat teks label menjadi tebal */
        }
    </style>
</head>
<body>
    <!-- Bagian utama dari halaman: container ini akan menampung beberapa kolom -->
    <div class="container">
        <!-- Loop pertama: Melakukan iterasi pada data kolom yang diberikan -->
        @foreach($columnsData as $column)
            <div class="column"> <!-- Setiap kolom ditandai dengan div dengan class 'column' -->
                <!-- Loop kedua: Iterasi pada data dalam setiap kolom -->
                @foreach($column as $data)
                    <div class="item"> <!-- Setiap data ditampilkan dalam div dengan class 'item' -->
                        <!-- Menampilkan NIK karyawan -->
                        <div><span class="label">NIK:</span> {{ $data->NIK }}</div>

                        <!-- Menampilkan Nama karyawan -->
                        <div><span class="label">Nama:</span> {{ $data->Nama }}</div>
                    </div>
                @endforeach
            </div>
        @endforeach
    </div>
</body>
</html>
