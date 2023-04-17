Imports DataAccess
Imports System.ComponentModel.DataAnnotations

Public Class PedidoDModel
    Private _id As Integer
    Private _idPedido As Integer
    Private _idProducto As Integer
    Private _cantidad As Integer
    Private _valorUnitario As Decimal

    Public state As EntityState
    Private Repository As IPedidoDRepository

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property IdPedido As Integer
        Get
            Return _idPedido
        End Get
        Set(value As Integer)
            _idPedido = value
        End Set
    End Property

    Public Property IdProducto As Integer
        Get
            Return _idProducto
        End Get
        Set(value As Integer)
            _idProducto = value
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return _cantidad
        End Get
        Set(value As Integer)
            _cantidad = value
        End Set
    End Property

    Public Property ValorUnitario As Decimal
        Get
            Return _valorUnitario
        End Get
        Set(value As Decimal)
            _valorUnitario = value
        End Set
    End Property

    Public Sub New()
        Repository = New PedidoDRepository()

    End Sub

    Public Function SaveChanges() As String
        Dim message = Nothing

        Try
            Dim PedidoDDataModel As New PedidoD()

            PedidoDDataModel.id = Id
            PedidoDDataModel.idPedido = IdPedido
            PedidoDDataModel.idProducto = IdProducto
            PedidoDDataModel.cantidad = Cantidad
            PedidoDDataModel.valorUnitario = ValorUnitario

            Select Case state
                Case EntityState.Added
                    Repository.Add(PedidoDDataModel)
                    message = "Successfuly record "
                Case EntityState.Modified
                    Repository.Edit(PedidoDDataModel)
                Case EntityState.Deleted
                    Repository.Remove(PedidoDDataModel.idPedido)
            End Select

        Catch ex As Exception
            message = ex.Message.ToString()
        End Try
        Return message
    End Function

    Public Function GetPedidoD() As List(Of PedidoD)
        Dim ListPedidoDDataModel = Repository.GetAll()
        Dim ListPedidoDViewModel = New List(Of PedidoD)

        For Each item As PedidoD In ListPedidoDDataModel
            ListPedidoDViewModel.Add(New PedidoD With {
                .id = item.id,
                .idPedido = item.idPedido,
                .idProducto = item.idProducto,
                .cantidad = item.cantidad,
                .valorUnitario = item.valorUnitario
            })
        Next
        Return ListPedidoDViewModel
    End Function

    Public Function FindById(Filtrer As String) As IEnumerable(Of PedidoD)
        Return GetPedidoD().FindAll(Function(pedD) pedD.idPedido.Equals(Integer.Parse(Filtrer)))
    End Function

End Class
