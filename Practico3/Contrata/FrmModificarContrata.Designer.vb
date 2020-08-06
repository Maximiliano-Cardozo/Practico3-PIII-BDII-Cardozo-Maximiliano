<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarContrata
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
        Me.TbxIdPersona = New System.Windows.Forms.TextBox()
        Me.TbxIdServicio = New System.Windows.Forms.TextBox()
        Me.TbxFechaCreacion = New System.Windows.Forms.TextBox()
        Me.TbxFechaContratacion = New System.Windows.Forms.TextBox()
        Me.TbxFechaFinContrato = New System.Windows.Forms.TextBox()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblIdPersona
        '
        Me.LblIdPersona.AutoSize = True
        Me.LblIdPersona.Location = New System.Drawing.Point(19, 33)
        Me.LblIdPersona.Name = "LblIdPersona"
        Me.LblIdPersona.Size = New System.Drawing.Size(60, 13)
        Me.LblIdPersona.TabIndex = 0
        Me.LblIdPersona.Text = "ID Persona"
        '
        'LblIdServicio
        '
        Me.LblIdServicio.AutoSize = True
        Me.LblIdServicio.Location = New System.Drawing.Point(19, 73)
        Me.LblIdServicio.Name = "LblIdServicio"
        Me.LblIdServicio.Size = New System.Drawing.Size(59, 13)
        Me.LblIdServicio.TabIndex = 1
        Me.LblIdServicio.Text = "ID Servicio"
        '
        'LblFechaCreacion
        '
        Me.LblFechaCreacion.AutoSize = True
        Me.LblFechaCreacion.Location = New System.Drawing.Point(19, 113)
        Me.LblFechaCreacion.Name = "LblFechaCreacion"
        Me.LblFechaCreacion.Size = New System.Drawing.Size(82, 13)
        Me.LblFechaCreacion.TabIndex = 2
        Me.LblFechaCreacion.Text = "Fecha Creacion"
        '
        'LblFechaContratacion
        '
        Me.LblFechaContratacion.AutoSize = True
        Me.LblFechaContratacion.Location = New System.Drawing.Point(19, 153)
        Me.LblFechaContratacion.Name = "LblFechaContratacion"
        Me.LblFechaContratacion.Size = New System.Drawing.Size(100, 13)
        Me.LblFechaContratacion.TabIndex = 3
        Me.LblFechaContratacion.Text = "Fecha Contratacion"
        '
        'LblFechaFinContrato
        '
        Me.LblFechaFinContrato.AutoSize = True
        Me.LblFechaFinContrato.Location = New System.Drawing.Point(19, 193)
        Me.LblFechaFinContrato.Name = "LblFechaFinContrato"
        Me.LblFechaFinContrato.Size = New System.Drawing.Size(97, 13)
        Me.LblFechaFinContrato.TabIndex = 4
        Me.LblFechaFinContrato.Text = "Fecha Fin Contrato"
        '
        'TbxIdPersona
        '
        Me.TbxIdPersona.Location = New System.Drawing.Point(136, 25)
        Me.TbxIdPersona.Name = "TbxIdPersona"
        Me.TbxIdPersona.Size = New System.Drawing.Size(100, 20)
        Me.TbxIdPersona.TabIndex = 5
        '
        'TbxIdServicio
        '
        Me.TbxIdServicio.Location = New System.Drawing.Point(136, 65)
        Me.TbxIdServicio.Name = "TbxIdServicio"
        Me.TbxIdServicio.Size = New System.Drawing.Size(100, 20)
        Me.TbxIdServicio.TabIndex = 6
        '
        'TbxFechaCreacion
        '
        Me.TbxFechaCreacion.Location = New System.Drawing.Point(136, 105)
        Me.TbxFechaCreacion.Name = "TbxFechaCreacion"
        Me.TbxFechaCreacion.Size = New System.Drawing.Size(100, 20)
        Me.TbxFechaCreacion.TabIndex = 7
        '
        'TbxFechaContratacion
        '
        Me.TbxFechaContratacion.Location = New System.Drawing.Point(136, 145)
        Me.TbxFechaContratacion.Name = "TbxFechaContratacion"
        Me.TbxFechaContratacion.Size = New System.Drawing.Size(100, 20)
        Me.TbxFechaContratacion.TabIndex = 8
        '
        'TbxFechaFinContrato
        '
        Me.TbxFechaFinContrato.Location = New System.Drawing.Point(136, 185)
        Me.TbxFechaFinContrato.Name = "TbxFechaFinContrato"
        Me.TbxFechaFinContrato.Size = New System.Drawing.Size(100, 20)
        Me.TbxFechaFinContrato.TabIndex = 9
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(140, 253)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BtnModificar.TabIndex = 10
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(59, 253)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 11
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'FrmModificarContrata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 326)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.TbxFechaFinContrato)
        Me.Controls.Add(Me.TbxFechaContratacion)
        Me.Controls.Add(Me.TbxFechaCreacion)
        Me.Controls.Add(Me.TbxIdServicio)
        Me.Controls.Add(Me.TbxIdPersona)
        Me.Controls.Add(Me.LblFechaFinContrato)
        Me.Controls.Add(Me.LblFechaContratacion)
        Me.Controls.Add(Me.LblFechaCreacion)
        Me.Controls.Add(Me.LblIdServicio)
        Me.Controls.Add(Me.LblIdPersona)
        Me.Name = "FrmModificarContrata"
        Me.Text = "Contrata - Modificar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblIdPersona As Label
    Friend WithEvents LblIdServicio As Label
    Friend WithEvents LblFechaCreacion As Label
    Friend WithEvents LblFechaContratacion As Label
    Friend WithEvents LblFechaFinContrato As Label
    Friend WithEvents TbxIdPersona As TextBox
    Friend WithEvents TbxIdServicio As TextBox
    Friend WithEvents TbxFechaCreacion As TextBox
    Friend WithEvents TbxFechaContratacion As TextBox
    Friend WithEvents TbxFechaFinContrato As TextBox
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnBuscar As Button
End Class
