<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAgregaProducto = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBuscaProducto = New System.Windows.Forms.Button()
        Me.txtValorUnitario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGVProductos = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGuardaPedido = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.DGVPedidos = New System.Windows.Forms.DataGridView()
        Me.TxtDireccionDespacho = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGVProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGVPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscarCliente)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNombreCliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCedula)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(554, 155)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información Cliente"
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnBuscarCliente.ForeColor = System.Drawing.Color.White
        Me.btnBuscarCliente.Location = New System.Drawing.Point(401, 35)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(136, 54)
        Me.btnBuscarCliente.TabIndex = 6
        Me.btnBuscarCliente.Text = "Buscar Cliente"
        Me.btnBuscarCliente.UseVisualStyleBackColor = False
        '
        'txtTelefono
        '
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Location = New System.Drawing.Point(350, 116)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(191, 22)
        Me.txtTelefono.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(347, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Teléfono"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Enabled = False
        Me.txtNombreCliente.Location = New System.Drawing.Point(25, 117)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(309, 22)
        Me.txtNombreCliente.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(25, 56)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(225, 22)
        Me.txtCedula.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cédula"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAgregaProducto)
        Me.GroupBox2.Controls.Add(Me.txtCantidad)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btnBuscaProducto)
        Me.GroupBox2.Controls.Add(Me.txtValorUnitario)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtNombreProducto)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtCodigoProducto)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 173)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(554, 203)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pruductos"
        '
        'btnAgregaProducto
        '
        Me.btnAgregaProducto.BackColor = System.Drawing.Color.LightGreen
        Me.btnAgregaProducto.ForeColor = System.Drawing.Color.White
        Me.btnAgregaProducto.Location = New System.Drawing.Point(26, 121)
        Me.btnAgregaProducto.Name = "btnAgregaProducto"
        Me.btnAgregaProducto.Size = New System.Drawing.Size(511, 36)
        Me.btnAgregaProducto.TabIndex = 13
        Me.btnAgregaProducto.Text = "Agrega Producto al Pedido"
        Me.btnAgregaProducto.UseVisualStyleBackColor = False
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(450, 96)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(90, 22)
        Me.txtCantidad.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(447, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Cantidad"
        '
        'btnBuscaProducto
        '
        Me.btnBuscaProducto.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnBuscaProducto.ForeColor = System.Drawing.Color.White
        Me.btnBuscaProducto.Location = New System.Drawing.Point(401, 18)
        Me.btnBuscaProducto.Name = "btnBuscaProducto"
        Me.btnBuscaProducto.Size = New System.Drawing.Size(136, 54)
        Me.btnBuscaProducto.TabIndex = 10
        Me.btnBuscaProducto.Text = "Buscar Producto"
        Me.btnBuscaProducto.UseVisualStyleBackColor = False
        '
        'txtValorUnitario
        '
        Me.txtValorUnitario.Enabled = False
        Me.txtValorUnitario.Location = New System.Drawing.Point(350, 96)
        Me.txtValorUnitario.Name = "txtValorUnitario"
        Me.txtValorUnitario.Size = New System.Drawing.Size(74, 22)
        Me.txtValorUnitario.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(347, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Valor Unitario"
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Enabled = False
        Me.txtNombreProducto.Location = New System.Drawing.Point(26, 96)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(308, 22)
        Me.txtNombreProducto.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nombre"
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.Location = New System.Drawing.Point(26, 38)
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.Size = New System.Drawing.Size(225, 22)
        Me.txtCodigoProducto.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Código de Producto"
        '
        'DGVProductos
        '
        Me.DGVProductos.AllowUserToDeleteRows = False
        Me.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Producto, Me.Precio, Me.Cantidad, Me.Total})
        Me.DGVProductos.Location = New System.Drawing.Point(572, 12)
        Me.DGVProductos.Name = "DGVProductos"
        Me.DGVProductos.ReadOnly = True
        Me.DGVProductos.RowHeadersWidth = 51
        Me.DGVProductos.RowTemplate.Height = 24
        Me.DGVProductos.Size = New System.Drawing.Size(739, 155)
        Me.DGVProductos.TabIndex = 2
        '
        'Codigo
        '
        Me.Codigo.Frozen = True
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.MinimumWidth = 6
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 125
        '
        'Producto
        '
        Me.Producto.Frozen = True
        Me.Producto.HeaderText = "Producto"
        Me.Producto.MinimumWidth = 6
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        Me.Producto.Width = 125
        '
        'Precio
        '
        Me.Precio.Frozen = True
        Me.Precio.HeaderText = "Precio"
        Me.Precio.MinimumWidth = 6
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 125
        '
        'Cantidad
        '
        Me.Cantidad.Frozen = True
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 125
        '
        'Total
        '
        Me.Total.Frozen = True
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 6
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 125
        '
        'btnGuardaPedido
        '
        Me.btnGuardaPedido.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnGuardaPedido.ForeColor = System.Drawing.Color.White
        Me.btnGuardaPedido.Location = New System.Drawing.Point(572, 336)
        Me.btnGuardaPedido.Name = "btnGuardaPedido"
        Me.btnGuardaPedido.Size = New System.Drawing.Size(739, 40)
        Me.btnGuardaPedido.TabIndex = 7
        Me.btnGuardaPedido.Text = "Guardar Pedido"
        Me.btnGuardaPedido.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnNuevo)
        Me.GroupBox3.Controls.Add(Me.btnEditar)
        Me.GroupBox3.Controls.Add(Me.btnRemover)
        Me.GroupBox3.Controls.Add(Me.DGVPedidos)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 382)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1299, 295)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pedidos"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNuevo.Location = New System.Drawing.Point(1154, 260)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(141, 37)
        Me.btnNuevo.TabIndex = 19
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEditar.Location = New System.Drawing.Point(1007, 260)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(141, 37)
        Me.btnEditar.TabIndex = 18
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnRemover
        '
        Me.btnRemover.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRemover.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRemover.Location = New System.Drawing.Point(860, 260)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(141, 37)
        Me.btnRemover.TabIndex = 17
        Me.btnRemover.Text = "Remover"
        Me.btnRemover.UseVisualStyleBackColor = False
        '
        'DGVPedidos
        '
        Me.DGVPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPedidos.Location = New System.Drawing.Point(15, 35)
        Me.DGVPedidos.Name = "DGVPedidos"
        Me.DGVPedidos.RowHeadersWidth = 51
        Me.DGVPedidos.RowTemplate.Height = 24
        Me.DGVPedidos.Size = New System.Drawing.Size(1278, 219)
        Me.DGVPedidos.TabIndex = 9
        '
        'TxtDireccionDespacho
        '
        Me.TxtDireccionDespacho.Location = New System.Drawing.Point(572, 269)
        Me.TxtDireccionDespacho.Multiline = True
        Me.TxtDireccionDespacho.Name = "TxtDireccionDespacho"
        Me.TxtDireccionDespacho.Size = New System.Drawing.Size(739, 61)
        Me.TxtDireccionDespacho.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(581, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Dirección de Despacho"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(963, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 17)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Cantidad : "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(963, 201)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 17)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Monto : "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(1045, 173)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(28, 17)
        Me.lblCantidad.TabIndex = 14
        Me.lblCantidad.Text = "0 : "
        Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(1045, 201)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(16, 17)
        Me.lblMonto.TabIndex = 15
        Me.lblMonto.Text = "0"
        Me.lblMonto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1323, 736)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtDireccionDespacho)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnGuardaPedido)
        Me.Controls.Add(Me.DGVProductos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPedidos"
        Me.Text = "Pedidos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGVProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGVPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAgregaProducto As Button
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnBuscaProducto As Button
    Friend WithEvents txtValorUnitario As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCodigoProducto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DGVProductos As DataGridView
    Friend WithEvents btnGuardaPedido As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DGVPedidos As DataGridView
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnRemover As Button
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents TxtDireccionDespacho As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblMonto As Label
End Class
