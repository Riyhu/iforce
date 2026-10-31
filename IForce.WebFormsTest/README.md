# IForce.WebFormsTest

ASP.NET Web Forms klasik dengan target .NET Framework 4.8.

## Alur aplikasi

1. `Default.aspx` menyediakan satu `TextBox` dan tombol `GO`.
2. Tombol `GO` membuka `Result.aspx` dengan input sebagai query string.
3. `ReverseTextService` membalik teks menggunakan fungsi recursive manual.

Fungsi tersebut tidak menggunakan `Array.Reverse`, `Enumerable.Reverse`, `StringBuilder`, atau API pembalik teks bawaan lainnya.
