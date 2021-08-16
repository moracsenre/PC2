Imports System.Math

Module Module1
    Public MONTOTOTAL As Double
    Public SALDONUEVO As Double
    Public DESCAHORRO As Double
    Public DESCPREMIER As Double
    Public INTERES As Double
    Public INTERES2 As Double
    Public PORCENTAJE As Double
    Public NUEVODEPOSITO As Double
    Public SALDODEPOSITO As Double
    Public TOTAL As Double
    Public Const A = 1.5
    Public Const B = 2.5
    Public Const C = 7.5
    Public Const F = 10
    Sub LIMPIAR()
        Form1.TXSALDOANTERIOR.Text = ""
        Form1.CCHEBANCOS.Checked = False
        Form1.CCHEPROPIO.Checked = False
        Form1.CEFECTIVO.Checked = False
        Form1.RAHORRO.Checked = False
        Form1.RPREMIER.Checked = False
        Form1.RMONETARIO.Checked = False
        Form2.LDESCUENTO.Text = ""
        Form2.LTOTAL.Text = ""
        Form2.LPORCENTAJE.Text = ""
        Form2.LSALDOANTERIOR.Text = ""
        Form2.LSALDONUEVO.Text = ""
        Form2.LSINTERES.Text = ""
        Form1.TXSALDOANTERIOR.Focus()
    End Sub


End Module