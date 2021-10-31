Imports System.Math

Public Class Form1
    Private Sub GUARDARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GUARDARToolStripMenuItem.Click
        If comprobar_repetido() Then
            If (dato < 12) Then
                If TETAPA.Text = "" Then
                    MsgBox("INGRESE NO. ETAPA")
                    TETAPA.Focus() : Exit Sub
                End If

                If TKILOMETROS.Text = "" Then
                    MsgBox("INGRESE KILOMETROS RECORRIDOS")
                    TKILOMETROS.Focus() : Exit Sub
                End If

                If TTIEMPO.Text = "" Then
                    MsgBox("INGRESE TIEMPO DEL CORREDOR")
                    TTIEMPO.Focus() : Exit Sub
                End If

                If COMBOEQUIPO.SelectedIndex = -1 Then
                    MsgBox("SELECCIONE EL EQUIPO DEL CORREDOR") : Exit Sub
                End If

                If COMBONACIONALIDAD.SelectedIndex = -1 Then
                    MsgBox("SELECCIONE LA NACIONALIDAD DEL CORREDOR") : Exit Sub
                End If

                ETAPA(dato) = TETAPA.Text
                KILOMETROS(dato) = TKILOMETROS.Text
                TIEMPO(dato) = TTIEMPO.Text
                EQUIPO(dato) = COMBOEQUIPO.Text
                NACIONALIDAD(dato) = COMBONACIONALIDAD.Text



                If COMBOEQUIPO.SelectedItem = "PRO TEAM" Then
                    REDUCIR(dato) = Val(10)
                End If
                If COMBOEQUIPO.SelectedItem = "PRO CYCLING" Then
                    REDUCIR(dato) = 0
                End If
                If COMBOEQUIPO.SelectedItem = "SKY" Then
                    REDUCIR(dato) = 0
                End If
                If COMBOEQUIPO.SelectedItem = "MOVISTAR" Then
                    REDUCIR(dato) = 0
                End If
                If COMBOEQUIPO.SelectedItem = "MOVISTAR" And Val(TTIEMPO.Text <= 85) Then
                    REDUCIR(dato) = Val(15)
                End If

                If Val(TTIEMPO.Text) <= 119 Then
                    PENALIZACION(dato) = 0
                End If

                If Val(TTIEMPO.Text) >= 120 Then
                    PENALIZACION(dato) = 30
                End If

                If Val(TTIEMPO.Text) >= 140 Then
                    PENALIZACION(dato) = 40
                End If
                If Val(TTIEMPO.Text) >= 160 Then
                    PENALIZACION(dato) = 50
                End If

                TOTAL(dato) = TIEMPO(dato) + PENALIZACION(dato) - REDUCIR(dato)
                dato = dato + 1
                limpiar_entradas()
            End If
        Else
            MsgBox("NUMERO DE ETAPA YA REGISTRADO, INGRESE UN NUEVO NUMERO DE ETAPA")
            TETAPA.Focus()

        End If
        If (dato = 12) Then
            MsgBox("VECTOR LLENO")
        End If
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        Mostrar_vectores()
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click
        Dim existe As Boolean = True

        I = 0
        While (I <= 11) And (existe)

            If (ETAPA(I) = Val(TCONSULTAETAPA.Text)) Then
                existe = False
            Else
                I = I + 1
            End If
        End While
        If (existe = False) Then
            MsgBox("NO. ETAPA ENCONTRADO EXITOSAMENTE")

            TETAPA.Text = ETAPA(I)
            TKILOMETROS.Text = KILOMETROS(I)
            TTIEMPO.Text = TIEMPO(I)
            COMBOEQUIPO.Text = EQUIPO(I)
            COMBONACIONALIDAD.Text = NACIONALIDAD(I)
            TOTAL(dato) = TOTAL(I)
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(ETAPA(I), EQUIPO(I), KILOMETROS(I), TIEMPO(I), NACIONALIDAD(I), PENALIZACION(I), REDUCIR(I), TOTAL(I))

            dato = I
        Else
            MsgBox("NO. ETAPA NO ENCONTRADO")
            TCONSULTAETAPA.Focus()
        End If
    End Sub

    Private Sub ESTADISTICAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ESTADISTICAToolStripMenuItem.Click
        Dim TIEMPO1 As Integer = 0
        Dim TIEMPO2 As Integer = 0
        Dim TIEMPO3 As Integer = 0
        Dim TIEMPO4 As Integer = 0

        Dim CHAPINES As Byte = 0
        Dim RECORRIDO1 As Integer = 0
        Dim RECORRIDO2 As Integer = 0
        Dim RECORRIDO3 As Integer = 0
        Dim RECORRIDO4 As Integer = 0


        For I = 0 To 11
            If (ETAPA(I) <> Nothing) Then

                If NACIONALIDAD(I) = "GUATEMALTECO" And KILOMETROS(I) > 45 Then
                    CHAPINES = CHAPINES + 1
                End If

                If EQUIPO(I) = "SKY" Then
                    RECORRIDO1 = RECORRIDO1 + KILOMETROS(I)
                    TIEMPO1 = TIEMPO1 + TOTAL(I)
                End If

                If EQUIPO(I) = "MOVISTAR" Then
                    RECORRIDO2 = RECORRIDO2 + KILOMETROS(I)
                    TIEMPO2 = TIEMPO2 + TOTAL(I)
                End If

                If EQUIPO(I) = "PRO CYCLING" Then
                    RECORRIDO3 = RECORRIDO3 + KILOMETROS(I)
                    TIEMPO3 = TIEMPO3 + TOTAL(I)
                End If

                If EQUIPO(I) = "PRO TEAM" Then
                    RECORRIDO4 = RECORRIDO4 + KILOMETROS(I)
                    TIEMPO4 = TIEMPO4 + TOTAL(I)
                End If

            Else
                Exit For
            End If


        Next I

        LCHAPINES.Text = CHAPINES & " " & "GUATEMALTECOS"
        LSKY.Text = RECORRIDO1 & " " & "KILOMETROS"
        LMOVISTAR.Text = RECORRIDO2 & " " & "KILOMETROS"
        LPROCLY.Text = RECORRIDO3 & " " & "KILOMETROS"
        LPROTEAM.Text = RECORRIDO4 & " " & "KILOMETROS"
        LTSKY.Text = Str(Round(TIEMPO1 / 60, 2)) & " " & "HORAS"
        LTMOVISTAR.Text = Str(Round(TIEMPO2 / 60, 2)) & " " & "HORAS"
        LTPROCLY.Text = Str(Round(TIEMPO3 / 60, 2)) & " " & "HORAS"
        LTPROTEAM.Text = Str(Round(TIEMPO4 / 60, 2)) & " " & "HORAS"
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        limpiar_vectores()
    End Sub

    Private Sub LIMPIARESTADISTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARESTADISTICASToolStripMenuItem.Click
        limpiar_estadisticas()
    End Sub

    Private Sub ACTUALIZARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACTUALIZARToolStripMenuItem.Click
        ETAPA(dato) = TETAPA.Text
        KILOMETROS(dato) = TKILOMETROS.Text
        TIEMPO(dato) = TTIEMPO.Text
        EQUIPO(dato) = COMBOEQUIPO.Text
        NACIONALIDAD(dato) = COMBONACIONALIDAD.Text
        MsgBox("Registro actualizado correctamente en los vectores")
        dato = 12
    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem.Click
        ETAPA(dato) = Nothing
        EQUIPO(dato) = Nothing
        KILOMETROS(dato) = Nothing
        TIEMPO(dato) = Nothing
        NACIONALIDAD(dato) = Nothing
        PENALIZACION(dato) = Nothing
        REDUCIR(dato) = Nothing
        TOTAL(dato) = Nothing

        For I = dato To 10

            ETAPA(I) = ETAPA(I + 1)
            EQUIPO(I) = EQUIPO(I + 1)
            KILOMETROS(I) = KILOMETROS(I + 1)
            TIEMPO(I) = TIEMPO(I + 1)
            NACIONALIDAD(I) = NACIONALIDAD(I + 1)
            PENALIZACION(I) = PENALIZACION(I + 1)
            REDUCIR(I) = REDUCIR(I + 1)
            TOTAL(I) = TOTAL(I + 1)
        Next I
        MsgBox("Registro Eliminado exitosamente")
        ETAPA(I) = Nothing
        EQUIPO(I) = Nothing
        KILOMETROS(I) = Nothing
        TIEMPO(I) = Nothing
        NACIONALIDAD(I) = Nothing
        PENALIZACION(I) = Nothing
        REDUCIR(I) = Nothing
        TOTAL(I) = Nothing
        dato = 11
        limpiar_entradas()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        salir_programa()
    End Sub
End Class
