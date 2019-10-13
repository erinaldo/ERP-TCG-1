'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_Contratos
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializacion"

    Public Sub New(Accion As String, oeContrTrab As e_Contratos, oeTrabAux As e_Trabajador)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        mnuMantContrato.Visible = True
        bandcargar = False
        Inicializar()
        CargarCombos()
        oeContratos = oeContrTrab
        leContratosAux = oeTrabAux.leContratos
        Select Case Accion
            Case "Agregar"
                cboTrabajador.Value = oeContratos.IdTrabajador
            Case "Editar"
                CargarDatos(oeContratos)
                cboTrabajador.ReadOnly = True
        End Select
        cboTrabajador.ReadOnly = True
    End Sub

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
        mnuMantContrato.Visible = False
    End Sub

    Private Shared Instancia As frm_Contratos = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_Contratos()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Declaración de variables"

    Private WithEvents oeContratos As New e_Contratos
    Private olContratos As New l_Contratos
    Private loContratos As New List(Of e_Contratos)
    Private loHistorialContratos As New List(Of e_Contratos)

    Private oeTrabajador As New e_Trabajador
    Private olTrabajador As New l_Trabajador

    Dim _ingresando_datos As Boolean = False
    Private bandcargar As Boolean = True
    Private leContratosAux As New List(Of e_Contratos)
    Private loTrabajadores As New List(Of e_Combo)
    Private olTrabajadores As New l_Combo

#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            MostrarTabs(1, ficContratos, 1)
            MostrarTabs(0, ficMantenimiento, 0)
            oeContratos.Modificado = False
            Inicializar()
            LlenaTrabajadores(True)
            Operacion = "Nuevo"
            cboTipoContrato.Focus()
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Tiempo1.Enabled = True
            Listar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Operacion = "Editar"
            Inicializar()
            Mostrar()
            MostrarTabs(1, ficContratos, 1)
            cboTipoContrato.Focus()
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarContrato() Then
                MostrarTabs(0, ficContratos)
                Listar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeContratos.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarContrato() Then
                            MostrarTabs(0, ficContratos, 2)
                            _ingresando_datos = False
                            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficContratos, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficContratos, 2)
                        _ingresando_datos = False
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                    Case Windows.Forms.DialogResult.Cancel
                        ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 1)
                End Select
            Else
                MostrarTabs(0, ficContratos)
                Listar()
                _ingresando_datos = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            Select Case ficContratos.SelectedTab.Index
                Case 0
                    If griContratos.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                    Exportar_Excel(griContratos)
                Case 1
                    If griHistorialContratos.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                    Exportar_Excel(griHistorialContratos)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If griContratos.ActiveRow.Cells("Estado").Value <> "ENVIADO" Then
                Select MessageBox.Show("Desea Eliminar la Informacion?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        EliminarContrato()
                        Listar()
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Metodos"

    Public Sub Listar()
        Try
            If rbPorVencer.Checked Then
                ListarContratosXVencer()
            Else
                oeContratos = New e_Contratos
                oeContratos.TipoOperacion = ""
                oeContratos.FechaDesde = fecDesde.Value
                oeContratos.FechaHasta = fecHasta.Value
                If cboTrabajadorBusqueda.SelectedIndex <> -1 Then oeContratos.IdTrabajador = cboTrabajadorBusqueda.Value
                If cboOcupacionBusqueda.SelectedIndex <> -1 Then oeContratos.IdOcupacion = cboOcupacionBusqueda.Value
                If cboTipoBusqueda.SelectedIndex <> -1 Then oeContratos.IdTipoContrato = cboTipoBusqueda.Value
                If rbVigentes.Checked Then
                    oeContratos.Vigencia = rbVigentes.Checked
                ElseIf rbCesados.Checked Then
                    oeContratos.Vigencia = False
                    oeContratos.TipoOperacion = "4"
                End If
                griContratos.DataSource = olContratos.Listar(oeContratos)
                ControlBotoneria()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Mostrar()
        Try
            oeContratos = New e_Contratos
            oeContratos.TipoOperacion = ""
            oeContratos.Id = griContratos.ActiveRow.Cells("Id").Value
            oeContratos = olContratos.Obtener(oeContratos)
            CargarDatos(oeContratos)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function GuardarContrato() As Boolean
        Try
            LlenarObjeto()
            oeContratos.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olContratos.Guardar(oeContratos) Then
                mensajeEmergente.Confirmacion("La Informacion ha Sido Guardada Correctamente")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Inicializar()
        oeContratos = New e_Contratos
        Agrupacion6.Enabled = True
        cboTrabajador.SelectedIndex = -1
        cboOcupacion.SelectedIndex = -1
        cboTipoContrato.SelectedIndex = -1
        loHistorialContratos = New List(Of e_Contratos)
        griHistorialContratos.DataSource = loHistorialContratos
        fecInicio.Value = Date.Now
        fecTermino.Value = Date.Now
        numSueldo.Value = 0
        cboRegimenLaboral.SelectedIndex = 0
        optDiscapacitado.CheckedIndex = 0
        optSindicalizado.CheckedIndex = 0
        verJornadaTrabajoMax.Checked = True
        verJornadaAcumulativo.Checked = False
        verJornadaNocturno.Checked = False
        optSituacionEspecial.CheckedIndex = 0
        txtEstado.Text = "GENERADA"
    End Sub

    Public Sub LlenarObjeto()
        Try
            If Validar() Then
                If Operacion = "Editar" Then
                    oeContratos.TipoOperacion = "A"
                ElseIf Operacion = "Nuevo" Then
                    oeContratos = New e_Contratos
                    oeContratos.TipoOperacion = "I"
                ElseIf Operacion = "Enviar" Then
                    oeContratos.TipoOperacion = "C"
                ElseIf Operacion = "Terminar" Then
                    oeContratos.TipoOperacion = "T"
                    oeContratos.IdMotivoCese = cboMotivoCese.Value
                    oeContratos.Glosa = txtGlosa.Text
                    oeContratos.FechaCese = fecCese.Value
                End If
                oeContratos.IdTrabajador = cboTrabajador.Value
                oeContratos.IdOcupacion = cboOcupacion.Value
                oeContratos.IdTipoContrato = cboTipoContrato.Value
                If oeContratos.IdTipoContrato = "1SI002" Then
                    oeContratos.IdModalidadContrato = cboModalidadContrato.Value
                End If
                oeContratos.FechaInicio = fecInicio.Value
                oeContratos.FechaTermino = fecTermino.Value
                oeContratos.FechaCreacion = ObtenerFechaServidor()
                oeContratos.Sueldo = numSueldo.Value
                oeContratos.UsuarioCreacion = gUsuarioSGI.Id
                oeContratos.RegimenLaboral = cboRegimenLaboral.Value
                oeContratos.Discapacitado = optDiscapacitado.CheckedIndex
                oeContratos.Sindicalizado = optSindicalizado.CheckedIndex
                oeContratos.JornadaTrabajoMax = verJornadaTrabajoMax.Checked
                oeContratos.JornadaAcumulativo = verJornadaAcumulativo.Checked
                oeContratos.JornadaNocturno = verJornadaNocturno.Checked
                oeContratos.SituacionEspecial = optSituacionEspecial.CheckedIndex
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function Validar()
        Try
            If bandcargar AndAlso cboTrabajador.SelectedIndex = -1 Then Throw New Exception("Seleccione Trabajador")
            If cboOcupacion.SelectedIndex = -1 Then Throw New Exception("Seleccione Ocupacion")
            If cboTipoContrato.SelectedIndex = -1 Then Throw New Exception("Seleccione Tipo de Contrato")
            If fecInicio.Value.Date >= fecTermino.Value.Date Then Throw New Exception("La Fecha Inicio no Puede ser Mayor a la Fecha Fin")
            If numSueldo.Value = 0 Then Throw New Exception("El Sueldo Tiene que ser Mayor a 0")
            If cboTipoContrato.Value = "1SI002" Then
                If cboModalidadContrato.SelectedIndex = -1 Then
                    Throw New Exception("El Contrato a Plazo Fijo Tiene que Tener Modalidad")
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub CambiarVigencia()
        Try
            oeContratos = New e_Contratos
            oeContratos.TipoOperacion = "V"
            oeContratos.Id = griContratos.ActiveRow.Cells("Id").Value
            oeContratos.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olContratos.Guardar(oeContratos) Then
                mensajeEmergente.Confirmacion("La Vigencia ha Sido Cambiada Correctamente")
                Listar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub ClonarContrato()
        Try
            Select Case MessageBox.Show("Desea Clonar el Contrato?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Case Windows.Forms.DialogResult.Yes
                    Dim oeCntr As New e_Contratos
                    Dim oeCntr2 As New e_Contratos
                    Dim dias As Integer = 0
                    oeCntr.Id = griContratos.ActiveRow.Cells("Id").Value
                    oeCntr.TipoOperacion = ""
                    oeCntr = olContratos.Obtener(oeCntr)
                    dias = DateDiff(DateInterval.Day, oeCntr.FechaInicio, oeCntr.FechaTermino)
                    oeCntr2 = oeCntr.Clonar
                    oeCntr2.TipoOperacion = "I"
                    oeCntr2.FechaCreacion = ObtenerFechaServidor()
                    oeCntr2.UsuarioCreacion = gUsuarioSGI.Id
                    oeCntr2.FechaTermino = oeCntr2.FechaInicio.AddDays(dias)
                    Dim frm As New frm_FechasContrato(oeCntr2.FechaInicio, oeCntr2.FechaTermino, oeCntr2.Sueldo)
                    frm.StartPosition = FormStartPosition.CenterScreen
                    frm.ShowDialog()
                    If frm.flag Then
                        oeCntr2.FechaInicio = frm.FechaInicio
                        oeCntr2.FechaTermino = frm.FechaTermino
                        oeCntr2.Sueldo = frm.Sueldo
                        If olContratos.Clonar(oeCntr, oeCntr2) Then
                            mensajeEmergente.Confirmacion("El Contrato ha Sido Clonado Correctamente")
                        End If
                    End If      
                    Listar()
            End Select
            

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub MostrarHistorial()
        Try
            Dim oeCon As New e_Contratos
            oeCon.TipoOperacion = "1"
            oeCon.IdTrabajador = cboTrabajador.Value
            loHistorialContratos = olContratos.Listar(oeCon)
            griHistorialContratos.DataSource = loHistorialContratos
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CargarCombos()
        Try
            Dim oeConceptosGenerales As New e_ConceptosGenerales
            Dim olConceptosGenerales As New l_ConceptosGenerales
            Dim loConceptosGenerales As New List(Of e_ConceptosGenerales)
            Dim oeModalidadContrato As New e_ModalidadContrato
            Dim olModalidadContrato As New l_ModalidadContrato
            Dim loModalidadContrato As New List(Of e_ModalidadContrato)
            Dim oeOcupacion As New e_Ocupacion
            Dim olOcupacion As New l_Ocupacion
            Dim loOcupacion As New List(Of e_Ocupacion)
            Dim oeMotivoCese As New e_MotivoCese
            Dim olMotivoCese As New l_MotivoCese
            Dim loMotivoCese As New List(Of e_MotivoCese)
            LlenaTrabajadores(False)
            oeOcupacion = New e_Ocupacion
            oeOcupacion.TipoOperacion = ""
            loOcupacion.AddRange(olOcupacion.Listar(oeOcupacion).OrderBy(Function(item) item.Nombre).ToList)
            LlenarCombo(cboOcupacion, "Nombre", loOcupacion, -1)
            LlenarCombo(cboOcupacionBusqueda, "Nombre", loOcupacion, -1)
            oeConceptosGenerales.IdProcesoNegocio = "1SI000000002"
            loConceptosGenerales.AddRange(olConceptosGenerales.Listar(oeConceptosGenerales).OrderBy(Function(item) item.Nombre).ToList)
            LlenarCombo(cboTipoContrato, "Nombre", loConceptosGenerales, -1)
            LlenarCombo(cboTipoBusqueda, "Nombre", loConceptosGenerales, -1)
            loModalidadContrato.AddRange(olModalidadContrato.Listar(oeModalidadContrato))
            LlenarCombo(cboModalidadContrato, "Nombre", loModalidadContrato, -1)
            loMotivoCese.AddRange(olMotivoCese.Listar(oeMotivoCese))
            LlenarCombo(cboMotivoCese, "Nombre", loMotivoCese, -1)
            Dim dtRegLaboral As Data.DataTable
            dtRegLaboral = GenerarDTConfigurable(CargarCTCD("T33_Regimen_Laboral"))
            LlenaComboConfigurable(cboRegimenLaboral, FiltraDTable(dtRegLaboral, "SECTOR_PRIVADO = 'A' ", ""), "CODIGO", "NOMBRE", -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaTrabajadores(ByVal Nuevos As Boolean)
        If Nuevos = True Then
            Dim oe As New e_Combo
            Dim olCombo As New l_Combo
            oe.Nombre = "Trabajador"
            loTrabajadores.AddRange(olCombo.Listar(oe))
            LlenarCombo(cboTrabajador, "Nombre", loTrabajadores, -1)
            LlenarCombo(cboTrabajadorBusqueda, "Nombre", loTrabajadores, -1)
        Else
            LlenarCombo(cboTrabajador, "Nombre", TrabajadorPublic, -1)
            LlenarCombo(cboTrabajadorBusqueda, "Nombre", TrabajadorPublic, -1)
        End If
    End Sub
    Public Sub EliminarContrato()
        Try
            oeContratos = New e_Contratos
            oeContratos.Id = griContratos.ActiveRow.Cells("Id").Value
            oeContratos.Activo = 0
            If olContratos.Eliminar(oeContratos) Then
                mensajeEmergente.Confirmacion("La Informacion ha Sido Eliminada Correctamente")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarContratosXVencer()
        oeContratos = New e_Contratos
        oeContratos.TipoOperacion = "2"
        oeContratos.FechaDesde = ObtenerFechaServidor()
        griContratos.DataSource = olContratos.Listar(oeContratos)
        ControlBotoneria()
    End Sub

    Public Sub ControlBotoneria()
        Dim fecha As Date
        Dim fechaserv As Date = ObtenerFechaServidor()
        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griContratos.Rows
            If fila.Cells("Estado").Value = "ENVIADO" Then
                fila.CellAppearance.BackColor = Me.Colores2.Color
                fecha = fila.Cells("FechaTermino").Value
                If fecha.Month = fechaserv.Month And fecha.Year = fechaserv.Year Then
                    fila.CellAppearance.BackColor = Me.Colores3.Color
                    fila.CellAppearance.ForeColor = Color.White
                End If
                If CDate(fila.Cells("FechaTermino").Value).Date < Date.Now.Date Then
                    fila.CellAppearance.BackColor = Me.Colores5.Color
                    fila.CellAppearance.ForeColor = Color.White
                End If
            ElseIf fila.Cells("Estado").Value = "CESADO" Then
                fila.CellAppearance.BackColor = Me.Colores4.Color
                fila.CellAppearance.ForeColor = Color.Black
            Else
                fila.CellAppearance.BackColor = Me.Colores1.Color
            End If
        Next
        If griContratos.Rows.Count > 0 Then
            ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
        Else
            ControlBoton(1, 1)
        End If
    End Sub

    Private Sub CargarDatos(oeContr As e_Contratos)
        With oeContr
            cboTrabajador.Value = .IdTrabajador
            cboOcupacion.Value = .IdOcupacion
            cboTipoContrato.Value = .IdTipoContrato
            fecInicio.Value = .FechaInicio
            fecTermino.Value = .FechaTermino
            numSueldo.Value = .Sueldo
            cboModalidadContrato.Value = .IdModalidadContrato
            cboRegimenLaboral.Value = .RegimenLaboral
            optDiscapacitado.CheckedIndex = IIf(.Discapacitado = False, 0, 1)
            optSindicalizado.CheckedIndex = IIf(.Sindicalizado = False, 0, 1)
            verJornadaTrabajoMax.Checked = .JornadaTrabajoMax
            verJornadaAcumulativo.Checked = .JornadaAcumulativo
            verJornadaNocturno.Checked = .JornadaNocturno
            optSituacionEspecial.CheckedIndex = .SituacionEspecial
            txtEstado.Text = .Estado
            If oeContratos.Estado = "ENVIADO" Then Agrupacion6.Enabled = False
            MostrarHistorial()
        End With
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Contratos_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Select Case ficContratos.SelectedTab.Index
            Case 0
                If griContratos.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 1)
        End Select
    End Sub

    Private Sub frm_Contratos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_Contratos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_Contratos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If bandcargar Then
                CargarCombos()
                fecDesde.Value = Date.Now.AddDays(-30)
            Else
                MostrarTabs(1, ficContratos)
                ficContratos.Tabs(0).Enabled = False
                ficContratos.Tabs(1).Enabled = True
                MostrarTabs(0, ficMantenimiento)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboTrabajador_ValueChanged(sender As Object, e As EventArgs) Handles cboTrabajador.ValueChanged
        oeContratos.Modificado = True
    End Sub

    Private Sub cboOcupacion_ValueChanged(sender As Object, e As EventArgs) Handles cboOcupacion.ValueChanged
        oeContratos.Modificado = True
    End Sub

    Private Sub cboTipoContrato_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoContrato.ValueChanged
        oeContratos.Modificado = True
        If cboTipoContrato.Value = "1SI002" Then
            cboModalidadContrato.Enabled = True
        Else
            cboModalidadContrato.SelectedIndex = -1
            cboModalidadContrato.Enabled = False
        End If
    End Sub

    Private Sub fecInicio_ValueChanged(sender As Object, e As EventArgs) Handles fecInicio.ValueChanged
        oeContratos.Modificado = True
    End Sub

    Private Sub fecTermino_ValueChanged(sender As Object, e As EventArgs) Handles fecTermino.ValueChanged
        oeContratos.Modificado = True
    End Sub

    Private Sub numSueldo_ValueChanged(sender As Object, e As EventArgs) Handles numSueldo.ValueChanged
        oeContratos.Modificado = True
    End Sub

    Private Sub griContratos_DoubleClick(sender As Object, e As EventArgs) Handles griContratos.DoubleClick
        Editar()
    End Sub

    Private Sub cboTrabajador_Validated(sender As Object, e As EventArgs) Handles cboTrabajador.Validated
        Try
            If griHistorialContratos.Rows.Count = 0 Then
                If Len(cboTrabajador.Value) = 12 Then
                    MostrarHistorial()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub mnuMantContrato_ToolClick(sender As Object, e As UltraWinToolbars.ToolClickEventArgs) Handles mnuMantContrato.ToolClick
        Try
            Select Case e.Tool.Key
                Case "Grabar"
                    If oeContratos.Id <> "" Then
                        oeContratos.Equivale = 1
                        If leContratosAux.Contains(oeContratos) Then
                            oeContratos = leContratosAux.Item(leContratosAux.IndexOf(oeContratos))
                            If oeContratos.Id <> "ID" Then oeContratos.TipoOperacion = "A"
                            LlenarObjeto()
                        End If
                    Else
                        Dim oeAux As New e_Contratos
                        oeAux.TipoOperacion = "5"
                        oeAux = olContratos.Obtener(oeAux)
                        LlenarObjeto()
                        oeContratos.TipoOperacion = "I"
                        If oeAux IsNot Nothing AndAlso oeAux.Codigo <> "" Then
                            oeContratos.Codigo = oeAux.Codigo
                        End If
                        oeContratos.Id = "ID"
                        leContratosAux.Add(oeContratos)
                    End If
                    mensajeEmergente.Confirmacion("Los Datos se han Guardado Correctamente!!", True)
                    Me.Close()
                Case "Cancelar"
                    If MessageBox.Show("¿Desea cancelar la Operacion", "Mensaje de Sistema", MessageBoxButtons.YesNo _
                                , MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        Me.Close()
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTrabajador_EditorButtonClick(sender As Object, e As UltraWinEditors.EditorButtonEventArgs) Handles cboTrabajador.EditorButtonClick
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            'Select Case e.Button.Key
            '    Case "Right"

            LlenaTrabajadores(True)
            'End Select
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

#End Region

#Region "Menu Contextual"

    Private Sub mnuContratos_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mnuContratos.Opening
        Try
            mnuContratos.Items("ToolStripMenuNuevo").Visible = True
            mnuContratos.Items("ToolStripMenuEditar").Visible = False
            mnuContratos.Items("ToolStripMenuEliminar").Visible = False
            mnuContratos.Items("ToolStripMenuVigencia").Visible = False
            mnuContratos.Items("ToolStripClonarContrato").Visible = False
            mnuContratos.Items("ToolStripTerminarContrato").Visible = False
            mnuContratos.Items("ToolStripEnviarContrato").Visible = False
            If griContratos.Selected.Rows.Count > 0 Then
                mnuContratos.Items("ToolStripMenuEditar").Visible = True
                mnuContratos.Items("ToolStripMenuEliminar").Visible = True
                mnuContratos.Items("ToolStripEnviarContrato").Visible = True
                If griContratos.ActiveRow.Cells("Estado").Value = "ENVIADO" Then
                    mnuContratos.Items("ToolStripMenuEliminar").Visible = False
                    mnuContratos.Items("ToolStripEnviarContrato").Visible = False
                    mnuContratos.Items("ToolStripMenuEditar").Visible = False
                    mnuContratos.Items("ToolStripClonarContrato").Visible = True
                    mnuContratos.Items("ToolStripTerminarContrato").Visible = True
                End If
                If griContratos.ActiveRow.Cells("Estado").Value = "CESADO" Then
                    mnuContratos.Items("ToolStripMenuEliminar").Visible = False
                    mnuContratos.Items("ToolStripEnviarContrato").Visible = False
                    mnuContratos.Items("ToolStripMenuEditar").Visible = False
                    mnuContratos.Items("ToolStripClonarContrato").Visible = False
                    mnuContratos.Items("ToolStripTerminarContrato").Visible = False
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuNuevo_Click(sender As Object, e As EventArgs) Handles ToolStripMenuNuevo.Click
        Nuevo()
    End Sub

    Private Sub ToolStripMenuEditar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuEditar.Click
        Editar()
    End Sub

    Private Sub ToolStripMenuEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuEliminar.Click
        Eliminar()
    End Sub

    Private Sub ToolStripMenuVigencia_Click(sender As Object, e As EventArgs) Handles ToolStripMenuVigencia.Click
        CambiarVigencia()
    End Sub

    Private Sub ToolStripClonarContrato_Click(sender As Object, e As EventArgs) Handles ToolStripClonarContrato.Click
        ClonarContrato()
    End Sub

    Private Sub ToolStripTerminarContrato_Click(sender As Object, e As EventArgs) Handles ToolStripTerminarContrato.Click
        Editar()
        Operacion = "Terminar"
        MostrarTabs(1, ficMantenimiento, 1)
    End Sub

    Private Sub ToolStripEnviarContrato_Click(sender As Object, e As EventArgs) Handles ToolStripEnviarContrato.Click
        Editar()
        Operacion = "Enviar"
        Agrupacion6.Enabled = False
        MostrarTabs(0, ficMantenimiento, 0)
    End Sub

#End Region

End Class