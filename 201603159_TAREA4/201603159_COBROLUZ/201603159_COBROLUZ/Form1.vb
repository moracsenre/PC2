Imports System.Math

Public Class Form1
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

    Private Sub TSALAN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TSALAN.KeyPress
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
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar_entradas()
        TNOMBRE.Focus()
    End Sub

    Private Sub TCONSUMO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TCONSUMO.KeyPress
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (dato < 11) Then

            If (TNOMBRE.Text <> "") Then
                NOMBRE(dato) = TNOMBRE.Text
            Else
                MsgBox("INGRESE NOMBRE")
                TNOMBRE.Focus() : Exit Sub
            End If

            If (TNIT.Text <> "") Then
                NIT(dato) = TNIT.Text
            Else
                MsgBox("INGRESE NIT")
                TNIT.Focus() : Exit Sub
            End If

            If (TSALAN.Text <> "") Then
                ANTERIOR(dato) = TSALAN.Text
            Else
                MsgBox("INGRESE SALDO ANTERIOR")
                TSALAN.Focus() : Exit Sub
            End If


            If (TCONSUMO.Text <> "") Then
                CONSUMO(dato) = TCONSUMO.Text
            Else
                MsgBox("INGRESE CONSUMO")
                TCONSUMO.Focus() : Exit Sub
            End If

            If (COMBOSERVICIO.SelectedIndex = -1) Then
                MsgBox("SELECCIONE ALGUN SERVICIO")
                COMBOSERVICIO.Focus() : Exit Sub
            End If

            If (COMBOTARIFA.SelectedIndex = -1) Then
                MsgBox("SELECCIONE ALGUNA TARIFA")
                COMBOTARIFA.Focus() : Exit Sub
            End If

            Select Case (COMBOSERVICIO.SelectedItem = "RESIDENCIAL")
                Case Val(TCONSUMO.Text) < 100 : PAGOINICIAL(dato) = Val(TCONSUMO.Text) * Val(0.99)
                Case 101 > Val(TCONSUMO.Text) < 300 : PAGOINICIAL(dato) = Val(TCONSUMO.Text) * Val(1.2)
                Case Val(TCONSUMO.Text) > 301 : PAGOINICIAL(dato) = Val(TCONSUMO.Text) * Val(3)
                Case Else
                    Select Case (COMBOSERVICIO.SelectedItem = "INDUSTRIAL")
                        Case Val(TCONSUMO.Text) < 100 : PAGOINICIAL(dato) = Val(TCONSUMO.Text) * Val(I1)
                        Case 101 > Val(TCONSUMO.Text) < 300 : PAGOINICIAL(dato) = Val(TCONSUMO.Text) * Val(I2)
                        Case Val(TCONSUMO.Text) > 301 : PAGOINICIAL(dato) = Val(TCONSUMO.Text) * Val(I3)
                    End Select
            End Select

            Select Case (COMBOTARIFA.SelectedIndex)
                Case 0 : DESCUENTO(dato) = 20 * PAGOINICIAL(dato) / 100
                Case 1 : DESCUENTO(dato) = 10 * PAGOINICIAL(dato) / 100
            End Select

            If Val(TSALAN.Text) > 0 Then
                MORA(dato) = Val(TSALAN.Text) * (2) / 100
            End If

            SINDESCUENTO(dato) = PAGOINICIAL(dato) + MORA(dato) + Val(TSALAN.Text)
            TOTAL(dato) = PAGOINICIAL(dato) + MORA(dato) + Val(TSALAN.Text) - DESCUENTO(dato)

            resultados()
            dato = dato + 1

        Else dato = 12
            MsgBox("VECTORES LLENOS")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        LIMPIARLISTAS()
    End Sub


End Class
