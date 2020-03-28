'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Microsoft.Office.Interop

Public Class frm_OIngreso
    Inherits frm_MenuPadre

#Region "Inicializacion"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Shared instancia As frm_OIngreso = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_OIngreso
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Variables"

    Dim oeOrden As e_Orden : Dim olOrden As l_Orden : Dim listaOrden As List(Of e_Orden)
    Dim oeCentro As e_Centro : Dim olCentro As l_Centro
    Dim oeMoneda As e_Moneda : Dim olMoneda As l_Moneda

    Dim oeAlmacen As e_Almacen : Dim olAlmacen As l_Almacen
    Dim oeSubAlmacen As e_SubAlmacen : Dim olSubAlmacen As l_SubAlmacen
    Dim oeMaterial As e_Material : Dim olMaterial As l_Material : Dim listaMaterial As List(Of e_Material)

    Dim oeMovimientoInventario As e_MovimientoInventario : Dim olMovimientoInventario As l_MovimientoInventario
    Dim listaMovimientoInventario As List(Of e_MovimientoInventario)
    Dim oeEstadoOrden As e_EstadoOrden : Dim olEstadoOrden As l_EstadoOrden : Dim listaEstadoOrden As List(Of e_EstadoOrden)

    Dim oeOrdenMaterial As e_OrdenMaterial : Dim olOrdenMaterial As l_OrdenMaterial : Dim loOrdenMaterial As List(Of e_OrdenMaterial)
    Dim oeUnidadMedida As e_UnidadMedida : Dim olUnidadMedida As l_UnidadMedida
    Dim oeMaterialAlmacen As e_MaterialAlmacen : Dim olMaterialAlmacen As l_MaterialAlmacen

    Dim oeTipoDocumento As e_TipoDocumento : Dim olTipoDocumento As l_TipoDocumento
    Dim oeMovimientoDocumento As e_MovimientoDocumento : Dim olMovimientoDocumento As l_MovimientoDocumento
    Dim lstMovimientoDocumento As List(Of e_MovimientoDocumento) : Dim lstMovimientoDocumentoAsoc As List(Of e_MovimientoDocumento)
    Dim oeOrdenDoc As e_Orden_Documento : Dim olOrdenDoc As l_Orden_Documento
    Dim oeGRRemitente As e_GuiaRemisionRemitente : Dim olGRRemitente As l_GuiaRemisionRemitente : Dim listaGRemision As List(Of e_GuiaRemisionRemitente)

    Dim olTrabajadorSeguridad As l_TrabajadorSeguridad
    Dim oeComboPropio As e_Combo

    Dim oeInventario As e_Inventario : Dim oeRegistroInventario As e_RegistroInventario : Dim olRegistroInventario As l_RegistroInventario
    Dim listaInventario As List(Of e_Inventario) : Dim listaRegistroInventario As List(Of e_RegistroInventario)

    Dim oeControlEntregaMaterial As e_ControlEntregaMaterial

    Dim RegistroEditado As Integer = 0
    Dim IdRegistroEditado As String = ""
    Dim oeRegistroEditado As e_RegistrosEditados
    Dim olRegistroEditado As l_RegistrosEditados
    Dim loRegistroInventario As List(Of e_RegistroInventario)

    Private oeMaterialesNegociadosDet As e_MaterialesNegociadosDet : Private loMaterialesNegociadosDet As List(Of e_MaterialesNegociadosDet)
    Private olMaterialesNegociadosDet As l_MaterialesNegociadosDet

    Private oeAsientoModelo As e_AsientoModelo : Private olAsientoModelo As l_AsientoModelo : Private loAsientoModelo As List(Of e_AsientoModelo)
    Private oeReferencia As e_AsientoModelo_Referencia : Private olReferencia As l_AsientoModelo_Referencia : Private loReferencia As List(Of e_AsientoModelo_Referencia)
    Private oeCtaCtbleSFam As e_CtaCtbleSubFamiliaMat : Private olCtaCtbleSFam As l_CtaCtbleSubFamiliaMat : Private loCtaCtbleSFam, loCtaCtbleSFamOrden As List(Of e_CtaCtbleSubFamiliaMat)

    Private dtReferencia As DataTable

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Listar()
            ControlBotoneria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            Operacion = "Nuevo"
            Inicializar()
            oeOrden.TipoOperacion = "I"
            oeOrden.TipoOperDocAsoc = "I"
            oeOrden.UsuarioCreacion = gUsuarioSGI.Id
            oeOrden.Activo = True
            SeleccionTabs(1, ficOIngreso)
            If gUsuarioSGI.oeArea.Nombre = gNombreAreaLogistica Or gUsuarioSGI.oeArea.Nombre = gNombreAreaInformaticaSistemas Then
                MostrarTabs(1, ficDetalle, 0)
                uebDocumento.Expanded = True
            Else
                MostrarTabs(0, ficDetalle, 0)
            End If
            ControlBotoneria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Operacion = "Editar"
            If VerificarRegistroEditado() Then
                If griOrden.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                    EditarOrden(griOrden.ActiveRow.Cells("Id").Value.ToString)
                    GuardarRegistroEditado()
                    oeOrden.TipoOperacion = "A"
                    SeleccionTabs(1, ficOIngreso)
                    uegMateriales.Expanded = False
                    If oeOrden.TipoReferencia.Trim <> "" Then
                        UltraGroupBox4.Visible = False
                    Else
                        UltraGroupBox4.Visible = True
                    End If
                    uceMovInventario.Focus()
                    ControlBotoneria()
                    SeleccionTabs(0, ficDetalle, False)
                End If            
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarOrden() Then
                ActualizaRegistroEditado(RegistroEditado, IdRegistroEditado)
                mensajeEmergente.Confirmacion("La Informacion ha Sido Guardada Correctamente en " & Me.Text, True)
                SeleccionTabs(0, ficOIngreso)
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
       Try
            If Operacion <> "Nuevo" Then
                ActualizaRegistroEditado(RegistroEditado, IdRegistroEditado)
            End If
            SeleccionTabs(0, ficOIngreso)
            Consultar(True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If griOrden.ActiveRow.Cells("EstadoOrden").Value = gNombreEstadoGenerada Then
                If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "ELIMINAR ORDENES (I,S)") Then 'And gUsuarioSGI.oeArea.Nombre = gNombreAreaLogistica
                    oeOrden.Id = griOrden.ActiveRow.Cells("Id").Value
                    oeOrden = olOrden.Obtener(oeOrden)
                    If Not oeOrden.Activo Then
                        Consultar(True)
                        Throw New Exception("La Orden ya fue Eliminada. Actualizar")
                    Else
                        If Trim(oeOrden.IdOrdenDocumento) = "" Then
                            If MessageBox.Show("Desea Eliminar la OI Nro: " & griOrden.ActiveRow.Cells("NroOrden").Value & "?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeOrden.TipoOperacion = "E"
                                olOrden.Eliminar(oeOrden)
                                Consultar(True)
                            End If
                        Else
                            Throw New Exception("No puede Eliminar Orden Asociada a un Documento Contable")
                        End If
                    End If
                Else
                    Throw New Exception("No Tiene Permiso para Eliminar Ordenes de Ingreso")
                End If
            Else
                Throw New Exception("La Orden de Ingreso ya fue Ejecutada. No Puede Eliminarla!")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Try
            ImprimirOrden()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griOrden.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If ficOIngreso.SelectedTab.Index = 0 Then Exportar_Excel(griOrden)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Metodos"

    Private Sub ControlBotoneria()
        Select Case ficOIngreso.SelectedTab.Index
            Case 0
                If griOrden.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                Else
                    ControlBoton(1, 1)
                End If
            Case 1
                Select Case oeOrden.EstadoOrden
                    Case "", gNombreEstadoOrdenGenerada
                        If Operacion = "Nuevo" Then
                            ControlBoton(0, 0, 0, 1, 1)
                        Else
                            Select Case oeOrden.TipoReferencia
                                Case "ORDEN TRABAJO", "ORDEN ASIGNACION", "ORDEN DE TRANSFERENCIA", "ORDEN VENTA", ""
                                    ControlBoton(0, 0, 0, 1, 1)
                                Case Else
                                    ControlBoton(0, 0, 0, 0, 1)
                            End Select
                        End If
                    Case gNombreEstadoOrdenTerminada
                        If Operacion = "Rectificar" Then
                            ControlBoton(0, 0, 0, 1, 1)
                        Else
                            ControlBoton(0, 0, 0, 0, 1)
                        End If
                End Select
        End Select
    End Sub

    Private Sub LlenaObjeto()
        Try
            loRegistroInventario = New List(Of e_RegistroInventario)
            With oeOrden
                .lstOrdenMaterial = New List(Of e_OrdenMaterial)
                .lstOrdenMaterial = loOrdenMaterial
                .IdSubAlmacenDestino = ""
                .IdSubAlmacenOrigen = ""
                .FechaOrden = dtpFechaOrden.Value
                .IdMovimientoInventario = uceMovInventario.Value
                .IdMoneda = uceMoneda.Value
                .Glosa = txtGlosa.Text.ToString
                .IdProveedor = cboProveedor.Value
                .Total = numTotalOrden.Value
                .IdTipoOrden = Me.Tag
                .UsuarioCreacion = gUsuarioSGI.Id
                If griOrdAsoc.Rows.Count > 0 Then
                    .TipoDocumento = lstMovimientoDocumentoAsoc.Item(0).IdTipoDocumento
                    .IdDocumento = lstMovimientoDocumentoAsoc.Item(0).Id
                End If
                If Operacion = "Ejecutar" Then
                    EjecutarOrden(0)
                ElseIf Operacion = "Rectificar" Then
                    For Each oe As e_RegistroInventario In listaRegistroInventario
                        oe.PrefijoID = gs_PrefijoIdSucursal '@0001
                        For Each oe1 As e_OrdenMaterial In loOrdenMaterial
                            oe1.PrefijoID = gs_PrefijoIdSucursal '@0001
                            If oe.IdMaterial = oe1.IdMaterial And oe1.Seleccion = True Then
                                oe.TipoOperacion = "T"
                                oe.Cantidad = oe1.CantidadMaterial
                                oe.ValorUnitario = Math.Round((oe1.PrecioUnitario / (1 + oeIGVGlobal.Porcentaje)) * IIf(.IdMoneda = "1CH02", TipoCambio(.FechaOrden)(0), 1), 4)
                                oe.CantidadReal = oe.Cantidad
                                oe.ValorUnitarioReal = oe.ValorUnitario
                                oe.ValorTotal = Math.Round(oe.CantidadReal * oe.ValorUnitarioReal, 4)
                                oe.Modificado = True
                            End If
                        Next
                    Next
                    loRegistroInventario.AddRange(listaRegistroInventario.Where(Function(i) i.Modificado = True).ToList)
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarOrden() As Boolean
        Try
            LlenaObjeto()
            If ValidarOrden() Then
                oeOrden.PrefijoID = gs_PrefijoIdSucursal '@0001
                olOrden.Guardar(oeOrden, loRegistroInventario)
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidarOrden() As Boolean
        Try
            With oeOrden
                If .lstOrdenMaterial.Count = 0 Then Throw New Exception("Ingrese Detalles")
                For Each oe As e_OrdenMaterial In .lstOrdenMaterial
                    If oe.IdAlmacen.Trim = "" Then Throw New Exception("Detalle sin Almacen. Verificar")
                    If oe.IdSubAlmacen.Trim = "" Then Throw New Exception("Detalle sin SubAlmacen. Verificar")
                    If oe.PrecioUnitario = 0 Then Throw New Exception("Detalle sin Precio. Verificar")
                    If oe.CantidadMaterial = 0 Then Throw New Exception("Detalle sin Cantidad. Verificar")
                Next
                Select Case .IdMovimientoInventario
                    Case "1CH000000037", "1CH000000035"
                        If .TipoDocumento = "" Then Throw New Exception("No Puede Ejecutar Ordenes sin Documentos Asociados")
                        If .IdMovimientoInventario = "1CH000000037" Then
                            oeComboPropio = New e_Combo
                            oeComboPropio.Tipo = 3
                            oeComboPropio.Nombre = "0"
                            For Each ordmat As e_OrdenMaterial In oeOrden.lstOrdenMaterial
                                oeComboPropio.Id = ordmat.IdAlmacen
                                If AlmacenesPublic.Contains(oeComboPropio) Then
                                    Throw New Exception("Ingreso x Consignacion solo para Almacenes de Consignacion")
                                End If
                            Next
                        End If
                    Case "1SI000000002", "1CH000000021"
                        If Not olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "EJECUTAR AJUSTES INV") Then Throw New Exception("No Tiene Permisos para Ejecutar Ajustes")
                End Select
                If Operacion = "Ejecutar" Then
                    If Not olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "EJECUTAR ORDENES") Then Throw New Exception("No Tiene Permisos para Ejecutar Ordenes")
                End If
                If Operacion = "Rectificar" Then
                    If Not olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "RECTIFICAR OI,OS") Then Throw New Exception("No Tiene Permisos para Rectificar Ordenes")
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub EjecutarOrden(Tipo As Integer)
        Try
            With oeOrden
                .lstInventario = New List(Of e_Inventario)
                .lstInventario.AddRange(Inventario(.lstOrdenMaterial))
                .IdUsuarioEjecucion = gUsuarioSGI.Id
                Select Case oeOrden.IdMovimientoInventario
                    Case "1CH000000013", "1CH000000018", "1SI000000002"
                        If Tipo = 0 Then
                            If oeOrden.IdMovimientoInventario = "1CH000000013" Or oeOrden.IdMovimientoInventario = "1CH000000018" Then
                                'Dim formulario As frm_AutenticarTrabajador
                                'formulario = New frm_AutenticarTrabajador
                                'If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                                '    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                                '    Exit Sub
                                'Else
                                '    For Each ordmat As e_OrdenMaterial In oeOrden.lstOrdenMaterial
                                '        oeControlEntregaMaterial = New e_ControlEntregaMaterial
                                '        oeControlEntregaMaterial.TipoOperacion = "I"
                                '        oeControlEntregaMaterial.FechaCreacion = Date.Now
                                '        oeControlEntregaMaterial.CantidadEntregada = ordmat.CantidadMaterial
                                '        oeControlEntregaMaterial.IdTrabajador = formulario.idTrabajador
                                '        oeControlEntregaMaterial.UsuarioCreacion = gUsuarioSGI.Id
                                '        oeControlEntregaMaterial.IdUnidadMedida = ordmat.IdUnidadMedida
                                '        ordmat.oeControlEntregaMat = oeControlEntregaMaterial
                                '    Next
                                'End If
                                'formulario = Nothing
                            End If
                        End If
                        .loCtaCtbleSFam = New List(Of e_CtaCtbleSubFamiliaMat)
                        oeComboPropio = New e_Combo
                        oeComboPropio.Tipo = 3
                        oeComboPropio.Nombre = "0"
                        For Each ordmat As e_OrdenMaterial In oeOrden.lstOrdenMaterial
                            oeComboPropio.Id = ordmat.IdAlmacen
                            If AlmacenesPublic.Contains(oeComboPropio) Then
                                ordmat.IndPropio = True
                            End If
                        Next
                        If oeOrden.lstOrdenMaterial.Where(Function(i) i.IndPropio).Count > 0 Then
                            Dim oePeriodo As New e_Periodo
                            Dim olPeriodo As New l_Periodo
                            Dim fechaactual As Date = ObtenerFechaServidor.Date
                            oePeriodo.Ejercicio = fechaactual.Year
                            oePeriodo.Mes = fechaactual.Month
                            oePeriodo = olPeriodo.Obtener(oePeriodo)
                            If oePeriodo.Id = "" Then Throw New Exception("No Existe el Periodo Contable de Este Periodo. Comunicar a Contabilidad")
                            .IndAsiento = True
                            .NombreProveedor = cboProveedor.Text
                            .loAsientoModelo = New List(Of e_AsientoModelo)
                            ObtenerAsientoModelo(uceMoneda.Value, oePeriodo.Ejercicio)
                            LlenaCuentaOrden(oeOrden, oePeriodo.Ejercicio, loCtaCtbleSFam)
                            oeOrden.IdPeriodo = oePeriodo.Id
                            oeOrden.TipoCambio = TipoCambio(fechaactual, True)(0)
                        End If
                End Select
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function Inventario(lo As List(Of e_OrdenMaterial)) As List(Of e_Inventario)
        Try
            oeMovimientoInventario = New e_MovimientoInventario
            oeMovimientoInventario.Id = oeOrden.IdMovimientoInventario
            oeMovimientoInventario.TipoOperacion = ""
            oeMovimientoInventario = olMovimientoInventario.Obtener(oeMovimientoInventario)
            Dim loInventario As New List(Of e_Inventario)
            Dim FechaActual As Date = ObtenerFechaServidor()
            For Each oe As e_OrdenMaterial In lo
                oeInventario = New e_Inventario
                With oeInventario
                    .FechaCreacion = oeOrden.FechaOrden ' FechaActual
                    .IdMaterial = oe.IdMaterial
                    .IdSubAlmacen = oe.IdSubAlmacen
                    .CantidadIngreso = oe.CantidadMaterial
                    .ValorUnitario = Math.Round(oe.PrecioUnitario / (1 + oeIGVGlobal.Porcentaje), 4)
                    If oeOrden.IdMoneda = "1CH02" Then
                        .ValorUnitario = Math.Round(.ValorUnitario * TipoCambio(FechaActual, True)(0), 4)
                    End If
                    .Usuario = gUsuarioSGI.Id
                    .IndDevolucion = oeMovimientoInventario.IndDevolucion
                End With
                oeRegistroInventario = New e_RegistroInventario
                With oeRegistroInventario
                    .TipoOperacion = "I"
                    .IdMaterial = oe.IdMaterial
                    .IdSubAlmacen = oe.IdSubAlmacen
                    .IdMovimientoInventario = oeOrden.IdMovimientoInventario
                    .IdUnidadMedida = oe.IdUnidadMedida
                    .Cantidad = oe.CantidadMaterial
                    .UsuarioCreacion = gUsuarioSGI.Id
                End With
                oeInventario.oeRegistroInventario = New e_RegistroInventario
                oeInventario.oeRegistroInventario = oeRegistroInventario
                oeInventario.PrefijoID = gs_PrefijoIdSucursal '@0001
                loInventario.Add(oeInventario)
            Next
            Return loInventario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub InicializarLogicas()
        olOrden = New l_Orden
        olOrdenMaterial = New l_OrdenMaterial
        olCentro = New l_Centro
        olAlmacen = New l_Almacen
        olSubAlmacen = New l_SubAlmacen
        olMaterial = New l_Material
        olMovimientoInventario = New l_MovimientoInventario
        olEstadoOrden = New l_EstadoOrden
        olTrabajadorSeguridad = New l_TrabajadorSeguridad
        olTipoDocumento = New l_TipoDocumento
        olGRRemitente = New l_GuiaRemisionRemitente
        olMoneda = New l_Moneda
        olRegistroEditado = New l_RegistrosEditados
        olUnidadMedida = New l_UnidadMedida
        olOrdenDoc = New l_Orden_Documento
        olRegistroInventario = New l_RegistroInventario
        olMaterialesNegociadosDet = New l_MaterialesNegociadosDet
        olAsientoModelo = New l_AsientoModelo
        olReferencia = New l_AsientoModelo_Referencia
        olCtaCtbleSFam = New l_CtaCtbleSubFamiliaMat
        olRegistroEditado = New l_RegistrosEditados
    End Sub

    Private Sub Inicializar()
        oeOrden = New e_Orden
        oeOrdenMaterial = New e_OrdenMaterial
        loOrdenMaterial = New List(Of e_OrdenMaterial)
        griOrdenMaterial.DataSource = loOrdenMaterial
        listaRegistroInventario = New List(Of e_RegistroInventario)
        griMovimientos.DataSource = listaRegistroInventario
        uceMovInventario.SelectedIndex = -1
        cboProveedor.DataSource = Nothing
        cboProveedor.Text = String.Empty
        chkRuc.Checked = False
        uceMoneda.SelectedIndex = 0
        dtpFechaOrden.Value = Date.Now
        txtOrden.Text = String.Empty
        txtEstadoOrden.Text = String.Empty
        txtGlosa.Text = String.Empty
        txtBuscaMateriales.Text = String.Empty
        oeMaterial = New e_Material
        listaMaterial = New List(Of e_Material)
        griListaMateriales.DataSource = listaMaterial
        fecInicioDoc.Value = Date.Now.AddDays(-20)
        fecFinDoc.Value = Date.Now
        lstMovimientoDocumento = New List(Of e_MovimientoDocumento)
        griListaDoc.DataSource = lstMovimientoDocumento
        lstMovimientoDocumentoAsoc = New List(Of e_MovimientoDocumento)
        griOrdAsoc.DataSource = lstMovimientoDocumentoAsoc
        txtBuscaMateriales.Text = String.Empty
        numTotalOrden.Value = 0
        ComboMovInventario()
        uceMovInventario.Focus()
        UltraGroupBox4.Visible = True
    End Sub

    Private Sub CargarCombos()
        Try
            oeMoneda = New e_Moneda
            oeMoneda.TipoOperacion = "1"
            oeMoneda.Activo = True
            LlenarCombo(uceMoneda, "Nombre", olMoneda.Listar(oeMoneda), 0)

            listaMovimientoInventario = New List(Of e_MovimientoInventario)
            oeMovimientoInventario = New e_MovimientoInventario
            oeMovimientoInventario.Id = "CERO"
            oeMovimientoInventario.Nombre = "TODOS"
            listaMovimientoInventario.Add(oeMovimientoInventario)
            oeMovimientoInventario = New e_MovimientoInventario
            oeMovimientoInventario.TipoOperacion = "1"
            oeMovimientoInventario.Activo = True
            listaMovimientoInventario.AddRange(olMovimientoInventario.Listar(oeMovimientoInventario))
            LlenarCombo(uceMovFiltro, "Nombre", listaMovimientoInventario, 0)

            listaEstadoOrden = New List(Of e_EstadoOrden)
            oeEstadoOrden = New e_EstadoOrden
            oeEstadoOrden.Id = "CERO"
            oeEstadoOrden.Nombre = "TODOS"
            listaEstadoOrden.Add(oeEstadoOrden)
            oeEstadoOrden = New e_EstadoOrden
            oeEstadoOrden.TipoOperacion = "1"
            oeEstadoOrden.Activo = True
            listaEstadoOrden.AddRange(olEstadoOrden.Listar(oeEstadoOrden))
            LlenarCombo(uceEstadoOrden, "Nombre", listaEstadoOrden, 0)

            ComboMovInventario()

            oeTipoDocumento = New e_TipoDocumento
            oeTipoDocumento.TipoOperacion = "A"
            oeTipoDocumento.Activo = True
            LlenarCombo(uceTipoDocumento, "Nombre", olTipoDocumento.Listar(oeTipoDocumento), 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboMovInventario()
        oeMovimientoInventario = New e_MovimientoInventario
        oeMovimientoInventario.TipoOperacion = IIf(Operacion = "Nuevo", "6", "3")
        oeMovimientoInventario.Activo = True
        LlenarCombo(uceMovInventario, "Nombre", olMovimientoInventario.Listar(oeMovimientoInventario), 0)
    End Sub

    Public Sub ListarMateriales()
        Try
            oeMaterial = New e_Material
            Me.Cursor = Cursors.WaitCursor
            If Not String.IsNullOrEmpty(Trim(txtBuscaMateriales.Text)) Then
                oeMaterial.Nombre = txtBuscaMateriales.Text
                oeMaterial.TipoOperacion = "5"
                oeMaterial.Tipo = 1
                listaMaterial = olMaterial.Listar_(oeMaterial)
                '-----
                With griListaMateriales
                    .DataSource = listaMaterial
                    .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                End With
            End If
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Listar()
        Try
            Me.Cursor = Cursors.WaitCursor
            listaOrden = New List(Of e_Orden)
            oeOrden = New e_Orden
            oeOrden.TipoOperacion = ""
            oeOrden.Activo = True
            oeOrden.IdTipoOrden = Me.Tag
            oeOrden.Id = ""
            If rbNroOrden.Checked Then
                If String.IsNullOrEmpty(txtNroOrden.Text.Trim) Then Throw New Exception("Ingrese N° de la Orden.")
                oeOrden.NroOrden = Me.txtNroOrden.Text.Trim
                oeOrden.fechaInicio = "01/01/1901"
                oeOrden.fechaFin = "01/01/1901"
            Else
                ValidarFechaDesde_Hasta(fecDesde, fecHasta)
                oeOrden.EstadoOrden = IIf(uceEstadoOrden.Value = "CERO", "", uceEstadoOrden.Value)
                oeOrden.IdMovimientoInventario = IIf(uceMovFiltro.Value = "CERO", "", uceMovFiltro.Value)
                oeOrden.fechaInicio = fecDesde.Value
                oeOrden.fechaFin = fecHasta.Value
            End If
            listaOrden = olOrden.Listar(oeOrden)
            griOrden.DataSource = listaOrden
            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griOrden.Rows
                Select Case fila.Cells("EstadoOrden").Value
                    Case "GENERADA"
                        fila.CellAppearance.BackColor = Me.UltraColorPicker1.Color
                    Case "RECEPCIONADO"
                        fila.CellAppearance.BackColor = Me.UltraColorPicker2.Color
                    Case "TERMINADA"
                        fila.CellAppearance.BackColor = Me.UltraColorPicker3.Color
                End Select
            Next
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Function VerificarRegistroEditado() As Boolean
        Try
            Dim oeOrd As New e_Orden
            oeOrd.Id = griOrden.ActiveRow.Cells("Id").Value
            oeOrd.TipoOperacion = "R"
            oeOrd.TipoOrden = Nothing
            oeOrd = olOrden.Obtener(oeOrd)
            If oeOrd.IdMovimientoInventario <> "" Then
                If oeOrd.UsuarioCreacion <> gUsuarioSGI.oePersona.NombreCompleto Then
                    mensajeEmergente.Confirmacion("La información de la Orden no es accesible pues esta siendo editado por el Usuario: " & Environment.NewLine & _
                                         oeOrd.UsuarioCreacion & Environment.NewLine & _
                                        "desde: " & oeOrd.FechaOrden & Environment.NewLine & _
                                        "en la Sucursal: " & oeOrd.IdEstadoOrden, True)
                    Return False
                Else
                    oeRegistroEditado = New e_RegistrosEditados
                    With oeRegistroEditado
                        .TipoOperacion = "A"
                        .Id = oeOrd.IdMovimientoInventario
                        .FechaModificado = DateAdd(DateInterval.Minute, 5, oeOrd.FechaOrden)
                    End With
                    oeRegistroEditado.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olRegistroEditado.Guardar(oeRegistroEditado)
                    RegistroEditado = 1
                End If
            Else
                RegistroEditado = 1
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EditarOrden(IdOrden As String) As Boolean
        Try
            Inicializar()
            oeOrden.Id = IdOrden
            oeOrden = olOrden.Obtener(oeOrden)
            uceMovInventario.Value = oeOrden.IdMovimientoInventario
            ListarProveedores(cboProveedor, oeOrden.IdProveedor)
            cboProveedor.Value = oeOrden.IdProveedor
            uceMoneda.Value = oeOrden.IdMoneda
            dtpFechaOrden.Value = oeOrden.FechaOrden
            txtGlosa.Text = oeOrden.Glosa
            txtEstadoOrden.Text = oeOrden.EstadoOrden
            txtOrden.Text = oeOrden.NroOrden
            numTotalOrden.Value = oeOrden.Total
            MostrarDocAsociado()
            If (oeOrden.EstadoOrden = gNombreEstadoTerminada Or oeOrden.EstadoOrden = gNombreEstadoOrdenRecepcionado) Then
                oeRegistroInventario = New e_RegistroInventario
                oeRegistroInventario.TipoOperacion = "B"
                oeRegistroInventario.Id = oeOrden.Id
                listaRegistroInventario = olRegistroInventario.ListarSOrden(oeRegistroInventario)
                griMovimientos.DataSource = listaRegistroInventario
            End If
            oeOrdenMaterial = New e_OrdenMaterial
            oeOrdenMaterial.TipoOperacion = "L"
            oeOrdenMaterial.Activo = True
            oeOrdenMaterial.IdOrden = oeOrden.Id
            loOrdenMaterial = olOrdenMaterial.Listar(oeOrdenMaterial)
            griOrdenMaterial.DataSource = loOrdenMaterial
            CalcularTotalesDetalle()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub MostrarDocAsociado()
        Try
            oeOrdenDoc = New e_Orden_Documento
            oeOrdenDoc.TipoOperacion = "D"
            oeOrdenDoc.IdOrden = oeOrden.Id
            oeOrdenDoc.IdTipoOrden = oeOrden.IdTipoOrden
            lstMovimientoDocumentoAsoc = New List(Of e_MovimientoDocumento)
            oeMovimientoDocumento = olOrdenDoc.ObtenerDocumento(oeOrdenDoc)
            griOrdAsoc.DataSource = lstMovimientoDocumentoAsoc
            If oeMovimientoDocumento.Id.Length > 0 Then
                oeOrden.TipoOperDocAsoc = "A"
                lstMovimientoDocumentoAsoc.Add(oeMovimientoDocumento)
                griOrdAsoc.DataBind()
            Else
                oeOrden.TipoOperDocAsoc = "I"
            End If
            If oeMovimientoDocumento.Id.Length = 0 Then
                oeOrdenDoc = New e_Orden_Documento
                oeOrdenDoc.TipoOperacion = ""
                oeOrdenDoc.IdOrden = oeOrden.Id
                oeOrdenDoc.IdTipoOrden = oeOrden.IdTipoOrden
                oeOrdenDoc.Activo = True
                oeOrdenDoc = olOrdenDoc.Obtener(oeOrdenDoc)
                'VERIFICANDO GR-REMITENTE ASOCIADO A LA ORDEN
                If Not String.IsNullOrEmpty(oeOrdenDoc.Id) Then
                    oeOrdenDoc.TipoOperacion = "G"
                    oeGRRemitente = New e_GuiaRemisionRemitente
                    oeGRRemitente = olOrdenDoc.ObtenerDocumentoGuiaRemision(oeOrdenDoc)
                    If oeGRRemitente.Id.Length > 0 Then
                        oeMovimientoDocumento = New e_MovimientoDocumento
                        oeMovimientoDocumento.Id = oeGRRemitente.Id
                        oeMovimientoDocumento.NombreDocumento = oeGRRemitente.Serie & " - " & oeGRRemitente.Numero
                        oeMovimientoDocumento.IdTipoDocumento = oeGRRemitente.IdTipoGuia
                        oeMovimientoDocumento.FechaEmision = oeGRRemitente.Fecha
                        oeMovimientoDocumento.IdClienteProveedor = oeGRRemitente.IdEmpresaProveedor
                        oeMovimientoDocumento.NombreProveedor = oeGRRemitente.Nombre
                        oeMovimientoDocumento.Serie = oeGRRemitente.Serie
                        oeMovimientoDocumento.Numero = oeGRRemitente.Numero
                        oeMovimientoDocumento.IdEstadoDocumento = oeGRRemitente.IdEstado
                        oeMovimientoDocumento.EstadoDocumento = oeGRRemitente.Estado
                        oeMovimientoDocumento.Moneda = String.Empty
                        oeMovimientoDocumento.IdMoneda = String.Empty
                        oeMovimientoDocumento.SubTotal = 0.0
                        oeMovimientoDocumento.IGV = 0.0
                        oeMovimientoDocumento.Total = 0.0
                        oeMovimientoDocumento.TipoCambio = 0.0
                        oeMovimientoDocumento.TipoPago = String.Empty
                        oeMovimientoDocumento.IdTipoPago = String.Empty
                        oeOrden.TipoOperDocAsoc = "A"
                        lstMovimientoDocumentoAsoc.Add(oeMovimientoDocumento)
                        griOrdAsoc.DataBind()
                    Else
                        oeOrden.TipoOperDocAsoc = "I"
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CombosGrillas()
        oeUnidadMedida = New e_UnidadMedida
        CrearComboGrid("IdUnidadMedida", "Nombre", griOrdenMaterial, olUnidadMedida.ComboGrilla(oeUnidadMedida), True)
        oeSubAlmacen = New e_SubAlmacen
        oeSubAlmacen.TipoOperacion = "S"
        CrearComboGrid("IdSubAlmacen", "Nombre", griOrdenMaterial, olSubAlmacen.ComboGrilla(oeSubAlmacen), True)
    End Sub

    Private Sub QuitarMaterial()
        Try
            If lstMovimientoDocumentoAsoc.Count = 1 Then Exit Sub
            oeOrdenMaterial = New e_OrdenMaterial
            If griOrdenMaterial.Selected.Rows.Count > 0 Then
                oeOrdenMaterial = griOrdenMaterial.ActiveRow.ListObject
                If oeOrdenMaterial.TipoOperacion = "I" Then
                    loOrdenMaterial.Remove(oeOrdenMaterial)
                Else
                    oeOrdenMaterial.TipoOperacion = "E"
                    griOrdenMaterial.ActiveRow.Hidden = True
                End If
                griOrdenMaterial.DataSource = loOrdenMaterial
                griOrdenMaterial.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarDocumento()
        Try
            lstMovimientoDocumentoAsoc = New List(Of e_MovimientoDocumento)
            griOrdAsoc.DataSource = lstMovimientoDocumentoAsoc
            loOrdenMaterial = New List(Of e_OrdenMaterial)
            griOrdenMaterial.DataSource = loOrdenMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarMaterial()
        Try
            If Not listaMaterial.Where(Function(i) i.Seleccion = True).Count > 0 Then Throw New Exception("Seleccione Material Para Agregar a la Orden")
            For Each oe As e_Material In listaMaterial.Where(Function(i) i.Seleccion = True).ToList
                oeOrdenMaterial = New e_OrdenMaterial
                If loOrdenMaterial.Where(Function(i) i.IdMaterial = oe.Id).Count > 0 Then Throw New Exception("Material ya Agregado a la Orden")
                With oeOrdenMaterial
                    .Seleccion = False
                    .TipoOperacion = "I"
                    .IdMaterial = oe.Id
                    .Material = oe.Nombre
                    .CantidadMaterial = 1
                    .IdAlmacen = oe.IdAlmacen
                    .IdSubAlmacen = oe.IdSubAlmacen
                    .Almacen = oe.Almacen
                    .IdTipoUnidadMedida = oe.IdTipoUnidadMedida
                    .IdUnidadMedida = oe.IdUnidadMedida
                    .UnidadMedida = oe.UnidadMedida
                    .PrecioUnitario = ObtenerPrecioUnitario(oe.Id, oe.IdSubAlmacen)
                    .ValorVenta = oeOrdenMaterial.PrecioUnitario * oeOrdenMaterial.CantidadMaterial
                    .Activo = True
                    .CodigoMaterial = oe.Codigo
                End With
                loOrdenMaterial.Add(oeOrdenMaterial)
            Next
            griOrdenMaterial.DataSource = loOrdenMaterial
            griOrdenMaterial.DataBind()
            For Each oe As e_Material In listaMaterial
                oe.Seleccion = False
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarDocumento()
        Try
            If lstMovimientoDocumentoAsoc.Count = 1 Then Exit Sub
            oeMovimientoDocumento = New e_MovimientoDocumento
            oeMovimientoDocumento = griListaDoc.ActiveRow.ListObject
            lstMovimientoDocumentoAsoc.Add(oeMovimientoDocumento)
            ListarProveedores(cboProveedor, oeMovimientoDocumento.IdClienteProveedor)
            cboProveedor.Value = oeMovimientoDocumento.IdClienteProveedor
            If uceTipoDocumento.Value = "1CH000000027" Then
                oeGRRemitente = New e_GuiaRemisionRemitente
                oeGRRemitente.TipoOperacion = "G"
                oeGRRemitente.Id = griListaDoc.ActiveRow.Cells("Id").Value.ToString
                oeGRRemitente.Activo = True
                listaMaterial = olGRRemitente.ObtenerDetallesGr(oeGRRemitente)
                Dim oeMatNeg As New e_MaterialesNegociados
                Dim olMatNeg As New l_MaterialesNegociados
                oeMatNeg.TipoOperacion = "1"
                oeMatNeg.IdProveedor = oeMovimientoDocumento.IdClienteProveedor
                oeMatNeg = olMatNeg.Obtener(oeMatNeg)
                oeMaterialesNegociadosDet = New e_MaterialesNegociadosDet
                oeMaterialesNegociadosDet.TipoOperacion = "1"
                oeMaterialesNegociadosDet.IdMaterialesNegociados = oeMatNeg.Id
                loMaterialesNegociadosDet = New List(Of e_MaterialesNegociadosDet)
                loMaterialesNegociadosDet = olMaterialesNegociadosDet.Listar(oeMaterialesNegociadosDet)
            Else
                oeMovimientoDocumento = New e_MovimientoDocumento
                oeMovimientoDocumento.TipoOperacion = "CDO"
                oeMovimientoDocumento.Id = griListaDoc.ActiveRow.Cells("Id").Value.ToString
                oeMovimientoDocumento.Activo = True
                listaMaterial = olMovimientoDocumento.ListarDetallesPorDocumentos(oeMovimientoDocumento)
            End If
            For Each oe As e_Material In listaMaterial
                oeOrdenMaterial = New e_OrdenMaterial
                If loOrdenMaterial.Where(Function(i) i.IdMaterial = oe.Id).Count > 0 Then Throw New Exception("Material ya Agregado a la Orden")
                With oeOrdenMaterial
                    .Seleccion = False
                    .TipoOperacion = "I"
                    .IdMaterial = oe.Id
                    .Material = oe.Nombre
                    .CantidadMaterial = oe.Peso
                    .IdAlmacen = oe.IdAlmacen
                    .IdSubAlmacen = oe.IdSubAlmacen
                    .Almacen = oe.Almacen
                    .IdTipoUnidadMedida = oe.IdTipoUnidadMedida
                    .IdUnidadMedida = oe.IdUnidadMedida
                    .UnidadMedida = oe.UnidadMedida
                    If uceMovInventario.Value = "1CH000000037" Then
                        oeMaterialesNegociadosDet = New e_MaterialesNegociadosDet
                        oeMaterialesNegociadosDet.IdMaterial = oe.Id
                        If loMaterialesNegociadosDet.Contains(oeMaterialesNegociadosDet) Then
                            oeMaterialesNegociadosDet = loMaterialesNegociadosDet.Item(loMaterialesNegociadosDet.IndexOf(oeMaterialesNegociadosDet))
                            If oeMaterialesNegociadosDet.IdMoneda <> uceMoneda.Value Then
                                .PrecioUnitario = oeMaterialesNegociadosDet.Precio / TipoCambio(dtpFechaOrden.Value, 1)(0)
                            Else
                                .PrecioUnitario = oeMaterialesNegociadosDet.Precio
                            End If
                        Else
                            Throw New Exception("Material sin Precio Negociado. Verificar")
                        End If
                    Else
                        .PrecioUnitario = ObtenerPrecioUnitario(oe.Id, oe.IdSubAlmacen)
                    End If
                    .ValorVenta = .PrecioUnitario * .CantidadMaterial
                    .Activo = True
                    .CodigoMaterial = oe.Codigo
                End With
                loOrdenMaterial.Add(oeOrdenMaterial)
            Next
            griOrdenMaterial.DataSource = loOrdenMaterial
            griOrdenMaterial.DataBind()
            griOrdAsoc.DataBind()
            SeleccionTabs(0, ficDetalle, False)
        Catch ex As Exception
            lstMovimientoDocumentoAsoc = New List(Of e_MovimientoDocumento)
            Throw ex
        End Try
    End Sub

    Public Sub GuardarRegistroEditado()
        If RegistroEditado = 1 Then
            oeRegistroEditado = New e_RegistrosEditados
            With oeRegistroEditado
                .IdRegistro = griOrden.ActiveRow.Cells("Id").Value()
                .Referencia = "Orden"
                .UsuarioEdita = gUsuarioSGI.Id
            End With
            oeRegistroEditado.PrefijoID = gs_PrefijoIdSucursal '@0001
            IdRegistroEditado = olRegistroEditado.Guardar(oeRegistroEditado)
        End If
    End Sub

    Private Sub CalcularTotalesDetalle()
        numTotalOrden.Value = 0.0
        For Each obj As e_OrdenMaterial In loOrdenMaterial.Where(Function(i) i.TipoOperacion <> "E").ToList
            numTotalOrden.Value += obj.ValorVenta
        Next
    End Sub

    Public Function MostrarOrden(IdOrden As String) As Boolean
        InicializarLogicas()
        Operacion = "Ayuda"
        Try
            EditarOrden(IdOrden)
            SeleccionTabs(1, ficOIngreso)
            UltraGroupBox3.Enabled = False
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub GenerarAsiento()
        Try
            oeOrden = New e_Orden
            oeOrden.Id = griOrden.ActiveRow.Cells("Id").Value
            oeOrden = olOrden.Obtener(oeOrden)
            Select Case MessageBox.Show("¿Desea Generar el Asiento de la: " & oeOrden.NroOrden & "?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                Case Windows.Forms.DialogResult.Yes
                    oeOrden.TipoOperacion = "A"
                    oeOrdenMaterial = New e_OrdenMaterial
                    oeOrdenMaterial.TipoOperacion = "L"
                    oeOrdenMaterial.Activo = True
                    oeOrdenMaterial.IdOrden = oeOrden.Id
                    oeOrden.lstOrdenMaterial = olOrdenMaterial.Listar(oeOrdenMaterial)
                    EjecutarOrden(1)
                    oeOrden.lstInventario = New List(Of e_Inventario)
                    oeOrden.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olOrden.Guardar(oeOrden, New List(Of e_RegistroInventario)) Then
                        mensajeEmergente.Confirmacion("Se Genero el Asiento de la Orden: " & oeOrden.NroOrden & ", Correctamente.", True)
                    End If
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ImprimirOrden()
        Dim id As String = ""
        Try
            If griOrden.Selected.Rows.Count > 0 Then
                Dim formulario As New frm_ImprimirOrden
                id = griOrden.ActiveRow.Cells("Id").Value
                formulario.CargarDatos(id)
                formulario.ShowDialog()
                ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_OIngreso_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Select Case ficOIngreso.SelectedTab.Index
            Case 0
                Consultar(True)
            Case 1
              
        End Select
        ControlBotoneria()
    End Sub

    Private Sub frm_OIngreso_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_OIngreso_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_OIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            gf_AsignarEventoSeleccionarTexto(Me)
            gmt_ConfigurarEventoKeyEnter_Tab(Me, txtNroOrden.Name, txtBuscaMateriales.Name)
            fecDesde.Value = Date.Now.AddDays(-30)
            InicializarLogicas()
            CargarCombos()
            CombosGrillas()
            AsientoContable()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles cboProveedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            ListarProveedores(cboProveedor, "0", chkRuc.Checked)
        End If
    End Sub

    Private Sub cboProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboProveedor.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboProveedor.PerformAction(Infragistics.Win.UltraWinGrid.UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub cboProveedor_InitializeLayout(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboProveedor.InitializeLayout
        Me.cboProveedor.ValueMember = "Id"
        Me.cboProveedor.DisplayMember = "Nombre"
        With cboProveedor.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("Email").Hidden = True
            .Columns("Seleccion").Hidden = True
            .Columns("Contacto").Hidden = True
            .Columns("Codigo").Hidden = True
            .Columns("TipoPersonaEmpresa").Hidden = True
            .Columns("IdPersona").Hidden = True
            .Columns("IdEmpresa").Hidden = True
            .Columns("FechaActividad").Hidden = True
            .Columns("UsuarioCreacion").Hidden = True
            .Columns("Activo").Hidden = True
            .Columns("NroDocumento").Header.Caption = "N° RUC"
            .Columns("NroDocumento").Width = 50
            .Columns("Nombre").Width = 150
        End With
    End Sub

    Private Sub UltraButton2_Click(sender As Object, e As EventArgs) Handles UltraButton2.Click
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            ValidarFechaDesde_Hasta(fecInicioDoc, fecFinDoc)
            If uceTipoDocumento.Value <> "1CH000000027" Then
                oeMovimientoDocumento = New e_MovimientoDocumento
                With oeMovimientoDocumento
                    .FechaInicio = fecInicioDoc.Value
                    .FechaFinal = fecFinDoc.Value
                    .Activo = True
                    .IdTipoDocumento = uceTipoDocumento.Value
                    .IndCompraVenta = 1
                    .IndServicioMaterial = "M"
                    .TipoOperacion = "DSA"
                End With
                lstMovimientoDocumento = olMovimientoDocumento.ListarDocumentosPorCompras(oeMovimientoDocumento)
                griListaDoc.DataSource = lstMovimientoDocumento
            Else
                oeGRRemitente = New e_GuiaRemisionRemitente
                oeGRRemitente.TipoOperacion = "3"
                oeGRRemitente.IdTipoGuia = uceTipoDocumento.Value
                oeGRRemitente.fechaInicio = fecInicioDoc.Value
                oeGRRemitente.fechaFin = fecFinDoc.Value
                oeGRRemitente.Id = ""
                listaGRemision = olGRRemitente.Listar(oeGRRemitente)
                lstMovimientoDocumento = New List(Of e_MovimientoDocumento)
                griListaDoc.DataSource = lstMovimientoDocumento
                For Each obj As e_GuiaRemisionRemitente In listaGRemision
                    oeMovimientoDocumento = New e_MovimientoDocumento
                    oeMovimientoDocumento.Id = obj.Id
                    oeMovimientoDocumento.NombreDocumento = obj.Serie & " - " & obj.Numero
                    oeMovimientoDocumento.IdTipoDocumento = obj.IdTipoGuia
                    oeMovimientoDocumento.FechaEmision = obj.Fecha
                    oeMovimientoDocumento.IdClienteProveedor = obj.IdEmpresaProveedor
                    oeMovimientoDocumento.NombreProveedor = obj.Nombre
                    oeMovimientoDocumento.Serie = obj.Serie
                    oeMovimientoDocumento.Numero = obj.Numero
                    oeMovimientoDocumento.IdEstadoDocumento = obj.IdEstado
                    oeMovimientoDocumento.EstadoDocumento = obj.Estado
                    oeMovimientoDocumento.Moneda = String.Empty
                    oeMovimientoDocumento.IdMoneda = String.Empty
                    oeMovimientoDocumento.SubTotal = 0.0
                    oeMovimientoDocumento.IGV = 0.0
                    oeMovimientoDocumento.Total = 0.0
                    oeMovimientoDocumento.TipoCambio = 0.0
                    oeMovimientoDocumento.TipoPago = String.Empty
                    oeMovimientoDocumento.IdTipoPago = String.Empty
                    lstMovimientoDocumento.Add(oeMovimientoDocumento)
                Next
                griListaDoc.DataSource = lstMovimientoDocumento
            End If
            griListaDoc.DisplayLayout.Bands(0).Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaMateriales_InitializeLayout(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griListaMateriales.InitializeLayout
        With griListaMateriales
            .DisplayLayout.Bands(0).SortedColumns.Add("CodigoNombre", False, True)
            .DisplayLayout.GroupByBox.Hidden = True
            .DisplayLayout.GroupByBox.Style = Infragistics.Win.UltraWinGrid.GroupByBoxStyle.Compact
        End With
    End Sub

    Private Sub UltraButton1_Click(sender As Object, e As EventArgs) Handles UltraButton1.Click
        Try
            ListarMateriales()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub rbDatosAdicionales_CheckedChanged(sender As Object, e As EventArgs) Handles rbDatosAdicionales.CheckedChanged
        gbDatosAdicionales.Enabled = rbDatosAdicionales.Checked
        txtNroOrden.Text = String.Empty
    End Sub

    Private Sub rbNroOrden_CheckedChanged(sender As Object, e As EventArgs) Handles rbNroOrden.CheckedChanged
        gbOI.Enabled = rbNroOrden.Checked
        txtNroOrden.Focus()
        uceMovFiltro.SelectedIndex = 0
        uceEstadoOrden.SelectedIndex = 0
        fecHasta.Value = Date.Now
    End Sub

    Private Sub griOrden_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles griOrden.DoubleClickRow
        If griOrden.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub uceMovInventario_ValueChanged(sender As Object, e As EventArgs) Handles uceMovInventario.ValueChanged
        Try
            uceMoneda.Value = "1CH01"
            loOrdenMaterial = New List(Of e_OrdenMaterial)
            griOrdenMaterial.DataSource = loOrdenMaterial
            lstMovimientoDocumentoAsoc = New List(Of e_MovimientoDocumento)
            griOrdAsoc.DataSource = lstMovimientoDocumentoAsoc
            Select Case uceMovInventario.Value
                Case "1CH000000037", "1CH000000035"
                    uebDocumento.Expanded = True
                    ficDetalle.Tabs(1).Selected = True
                    uegMateriales.Enabled = False
                    uegMateriales.Expanded = False
                    If uceMovInventario.Value = "1CH000000037" Then uceMoneda.Value = "1CH02"
                    ControlGrillaDetalle(1)
                Case "1SI000000002", "1CH000000021", "CHC000000001"
                    uebDocumento.Expanded = False
                    ficDetalle.Tabs(0).Selected = True
                    uegMateriales.Enabled = True
                    uegMateriales.Expanded = True
                    ListarProveedores(cboProveedor, gs_IdClienteProveedorSistema.Trim)
                    cboProveedor.Value = gs_IdClienteProveedorSistema.Trim
                    ControlGrillaDetalle(0)
                Case Else
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ControlGrillaDetalle(Tipo As Integer)
        Try
            With griOrdenMaterial
                If Tipo = 1 Then
                    .DisplayLayout.Bands(0).Columns("CantidadMaterial").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    .DisplayLayout.Bands(0).Columns("PrecioUnitario").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    .DisplayLayout.Bands(0).Columns("CantidadMaterial").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
                    .DisplayLayout.Bands(0).Columns("PrecioUnitario").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
                Else
                    .DisplayLayout.Bands(0).Columns("CantidadMaterial").CellActivation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit
                    .DisplayLayout.Bands(0).Columns("PrecioUnitario").CellActivation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit
                    .DisplayLayout.Bands(0).Columns("CantidadMaterial").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
                    .DisplayLayout.Bands(0).Columns("PrecioUnitario").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
                End If
            End With        
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Select Case ficDetalle.SelectedTab.Index
                Case 0
                    AgregarMaterial()
                Case 1
                    AgregarDocumento()
            End Select
            CalcularTotalesDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Try
            Select Case ficDetalle.SelectedTab.Index
                Case 0
                    If griOrdenMaterial.Selected.Rows.Count > 0 Then QuitarMaterial()
                Case 1
                    If griOrdAsoc.Selected.Rows.Count > 0 Then QuitarDocumento()
            End Select
            CalcularTotalesDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaMateriales_CellChange(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaMateriales.CellChange
        griListaMateriales.UpdateData()
    End Sub

    Private Sub griListaDoc_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles griListaDoc.DoubleClickRow
        Try
            AgregarDocumento()
            CalcularTotalesDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griOrden_AfterRowActivate(sender As Object, e As EventArgs) Handles griOrden.AfterRowActivate
        btnEjecutar.Enabled = 0
        btnRectificar.Enabled = 0
        If griOrden.ActiveRow.Index > -1 Then
            Select Case griOrden.ActiveRow.Cells("EstadoOrden").Value
                Case "GENERADA"
                    Select Case griOrden.ActiveRow.Cells("TipoReferencia").Value
                        Case "ORDEN TRABAJO", "ORDEN ASIGNACION", "ORDEN DE TRANSFERENCIA", "ORDEN VENTA", ""
                            btnEjecutar.Enabled = 1
                    End Select
                Case "RECEPCIONADO", "TERMINADA"
                        btnEjecutar.Enabled = 0
                        btnRectificar.Enabled = 1
            End Select
        End If
    End Sub

    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Try
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "EJECUTAR ORDENES") Then
                Editar()
                Operacion = "Ejecutar"
                oeOrden.TipoOperacion = "T"
                uceMovInventario.ReadOnly = True
                Me.lbl_etiqueta.Text = "Ejecutar OI"
                Me.lbl_etiqueta.Visible = True
            Else
                Throw New Exception("No Tiene Permiso para Ejecutar Ordenes")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnRectificar_Click(sender As Object, e As EventArgs) Handles btnRectificar.Click
        Try
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "RECTIFICAR OI,OS") Then
                Editar()
                Operacion = "Rectificar"
                ControlBotoneria()
                ControlGrillaDetalle(0)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griOrdenMaterial_AfterCellUpdate(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griOrdenMaterial.AfterCellUpdate
        Try
            With griOrdenMaterial.Rows(e.Cell.Row.Index)
                Select Case e.Cell.Column.Key
                    Case "CantidadMaterial"
                        If IsDBNull(e.Cell.Value) Then
                            .Cells("CantidadMaterial").Value = 0
                            Exit Sub
                        End If
                    Case "PrecioUnitario"
                        If IsDBNull(e.Cell.Value) Then
                            .Cells("PrecioUnitario").Value = 0
                            Exit Sub
                        End If
                End Select
                If Operacion = "Rectificar" Then .Cells("Seleccion").Value = True
                .Cells("ValorVenta").Value = Math.Round(.Cells("PrecioUnitario").Value * .Cells("CantidadMaterial").Value, 4)
            End With
            CalcularTotalesDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griOrdenMaterial_CellChange(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griOrdenMaterial.CellChange
        griOrdenMaterial.UpdateData()
    End Sub

    Private Sub txtNroOrden_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroOrden.KeyDown
        If e.KeyCode = Keys.Enter Then
            Consultar(True)
        End If
    End Sub

    Private Sub txtBuscaMateriales_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscaMateriales.KeyDown
        If e.KeyCode = Keys.Enter Then
            ListarMateriales()
        End If
    End Sub

    Private Sub griOrdenMaterial_BeforeRowsDeleted(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griOrdenMaterial.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griOrdenMaterial_KeyDown(sender As Object, e As KeyEventArgs) Handles griOrdenMaterial.KeyDown
        Try
            With griOrdenMaterial
                Dim int As Integer = .ActiveRow.Index
                If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
                    If .Rows(int).Cells("PrecioUnitario").IsActiveCell Then
                        .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ExitEditMode, False, False)
                        .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.BelowCell, False, False)
                        e.Handled = True
                        .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                    End If
                    If .Rows(int).Cells("CantidadMaterial").IsActiveCell Then
                        .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ExitEditMode, False, False)
                        .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.BelowCell, False, False)
                        e.Handled = True
                        .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                    End If
                End If
                If e.KeyCode = Keys.Up Then
                    If .Rows(int).Cells("PrecioUnitario").IsActiveCell Then
                        .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ExitEditMode, False, False)
                        .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.AboveCell, False, False)
                        e.Handled = True
                        .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                    End If
                    If .Rows(int).Cells("CantidadMaterial").IsActiveCell Then
                        .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ExitEditMode, False, False)
                        .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.AboveCell, False, False)
                        e.Handled = True
                        .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                    End If
                End If
                If e.KeyValue = Keys.Space Then
                    .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ExitEditMode, 0, 0)
                    .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, 0, 0)
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnGenerarAsiento_Click(sender As Object, e As EventArgs) Handles btnGenerarAsiento.Click
        Try
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "EXTORNAR ASIENTO") Then
                If griOrden.Selected.Rows.Count > 0 Then GenerarAsiento()
            Else
                Throw New Exception("No Tiene Permisos Para Generar Asientos")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Asiento Modelo"

    Private Sub AsientoContable()
        AsientoModelo()
        CtaCtbleSubFamilia()
        dtReferencia = New DataTable
        If loReferencia.Count > 0 Then dtReferencia = GeneraDTRef(loReferencia)
    End Sub

    Private Sub AsientoModelo()
        oeAsientoModelo = New e_AsientoModelo
        loAsientoModelo = New List(Of e_AsientoModelo)
        oeAsientoModelo.TipoOperacion = "A" : oeAsientoModelo.Activo = True : oeAsientoModelo.Nombre = pIdActividadNegocio
        loAsientoModelo = olAsientoModelo.Listar(oeAsientoModelo)

        oeReferencia = New e_AsientoModelo_Referencia
        loReferencia = New List(Of e_AsientoModelo_Referencia)
        oeReferencia.TipoOperacion = "N" : oeReferencia.Activo = True : oeReferencia.IdReferencia = pIdActividadNegocio
        loReferencia = olReferencia.Listar(oeReferencia)
    End Sub

    Private Sub CtaCtbleSubFamilia()
        oeCtaCtbleSFam = New e_CtaCtbleSubFamiliaMat
        loCtaCtbleSFam = olCtaCtbleSFam.Listar(oeCtaCtbleSFam)
    End Sub

    Public Sub ObtenerAsientoModelo(IdMoneda As String, Ejercicio As Integer)
        Try
            Dim dtAux = New Data.DataTable
            Dim _rwAux() As Data.DataRow
            Dim cadSQL As String = String.Empty
            cadSQL = "TipoRef1 = 4 AND IdRef1 = '" & IdMoneda & "'"
            _rwAux = dtReferencia.Select(cadSQL, "")
            If _rwAux.Count = 0 Then Throw New Exception("Error en el Modelo de Asiento Contable. Verificar")
            dtAux = _rwAux.CopyToDataTable
            oeAsientoModelo = New e_AsientoModelo
            oeAsientoModelo.TipoOperacion = "" : oeAsientoModelo.Activo = True
            oeAsientoModelo.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
            oeAsientoModelo.Ejercicio = Ejercicio
            oeAsientoModelo = olAsientoModelo.Obtener(oeAsientoModelo)
            oeOrden.loAsientoModelo = New List(Of e_AsientoModelo)
            oeOrden.loAsientoModelo.Add(oeAsientoModelo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class