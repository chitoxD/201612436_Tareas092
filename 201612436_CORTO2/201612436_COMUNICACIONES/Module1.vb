Module Module1

    Public Const tablet1 = 375
    Public Const drone1 = 560
    Public Const celular1 = 1450
    Public Const tv = 3250

    Public Const comision = 0.055
    Public Const b1 = 0.03
    Public Const b2 = 0.04
    Public Const b3 = 0.05

    Public vendedor(6)
    Public salario(6)
    Public comi(6)
    Public bono(6)
    Public total(6)
    Public indice As Byte = 0

    Public Sub mostrar_resultados()
        Form1.ListBox1.Items.Add(vendedor(indice))
        Form1.ListBox2.Items.Add(salario(indice))
        Form1.ListBox3.Items.Add(comi(indice))
        Form1.ListBox4.Items.Add(bono(indice))
        Form1.ListBox5.Items.Add(total(indice))

    End Sub

    Public Sub limpiar()
        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""
        Form1.TextBox3.Text = ""
        Form1.ComboBox1.Items.Clear()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
    End Sub

End Module
