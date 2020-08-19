Imports System.Data.SqlClient
Public Class Remisiones
    Dim bandera As Int16
    Dim ClaseModuloDeRemisiones As New ModuloDeClasesRemision 'Instancia clase ModuloDeClaseContrato

#Region "ComboBox"

    Private Sub CagarComboBox()
        Try
            Dim Producto As DataSet = SQLDataSET("SELECT CodProSer,NomProSer FROM [Datos catalogo de producservicios]")
            cboProducto.DataSource = Producto.Tables(0)
            cboProducto.DisplayMember = "NomProSer"
            cboProducto.ValueMember = "CodProSer"
            cboCodigoProducto.DataSource = Producto.Tables(0)
            cboCodigoProducto.DisplayMember = "CodProSer"
            cboCodigoProducto.ValueMember = "NomProSer"

            Dim Provedores As DataSet = SQLDataSET("select p.IdenProve, p.RazonSol
                                                    from [Datos proveedores] p inner join [Datos registros de contratos] r
                                                    on p.IdenProve = r.NumDocContra
                                                    and p.TipoDocu = r.TipDocContra
                                                    and p.SucurProv = r.CodSucContra
                                                    where p.HabilPro = 1
                                                    group by p.IdenProve, p.RazonSol
                                                    ")
            cboProvedores.DataSource = Provedores.Tables(0)
            cboProvedores.DisplayMember = "RazonSol"
            cboProvedores.ValueMember = "IdenProve"



        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "En la funcion CargarComboBox" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cboProvedores_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboProvedores.SelectedIndexChanged
        LimpiarCampos()

        If bandera = 1 Then
            CargarDataGridContratos(cboProvedores.SelectedValue)
            MostrasDatosCliente(cboProvedores.SelectedValue)
        End If
    End Sub

#End Region

#Region "Datagridview"

    Private Sub DataGridViewDetalleRemision_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewDetalleRemision.SelectionChanged
        If DataGridViewDetalleRemision.SelectedCells.Count <> 0 Then

            cboCodigoProducto.Text = DataGridViewDetalleRemision.SelectedCells(1).Value.ToString()
            txtConcepto.Text = DataGridViewDetalleRemision.SelectedCells(3).Value.ToString()
            txtCantidad.Text = DataGridViewDetalleRemision.SelectedCells(4).Value.ToString()
            txtValorUnitrio.Text = DataGridViewDetalleRemision.SelectedCells(5).Value.ToString()
            txtValorUniIva.Text = DataGridViewDetalleRemision.SelectedCells(6).Value.ToString()
            txtTotal.Text = DataGridViewDetalleRemision.SelectedCells(7).Value.ToString()

        End If
    End Sub

    Private Sub DataGridDetalleCuotas_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridDetalleCuotas.CellMouseClick
        DataGridViewDetalleRemision.Rows.Clear()
        Try
            Dim codigo As String = DataGridDetalleCuotas.SelectedCells.Item(0).Value 'OPtenemos el item del contrato
            Dim estado As Boolean = DataGridDetalleCuotas.SelectedCells.Item(4).Value 'Obtenemos el estado de pago de la cuota

            If estado = True Then

                MsgBox("Esta cuota ya esta facturada, no podras modificarla")
                btnFacturar.Enabled = False
                GroupModi.Visible = False
                GroupRegis.Visible = False
                btnaAgregarFila.Enabled = False
                btnEliminar.Enabled = False
                Dim reader As SqlDataReader
                reader = SQLReader("SELECT DTR.NumRemi, DC.ID_Contratos, DC.CuotaNoPac, DC.ValTolCuota, DF.FecAperRemi, DF.FecCieRemi, DF.HorAperRemi, DF.RemiActiva,
                                    DTR.ItemNum, DTR.CodProSer, DTR.Concepto, DTR.CantDeta, DTR.ValUniDeta, DTR.ValIVADeta
                                    FROM [Datos detalle de remisiones] as dtr, [Datos remisiones de facturas] df, [Datos detalles de cuotas contratos] as dc 
                                    where dc.CuotaNoPac = '" & codigo & "'
                                    and dc.ID_Contratos = '" & txtIdContrato.Text & "'
                                    and dc.ID_Contratos = df.ID_Contratos
                                    and df.NumRemi = dtr.NumRemi
                                    and  DF.CuotNum = '" & codigo & "'")

                If reader.HasRows = False Then
                    MsgBox("No se efectuaron filas")
                    Me.DataGridDetalleCuotas.Rows.Clear()
                    Exit Sub
                Else


                    While reader.Read()
                        txtNumRemision.Text = reader("NumRemi")
                        txtIdContrato.Text = reader("ID_Contratos")
                        txtNumeroDeCouta.Text = reader![ItemNum]
                        txtTotalCuota.Text = reader("ValTolCuota")
                        ftAperturaRemision.Value = reader("FecAperRemi")
                        ftCierreRemision.Value = reader("FecCieRemi")

                        If reader("RemiActiva") = True Then
                            cboActivaRemicion.SelectedIndex = 1
                        Else
                            cboActivaRemicion.SelectedIndex = 0
                        End If
                        DataGridViewDetalleRemision.Rows.Add(New String() {reader("ItemNum"), reader("CodProSer"), "", reader("Concepto"), reader("CantDeta"), reader("ValUniDeta"), reader("ValIVADeta"), reader("ValTolCuota")})
                    End While
                    cn.Close()
                End If

            Else
                btnaAgregarFila.Enabled = True

                Dim CuotasPagadas As Int32 = 0

                Dim Fila As DataGridViewRow = New DataGridViewRow()
                For Each Fila In DataGridDetalleCuotas.Rows
                    If Fila.Cells("EstadoPagado").Value = True Then
                        CuotasPagadas += 1
                    End If
                Next

                If codigo > CuotasPagadas + 1 Then
                    MsgBox("No puedes crear la remision de esta cuota sin antes facturar la cuota numero: " & (CuotasPagadas + 1) & " ")
                    btnFacturar.Enabled = False
                    GroupModi.Visible = False
                    GroupRegis.Visible = False
                    btnaAgregarFila.Enabled = False
                    LimpiarCampos()
                Else
                    Dim reader2 As SqlDataReader
                    reader2 = SQLReader("SELECT DTR.NumRemi, DC.ID_Contratos, DC.CuotaNoPac, DC.ValTolCuota, DF.FecAperRemi, DF.FecCieRemi, DF.HorAperRemi, DF.RemiActiva,
                                    DTR.ItemNum, DTR.CodProSer, DTR.Concepto, DTR.CantDeta, DTR.ValUniDeta, DTR.ValIVADeta, DF.CuotNum
                                    FROM [Datos detalle de remisiones] as dtr, [Datos remisiones de facturas] df, [Datos detalles de cuotas contratos] as dc 
                                    where dc.CuotaNoPac = '" & codigo & "'
                                    and dc.ID_Contratos = '" & txtIdContrato.Text & "'
                                    and dc.ID_Contratos = df.ID_Contratos
                                    and df.NumRemi = dtr.NumRemi
                                    and  DF.CuotNum = '" & codigo & "'")

                    If reader2.HasRows = False Then
                        cn.Close()
                        Dim dc As SqlDataReader

                        dc = SQLReader("Select dtc.PorCuoPac, dtc.CuotaNoPac, dtc.ValTolCuota from [Datos registros de contratos] as dr, [Datos detalles de cuotas contratos] as dtc  where dtc.ID_Contratos = dr.ID_Contratos and dr.NumDocContra = '" & txtIdentificacion.Text & "' and dr.ID_Contratos = '" & txtIdContrato.Text & "'  and dtc.CuotaNoPac = " & codigo & "")
                        If dc.HasRows = False Then
                            MsgBox("No se encontraron registros de esta cuota")
                        Else
                            MsgBox("Registraras un nueva remisión")
                            GroupModi.Visible = False
                            GroupRegis.Visible = True
                            btnFacturar.Enabled = False
                            txtNumeroDeCouta.Text = CuotasPagadas + 1
                            dc.Read()
                            txtValorUnitrio.Text = (dc![ValTolCuota] / 1.19)
                            txtValorUniIva.Text = (Convert.ToDouble(txtValorUnitrio.Text) * 0.19)
                            txtTotal.Text = Convert.ToDouble(txtValorUnitrio.Text) + Convert.ToDouble(txtValorUniIva.Text)
                            txtTotalCuota.Text = DataGridDetalleCuotas.SelectedCells.Item(3).Value
                            txtNumeroDeCouta.Text = CuotasPagadas + 1
                            txtCantidad.Text = 1
                        End If

                    Else
                        MsgBox("Esta cuota ya tiene una remision cargada, podras modificarla o eliminarla")
                        GroupModi.Visible = True
                        GroupRegis.Visible = False
                        btnEliminar.Enabled = True
                        btnFacturar.Enabled = True
                        While reader2.Read()
                            txtNumRemision.Text = reader2("NumRemi")
                            txtIdContrato.Text = reader2("ID_Contratos")
                            txtNumeroDeCouta.Text = reader2![CuotNum]
                            txtTotalCuota.Text = reader2("ValTolCuota")
                            ftAperturaRemision.Value = reader2("FecAperRemi")
                            ftCierreRemision.Value = reader2("FecCieRemi")
                            If reader2("RemiActiva") = True Then
                                cboActivaRemicion.SelectedIndex = 1
                            Else
                                cboActivaRemicion.SelectedIndex = 0
                            End If
                            DataGridViewDetalleRemision.Rows.Add(New String() {reader2("ItemNum"), reader2("CodProSer"), "", reader2("Concepto"), reader2("CantDeta"), reader2("ValUniDeta"), reader2("ValIVADeta"), reader2("ValTolCuota")})
                        End While
                        cn.Close()
                    End If

                End If

            End If


        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "En la evento cell mouse click en el datagrid detalle cuotas" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Close()
        End Try

    End Sub

    Private Function CagarDetallesCuotas(ID_Contratos) As Boolean
        DataGridDetalleCuotas.AutoGenerateColumns = False
        DataGridDetalleCuotas.DataSource = Nothing
        DataGridDetalleCuotas.Rows.Clear()
        Try
            Dim reader As SqlDataReader
            reader = SQLReader("Select CuotaNoPac,PorCuoPac, ValTolCuota, FecPacPag, FacturCuota From [Datos detalles de cuotas contratos] WHERE ID_Contratos = '" & txtIdContrato.Text & "' ")

            If reader.HasRows Then
                While reader.Read()
                    Me.DataGridDetalleCuotas.Rows.Add(reader("CuotaNoPac"), reader("FecPacPag"), reader("PorCuoPac"), reader("ValTolCuota"), reader("FacturCuota"))
                End While
            Else
                Me.DataGridDetalleCuotas.Rows.Clear()
            End If
            reader.Close()
            reader = Nothing
            cn.Close()
            Return True
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la funcion cargar detalles cuotas." & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function 'Carga detalles de cuotas desde la base de datos

    Public Sub CargarDataGridContratos(id)
        Try
            If id.ToString <> Nothing Then
                Dim consulta As String
                consulta = "Select dgc.ID_Contratos, dgc.TipDocContra, dgc.NumDocContra,  dp.RazonSol, dtc.NomTipCon FROM [Datos registros de contratos] as dgc, [Datos proveedores] as dp,  [Datos tipos de contratos] as dtc
                        WHERE dgc.NumDocContra = dp.IdenProve and dgc.TipoContra = dtc.CodTipCon and dp.IdenProve = '" & id.ToString & "' and EstaVigCon = 1 "
                bandera = 0
                DataGridContratos.DataSource = DataTable(consulta)
                bandera = 1
            Else
                MsgBox("No se le encontraron contratos a este registro")
            End If

        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "al cargar el datagrid contratos" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub 'Funcion que envia a listar

    Private Sub DataGridContratos_CurrentCellChanged(sender As Object, e As EventArgs) Handles DataGridContratos.CurrentCellChanged
        Try
            If bandera = 1 Then
                Dim codigo As String = DataGridContratos.SelectedCells.Item(0).Value
                MostrarTexbox(codigo)
            End If
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "En la evento CurrentCellChanged en el datagrid contratos" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub 'Ejecuta la funcion mostrar cada vez que cambia el datagridview



#End Region

#Region "botones t texbox"

    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
        If ValidacionDeCampos() Then
            If ValidarCamposAñadirDetalle() Then
                If MsgBox("Se facturara esta remision ¿Esta seguro?", vbYesNo) = vbYes Then

                    Dim concecutivoFactura As String = CreaConsecutivo("03", True, 2)

                    If String.IsNullOrWhiteSpace(concecutivoFactura) Then
                        Exit Sub
                    Else
                        Dim Prefijo As String = Mid(concecutivoFactura, 1, 2)
                        Dim fecha As Date = Date.Now
                        Dim FechaFinal As Date = Date.Now.AddDays(30)

                        ClaseModuloDeRemisiones.FacturarRemision(Prefijo, concecutivoFactura, txtNumRemision.Text, fecha, Format(FechaFinal, "yyyy/MM/dd"), txtTipoDocu.Text, txtIdentificacion.Text, txtSucursal.Text, txtValorUnitrio.Text, 0, txtValorUniIva.Text,
                                            0, 0, 0, 0, fecha, "Sinresolucion", txtCodRegis.Text, ftRegis.Value, txtIdContrato.Text, txtNumeroDeCouta.Text)

                        CagarDetallesCuotas(txtIdContrato.Text)

                    End If
                End If
            End If
        End If
    End Sub 'Facturar

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim estado As Boolean = DataGridDetalleCuotas.SelectedCells.Item(4).Value 'Obtenemos el estado de pago de la cuota

        If estado = True Then
            MsgBox("No puedes eliminar esta remision porque ya ha sido facturada")
        Else
            If MsgBox("Eliminaras este remision. ¿Estas de acuerdo?", vbYesNo) = vbYes Then
                ClaseModuloDeRemisiones.EliminarRemision(txtNumRemision.Text, txtNumeroDeCouta.Text, txtIdContrato.Text)
            End If
        End If

    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Try

            If String.IsNullOrWhiteSpace(txtNumRemision.Text) Then

                If ValidacionDeCampos() = True And ValidarTotal() = True Then
                    If MsgBox("Se generara un consecutivo. ¿Estas de acuerdo?", vbYesNo) = vbYes Then
                        Dim concecutivo As String = CreaConsecutivo("02", True, 2)
                        txtNumRemision.Text = concecutivo

                        Dim hora As String = Now.ToString("HH:mm:ss")
                        If String.IsNullOrWhiteSpace(txtNumRemision.Text) Then
                            MsgBox("No se cargo el concecutivo")
                        Else
                            ClaseModuloDeRemisiones.ModuloRemision(txtNumRemision.Text, txtIdContrato.Text, ftAperturaRemision.Value, hora, cboActivaRemicion.SelectedIndex, txtNumeroDeCouta.Text, ftCierreRemision.Value, txtCodRegis.Text, ftRegis.Value, txtCodModi.Text, ftModi.Value, DataGridViewDetalleRemision)
                            CagarDetallesCuotas(txtIdContrato.Text)
                            btnFacturar.Enabled = True
                        End If
                    End If
                End If
            Else
                Dim estado As Boolean = DataGridDetalleCuotas.SelectedCells.Item(4).Value 'Obtenemos el estado de pago de la cuota
                If estado = True Then
                    MsgBox("No podras modificar esta remision porque ya fue facturara")
                Else
                    If ValidacionDeCampos() = True And ValidarTotal() = True Then
                        Dim hora As String = Now.ToString("HH:mm:ss")
                        ClaseModuloDeRemisiones.ModuloRemision(txtNumRemision.Text, txtIdContrato.Text, ftAperturaRemision.Value, hora, cboActivaRemicion.SelectedIndex, txtNumeroDeCouta.Text, ftCierreRemision.Value, txtCodRegis.Text, ftRegis.Value, txtCodModi.Text, ftModi.Value, DataGridViewDetalleRemision)
                        CagarDetallesCuotas(txtIdContrato.Text)
                        btnFacturar.Enabled = True
                    End If
                End If
            End If


        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en el boton guardar Remision" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub  'Genera Concecutivo

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarCampos()
    End Sub

    Private Sub txtValorUnitrio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtValorUnitrio.KeyDown
        Try
            Select Case e.KeyData
                Case Keys.Enter
                    If String.IsNullOrWhiteSpace(txtCantidad.Text) Or String.IsNullOrWhiteSpace(txtValorUnitrio.Text) Then
                        MsgBox("Te falta rellenar alguno de estos campos: Cantidad, Valor Unitario o Valor Iva")
                    Else
                        txtTotal.Clear()
                        Dim total As Double = Convert.ToDouble(txtValorUnitrio.Text) * Convert.ToDouble(txtCantidad.Text)
                        Dim TotalIVa As Double = total * 0.19
                        txtValorUniIva.Text = TotalIVa
                        txtTotal.Text = (TotalIVa + total)
                    End If
            End Select
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "En la evento keydown del campo total" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub 'Calcula el total con evento enter

    Private Sub txtNumRemision_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorUnitrio.KeyPress, txtValorUniIva.KeyPress, txtTotal.KeyPress, txtNumRemision.KeyPress, txtCantidad.KeyPress, cboCodigoProducto.KeyPress
        soloNumeros(e)
    End Sub 'Deja digitar solo numeros

    Private Sub btnaAgregarFila_Click(sender As Object, e As EventArgs) Handles btnaAgregarFila.Click
        Dim TotalGrillaDetalleRemision As Double
        Try
            If DataGridViewDetalleRemision.Rows.Count > 0 Then
                Dim fila As DataGridViewRow = New DataGridViewRow()
                For Each fila In DataGridViewDetalleRemision.Rows
                    TotalGrillaDetalleRemision += Convert.ToDouble(fila.Cells("Total").Value)
                Next
                If String.IsNullOrWhiteSpace(txtIdContrato.Text) Then
                    If ValidarCamposAñadirDetalle() Then
                        Dim NumItem As Int32 = DataGridViewDetalleRemision.Rows.Count
                        NumItem += 1
                        DataGridViewDetalleRemision.Rows.Add(New String() {NumItem, cboCodigoProducto.Text, cboProducto.Text, txtConcepto.Text, txtCantidad.Text, txtValorUnitrio.Text, txtValorUniIva.Text, txtTotal.Text})
                        TotalGrillaDetalleRemision = 0
                    End If
                Else
                    If TotalGrillaDetalleRemision >= Convert.ToDouble(txtTotal.Text) Then
                        MsgBox("No puedes agregar un valor mas alto que el total a pagar")
                        TotalGrillaDetalleRemision = 0
                        Exit Sub
                    End If
                End If
            Else
                Dim NumItem As Int32 = DataGridViewDetalleRemision.Rows.Count
                NumItem += 1
                If ValidarCamposAñadirDetalle() Then
                    DataGridViewDetalleRemision.Rows.Add(New String() {NumItem, cboCodigoProducto.Text, cboProducto.Text, txtConcepto.Text, txtCantidad.Text, txtValorUnitrio.Text, txtValorUniIva.Text, txtTotal.Text})
                    TotalGrillaDetalleRemision = 0
                End If
            End If
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "En la evento click del boton agregar" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub 'Agrega filas a datafrid detalle remision

    Private Sub BtnCerrarContratos_Click(sender As Object, e As EventArgs) Handles BtnCerrarContratos.Click
        Me.Dispose()
    End Sub

#End Region

#Region "Funciones "

    Private Function CreaConsecutivo(CodDocu As String, ActConse As Boolean, CodUsua As String) As String
        Dim Consecutivo As String = ConsecutivoDocumen(CodDocu, ActConse, CodUsua)
        Select Case Consecutivo
            Case "0"
                Informa = "Lo siento pero en esta base de datos no" & Chr(13) & Chr(10)
                Informa = Informa & "se encontro el registro consecutivo," & Chr(13) & Chr(10)
                MsgBox(Informa, vbExclamation, Titulo01)
                Consecutivo = 0
            Case "-3"
                Informa = "Lo siento pero en esta base de datos no" & Chr(13) & Chr(10)
                Informa = Informa & "se pueden registrar más facturas de ventas," & Chr(13) & Chr(10)
                Informa = Informa & "porque pasó la longitud permitida del código."
                MsgBox(Informa, vbExclamation, Titulo01)
                Consecutivo = 0

            Case "-2"
                Informa = "Lo siento pero en esta base de datos no se" & Chr(13) & Chr(10)
                Informa = Informa & "pueden registrar más más facturas de ventas, porque" & Chr(13) & Chr(10)
                Informa = Informa & "la fecha del último generado es mayor a la del sistema."
                MsgBox(Informa, vbExclamation, Titulo01)
                Consecutivo = 0
        End Select
        cn.Close()
        Return Consecutivo
    End Function

    Private Function ValidarTotal() As Boolean
        Dim TotalCuota As Double
        Dim Fila As DataGridViewRow = New DataGridViewRow()
        For Each Fila In DataGridViewDetalleRemision.Rows
            TotalCuota += Fila.Cells("Total").Value
        Next

        If String.IsNullOrWhiteSpace(txtTotalCuota.Text) Then
            MsgBox("Escoge una cuota a la cual se le puede realizar la remision.")
            Return False
        Else
            If TotalCuota > Convert.ToDouble(txtTotalCuota.Text) Then
                MsgBox("El total de los items de la tabla no puede ser mayor al total de la cuota")
                Return False
            Else
                Return True
            End If
        End If
    End Function

    Private Function ValidacionDeCampos() As Boolean
        Dim estado As Boolean = False

        If String.IsNullOrWhiteSpace(txtIdContrato.Text) Then
            MsgBox("El campo ID Contraro esta vacio")
            txtIdContrato.Select()
            estado = False
            Return estado
        Else
            estado = True
        End If
        If String.IsNullOrWhiteSpace(txtNumeroDeCouta.Text) Then
            MsgBox("El campo numero de cuota esta vacio")
            txtNumeroDeCouta.Select()
            estado = False
            Return estado
        Else
            estado = True
        End If
        If String.IsNullOrWhiteSpace(txtTotalCuota.Text) Then
            MsgBox("El campo total cuota esta vacio")
            txtTotalCuota.Select()
            estado = False
            Return estado
        Else
            estado = True
        End If

        If String.IsNullOrWhiteSpace(cboActivaRemicion.Text) Or cboActivaRemicion.SelectedIndex = -1 Then
            MsgBox("Escoge si la remision esta activa o no")
            cboActivaRemicion.Select()
            estado = False
            Return estado
        Else
            estado = True
        End If

        If ftCierreRemision.Value < ftAperturaRemision.Value Then
            MsgBox("No puedes registrar una fecha menor a la fecha de apertura")
            ftCierreRemision.Select()
            estado = False
            Return estado
        Else
            estado = True
        End If

        If DataGridViewDetalleRemision.Rows.Count() = 0 Then
            MsgBox("La tabla de detalles de remisiones esta vacia")
            DataGridViewDetalleRemision.Select()
            estado = False
            Return estado
        Else
            estado = True
        End If


        Return estado

    End Function

    Private Function ValidarCamposAñadirDetalle() As Boolean
        Dim estado As Boolean = False
        If (cboCodigoProducto.SelectedIndex < 0) Then
            MsgBox("Selecciona un producto")
            cboCodigoProducto.Select()
            estado = False
            Return estado
        End If

        If cboProducto.SelectedIndex < 0 Then
            MsgBox("Selecciona un codigo de producto")
            cboProducto.Select()
            estado = False
            Return estado
        End If
        If String.IsNullOrEmpty(txtConcepto.Text) Then
            MsgBox("El campo concepto esta vacio")
            txtConcepto.Select()
            estado = False
            Return estado
        Else
            estado = True
        End If
        If String.IsNullOrEmpty(txtCantidad.Text) Then
            MsgBox("El campo cantidad esta vacio")
            txtCantidad.Select()
            estado = False
            Return estado
        Else
            estado = True
        End If
        If String.IsNullOrEmpty(txtValorUnitrio.Text) Then
            MsgBox("El campo valor unitario esta vacio")
            txtValorUnitrio.Select()
            estado = False
            Return estado
        Else
            estado = True
        End If
        If String.IsNullOrEmpty(txtValorUniIva.Text) Then
            MsgBox("El campo valor unitario IVA esta vacio")
            txtValorUniIva.Select()
            estado = False
            Return estado
        Else
            estado = True
        End If
        If String.IsNullOrEmpty(txtTotal.Text) Then
            MsgBox("El campo valor total esta vacio")
            txtTotal.Select()
            estado = False
            Return estado
        Else
            estado = True
        End If

        Return estado
    End Function

    Private Sub MostrasDatosCliente(identificador)
        LimpiarCampos()
        GroupModi.Visible = False
        GroupRegis.Visible = True
        Try
            Dim dr As SqlDataReader
            Dim consulta As String = "SELECT * FROM [Datos Proveedores] where IdenProve = '" & identificador.ToString & "' "

            dr = SQLReader(consulta)

            If dr.HasRows = False Then
                ' MsgBox("Este cliente no tiene contrato")
            Else
                dr.Read()

                txtTipoDocu.Text = dr("TipoDocu")
                txtIdentificacion.Text = dr("IdenProve")
                txtSucursal.Text = dr![SucurProv]
                txtRazonSocial.Text = dr![RazonSol]
                txtTelefono.Text = dr("TelProve1")
                txtEmail.Text = dr("DirElectro")


            End If
            cn.Close()

            ' CagarDetallesCuotas(identificador)

        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "En la funcion MostrarTexbox" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub MostrarTexbox(identificador)
        LimpiarCampos()
        Try
            Dim dr As SqlDataReader
            Dim consulta As String = "SELECT rc.ID_Contratos, rc.ContraNo, rc.TipDocContra, rc.NumDocContra, dp.DigVeri, dp.TelProve1, dp.DirElectro, dp.RazonSol, dp.SucurProv,  rc.NumPagos from [Datos registros de contratos] as rc, [Datos proveedores] as dp where rc.ID_Contratos = '" & identificador.ToString & "' and rc.NumDocContra = dp.IdenProve"

            dr = SQLReader(consulta)

            If dr.HasRows = False Then
                MsgBox("No se efectuaron filas")
            Else
                dr.Read()

                txtTipoDocu.Text = dr("TipDocContra")
                txtIdentificacion.Text = dr("NumDocContra")
                txtSucursal.Text = dr![SucurProv]
                txtRazonSocial.Text = dr![RazonSol]
                txtTelefono.Text = dr("TelProve1")
                txtEmail.Text = dr("DirElectro")
                txtIdContrato.Text = dr("ID_Contratos")


            End If
            cn.Close()

            CagarDetallesCuotas(identificador)

        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "En la funcion MostrarTexbox" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub LimpiarCampos()
        GroupModi.Visible = False
        GroupRegis.Visible = True
        txtTipoDocu.Clear()
        txtIdentificacion.Clear()
        txtSucursal.Clear()
        txtRazonSocial.Clear()
        txtTelefono.Clear()
        txtEmail.Clear()
        txtNumeroDeCouta.Clear()
        txtNumRemision.Clear()
        txtIdContrato.Clear()
        txtNumeroDeCouta.Clear()
        txtTotalCuota.Clear()
        cboActivaRemicion.SelectedIndex = 1
        cboCodigoProducto.SelectedIndex = 0
        cboProducto.SelectedIndex = 0
        txtCantidad.Clear()
        txtValorUnitrio.Clear()
        txtValorUniIva.Clear()
        txtTotal.Clear()
        txtConcepto.Clear()
        DataGridViewDetalleRemision.Rows.Clear()
        DataGridDetalleCuotas.Rows.Clear()
    End Sub 'Limpia los campos
#End Region



    Private Sub Remisiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bandera = 0
        Call conectarGeogebra()
        ' CargarDataGridContratos()
        CagarComboBox()
        For Each col As DataGridViewColumn In DataGridContratos.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next  'Desactiva que no pueda seleccionar las cabeceras del datagridview DataGridContratos 
        For Each col As DataGridViewColumn In DataGridDetalleCuotas.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next  'Desactiva que no pueda seleccionar las cabeceras del datagridview DataGridContratos 
        bandera = 1

        MostrasDatosCliente(cboProvedores.SelectedValue)

        CargarDataGridContratos(cboProvedores.SelectedValue)

        Dim codigo As String = DataGridContratos.SelectedCells.Item(0).Value
        MostrarTexbox(codigo)

    End Sub




End Class