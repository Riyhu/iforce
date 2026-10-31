# IForce.WebFormsTest

ASP.NET Web Forms application dengan target .NET Framework 4.8.

## Fitur

- Reverse text menggunakan recursive function.
- Pencarian produk.
- Export hasil pencarian ke CSV.

## Menjalankan Project

1. Buka `IForce.WebFormsTest.sln` menggunakan Visual Studio.
2. Restore NuGet packages.
3. Pastikan SQL Server lokal aktif.
4. Jalankan project menggunakan IIS Express.

Connection string berada di `Web.config` dengan nama `IForceSqlServer`.

## Struktur

- `Entities`: entity database.
- `Databases`: `DbContext` dan initializer.
- `Configurations`: konfigurasi database dan dependency injection.
- `Services`: service aplikasi.
- `Default.aspx`: halaman reverse text.
- `Products.aspx`: halaman pencarian produk.
