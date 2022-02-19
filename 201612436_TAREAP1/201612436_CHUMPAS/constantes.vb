Module constantes

    Public Const mano_s = 65.5
    Public Const mano_m = 85.99
    Public Const mano_l = 99.99

    Public Const material_algodon = 15
    Public Const material_seda = 23.99
    Public Const material_lona = 30.99

    Public Const s_yardas = 2
    Public Const m_yardas = 2.5
    Public Const l_yardas = 3

    Public costo_unidad As Double
    Public precio_venta As Double
    Public precio_total As Double

    Public Function calculo_costo_unidad(ByVal talla As String, ByVal material As String)
        Dim costo As Double
        If talla = "s" Then
            Select Case material
                Case "algodon"
                    costo = mano_s + s_yardas * material_algodon
                Case "seda"
                    costo = mano_s + s_yardas * material_seda
                Case "lona"
                    costo = mano_s + s_yardas * material_lona
                Case Else
                    costo = 0
            End Select
        ElseIf talla = "m" Then
            Select Case material
                Case "algodon"
                    costo = mano_m + m_yardas * material_algodon
                Case "seda"
                    costo = mano_m + m_yardas * material_seda
                Case "lona"
                    costo = mano_m + m_yardas * material_lona
                Case Else
                    costo = 0
            End Select
        ElseIf talla = "l" Then
            Select Case material
                Case "algodon"
                    costo = mano_l + l_yardas * material_algodon
                Case "seda"
                    costo = mano_l + l_yardas * material_seda
                Case "lona"
                    costo = mano_l + l_yardas * material_lona
                Case Else
                    costo = 0
            End Select
        End If

        Return costo

    End Function

    Public Sub limpiar()
        Form1.Tcantidad.Clear()
        Form1.Tcantidad.Focus()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.rs.Checked = False
        Form1.rm.Checked = False
        Form1.rl.Checked = False
        Form1.ralgodon.Checked = False
        Form1.rseda.Checked = False
        Form1.rlona.Checked = False
        Form1.resultados.Visible = False

    End Sub
    Public Sub starto2()
        Form1.resultados.Visible = False
    End Sub

End Module
