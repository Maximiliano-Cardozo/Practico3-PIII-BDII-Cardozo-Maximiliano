<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarPersona
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
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblMail = New System.Windows.Forms.Label()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.TbxNombre = New System.Windows.Forms.TextBox()
        Me.TbxApellido = New System.Windows.Forms.TextBox()
        Me.TbxMail = New System.Windows.Forms.TextBox()
        Me.TbxTelefono = New System.Windows.Forms.TextBox()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.LblId = New System.Windows.Forms.Label()
        Me.TbxId = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(37, 90)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(37, 135)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(44, 13)
        Me.LblApellido.TabIndex = 1
        Me.LblApellido.Text = "Apellido"
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.Location = New System.Drawing.Point(37, 180)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(26, 13)
        Me.LblMail.TabIndex = 2
        Me.LblMail.Text = "Mail"
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(37, 225)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LblTelefono.TabIndex = 3
        Me.LblTelefono.Text = "Telefono"
        '
        'TbxNombre
        '
        Me.TbxNombre.Location = New System.Drawing.Point(98, 83)
        Me.TbxNombre.Name = "TbxNombre"
        Me.TbxNombre.Size = New System.Drawing.Size(100, 20)
        Me.TbxNombre.TabIndex = 4
        '
        'TbxApellido
        '
        Me.TbxApellido.Location = New System.Drawing.Point(98, 128)
        Me.TbxApellido.Name = "TbxApellido"
        Me.TbxApellido.Size = New System.Drawing.Size(100, 20)
        Me.TbxApellido.TabIndex = 5
        '
        'TbxMail
        '
        Me.TbxMail.Location = New System.Drawing.Point(98, 173)
        Me.TbxMail.Name = "TbxMail"
        Me.TbxMail.Size = New System.Drawing.Size(100, 20)
        Me.TbxMail.TabIndex = 6
        '
        'TbxTelefono
        '
        Me.TbxTelefono.Location = New System.Drawing.Point(98, 218)
        Me.TbxTelefono.Name = "TbxTelefono"
        Me.TbxTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TbxTelefono.TabIndex = 7
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(81, 284)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BtnModificar.TabIndex = 8
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Location = New System.Drawing.Point(37, 40)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(18, 13)
        Me.LblId.TabIndex = 9
        Me.LblId.Text = "ID"
        '
        'TbxId
        '
        Me.TbxId.Enabled = False
        Me.TbxId.Location = New System.Drawing.Point(98, 33)
        Me.TbxId.Name = "TbxId"
        Me.TbxId.Size = New System.Drawing.Size(100, 20)
        Me.TbxId.TabIndex = 10
        '
        'FrmModificarPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 334)
        Me.Controls.Add(Me.TbxId)
        Me.Controls.Add(Me.LblId)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.TbxTelefono)
        Me.Controls.Add(Me.TbxMail)
        Me.Controls.Add(Me.TbxApellido)
        Me.Controls.Add(Me.TbxNombre)
        Me.Controls.Add(Me.LblTelefono)
        Me.Controls.Add(Me.LblMail)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.LblNombre)
        Me.Name = "FrmModificarPersona"
        Me.Text = "Persona - Modificar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNombre As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblMail As Label
    Friend WithEvents LblTelefono As Label
    Friend WithEvents TbxNombre As TextBox
    Friend WithEvents TbxApellido As TextBox
    Friend WithEvents TbxMail As TextBox
    Friend WithEvents TbxTelefono As TextBox
    Friend WithEvents BtnModificar As Button
    Friend WithEvents LblId As Label
    Friend WithEvents TbxId As TextBox
End Class
