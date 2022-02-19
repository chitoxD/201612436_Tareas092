<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Tcantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rl = New System.Windows.Forms.RadioButton()
        Me.rm = New System.Windows.Forms.RadioButton()
        Me.rs = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rlona = New System.Windows.Forms.RadioButton()
        Me.rseda = New System.Windows.Forms.RadioButton()
        Me.ralgodon = New System.Windows.Forms.RadioButton()
        Me.resultados = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.resultados.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Tcantidad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Controles"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(102, 66)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 66)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(50, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Tcantidad
        '
        Me.Tcantidad.Location = New System.Drawing.Point(131, 16)
        Me.Tcantidad.Name = "Tcantidad"
        Me.Tcantidad.Size = New System.Drawing.Size(63, 23)
        Me.Tcantidad.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero de chumpas"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBox2.Controls.Add(Me.rl)
        Me.GroupBox2.Controls.Add(Me.rm)
        Me.GroupBox2.Controls.Add(Me.rs)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Talla"
        '
        'rl
        '
        Me.rl.AutoSize = True
        Me.rl.Location = New System.Drawing.Point(28, 72)
        Me.rl.Name = "rl"
        Me.rl.Size = New System.Drawing.Size(31, 19)
        Me.rl.TabIndex = 2
        Me.rl.TabStop = True
        Me.rl.Text = "L"
        Me.rl.UseVisualStyleBackColor = True
        '
        'rm
        '
        Me.rm.AutoSize = True
        Me.rm.Location = New System.Drawing.Point(28, 47)
        Me.rm.Name = "rm"
        Me.rm.Size = New System.Drawing.Size(36, 19)
        Me.rm.TabIndex = 1
        Me.rm.TabStop = True
        Me.rm.Text = "M"
        Me.rm.UseVisualStyleBackColor = True
        '
        'rs
        '
        Me.rs.AutoSize = True
        Me.rs.Location = New System.Drawing.Point(28, 22)
        Me.rs.Name = "rs"
        Me.rs.Size = New System.Drawing.Size(31, 19)
        Me.rs.TabIndex = 0
        Me.rs.TabStop = True
        Me.rs.Text = "S"
        Me.rs.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox3.Controls.Add(Me.rlona)
        Me.GroupBox3.Controls.Add(Me.rseda)
        Me.GroupBox3.Controls.Add(Me.ralgodon)
        Me.GroupBox3.Location = New System.Drawing.Point(232, 129)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Material"
        '
        'rlona
        '
        Me.rlona.AutoSize = True
        Me.rlona.Location = New System.Drawing.Point(29, 75)
        Me.rlona.Name = "rlona"
        Me.rlona.Size = New System.Drawing.Size(51, 19)
        Me.rlona.TabIndex = 5
        Me.rlona.TabStop = True
        Me.rlona.Text = "Lona"
        Me.rlona.UseVisualStyleBackColor = True
        '
        'rseda
        '
        Me.rseda.AutoSize = True
        Me.rseda.Location = New System.Drawing.Point(29, 47)
        Me.rseda.Name = "rseda"
        Me.rseda.Size = New System.Drawing.Size(50, 19)
        Me.rseda.TabIndex = 4
        Me.rseda.TabStop = True
        Me.rseda.Text = "Seda"
        Me.rseda.UseVisualStyleBackColor = True
        '
        'ralgodon
        '
        Me.ralgodon.AutoSize = True
        Me.ralgodon.Location = New System.Drawing.Point(29, 22)
        Me.ralgodon.Name = "ralgodon"
        Me.ralgodon.Size = New System.Drawing.Size(71, 19)
        Me.ralgodon.TabIndex = 3
        Me.ralgodon.TabStop = True
        Me.ralgodon.Text = "Algodon"
        Me.ralgodon.UseVisualStyleBackColor = True
        '
        'resultados
        '
        Me.resultados.BackColor = System.Drawing.Color.WhiteSmoke
        Me.resultados.Controls.Add(Me.TextBox4)
        Me.resultados.Controls.Add(Me.Label4)
        Me.resultados.Controls.Add(Me.TextBox3)
        Me.resultados.Controls.Add(Me.TextBox2)
        Me.resultados.Controls.Add(Me.Label3)
        Me.resultados.Controls.Add(Me.Label2)
        Me.resultados.Location = New System.Drawing.Point(232, 12)
        Me.resultados.Name = "resultados"
        Me.resultados.Size = New System.Drawing.Size(200, 100)
        Me.resultados.TabIndex = 3
        Me.resultados.TabStop = False
        Me.resultados.Text = "Resultados"
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(111, 67)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(63, 23)
        Me.TextBox4.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Precio venta total"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(111, 40)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(63, 23)
        Me.TextBox3.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(111, 16)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(63, 23)
        Me.TextBox2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Precio venta c/u"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Precio costo c/u"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(455, 241)
        Me.Controls.Add(Me.resultados)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Fabrica ""La Duradera xD"""
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.resultados.ResumeLayout(False)
        Me.resultados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Tcantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents resultados As GroupBox
    Friend WithEvents rl As RadioButton
    Friend WithEvents rm As RadioButton
    Friend WithEvents rs As RadioButton
    Friend WithEvents rlona As RadioButton
    Friend WithEvents rseda As RadioButton
    Friend WithEvents ralgodon As RadioButton
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
