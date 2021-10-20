Imports System.Math

Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        pagototal = 0


        If (fila < 7) Then

            If COMBONIVEL.SelectedItem = "BASICO" Then
                BASICOINSCIPCION = 350
                BASICOMENSUAL = 250
            Else
                BASICOINSCIPCION = 0
                BASICOMENSUAL = 0
            End If

            If COMBONIVEL.SelectedItem = "DIVERSIFICADO" Then
                DIVERSIFICADOINSCRIPCION = 450
                DIVERSIFICADOMENSUAL = 350
            Else
                BASICOINSCIPCION = 0
                BASICOMENSUAL = 0
            End If

            Select Case (COMBOPAGO.SelectedIndex)
                Case 0 : RECARGO = 0
                Case 1 : RECARGO = Round((TOTALSINCARGO * 10) / 100, 2)
                Case 2 : RECARGO = 0
                Case 3 : RECARGO = 0
            End Select

            TOTALSINCARGO = Val(BASICOMENSUAL) + Val(BASICOINSCIPCION) + Val(DIVERSIFICADOMENSUAL) + Val(DIVERSIFICADOINSCRIPCION)
            TOTAL = TOTALSINCARGO + RECARGO

            ESTUDIANTE(fila, 0) = TNOMBRE.Text
            ESTUDIANTE(fila, 1) = TCARNET.Text
            ESTUDIANTE(fila, 2) = COMBONIVEL.Text
            ESTUDIANTE(fila, 3) = COMBOBASICO.Text
            ESTUDIANTE(fila, 4) = COMBODIVERSIFICADO.Text
            ESTUDIANTE(fila, 5) = COMBOPAGO.Text
            ESTUDIANTE(fila, 6) = Val(Round(RECARGO, 2))
            ESTUDIANTE(fila, 7) = Val(Round(TOTAL, 2))



            fila = fila + 1
        End If
        If (fila = 7) Then
            MsgBox("Matriz llena")
        End If
        LIMPIARENTRADAS()

    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Mostrar()
    End Sub

    Private Sub COMBONIVEL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMBONIVEL.SelectedIndexChanged

        If (COMBONIVEL.Text = "BASICO") Then
            LBASICO.Visible = True
            COMBOBASICO.Visible = True
        End If

        If (COMBONIVEL.Text = "DIVERSIFICADO") Then
            LDIVERSIFICADO.Visible = True
            COMBODIVERSIFICADO.Visible = True
        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim i As Byte

        Dim TOTPERITO As Double
        Dim TOTBACHILLER As Double
        Dim TOTELECTRO As Double
        Dim TOTDISEÑO As Double
        Dim TOTPRIMERO As Double
        Dim TOTSEGUNDO As Double
        Dim TOTTERCERO As Double
        Dim TOTALGENERAL As Double


        TOTBACHILLER = 0
        TOTPERITO = 0
        TOTELECTRO = 0
        TOTDISEÑO = 0
        TOTPRIMERO = 0
        TOTSEGUNDO = 0
        TOTTERCERO = 0
        TOTALGENERAL = 0



        For i = 0 To 7


            If (ESTUDIANTE(i, 0) <> Nothing) Then
                TOTALGENERAL = TOTALGENERAL + Val(ESTUDIANTE(i, 7))

                If (ESTUDIANTE(i, 4) = "PERITO CONTADOR") Then
                    TOTPERITO = TOTPERITO + 1
                End If
                If (ESTUDIANTE(i, 4) = "BACHILLERATO") Then
                    TOTBACHILLER = TOTBACHILLER + 1
                End If
                If (ESTUDIANTE(i, 4) = "ELECTRONICA") Then
                    TOTELECTRO = TOTELECTRO + 1
                End If
                If (ESTUDIANTE(i, 4) = "DISEÑO GRAFICO") Then
                    TOTDISEÑO = TOTDISEÑO + 1
                End If
                If (ESTUDIANTE(i, 3) = "PRIMERO") Then
                    TOTPRIMERO = TOTPRIMERO + 1
                End If
                If (ESTUDIANTE(i, 3) = "SEGUNDO") Then
                    TOTSEGUNDO = TOTSEGUNDO + 1
                End If
                If (ESTUDIANTE(i, 3) = "TERCERO") Then
                    TOTTERCERO = TOTTERCERO + 1
                End If
            Else
                Exit For
            End If
        Next i

        LPERITO.Text = Val(TOTPERITO)
        LBACH.Text = Val(TOTBACHILLER)
        LDISEÑO.Text = Val(TOTDISEÑO)
        LELEC.Text = Val(TOTELECTRO)
        LTOTALGENERAL.Text = Val(TOTALGENERAL)
        LPRIMERO.Text = Val(TOTPRIMERO)
        LSEGUNDO.Text = Val(TOTSEGUNDO)
        LTERCERO.Text = Val(TOTTERCERO)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LPRIMERO.Text = ""
        LSEGUNDO.Text = ""
        LTERCERO.Text = ""
        LTOTALGENERAL.Text = ""
        LPERITO.Text = ""
        LDISEÑO.Text = ""
        LELEC.Text = ""
        LBACH.Text = ""


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LIMPIARENTRADAS()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        limpiar_matriz()
        TNOMBRE.Focus()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje de Salida") = vbYes) Then
            End
        Else
            LIMPIARENTRADAS()
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

    Private Sub TCARNET_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TCARNET.KeyPress
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
End Class
