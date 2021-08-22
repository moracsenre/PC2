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
        Me.RKI = New System.Windows.Forms.RadioButton()
        Me.RQUE = New System.Windows.Forms.RadioButton()
        Me.RMA = New System.Windows.Forms.RadioButton()
        Me.RIM = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CHI = New System.Windows.Forms.CheckBox()
        Me.CSE = New System.Windows.Forms.CheckBox()
        Me.CAL = New System.Windows.Forms.CheckBox()
        Me.CLI = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.THI = New System.Windows.Forms.TextBox()
        Me.TSE = New System.Windows.Forms.TextBox()
        Me.TAL = New System.Windows.Forms.TextBox()
        Me.TLI = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LPM = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LPC = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PV = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(408, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CALCULO DE PRECIOS DE CUBRECAMAS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RKI)
        Me.GroupBox1.Controls.Add(Me.RQUE)
        Me.GroupBox1.Controls.Add(Me.RMA)
        Me.GroupBox1.Controls.Add(Me.RIM)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(172, 122)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TAMAÑO DE CUBRECAMA:"
        '
        'RKI
        '
        Me.RKI.AutoSize = True
        Me.RKI.Location = New System.Drawing.Point(26, 98)
        Me.RKI.Name = "RKI"
        Me.RKI.Size = New System.Drawing.Size(51, 17)
        Me.RKI.TabIndex = 3
        Me.RKI.TabStop = True
        Me.RKI.Text = "KING"
        Me.RKI.UseVisualStyleBackColor = True
        '
        'RQUE
        '
        Me.RQUE.AutoSize = True
        Me.RQUE.Location = New System.Drawing.Point(26, 75)
        Me.RQUE.Name = "RQUE"
        Me.RQUE.Size = New System.Drawing.Size(63, 17)
        Me.RQUE.TabIndex = 2
        Me.RQUE.TabStop = True
        Me.RQUE.Text = "QUEEN"
        Me.RQUE.UseVisualStyleBackColor = True
        '
        'RMA
        '
        Me.RMA.AutoSize = True
        Me.RMA.Location = New System.Drawing.Point(26, 52)
        Me.RMA.Name = "RMA"
        Me.RMA.Size = New System.Drawing.Size(100, 17)
        Me.RMA.TabIndex = 1
        Me.RMA.TabStop = True
        Me.RMA.Text = "MATRIMONIAL"
        Me.RMA.UseVisualStyleBackColor = True
        '
        'RIM
        '
        Me.RIM.AutoSize = True
        Me.RIM.Location = New System.Drawing.Point(26, 29)
        Me.RIM.Name = "RIM"
        Me.RIM.Size = New System.Drawing.Size(75, 17)
        Me.RIM.TabIndex = 0
        Me.RIM.TabStop = True
        Me.RIM.Text = "IMPERIAL"
        Me.RIM.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CHI)
        Me.GroupBox2.Controls.Add(Me.CSE)
        Me.GroupBox2.Controls.Add(Me.CAL)
        Me.GroupBox2.Controls.Add(Me.CLI)
        Me.GroupBox2.Location = New System.Drawing.Point(229, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(134, 122)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TIPO DE MATERIAL:"
        '
        'CHI
        '
        Me.CHI.AutoSize = True
        Me.CHI.Location = New System.Drawing.Point(23, 96)
        Me.CHI.Name = "CHI"
        Me.CHI.Size = New System.Drawing.Size(93, 17)
        Me.CHI.TabIndex = 3
        Me.CHI.Text = "HILO CRUDO"
        Me.CHI.UseVisualStyleBackColor = True
        '
        'CSE
        '
        Me.CSE.AutoSize = True
        Me.CSE.Location = New System.Drawing.Point(23, 73)
        Me.CSE.Name = "CSE"
        Me.CSE.Size = New System.Drawing.Size(55, 17)
        Me.CSE.TabIndex = 2
        Me.CSE.Text = "SEDA"
        Me.CSE.UseVisualStyleBackColor = True
        '
        'CAL
        '
        Me.CAL.AutoSize = True
        Me.CAL.Location = New System.Drawing.Point(23, 50)
        Me.CAL.Name = "CAL"
        Me.CAL.Size = New System.Drawing.Size(79, 17)
        Me.CAL.TabIndex = 1
        Me.CAL.Text = "ALGODON"
        Me.CAL.UseVisualStyleBackColor = True
        '
        'CLI
        '
        Me.CLI.AutoSize = True
        Me.CLI.Location = New System.Drawing.Point(23, 27)
        Me.CLI.Name = "CLI"
        Me.CLI.Size = New System.Drawing.Size(51, 17)
        Me.CLI.TabIndex = 0
        Me.CLI.Text = "LINO"
        Me.CLI.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.THI)
        Me.GroupBox3.Controls.Add(Me.TSE)
        Me.GroupBox3.Controls.Add(Me.TAL)
        Me.GroupBox3.Controls.Add(Me.TLI)
        Me.GroupBox3.Location = New System.Drawing.Point(391, 81)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(146, 122)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CANTIDAD DE YARDAS:"
        '
        'THI
        '
        Me.THI.Location = New System.Drawing.Point(25, 93)
        Me.THI.Name = "THI"
        Me.THI.Size = New System.Drawing.Size(100, 20)
        Me.THI.TabIndex = 3
        Me.THI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.THI.Visible = False
        '
        'TSE
        '
        Me.TSE.Location = New System.Drawing.Point(25, 70)
        Me.TSE.Name = "TSE"
        Me.TSE.Size = New System.Drawing.Size(100, 20)
        Me.TSE.TabIndex = 2
        Me.TSE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TSE.Visible = False
        '
        'TAL
        '
        Me.TAL.Location = New System.Drawing.Point(25, 47)
        Me.TAL.Name = "TAL"
        Me.TAL.Size = New System.Drawing.Size(100, 20)
        Me.TAL.TabIndex = 1
        Me.TAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TAL.Visible = False
        '
        'TLI
        '
        Me.TLI.Location = New System.Drawing.Point(25, 24)
        Me.TLI.Name = "TLI"
        Me.TLI.Size = New System.Drawing.Size(100, 20)
        Me.TLI.TabIndex = 0
        Me.TLI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TLI.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(97, 386)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "CALCULAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Maroon
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(251, 386)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 34)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "LIMPIAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Maroon
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(391, 386)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 34)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "SALIR"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(114, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 21)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "PRECIO MATERIAL ="
        '
        'LPM
        '
        Me.LPM.AutoSize = True
        Me.LPM.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPM.Location = New System.Drawing.Point(291, 245)
        Me.LPM.Name = "LPM"
        Me.LPM.Size = New System.Drawing.Size(0, 21)
        Me.LPM.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(139, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 21)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "PRECIO COSTO ="
        '
        'LPC
        '
        Me.LPC.AutoSize = True
        Me.LPC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPC.Location = New System.Drawing.Point(291, 279)
        Me.LPC.Name = "LPC"
        Me.LPC.Size = New System.Drawing.Size(0, 21)
        Me.LPC.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(139, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 21)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "PRECIO VENTA ="
        '
        'PV
        '
        Me.PV.AutoSize = True
        Me.PV.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PV.Location = New System.Drawing.Point(291, 316)
        Me.PV.Name = "PV"
        Me.PV.Size = New System.Drawing.Size(0, 21)
        Me.PV.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(271, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 21)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Q."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(271, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 21)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Q."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(271, 245)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 21)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Q."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-31, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(638, 421)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(594, 450)
        Me.Controls.Add(Me.PV)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LPC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LPM)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "FABRICA DE CUBRECAMAS"
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CHI As CheckBox
    Friend WithEvents CSE As CheckBox
    Friend WithEvents CAL As CheckBox
    Friend WithEvents CLI As CheckBox
    Friend WithEvents RKI As RadioButton
    Friend WithEvents RQUE As RadioButton
    Friend WithEvents RMA As RadioButton
    Friend WithEvents RIM As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents THI As TextBox
    Friend WithEvents TSE As TextBox
    Friend WithEvents TAL As TextBox
    Friend WithEvents TLI As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LPM As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LPC As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PV As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
