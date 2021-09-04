Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TXSALDOANTERIOR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXSALDOANTERIOR.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TCHEBANCOS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TCHEBANCOS.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TCHEPROPIO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TCHEPROPIO.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TEFECTIVO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TEFECTIVO.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.LSALDOANTERIOR.Text += Str(Val(TXSALDOANTERIOR.Text))

        NUEVODEPOSITO = Val(TCHEPROPIO.Text) + Val(TCHEBANCOS.Text) + Val(TEFECTIVO.Text)
        Form2.LSALDONUEVO.Text += Str(Val(NUEVODEPOSITO))
        SALDODEPOSITO = Val(NUEVODEPOSITO) + Val(TXSALDOANTERIOR.Text)

        If RAHORRO.Checked = True Then
            Select Case SALDODEPOSITO
                Case 1.01 To 1000.99
                    INTERES = A
                    DESCAHORRO = Val((Val(SALDODEPOSITO) * (1.5)) / 100)
                Case 1001 To 5000.99
                    INTERES = B
                    DESCAHORRO = Val((Val(SALDODEPOSITO) * (2.5)) / 100)
                Case 5001 To 15000.99
                    INTERES = C
                    DESCAHORRO = Val((Val(SALDODEPOSITO) * (7.5)) / 100)
                Case >= 15001
                    INTERES = F
                    DESCAHORRO = Val((Val(SALDODEPOSITO) * (10)) / 100)
            End Select
        End If

        If RPREMIER.Checked = True Then
            If 1 >= Val(TXSALDOANTERIOR.Text) < 10001 Then
                INTERES2 = 2.5
                DESCPREMIER = Val((Val(SALDODEPOSITO) * (2.5)) / 100)
            ElseIf 10001 >= Val(TXSALDOANTERIOR.Text) < 15001 Then
                INTERES2 = 3
                DESCPREMIER = Val((Val(SALDODEPOSITO) * (3)) / 100)
            ElseIf Val(TXSALDOANTERIOR.Text) >= 15001 Then
                INTERES2 = 4.5
                DESCPREMIER = Val((Val(SALDODEPOSITO) * (4.5)) / 100)
            End If
        Else
            INTERES2 = 0
            DESCPREMIER = 0
        End If

            TOTAL = Val(DESCPREMIER) + Val(NUEVODEPOSITO) + Val(DESCAHORRO) + Val(TXSALDOANTERIOR.Text)
        Form2.LDESCUENTO.Text += Str((Val(DESCPREMIER) + Val(DESCAHORRO)))
        Form2.LPORCENTAJE.Text += Str(Val(INTERES2) + Val(INTERES))
        Form2.LSINTERES.Text += Str(Val(SALDODEPOSITO))
        Form2.LTOTAL.Text += Str(Val(TOTAL))

        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub CCHEPROPIO_CheckedChanged(sender As Object, e As EventArgs) Handles CCHEPROPIO.CheckedChanged
        If (CCHEPROPIO.Checked) Then
            TCHEPROPIO.Visible = True
            Label4.Visible = True
            TCHEPROPIO.Focus()
        Else
            TCHEPROPIO.Clear()
            TCHEPROPIO.Visible = False
            Label4.Visible = False
        End If
    End Sub

    Private Sub CCHEBANCOS_CheckedChanged(sender As Object, e As EventArgs) Handles CCHEBANCOS.CheckedChanged
        If (CCHEBANCOS.Checked) Then
            TCHEBANCOS.Visible = True
            Label5.Visible = True
            TCHEBANCOS.Focus()
        Else
            TCHEBANCOS.Clear()
            TCHEBANCOS.Visible = False
            Label5.Visible = False
        End If
    End Sub

    Private Sub CEFECTIVO_CheckedChanged(sender As Object, e As EventArgs) Handles CEFECTIVO.CheckedChanged
        If (CEFECTIVO.Checked) Then
            TEFECTIVO.Visible = True
            Label6.Visible = True
            TEFECTIVO.Focus()
        Else
            TEFECTIVO.Clear()
            Label6.Visible = False
            TEFECTIVO.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LIMPIAR()
    End Sub
End Class