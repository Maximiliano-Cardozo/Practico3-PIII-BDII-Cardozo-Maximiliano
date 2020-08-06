<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBajaPersona
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
        Me.BtnBaja = New System.Windows.Forms.Button()
        Me.LblId = New System.Windows.Forms.Label()
        Me.TbxBaja = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnBaja
        '
        Me.BtnBaja.Location = New System.Drawing.Point(80, 145)
        Me.BtnBaja.Name = "BtnBaja"
        Me.BtnBaja.Size = New System.Drawing.Size(75, 23)
        Me.BtnBaja.TabIndex = 0
        Me.BtnBaja.Text = "Dar De Baja"
        Me.BtnBaja.UseVisualStyleBackColor = True
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Location = New System.Drawing.Point(109, 28)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(16, 13)
        Me.LblId.TabIndex = 1
        Me.LblId.Text = "Id"
        '
        'TbxBaja
        '
        Me.TbxBaja.Location = New System.Drawing.Point(67, 67)
        Me.TbxBaja.Name = "TbxBaja"
        Me.TbxBaja.Size = New System.Drawing.Size(100, 20)
        Me.TbxBaja.TabIndex = 2
        '
        'FrmBajaPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(245, 207)
        Me.Controls.Add(Me.TbxBaja)
        Me.Controls.Add(Me.LblId)
        Me.Controls.Add(Me.BtnBaja)
        Me.Name = "FrmBajaPersona"
        Me.Text = "Persona - Baja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBaja As Button
    Friend WithEvents LblId As Label
    Friend WithEvents TbxBaja As TextBox
End Class
