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
        Me.COMBOMARCA = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.INGRESARCANTIDAD = New System.Windows.Forms.Label()
        Me.TTARJETA = New System.Windows.Forms.TextBox()
        Me.TEFECTIVO = New System.Windows.Forms.TextBox()
        Me.CTARJETA = New System.Windows.Forms.CheckBox()
        Me.CEFECTIVO = New System.Windows.Forms.CheckBox()
        Me.TDIASALQUILER = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TPLACA = New System.Windows.Forms.TextBox()
        Me.TNIT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARVECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LPLACA = New System.Windows.Forms.ListBox()
        Me.LMARCA = New System.Windows.Forms.ListBox()
        Me.LDIASALQUILER = New System.Windows.Forms.ListBox()
        Me.LPAGOPARCIAL = New System.Windows.Forms.ListBox()
        Me.LPAGOTOTAL = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LDESCUENTO = New System.Windows.Forms.ListBox()
        Me.LAUTO = New System.Windows.Forms.Label()
        Me.LPRECIO = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PLACA DEL AUTOMOVIL ="
        '
        'COMBOMARCA
        '
        Me.COMBOMARCA.FormattingEnabled = True
        Me.COMBOMARCA.Items.AddRange(New Object() {"HONDA", "MERCEDES BENZ", "TOYOTA", "MAZDA"})
        Me.COMBOMARCA.Location = New System.Drawing.Point(163, 94)
        Me.COMBOMARCA.Name = "COMBOMARCA"
        Me.COMBOMARCA.Size = New System.Drawing.Size(121, 21)
        Me.COMBOMARCA.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Controls.Add(Me.LAUTO)
        Me.GroupBox1.Controls.Add(Me.LPRECIO)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.TDIASALQUILER)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.COMBOMARCA)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TPLACA)
        Me.GroupBox1.Controls.Add(Me.TNIT)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(29, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 257)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESE LOS SIGUIENTES DATOS:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.INGRESARCANTIDAD)
        Me.GroupBox2.Controls.Add(Me.TTARJETA)
        Me.GroupBox2.Controls.Add(Me.TEFECTIVO)
        Me.GroupBox2.Controls.Add(Me.CTARJETA)
        Me.GroupBox2.Controls.Add(Me.CEFECTIVO)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(16, 170)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(229, 87)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FORMA DE PAGO ="
        '
        'INGRESARCANTIDAD
        '
        Me.INGRESARCANTIDAD.AutoSize = True
        Me.INGRESARCANTIDAD.Location = New System.Drawing.Point(106, 14)
        Me.INGRESARCANTIDAD.Name = "INGRESARCANTIDAD"
        Me.INGRESARCANTIDAD.Size = New System.Drawing.Size(121, 13)
        Me.INGRESARCANTIDAD.TabIndex = 4
        Me.INGRESARCANTIDAD.Text = "INGRESAR CANTIDAD"
        Me.INGRESARCANTIDAD.Visible = False
        '
        'TTARJETA
        '
        Me.TTARJETA.Location = New System.Drawing.Point(116, 58)
        Me.TTARJETA.Name = "TTARJETA"
        Me.TTARJETA.Size = New System.Drawing.Size(100, 20)
        Me.TTARJETA.TabIndex = 3
        Me.TTARJETA.Visible = False
        '
        'TEFECTIVO
        '
        Me.TEFECTIVO.Location = New System.Drawing.Point(116, 32)
        Me.TEFECTIVO.Name = "TEFECTIVO"
        Me.TEFECTIVO.Size = New System.Drawing.Size(100, 20)
        Me.TEFECTIVO.TabIndex = 2
        Me.TEFECTIVO.Visible = False
        '
        'CTARJETA
        '
        Me.CTARJETA.AutoSize = True
        Me.CTARJETA.Location = New System.Drawing.Point(6, 60)
        Me.CTARJETA.Name = "CTARJETA"
        Me.CTARJETA.Size = New System.Drawing.Size(74, 17)
        Me.CTARJETA.TabIndex = 1
        Me.CTARJETA.Text = "TARJETA"
        Me.CTARJETA.UseVisualStyleBackColor = True
        '
        'CEFECTIVO
        '
        Me.CEFECTIVO.AutoSize = True
        Me.CEFECTIVO.Location = New System.Drawing.Point(6, 34)
        Me.CEFECTIVO.Name = "CEFECTIVO"
        Me.CEFECTIVO.Size = New System.Drawing.Size(78, 17)
        Me.CEFECTIVO.TabIndex = 0
        Me.CEFECTIVO.Text = "EFECTIVO"
        Me.CEFECTIVO.UseVisualStyleBackColor = True
        '
        'TDIASALQUILER
        '
        Me.TDIASALQUILER.Location = New System.Drawing.Point(163, 126)
        Me.TDIASALQUILER.Name = "TDIASALQUILER"
        Me.TDIASALQUILER.Size = New System.Drawing.Size(100, 20)
        Me.TDIASALQUILER.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "DIAS DE ALQUILER ="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "MARCA DEL AUTOMOVIL ="
        '
        'TPLACA
        '
        Me.TPLACA.Location = New System.Drawing.Point(163, 62)
        Me.TPLACA.Name = "TPLACA"
        Me.TPLACA.Size = New System.Drawing.Size(100, 20)
        Me.TPLACA.TabIndex = 3
        '
        'TNIT
        '
        Me.TNIT.Location = New System.Drawing.Point(163, 30)
        Me.TNIT.Name = "TNIT"
        Me.TNIT.Size = New System.Drawing.Size(100, 20)
        Me.TNIT.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIT ="
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Yellow
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.LIMPIARENTRADASToolStripMenuItem, Me.LIMPIARVECTORESToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1132, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.Yellow
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(95, 24)
        Me.ToolStripMenuItem1.Text = "PROCESOS"
        '
        'LIMPIARENTRADASToolStripMenuItem
        '
        Me.LIMPIARENTRADASToolStripMenuItem.BackColor = System.Drawing.Color.Yellow
        Me.LIMPIARENTRADASToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LIMPIARENTRADASToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LIMPIARENTRADASToolStripMenuItem.Name = "LIMPIARENTRADASToolStripMenuItem"
        Me.LIMPIARENTRADASToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.LIMPIARENTRADASToolStripMenuItem.Text = "LIMPIAR ENTRADAS"
        '
        'LIMPIARVECTORESToolStripMenuItem
        '
        Me.LIMPIARVECTORESToolStripMenuItem.BackColor = System.Drawing.Color.Yellow
        Me.LIMPIARVECTORESToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LIMPIARVECTORESToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LIMPIARVECTORESToolStripMenuItem.Name = "LIMPIARVECTORESToolStripMenuItem"
        Me.LIMPIARVECTORESToolStripMenuItem.Size = New System.Drawing.Size(159, 24)
        Me.LIMPIARVECTORESToolStripMenuItem.Text = "LIMPIAR VECTORES"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.BackColor = System.Drawing.Color.Yellow
        Me.SALIRToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SALIRToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Aqua
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(458, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "PLACA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Aqua
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(565, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "MARCA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Aqua
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(652, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "DIAS DE ALQUILER"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Aqua
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(784, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "PAGO PARCIAL"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Aqua
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1025, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "PAGO TOTAL"
        '
        'LPLACA
        '
        Me.LPLACA.FormattingEnabled = True
        Me.LPLACA.Location = New System.Drawing.Point(423, 84)
        Me.LPLACA.Name = "LPLACA"
        Me.LPLACA.Size = New System.Drawing.Size(110, 225)
        Me.LPLACA.TabIndex = 9
        '
        'LMARCA
        '
        Me.LMARCA.FormattingEnabled = True
        Me.LMARCA.Location = New System.Drawing.Point(539, 84)
        Me.LMARCA.Name = "LMARCA"
        Me.LMARCA.Size = New System.Drawing.Size(110, 225)
        Me.LMARCA.TabIndex = 10
        '
        'LDIASALQUILER
        '
        Me.LDIASALQUILER.FormattingEnabled = True
        Me.LDIASALQUILER.Location = New System.Drawing.Point(658, 84)
        Me.LDIASALQUILER.Name = "LDIASALQUILER"
        Me.LDIASALQUILER.Size = New System.Drawing.Size(110, 225)
        Me.LDIASALQUILER.TabIndex = 11
        '
        'LPAGOPARCIAL
        '
        Me.LPAGOPARCIAL.FormattingEnabled = True
        Me.LPAGOPARCIAL.Location = New System.Drawing.Point(777, 84)
        Me.LPAGOPARCIAL.Name = "LPAGOPARCIAL"
        Me.LPAGOPARCIAL.Size = New System.Drawing.Size(110, 225)
        Me.LPAGOPARCIAL.TabIndex = 12
        '
        'LPAGOTOTAL
        '
        Me.LPAGOTOTAL.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPAGOTOTAL.FormattingEnabled = True
        Me.LPAGOTOTAL.ItemHeight = 15
        Me.LPAGOTOTAL.Location = New System.Drawing.Point(1009, 84)
        Me.LPAGOTOTAL.Name = "LPAGOTOTAL"
        Me.LPAGOTOTAL.Size = New System.Drawing.Size(110, 229)
        Me.LPAGOTOTAL.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Aqua
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(904, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 17)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "DESCUENTO"
        '
        'LDESCUENTO
        '
        Me.LDESCUENTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDESCUENTO.FormattingEnabled = True
        Me.LDESCUENTO.Location = New System.Drawing.Point(893, 84)
        Me.LDESCUENTO.Name = "LDESCUENTO"
        Me.LDESCUENTO.Size = New System.Drawing.Size(110, 225)
        Me.LDESCUENTO.TabIndex = 15
        '
        'LAUTO
        '
        Me.LAUTO.AutoSize = True
        Me.LAUTO.BackColor = System.Drawing.Color.Yellow
        Me.LAUTO.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAUTO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LAUTO.Location = New System.Drawing.Point(251, 184)
        Me.LAUTO.Name = "LAUTO"
        Me.LAUTO.Size = New System.Drawing.Size(0, 13)
        Me.LAUTO.TabIndex = 5
        Me.LAUTO.Visible = False
        '
        'LPRECIO
        '
        Me.LPRECIO.AutoSize = True
        Me.LPRECIO.BackColor = System.Drawing.Color.Yellow
        Me.LPRECIO.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPRECIO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LPRECIO.Location = New System.Drawing.Point(251, 209)
        Me.LPRECIO.Name = "LPRECIO"
        Me.LPRECIO.Size = New System.Drawing.Size(0, 13)
        Me.LPRECIO.TabIndex = 6
        Me.LPRECIO.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1132, 309)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(674, -15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(160, 84)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 328)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LDESCUENTO)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LPAGOTOTAL)
        Me.Controls.Add(Me.LPAGOPARCIAL)
        Me.Controls.Add(Me.LDIASALQUILER)
        Me.Controls.Add(Me.LMARCA)
        Me.Controls.Add(Me.LPLACA)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "RENTAUTOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents COMBOMARCA As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CTARJETA As CheckBox
    Friend WithEvents TDIASALQUILER As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TPLACA As TextBox
    Friend WithEvents TNIT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CEFECTIVO As CheckBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LIMPIARENTRADASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARVECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LPLACA As ListBox
    Friend WithEvents LMARCA As ListBox
    Friend WithEvents LDIASALQUILER As ListBox
    Friend WithEvents LPAGOPARCIAL As ListBox
    Friend WithEvents LPAGOTOTAL As ListBox
    Friend WithEvents TTARJETA As TextBox
    Friend WithEvents TEFECTIVO As TextBox
    Friend WithEvents INGRESARCANTIDAD As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LDESCUENTO As ListBox
    Friend WithEvents LAUTO As Label
    Friend WithEvents LPRECIO As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
