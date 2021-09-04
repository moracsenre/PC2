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
        Me.TXSALDOANTERIOR = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RAHORRO = New System.Windows.Forms.RadioButton()
        Me.RPREMIER = New System.Windows.Forms.RadioButton()
        Me.RMONETARIO = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CEFECTIVO = New System.Windows.Forms.CheckBox()
        Me.CCHEBANCOS = New System.Windows.Forms.CheckBox()
        Me.CCHEPROPIO = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TEFECTIVO = New System.Windows.Forms.TextBox()
        Me.TCHEBANCOS = New System.Windows.Forms.TextBox()
        Me.TCHEPROPIO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(532, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CÁLCULO DE INTERESES Y CONTROL DE DEPOSITO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(110, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "INGRESAR SALDO ANTERIOR ="
        '
        'TXSALDOANTERIOR
        '
        Me.TXSALDOANTERIOR.Location = New System.Drawing.Point(365, 64)
        Me.TXSALDOANTERIOR.Name = "TXSALDOANTERIOR"
        Me.TXSALDOANTERIOR.Size = New System.Drawing.Size(141, 20)
        Me.TXSALDOANTERIOR.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RAHORRO)
        Me.GroupBox1.Controls.Add(Me.RPREMIER)
        Me.GroupBox1.Controls.Add(Me.RMONETARIO)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(154, 132)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DEPOSITO:"
        '
        'RAHORRO
        '
        Me.RAHORRO.AutoSize = True
        Me.RAHORRO.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RAHORRO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RAHORRO.Location = New System.Drawing.Point(25, 95)
        Me.RAHORRO.Name = "RAHORRO"
        Me.RAHORRO.Size = New System.Drawing.Size(88, 24)
        Me.RAHORRO.TabIndex = 2
        Me.RAHORRO.TabStop = True
        Me.RAHORRO.Text = "AHORRO"
        Me.RAHORRO.UseVisualStyleBackColor = True
        '
        'RPREMIER
        '
        Me.RPREMIER.AutoSize = True
        Me.RPREMIER.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RPREMIER.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RPREMIER.Location = New System.Drawing.Point(25, 63)
        Me.RPREMIER.Name = "RPREMIER"
        Me.RPREMIER.Size = New System.Drawing.Size(86, 24)
        Me.RPREMIER.TabIndex = 1
        Me.RPREMIER.TabStop = True
        Me.RPREMIER.Text = "PREMIER"
        Me.RPREMIER.UseVisualStyleBackColor = True
        '
        'RMONETARIO
        '
        Me.RMONETARIO.AutoSize = True
        Me.RMONETARIO.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RMONETARIO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RMONETARIO.Location = New System.Drawing.Point(25, 32)
        Me.RMONETARIO.Name = "RMONETARIO"
        Me.RMONETARIO.Size = New System.Drawing.Size(111, 24)
        Me.RMONETARIO.TabIndex = 0
        Me.RMONETARIO.TabStop = True
        Me.RMONETARIO.Text = "MONETARIO"
        Me.RMONETARIO.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CEFECTIVO)
        Me.GroupBox2.Controls.Add(Me.CCHEBANCOS)
        Me.GroupBox2.Controls.Add(Me.CCHEPROPIO)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(187, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(212, 132)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MODO DE DEPOSITO:"
        '
        'CEFECTIVO
        '
        Me.CEFECTIVO.AutoSize = True
        Me.CEFECTIVO.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEFECTIVO.Location = New System.Drawing.Point(36, 91)
        Me.CEFECTIVO.Name = "CEFECTIVO"
        Me.CEFECTIVO.Size = New System.Drawing.Size(97, 25)
        Me.CEFECTIVO.TabIndex = 2
        Me.CEFECTIVO.Text = "EFECTIVO"
        Me.CEFECTIVO.UseVisualStyleBackColor = True
        '
        'CCHEBANCOS
        '
        Me.CCHEBANCOS.AutoSize = True
        Me.CCHEBANCOS.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CCHEBANCOS.Location = New System.Drawing.Point(36, 60)
        Me.CCHEBANCOS.Name = "CCHEBANCOS"
        Me.CCHEBANCOS.Size = New System.Drawing.Size(155, 25)
        Me.CCHEBANCOS.TabIndex = 1
        Me.CCHEBANCOS.Text = "CHEQUE BANCOS"
        Me.CCHEBANCOS.UseVisualStyleBackColor = True
        '
        'CCHEPROPIO
        '
        Me.CCHEPROPIO.AutoSize = True
        Me.CCHEPROPIO.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CCHEPROPIO.Location = New System.Drawing.Point(36, 30)
        Me.CCHEPROPIO.Name = "CCHEPROPIO"
        Me.CCHEPROPIO.Size = New System.Drawing.Size(149, 25)
        Me.CCHEPROPIO.TabIndex = 0
        Me.CCHEPROPIO.Text = "CHEQUE PROPIO"
        Me.CCHEPROPIO.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(343, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Q."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TEFECTIVO)
        Me.GroupBox3.Controls.Add(Me.TCHEBANCOS)
        Me.GroupBox3.Controls.Add(Me.TCHEPROPIO)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(420, 99)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(212, 132)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CANTIDAD DE DEPOSITO:"
        '
        'TEFECTIVO
        '
        Me.TEFECTIVO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TEFECTIVO.Location = New System.Drawing.Point(56, 96)
        Me.TEFECTIVO.Name = "TEFECTIVO"
        Me.TEFECTIVO.Size = New System.Drawing.Size(129, 20)
        Me.TEFECTIVO.TabIndex = 2
        Me.TEFECTIVO.Visible = False
        '
        'TCHEBANCOS
        '
        Me.TCHEBANCOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCHEBANCOS.Location = New System.Drawing.Point(56, 65)
        Me.TCHEBANCOS.Name = "TCHEBANCOS"
        Me.TCHEBANCOS.Size = New System.Drawing.Size(129, 20)
        Me.TCHEBANCOS.TabIndex = 1
        Me.TCHEBANCOS.Visible = False
        '
        'TCHEPROPIO
        '
        Me.TCHEPROPIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCHEPROPIO.Location = New System.Drawing.Point(56, 30)
        Me.TCHEPROPIO.Name = "TCHEPROPIO"
        Me.TCHEPROPIO.Size = New System.Drawing.Size(129, 20)
        Me.TCHEPROPIO.TabIndex = 0
        Me.TCHEPROPIO.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Q."
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 21)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Q."
        Me.Label6.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Q."
        Me.Label4.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(126, 262)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "RESULTADO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(244, 262)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 34)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "LIMPIAR DATOS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(405, 262)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 34)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "SALIR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(658, 318)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 320)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TXSALDOANTERIOR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        Me.Text = "BANCO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXSALDOANTERIOR As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RAHORRO As RadioButton
    Friend WithEvents RPREMIER As RadioButton
    Friend WithEvents RMONETARIO As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CEFECTIVO As CheckBox
    Friend WithEvents CCHEBANCOS As CheckBox
    Friend WithEvents CCHEPROPIO As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TEFECTIVO As TextBox
    Friend WithEvents TCHEBANCOS As TextBox
    Friend WithEvents TCHEPROPIO As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
