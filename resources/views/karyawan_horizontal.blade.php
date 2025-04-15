<!DOCTYPE html>  <!-- Menyatakan bahwa ini adalah dokumen HTML5 -->
<html>
<head>
    <style>
        /* Gaya untuk body halaman */
        body {
            font-family: DejaVu Sans, sans-serif; /* Menentukan jenis font untuk teks di halaman */
            font-size: 10pt; /* Mengatur ukuran font menjadi 10pt */
            margin: 20px; /* Memberikan margin sebesar 20px di seluruh sisi halaman */
        }

        /* Gaya untuk tabel */
        table {
            width: 100%; /* Tabel akan mengambil 100% lebar halaman atau kontainer */
            border-collapse: collapse; /* Menghilangkan jarak antar border sel dalam tabel */
        }

        /* Gaya untuk sel tabel (td) */
        td {
            border: 1px solid #ccc; /* Memberikan border 1px berwarna abu-abu terang pada setiap sel */
            padding: 5px; /* Memberikan jarak 5px di dalam setiap sel */
            vertical-align: top; /* Mengatur agar teks berada di atas sel */
            width: 33.3%; /* Setiap kolom sel memiliki lebar 33.3% dari lebar total tabel (3 kolom per baris) */
            border: 1px solid transparent;  /* Mengatur border sel menjadi transparan, agar tidak terlihat */
        }

        /* Gaya untuk label yang ada dalam tabel */
        .label {
            font-weight: bold; /* Membuat label seperti "NIK" dan "Nama" menjadi tebal */
        }
    </style>
</head>
<body>
    <!-- Tabel yang menampilkan data karyawan -->
    <table>
        <tr> <!-- Baris pertama tabel -->
            <!-- Loop untuk menampilkan data karyawan -->
            @foreach($dataKaryawan as $index => $karyawan)
                <td>
                    <!-- Menampilkan NIK karyawan -->
                    <div><span class="label">NIK:</span> {{ $karyawan->NIK }}</div>

                    <!-- Menampilkan Nama karyawan -->
                    <div><span class="label">Nama:</span> {{ $karyawan->Nama }}</div>
                </td>
                
                <!-- Setiap 3 kolom, buat baris baru -->
                @if(($index + 1) % 3 === 0)
                    </tr><tr> <!-- Menutup baris saat sudah ada 3 kolom dan membuka baris baru -->
                @endif
            @endforeach
        </tr>
    </table>
</body>
</html>
