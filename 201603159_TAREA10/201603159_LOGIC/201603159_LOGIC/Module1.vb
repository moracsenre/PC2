Module Module1
    Public dato As Byte = 0
    Public DPI(7) As Integer
    Public NOMBRE(7) As String
    Public VALORARTICULO(7) As Integer
    Public MESESCANCELAR(7) As Integer
    Public INTERES(7) As Integer
    Public DESCUENTO(7) As Integer
    Public MONTOTOTAL(7) As Integer

    Public I As Byte

    Function comprobar_repetido() As Boolean
        Dim encontrado As Boolean = True

        I = 0
        comprobar_repetido = True
        While (I <= 7) And (encontrado)

            If (NOMBRE(I) <> Nothing) Then

                If (DPI(I) = Val(Form1.TDPI.Text)) Then
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
        Form1.TDPI.Clear()
        Form1.TNOMBRE.Clear()
        Form1.TVALORARTICULO.Clear()
        Form1.TMESES.Clear()

        Form1.TDPI.Focus()
    End Sub

    Sub Mostrar_vector()

        Form1.DataGridView1.Rows.Clear()

        I = 0
        While (I <= 7)
            If (DPI(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(DPI(I), NOMBRE(I), String.Format("Q{0:N2}", VALORARTICULO(I)), MESESCANCELAR(I), INTERES(I), DESCUENTO(I), String.Format("Q{0:N2}", MONTOTOTAL(I)))
            Else
                Exit While
            End If
            I = I + 1
        End While
    End Sub

    Sub limpiar_vector()
        Form1.DataGridView1.Rows.Clear()
        dato = 0
        I = 0
        While (I <= 4)
            NOMBRE(I) = Nothing
            DPI(I) = Nothing
            VALORARTICULO(I) = Nothing
            INTERES(I) = Nothing
            MONTOTOTAL(I) = Nothing
            MESESCANCELAR(I) = Nothing
            DESCUENTO(I) = Nothing

            I = I + 1
        End While
    End Sub
End Module
