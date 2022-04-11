Imports System.Math
Module Module1

    Public Const docu = 0.015
    Public Const ropa = 0.06
    Public Const art_per = 0.055
    Public Const art_plasti = 0.045
    Public Const locions = 0.02
    Public Const envio_camion = 50
    Public Const envio_moto = 15

    Public nombre(10) As String
    Public paquete(10) As String
    Public valor_p(10) As String
    Public pago_parcial(10) As String
    Public impuesto(10) As String
    Public pago_total(10) As String

    Public total_lociones As Integer
    Public total_art_plastico As Byte
    Public total_documentos As Integer
    Public total_ropa As Byte

    Public impuesto_paquete As Double
    Public i As Byte

    Public Function pago_parcial_func(ByVal tipo As String, ByVal valor As String, ByRef i As Byte) As Double
        Dim parcial_pago As Double

        If tipo = "Documentos" Then 'camion
            parcial_pago = Round(Val(valor) * docu + Val(valor), 2)
            impuesto(i) = Round(Val(valor) * docu, 2)
            total_documentos = total_documentos + parcial_pago
        ElseIf tipo = "Ropa" Then
            parcial_pago = Round(Val(valor) * ropa + Val(valor), 2)
            impuesto(i) = Round(Val(valor) * ropa, 2)
            total_ropa = total_ropa + 1
        ElseIf tipo = "Art perecederos" Then
            parcial_pago = Round(Val(valor) * art_per + Val(valor), 2)
            impuesto(i) = Round(Val(valor) * art_per, 2)
        ElseIf tipo = "Art de plastico" Then
            parcial_pago = Round(Val(valor) * art_plasti + Val(valor), 2)
            impuesto(i) = Round(Val(valor) * art_plasti, 2)
            total_art_plastico = total_art_plastico + 1
        ElseIf tipo = "Lociones" Then
            parcial_pago = Round(Val(valor) * locions + Val(valor), 2)
            impuesto(i) = Round(Val(valor) * locions, 2)
            total_lociones = total_lociones + parcial_pago
        End If

        Return parcial_pago
    End Function

    Public Sub mostrar_resultados()
        Form1.ListBox1.Items.Add(nombre(i))
        Form1.ListBox2.Items.Add(paquete(i))
        Form1.ListBox3.Items.Add(valor_p(i))
        Form1.ListBox4.Items.Add(pago_parcial(i))
        Form1.ListBox5.Items.Add(impuesto(i))
        Form1.ListBox6.Items.Add(pago_total(i))
    End Sub
    Public Sub limpiar_entradas()
        Form1.tnombre.Text = ""
        Form1.tpeso.Text = ""
        Form1.tvalor.Text = ""
        Form1.ComboBox1.SelectedIndex = -1
        Form1.ComboBox2.SelectedIndex = -1
    End Sub
    Public Sub limpiar_vectores()
        Array.Clear(nombre, 0, nombre.Length)
        Array.Clear(paquete, 0, paquete.Length)
        Array.Clear(valor_p, 0, valor_p.Length)
        Array.Clear(pago_parcial, 0, pago_parcial.Length)
        Array.Clear(impuesto, 0, impuesto.Length)
        Array.Clear(pago_total, 0, pago_total.Length)
    End Sub



End Module
