Public Class Form1
    Private Sub CLI_CheckedChanged(sender As Object, e As EventArgs) Handles CLI.CheckedChanged
        If (CLI.Checked) Then
            TLI.Visible = True
            TLI.Focus()
        Else
            TLI.Clear()
            TLI.Visible = False
        End If
    End Sub

    Private Sub CAL_CheckedChanged(sender As Object, e As EventArgs) Handles CAL.CheckedChanged
        If (CAL.Checked) Then
            TAL.Visible = True
            TAL.Focus()
        Else
            TAL.Clear()
            TAL.Visible = False
        End If
    End Sub

    Private Sub CSE_CheckedChanged(sender As Object, e As EventArgs) Handles CSE.CheckedChanged
        If (CSE.Checked) Then
            TSE.Visible = True
            TSE.Focus()
        Else
            TSE.Clear()
            TSE.Visible = False
        End If
    End Sub

    Private Sub CHI_CheckedChanged(sender As Object, e As EventArgs) Handles CHI.CheckedChanged
        If (CHI.Checked) Then
            THI.Visible = True
            THI.Focus()
        Else
            THI.Clear()
            THI.Visible = False
        End If
    End Sub

    Private Sub TAL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TAL.KeyPress
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

    Private Sub THI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles THI.KeyPress
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

    Private Sub TLI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TLI.KeyPress
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

    Private Sub TSE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TSE.KeyPress
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
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Me.Close()
            'End
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RIM.Checked = True Then
            If CLI.Checked = True And CSE.Checked = True And CHI.Checked = True And CAL.Checked = True Then
                PRECIOMATERIAL = (MALINO + MAALGODON + MAHILO + MASEDA) * 3
            ElseIf CLI.Checked = True And CSE.Checked = True And CHI.Checked = True Then
                PRECIOMATERIAL = (MALINO + MAHILO + MASEDA) * 3
            ElseIf CLI.Checked = True And CSE.Checked = True Then
                PRECIOMATERIAL = (MALINO + MASEDA) * 3
            ElseIf CSE.Checked = True Then
                PRECIOMATERIAL = MASEDA * 3
            ElseIf CHI.Checked = True Then
                PRECIOMATERIAL = MAHILO * 3
            ElseIf CAL.Checked = True Then
                PRECIOMATERIAL = MAALGODON * 3
            ElseIf CLI.Checked = True Then
                PRECIOMATERIAL = MALINO * 3
            End If
            PRECIOCOSTO = PRECIOMATERIAL + MANOIMPERIAL
        End If

        If RMA.Checked = True Then
            If CLI.Checked = True And CSE.Checked = True And CHI.Checked = True And CAL.Checked = True Then
                PRECIOMATERIAL = (MALINO + MAALGODON + MAHILO + MASEDA) * 5
            ElseIf CLI.Checked = True And CSE.Checked = True And CHI.Checked = True Then
                PRECIOMATERIAL = (MALINO + MAHILO + MASEDA) * 5
            ElseIf CLI.Checked = True And CSE.Checked = True Then
                PRECIOMATERIAL = (MALINO + MASEDA) * 5
            ElseIf CSE.Checked = True Then
                PRECIOMATERIAL = MASEDA * 5
            ElseIf CHI.Checked = True Then
                PRECIOMATERIAL = MAHILO * 5
            ElseIf CAL.Checked = True Then
                PRECIOMATERIAL = MAALGODON * 5
            ElseIf CLI.Checked = True Then
                PRECIOMATERIAL = MALINO * 5
            End If
            PRECIOCOSTO = PRECIOMATERIAL + MANOMATRIMONIAL
        End If

        If RQUE.Checked = True Then
            If CLI.Checked = True And CSE.Checked = True And CHI.Checked = True And CAL.Checked = True Then
                PRECIOMATERIAL = (MALINO + MAALGODON + MAHILO + MASEDA) * 6
            ElseIf CLI.Checked = True And CSE.Checked = True And CHI.Checked = True Then
                PRECIOMATERIAL = (MALINO + MAHILO + MASEDA) * 6
            ElseIf CLI.Checked = True And CSE.Checked = True Then
                PRECIOMATERIAL = (MALINO + MASEDA) * 6
            ElseIf CSE.Checked = True Then
                PRECIOMATERIAL = MASEDA * 6
            ElseIf CHI.Checked = True Then
                PRECIOMATERIAL = MAHILO * 6
            ElseIf CAL.Checked = True Then
                PRECIOMATERIAL = MAALGODON * 6
            ElseIf CLI.Checked = True Then
                PRECIOMATERIAL = MALINO * 6
            End If
            PRECIOCOSTO = PRECIOMATERIAL + MANOQUEEN
        End If

        If RKI.Checked = True Then
            If CLI.Checked = True And CSE.Checked = True And CHI.Checked = True And CAL.Checked = True Then
                PRECIOMATERIAL = (MALINO + MAALGODON + MAHILO + MASEDA) * 7
            ElseIf CLI.Checked = True And CSE.Checked = True And CHI.Checked = True Then
                PRECIOMATERIAL = (MALINO + MAHILO + MASEDA) * 7
            ElseIf CLI.Checked = True And CSE.Checked = True Then
                PRECIOMATERIAL = (MALINO + MASEDA) * 7
            ElseIf CSE.Checked = True Then
                PRECIOMATERIAL = MASEDA * 7
            ElseIf CHI.Checked = True Then
                PRECIOMATERIAL = MAHILO * 7
            ElseIf CAL.Checked = True Then
                PRECIOMATERIAL = MAALGODON * 7
            ElseIf CLI.Checked = True Then
                PRECIOMATERIAL = MALINO * 7
            End If
            PRECIOCOSTO = PRECIOMATERIAL + MANOKING
        End If

        If RIM.Checked = True Then
            If CLI.Checked = True And TLI.Text = "3" Then
            Else
                MsgBox("SE NECESITAN 3 YARDAS PARA UN CUBRECAMA TAMAÑO IMPERIAL")
                TLI.Text = "3"
            End If
            If CAL.Checked = True And TAL.Text = "3" Then
            Else
                MsgBox("SE NECESITAN 3 YARDAS PARA UN CUBRECAMA TAMAÑO IMPERIAL")
                TAL.Text = "3"
            End If
            If CSE.Checked = True And TSE.Text = "3" Then
            Else
                MsgBox("SE NECESITAN 3 YARDAS PARA UN CUBRECAMA TAMAÑO IMPERIAL")
                TSE.Text = "3"
            End If
            If CHI.Checked = True And THI.Text = "3" Then
            Else
                MsgBox("SE NECESITAN 3 YARDAS PARA UN CUBRECAMA TAMAÑO IMPERIAL")
                THI.Text = "3"
            End If
            LPM.Text += Str(PRECIOMATERIAL)
            LPC.Text += Str(PRECIOCOSTO)
        End If

        If RMA.Checked = True Then
            If CLI.Checked = True And TLI.Text = "5" Then
            Else
                MsgBox("SE NECESITAN 5 YARDAS PARA UN CUBRECAMA TAMAÑO MATRIMONIAL")
                TLI.Text = "5"
            End If
            If CAL.Checked = True And TAL.Text = "5" Then
            Else
                MsgBox("SE NECESITAN 5 YARDAS PARA UN CUBRECAMA TAMAÑO MATRIMONIAL")
                TAL.Text = "5"
            End If
            If CSE.Checked = True And TSE.Text = "5" Then
            Else
                MsgBox("SE NECESITAN 5 YARDAS PARA UN CUBRECAMA TAMAÑO MATRIMONIAL")
                TSE.Text = "5"
            End If
            If CHI.Checked = True And THI.Text = "5" Then
            Else
                MsgBox("SE NECESITAN 5 YARDAS PARA UN CUBRECAMA TAMAÑO MATRIMONIAL")
                THI.Text = "5"
            End If
            LPM.Text += Str(PRECIOMATERIAL)
            LPC.Text += Str(PRECIOCOSTO)
        End If

         If RQUE.Checked = True Then
            If CLI.Checked = True And TLI.Text = "6" Then
            Else
              MsgBox("SE NECESITAN 6 YARDAS PARA UN CUBRECAMA TAMAÑO QUEEN")
                TLI.Text = "6"
            End If
            If CAL.Checked = True And TAL.Text = "6" Then
            Else
                MsgBox("SE NECESITAN 6 YARDAS PARA UN CUBRECAMA TAMAÑO QUEEN")
                TAL.Text = "6"
            End If
            If CSE.Checked = True And TSE.Text = "6" Then
            Else
                MsgBox("SE NECESITAN 6 YARDAS PARA UN CUBRECAMA TAMAÑO QUEEN")
                TSE.Text = "6"
            End If
            If CHI.Checked = True And THI.Text = "6" Then
            Else
                MsgBox("SE NECESITAN 6 YARDAS PARA UN CUBRECAMA TAMAÑO QUEEN")
                THI.Text = "6"
            End If
            LPM.Text += Str(PRECIOMATERIAL)
            LPC.Text += Str(PRECIOCOSTO)
        End If

        If RKI.Checked = True Then
            If CLI.Checked = True And TLI.Text = "7" Then
            Else
                MsgBox("SE NECESITAN 7 YARDAS PARA UN CUBRECAMA TAMAÑO KING")
                TLI.Text = "7"
            End If
            If CAL.Checked = True And TAL.Text = "7" Then
            Else
                MsgBox("SE NECESITAN 7 YARDAS PARA UN CUBRECAMA TAMAÑO KING")
                TAL.Text = "7"
            End If
            If CSE.Checked = True And TSE.Text = "7" Then
            Else
                MsgBox("SE NECESITAN 7 YARDAS PARA UN CUBRECAMA TAMAÑO KING")
                TSE.Text = "7"
            End If
            If CHI.Checked = True And THI.Text = "7" Then
            Else
                MsgBox("SE NECESITAN 7 YARDAS PARA UN CUBRECAMA TAMAÑO KING")
                THI.Text = "7"
            End If
            LPM.Text += Str(PRECIOMATERIAL)
            LPC.Text += Str(PRECIOCOSTO)
        End If

        PV.Text += Str(((PRECIOCOSTO) * (65) / 100) + PRECIOCOSTO)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CLI.Checked = False
        CAL.Checked = False
        CSE.Checked = False
        CHI.Checked = False
        RIM.Checked = False
        RMA.Checked = False
        RQUE.Checked = False
        RKI.Checked = False
        TLI.Text = ""
        TAL.Text = ""
        TSE.Text = ""
        THI.Text = ""
        LPC.Text = ""
        LPM.Text = ""
        PV.Text = ""
    End Sub
End Class
