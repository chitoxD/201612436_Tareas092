Imports System.Math
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Documentos")
        ComboBox1.Items.Add("Ropa")
        ComboBox1.Items.Add("Art perecederos")
        ComboBox1.Items.Add("Art de plastico")
        ComboBox1.Items.Add("Lociones")
        ComboBox2.Items.Add("Camion")
        ComboBox2.Items.Add("Motocicleta")
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem.Click
        If i < 11 Then
            If tnombre.Text <> "" And ComboBox1.Text <> "" And tvalor.Text <> "" And tpeso.Text <> "" Then

                nombre(i) = tnombre.Text
                paquete(i) = ComboBox1.SelectedItem
                valor_p(i) = tvalor.Text

                Select Case ComboBox1.SelectedIndex
                    Case 0 : pago_parcial(i) = pago_parcial_func(ComboBox1.SelectedItem, tvalor.Text, i)
                    Case 1 : pago_parcial(i) = pago_parcial_func(ComboBox1.SelectedItem, tvalor.Text, i)
                    Case 2 : pago_parcial(i) = pago_parcial_func(ComboBox1.SelectedItem, tvalor.Text, i)
                    Case 3 : pago_parcial(i) = pago_parcial_func(ComboBox1.SelectedItem, tvalor.Text, i)
                    Case 4 : pago_parcial(i) = pago_parcial_func(ComboBox1.SelectedItem, tvalor.Text, i)

                End Select

                Select Case ComboBox2.SelectedIndex
                    Case 0 : pago_total(i) = pago_parcial(i) + envio_camion
                    Case 1 : pago_total(i) = pago_parcial(i) + envio_moto
                End Select
                mostrar_resultados()
                limpiar_entradas()

                i = i + 1

            Else
                MsgBox("Olvido colocar algun dato de entrada, por favor revise y vuelva a intentar")
            End If
        Else
            'espacio para colocar todos los datos de estadisticas
            MsgBox("Vectores llenos")
        End If
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_vectores()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("Desea Salir?", vbYesNo, "Salida") = vbYes Then
            Me.Close()
        Else
            limpiar_entradas()
            limpiar_vectores()
        End If
    End Sub
End Class