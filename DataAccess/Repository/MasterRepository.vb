﻿Imports System.Data
Imports System.Data.SqlClient
Public MustInherit Class MasterRepository
    Inherits Repository

    Protected parameters As List(Of SqlParameter)
    Protected Function ExecuteNonQuery(transactSql As String) As Integer
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = transactSql
                command.CommandType = CommandType.Text

                For Each item As SqlParameter In parameters
                    command.Parameters.Add(item)
                Next

                Dim result = command.ExecuteNonQuery()
                parameters.Clear()

                Return result

            End Using
        End Using

    End Function

    Protected Function ExecuteReader(transactSql As String) As DataTable
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = transactSql
                command.CommandType = CommandType.Text

                Dim reader = command.ExecuteReader()
                Using table = New DataTable()
                    table.Load(reader)
                    reader.Dispose()
                    Return table
                End Using
            End Using
        End Using

    End Function

End Class
