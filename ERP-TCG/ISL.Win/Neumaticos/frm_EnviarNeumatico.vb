Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports ISL.Controles

Public Class frm_EnviarNeumatico

#Region "Declaracion de Variables"

    Dim oeMotivo As New e_Motivo, olMotivo As New l_Motivo
    Dim oeMovimientoNeumatico As New e_MovimientoNeumatico, olMovimientoNeumatico As New l_MovimientoNeumatico
    Private oeVehiculo As New e_Combo, olVehiculo As New l_Combo, leVehiculo As New List(Of e_Combo)
    Private oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador, leTrabajador As New List(Of e_Trabajador)
    Private oeOperacionNeu As New e_OperacionNeumatico, olOperacionNeu As New l_OperacionNeumatico
    Dim _IdVidaNeumatico As String, _CodigoNeu As String, _EstadoInicial As String, _EstadoFinal As String, _idOpeNeuUtl As String

#End Region

#Region "Instancia"

    Sub New(ByVal ls_Operacion As String, ByVal ls_IdVidaNeumatico As String, ByVal ls_CodigoNeu As String, _
         ByVal ls_EstadoInicial As String)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _IdVidaNeumatico = ls_IdVidaNeumatico
        _EstadoInicial = ls_EstadoInicial
        _CodigoNeu = ls_CodigoNeu
        _EstadoFinal = ls_Operacion
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_EnviarNeumatico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gmt_ConfigurarEventoKeyEnter_Tab(Me)
            gf_AsignarEventoSeleccionarTexto(Me)
            txtCodigo.Text = _CodigoNeu
            fecMovimiento.Value = Date.Now.Date
            CargarCombos()
            CargarUltimoMontaje()
            ndPrecioVenta.Value = 0
            etiPrecio.Visible = IIf(_EstadoFinal = "VENTA", True, False)
            ndPrecioVenta.Visible = IIf(_EstadoFinal = "VENTA", True, False)
            If _EstadoFinal = "VENTA" Then cmbMotivo.SelectedText = "PARA VENTA" : cmbMotivo.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            oeMovimientoNeumatico = New e_MovimientoNeumatico
            oeMovimientoNeumatico.TipoOperacion = "I"
            oeMovimientoNeumatico.IdVidaNeumatico = _IdVidaNeumatico
            oeMovimientoNeumatico.IdMotivo = cmbMotivo.Value
            oeMovimientoNeumatico.EstadoInicial = _EstadoInicial
            oeMovimientoNeumatico.EstadoFinal = _EstadoFinal
            oeMovimientoNeumatico.IndVigente = 1
            oeMovimientoNeumatico.CostoSoles = ndPrecioVenta.Value
            oeMovimientoNeumatico.IdOperacionNeumatico = _idOpeNeuUtl
            oeMovimientoNeumatico.IdConductor = cboConductor.Value
            oeMovimientoNeumatico.IdVehiculo = cboVehiculo.Value
            oeMovimientoNeumatico.IdTecnicoNeu = cboTecnico.Value
            oeMovimientoNeumatico.UsuarioCreacion = gUsuarioSGI.Id
            oeMovimientoNeumatico.FechaMov = fecMovimiento.Value
            If olMovimientoNeumatico.Guardar(oeMovimientoNeumatico) Then
                MessageBox.Show("Registrado correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub cboVehiculo_ValueChanged(sender As Object, e As EventArgs) Handles cboVehiculo.ValueChanged
        Try
            If cboVehiculo.SelectedIndex > -1 Then
                oeVehiculo = New e_Combo
                oeVehiculo = cboVehiculo.Items(cboVehiculo.SelectedIndex).ListObject
                txtTipoVehiculo.Text = IIf(oeVehiculo.Descripcion = "1", "TRACTO", "CARRETA")
            Else
                txtTipoVehiculo.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try
            r_LlenarMotivo()
            ' Cargar Vehiculo
            oeVehiculo = New e_Combo
            oeVehiculo.Nombre = "Vehiculo"
            leVehiculo = olVehiculo.Listar(oeVehiculo).OrderBy(Function(it) it.Nombre).ToList
            LlenarCombo(cboVehiculo, "Nombre", leVehiculo, -1)
            ' Cargar Conductor
            LlenarCombo(cboConductor, "Nombre", PilotoPublic, -1)
            ' Cargar Tecnico Responsable
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
            Dim _leTrabAux = From le In _leTrab _
                             Where le.Disponible = True And le.IndEstado > 0 _
                             Select le.Id, le.oePersona.NombreCompleto, le.oePersona.Dni

            LlenarCombo(cboTecnico, "NombreCompleto", _leTrabAux.ToList, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub r_LlenarMotivo()
        oeMotivo = New e_Motivo
        oeMotivo.Activo = True
        oeMotivo.IndAlmacen = False
        oeMotivo.IndReparacion = False
        oeMotivo.IndReencauche = False
        oeMotivo.IndBaja = False
        Select Case _EstadoFinal
            Case "ALMACEN"
                Me.Text = "Enviar a Almacén"
                oeMotivo.IndAlmacen = True
            Case "REENCAUCHE"
                Me.Text = "Enviar a Reencauche"
                oeMotivo.IndReencauche = True
            Case "REPARACION"
                Me.Text = "Enviar a Reparar"
                oeMotivo.IndReparacion = True
            Case "BAJA"
                Me.Text = "Enviar de Baja"
                oeMotivo.IndBaja = True
            Case "VENTA"
                Me.Text = "Enviar a Venta"
        End Select
        cmbMotivo.DataSource = olMotivo.Listar(oeMotivo)
    End Sub

    Private Sub CargarUltimoMontaje()
        Try
            ' Obtener Datos de Vehiculo
            oeOperacionNeu = New e_OperacionNeumatico
            oeOperacionNeu.TipoOperacion = "U"
            oeOperacionNeu.IdVidaNeumatico = _IdVidaNeumatico
            oeOperacionNeu = olOperacionNeu.Obtener(oeOperacionNeu)
            If oeOperacionNeu IsNot Nothing AndAlso oeOperacionNeu.IdVehiculo <> "" Then
                cboVehiculo.Value = oeOperacionNeu.IdVehiculo : _idOpeNeuUtl = oeOperacionNeu.Id
            End If
            ' Obtener Datos de Conductor
            oeOperacionNeu = New e_OperacionNeumatico
            oeOperacionNeu.TipoOperacion = "O"
            oeOperacionNeu.IdVehiculo = cboVehiculo.Value
            oeOperacionNeu.IndMontaje = IIf(txtTipoVehiculo.Text <> "TRACTO", 0, 1)
            oeOperacionNeu = olOperacionNeu.Obtener(oeOperacionNeu)
            If oeOperacionNeu IsNot Nothing AndAlso oeOperacionNeu.UsuarioCreacion <> "" Then
                cboConductor.Value = oeOperacionNeu.UsuarioCreacion
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class