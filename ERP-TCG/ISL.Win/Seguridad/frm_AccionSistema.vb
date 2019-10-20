'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_AccionSistema
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_AccionSistema = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_AccionSistema()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeAccionSistema As New e_AccionSistema, olAccionSistema As New l_AccionSistema, leAccionSistema As New List(Of e_AccionSistema)
    Private oeProcesoNegocio As New e_ProcesoNegocio, olProcesoNegocio As New l_ProcesoNegocio, leProcesoNegocio As New List(Of e_ProcesoNegocio)
    Private oeActividadNegocio As New e_ActividadNegocio, olActividadNegocio As New l_ActividadNegocio, leActividadNegocio As New List(Of e_ActividadNegocio)
    Private oeActividadRestringida As New e_ActividadRestringida, olActividadRestringida As New l_ActividadRestringida, leActividadRestringida As New List(Of e_ActividadRestringida)
    Dim _ingresando_datos As Boolean = False
    Dim _BandValida As Boolean = True

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griAccionSistema.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        MostrarTabs(1, ficAccionSistema, 1)
        Inicializar()
        oeAccionSistema.TipoOperacion = "I"
        oeAccionSistema.Modificado = False
        txtCodigo.Text = ObtieneCodigo()
        txtNombre.Focus()
        Operacion = "Nuevo"
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        Mostrar()
        oeAccionSistema.TipoOperacion = "A"
        oeAccionSistema.Modificado = False
        txtNombre.Focus()
        Operacion = "Editar"
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            If Guardando() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficAccionSistema, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeAccionSistema.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            MostrarTabs(0, ficAccionSistema, 2)
                            _ingresando_datos = False
                            Consultar(_Activo)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficAccionSistema, 1)
                        End If

                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficAccionSistema, 2)
                        _ingresando_datos = False
                        Consultar(_Activo)
                End Select
            Else
                MostrarTabs(0, ficAccionSistema, 2)
                _ingresando_datos = False
                Consultar(_Activo)
            End If
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griAccionSistema
                If ValidarGrilla(griAccionSistema, "Formulario") Then
                    oeAccionSistema.Id = .ActiveRow.Cells("ID").Value
                    oeAccionSistema = olAccionSistema.Obtener(oeAccionSistema)
                    If oeAccionSistema.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar el Formulario: " & _
                                 .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeAccionSistema.TipoOperacion = "E"
                            olAccionSistema.Eliminar(oeAccionSistema)
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

#End Region

#Region "Eventos"

    Private Sub frm_AccionSistema_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_AccionSistema_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CargarAS(New List(Of e_AccionSistema))
            CargaCombo()
            CargarActividadProceso(New List(Of e_ActividadNegocio))
            CargarActividadRestringida(New List(Of e_ActividadRestringida))
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboProceso_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProceso.ValueChanged
        Try
            If cboProceso.SelectedIndex > -1 Then
                Dim _leActividadProceso = leActividadNegocio.Where(Function(it) it.IdProcesoNegocio = cboProceso.Value And it.Activo = True).ToList
                CargarActividadProceso(_leActividadProceso)
                CargarActividadRestringida(leActividadRestringida)
                _BandValida = False
                RemarcarActividad()
                _BandValida = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griActividadNegocio_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griActividadNegocio.CellChange
        Try
            If _BandValida Then
                With griActividadNegocio
                    If .ActiveRow.Index > -1 Then
                        .UpdateData()
                        oeActividadRestringida = New e_ActividadRestringida
                        oeActividadRestringida.IdActividadNegocio = .ActiveRow.Cells("Id").Value
                        If .ActiveRow.Cells("Selec").Value Then
                            If Not leActividadRestringida.Contains(oeActividadRestringida) Then
                                oeActividadRestringida.TipoOperacion = "I"
                                oeActividadRestringida.Activo = True
                                oeActividadRestringida.ActividadNegocio = .ActiveRow.Cells("Nombre").Value
                                oeActividadRestringida.ProcesoNegocio = cboProceso.Text
                                oeActividadRestringida.IdProcesoNegocio = cboProceso.Value
                                leActividadRestringida.Add(oeActividadRestringida)
                                'CargarActividadRestringida(leActividadRestringida)
                            Else
                                oeActividadRestringida = leActividadRestringida.Item(leActividadRestringida.IndexOf(oeActividadRestringida))
                                If Not oeActividadRestringida.Activo Then
                                    oeActividadRestringida.TipoOperacion = "A"
                                    oeActividadRestringida.Activo = True
                                    'CargarActividadRestringida(leActividadRestringida)
                                Else
                                    Throw New Exception("La Actividad: " & .ActiveRow.Cells("Nombre").Value & " ya esta agregada")
                                End If
                            End If
                        Else
                            oeActividadRestringida = leActividadRestringida.Item(leActividadRestringida.IndexOf(oeActividadRestringida))
                            oeActividadRestringida.Activo = False
                            oeActividadRestringida.TipoOperacion = "E"
                        End If
                    End If
                End With
                CargarActividadRestringida(leActividadRestringida)
                griActividadRestringida.DataBind()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griAccionSistema_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griAccionSistema.DoubleClick
        Try
            If griAccionSistema.Rows.Count > 0 Then Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            oeAccionSistema = New e_AccionSistema
            oeAccionSistema.TipoOperacion = ""
            oeAccionSistema.Activo = Activo
            CargarAS(olAccionSistema.Listar(oeAccionSistema))
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griAccionSistema.Focus()
    End Sub

    Private Sub Inicializar()
        oeAccionSistema = New e_AccionSistema
        txtNombre.Text = String.Empty
        txtDescripcion.Text = String.Empty
        cboProceso.SelectedIndex = -1
        CargarActividadProceso(New List(Of e_ActividadNegocio))
        leActividadRestringida = New List(Of e_ActividadRestringida)
        CargarActividadRestringida(leActividadRestringida)
    End Sub

    Private Sub Mostrar()
        Try
            If griAccionSistema.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeAccionSistema.Id = griAccionSistema.ActiveRow.Cells("Id").Value.ToString
                oeAccionSistema = olAccionSistema.Obtener(oeAccionSistema)
                txtCodigo.Text = oeAccionSistema.Codigo
                txtNombre.Text = oeAccionSistema.Nombre
                txtDescripcion.Text = oeAccionSistema.Descripcion
                leActividadRestringida = oeAccionSistema.leActividadRestringida
                CargarActividadRestringida(leActividadRestringida)
                MostrarTabs(1, ficAccionSistema, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function Guardando() As Boolean
        Try
            oeAccionSistema.UsuarioCreacion = gUsuarioSGI.Id
            oeAccionSistema.Codigo = txtCodigo.Text.Trim
            oeAccionSistema.Nombre = txtNombre.Text.Trim
            oeAccionSistema.Descripcion = txtDescripcion.Text.Trim
            oeAccionSistema.leActividadRestringida = leActividadRestringida
            'oeAccionSistema.Activo = True 
            oeAccionSistema.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olAccionSistema.Guardar(oeAccionSistema) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                MostrarTabs(0, ficAccionSistema, 2)
                Consultar(_Activo)
                griAccionSistema.Focus()
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            Enfocar(ex.Message)
        End Try
    End Function

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("Nombre") Then
            txtNombre.Focus()
        End If
        If excepcion.Contains("Descripcion") Then
            txtDescripcion.Focus()
        End If
    End Sub

    Private Function ObtieneCodigo() As String
        Try
            Dim oe As New e_AccionSistema
            oe.TipoOperacion = "C"
            Return olAccionSistema.Obtener(oe).Codigo
        Catch ex As Exception
            'mensajeEmergente.Problema(ex.Message, True)
            Return ""
        End Try
    End Function

    Private Sub CargarAS(ByVal le As List(Of e_AccionSistema))
        Try
            With griAccionSistema

                .DataSource = le

                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True

                .DisplayLayout.Bands(0).Columns("Codigo").Width = 150
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 200
                .DisplayLayout.Bands(0).Columns("Descripcion").Width = 400

                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaCombo()
        Try

            oeProcesoNegocio = New e_ProcesoNegocio
            oeProcesoNegocio.TipoOperacion = String.Empty
            oeProcesoNegocio.Indicador = 1
            leProcesoNegocio = olProcesoNegocio.Listar(oeProcesoNegocio)
            LlenarCombo(cboProceso, "Nombre", leProcesoNegocio, -1)

            oeActividadNegocio = New e_ActividadNegocio
            oeActividadNegocio.Activo = True
            oeActividadNegocio.TipoOperacion = ""
            leActividadNegocio = olActividadNegocio.Listar(oeActividadNegocio)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarActividadProceso(ByVal leAP As List(Of e_ActividadNegocio))
        Try
            With griActividadNegocio

                .ResetDisplayLayout()
                .Text = "Actividad de Negocio de Proceso: " & IIf(cboProceso.SelectedIndex > -1, cboProceso.Text, "")
                .DataSource = leAP

                .DisplayLayout.Bands(0).Columns.Add("Selec", "Seleccionar")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Selec").Width = 60

                For Each col In .DisplayLayout.Bands(0).Columns
                    If col.Key = "Selec" Then
                        col.CellClickAction = CellClickAction.Edit
                    Else
                        col.CellClickAction = CellClickAction.RowSelect
                    End If
                Next


                OcultarColumna(griActividadNegocio, True, "Id", "IdProcesoNegocio", "Abreviatura", "UsuarioCreacion", "FechaCreacion", "Activo")

                .DisplayLayout.Bands(0).Columns("Codigo").Width = 80
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 400

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarActividadRestringida(ByVal leAR As List(Of e_ActividadRestringida))
        Try
            With griActividadRestringida

                Dim _leAux As New List(Of e_ActividadRestringida)
                If cboProceso.SelectedIndex > -1 Then
                    _leAux = leAR.Where(Function(it) it.Activo = True And it.IdProcesoNegocio = cboProceso.Value).ToList
                End If

                .DataSource = _leAux
                .Text = "Actividad Negocio Asociada"
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdActividadNegocio").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdAccionSistema").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True

                .DisplayLayout.Bands(0).Columns("ProcesoNegocio").Width = 250
                .DisplayLayout.Bands(0).Columns("ActividadNegocio").Width = 400

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub RemarcarActividad()
        Try
            If leActividadRestringida.Count > 0 Then
                For Each Fila In griActividadNegocio.Rows
                    Dim _idan = Fila.Cells("Id").Value
                    Dim _leARAux = leActividadRestringida.Where(Function(it) it.Activo = True And it.IdActividadNegocio = _idan).ToList
                    If _leARAux.Count > 0 Then Fila.Cells("Selec").Value = True
                Next
                griActividadNegocio.UpdateData()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class