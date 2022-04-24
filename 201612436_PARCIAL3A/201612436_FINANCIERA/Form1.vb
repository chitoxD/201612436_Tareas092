Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Laguna Brava")
        ComboBox1.Items.Add("Mirador")
        ComboBox1.Items.Add("Biotopo del Quetzal")
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem.Click
        If index < 7 Then
            If IsNumeric(TextBox1.Text) And TextBox1.Text <> "" And ComboBox1.SelectedIndex <> -1 And TextBox2.Text <> "" And IsNumeric(TextBox2.Text) And TextBox3.Text <> "" And IsNumeric(TextBox3.Text) Then

                identificacion(index) = TextBox1.Text
                viaje(index) = ComboBox1.SelectedItem
                dias(index) = TextBox3.Text
                cantidad_personas(index) = TextBox2.Text

                Select Case ComboBox1.SelectedIndex
                    Case 0 : total(index) = biotopo * Val(dias(index)) * Val(cantidad_personas(index))
                    Case 1 : total(index) = laguna * Val(dias(index)) * Val(cantidad_personas(index))
                    Case 2 : total(index) = mirador * Val(dias(index)) * Val(cantidad_personas(index))
                    Case Else : total(index) = 0
                End Select

                index = index + 1
                limpiar()
            Else
                MsgBox("No lleno un campo requerido de informacion o algun valor que ingreso no es numerico")
            End If

        Else
            MsgBox("Vector lleno")
        End If
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        mostrar_data()
    End Sub

    Private Sub LImpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LImpiarVectoresToolStripMenuItem.Click
        limpiar_vectores()
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        buscar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        borrar()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("Desea salir?", vbYesNo, "Salir") = vbYes Then
            Me.Close()
        Else
            limpiar()
            limpiar_vectores()
        End If
    End Sub
End Class