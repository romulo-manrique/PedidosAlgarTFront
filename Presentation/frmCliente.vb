Imports Domain
Public Class frmCliente
    Dim ClienteModel As New ClienteModel()
    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListClientes()
        Panel1.Enabled = False
    End Sub

    Private Sub ListClientes()
        Try
            DGVClientes.DataSource = ClienteModel.GetClientes()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        DGVClientes.DataSource = ClienteModel.FindById(txtBuscar.Text)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Panel1.Enabled = True
        ClienteModel.state = EntityState.Added

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If DGVClientes.SelectedRows.Count > 0 Then
            Panel1.Enabled = True
            ClienteModel.Cedula = DGVClientes.CurrentRow.Cells(0).Value
            ClienteModel.state = EntityState.Modified

            txtCedula.Text = DGVClientes.CurrentRow.Cells(0).Value
            txtNombre.Text = DGVClientes.CurrentRow.Cells(1).Value
            txtApellido.Text = DGVClientes.CurrentRow.Cells(2).Value
            txtTelefono.Text = DGVClientes.CurrentRow.Cells(3).Value
        Else


        End If
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        If DGVClientes.SelectedRows.Count > 0 Then
            Panel1.Enabled = True
            ClienteModel.Cedula = DGVClientes.CurrentRow.Cells(0).Value
            ClienteModel.state = EntityState.Deleted

            Dim result = ClienteModel.SaveChanges()
            MessageBox.Show(result)
            ListClientes()
        Else


        End If
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        ClienteModel.Cedula = txtCedula.Text
        ClienteModel.NombreCliente = txtNombre.Text
        ClienteModel.ApellidoCliente = txtApellido.Text
        ClienteModel.TelefonoCliente = txtTelefono.Text

        Dim valid = New DataValidation(ClienteModel).validate()

        If valid = True Then
            Dim result = ClienteModel.SaveChanges()
            MessageBox.Show(result)
            ListClientes()
            Restart()


        End If
    End Sub

    Private Sub Restart()
        Panel1.Enabled = False
        txtCedula.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtTelefono.Clear()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Restart()
    End Sub
End Class
