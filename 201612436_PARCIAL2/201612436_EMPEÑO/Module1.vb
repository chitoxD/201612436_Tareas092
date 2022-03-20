Module Module1

    Public Const corto_tv = 250
    Public Const corto_telefono = 550
    Public Const corto_laptop = 770
    Public Const corto_refri = 1000
    Public Const largo_tv = 300
    Public Const largo_telefono = 600
    Public Const largo_laptob = 800
    Public Const largo_refri = 1200

    Public prestamo(6, 8) As String
    Public indice As Byte = 0
    Public descuento2 As Double
    Public subtotal As Double
    Public total As Double

    Public costo_tv, costo_telefono, costo_laptop, costo_refri As Double

    Public Function descuento(ByVal subtotal As Double) As Double
        Dim descuento1 As Double

        If Form1.ComboBox1.SelectedIndex = 0 And Form1.ctv.Checked And Form1.crefri.Checked Then
            descuento1 = subtotal * 0.15 + descuento1
        End If
        If Form1.ComboBox1.SelectedIndex = 1 And Form1.ctv.Checked And Form1.crefri.Checked Then
            descuento1 = subtotal * 0.05 + descuento1
        End If

        If Form1.ComboBox1.SelectedIndex = 0 And Form1.ctelefono.Checked And Form1.claptop.Checked Then
            descuento1 = subtotal * 0.1 + descuento1
        End If
        If Form1.ComboBox1.SelectedIndex = 1 And Form1.ctelefono.Checked And Form1.claptop.Checked Then
            descuento1 = subtotal * 0.05 + descuento1
        End If

        Return descuento1
    End Function


    Public Sub mostrar_resultados()
        Form1.ListBox1.Items.Add(prestamo(indice, 0))
        Form1.ListBox2.Items.Add(prestamo(indice, 1))
        Form1.ListBox3.Items.Add(prestamo(indice, 2))
        Form1.ListBox4.Items.Add(prestamo(indice, 3))
        Form1.ListBox5.Items.Add(prestamo(indice, 4))
        Form1.ListBox6.Items.Add(prestamo(indice, 5))
        Form1.ListBox7.Items.Add(prestamo(indice, 6))
    End Sub

    Public Sub limpiar_entradas()
        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""
        Form1.TextBox3.Text = ""
        Form1.ttv.Text = ""
        Form1.tlaptop.Text = ""
        Form1.ttelefono.Text = ""
        Form1.trefri.Text = ""
        Form1.ComboBox1.SelectedIndex = -1
        Form1.ctv.Checked = False
        Form1.ctelefono.Checked = False
        Form1.claptop.Checked = False
        Form1.crefri.Checked = False

    End Sub

    Public Sub limpiar_listas()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()
        Form1.ListBox8.Items.Clear()
    End Sub

    Public Sub limpiar_matriz()
        ReDim prestamo(6, 8)
        indice = 0
    End Sub
End Module
