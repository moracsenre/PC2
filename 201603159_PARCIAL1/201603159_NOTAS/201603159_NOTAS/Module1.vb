Imports System.Math

Module Module1
    Public SUMA As Double
    Public PROMEDIO As Double
    Public BAJO As Double
    Public BUENO As Double
    Public MUYBUENO As Double
    Public EXCELENTE As Double
    Public NOMBRE As String
    Public RENDIMIENTO As Double


    Sub LIMPIAR()
        Form1.TNOMBRE.Text = ""
        Form1.CMA.Checked = False
        Form1.CFI.Checked = False
        Form1.CSO.Checked = False
        Form1.CCI.Checked = False
        Form1.CED.Checked = False
        Form1.CMU.Checked = False
        Form1.CTE.Checked = False
        Form1.CQUI.Checked = False
        Form1.CLEN.Checked = False
        Form1.CIN.Checked = False
        Form1.C1.Checked = False
        Form1.C2.Checked = False
        Form1.C3.Checked = False
        Form1.C4.Checked = False
        Form1.C5.Checked = False
        Form1.C6.Checked = False
        Form1.C7.Checked = False
        Form1.C8.Checked = False
        Form1.C9.Checked = False
        Form1.C10.Checked = False
        Form2.LNOMBRE.Text = ""
        Form2.LPROMEDIO.Text = ""
        Form2.LRENDIMIENTO.Text = ""
        Form1.TNOMBRE.Focus()
    End Sub
End Module
