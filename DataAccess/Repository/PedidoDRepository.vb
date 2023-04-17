Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess

Public Class PedidoDRepository
    Inherits MasterRepository
    Implements IPedidoDRepository

    Private selectAll As String
    Private insert As String
    Private update As String
    Private delete As String
    Public Sub New()
        selectAll = "usp_listar_pedidoD"
        insert = "usp_registrar_pedidoD"
        update = "usp_modicar_pedidoD"
        delete = "usp_borrar_pedidoD"

    End Sub

    Public Function Add(entity As PedidoD) As Integer Implements IGenericReposotory(Of PedidoD).Add
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@idPedido", entity.idPedido))
        parameters.Add(New SqlParameter("@idProducto", entity.idProducto))
        parameters.Add(New SqlParameter("@cantidad", entity.cantidad))
        parameters.Add(New SqlParameter("@valorUnitario", entity.valorUnitario))

        Return ExecuteNonQuerySP(insert)
    End Function

    Public Function Edit(entity As PedidoD) As Integer Implements IGenericReposotory(Of PedidoD).Edit
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@id", entity.id))
        parameters.Add(New SqlParameter("@idPedido", entity.idPedido))
        parameters.Add(New SqlParameter("@idProducto", entity.idProducto))
        parameters.Add(New SqlParameter("@cantidad", entity.cantidad))
        parameters.Add(New SqlParameter("@valorUnitario", entity.valorUnitario))

        Return ExecuteNonQuerySP(update)
    End Function

    Public Function GetAll() As IEnumerable(Of PedidoD) Implements IGenericReposotory(Of PedidoD).GetAll
        Dim resultTable = ExecuteReader(selectAll)
        Dim ListPedidosD As New List(Of PedidoD)

        For Each items As DataRow In resultTable.Rows
            ListPedidosD.Add(New PedidoD With {
                .id = items(0),
                .idPedido = items(1),
                .idProducto = items(2),
                .cantidad = items(3),
                .valorUnitario = items(4)
            })
        Next

        Return ListPedidosD
    End Function

    Public Function Remove(id As String) As Integer Implements IGenericReposotory(Of PedidoD).Remove
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@id", id))

        Return ExecuteNonQuerySP(delete)
    End Function

End Class
