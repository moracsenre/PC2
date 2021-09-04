Imports System.Math

Module Module1
    Public dato As Byte = 0
    Public Const R1 = 0.99
    Public Const R2 = 1.2
    Public Const R3 = 3
    Public Const I1 = 1.99
    Public Const I2 = 2.2
    Public Const I3 = 4
    Public NOMBRE(11) As String
    Public SERVICIO(11) As String
    Public TARIFA(11) As String
    Public ANTERIOR(11) As Double
    Public CONSUMO(11) As Double
    Public NIT(11) As Integer
    Public PAGOINICIAL(11) As Double
    Public PAGORESIDENCIAL(11) As Double
    Public PAGOINDUSTRIAL(11) As Double

    Public DESCUENTO(11) As Double
    Public MORA(11) As Double
    Public SINDESCUENTO(11) As Double
    Public TOTAL(11) As Double

    Sub limpiar_entradas()
        Form1.TNOMBRE.Text = ""
        Form1.TNIT.Text = ""
        Form1.TSALAN.Text = ""
        Form1.TCONSUMO.Text = ""
        Form1.COMBOSERVICIO.SelectedIndex = -1
        Form1.COMBOTARIFA.SelectedIndex = -1
    End Sub

    Sub LIMPIARLISTAS()
        Form1.LISTDESCUENTO.Items.Clear()
        Form1.LISTINICIAL.Items.Clear()
        Form1.LISTMORA.Items.Clear()
        Form1.LISTSALAN.Items.Clear()
        Form1.LISTSERVICIO.Items.Clear()
        Form1.LISTTARIFA.Items.Clear()
        Form1.LISTSINDESCUENTO.Items.Clear()
        Form1.LISTTOTAL.Items.Clear()
        dato = 0
    End Sub

    Sub resultados()

        Form1.LISTSERVICIO.Items.Add(Form1.COMBOSERVICIO.Text)
        Form1.LISTTARIFA.Items.Add(Form1.COMBOTARIFA.Text)
        Form1.LISTMORA.Items.Add(String.Format("Q{0:N2}", Double.Parse(MORA(dato))))
        Form1.LISTSALAN.Items.Add(String.Format("Q{0:N2}", Double.Parse(Form1.TSALAN.Text)))
        Form1.LISTTOTAL.Items.Add(String.Format("Q{0:N2}", Double.Parse(TOTAL(dato))))
        Form1.LISTSINDESCUENTO.Items.Add(String.Format("Q{0:N2}", Double.Parse(SINDESCUENTO(dato))))
        Form1.LISTDESCUENTO.Items.Add(String.Format("Q{0:N2}", Double.Parse(DESCUENTO(dato))))
        Form1.LISTINICIAL.Items.Add(String.Format("Q{0:N2}", Double.Parse(PAGOINICIAL(dato))))

    End Sub
End Module
