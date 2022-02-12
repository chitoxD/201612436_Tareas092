Imports System.Math
Public Class Principal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If CheckBox1.Checked = False And CheckBox2.Checked = False Then
            MsgBox("No selecciono alguna transaccion", vbExclamation, "Error")
            limpiar()
        End If

        If CheckBox1.Checked Then 'esta seleccionado compra o venta

            If (RadioButton1.Checked Or RadioButton2.Checked Or RadioButton3.Checked Or RadioButton4.Checked) And CheckBox1.Checked And Val(compra.Text) > 0 Then
                If RadioButton1.Checked Then
                    monto_compra = dolar * Val(compra.Text)
                    GroupBox5.Visible = True
                ElseIf RadioButton2.Checked Then
                    monto_compra = peso * Val(compra.Text)
                    GroupBox5.Visible = True
                ElseIf RadioButton3.Checked Then
                    monto_compra = euro * Val(compra.Text)
                    GroupBox5.Visible = True
                ElseIf RadioButton4.Checked Then
                    monto_compra = colon * Val(compra.Text)
                    GroupBox5.Visible = True
                Else
                    monto_compra = 0

                End If
            ElseIf (RadioButton1.Checked = False Or RadioButton2.Checked = False Or RadioButton3.Checked = False Or RadioButton4.Checked = False) And CheckBox1.Checked = True Then

                MsgBox("No selecciono la moneda de compra", vbExclamation, "Error")

            End If
        End If
        If CheckBox2.Checked Then

            If (RadioButton5.Checked Or RadioButton6.Checked Or RadioButton7.Checked Or RadioButton8.Checked) And CheckBox2.Checked And Val(venta.Text) > 0 Then

                If RadioButton5.Checked Then
                    monto_venta = dolar * Val(venta.Text)
                    GroupBox5.Visible = True
                ElseIf RadioButton6.Checked Then
                    monto_venta = peso * Val(venta.Text)
                    GroupBox5.Visible = True
                ElseIf RadioButton7.Checked Then
                    monto_venta = euro * Val(venta.Text)
                    GroupBox5.Visible = True
                ElseIf RadioButton8.Checked Then
                    monto_venta = colon * Val(venta.Text)
                    GroupBox5.Visible = True
                Else
                    monto_venta = 0

                End If
            ElseIf (RadioButton5.Checked = False Or RadioButton6.Checked = False Or RadioButton7.Checked = False Or RadioButton8.Checked = False) And CheckBox2.Checked = True Then

                MsgBox("No se selecciono una moneda de venta", vbExclamation, "Error")
            End If

        End If

        recargo_monto = recargo * monto_compra
        total_compra = monto_compra + recargo_monto
        TextBox1.Text = Str(Round(total_compra, 2))
        TextBox2.Text = Str(Round(recargo_monto, 2))

        comision_monto = comision * monto_venta
        total_venta = comision_monto + monto_venta
        TextBox3.Text = Str(Round(total_venta, 2))
        TextBox4.Text = Str(Round(comision_monto, 2))


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            compra.Enabled = True

        Else
            compra.Enabled = False
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            venta.Enabled = True
        Else
            venta.Enabled = False
        End If

    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (MsgBox("Desea salir?", vbYesNo, "Sugerencia") = vbYes) Then
            Me.Close()
        Else
            limpiar()
        End If
    End Sub
End Class