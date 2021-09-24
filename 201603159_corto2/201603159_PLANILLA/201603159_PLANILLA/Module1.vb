Imports System.Math

Module Module1
    Public DATO As Byte = 0


    Public DESC1(6) As Double
    Public DESC2(6) As Double
    Public PRECIO(6) As Double


    Public NOMBRE(6) As String
    Public IGGS(6) As Double
    Public ISR(6) As Double
    Public OPCI(6) As Double
    Public SIN(6) As Double
    Public PARCIAL(6) As Double
    Public DESCUENTO(6) As Double
    Public TOTAL(6) As Double

    Sub resultados()

        Form1.LSELECCION.Items.Add(Form1.ComboBox1.Text)
        Form1.LVDESCUENTO.Items.Add(String.Format("Q{0:N2}", Double.Parse(SIN(DATO))))
        Form1.LDESCUENTO.Items.Add(String.Format("Q{0:N2}", Double.Parse(DESC1(DATO))))
        Form1.LTOTAL.Items.Add(String.Format("Q{0:N2}", Double.Parse(TOTAL(DATO))))

        Form1.TNOMBRE.Focus()

    End Sub

    Sub limpiar_entradas()
        Form1.TNOMBRE.Text = ""
        Form1.TSUELDOBRUTO.Text = ""
        Form1.ComboBox1.SelectedIndex = -1
    End Sub
End Module
