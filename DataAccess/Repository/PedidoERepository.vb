Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess

Public Class PedidoERepository
    Inherits MasterRepository
    Implements IPedidoERepository

    Private selectAll As String
    Private insert As String
    Private update As String
    Private delete As String
    Public Sub New()
        selectAll = "usp_listar_pedidoE"
        insert = "usp_registrar_pedidoE"
        update = "usp_modicar_pedidoE"
        delete = "usp_borrar_pedidoE"

    End Sub

    Public Function Add(entity As PedidoE) As Integer Implements IGenericReposotory(Of PedidoE).Add
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@idPedido", entity.idPedido))
        parameters.Add(New SqlParameter("@cedula", entity.cedula))
        parameters.Add(New SqlParameter("@fecha", entity.fecha))
        parameters.Add(New SqlParameter("@direccion", entity.direccion))
        parameters.Add(New SqlParameter("@precioTotal", entity.precioTotal))

        Return ExecuteNonQuerySP(insert)
    End Function

    Public Function Edit(entity As PedidoE) As Integer Implements IGenericReposotory(Of PedidoE).Edit
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@idPedido", entity.idPedido))
        parameters.Add(New SqlParameter("@cedula", entity.cedula))
        parameters.Add(New SqlParameter("@fecha", entity.fecha))
        parameters.Add(New SqlParameter("@direccion", entity.direccion))
        parameters.Add(New SqlParameter("@precioTotal", entity.precioTotal))

        Return ExecuteNonQuerySP(update)
    End Function

    Public Function GetAll() As IEnumerable(Of PedidoE) Implements IGenericReposotory(Of PedidoE).GetAll
        Dim resultTable = ExecuteReader(selectAll)
        Dim ListPedidosE As New List(Of PedidoE)

        For Each items As DataRow In resultTable.Rows
            ListPedidosE.Add(New PedidoE With {
                .idPedido = items(0),
                .cedula = items(1),
                .fecha = items(2),
                .direccion = items(3),
                .precioTotal = items(4)
            })
        Next

        Return ListPedidosE
    End Function

    Public Function Remove(idPedido As String) As Integer Implements IGenericReposotory(Of PedidoE).Remove
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@idPedido", idPedido))

        Return ExecuteNonQuerySP(delete)
    End Function

End Class
