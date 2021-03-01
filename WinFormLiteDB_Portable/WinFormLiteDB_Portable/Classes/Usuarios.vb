Imports LiteDB

Public Class Usuarios
    <BsonId>
    Property codigo As Integer
    Property nome As String
    Property sobrenome As String
    Property dataNascimento As Date
    Property usuario As String
    Property email As String
    Property senha As String

    Sub New()
        nome = ""
        sobrenome = ""
        dataNascimento = Nothing
        usuario = ""
        email = ""
        senha = ""
    End Sub
End Class
