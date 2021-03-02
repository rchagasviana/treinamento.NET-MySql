Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As MySqlConnection
        'Variável para conexão com o servidor local
        mysql.ConnectionString = "server=;userid;password=;database=;"

    End Sub
End Class
