'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Imports ISL.Controles

Public Class frm_MantenimientoNeumaticos
    
#Region "Instancia"

    Sub New(ByVal objOperacionNeumatico As e_OperacionNeumatico)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        _Posicion = objOperacionNeumatico.Posicion
        _KmVehiculo = objOperacionNeumatico.KmVehiculo
        _IdVehiculo = objOperacionNeumatico.IdVehiculo
        _Operacion = objOperacionNeumatico.Descripcion
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'oeOperacionNeumatico = oeOperNeu
        'dtpFecha.Value = Date.Now
        fecDesmontaje.Value = Date.Now
    End Sub

#End Region

#Region "Declaracion de Variables"

    Dim oeOperacionNeumatico As New e_OperacionNeumatico, olOperacionNeumatico As New l_OperacionNeumatico
    Dim oeVidaNeumatico As New e_VidaNeumatico, olVidaNeumatico As New l_VidaNeumatico
    Dim _KmVehiculo As Double, _KmNeumatico As Double
    Dim _Posicion As Integer
    Dim _IdVehiculo As String
    Dim _Operacion As String
    Dim _IdVidaNeumatico As String
    Dim lstOperacionesNeu As New List(Of e_OperacionNeumatico)
    Dim oeMotivo As New e_Motivo, olMotivo As New l_Motivo
    Public mensajeEmergente As New c_Alertas

    Dim oeVehiculo As New e_Combo, olVehiculo As New l_Combo, leVehiculo As New List(Of e_Combo)
    Dim oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador, leTrabajador As New List(Of e_Trabajador)

    Private FechaServidor As Date = ObtenerFechaServidor(), olFuncionesGenerales As New l_FuncionesGenerales

#End Region

#Region "Eventos"

    Private Sub frm_MantenimientoNeumaticos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gmt_ConfigurarEventoKeyEnter_Tab(Me)
            gf_AsignarEventoSeleccionarTexto(Me)
            LlenarMotivo()
            CargarDatos()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If MessageBox.Show("¿Desea Guardar los cambios realizados?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                If _Operacion = "BAJA" AndAlso gUsuarioSGI.Controlado = 1 Then olFuncionesGenerales.ValidarFechaNeu("Mov_Baja_Neu", fecDesmontaje.Value, FechaServidor.Date)

                oeOperacionNeumatico = New e_OperacionNeumatico
                oeOperacionNeumatico.TipoOperacion = "I"
                oeOperacionNeumatico.Operacion = _Operacion
                oeOperacionNeumatico.IdMotivo = cmbMotivo.Value
                oeOperacionNeumatico.Presion = 0

                'oeOperacionNeumatico.FechaOperacion = dtpFecha.Value
                oeOperacionNeumatico.FechaOperacion = fecDesmontaje.Value
                oeOperacionNeumatico.Ribete1 = ndRibete1.Value
                oeOperacionNeumatico.Ribete2 = ndRibete2.Value
                oeOperacionNeumatico.Ribete3 = ndRibete3.Value
                oeOperacionNeumatico.Ribete4 = _KmNeumatico
                oeOperacionNeumatico.KmNeumatico = ndKmRecorrido.Value + _KmNeumatico
                oeOperacionNeumatico.KmVehiculo = ndKmVehiculo.Value  '_KmVehiculo
                oeOperacionNeumatico.UsuarioCreacion = gUsuarioSGI.Id
                oeOperacionNeumatico.Cocada = ndCocada.Value
                'oeOperacionNeumatico.CocadaMinima = 0
                oeOperacionNeumatico.IdVidaNeumatico = _IdVidaNeumatico
                oeOperacionNeumatico.Posicion = _Posicion
                oeOperacionNeumatico.IdVehiculo = _IdVehiculo
                oeOperacionNeumatico.IndMontaje = 0
                oeOperacionNeumatico.IndInspeccion = 0
                oeOperacionNeumatico.Descripcion = _Operacion
                oeOperacionNeumatico.IdResponsable = cboTecnico.Value
                oeOperacionNeumatico.IdConductor = cboConductor.Value
                oeOperacionNeumatico.IndObservacion = cboObservacion.SelectedIndex + 1
                oeOperacionNeumatico.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olOperacionNeumatico.Guardar(oeOperacionNeumatico) Then
                    MessageBox.Show("Registrado Correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ndKmVehiculo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndKmVehiculo.ValueChanged
        If Not ndKmVehiculo.Value Is Nothing Then
            Me.ndKmRecorrido.Value = IIf(_Posicion > 0, Me.ndKmVehiculo.Value - Me.ndKmMontaje.Value, 0)
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub ndCocada_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndCocada.ValueChanged
        If Not ndCocada.Value Is Nothing Then
            Me.ndCocadaDesgastada.Value = Me.ndCocadaMontada.Value - Me.ndCocada.Value
        End If
    End Sub

    Private Sub ndRibete1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndRibete1.ValueChanged, _
    ndRibete2.ValueChanged, ndRibete3.ValueChanged, ndRibete4.ValueChanged
        ndCocada.Value = CalculaCocada(ndRibete1.Value, ndRibete2.Value, ndRibete3.Value, ndRibete4.Value)
    End Sub

#End Region

#Region "Metodos"

    Sub LlenarMotivo()
        Try
            cboObservacion.Enabled = False
            oeMotivo = New e_Motivo
            oeMotivo.Activo = True
            oeMotivo.IndAlmacen = False
            oeMotivo.IndReparacion = False
            oeMotivo.IndReencauche = False
            oeMotivo.IndBaja = False
            Select Case _Operacion
                Case "DESMONTAJE"
                    Me.Text = "Enviar a Almacén"
                    oeMotivo.IndAlmacen = True
                Case "REENCAUCHE"
                    Me.Text = "Enviar a Reencauche"
                    oeMotivo.IndReencauche = True
                Case "REPARAR"
                    Me.Text = "Enviar a Reparar"
                    oeMotivo.IndReparacion = True
                Case "BAJA"
                    Me.Text = "Enviar de Baja"
                    oeMotivo.IndBaja = True
                    cboObservacion.Enabled = True
                    cboObservacion.Items.Clear()
                    cboObservacion.Items.Add("POR TRABAJO")
                    cboObservacion.Items.Add("POR MANTENIMIENTO")
                    cboObservacion.Items.Add("POR DOT")
                    cboObservacion.Items.Add("POR CONDUCTOR")
                    cboObservacion.SelectedIndex = -1
            End Select
            cmbMotivo.DataSource = olMotivo.Listar(oeMotivo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub CargarDatos()
        Try
            txtPosicion.Text = _Posicion
            ' Obtener Datos de Neumatico
            oeOperacionNeumatico = New e_OperacionNeumatico
            oeOperacionNeumatico.FechaOperacion = Date.Parse("01/01/1901")
            oeOperacionNeumatico.TipoOperacion = ""
            oeOperacionNeumatico.IndMontaje = 1
            oeOperacionNeumatico.IndInspeccion = 0
            oeOperacionNeumatico.IdVehiculo = _IdVehiculo
            oeOperacionNeumatico.Posicion = _Posicion
            oeOperacionNeumatico = olOperacionNeumatico.Obtener(oeOperacionNeumatico)
            ' Obtener Datos de la Vida Neumatico
            oeVidaNeumatico = New e_VidaNeumatico
            oeVidaNeumatico.Id = oeOperacionNeumatico.IdVidaNeumatico
            oeVidaNeumatico.Activo = True
            oeVidaNeumatico = olVidaNeumatico.Obtener(oeVidaNeumatico)
            _IdVidaNeumatico = oeVidaNeumatico.Id
            ' Cargar Información de Neumatico
            Me.txtCodigoNeu.Text = oeVidaNeumatico.CodigoNeumatico
            Me.ndRibete1.Value = oeVidaNeumatico.Ribete1
            Me.ndRibete2.Value = oeVidaNeumatico.Ribete2
            Me.ndRibete3.Value = oeVidaNeumatico.Ribete3
            Me.ndRibete4.Value = oeVidaNeumatico.Ribete4
            Me.ndCocada.Value = oeVidaNeumatico.Cocada
            Me.ndRibete1.MaxValue = oeVidaNeumatico.Ribete1
            Me.ndRibete2.MaxValue = oeVidaNeumatico.Ribete2
            Me.ndRibete3.MaxValue = oeVidaNeumatico.Ribete3
            Me.ndKmVehiculo.Value = _KmVehiculo
            ' Cargar Datos de Primer Montaje
            oeOperacionNeumatico = New e_OperacionNeumatico
            oeOperacionNeumatico.FechaOperacion = Date.Parse("01/01/1901")
            oeOperacionNeumatico.TipoOperacion = "P"
            oeOperacionNeumatico.IndMontaje = -1
            oeOperacionNeumatico.IndInspeccion = -1
            oeOperacionNeumatico.IdVehiculo = _IdVehiculo
            oeOperacionNeumatico.IdVidaNeumatico = _IdVidaNeumatico
            oeOperacionNeumatico = olOperacionNeumatico.Obtener(oeOperacionNeumatico)
            Me.ndCocadaMontada.Value = oeOperacionNeumatico.Cocada
            Me.ndCocadaDesgastada.Value = Me.ndCocadaMontada.Value - Me.ndCocada.Value
            ' Cargar Ultimo Operacion
            oeOperacionNeumatico = New e_OperacionNeumatico
            oeOperacionNeumatico.FechaOperacion = Date.Parse("01/01/1901")
            oeOperacionNeumatico.TipoOperacion = "U"
            oeOperacionNeumatico.IdVidaNeumatico = _IdVidaNeumatico
            oeOperacionNeumatico = olOperacionNeumatico.Obtener(oeOperacionNeumatico)
            _KmNeumatico = oeOperacionNeumatico.KmNeumatico
            Me.ndKmMontaje.Value = oeOperacionNeumatico.KmVehiculo
            Me.ndKmRecorrido.Value = IIf(_Posicion > 0, Me.ndKmVehiculo.Value - Me.ndKmMontaje.Value, 0)
            ' Cargar Conductor
            Dim oeConductor As New e_Combo
            Dim leConductor As New List(Of e_Combo)
            oeConductor.Id = "NO ASIGNADO"
            oeConductor.Nombre = "NO ASIGNADO"
            leConductor.Add(oeConductor)
            leConductor.AddRange(PilotoPublic)
            LlenarCombo(cboConductor, "Nombre", leConductor, -1)
            ' Cargar Conductor de Vehiculo
            oeVehiculo = New e_Combo
            oeVehiculo.Nombre = "Vehiculo"
            leVehiculo = olVehiculo.Listar(oeVehiculo).OrderBy(Function(it) it.Nombre).ToList
            Dim _leVeh = leVehiculo.Where(Function(it) it.Id = _IdVehiculo).ToList
            If _leVeh.Count > 0 Then
                oeVehiculo = _leVeh(0)
                Dim oeOpeNeu As New e_OperacionNeumatico
                oeOpeNeu.TipoOperacion = "O"
                oeOpeNeu.IdVehiculo = oeVehiculo.Id
                oeOpeNeu.IndMontaje = oeVehiculo.Descripcion
                oeOpeNeu = olOperacionNeumatico.Obtener(oeOpeNeu)
                If oeOpeNeu IsNot Nothing AndAlso oeOpeNeu.UsuarioCreacion.Trim <> "" Then
                    cboConductor.Value = oeOpeNeu.UsuarioCreacion
                Else
                    cboConductor.SelectedIndex = 0
                End If
            End If
            ' Cargar Trabjadores de Mantenimineto
            oeTrabajador = New e_Trabajador
            oeTrabajador.Id = "NO ASIGNADO"
            oeTrabajador.oePersona.ApellidoPaterno = "NO ASIGNADO"
            oeTrabajador.oeArea.Nombre = "MANTENIMIENTO"
            oeTrabajador.Disponible = True
            oeTrabajador.IndEstado = 1
            leTrabajador.Add(oeTrabajador)
            oeTrabajador = New e_Trabajador
            oeTrabajador.TipoOperacion = "N"
            leTrabajador.AddRange(olTrabajador.Listar(oeTrabajador).Where(Function(it) it.oeArea.Nombre = "MANTENIMIENTO").OrderBy(Function(it) it.oePersona.NombreCompleto).ToList)
            Dim _leTrab = leTrabajador
            Dim _leTrabAux = (From le In _leTrab Where le.Disponible = True And le.IndEstado > 0 Select le.Id, le.oePersona.NombreCompleto, le.oePersona.Dni)
            LlenarCombo(cboTecnico, "NombreCompleto", _leTrabAux.ToList, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function CalculaCocada(r1 As Double, r2 As Double, r3 As Double, r4 As Double) As Double
        Try
            Dim cocada As Integer = 0
            'Dim ribetes() As Integer = {r1, r2, r3, r4}
            Dim ribetes() As Integer = {r1, r2, r3}
            cocada = ribetes(0)
            For Each rib As Integer In ribetes
                If rib < cocada Then
                    cocada = rib
                End If
            Next
            Return cocada
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class