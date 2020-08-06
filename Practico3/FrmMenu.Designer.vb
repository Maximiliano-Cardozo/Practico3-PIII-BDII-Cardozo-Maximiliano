<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MnuPersona = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuPersonaAlta = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MnuPersonaBaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuPersonaModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuPersonaListar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuServicio = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuServicioAlta = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuServicioBaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuServicioModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuServicioListar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuContrata = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuContrataAlta = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuContrataBaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuContrataModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuContrataListar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuPersona, Me.MenuServicio, Me.MnuContrata})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MnuPersona
        '
        Me.MnuPersona.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuPersonaAlta, Me.MnuPersonaBaja, Me.MnuPersonaModificar, Me.MnuPersonaListar})
        Me.MnuPersona.Name = "MnuPersona"
        Me.MnuPersona.Size = New System.Drawing.Size(61, 20)
        Me.MnuPersona.Text = "Persona"
        '
        'MnuPersonaAlta
        '
        Me.MnuPersonaAlta.Name = "MnuPersonaAlta"
        Me.MnuPersonaAlta.Size = New System.Drawing.Size(180, 22)
        Me.MnuPersonaAlta.Text = "Alta"
        '
        'MnuPersonaBaja
        '
        Me.MnuPersonaBaja.Name = "MnuPersonaBaja"
        Me.MnuPersonaBaja.Size = New System.Drawing.Size(180, 22)
        Me.MnuPersonaBaja.Text = "Baja"
        '
        'MnuPersonaModificar
        '
        Me.MnuPersonaModificar.Name = "MnuPersonaModificar"
        Me.MnuPersonaModificar.Size = New System.Drawing.Size(180, 22)
        Me.MnuPersonaModificar.Text = "Modificar"
        '
        'MnuPersonaListar
        '
        Me.MnuPersonaListar.Name = "MnuPersonaListar"
        Me.MnuPersonaListar.Size = New System.Drawing.Size(180, 22)
        Me.MnuPersonaListar.Text = "Listar"
        '
        'MenuServicio
        '
        Me.MenuServicio.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuServicioAlta, Me.MnuServicioBaja, Me.MnuServicioModificar, Me.MnuServicioListar})
        Me.MenuServicio.Name = "MenuServicio"
        Me.MenuServicio.Size = New System.Drawing.Size(60, 20)
        Me.MenuServicio.Text = "Servicio"
        '
        'MnuServicioAlta
        '
        Me.MnuServicioAlta.Name = "MnuServicioAlta"
        Me.MnuServicioAlta.Size = New System.Drawing.Size(180, 22)
        Me.MnuServicioAlta.Text = "Alta"
        '
        'MnuServicioBaja
        '
        Me.MnuServicioBaja.Name = "MnuServicioBaja"
        Me.MnuServicioBaja.Size = New System.Drawing.Size(180, 22)
        Me.MnuServicioBaja.Text = "Baja"
        '
        'MnuServicioModificar
        '
        Me.MnuServicioModificar.Name = "MnuServicioModificar"
        Me.MnuServicioModificar.Size = New System.Drawing.Size(180, 22)
        Me.MnuServicioModificar.Text = "Modificar"
        '
        'MnuServicioListar
        '
        Me.MnuServicioListar.Name = "MnuServicioListar"
        Me.MnuServicioListar.Size = New System.Drawing.Size(180, 22)
        Me.MnuServicioListar.Text = "Listar"
        '
        'MnuContrata
        '
        Me.MnuContrata.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuContrataAlta, Me.MnuContrataBaja, Me.MnuContrataModificar, Me.MnuContrataListar})
        Me.MnuContrata.Name = "MnuContrata"
        Me.MnuContrata.Size = New System.Drawing.Size(65, 20)
        Me.MnuContrata.Text = "Contrata"
        '
        'MnuContrataAlta
        '
        Me.MnuContrataAlta.Name = "MnuContrataAlta"
        Me.MnuContrataAlta.Size = New System.Drawing.Size(180, 22)
        Me.MnuContrataAlta.Text = "Alta"
        '
        'MnuContrataBaja
        '
        Me.MnuContrataBaja.Name = "MnuContrataBaja"
        Me.MnuContrataBaja.Size = New System.Drawing.Size(180, 22)
        Me.MnuContrataBaja.Text = "Baja"
        '
        'MnuContrataModificar
        '
        Me.MnuContrataModificar.Name = "MnuContrataModificar"
        Me.MnuContrataModificar.Size = New System.Drawing.Size(180, 22)
        Me.MnuContrataModificar.Text = "Modificar"
        '
        'MnuContrataListar
        '
        Me.MnuContrataListar.Name = "MnuContrataListar"
        Me.MnuContrataListar.Size = New System.Drawing.Size(180, 22)
        Me.MnuContrataListar.Text = "Listar"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 238)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "FrmMenu"
        Me.Text = "Menu"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MnuPersona As ToolStripMenuItem
    Friend WithEvents MnuPersonaAlta As ToolStripMenuItem
    Friend WithEvents MnuPersonaBaja As ToolStripMenuItem
    Friend WithEvents MnuPersonaModificar As ToolStripMenuItem
    Friend WithEvents MnuPersonaListar As ToolStripMenuItem
    Friend WithEvents MenuServicio As ToolStripMenuItem
    Friend WithEvents MnuServicioAlta As ToolStripMenuItem
    Friend WithEvents MnuServicioBaja As ToolStripMenuItem
    Friend WithEvents MnuServicioModificar As ToolStripMenuItem
    Friend WithEvents MnuServicioListar As ToolStripMenuItem
    Friend WithEvents MnuContrata As ToolStripMenuItem
    Friend WithEvents MnuContrataAlta As ToolStripMenuItem
    Friend WithEvents MnuContrataBaja As ToolStripMenuItem
    Friend WithEvents MnuContrataModificar As ToolStripMenuItem
    Friend WithEvents MnuContrataListar As ToolStripMenuItem
End Class
