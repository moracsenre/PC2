Module VarProced


    Public ESTUDIANTE(7, 8) As String
    Public BASICOINSCIPCION As Integer
    Public BASICOMENSUAL As Integer
    Public DIVERSIFICADOINSCRIPCION As Integer
    Public DIVERSIFICADOMENSUAL As Integer
    Public BACHILLER As Integer
    Public PERITO As Integer
    Public ELECTRONICA As Integer
    Public DISEÑO As Integer
    Public NIVEL As Integer
    Public CREDITO As Integer
    Public RECARGO As Integer
    Public TOTAL As Integer
    Public TOTALSINCARGO As Integer

    Public pagototal As Double

    Public fila As Byte = 0

    Sub Mostrar()

        Dim i As Byte
        For i = 0 To 7

            If ESTUDIANTE(i, 0) <> Nothing Then
                Form1.DataGridView1.Rows.Add(ESTUDIANTE(i, 0), ESTUDIANTE(i, 1), ESTUDIANTE(i, 2), ESTUDIANTE(i, 3), ESTUDIANTE(i, 4), ESTUDIANTE(i, 5), ESTUDIANTE(i, 6), ESTUDIANTE(i, 7))
            Else
                Exit For
            End If
        Next i
    End Sub

    Sub LIMPIARENTRADAS()
        Form1.TNOMBRE.Text = ""
        Form1.TCARNET.Text = ""
        Form1.COMBONIVEL.SelectedIndex = -1
        Form1.COMBOPAGO.SelectedIndex = -1
        Form1.COMBODIVERSIFICADO.SelectedIndex = -1
        Form1.COMBOBASICO.SelectedIndex = -1

        Form1.LBASICO.Visible = False
        Form1.COMBOBASICO.Visible = False
        Form1.LDIVERSIFICADO.Visible = False
        Form1.COMBODIVERSIFICADO.Visible = False


        Form1.TNOMBRE.Focus()

    End Sub
    Sub limpiar_matriz()
        Dim i As Byte, j As Byte
        For i = 0 To 7
            For j = 0 To 7
                ESTUDIANTE(i, j) = Nothing
            Next j
        Next i

        Form1.DataGridView1.Rows.Clear()

        fila = 0


    End Sub
End Module
