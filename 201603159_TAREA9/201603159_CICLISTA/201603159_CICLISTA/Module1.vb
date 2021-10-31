Module Decla
    Public dato As Byte = 0
    Public ETAPA(12) As Integer
    Public EQUIPO(12) As String
    Public KILOMETROS(12) As Integer
    Public TIEMPO(12) As Integer
    Public REDUCIR(12) As Integer
    Public PENALIZACION(12) As Integer
    Public NACIONALIDAD(12) As String
    Public TOTAL(12) As Integer

    Public I As Byte
    Function comprobar_repetido() As Boolean
        Dim encontrado As Boolean = True

        I = 0
        comprobar_repetido = True
        While (I <= 11) And (encontrado)

            If (ETAPA(I) <> Nothing) Then

                If (ETAPA(I) = Val(Form1.TETAPA.Text)) Then
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
    Sub Mostrar_vectores()
        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 12
            If (ETAPA(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(ETAPA(I), EQUIPO(I), KILOMETROS(I), TIEMPO(I), NACIONALIDAD(I), PENALIZACION(I), REDUCIR(I), TOTAL(I))
            Else
                Exit For
            End If
        Next I

    End Sub
    Sub limpiar_entradas()
        Form1.TETAPA.Clear()
        Form1.TKILOMETROS.Clear()
        Form1.TTIEMPO.Clear()
        Form1.COMBOEQUIPO.Text = ""
        Form1.COMBONACIONALIDAD.Text = ""
        Form1.TETAPA.Focus()
    End Sub
    Sub limpiar_vectores()
        Form1.DataGridView1.Rows.Clear()
        dato = 0
        For I = 0 To 11
            ETAPA(I) = Nothing
            EQUIPO(I) = Nothing
            KILOMETROS(I) = Nothing
            TIEMPO(I) = Nothing
            NACIONALIDAD(I) = Nothing
            PENALIZACION(I) = Nothing
            REDUCIR(I) = Nothing
            TOTAL(I) = Nothing
        Next I

    End Sub
    Sub limpiar_estadisticas()
        Form1.LSKY.Text = ""
        Form1.LTSKY.Text = ""
        Form1.LMOVISTAR.Text = ""
        Form1.LTMOVISTAR.Text = ""
        Form1.LPROCLY.Text = ""
        Form1.LTPROCLY.Text = ""
        Form1.LPROTEAM.Text = ""
        Form1.LTPROTEAM.Text = ""
        Form1.LCHAPINES.Text = ""

    End Sub
    Sub salir_programa()
        If (MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje de Salida") = vbYes) Then
            End
        End If
    End Sub
End Module
