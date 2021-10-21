Module Declaraciones

    Public dato As Byte = 0
    Public NOMBRE(6) As String
    Public NIT(6) As Integer
    Public DIAS(6) As Integer
    Public HONORARIO(6) As Integer
    Public PAGO(6) As String
    Public HABITACION(6) As String
    Public PRECIOHABITACION(6) As Integer
    Public DESCUENTO(6) As Integer
    Public RECARGO(6) As Integer
    Public PARCIAL(6) As Integer
    Public TOTAL(6) As Integer
    Public I As Byte

    Function comprobar_repetido() As Boolean
        Dim encontrado As Boolean = True

        I = 0
        comprobar_repetido = True
        While (I <= 6) And (encontrado)

            If (NOMBRE(I) <> Nothing) Then

                If (NIT(I) = Val(Form1.TNIT.Text)) Then
                    comprobar_repetido = encontrado = False
                    Return comprobar_repetido

                Else
                    I = I + 1
                End If
            Else
                Exit While
            End If
        End While
        If (encontrado) Then
            Return comprobar_repetido
        End If

    End Function
    Sub salir()
        If (MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje de Salida") = vbYes) Then
            End
        End If
    End Sub
    Sub limpiar_entradas()
        'procedimiento que limpia los objetos de entrada
        Form1.TNIT.Clear()
        Form1.TNITCONSULTA.Clear()
        Form1.TNOMBRE.Clear()
        Form1.THONORARIO.Clear()
        Form1.TDIAS.Clear()
        Form1.TNITCONSULTA.Clear()
        Form1.COMBOHABITACION.SelectedIndex = -1
        Form1.COMBOPAGO.SelectedIndex = -1
        Form1.TNOMBRE.Focus()
    End Sub

    Sub Mostrar_Matriz()

        Form1.DataGridView1.Rows.Clear()

        I = 0
        While (I <= 6)
            If (NOMBRE(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(NOMBRE(I), NIT(I), DIAS(I), HONORARIO(I), PAGO(I), HABITACION(I), String.Format("Q{0:N2}", PARCIAL(I)), String.Format("Q{0:N2}", DESCUENTO(I)), String.Format("Q{0:N2}", RECARGO(I)), String.Format("Q{0:N2}", (TOTAL(I))))
            Else
                Exit While
            End If
            I = I + 1
        End While
    End Sub
    Sub limpiar_matriz()
        Form1.DataGridView1.Rows.Clear()
        dato = 0
        I = 0
        While (I <= 4)
            NOMBRE(I) = Nothing
            NIT(I) = Nothing
            DIAS(I) = Nothing
            HONORARIO(I) = Nothing
            PAGO(I) = Nothing
            HABITACION(I) = Nothing
            PARCIAL(I) = Nothing
            DESCUENTO(I) = Nothing
            RECARGO(I) = Nothing
            TOTAL(I) = Nothing
            I = I + 1
        End While
    End Sub
    Sub limpiar_estadisticas()

        Form1.LPRIVADA.Text = ""
        Form1.LSEMI.Text = ""
        Form1.LNOPRIVADA.Text = ""
        Form1.LGANANCIA.Text = ""
        Form1.LCHN.Text = ""

    End Sub
End Module
