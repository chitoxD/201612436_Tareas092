Imports System.Math
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("CORTO")
        ComboBox1.Items.Add("LARGO")
        ttv.Enabled = False
        ttelefono.Enabled = False
        tlaptop.Enabled = False
        trefri.Enabled = False
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem.Click
        If indice < 7 Then
            If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" Then 'si todos los datos estan llenos
                If ComboBox1.SelectedIndex <> -1 And IsNumeric(Val(TextBox2.Text)) Then 'elemento en combobox
                    If ctv.Checked Or ctelefono.Checked Or claptop.Checked Or crefri.Checked Then 'algun elemento de algun check chequeado xP

                        costo_tv = Val(ttv.Text)
                        costo_telefono = Val(ttelefono.Text)
                        costo_laptop = Val(tlaptop.Text)
                        costo_refri = Val(trefri.Text)

                        'MsgBox(costo_tv + costo_telefono + costo_laptop + costo_refri)

                        prestamo(indice, 0) = TextBox1.Text
                        prestamo(indice, 1) = TextBox2.Text
                        prestamo(indice, 2) = TextBox3.Text

                        'prestamo(indice, 3) = ctv.Text + "," + ctelefono.Text + "," + claptop.Text + "," + crefri.Text

                        If ctv.Checked Then
                            prestamo(indice, 3) = prestamo(indice, 3) + ctv.Text + ","
                        End If
                        If ctelefono.Checked Then
                            prestamo(indice, 3) = prestamo(indice, 3) + ctelefono.Text + ","
                        End If
                        If claptop.Checked Then
                            prestamo(indice, 3) = prestamo(indice, 3) + claptop.Text + ","
                        End If
                        If crefri.Checked Then
                            prestamo(indice, 3) = prestamo(indice, 3) + crefri.Text
                        End If

                        Select Case ComboBox1.SelectedIndex 'el valor costo del prestamo
                            Case 0 'corto plazo
                                If ctv.Checked Then
                                    costo_tv = costo_tv + corto_tv
                                End If
                                If ctelefono.Checked Then
                                    costo_telefono = costo_telefono + corto_telefono
                                End If
                                If claptop.Checked Then
                                    costo_laptop = costo_laptop + corto_laptop
                                End If
                                If crefri.Checked Then
                                    costo_refri = costo_refri + corto_refri
                                End If
                            Case 1 'largo plazo
                                If ctv.Checked Then
                                    costo_tv = costo_tv + largo_tv
                                End If
                                If ctelefono.Checked Then
                                    costo_telefono = costo_telefono + largo_telefono
                                End If
                                If claptop.Checked Then
                                    costo_laptop = costo_laptop + largo_laptob
                                End If
                                If crefri.Checked Then
                                    costo_refri = costo_refri + largo_refri
                                End If
                        End Select

                        prestamo(indice, 4) = ComboBox1.SelectedItem

                        subtotal = Round(costo_tv + costo_telefono + costo_laptop + costo_refri, 2)
                        prestamo(indice, 5) = Str(subtotal)

                        'calculo del descuento
                        descuento2 = descuento(subtotal)
                        prestamo(indice, 6) = Str(Round(descuento2, 2))

                        total = Round(subtotal - descuento2, 2)
                        prestamo(indice, 7) = Str(total)

                        mostrar_resultados()
                        indice = indice + 1

                        limpiar_entradas()


                    Else
                        MsgBox("No selecciono ningun articulo para el empeño", vbExclamation, "Falta")
                    End If

                Else
                    MsgBox("No selecciono plazo para el empeño", vbExclamation, "Falta")
                End If

            Else
                MsgBox("No lleno algun campo de datos, por favor revise y llene el faltannte", vbExclamation, "ERROR")
            End If
        Else
            MsgBox("Matriz llena", vbExclamation, "LLENO")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ctv.CheckedChanged
        If ctv.Checked = True Then
            ttv.Enabled = True
        Else
            ttv.Enabled = False
        End If
    End Sub

    Private Sub ctelefono_CheckedChanged(sender As Object, e As EventArgs) Handles ctelefono.CheckedChanged
        If ctelefono.Checked = True Then
            ttelefono.Enabled = True
        Else
            ttelefono.Enabled = False
        End If
    End Sub

    Private Sub claptop_CheckedChanged(sender As Object, e As EventArgs) Handles claptop.CheckedChanged
        If claptop.Checked Then
            tlaptop.Enabled = True
        Else
            tlaptop.Enabled = False
        End If
    End Sub

    Private Sub crefri_CheckedChanged(sender As Object, e As EventArgs) Handles crefri.CheckedChanged
        If crefri.Checked Then
            trefri.Enabled = True
        Else
            trefri.Enabled = False
        End If
    End Sub

    Private Sub LimpiarListboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarListboxToolStripMenuItem.Click
        limpiar_listas()
    End Sub

    Private Sub LimpiarMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarMatrizToolStripMenuItem.Click
        limpiar_matriz()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("Desea Salir?", vbYesNo, "Salir") = vbYes Then
            Me.Close()
        Else
            limpiar_matriz()
            limpiar_listas()
            limpiar_entradas()
        End If
    End Sub
End Class