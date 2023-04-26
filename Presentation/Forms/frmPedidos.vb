Imports System.Net
Imports System.Text
Imports DataAccess
Imports Domain
Imports Newtonsoft.Json
Public Class frmPedidos
    Dim ClienteModel As New ClienteModel
    Dim ProductoModel As New ProductoModel
    Dim PedidoEncabezado As New PedidoEModel
    Dim PedidoDetalle As New PedidoDModel
    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Dim obj As List(Of Cliente) = ClienteModel.FindById(txtCedula.Text)

        txtNombreCliente.Text = obj(0).nombreCliente
        txtTelefono.Text = obj(0).telefonoCliente
    End Sub
    Private Sub frmPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListPedidos()
    End Sub
    Private Sub LoadCliente()

    End Sub
    Private Sub btnBuscaProducto_Click(sender As Object, e As EventArgs) Handles btnBuscaProducto.Click
        Dim obj As List(Of Producto) = ProductoModel.FindById(txtCodigoProducto.Text)

        txtNombreProducto.Text = obj(0).nombreProducto
        txtValorUnitario.Text = obj(0).valorUnitario

    End Sub

    Private Sub btnAgregaProducto_Click(sender As Object, e As EventArgs) Handles btnAgregaProducto.Click
        DGVProductos.Rows.Add(txtCodigoProducto.Text, txtNombreProducto.Text, txtValorUnitario.Text, txtCantidad.Text, (txtValorUnitario.Text * txtCantidad.Text))
        calculaCantidadMonto()
        RestartProducto()

    End Sub

    Private Sub RestartProducto()
        txtCodigoProducto.Clear()
        txtNombreProducto.Clear()
        txtValorUnitario.Clear()
    End Sub

    Private Sub calculaCantidadMonto()

        lblMonto.Text = 0
        lblCantidad.Text = 0
        Dim I As Integer = 0
        For Each Fila As DataGridViewRow In DGVProductos.Rows
            I += 1

            If Not Fila Is Nothing Then

                If (I < DGVProductos.Rows.Count) Then
                    lblCantidad.Text += Integer.Parse(Fila.Cells("Cantidad").Value)
                    lblMonto.Text += Decimal.Parse(Fila.Cells("Precio").Value)
                End If
            End If
        Next

    End Sub

    Private Sub btnGuardaPedido_Click(sender As Object, e As EventArgs) Handles btnGuardaPedido.Click
        If DGVProductos.Rows.Count > 0 Then

            PedidoEncabezado.Cedula = txtCedula.Text
            PedidoEncabezado.Fecha = Now.Date
            PedidoEncabezado.Direcion = TxtDireccionDespacho.Text
            PedidoEncabezado.PrecioTotal = 0

            Dim valid = New DataValidation(PedidoEncabezado).validate()
            Dim I As Integer = 0
            If valid = True Then
                Dim result = PedidoEncabezado.SaveChanges()
                If result > 0 Then
                    For Each Fila As DataGridViewRow In DGVProductos.Rows
                        If Not Fila Is Nothing Then
                            I += 1
                            If I < DGVProductos.Rows.Count Then
                                With PedidoDetalle
                                    .IdProducto = Fila.Cells("Codigo").Value
                                    .Cantidad = Fila.Cells("Cantidad").Value
                                    .ValorUnitario = Fila.Cells("Precio").Value

                                    Dim resultDetalle = .SaveChanges()
                                End With
                            End If
                        End If
                    Next
                End If

                MessageBox.Show(result)
                ListPedidos()
                Restart()
            End If
        End If
    End Sub

    Private Sub Restart()
        PedidoEncabezado.state = EntityState.Added
        PedidoDetalle.state = EntityState.Added

        txtCantidad.Clear()
        txtCedula.Clear()
        txtNombreCliente.Clear()
        txtTelefono.Clear()
        txtCodigoProducto.Clear()
        txtNombreProducto.Clear()
        TxtDireccionDespacho.Clear()

        DGVProductos.Rows.Clear()

    End Sub

    Private Async Sub ListPedidos()

        Dim c As New Producto
        Dim RestURL As String = "http://localhost:44399/api/Ventas"
        Dim client As New Http.HttpClient

        Dim RestResponse As Http.HttpResponseMessage = Await client.GetAsync(RestURL)

        Dim OK = RestResponse.StatusCode.ToString
        Dim respuesta = RestResponse.Content.ReadAsStringAsync
        Dim Tabla As DataTable = JsonConvert.DeserializeObject(Of DataTable)(respuesta.Result())
        DGVPedidos.DataSource = Tabla


    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        PedidoEncabezado.state = EntityState.Added
        PedidoDetalle.state = EntityState.Added
        Restart()

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If DGVPedidos.SelectedRows.Count > 0 Then

            PedidoEncabezado.state = EntityState.Modified
            PedidoDetalle.state = EntityState.Modified

            PedidoEncabezado.IdPedido = DGVPedidos.CurrentRow.Cells("idPedido").Value.ToString()
            PedidoDetalle.IdPedido = DGVPedidos.CurrentRow.Cells("idPedido").Value.ToString()

            Dim obj As List(Of Cliente) = ClienteModel.FindById(DGVPedidos.CurrentRow.Cells("cedula").Value)

            txtCedula.Text = obj(0).cedula
            txtNombreCliente.Text = obj(0).nombreCliente
            txtTelefono.Text = obj(0).telefonoCliente

            Dim obj2 As List(Of PedidoE) = PedidoEncabezado.FindById(DGVPedidos.CurrentRow.Cells("idPedido").Value.ToString())
            TxtDireccionDespacho.Text = obj2(0).direccion.ToString()

            Dim obj3 As List(Of PedidoD) = PedidoDetalle.FindById(DGVPedidos.CurrentRow.Cells("idPedido").Value.ToString())

            Dim ListPedidosD As New List(Of PedidoD)

            For Each items As PedidoD In obj3
                DGVProductos.Rows.Add(items.idProducto, String.Empty, items.valorUnitario, items.cantidad, (items.valorUnitario * items.cantidad))
            Next

            calculaCantidadMonto()
        End If

    End Sub
    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        If DGVPedidos.SelectedRows.Count > 0 Then
            PedidoEncabezado.state = EntityState.Deleted
            PedidoDetalle.state = EntityState.Deleted

            PedidoEncabezado.IdPedido = DGVPedidos.CurrentRow.Cells(0).Value
            PedidoDetalle.IdPedido = DGVPedidos.CurrentRow.Cells(0).Value

            Dim result = PedidoDetalle.SaveChanges()
            Dim result2 = PedidoEncabezado.SaveChanges()

            MessageBox.Show(result2)
            ListPedidos()
            RestartProducto()

        Else


        End If

    End Sub
End Class