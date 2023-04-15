Imports DataAccess
Imports System.ComponentModel.DataAnnotations

Public Class PedidoEModel
    Private _idPedido As Integer
    Private _cedula As String
    Private _fecha As Date
    Private _direcion As String
    Private _PrecioTotal As Decimal

    Public state As EntityState

    Private Repository As IPedidoERepository

    Public Property IdPedido As Integer
        Get
            Return _idPedido
        End Get
        Set(value As Integer)
            _idPedido = value
        End Set
    End Property

    Public Property Cedula As String
        Get
            Return _cedula
        End Get
        Set(value As String)
            _cedula = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Public Property Direcion As String
        Get
            Return _direcion
        End Get
        Set(value As String)
            _direcion = value
        End Set
    End Property

    Public Property PrecioTotal As Decimal
        Get
            Return _PrecioTotal
        End Get
        Set(value As Decimal)
            _PrecioTotal = value
        End Set
    End Property

    Public Sub New()
        Repository = New PedidoERepository()

    End Sub

    Public Function SaveChanges() As String
        Dim message = Nothing

        Try
            Dim PedidoEDataModel As New PedidoE()

            PedidoEDataModel.idPedido = IdPedido
            PedidoEDataModel.cedula = Cedula
            PedidoEDataModel.fecha = Fecha
            PedidoEDataModel.direccion = Direcion
            PedidoEDataModel.precioTotal = PrecioTotal

            Select Case state
                Case EntityState.Added
                    Repository.Add(PedidoEDataModel)
                    message = "Successfuly record "
                Case EntityState.Modified
                    Repository.Edit(PedidoEDataModel)
                Case EntityState.Deleted
                    Repository.Remove(PedidoEDataModel.idPedido)
            End Select

        Catch ex As Exception
            message = ex.Message.ToString()
        End Try
        Return message
    End Function

    Public Function GetPedidoE() As List(Of PedidoE)
        Dim ListPedidoEDataModel = Repository.GetAll()
        Dim ListPedidoEViewModel = New List(Of PedidoE)

        For Each item As PedidoE In ListPedidoEDataModel
            ListPedidoEViewModel.Add(New PedidoE With {
                .idPedido = item.idPedido,
                .cedula = item.cedula,
                .fecha = item.fecha,
                .direccion = item.direccion,
                .precioTotal = item.precioTotal
            })
        Next
        Return ListPedidoEViewModel
    End Function

    Public Function FindById(Filtrer As String) As IEnumerable(Of PedidoE)
        Return GetPedidoE().FindAll(Function(pedE) pedE.idPedido.Equals(Filtrer))
    End Function

End Class
