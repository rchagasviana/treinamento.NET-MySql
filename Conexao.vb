Imports MySql.Data.MySqlClient

Module Conexao
    Public conexao As New MySqlConnection("server=localhost;userid=root;password='root';database=vb6;")
    'Função para abri a conexão
    Sub abrirConexao()
        If conexao.State = 0 Then
            conexao.Open()
            MsgBox("Conectado com Sucesso!")
        End If
    End Sub
    'Função para fechar a conexão
    Sub fecharConexao()
        If conexao.State = 1 Then
            conexao.Close()
            'MsgBox("Erro ao conectar!")

        End If
    End Sub



End Module
