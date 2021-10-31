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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GUARDARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOSTRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ESTADISTICAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARVECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARESTADISTICASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ACTUALIZARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ELIMINARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.COMBOEQUIPO = New System.Windows.Forms.ComboBox()
        Me.TTIEMPO = New System.Windows.Forms.TextBox()
        Me.TKILOMETROS = New System.Windows.Forms.TextBox()
        Me.TETAPA = New System.Windows.Forms.TextBox()
        Me.COMBONACIONALIDAD = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TCONSULTAETAPA = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LTPROTEAM = New System.Windows.Forms.Label()
        Me.LTPROCLY = New System.Windows.Forms.Label()
        Me.LTMOVISTAR = New System.Windows.Forms.Label()
        Me.LTSKY = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.LPROTEAM = New System.Windows.Forms.Label()
        Me.LPROCLY = New System.Windows.Forms.Label()
        Me.LMOVISTAR = New System.Windows.Forms.Label()
        Me.LSKY = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LCHAPINES = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gold
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GUARDARToolStripMenuItem, Me.MOSTRARToolStripMenuItem, Me.ESTADISTICAToolStripMenuItem, Me.LIMPIARENTRADASToolStripMenuItem, Me.LIMPIARVECTORESToolStripMenuItem, Me.LIMPIARESTADISTICASToolStripMenuItem, Me.CONSULTARToolStripMenuItem, Me.ACTUALIZARToolStripMenuItem, Me.ELIMINARToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1196, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GUARDARToolStripMenuItem
        '
        Me.GUARDARToolStripMenuItem.Name = "GUARDARToolStripMenuItem"
        Me.GUARDARToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.GUARDARToolStripMenuItem.Text = "GUARDAR"
        '
        'MOSTRARToolStripMenuItem
        '
        Me.MOSTRARToolStripMenuItem.Name = "MOSTRARToolStripMenuItem"
        Me.MOSTRARToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.MOSTRARToolStripMenuItem.Text = "MOSTRAR"
        '
        'ESTADISTICAToolStripMenuItem
        '
        Me.ESTADISTICAToolStripMenuItem.Name = "ESTADISTICAToolStripMenuItem"
        Me.ESTADISTICAToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.ESTADISTICAToolStripMenuItem.Text = "ESTADISTICA"
        '
        'LIMPIARENTRADASToolStripMenuItem
        '
        Me.LIMPIARENTRADASToolStripMenuItem.Name = "LIMPIARENTRADASToolStripMenuItem"
        Me.LIMPIARENTRADASToolStripMenuItem.Size = New System.Drawing.Size(132, 20)
        Me.LIMPIARENTRADASToolStripMenuItem.Text = "LIMPIAR ENTRADAS"
        '
        'LIMPIARVECTORESToolStripMenuItem
        '
        Me.LIMPIARVECTORESToolStripMenuItem.Name = "LIMPIARVECTORESToolStripMenuItem"
        Me.LIMPIARVECTORESToolStripMenuItem.Size = New System.Drawing.Size(128, 20)
        Me.LIMPIARVECTORESToolStripMenuItem.Text = "LIMPIAR VECTORES"
        '
        'LIMPIARESTADISTICASToolStripMenuItem
        '
        Me.LIMPIARESTADISTICASToolStripMenuItem.Name = "LIMPIARESTADISTICASToolStripMenuItem"
        Me.LIMPIARESTADISTICASToolStripMenuItem.Size = New System.Drawing.Size(150, 20)
        Me.LIMPIARESTADISTICASToolStripMenuItem.Text = "LIMPIAR ESTADISTICAS"
        '
        'CONSULTARToolStripMenuItem
        '
        Me.CONSULTARToolStripMenuItem.Name = "CONSULTARToolStripMenuItem"
        Me.CONSULTARToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.CONSULTARToolStripMenuItem.Text = "CONSULTAR"
        '
        'ACTUALIZARToolStripMenuItem
        '
        Me.ACTUALIZARToolStripMenuItem.Name = "ACTUALIZARToolStripMenuItem"
        Me.ACTUALIZARToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.ACTUALIZARToolStripMenuItem.Text = "ACTUALIZAR"
        '
        'ELIMINARToolStripMenuItem
        '
        Me.ELIMINARToolStripMenuItem.Name = "ELIMINARToolStripMenuItem"
        Me.ELIMINARToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.ELIMINARToolStripMenuItem.Text = "ELIMINAR"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGreen
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.COMBOEQUIPO)
        Me.GroupBox1.Controls.Add(Me.TTIEMPO)
        Me.GroupBox1.Controls.Add(Me.TKILOMETROS)
        Me.GroupBox1.Controls.Add(Me.TETAPA)
        Me.GroupBox1.Controls.Add(Me.COMBONACIONALIDAD)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(465, 206)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DEL CICLISTA:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(310, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "MINUTOS"
        '
        'COMBOEQUIPO
        '
        Me.COMBOEQUIPO.FormattingEnabled = True
        Me.COMBOEQUIPO.Items.AddRange(New Object() {"SKY", "MOVISTAR", "PRO CYCLING", "PRO TEAM"})
        Me.COMBOEQUIPO.Location = New System.Drawing.Point(229, 55)
        Me.COMBOEQUIPO.Name = "COMBOEQUIPO"
        Me.COMBOEQUIPO.Size = New System.Drawing.Size(121, 28)
        Me.COMBOEQUIPO.TabIndex = 14
        '
        'TTIEMPO
        '
        Me.TTIEMPO.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTIEMPO.Location = New System.Drawing.Point(229, 123)
        Me.TTIEMPO.Name = "TTIEMPO"
        Me.TTIEMPO.Size = New System.Drawing.Size(75, 27)
        Me.TTIEMPO.TabIndex = 11
        '
        'TKILOMETROS
        '
        Me.TKILOMETROS.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TKILOMETROS.Location = New System.Drawing.Point(229, 88)
        Me.TKILOMETROS.Name = "TKILOMETROS"
        Me.TKILOMETROS.Size = New System.Drawing.Size(121, 27)
        Me.TKILOMETROS.TabIndex = 10
        '
        'TETAPA
        '
        Me.TETAPA.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TETAPA.Location = New System.Drawing.Point(229, 22)
        Me.TETAPA.Name = "TETAPA"
        Me.TETAPA.Size = New System.Drawing.Size(222, 27)
        Me.TETAPA.TabIndex = 8
        '
        'COMBONACIONALIDAD
        '
        Me.COMBONACIONALIDAD.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COMBONACIONALIDAD.FormattingEnabled = True
        Me.COMBONACIONALIDAD.Items.AddRange(New Object() {"GUATEMALTECO", "EXTRANJERO"})
        Me.COMBONACIONALIDAD.Location = New System.Drawing.Point(229, 156)
        Me.COMBONACIONALIDAD.Name = "COMBONACIONALIDAD"
        Me.COMBONACIONALIDAD.Size = New System.Drawing.Size(169, 28)
        Me.COMBONACIONALIDAD.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(101, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "NACIONALIDAD ="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(150, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "TIEMPO ="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "KILOMETROS RECORRIDOS ="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(150, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "EQUIPO ="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NO. ETAPA  DE PARTICIPACION ="
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 274)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(813, 150)
        Me.DataGridView1.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = "ETAPA "
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "EQUIPO"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "KILOMETROS"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "TIEMPO"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "NACIONALIDAD"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "PENALIZACION"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "REDUCCION"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "TIEMPO TOTAL (min)"
        Me.Column8.Name = "Column8"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightGreen
        Me.GroupBox2.Controls.Add(Me.TCONSULTAETAPA)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(489, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(185, 81)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CONSULTAR:"
        '
        'TCONSULTAETAPA
        '
        Me.TCONSULTAETAPA.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCONSULTAETAPA.Location = New System.Drawing.Point(113, 27)
        Me.TCONSULTAETAPA.Name = "TCONSULTAETAPA"
        Me.TCONSULTAETAPA.Size = New System.Drawing.Size(58, 27)
        Me.TCONSULTAETAPA.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(22, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 17)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "NO. ETAPA ="
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightGreen
        Me.GroupBox3.Controls.Add(Me.LTPROTEAM)
        Me.GroupBox3.Controls.Add(Me.LTPROCLY)
        Me.GroupBox3.Controls.Add(Me.LTMOVISTAR)
        Me.GroupBox3.Controls.Add(Me.LTSKY)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.LPROTEAM)
        Me.GroupBox3.Controls.Add(Me.LPROCLY)
        Me.GroupBox3.Controls.Add(Me.LMOVISTAR)
        Me.GroupBox3.Controls.Add(Me.LSKY)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.LCHAPINES)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(831, 59)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(373, 388)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ESTADISTICAS:"
        '
        'LTPROTEAM
        '
        Me.LTPROTEAM.AutoSize = True
        Me.LTPROTEAM.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTPROTEAM.Location = New System.Drawing.Point(137, 351)
        Me.LTPROTEAM.Name = "LTPROTEAM"
        Me.LTPROTEAM.Size = New System.Drawing.Size(0, 21)
        Me.LTPROTEAM.TabIndex = 22
        '
        'LTPROCLY
        '
        Me.LTPROCLY.AutoSize = True
        Me.LTPROCLY.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTPROCLY.Location = New System.Drawing.Point(162, 325)
        Me.LTPROCLY.Name = "LTPROCLY"
        Me.LTPROCLY.Size = New System.Drawing.Size(0, 21)
        Me.LTPROCLY.TabIndex = 21
        '
        'LTMOVISTAR
        '
        Me.LTMOVISTAR.AutoSize = True
        Me.LTMOVISTAR.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTMOVISTAR.Location = New System.Drawing.Point(138, 298)
        Me.LTMOVISTAR.Name = "LTMOVISTAR"
        Me.LTMOVISTAR.Size = New System.Drawing.Size(0, 21)
        Me.LTMOVISTAR.TabIndex = 20
        '
        'LTSKY
        '
        Me.LTSKY.AutoSize = True
        Me.LTSKY.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTSKY.Location = New System.Drawing.Point(79, 272)
        Me.LTSKY.Name = "LTSKY"
        Me.LTSKY.Size = New System.Drawing.Size(0, 21)
        Me.LTSKY.TabIndex = 19
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(31, 351)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(100, 21)
        Me.Label23.TabIndex = 18
        Me.Label23.Text = "PRO TEAM ="
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(31, 325)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(130, 21)
        Me.Label24.TabIndex = 17
        Me.Label24.Text = "PRO CLYCLING ="
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(31, 298)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(101, 21)
        Me.Label25.TabIndex = 16
        Me.Label25.Text = "MOVISTAR ="
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(31, 272)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(52, 21)
        Me.Label26.TabIndex = 15
        Me.Label26.Text = "SKY ="
        '
        'LPROTEAM
        '
        Me.LPROTEAM.AutoSize = True
        Me.LPROTEAM.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPROTEAM.Location = New System.Drawing.Point(137, 202)
        Me.LPROTEAM.Name = "LPROTEAM"
        Me.LPROTEAM.Size = New System.Drawing.Size(0, 21)
        Me.LPROTEAM.TabIndex = 14
        '
        'LPROCLY
        '
        Me.LPROCLY.AutoSize = True
        Me.LPROCLY.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPROCLY.Location = New System.Drawing.Point(162, 176)
        Me.LPROCLY.Name = "LPROCLY"
        Me.LPROCLY.Size = New System.Drawing.Size(0, 21)
        Me.LPROCLY.TabIndex = 13
        '
        'LMOVISTAR
        '
        Me.LMOVISTAR.AutoSize = True
        Me.LMOVISTAR.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMOVISTAR.Location = New System.Drawing.Point(138, 149)
        Me.LMOVISTAR.Name = "LMOVISTAR"
        Me.LMOVISTAR.Size = New System.Drawing.Size(0, 21)
        Me.LMOVISTAR.TabIndex = 12
        '
        'LSKY
        '
        Me.LSKY.AutoSize = True
        Me.LSKY.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSKY.Location = New System.Drawing.Point(79, 123)
        Me.LSKY.Name = "LSKY"
        Me.LSKY.Size = New System.Drawing.Size(0, 21)
        Me.LSKY.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(31, 202)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 21)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "PRO TEAM ="
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(31, 176)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(130, 21)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "PRO CLYCLING ="
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(31, 149)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 21)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "MOVISTAR ="
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(31, 123)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 21)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "SKY ="
        '
        'LCHAPINES
        '
        Me.LCHAPINES.AutoSize = True
        Me.LCHAPINES.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCHAPINES.Location = New System.Drawing.Point(118, 66)
        Me.LCHAPINES.Name = "LCHAPINES"
        Me.LCHAPINES.Size = New System.Drawing.Size(0, 21)
        Me.LCHAPINES.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 246)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(253, 17)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Tiempo total en horas por cada equipo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(249, 17)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Kilómetros recorridos por cada equipo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(351, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "¿Cuántos corredores nacionales hicieron más de 45 km?"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1202, 436)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1196, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "CONTROL DE CICLISTAS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GUARDARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MOSTRARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ESTADISTICAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARENTRADASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARVECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARESTADISTICASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ACTUALIZARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ELIMINARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents COMBOEQUIPO As ComboBox
    Friend WithEvents TTIEMPO As TextBox
    Friend WithEvents TKILOMETROS As TextBox
    Friend WithEvents TETAPA As TextBox
    Friend WithEvents COMBONACIONALIDAD As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TCONSULTAETAPA As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LTPROTEAM As Label
    Friend WithEvents LTPROCLY As Label
    Friend WithEvents LTMOVISTAR As Label
    Friend WithEvents LTSKY As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents LPROTEAM As Label
    Friend WithEvents LPROCLY As Label
    Friend WithEvents LMOVISTAR As Label
    Friend WithEvents LSKY As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LCHAPINES As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
End Class
