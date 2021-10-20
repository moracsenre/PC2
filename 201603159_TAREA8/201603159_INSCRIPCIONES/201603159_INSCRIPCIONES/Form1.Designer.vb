<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.COMBOPAGO = New System.Windows.Forms.ComboBox()
        Me.TCARNET = New System.Windows.Forms.TextBox()
        Me.TNOMBRE = New System.Windows.Forms.TextBox()
        Me.COMBONIVEL = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBASICO = New System.Windows.Forms.Label()
        Me.COMBOBASICO = New System.Windows.Forms.ComboBox()
        Me.LDIVERSIFICADO = New System.Windows.Forms.Label()
        Me.COMBODIVERSIFICADO = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LTERCERO = New System.Windows.Forms.Label()
        Me.LSEGUNDO = New System.Windows.Forms.Label()
        Me.LPRIMERO = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.LDISEÑO = New System.Windows.Forms.Label()
        Me.LELEC = New System.Windows.Forms.Label()
        Me.LBACH = New System.Windows.Forms.Label()
        Me.LPERITO = New System.Windows.Forms.Label()
        Me.LTOTALGENERAL = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(314, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 30)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CAMINO DEL SABER"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.COMBOPAGO)
        Me.GroupBox1.Controls.Add(Me.TCARNET)
        Me.GroupBox1.Controls.Add(Me.TNOMBRE)
        Me.GroupBox1.Controls.Add(Me.COMBONIVEL)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LBASICO)
        Me.GroupBox1.Controls.Add(Me.COMBOBASICO)
        Me.GroupBox1.Controls.Add(Me.LDIVERSIFICADO)
        Me.GroupBox1.Controls.Add(Me.COMBODIVERSIFICADO)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(52, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 207)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMACION DEL ESTUDIANTE:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 17)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "FORMA DE PAGO ="
        '
        'COMBOPAGO
        '
        Me.COMBOPAGO.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COMBOPAGO.FormattingEnabled = True
        Me.COMBOPAGO.Items.AddRange(New Object() {"EFECTIVO", "TARJETA DE CREDITO", "TRANSFERENCIA POR ACH", "DEPOSITO BANCARIO"})
        Me.COMBOPAGO.Location = New System.Drawing.Point(156, 165)
        Me.COMBOPAGO.Name = "COMBOPAGO"
        Me.COMBOPAGO.Size = New System.Drawing.Size(121, 25)
        Me.COMBOPAGO.TabIndex = 5
        '
        'TCARNET
        '
        Me.TCARNET.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCARNET.Location = New System.Drawing.Point(106, 60)
        Me.TCARNET.Name = "TCARNET"
        Me.TCARNET.Size = New System.Drawing.Size(142, 25)
        Me.TCARNET.TabIndex = 6
        '
        'TNOMBRE
        '
        Me.TNOMBRE.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNOMBRE.Location = New System.Drawing.Point(106, 29)
        Me.TNOMBRE.Name = "TNOMBRE"
        Me.TNOMBRE.Size = New System.Drawing.Size(257, 25)
        Me.TNOMBRE.TabIndex = 5
        '
        'COMBONIVEL
        '
        Me.COMBONIVEL.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COMBONIVEL.FormattingEnabled = True
        Me.COMBONIVEL.Items.AddRange(New Object() {"BASICO", "DIVERSIFICADO"})
        Me.COMBONIVEL.Location = New System.Drawing.Point(242, 90)
        Me.COMBONIVEL.Name = "COMBONIVEL"
        Me.COMBONIVEL.Size = New System.Drawing.Size(121, 25)
        Me.COMBONIVEL.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "NIVEL ESTUDIOS A INSCRIBIRSE ="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "CARNET ="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "NOMBRE ="
        '
        'LBASICO
        '
        Me.LBASICO.AutoSize = True
        Me.LBASICO.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBASICO.Location = New System.Drawing.Point(169, 134)
        Me.LBASICO.Name = "LBASICO"
        Me.LBASICO.Size = New System.Drawing.Size(67, 17)
        Me.LBASICO.TabIndex = 0
        Me.LBASICO.Text = "BASICO ="
        Me.LBASICO.Visible = False
        '
        'COMBOBASICO
        '
        Me.COMBOBASICO.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COMBOBASICO.FormattingEnabled = True
        Me.COMBOBASICO.Items.AddRange(New Object() {"PRIMERO", "SEGUNDO", "TERCERO"})
        Me.COMBOBASICO.Location = New System.Drawing.Point(242, 126)
        Me.COMBOBASICO.Name = "COMBOBASICO"
        Me.COMBOBASICO.Size = New System.Drawing.Size(121, 25)
        Me.COMBOBASICO.TabIndex = 2
        Me.COMBOBASICO.Visible = False
        '
        'LDIVERSIFICADO
        '
        Me.LDIVERSIFICADO.AutoSize = True
        Me.LDIVERSIFICADO.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDIVERSIFICADO.Location = New System.Drawing.Point(121, 134)
        Me.LDIVERSIFICADO.Name = "LDIVERSIFICADO"
        Me.LDIVERSIFICADO.Size = New System.Drawing.Size(115, 17)
        Me.LDIVERSIFICADO.TabIndex = 1
        Me.LDIVERSIFICADO.Text = "DIVERSIFICADO ="
        Me.LDIVERSIFICADO.Visible = False
        '
        'COMBODIVERSIFICADO
        '
        Me.COMBODIVERSIFICADO.FormattingEnabled = True
        Me.COMBODIVERSIFICADO.Items.AddRange(New Object() {"PERITO CONTADOR", "BACHILLERATO", "ELECTRONICA", "DISEÑO GRAFICO"})
        Me.COMBODIVERSIFICADO.Location = New System.Drawing.Point(242, 129)
        Me.COMBODIVERSIFICADO.Name = "COMBODIVERSIFICADO"
        Me.COMBODIVERSIFICADO.Size = New System.Drawing.Size(121, 25)
        Me.COMBODIVERSIFICADO.TabIndex = 3
        Me.COMBODIVERSIFICADO.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LimeGreen
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(678, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 32)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "LIMPIAR MATRIZ"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LimeGreen
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(678, 107)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 52)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "LIMPIAR ENTRADAS"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LimeGreen
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(148, 512)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 43)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "LIMPIAR TOTALES"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LimeGreen
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(528, 107)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(122, 49)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "GUARDAR DATOS"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LimeGreen
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(148, 474)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(122, 32)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "TOTALES"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LimeGreen
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(528, 162)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(122, 49)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "MOSTRAR RESULTADOS"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column7, Me.Column4, Me.Column5, Me.Column8})
        Me.DataGridView1.Location = New System.Drawing.Point(30, 266)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(806, 150)
        Me.DataGridView1.TabIndex = 10
        '
        'Column1
        '
        Me.Column1.HeaderText = "NOMBRE"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "CARNET"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "NIVEL ACADEMICO"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "GRADO BASICO"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "GRADO DIVERSIFICADO"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "FORMA DE PAGO"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "RECARGO"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "TOTAL A PAGAR"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LTERCERO)
        Me.GroupBox2.Controls.Add(Me.LSEGUNDO)
        Me.GroupBox2.Controls.Add(Me.LPRIMERO)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.LDISEÑO)
        Me.GroupBox2.Controls.Add(Me.LELEC)
        Me.GroupBox2.Controls.Add(Me.LBACH)
        Me.GroupBox2.Controls.Add(Me.LPERITO)
        Me.GroupBox2.Controls.Add(Me.LTOTALGENERAL)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(294, 448)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(482, 156)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TOTALES:"
        '
        'LTERCERO
        '
        Me.LTERCERO.AutoSize = True
        Me.LTERCERO.Location = New System.Drawing.Point(313, 112)
        Me.LTERCERO.Name = "LTERCERO"
        Me.LTERCERO.Size = New System.Drawing.Size(0, 17)
        Me.LTERCERO.TabIndex = 27
        '
        'LSEGUNDO
        '
        Me.LSEGUNDO.AutoSize = True
        Me.LSEGUNDO.Location = New System.Drawing.Point(313, 95)
        Me.LSEGUNDO.Name = "LSEGUNDO"
        Me.LSEGUNDO.Size = New System.Drawing.Size(0, 17)
        Me.LSEGUNDO.TabIndex = 26
        '
        'LPRIMERO
        '
        Me.LPRIMERO.AutoSize = True
        Me.LPRIMERO.Location = New System.Drawing.Point(313, 76)
        Me.LPRIMERO.Name = "LPRIMERO"
        Me.LPRIMERO.Size = New System.Drawing.Size(0, 17)
        Me.LPRIMERO.TabIndex = 25
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(231, 112)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 17)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "TERCERO ="
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(225, 93)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 17)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "SEGUNDO ="
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(229, 76)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 17)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "PRIMERO ="
        '
        'LDISEÑO
        '
        Me.LDISEÑO.AutoSize = True
        Me.LDISEÑO.Location = New System.Drawing.Point(150, 130)
        Me.LDISEÑO.Name = "LDISEÑO"
        Me.LDISEÑO.Size = New System.Drawing.Size(0, 17)
        Me.LDISEÑO.TabIndex = 21
        '
        'LELEC
        '
        Me.LELEC.AutoSize = True
        Me.LELEC.Location = New System.Drawing.Point(150, 112)
        Me.LELEC.Name = "LELEC"
        Me.LELEC.Size = New System.Drawing.Size(0, 17)
        Me.LELEC.TabIndex = 20
        '
        'LBACH
        '
        Me.LBACH.AutoSize = True
        Me.LBACH.Location = New System.Drawing.Point(150, 95)
        Me.LBACH.Name = "LBACH"
        Me.LBACH.Size = New System.Drawing.Size(0, 17)
        Me.LBACH.TabIndex = 19
        '
        'LPERITO
        '
        Me.LPERITO.AutoSize = True
        Me.LPERITO.Location = New System.Drawing.Point(150, 78)
        Me.LPERITO.Name = "LPERITO"
        Me.LPERITO.Size = New System.Drawing.Size(0, 17)
        Me.LPERITO.TabIndex = 18
        '
        'LTOTALGENERAL
        '
        Me.LTOTALGENERAL.AutoSize = True
        Me.LTOTALGENERAL.Location = New System.Drawing.Point(129, 26)
        Me.LTOTALGENERAL.Name = "LTOTALGENERAL"
        Me.LTOTALGENERAL.Size = New System.Drawing.Size(0, 17)
        Me.LTOTALGENERAL.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 17)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "DISEÑO GRAFICO ="
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(39, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 17)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "ELECTRONICA ="
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "BACHILLERATO ="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "PERITO CONTADOR ="
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(213, 17)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "TOTAL INSCRITOS POR CARRERA:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "TOTAL GENERAL ="
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.LimeGreen
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(730, 26)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(122, 43)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "SALIR DEL PROGRAMA"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(874, 642)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 616)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "COLEGIO DE SECUNDARIA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents COMBONIVEL As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LDIVERSIFICADO As Label
    Friend WithEvents LBASICO As Label
    Friend WithEvents COMBOBASICO As ComboBox
    Friend WithEvents COMBODIVERSIFICADO As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents COMBOPAGO As ComboBox
    Friend WithEvents TCARNET As TextBox
    Friend WithEvents TNOMBRE As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LDISEÑO As Label
    Friend WithEvents LELEC As Label
    Friend WithEvents LBACH As Label
    Friend WithEvents LPERITO As Label
    Friend WithEvents LTOTALGENERAL As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents LTERCERO As Label
    Friend WithEvents LSEGUNDO As Label
    Friend WithEvents LPRIMERO As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
