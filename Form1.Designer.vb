<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.namaJam = New System.Windows.Forms.Label()
        Me.lblJam = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.rtResi = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnUangKembali = New System.Windows.Forms.Button()
        Me.namaUangKembali = New System.Windows.Forms.Label()
        Me.lbUangKembali = New System.Windows.Forms.TextBox()
        Me.namaUangBayar = New System.Windows.Forms.Label()
        Me.lbUangBayar = New System.Windows.Forms.TextBox()
        Me.lblJumlah = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.namaTotalHarga = New System.Windows.Forms.Label()
        Me.NumLemon = New System.Windows.Forms.NumericUpDown()
        Me.lblLemon = New System.Windows.Forms.Label()
        Me.namaLemon = New System.Windows.Forms.Label()
        Me.NumAlpukat = New System.Windows.Forms.NumericUpDown()
        Me.lblAlpukat = New System.Windows.Forms.Label()
        Me.namaAlpukat = New System.Windows.Forms.Label()
        Me.NumNaga = New System.Windows.Forms.NumericUpDown()
        Me.lblNaga = New System.Windows.Forms.Label()
        Me.namaNaga = New System.Windows.Forms.Label()
        Me.NumApel = New System.Windows.Forms.NumericUpDown()
        Me.lblApel = New System.Windows.Forms.Label()
        Me.namaApel = New System.Windows.Forms.Label()
        Me.NumJeruk = New System.Windows.Forms.NumericUpDown()
        Me.lblJeruk = New System.Windows.Forms.Label()
        Me.namaJeruk = New System.Windows.Forms.Label()
        Me.NumSemangka = New System.Windows.Forms.NumericUpDown()
        Me.lblSemangka = New System.Windows.Forms.Label()
        Me.namaSemangka = New System.Windows.Forms.Label()
        Me.NumMangga = New System.Windows.Forms.NumericUpDown()
        Me.lblMangga = New System.Windows.Forms.Label()
        Me.namaMangga = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnResi = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.NumLemon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumAlpukat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumNaga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumApel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumJeruk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumSemangka, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumMangga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1352, 736)
        Me.Panel1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel5.Controls.Add(Me.lblTanggal)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.namaJam)
        Me.Panel5.Controls.Add(Me.lblJam)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Location = New System.Drawing.Point(301, 14)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(685, 102)
        Me.Panel5.TabIndex = 14
        '
        'lblTanggal
        '
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.BackColor = System.Drawing.Color.Transparent
        Me.lblTanggal.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanggal.ForeColor = System.Drawing.Color.Black
        Me.lblTanggal.Location = New System.Drawing.Point(597, 56)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(58, 39)
        Me.lblTanggal.TabIndex = 18
        Me.lblTanggal.Text = "Label2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(533, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 39)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(235, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Jl. Durian, Telp (021) 230132"
        '
        'namaJam
        '
        Me.namaJam.AutoSize = True
        Me.namaJam.BackColor = System.Drawing.Color.Transparent
        Me.namaJam.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namaJam.ForeColor = System.Drawing.Color.Black
        Me.namaJam.Location = New System.Drawing.Point(17, 56)
        Me.namaJam.Name = "namaJam"
        Me.namaJam.Size = New System.Drawing.Size(43, 39)
        Me.namaJam.TabIndex = 15
        Me.namaJam.Text = "Jam"
        '
        'lblJam
        '
        Me.lblJam.AutoSize = True
        Me.lblJam.BackColor = System.Drawing.Color.Transparent
        Me.lblJam.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJam.ForeColor = System.Drawing.Color.Black
        Me.lblJam.Location = New System.Drawing.Point(60, 56)
        Me.lblJam.Name = "lblJam"
        Me.lblJam.Size = New System.Drawing.Size(58, 39)
        Me.lblJam.TabIndex = 13
        Me.lblJam.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Gabriola", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(227, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 65)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Toko Buah Ragam"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Chocolate
        Me.Panel4.Controls.Add(Me.rtResi)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(905, 144)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(306, 481)
        Me.Panel4.TabIndex = 11
        '
        'rtResi
        '
        Me.rtResi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtResi.Location = New System.Drawing.Point(16, 54)
        Me.rtResi.Name = "rtResi"
        Me.rtResi.Size = New System.Drawing.Size(274, 382)
        Me.rtResi.TabIndex = 29
        Me.rtResi.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Gabriola", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(91, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 45)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "STRUK ANDA"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Chocolate
        Me.Panel3.Controls.Add(Me.btnUangKembali)
        Me.Panel3.Controls.Add(Me.namaUangKembali)
        Me.Panel3.Controls.Add(Me.lbUangKembali)
        Me.Panel3.Controls.Add(Me.namaUangBayar)
        Me.Panel3.Controls.Add(Me.lbUangBayar)
        Me.Panel3.Controls.Add(Me.lblJumlah)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.lblTotal)
        Me.Panel3.Controls.Add(Me.namaTotalHarga)
        Me.Panel3.Controls.Add(Me.NumLemon)
        Me.Panel3.Controls.Add(Me.lblLemon)
        Me.Panel3.Controls.Add(Me.namaLemon)
        Me.Panel3.Controls.Add(Me.NumAlpukat)
        Me.Panel3.Controls.Add(Me.lblAlpukat)
        Me.Panel3.Controls.Add(Me.namaAlpukat)
        Me.Panel3.Controls.Add(Me.NumNaga)
        Me.Panel3.Controls.Add(Me.lblNaga)
        Me.Panel3.Controls.Add(Me.namaNaga)
        Me.Panel3.Controls.Add(Me.NumApel)
        Me.Panel3.Controls.Add(Me.lblApel)
        Me.Panel3.Controls.Add(Me.namaApel)
        Me.Panel3.Controls.Add(Me.NumJeruk)
        Me.Panel3.Controls.Add(Me.lblJeruk)
        Me.Panel3.Controls.Add(Me.namaJeruk)
        Me.Panel3.Controls.Add(Me.NumSemangka)
        Me.Panel3.Controls.Add(Me.lblSemangka)
        Me.Panel3.Controls.Add(Me.namaSemangka)
        Me.Panel3.Controls.Add(Me.NumMangga)
        Me.Panel3.Controls.Add(Me.lblMangga)
        Me.Panel3.Controls.Add(Me.namaMangga)
        Me.Panel3.Location = New System.Drawing.Point(272, 144)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(550, 527)
        Me.Panel3.TabIndex = 10
        '
        'btnUangKembali
        '
        Me.btnUangKembali.BackColor = System.Drawing.Color.SandyBrown
        Me.btnUangKembali.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUangKembali.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUangKembali.Location = New System.Drawing.Point(423, 446)
        Me.btnUangKembali.Name = "btnUangKembali"
        Me.btnUangKembali.Size = New System.Drawing.Size(97, 46)
        Me.btnUangKembali.TabIndex = 10
        Me.btnUangKembali.Text = "HITUNG"
        Me.btnUangKembali.UseVisualStyleBackColor = False
        '
        'namaUangKembali
        '
        Me.namaUangKembali.AutoSize = True
        Me.namaUangKembali.BackColor = System.Drawing.Color.Transparent
        Me.namaUangKembali.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namaUangKembali.ForeColor = System.Drawing.Color.White
        Me.namaUangKembali.Location = New System.Drawing.Point(243, 413)
        Me.namaUangKembali.Name = "namaUangKembali"
        Me.namaUangKembali.Size = New System.Drawing.Size(123, 39)
        Me.namaUangKembali.TabIndex = 31
        Me.namaUangKembali.Text = "Uang Kembali"
        '
        'lbUangKembali
        '
        Me.lbUangKembali.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUangKembali.Location = New System.Drawing.Point(221, 455)
        Me.lbUangKembali.Multiline = True
        Me.lbUangKembali.Name = "lbUangKembali"
        Me.lbUangKembali.Size = New System.Drawing.Size(165, 37)
        Me.lbUangKembali.TabIndex = 30
        '
        'namaUangBayar
        '
        Me.namaUangBayar.AutoSize = True
        Me.namaUangBayar.BackColor = System.Drawing.Color.Transparent
        Me.namaUangBayar.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namaUangBayar.ForeColor = System.Drawing.Color.White
        Me.namaUangBayar.Location = New System.Drawing.Point(61, 413)
        Me.namaUangBayar.Name = "namaUangBayar"
        Me.namaUangBayar.Size = New System.Drawing.Size(106, 39)
        Me.namaUangBayar.TabIndex = 29
        Me.namaUangBayar.Text = "Uang Bayar"
        '
        'lbUangBayar
        '
        Me.lbUangBayar.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbUangBayar.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUangBayar.Location = New System.Drawing.Point(29, 455)
        Me.lbUangBayar.Multiline = True
        Me.lbUangBayar.Name = "lbUangBayar"
        Me.lbUangBayar.Size = New System.Drawing.Size(165, 37)
        Me.lbUangBayar.TabIndex = 28
        '
        'lblJumlah
        '
        Me.lblJumlah.BackColor = System.Drawing.Color.White
        Me.lblJumlah.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblJumlah.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlah.ForeColor = System.Drawing.Color.Black
        Me.lblJumlah.Location = New System.Drawing.Point(454, 340)
        Me.lblJumlah.Name = "lblJumlah"
        Me.lblJumlah.Size = New System.Drawing.Size(77, 27)
        Me.lblJumlah.TabIndex = 27
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Gabriola", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(446, 9)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(94, 45)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "JUMLAH"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Gabriola", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(213, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 45)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "HARGA"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Gabriola", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(22, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(125, 45)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "NAMA ITEM"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.White
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Lime
        Me.lblTotal.Location = New System.Drawing.Point(151, 340)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(215, 27)
        Me.lblTotal.TabIndex = 22
        '
        'namaTotalHarga
        '
        Me.namaTotalHarga.AutoSize = True
        Me.namaTotalHarga.BackColor = System.Drawing.Color.Transparent
        Me.namaTotalHarga.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namaTotalHarga.ForeColor = System.Drawing.Color.White
        Me.namaTotalHarga.Location = New System.Drawing.Point(22, 340)
        Me.namaTotalHarga.Name = "namaTotalHarga"
        Me.namaTotalHarga.Size = New System.Drawing.Size(105, 39)
        Me.namaTotalHarga.TabIndex = 21
        Me.namaTotalHarga.Text = "Total Harga"
        '
        'NumLemon
        '
        Me.NumLemon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumLemon.Location = New System.Drawing.Point(454, 295)
        Me.NumLemon.Name = "NumLemon"
        Me.NumLemon.Size = New System.Drawing.Size(77, 29)
        Me.NumLemon.TabIndex = 20
        '
        'lblLemon
        '
        Me.lblLemon.BackColor = System.Drawing.Color.White
        Me.lblLemon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLemon.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLemon.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblLemon.Location = New System.Drawing.Point(151, 295)
        Me.lblLemon.Name = "lblLemon"
        Me.lblLemon.Size = New System.Drawing.Size(215, 27)
        Me.lblLemon.TabIndex = 19
        '
        'namaLemon
        '
        Me.namaLemon.AutoSize = True
        Me.namaLemon.BackColor = System.Drawing.Color.Transparent
        Me.namaLemon.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namaLemon.ForeColor = System.Drawing.Color.White
        Me.namaLemon.Location = New System.Drawing.Point(22, 295)
        Me.namaLemon.Name = "namaLemon"
        Me.namaLemon.Size = New System.Drawing.Size(65, 39)
        Me.namaLemon.TabIndex = 18
        Me.namaLemon.Text = "Lemon"
        '
        'NumAlpukat
        '
        Me.NumAlpukat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumAlpukat.Location = New System.Drawing.Point(454, 250)
        Me.NumAlpukat.Name = "NumAlpukat"
        Me.NumAlpukat.Size = New System.Drawing.Size(77, 29)
        Me.NumAlpukat.TabIndex = 17
        '
        'lblAlpukat
        '
        Me.lblAlpukat.BackColor = System.Drawing.Color.White
        Me.lblAlpukat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAlpukat.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlpukat.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblAlpukat.Location = New System.Drawing.Point(151, 250)
        Me.lblAlpukat.Name = "lblAlpukat"
        Me.lblAlpukat.Size = New System.Drawing.Size(215, 27)
        Me.lblAlpukat.TabIndex = 16
        '
        'namaAlpukat
        '
        Me.namaAlpukat.AutoSize = True
        Me.namaAlpukat.BackColor = System.Drawing.Color.Transparent
        Me.namaAlpukat.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namaAlpukat.ForeColor = System.Drawing.Color.White
        Me.namaAlpukat.Location = New System.Drawing.Point(22, 250)
        Me.namaAlpukat.Name = "namaAlpukat"
        Me.namaAlpukat.Size = New System.Drawing.Size(77, 39)
        Me.namaAlpukat.TabIndex = 15
        Me.namaAlpukat.Text = "Alpukat"
        '
        'NumNaga
        '
        Me.NumNaga.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumNaga.Location = New System.Drawing.Point(454, 211)
        Me.NumNaga.Name = "NumNaga"
        Me.NumNaga.Size = New System.Drawing.Size(77, 29)
        Me.NumNaga.TabIndex = 14
        '
        'lblNaga
        '
        Me.lblNaga.BackColor = System.Drawing.Color.White
        Me.lblNaga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNaga.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNaga.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblNaga.Location = New System.Drawing.Point(151, 210)
        Me.lblNaga.Name = "lblNaga"
        Me.lblNaga.Size = New System.Drawing.Size(215, 27)
        Me.lblNaga.TabIndex = 13
        '
        'namaNaga
        '
        Me.namaNaga.AutoSize = True
        Me.namaNaga.BackColor = System.Drawing.Color.Transparent
        Me.namaNaga.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namaNaga.ForeColor = System.Drawing.Color.White
        Me.namaNaga.Location = New System.Drawing.Point(22, 208)
        Me.namaNaga.Name = "namaNaga"
        Me.namaNaga.Size = New System.Drawing.Size(100, 39)
        Me.namaNaga.TabIndex = 12
        Me.namaNaga.Text = "Buah Naga"
        '
        'NumApel
        '
        Me.NumApel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumApel.Location = New System.Drawing.Point(454, 173)
        Me.NumApel.Name = "NumApel"
        Me.NumApel.Size = New System.Drawing.Size(77, 29)
        Me.NumApel.TabIndex = 11
        '
        'lblApel
        '
        Me.lblApel.BackColor = System.Drawing.Color.White
        Me.lblApel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblApel.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApel.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblApel.Location = New System.Drawing.Point(151, 172)
        Me.lblApel.Name = "lblApel"
        Me.lblApel.Size = New System.Drawing.Size(215, 27)
        Me.lblApel.TabIndex = 10
        '
        'namaApel
        '
        Me.namaApel.AutoSize = True
        Me.namaApel.BackColor = System.Drawing.Color.Transparent
        Me.namaApel.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namaApel.ForeColor = System.Drawing.Color.White
        Me.namaApel.Location = New System.Drawing.Point(22, 170)
        Me.namaApel.Name = "namaApel"
        Me.namaApel.Size = New System.Drawing.Size(50, 39)
        Me.namaApel.TabIndex = 9
        Me.namaApel.Text = "Apel"
        '
        'NumJeruk
        '
        Me.NumJeruk.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumJeruk.Location = New System.Drawing.Point(454, 132)
        Me.NumJeruk.Name = "NumJeruk"
        Me.NumJeruk.Size = New System.Drawing.Size(77, 29)
        Me.NumJeruk.TabIndex = 8
        '
        'lblJeruk
        '
        Me.lblJeruk.BackColor = System.Drawing.Color.White
        Me.lblJeruk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblJeruk.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJeruk.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblJeruk.Location = New System.Drawing.Point(151, 131)
        Me.lblJeruk.Name = "lblJeruk"
        Me.lblJeruk.Size = New System.Drawing.Size(215, 27)
        Me.lblJeruk.TabIndex = 7
        '
        'namaJeruk
        '
        Me.namaJeruk.AutoSize = True
        Me.namaJeruk.BackColor = System.Drawing.Color.Transparent
        Me.namaJeruk.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namaJeruk.ForeColor = System.Drawing.Color.White
        Me.namaJeruk.Location = New System.Drawing.Point(26, 122)
        Me.namaJeruk.Name = "namaJeruk"
        Me.namaJeruk.Size = New System.Drawing.Size(61, 39)
        Me.namaJeruk.TabIndex = 6
        Me.namaJeruk.Text = "Jeruk "
        '
        'NumSemangka
        '
        Me.NumSemangka.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumSemangka.Location = New System.Drawing.Point(454, 95)
        Me.NumSemangka.Name = "NumSemangka"
        Me.NumSemangka.Size = New System.Drawing.Size(77, 29)
        Me.NumSemangka.TabIndex = 5
        '
        'lblSemangka
        '
        Me.lblSemangka.BackColor = System.Drawing.Color.White
        Me.lblSemangka.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSemangka.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemangka.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblSemangka.Location = New System.Drawing.Point(151, 94)
        Me.lblSemangka.Name = "lblSemangka"
        Me.lblSemangka.Size = New System.Drawing.Size(215, 27)
        Me.lblSemangka.TabIndex = 4
        '
        'namaSemangka
        '
        Me.namaSemangka.AutoSize = True
        Me.namaSemangka.BackColor = System.Drawing.Color.Transparent
        Me.namaSemangka.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namaSemangka.ForeColor = System.Drawing.Color.White
        Me.namaSemangka.Location = New System.Drawing.Point(22, 85)
        Me.namaSemangka.Name = "namaSemangka"
        Me.namaSemangka.Size = New System.Drawing.Size(92, 39)
        Me.namaSemangka.TabIndex = 3
        Me.namaSemangka.Text = "Semangka"
        '
        'NumMangga
        '
        Me.NumMangga.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumMangga.Location = New System.Drawing.Point(454, 57)
        Me.NumMangga.Name = "NumMangga"
        Me.NumMangga.Size = New System.Drawing.Size(77, 29)
        Me.NumMangga.TabIndex = 2
        '
        'lblMangga
        '
        Me.lblMangga.BackColor = System.Drawing.Color.White
        Me.lblMangga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMangga.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMangga.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblMangga.Location = New System.Drawing.Point(151, 56)
        Me.lblMangga.Name = "lblMangga"
        Me.lblMangga.Size = New System.Drawing.Size(215, 27)
        Me.lblMangga.TabIndex = 1
        '
        'namaMangga
        '
        Me.namaMangga.AutoSize = True
        Me.namaMangga.BackColor = System.Drawing.Color.Transparent
        Me.namaMangga.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namaMangga.ForeColor = System.Drawing.Color.White
        Me.namaMangga.Location = New System.Drawing.Point(22, 54)
        Me.namaMangga.Name = "namaMangga"
        Me.namaMangga.Size = New System.Drawing.Size(78, 39)
        Me.namaMangga.TabIndex = 0
        Me.namaMangga.Text = "Mangga"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnResi)
        Me.Panel2.Controls.Add(Me.btnCalculate)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.btnReset)
        Me.Panel2.Location = New System.Drawing.Point(31, 185)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(159, 376)
        Me.Panel2.TabIndex = 9
        '
        'btnResi
        '
        Me.btnResi.BackColor = System.Drawing.Color.SandyBrown
        Me.btnResi.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResi.ForeColor = System.Drawing.SystemColors.Control
        Me.btnResi.Location = New System.Drawing.Point(25, 202)
        Me.btnResi.Name = "btnResi"
        Me.btnResi.Size = New System.Drawing.Size(97, 46)
        Me.btnResi.TabIndex = 9
        Me.btnResi.Text = "CETAK"
        Me.btnResi.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.SandyBrown
        Me.btnCalculate.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCalculate.Location = New System.Drawing.Point(25, 22)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(97, 47)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "HITUNG"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.SandyBrown
        Me.btnExit.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.Control
        Me.btnExit.Location = New System.Drawing.Point(25, 295)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(97, 46)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "KELUAR"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.SandyBrown
        Me.btnReset.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.SystemColors.Control
        Me.btnReset.Location = New System.Drawing.Point(25, 111)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(97, 47)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistem Pembayaran"
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.NumLemon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumAlpukat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumNaga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumApel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumJeruk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumSemangka, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumMangga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents namaMangga As Label
    Friend WithEvents lblMangga As Label
    Friend WithEvents NumMangga As NumericUpDown
    Friend WithEvents NumNaga As NumericUpDown
    Friend WithEvents lblNaga As Label
    Friend WithEvents namaNaga As Label
    Friend WithEvents NumApel As NumericUpDown
    Friend WithEvents lblApel As Label
    Friend WithEvents namaApel As Label
    Friend WithEvents NumJeruk As NumericUpDown
    Friend WithEvents lblJeruk As Label
    Friend WithEvents namaJeruk As Label
    Friend WithEvents NumSemangka As NumericUpDown
    Friend WithEvents lblSemangka As Label
    Friend WithEvents namaSemangka As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents namaTotalHarga As Label
    Friend WithEvents NumLemon As NumericUpDown
    Friend WithEvents lblLemon As Label
    Friend WithEvents namaLemon As Label
    Friend WithEvents NumAlpukat As NumericUpDown
    Friend WithEvents lblAlpukat As Label
    Friend WithEvents namaAlpukat As Label
    Friend WithEvents lblJumlah As Label
    Friend WithEvents btnResi As Button
    Friend WithEvents rtResi As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents namaUangBayar As Label
    Friend WithEvents lbUangBayar As TextBox
    Friend WithEvents namaUangKembali As Label
    Friend WithEvents lbUangKembali As TextBox
    Friend WithEvents btnUangKembali As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblJam As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents namaJam As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblTanggal As Label
End Class
