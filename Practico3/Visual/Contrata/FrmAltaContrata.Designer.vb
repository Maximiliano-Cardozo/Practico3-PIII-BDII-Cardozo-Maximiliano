<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaContrata
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
        Me.LblIdPersona = New System.Windows.Forms.Label()
        Me.LblIdServicio = New System.Windows.Forms.Label()
        Me.LblFechaCreacion = New System.Windows.Forms.Label()
        Me.LblFechaContratacion = New System.Windows.Forms.Label()
        Me.LblFechaFinContrato = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.BtnAlta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblIdPersona
        '
        Me.LblIdPersona.AutoSize = True
        Me.LblIdPersona.Location = New System.Drawing.Point(44, 33)
        Me.LblIdPersona.Name = "LblIdPersona"
        Me.LblIdPersona.Size = New System.Drawing.Size(60, 13)
        Me.LblIdPersona.TabIndex = 0
        Me.LblIdPersona.Text = "ID Persona"
        '
        'LblIdServicio
        '
        Me.LblIdServicio.AutoSize = True
        Me.LblIdServicio.Location = New System.Drawing.Point(44, 75)
        Me.LblIdServicio.Name = "LblIdServicio"
        Me.LblIdServicio.Size = New System.Drawing.Size(59, 13)
        Me.LblIdServicio.TabIndex = 1
        Me.LblIdServicio.Text = "ID Servicio"
        '
        'LblFechaCreacion
        '
        Me.LblFechaCreacion.AutoSize = True
        Me.LblFechaCreacion.Location = New System.Drawing.Point(44, 117)
        Me.LblFechaCreacion.Name = "LblFechaCreacion"
        Me.LblFechaCreacion.Size = New System.Drawing.Size(82, 13)
        Me.LblFechaCreacion.TabIndex = 2
        Me.LblFechaCreacion.Text = "Fecha Creacion"
        '
        'LblFechaContratacion
        '
        Me.LblFechaContratacion.AutoSize = True
        Me.LblFechaContratacion.Location = New System.Drawing.Point(44, 159)
        Me.LblFechaContratacion.Name = "LblFechaContratacion"
        Me.LblFechaContratacion.Size = New System.Drawing.Size(100, 13)
        Me.LblFechaContratacion.TabIndex = 3
        Me.LblFechaContratacion.Text = "Fecha Contratacion"
        '
        'LblFechaFinContrato
        '
        Me.LblFechaFinContrato.AutoSize = True
        Me.LblFechaFinContrato.Location = New System.Drawing.Point(44, 201)
        Me.LblFechaFinContrato.Name = "LblFechaFinContrato"
        Me.LblFechaFinContrato.Size = New System.Drawing.Size(97, 13)
        Me.LblFechaFinContrato.TabIndex = 4
        Me.LblFechaFinContrato.Text = "Fecha Fin Contrato"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(165, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(165, 68)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(165, 110)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(165, 152)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 8
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(165, 194)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 9
        '
        'BtnAlta
        '
        Me.BtnAlta.Location = New System.Drawing.Point(102, 259)
        Me.BtnAlta.Name = "BtnAlta"
        Me.BtnAlta.Size = New System.Drawing.Size(119, 23)
        Me.BtnAlta.TabIndex = 10
        Me.BtnAlta.Text = "Alta"
        Me.BtnAlta.UseVisualStyleBackColor = True
        '
        'FrmAltaContrata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 332)
        Me.Controls.Add(Me.BtnAlta)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LblFechaFinContrato)
        Me.Controls.Add(Me.LblFechaContratacion)
        Me.Controls.Add(Me.LblFechaCreacion)
        Me.Controls.Add(Me.LblIdServicio)
        Me.Controls.Add(Me.LblIdPersona)
        Me.Name = "FrmAltaContrata"
        Me.Text = "Contrata - Alta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblIdPersona As Label
    Friend WithEvents LblIdServicio As Label
    Friend WithEvents LblFechaCreacion As Label
    Friend WithEvents LblFechaContratacion As Label
    Friend WithEvents LblFechaFinContrato As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents BtnAlta As Button
End Class
