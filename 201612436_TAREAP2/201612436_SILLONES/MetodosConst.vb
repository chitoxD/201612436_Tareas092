Module MetodosConst

    Public Const mano_sofa = 250.99
    Public Const mano_individual = 150.99
    Public Const mano_doble = 200.99

    Public Const tela_cuero = 75
    Public Const tela_cuerina = 45.99
    Public Const elaborar_sofa = 8
    Public Const elaborar_individual = 3.5
    Public Const elaborar_doble = 6

    Public tama(7)
    Public tela(7)
    Public costo(7)
    Public venta(7)
    Public mano_obra(7)

    Public indice As Byte = 0
    Public Const porcentaje = 0.65

    Public Sub mostrar_resultados()
        Form1.DataGridView1.Rows.Add(indice + 1, tama(indice), tela(indice), costo(indice), mano_obra(indice), venta(indice))
    End Sub

    Public Sub limpiar_grid()
        Form1.DataGridView1.Rows.Clear()

    End Sub
    Public Sub limpiar_vectores()
        Form1.ComboBox1.SelectedIndex = -1
        Form1.ComboBox2.SelectedIndex = -1
        Form1.TextBox1.Text = ""
        indice = 0

    End Sub
    Public Sub limpiar_entradas()
        Form1.ComboBox1.SelectedIndex = -1
        Form1.ComboBox2.SelectedIndex = -1
        Form1.TextBox1.Text = ""
    End Sub
End Module
