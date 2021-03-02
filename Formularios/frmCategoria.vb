Imports MySql.Data.MySqlClient

Public Class frmCategoria
    Private Sub txtDescricao_TextChanged(sender As Object, e As EventArgs) Handles txtDescricao.TextChanged

    End Sub

    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
    End Sub

    Private Sub Listar()
        Try
            abrirConexao()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sqlListar As String
            sqlListar = "SELECT idCategoria as Código, descricao as Descrição FROM categorias ORDER BY idCategoria"
            da = New MySqlDataAdapter(sqlListar, con)
            da.Fill(dt)
            dg.DataSource = dt
        Catch ex As Exception
            MsgBox("Erro ao listar os dados")
        End Try
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        btnSalvar.Enabled = True 'Tornar botão Salvar inativo quando for clicado
        txtDescricao.Enabled = True
        txtDescricao.Text = "" 'Limpa o campo
    End Sub

    'Rotina para salvar categorias
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If txtDescricao.Text <> "" Then
            Try
                abrirConexao()
                Dim descricao = txtDescricao.Text
                Dim cmd As MySqlCommand
                Dim sqlInserir As String
                sqlInserir = "INSERT into categorias(descricao) VALUES('" & descricao & "')"
                cmd = New MySqlCommand(sqlInserir, con) 'Chama a variável con que é pública e está no Módulo usado para criar a conexção
                cmd.ExecuteNonQuery()
                MsgBox("Salvo com Sucesso!")
                fecharConexao()
            Catch ex As Exception
                MsgBox("Erro ao salvar!")
            End Try
            'DESATIVAR O BTNSALVAR APÓS INSERIR NA BASE DE DADOS
            btnSalvar.Enabled = False
            Listar() 'APÓS SALVAR O REGISTRO, OS DADOS SÃO PESQUISADOS E A DATAGRID É ATUALIZADA PARA MOSTRAR O ÚLTIMO DADO INSERIDO
            txtDescricao.Text = ""
            txtDescricao.Enabled = False
        Else
            MsgBox("Não deixe o texto descrição vazio!")
        End If
    End Sub
End Class