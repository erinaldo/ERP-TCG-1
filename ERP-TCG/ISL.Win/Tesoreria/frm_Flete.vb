'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win
Imports Infragistics
Imports System.Math
Public Class frm_Flete

    Inherits frm_MenuPadre

    Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Flete = Nothing
    Private Shared Operacion As String
    Private Estado As String
    Dim _ingresando_datos As Boolean = False

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Flete()
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaracion de Variables"

    Dim oeViaje As New e_Viaje
    Dim oeOperacionDetalle As New e_OperacionDetalle
    Dim loOperacionDetalle As New List(Of e_OperacionDetalle)

    Dim oeReporteFlete As New e_ReporteFlete
    Dim loReporteFlete As New List(Of e_ReporteFlete)
    Dim olReporteFlete As New l_ReporteFlete

    Dim oeOperacion As New e_Operacion
    Dim olOperacion As New l_Operacion
    Dim loOperacion As New List(Of e_Viaje)

    Dim oeMovimiento As New e_Movimiento
    Dim olMovimiento As New l_Movimiento
    Dim idOpeDet As String = ""

    Dim oeCajaUsuario As New e_CajaUsuario
    Dim olCajaUsuario As New l_CajaUsuario
    Dim loCajaUsuario As New List(Of e_CajaUsuario)

    Dim oeDeposito As New e_Deposito
    Dim olDeposito As New l_Deposito

    Dim oeDepositoDetalle, oeDepositoDetalle2 As New e_DepositoDetalle
    Dim olDepositoDetalle As New l_DepositoDetalle

    Dim loDepositoDetalle = New List(Of e_DepositoDetalle)

    Dim oeMovGrupo As New e_Movimiento
    Dim olMovGrupo As New l_Movimiento

    Dim loMovimientoFlete As New List(Of e_Movimiento_Flete)
    Dim oeMovimientoFlete As New e_Movimiento_Flete
    Dim olMovimientoFlete As New l_Movimiento_Flete
    Dim loCA As New List(Of e_CuentaCorriente)

    Dim oeIgv As New e_Impuesto
    Dim OlIgv As New l_Impuesto

    Dim oeMovimientoViaje As New e_Movimiento_Viaje
    Dim olMovimientoViaje As New l_Movimiento_Viaje

    Dim oeCuentaCorriente As New e_CuentaCorriente
    Dim oeTemp As New e_CuentaCorriente

    Dim olCuentaCorriente As New l_CuentaCorriente
    Dim loCuentaCorriente As New List(Of e_CuentaCorriente)

    Dim oeChequexCobrar As New e_ChequexCobrar
    Dim olChequexCobrar As New l_ChequexCobrar

    Dim oeEstado As New e_Estado
    Dim olEstado As New l_Estado

    Dim IndFleOpe As Boolean = False

    Dim oeRuta As New e_Ruta
    Dim olRuta As New l_Ruta

    Dim oeCliente As New e_Cliente
    Dim olCliente As New l_Cliente
    Dim loCliente As New List(Of e_Cliente)

    Dim oeTrabajador As New e_Trabajador
    Dim olTrabajador As New l_Trabajador
    Dim loTrabajador As New List(Of e_Trabajador)


    Dim oeTipoCarga As New e_TipoCarga
    Dim olTipoCarga As New l_TipoCarga

    Dim oeMaterial As New e_Material
    Dim olMaterial As New l_Material
    Dim loMaterial As New List(Of e_Material)

    Dim oeLugar As New e_Lugar
    Dim olLugar As New l_Lugar

    Dim oeMoneda As New e_Moneda
    Dim olMoneda As New l_Moneda

    Dim oeVehiculo As New e_Vehiculo
    Dim olVehiculo As New l_Vehiculo
    Dim loVehiculo As New List(Of e_Vehiculo)

    Dim oeTipoVehiculo As New e_TipoVehiculo
    Dim olTipoVehiculo As New l_TipoVehiculo

    Dim Prefijo As New l_Configuracion

    Dim IdTrabajador As String
    Dim ImporteCarga As Decimal
    Dim IdViaje As String
    Public ViajeId As String = ""
    Dim OperacionFlete, IdDetalleOperacion, IdOperacion As String

    Dim oeCentro As New e_Centro
    Dim olCentro As New l_Centro
    Dim ListaCentro As New List(Of e_Centro)

    Dim Cargado As Decimal
    Dim Cobrado As Decimal
    Dim Depositado As Decimal
    Dim SaldoPorDepositar As Decimal

    Dim FleteGrupo As Boolean = False

    Dim FilaOperacion As Integer = -1
    Dim IdMovimiento As String = ""
#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Operacion = "Inicializa"
            If Activo Then
                Estado = " Activo"
            Else
                Estado = " Inactivo"
            End If
            Select Case ficOperacion.SelectedTab.Index
                Case 0
                    InicializarEntidad()
                    oeViaje.Activo = Activo
                    griViajeDetalle.DataSource = Nothing
                    Listar()
                    If griLista.Rows.Count > 0 Then
                        MyBase.Consultar(Activo)
                        MostrarTabs(0, ficOperacion)
                        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                    Else
                        MyBase.Consultar()
                    End If
            End Select
            InicializaTiempo()
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        If ficOperacion.SelectedTab.Index = 0 Then
            Operacion = "Inicializa"
            InicializarEntidad()
        ElseIf ficOperacion.SelectedTab.Index = 1 AndAlso ficMovimientoFlete.SelectedTab.Index = 1 Then
            oeDeposito.Activo = True
            oeChequexCobrar.UsuarioCreacion = gUsuarioSGI.Id
            loDepositoDetalle = New List(Of e_DepositoDetalle)
        End If
    End Sub

    Private Sub UbicarOperacion()

        For Each Fila As UltraGridRow In griLista.Rows
            If Fila.Cells("Id").Value = IdOperacion Then
                griLista.Rows.Item(Fila.Index).Activated = True
                Exit For
            End If
        Next

        For Each Fila2 As UltraGridRow In griViajeDetalle.Rows
            If Fila2.Cells("Id").Value = IdDetalleOperacion Then
                griViajeDetalle.Rows.Item(Fila2.Index).Activated = True
                Exit For
            End If
        Next

    End Sub

    Public Overrides Sub Guardar()
        Try
            If OperacionFlete = "Cargar" Then
                If GuardarCarga() Then
                    MostrarTabs(0, ficOperacion)
                    MyBase.Guardar()
                    Consultar(True)
                    UbicarOperacion()
                    IdViaje = String.Empty
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griLista.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If ficOperacion.SelectedTab.Index = 0 Then Exportar_Excel(griLista)

            If griViajeDetalle.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If ficOperacion.SelectedTab.Index = 0 Then Exportar_Excel(griViajeDetalle)

            If griMovimientoFlete.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If ficOperacion.SelectedTab.Index = 0 Then Exportar_Excel(griMovimientoFlete)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub EnviarCorreo(IdViaje As String, IdMovimientoFlete As String)
        Try
            If My.Computer.Network.IsAvailable Then
                Try
                    If My.Computer.Network.Ping("8.8.8.8", 10) Then
                        Dim txtDe As String = "consultores.tecnologicos.2010@gmail.com"
                        Dim txtPara As String = "consultores.tecnologicos.2010@gmail.com; consultores.tecnologicos.2010@gmail.com; consultores.tecnologicos.2010@gmail.com; " &
                            "consultores.tecnologicos.2010@gmail.com; consultores.tecnologicos.2010@gmail.com; consultores.tecnologicos.2010@gmail.com; consultores.tecnologicos.2010@gmail.com"
                        Dim txtAsunto As String = "FLETE CARGADO A CONDUCTOR"
                        Dim txtMensaje As String = ""
                        Dim oeMovVia As New e_Movimiento_Viaje
                        Dim olMovVia As New l_Movimiento_Viaje
                        oeMovVia.IdViaje = IdViaje
                        oeMovVia.IdMovimiento = IdMovimientoFlete
                        oeMovVia.TipoOperacion = "F"
                        oeMovVia = olMovVia.Obtener(oeMovVia)
                        txtMensaje = "FLETE CARGADO AL TRABAJADOR: " & oeMovVia.Piloto & " DEL VIAJE: " & oeMovVia.Viaje & " EL DIA: " & oeMovVia.Fecha.Date _
                            & " POR EL USUARIO: " & oeMovVia.Usuario & " // " & Environment.NewLine & "                   CON GLOSA: " & oeMovVia.Glosa
                        Dim ls_ListaAdjuntos As String = ""
                        EnviarEmail(txtDe, txtPara, "", "", txtAsunto, txtMensaje, ls_ListaAdjuntos)
                    End If
                Catch ex As Exception
                End Try
            End If        
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarCarga() As Boolean
        Dim Mensaje As String = ""
        Dim flag As Boolean = False
        Try
            If Me.decImporteCarga.Value = 0.0 Then
                Throw New Exception("Ingrese Monto de Carga Por Favor")
            Else
                If cboViaje.SelectedIndex = -1 And ficCargaFlete.SelectedTab.Index = 0 Then
                    Throw New Exception("No Puede Realizar Carga")
                Else
                    If verCheque.Checked = True Then
                        Mensaje = "¿Desea Cargar S/." & decImporteCarga.Value & _
                                    " con el cheque: " & txtNumeroCheque.Text & ", Banco: " & cboBanco.Text & ", al trabajador: " & Me.cboTrabajadorFlete.Text
                    Else
                        If ficCargaFlete.SelectedTab.Index = 0 Then
                            Mensaje = "¿Desea Cargar S/." & decImporteCarga.Value & ", al Trabajador: " & Me.cboTrabajadorFlete.Text
                        Else
                            Mensaje = "¿Desea Cargar S/." & decImporteCarga.Value & ", ala Cuenta: " & Me.cboAdm.Text
                        End If
                    End If
                    If MessageBox.Show(Mensaje & " " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.No Then
                        Return False
                    Else
                        ugb_Espera.Visible = True
                        Application.DoEvents()
                        Cursor.Current = Cursors.WaitCursor
                        Cursor.Show()
                        Dim oeMovAux As New e_Movimiento
                        oeChequexCobrar = New e_ChequexCobrar
                        oeMovimientoViaje = New e_Movimiento_Viaje
                        With oeMovimiento
                            If ficCargaFlete.SelectedTab.Index = 0 Then
                                .oeMovimientoViaje = New e_Movimiento_Viaje
                                '.IndPrestamoHab = 1
                                .TipoProceso = "FLETE_CARGA"
                                .Descuento = 1
                                .TipoTransa = 1
                                .IndPrestamoHab = 1 '
                                .Descuento = 1 ' ind para hab x flete
                                .IdEstado = "HABILITADA"
                                If etiEstadoAsociado.Text = "PENDIENTE" Then
                                    oeMovAux.TipoOperacion = "D"
                                    oeMovAux.Id = IdMovimiento
                                    oeMovAux.IdEstado = "HABILITADA"
                                End If
                                .Glosa = Me.txtGlosa.Text
                                .Voucher = ""
                                .TipoOperacion = "I"
                                .TipoTransa = 2
                                .Activo = True
                                .AsignadoGrupo = 0
                                .Fecha = fecFechaCarga.Value
                                .UsuarioCreacion = gUsuarioSGI.Id
                                .Voucher = String.Empty
                                If decImporteCarga.Value >= 2000 Then flag = True
                                .SaldoPorDepositar = decImporteCarga.Value
                                .Egreso = decImporteCarga.Value
                                .Saldo = decImporteCarga.Value
                                .UsuarioCreacion = gUsuarioSGI.Id
                                .oeMovimientoViaje.TipoTRB = "P"
                                .oeMovimientoViaje.IdViaje = IdViaje
                                .oeMovimientoViaje.TipoOperacion = "I"
                                .oeMovimientoViaje.IdTrabajadorRecepciona = cboTrabajadorFlete.Value
                                .oeMovimientoViaje.FechaRecepcion = fecFechaCarga.Value
                                .oeMovimientoViaje.FechaLiquidacion = Date.Parse("01/01/1901")
                                .oeMovimientoViaje.FechaReembolso = Date.Parse("01/01/1901")
                            Else
                                .TipoProceso = "FLETE_CARGA"
                                .Descuento = 1
                                .TipoTransa = 6
                                .IndPrestamoHab = 1 '
                                .Descuento = 1 ' ind para hab x flete
                                .IdEstado = "HABILITADA"
                                .TipoOperacion = "I"
                                .Id = IdMovimiento
                                .Glosa = Me.txtGlosa.Text
                                .Voucher = ""
                                .Activo = True
                                .AsignadoGrupo = 0
                                .Fecha = fecFechaCarga.Value
                                .UsuarioCreacion = gUsuarioSGI.Id
                                .Voucher = String.Empty
                                .SaldoPorDepositar = decImporteCarga.Value
                                .Egreso = decImporteCarga.Value
                                .Saldo = decImporteCarga.Value
                                .UsuarioCreacion = gUsuarioSGI.Id
                            End If
                            .oeMovimientoFlete = oeMovimientoFlete
                            .oeMovimientoFlete.TipoOperacion = "I"
                            .oeMovimientoFlete.TipoCobro = 1
                            .oeMovimientoFlete.IdOperacionDetalle = IdDetalleOperacion
                            .oeMovimientoFlete.Fecha = fecFechaCarga.Value
                            .oeMovimientoFlete.IdViaje = ViajeId
                            If verCheque.Checked Then
                                oeMoneda = New e_Moneda
                                oeMoneda.Nombre = "SOLES"
                                oeMoneda.Activo = True
                                oeMoneda = olMoneda.Obtener(oeMoneda)
                                .oeMovimientoFlete.oeChequeCobrar = New e_ChequexCobrar
                                .oeMovimientoFlete.oeChequeCobrar = oeChequexCobrar
                                .oeMovimientoFlete.oeChequeCobrar.TipoOperacion = "I"
                                .oeMovimientoFlete.oeChequeCobrar.IdBanco = cboBanco.Value
                                .oeMovimientoFlete.oeChequeCobrar.NroCheque = txtNumeroCheque.Text
                                .oeMovimientoFlete.oeChequeCobrar.Fecha = Date.Now
                                .oeMovimientoFlete.oeChequeCobrar.IdMoneda = oeMoneda.Id
                                .oeMovimientoFlete.oeChequeCobrar.Monto = decImporteCarga.Value
                                .oeMovimientoFlete.oeChequeCobrar.FechaCobro = fecFechaCheque.Value
                                .oeMovimientoFlete.oeChequeCobrar.IdTrabajadorCobro = String.Empty
                                .oeMovimientoFlete.oeChequeCobrar.UsuarioCreacion = gUsuarioSGI.Id
                                .oeMovimientoFlete.oeChequeCobrar.IdCuentaCorriente = .IdCuentaCorrienteDestino
                                .oeMovimientoFlete.oeChequeCobrar.Asociado = 2
                                .oeMovimientoFlete.oeChequeCobrar.TipoTransa = 1
                                .oeMovimientoFlete.oeChequeCobrar.Activo = True
                            Else
                                .oeMovimientoFlete.TipoCobro = 0
                            End If
                            Dim oeOpeDet As New e_OperacionDetalle
                            Dim olOpeDet As New l_Operacion

                            oeOpeDet.Id = griViajeDetalle.ActiveRow.Cells("Id").Value.ToString
                            oeOpeDet.SaldoCarga = .Egreso
                            oeOpeDet.TipoOperacion = "S"
                            oeMovimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                            oeMovAux.PrefijoID = gs_PrefijoIdSucursal '@0001
                            If olMovimiento.Guardar(oeMovimiento, oeMovAux) Then
                                oeOpeDet.PrefijoID = gs_PrefijoIdSucursal '@0001
                                If olOperacion.GuardarOperacionDetalle(oeOpeDet) Then
                                    If flag Then EnviarCorreo(oeMovimiento.oeMovimientoViaje.IdViaje, oeMovimiento.oeMovimientoFlete.Id)
                                    ugb_Espera.Visible = False
                                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                                    MostrarTabs(0, ficOperacion)
                                    griLista.Focus()
                                    Return True
                                End If
                            Else
                                oeMovimiento.oeMovimientoFlete = New e_Movimiento_Flete
                                Return False
                            End If
                        End With
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Function

    Public Overrides Sub Cancelar()
        Select Case ficMovimientoFlete.SelectedTab.Index
            Case 0
                MostrarTabs(0, ficOperacion)
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            Case 1

                MostrarTabs(0, ficOperacion)
                MostrarTabs(0, ficMovimientoFlete, 0)
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
        End Select
    End Sub

#End Region

#Region "Eventos"

    Private Sub ListarOperacionDetalle(ByVal IdOperacion As String)
        Try
            LimpiarSaldos()
            oeOperacionDetalle = New e_OperacionDetalle
            oeOperacionDetalle.IdOperacion = IdOperacion
            oeOperacionDetalle.Activo = True
            oeOperacionDetalle.TipoOperacion = "4"
            Dim olCombo = New l_Combo

            With griViajeDetalle
                .ResetDisplayLayout()
                .DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True
                .DataSource = olOperacion.ListarOperacionDetalle(oeOperacionDetalle)
                .DisplayLayout.Bands(0).Columns.Add("Mod", "Edit")
                .DisplayLayout.Bands(0).Columns("Mod").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Mod").Style = ColumnStyle.Button
                .DisplayLayout.Bands(0).Columns("Mod").CellAppearance.Image = Global.ISL.Win.My.Resources.Resources.Editar
                .DisplayLayout.Bands(0).Columns("ClienteFinal").Header.Enabled = False
                .DisplayLayout.Bands(0).Columns("ClienteFinal").EditorComponent = Nothing
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdOperacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdDemanda").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdDemandaDetalle").Hidden = True
                .DisplayLayout.Bands(0).Columns("PesoToneladas").Hidden = True
                .DisplayLayout.Bands(0).Columns("Facturado").Hidden = True
                .DisplayLayout.Bands(0).Columns("Cargar").Hidden = True
                .DisplayLayout.Bands(0).Columns("Descarga").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("Cliente").Hidden = True
                .DisplayLayout.Bands(0).Columns("Saldo").Hidden = True
                .DisplayLayout.Bands(0).Columns("Seleccion").Hidden = True
                .DisplayLayout.Bands(0).Columns("MotivoConsolidado").Hidden = True
                .DisplayLayout.Bands(0).Columns("FalsoFlete").Hidden = True
                .DisplayLayout.Bands(0).Columns("Subtotal").Hidden = True
                .DisplayLayout.Bands(0).Columns("CostoEstiba").Hidden = True
                .DisplayLayout.Bands(0).Columns("CostoEstibaDescarga").Hidden = True
                .DisplayLayout.Bands(0).Columns("AdelantoFlete").Hidden = False
                .DisplayLayout.Bands(0).Columns("PagoContraEntrega").Hidden = True
                .DisplayLayout.Bands(0).Columns("IncluyeIgvConsolidado").Hidden = True
                .DisplayLayout.Bands(0).Columns("PagoEfectivoDeposito").Hidden = True
                .DisplayLayout.Bands(0).Columns("Consolidado").Hidden = True
                .DisplayLayout.Bands(0).Columns("MotivoConsolidado").Hidden = True
                .DisplayLayout.Bands(0).Columns("FalsoFlete").Hidden = True

                .DisplayLayout.Bands(0).Columns("Mod").Width = 25
                .DisplayLayout.Bands(0).Columns("Glosa").Width = 250
                .DisplayLayout.Bands(0).Columns("Carga").Width = 100
                .DisplayLayout.Bands(0).Columns("Cantidad").Width = 50
                .DisplayLayout.Bands(0).Columns("FleteUnitario").Width = 70
                .DisplayLayout.Bands(0).Columns("Facturado").Width = 60
                .DisplayLayout.Bands(0).Columns("PagoContraEntrega").Width = 100
                .DisplayLayout.Bands(0).Columns("Material").Width = 100
                .DisplayLayout.Bands(0).Columns("Moneda").Width = 40
                .DisplayLayout.Bands(0).Columns("Flete").Width = 70
                .DisplayLayout.Bands(0).Columns("Comisionista").Width = 200
                .DisplayLayout.Bands(0).Columns("Comision").Width = 50
                .DisplayLayout.Bands(0).Columns("Origen").Width = 100
                .DisplayLayout.Bands(0).Columns("Destino").Width = 100
                .DisplayLayout.Bands(0).Columns("PesoToneladasCarga").Width = 100
                .DisplayLayout.Bands(0).Columns("PesoToneladasDescarga").Width = 100

                .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Carga").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Cantidad").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("FleteUnitario").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("Facturado").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("PagoContraEntrega").Header.VisiblePosition = 13
                .DisplayLayout.Bands(0).Columns("Material").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("IncluyeIgv").Header.VisiblePosition = 9
                .DisplayLayout.Bands(0).Columns("Moneda").Header.VisiblePosition = 10
                .DisplayLayout.Bands(0).Columns("Flete").Header.VisiblePosition = 11
                .DisplayLayout.Bands(0).Columns("PesoToneladasCarga").Header.VisiblePosition = 12
                .DisplayLayout.Bands(0).Columns("PesoToneladasDescarga").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("IndPesotnDescarga").Header.VisiblePosition = 14
                .DisplayLayout.Bands(0).Columns("Comisionista").Header.VisiblePosition = 15
                .DisplayLayout.Bands(0).Columns("Comision").Header.VisiblePosition = 16
                .DisplayLayout.Bands(0).Columns("Origen").Header.VisiblePosition = 17
                .DisplayLayout.Bands(0).Columns("Destino").Header.VisiblePosition = 18

                .DisplayLayout.Bands(0).Columns("Flete").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("FleteUnitario").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("PesoToneladasCarga").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("PesoToneladasDescarga").CellAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
                .DisplayLayout.Bands(0).Columns("FleteUnitario").CellAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
                .DisplayLayout.Bands(0).Columns("Glosa").CellAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))

                .DisplayLayout.Bands(0).Columns("Glosa").Style = ColumnStyle.EditButton
                .DisplayLayout.Bands(0).Columns("Glosa").CellButtonAppearance.Image = Global.ISL.Win.My.Resources.Resources.Grabar
                .DisplayLayout.Bands(0).Columns("Glosa").CharacterCasing = CharacterCasing.Upper

                .DisplayLayout.Bands(0).Columns("PesoToneladasDescarga").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("FleteUnitario").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("AdelantoFlete").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("Comision").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("Cantidad").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("Flete").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("PesoToneladasCarga").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("PesoToneladasDescarga").CellAppearance.TextHAlign = HAlign.Right


                .DisplayLayout.Bands(0).Columns("IncluyeIgv").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
                .DisplayLayout.Override.CellClickAction = CellClickAction.EditAndSelectText

                For Each Columna As UltraGridColumn In griViajeDetalle.DisplayLayout.Bands(0).Columns
                    If Not Columna.Key = "PesoToneladasDescarga" And Not Columna.Key = "FleteUnitario" And Not Columna.Key = "IncluyeIgv" And Not Columna.Key = "Glosa" Then
                        Columna.CellClickAction = CellClickAction.RowSelect : Columna.CellActivation = Activation.NoEdit
                    End If
                Next

                .DisplayLayout.Bands(0).Columns("PesoToneladasDescarga").Format = "#,###,###,####0.0000"
                .DisplayLayout.Bands(0).Columns("PesoToneladasDescarga").MaskInput = "{LOC}n,nnn,nnn,nnn.nnnn"
                .DisplayLayout.Bands(0).Columns("Flete").Format = "#,###,###,####0.0000"
                .DisplayLayout.Bands(0).Columns("Flete").MaskInput = "{LOC}n,nnn,nnn,nnn.nn"
                .DisplayLayout.Bands(0).Columns("FleteUnitario").Format = "#,###,###,####0.0000"
                .DisplayLayout.Bands(0).Columns("FleteUnitario").MaskInput = "{LOC}n,nnn,nnn,nnn.nnnn"

                CalcularTotales(griViajeDetalle, "Flete", "Comision")
                .DisplayLayout.Bands(0).Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
                If .Rows.Count > 0 Then
                    .Rows.Item(0).Selected = True
                    .Rows.Item(0).Activated = True
                Else
                    griViajeDetalle.DataSource = Nothing
                    griMovimientoFlete.DataSource = Nothing
                End If
                .DisplayLayout.Override.FilterUIProvider = Filtro
                .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
                .DisplayLayout.Bands(0).Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Bands(0).Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
            End With
            CrearComboGrid("ClienteFinal", "Nombre", griViajeDetalle, olCombo.ComboGrilla(ClientesPublic), True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try      
    End Sub

    Private Sub griLista_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griLista.AfterRowActivate
        Try
            Me.decMontoFlete.Value = 0.0
            Me.decSaldoFlete.Value = 0.0
            Me.decSaldoPorDepositar.Value = 0.0
            Me.decTotalCargado.Value = 0.0
            Me.decFleteDepositado.Value = 0.0
           
            If griLista.ActiveRow.Index >= 0 Then
                FilaOperacion = griLista.ActiveRow.Index
                IdOperacion = griLista.ActiveRow.Cells("IdOperacion").Value
                IdTrabajador = griLista.ActiveRow.Cells("IdPiloto").Value
                expOperacionDetalle.Text = "Operaciones - Detalles/ N° Operacion: " & _
                griLista.ActiveRow.Cells("Operacion").Value & "/ Piloto: " & griLista.ActiveRow.Cells("Piloto").Value & "/ Viaje: " & griLista.ActiveRow.Cells("Codigo").Value
                oeIgv = OlIgv.IGV(griLista.ActiveRow.Cells("Fecha").Value)
                ListarOperacionDetalle(IdOperacion)
            Else
                expOperacionDetalle.Text = "Operaciones - Detalles"
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtOperacionBuscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not ((e.KeyValue >= 48 And e.KeyValue <= 57) OrElse (e.KeyValue >= 96 And e.KeyValue <= 105) OrElse (e.KeyValue >= 37 And e.KeyValue <= 40) OrElse (e.KeyValue >= 65 And e.KeyValue <= 90) _
                 OrElse (e.KeyValue >= 37 And e.KeyValue <= 40) OrElse (e.KeyValue = 192) OrElse (e.KeyValue = 8 OrElse e.KeyValue = 46 OrElse e.KeyValue = 13)) Then
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub frm_Flete_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case ficOperacion.SelectedTab.Index
            Case 0
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            Case 1
                If decImporteCarga.Value > CDec(Me.etiSaldoCarga.Text) Then
                    ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 1)
                Else
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
                End If
        End Select
        If ficOperacion.SelectedTab.Index = 1 And ficMovimientoFlete.SelectedTab.Index = 1 Then
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_Flete_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Flete_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case Operacion
            Case "Nuevo"
                Me.Activate()
                Me.Cancelar()
            Case "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_Flete_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            gf_AsignarEventoSeleccionarTexto(Me)
            gmt_ConfigurarEventoKeyEnter_Tab(Me, txtOperacion.Name, txtViaje.Name)
            colorCargado.Color = Color.LightGreen
            EtiCargado.Appearance.BackColor = colorCargado.Color
            fecHasta.Value = Date.Today
            fecDesde.Value = Date.Today.AddDays(-7)
            agrBuscarFecha.Enabled = False
            agrBuscarOtros.Enabled = False
            CargarCombos()
            ListarCuentaCorriente()
            oeCentro.Abreviatura = ""
            oeCentro.Nombre = "TODOS"
            ListaCentro.Add(oeCentro)
            oeCentro = New e_Centro
            oeCentro.TipoOperacion = "O"
            ListaCentro.AddRange(olCentro.Listar(oeCentro))
            LlenarCombo(cboCentro, "Nombre", ListaCentro, 0)
            cboCentro.SelectedIndex = 0
            fecFechaCarga.Value = Date.Now
            verBuscarOtros.Checked = True
            MostrarTabs(0, ficOperacion)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub frm_Flete_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub MenuContextual_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual.Opening
        MenuContextual.Items("MnuCargar").Visible = False
        If griViajeDetalle.Rows.Count > 0 Then
            MenuContextual.Items("MnuCargar").Visible = True
        End If
    End Sub

    Private Sub MnuCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuCargar.Click
        Nuevo()
        OperacionFlete = "Cargar"
        Dim oeEmpresa As New e_Empresa
        Dim olEmpresa As New l_Empresa
        IdDetalleOperacion = String.Empty
        Try
            If VerificarEditado(griLista.ActiveRow.Cells("Id").Value.ToString) Then
                oeEmpresa.IdTipoEmpresa = "1CH000000003"
                LlenarCombo(cboBanco, "Nombre", olEmpresa.Listar(oeEmpresa), -1)
                agrDetalleCargarCobrar.Text = "Cargar Flete"

                LlenaComboTrabajadorFlete()
                MostrarTabs(1, ficOperacion, 1)
                MostrarTabs(0, ficMovimientoFlete)
                MostrarTabs(0, ficCargaFlete, 1)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
                oeMovimiento = New e_Movimiento
                LimpiarCargaFlete()
                LimpiarCobroFlete()
                MostrarTabs(0, ficCargar_Cobrar, 0)
                CalcularSaldo()
                IdDetalleOperacion = griViajeDetalle.ActiveRow.Cells("Id").Value
                decImporteCarga.Value = decSaldoFlete.Value

                decFleteDepositado.Value = Cobrado
                etiSaldoCarga.Text = decImporteCarga.Value
                ViajeId = griLista.ActiveRow.Cells("Id").Value
                txtGlosa.Text = "A CARGO FLETE N° Viaje: " & griLista.ActiveRow.Cells("Codigo").Value
                cboTrabajadorFlete.Focus()
                cboTrabajadorFlete.Value = griLista.ActiveRow.Cells("IdPiloto").Value
                MovimientosFlete(GriMovimientoFleteGlobal)
            Else
                Throw New Exception("El Viaje se Encuentra Siendo Editado. No puede Cargar Fletes.")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub MovimientosFlete(ByVal Grilla As Infragistics.Win.UltraWinGrid.UltraGrid)
        With Grilla
            .ResetDisplayLayout()
            .DataSource = loMovimientoFlete
            .DisplayLayout.Bands(0).Columns("Id").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdOperacionDetalle").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdMovimiento").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdCheque").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdViaje").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdTrabajador").Hidden = True
            .DisplayLayout.Bands(0).Columns("ApellidoPaterno").Hidden = True
            .DisplayLayout.Bands(0).Columns("ApellidoMaterno").Hidden = True
            .DisplayLayout.Bands(0).Columns("Nombre").Hidden = True
            .DisplayLayout.Bands(0).Columns("TipoCobro").Hidden = True
            .DisplayLayout.Bands(0).Columns("Destino").Hidden = True
            .DisplayLayout.Bands(0).Columns("Origen").Hidden = True
            .DisplayLayout.Bands(0).Columns("Depositado").Hidden = True
            .DisplayLayout.Bands(0).Columns("Flete").Hidden = True
            .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdCliente").Hidden = True
            .DisplayLayout.Bands(0).Columns("Cliente").Hidden = True
            .DisplayLayout.Bands(0).Columns("Carga").Hidden = True
            .DisplayLayout.Bands(0).Columns("Cobrado").Hidden = True
            .DisplayLayout.Bands(0).Columns("Importe").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdGrupo").Hidden = True

            .DisplayLayout.Bands(0).Columns("Cargado").Width = 60
            .DisplayLayout.Bands(0).Columns("Cobrado").Width = 60
            .DisplayLayout.Bands(0).Columns("Fecha").Width = 70
            .DisplayLayout.Bands(0).Columns("Trabajador").Width = 200
            .DisplayLayout.Bands(0).Columns("Viaje").Width = 100
            .DisplayLayout.Bands(0).Columns("Glosa").Width = 500

            .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 1
            .DisplayLayout.Bands(0).Columns("Cargado").Header.VisiblePosition = 2
            .DisplayLayout.Bands(0).Columns("Cobrado").Header.VisiblePosition = 3

            .DisplayLayout.Bands(0).Columns("Cobrado").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .DisplayLayout.Bands(0).Columns("Cargado").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .DisplayLayout.Bands(0).Columns("Cargado").Format = "#,###,###,####0.00"

            CalcularTotales(Grilla, "Cobrado", "Cargado")
            .DisplayLayout.Bands(0).Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
            .DisplayLayout.Bands(0).Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
            If .Rows.Count > 0 Then
                .Focus()
                .Rows.Item(0).Selected = True
            End If
            .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
            .DisplayLayout.Override.FilterUIProvider = Filtro
            .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
            .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
            .DisplayLayout.Bands(0).Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
            .DisplayLayout.Bands(0).Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        End With
    End Sub

    Private Sub colorCargado_ColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colorCargado.ColorChanged
        EtiCargado.Appearance.BackColor = colorCargado.Color
    End Sub

    Private Sub verAdelanto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verAdelanto.CheckedChanged
        If verAdelanto.Checked = True Then
            decImporteCarga.Enabled = True
            txtGlosa.Text = "ADELANTO DE FLETE N° OPERACION: " & griLista.ActiveRow.Cells("Operacion").Value & " /VIAJE: " & _
                    cboViaje.Text & " /RUTA: " & etiRutaCarga.Text & " /Trabajador: " & cboTrabajadorFlete.Text
        Else
            decImporteCarga.Enabled = False
            decImporteCarga.Value = CDec(etiSaldoCarga.Text)
            txtGlosa.Text = "A CARGO FLETE N° OPERACION: " & griLista.ActiveRow.Cells("Operacion").Value & " /VIAJE: " & _
                    cboViaje.Text & " /RUTA: " & etiRutaCarga.Text & " /Trabajador: " & cboTrabajadorFlete.Text
        End If
    End Sub

    Private Sub verCheque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verCheque.CheckedChanged
        If Me.ficCargaFlete.SelectedTab.Index = 0 And Me.etiEstadoAsociado.Text = "PENDIENTE" Then
            mensajeEmergente.Problema("No Puede Habilitar Viaje con Cheque")
            Exit Sub
        Else
            If verCheque.Checked = True Then
                agrCheque.Enabled = True
            Else
                agrCheque.Enabled = False
            End If
        End If

    End Sub

    Private Sub decImporteCarga_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decImporteCarga.ValueChanged
        Try
            If IsDBNull(decImporteCarga.Value) Then decImporteCarga.Value = 0.0
            If decImporteCarga.Value > CDec(Me.etiSaldoCarga.Text) Then
                ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 1)
            Else
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub decImporteCobro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decImporteCobro.ValueChanged
        If decImporteCobro.Value > CDec(etiSaldoFlete.Text) Then
            ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 1)
        Else
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            oeMovimiento.Ingreso = decImporteCobro.Value
        End If
    End Sub

    Private Sub cboTrabajadorFlete_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrabajadorFlete.ValueChanged
        Try
            Dim oeTemp As New e_CuentaCorriente
            With cboTrabajadorFlete
                If .SelectedIndex > -1 Then
                    Dim i As Integer = .SelectedIndex
                    ' otemp (Id, NombreCompleto) {e_Trabajador}
                    Dim otemp = .Items(i).ListObject
                    oeMovimiento.IdCuentaCorrienteDestino = BuscarIdCtaCte(otemp.Id, 0, loCuentaCorriente)
                    CargaComboViajePiloto(otemp.Id)
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboViaje_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboViaje.ValueChanged
        Dim oeTemp As New e_Movimiento_Viaje
        etiRutaCarga.Text = String.Empty
        decSaldoViaje.Value = 0
        etiEstadoAsociado.Text = String.Empty
        etiFechaViajeAsociado.Text = String.Empty
        With cboViaje
            If .SelectedIndex > -1 Then
                Dim i As Integer = .SelectedIndex
                oeTemp = .Items(i).ListObject
                etiRutaCarga.Text = oeTemp.Ruta
                decSaldoViaje.Value = oeTemp.SaldoTotal
                decImporteCarga.Value = 0.0
                etiEstadoAsociado.Text = oeTemp.Estado
                etiFechaViajeAsociado.Text = oeTemp.Fecha
                IdMovimiento = oeTemp.IdMovimiento
                IdViaje = oeTemp.IdViaje
                If OperacionFlete = "Cargar" Then
                    txtGlosa.Text = "A CARGO FLETE N° VIAJE: " & griLista.ActiveRow.Cells("Codigo").Value.ToString & " /RUTA: " & etiRutaCarga.Text & " /Trabajador: " & cboTrabajadorFlete.Text
                ElseIf OperacionFlete = "Cobrar" Then
                    txtGlosaCobro.Text = "INGRESO A CHICLAYO DE FLETE N° OPERACION: " & griLista.ActiveRow.Cells("Operacion").Value & " /VIAJE: " & _
                   oeTemp.Viaje & " /RUTA: " & etiRutaCarga.Text & " /Trabajador: " & cboTrabajadorFlete.Text
                End If
            End If
        End With
        If decImporteCarga.Value > CDec(etiSaldoCarga.Text) And cboViaje.SelectedIndex = -1 Then
            ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 1)
        Else
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub fecFechaCarga_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecFechaCarga.ValueChanged, fecFechaCarga.KeyDown, fecFechaCarga.GotFocus
        oeMovimiento.Fecha = fecFechaCarga.Value
    End Sub

    Private Sub txtGlosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
        oeMovimiento.Glosa = txtGlosa.Text
    End Sub

    Private Sub griViajeDetalle_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griViajeDetalle.AfterRowActivate
        Try
            LimpiarSaldos()
            If griViajeDetalle.ActiveRow.Index >= 0 Then
                expOperacionDetalle.Text = "Operaciones - Detalles/ N° Operacion: " & griLista.ActiveRow.Cells("Operacion").Value & "/ Piloto: " & _
                                griLista.ActiveRow.Cells("Piloto").Value & "/ Viaje: " & griLista.ActiveRow.Cells("Codigo").Value
                Dim olMovFle As New l_Movimiento_Flete
                Dim oeMovFle As New e_Movimiento_Flete
                loMovimientoFlete.Clear()
                oeMovimientoFlete = New e_Movimiento_Flete
                oeMovimientoFlete.TipoOperacion = "2"
                oeMovimientoFlete.IdOperacionDetalle = griViajeDetalle.ActiveRow.Cells("Id").Value
                oeMovFle.TipoOperacion = "8"
                oeMovFle.Id = oeMovimientoFlete.IdOperacionDetalle
                oeMovFle = olMovFle.Obtener(oeMovFle)
                With griMovimientoFlete
                    .ResetDisplayLayout()
                    loMovimientoFlete = olMovimientoFlete.Listar(oeMovimientoFlete)
                    .DataSource = loMovimientoFlete
                    If .Rows.Count > 0 Then
                        .Focus()
                        .Rows.Item(0).Selected = True
                        .Rows.Item(0).Activated = True
                    End If
                    .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdOperacionDetalle").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdMovimiento").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdCheque").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdViaje").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdTrabajador").Hidden = True
                    .DisplayLayout.Bands(0).Columns("ApellidoPaterno").Hidden = True
                    .DisplayLayout.Bands(0).Columns("ApellidoMaterno").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Nombre").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Glosa").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdGrupo").Hidden = True
                    .DisplayLayout.Bands(0).Columns("TipoCobro").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Trabajador").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Depositado").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Flete").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Importe").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Origen").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Destino").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdCliente").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Cliente").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Carga").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Cobrado").Header.Caption = "Extorno"
                    .DisplayLayout.Bands(0).Columns("Cargado").Width = 70
                    .DisplayLayout.Bands(0).Columns("Cobrado").Width = 70
                    .DisplayLayout.Bands(0).Columns("Fecha").Width = 55
                    .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").Width = 100
                    .DisplayLayout.Bands(0).Columns("Viaje").Width = 100
                    .DisplayLayout.Bands(0).Columns("NumeroCheque").Width = 100
                    .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 1
                    .DisplayLayout.Bands(0).Columns("Cargado").Header.VisiblePosition = 2
                    .DisplayLayout.Bands(0).Columns("Cobrado").Header.VisiblePosition = 3
                    .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").Header.VisiblePosition = 4
                    .DisplayLayout.Bands(0).Columns("Viaje").Header.VisiblePosition = 5
                    .DisplayLayout.Bands(0).Columns("NumeroCheque").Header.VisiblePosition = 6
                    .DisplayLayout.Bands(0).Columns("Cobrado").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                    .DisplayLayout.Bands(0).Columns("Cargado").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                    .DisplayLayout.Bands(0).Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
                    .DisplayLayout.Bands(0).Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
                    .DisplayLayout.Bands(0).Override.CellClickAction = CellClickAction.RowSelect
                    .DisplayLayout.Bands(0).Override.AllowUpdate = DefaultableBoolean.False
                    '.DisplayLayout.Bands(0).Override.c
                    If griViajeDetalle.Rows.Count > 0 Then
                        decMontoFlete.Value = round(griViajeDetalle.ActiveRow.Cells("Flete").Value, 2)
                        If oeMovFle.Id <> "" Then
                            decFleteDepositado.Value = oeMovFle.Depositado
                            decSaldoFlete.Value = decMontoFlete.Value - decFleteDepositado.Value
                        Else
                            decSaldoFlete.Value = Round((decMontoFlete.Value - CalcularSaldo()), 2)
                        End If
                        Dim DepoTotal As Double = 0
                        If griMovimientoFlete.Rows.Count > 0 Then
                            decSaldoFlete.Value = decMontoFlete.Value - decTotalCargado.Value
                            decFleteDepositado.Value = Round((Cargado - Depositado), 2)
                            Dim Depo As Double = 0
                            Dim Carga As Double = 0
                            Dim Carga2 As Double = 0
                            For i = 0 To .Rows.Count - 1
                                Depo += .Rows(i).Cells("SaldoPorDepositar").Value
                                If .Rows(i).Cells("SaldoPorDepositar").Value <> 0 Then
                                    Carga += .Rows(i).Cells("Cargado").Value
                                End If
                                Carga2 += .Rows(i).Cells("Cargado").Value
                                DepoTotal += .Rows(i).Cells("Depositado").Value
                            Next
                            decSaldoPorDepositar.Value = Depo
                            decTotalCargado.Value = Carga
                            decSaldoFlete.Value = decMontoFlete.Value - (oeMovFle.Depositado + Carga2)
                        End If

                        If Me.griMovimientoFlete.Rows.Count > 0 Then
                            decFleteDepositado.Value = oeMovFle.Depositado + DepoTotal
                        End If
                    End If
                End With
            Else
                griMovimientoFlete.DataSource = Nothing
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub verChequePorCobrar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verChequePorCobrar.CheckedChanged
        If verChequePorCobrar.Checked Then
            ListarCheques(True)
            cboViaje.SelectedIndex = -1
            expCheque.Expanded = True
            agrViaje.Enabled = False
        Else
            expCheque.Expanded = False
            agrViaje.Enabled = True
            decImporteCobro.Value = CalcularSaldo()
        End If
        txtGlosaCobro.Text = "INGRESO A CHICLAYO DE FLETE N° OPERACION: " & griLista.ActiveRow.Cells("Operacion").Value
    End Sub

    Private Sub mnuConsultarCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConsultarCheque.Click
        ListarCheques(True)
    End Sub

    Private Sub griChequexCobrar_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griChequexCobrar.AfterRowActivate
        If expCheque.Expanded = True AndAlso griChequexCobrar.ActiveRow.Index >= 0 AndAlso griChequexCobrar.ActiveRow.Cells("Cobrado").Value = True Then
            decImporteCobro.Value = griChequexCobrar.ActiveRow.Cells("Monto").Value
            fecFechaCobro.Value = griChequexCobrar.ActiveRow.Cells("FechaCobro").Value
            txtGlosaCobro.Text = "INGRESO A CHICLAYO DE FLETE N° OPERACION: " & griLista.ActiveRow.Cells("Operacion").Value & "/ Banco : " _
            & griChequexCobrar.ActiveRow.Cells("Banco").Value & "/ Cheque :" & griChequexCobrar.ActiveRow.Cells("NroCheque").Value
        Else
            txtGlosaCobro.Text = String.Empty
            decImporteCobro.Value = 0
            fecFechaCobro.Value = Date.Now
        End If
    End Sub

    Private Sub txtGlosaCobro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosaCobro.ValueChanged
        oeMovimiento.Glosa = txtGlosaCobro.Text
    End Sub

    Private Sub fecFechaCobro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecFechaCobro.ValueChanged
        oeMovimiento.Fecha = fecFechaCobro.Value
    End Sub

    Private Sub MenuContextualCheque_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextualCheque.Opening
        MenuContextualCheque.Items("mnuConsultarCheque").Visible = False
        If verChequePorCobrar.Checked Then MenuContextualCheque.Items("mnuConsultarCheque").Visible = True
    End Sub

    Private Sub MenuExtornar_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuExtornar.Opening
        MenuExtornar.Items("mnuExtornar").Visible = False
        If griMovimientoFlete.Rows.Count > 0 Then
            MenuExtornar.Items("mnuExtornar").Visible = True
        End If
    End Sub

    Private Sub griViajeDetalle_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griViajeDetalle.CellChange
        griViajeDetalle.UpdateData()
        Dim oeDemandaDetalle As New e_DemandaDetalle
        With oeDemandaDetalle
            With griViajeDetalle.ActiveRow
                If .Cells("Carga").Text = "TONELADA" Then
                    If Not .Cells("PesoToneladasDescarga").Value.ToString = "" Or Not IsNumeric(.Cells("PesoToneladasDescarga").Value.ToString) Then
                        oeDemandaDetalle.Cantidad = CDbl(.Cells("PesoToneladasDescarga").Value)
                    Else
                        .Cells("PesoToneladasDescarga").Value = 0
                    End If
                    If .Cells("Seleccion").Value Then
                        .Cells("IndPesoTnDescarga").Value = 1
                    Else
                        .Cells("IndPesoTnDescarga").Value = 0
                    End If
                Else
                    If Not .Cells("Cantidad").Value.ToString = "" Or Not IsNumeric(.Cells("Cantidad").Value.ToString) Then
                        oeDemandaDetalle.Cantidad = CDbl(.Cells("Cantidad").Value)
                    Else
                        .Cells("Cantidad").Value = 0
                    End If
                End If
                If Not .Cells("FleteUnitario").Value.ToString = "" Or Not IsNumeric(.Cells("FleteUnitario").Value.ToString) Then
                    oeDemandaDetalle.FleteUnitario = CDbl(.Cells("FleteUnitario").Value)
                Else
                    .Cells("FleteUnitario").Value = 0
                End If
                oeIgv = OlIgv.IGV(Date.Now)
                oeDemandaDetalle.IGV = oeIgv.Porcentaje
                If .Cells("IncluyeIgv").Value = False Then
                    .Cells("Flete").Value = oeDemandaDetalle.FleteCalcularSinIgv
                Else
                    .Cells("Flete").Value = oeDemandaDetalle.FleteCalcularIgv
                End If
            End With
        End With
    End Sub

    Private Sub griViajeDetalle_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griViajeDetalle.BeforeCellUpdate
        With griViajeDetalle
            Select Case e.Cell.Column.Key
                Case "PesoToneladasDescarga"
                    If e.Cell.Column.Key = "PesoToneladasDescarga" Then If IsDBNull(e.NewValue) Then e.Cancel = True
                Case "FleteUnitario"
                    If e.Cell.Column.Key = "FleteUnitario" Then If IsDBNull(e.NewValue) Then e.Cancel = True
                Case "Glosa"
                    If IsDBNull(e.NewValue) Then
                        e.Cancel = True
                        Exit Sub
                    End If
            End Select
        End With
    End Sub

    Private Sub griViajeDetalle_ClickCellButton(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griViajeDetalle.ClickCellButton
        Try
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim oe As New e_OperacionDetalle
            Select Case e.Cell.Column.Key
                Case "Mod"
                    oe = New e_OperacionDetalle
                    oe.TipoOperacion = "F"
                    oe.Id = griViajeDetalle.ActiveRow.Cells("Id").Value
                    oe.PesoToneladasDescarga = griViajeDetalle.ActiveRow.Cells("PesoToneladasDescarga").Value
                    oe.IndPesoTnDescarga = griViajeDetalle.ActiveRow.Cells("IndPesoTnDescarga").Value
                    oe.PesoToneladas = griViajeDetalle.ActiveRow.Cells("PesoToneladas").Value
                    oe.Flete = griViajeDetalle.ActiveRow.Cells("Flete").Value
                    oe.FleteUnitario = griViajeDetalle.ActiveRow.Cells("FleteUnitario").Value
                    oe.IncluyeIgv = griViajeDetalle.ActiveRow.Cells("IncluyeIgv").Value
                    oe.SaldoCarga = griViajeDetalle.ActiveRow.Cells("Flete").Value
                    oe.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olOperacion.GuardarOperacionDetalle(oe) Then mensajeEmergente.Confirmacion(Me.Text & ": La Informacion del flete ha sido grabada Satisfactoriamente", True)
                    decMontoFlete.Value = griViajeDetalle.ActiveRow.Cells("Flete").Value
                    decSaldoFlete.Value = decMontoFlete.Value - CalcularSaldo()
                    decTotalCargado.Value = Cargado - Cobrado
                    decFleteDepositado.Value = Cargado - Depositado
                    decSaldoPorDepositar.Value = SaldoPorDepositar
                    decFleteDepositado.Value = Depositado
                Case "Glosa"
                    oe = New e_OperacionDetalle
                    oe.TipoOperacion = "X"
                    oe.Id = griViajeDetalle.ActiveRow.Cells("Id").Value
                    oe.Glosa = griViajeDetalle.ActiveRow.Cells("Glosa").Value
                    oe.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olOperacion.GuardarOperacionDetalle(oe) Then mensajeEmergente.Confirmacion(Me.Text & ": La Informacion del flete ha sido grabada Satisfactoriamente", True)
            End Select
            griViajeDetalle.Rows.Item(0).Selected = True
            griViajeDetalle.Rows.Item(0).Activated = True
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
        End Try
    End Sub

    Private Sub txtOperacion_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOperacion.Validated
        Try
            If txtOperacion.Text <> "" Then
                If CInt(txtOperacion.Text) > 0 Then
                    txtOperacion.Text = FormatoDocumento(txtOperacion.Text.Trim, 12)
                End If
            End If
            txtOperacion.Update()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtViaje_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtViaje.Validated
        Try
            If txtViaje.Text <> "" Then txtViaje.Text = FormatoDocumento(txtViaje.Text.Trim, 12)
            txtViaje.Update()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtOperacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOperacion.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Listar()
        End If
    End Sub

    Private Sub griLista_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griLista.InitializeLayout
        agrOperaciones.Text = "Total de Operaciones: " & e.Layout.Rows.Count
    End Sub

    Private Sub verBuscarFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verBuscarFecha.CheckedChanged
        'If verBuscarFecha.Checked Then
        '    agrBuscarFecha.Enabled = True
        'Else
        '    agrBuscarFecha.Enabled = False
        'End If
        agrBuscarFecha.Enabled = verBuscarFecha.Checked
        verBuscarOtros.Checked = Not verBuscarFecha.Checked
    End Sub

    Private Sub verBuscarOtros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verBuscarOtros.CheckedChanged
        'If verBuscarOtros.Checked Then
        '    agrBuscarOtros.Enabled = True
        'Else
        '    agrBuscarOtros.Enabled = False
        'End If
        agrBuscarOtros.Enabled = verBuscarOtros.Checked
        verBuscarFecha.Checked = Not verBuscarOtros.Checked
    End Sub

    Private Sub txtViaje_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtViaje.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
        Dim ea As New System.EventArgs
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            txtViaje_Validated(txtViaje, ea)
            Listar()
        End If
    End Sub

    Private Sub ficCargaFlete_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles ficCargaFlete.SelectedTabChanged
        Try
            If ficCargaFlete.Tabs(1).Selected = True Then
                If loCuentaCorriente.Count > 0 Then
                    LlenarCombo(cboAdm, "Trabajador", loCA, -1)
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboAdm_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAdm.ValueChanged
        Try
            Dim otemp As New e_CuentaCorriente
            With cboAdm
                If .SelectedIndex > -1 Then
                    Dim i As Integer = .SelectedIndex
                    otemp = .Items(i).ListObject
                    oeMovimiento.IdCuentaCorrienteDestino = BuscarIdCtaCte(otemp.IdTrabajador, 1, loCuentaCorriente)
                    oeMovimiento.IdCaja = BuscarCajaUsuario(otemp.IdTrabajador)
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub MnuExtornar_Click(sender As Object, e As EventArgs) Handles MnuExtornar.Click
        Try
            If griMovimientoFlete.Selected.Rows.Count > 0 Then ExtornarCarga()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub Listar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeViaje.TipoOperacion = "1"
            oeViaje.Operacion = String.Empty
            oeViaje.Codigo = String.Empty
            oeViaje.IdPiloto = String.Empty
            oeViaje.Cliente = String.Empty
            oeViaje.CargaMaterial = String.Empty
            oeViaje.IdTracto = String.Empty

            If verBuscarFecha.Checked Then
                oeViaje.FechaDesde = Me.fecDesde.Value
                oeViaje.FechaHasta = Me.fecHasta.Value
            Else
                oeViaje.FechaDesde = "#1/1/1901#"
                oeViaje.FechaHasta = "#1/1/1901#"
            End If

            If verBuscarOtros.Checked Then
                oeViaje.Operacion = txtOperacion.Text
                oeViaje.Codigo = txtViaje.Text
                oeViaje.IdPiloto = cboTrabajador.Value
                oeViaje.Cliente = cboCliente.Value
                oeViaje.CargaMaterial = cboCarga.Value
                oeViaje.IdTracto = cboPlaca.Value
                oeViaje.Centro = cboCentro.Value
                If oeViaje.Codigo = String.Empty Then Throw New Exception("Escriba el Codigo del Viaje")
            Else
                oeViaje.Activo = Nothing
            End If
            oeViaje.Activo = verContraEntrega.Checked
            If verBuscarFecha.Checked = True Or verBuscarOtros.Checked = True Then
                With griLista
                    Dim loHabsinCeros As New List(Of e_Viaje)
                    .ResetDisplayLayout()
                    loOperacion = olOperacion.ListarFletes(oeViaje)
                    loHabsinCeros = loOperacion.Where(Function(item) item.TotalFlete > 0).ToList()
                    .DataSource = loHabsinCeros
                    .DisplayLayout.Bands(0).Columns("Operacion").SortIndicator = SortOrder.Ascending
                    .DisplayLayout.Bands(0).Columns("Seleccion").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdCarreta").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdTracto").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Ayudante").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdAyudante").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdOperacion").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdOrigen").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdDestino").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdEscala").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Escala").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Flota").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Zona").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdPiloto").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Copiloto").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdEstado").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Operacion").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdTipoVehiculo").Hidden = True
                    .DisplayLayout.Bands(0).Columns("DisponibleP").Hidden = True
                    .DisplayLayout.Bands(0).Columns("DisponibleC").Hidden = True
                    .DisplayLayout.Bands(0).Columns("DisponibleA").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IndEscala").Hidden = True
                    .DisplayLayout.Bands(0).Columns("GlosaEscala").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IncidenciaOperaciones").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IncidenciaSeguimiento").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdCopiloto").Hidden = True
                    .DisplayLayout.Bands(0).Columns("LlegadaOrigen").Hidden = True
                    .DisplayLayout.Bands(0).Columns("SalidaOrigen").Hidden = True
                    .DisplayLayout.Bands(0).Columns("LlegadaDestino").Hidden = True
                    .DisplayLayout.Bands(0).Columns("SalidaDestino").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Carga").Hidden = True
                    .DisplayLayout.Bands(0).Columns("UsuarioModifica").Hidden = True
                    .DisplayLayout.Bands(0).Columns("UsuarioSeguimiento").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Turno").Hidden = True
                    .DisplayLayout.Bands(0).Columns("DiaNoche").Hidden = True
                    .DisplayLayout.Bands(0).Columns("kmTractoOrigen").Hidden = True
                    .DisplayLayout.Bands(0).Columns("kmTractoDestino").Hidden = True
                    .DisplayLayout.Bands(0).Columns("kmCarretaOrigen").Hidden = True
                    .DisplayLayout.Bands(0).Columns("kmCarretaDestino").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IndFecha").Hidden = True
                    .DisplayLayout.Bands(0).Columns("PorcentajeFlete").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Tesoreria").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IngresoComplejoOrigen").Hidden = True
                    .DisplayLayout.Bands(0).Columns("CargaOrigen").Hidden = True
                    .DisplayLayout.Bands(0).Columns("TerminoCargaOrigen").Hidden = True
                    .DisplayLayout.Bands(0).Columns("ImpresionGuiaOrigen").Hidden = True
                    .DisplayLayout.Bands(0).Columns("LlegadaAproximadaDestino").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IngresoDestino").Hidden = True
                    .DisplayLayout.Bands(0).Columns("DescargaDestino").Hidden = True
                    .DisplayLayout.Bands(0).Columns("TerminoDescargaDestino").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Cantidad").Hidden = True
                    .DisplayLayout.Bands(0).Columns("FleteUnitario").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Subtotal").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Consolidado").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdTercero").Hidden = True

                    .DisplayLayout.Bands(0).Columns("Codigo").Header.Caption = "Viaje"
                    .DisplayLayout.Bands(0).Columns("Operacion").Header.VisiblePosition = 1
                    .DisplayLayout.Bands(0).Columns("Codigo").Header.VisiblePosition = 2
                    .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 3
                    .DisplayLayout.Bands(0).Columns("Zona").Header.VisiblePosition = 4
                    .DisplayLayout.Bands(0).Columns("Origen").Header.VisiblePosition = 5
                    .DisplayLayout.Bands(0).Columns("Destino").Header.VisiblePosition = 6
                    .DisplayLayout.Bands(0).Columns("Piloto").Header.VisiblePosition = 7
                    .DisplayLayout.Bands(0).Columns("Tracto").Header.VisiblePosition = 8
                    .DisplayLayout.Bands(0).Columns("Carreta").Header.VisiblePosition = 9
                    .DisplayLayout.Bands(0).Columns("Flota").Header.VisiblePosition = 10
                    .DisplayLayout.Bands(0).Columns("Cliente").Header.VisiblePosition = 11
                    .DisplayLayout.Bands(0).Columns("ViajeVacio").Header.VisiblePosition = 12
                    .DisplayLayout.Bands(0).Columns("Estado").Header.VisiblePosition = 13
                    .DisplayLayout.Bands(0).Columns("TotalFlete").Header.VisiblePosition = 14
                    .DisplayLayout.Bands(0).Columns("PesoToneladas").Header.VisiblePosition = 15

                    .DisplayLayout.Bands(0).Columns("Carga").Header.VisiblePosition = 20
                    .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Header.VisiblePosition = 21

                    .DisplayLayout.Bands(0).Columns("Operacion").Width = 90
                    .DisplayLayout.Bands(0).Columns("Codigo").Width = 90
                    .DisplayLayout.Bands(0).Columns("Fecha").Width = 60

                    .DisplayLayout.Bands(0).Columns("Piloto").Width = 250

                    .DisplayLayout.Bands(0).Columns("ViajeVacio").Style = ColumnStyle.CheckBox
                    .DisplayLayout.Bands(0).Columns("Carga").Style = ColumnStyle.CheckBox
                    .DisplayLayout.Bands(0).Columns("DiaNoche").Style = ColumnStyle.CheckBox

                    .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                    .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                    .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                    .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                    .DisplayLayout.Override.FilterUIProvider = Filtro
                    .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                    .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                End With

                For Each fila As UltraGridRow In griLista.Rows
                    Dim var As String = fila.Cells("Ayudante").Value
                    If fila.Cells("Ayudante").Value = "1" Then fila.Appearance.BackColor = colorCargado.Color
                Next
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub ListarReporteFlete()
        InicializarReporte()
        oeReporteFlete.TipoOperacion = "1"
        loReporteFlete = olReporteFlete.Listar(oeReporteFlete)
    End Sub

    Public Function BuscarCajaUsuario(IdTrabajador) As String
        Try
            Dim IdCaja As String = ""
            For Each cajatrab As e_CajaUsuario In loCajaUsuario
                If cajatrab.IdTrabajador = IdTrabajador Then
                    IdCaja = cajatrab.IdCaja
                    Exit For
                End If
            Next
            Return IdCaja
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub InicializarEntidad()
        oeViaje = New e_Viaje
    End Sub

    Private Sub InicializarDeposito()
        oeDeposito = New e_Deposito
    End Sub

    Private Sub InicializarReporte()
        oeReporteFlete = New e_ReporteFlete
    End Sub

    Private Function CalcularSaldo() As Decimal
        Cargado = 0
        Cobrado = 0
        Depositado = 0
        SaldoPorDepositar = 0
        For Each Lista As e_Movimiento_Flete In loMovimientoFlete
            Cargado = Cargado + Lista.Cargado
            Cobrado = Cobrado + Lista.Cobrado
            SaldoPorDepositar = SaldoPorDepositar + Lista.SaldoPorDepositar
        Next
        Depositado = (Cargado - Cobrado) - SaldoPorDepositar
        Return Cargado - Cobrado
    End Function

    Private Function VerificarEditado(IdViaje As String) As Boolean
        Try
            Dim oeRegistroEditado As New e_RegistrosEditados
            Dim olRegistroEditado As New l_RegistrosEditados
            oeRegistroEditado.TipoOperacion = "1"
            oeRegistroEditado.Id = IdViaje
            oeRegistroEditado = olRegistroEditado.Obtener(oeRegistroEditado)
            If oeRegistroEditado.Id <> "" Then Return False
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Sub LimpiarCobroFlete()
        decImporteCobro.Value = 0
        txtGlosaCobro.Text = String.Empty
        fecFechaCobro.Value = Date.Now
        verExtornoCobro.Checked = False
    End Sub

    Sub LimpiarCargaFlete()
        verAdelanto.Checked = False
        decImporteCarga.Value = 0
        decImporteCarga.Enabled = False
        fecFechaCarga.Value = Date.Now
        txtGlosa.Text = String.Empty
        verCheque.Checked = False
        agrCheque.Enabled = False
        txtNumeroCheque.Text = String.Empty
        fecFechaCheque.Value = Date.Now
        cboTrabajadorFlete.SelectedIndex = -1
        cboViaje.SelectedIndex = -1
        etiRutaCarga.Text = String.Empty
        etiFechaViajeAsociado.Text = String.Empty
        etiEstadoAsociado.Text = String.Empty
        decSaldoViaje.Value = 0
    End Sub

    Private Sub ListarCuentaCorriente()
        oeCuentaCorriente = New e_CuentaCorriente
        oeCuentaCorriente.Activo = True
        loCuentaCorriente = olCuentaCorriente.Listar(oeCuentaCorriente).OrderBy(Function(item) item.Trabajador).ToList
        loCA.AddRange(loCuentaCorriente.Where(Function(item) item.Tipo = 1))
    End Sub

    Public Sub ListarCheques(ByVal Activo As Boolean)
        Try
            With griChequexCobrar
                oeChequexCobrar = New e_ChequexCobrar
                oeChequexCobrar.Activo = Activo
                .DataSource = olChequexCobrar.Listar(oeChequexCobrar)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        'griChequexCobrar.Focus()
    End Sub

    Private Sub CargaComboViajePiloto(ByVal IdTrabajador As String)
        Try
            Dim oeViajePiloto As New e_Movimiento_Viaje
            Dim olViajePiloto As New l_Movimiento_Viaje
            Dim asd As String = ""
            oeViajePiloto.TipoOperacion = "3"
            oeViajePiloto.IdPiloto = IdTrabajador
            oeViajePiloto.VincularViajePiloto = "1"
            oeViajePiloto.TipoTransa = "1"
            asd = griLista.ActiveRow.Cells("Id").Value.ToString
            oeViajePiloto.IdViaje = asd
            LlenarCombo(cboViaje, "Viaje", olViajePiloto.Listar(oeViajePiloto), -1)
            cboViaje.SelectedIndex = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub LimpiarSaldos()
        Try
            decSaldoFlete.Value = 0
            decTotalCargado.Value = 0
            decMontoFlete.Value = 0
            decFleteDepositado.Value = 0
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CargarCombos()

        Dim oePiloto As New e_Trabajador
        oeTrabajador = New e_Trabajador : loTrabajador.Clear()
        oeMaterial = New e_Material : loMaterial.Clear()
        oeCliente = New e_Cliente : loCliente.Clear()
        oeVehiculo = New e_Vehiculo : loVehiculo.Clear()

        oeMaterial.Id = String.Empty
        oeMaterial.Nombre = "TODOS"
        loMaterial.Add(oeMaterial)

        oeMaterial = New e_Material
        oeMaterial.TipoOperacion = "O"
        oeMaterial.Activo = True
        loMaterial.AddRange(olMaterial.Listar(oeMaterial))
        LlenarCombo(cboCarga, "Nombre", loMaterial, 0)

        oeCliente.Id = String.Empty
        oeCliente.Nombre = "TODOS"
        loCliente.Add(oeCliente)

        oeCliente = New e_Cliente
        oeCliente.TipoOperacion = ""
        oeCliente.Activo = True
        oeCliente.TipoClienteProveedor = 1
        loCliente.AddRange(olCliente.Listar(oeCliente))
        LlenarCombo(cboCliente, "Nombre", loCliente, 0)

        oeTrabajador.Id = String.Empty
        oeTrabajador.oePersona.ApellidoPaterno = "TODOS"
        loTrabajador.Add(oeTrabajador)

        oeTrabajador = New e_Trabajador
        loTrabajador.AddRange(olTrabajador.Listar(oeTrabajador))
        ' _leTrabAux[Lista] (Id, NombreCompleto) {e_Trabajador}
        Dim _leTrabAux = From le In loTrabajador _
                         Select le.Id, le.oePersona.NombreCompleto
        LlenarCombo(cboTrabajador, "NombreCompleto", _leTrabAux.ToList, 0)

        oeVehiculo.Id = String.Empty
        oeVehiculo.Placa = "TODOS"
        loVehiculo.Add(oeVehiculo)

        oeVehiculo = New e_Vehiculo
        oeVehiculo.Motriz = 1
        oeVehiculo.Activo = True
        loVehiculo.AddRange(olVehiculo.Listar(oeVehiculo))
        LlenarCombo(cboPlaca, "Placa", loVehiculo, 0)

        oeCajaUsuario = New e_CajaUsuario
        oeCajaUsuario.TipoOperacion = ""
        loCajaUsuario.AddRange(olCajaUsuario.Listar(oeCajaUsuario))
        
    End Sub

    Private Sub LlenaComboTrabajadorFlete()
        cboTrabajadorFlete.DataSource = Nothing
        Dim _leTrabFle = From leF In loTrabajador _
                         Select leF.Id, leF.oePersona.NombreCompleto
        LlenarCombo(cboTrabajadorFlete, "NombreCompleto", _leTrabFle.ToList, -1)
        LlenarCombo(cboAdm, "NombreCompleto", loTrabajador, -1)
    End Sub

    Private Function BuscarTrabajadorCuentaCorriente(ByVal IdTrabajador As String) As String
        Dim IdCuentaCorriente As String = ""
        Try
            For Each Lista As e_CuentaCorriente In loCuentaCorriente
                If Lista.IdTrabajador = IdTrabajador Then IdCuentaCorriente = Lista.Id
                Exit For
            Next
        Catch ex As Exception
            Throw ex
        End Try
        Return IdCuentaCorriente
    End Function

    Private Sub ExtornarCarga()
        Try
            If griMovimientoFlete.ActiveRow.Cells("SaldoporDepositar").Value = 0 Then Throw New Exception("No Puede Extornar Flete Depositado")
            If MessageBox.Show("Desea Extornar la Carga del Viaje Seleccionado?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.No Then
                Exit Sub
            Else
                oeMovimiento = New e_Movimiento
                oeMovimiento.TipoOperacion = "F"
                oeMovimiento.Id = griMovimientoFlete.ActiveRow.Cells("IdMovimiento").Value
                oeMovimiento = olMovimiento.ObtenerMovimiento(oeMovimiento)
                If Not oeMovimiento.IndAdministrativo Then
                    If oeMovimiento.IdMovimientoViaje <> gNombreEstadoHabilitada Then Throw New Exception("Solo Puede Extornar Cargas de Viajes Habilitados")
                    If oeMovimiento.Importe < CDbl(oeMovimiento.ViajeId) Then Throw New Exception("El Importe es Mayor al Saldo del Viaje. No se puede Extornar")
                    oeMovimiento.TipoOperacion = "T"
                    oeMovimiento.Fecha = Date.Parse("01/01/1901")
                    oeMovimiento.FechaCierre = Date.Parse("01/01/1901")
                    oeMovimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olMovimiento.GuardarSimple(oeMovimiento) Then
                        mensajeEmergente.Confirmacion("La Informacion ha Sido Eliminada Correctamente", True)
                        Consultar(True)
                    End If
                Else
                    Dim oeSaldo As New e_Saldo
                    Dim olSaldo As New l_Saldo
                    oeSaldo.TipoOperacion = "3"
                    oeSaldo.IdCaja = oeMovimiento.IdCuentaCorrienteOrigen
                    oeSaldo = olSaldo.Obtener(oeSaldo)
                    If oeMovimiento.Fecha > oeSaldo.FechaHora Then
                        If olMovimiento.Eliminar(oeMovimiento) Then
                            mensajeEmergente.Confirmacion("La Informacion ha Sido Eliminada Correctamente", True)
                            Consultar(True)
                        End If
                    Else
                        Throw New Exception("No Puede Extornar el Flete por que ha sido Cargado Pasado el Cierre de Caja")
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class