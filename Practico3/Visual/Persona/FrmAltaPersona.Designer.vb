<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaPersona
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
        Me.TbxNombre = New System.Windows.Forms.TextBox()
        Me.TbxApellido = New System.Windows.Forms.TextBox()
        Me.TbxMail = New System.Windows.Forms.TextBox()
        Me.TbxTelefono = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblMail = New System.Windows.Forms.Label()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TbxNombre
        '
        Me.TbxNombre.Location = New System.Drawing.Point(185, 64)
        Me.TbxNombre.Name = "TbxNombre"
        Me.TbxNombre.Size = New System.Drawing.Size(100, 20)
        Me.TbxNombre.TabIndex = 0
        '
        'TbxApellido
        '
        Me.TbxApellido.Location = New System.Drawing.Point(185, 108)
        Me.TbxApellido.Name = "TbxApellido"
        Me.TbxApellido.Size = New System.Drawing.Size(100, 20)
        Me.TbxApellido.TabIndex = 1
        '
        'TbxMail
        '
        Me.TbxMail.Location = New System.Drawing.Point(185, 152)
        Me.TbxMail.Name = "TbxMail"
        Me.TbxMail.Size = New System.Drawing.Size(100, 20)
        Me.TbxMail.TabIndex = 2
        '
        'TbxTelefono
        '
        Me.TbxTelefono.Location = New System.Drawing.Point(185, 196)
        Me.TbxTelefono.Name = "TbxTelefono"
        Me.TbxTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TbxTelefono.TabIndex = 3
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(63, 71)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 4
        Me.LblNombre.Text = "Nombre"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(63, 115)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(44, 13)
        Me.LblApellido.TabIndex = 5
        Me.LblApellido.Text = "Apellido"
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.Location = New System.Drawing.Point(63, 159)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(26, 13)
        Me.LblMail.TabIndex = 6
        Me.LblMail.Text = "Mail"
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(63, 203)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LblTelefono.TabIndex = 7
        Me.LblTelefono.Text = "Telefono"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(158, 279)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 8
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'FrmAltaPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 352)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.LblTelefono)
        Me.Controls.Add(Me.LblMail)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.TbxTelefono)
        Me.Controls.Add(Me.TbxMail)
        Me.Controls.Add(Me.TbxApellido)
        Me.Controls.Add(Me.TbxNombre)
        Me.Name = "FrmAltaPersona"
        Me.Text = "Persona - Alta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbxNombre As TextBox
    Friend WithEvents TbxApellido As TextBox
    Friend WithEvents TbxMail As TextBox
    Friend WithEvents TbxTelefono As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblMail As Label
    Friend WithEvents LblTelefono As Label
    Friend WithEvents BtnAceptar As Button
End Class
