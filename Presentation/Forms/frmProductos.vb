Imports Domain

Public Class frmProductos
    Dim ProductosModel As New ProductoModel
    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListProductos()
    End Sub

    Private Sub ListProductos()
        Try
            DGVProductos.DataSource = ProductosModel.GetProductos()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        DGVProductos.DataSource = ProductosModel.FindById(txtBuscar.Text)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Panel1.Enabled = True
        ProductosModel.state = EntityState.Added
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If DGVProductos.SelectedRows.Count > 0 Then
            Panel1.Enabled = True
            ProductosModel.idProducto = DGVProductos.CurrentRow.Cells(0).Value
            ProductosModel.state = EntityState.Modified

            txtId.Text = DGVProductos.CurrentRow.Cells(0).Value
            txtNombre.Text = DGVProductos.CurrentRow.Cells(1).Value
            txtValorUnitario.Text = DGVProductos.CurrentRow.Cells(2).Value
        Else

        End If
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        ProductosModel.idProducto = txtId.Text
        ProductosModel.NombreProducto = txtNombre.Text
        ProductosModel.valorUnitario = txtValorUnitario.Text

        Dim valid = New DataValidation(ProductosModel).validate()

        If valid = True Then
            Dim result = ProductosModel.SaveChanges()
            MessageBox.Show(result)
            ListProductos()
            Restart()

        End If
    End Sub

    Private Sub Restart()
        Panel1.Enabled = False
        txtId.Clear()
        txtNombre.Clear()
        txtValorUnitario.Clear()
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        If DGVProductos.SelectedRows.Count > 0 Then
            Panel1.Enabled = True
            ProductosModel.idProducto = DGVProductos.CurrentRow.Cells(0).Value
            ProductosModel.state = EntityState.Deleted

            Dim result = ProductosModel.SaveChanges()
            MessageBox.Show(result)
            ListProductos()
        Else

        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Restart()
    End Sub
End Class