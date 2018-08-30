Public Class frmSindicato
    Public gIdTipo As Integer
    Public gExpedicion As String
    Public gfecha As String
    Public gfechaCorta As String
    Public gNomina As String
    Private Sub frmSindicato_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdaceptar_Click(sender As Object, e As EventArgs) Handles cmdaceptar.Click
        gExpedicion = txtlugar.Text.ToUpper()
        gfecha = dtpfecha.Value.ToLongDateString().ToUpper()
        gfechaCorta = dtpfecha.Value.Date.ToShortDateString
        gIdTipo = 5
        gNomina = cbonomina.SelectedText

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub cmdcancelar_Click(sender As Object, e As EventArgs) Handles cmdcancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class