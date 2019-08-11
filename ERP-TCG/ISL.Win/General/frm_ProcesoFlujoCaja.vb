Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win

Public Class frm_ProcesoFlujoCaja

    Inherits ISL.Win.frm_MenuPadre

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Shared instancia As frm_ProcesoFlujoCaja = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ProcesoFlujoCaja()
        End If
        instancia.Activate()
        Return instancia

    End Function

#Region "Declaracion de Variables"

    Dim oeProcesoNegocio As New e_ProcesoNegocio
    Dim olProcesoNegocio As New l_ProcesoNegocio

    Dim oeProcesoFlujoCaja As New e_ProcesoFlujoCaja
    Dim olProcesoFlujoCaja As New l_ProcesoFlujoCaja

    Dim oeFlujoCaja As New e_FlujoCaja
    Dim olFlujoCaja As New l_FlujoCaja

    Dim loProcesoFlujoCajaRelacion As New List(Of e_ProcesoFlujoCaja)
    Dim loProcesoFlujoCaja As New List(Of e_ProcesoFlujoCaja)

    Dim IdProcesoNegocio As String
    Dim _ingresando_datos As Boolean = False
#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try

            If cboProcesoNegocio.SelectedIndex > -1 Then
                Listar(Activo)
                Tiempo1.Enabled = True
                Operacion = "Inicializa"
                If griProcesoFlujo.Rows.Count > 0 Then
                    MyBase.Consultar(Activo)
                Else
                    MyBase.Consultar()
                End If
            Else
                mensajeEmergente.Problema("Seleccione Proceso")
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            If cboProcesoNegocio.SelectedIndex = -1 Then Throw New Exception("Seleccione Proceso Negocio")
            oeProcesoFlujoCaja.TipoOperacion = "I"
            oeProcesoNegocio.Protegido = 1
            oeProcesoFlujoCaja.Modificado = False
            expFlujoCaja.Expanded = True
            Operacion = "Nuevo"
            cboProcesoNegocio.Enabled = False
            expFlujoCaja.Enabled = True
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
        
    End Sub

    Public Overrides Sub Editar()
        oeProcesoFlujoCaja.TipoOperacion = "I"
        oeProcesoNegocio.Protegido = 1
        oeProcesoFlujoCaja.Modificado = False
        expFlujoCaja.Expanded = True
        Operacion = "Nuevo"
        cboProcesoNegocio.Enabled = False
        expFlujoCaja.Enabled = True
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            If Guardando() Then
                'griFlujoCaja.DataSource = Nothing
                expFlujoCaja.Expanded = False
                cboProcesoNegocio.Enabled = True
                expFlujoCaja.Enabled = False
                MyBase.Guardar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        'griFlujoCaja.DataSource = Nothing
        expFlujoCaja.Expanded = False
        expFlujoCaja.Enabled = False
        cboProcesoNegocio.Enabled = True
        If IdProcesoNegocio <> "" Then cboProcesoNegocio.Value = IdProcesoNegocio
        Consultar(True)
        MyBase.Cancelar()
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try

            If griFlujoCaja.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griProcesoFlujo)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Function Guardando() As Boolean

        Try
            oeProcesoFlujoCaja.ListaProcesoFlujoCaja = loProcesoFlujoCajaRelacion
            If olProcesoFlujoCaja.Guardar(oeProcesoFlujoCaja) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                ' LlenaCombos()
                If IdProcesoNegocio <> "" Then cboProcesoNegocio.Value = IdProcesoNegocio
                Consultar(True)
                cboProcesoNegocio.Focus()
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Function

    Private Sub ListarFlujoCaja()
        Try
            oeFlujoCaja = New e_FlujoCaja
            oeFlujoCaja.Activo = True
            'Inicializar()
            griFlujoCaja.DataSource = Nothing
            With griFlujoCaja
                .ResetDisplayLayout()
                .DataSource = olFlujoCaja.Listar(oeFlujoCaja)

                'Ordena los datos en forma ascendente por el campo Nombre
                .DisplayLayout.Bands(0).Columns.Add("Selec", "Seleccionar")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Selec").Width = 40

                .DisplayLayout.Bands(0).Columns("Nombre").SortIndicator = SortOrder.Ascending

                'Ocultar columnas específicas
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Codigo").Hidden = True
                .DisplayLayout.Bands(0).Columns("Abreviatura").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdItemGasto").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                '.DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Modificado").Hidden = True
                .DisplayLayout.Bands(0).Columns("TipoOperacion").Hidden = True
                ' .DisplayLayout.Bands(0).Columns("Activo").Hidden = True

                ''Especificar el ancho de las columnas que se muestran
                ' .DisplayLayout.Bands(0).Columns("Codigo").Width = 80
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 400

                ''Define el nombre que se mostrará en la cabecera de la lista
                ''.DisplayLayout.Bands(0).Columns("ProcesoNegocio").Header.Caption = "ProcesoNegocio"
                '.DisplayLayout.Bands(0).Columns("Nombre").Header.Caption = "Glosa"

                .DisplayLayout.Bands(0).Columns("Nombre").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                'Cofigura la grilla para que se seleccione la fila completa al hacer click en algun lado
                .DisplayLayout.Bands(0).Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
                .DisplayLayout.Override.RowSelectorNumberStyle = UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
            griFlujoCaja.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
            griFlujoCaja.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try


    End Sub

    Private Sub LlenaCombos()
        oeProcesoNegocio = New e_ProcesoNegocio
        oeProcesoNegocio.TipoOperacion = ""
        oeProcesoNegocio.Indicador = -1
        oeProcesoNegocio.Activo = True
        LlenarCombo(cboProcesoNegocio, "Nombre", olProcesoNegocio.Listar(oeProcesoNegocio), -1)
    End Sub

    Private Sub Listar(ByVal Activo As Boolean) 'MostrarFlujos
        Try
            Me.Cursor = Cursors.WaitCursor
            oeProcesoFlujoCaja = New e_ProcesoFlujoCaja
            ListarFlujoCaja()
            With griProcesoFlujo
                If Activo Then
                    oeProcesoFlujoCaja.Activo = 1
                Else
                    oeProcesoFlujoCaja.Activo = 0
                End If
                oeProcesoFlujoCaja.IdProcesoNegocio = IdProcesoNegocio
                loProcesoFlujoCaja = olProcesoFlujoCaja.Listar(oeProcesoFlujoCaja)
                .DataSource = loProcesoFlujoCaja

                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdProcesoNegocio").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdFlujoCaja").Hidden = True
                .DisplayLayout.Bands(0).Columns("ProcesoNegocio").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("FlujoCaja").Width = 400
                .DisplayLayout.Bands(0).Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If

                For Each oe As e_ProcesoFlujoCaja In loProcesoFlujoCaja
                    For Each Fila As UltraWinGrid.UltraGridRow In griFlujoCaja.Rows
                        If Fila.Cells("Id").Value = oe.IdFlujoCaja And oe.Activo Then
                            Fila.Cells("Selec").Value = True
                            Exit For
                        End If
                    Next
                Next
                griFlujoCaja.UpdateData()

            End With
            griProcesoFlujo.DisplayLayout.Override.RowSelectorNumberStyle = UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
            griProcesoFlujo.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
            griProcesoFlujo.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub LlenarUsuario(ByVal loProcesoFlujoCajaRelacion As List(Of e_ProcesoFlujoCaja))
        With griProcesoFlujo
            .DataSource = loProcesoFlujoCajaRelacion

            .DisplayLayout.Bands(0).Columns("Id").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdProcesoNegocio").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdFlujoCaja").Hidden = True
            '.DisplayLayout.Bands(0).Columns("ProcesoNegocio").Hidden = True
            '.DisplayLayout.Bands(0).Columns("Activo").Hidden = True
            .DisplayLayout.Bands(0).Columns("FlujoCaja").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        End With
    End Sub


#End Region

#Region "Eventos"

    Private Sub frm_ProcesoFlujoCaja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        Tiempo1.Enabled = False
        MostrarTabs(0, ficProcesoNegocio)
        LlenaCombos()
        ListarFlujoCaja()
        cboProcesoNegocio.Focus()
    End Sub

    Private Sub frm_ProcesoFlujoCaja_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ProcesoFlujoCaja_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub griFlujoCaja_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griFlujoCaja.CellChange
        Try
            With griFlujoCaja
                .UpdateData()
                If .ActiveRow.Cells("Selec").Activated Then
                    Dim oeProcesoFlujoCaja As New e_ProcesoFlujoCaja
                    'leOcupacionTrabajador = New List(Of e_OcupacionTrabajador)
                    loProcesoFlujoCajaRelacion = loProcesoFlujoCaja

                    oeProcesoFlujoCaja.IdFlujoCaja = .ActiveRow.Cells("Id").Value

                    If Not loProcesoFlujoCajaRelacion.Contains(oeProcesoFlujoCaja) Then
                        If .ActiveRow.Cells("Selec").Value Then
                            oeProcesoFlujoCaja.IdProcesoNegocio = IdProcesoNegocio
                            oeProcesoFlujoCaja.IdFlujoCaja = .ActiveRow.Cells("Id").Value
                            oeProcesoFlujoCaja.FlujoCaja = .ActiveRow.Cells("Nombre").Value
                            loProcesoFlujoCajaRelacion.Add(oeProcesoFlujoCaja)
                            If griProcesoFlujo.Rows.Count < 1 Then
                                LlenarUsuario(loProcesoFlujoCajaRelacion)
                            End If

                        End If
                    Else
                        oeProcesoFlujoCaja = loProcesoFlujoCajaRelacion.Item(loProcesoFlujoCajaRelacion.IndexOf(oeProcesoFlujoCaja))
                        If .ActiveRow.Cells("Selec").Value Then
                            If oeProcesoFlujoCaja.TipoOperacion = "E" Then
                                oeProcesoFlujoCaja.TipoOperacion = ""
                                For Each fila As UltraWinGrid.UltraGridRow In griProcesoFlujo.Rows
                                    If fila.Cells("IdFlujoCaja").Value = oeProcesoFlujoCaja.IdFlujoCaja Then
                                        fila.Hidden = False
                                        Exit For
                                    End If
                                Next
                            Else
                                Throw New Exception("El Flujo Caja: " & .ActiveRow.Cells("Nombre").Value & " ya esta Asignado")
                            End If

                        Else
                            If oeProcesoFlujoCaja.Id <> "" Then
                                oeProcesoFlujoCaja.TipoOperacion = "E"
                                For Each fila As UltraWinGrid.UltraGridRow In griProcesoFlujo.Rows
                                    If fila.Cells("IdFlujoCaja").Value = oeProcesoFlujoCaja.IdFlujoCaja Then
                                        fila.Hidden = True
                                        Exit For
                                    End If
                                Next
                            Else
                                loProcesoFlujoCajaRelacion.Remove(oeProcesoFlujoCaja)
                            End If

                        End If

                    End If

                End If

            End With
            griProcesoFlujo.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboProcesoNegocio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProcesoNegocio.ValueChanged
        IdProcesoNegocio = cboProcesoNegocio.Value
    End Sub

#End Region

End Class