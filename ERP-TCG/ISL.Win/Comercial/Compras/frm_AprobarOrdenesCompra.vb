'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios Centro y Giro
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource

Public Class frm_AprobarOrdenesCompra
    Inherits frm_MenuPadre

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_AprobarOrdenesCompra = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_AprobarOrdenesCompra()
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaración de variables"

    Dim oeFecha As New e_Fechas
    Dim oeOrdenCompra As New e_OrdenCompra
    Dim llOrdenCompra As New List(Of e_OrdenCompra)

    Dim olOrdenCompra As New l_OrdenCompra
    Dim oeOrdenCompraMaterial As New e_OrdenCompraMaterial
    Dim olOrdenCompraMaterial As New l_OrdenCompraMaterial
    Dim llOrdenCompraMaterial As New List(Of e_OrdenCompraMaterial)

    'Dim llHistorialCompras As New List(Of e_OrdenCompraMaterial)

    Dim oeOrdenCompraServicio As New e_OrdenCompraServicio
    Dim olOrdenCompraServicio As New l_OrdenCompraServicio
    Dim llOrdenCompraServicio As New List(Of e_OrdenCompraServicio)


    Dim oeProveedor As New e_Proveedor
    Dim olProveedor As New l_Proveedor
    Dim llProveedores As New List(Of e_Proveedor)

    Dim oeMoneda As New e_Moneda
    Dim olMoneda As New l_Moneda
    Dim llMoneda As New List(Of e_Moneda)

    'Dim oeBanco As New e_Banco
    'Dim olBanco As New l_Banco

    Dim oeTipoOrdenCompra As New e_TipoOrdenCompra, olTipoOrdenCompra As New l_TipoOrdenCompra
    Dim lstTipoOC As New List(Of e_TipoOrdenCompra)

    Dim oeTipoPago As New e_TipoPago
    Dim olTipoPago As New l_TipoPago
    Dim llTipoPago As New List(Of e_TipoPago)

    Private IdTipoOrdenCompra As String = ""

    Dim oeCentro As New e_Centro
    Dim olCentro As New l_Centro

    Dim oeCuentaBancaria As New e_CuentaBancaria
    Dim olCuentaBancaria As New l_CuentaBancaria

    Dim oeRequerimientoMaterial As New e_RequerimientoMaterial
    Dim olRequerimientoMaterial As New l_RequerimientoMaterial
    Dim llRequerimientoMaterial As New List(Of e_RequerimientoMaterial)

    Dim llRequerimientoServicio As New List(Of e_RequerimientoServicio)
    Dim oeRequerimientoServicio As New e_RequerimientoServicio()

    Dim olArea As New l_Area
    Dim oeArea As New e_Area
    Dim olUsuario As New l_Usuario
    Dim oeUsuario As New e_Usuario
    Dim oeIGV As New e_Impuesto
    Dim olIGV As New l_Impuesto

    Dim _IndiceTipoOrdenCompra As Integer = 1 '1: Orden de compra de material --- 0:Orden de compra de servicios

    Dim _IdTipoOrden As String = "1CH000000006" 'Indica el tipo de orden Compra

    Dim _Estado As String = "Por generar" 'Para cuando que registrar por primera vez el estado de la orden pasará a generado.        
    Dim _IdEstadoOrden As String  '"1CH000000001" :Estado Generado.             

    Dim montoMaxOC As Double = 200 'Monto total máximo con la que la orden puede aprobarse de manera automática.    

    Dim totalSinIgv As Double = 0.0
    Dim totalIgv As Double = 0.0
    Dim totalConIng As Double = 0.0

    '------------Variables para controlar si se incluye o no el IGV.------------------
    Dim swIgv As Boolean
    Dim codigoMaterial As String
    Dim codigoRequerimiento As String
    '---------------------------------------------------------------------------------

    Dim oeEstado As New e_EstadoOrden, olEstado As New l_EstadoOrden
    Dim llEstado As New List(Of e_EstadoOrden)

    Dim tipoOperacion As String

    Dim _ingresando_datos As Boolean = False

    Dim oeTrabSeg As New e_TrabajadorSeguridad
    Dim olTrabSeg As New l_TrabajadorSeguridad

    Dim oeTrab As New e_Trabajador
    Dim olTrab As New l_Trabajador
    Dim leTrab As New List(Of e_Trabajador)

#End Region

#Region "BOTONES"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try

            Operacion = "Inicializa"            
            LimpiarListas()
            MostrarFichaDetalleOrden()
            Listar(Activo)
            Tiempo1.Enabled = True
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try


    End Sub

    Public Overrides Sub Nuevo()

        'LimpiarListas(True)
        'LimpiarControles()
        'Operacion = "Nuevo"
        'MostrarTabs(1, ficRequerimiento, 1)
        'ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)

    End Sub

    Public Overrides Sub Editar()

        'LimpiarListas(True)
        Operacion = "Editar"
        EditarOrdenCompra()
        'If EditarOrdenCompra() Then
        '    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        'End If
    End Sub

    Public Overrides Sub Guardar()

    End Sub

    Public Overrides Sub Cancelar()
        Try

            If oeOrdenCompra.Modificado Then

                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)

                    Case Windows.Forms.DialogResult.Yes

                        If GuardarOrdenCompra() Then
                            MostrarTabs(0, ficRequerimiento, 2)
                            _ingresando_datos = False
                            Consultar(True)
                        Else
                            _ingresando_datos = True
                        End If

                    Case Windows.Forms.DialogResult.No

                        MostrarTabs(0, ficRequerimiento, 2)
                        _ingresando_datos = False
                        Consultar(True)

                    Case Windows.Forms.DialogResult.Cancel

                        _ingresando_datos = True

                End Select

            Else

                MostrarTabs(0, ficRequerimiento, 2)
                _ingresando_datos = False
                Consultar(True)

            End If

            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Function EditarOrdenCompra() As Boolean

        Dim id As String
        Try

            With griListaOrdenCompra

                '_Estado = .ActiveRow.Cells("EstadoOrden").Value
                id = .ActiveRow.Cells("Id").Value.ToString
                'If Trim(_Estado) = "GENERADA" Then

                If id.Length > 0 Then
                    oeOrdenCompra = New e_OrdenCompra
                    oeOrdenCompra.Id = id
                    oeOrdenCompra.Activo = .ActiveRow.Cells("Activo").Value.ToString
                    oeOrdenCompra.TipoOperacion = "1"
                    oeOrdenCompra.IdMoneda = "CERO"
                    oeOrdenCompra.IdProveedor = "CERO"
                    oeOrdenCompra.IdEstadoOrden = "CERO"
                    oeOrdenCompra.IdTipoPago = "CERO"
                    oeOrdenCompra.PrefijoID = gs_PrefijoIdSucursal '@0001
                    oeOrdenCompra = olOrdenCompra.Obtener(oeOrdenCompra)
                    IdTipoOrdenCompra = oeOrdenCompra.IdTipoOrdenCompra
                    If oeOrdenCompra.Activo Then

                        txtNumeroOrden.Value = oeOrdenCompra.NroOrden
                        txtNumeroOrden.ReadOnly = True
                        txtFechaOrden.Value = oeOrdenCompra.FechaOrden
                        txtFechaOrden.ReadOnly = True
                        txtProveedor.Value = oeOrdenCompra.NombreProveedor
                        txtProveedor.ReadOnly = True
                        oeOrdenCompra.TipoOperacion = "A"
                        oeOrdenCompra.PrefijoID = gs_PrefijoIdSucursal '@0001
                        ConsultarDetalleOrdenCompra(True)

                        Return True
                    Else
                        Throw New Exception(Me.Text & ": El Registro se encuentra eliminado y no se puede editar")
                    End If
                Else
                    Throw New Exception("Seleccione una Fila!")
                End If

                'End If

            End With

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Function

    ''' <summary>
    ''' Muestra el Detalle de la Orden de acuerdo al tipo de Orden de Compra actual (Id)
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub MostrarFichaDetalleOrden()
        If IdTipoOrdenCompra = "1PK000000001" Then
            ficDetalle.Tabs(0).Selected = True
            ficDetalle.Tabs(0).Enabled = True
            ficDetalle.Tabs(1).Enabled = False
        Else
            ficDetalle.Tabs(1).Selected = True
            ficDetalle.Tabs(1).Enabled = True
            ficDetalle.Tabs(0).Enabled = False
        End If
    End Sub

    Public Sub ConsultarDetalleOrdenCompra(ByVal Activo As Boolean)

        Try

            MostrarFichaDetalleOrden()
            If IdTipoOrdenCompra = "1PK000000001" Then
                listarDetalleOrdenCompraMaterial(Activo)
            Else
                listarDetalleOrdenCompraServicio(Activo)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub listarDetalleOrdenCompraMaterial(ByVal Activo As Boolean)
        Try

            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            oeOrdenCompraMaterial = New e_OrdenCompraMaterial
            With griListaDetalleOrdenCompraMaterial
                oeOrdenCompraMaterial.TipoOperacion = "1"
                oeOrdenCompraMaterial.Activo = Activo
                oeOrdenCompraMaterial.IdOrden = oeOrdenCompra.Id
                oeOrdenCompraMaterial.PrefijoID = gs_PrefijoIdSucursal '@0001
                llOrdenCompraMaterial = olOrdenCompraMaterial.Listar(oeOrdenCompraMaterial)
                .DataSource = llOrdenCompraMaterial
            End With

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
        griListaDetalleOrdenCompraMaterial.Focus()

    End Sub

    Public Sub listarDetalleOrdenCompraServicio(ByVal Activo As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeOrdenCompraServicio = New e_OrdenCompraServicio
            With griListaDetalleOrdenCompraServicio
                oeOrdenCompraServicio.Activo = Activo
                oeOrdenCompraServicio.IdOrden = oeOrdenCompra.Id
                oeOrdenCompraServicio.PrefijoID = gs_PrefijoIdSucursal '@0001
                llOrdenCompraServicio = olOrdenCompraServicio.Listar(oeOrdenCompraServicio)
                .DataSource = llOrdenCompraServicio
            End With

        Catch ex As Exception
            Throw ex
        End Try

        If griListaDetalleOrdenCompraServicio.Rows.Count > 0 Then griListaDetalleOrdenCompraServicio.Focus()

    End Sub


    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griListaOrdenCompra.Rows.Count = 0 Then Throw New Exception("No hay ninguna Orden de Compra para Aprobar para exportar al Excel")
            Exportar_Excel(griListaOrdenCompra)

            If ficDetalle.Tabs(0).Selected AndAlso griListaDetalleOrdenCompraMaterial.Rows.Count = 0 Then Throw New Exception("No hay ninguna Orden de Compra de Material para exportar al Excel")
            If ficDetalle.Tabs(0).Selected Then Exportar_Excel(griListaDetalleOrdenCompraMaterial)

            If ficDetalle.Tabs(1).Selected AndAlso griListaDetalleOrdenCompraServicio.Rows.Count = 0 Then Throw New Exception("No hay ninguna Orden de Compra de Servicio para exportar al Excel")
            If ficDetalle.Tabs(1).Selected Then Exportar_Excel(griListaDetalleOrdenCompraServicio)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub


#End Region

#Region "Métodos"

    Public Function GuardarOrdenCompra() As Boolean
        Try
            Dim oeMatNeg As New e_MaterialesNegociados
            Dim olMatNeg As New l_MaterialesNegociados
            Dim oeMatNegDet As New e_MaterialesNegociadosDet
            Dim olMatNegDet As New l_MaterialesNegociadosDet
            Dim loMatNegDet As New List(Of e_MaterialesNegociadosDet)
            Dim oeOrdComMat As New e_OrdenCompraMaterial
            Dim olOrdComMat As New l_OrdenCompraMaterial
            Dim loOrdCom As New List(Of e_OrdenCompra)
            loOrdCom = llOrdenCompra.Where(Function(item) item.IndicadorAprobacion = True).ToList
            For Each ordencompra As e_OrdenCompra In loOrdCom
                oeMatNeg.TipoOperacion = "1"
                oeMatNeg.IdProveedor = ordencompra.IdProveedor
                oeOrdComMat.IdOrden = ordencompra.Id
                oeOrdComMat.TipoOperacion = "1"
                oeOrdComMat.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeMatNeg = olMatNeg.Obtener(oeMatNeg)
                oeMatNeg.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeMatNegDet.IdMaterialesNegociados = oeMatNeg.Id
                oeMatNegDet.TipoOperacion = "1"
                oeMatNegDet.FechaCreacion = Date.Parse("01/01/1901")
                oeMatNegDet.PrefijoID = gs_PrefijoIdSucursal '@0001
                loMatNegDet = olMatNegDet.Listar(oeMatNegDet)
                If loMatNegDet.Count = 0 Then
                    oeMatNeg.IdProveedor = gs_IdClienteProveedorSistema.Trim '@0001
                    oeMatNeg = olMatNeg.Obtener(oeMatNeg)
                    oeMatNegDet.IdMaterialesNegociados = oeMatNeg.Id
                    loMatNegDet = olMatNegDet.Listar(oeMatNegDet)
                End If
                Dim CBO As String = ordencompra.IdMoneda
                ordencompra.lstOrdenMaterial = olOrdComMat.Listar(oeOrdComMat)
                ordencompra.PrefijoID = gs_PrefijoIdSucursal '@0001
                For Each material As e_OrdenCompraMaterial In ordencompra.lstOrdenMaterial
                    For Each matnegdet As e_MaterialesNegociadosDet In loMatNegDet
                        If material.IdMaterial = matnegdet.IdMaterial Then
                            If ordencompra.IdMoneda <> matnegdet.IdMoneda Then
                                Dim preciomat As Double = 0
                                If ordencompra.IdMoneda <> "1CH01" Then
                                    preciomat = material.PrecioUnitario * TipoCambio(ordencompra.FechaOrden, 1)(0)
                                Else
                                    preciomat = material.PrecioUnitario / TipoCambio(ordencompra.FechaOrden, 1)(0)
                                End If
                                If preciomat > matnegdet.Precio Then
                                    mensajeEmergente.Problema("Precio no Coincide con Precio Negociado y/o Precio Maximo Permitido", True)
                                    Return False
                                End If
                            Else
                                If material.PrecioUnitario > matnegdet.Precio Then
                                    mensajeEmergente.Problema("Precio no Coincide con Precio Negociado y/o Precio Maximo Permitido", True)
                                    Return False
                                End If
                            End If
                        End If
                    Next
                    If ordencompra.lstOrdenMaterial.Count = 1 Then
                        If material.Material = "DIESEL D2" Then
                            If PermisoCombustible() = False Then
                                mensajeEmergente.Problema("No tiene Permiso para Aprobar el Monto para OC de Combustible", True)
                                Return False
                            Else
                                If oeTrabSeg.CantidadLimite <= ordencompra.Total Then
                                    mensajeEmergente.Problema("No tiene Permiso para Aprobar el Monto para OC de Combustible", True)
                                    Return False
                                Else
                                    ordencompra.IdEstadoOrden = "1CH000000011"
                                End If
                            End If
                        Else
                            If ordencompra.Total >= 5000 Then
                                If PermisoPreAprobado() = True Then
                                    ordencompra.IdEstadoOrden = "1CH000000011"
                                Else
                                    ordencompra.IdEstadoOrden = "1CH000000002"
                                End If
                            Else
                                ordencompra.IdEstadoOrden = "1CH000000011"
                            End If
                        End If
                    Else
                        If ordencompra.Total >= 5000 Then
                            If PermisoPreAprobado() = True Then
                                ordencompra.IdEstadoOrden = "1CH000000011"
                            Else
                                ordencompra.IdEstadoOrden = "1CH000000002"

                            End If
                        Else
                            ordencompra.IdEstadoOrden = "1CH000000011"
                        End If
                    End If
                Next
            Next
            olOrdenCompra.GuardarLista(llOrdenCompra, tipoOperacion, gUsuarioSGI.IdTrabajador, gUsuarioSGI.Id)
            olOrdenCompraMaterial.GuardarLista(llOrdenCompraMaterial)
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
            Consultar(True)
            Return True

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Function

    Public Sub InicializarControlesLista()
        cboMaterialServicio.SelectedIndex = 0
        cboFormaBusqueda.SelectedIndex = 0
        'rfOrden.Desde = Date.Now
        'rfOrden.Hasta = Date.Now
    End Sub

    Private Function PermisoPreAprobado() As Boolean
        oeTrabSeg = New e_TrabajadorSeguridad
        oeTrabSeg.IdTrabajador = gUsuarioSGI.IdTrabajador
        oeTrabSeg.TipoOperacion = "H"
        oeTrabSeg.NombreProceso = "APROBACION DEL PRE-APROBADO"
        oeTrabSeg = olTrabSeg.Obtener(oeTrabSeg)
        If oeTrabSeg.IdTrabajador = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function PermisoCombustible() As Boolean
        oeTrabSeg = New e_TrabajadorSeguridad
        oeTrabSeg.IdTrabajador = gUsuarioSGI.IdTrabajador
        oeTrabSeg.TipoOperacion = "H"
        oeTrabSeg.NombreProceso = "APROBAR ORDENES DE DIESEL"
        oeTrabSeg = olTrabSeg.Obtener(oeTrabSeg)
        If oeTrabSeg.IdTrabajador = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub LlenaCombos()

        oeEstado.Id = "CERO"
        oeEstado.Nombre = "TODOS"
        llEstado.Add(oeEstado)
        oeEstado = New e_EstadoOrden
        oeEstado.Activo = True
        oeEstado.TipoOperacion = "2"
        llEstado.AddRange(olEstado.Listar(oeEstado))
        LlenarComboMaestro(cboEstadoOrden, llEstado, 3)
        _IdEstadoOrden = cboEstadoOrden.Value
        cboEstadoOrden.SelectedIndex = 0


        'oeTipoOrdenCompra.Activo = True
        'LlenarComboMaestro(cboMaterialServicio, olTipoOrdenCompra.Listar(oeTipoOrdenCompra), 0)
        oeTipoOrdenCompra.Id = "CERO" : oeTipoOrdenCompra.Nombre = "TODOS"
        lstTipoOC.Add(oeTipoOrdenCompra)
        oeTipoOrdenCompra = New e_TipoOrdenCompra
        oeTipoOrdenCompra.Activo = True
        lstTipoOC.AddRange(olTipoOrdenCompra.Listar(oeTipoOrdenCompra))
        LlenarComboMaestro(cboMaterialServicio, lstTipoOC, 0)

        'oeCentro.Activo = True
        'LlenarComboMaestro(cboCentroL, olCentro.Listar(oeCentro), 0)

        oeTrab = New e_Trabajador
        oeTrab.TipoOperacion = "P"
        leTrab.AddRange(olTrab.Listar(oeTrab))

    End Sub

    Private Sub Inicializar()

        Try

            'Para las cabezeras
            ColoresGenerado.Color = Blanco
            ColoresEvaluado.Color = Kaki
            ColoresAtendidoParcialmente.Color = Color.PowderBlue
            ColoresAtendido.Color = VerdeClaro
            ColoresRechazado.Color = Coral

            'Obtener la información del área del usuario        
            oeUsuario.Id = gUsuarioSGI.Id
            oeUsuario = olUsuario.Obtener(oeUsuario)
            oeArea = olUsuario.Area(oeUsuario)

            'Carga los valores por defecto del rango de fechas
            rfOrdenDesde.Value = Date.Now.AddDays(-30)
            rfOrdenHasta.Value = Date.Now
            btnAprobar.Enabled = False
            btnRechazar.Enabled = False
            'gbeListadoHistorial.Expanded = True
            gbeListadoHistorial.Height = 250
            verLimites.Checked = True

            InicializarControlesLista()
            LlenaCombos()
            LimpiarListas()
            MostrarFichaDetalleOrden()
            AsociarMenu()

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeOrdenCompra = New e_OrdenCompra
            ValidarFechaDesde_Hasta(rfOrdenDesde, rfOrdenHasta)
            oeOrdenCompra.Activo = Activo
            oeOrdenCompra.IdEstadoOrden = cboEstadoOrden.Value
            oeOrdenCompra.IdTipoOrdenCompra = cboMaterialServicio.Value
            oeFecha.OpcionFecha = cboFormaBusqueda.Value
            oeFecha.FechaInicio = rfOrdenDesde.Value
            oeFecha.FechaFin = rfOrdenHasta.Value
            If verLimites.Checked Then
                oeOrdenCompra._CantMax = oeTrabSeg.CantidadLimite
                oeOrdenCompra._CantMin = oeTrabSeg.CantidadMinima
            Else
                oeOrdenCompra._CantMax = -1
                oeOrdenCompra._CantMin = -1
            End If
            'oeOrdenCompra.IndicadorMaterial = IIf(cboMaterialServicio.Value = "M", 1, 0)
            'oeOrdenCompra.IndicadorServicio = IIf(cboMaterialServicio.Value = "S", 1, 0)
            oeOrdenCompra.TipoOperacion = "2"
            oeOrdenCompra.PrefijoID = gs_PrefijoIdSucursal '@0001
            With griListaOrdenCompra
                llOrdenCompra = olOrdenCompra.Listar(oeOrdenCompra, oeFecha)
                'agrOrdenCompra.Text = "OrdenCompra : " & .Rows.Count
                .DataSource = llOrdenCompra
            End With

            For Each fila As UltraGridRow In griListaOrdenCompra.Rows
                Select Case fila.Cells("EstadoOrden").Value
                    Case "GENERADA"
                        fila.CellAppearance.BackColor = Me.ColoresGenerado.Color
                    Case "EVALUADA"
                        fila.CellAppearance.BackColor = Me.ColoresEvaluado.Color
                    Case "ATENDIDO PARCIALMENTE"
                        fila.CellAppearance.BackColor = Me.ColoresAtendidoParcialmente.Color
                    Case "TERMINADA"
                        fila.CellAppearance.BackColor = Me.ColoresAtendido.Color
                    Case "RECHAZADA"
                        fila.CellAppearance.BackColor = Me.ColoresRechazado.Color
                End Select
            Next

            If cboEstadoOrden.Text = "GENERADA" Then
                controlaColumnasGriDetOC(False)
            Else
                controlaColumnasGriDetOC(True)
            End If
            CargarMenuContextual()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Private Sub LimpiarListas()

        llOrdenCompra.Clear()
        llOrdenCompraMaterial.Clear()
        llOrdenCompraServicio.Clear()

        griListaOrdenCompra.DataSource = llOrdenCompra
        griListaDetalleOrdenCompraMaterial.DataSource = llOrdenCompraMaterial
        griListaDetalleOrdenCompraServicio.DataSource = llOrdenCompraServicio

        With griListaDetalleOrdenCompraMaterial
            .DisplayLayout.Bands(0).Columns("CantidadMaterialAAtender").Hidden = True
            .DisplayLayout.Bands(0).Columns("CantidadMaterialPendiente").Hidden = True
        End With



    End Sub

    Private Sub controlaColumnasGriDetOC(ByVal valorCantAtenderHidden As Boolean)
        griListaOrdenCompra.DisplayLayout.Bands(0).Columns("IndicadorAprobacion").Hidden = valorCantAtenderHidden
        griListaOrdenCompra.DisplayLayout.Bands(0).Columns("NombreSubEstado").Hidden = Not valorCantAtenderHidden
    End Sub

    Public Sub CargarMenuContextual()
        Try
            If oeOrdenCompra.VerificarOrdenCompra(llOrdenCompra) = 0 Then
                MenuContextual1.Items("AprobarToolStripMenuItem").Enabled = False
                MenuContextual1.Items("RechazarToolStripMenuItem").Enabled = False
                btnAprobar.Enabled = False
                btnRechazar.Enabled = False
            Else
                MenuContextual1.Items("AprobarToolStripMenuItem").Enabled = True
                MenuContextual1.Items("RechazarToolStripMenuItem").Enabled = True
                btnAprobar.Enabled = True
                btnRechazar.Enabled = True
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub ListarHistorialCompras()

        Try
            Dim dsHistorial As New DataSet
            Dim ls_Material As String = ""
            oeOrdenCompraMaterial = New e_OrdenCompraMaterial

            If IdTipoOrdenCompra = "1PK000000001" Then
                oeOrdenCompraMaterial.TipoOperacion = "M"
                oeOrdenCompraMaterial.IdOrden = griListaDetalleOrdenCompraMaterial.ActiveRow.Cells("IdOrden").Value.ToString
                oeOrdenCompraMaterial.IdMaterial = griListaDetalleOrdenCompraMaterial.ActiveRow.Cells("IdMaterial").Value.ToString
                ls_Material = griListaDetalleOrdenCompraMaterial.ActiveRow.Cells("Material").Value.ToString
            Else
                oeOrdenCompraMaterial.TipoOperacion = "S"
                oeOrdenCompraMaterial.IdOrden = griListaDetalleOrdenCompraServicio.ActiveRow.Cells("IdOrden").Value.ToString
                oeOrdenCompraMaterial.IdMaterial = griListaDetalleOrdenCompraServicio.ActiveRow.Cells("IdServicio").Value.ToString
                ls_Material = griListaDetalleOrdenCompraServicio.ActiveRow.Cells("Servicio").Value.ToString
            End If
            dsHistorial = olOrdenCompraMaterial.ListarHistorial(oeOrdenCompraMaterial)
            If dsHistorial.Tables(0).Rows.Count = 0 Then
                panelOcultarGrafico.Visible = 1
            Else
                panelOcultarGrafico.Visible = 0
            End If
            griHistorialCompras.DataSource = dsHistorial.Tables(0)
            Dim dt As New DataTable
            Dim j As Integer = 0
            Dim fecha As Date = Now
            'Dim Precio As Double = 0
            '---------------Definiendo las columnas-----------------------            
            For Each row As DataRow In dsHistorial.Tables(1).Rows
                dt.Columns.Add(row("FechaOrden"), System.Type.GetType("System.Double"))
                fecha = DateAdd(DateInterval.Day, 15, row("FechaOrden"))
            Next
            ''------Recorremos la colección para guardar los datos  en el DataTable-----------
            Dim newRow() As Object = New Object(dt.Columns.Count - 1) {}
            fecha = Now
            '----------------------Agregando datos-----------------------
            For Each row As DataRow In dsHistorial.Tables(1).Rows
                newRow(j) = row("Precio")
                j = j + 1
            Next
            dt.Rows.Add(newRow)
            '----------------------------------------------GRAFICO LINEAL--------------------------------------------
            chaHistorialCompras.TitleTop.Text = "HISTORIAL DE COMPRAS DE : " + ls_Material
            chaHistorialCompras.ChartType = Infragistics.UltraChart.Shared.Styles.ChartType.LineChart
            chaHistorialCompras.LineChart.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dash
            'sets the styles for the beginning and end of the line
            chaHistorialCompras.LineChart.StartStyle = Infragistics.UltraChart.[Shared].Styles.LineCapStyle.NoAnchor
            chaHistorialCompras.LineChart.EndStyle = Infragistics.UltraChart.[Shared].Styles.LineCapStyle.Flat
            'winchart only- determines whether to highlight the entire line when a point is mosed over
            chaHistorialCompras.LineChart.HighLightLines = True
            'turns on/off the midpoints of the line
            chaHistorialCompras.LineChart.MidPointAnchors = True
            'determines how to handle nulls for the line chart
            chaHistorialCompras.LineChart.NullHandling = Infragistics.UltraChart.[Shared].Styles.NullHandling.Zero
            'sets the thickness of the line
            chaHistorialCompras.LineChart.Thickness = 3
            chaHistorialCompras.DataSource = dt
            '--------------------------------------------------------------------------------------------------------
            gbeListadoHistorial.Expanded = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub AprobarOC()
        Try
            tipoOperacion = "1"
            GuardarOrdenCompra()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub RechazarOC()
        Try
            'Validar("Rechazar")
            tipoOperacion = "2"
            cboEstadoOrden.SelectedIndex = 0
            RechazarOrdenCompra()
            'Validar()
            'If GuardarOrdenCompra() Then
            '    MostrarTabs(0, ficRequerimiento, 2)
            'End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Public Sub Lista_Alerta()
        Try
            CargarTrabSeg()
            cboEstadoOrden.Text = "GENERADA"
            rfOrdenDesde.Value = Date.Now.AddDays(-30)
            rfOrdenHasta.Value = Date.Now.Date
            verLimites.Checked = True
            InicializarControlesLista()
            Listar(True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub


#End Region

#Region "Eventos"

    Private Sub RechazarOrdenCompra()
        Dim loOrden As New List(Of e_OrdenCompra)
        Dim formulario As New frm_RechazarOrdenCompra
        Dim idOrdCom As String
        Dim NroOrden As String
        loOrden = llOrdenCompra.Where(Function(item) item.IndicadorAprobacion = True).ToList
        For Each orden As e_OrdenCompra In loOrden
            idOrdCom = orden.Id
            NroOrden = orden.NroOrden
            formulario.Listar(idOrdCom, NroOrden)
            formulario.ShowDialog()
        Next
        Lista_Alerta()
    End Sub

    Private Sub frm_AprobarOrdenesCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
        MostrarTabs(0, ficRequerimiento)
        InicializaTiempo()
        Inicializar()
    End Sub


    Private Sub frm_AprobarOrdenesCompra_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_AprobarOrdenesCompra_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Select Case Operacion
            Case "Nuevo", "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If

    End Sub

    Private Sub griListaOrdenCompra_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaOrdenCompra.CellChange
        Try
            griListaOrdenCompra.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Private Sub griListaOrdenCompra_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaOrdenCompra.AfterCellUpdate

        '_Estado = .ActiveRow.Cells("EstadoOrden").Value
        'id = .ActiveRow.Cells("Id").Value.ToString
        Select Case e.Cell.Column.Key
            Case "IndicadorAprobacion"
                'With griListaOrdenCompra.Rows(e.Cell.Row.Index)
                CargarMenuContextual()
                'If .Cells("IndicadorAprobacion").Value Then
                'Else
                'End If
                'End With
        End Select

    End Sub

    Private Sub griListaDetalleOrdenCompra_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs)
        Try
            griListaOrdenCompra.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub btnAprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAprobar.Click
        AprobarOC()
    End Sub

    Private Sub btnRechazar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRechazar.Click
        RechazarOC()
    End Sub

    Private Sub CargarTrabSeg()
        If gleTrabSeguridad.Count > 0 Then
            Dim leTrabSeg As New List(Of e_TrabajadorSeguridad)
            leTrabSeg = gleTrabSeguridad.Where(Function(item) item.NombreProceso = "APROBAR ORDENES DE COMPRA").ToList
            If leTrabSeg.Count > 0 Then oeTrabSeg = leTrabSeg(0)
        End If
    End Sub

#End Region

#Region "Menú contextual"

    Private Sub AsociarMenu()
        griListaOrdenCompra.ContextMenuStrip = MenuContextual1
        MenuContextual1.Items("AprobarToolStripMenuItem").Enabled = False
        MenuContextual1.Items("RechazarToolStripMenuItem").Enabled = False
    End Sub
    Private Sub AprobarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AprobarToolStripMenuItem.Click
        AprobarOC()
    End Sub
    Private Sub RechazarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechazarToolStripMenuItem.Click
        RechazarOC()
    End Sub
    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        'If griListaOrdenCompra.Selected.Rows.Count > 0 Then
        '    MenuContextual1.Items("AprobarToolStripMenuItem").Enabled = True
        '    MenuContextual1.Items("RechazarToolStripMenuItem").Enabled = True
        'Else
        'MenuContextual1.Items("AprobarToolStripMenuItem").Enabled = False
        'MenuContextual1.Items("RechazarToolStripMenuItem").Enabled = False
        'End If
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_AprobarOrdenesCompra_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griListaOrdenCompra_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griListaOrdenCompra.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

    Private Sub griListaOrdenCompra_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaOrdenCompra.DoubleClick
        If griListaOrdenCompra.Selected.Rows.Count > 0 Then Editar()
    End Sub

#End Region

    Private Sub griListaDetalleOrdenCompraMaterial_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaDetalleOrdenCompraMaterial.DoubleClick
        If IdTipoOrdenCompra = "1PK000000001" Then
            If griListaDetalleOrdenCompraMaterial.Selected.Rows.Count > 0 Then ListarHistorialCompras()
        Else
            If griListaDetalleOrdenCompraServicio.Selected.Rows.Count > 0 Then ListarHistorialCompras()
        End If
    End Sub

    Private Sub griListaDetalleOrdenCompraServicio_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaDetalleOrdenCompraServicio.DoubleClick
        If IdTipoOrdenCompra = "1PK000000001" Then
            If griListaDetalleOrdenCompraMaterial.Selected.Rows.Count > 0 Then ListarHistorialCompras()
        Else
            If griListaDetalleOrdenCompraServicio.Selected.Rows.Count > 0 Then ListarHistorialCompras()
        End If
    End Sub

    Private Sub gbeListadoHistorial_ExpandedStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbeListadoHistorial.ExpandedStateChanged
        Try
            If griHistorialCompras.Rows.Count = 0 Then
                panelOcultarGrafico.Visible = 1
            Else
                panelOcultarGrafico.Visible = 0
            End If
        Catch
        End Try
    End Sub

End Class