Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess

Public Class ClienteRepository
    Inherits MasterRepository
    Implements IClienteRepository

    Private selectAll As String
    Private insert As String
    Private update As String
    Private delete As String
    Public Sub New()
        selectAll = "select * from  cliente"
        insert = "INSERT INTO [dbo].[cliente] ([cedula] ,[nombreCliente] ,[apellidoCliente] ,[telefonoCliente]) VALUES (@cedula ,@nombreCliente,@apellidoCliente ,@telefonoCliente)"
        update = "UPDATE [dbo].[cliente]  SET [nombreCliente]   = @nombreCliente,[apellidoCliente] = @apellidoCliente ,[telefonoCliente] = @telefonoCliente WHERE [cedula] = @cedula "
        delete = "DELETE FROM [dbo].[cliente] WHERE cedula = @cedula"

    End Sub


    Public Function Add(entity As Cliente) As Integer Implements IGenericReposotory(Of Cliente).Add
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@cedula", entity.cedula))
        parameters.Add(New SqlParameter("@nombreCliente", entity.nombreCliente))
        parameters.Add(New SqlParameter("@apellidoCliente", entity.apellidoCliente))
        parameters.Add(New SqlParameter("@telefonoCliente", entity.telefonoCliente))

        Return ExecuteNonQuery(insert)
    End Function
    Public Function Edit(entity As Cliente) As Integer Implements IGenericReposotory(Of Cliente).Edit
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@cedula", entity.cedula))
        parameters.Add(New SqlParameter("@nombreCliente", entity.nombreCliente))
        parameters.Add(New SqlParameter("@apellidoCliente", entity.apellidoCliente))
        parameters.Add(New SqlParameter("@telefonoCliente", entity.telefonoCliente))

        Return ExecuteNonQuery(update)
    End Function

    Public Function Remove(cedula As String) As Integer Implements IGenericReposotory(Of Cliente).Remove
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@cedula", cedula))

        Return ExecuteNonQuery(delete)
    End Function

    Public Function GetAll() As IEnumerable(Of Cliente) Implements IGenericReposotory(Of Cliente).GetAll
        Dim resultTable = ExecuteReader(selectAll)
        Dim ListClientes As New List(Of Cliente)

        For Each items As DataRow In resultTable.Rows
            ListClientes.Add(New Cliente With {
                .cedula = items(0),
                .nombreCliente = items(1),
                .apellidoCliente = items(2),
                .telefonoCliente = items(3)
            })
        Next

        Return ListClientes

    End Function
End Class
