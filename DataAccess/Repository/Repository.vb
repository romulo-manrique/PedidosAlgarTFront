Imports System.Configuration
Imports System.Data.SqlClient

Public MustInherit Class Repository
    Private ReadOnly Cnn As String

    Public Sub New()
        Cnn = ConfigurationManager.ConnectionStrings("cnn").ToString()
    End Sub

    Protected Function GetConnection() As SqlConnection
        Return New SqlConnection(Cnn)
    End Function
End Class
