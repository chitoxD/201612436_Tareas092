Imports System.Math
Public Class Form1

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        If index <= 5 Then
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
                MsgBox("No ingreso un dato del paciente", vbExclamation, "Error")
            Else
                If encamamiento.Checked Or operacion.Checked Or maternidad.Checked Then
                    If ComboBox1.Text <> "" And ComboBox2.Text <> "" Then
                        Select Case ComboBox1.SelectedIndex
                            Case 0 : calcular_servicio("privada")
                            Case 1 : calcular_servicio("semi")
                            Case 2 : calcular_servicio("no")
                        End Select 'ya tengo total del servicio

                        Select Case ComboBox2.SelectedIndex
                            Case 0 : descuento = 0.15
                            Case 1 : descuento = 0.15
                            Case 2 : descuento = 0.08
                            Case 3 : recargo = 0.05
                        End Select 'ya tengo el recargo o descuento

                        persona(index) = TextBox1.Text
                        nit(index) = TextBox2.Text
                        dias(index) = TextBox3.Text
                        If encamamiento.Checked Then
                            cama = encamamiento.Text + ","
                        End If
                        If operacion.Checked Then
                            ope = operacion.Text + ","
                        End If
                        If maternidad.Checked Then
                            mater = maternidad.Text
                        End If
                        servicio(index) = cama + ope + mater
                        habitacion(index) = ComboBox1.SelectedItem
                        tipo_pago(index) = ComboBox2.SelectedItem

                        subtotal = Round(Val(TextBox3.Text) * total_servicio, 2)
                        total_descuento = Round(subtotal * descuento, 2)
                        total_recargo = Round(subtotal * recargo, 2)
                        If total_descuento > 0 Then
                            descuentos(index) = total_descuento
                        ElseIf total_recargo > 0 Then
                            descuentos(index) = total_recargo
                        End If

                        total = Round(subtotal - total_descuento + total_recargo, 2)

                        'MsgBox(Str(subtotal) + "," + Str(total_descuento) + "," + Str(total_recargo) + "," + Str(total))

                        totales(index) = total
                        resultados_list()

                        index = index + 1
                        limpiar_entradas()

                    Else
                        MsgBox("Seleccione un tipo de habitacion o pago por favor y vuelta a intentar", vbExclamation, "Error")
                    End If

                Else
                    MsgBox("Seleccione un tipo de servicio por favor y vuelva a intentar", vbExclamation, "Error")
                End If

            End If
        Else
            MsgBox("Pacientes llenos", vbExclamation, "FULL")
        End If
    End Sub


    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        If MsgBox("Desea salir?", vbYesNo, "Salida") = vbYes Then
            Me.Close()
        Else
            limpiar_vectores()
            limpiar_entradas()
        End If
    End Sub

    Private Sub LimpiarEntradasDeDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasDeDatosToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub LimpiarVectoreslistboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoreslistboxToolStripMenuItem.Click
        limpiar_vectores()
    End Sub
End Class