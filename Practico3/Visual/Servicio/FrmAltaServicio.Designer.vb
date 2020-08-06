<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaServicio
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
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblCostoMensual = New System.Windows.Forms.Label()
        Me.LblTipo = New System.Windows.Forms.Label()
        Me.TbxNombre = New System.Windows.Forms.TextBox()
        Me.TbxCostoMensual = New System.Windows.Forms.TextBox()
        Me.BtnAlta = New System.Windows.Forms.Button()
        Me.ListTipo = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(49, 30)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre"
        '
        'LblCostoMensual
        '
        Me.LblCostoMensual.AutoSize = True
        Me.LblCostoMensual.Location = New System.Drawing.Point(49, 74)
        Me.LblCostoMensual.Name = "LblCostoMensual"
        Me.LblCostoMensual.Size = New System.Drawing.Size(77, 13)
        Me.LblCostoMensual.TabIndex = 1
        Me.LblCostoMensual.Text = "Costo Mensual"
        '
        'LblTipo
        '
        Me.LblTipo.AutoSize = True
        Me.LblTipo.Location = New System.Drawing.Point(49, 118)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(28, 13)
        Me.LblTipo.TabIndex = 2
        Me.LblTipo.Text = "Tipo"
        '
        'TbxNombre
        '
        Me.TbxNombre.Location = New System.Drawing.Point(138, 23)
        Me.TbxNombre.Name = "TbxNombre"
        Me.TbxNombre.Size = New System.Drawing.Size(100, 20)
        Me.TbxNombre.TabIndex = 3
        '
        'TbxCostoMensual
        '
        Me.TbxCostoMensual.Location = New System.Drawing.Point(138, 67)
        Me.TbxCostoMensual.Name = "TbxCostoMensual"
        Me.TbxCostoMensual.Size = New System.Drawing.Size(100, 20)
        Me.TbxCostoMensual.TabIndex = 4
        '
        'BtnAlta
        '
        Me.BtnAlta.Location = New System.Drawing.Point(105, 189)
        Me.BtnAlta.Name = "BtnAlta"
        Me.BtnAlta.Size = New System.Drawing.Size(75, 23)
        Me.BtnAlta.TabIndex = 6
        Me.BtnAlta.Text = "Dar Alta"
        Me.BtnAlta.UseVisualStyleBackColor = True
        '
        'ListTipo
        '
        Me.ListTipo.FormattingEnabled = True
        Me.ListTipo.Items.AddRange(New Object() {"-", "Limpieza", "Mantenimiento", "Electricidad", "Telecomunicacion", "Informatica"})
        Me.ListTipo.Location = New System.Drawing.Point(138, 118)
        Me.ListTipo.Name = "ListTipo"
        Me.ListTipo.Size = New System.Drawing.Size(120, 30)
        Me.ListTipo.TabIndex = 7
        '
        'FrmAltaServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 255)
        Me.Controls.Add(Me.ListTipo)
        Me.Controls.Add(Me.BtnAlta)
        Me.Controls.Add(Me.TbxCostoMensual)
        Me.Controls.Add(Me.TbxNombre)
        Me.Controls.Add(Me.LblTipo)
        Me.Controls.Add(Me.LblCostoMensual)
        Me.Controls.Add(Me.LblNombre)
        Me.Name = "FrmAltaServicio"
        Me.Text = "Servicio - Alta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNombre As Label
    Friend WithEvents LblCostoMensual As Label
    Friend WithEvents LblTipo As Label
    Friend WithEvents TbxNombre As TextBox
    Friend WithEvents TbxCostoMensual As TextBox
    Friend WithEvents BtnAlta As Button
    Friend WithEvents ListTipo As ListBox
End Class
