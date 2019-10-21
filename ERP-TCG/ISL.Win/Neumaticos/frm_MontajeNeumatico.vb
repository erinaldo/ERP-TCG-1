'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports ISL.Controles

Public Class frm_MontajeNeumatico

#Region "Instancia"

    Sub New(ByVal oeOperNeu As e_OperacionNeumatico)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oeOperacionNeumatico = oeOperNeu
        'dtpFecha.Value = Date.Now
        fecMontaje.Value = Date.Now
    End Sub

#End Region

#Region "Declaracion de Variables"

    Dim oeOperacionNeumatico As New e_OperacionNeumatico, olOperacionNeumatico As New l_OperacionNeumatico
    Dim oeVidaNeumatico As New e_VidaNeumatico, olVidaNeumatico As New l_VidaNeumatico
    Dim _KmNeumatico As Double
    Public mensajeEmergente As New c_Alertas

    Dim oeVehiculo As New e_Combo, olVehiculo As New l_Combo, leVehiculo As New List(Of e_Combo)
    Dim oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador, leTrabajador As New List(Of e_Trabajador)

#End Region

#Region "Eventos"

    Private Sub frm_MontajeNeumatico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarDatos()
        gmt_ConfigurarEventoKeyEnter_Tab(Me)
        gf_AsignarEventoSeleccionarTexto(Me)
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If Not ValidarDatos() Then Exit Sub
            oeOperacionNeumatico.TipoOperacion = "I"
            oeOperacionNeumatico.IdMotivo = ""
            oeOperacionNeumatico.Operacion = "VEHICULO" ' MONTAJE
            oeOperacionNeumatico.IndMontaje = 1
            oeOperacionNeumatico.IndInspeccion = 0
            oeOperacionNeumatico.Ribete1 = ndRibete1.Value
            oeOperacionNeumatico.Ribete2 = ndRibete2.Value
            oeOperacionNeumatico.Ribete3 = ndRibete3.Value
            'oeOperacionNeumatico.Ribete4 =
            oeOperacionNeumatico.Cocada = ndCocada.Value
            'oeOperacionNeumatico.FechaOperacion = dtpFecha.Value
            oeOperacionNeumatico.FechaOperacion = fecMontaje.Value
            oeOperacionNeumatico.KmVehiculo = ndKmVehiculo.Value
            oeOperacionNeumatico.KmNeumatico = _KmNeumatico
            oeOperacionNeumatico.UsuarioCreacion = gUsuarioSGI.Id
            oeOperacionNeumatico.Presion = ndPresion.Value
            oeOperacionNeumatico.IdResponsable = cboTecnico.Value
            oeOperacionNeumatico.IdConductor = cboConductor.Value
            oeOperacionNeumatico.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olOperacionNeumatico.Guardar(oeOperacionNeumatico) Then
                MessageBox.Show("Registrado correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub ndPresion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndPresion.ValueChanged
        If ndPresion.Value < 90 OrElse ndPresion.Value > 120 Then
            Me.ErrorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            ErrorProvider1.SetError(ndPresion, "El valor de la presion no puede ser menor que 90 o mayor que 120")
            ToolTip1.SetToolTip(ndPresion, "El ragon de valores de la presion es: 90 - 120 ")
        Else
            Me.ErrorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink
            ErrorProvider1.SetError(ndPresion, Nothing)
            ToolTip1.SetToolTip(ndPresion, Nothing)
        End If
    End Sub

    Private Sub ndCocada_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndCocada.ValueChanged
        oeOperacionNeumatico.Cocada = ndCocada.Value
    End Sub

    Private Sub ndRibete1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndRibete1.ValueChanged, _
    ndRibete2.ValueChanged, ndRibete3.ValueChanged, ndRibete4.ValueChanged
        Try
            'If ndRibete1.Value > oeVidaNeumatico.Ribete1 Then
            '    ndRibete1.Value = oeVidaNeumatico.Ribete1
            '    ndRibete1.Update()
            '    Throw New Exception("El Ribete 1 no puede ser mayor a: " & oeVidaNeumatico.Ribete1)
            'End If
            'If ndRibete2.Value > oeVidaNeumatico.Ribete2 Then
            '    ndRibete2.Value = oeVidaNeumatico.Ribete2
            '    ndRibete2.Update()
            '    Throw New Exception("El Ribete 2 no puede ser mayor a: " & oeVidaNeumatico.Ribete2)
            'End If
            'If ndRibete3.Value > oeVidaNeumatico.Ribete3 Then
            '    ndRibete3.Value = oeVidaNeumatico.Ribete3
            '    ndRibete3.Update()
            '    Throw New Exception("El Ribete 3 no puede ser mayor a: " & oeVidaNeumatico.Ribete3)
            'End If

            ndCocada.Value = CalculaCocada(ndRibete1.Value, ndRibete2.Value, ndRibete3.Value, ndRibete4.Value)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Sub CargarDatos(Optional ByVal ls_Opcion As Integer = 0)
        Try
            oeVidaNeumatico = New e_VidaNeumatico
            oeVidaNeumatico.Id = oeOperacionNeumatico.IdVidaNeumatico
            oeVidaNeumatico.Activo = True
            oeVidaNeumatico = olVidaNeumatico.Obtener(oeVidaNeumatico)

            'If Not a_Neumatico Is Nothing And a_Neumatico.Count > 0 Then
            Me.txtCodigoNeu.Text = oeVidaNeumatico.CodigoNeumatico
            Me.ndRibete1.Value = oeVidaNeumatico.Ribete1
            Me.ndRibete2.Value = oeVidaNeumatico.Ribete2
            Me.ndRibete3.Value = oeVidaNeumatico.Ribete3
            Me.ndRibete4.Value = oeVidaNeumatico.Ribete4
            Me.ndCocada.Value = oeVidaNeumatico.Cocada
            Me.ndRibete1.MaxValue = oeVidaNeumatico.Ribete1
            Me.ndRibete2.MaxValue = oeVidaNeumatico.Ribete2
            Me.ndRibete3.MaxValue = oeVidaNeumatico.Ribete3
            'Me.ndPresion.Value = oeVidaNeumatico.Presion
            'Me.ndCocadaMin.Value = oeVidaNeumatico.CocadaMinima
            _KmNeumatico = oeVidaNeumatico.Kilometraje
            'End If
            Me.txtPosicion.Text = oeOperacionNeumatico.Posicion
            Me.ndKmVehiculo.Value = oeOperacionNeumatico.KmVehiculo
            'lbl_KmCallCenter.Text = Format(mn_KilometrajeVeh, "###,##0.00")

            Dim oeConductor As New e_Combo
            Dim leConductor As New List(Of e_Combo)
            oeConductor.Id = "NO ASIGNADO"
            oeConductor.Nombre = "NO ASIGNADO"
            leConductor.Add(oeConductor)
            leConductor.AddRange(PilotoPublic)
            LlenarCombo(cboConductor, "Nombre", leConductor, 0)

            oeVehiculo = New e_Combo
            oeVehiculo.Nombre = "Vehiculo"
            leVehiculo = olVehiculo.Listar(oeVehiculo).OrderBy(Function(it) it.Nombre).ToList

            If oeOperacionNeumatico.IdVehiculo <> "" Then
                Dim _leVeh = leVehiculo.Where(Function(it) it.Id = oeOperacionNeumatico.IdVehiculo).ToList
                If _leVeh.Count > 0 Then
                    oeVehiculo = _leVeh(0)
                    Dim oeOpeNeu As New e_OperacionNeumatico
                    oeOpeNeu.TipoOperacion = "O"
                    oeOpeNeu.IdVehiculo = oeVehiculo.Id
                    oeOpeNeu.IndMontaje = oeVehiculo.Descripcion
                    oeOpeNeu = olOperacionNeumatico.Obtener(oeOpeNeu)
                    If oeOpeNeu IsNot Nothing AndAlso oeOpeNeu.UsuarioCreacion.Trim <> "" Then
                        cboConductor.Value = oeOpeNeu.UsuarioCreacion
                    End If
                End If
            End If

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
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function ValidarDatos() As Boolean
        Try
            If ndPresion.Value < 90 OrElse ndPresion.Value > 120 Then
                Me.ErrorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                ErrorProvider1.SetError(ndPresion, "El valor de la presion no puede ser menor que 90 o mayor que 120")
                ToolTip1.SetToolTip(ndPresion, "El ragon de valores de la presion es: 90 - 120 ")
                Return False
            Else
                Me.ErrorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink
                ErrorProvider1.SetError(ndPresion, Nothing)
                ToolTip1.SetToolTip(ndPresion, Nothing)
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CalculaCocada(ByVal r1 As Double, ByVal r2 As Double, ByVal r3 As Double, ByVal r4 As Double) As Double
        Try
            Dim cocada As Integer = 0
            Dim ribetes() As Integer = {r1, r2, r3, r4}
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