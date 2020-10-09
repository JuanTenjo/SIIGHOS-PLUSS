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

            Dim Provedores As DataSet = SQLDataSET("select p.IdenProve, p.IdenProve + '  ' + p.RazonSol as DatosProve
                                                    from [Datos proveedores] p inner join [Datos registros de contratos] r
                                                    on p.IdenProve = r.NumDocContra
                                                    and p.TipoDocu = r.TipDocContra
                                                    and p.SucurProv = r.CodSucContra
                                                    where p.HabilPro = 1
                                                    group by p.IdenProve, p.RazonSol
                                                    ")
            cboProvedores.DataSource = Provedores.Tables(0)
            cboProvedores.DisplayMember = "DatosProve"
            cboProvedores.ValueMember = "IdenProve"

            Dim ResolucionesDeFacturas As DataSet = SQLDataSET("SELECT TexResol FROM [Datos resoluciones de facturacion]")
            cboResolucionFactura.DataSource = ResolucionesDeFacturas.Tables(0)
            cboResolucionFactura.DisplayMember = "TexResol"
            cboResolucionFactura.ValueMember = "TexResol"




        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "En la funcion CargarComboBox" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub  'Carga Combobox

    Private Sub cboProvedores_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboProvedores.SelectedIndexChanged
        Try
            LimpiarCampos()
            If bandera = 1 Then
                If String.IsNullOrWhiteSpace(cboProvedores.Text) Then
                Else
                    CargarDataGridContratos(cboProvedores.SelectedValue)
                    MostrasDatosCliente(cboProvedores.SelectedValue)
                End If
            End If
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en cbo de proveedores" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub 'Rellena campos cuando se cambia la opcion de ccboProvedoores

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
    End Sub  'Rellena los campos correspondientes cuando se selecciones una fila de el detalle de la remision

    Private Sub DataGridDetalleCuotas_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridDetalleCuotas.CellMouseClick
        DataGridViewDetalleRemision.Rows.Clear()
        Try
            Dim codigo As String = DataGridDetalleCuotas.SelectedCells.Item(0).Value 'OPtenemos el item del contrato
            Dim estado As Boolean = DataGridDetalleCuotas.SelectedCells.Item(4).Value 'Obtenemos el estado de pago de la cuota

            If estado = True Then   'Si la cuota ya fue facturada

                MsgBox("Esta cuota ya esta facturada, no podras modificarla")
                btnFacturar.Enabled = False
                btnaAgregarFila.Enabled = False
                btnEliminar.Enabled = False
                GroupRegis.Visible = True
                GroupModi.Visible = True
                Dim reader As SqlDataReader
                reader = SQLReader("SELECT DTR.NumRemi, DC.ID_Contratos, DC.CuotaNoPac, DC.ValTolCuota, DF.FecAperRemi, DF.FecCieRemi, DF.HorAperRemi, DF.RemiActiva,
                                    DTR.ItemNum, DTR.CodProSer, DTR.Concepto, DTR.CantDeta, DTR.ValUniDeta, DTR.ValIVADeta, df.CodRegis, df.FecRegis, df.CodModi, df.FecModi, dft.NumFact
                                    FROM [Datos detalle de remisiones] as dtr, [Datos remisiones de facturas] df, [Datos detalles de cuotas contratos] as dc, [Datos facturas realizadas] as dft 
                                    where dc.CuotaNoPac = '" & codigo & "'
                                    and dc.ID_Contratos = '" & txtIdContrato.Text & "'
                                    and dc.ID_Contratos = df.ID_Contratos
                                    and df.NumRemi = dtr.NumRemi
                                    and df.NumRemi = dft.NumRemi
                                    and  df.CuotNum = '" & codigo & "'")

                If reader.HasRows = False Then
                    MsgBox("No se efectuaron filas")
                    Me.DataGridDetalleCuotas.Rows.Clear()
                    Exit Sub
                Else


                    While reader.Read()
                        txtNumRemision.Text = reader("NumRemi")
                        txtIdContrato.Text = reader("ID_Contratos")
                        txtNumeroDeCouta.Text = reader("CuotaNoPac")
                        txtTotalCuota.Text = reader("ValTolCuota")
                        ftAperturaRemision.Value = reader("FecAperRemi")
                        ftCierreRemision.Value = reader("FecCieRemi")
                        txtNumeroFactura.Text = reader("NumFact")
                        txtCodRegis.Text = reader("CodModi")
                        ftRegis.Value = reader("FecRegis")
                        txtCodModi.Text = reader("CodModi")
                        ftModi.Value = reader("FecModi")

                        If reader("RemiActiva") = True Then
                            cboActivaRemicion.SelectedIndex = 1
                        Else
                            cboActivaRemicion.SelectedIndex = 0
                        End If
                        Dim TotalItems As Double = ((reader("ValUniDeta") * reader("CantDeta")) + reader("ValIVADeta"))

                        DataGridViewDetalleRemision.Rows.Add(New String() {reader("ItemNum"), reader("CodProSer"), "", reader("Concepto"), reader("CantDeta"), reader("ValUniDeta"), reader("ValIVADeta"), TotalItems})
                        If DataGridViewDetalleRemision.Rows.Count > 0 Then
                            CalcularTotalDetalle()
                        End If
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

                    btnaAgregarFila.Enabled = False
                    LimpiarCamposDataGridDetalle()
                Else

                    Dim reader2 As SqlDataReader
                    reader2 = SQLReader("SELECT DTR.NumRemi, DC.ID_Contratos, DC.CuotaNoPac, DC.ValTolCuota, DF.FecAperRemi, DF.FecCieRemi, DF.HorAperRemi, DF.RemiActiva,
                                    DTR.ItemNum, DTR.CodProSer, DTR.Concepto, DTR.CantDeta, DTR.ValUniDeta, DTR.ValIVADeta, DF.CuotNum, df.CodRegis, df.FecRegis, df.CodModi, df.FecModi
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
                            LimpiarCamposDataGridDetalle()
                        Else

                            MsgBox("Registraras un nueva remisión")
                            LimpiarCamposDataGridDetalle()
                            GroupModi.Enabled = False
                            GroupRegis.Enabled = True
                            btnFacturar.Enabled = False
                            txtNumeroDeCouta.Text = CuotasPagadas + 1
                            dc.Read()
                            txtValorUnitrio.Text = Math.Round((dc![ValTolCuota] / 1.19), 4)
                            txtValorUniIva.Text = Math.Round((Convert.ToDouble(txtValorUnitrio.Text) * 0.19), 4)
                            txtTotal.Text = Math.Round((Convert.ToDouble(txtValorUnitrio.Text) + Convert.ToDouble(txtValorUniIva.Text)), 3)

                            txtTotalCuota.Text = DataGridDetalleCuotas.SelectedCells.Item(3).Value
                            txtNumeroDeCouta.Text = CuotasPagadas + 1
                            txtCantidad.Text = 1
                        End If

                    Else
                        MsgBox("Esta cuota ya tiene una remision cargada, podras modificarla o eliminarla")
                        LimpiarCamposDataGridDetalle()
                        GroupModi.Enabled = True
                        GroupRegis.Enabled = False
                        btnEliminar.Enabled = True
                        btnFacturar.Enabled = True
                        While reader2.Read()
                            txtNumRemision.Text = reader2("NumRemi")
                            txtIdContrato.Text = reader2("ID_Contratos")
                            txtNumeroDeCouta.Text = reader2![CuotNum]
                            txtTotalCuota.Text = reader2("ValTolCuota")
                            ftAperturaRemision.Value = reader2("FecAperRemi")
                            ftCierreRemision.Value = reader2("FecCieRemi")
                            txtCodRegis.Text = reader2("CodModi")
                            ftRegis.Value = reader2("FecRegis")
                            txtCodModi.Text = reader2("CodModi")
                            ftModi.Value = reader2("FecModi")
                            If reader2("RemiActiva") = True Then
                                cboActivaRemicion.SelectedIndex = 1
                            Else
                                cboActivaRemicion.SelectedIndex = 0
                            End If


                            Dim TotalItems As Double = ((reader2("ValUniDeta") * reader2("CantDeta")) + reader2("ValIVADeta"))


                            DataGridViewDetalleRemision.Rows.Add(New String() {reader2("ItemNum"), reader2("CodProSer"), "", reader2("Concepto"), reader2("CantDeta"), reader2("ValUniDeta"), reader2("ValIVADeta"), TotalItems})
                        End While
                        If DataGridViewDetalleRemision.Rows.Count > 0 Then
                            CalcularTotalDetalle()
                        End If
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

    End Sub 'IMPORTANTE: Muestra, calcula, valida cada vez que se selecciona una cuota de un contrato

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

    Private Sub txtValorUniIva_KeyDown(sender As Object, e As KeyEventArgs) Handles txtValorUniIva.KeyDown
        Try
            Select Case e.KeyData
                Case Keys.Enter
                    If String.IsNullOrWhiteSpace(txtValorUniIva.Text) Then
                        MsgBox("Para calcular valores a partir del IVA digita primero algun valor unitario de IVA")
                    Else
                        Dim ValorUnitario As Double = Math.Round(Convert.ToDouble(txtValorUniIva.Text / 0.19), 0)
                        txtValorUnitrio.Text = ValorUnitario
                        txtTotal.Text = Math.Round(Convert.ToDouble(txtValorUniIva.Text) + Convert.ToDouble(txtValorUnitrio.Text), 0)

                    End If
            End Select

        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "al calcular totales por IVA" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub  'Calcula valor unitario y total a patir de el enter en el texbox valor Unitatio iva

    Private Sub txtTotal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTotal.KeyDown
        Try
            Select Case e.KeyData
                Case Keys.Enter
                    If String.IsNullOrWhiteSpace(txtValorUniIva.Text) Then
                        MsgBox("Para calcular valores a partir del Total digita primero algun valor total")
                    Else

                        Dim ValorUnitario As Double = Math.Round(Convert.ToDouble(txtTotal.Text / 1.19), 0)
                        txtValorUnitrio.Text = ValorUnitario

                        Dim ValorIva As Double = Math.Round(Convert.ToDouble(txtValorUnitrio.Text * 0.19), 0)
                        txtValorUniIva.Text = ValorIva

                    End If
            End Select

        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "al calcular totales por Total" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub 'Calcula valor unitario y iva a patir de el enter en el texbox total

    Private Sub txtValorUnitrio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtValorUnitrio.KeyDown
        Try
            Select Case e.KeyData
                Case Keys.Enter
                    If String.IsNullOrWhiteSpace(txtCantidad.Text) Or String.IsNullOrWhiteSpace(txtValorUnitrio.Text) Or Convert.ToInt32(txtCantidad.Text) <= 0 Then
                        MsgBox("Te falta rellenar alguno de estos campos: Cantidad, Valor Unitario o Valor Iva")
                    Else
                        txtTotal.Clear()
                        Dim total As Double = Math.Round(Convert.ToDouble(txtValorUnitrio.Text) * Convert.ToDouble(txtCantidad.Text), 0)
                        Dim TotalIVa As Double = Math.Round((total * 0.19), 0)
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

    End Sub 'Calcula valor iva y total a patir de el enter en el texbox valor unitario

    Private Sub txtValorUnitrio_LostFocus(sender As Object, e As EventArgs) Handles txtValorUnitrio.LostFocus
        Try
            If String.IsNullOrWhiteSpace(txtValorUnitrio.Text) Then

            Else
                txtTotal.Clear()
                Dim total As Double = Math.Round(Convert.ToDouble(txtValorUnitrio.Text) * Convert.ToDouble(txtCantidad.Text), 0)
                Dim TotalIVa As Double = Math.Round((total * 0.19), 0)
                txtValorUniIva.Text = TotalIVa
                txtTotal.Text = (TotalIVa + total)
            End If
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "al calcular totales en el evento focus de salida" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub 'Calcula valor iva  y total a patir de el evento cuanto pierde el foco en el texbox valor Unitatio 

    Private Sub txtValorUniIva_LostFocus(sender As Object, e As EventArgs) Handles txtValorUniIva.LostFocus
        Try
            If String.IsNullOrWhiteSpace(txtValorUniIva.Text) Then

            Else
                If String.IsNullOrWhiteSpace(txtValorUniIva.Text) Then
                    MsgBox("Para calcular valores a partir del IVA digita primero algun valor unitario de IVA")
                Else
                    Dim ValorUnitario As Double = Math.Round(Convert.ToDouble(txtValorUniIva.Text / 0.19), 0)
                    txtValorUnitrio.Text = ValorUnitario
                    txtTotal.Text = Math.Round(Convert.ToDouble(txtValorUniIva.Text) + Convert.ToDouble(txtValorUnitrio.Text), 0)

                End If
            End If


        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "al calcular totales por IVA" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub 'Calcula valor unitario y total a patir de el evento cuanto pierde el foco en el texbox valor Unitatio IVA 

    Private Sub txtTotal_LostFocus(sender As Object, e As EventArgs) Handles txtTotal.LostFocus
        Try

            If String.IsNullOrWhiteSpace(txtTotal.Text) Then

            Else
                Dim ValorUnitario As Double = Math.Round(Convert.ToDouble(txtTotal.Text / 1.19), 0)
                txtValorUnitrio.Text = ValorUnitario

                Dim ValorIva As Double = Math.Round(Convert.ToDouble(txtValorUnitrio.Text * 0.19), 0)
                txtValorUniIva.Text = ValorIva
            End If


        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "al calcular totales por Total en el evento lost focus" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub 'Calcula valor iva  y valor unitario a patir de el evento cuanto pierde el foco en el texbox total 

    Private Sub DataGridViewDetalleRemision_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DataGridViewDetalleRemision.RowsRemoved
        CalcularTotalDetalle()
    End Sub 'Cuando se elimina una fila se recalcula el total 

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Try

            ModuloVariablesAplicacion.InfConsultaReporte = "SELECT dr.NumRemi, dr.ID_Contratos, dr.FecAperRemi, dr.HorAperRemi, dr.HorAperRemi, dr.RemiActiva, dr.CuotNum, dr.FecCieRemi
                                                            , ddr.ItemNum, ddr.CodProSer, ddr.Concepto, ddr.CantDeta, ddr.ValIVADeta, ddr.ValUniDeta, dr.CodModi, dr.FecModi, dr.FecRegis, dr.CodRegis
                                                            FROM [Datos remisiones de facturas] AS dr, [Datos detalle de remisiones] as ddr where dr.NumRemi = ddr.NumRemi"
            ModuloVariablesAplicacion.InfCabecera = "Remisiones"
            ModuloVariablesAplicacion.InfTituloInforme = "Reporte de Remisiones"
            ModuloVariablesAplicacion.infNombreInforme = "ReportRemisiones"
            Dim FrmsInformes As New FrmlInformes
            FrmlInformes.ShowDialog()
        Catch ex As Exception
            MsgBox("Error al exportar Remisiones " & ex.Message)
        End Try
    End Sub 'Reporte

    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
        Try

            If ValidacionDeCampos() Then
                If ValidarCamposAñadirDetalle() Then
                    If MsgBox("Se facturara esta remision ¿Esta seguro?", vbYesNo) = vbYes Then

                        Dim concecutivoFactura As String = CreaConsecutivo("03", True, 2)

                        Dim PrefijoFacturas As String

                        If String.IsNullOrWhiteSpace(concecutivoFactura) Then

                            Exit Sub

                        Else
                            Dim prefijo As SqlDataReader

                            prefijo = SQLReader("select PrefiConse from [Datos consecutivos SIIGHOSPLUS] WHERE CodConse = 03")

                            If prefijo.HasRows = False Then
                                MsgBox("No se encontro el concecutivo")
                                Exit Sub
                            Else

                                prefijo.Read()
                                PrefijoFacturas = prefijo("PrefiConse")
                                cn.Close()
                            End If


                            Dim fecha As Date = Date.Now
                            Dim FechaFinal As Date = Date.Now.AddDays(30)
                            Dim EstadoFacturado As Boolean
                            EstadoFacturado = ClaseModuloDeRemisiones.FacturarRemision(PrefijoFacturas, concecutivoFactura, txtNumRemision.Text, fecha, Format(FechaFinal, "yyyy/MM/dd"), txtTipoDocu.Text, txtIdentificacion.Text, txtSucursal.Text, txtValorUnitrio.Text, 0, txtValorUniIva.Text,
                                                0, 0, 0, 0, fecha, cboResolucionFactura.SelectedValue, txtCodRegis.Text, ftRegis.Value, txtIdContrato.Text, txtNumeroDeCouta.Text)

                            If EstadoFacturado Then
                                btnFacturar.Enabled = False
                                CagarDetallesCuotas(txtIdContrato.Text)

                                '    Dim Proceso As Process = New Process
                                '    Dim ruta As String = "C:\Facturacion\ApiFactElec\ApiFactElec.exe"

                                '    Dim startInfo As ProcessStartInfo = New ProcessStartInfo(ruta)
                                '    Dim Parametros As String = "factura " + concecutivoFactura + " " + txtNumRemision.Text

                                '    startInfo.Arguments = Parametros
                                '    startInfo.UseShellExecute = False
                                '    System.Diagnostics.Process.Start(startInfo)
                            End If


                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en el boton guardar Facturar" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub 'Facturar

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim estado As Boolean = DataGridDetalleCuotas.SelectedCells.Item(4).Value 'Obtenemos el estado de pago de la cuota

            If estado = True Then
                MsgBox("No puedes eliminar esta remision porque ya ha sido facturada")
            Else
                If MsgBox("Eliminaras este remision. ¿Estas de acuerdo?", vbYesNo) = vbYes Then
                    Dim Eliminar As Boolean = ClaseModuloDeRemisiones.EliminarRemision(txtNumRemision.Text, txtNumeroDeCouta.Text, txtIdContrato.Text)
                    If Eliminar Then
                        LimpiarCamposDataGridDetalle()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub 'Eliminar

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Try

            If String.IsNullOrWhiteSpace(txtNumRemision.Text) Then

                If ValidacionDeCampos() = True And ValidarTotal() = True Then
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
            Else
                Dim estado As Boolean = DataGridDetalleCuotas.SelectedCells.Item(4).Value 'Obtenemos el estado de pago de la cuota
                If estado = True Then
                    MsgBox("No podras modificar esta remision porque ya fue facturara")

                Else
                    If ValidacionDeCampos() = True And ValidarTotal() = True And txtNumRemision.Text <> Nothing Then
                        Dim hora As String = Now.ToString("HH:mm:ss")
                        Dim EstadoRegistroRemision As Boolean
                        EstadoRegistroRemision = ClaseModuloDeRemisiones.ModuloRemision(txtNumRemision.Text, txtIdContrato.Text, ftAperturaRemision.Value, hora, cboActivaRemicion.SelectedIndex, txtNumeroDeCouta.Text, ftCierreRemision.Value, txtCodRegis.Text, ftRegis.Value, txtCodModi.Text, ftModi.Value, DataGridViewDetalleRemision)
                        CagarDetallesCuotas(txtIdContrato.Text)

                        If EstadoRegistroRemision Then
                            btnFacturar.Enabled = True
                        End If

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
    End Sub 'Limpia Campos

    Private Sub txtNumRemision_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorUnitrio.KeyPress, txtValorUniIva.KeyPress, txtTotal.KeyPress, txtNumRemision.KeyPress, txtCantidad.KeyPress, cboCodigoProducto.KeyPress
        soloNumeros(e)
    End Sub 'Deja digitar solo numeros

    Private Function CalcularTotalDetalle() As Double
        Try
            Dim TotalGrillaDetalleRemision As Double = 0
            Dim fila As DataGridViewRow = New DataGridViewRow()
            For Each fila In DataGridViewDetalleRemision.Rows
                TotalGrillaDetalleRemision += Convert.ToDouble(fila.Cells("Total").Value)
            Next
            txtTotalGrillaDetalle.Text = TotalGrillaDetalleRemision

            Return TotalGrillaDetalleRemision
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "En la funcion calcular total Detalle" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function  'Suma el total de la fila total de la grilla detalle de remisio y lo exporta

    Private Sub btnaAgregarFila_Click(sender As Object, e As EventArgs) Handles btnaAgregarFila.Click

        Dim TotalGrillaDetalleRemision As Double = CalcularTotalDetalle()

        Try
            If DataGridViewDetalleRemision.Rows.Count > 0 Then
                If String.IsNullOrWhiteSpace(txtIdContrato.Text) Then
                    If ValidarCamposAñadirDetalle() Then
                        Dim totalcuota As Double = txtTotalCuota.Text
                        Dim NumItem As Int32 = DataGridViewDetalleRemision.Rows.Count
                        NumItem += 1
                        DataGridViewDetalleRemision.Rows.Add(New String() {NumItem, cboCodigoProducto.Text, cboProducto.Text, txtConcepto.Text, txtCantidad.Text, txtValorUnitrio.Text, txtValorUniIva.Text, txtTotal.Text})
                        CalcularTotalDetalle()
                        txtValorUnitrio.Clear()
                        txtValorUniIva.Clear()
                        txtTotal.Text = totalcuota - CalcularTotalDetalle() 'Cuando entre la fila, al total de la cuota le resto la suma del total en las grillas 
                        'de detalle remision y coloco ese resultado en el txttotal: Para que se de cuena cuanto
                        'le esta faltando para el total de la cuota
                    End If
                Else
                    Dim totalcuota As Double = DataGridDetalleCuotas.SelectedCells.Item(3).Value
                    If TotalGrillaDetalleRemision >= Convert.ToDouble(totalcuota) Then
                        MsgBox("No puedes agregar un valor mas alto que el total a pagar")
                        CalcularTotalDetalle()
                        Exit Sub
                    Else
                        Dim NumItem As Int64
                        Dim Fila As DataGridViewRow = New DataGridViewRow()
                        For Each Fila In DataGridViewDetalleRemision.Rows  'Lo hago para recalcular el indice de la grillas donde se elimine un Item
                            NumItem = Fila.Cells("Item").Value
                        Next

                        NumItem += 1 'Recojo el ultimo numero del Item y le sumo uno

                        If ValidarCamposAñadirDetalle() Then

                            DataGridViewDetalleRemision.Rows.Add(New String() {NumItem, cboCodigoProducto.Text, cboProducto.Text, txtConcepto.Text, txtCantidad.Text, txtValorUnitrio.Text, txtValorUniIva.Text, txtTotal.Text})
                            CalcularTotalDetalle()
                            txtValorUnitrio.Clear()
                            txtValorUniIva.Clear()
                            txtTotal.Text = totalcuota - CalcularTotalDetalle()   'Cuando entre la fila, al total de la cuota le resto la suma del total en las grillas 
                            'de detalle remision y coloco ese resultado en el txttotal: Para que se de cuena cuanto
                            'le esta faltando para el total de la cuota
                        End If
                    End If
                End If
            Else
                Dim NumItem As Int32 = DataGridViewDetalleRemision.Rows.Count
                NumItem += 1
                If ValidarCamposAñadirDetalle() Then
                    Dim totalcuota As Double = DataGridDetalleCuotas.SelectedCells.Item(3).Value
                    DataGridViewDetalleRemision.Rows.Add(New String() {NumItem, cboCodigoProducto.Text, cboProducto.Text, txtConcepto.Text, txtCantidad.Text, txtValorUnitrio.Text, txtValorUniIva.Text, txtTotal.Text})
                    CalcularTotalDetalle()
                    txtValorUnitrio.Clear()
                    txtValorUniIva.Clear()
                    txtTotal.Text = totalcuota - CalcularTotalDetalle() 'Cuando entre la fila, al total de la cuota le resto la suma del total en las grillas 
                    'de detalle remision y coloco ese resultado en el txttotal: Para que se de cuena cuanto
                    'le esta faltando para el total de la cuota
                End If
            End If
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "En la evento click del boton agregar" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub 'Agrega filas a datagrid detalle remision

    Private Sub BtnCerrarContratos_Click(sender As Object, e As EventArgs) Handles BtnCerrarContratos.Click
        Me.Dispose()
    End Sub  'Cerrar


#End Region

#Region "Funciones "

    Private Sub btnBuscaPorNit_Click(sender As Object, e As EventArgs) Handles btnBuscaPorNit.Click
        Dim Remi As String
        Remi = InputBox("Ingrese la Remision que desea buscar")
        If Remi = "" Then
            MsgBox("Operacion Cancelada")
        Else
            Dim Identificador As String = BuscarPorRemision(Remi)


        End If
    End Sub  'Busca por nit

    Private Function BuscarPorRemision(Remi As String) As String

        Try
            Dim consulta As String = "select df.ID_Contratos, dc.NumDocContra,  df.CuotNum
                                    from [Datos remisiones de facturas] as df, [Datos registros de contratos] as dc
                                    where df.ID_Contratos = dc.ID_Contratos AND df.NumRemi = '" & Remi & "'"



            Dim br As SqlDataReader

            br = SQLReader(consulta)

            If br.HasRows = False Then
                MsgBox("Esta remision no existe")
                cn.Close()
            Else
                br.Read()
                Dim Indentificador As String = br("ID_Contratos")
                Dim Documento As String = br("NumDocContra")
                Dim NumeroCuota As Int16 = br("CuotNum")
                cn.Close()

                MostrarTexbox(Indentificador)
                cboProvedores.SelectedValue = Documento

                Dim Fila As DataGridViewRow = New DataGridViewRow()
                Dim Fila2 As DataGridViewRow = New DataGridViewRow()


                Dim CuentaFilaContratos As Int64 = 0
                Dim CuentaFilaCuotas As Int64 = 0

                If DataGridContratos.Rows.Count = 0 Then   'BUSCA EL CONTRATO Y LO SELECCIONA
                    MsgBox("No se econtro la remision")
                Else
                    For Each Fila In DataGridContratos.Rows
                        CuentaFilaContratos += 1
                        If Fila.Cells("ID_Contratos").Value = Indentificador Then

                            DataGridContratos.CurrentCell = DataGridContratos.Rows(CuentaFilaContratos - 1).Cells(0)
                            MessageBox.Show("Presiona click en la fila seleccionada en la tabla DETALLE CUOTAS para ver los detalles", "REMISION ENCONTRADA ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit For
                        End If
                    Next
                    If DataGridDetalleCuotas.Rows.Count = 0 Then  'BUSCA LA CUOTA Y LA SELECCIONA
                        MsgBox("No se econtro la remision")
                    Else
                        For Each Fila2 In DataGridDetalleCuotas.Rows
                            CuentaFilaCuotas += 1

                            If Fila2.Cells("NumeroDeCouta").Value = NumeroCuota Then
                                DataGridDetalleCuotas.Rows(CuentaFilaCuotas - 1).Selected = True
                                Exit For
                            End If
                        Next
                    End If
                End If
            End If

        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en la busqueda por remi" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            If cn.State = True Then
                cn.Close()
            End If
        End Try

    End Function 'Busca por remision

    Private Function ComprobarDatos() As Boolean
        Try
            Dim reader As SqlDataReader
            reader = SQLReader("SELECT * FROM [Datos registros de contratos]")
            If reader.HasRows = False Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error en comprobar datos ")
            Return False
        Finally
            cn.Close()
        End Try

    End Function 'Validacion de datos

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
    End Function 'Crea el concecutivo

    Private Function ValidarTotal() As Boolean
        Try
            Dim estado As Boolean = False
            Dim TotalGrilla As Double
            Dim Fila As DataGridViewRow = New DataGridViewRow()
            For Each Fila In DataGridViewDetalleRemision.Rows
                TotalGrilla += Fila.Cells("Total").Value
            Next

            If String.IsNullOrWhiteSpace(txtTotalCuota.Text) Then
                MsgBox("Escoge una cuota a la cual se le puede realizar la remision.")
                Return False
            Else
                Dim totalcuotacontrato As Double = DataGridDetalleCuotas.SelectedCells.Item(3).Value
                If TotalGrilla > Convert.ToDouble(totalcuotacontrato) Then
                    MsgBox("El total de los items de la tabla no puede ser mayor al total de la cuota")
                    estado = False
                Else
                    estado = True
                End If
                If TotalGrilla < Convert.ToDouble(totalcuotacontrato) Then
                    MsgBox("El total de los items de la tabla no puede ser menor al total de la cuota")
                    estado = False
                Else
                    estado = True
                End If
            End If
            Return estado
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en alguna la funcion en validar el total de la grillas detalle" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function  'Valida datos del total

    Private Function ValidacionDeCampos() As Boolean
        Try
            Dim estado As Boolean = False

            If cboResolucionFactura.SelectedIndex = -1 Then
                MsgBox("Escoge una resolucion de factura")
                cboResolucionFactura.Select()
                estado = False
                Return estado
            Else
                estado = True
            End If

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
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en alguna ka funcion validacion de campos" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try


    End Function  'Valida campos

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
    End Function 'Valida los datos del datagridview

    Private Sub MostrasDatosCliente(identificador)
        LimpiarCampos()

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

    End Sub  'Muestra

    Private Sub MostrarTexbox(identificador)
        LimpiarCampos()
        Try
            Dim dr As SqlDataReader
            Dim consulta As String = "SELECT rc.ID_Contratos, rc.ContraNo, rc.TipDocContra, rc.NumDocContra, dp.DigVeri, dp.TelProve1, dp.DirElectro, dp.RazonSol, dp.SucurProv,  rc.NumPagos
                                    from [Datos registros de contratos] as rc, [Datos proveedores] as dp 
                                    where rc.ID_Contratos = '" & identificador.ToString & "' and rc.NumDocContra = dp.IdenProve"

            dr = SQLReader(consulta)

            If dr.HasRows = False Then
                MsgBox("No se efectuaron filas")
            Else
                dr.Read()

                txtTipoDocu.Text = dr("TipDocContra")
                txtIdentificacion.Text = dr("NumDocContra")   'ESTAS REALIZANDO LA BUSQUEDA POR REMI
                txtSucursal.Text = dr![SucurProv]
                txtRazonSocial.Text = dr![RazonSol]
                txtTelefono.Text = dr("TelProve1")
                txtIdContrato.Text = dr("ID_Contratos")


            End If

            dr.Dispose()
            cn.Close()

            CagarDetallesCuotas(identificador)

        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "En la funcion MostrarTexbox" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub 'Muestra

    Private Sub LimpiarCampos()
        txtNumeroFactura.Clear()
        txtTotalGrillaDetalle.Clear()
        txtTipoDocu.Clear()
        txtIdentificacion.Clear()
        txtSucursal.Clear()
        txtRazonSocial.Clear()
        txtTelefono.Clear()
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

    Private Sub LimpiarCamposDataGridDetalle()
        txtNumeroFactura.Clear()
        txtTotalGrillaDetalle.Clear()
        txtNumRemision.Clear()
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
    End Sub
#End Region


    Private Sub Remisiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'LEER CREAR COMBOBOX RESOLUCIOM FACTURACION Y HACER QUE GUARDE EN LA BASDE DE DATOS
        Try
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


            If ComprobarDatos() Then
                MostrasDatosCliente(cboProvedores.SelectedValue)
                CargarDataGridContratos(cboProvedores.SelectedValue)
                Dim codigo As String = DataGridContratos.SelectedCells.Item(0).Value
                MostrarTexbox(codigo)
            Else
                MsgBox("No existen cuotas ni contratos para remitir")
            End If
        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error" & Chr(13) & Chr(10)
            Informa += "en alguna funcion del load" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub  'LOAD


End Class