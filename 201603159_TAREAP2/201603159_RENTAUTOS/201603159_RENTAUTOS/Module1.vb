Imports System.Math

Module Module1
    Public dato As Byte = 0

    Public NIT(6) As String
    Public PLACAUTO(6) As String
    Public MARCA(6) As String
    Public DESC(6) As String
    Public PRECIO(6) As String
    Public VALIDAR(6) As String
    Public CANTIDADDIAS(6) As String
    Public CANTIDADEFECTIVO(6) As String
    Public CANTIDADTARJETA(6) As String
    Public FORMADEPAGO(6) As String
    Public PARCIAL(6) As String
    Public PAGOTOTAL(6) As String
    Sub ELIMINARENTRADAS()
        Form1.TNIT.Clear()
        Form1.COMBOMARCA.Text = ""
        Form1.TPLACA.Clear()
        Form1.TDIASALQUILER.Clear()
        Form1.CEFECTIVO.Checked = False
        Form1.CTARJETA.Checked = False
        Form1.TNIT.Focus()
        Form1.LAUTO.Visible = False
        Form1.LPRECIO.Visible = False

    End Sub
    Sub ELIMINARVECTORES()
        Form1.LMARCA.Items.Clear()
        Form1.LPLACA.Items.Clear()
        Form1.LDIASALQUILER.Items.Clear()
        Form1.LPAGOPARCIAL.Items.Clear()
        Form1.LDESCUENTO.Items.Clear()
        Form1.LPAGOTOTAL.Items.Clear()
        dato = 0
    End Sub

    Sub RESULTADOS()
        Form1.LMARCA.Items.Add(Form1.COMBOMARCA.Text)
        Form1.LPLACA.Items.Add(Form1.TPLACA.Text)
        Form1.LDIASALQUILER.Items.Add(Form1.TDIASALQUILER.Text)
        Form1.LDESCUENTO.Items.Add(String.Format("Q{0:N2}", Double.Parse(DESC(dato))))
        Form1.LPAGOPARCIAL.Items.Add(String.Format("Q{0:N2}", Double.Parse(PARCIAL(dato))))
        Form1.LPAGOTOTAL.Items.Add(String.Format("Q{0:N2}", Double.Parse(PAGOTOTAL(dato))))
    End Sub
End Module