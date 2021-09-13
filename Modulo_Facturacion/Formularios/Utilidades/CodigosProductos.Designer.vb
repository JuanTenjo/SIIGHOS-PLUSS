<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CodigosProductos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridCodigosModulos = New System.Windows.Forms.DataGridView()
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clasificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValTarifa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorceIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodClasificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.BtnCerrarContratos = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPorceIVA = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNombreCodigo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtValorTarifa = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboClasificacion = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEliminarCodigo = New System.Windows.Forms.Button()
        Me.lblCodigoUsuario2 = New System.Windows.Forms.Label()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridCodigosModulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(484, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Listado Codigos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridCodigosModulos
        '
        Me.DataGridCodigosModulos.AllowUserToAddRows = False
        Me.DataGridCodigosModulos.AllowUserToDeleteRows = False
        Me.DataGridCodigosModulos.AllowUserToOrderColumns = True
        Me.DataGridCodigosModulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridCodigosModulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridCodigosModulos.BackgroundColor = System.Drawing.Color.White
        Me.DataGridCodigosModulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridCodigosModulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridCodigosModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridCodigosModulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cod, Me.NombreCod, Me.Clasificacion, Me.ValTarifa, Me.PorceIva, Me.CodClasificacion})
        Me.DataGridCodigosModulos.Location = New System.Drawing.Point(6, 39)
        Me.DataGridCodigosModulos.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridCodigosModulos.MultiSelect = False
        Me.DataGridCodigosModulos.Name = "DataGridCodigosModulos"
        Me.DataGridCodigosModulos.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridCodigosModulos.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridCodigosModulos.RowHeadersVisible = False
        Me.DataGridCodigosModulos.RowHeadersWidth = 51
        Me.DataGridCodigosModulos.RowTemplate.Height = 24
        Me.DataGridCodigosModulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridCodigosModulos.Size = New System.Drawing.Size(484, 385)
        Me.DataGridCodigosModulos.TabIndex = 112
        '
        'Cod
        '
        Me.Cod.FillWeight = 57.44576!
        Me.Cod.HeaderText = "Cod"
        Me.Cod.MaxInputLength = 5
        Me.Cod.MinimumWidth = 6
        Me.Cod.Name = "Cod"
        Me.Cod.ReadOnly = True
        '
        'NombreCod
        '
        Me.NombreCod.FillWeight = 196.5007!
        Me.NombreCod.HeaderText = "Nombre"
        Me.NombreCod.MinimumWidth = 6
        Me.NombreCod.Name = "NombreCod"
        Me.NombreCod.ReadOnly = True
        '
        'Clasificacion
        '
        Me.Clasificacion.FillWeight = 66.24203!
        Me.Clasificacion.HeaderText = "Clasificacion"
        Me.Clasificacion.MinimumWidth = 6
        Me.Clasificacion.Name = "Clasificacion"
        Me.Clasificacion.ReadOnly = True
        '
        'ValTarifa
        '
        Me.ValTarifa.FillWeight = 66.24203!
        Me.ValTarifa.HeaderText = "ValTarifa"
        Me.ValTarifa.MinimumWidth = 6
        Me.ValTarifa.Name = "ValTarifa"
        Me.ValTarifa.ReadOnly = True
        '
        'PorceIva
        '
        Me.PorceIva.FillWeight = 66.24203!
        Me.PorceIva.HeaderText = "PorceIva"
        Me.PorceIva.MinimumWidth = 6
        Me.PorceIva.Name = "PorceIva"
        Me.PorceIva.ReadOnly = True
        '
        'CodClasificacion
        '
        Me.CodClasificacion.HeaderText = "CodClasificacion"
        Me.CodClasificacion.MinimumWidth = 6
        Me.CodClasificacion.Name = "CodClasificacion"
        Me.CodClasificacion.ReadOnly = True
        Me.CodClasificacion.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNuevo.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = Global.Modulo_Facturacion.My.Resources.Resources.icons8_crear_nuevo_40
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(582, 333)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnNuevo.Size = New System.Drawing.Size(86, 47)
        Me.btnNuevo.TabIndex = 59
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNuevo.UseMnemonic = False
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'BtnCerrarContratos
        '
        Me.BtnCerrarContratos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCerrarContratos.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrarContratos.Image = Global.Modulo_Facturacion.My.Resources.Resources.IconoCERRAR40
        Me.BtnCerrarContratos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrarContratos.Location = New System.Drawing.Point(491, 332)
        Me.BtnCerrarContratos.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnCerrarContratos.Name = "BtnCerrarContratos"
        Me.BtnCerrarContratos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnCerrarContratos.Size = New System.Drawing.Size(90, 47)
        Me.BtnCerrarContratos.TabIndex = 113
        Me.BtnCerrarContratos.Text = "Cerrar"
        Me.BtnCerrarContratos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCerrarContratos.UseMnemonic = False
        Me.BtnCerrarContratos.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnActualizar.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Image = Global.Modulo_Facturacion.My.Resources.Resources.IconActualizar
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.Location = New System.Drawing.Point(672, 332)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnActualizar.Size = New System.Drawing.Size(97, 47)
        Me.btnActualizar.TabIndex = 114
        Me.btnActualizar.Text = "Act"
        Me.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnActualizar.UseMnemonic = False
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.TxtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtPorceIVA)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtNombreCodigo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtValorTarifa)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboClasificacion)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(498, 39)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(373, 258)
        Me.GroupBox1.TabIndex = 116
        Me.GroupBox1.TabStop = False
        '
        'TxtCodigo
        '
        Me.TxtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodigo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.Location = New System.Drawing.Point(8, 24)
        Me.TxtCodigo.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCodigo.MaxLength = 5
        Me.TxtCodigo.Multiline = True
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(363, 21)
        Me.TxtCodigo.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(2, 24)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 21)
        Me.Label5.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Location = New System.Drawing.Point(4, 7)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 14)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Codigo"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPorceIVA
        '
        Me.txtPorceIVA.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorceIVA.Location = New System.Drawing.Point(9, 224)
        Me.txtPorceIVA.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPorceIVA.MaxLength = 2
        Me.txtPorceIVA.Multiline = True
        Me.txtPorceIVA.Name = "txtPorceIVA"
        Me.txtPorceIVA.Size = New System.Drawing.Size(362, 21)
        Me.txtPorceIVA.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(3, 224)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(8, 21)
        Me.Label12.TabIndex = 20
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label13.Location = New System.Drawing.Point(5, 207)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 14)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Porce IVA"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombreCodigo
        '
        Me.txtNombreCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreCodigo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCodigo.Location = New System.Drawing.Point(9, 69)
        Me.txtNombreCodigo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreCodigo.MaxLength = 150
        Me.txtNombreCodigo.Multiline = True
        Me.txtNombreCodigo.Name = "txtNombreCodigo"
        Me.txtNombreCodigo.Size = New System.Drawing.Size(362, 21)
        Me.txtNombreCodigo.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(3, 69)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(8, 21)
        Me.Label6.TabIndex = 17
        '
        'txtValorTarifa
        '
        Me.txtValorTarifa.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTarifa.Location = New System.Drawing.Point(9, 170)
        Me.txtValorTarifa.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValorTarifa.MaxLength = 15
        Me.txtValorTarifa.Multiline = True
        Me.txtValorTarifa.Name = "txtValorTarifa"
        Me.txtValorTarifa.Size = New System.Drawing.Size(362, 21)
        Me.txtValorTarifa.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(3, 170)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(8, 21)
        Me.Label3.TabIndex = 15
        '
        'cboClasificacion
        '
        Me.cboClasificacion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClasificacion.FormattingEnabled = True
        Me.cboClasificacion.Location = New System.Drawing.Point(8, 118)
        Me.cboClasificacion.Margin = New System.Windows.Forms.Padding(2)
        Me.cboClasificacion.Name = "cboClasificacion"
        Me.cboClasificacion.Size = New System.Drawing.Size(362, 22)
        Me.cboClasificacion.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(3, 101)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 14)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Clasificacion"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(1, 118)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(10, 22)
        Me.Label9.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(5, 153)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 14)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Valor Tarifa"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(5, 52)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 14)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Nombre"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnGuardar
        '
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGuardar.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.Modulo_Facturacion.My.Resources.Resources.IconoGuardar
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(672, 332)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnGuardar.Size = New System.Drawing.Size(97, 47)
        Me.btnGuardar.TabIndex = 117
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseMnemonic = False
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnEliminarCodigo
        '
        Me.btnEliminarCodigo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEliminarCodigo.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarCodigo.Image = Global.Modulo_Facturacion.My.Resources.Resources.icons8_eliminar_40
        Me.btnEliminarCodigo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarCodigo.Location = New System.Drawing.Point(773, 332)
        Me.btnEliminarCodigo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEliminarCodigo.Name = "btnEliminarCodigo"
        Me.btnEliminarCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnEliminarCodigo.Size = New System.Drawing.Size(98, 47)
        Me.btnEliminarCodigo.TabIndex = 132
        Me.btnEliminarCodigo.Text = "Eliminar"
        Me.btnEliminarCodigo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEliminarCodigo.UseMnemonic = False
        Me.btnEliminarCodigo.UseVisualStyleBackColor = True
        '
        'lblCodigoUsuario2
        '
        Me.lblCodigoUsuario2.AutoSize = True
        Me.lblCodigoUsuario2.Location = New System.Drawing.Point(819, 407)
        Me.lblCodigoUsuario2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodigoUsuario2.Name = "lblCodigoUsuario2"
        Me.lblCodigoUsuario2.Size = New System.Drawing.Size(49, 13)
        Me.lblCodigoUsuario2.TabIndex = 136
        Me.lblCodigoUsuario2.Text = "CODIGO"
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Location = New System.Drawing.Point(549, 407)
        Me.lblNombreUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(124, 13)
        Me.lblNombreUsuario.TabIndex = 135
        Me.lblNombreUsuario.Text = "NOMBRE DE USUARIO"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(772, 407)
        Me.Label45.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(43, 13)
        Me.Label45.TabIndex = 134
        Me.Label45.Text = "Codigo:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(499, 407)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 13)
        Me.Label16.TabIndex = 133
        Me.Label16.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Teal
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(495, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(376, 25)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Informacion"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CodigosProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 432)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCodigoUsuario2)
        Me.Controls.Add(Me.btnEliminarCodigo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblNombreUsuario)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.BtnCerrarContratos)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.DataGridCodigosModulos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "CodigosProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GESTION PRODUCTOS Y SERVICIOS"
        CType(Me.DataGridCodigosModulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridCodigosModulos As DataGridView
    Friend WithEvents btnNuevo As Button
    Friend WithEvents BtnCerrarContratos As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNombreCodigo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtValorTarifa As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboClasificacion As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPorceIVA As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEliminarCodigo As Button
    Friend WithEvents lblCodigoUsuario2 As Label
    Friend WithEvents lblNombreUsuario As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Cod As DataGridViewTextBoxColumn
    Friend WithEvents NombreCod As DataGridViewTextBoxColumn
    Friend WithEvents Clasificacion As DataGridViewTextBoxColumn
    Friend WithEvents ValTarifa As DataGridViewTextBoxColumn
    Friend WithEvents PorceIva As DataGridViewTextBoxColumn
    Friend WithEvents CodClasificacion As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
End Class
