Imports System.Math
Module Module1
    Public dato As Byte = 0
    Public CEntradas As Double = 0
    Public CSubtotal As Double = 0
    Public Descuento1 As Double = 0
    Public Descuento2 As Double = 0
    Public CTotal As Double = 0

    Public ENTRADAS(9) As String
    Public DCINE(9) As String
    Public DFUNCION(9) As String
    Public DESC1(9) As String
    Public DESC2(9) As String
    Public SUBTOTAL(9) As String
    Public TOTAL(9) As String


    Sub resultados()

        Form1.LISTCINE.Items.Add(Form1.COMBOCINE.Text)
        Form1.LISTFUNCION.Items.Add(Form1.COMBOFUNCION.Text)
        Form1.LISTDESC1.Items.Add(String.Format("Q{0:N2}", Double.Parse(DESC1(dato))))
        Form1.LISTDESC2.Items.Add(String.Format("Q{0:N2}", Double.Parse(DESC2(dato))))
        Form1.LISTSUB.Items.Add(String.Format("Q{0:N2}", Double.Parse(SUBTOTAL(dato))))
        Form1.LISTTOTAL.Items.Add(String.Format("Q{0:N2}", Double.Parse(TOTAL(dato))))

    End Sub

    Function CALCULOSUBTOTAL(FUNCION As String, CINE As String) As Double
        CEntradas = Val(Form1.TENTRADAS.Text)
        Select Case CINE
            Case "A"
                Select Case FUNCION
                    Case "1"
                        CSubtotal = 30
                    Case "2"
                        CSubtotal = 35
                    Case "3"
                        CSubtotal = 40
                    Case "4"
                        CSubtotal = 40
                End Select
            Case "B"
                Select Case FUNCION
                    Case "1"
                        CSubtotal = 24
                    Case "2"
                        CSubtotal = 34
                    Case "3"
                        CSubtotal = 44
                    Case "4"
                        CSubtotal = 44
                End Select
            Case "C"
                Select Case FUNCION
                    Case "1"
                        CSubtotal = 35
                    Case "2"
                        CSubtotal = 40
                    Case "3"
                        CSubtotal = 50
                    Case "4"
                        CSubtotal = 50
                End Select
        End Select
        CSubtotal = Round(CSubtotal * CEntradas, 2)
        Return CSubtotal

    End Function

    Function CALCULODESCUENTO1(FUNCION As String, CINE As String) As Double

        If (FUNCION = "3" Or FUNCION = "4") And (CINE = "C" Or CINE = "B") Then
            Descuento1 = 5.5 / 100
        ElseIf (FUNCION = "1") And (CINE = "C" Or CINE = "B") Then
            Descuento1 = 3 / 100
        ElseIf (FUNCION = "2") And (CINE = "A") Then
            Descuento1 = 1.5 / 100
        Else
            Descuento1 = 0
        End If
        Descuento1 = Round(Descuento1 * CSubtotal, 2)
        Return Descuento1
    End Function

    Function CALCULODESCUENTO2(CSubtotal As Double) As Double

        Select Case CSubtotal
            Case 100 To 300
                Descuento2 = 2 / 100
            Case 300.01 To 500
                Descuento2 = 4 / 100
            Case 500.01 To 1000
                Descuento2 = 6 / 100
            Case Else
                Descuento2 = 0
        End Select
        Descuento2 = Round(Descuento2 * CSubtotal, 2)
        Return Descuento2
    End Function

    Function CALCULOTOTAL(CSubtotal As Double, D1 As Double, D2 As Double) As Double
        CTotal = Round(CSubtotal - D1 - D2, 2)
        Return CTotal
    End Function

    Sub INGRESARDATONUEVO()
        Form1.COMBOCINE.Text = ""
        Form1.COMBOFUNCION.Text = ""
        Form1.TENTRADAS.Clear()
    End Sub

    Sub ELIMINARLISTAS()
        Form1.LISTCINE.Items.Clear()
        Form1.LISTDESC1.Items.Clear()
        Form1.LISTDESC2.Items.Clear()
        Form1.LISTFUNCION.Items.Clear()
        Form1.LISTSUB.Items.Clear()
        Form1.LISTTOTAL.Items.Clear()

        dato = 0
    End Sub


End Module
