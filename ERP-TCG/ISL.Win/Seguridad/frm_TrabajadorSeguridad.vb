'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF

Public Class frm_TrabajadorSeguridad

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Shared instancia As frm_TrabajadorSeguridad = Nothing
    Private Shared Operacion As String
    Dim _ingresando_datos As Boolean = False

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_TrabajadorSeguridad()
        End If
        instancia.Activate()
        Return instancia
    End Function


#Region "Declaración de variables"

    Dim oeProcesoNeg As New e_ProcesoNegocio, olProcesoNeg As New l_ProcesoNegocio
    Dim oeTrabajadorSeg As New e_TrabajadorSeguridad, olTrabajadorSeg As New l_TrabajadorSeguridad
    Dim oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            ListarTrabajadoresSeguridad(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If grid_TrabajadorSeguridad.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            oeTrabajadorSeg = New e_TrabajadorSeguridad
            oeTrabajadorSeg.TipoOperacion = "I"
            oeTrabajadorSeg.UsuarioCreacion = gUsuarioSGI.Id 'goeUsuario.Id
            MostrarTabs(1, tcTrabajadorSeguridad, 1)
            Inicializar()
            cboTrabajador.Focus()
            Operacion = "Nuevo"
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            cboProcesoM.Value = cboProceso.Value
            'MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Inicializar()
            If EditarTrabajadorSeguridad() Then
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0) 'Habilito el boton Guardar    
                oeTrabajadorSeg.TipoOperacion = "A"
                cboTrabajador.Focus()
                Operacion = "Editar"
            End If

            'MyBase.Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub


    Public Function EditarTrabajadorSeguridad() As Boolean
        Dim id As String
        Try
            With grid_TrabajadorSeguridad
                id = .ActiveRow.Cells("Id").Value.ToString
                If id.Length > 0 Then
                    oeTrabajadorSeg = New e_TrabajadorSeguridad
                    oeTrabajadorSeg.Id = id
                    oeTrabajadorSeg = olTrabajadorSeg.Obtener(oeTrabajadorSeg)
                    If oeTrabajadorSeg.Activo Then
                        cboProcesoM.Value = oeTrabajadorSeg.IdProcesoNegocio
                        cboTrabajador.Value = oeTrabajadorSeg.IdTrabajador
                        ndMonto.Value = oeTrabajadorSeg.CantidadLimite
                        ndMontoMinimo.Value = oeTrabajadorSeg.CantidadMinima
                        If oeTrabajadorSeg.IndMontoFuncional = 1 Then
                            rbMontoDiario.Checked = 1 : rbComprobante.Checked = 0
                        Else
                            rbMontoDiario.Checked = 0 : rbComprobante.Checked = 1
                        End If
                        MostrarTabs(1, tcTrabajadorSeguridad, 1)
                        Return True
                    Else
                        Throw New Exception(Me.Text & ": El Registro se encuentra eliminado y no se puede editar")
                    End If
                Else
                    Throw New Exception("Seleccione una Fila!")
                End If
            End With
        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Overrides Sub Guardar()
        Try
            If GuardarTrabajadorSeguridad() Then
                MostrarTabs(0, tcTrabajadorSeguridad, 2)
            Else
                MostrarTabs(1, tcTrabajadorSeguridad, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeTrabajadorSeg.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarTrabajadorSeguridad() Then
                            MostrarTabs(0, tcTrabajadorSeguridad, 2)
                            _ingresando_datos = False
                            Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, tcTrabajadorSeguridad, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcTrabajadorSeguridad, 2)
                        _ingresando_datos = False
                        Consultar(True)
                End Select
            Else
                MostrarTabs(0, tcTrabajadorSeguridad, 2)
                _ingresando_datos = False
                Consultar(True)
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With grid_TrabajadorSeguridad
                If ValidarGrilla(grid_TrabajadorSeguridad, "Trabajadores") Then
                    oeTrabajadorSeg.Id = .ActiveRow.Cells("Id").Value
                    oeTrabajadorSeg = olTrabajadorSeg.Obtener(oeTrabajadorSeg)
                    If oeTrabajadorSeg.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar el Trabajador : " & _
                                       .ActiveRow.Cells("NombreTrabajador").Value.ToString & " ?", _
                                                      "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeTrabajadorSeg.TipoOperacion = "E"
                            olTrabajadorSeg.Eliminar(oeTrabajadorSeg)
                            Consultar(True)
                        End If
                    Else
                        Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If grid_TrabajadorSeguridad.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grid_TrabajadorSeguridad)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Métodos"

    Public Sub LlenaComboProceso()
        oeProcesoNeg = New e_ProcesoNegocio
        Dim loProcNeg As New List(Of e_ProcesoNegocio)
        oeProcesoNeg.Activo = True
        oeProcesoNeg.Indicador = 0
        oeProcesoNeg.TipoOperacion = "S"
        loProcNeg.AddRange(olProcesoNeg.Listar(oeProcesoNeg))
        LlenarComboMaestro(cboProceso, loProcNeg, 0)
        LlenarComboMaestro(cboProcesoM, loProcNeg, 0)
    End Sub

    Private Function GuardarTrabajadorSeguridad() As Boolean
        Try
            oeTrabajadorSeg.PrefijoID = gs_PrefijoIdSucursal '@0001
            oeTrabajadorSeg.IdProcesoNegocio = cboProcesoM.Value
            If olTrabajadorSeg.Guardar(oeTrabajadorSeg) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                Consultar(True)
                grid_TrabajadorSeguridad.Focus()
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Sub ListarTrabajadoresSeguridad(ByVal Activo As Boolean)
        Try
            oeTrabajadorSeg = New e_TrabajadorSeguridad
            oeTrabajadorSeg.Activo = Activo
            oeTrabajadorSeg.IdProcesoNegocio = cboProceso.Value
            grid_TrabajadorSeguridad.DataSource = olTrabajadorSeg.Listar(oeTrabajadorSeg)
            With grid_TrabajadorSeguridad
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
        grid_TrabajadorSeguridad.Focus()
    End Sub

    Sub Inicializar()
        Try
            LlenaCombos()
            ndMonto.Value = 0
            verActivo.Checked = True
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub LlenaCombos() 
        LLenaComboTrabajador()
    End Sub

    Sub LLenaComboTrabajador()
        cboTrabajador.DataSource = Nothing
        oeTrabajador.TipoOperacion = ""
        Dim _leTrabSeg = olTrabajador.Listar(oeTrabajador)
        Dim _leTrabAux = From le In _leTrabSeg _
                         Select le.Id, le.oePersona.NombreCompleto
        LlenarCombo(cboTrabajador, "NombreCompleto", _leTrabAux.ToList, -1)
    End Sub


#End Region

#Region "Eventos"

    Private Sub frm_TrabajadorSeguridad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenaComboProceso()
    End Sub

    Private Sub frm_TrabajadorSeguridad_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_TrabajadorSeguridad_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Select Case _Operacion
            Case "Nuevo", "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_TrabajadorSeguridad_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Select Case tcTrabajadorSeguridad.SelectedTab.Index
            Case 0
                If grid_TrabajadorSeguridad.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 0, 1)
                Else
                    ControlBoton(1, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        End Select
    End Sub

    Private Sub cmbTrabajador_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrabajador.ValueChanged
        oeTrabajadorSeg.IdTrabajador = cboTrabajador.Value
    End Sub


    Private Sub ndMonto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndMonto.ValueChanged
        oeTrabajadorSeg.CantidadLimite = ndMonto.Value
    End Sub

    Private Sub cmdProceso2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProcesoM.ValueChanged
        oeTrabajadorSeg.IdProcesoNegocio = cboProcesoM.Value
    End Sub

    Private Sub grid_TrabajadorSeguridad_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid_TrabajadorSeguridad.DoubleClick
        If grid_TrabajadorSeguridad.Selected.Rows.Count > 0 Then Editar()
    End Sub
    Private Sub ndMontoMinimo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndMontoMinimo.ValueChanged
        oeTrabajadorSeg.CantidadMinima = ndMontoMinimo.Value
    End Sub
    Private Sub rbMontoDiario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMontoDiario.CheckedChanged
        If rbMontoDiario.Checked Then oeTrabajadorSeg.IndMontoFuncional = 1
    End Sub

    Private Sub rbComprobante_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbComprobante.CheckedChanged
        If rbComprobante.Checked Then oeTrabajadorSeg.IndMontoFuncional = 2
    End Sub

#End Region

End Class
