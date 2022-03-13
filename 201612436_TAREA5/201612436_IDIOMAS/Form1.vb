Public Class Form1
    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        If indice < 8 Then
            If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And IsNumeric(TextBox2.Text) And IsNumeric(TextBox3.Text) Then
                If ComboBox1.Text <> "" Then 'seleccion de idioma
                    If CheckBox1.Checked Or CheckBox2.Checked Then 'seleccion de dias
                        If RadioButton4.Checked Or RadioButton5.Checked Then 'seleccion de pago

                            matriz_idioma(indice, 0) = TextBox1.Text 'nombre
                            matriz_idioma(indice, 1) = TextBox2.Text 'carnet
                            matriz_idioma(indice, 2) = TextBox3.Text 'horas
                            matriz_idioma(indice, 3) = ComboBox1.SelectedItem 'para el idioma



                            If CheckBox1.Checked Then 'dias
                                matriz_idioma(indice, 4) = CheckBox1.Text
                                Select Case ComboBox1.SelectedIndex 'calculo de subtotal1 por dia
                                    Case 0 : subtotal1 = ingles * Val(matriz_idioma(indice, 2))
                                    Case 1 : subtotal1 = portugues * Val(matriz_idioma(indice, 2))
                                    Case 2 : subtotal1 = frances * Val(matriz_idioma(indice, 2))
                                End Select
                            End If

                            If CheckBox2.Checked Then
                                matriz_idioma(indice, 4) = CheckBox2.Text
                                Select Case ComboBox1.SelectedIndex 'calculo de subtotal2 por dia
                                    Case 0 : subtotal2 = ingles * Val(matriz_idioma(indice, 2))
                                    Case 1 : subtotal2 = portugues * Val(matriz_idioma(indice, 2))
                                    Case 2 : subtotal2 = frances * Val(matriz_idioma(indice, 2))
                                End Select
                            End If

                            matriz_idioma(indice, 5) = DateTimePicker1.Value.Date 'fecha

                            subtotal_final = subtotal1 + subtotal2
                            matriz_idioma(indice, 7) = Str(subtotal_final)

                            If RadioButton4.Checked Then 'forma de pago efectivo
                                matriz_idioma(indice, 6) = RadioButton4.Text
                                descuento1 = descuento1 + subtotal_final * 0.02
                            ElseIf RadioButton5.Checked Then 'cheque
                                matriz_idioma(indice, 6) = RadioButton5.Text
                                descuento1 = descuento1 + subtotal_final * 0.015
                            End If

                            If CheckBox1.Checked And CheckBox2.Checked Then 'segundo descuento
                                descuento1 = descuento1 + subtotal_final * 0.05
                            End If

                            matriz_idioma(indice, 8) = Str(descuento1)

                            total_final = subtotal_final - descuento1
                            matriz_idioma(indice, 9) = Str(total_final)

                            mostrar_resultados()
                            limpiar_controles()

                            indice = indice + 1

                        Else
                            MsgBox("No selecciono metodo de pago", vbExclamation, "Error")
                        End If
                    Else
                        MsgBox("No selecciono algun dia para recibir su curso", vbExclamation, "Error")
                    End If

                Else
                    MsgBox("No selecciono ningun idioma", vbExclamation, "Error")
                End If

            Else
                MsgBox("Casilla de nombre, carnet u horas no llenadas, por favor vuelva a llenar, puede que el valor del carnet o horas no sea numerico")
                limpiar_controles()

            End If
        Else
            MsgBox("Matriz llena, vacie los datos para continuar", vbExclamation, "Matriz llena")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Ingles")
        ComboBox1.Items.Add("Portugues")
        ComboBox1.Items.Add("Frances")
    End Sub

    Private Sub LimpiarMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarMatrizToolStripMenuItem.Click
        ReDim matriz_idioma(8, 10)
        DataGridView1.Rows.Clear()

    End Sub

    Private Sub LimpiarDatosDeEntradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarDatosDeEntradaToolStripMenuItem.Click
        limpiar_controles()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("Desea salir?", vbYesNo, "Salir") = vbYes Then
            Me.Close()
        Else
            limpiar_controles()
            ReDim matriz_idioma(8, 10)
            DataGridView1.Rows.Clear()

        End If
    End Sub
End Class