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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.COMBOFUNCION = New System.Windows.Forms.ComboBox()
        Me.COMBOCINE = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TENTRADAS = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.LISTSUB = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LISTDESC1 = New System.Windows.Forms.ListBox()
        Me.LISTDESC2 = New System.Windows.Forms.ListBox()
        Me.LISTTOTAL = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LISTFUNCION = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LISTCINE = New System.Windows.Forms.ListBox()
        Me.GRESULTADOS = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GRESULTADOS.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.COMBOFUNCION)
        Me.GroupBox1.Controls.Add(Me.COMBOCINE)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(40, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(277, 154)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SELECCIONE DATOS PEDIDOS:"
        '
        'COMBOFUNCION
        '
        Me.COMBOFUNCION.FormattingEnabled = True
        Me.COMBOFUNCION.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.COMBOFUNCION.Location = New System.Drawing.Point(101, 103)
        Me.COMBOFUNCION.Margin = New System.Windows.Forms.Padding(4)
        Me.COMBOFUNCION.Name = "COMBOFUNCION"
        Me.COMBOFUNCION.Size = New System.Drawing.Size(160, 25)
        Me.COMBOFUNCION.TabIndex = 3
        '
        'COMBOCINE
        '
        Me.COMBOCINE.FormattingEnabled = True
        Me.COMBOCINE.Items.AddRange(New Object() {"A", "B", "C"})
        Me.COMBOCINE.Location = New System.Drawing.Point(101, 43)
        Me.COMBOCINE.Margin = New System.Windows.Forms.Padding(4)
        Me.COMBOCINE.Name = "COMBOCINE"
        Me.COMBOCINE.Size = New System.Drawing.Size(160, 25)
        Me.COMBOCINE.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FUNCION ="
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CINE ="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(37, 186)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "NUMERO DE ENTRADAS ="
        '
        'TENTRADAS
        '
        Me.TENTRADAS.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TENTRADAS.Location = New System.Drawing.Point(215, 178)
        Me.TENTRADAS.Margin = New System.Windows.Forms.Padding(4)
        Me.TENTRADAS.Name = "TENTRADAS"
        Me.TENTRADAS.Size = New System.Drawing.Size(103, 25)
        Me.TENTRADAS.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(379, 135)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 30)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "ACEPTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(612, 111)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 54)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "LIMPIAR LISTAS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(487, 111)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 54)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "AGREGAR DATO NUEVO"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(720, 135)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 30)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "SALIR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'LISTSUB
        '
        Me.LISTSUB.FormattingEnabled = True
        Me.LISTSUB.ItemHeight = 17
        Me.LISTSUB.Location = New System.Drawing.Point(264, 52)
        Me.LISTSUB.Margin = New System.Windows.Forms.Padding(4)
        Me.LISTSUB.Name = "LISTSUB"
        Me.LISTSUB.Size = New System.Drawing.Size(159, 191)
        Me.LISTSUB.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(273, 31)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "SUB TOTAL A PAGAR:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(437, 31)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "DESCUENTO 1:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(553, 31)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "DESCUENTO 2:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(693, 31)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "TOTAL A PAGAR:"
        '
        'LISTDESC1
        '
        Me.LISTDESC1.FormattingEnabled = True
        Me.LISTDESC1.ItemHeight = 17
        Me.LISTDESC1.Location = New System.Drawing.Point(431, 52)
        Me.LISTDESC1.Margin = New System.Windows.Forms.Padding(4)
        Me.LISTDESC1.Name = "LISTDESC1"
        Me.LISTDESC1.Size = New System.Drawing.Size(109, 191)
        Me.LISTDESC1.TabIndex = 15
        '
        'LISTDESC2
        '
        Me.LISTDESC2.FormattingEnabled = True
        Me.LISTDESC2.ItemHeight = 17
        Me.LISTDESC2.Location = New System.Drawing.Point(546, 52)
        Me.LISTDESC2.Margin = New System.Windows.Forms.Padding(4)
        Me.LISTDESC2.Name = "LISTDESC2"
        Me.LISTDESC2.Size = New System.Drawing.Size(115, 191)
        Me.LISTDESC2.TabIndex = 16
        '
        'LISTTOTAL
        '
        Me.LISTTOTAL.FormattingEnabled = True
        Me.LISTTOTAL.ItemHeight = 17
        Me.LISTTOTAL.Location = New System.Drawing.Point(670, 52)
        Me.LISTTOTAL.Margin = New System.Windows.Forms.Padding(4)
        Me.LISTTOTAL.Name = "LISTTOTAL"
        Me.LISTTOTAL.Size = New System.Drawing.Size(159, 191)
        Me.LISTTOTAL.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(162, 31)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "FUNCION:"
        '
        'LISTFUNCION
        '
        Me.LISTFUNCION.FormattingEnabled = True
        Me.LISTFUNCION.ItemHeight = 17
        Me.LISTFUNCION.Location = New System.Drawing.Point(146, 52)
        Me.LISTFUNCION.Margin = New System.Windows.Forms.Padding(4)
        Me.LISTFUNCION.Name = "LISTFUNCION"
        Me.LISTFUNCION.Size = New System.Drawing.Size(109, 191)
        Me.LISTFUNCION.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(61, 31)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "CINE:"
        '
        'LISTCINE
        '
        Me.LISTCINE.FormattingEnabled = True
        Me.LISTCINE.ItemHeight = 17
        Me.LISTCINE.Location = New System.Drawing.Point(27, 52)
        Me.LISTCINE.Margin = New System.Windows.Forms.Padding(4)
        Me.LISTCINE.Name = "LISTCINE"
        Me.LISTCINE.Size = New System.Drawing.Size(109, 191)
        Me.LISTCINE.TabIndex = 21
        '
        'GRESULTADOS
        '
        Me.GRESULTADOS.Controls.Add(Me.LISTCINE)
        Me.GRESULTADOS.Controls.Add(Me.Label9)
        Me.GRESULTADOS.Controls.Add(Me.LISTFUNCION)
        Me.GRESULTADOS.Controls.Add(Me.Label8)
        Me.GRESULTADOS.Controls.Add(Me.LISTTOTAL)
        Me.GRESULTADOS.Controls.Add(Me.LISTDESC2)
        Me.GRESULTADOS.Controls.Add(Me.LISTDESC1)
        Me.GRESULTADOS.Controls.Add(Me.Label7)
        Me.GRESULTADOS.Controls.Add(Me.Label6)
        Me.GRESULTADOS.Controls.Add(Me.Label5)
        Me.GRESULTADOS.Controls.Add(Me.Label4)
        Me.GRESULTADOS.Controls.Add(Me.LISTSUB)
        Me.GRESULTADOS.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRESULTADOS.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GRESULTADOS.Location = New System.Drawing.Point(40, 229)
        Me.GRESULTADOS.Name = "GRESULTADOS"
        Me.GRESULTADOS.Size = New System.Drawing.Size(856, 260)
        Me.GRESULTADOS.TabIndex = 22
        Me.GRESULTADOS.TabStop = False
        Me.GRESULTADOS.Text = "RESULTADOS:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-8, -10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(917, 733)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(908, 660)
        Me.Controls.Add(Me.GRESULTADOS)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TENTRADAS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "CONTROL"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GRESULTADOS.ResumeLayout(False)
        Me.GRESULTADOS.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents COMBOFUNCION As ComboBox
    Friend WithEvents COMBOCINE As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TENTRADAS As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents LISTSUB As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LISTDESC1 As ListBox
    Friend WithEvents LISTDESC2 As ListBox
    Friend WithEvents LISTTOTAL As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents LISTFUNCION As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents LISTCINE As ListBox
    Friend WithEvents GRESULTADOS As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
