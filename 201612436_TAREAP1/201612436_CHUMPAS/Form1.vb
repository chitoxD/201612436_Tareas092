Imports System.Math
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Tcantidad.Text <> "" Then
            If rs.Checked Or rm.Checked Or rl.Checked Then 'talla de las chumpas
                If rs.Checked Then 'talla s
                    If ralgodon.Checked Or rseda.Checked Or rlona.Checked Then 'material de la chumpa
                        If ralgodon.Checked Then
                            costo_unidad = calculo_costo_unidad("s", "algodon")
                        ElseIf rseda.Checked Then
                            costo_unidad = calculo_costo_unidad("s", "seda")
                        ElseIf rlona.Checked Then
                            costo_unidad = calculo_costo_unidad("s", "lona")
                        End If
                    Else
                        MsgBox("No selecciono el material de las chumpas")
                    End If
                ElseIf rm.Checked Then 'talla m
                    If ralgodon.Checked Or rseda.Checked Or rlona.Checked Then 'material de la chumpa
                        If ralgodon.Checked Then
                            costo_unidad = calculo_costo_unidad("m", "algodon")
                        ElseIf rseda.Checked Then
                            costo_unidad = calculo_costo_unidad("m", "seda")
                        ElseIf rlona.Checked Then
                            costo_unidad = calculo_costo_unidad("m", "lona")
                        End If
                    Else
                        MsgBox("No selecciono el material de las chumpas")
                    End If
                ElseIf rl.Checked Then 'talla l
                    If ralgodon.Checked Or rseda.Checked Or rlona.Checked Then 'material de la chumpa
                        If ralgodon.Checked Then
                            costo_unidad = calculo_costo_unidad("l", "algodon")
                        ElseIf rseda.Checked Then
                            costo_unidad = calculo_costo_unidad("l", "seda")
                        ElseIf rlona.Checked Then
                            costo_unidad = calculo_costo_unidad("l", "lona")
                        End If
                    Else
                        MsgBox("No selecciono el material de las chumpas")
                    End If
                End If
                resultados.Visible = True
                TextBox2.Text = Str(Round(costo_unidad, 2)) 'despliega el costo por unidad
                precio_venta = costo_unidad * 0.65 + costo_unidad
                TextBox3.Text = Str(Round(precio_venta, 2)) 'costo venta
                precio_total = precio_venta * Val(Tcantidad.Text)
                TextBox4.Text = Str(Round(precio_total, 2))
            Else
                MsgBox("No selecciono la talla de la chumpa a ser elaborada")
            End If
        Else
            MsgBox("No ingreso la cantidad de chumpas a elaborar")
            limpiar()
        End If
    End Sub

    Private Sub Tcantidad_Keypress(sender As Object, e As KeyPressEventArgs) Handles Tcantidad.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (MsgBox("De verdad desea salir?", vbExclamation + vbYesNo, "Salir") = vbYes) Then
            Me.Close()
        Else
            limpiar()

        End If
    End Sub

    Private Sub starto(sender As Object, e As EventArgs) Handles MyBase.Load
        starto2()
    End Sub
End Class