Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess

Public Class ProductoRepository
    Inherits MasterRepository
    Implements IProductoRepository

    Private selectAll As String
    Private insert As String
    Private update As String
    Private delete As String
    Public Sub New()
        selectAll = "usp_listar_productos"
        insert = "usp_registrar_producto"
        update = "usp_modicar_producto"
        delete = "usp_borrar_producto"

    End Sub

    Public Function Add(entity As Producto) As Integer Implements IGenericReposotory(Of Producto).Add
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@nombreProducto", entity.nombreProducto))
        parameters.Add(New SqlParameter("@valorUnitario", entity.valorUnitario))
        Return ExecuteNonQuerySP(insert)
    End Function

    Public Function Edit(entity As Producto) As Integer Implements IGenericReposotory(Of Producto).Edit
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@idProducto", entity.idProducto))
        parameters.Add(New SqlParameter("@nombreProducto", entity.nombreProducto))
        parameters.Add(New SqlParameter("@valorUnitario", entity.valorUnitario))
        Return ExecuteNonQuerySP(update)
    End Function

    Private Function IGenericReposotory_GetAll() As IEnumerable(Of Producto) Implements IGenericReposotory(Of Producto).GetAll
        Dim resultTable = ExecuteReader(selectAll)
        Dim ListProductos As New List(Of Producto)

        For Each items As DataRow In resultTable.Rows
            ListProductos.Add(New Producto With {
                .idProducto = items(0),
                .nombreProducto = items(1),
                .valorUnitario = items(2)
            })
        Next

        Return ListProductos
    End Function

    Private Function IGenericReposotory_Remove(idProducto As String) As Integer Implements IGenericReposotory(Of Producto).Remove
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@idProducto", idProducto))

        Return ExecuteNonQuerySP(delete)
    End Function
End Class
