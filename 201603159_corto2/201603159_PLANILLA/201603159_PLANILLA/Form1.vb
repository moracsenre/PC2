Imports System.Math

Public Class Form1


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (DATO < 6) Then





            If ComboBox1.SelectedIndex = -1 Then
                MsgBox("SELECCIONE ALGUNA OPCION")
                ComboBox1.Focus() : Exit Sub
            End If


            OPCI(DATO) = Val(ComboBox1.SelectedItem)
            SIN(DATO) = TSUELDOBRUTO.Text


            Select Case (ComboBox1.SelectedIndex)
                Case 0 : DESC1(DATO) = (Val(TSUELDOBRUTO.Text) * 15) / 100
                Case 1 : DESC1(DATO) = (Val(TSUELDOBRUTO.Text) * 6) / 100
                Case Else
                    DESC1(DATO) = 0
            End Select


            DESCUENTO(DATO) = Round(DESC1(DATO), 2)

            TOTAL(DATO) = SIN(DATO) - DESCUENTO(DATO)

            resultados()
            DATO = DATO + 1


        Else DATO = 7
            MsgBox("VECTORES LLENOS")

        End If

    End Sub

    Private Sub TSUELDOBRUTO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TSUELDOBRUTO.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TNOMBRE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNOMBRE.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar_entradas()
        TNOMBRE.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        LDESCUENTO.Items.Clear()
        LSELECCION.Items.Clear()
        LVDESCUENTO.Items.Clear()
        LTOTAL.Items.Clear()

        DATO = 0
        TNOMBRE.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Me.Close()
        End If
    End Sub
End Class
