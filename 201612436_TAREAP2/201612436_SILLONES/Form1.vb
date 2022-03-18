Imports System.Math
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Sofa")
        ComboBox1.Items.Add("Individual")
        ComboBox1.Items.Add("Doble")

        ComboBox2.Items.Add("Cuero")
        ComboBox2.Items.Add("Cuerina")
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        If TextBox1.Text <> "" And ComboBox1.SelectedIndex <> -1 And ComboBox2.SelectedIndex <> -1 Then
            If indice < 8 Then
                tama(indice) = ComboBox1.SelectedItem
                tela(indice) = ComboBox2.SelectedItem

                Select Case ComboBox1.SelectedIndex'tama;o de sillon
                    Case 0
                        mano_obra(indice) = Round(Val(TextBox1.Text) * mano_sofa, 2)
                        Select Case ComboBox2.SelectedIndex'tela sofa
                            Case 0 : costo(indice) = Round((Val(TextBox1.Text) * mano_sofa) + ((tela_cuero * elaborar_sofa) * Val(TextBox1.Text)), 2)
                            Case 1 : costo(indice) = Round((Val(TextBox1.Text) * mano_sofa) + ((tela_cuerina * elaborar_sofa) * Val(TextBox1.Text)), 2)
                        End Select
                    Case 1
                        mano_obra(indice) = Round(Val(TextBox1.Text) * mano_individual, 2)
                        Select Case ComboBox2.SelectedIndex'tela individual
                            Case 0 : costo(indice) = Round((Val(TextBox1.Text) * mano_individual) + ((tela_cuero * elaborar_individual) * Val(TextBox1.Text)), 2)
                            Case 1 : costo(indice) = Round((Val(TextBox1.Text) * mano_individual) + ((tela_cuerina * elaborar_individual) * Val(TextBox1.Text)), 2)
                        End Select
                    Case 2
                        mano_obra(indice) = Round(Val(TextBox1.Text) * mano_doble, 2)
                        Select Case ComboBox2.SelectedIndex'tela doble
                            Case 0 : costo(indice) = Round((Val(TextBox1.Text) * mano_doble) + ((tela_cuero * elaborar_doble) * Val(TextBox1.Text)), 2)
                            Case 1 : costo(indice) = Round((Val(TextBox1.Text) * mano_doble) + ((tela_cuerina * elaborar_doble) * Val(TextBox1.Text)), 2)
                        End Select
                End Select

                venta(indice) = Round((costo(indice) * porcentaje) + costo(indice), 2)

                mostrar_resultados()
                indice = indice + 1

                limpiar_entradas()

            Else
                MsgBox("El vector se lleno", vbExclamation, "LLENO")
            End If



        Else
            MsgBox("No selecciono todos los requisitos para hacer el calculo", vbExclamation, "Error")

        End If
    End Sub

    Private Sub LimpiarGridToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarGridToolStripMenuItem.Click
        limpiar_grid()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_vectores()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("Desea Salir?", vbYesNo, "Salir") = vbYes Then
            Me.Close()
        Else
            limpiar_vectores()
            limpiar_grid()
        End If
    End Sub
End Class