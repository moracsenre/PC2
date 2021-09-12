Imports System.Math
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If COMBOCINE.SelectedIndex = -1 Then
            MsgBox("SELECCIONE ALGUN CINE")
            COMBOCINE.Focus() : Exit Sub
        End If

        If COMBOFUNCION.SelectedIndex = -1 Then
            MsgBox("SELECCIONE ALGUNA FUNCION")
            COMBOFUNCION.Focus() : Exit Sub
        End If

        If TENTRADAS.Text = "" Then
            MsgBox("INGRESE NUMERO DE ENTRADAS")
            TENTRADAS.Focus() : Exit Sub
        End If

        If (dato < 9) Then

            ENTRADAS(dato) = Str(TENTRADAS.Text)
            DFUNCION(dato) = COMBOFUNCION.SelectedItem
            DCINE(dato) = COMBOCINE.SelectedItem
            SUBTOTAL(dato) = Str(CALCULOSUBTOTAL(DFUNCION(dato), DCINE(dato)))
            DESC1(dato) = Str(CALCULODESCUENTO1(DFUNCION(dato), DCINE(dato)))
            DESC2(dato) = Str(CALCULODESCUENTO2(CSubtotal))
            TOTAL(dato) = Str(CALCULOTOTAL(CSubtotal, Descuento1, Descuento2))

            resultados()
            dato = dato + 1


        Else dato = 10
            MsgBox("VECTORES LLENOS")
        End If


    End Sub

    Private Sub TENTRADAS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TENTRADAS.KeyPress
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


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        INGRESARDATONUEVO()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ELIMINARLISTAS()
    End Sub
End Class
