Imports System.Math
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Tablet")
        ComboBox1.Items.Add("Drone")
        ComboBox1.Items.Add("Celular")
        ComboBox1.Items.Add("Television")

    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" Then
            If indice < 7 Then
                vendedor(indice) = TextBox1.Text
                salario(indice) = TextBox2.Text

                Select Case ComboBox1.SelectedIndex
                    Case 0 : comi(indice) = Round((Val(TextBox3.Text) * tablet1) * comision, 2)
                    Case 1 : comi(indice) = Round((Val(TextBox3.Text) * drone1) * comision, 2)
                    Case 2 : comi(indice) = Round((Val(TextBox3.Text) * celular1) * comision, 2)
                    Case 3 : comi(indice) = Round((Val(TextBox3.Text) * tv) * comision, 2)
                    Case Else
                        comi(indice) = 0
                End Select


                If Val(TextBox2.Text) <= 2000 Then
                    bono(indice) = Val(TextBox2.Text) * b1
                ElseIf Val(TextBox2.Text) > 2000 And Val(TextBox2.Text) <= 5000 Then
                    bono(indice) = Val(TextBox2.Text) * b2
                ElseIf Val(TextBox2.Text) > 5000 Then
                    bono(indice) = Val(TextBox2.Text) * b3
                Else
                    bono(indice) = 0
                End If
                total(indice) = Round(comi(indice) + bono(indice) + salario(indice), 2)

                mostrar_resultados()
                indice-indice + 1


            Else
                MsgBox("Elementos del vector lleno")
            End If


        Else
            MsgBox("No selecciono alguno de los elementos necesarios")
        End If
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        limpiar()

    End Sub
End Class