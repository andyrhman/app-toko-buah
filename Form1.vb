Public Class Form1

    'Mendeklarasikan harga buah
    Const Mangga = 4000
    Const Semangka = 15000
    Const Jeruk = 4000
    Const Apel = 3000
    Const Naga = 6000
    Const Alpukat = 5000
    Const Lemon = 10000

    'Mendekelarasikan variabel array yang bernama item dan TotaItem
    'yang nanti akan digunakan dalam menghitung harga dan jumlah buah
    Dim item(10)
    Dim TotalItem(10)

    'Tombol Keluar
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim Keluar As DialogResult

        Keluar = MessageBox.Show("Anda yakin ingin keluar?", "Sistem Pembayaran",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Keluar = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    'Jumlah buah yang akan diisi
    'akan langsung otomatis dihitung harganya
    Private Sub NumMangga_ValueChanged(sender As Object, e As EventArgs) Handles NumMangga.ValueChanged
        lblMangga.Text = FormatCurrency(NumMangga.Value * Mangga)
    End Sub

    Private Sub NumSemangka_ValueChanged(sender As Object, e As EventArgs) Handles NumSemangka.ValueChanged
        lblSemangka.Text = FormatCurrency(NumSemangka.Value * Semangka)
    End Sub

    Private Sub NumJeruk_ValueChanged(sender As Object, e As EventArgs) Handles NumJeruk.ValueChanged
        lblJeruk.Text = FormatCurrency(NumJeruk.Value * Jeruk)
    End Sub

    Private Sub NumApel_ValueChanged(sender As Object, e As EventArgs) Handles NumApel.ValueChanged
        lblApel.Text = FormatCurrency(NumApel.Value * Apel)
    End Sub

    Private Sub NumNaga_ValueChanged(sender As Object, e As EventArgs) Handles NumNaga.ValueChanged
        lblNaga.Text = FormatCurrency(NumNaga.Value * Naga)
    End Sub

    Private Sub NumAlpukat_ValueChanged(sender As Object, e As EventArgs) Handles NumAlpukat.ValueChanged
        lblAlpukat.Text = FormatCurrency(NumAlpukat.Value * Alpukat)
    End Sub

    Private Sub NumLemon_ValueChanged(sender As Object, e As EventArgs) Handles NumLemon.ValueChanged
        lblLemon.Text = FormatCurrency(NumLemon.Value * Lemon)
    End Sub

    'Reset semua input
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        NumMangga.Value = 0
        NumAlpukat.Value = 0
        NumJeruk.Value = 0
        NumSemangka.Value = 0
        NumApel.Value = 0
        NumNaga.Value = 0
        NumLemon.Value = 0

        lblMangga.Text = ""
        lblSemangka.Text = ""
        lblJeruk.Text = ""
        lblApel.Text = ""
        lblNaga.Text = ""
        lblAlpukat.Text = ""
        lblLemon.Text = ""

        lblTotal.Text = ""
        lbUangBayar.Text = ""
        lbUangKembali.Text = ""
        lblJumlah.Text = ""

        rtResi.Clear()
    End Sub

    'Menghitung jumlah dan harga keseluruhan
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        item(0) = NumMangga.Value * Mangga
        item(1) = NumSemangka.Value * Semangka
        item(2) = NumJeruk.Value * Jeruk
        item(3) = NumApel.Value * Apel
        item(4) = NumNaga.Value * Naga
        item(5) = NumAlpukat.Value * Alpukat
        item(6) = NumLemon.Value * Lemon

        item(7) = item(0) + item(1) + item(2) + item(3) + item(4) + item(5) + item(6)
        lblTotal.Text = FormatCurrency(item(7))

        ' Untuk Total Jumlah buah
        TotalItem(0) = NumMangga.Value
        TotalItem(1) = NumSemangka.Value
        TotalItem(2) = NumJeruk.Value
        TotalItem(3) = NumApel.Value
        TotalItem(4) = NumNaga.Value
        TotalItem(5) = NumAlpukat.Value
        TotalItem(6) = NumLemon.Value
        TotalItem(7) = TotalItem(0) + TotalItem(1) + TotalItem(2) + TotalItem(3) + TotalItem(4) + TotalItem(5) + TotalItem(6)

        lblJumlah.Text = TotalItem(7)



    End Sub

    'Tombol Mencetak Struk
    Private Sub btnResi_Click(sender As Object, e As EventArgs) Handles btnResi.Click

        'Jika pengguna belum mengisi uang bayar
        If String.IsNullOrEmpty(lbUangKembali.Text) Then
            'Maka akan muncul pesan peringatan
            MessageBox.Show("Anda belum mengisi uang bayar", "Sistem Pembayaran",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)

            'Tapi jika pengguna telah mengisi uang bayar
            'maka akan mencetak struk
        ElseIf InStr(lbUangKembali.Text, "") Then
            rtResi.Clear()
            rtResi.AppendText(vbTab & "           Toko Buah Ragam" & vbNewLine)
            rtResi.AppendText(vbTab & "  Jl. Durian, Telp (021) 230132" & vbNewLine)
            rtResi.AppendText(vbNewLine)
            rtResi.AppendText("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" & vbNewLine)
            rtResi.AppendText("Jam " & Date.Now.ToString("hh:mm:ss") & vbTab & vbTab & "            Tgl " & Date.Now.ToString("dd-MM-yyyy") & vbNewLine)
            rtResi.AppendText("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" & vbNewLine)
            rtResi.AppendText(vbNewLine)
            rtResi.AppendText("Nama" & vbTab & "         Jumlah" & vbTab & "Harga" & vbNewLine)
            rtResi.AppendText(vbNewLine)
            rtResi.AppendText(namaMangga.Text & vbTab & NumMangga.Value & vbTab & lblMangga.Text & vbNewLine)
            rtResi.AppendText(namaSemangka.Text & vbTab & NumSemangka.Value & vbTab & lblSemangka.Text & vbNewLine)
            rtResi.AppendText(namaJeruk.Text & vbTab & vbTab & NumJeruk.Value & vbTab & lblJeruk.Text & vbNewLine)
            rtResi.AppendText(namaApel.Text & vbTab & vbTab & NumApel.Value & vbTab & lblApel.Text & vbNewLine)
            rtResi.AppendText(namaNaga.Text & vbTab & NumNaga.Value & vbTab & lblNaga.Text & vbNewLine)
            rtResi.AppendText(namaAlpukat.Text & vbTab & vbTab & NumAlpukat.Value & vbTab & lblAlpukat.Text & vbNewLine)
            rtResi.AppendText(namaLemon.Text & vbTab & vbTab & NumLemon.Value & vbTab & lblLemon.Text & vbNewLine)
            rtResi.AppendText(vbNewLine)
            rtResi.AppendText(namaTotalHarga.Text & vbTab & lblJumlah.Text & vbTab & lblTotal.Text & vbNewLine)
            rtResi.AppendText(vbNewLine)
            rtResi.AppendText(namaUangBayar.Text & vbTab & vbTab & FormatCurrency(lbUangBayar.Text) & vbNewLine)
            rtResi.AppendText(namaUangKembali.Text & vbTab & vbTab & lbUangKembali.Text & vbNewLine)

        End If


    End Sub

    'Menampilkan jam
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblJam.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    'Menampilkan Tanggal
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lblTanggal.Text = Date.Now.ToString("dd-MM-yyyy")
    End Sub

    'Memanggil Form_load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub


    'Menghitung uang kembali
    Private Sub btnUangKembali_Click(sender As Object, e As EventArgs) Handles btnUangKembali.Click
        'Jika pengguna belum menghitung total harga buah
        If String.IsNullOrEmpty(lblTotal.Text) Then
            'Maka akan muncul pesan peringatan
            MessageBox.Show("Anda belum pilih item", "Sistem Pembayaran",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)

            'Tapi jika pengguna telah menghitung total harga buah
        ElseIf InStr(lblTotal.Text, "") Then
            'Maka kode ini akan menghitung uang kembali
            lbUangKembali.Text = FormatCurrency(lbUangBayar.Text - lblTotal.Text)
        End If

    End Sub

End Class
