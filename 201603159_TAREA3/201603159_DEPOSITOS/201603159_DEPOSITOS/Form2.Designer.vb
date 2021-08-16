<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LSALDOANTERIOR = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LPORCENTAJE = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LSALDONUEVO = New System.Windows.Forms.Label()
        Me.LDESCUENTO = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LTOTAL = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LSINTERES = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(250, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Q."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(92, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "SALDO ANTERIOR ="
        '
        'LSALDOANTERIOR
        '
        Me.LSALDOANTERIOR.AutoSize = True
        Me.LSALDOANTERIOR.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSALDOANTERIOR.Location = New System.Drawing.Point(271, 31)
        Me.LSALDOANTERIOR.Name = "LSALDOANTERIOR"
        Me.LSALDOANTERIOR.Size = New System.Drawing.Size(0, 21)
        Me.LSALDOANTERIOR.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "SALDO NUEVO DEPOSITO ="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 21)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "PORCENTAJE DE INTERES ="
        '
        'LPORCENTAJE
        '
        Me.LPORCENTAJE.AutoSize = True
        Me.LPORCENTAJE.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPORCENTAJE.Location = New System.Drawing.Point(271, 122)
        Me.LPORCENTAJE.Name = "LPORCENTAJE"
        Me.LPORCENTAJE.Size = New System.Drawing.Size(0, 21)
        Me.LPORCENTAJE.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(78, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(168, 21)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "MONTO DE INTERES ="
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(250, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 21)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(250, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Q."
        '
        'LSALDONUEVO
        '
        Me.LSALDONUEVO.AutoSize = True
        Me.LSALDONUEVO.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSALDONUEVO.Location = New System.Drawing.Point(271, 61)
        Me.LSALDONUEVO.Name = "LSALDONUEVO"
        Me.LSALDONUEVO.Size = New System.Drawing.Size(0, 21)
        Me.LSALDONUEVO.TabIndex = 11
        '
        'LDESCUENTO
        '
        Me.LDESCUENTO.AutoSize = True
        Me.LDESCUENTO.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDESCUENTO.Location = New System.Drawing.Point(271, 154)
        Me.LDESCUENTO.Name = "LDESCUENTO"
        Me.LDESCUENTO.Size = New System.Drawing.Size(0, 21)
        Me.LDESCUENTO.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(250, 154)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 21)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Q"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 186)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(223, 21)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "SALDO TOTAL CON INTERES ="
        '
        'LTOTAL
        '
        Me.LTOTAL.AutoSize = True
        Me.LTOTAL.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTOTAL.Location = New System.Drawing.Point(269, 186)
        Me.LTOTAL.Name = "LTOTAL"
        Me.LTOTAL.Size = New System.Drawing.Size(0, 21)
        Me.LTOTAL.TabIndex = 20
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(248, 186)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 21)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Q."
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(138, 244)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(154, 36)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "ACEPTAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(75, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 21)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "SALDO SIN INTERES ="
        '
        'LSINTERES
        '
        Me.LSINTERES.AutoSize = True
        Me.LSINTERES.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSINTERES.Location = New System.Drawing.Point(271, 93)
        Me.LSINTERES.Name = "LSINTERES"
        Me.LSINTERES.Size = New System.Drawing.Size(0, 21)
        Me.LSINTERES.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(250, 93)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(22, 21)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Q"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(440, 292)
        Me.Controls.Add(Me.LSINTERES)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.LTOTAL)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LDESCUENTO)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LPORCENTAJE)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LSALDONUEVO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LSALDOANTERIOR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form2"
        Me.Text = "RESULTADOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LSALDOANTERIOR As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LPORCENTAJE As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LSALDONUEVO As Label
    Friend WithEvents LDESCUENTO As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LTOTAL As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents LSINTERES As Label
    Friend WithEvents Label12 As Label
End Class
