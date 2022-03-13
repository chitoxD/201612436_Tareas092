Module Module1
    Public indice As Byte
    Public subtotal1 As Double
    Public subtotal2 As Double
    Public subtotal_final As Double
    Public descuento1 As Double = 0
    Public total_final As Double

    Public Const ingles = 150
    Public Const portugues = 80
    Public Const frances = 125

    Public matriz_idioma(8, 10) As String

    Public Sub limpiar_controles()
        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""
        Form1.TextBox3.Text = ""
        Form1.ComboBox1.SelectedIndex = -1
        Form1.CheckBox1.Checked = False
        Form1.CheckBox2.Checked = False

    End Sub

    Public Sub mostrar_resultados()
        Form1.DataGridView1.Rows.Add(matriz_idioma(indice, 0), matriz_idioma(indice, 1), matriz_idioma(indice, 2), matriz_idioma(indice, 3), matriz_idioma(indice, 4), matriz_idioma(indice, 5), matriz_idioma(indice, 6), matriz_idioma(indice, 7), matriz_idioma(indice, 8), matriz_idioma(indice, 9))
        subtotal1 = 0
        subtotal2 = 0
        subtotal_final = 0
        descuento1 = 0
        total_final = 0
    End Sub
End Module
