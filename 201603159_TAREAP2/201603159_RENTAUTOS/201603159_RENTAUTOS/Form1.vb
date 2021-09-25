Imports System.Math
Public Class Form1
    Private Sub CEFECTIVO_CheckedChanged(sender As Object, e As EventArgs) Handles CEFECTIVO.CheckedChanged
        If (CEFECTIVO.Checked) Then
            TEFECTIVO.Visible = True
            INGRESARCANTIDAD.Visible = True
            TEFECTIVO.Focus()
        Else
            TEFECTIVO.Clear()
            TEFECTIVO.Visible = False
        End If
    End Sub

    Private Sub CTARJETA_CheckedChanged(sender As Object, e As EventArgs) Handles CTARJETA.CheckedChanged
        If (CTARJETA.Checked) Then
            TTARJETA.Visible = True
            INGRESARCANTIDAD.Visible = True
            TTARJETA.Focus()
        Else
            TTARJETA.Clear()
            TTARJETA.Visible = False
        End If
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        ELIMINARVECTORES()
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        ELIMINARENTRADAS()
    End Sub

    Private Sub TNIT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNIT.KeyPress
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

    Private Sub TTARJETA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TTARJETA.KeyPress
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

    Private Sub TDIASALQUILER_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDIASALQUILER.KeyPress
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

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

        If COMBOMARCA.SelectedIndex = -1 Then
            MsgBox("SELECCIONE ALGUNA MARCA")
            COMBOMARCA.Focus() : Exit Sub
        End If

        If TNIT.Text = "" Then
            MsgBox("INGRESE NUMERO DE NIT")
            TNIT.Focus() : Exit Sub
        End If

        If TDIASALQUILER.Text = "" Then
            MsgBox("INGRESE NUMERO DE DIAS DE ALQUILER")
            TDIASALQUILER.Focus() : Exit Sub
        End If

        If TPLACA.Text = "" Then
            MsgBox("INGRESE NUMERO DE PLACA")
            TPLACA.Focus() : Exit Sub
        End If

        If (dato < 6) Then

            Select Case (COMBOMARCA.SelectedIndex)
                Case 0 : PRECIO(dato) = 250
                Case 1 : PRECIO(dato) = 450
                Case 2 : PRECIO(dato) = 325
                Case 3 : PRECIO(dato) = 300
            End Select

            PARCIAL(dato) = Val(TDIASALQUILER.Text) * PRECIO(dato)


            If CEFECTIVO.Checked Then
                    DESC(dato) = Val((PARCIAL(dato) * (5)) / 100)
                VALIDAR(dato) = Val(TEFECTIVO.Text)
            End If

            If CTARJETA.Checked Then
                    DESC(dato) = Val((PARCIAL(dato) * (2.5)) / 100)
                VALIDAR(dato) = Val(TTARJETA.Text)
            End If

            If CEFECTIVO.Checked And CTARJETA.Checked Then
                DESC(dato) = 0
                VALIDAR(dato) = Val(TEFECTIVO.Text) + Val(TTARJETA.Text)
            End If



            If VALIDAR(dato) = PRECIO(dato) Then
                Else
                LAUTO.Text = COMBOMARCA.Text
                LAUTO.Visible = True
                LPRECIO.Text = (String.Format("Q{0:N2}", Double.Parse(PRECIO(dato))))
                LPRECIO.Visible = True

                MsgBox("INGRESE VALOR CORRECTO") : Exit Sub
            End If


            PAGOTOTAL(dato) = Str(PARCIAL(dato) - DESC(dato))

                RESULTADOS()
                dato = dato + 1


            Else dato = 7
            MsgBox("VECTORES LLENOS")
        End If

    End Sub


End Class
