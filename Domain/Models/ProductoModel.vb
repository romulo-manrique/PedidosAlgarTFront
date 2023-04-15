Imports DataAccess
Imports System.ComponentModel.DataAnnotations

Public Class ProductoModel
    Private _idProducto As Integer
    Private _nombreProducto As String
    Private _valorUnitario As Decimal

    Public state As EntityState

    Private Repository As IProductoRepository

    Public Property idProducto As Integer
        Get
            Return _idProducto
        End Get
        Set(value As Integer)
            _idProducto = value
        End Set
    End Property
    <Required>
    <StringLength(50, MinimumLength:=10, ErrorMessage:="Valor mínimo de caracteres es 10 máximo es 20 de longitud")>
    Public Property NombreProducto As String
        Get
            Return _nombreProducto
        End Get
        Set(value As String)
            _nombreProducto = value
        End Set
    End Property
    <Required>
    Public Property valorUnitario As Decimal
        Get
            Return _valorUnitario
        End Get
        Set(value As Decimal)
            _valorUnitario = value
        End Set
    End Property

    Public Sub New()
        Repository = New ProductoRepository()

    End Sub

    Public Function SaveChanges() As String
        Dim message = Nothing

        Try
            Dim ProductoDataModel As New Producto()

            ProductoDataModel.idProducto = idProducto
            ProductoDataModel.nombreProducto = NombreProducto
            ProductoDataModel.valorUnitario = valorUnitario

            Select Case state
                Case EntityState.Added
                    Repository.Add(ProductoDataModel)
                    message = "Successfuly record "
                Case EntityState.Modified
                    Repository.Edit(ProductoDataModel)
                Case EntityState.Deleted
                    Repository.Remove(ProductoDataModel.idProducto)
            End Select

        Catch ex As Exception
            message = ex.Message.ToString()
        End Try
        Return message
    End Function

    Public Function GetProductos() As List(Of Producto)
        Dim ListProductoDataModel = Repository.GetAll()
        Dim ListProductoViewModel = New List(Of Producto)

        For Each item As Producto In ListProductoDataModel
            ListProductoViewModel.Add(New Producto With {
                .idProducto = item.idProducto,
                .nombreProducto = item.nombreProducto,
                .valorUnitario = item.valorUnitario
            })
        Next
        Return ListProductoViewModel
    End Function

    Public Function FindById(Filtrer As String) As IEnumerable(Of Producto)
        Return GetProductos().FindAll(Function(pro) pro.nombreProducto.Contains(Filtrer))
    End Function

End Class
