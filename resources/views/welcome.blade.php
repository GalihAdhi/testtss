<!DOCTYPE html>
<html lang="{{ str_replace('_', '-', app()->getLocale()) }}">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <title>Laravel</title>

    <!-- Load Bootstrap 5 CSS via CDN -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" 
          rel="stylesheet" 
          integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" 
          crossorigin="anonymous">
</head>

<body>
    <!-- Navbar / Navigasi Atas -->
    <nav class="navbar navbar-expand-lg navbar-light bg-light">
        <div class="container-fluid">
            <a class="navbar-brand" href="#">Navbar</a>

            <!-- Button toggle untuk responsif mobile -->
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" 
                    data-bs-target="#navbarSupportedContent" 
                    aria-controls="navbarSupportedContent" 
                    aria-expanded="false" 
                    aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>

            <!-- Isi navigasi -->
            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                    <!-- Tombol buka modal untuk tambah karyawan -->
                    <button type="button" class="btn" data-bs-toggle="modal" data-bs-target="#exampleModal">Add Karyawan</button>
                    
                    <!-- Tombol untuk mengekspor data -->
                    <form action="{{ route('export')}}" method="get" style="display:inline;">
                        @csrf
                        <button type="submit" class="btn">Export Excel</button>
                    </form>
                    <form action="{{ route('exportHorizontal')}}" method="get" style="display:inline;">
                        @csrf
                        <button type="submit" class="btn">Export report model 1</button>
                    </form>
                    <form action="{{ route('exportVertikal')}}" method="get" style="display:inline;">
                        @csrf
                        <button type="submit" class="btn">Export report model 2</button>
                    </form>
                </ul>
            </div>
        </div>
    </nav>

    <!-- Modal Tambah Karyawan -->
    <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                
                <!-- Header Modal -->
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Add Karyawan</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                
                <!-- Body Modal -->
                <div class="modal-body">
                    <form action="{{ route('tambahKaryawan') }}" method="post">
                        @csrf
                        <div class="form-group">
                            <!-- Input NIK -->
                            <label class="col-form-label">NIK:</label>
                            <input type="text" class="form-control" name="NIK">

                            <!-- Input Nama -->
                            <label class="col-form-label">Nama:</label>
                            <input type="text" class="form-control" name="Nama">

                            <!-- Input Alamat -->
                            <label class="col-form-label">Alamat:</label>
                            <input type="text" class="form-control" name="Alamat">

                            <!-- Dropdown Departemen -->
                            <label class="col-form-label">Dept:</label>
                            <select class="form-select" name="id_Dept">
                                <option selected>Dept...</option>
                                @foreach($dataDept as $datas)
                                <option value="{{ $datas->id }}">{{ $datas->Dept }}</option>
                                @endforeach
                            </select>
                        </div>
                </div>

                <!-- Footer Modal -->
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
                    <button type="submit" class="btn btn-primary">Save changes</button>
                </div>
                    </form>
            </div>
        </div>
    </div>

    <!-- Tabel Data Karyawan -->
    <table class="table">
        <thead>
            <tr>
                <th scope="col">#</th> <!-- Kolom nomor urut -->
                <th scope="col">NIK</th>
                <th scope="col">Nama</th>
                <th scope="col">ALAMAT</th>
                <th scope="col">DEPT</th>
                <th scope="col">Action</th>
            </tr>
        </thead>
        <tbody>
            @foreach ($data as $datas)
            <tr>
                <th scope="row">{{ $loop->iteration }}</th>
                <td>{{ $datas->NIK }}</td>
                <td>{{ $datas->Nama }}</td>
                <td>{{ $datas->Alamat }}</td>
                <td>{{ $datas->Dept }}</td>
                <td>
                    <!-- Tombol Hapus -->
                    <form action="{{ route('destroyKaryawan', $datas->id) }}" method="post" style="display:inline;">
                        @csrf
                        @method('DELETE')
                        <button type="submit" class="btn btn-outline-danger">Delete</button>
                    </form>

                    <!-- Tombol Edit membuka modal -->
                    <button type="button" class="btn" data-bs-toggle="modal" data-bs-target="#editKaryawan{{ $datas->id }}">Edit</button>

                    <!-- Modal Edit Karyawan -->
                    <div class="modal fade" id="editKaryawan{{ $datas->id }}" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                        <div class="modal-dialog" role="document">
                            <div class="modal-content">
                                
                                <!-- Header Modal -->
                                <div class="modal-header">
                                    <h5 class="modal-title">Edit Karyawan</h5>
                                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>                    
                                </div>
                                
                                <!-- Body Modal -->
                                <div class="modal-body">
                                    <form action="{{ route('editKaryawan', $datas->id) }}" method="post">
                                        @csrf
                                        <div class="form-group">
                                            <label class="col-form-label">NIK:</label>
                                            <input type="text" class="form-control" name="NIK" value="{{ $datas->NIK }}">

                                            <label class="col-form-label">Nama:</label>
                                            <input type="text" class="form-control" name="Nama" value="{{ $datas->Nama }}">

                                            <label class="col-form-label">Alamat:</label>
                                            <input type="text" class="form-control" name="Alamat" value="{{ $datas->Alamat }}">

                                            <label class="col-form-label">Dept:</label>
                                            <select class="form-select" name="id_Dept">
                                                <option selected disabled>Dept...</option>
                                                @foreach($dataDept as $depts)
                                                <option value="{{ $depts->id }}" 
                                                    @if($datas->id_Dept == $depts->id) selected @endif>
                                                    {{ $depts->Dept }}
                                                </option>
                                                @endforeach
                                            </select>
                                        </div>
                                </div>

                                <!-- Footer Modal -->
                                <div class="modal-footer">
                                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
                                    <button type="submit" class="btn btn-primary">Save changes</button>
                                </div>
                                    </form>
                            </div>
                        </div>
                    </div>
                </td>
            </tr>
            @endforeach
        </tbody>
    </table>

    <!-- Load Bootstrap 5 JS Bundle untuk modal dan komponen interaktif -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" 
            integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" 
            crossorigin="anonymous"></script>
</body>
</html>
