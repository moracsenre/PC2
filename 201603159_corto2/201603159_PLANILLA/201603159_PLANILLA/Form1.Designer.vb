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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TNOMBRE = New System.Windows.Forms.TextBox()
        Me.TSUELDOBRUTO = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LSELECCION = New System.Windows.Forms.ListBox()
        Me.LDESCUENTO = New System.Windows.Forms.ListBox()
        Me.LVDESCUENTO = New System.Windows.Forms.ListBox()
        Me.LTOTAL = New System.Windows.Forms.ListBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INGRESE NOMBRE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "INGRESE SUELDO BRUTO:"
        '
        'TNOMBRE
        '
        Me.TNOMBRE.Location = New System.Drawing.Point(196, 56)
        Me.TNOMBRE.Name = "TNOMBRE"
        Me.TNOMBRE.Size = New System.Drawing.Size(100, 20)
        Me.TNOMBRE.TabIndex = 2
        '
        'TSUELDOBRUTO
        '
        Me.TSUELDOBRUTO.Location = New System.Drawing.Point(196, 96)
        Me.TSUELDOBRUTO.Name = "TSUELDOBRUTO"
        Me.TSUELDOBRUTO.Size = New System.Drawing.Size(100, 20)
        Me.TSUELDOBRUTO.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(712, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "SALIR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(550, 69)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 47)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "AGREGAR DATO NUEVO"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(631, 80)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 36)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "LIMPIAR LISTA"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(170, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "SELECCION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(305, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "DESCUENTO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(414, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "VALOR SIN DESCUENTO "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(597, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "TOTAL"
        '
        'LSELECCION
        '
        Me.LSELECCION.FormattingEnabled = True
        Me.LSELECCION.Location = New System.Drawing.Point(153, 166)
        Me.LSELECCION.Name = "LSELECCION"
        Me.LSELECCION.Size = New System.Drawing.Size(120, 199)
        Me.LSELECCION.TabIndex = 13
        '
        'LDESCUENTO
        '
        Me.LDESCUENTO.FormattingEnabled = True
        Me.LDESCUENTO.Location = New System.Drawing.Point(285, 166)
        Me.LDESCUENTO.Name = "LDESCUENTO"
        Me.LDESCUENTO.Size = New System.Drawing.Size(120, 199)
        Me.LDESCUENTO.TabIndex = 14
        '
        'LVDESCUENTO
        '
        Me.LVDESCUENTO.FormattingEnabled = True
        Me.LVDESCUENTO.Location = New System.Drawing.Point(417, 166)
        Me.LVDESCUENTO.Name = "LVDESCUENTO"
        Me.LVDESCUENTO.Size = New System.Drawing.Size(120, 199)
        Me.LVDESCUENTO.TabIndex = 15
        '
        'LTOTAL
        '
        Me.LTOTAL.FormattingEnabled = True
        Me.LTOTAL.Location = New System.Drawing.Point(559, 166)
        Me.LTOTAL.Name = "LTOTAL"
        Me.LTOTAL.Size = New System.Drawing.Size(120, 199)
        Me.LTOTAL.TabIndex = 16
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(469, 94)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "ACEPTAR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(310, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(153, 76)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SELECCIONE UNA OPCION:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"IGSS", "ISR"})
        Me.ComboBox1.Location = New System.Drawing.Point(23, 43)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 388)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.LTOTAL)
        Me.Controls.Add(Me.LVDESCUENTO)
        Me.Controls.Add(Me.LDESCUENTO)
        Me.Controls.Add(Me.LSELECCION)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TSUELDOBRUTO)
        Me.Controls.Add(Me.TNOMBRE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TNOMBRE As TextBox
    Friend WithEvents TSUELDOBRUTO As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LSELECCION As ListBox
    Friend WithEvents LDESCUENTO As ListBox
    Friend WithEvents LVDESCUENTO As ListBox
    Friend WithEvents LTOTAL As ListBox
    Friend WithEvents Button4 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
