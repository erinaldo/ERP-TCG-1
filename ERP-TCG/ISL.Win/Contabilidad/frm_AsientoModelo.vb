'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_AsientoModelo
    Inherits frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_AsientoModelo = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_AsientoModelo
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeAsientoModel As New e_AsientoModelo, olAsientoModel As New l_AsientoModelo
    Private leAsientoModel As New List(Of e_AsientoModelo), leAMAux As New List(Of e_AsientoModelo)
    Private oeDetalleAM As New e_DetalleAsientoModelo, olDetalleAM As New l_DetalleAsientoModelo
    Private leDetalleAM As New List(Of e_DetalleAsientoModelo), leDAMAux As New List(Of e_DetalleAsientoModelo)
    Private oeMoneda As New e_Moneda, olMoneda As New l_Moneda, leMoneda As New List(Of e_Moneda)
    Private oeCtaCtble As New e_CuentaContable, olCtaCtble As New l_CuentaContable, leCtaCtble As New List(Of e_CuentaContable)
    Private oeTipoAsiento As New e_TablaContableDet, olTipoAsiento As New l_TablaContableDet
    Private leTipoAsiento As New List(Of e_TablaContableDet), leTipoAsientoBus As New List(Of e_TablaContableDet)
    Private oeProceso As New e_ProcesoNegocio, olProceso As New l_ProcesoNegocio, leProceso As New List(Of e_ProcesoNegocio)
    Private oeActividad As New e_ActividadNegocio, olActividad As New l_ActividadNegocio, leActividad As New List(Of e_ActividadNegocio)
    Private leAMActividad As New List(Of e_AsientoModelo_ActividadNegocio), oeAMActividad As New e_AsientoModelo_ActividadNegocio
    Private leAMReferencia As New List(Of e_AsientoModelo_Referencia), oeAMReferencia As New e_AsientoModelo_Referencia
    Private leDMReferencia As New List(Of e_DetalleModelo_Referencia), oeDMReferencia As New e_DetalleModelo_Referencia
    Private oeTipoRef As e_AsientoModelo_Referencia, olTipoRef As New l_AsientoModelo_Referencia, leTipoRef As New List(Of e_AsientoModelo_Referencia)
    Private oeReferencia As e_AsientoModelo_Referencia, olReferencia As New l_AsientoModelo_Referencia, leReferencia As New List(Of e_AsientoModelo_Referencia)
    Private _opePrest As String = "", _acl As String = "", BandLoad As Boolean = False

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            Listar()
            If griAsientoModelo.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            _acl = gAccionSistema.NUEVO.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                '_opeGrati = "GENERADA"
                oeAsientoModel = New e_AsientoModelo
                oeAsientoModel.TipoOperacion = "I"
                oeAsientoModel.Activo = True
                Inicializa()
                txtCodigo.Text = fn_ObtenerCodigo()
                MostrarTabs(1, ficAsientoModelo)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            _acl = gAccionSistema.EDITAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                '_opeGrati = "GENERADA"
                Inicializa()
                Mostrar()
                oeAsientoModel.TipoOperacion = "A"
                MostrarTabs(1, ficAsientoModelo)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            RecolectaDatos()
            oeAsientoModel.UsuarioCreacion = gUsuarioSGI.Id
            If oeAsientoModel.TipoOperacion = "A" Then oeAsientoModel.UsuarioModificacion = gUsuarioSGI.Id
            oeAsientoModel.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olAsientoModel.Guardar(oeAsientoModel) Then
                mensajeEmergente.Confirmacion("El Registro se Guardo correctamente!!", True)
                MostrarTabs(0, ficAsientoModelo)
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", _
                              MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                MostrarTabs(0, ficAsientoModelo)
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            _acl = gAccionSistema.ELIMINAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                Dim formulario As frm_AutenticarTrabajador
                formulario = New frm_AutenticarTrabajador
                formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                    Throw New Exception("Ingrese un Clave Correcta")
                Else
                    oeAsientoModel = New e_AsientoModelo
                    oeAsientoModel.TipoOperacion = "E"
                    oeAsientoModel.Id = griAsientoModelo.ActiveRow.Cells("Id").Value
                    ' oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                    oeAsientoModel.UsuarioModificacion = gUsuarioSGI.Id
                    If olAsientoModel.Eliminar(oeAsientoModel) Then
                        mensajeEmergente.Confirmacion("¡La Plantilla de Asiento Nº: " & oeAsientoModel.Codigo & _
                                                         " se ha Eliminado correctamente!", True)
                        MostrarTabs(0, ficAsientoModelo)
                        Consultar(True)
                    End If
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            _acl = gAccionSistema.EXPORTAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                If griAsientoModelo.Rows.Count > 0 Then
                    Exportar_Excel(griAsientoModelo, "Plantilla_Asiento")
                Else
                    Throw New Exception("No hay Registros para Exportar")
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_AsientoModelo_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Select Case ficAsientoModelo.SelectedTab.Index
            Case 0
                If griAsientoModelo.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        End Select
    End Sub

    Private Sub frm_AsientoModelo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_AsientoModelo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarCombos()
            leAsientoModel = New List(Of e_AsientoModelo)
            BandLoad = True
            CargarAsientoModel(leAsientoModel)
            BandLoad = False
            leDetalleAM = New List(Of e_DetalleAsientoModelo)
            CargarDetAsiMod(leDetalleAM)
            MostrarTabs(0, ficAsientoModelo)
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griAsientoModelo_DoubleClick(sender As Object, e As EventArgs) Handles griAsientoModelo.DoubleClick
        If griAsientoModelo.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If cboNivelCuenta.SelectedIndex > 0 AndAlso cboCtaCtble.SelectedIndex = -1 Then cboCtaCtble.Focus() : Throw New Exception("Seleccione Cuenta Contable")
            If cboPartida.SelectedIndex = -1 Then cboPartida.Focus() : Throw New Exception("Seleccione Partida")
            If txtFila.Text.Trim = "" Then txtFila.Focus() : Throw New Exception("Ingrese Fila")
            RecolectaDetalle()
            If oeDetalleAM.TipoOperacion = "I" Then
                oeDetalleAM.UsuarioCreacion = gUsuarioSGI.oePersona.NombreCompleto
                oeDetalleAM.FechaCreacion = Date.Now.Date
                leDetalleAM.Add(oeDetalleAM)
            Else
                If oeDetalleAM.Id.Trim <> "" Then
                    oeDetalleAM.UsuarioModificacion = gUsuarioSGI.oePersona.NombreCompleto
                    oeDetalleAM.FechaModificacion = Date.Now.Date
                Else
                    oeDetalleAM.TipoOperacion = "I"
                End If
            End If
            CargarDetAsiMod(leDetalleAM)
            griDetalle.DataBind()
            MostrarTabs(0, ficDetAsiento)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("¿Desea Cancelar la Operación?", "Mensaje de Sistema", MessageBoxButtons.YesNo, _
                           MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            MostrarTabs(0, ficDetAsiento)
        End If
    End Sub

    Private Sub cboCtaCtble_Validated(sender As Object, e As EventArgs) Handles cboCtaCtble.Validated
        If cboCtaCtble.SelectedIndex > -1 Then
            oeCtaCtble = New e_CuentaContable
            oeCtaCtble.Id = cboCtaCtble.Value
            oeCtaCtble.Equivale = 1
            If leCtaCtble.Contains(oeCtaCtble) Then
                oeCtaCtble = leCtaCtble.Item(leCtaCtble.IndexOf(oeCtaCtble))
                txtCtaCtable.Text = oeCtaCtble.Cuenta
                txtTitulo.Text = oeCtaCtble.Nombre
                cboPartida.Focus()
            End If
        End If
    End Sub

    Private Sub griDetalle_DoubleClick(sender As Object, e As EventArgs) Handles griDetalle.DoubleClick
        If griDetalle.Selected.Rows.Count > 0 Then EditarDetalle()
    End Sub

    Private Sub griAMActividadNegocio_DoubleClick(sender As Object, e As EventArgs) Handles griAMActividadNegocio.DoubleClick
        If griAMActividadNegocio.Selected.Rows.Count > 0 Then EditarAMAct()
    End Sub

    Private Sub cboVinculo_ValueChanged(sender As Object, e As EventArgs) Handles cboVinculo.ValueChanged
        If cboVinculo.SelectedIndex > -1 Then
            If cboVinculo.Value = oeAsientoModel.Id Then
                mensajeEmergente.Problema("No se permite vincular con la misma Plantilla", True)
            Else
                Dim oeVinc = cboVinculo.Items(cboVinculo.SelectedIndex).ListObject
                txtCodVinculo.Text = oeVinc.Codigo
                Dim _leAux = leDAMAux.Where(Function(it) it.IdAsientoModelo = oeVinc.id).ToList
                CargarDetVinc(_leAux)
            End If
        End If
    End Sub

    Private Sub cboNivelCuenta_ValueChanged(sender As Object, e As EventArgs) Handles cboNivelCuenta.ValueChanged
        If cboNivelCuenta.SelectedIndex > -1 Then
            txtCtaCtable.ReadOnly = IIf(cboNivelCuenta.SelectedIndex = 0, False, True)
            Dim _leCtaAux = From le In leCtaCtble.Where(Function(it) it.NivelCuenta = cboNivelCuenta.SelectedIndex).ToList _
                            Select le.Id, Nombre = le.Cuenta.Trim & " - " & le.Nombre.Trim _
                            Order By Nombre
            LlenarCombo(cboCtaCtble, "Nombre", _leCtaAux.ToList, -1)
        End If
    End Sub

    Private Sub cboProceso_ValueChanged(sender As Object, e As EventArgs) Handles cboProceso.ValueChanged
        If cboProceso.SelectedIndex > -1 Then
            Dim _leActAux = leActividad.Where(Function(it) it.IdProcesoNegocio = cboProceso.Value).ToList
            If _leActAux.Count > 0 Then
                LlenarCombo(cboActividad, "Nombre", _leActAux, -1)
            End If
        Else
            cboActividad.SelectedIndex = -1
        End If
    End Sub

    Private Sub cboActividad_ValueChanged(sender As Object, e As EventArgs) Handles cboActividad.ValueChanged
        'If cboActividad.SelectedIndex > -1 Then
        'oeAMActividad.IdActividadNegocio = cboActividad.Value
        '    oeAMActividad.TipoOperacion = IIf(oeAMActividad.Id.Trim <> "", "A", "I")
        'Else
        '    oeAMActividad.TipoOperacion = IIf(oeAMActividad.Id.Trim <> "", "E", "")
        'End If
        'oeAMActividad.UsuarioCreacion = gUsuarioSGI.Id : oeAMActividad.UsuarioModifica = gUsuarioSGI.Id
    End Sub

    Private Sub btnCancelarRef_Click(sender As Object, e As EventArgs) Handles btnCancelarRef.Click
        If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", MessageBoxButtons.YesNo, _
                           MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            MostrarTabs(0, ficAsientoProceso)
        End If
    End Sub

    Private Sub cboTipoReferencia_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoReferencia.ValueChanged
        If cboTipoReferencia.SelectedIndex > -1 Then
            Dim _leRefAux = leReferencia.Where(Function(it) it.TipoReferencia = cboTipoReferencia.Value).OrderBy(Function(it) it.Referencia).ToList
            LlenarCombo(cboReferencia, "Referencia", _leRefAux, -1)
        Else
            cboReferencia.SelectedIndex = -1
        End If
    End Sub

    Private Sub btnAceptarRef_Click(sender As Object, e As EventArgs) Handles btnAceptarRef.Click
        Try
            If cboTipoReferencia.SelectedIndex = -1 Then cboTipoReferencia.Focus() : Throw New Exception("Seleccione Tipo Referencia")
            If cboReferencia.SelectedIndex = -1 Then cboReferencia.Focus() : Throw New Exception("Seleccione Referencia")
            RecolectaReferencia()
            If oeAMReferencia.TipoOperacion = "I" Then
                oeAMReferencia.UsuarioCreacion = gUsuarioSGI.Id
                oeAMReferencia.FechaCreacion = Date.Now.Date
                leAMReferencia.Add(oeAMReferencia)
            Else
                If oeAMReferencia.Id.Trim <> "" Then
                    oeAMReferencia.UsuarioModifica = gUsuarioSGI.Id
                    oeAMReferencia.FechaModifica = Date.Now.Date
                Else
                    oeAMReferencia.TipoOperacion = "I"
                End If
            End If
            CargarReferencias(leAMReferencia, oeAMReferencia.IdActividad)
            griReferenciaAsiento.DataBind()
            MostrarTabs(0, ficAsientoProceso)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griReferenciaAsiento_DoubleClick(sender As Object, e As EventArgs) Handles griReferenciaAsiento.DoubleClick
        EditarReferencia()
    End Sub

    Private Sub cboTipoRefDetMod_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoRefDetMod.ValueChanged
        If cboTipoRefDetMod.SelectedIndex > -1 Then
            Dim _leRefAux = leReferencia.Where(Function(it) it.TipoReferencia = cboTipoRefDetMod.Value).OrderBy(Function(it) it.Referencia).ToList
            LlenarCombo(cboRefDetMod, "Referencia", _leRefAux, -1)
        Else
            cboRefDetMod.SelectedIndex = -1
        End If
    End Sub

    Private Sub btnAceptarDMR_Click(sender As Object, e As EventArgs) Handles btnAceptarDMR.Click
        Try
            If cboTipoRefDetMod.SelectedIndex = -1 Then cboTipoRefDetMod.Focus() : Throw New Exception("Seleccione Tipo Referencia")
            If cboRefDetMod.SelectedIndex = -1 Then cboRefDetMod.Focus() : Throw New Exception("Seleccione Referencia")
            RecolectaDMRef()
            If oeDMReferencia.TipoOperacion = "I" Then
                oeDMReferencia.UsuarioCreacion = gUsuarioSGI.Id
                oeDMReferencia.FechaCreacion = Date.Now.Date
                leDMReferencia.Add(oeDMReferencia)
            Else
                If oeDMReferencia.Id.Trim <> "" Then
                    oeDMReferencia.UsuarioModifica = gUsuarioSGI.Id
                    oeDMReferencia.FechaModifica = Date.Now.Date
                Else
                    oeDMReferencia.TipoOperacion = "I"
                End If
            End If
            CargarDMRef(leDMReferencia, oeDetalleAM.Codigo)
            griDetModReferencia.DataBind()
            MostrarTabs(0, ficDetModReferencia)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCancelarDMR_Click(sender As Object, e As EventArgs) Handles btnCancelarDMR.Click
        If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", MessageBoxButtons.YesNo, _
                         MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            MostrarTabs(0, ficDetModReferencia)
        End If
    End Sub

    Private Sub btnAceptarAMAct_Click(sender As Object, e As EventArgs) Handles btnAceptarAMAct.Click
        Try
            If cboProceso.SelectedIndex = -1 Then cboProceso.Focus() : Throw New Exception("Seleccione Proceso")
            If cboActividad.SelectedIndex = -1 Then cboActividad.Focus() : Throw New Exception("Seleccione Actividad")
            RecolectaAMAct()
            If oeAMActividad.TipoOperacion = "I" Then
                oeAMActividad.UsuarioCreacion = gUsuarioSGI.oePersona.NombreCompleto
                oeAMActividad.FechaCreacion = Date.Now.Date
                leAMActividad.Add(oeAMActividad)
            Else
                If oeAMActividad.Id.Trim <> "" Then
                    oeAMActividad.UsuarioModifica = gUsuarioSGI.oePersona.NombreCompleto
                    oeAMActividad.FechaModifica = Date.Now.Date
                Else
                    oeAMActividad.TipoOperacion = "I"
                End If
            End If
            CargarANActividad(leAMActividad)
            griAMActividadNegocio.DataBind()
            MostrarTabs(0, ficAMActNeg)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCancelarAMAct_Click(sender As Object, e As EventArgs) Handles btnCancelarAMAct.Click
        If MessageBox.Show("¿Desea Cancelar la Operación?", "Mensaje de Sistema", MessageBoxButtons.YesNo, _
                          MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            MostrarTabs(0, ficAMActNeg)
        End If
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try
            'Cargar Partidas
            cboPartida.Items.Clear()
            cboPartida.Items.Add("DEBE")
            cboPartida.Items.Add("HABER")
            cboPartida.SelectedIndex = -1
            'Cargar Nivel de Cuentas
            cboNivelCuenta.Items.Clear()
            cboNivelCuenta.Items.Add("Nivel Cuenta 0")
            cboNivelCuenta.Items.Add("Nivel Cuenta 1")
            cboNivelCuenta.Items.Add("Nivel Cuenta 2")
            cboNivelCuenta.Items.Add("Nivel Cuenta 3")
            cboNivelCuenta.Items.Add("Nivel Cuenta 4")
            cboNivelCuenta.Items.Add("Nivel Cuenta 5")
            cboNivelCuenta.SelectedIndex = -1
            'Cargar Monedas
            oeMoneda = New e_Moneda
            oeMoneda.TipoOperacion = "" : oeMoneda.Activo = True
            leMoneda = olMoneda.Listar(oeMoneda)
            LlenarCombo(cboTipoMoneda, "Nombre", leMoneda, -1)
            'Cargar Cuentas Contables
            oeCtaCtble = New e_CuentaContable
            oeCtaCtble.TipoOperacion = "N"
            oeCtaCtble.Activo = True : oeCtaCtble.Ejercicio = Date.Now.Year
            leCtaCtble = olCtaCtble.Listar(oeCtaCtble).OrderBy(Function(it) it.Nombre).ToList
            'Cargar Tipo Asiento
            oeTipoAsiento = New e_TablaContableDet
            oeTipoAsiento.TipoOperacion = "N" : oeTipoAsiento.Nombre = "TIPO DE ASIENTO"
            oeTipoAsiento.Logico1 = True : oeTipoAsiento.Activo = True
            leTipoAsiento.AddRange(olTipoAsiento.Listar(oeTipoAsiento))
            LlenarCombo(cboTipoAsiento, "Nombre", leTipoAsiento, -1)
            oeTipoAsiento = New e_TablaContableDet
            oeTipoAsiento.Id = String.Empty : oeTipoAsiento.Nombre = "[ TODOS ]"
            leTipoAsientoBus.Add(oeTipoAsiento)
            leTipoAsientoBus.AddRange(leTipoAsiento)
            LlenarCombo(cboTipoAsientoBus, "Nombre", leTipoAsientoBus, 0)
            'Cargar Proceso
            oeProceso = New e_ProcesoNegocio
            oeProceso.TipoOperacion = "" : oeProceso.Activo = True : oeProceso.Indicador = 1
            leProceso = olProceso.Listar(oeProceso)
            LlenarCombo(cboProceso, "Nombre", leProceso, -1)
            'Cargar Actividad
            oeActividad = New e_ActividadNegocio
            oeActividad.TipoOperacion = "" : oeActividad.Activo = True
            leActividad = olActividad.Listar(oeActividad)
            'Cargar Tipo Referencia
            oeTipoRef = New e_AsientoModelo_Referencia
            oeTipoRef.TipoOperacion = "T"
            leTipoRef = olTipoRef.Listar2(oeTipoRef)
            LlenarCombo(cboTipoReferencia, "Referencia", leTipoRef, -1)
            LlenarCombo(cboTipoRefDetMod, "Referencia", leTipoRef, -1)
            'Cargar Referencia
            oeReferencia = New e_AsientoModelo_Referencia
            oeReferencia.TipoOperacion = "R"
            leReferencia = olReferencia.Listar2(oeReferencia)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        Try
            oeAsientoModel = New e_AsientoModelo
            oeAsientoModel.TipoOperacion = ""
            oeAsientoModel.Activo = True
            oeAsientoModel.IdTipoAsiento = cboTipoAsientoBus.Value
            leAsientoModel = olAsientoModel.Listar(oeAsientoModel)
            CargarAsientoModel(leAsientoModel)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarAsientoModel(leAsiMod As List(Of e_AsientoModelo))
        Try
            With griAsientoModelo
                If BandLoad Then .ResetDisplayLayout()
                .DataSource = leAsiMod
                .Text = "REGISTRO DE PLANTILLAS DE ASIENTOS CONTABLES ( " & leAsiMod.Count & " )"
                If BandLoad Then
                    OcultarColumna(griAsientoModelo, True, "Id", "IdMoneda", "IdVinculado", "Activo", "IdTipoAsiento")
                    ExcluirColumna(griAsientoModelo, "Id", "IdMoneda", "IdVinculado", "Activo", "IdTipoAsiento")
                    .DisplayLayout.Bands(0).Columns("Codigo").Width = 50
                    .DisplayLayout.Bands(0).Columns("Nombre").Width = 300
                    .DisplayLayout.Bands(0).Columns("Abreviatura").Width = 100
                    .DisplayLayout.Bands(0).Columns("Moneda").Width = 65
                    .DisplayLayout.Bands(0).Columns("TipoAsiento").Width = 70
                    .DisplayLayout.Bands(0).Columns("Fila").Width = 50
                    .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Width = 200
                    .DisplayLayout.Bands(0).Columns("UsuarioModificacion").Width = 200
                    .DisplayLayout.Bands(0).Columns("Cuentas").Style = ColumnStyle.CheckBox
                    .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                    .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                    .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                    .DisplayLayout.Override.FilterUIProvider = Filtro1
                    .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                    .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                    .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                    .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                    .DisplayLayout.MaxColScrollRegions = 1
                    .DisplayLayout.MaxRowScrollRegions = 1
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializa()
        txtCodigo.ReadOnly = True
        txtNombre.Text = String.Empty
        txtAbreviatura.Text = String.Empty
        cboTipoMoneda.SelectedIndex = 0
        txtCodVinculo.Text = String.Empty
        chkCuentas.Enabled = False : chkCuentas.Checked = False
        cboTipoAsiento.SelectedIndex = -1
        cboProceso.SelectedIndex = -1
        ficDetalle.Tabs(0).Selected = True
        MostrarTabs(0, ficDetAsiento)
        MostrarTabs(0, ficAMActNeg)
        leDetalleAM = New List(Of e_DetalleAsientoModelo)
        CargarDetAsiMod(leDetalleAM)
        leAMActividad = New List(Of e_AsientoModelo_ActividadNegocio)
        CargarANActividad(leAMActividad)
        leAMAux = New List(Of e_AsientoModelo)
        leDAMAux = New List(Of e_DetalleAsientoModelo)
        Dim oeAMAux = New e_AsientoModelo
        oeAMAux.TipoOperacion = "" : oeAMAux.Activo = True
        leAMAux = olAsientoModel.Listar(oeAMAux)
        LlenarCombo(cboVinculo, "Nombre", leAMAux, -1)
        oeDetalleAM = New e_DetalleAsientoModelo
        oeDetalleAM.TipoOperacion = "" : oeDetalleAM.Activo = True
        leDAMAux = olDetalleAM.Listar(oeDetalleAM)
        CargarDetVinc(New List(Of e_DetalleAsientoModelo))
        leAMReferencia = New List(Of e_AsientoModelo_Referencia)
        CargarReferencias(leAMReferencia, "")
        leDMReferencia = New List(Of e_DetalleModelo_Referencia)
        CargarDMRef(leDMReferencia, "")
    End Sub

    Private Function fn_ObtenerCodigo() As String
        Try
            Dim str As String = ""
            Dim oeAsiMod As New e_AsientoModelo
            oeAsiMod.TipoOperacion = "U"
            oeAsiMod = olAsientoModel.Obtener(oeAsiMod)
            If oeAsiMod IsNot Nothing AndAlso oeAsiMod.Codigo <> "" Then
                str = oeAsiMod.Codigo
            End If
            Return str
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Mostrar()
        Try
            oeAsientoModel = New e_AsientoModelo
            oeAsientoModel.TipoOperacion = ""
            oeAsientoModel.Id = griAsientoModelo.ActiveRow.Cells("Id").Value
            oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
            With oeAsientoModel
                txtCodigo.Text = .Codigo
                txtNombre.Text = .Nombre
                txtAbreviatura.Text = .Abreviatura
                cboTipoMoneda.Value = .IdMoneda
                chkCuentas.Checked = .Cuentas
                cboVinculo.Value = .IdVinculado
                cboTipoAsiento.Value = .IdTipoAsiento
                leDetalleAM = .leDetalle
                leDMReferencia = .leDMReferencia
                CargarDetAsiMod(leDetalleAM)
                leAMActividad = .leAMActiviad
                CargarANActividad(leAMActividad)
                leAMReferencia = .leAMReferencia
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDetVinc(leDetVinc As List(Of e_DetalleAsientoModelo))
        Try
            With griDetVinculado
                .ResetDisplayLayout()
                .DataSource = leDetVinc
                ConfiguraGrilla(griDetVinculado, 2)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConfiguraGrilla(Grilla As UltraGrid, Ind As Integer)
        Try
            With Grilla

                If Ind = 2 Then .Text = "Detalle de Vinculo"

                OcultarColumna(Grilla, True, "Id", "IdAsientoModelo", "AsientoModelo", "IdCuentaContable", "IdMoneda", "Activo", _
                               "CuentaContable", "Partida", "Cuenta", "NivelCuenta")
                ExcluirColumna(Grilla, "Id", "IdAsientoModelo", "AsientoModelo", "IdCuentaContable", "IdMoneda", "Activo", _
                               "CuentaContable", "Partida", "Cuenta", "NivelCuenta")

                .DisplayLayout.Bands(0).Columns("Codigo").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Fila").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Titulo").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Debe").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Haber").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Repetir").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("Formula").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("Moneda").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Header.VisiblePosition = 9
                .DisplayLayout.Bands(0).Columns("UsuarioModificacion").Header.VisiblePosition = 10
                .DisplayLayout.Bands(0).Columns("FechaModificacion").Header.VisiblePosition = 11

                .DisplayLayout.Bands(0).Columns("Codigo").Width = 50
                .DisplayLayout.Bands(0).Columns("Fila").Width = 30
                .DisplayLayout.Bands(0).Columns("Titulo").Width = 200
                .DisplayLayout.Bands(0).Columns("Debe").Width = 70
                .DisplayLayout.Bands(0).Columns("Haber").Width = 70
                .DisplayLayout.Bands(0).Columns("Repetir").Width = 50
                .DisplayLayout.Bands(0).Columns("Formula").Width = 90
                .DisplayLayout.Bands(0).Columns("Moneda").Width = 100

                .DisplayLayout.Bands(0).Columns("Repetir").Style = ColumnStyle.CheckBox

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub RecolectaDatos()
        oeAsientoModel.Codigo = txtCodigo.Text
        oeAsientoModel.Nombre = txtNombre.Text
        oeAsientoModel.Abreviatura = txtAbreviatura.Text
        oeAsientoModel.IdMoneda = cboTipoMoneda.Value
        oeAsientoModel.Cuentas = IIf(chkCuentas.Checked, 1, 0)
        oeAsientoModel.IdVinculado = cboVinculo.Value
        oeAsientoModel.IdTipoAsiento = cboTipoAsiento.Value
        For Each _oeDet In leDetalleAM
            If _oeDet.TipoOperacion <> "" Then
                If _oeDet.TipoOperacion = "I" Then
                    _oeDet.UsuarioCreacion = gUsuarioSGI.Id
                Else
                    _oeDet.UsuarioModificacion = gUsuarioSGI.Id
                End If
            End If
        Next
        oeAsientoModel.leDetalle = leDetalleAM
        'leAMActividad = New List(Of e_AsientoModelo_ActividadNegocio)
        'leAMActividad.Add(oeAMActividad)
        oeAsientoModel.leAMActiviad = leAMActividad ' Llenar Relacion con Actividades
        oeAsientoModel.leAMReferencia = leAMReferencia ' Llenar Relacion con Referencias
        oeAsientoModel.leDMReferencia = leDMReferencia ' Llenar Relacion con Detalle Referencias
    End Sub

#Region "Detalle Asiento Modelo"

    Private Sub InicializaDetalle()
        Dim ls_Cod As String = "000"
        If leDetalleAM.Count > 0 Then ls_Cod = leDetalleAM.Max(Function(it) it.Codigo)
        txtCodDet.Text = FormatoDocumento(CInt(ls_Cod) + 1, 3)
        txtCodDet.ReadOnly = True
        cboNivelCuenta.SelectedIndex = -1
        txtCtaCtable.Text = String.Empty
        txtCtaCtable.ReadOnly = True
        cboCtaCtble.SelectedIndex = -1
        cboPartida.SelectedIndex = -1
        txtFila.Text = String.Empty
        txtFormula.Text = String.Empty
        txtTitulo.Text = String.Empty
        chkRepetir.Checked = False
        MostrarTabs(1, ficDetAsiento)
        MostrarTabs(0, ficDetModReferencia)
    End Sub

    Private Sub CargarDetAsiMod(leDet As List(Of e_DetalleAsientoModelo))
        Try
            With griDetalle

                .ResetDisplayLayout()
                .Text = "Detalle de Asiento"
                Dim _leAux = leDet.Where(Function(it) it.Activo = True).OrderBy(Function(it) it.Fila).ToList
                chkCuentas.Checked = IIf(_leAux.Count > 0, True, False)
                .DataSource = _leAux
                ConfiguraGrilla(griDetalle, 1)

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDMRef(leDMR As List(Of e_DetalleModelo_Referencia), codigo As String)
        Try
            With griDetModReferencia
                .ResetDisplayLayout()
                .DataSource = leDMR.Where(Function(it) it.Fila = codigo And it.Activo = True).ToList
                .Text = "Listado de Referencia"
                OcultarColumna(griDetModReferencia, True, "Id", "TipoReferencia", "IdReferencia", "FechaCreacion", "UsuarioCreacion", "FechaModifica", _
                               "UsuarioModifica", "Activo", "IdDetalleAsientoModelo", "IdConfiguracionColumna")
                ExcluirColumna(griDetModReferencia, "Id", "TipoReferencia", "IdReferencia", "FechaCreacion", "UsuarioCreacion", "FechaModifica", _
                               "UsuarioModifica", "Activo", "IdDetalleAsientoModelo", "IdConfiguracionColumna")
                .DisplayLayout.Bands(0).Columns("Referencia").Width = 200
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 400
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub RecolectaDetalle()
        oeDetalleAM.Codigo = txtCodDet.Text
        oeDetalleAM.NivelCuenta = cboNivelCuenta.SelectedIndex
        oeDetalleAM.IdCuentaContable = cboCtaCtble.Value
        oeDetalleAM.CuentaContable = cboCtaCtble.Text
        oeDetalleAM.Cuenta = txtCtaCtable.Text
        oeDetalleAM.Partida = cboPartida.SelectedIndex + 1
        oeDetalleAM.Fila = txtFila.Text
        oeDetalleAM.Formula = txtFormula.Text
        oeDetalleAM.Titulo = txtTitulo.Text
        oeDetalleAM.IdMoneda = cboTipoMoneda.Value
        oeDetalleAM.Moneda = cboTipoMoneda.Text
        oeDetalleAM.Repetir = IIf(chkRepetir.Checked, 1, 0)
    End Sub

    Private Sub MostrarDetalle()
        Try
            If griDetalle.Selected.Rows.Count > 0 Then
                oeDetalleAM = New e_DetalleAsientoModelo
                If griDetalle.ActiveRow.Cells("Id").Value.ToString.Trim <> "" Then
                    oeDetalleAM.Equivale = 1
                    oeDetalleAM.Id = griDetalle.ActiveRow.Cells("Id").Value
                Else
                    oeDetalleAM.Equivale = 0
                    oeDetalleAM.Codigo = griDetalle.ActiveRow.Cells("Codigo").Value
                End If
                If leDetalleAM.Contains(oeDetalleAM) Then
                    oeDetalleAM = leDetalleAM.Item(leDetalleAM.IndexOf(oeDetalleAM))
                    txtCodDet.Text = oeDetalleAM.Codigo
                    cboNivelCuenta.SelectedIndex = oeDetalleAM.NivelCuenta
                    txtCtaCtable.Text = oeDetalleAM.Cuenta
                    cboCtaCtble.Value = oeDetalleAM.IdCuentaContable.Trim
                    txtTitulo.Text = oeDetalleAM.Titulo
                    txtFila.Text = oeDetalleAM.Fila
                    cboPartida.SelectedIndex = CInt(oeDetalleAM.Partida) - 1
                    txtFormula.Text = oeDetalleAM.Formula
                    chkRepetir.Checked = IIf(oeDetalleAM.Repetir = 1, True, False)
                    CargarDMRef(leDMReferencia, oeDetalleAM.Codigo)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EditarDetalle()
        Try
            InicializaDetalle()
            MostrarDetalle()
            oeDetalleAM.TipoOperacion = "A"
            ' MostrarTabs(1, ficDetAsiento)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub InicializaDMRef()
        cboTipoRefDetMod.SelectedIndex = -1
    End Sub

    Private Sub EditarDMRef()
        Try
            InicializaDMRef()
            MostrarDMref()
            oeDMReferencia.TipoOperacion = "A"
            MostrarTabs(1, ficDetModReferencia)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub MostrarDMref()
        Try
            If griDetModReferencia.Selected.Rows.Count > 0 Then
                oeDMReferencia = New e_DetalleModelo_Referencia
                If griDetModReferencia.ActiveRow.Cells("Id").Value.ToString.Trim <> "" Then
                    oeDMReferencia.Equivale = 0
                    oeDMReferencia.Id = griDetModReferencia.ActiveRow.Cells("Id").Value
                Else
                    oeDMReferencia.Equivale = 1
                    oeDMReferencia.TipoReferencia = griDetModReferencia.ActiveRow.Cells("TipoReferencia").Value
                    oeDMReferencia.IdReferencia = griDetModReferencia.ActiveRow.Cells("IdReferencia").Value.ToString.Trim
                End If
                If leDMReferencia.Contains(oeDMReferencia) Then
                    oeDMReferencia = leDMReferencia.Item(leDMReferencia.IndexOf(oeDMReferencia))
                    cboTipoRefDetMod.Value = oeDMReferencia.TipoReferencia
                    cboRefDetMod.Value = oeDMReferencia.IdReferencia
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub RecolectaDMRef()
        oeDMReferencia.TipoReferencia = cboTipoRefDetMod.Value
        oeDMReferencia.Referencia = cboTipoRefDetMod.Text.ToString
        oeDMReferencia.IdReferencia = cboRefDetMod.Value
        oeDMReferencia.Nombre = cboRefDetMod.Text
        oeDMReferencia.Fila = txtCodDet.Text.Trim
    End Sub

#End Region

#Region "Asiento Modelo Actividad Negocio"

    Private Sub InicializaAMAct()
        cboProceso.SelectedIndex = -1
        cboActividad.SelectedIndex = -1
        MostrarTabs(1, ficAMActNeg)
        MostrarTabs(0, ficAsientoProceso)
    End Sub

    Private Sub CargarANActividad(leActNeg As List(Of e_AsientoModelo_ActividadNegocio))
        Try
            With griAMActividadNegocio
                .ResetDisplayLayout()
                .Text = "ActividadNegocio"
                Dim _leAux = leActNeg.Where(Function(it) it.Activo = True).ToList
                .DataSource = _leAux
                OcultarColumna(griAMActividadNegocio, True, "Id", "IdAsientoModelo", "IdActividadNegocio", "UsuarioCreacion", "FechaCreacion", _
                               "UsuarioModifica", "FechaModifica", "Activo")
                ExcluirColumna(griAMActividadNegocio, "Id", "IdAsientoModelo", "IdActividadNegocio", "UsuarioCreacion", "FechaCreacion", _
                               "UsuarioModifica", "FechaModifica", "Activo")
                .DisplayLayout.Bands(0).Columns("ProcesoNegocio").Width = 300
                .DisplayLayout.Bands(0).Columns("ActividadNegocio").Width = 400
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarReferencias(leRefAux As List(Of e_AsientoModelo_Referencia), IdActividad As String)
        Try
            With griReferenciaAsiento
                .ResetDisplayLayout()
                Dim _leAux = leRefAux.Where(Function(it) it.IdActividad = IdActividad).ToList
                .DataSource = _leAux
                .Text = "Listado de Referencia"
                OcultarColumna(griReferenciaAsiento, True, "Id", "TipoReferencia", "IdReferencia", "FechaCreacion", "UsuarioCreacion", "FechaModifica", _
                               "UsuarioModifica", "Activo", "IdAsiMod_ActNeg")
                ExcluirColumna(griReferenciaAsiento, "Id", "TipoReferencia", "IdReferencia", "FechaCreacion", "UsuarioCreacion", "FechaModifica", _
                               "UsuarioModifica", "Activo", "IdAsiMod_ActNeg")
                .DisplayLayout.Bands(0).Columns("Referencia").Width = 200
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 400
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub RecolectaAMAct()
        oeAMActividad.IdActividadNegocio = cboActividad.Value
        oeAMActividad.ProcesoNegocio = cboProceso.Text
        oeAMActividad.ActividadNegocio = cboActividad.Text
    End Sub

    Private Sub MostrarAMAct()
        Try
            If griAMActividadNegocio.Selected.Rows.Count > 0 Then
                oeAMActividad = New e_AsientoModelo_ActividadNegocio
                If griAMActividadNegocio.ActiveRow.Cells("Id").Value.ToString.Trim <> "" Then
                    oeAMActividad.Equivale = 0
                    oeAMActividad.Id = griAMActividadNegocio.ActiveRow.Cells("Id").Value
                Else
                    oeAMActividad.Equivale = 1
                    oeAMActividad.IdActividadNegocio = griDetalle.ActiveRow.Cells("IdActividadNegocio").Value
                End If
                If leAMActividad.Contains(oeAMActividad) Then
                    oeAMActividad = leAMActividad.Item(leAMActividad.IndexOf(oeAMActividad))
                    cboProceso.Text = oeAMActividad.ProcesoNegocio
                    cboActividad.Value = oeAMActividad.IdActividadNegocio
                    CargarReferencias(leAMReferencia, oeAMActividad.IdActividadNegocio)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EditarAMAct()
        Try
            InicializaAMAct()
            MostrarAMAct()
            oeAMActividad.TipoOperacion = "A"
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub InicializaReferencia()
        cboTipoReferencia.SelectedIndex = -1
    End Sub

    Private Sub EditarReferencia()
        Try
            InicializaReferencia()
            MostrarReferencia()
            oeAMReferencia.TipoOperacion = "A"
            MostrarTabs(1, ficAsientoProceso)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub MostrarReferencia()
        Try
            If griReferenciaAsiento.Selected.Rows.Count > 0 Then
                oeAMReferencia = New e_AsientoModelo_Referencia
                If griReferenciaAsiento.ActiveRow.Cells("Id").Value.ToString.Trim <> "" Then
                    oeAMReferencia.Equivale = 0
                    oeAMReferencia.Id = griReferenciaAsiento.ActiveRow.Cells("Id").Value
                Else
                    oeAMReferencia.Equivale = 1
                    oeAMReferencia.TipoReferencia = griReferenciaAsiento.ActiveRow.Cells("TipoReferencia").Value
                    oeAMReferencia.IdReferencia = griReferenciaAsiento.ActiveRow.Cells("IdReferencia").Value.ToString.Trim
                End If
                If leAMReferencia.Contains(oeAMReferencia) Then
                    oeAMReferencia = leAMReferencia.Item(leAMReferencia.IndexOf(oeAMReferencia))
                    cboTipoReferencia.Value = oeAMReferencia.TipoReferencia
                    cboReferencia.Value = oeAMReferencia.IdReferencia
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub RecolectaReferencia()
        oeAMReferencia.TipoReferencia = cboTipoReferencia.Value
        oeAMReferencia.Referencia = cboTipoReferencia.Text.ToString
        oeAMReferencia.IdReferencia = cboReferencia.Value
        oeAMReferencia.Nombre = cboReferencia.Text
        oeAMReferencia.IdActividad = cboActividad.Value
    End Sub

#End Region

#End Region

#Region "Menu Contextual"

    Private Sub mcAsientoModel_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mcAsientoModel.Opening
        mcAsientoModel.Items("tsmiNuevo").Enabled = True
        mcAsientoModel.Items("tsmiEditar").Enabled = IIf(griAsientoModelo.Selected.Rows.Count > 0, True, False)
        mcAsientoModel.Items("tsmiEliminar").Enabled = IIf(griAsientoModelo.Selected.Rows.Count > 0, True, False)
        mcAsientoModel.Items("tsmiExportar").Enabled = IIf(griAsientoModelo.Rows.Count > 0, True, False)
    End Sub

    Private Sub tsmiNuevo_Click(sender As Object, e As EventArgs) Handles tsmiNuevo.Click
        Nuevo()
    End Sub

    Private Sub tsmiEditar_Click(sender As Object, e As EventArgs) Handles tsmiEditar.Click
        Editar()
    End Sub

    Private Sub tsmiEliminar_Click(sender As Object, e As EventArgs) Handles tsmiEliminar.Click
        Eliminar()
    End Sub

    Private Sub tsmiExportar_Click(sender As Object, e As EventArgs) Handles tsmiExportar.Click
        Exportar()
    End Sub

    Private Sub mcDetalle_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mcDetalle.Opening
        mcDetalle.Items("tsmiAgregar").Enabled = True
        mcDetalle.Items("tsmiModificar").Enabled = IIf(griDetalle.Selected.Rows.Count > 0, True, False)
        mcDetalle.Items("tsmiQuitar").Enabled = IIf(griDetalle.Selected.Rows.Count > 0, True, False)
    End Sub

    Private Sub tsmiAgregar_Click(sender As Object, e As EventArgs) Handles tsmiAgregar.Click
        InicializaDetalle()
        oeDetalleAM = New e_DetalleAsientoModelo
        oeDetalleAM.TipoOperacion = "I"
        oeDetalleAM.Activo = True
        MostrarTabs(1, ficDetAsiento)
        txtCtaCtable.Focus()
    End Sub

    Private Sub tsmiModificar_Click(sender As Object, e As EventArgs) Handles tsmiModificar.Click
        EditarDetalle()
    End Sub

    Private Sub tsmiQuitar_Click(sender As Object, e As EventArgs) Handles tsmiQuitar.Click
        If griDetalle.Selected.Rows.Count > 0 Then
            If MessageBox.Show("¿Desea Eliminar la Cuenta: " & griDetalle.ActiveRow.Cells("Cuenta").Value & "?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                oeDetalleAM = New e_DetalleAsientoModelo
                If griDetalle.ActiveRow.Cells("Id").Value.ToString.Trim <> "" Then
                    oeDetalleAM.Equivale = 1
                    oeDetalleAM.Id = griDetalle.ActiveRow.Cells("Id").Value.ToString.Trim
                Else
                    oeDetalleAM.Equivale = 0
                    oeDetalleAM.Codigo = griDetalle.ActiveRow.Cells("Codigo").Value.ToString.Trim
                End If
                If leDetalleAM.Contains(oeDetalleAM) Then
                    oeDetalleAM = leDetalleAM.Item(leDetalleAM.IndexOf(oeDetalleAM))
                    If oeDetalleAM.Id.Trim <> "" Then
                        oeDetalleAM.TipoOperacion = "E"
                        oeDetalleAM.Activo = False
                    Else
                        leDetalleAM.Remove(oeDetalleAM)
                    End If
                    CargarDetAsiMod(leDetalleAM)
                    griDetalle.DataBind()
                End If
            End If
        End If
    End Sub

    Private Sub mcAsientoProceso_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mcAsientoProceso.Opening
        mcAsientoProceso.Items("tsmiAgregarAP").Enabled = True
        mcAsientoProceso.Items("tsmiEditarAP").Enabled = IIf(griReferenciaAsiento.Selected.Rows.Count > 0, True, False)
        mcAsientoProceso.Items("tsmiQuitarAP").Enabled = IIf(griReferenciaAsiento.Selected.Rows.Count > 0, True, False)
    End Sub

    Private Sub tsmiAgregarAP_Click(sender As Object, e As EventArgs) Handles tsmiAgregarAP.Click
        InicializaReferencia()
        oeAMReferencia = New e_AsientoModelo_Referencia
        oeAMReferencia.TipoOperacion = "I"
        oeAMReferencia.Activo = True
        MostrarTabs(1, ficAsientoProceso)
        cboTipoReferencia.Focus()
    End Sub

    Private Sub tsmiEditarAP_Click(sender As Object, e As EventArgs) Handles tsmiEditarAP.Click
        EditarReferencia()
    End Sub

    Private Sub tsmiQuitarAP_Click(sender As Object, e As EventArgs) Handles tsmiQuitarAP.Click
        If griReferenciaAsiento.Selected.Rows.Count > 0 Then
            If MessageBox.Show("¿Desea Eliminar la Referencia: " & griReferenciaAsiento.ActiveRow.Cells("Nombre").Value & "?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                oeAMReferencia = New e_AsientoModelo_Referencia
                If griReferenciaAsiento.ActiveRow.Cells("Id").Value.ToString.Trim <> "" Then
                    oeAMReferencia.Equivale = 0
                    oeAMReferencia.Id = griReferenciaAsiento.ActiveRow.Cells("Id").Value.ToString.Trim
                Else
                    oeAMReferencia.Equivale = 1
                    oeAMReferencia.TipoReferencia = griReferenciaAsiento.ActiveRow.Cells("TipoReferencia").Value
                    oeAMReferencia.IdReferencia = griReferenciaAsiento.ActiveRow.Cells("IdReferencia").Value.ToString.Trim
                End If
                If leAMReferencia.Contains(oeAMReferencia) Then
                    oeAMReferencia = leAMReferencia.Item(leAMReferencia.IndexOf(oeAMReferencia))
                    If oeAMReferencia.Id.Trim <> "" Then
                        oeAMReferencia.TipoOperacion = "E"
                        oeAMReferencia.Activo = False
                    Else
                        leAMReferencia.Remove(oeAMReferencia)
                    End If
                    CargarReferencias(leAMReferencia, oeAMReferencia.IdActividad)
                    griReferenciaAsiento.DataBind()
                End If
            End If
        End If
    End Sub

    Private Sub mcDetalleModeloRef_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mcDetalleModeloRef.Opening
        mcDetalleModeloRef.Items("tsmiAgregarDMR").Enabled = True
        mcDetalleModeloRef.Items("tsmiEditarDMR").Enabled = IIf(griDetModReferencia.Selected.Rows.Count > 0, True, False)
        mcDetalleModeloRef.Items("tsmiQuitarDMR").Enabled = IIf(griDetModReferencia.Selected.Rows.Count > 0, True, False)
    End Sub

    Private Sub tsmiAgregarDMR_Click(sender As Object, e As EventArgs) Handles tsmiAgregarDMR.Click
        InicializaDMRef()
        oeDMReferencia = New e_DetalleModelo_Referencia
        oeDMReferencia.TipoOperacion = "I"
        oeDMReferencia.Activo = True
        MostrarTabs(1, ficDetModReferencia)
        cboTipoRefDetMod.Focus()
    End Sub

    Private Sub tsmiEditarDMR_Click(sender As Object, e As EventArgs) Handles tsmiEditarDMR.Click
        EditarDMRef()
    End Sub

    Private Sub tsmiQuitarDMR_Click(sender As Object, e As EventArgs) Handles tsmiQuitarDMR.Click
        If griDetModReferencia.Selected.Rows.Count > 0 Then
            If MessageBox.Show("¿Desea Eliminar la Referencia: " & griDetModReferencia.ActiveRow.Cells("Nombre").Value & "?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                oeDMReferencia = New e_DetalleModelo_Referencia
                If griDetModReferencia.ActiveRow.Cells("Id").Value.ToString.Trim <> "" Then
                    oeDMReferencia.Equivale = 0
                    oeDMReferencia.Id = griDetModReferencia.ActiveRow.Cells("Id").Value.ToString.Trim
                Else
                    oeDMReferencia.Equivale = 1
                    oeDMReferencia.TipoReferencia = griDetModReferencia.ActiveRow.Cells("TipoReferencia").Value
                    oeDMReferencia.IdReferencia = griDetModReferencia.ActiveRow.Cells("IdReferencia").Value.ToString.Trim
                End If
                If leDMReferencia.Contains(oeDMReferencia) Then
                    oeDMReferencia = leDMReferencia.Item(leDMReferencia.IndexOf(oeDMReferencia))
                    If oeDMReferencia.Id.Trim <> "" Then
                        oeDMReferencia.TipoOperacion = "E"
                        oeDMReferencia.Activo = False
                    Else
                        leDMReferencia.Remove(oeDMReferencia)
                    End If
                    CargarDMRef(leDMReferencia, oeDetalleAM.Codigo)
                    griDetModReferencia.DataBind()
                End If
            End If
        End If
    End Sub

    Private Sub mcAMActividad_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mcAMActividad.Opening
        mcAMActividad.Items("tsmiAgregarAMAct").Enabled = True
        mcAMActividad.Items("tsmiEditarAMAct").Enabled = IIf(griAMActividadNegocio.Selected.Rows.Count > 0, True, False)
        mcAMActividad.Items("tsmiQuitarAMAct").Enabled = IIf(griAMActividadNegocio.Selected.Rows.Count > 0, True, False)
    End Sub

    Private Sub tsmiAgregarAMAct_Click(sender As Object, e As EventArgs) Handles tsmiAgregarAMAct.Click
        InicializaAMAct()
        oeAMActividad = New e_AsientoModelo_ActividadNegocio
        oeAMActividad.TipoOperacion = "I"
        oeAMActividad.Activo = True
        MostrarTabs(1, ficAMActNeg)
        cboProceso.Focus()
    End Sub

    Private Sub tsmiEditarAMAct_Click(sender As Object, e As EventArgs) Handles tsmiEditarAMAct.Click
        EditarAMAct()
    End Sub

    Private Sub tsmiQuitarAMAct_Click(sender As Object, e As EventArgs) Handles tsmiQuitarAMAct.Click
        If griAMActividadNegocio.Selected.Rows.Count > 0 Then
            If MessageBox.Show("¿Desea Eliminar la Actividad: " & griAMActividadNegocio.ActiveRow.Cells("ActividadNegocio").Value & "?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                oeAMActividad = New e_AsientoModelo_ActividadNegocio
                If griAMActividadNegocio.ActiveRow.Cells("Id").Value.ToString.Trim <> "" Then
                    oeAMActividad.Equivale = 0
                    oeAMActividad.Id = griAMActividadNegocio.ActiveRow.Cells("Id").Value.ToString.Trim
                Else
                    oeAMActividad.Equivale = 1
                    oeAMActividad.IdActividadNegocio = griAMActividadNegocio.ActiveRow.Cells("IdActividadNegocio").Value.ToString.Trim
                End If
                If leAMActividad.Contains(oeAMActividad) Then
                    oeAMActividad = leAMActividad.Item(leAMActividad.IndexOf(oeAMActividad))
                    If oeAMActividad.Id.Trim <> "" Then
                        oeAMActividad.TipoOperacion = "E"
                        oeAMActividad.Activo = False
                    Else
                        leAMActividad.Remove(oeAMActividad)
                    End If
                    CargarANActividad(leAMActividad)
                    griAMActividadNegocio.DataBind()
                End If
            End If
        End If
    End Sub

#End Region

End Class