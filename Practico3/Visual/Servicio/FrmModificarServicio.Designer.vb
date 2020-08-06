<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmModificarServicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LblID = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblCostoMensual = New System.Windows.Forms.Label()
        Me.LblTipo = New System.Windows.Forms.Label()
        Me.TbxID = New System.Windows.Forms.TextBox()
        Me.TbxNombre = New System.Windows.Forms.TextBox()
        Me.TbxCostoMensual = New System.Windows.Forms.TextBox()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.ListTipo = New System.Windows.Forms.ListBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Location = New System.Drawing.Point(35, 46)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(18, 13)
        Me.LblID.TabIndex = 0
        Me.LblID.Text = "ID"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(35, 89)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 1
        Me.LblNombre.Text = "Nombre"
        '
        'LblCostoMensual
        '
        Me.LblCostoMensual.AutoSize = True
        Me.LblCostoMensual.Location = New System.Drawing.Point(35, 131)
        Me.LblCostoMensual.Name = "LblCostoMensual"
        Me.LblCostoMensual.Size = New System.Drawing.Size(77, 13)
        Me.LblCostoMensual.TabIndex = 2
        Me.LblCostoMensual.Text = "Costo Mensual"
        '
        'LblTipo
        '
        Me.LblTipo.AutoSize = True
        Me.LblTipo.Location = New System.Drawing.Point(35, 180)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(28, 13)
        Me.LblTipo.TabIndex = 3
        Me.LblTipo.Text = "Tipo"
        '
        'TbxID
        '
        Me.TbxID.Location = New System.Drawing.Point(142, 39)
        Me.TbxID.Name = "TbxID"
        Me.TbxID.Size = New System.Drawing.Size(100, 20)
        Me.TbxID.TabIndex = 4
        '
        'TbxNombre
        '
        Me.TbxNombre.Location = New System.Drawing.Point(142, 82)
        Me.TbxNombre.Name = "TbxNombre"
        Me.TbxNombre.Size = New System.Drawing.Size(100, 20)
        Me.TbxNombre.TabIndex = 5
        '
        'TbxCostoMensual
        '
        Me.TbxCostoMensual.Location = New System.Drawing.Point(142, 124)
        Me.TbxCostoMensual.Name = "TbxCostoMensual"
        Me.TbxCostoMensual.Size = New System.Drawing.Size(100, 20)
        Me.TbxCostoMensual.TabIndex = 6
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(142, 235)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BtnModificar.TabIndex = 8
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'ListTipo
        '
        Me.ListTipo.FormattingEnabled = True
        Me.ListTipo.Items.AddRange(New Object() {"-", "Limpieza", "Mantenimiento", "Electricidad", "Telecomunicaciones", "Informatica"})
        Me.ListTipo.Location = New System.Drawing.Point(142, 180)
        Me.ListTipo.Name = "ListTipo"
        Me.ListTipo.Size = New System.Drawing.Size(120, 30)
        Me.ListTipo.TabIndex = 9
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(61, 235)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 10
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'FrmModificarServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 298)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.ListTipo)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.TbxCostoMensual)
        Me.Controls.Add(Me.TbxNombre)
        Me.Controls.Add(Me.TbxID)
        Me.Controls.Add(Me.LblTipo)
        Me.Controls.Add(Me.LblCostoMensual)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblID)
        Me.Name = "FrmModificarServicio"
        Me.Text = "Servicio - Modificar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblID As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblCostoMensual As Label
    Friend WithEvents LblTipo As Label
    Friend WithEvents TbxID As TextBox
    Friend WithEvents TbxNombre As TextBox
    Friend WithEvents TbxCostoMensual As TextBox
    Friend WithEvents BtnModificar As Button
    Friend WithEvents ListTipo As ListBox
    Friend WithEvents BtnBuscar As Button
End Class
