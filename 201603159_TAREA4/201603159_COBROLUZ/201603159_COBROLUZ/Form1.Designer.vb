<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TNIT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TSALAN = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.COMBOSERVICIO = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.COMBOTARIFA = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LISTSERVICIO = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LISTTARIFA = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LISTSALAN = New System.Windows.Forms.ListBox()
        Me.LISTINICIAL = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LISTMORA = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LISTDESCUENTO = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LISTTOTAL = New System.Windows.Forms.ListBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TCONSUMO = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LISTSINDESCUENTO = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(408, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CÁLCULO DE LUZ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(95, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NOMBRE ="
        '
        'TNOMBRE
        '
        Me.TNOMBRE.Location = New System.Drawing.Point(193, 53)
        Me.TNOMBRE.Name = "TNOMBRE"
        Me.TNOMBRE.Size = New System.Drawing.Size(260, 20)
        Me.TNOMBRE.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(136, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "NIT ="
        '
        'TNIT
        '
        Me.TNIT.Location = New System.Drawing.Point(193, 82)
        Me.TNIT.Name = "TNIT"
        Me.TNIT.Size = New System.Drawing.Size(100, 20)
        Me.TNIT.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "SALDO ANTERIOR ="
        '
        'TSALAN
        '
        Me.TSALAN.Location = New System.Drawing.Point(193, 109)
        Me.TSALAN.Name = "TSALAN"
        Me.TSALAN.Size = New System.Drawing.Size(100, 20)
        Me.TSALAN.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.COMBOSERVICIO)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(546, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(171, 69)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TIPO DE SERVICIO:"
        '
        'COMBOSERVICIO
        '
        Me.COMBOSERVICIO.FormattingEnabled = True
        Me.COMBOSERVICIO.Items.AddRange(New Object() {"RESIDENCIAL", "INDUSTRIAL"})
        Me.COMBOSERVICIO.Location = New System.Drawing.Point(21, 26)
        Me.COMBOSERVICIO.Name = "COMBOSERVICIO"
        Me.COMBOSERVICIO.Size = New System.Drawing.Size(121, 29)
        Me.COMBOSERVICIO.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.COMBOTARIFA)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(763, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(161, 69)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TIPO DE TARIFA:"
        '
        'COMBOTARIFA
        '
        Me.COMBOTARIFA.FormattingEnabled = True
        Me.COMBOTARIFA.Items.AddRange(New Object() {"SOCIAL", "NO SOCIAL"})
        Me.COMBOTARIFA.Location = New System.Drawing.Point(18, 28)
        Me.COMBOTARIFA.Name = "COMBOTARIFA"
        Me.COMBOTARIFA.Size = New System.Drawing.Size(121, 29)
        Me.COMBOTARIFA.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(151, 414)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "CALCULAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(269, 414)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(197, 34)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "AGREGAR DATO NUEVO:"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(723, 414)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 34)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "SALIR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 21)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "TIPO DE SERVICIO:"
        '
        'LISTSERVICIO
        '
        Me.LISTSERVICIO.FormattingEnabled = True
        Me.LISTSERVICIO.Location = New System.Drawing.Point(17, 224)
        Me.LISTSERVICIO.Name = "LISTSERVICIO"
        Me.LISTSERVICIO.Size = New System.Drawing.Size(141, 173)
        Me.LISTSERVICIO.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(169, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 21)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "TIPO DE TARIFA:"
        '
        'LISTTARIFA
        '
        Me.LISTTARIFA.FormattingEnabled = True
        Me.LISTTARIFA.Location = New System.Drawing.Point(173, 224)
        Me.LISTTARIFA.Name = "LISTTARIFA"
        Me.LISTTARIFA.Size = New System.Drawing.Size(120, 173)
        Me.LISTTARIFA.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(303, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 21)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "SALDO ANTERIOR:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(455, 200)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 21)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "PAGO INICIAL:"
        '
        'LISTSALAN
        '
        Me.LISTSALAN.FormattingEnabled = True
        Me.LISTSALAN.Location = New System.Drawing.Point(307, 224)
        Me.LISTSALAN.Name = "LISTSALAN"
        Me.LISTSALAN.Size = New System.Drawing.Size(142, 173)
        Me.LISTSALAN.TabIndex = 20
        '
        'LISTINICIAL
        '
        Me.LISTINICIAL.FormattingEnabled = True
        Me.LISTINICIAL.Location = New System.Drawing.Point(459, 224)
        Me.LISTINICIAL.Name = "LISTINICIAL"
        Me.LISTINICIAL.Size = New System.Drawing.Size(120, 173)
        Me.LISTINICIAL.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(594, 200)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 21)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "MORA:"
        '
        'LISTMORA
        '
        Me.LISTMORA.FormattingEnabled = True
        Me.LISTMORA.Location = New System.Drawing.Point(598, 224)
        Me.LISTMORA.Name = "LISTMORA"
        Me.LISTMORA.Size = New System.Drawing.Size(96, 173)
        Me.LISTMORA.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(842, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 21)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "DESCUENTO:"
        '
        'LISTDESCUENTO
        '
        Me.LISTDESCUENTO.FormattingEnabled = True
        Me.LISTDESCUENTO.Location = New System.Drawing.Point(846, 224)
        Me.LISTDESCUENTO.Name = "LISTDESCUENTO"
        Me.LISTDESCUENTO.Size = New System.Drawing.Size(99, 173)
        Me.LISTDESCUENTO.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(959, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 21)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "PAGO TOTAL:"
        '
        'LISTTOTAL
        '
        Me.LISTTOTAL.FormattingEnabled = True
        Me.LISTTOTAL.Location = New System.Drawing.Point(963, 224)
        Me.LISTTOTAL.Name = "LISTTOTAL"
        Me.LISTTOTAL.Size = New System.Drawing.Size(99, 173)
        Me.LISTTOTAL.TabIndex = 27
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(472, 414)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(245, 34)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "LIMPIAR DATOS GUARDADOS:"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 21)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "CONSUMO DE 1 MES ="
        '
        'TCONSUMO
        '
        Me.TCONSUMO.Location = New System.Drawing.Point(193, 135)
        Me.TCONSUMO.Name = "TCONSUMO"
        Me.TCONSUMO.Size = New System.Drawing.Size(100, 20)
        Me.TCONSUMO.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(701, 200)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(133, 21)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "SIN DESCUENTO:"
        '
        'LISTSINDESCUENTO
        '
        Me.LISTSINDESCUENTO.FormattingEnabled = True
        Me.LISTSINDESCUENTO.Location = New System.Drawing.Point(705, 224)
        Me.LISTSINDESCUENTO.Name = "LISTSINDESCUENTO"
        Me.LISTSINDESCUENTO.Size = New System.Drawing.Size(120, 173)
        Me.LISTSINDESCUENTO.TabIndex = 32
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1091, 464)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 460)
        Me.Controls.Add(Me.LISTSINDESCUENTO)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TCONSUMO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.LISTTOTAL)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LISTDESCUENTO)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LISTMORA)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LISTINICIAL)
        Me.Controls.Add(Me.LISTSALAN)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LISTTARIFA)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LISTSERVICIO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TSALAN)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TNIT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TNOMBRE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "CONTROL"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TNOMBRE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TNIT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TSALAN As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents COMBOSERVICIO As ComboBox
    Friend WithEvents COMBOTARIFA As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LISTSERVICIO As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents LISTTARIFA As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LISTSALAN As ListBox
    Friend WithEvents LISTINICIAL As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents LISTMORA As ListBox
    Friend WithEvents Label11 As Label
    Friend WithEvents LISTDESCUENTO As ListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents LISTTOTAL As ListBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TCONSUMO As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents LISTSINDESCUENTO As ListBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
