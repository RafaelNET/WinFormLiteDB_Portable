Imports LiteDB

Public Class Form1
    Dim mapper As New BsonMapper

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCriarBanco_Click(sender As Object, e As EventArgs) Handles btnCriarBanco.Click
        Dim db As New LiteDatabase("banco.db")
        db.Dispose()
    End Sub

    Private Sub btnNovaTabela_Click(sender As Object, e As EventArgs) Handles btnNovaTabela.Click
        Dim db As New LiteDatabase("banco.db")
        Dim users = db.GetCollection(Of Usuarios)
        Dim nomes() As String = {"Rafael", "Fernando", "Willians", "Allas", "Airton"}
        For Each nome As String In nomes
            Dim usuario As New Usuarios
            usuario.nome = nome
            users.Insert(usuario)
        Next
        db.Dispose()
    End Sub

    Private Sub btnLerRegistros_Click(sender As Object, e As EventArgs) Handles btnLerRegistros.Click
        Dim db As New LiteDatabase("banco.db")
        Dim users = db.GetCollection(Of Usuarios)
        If users.FindAll.Count = 0 Then
            MsgBox("Nenhum registro encontrado!")
        Else
            For Each user As Usuarios In users.FindAll
                MsgBox("ID: " & user.codigo & Environment.NewLine & "Nome: " & user.nome & Environment.NewLine & "Sobrenome: " & user.sobrenome)
            Next
        End If
        db.Dispose()
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        Dim db As New LiteDatabase("banco.db")
        Dim users = db.GetCollection(Of Usuarios)
        Dim nome As String
        Dim nomes() As String = {"Rafael", "Fernando", "Willians", "Allas", "Airton"}
        Dim sobrenomes() As String = {"Andrade", "Novais", "Freitas", "Capucho", "Reis"}
        If users.FindAll.Count = 0 Then
            MsgBox("Nenhum registro encontrado!")
        Else
            For index = 0 To nomes.Count - 1
                nome = nomes(index)
                Dim usuario = users.FindAll().Where(Function(u) u.nome = nome).FirstOrDefault
                If usuario IsNot Nothing Then
                    usuario.sobrenome = sobrenomes(index)
                    users.Update(usuario)
                End If
            Next
        End If

        db.Dispose()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim db As New LiteDatabase("banco.db")
        Dim users = db.GetCollection(Of Usuarios)
        Dim lista = users.FindAll.Where(Function(u) (u.codigo / 2) <> Math.Truncate(u.codigo / 2))
        For Each user In lista
            users.Delete(user.codigo)
        Next
        db.Dispose()
        MsgBox("Registros com ID ímpar foram removidos!")
        btnLerRegistros.PerformClick()
    End Sub
End Class
