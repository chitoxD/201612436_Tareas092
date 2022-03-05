Module Module1
    'contantes de los precios de los servicios

    Public Const p_encamamiento = 350
    Public Const p_operacion = 550
    Public Const p_maternidad = 450

    Public Const s_encamamiento = 250
    Public Const s_operacion = 400
    Public Const s_maternidad = 350

    Public Const no_encamamiento = 150
    Public Const no_operacion = 300
    Public Const no_maternidad = 250

    Public persona(5)
    Public nit(5)
    Public dias(5)
    Public servicio(5)
    Public habitacion(5)
    Public tipo_pago(5)
    Public descuentos(5)
    Public totales(5)

    Public index As Byte

    Public total_servicio
    Public descuento = 0, recargo = 0
    Public subtotal
    Public total_descuento, total_recargo
    Public total
    Public cama, ope, mater As String

    Public Sub limpiar_vectores()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()
        Form1.ListBox8.Items.Clear()
        Form1.ComboBox1.SelectedIndex = -1
        Form1.ComboBox2.SelectedIndex = -1
        index = 0

    End Sub
    Public Sub limpiar_entradas()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()

        Form1.encamamiento.Checked = False
        Form1.operacion.Checked = False
        Form1.maternidad.Checked = False

        Form1.ComboBox1.SelectedIndex = -1
        Form1.ComboBox2.SelectedIndex = -1

        cama = ""
        ope = ""
        mater = ""

    End Sub
    Public Sub resultados_list()
        Form1.ListBox1.Items.Add(persona(index))
        Form1.ListBox2.Items.Add(nit(index))
        Form1.ListBox3.Items.Add(dias(index))
        Form1.ListBox4.Items.Add(servicio(index))
        Form1.ListBox5.Items.Add(habitacion(index))
        Form1.ListBox6.Items.Add(tipo_pago(index))
        Form1.ListBox7.Items.Add(descuentos(index))
        Form1.ListBox8.Items.Add(totales(index))

    End Sub

    Public Sub calcular_servicio(ByVal habitacion)
        Select Case habitacion
            Case "privada"
                If Form1.encamamiento.Checked Then
                    total_servicio = total_servicio + p_encamamiento
                End If
                If Form1.operacion.Checked Then
                    total_servicio = total_servicio + p_operacion
                End If
                If Form1.maternidad.Checked Then
                    total_servicio = total_servicio + p_maternidad
                End If
            Case "semi"
                If Form1.encamamiento.Checked Then
                    total_servicio = total_servicio + s_encamamiento
                End If
                If Form1.operacion.Checked Then
                    total_servicio = total_servicio + s_operacion
                End If
                If Form1.maternidad.Checked Then
                    total_servicio = total_servicio + s_maternidad
                End If
            Case "no"
                If Form1.encamamiento.Checked Then
                    total_servicio = total_servicio + no_encamamiento
                End If
                If Form1.operacion.Checked Then
                    total_servicio = total_servicio + no_operacion
                End If
                If Form1.maternidad.Checked Then
                    total_servicio = total_servicio + no_maternidad
                End If
        End Select
    End Sub


End Module
