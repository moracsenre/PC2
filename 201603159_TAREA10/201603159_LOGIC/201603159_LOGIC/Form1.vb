Imports System.Math

Public Class Form1
    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        Mostrar_vector()
    End Sub

    Private Sub ELIMINARDATOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARDATOSToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub LIMPIARMATRIZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARMATRIZToolStripMenuItem.Click
        limpiar_vector()
    End Sub

    Private Sub SALIRDELPROGRAMAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRDELPROGRAMAToolStripMenuItem.Click
        salir()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If ((comprobar_repetido())) Then
            If (dato < 7) Then
                If TNOMBRE.Text = "" Then
                    MsgBox("INGRESE NOMBRE")
                    TNOMBRE.Focus() : Exit Sub
                End If

                If TDPI.Text = "" Then
                    MsgBox("INGRESE NUMERO DE DPI")
                    TDPI.Focus() : Exit Sub
                End If

                If TVALORARTICULO.Text = "" Then
                    MsgBox("INGRESE VALOR DE ARTICULO")
                    TVALORARTICULO.Focus() : Exit Sub
                End If

                If TMESES.Text = "" Then
                    MsgBox("INGRESE VALOR DE MESES PARA CANCELAR")
                    TMESES.Focus() : Exit Sub
                End If

                NOMBRE(dato) = TNOMBRE.Text
                DPI(dato) = TDPI.Text
                VALORARTICULO(dato) = TVALORARTICULO.Text
                MESESCANCELAR(dato) = TMESES.Text

                If TVALORARTICULO.Text >= 8000 And TMESES.Text = 12 Then
                    DESCUENTO(dato) = (VALORARTICULO(dato) * 12) / 100
                Else
                    DESCUENTO(dato) = 0
                End If

                If TMESES.Text <= 11 Then
                    INTERES(dato) = (VALORARTICULO(dato) * 3) / 100
                End If
                If TMESES.Text >= 12 Then
                    INTERES(dato) = (VALORARTICULO(dato) * 4.5) / 100
                End If

                If TMESES.Text >= 24 Then
                    INTERES(dato) = (VALORARTICULO(dato) * 5.5) / 100
                End If

                If TMESES.Text >= 37 Then
                    INTERES(dato) = (VALORARTICULO(dato) * 6.2) / 100
                End If

                MONTOTOTAL(dato) = Val(VALORARTICULO(dato)) + Val(INTERES(dato)) - Val(DESCUENTO(dato))
                dato = dato + 1
                limpiar_entradas()
            End If
        Else
            MsgBox("CLIENTE YA REGISTRADO, INGRESE UN NUEVO DPI")
            TDPI.Focus()
        End If
        If (dato = 7) Then
            MsgBox("VECTOR LLENO")
        End If
    End Sub

    Private Sub LIMPIARESTADISTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARESTADISTICASToolStripMenuItem.Click
        Dim i As Byte
        Dim j As Byte
        Dim temp1 As String
        For i = 0 To 5
            For j = i + 1 To 6
                'este if es para saber si hay dato para comparar en la siguiente casilla, de lo contrario se sale del ciclo
                If (DPI(j) <> Nothing) Then
                    If (Val(DPI(i)) < Val(DPI(j))) Then
                        temp1 = DPI(i)
                        DPI(i) = DPI(j)
                        DPI(j) = temp1
                        temp1 = NOMBRE(i)
                        NOMBRE(i) = NOMBRE(j)
                        NOMBRE(j) = temp1
                        temp1 = VALORARTICULO(i)
                        VALORARTICULO(i) = VALORARTICULO(j)
                        VALORARTICULO(j) = temp1
                        temp1 = MESESCANCELAR(i)
                        MESESCANCELAR(i) = MESESCANCELAR(j)
                        MESESCANCELAR(j) = temp1
                        temp1 = INTERES(i)
                        INTERES(i) = INTERES(j)
                        INTERES(j) = temp1
                        temp1 = DESCUENTO(i)
                        DESCUENTO(i) = DESCUENTO(j)
                        DESCUENTO(j) = temp1
                        temp1 = MONTOTOTAL(i)
                        MONTOTOTAL(i) = MONTOTOTAL(j)
                        MONTOTOTAL(j) = temp1

                    End If
                Else
                    Exit For
                End If
            Next j
        Next i

        Mostrar_vector()

    End Sub

    Private Sub TDPI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDPI.KeyPress
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

    Private Sub TMESES_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TMESES.KeyPress
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

    Private Sub TVALORARTICULO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TVALORARTICULO.KeyPress
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
End Class
