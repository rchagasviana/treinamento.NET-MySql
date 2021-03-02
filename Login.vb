Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirConexao()
        fecharConexao()
    End Sub

    Private Sub btnAcessar_Click(sender As Object, e As EventArgs) Handles btnAcessar.Click
        Dim form = New frmCategoria
        form.ShowDialog()
    End Sub
End Class
