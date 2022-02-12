Module const_y_metod

    Public Const dolar As Double = 7.69
    Public Const peso As Double = 0.38
    Public Const euro As Double = 8.79
    Public Const colon As Double = 0.012

    'variables
    Public monto_compra As Double

    Public Const recargo As Double = 0.025
    Public monto_venta As Double

    Public Const comision As Double = 0.03

    Public recargo_monto As Double
    Public comision_monto As Double

    Public total_compra As Double
    Public total_venta As Double


    Sub limpiar()
        Principal.CheckBox1.Checked = False
        Principal.CheckBox2.Checked = False

        Principal.RadioButton1.Checked = False
        Principal.RadioButton2.Checked = False
        Principal.RadioButton3.Checked = False
        Principal.RadioButton4.Checked = False
        Principal.RadioButton5.Checked = False
        Principal.RadioButton6.Checked = False
        Principal.RadioButton7.Checked = False
        Principal.RadioButton8.Checked = False

        Principal.TextBox1.Text = 0
        Principal.TextBox2.Text = 0
        Principal.TextBox3.Text = 0
        Principal.TextBox4.Text = 0

        Principal.compra.Text = ""
        Principal.venta.Text = ""

        Principal.GroupBox5.Visible = False

        monto_compra = 0
        recargo_monto = 0
        monto_venta = 0
        comision_monto = 0


    End Sub

    Sub start()
        Principal.compra.Enabled = False
        Principal.venta.Enabled = False
        Principal.GroupBox5.Visible = False

    End Sub



End Module
