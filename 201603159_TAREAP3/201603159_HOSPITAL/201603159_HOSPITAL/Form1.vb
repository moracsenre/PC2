Imports System.Math

Public Class Form1
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

        If ((comprobar_repetido())) Then
            If (dato < 6) Then
                If TNOMBRE.Text = "" Then
                    MsgBox("INGRESE NOMBRE")
                    TNOMBRE.Focus() : Exit Sub
                End If

                If TNIT.Text = "" Then
                    MsgBox("INGRESE NUMERO DE NIT")
                    TNIT.Focus() : Exit Sub
                End If

                If TDIAS.Text = "" Then
                    MsgBox("INGRESE NUMERO DE DIAS")
                    TDIAS.Focus() : Exit Sub
                End If

                If THONORARIO.Text = "" Then
                    MsgBox("INGRESE HONORARIO DEL MEDICO")
                    THONORARIO.Focus() : Exit Sub
                End If

                If COMBOHABITACION.SelectedIndex = -1 Then
                    MsgBox("SELECCIONE UNA HABITACION") : Exit Sub
                End If

                If COMBOPAGO.SelectedIndex = -1 Then
                    MsgBox("SELECCIONE UNA MANERA DE PAGO") : Exit Sub
                End If

                NOMBRE(dato) = TNOMBRE.Text
                NIT(dato) = TNIT.Text
                DIAS(dato) = TDIAS.Text
                HONORARIO(dato) = THONORARIO.Text
                PAGO(dato) = COMBOPAGO.Text
                HABITACION(dato) = COMBOHABITACION.Text
                PAGO(dato) = COMBOPAGO.Text

                Select Case (COMBOHABITACION.SelectedIndex)
                    Case 0 : PRECIOHABITACION(dato) = Val(350)
                    Case 1 : PRECIOHABITACION(dato) = Val(250)
                    Case 2 : PRECIOHABITACION(dato) = Val(150)
                End Select

                PARCIAL(dato) = Val(PRECIOHABITACION(dato)) * Val(DIAS(dato))

                Select Case (COMBOPAGO.SelectedIndex)
                    Case 0 : DESCUENTO(dato) = Str(Round((PARCIAL(dato) * 10) / 100, 2))
                    Case 1 : DESCUENTO(dato) = Str(Round((PARCIAL(dato) * 8) / 100, 2))
                    Case 2 : DESCUENTO(dato) = Str(Round((PARCIAL(dato) * 10) / 100, 2))
                    Case 3 : DESCUENTO(dato) = 0
                    Case 4 : DESCUENTO(dato) = 0
                End Select

                Select Case (COMBOPAGO.SelectedIndex)
                    Case 0 : RECARGO(dato) = 0
                    Case 1 : RECARGO(dato) = 0
                    Case 2 : RECARGO(dato) = 0
                    Case 3 : RECARGO(dato) = Str(Round((PARCIAL(dato) * 1.5) / 100, 2))
                    Case 4 : RECARGO(dato) = 0
                End Select


                TOTAL(dato) = Round(((PARCIAL(dato) + RECARGO(dato) - DESCUENTO(dato))), 2)
                dato = dato + 1
                limpiar_entradas()
            End If
        Else
            MsgBox("NUMERO DE NIT YA REGISTRADO, INGRESE UN NUEVO NIT")
            TNIT.Focus()
        End If
        If (dato = 6) Then
            MsgBox("MATRIZ LLENO")
        End If



    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        Mostrar_Matriz()
    End Sub

    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click

        Dim existe As Boolean = True
        I = 0

        While (I <= 6) And (existe)

            If (NOMBRE(I) <> Nothing) Then
                If (Val(NIT(I)) = Val(TNITCONSULTA.Text)) Then
                    existe = False
                Else
                    I = I + 1
                End If
            Else
                Exit While
            End If
        End While
        If (existe) Then
            MsgBox("NUMERO DE NIT NO ENCONTRADO")
            TNITCONSULTA.Focus() : Exit Sub
        Else
            MsgBox("NUMERO DE NIT ENCONTRADO EXITOSAMENTE")
            TNOMBRE.Text = NOMBRE(I)
            TNIT.Text = NIT(I)
            TDIAS.Text = DIAS(I)
            THONORARIO.Text = HONORARIO(I)
            COMBOPAGO.Text = PAGO(I)
            COMBOHABITACION.Text = HABITACION(I)
            PARCIAL(dato) = PARCIAL(I)
            DESCUENTO(dato) = DESCUENTO(I)
            RECARGO(dato) = RECARGO(I)
            TOTAL(dato) = TOTAL(I)

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(NOMBRE(I), NIT(I), DIAS(I), HONORARIO(I), PAGO(I), HABITACION(I), String.Format("Q{0:N2}", PARCIAL(I)), String.Format("Q{0:N2}", DESCUENTO(I)), String.Format("Q{0:N2}", RECARGO(I)), String.Format("Q{0:N2}", TOTAL(I)))

            dato = I
        End If
    End Sub

    Private Sub ESTADISTICAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ESTADISTICAToolStripMenuItem.Click


        Dim GANANCIA As Integer = 0
        Dim HABITACION1 As Byte = 0
        Dim HABITACION2 As Byte = 0
        Dim HABITACION3 As Byte = 0
        Dim ACH As Byte = 0


        I = 0
        While (I <= 6)
            If (NOMBRE(I) <> Nothing) Then

                GANANCIA = GANANCIA + Val(TOTAL(I))

                If (HABITACION(I) = "PRIVADA") Then
                    HABITACION1 = HABITACION1 + 1
                End If

                If (HABITACION(I) = "SEMIPRIVADA") Then
                    HABITACION2 = HABITACION2 + 1
                End If

                If (HABITACION(I) = "NO PRIVADA") Then
                    HABITACION3 = HABITACION3 + 1
                End If

                If (PAGO(I) = "TRANSFERENCIA ACH") Then
                    ACH = ACH + 1
                End If


                I = I + 1
            Else
                Exit While
            End If
        End While


        LPRIVADA.Text = Str(HABITACION1)
        LSEMI.Text = Str(HABITACION2)
        LNOPRIVADA.Text = Str(HABITACION3)
        LCHN.Text = Str(ACH)

        LGANANCIA.Text = String.Format("Q{0:N2}", GANANCIA)

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

    Private Sub TNITCONSULTA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNITCONSULTA.KeyPress
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

    Private Sub TDIAS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDIAS.KeyPress
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

    Private Sub THONORARIO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles THONORARIO.KeyPress
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

    Private Sub SALIRDELPROGRAMAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRDELPROGRAMAToolStripMenuItem.Click
        salir()
    End Sub

    Private Sub LIMPIARMATRIZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARMATRIZToolStripMenuItem.Click
        limpiar_matriz()
    End Sub

    Private Sub LIMPIARESTADISTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARESTADISTICASToolStripMenuItem.Click
        limpiar_estadisticas()
    End Sub
End Class
