Imports System.Windows.Forms

Public Class FrmMenu


    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MnuPersonaAlta.Click
        Dim Formulario As New FrmAltaPersona
        Formulario.Show()
    End Sub

    Private Sub BajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MnuPersonaBaja.Click
        Dim Formulario As New FrmBajaPersona
        Formulario.Show()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MnuPersonaModificar.Click
        Dim Formulario As New FrmModificarPersona
        Formulario.Show()
    End Sub

    Private Sub ListarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MnuPersonaListar.Click
        Dim Formulario As New FrmListarPersona
        Formulario.Show()
    End Sub

    Private Sub AltaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MnuServicioAlta.Click
        Dim Formulario As New FrmAltaServicio
        Formulario.Show()
    End Sub

    Private Sub BajaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MnuServicioBaja.Click
        Dim Formulario As New FrmBajaServicio
        Formulario.Show()
    End Sub

    Private Sub ModificarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MnuServicioModificar.Click
        Dim Formulario As New FrmModificarServicio
        Formulario.Show()
    End Sub

    Private Sub ListarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MnuServicioListar.Click
        Dim Formulario As New FrmListarServicio
        Formulario.Show()
    End Sub

    Private Sub AltaToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles MnuContrataAlta.Click
        Dim Formulario As New FrmAltaContrata
        Formulario.Show()
    End Sub

    Private Sub BajaToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles MnuContrataBaja.Click
        Dim Formulario As New FrmBajaContrata
        Formulario.Show()
    End Sub

    Private Sub ModificarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles MnuContrataModificar.Click
        Dim Formulario As New FrmModificarContrata
        Formulario.Show()
    End Sub

    Private Sub ListarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles MnuContrataListar.Click
        Dim Formulario As New FrmListarContrata
        Formulario.Show()
    End Sub
End Class
