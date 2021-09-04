Imports System.Math

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CMA_CheckedChanged(sender As Object, e As EventArgs) Handles CMA.CheckedChanged
        If (CMA.Checked) Then
            TMA.Visible = True
            TMA.Focus()
        Else
            TMA.Clear()
            TMA.Visible = False
        End If
    End Sub

    Private Sub CFI_CheckedChanged(sender As Object, e As EventArgs) Handles CFI.CheckedChanged
        If (CFI.Checked) Then
            TFI.Visible = True
            TFI.Focus()
        Else
            TFI.Clear()
            TFI.Visible = False
        End If
    End Sub

    Private Sub CSO_CheckedChanged(sender As Object, e As EventArgs) Handles CSO.CheckedChanged
        If (CSO.Checked) Then
            TSO.Visible = True
            TSO.Focus()
        Else
            TSO.Clear()
            TSO.Visible = False
        End If
    End Sub

    Private Sub CCI_CheckedChanged(sender As Object, e As EventArgs) Handles CCI.CheckedChanged
        If (CCI.Checked) Then
            TCI.Visible = True
            TCI.Focus()
        Else
            TCI.Clear()
            TCI.Visible = False
        End If
    End Sub

    Private Sub CED_CheckedChanged(sender As Object, e As EventArgs) Handles CED.CheckedChanged
        If (CED.Checked) Then
            TED.Visible = True
            TED.Focus()
        Else
            TED.Clear()
            TED.Visible = False
        End If
    End Sub

    Private Sub CMU_CheckedChanged(sender As Object, e As EventArgs) Handles CMU.CheckedChanged
        If (CMU.Checked) Then
            TMU.Visible = True
            TMU.Focus()
        Else
            TMU.Clear()
            TMU.Visible = False
        End If
    End Sub

    Private Sub CTE_CheckedChanged(sender As Object, e As EventArgs) Handles CTE.CheckedChanged
        If (CTE.Checked) Then
            TTE.Visible = True
            TTE.Focus()
        Else
            TTE.Clear()
            TTE.Visible = False
        End If
    End Sub

    Private Sub CQUI_CheckedChanged(sender As Object, e As EventArgs) Handles CQUI.CheckedChanged
        If (CQUI.Checked) Then
            TQUI.Visible = True
            TQUI.Focus()
        Else
            TQUI.Clear()
            TQUI.Visible = False
        End If
    End Sub

    Private Sub CLEN_CheckedChanged(sender As Object, e As EventArgs) Handles CLEN.CheckedChanged
        If (CLEN.Checked) Then
            TLE.Visible = True
            TLE.Focus()
        Else
            TLE.Clear()
            TLE.Visible = False
        End If
    End Sub

    Private Sub CIN_CheckedChanged(sender As Object, e As EventArgs) Handles CIN.CheckedChanged
        If (CIN.Checked) Then
            TIN.Visible = True
            TIN.Focus()
        Else
            TIN.Clear()
            TIN.Visible = False
        End If
    End Sub

    Private Sub TMA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TMA.KeyPress
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

    Private Sub TFI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TFI.KeyPress
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

    Private Sub TSO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TSO.KeyPress
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

    Private Sub TCI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TCI.KeyPress
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

    Private Sub TED_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TED.KeyPress
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

    Private Sub TMU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TMU.KeyPress
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

    Private Sub TTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TTE.KeyPress
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

    Private Sub TQUI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TQUI.KeyPress
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

    Private Sub TLE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TLE.KeyPress
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

    Private Sub TIN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TIN.KeyPress
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

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem.Click
        LIMPIAR()
    End Sub

    Private Sub C1_CheckedChanged(sender As Object, e As EventArgs) Handles C1.CheckedChanged
        If C1.Checked = True Then
            TMA.Visible = True
            TMA.Text = "EQV"
        Else
            TMA.Clear()
            TMA.Visible = False
        End If

    End Sub

    Private Sub C2_CheckedChanged(sender As Object, e As EventArgs) Handles C2.CheckedChanged
        If C2.Checked = True Then
            TFI.Visible = True
            TFI.Text = "EQV"
        Else
            TFI.Clear()
            TFI.Visible = False
        End If

    End Sub

    Private Sub C3_CheckedChanged(sender As Object, e As EventArgs) Handles C3.CheckedChanged
        If C3.Checked = True Then
            TSO.Visible = True
            TSO.Text = "EQV"
        Else
            TSO.Clear()
            TSO.Visible = False
        End If

    End Sub

    Private Sub C4_CheckedChanged(sender As Object, e As EventArgs) Handles C4.CheckedChanged
        If C4.Checked = True Then
            TCI.Visible = True
            TCI.Text = "EQV"
        Else
            TCI.Clear()
            TCI.Visible = False
        End If

    End Sub

    Private Sub C5_CheckedChanged(sender As Object, e As EventArgs) Handles C5.CheckedChanged
        If C5.Checked = True Then
            TED.Visible = True
            TED.Text = "EQV"
        Else
            TED.Clear()
            TED.Visible = False
        End If

    End Sub

    Private Sub C6_CheckedChanged(sender As Object, e As EventArgs) Handles C6.CheckedChanged
        If C6.Checked = True Then
            TMU.Visible = True
            TMU.Text = "EQV"
        Else
            TMU.Clear()
            TMU.Visible = False
        End If

    End Sub

    Private Sub C7_CheckedChanged(sender As Object, e As EventArgs) Handles C7.CheckedChanged
        If C7.Checked = True Then
            TTE.Visible = True
            TTE.Text = "EQV"
        Else
            TTE.Clear()
            TTE.Visible = False
        End If

    End Sub

    Private Sub C8_CheckedChanged(sender As Object, e As EventArgs) Handles C8.CheckedChanged
        If C8.Checked = True Then
            TQUI.Visible = True
            TQUI.Text = "EQV"
        Else
            TQUI.Clear()
            TQUI.Visible = False
        End If

    End Sub

    Private Sub C9_CheckedChanged(sender As Object, e As EventArgs) Handles C9.CheckedChanged
        If C9.Checked = True Then
            TLE.Visible = True
            TLE.Text = "EQV"
        Else
            TLE.Clear()
            TLE.Visible = False
        End If

    End Sub

    Private Sub C10_CheckedChanged(sender As Object, e As EventArgs) Handles C10.CheckedChanged
        If C10.Checked = True Then
            TIN.Visible = True
            TIN.Text = "EQV"
        Else
            TIN.Clear()
            TIN.Visible = False
        End If

    End Sub

    Private Sub PROMEDIOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PROMEDIOToolStripMenuItem.Click
        SUMA = Val(TMA.Text) + Val(TFI.Text) + Val(TSO.Text) + Val(TCI.Text) + Val(TED.Text) + Val(TMU.Text) + Val(TTE.Text) + Val(TQUI.Text) + Val(TLE.Text) + Val(TIN.Text)
        PROMEDIO = Val(SUMA) / 10


        Select Case PROMEDIO
            Case 61 To 70
                RENDIMIENTO = "BAJO"
            Case 71 To 80
                RENDIMIENTO = "BUENO"
            Case 81 To 90
                RENDIMIENTO = "MUY BUENO"
            Case 91 To 100
                RENDIMIENTO = "EXCELENTE"
        End Select

        Form2.LPROMEDIO.Text += Str(PROMEDIO)
        Form2.LRENDIMIENTO.Text += Str(RENDIMIENTO)
        Form2.LNOMBRE.Text += TNOMBRE.Text
        Me.Hide()
        Form2.Show()

    End Sub


End Class
