Imports DataAccess
Imports System.ComponentModel.DataAnnotations

Public Class ClienteModel
    Private _cedula As String
    Private _nombreCliente As String
    Private _apellidoCliente As String
    Private _telefonoCliente As String

    Private state As EntityState

    Private Repository As IClienteRepository

    <Required(ErrorMessage:="Campo Cédula es Obligatorio")>
    <StringLength(20, MinimumLength:=10, ErrorMessage:="Valor mínimo de caracteres es 10 máximo es 20 de longitud")>
    Public Property Cedula As String
        Get
            Return _cedula
        End Get
        Set(value As String)
            _cedula = value
        End Set
    End Property
    <Required>
    <StringLength(50, MinimumLength:=10, ErrorMessage:="Valor mínimo de caracteres es 10 máximo es 20 de longitud")>
    Public Property NombreCliente As String
        Get
            Return _nombreCliente
        End Get
        Set(value As String)
            _nombreCliente = value
        End Set
    End Property
    <Required>
    <StringLength(50, MinimumLength:=10, ErrorMessage:="Valor mínimo de caracteres es 10 máximo es 20 de longitud")>
    Public Property ApellidoCliente As String
        Get
            Return _apellidoCliente
        End Get
        Set(value As String)
            _apellidoCliente = value
        End Set
    End Property
    <Required>
    Public Property TelefonoCliente As String
        Get
            Return _telefonoCliente
        End Get
        Set(value As String)
            _telefonoCliente = value
        End Set
    End Property

    Public Sub New()
        Repository = New ClienteRepository()

    End Sub

    Public Function SaveChanges() As String
        Dim message = Nothing

        Try
            Dim employedDataModel As New Cliente()

            employedDataModel.cedula = Cedula
            employedDataModel.nombreCliente = NombreCliente
            employedDataModel.apellidoCliente = ApellidoCliente
            employedDataModel.telefonoCliente = TelefonoCliente

            Select Case state
                Case EntityState.Added
                    Repository.Add(employedDataModel)
                    message = "Successfuly record "
                Case EntityState.Modified
                    Repository.Edit(employedDataModel)
                Case EntityState.Deleted
                    Repository.Remove(employedDataModel.cedula)
            End Select

        Catch ex As Exception
            message = ex.Message.ToString()
        End Try


        Return message
    End Function

    Public Function GetClientes() As List(Of Cliente)
        Dim ListClienteDataModel = Repository.GetAll()
        Dim ListClienteViewModel = New List(Of Cliente)

        For Each item As Cliente In ListClienteDataModel
            ListClienteViewModel.Add(New Cliente With {
                .cedula = item.cedula,
                .nombreCliente = item.nombreCliente,
                .apellidoCliente = item.apellidoCliente,
                .telefonoCliente = item.telefonoCliente
            })

        Next
        Return ListClienteViewModel
    End Function


End Class
