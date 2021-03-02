Imports MySql.Data.MySqlClient

Module Conexao
    Public con As New MySqlConnection("server=localhost;userid=root;password='root';database=vb6;")
    'Função para abri a conexão
    Sub abrirConexao()
        If con.State = 0 Then
            con.Open()
            MsgBox("Conectado com Sucesso!")
        End If
    End Sub
    'Função para fechar a conexão
    Sub fecharConexao()
        If con.State = 1 Then
            con.Close()
            'MsgBox("Erro ao conectar!")

        End If
    End Sub



End Module
