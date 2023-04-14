Imports DataAccess
Imports System.ComponentModel.DataAnnotations

Public Class ClienteModel
    Private _cedula As String
    Private _nombreCliente As String
    Private _apellidoCliente As String
    Private _telefonoCliente As String

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
End Class
