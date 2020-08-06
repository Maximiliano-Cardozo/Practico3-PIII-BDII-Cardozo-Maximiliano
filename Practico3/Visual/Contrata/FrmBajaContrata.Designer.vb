<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBajaContrata
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
        Me.TbxPersona = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TbxFechaCreacion = New System.Windows.Forms.TextBox()
        Me.BtnBaja = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblIdPersona
        '
        Me.LblIdPersona.AutoSize = True
        Me.LblIdPersona.Location = New System.Drawing.Point(35, 59)
        Me.LblIdPersona.Name = "LblIdPersona"
        Me.LblIdPersona.Size = New System.Drawing.Size(60, 13)
        Me.LblIdPersona.TabIndex = 0
        Me.LblIdPersona.Text = "ID Persona"
        '
        'LblIdServicio
        '
        Me.LblIdServicio.AutoSize = True
        Me.LblIdServicio.Location = New System.Drawing.Point(35, 106)
        Me.LblIdServicio.Name = "LblIdServicio"
        Me.LblIdServicio.Size = New System.Drawing.Size(59, 13)
        Me.LblIdServicio.TabIndex = 1
        Me.LblIdServicio.Text = "ID Servicio"
        '
        'LblFechaCreacion
        '
        Me.LblFechaCreacion.AutoSize = True
        Me.LblFechaCreacion.Location = New System.Drawing.Point(35, 153)
        Me.LblFechaCreacion.Name = "LblFechaCreacion"
        Me.LblFechaCreacion.Size = New System.Drawing.Size(82, 13)
        Me.LblFechaCreacion.TabIndex = 2
        Me.LblFechaCreacion.Text = "Fecha Creacion"
        '
        'TbxPersona
        '
        Me.TbxPersona.Location = New System.Drawing.Point(120, 52)
        Me.TbxPersona.Name = "TbxPersona"
        Me.TbxPersona.Size = New System.Drawing.Size(100, 20)
        Me.TbxPersona.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(120, 99)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 4
        '
        'TbxFechaCreacion
        '
        Me.TbxFechaCreacion.Location = New System.Drawing.Point(120, 146)
        Me.TbxFechaCreacion.Name = "TbxFechaCreacion"
        Me.TbxFechaCreacion.Size = New System.Drawing.Size(100, 20)
        Me.TbxFechaCreacion.TabIndex = 5
        '
        'BtnBaja
        '
        Me.BtnBaja.Location = New System.Drawing.Point(95, 214)
        Me.BtnBaja.Name = "BtnBaja"
        Me.BtnBaja.Size = New System.Drawing.Size(75, 23)
        Me.BtnBaja.TabIndex = 6
        Me.BtnBaja.Text = "Dar De Baja"
        Me.BtnBaja.UseVisualStyleBackColor = True
        '
        'FrmBajaContrata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 315)
        Me.Controls.Add(Me.BtnBaja)
        Me.Controls.Add(Me.TbxFechaCreacion)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TbxPersona)
        Me.Controls.Add(Me.LblFechaCreacion)
        Me.Controls.Add(Me.LblIdServicio)
        Me.Controls.Add(Me.LblIdPersona)
        Me.Name = "FrmBajaContrata"
        Me.Text = "Contrata - Baja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblIdPersona As Label
    Friend WithEvents LblIdServicio As Label
    Friend WithEvents LblFechaCreacion As Label
    Friend WithEvents TbxPersona As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TbxFechaCreacion As TextBox
    Friend WithEvents BtnBaja As Button
End Class
