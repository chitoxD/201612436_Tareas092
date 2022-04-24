Module Module1

    Public Const biotopo = 255
    Public Const laguna = 440
    Public Const mirador = 1190
    Public index As Byte = 0

    Public identificacion(7)
    Public viaje(7)
    Public dias(7)
    Public cantidad_personas(7)
    Public total(7)

    Public Sub mostrar_data()
        Form1.DataGridView1.Rows.Clear()
        For i As Byte = 0 To index
            Form1.DataGridView1.Rows.Add(identificacion(i), viaje(i), dias(i), cantidad_personas(i), total(i))
            If Form1.DataGridView1.Rows(i).Cells(0).Value = Nothing Then
                If Not Form1.DataGridView1.Rows(i).IsNewRow Then 'Validar que no sea la fila que permite agregar registros para que no marque error
                    Form1.DataGridView1.Rows.Remove(Form1.DataGridView1.Rows(i))
                End If
            End If
        Next
    End Sub

    Public Sub limpiar_vectores()
        For i As Byte = 0 To index
            identificacion(i) = Nothing
            viaje(i) = Nothing
            dias(i) = Nothing
            cantidad_personas(i) = Nothing
            total(i) = Nothing
        Next
        index = 0
        Form1.DataGridView1.Rows.Clear()
    End Sub
    Public Sub limpiar()
        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""
        Form1.TextBox3.Text = ""
        Form1.ComboBox1.SelectedIndex = -1
        Form1.TextBox1.Focus()
    End Sub

    Public Sub buscar()

        Dim identificacion_persona As String
        identificacion_persona = InputBox("Ingrese un identificador de cliente para buscar")
        For i As Byte = 0 To index
            If identificacion(i) = identificacion_persona Then
                MsgBox("Coincidencia encontrada xD")
                Form1.DataGridView1.Rows.Clear()
                Form1.DataGridView1.Rows.Add(identificacion(i), viaje(i), dias(i), cantidad_personas(i), total(i))

                Exit For
            End If
        Next
    End Sub
    Public Sub borrar()
        Dim identificacion_persona As String
        identificacion_persona = InputBox("Ingrese un identificador de cliente para borrar")
        For i As Byte = 0 To index
            If identificacion(i) = identificacion_persona Then
                MsgBox("Borrado con exito")
                identificacion(i) = Nothing
                viaje(i) = Nothing
                dias(i) = Nothing
                cantidad_personas(i) = Nothing
                total(i) = Nothing
                index = index - 1
                Form1.DataGridView1.Rows.Remove(Form1.DataGridView1.Rows(i))
                Exit For
            End If
        Next
    End Sub
End Module
