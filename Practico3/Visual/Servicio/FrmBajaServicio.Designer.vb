<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBajaServicio
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
        Me.LblId = New System.Windows.Forms.Label()
        Me.TbxId = New System.Windows.Forms.TextBox()
        Me.BtnBaja = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Location = New System.Drawing.Point(102, 52)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(18, 13)
        Me.LblId.TabIndex = 0
        Me.LblId.Text = "ID"
        '
        'TbxId
        '
        Me.TbxId.Location = New System.Drawing.Point(61, 85)
        Me.TbxId.Name = "TbxId"
        Me.TbxId.Size = New System.Drawing.Size(100, 20)
        Me.TbxId.TabIndex = 1
        '
        'BtnBaja
        '
        Me.BtnBaja.Location = New System.Drawing.Point(74, 153)
        Me.BtnBaja.Name = "BtnBaja"
        Me.BtnBaja.Size = New System.Drawing.Size(75, 23)
        Me.BtnBaja.TabIndex = 2
        Me.BtnBaja.Text = "Dar De Baja"
        Me.BtnBaja.UseVisualStyleBackColor = True
        '
        'FrmBajaServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 244)
        Me.Controls.Add(Me.BtnBaja)
        Me.Controls.Add(Me.TbxId)
        Me.Controls.Add(Me.LblId)
        Me.Name = "FrmBajaServicio"
        Me.Text = "Servicio - Baja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblId As Label
    Friend WithEvents TbxId As TextBox
    Friend WithEvents BtnBaja As Button
End Class
