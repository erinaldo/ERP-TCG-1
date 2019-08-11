Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports ISL.Controles
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frm_Accidente
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializar el formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_Accidente = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_Accidente()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Declaración de variables"

    Dim olAccidente As New l_Accidente

    'Declaración de instancia para el control de modificaciones de la entidad en el formulario
    Private WithEvents oeAccidente As New e_Accidente

    'Variable para controlar el estado de los registros mostrados (Activo - Inactivo)
    Dim Estado As String

    'Variable para controlar el estado de la botonera principal del sistema
    Dim _ingresando_datos As Boolean = False

    Private lstTrabajadores As New List(Of e_Trabajador)
    'Para Lista Trabajadores
    Private oeTrabajador As New e_Trabajador
    Private olTrabajador As New l_Trabajador

    Dim ds_UA_MA As DataSet

    'Variables para almacenar información de las trabajadores accidentados
    Private olAccidentePersona As l_AccidentePersona
    Private oeAccidentePersona As e_AccidentePersona

    'Variables para almacenar información de los vehículos accidentados
    Private olAccidenteVehiculo As l_AccidenteVehiculo
    Private oeAccidenteVehiculo As e_AccidenteVehiculo

    'Variables para almacenar infromacion del material
    Private oeAccidenteMaterial As e_AccidenteMaterial
    Private olAccidenteMaterial As l_AccidenteMaterial

    'Variables para almacenar infromacion de la carga
    Private oeAccidenteCarga As e_AccidenteCarga
    Private olAccidenteCarga As l_AccidenteCarga

    Private oeAccidenteFoto As e_AccidenteFoto
    Private olAccidenteFoto As l_AccidenteFoto

    Private oeConceptosGenerales As e_ConceptosGenerales
    Private olConceptosGenerales As l_ConceptosGenerales
    Private loConGen As List(Of e_ConceptosGenerales)

    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Dim lstTrabajadoresAccidentados As List(Of e_AccidentePersona)
    Dim lstVehiculosAccidentados As List(Of e_AccidenteVehiculo)
    Dim lstMaterialesAccidentados As List(Of e_AccidenteMaterial)
    Dim lstCargaAccidentados As List(Of e_AccidenteCarga)
    Dim lstFotoAccidentados As List(Of e_AccidenteFoto)

    Private oeVehiculo As New e_Vehiculo
    Private olVehiculo As New l_Vehiculo
    Dim lstVehiculos As New List(Of e_Vehiculo)

    Private oeMaterial As New e_Material
    Private olMaterial As New l_Material
    Dim lstMaterial As New List(Of e_Material)
    Dim lstCarga As New List(Of e_Material)


#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griListaAccidente.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            oeAccidente.TipoOperacion = "I"
            MostrarTabs(1, tcAccidente, 1)
            Inicializar()
            Fecha1.Focus()
            Operacion = "Nuevo"
            MyBase.Nuevo()
            oeAccidente.Modificado = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try 
    End Sub

    Public Overrides Sub Editar()
        Try
            MostrarAccidente()
            oeAccidente.TipoOperacion = "A"
            Fecha1.Focus()
            Operacion = "Editar"
            MyBase.Editar()
            oeAccidente.Modificado = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try   
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarAccidente() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcAccidente, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeAccidente.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarAccidente() Then
                            MostrarTabs(0, tcAccidente, 2)
                            _ingresando_datos = False
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, tcAccidente, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcAccidente, 2)
                        _ingresando_datos = False
                        MyBase.Consultar(True)
                End Select
            Else
                MostrarTabs(0, tcAccidente, 2)
                _ingresando_datos = False
                MyBase.Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griListaAccidente
                If ValidarGrilla(griListaAccidente, "Accidente") Then
                    oeAccidente.Id = .ActiveRow.Cells("ID").Value
                    oeAccidente = olAccidente.Obtener(oeAccidente)
                    If oeAccidente.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar el Accidente: " & _
                                 .ActiveRow.Cells("Nombre").Value.ToString.Trim & "?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeAccidente.TipoOperacion = "E"
                            olAccidente.Eliminar(oeAccidente)
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

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
        'Dim frm As frm_ReporteBasico = frm_ReporteAccidente
        'frm.MdiParent = frm_Menu
        'frm.Show()
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griListaAccidente.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griListaAccidente)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Accidente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        MostrarTabs(0, tcAccidente)
        ListarTrabajadores()
        ListarEquipos()
        CargarTipoAccidente()
        griListaAccidente.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        griListaAccidente.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        Tiempo1.Enabled = False
        InicializaTiempo()
    End Sub

    Private Sub frm_Accidente_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

    End Sub

    Private Sub oeAccidente_DatoCambiado() Handles oeAccidente.DatoCambiado
        oeAccidente.Modificado = True
    End Sub

    Private Sub frm_Accidente_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub
    
    Private Sub frm_Accidente_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case Operacion
            Case "Nuevo"
                Me.Activate()
                Me.Cancelar()
            Case "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub griListaAccidente_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaAccidente.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griListaAccidente_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaAccidente.DoubleClick
        If griListaAccidente.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griListaAccidente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griListaAccidente.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub griListaAccidente_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griListaAccidente.InitializeLayout
        agrTotalAccidentes.Text = "Total de Accidentes: " & e.Layout.Rows.Count & Estado
    End Sub

    Private Sub verActivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        TeclaPulsada(e)
    End Sub

    Private Sub Lugar_DatoCambiado(ByVal Id As String) Handles Lugar.DatoCambiado
        Try
            oeAccidente.Lugar = Id
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Fecha1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fecha1.ValueChanged
        oeAccidente.Fecha = Fecha1.Value
    End Sub

    Private Sub txtDetalle_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDetalle.ValueChanged
        oeAccidente.Detalle = txtDetalle.Text
    End Sub

    Private Sub griTrabajadores_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griTrabajadores.DoubleClick
        Try
            AsignarTrabajadores()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub mnDetalle_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles mnDetalle.ToolClick
        Try
            Select Case e.Tool.Key
                Case "Agregar"
                    AgregarDetalle()
                Case "Quitar"
                    EliminarDetalle()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griTrabajadores_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs)
        Try
            griTrabajadores.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griEquipos_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griEquipos.CellChange
        Try
            griEquipos.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griListaMateriales_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaMateriales.CellChange
        Try
            griListaMateriales.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub btnListarMateriales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarMateriales.Click
        ListarMateriales(griListaMateriales, txtBuscarMateriales.Text, 0)
    End Sub

    Private Sub txtBuscarMateriales_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscarMateriales.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnListarMateriales.PerformClick()
        End If
    End Sub

    Private Sub griListaMaterialesAccidentados_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaMaterialesAccidentados.CellChange
        Try
            griListaMaterialesAccidentados.UpdateData()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griTrabajadoresAccidentados_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griTrabajadoresAccidentados.CellChange
        Try
            griTrabajadoresAccidentados.UpdateData()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griVehiculosAccidentados_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griVehiculosAccidentados.CellChange
        Try
            griVehiculosAccidentados.UpdateData()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarCarga.Click
        ListarMateriales(griListaCarga, txtBuscarCarga.Text, 1)
    End Sub

    Private Sub txtBuscarCarga_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscarCarga.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnListarCarga.PerformClick()
        End If
    End Sub

    Private Sub griListaCarga_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaCarga.CellChange
        Try
            griListaCarga.UpdateData()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griCargaAccidentada_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griCargaAccidentada.CellChange
        Try
            griCargaAccidentada.UpdateData()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub FichaDatosParaAsignar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles FichaDatosParaAsignar.Click
        Try
            Select Case FichaDatosParaAsignar.SelectedTab.Index
                Case 0
                    FichaParticipantes.Tabs(0).Selected = True
                Case 1
                    FichaParticipantes.Tabs(1).Selected = True
                Case 2
                    FichaParticipantes.Tabs(2).Selected = True
                Case 3
                    FichaParticipantes.Tabs(3).Selected = True
                Case 4
                    FichaParticipantes.Tabs(4).Selected = True
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub FichaParticipantes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles FichaParticipantes.Click
        Try
            Select Case FichaParticipantes.SelectedTab.Index
                Case 0
                    FichaDatosParaAsignar.Tabs(0).Selected = True
                Case 1
                    FichaDatosParaAsignar.Tabs(1).Selected = True
                Case 2
                    FichaDatosParaAsignar.Tabs(2).Selected = True
                Case 3
                    FichaDatosParaAsignar.Tabs(3).Selected = True
                Case 4
                    FichaDatosParaAsignar.Tabs(4).Selected = True
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Btn_imagen_Click(sender As Object, e As EventArgs) Handles Btn_imagen.Click
        Dim ofd_Imagen As New OpenFileDialog
        With ofd_Imagen
            .Filter = "Imágenes JPG (*.jpg)|*.jpg"
            .FilterIndex = 1
            .Title = "Abrir imagen ..."
        End With
        If ofd_Imagen.ShowDialog = Windows.Forms.DialogResult.OK Then
            oeAccidenteFoto = New e_AccidenteFoto
            oeAccidenteFoto.TipoOperacion = "I"
            oeAccidenteFoto.FechaFoto = Date.Now
            oeAccidenteFoto.Descripcion = String.Empty
            oeAccidenteFoto.Foto = Image.FromFile(ofd_Imagen.FileName)
            lstFotoAccidentados.Add(oeAccidenteFoto)
        End If
        ofd_Imagen.Dispose()
        ofd_Imagen = Nothing
        griFotos.DataBind()
    End Sub

    Private Sub griFotos_CellChange(sender As Object, e As CellEventArgs) Handles griFotos.CellChange
        griFotos.UpdateData()
    End Sub

    Private Sub griFotos_Click(sender As Object, e As EventArgs) Handles griFotos.Click
        upb_ImgAuxiliar.Image = griFotos.ActiveRow.Cells("Foto").Value
    End Sub

#End Region

#Region "Métodos"
    
    Private Sub Inicializar()
        Fecha1.Value = Date.Now
        fecHora.Value = Date.Parse("01/01/1901").Date
        txtDetalle.Text = String.Empty
        cboConcepto.SelectedIndex = -1
        FichaParticipantes.Tabs(0).Selected = True
        FichaDatosParaAsignar.Tabs(0).Selected = True
        upb_ImgAuxiliar.Image = Nothing
        lstTrabajadoresAccidentados = New List(Of e_AccidentePersona)
        lstMaterialesAccidentados = New List(Of e_AccidenteMaterial)
        lstCargaAccidentados = New List(Of e_AccidenteCarga)
        lstVehiculosAccidentados = New List(Of e_AccidenteVehiculo)
        lstFotoAccidentados = New List(Of e_AccidenteFoto)
        griTrabajadoresAccidentados.DataSource = lstTrabajadoresAccidentados
        griVehiculosAccidentados.DataSource = lstVehiculosAccidentados
        griListaMaterialesAccidentados.DataSource = lstMaterialesAccidentados
        griCargaAccidentada.DataSource = lstCargaAccidentados
        griFotos.DataSource = lstFotoAccidentados
        AsociarMenu()
    End Sub

    Private Function GuardarAccidente() As Boolean
        Try
            oeAccidente.Hora = fecHora.Value
            oeAccidente.IdTipoAccidente = cboConcepto.Value
            oeAccidente.loCargaAccidentados = lstCargaAccidentados
            oeAccidente.loMaterialesAccidentados = lstMaterialesAccidentados
            oeAccidente.loTrabajadoresAccidentados = lstTrabajadoresAccidentados
            oeAccidente.loEquiposAccidentados = lstVehiculosAccidentados
            oeAccidente.loFotosAccidentados = lstFotoAccidentados
            If olAccidente.Guardar(oeAccidente) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, tcAccidente, 2)
                Consultar(True)
                griListaAccidente.Focus()
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("Fecha") Then Fecha1.Focus()
        If excepcion.Contains("Detalle") Then txtDetalle.Focus()
    End Sub

    Private Sub MostrarAccidente()
        Try
            If griListaAccidente.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeAccidente.Id = griListaAccidente.ActiveRow.Cells("Id").Value.ToString
                oeAccidente = olAccidente.Obtener(oeAccidente)
                Fecha1.Value = oeAccidente.Fecha
                fecHora.Value = oeAccidente.Hora
                cboConcepto.Value = oeAccidente.IdTipoAccidente.Trim
                Lugar.Seleccionar(oeAccidente.Lugar)
                txtDetalle.Text = oeAccidente.Detalle
                MostrarTabs(1, tcAccidente, 1)
                MyBase.Editar()

                l_FuncionesGenerales.ValidarCampoNoNulo(oeAccidente.Id, "No se ha seleccionado aún el accidente")

                'Cargando datos de personas vinculadas al accidente
                oeAccidentePersona = New e_AccidentePersona
                olAccidentePersona = New l_AccidentePersona
                oeAccidentePersona.IdAccidente = oeAccidente.Id
                oeAccidentePersona.TipoOperacion = "1"
                lstTrabajadoresAccidentados = olAccidentePersona.Listar(oeAccidentePersona)
                griTrabajadoresAccidentados.DataSource = lstTrabajadoresAccidentados

                'Cargando datos de vehículos vinculados al accidente
                oeAccidenteVehiculo = New e_AccidenteVehiculo
                olAccidenteVehiculo = New l_AccidenteVehiculo
                oeAccidenteVehiculo.IdAccidente = oeAccidente.Id
                oeAccidenteVehiculo.TipoOperacion = "1"
                lstVehiculosAccidentados = olAccidenteVehiculo.Listar(oeAccidenteVehiculo)
                griVehiculosAccidentados.DataSource = lstVehiculosAccidentados

                'cargando datos de materiales
                oeAccidenteMaterial = New e_AccidenteMaterial
                olAccidenteMaterial = New l_AccidenteMaterial
                oeAccidenteMaterial.IdAccidente = oeAccidente.Id
                oeAccidenteMaterial.TipoOperacion = "1"
                lstMaterialesAccidentados = olAccidenteMaterial.Listar(oeAccidenteMaterial)
                griListaMaterialesAccidentados.DataSource = lstMaterialesAccidentados

                'cargando datos de carga
                oeAccidenteCarga = New e_AccidenteCarga
                olAccidenteCarga = New l_AccidenteCarga
                oeAccidenteCarga.IdAccidente = oeAccidente.Id
                oeAccidenteCarga.TipoOperacion = "1"
                lstCargaAccidentados = olAccidenteCarga.Listar(oeAccidenteCarga)
                griCargaAccidentada.DataSource = lstCargaAccidentados

                'cargando datos de fotos
                oeAccidenteFoto = New e_AccidenteFoto
                olAccidenteFoto = New l_AccidenteFoto
                oeAccidenteFoto.IdAccidente = oeAccidente.Id
                lstFotoAccidentados = olAccidenteFoto.Listar(oeAccidenteFoto)
                griFotos.DataSource = lstFotoAccidentados

            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Estado = IIf(Activo, " Activo", " Inactivo")
            Me.Cursor = Cursors.WaitCursor
            oeAccidente = New e_Accidente
            With griListaAccidente
                oeAccidente.Activo = Activo

                .DataSource = olAccidente.Listar(oeAccidente).OrderBy(Function(i) i.Fecha).ToList

                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdTipoAccidente").Hidden = True
                .DisplayLayout.Bands(0).Columns("Lugar").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True

                'Especificar el ancho de las columnas que se muestran
                .DisplayLayout.Bands(0).Columns("TipoAccidente").Width = 200
                .DisplayLayout.Bands(0).Columns("NombreLugar").Width = 300
                .DisplayLayout.Bands(0).Columns("Detalle").Width = 500
                .DisplayLayout.Bands(0).Columns("Hora").Style = ColumnStyle.Time

                'Cofigura la grilla para que se seleccione la fila completa al hacer click en algun lado
                .DisplayLayout.Bands(0).Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
                .DisplayLayout.Bands(0).Override.FilterUIProvider = Filtro1
                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ListarEquipos()
        oeVehiculo = New e_Vehiculo
        oeVehiculo.TipoOperacion = "A"
        oeVehiculo.Motriz = 1
        oeVehiculo.Activo = True
        lstVehiculos = olVehiculo.Listar(oeVehiculo)
        griEquipos.DataSource = lstVehiculos
    End Sub

    Private Sub CargarTipoAccidente()
        oeConceptosGenerales = New e_ConceptosGenerales
        olConceptosGenerales = New l_ConceptosGenerales
        loConGen = New List(Of e_ConceptosGenerales)
        oeConceptosGenerales.IdProcesoNegocio = "1CH000000034"
        loConGen.AddRange(olConceptosGenerales.Listar(oeConceptosGenerales).OrderBy(Function(i) i.Nombre).ToList)
        LlenarCombo(cboConcepto, "Nombre", loConGen, -1)
    End Sub

    Private Sub ListarTrabajadores()
        Try
            Me.Cursor = Cursors.WaitCursor
            With griTrabajadores
                .ResetDisplayLayout()
                Dim oeTrab As New e_Trabajador
                Dim olTrab As New l_Trabajador
                oeTrab.Activo = True
                lstTrabajadores = olTrab.Listar(oeTrab)
                Dim _leTrab = From le In lstTrabajadores _
                              Select le.Id, le.oePersona.Dni, le.oePersona.NombreCompleto, Area = le.oeArea.Nombre, Cargo = le.oeCargo.Nombre

                .DataSource = _leTrab.ToList

                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Id").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True

                .DisplayLayout.Bands(0).Columns("Dni").Width = 70
                .DisplayLayout.Bands(0).Columns("NombreCompleto").Width = 250
                .DisplayLayout.Bands(0).Columns("Area").Width = 200
                .DisplayLayout.Bands(0).Columns("Cargo").Width = 150

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                '.DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect

                .DisplayLayout.Override.FilterUIProvider = Filtro1

                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Sub AgregarDetalle()
        Try
            Select Case FichaDatosParaAsignar.SelectedTab.Index
                Case 0
                    Me.FichaParticipantes.Tabs(0).Selected = True
                    AsignarTrabajadores()
                Case 1
                    Me.FichaParticipantes.Tabs(1).Selected = True
                    AsignarVehiculos()
                Case 2
                    Me.FichaParticipantes.Tabs(2).Selected = True
                    AsignarMateriales()
                Case 3
                    Me.FichaParticipantes.Tabs(3).Selected = True
                    AsignarCarga()
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AsignarTrabajadores()
        Try
            If griTrabajadores.Selected.Rows.Count > 0 Then
                Dim idTrabajador As String = ""
                idTrabajador = griTrabajadores.ActiveRow.Cells("Id").Value
                For Each acctrab As e_AccidentePersona In lstTrabajadoresAccidentados
                    If idTrabajador = acctrab.IdTrabajador Then
                        Throw New Exception("Trabajador ya Agregado al Detalle")
                    End If
                Next
                oeAccidentePersona = New e_AccidentePersona
                With oeAccidentePersona
                    .IdTrabajador = griTrabajadores.ActiveRow.Cells("Id").Value
                    .NombreCompleto = griTrabajadores.ActiveRow.Cells("NombreCompleto").Value
                    .Area = griTrabajadores.ActiveRow.Cells("Area").Value
                    lstTrabajadoresAccidentados.Add(oeAccidentePersona)
                End With
                griTrabajadoresAccidentados.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AsignarVehiculos()
        Try
            For Each vehiculo As e_Vehiculo In lstVehiculos
                If vehiculo.Seleccion Then
                    oeAccidenteVehiculo = New e_AccidenteVehiculo()
                    oeAccidenteVehiculo.TipoOperacion = "I"
                    oeAccidenteVehiculo.IdVehiculo = vehiculo.Id
                    oeAccidenteVehiculo.Placa = vehiculo.Placa
                    lstVehiculosAccidentados.Add(oeAccidenteVehiculo)
                End If
            Next
            griVehiculosAccidentados.DataBind()
            lstVehiculos.RemoveAll(AddressOf eliminaVehiculos)
            griEquipos.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AsignarMateriales()
        Try
            For Each material As e_Material In lstMaterial
                If material.Seleccion Then
                    oeAccidenteMaterial = New e_AccidenteMaterial()
                    oeAccidenteMaterial.TipoOperacion = "I"
                    oeAccidenteMaterial.IdMaterial = material.Id
                    oeAccidenteMaterial.Material = material.Nombre
                    lstMaterialesAccidentados.Add(oeAccidenteMaterial)
                End If
            Next
            griListaMaterialesAccidentados.DataBind()
            lstMaterial.RemoveAll(AddressOf eliminaMateriales)
            griListaMateriales.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub AsignarCarga()
        Try
            For Each material As e_Material In lstCarga
                If material.Seleccion Then
                    oeAccidenteCarga = New e_AccidenteCarga()
                    oeAccidenteCarga.TipoOperacion = "I"
                    oeAccidenteCarga.IdMaterial = material.Id
                    oeAccidenteCarga.Material = material.Nombre
                    lstCargaAccidentados.Add(oeAccidenteCarga)
                End If
            Next
            griCargaAccidentada.DataBind()
            lstCarga.RemoveAll(AddressOf eliminaCarga)
            griListaCarga.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function eliminaTrabajadores(ByVal oeTrab As e_Trabajador) As Boolean
        Return oeTrab.Seleccion
    End Function

    Private Function eliminaVehiculos(ByVal oeVeh As e_Vehiculo) As Boolean
        Return oeVeh.Seleccion
    End Function

    Private Function eliminaMateriales(ByVal oeMat As e_Material) As Boolean
        Return oeMat.Seleccion
    End Function

    Private Function eliminaCarga(ByVal oeCar As e_Material) As Boolean
        Return oeCar.Seleccion
    End Function

    Public Sub DescheckearlstTrabajadores(ByVal oeItem As e_Trabajador)
        If oeItem.Seleccion Then oeItem.Seleccion = False
    End Sub

    Sub EliminarDetalle()
        Try
            Select Case FichaParticipantes.SelectedTab.Index
                Case 0
                    EliminarTrabajadores()
                Case 1
                    EliminarVehiculos()
                Case 2
                    EliminarMateriales()
                Case 3
                    EliminarCarga()
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EliminarTrabajadores()
        lstTrabajadoresAccidentados.RemoveAll(AddressOf verificarSeleccionadoTrabajador)
        griTrabajadores.DataBind()
        griTrabajadoresAccidentados.DataBind()
    End Sub

    Private Sub EliminarVehiculos()
        lstVehiculosAccidentados.RemoveAll(AddressOf verificarSeleccionadoEquipo)
        griEquipos.DataBind()
        griVehiculosAccidentados.DataBind()
    End Sub

    Private Sub EliminarMateriales()
        lstMaterialesAccidentados.RemoveAll(AddressOf verificarSeleccionadoMaterial)
        griListaMateriales.DataBind()
        griListaMaterialesAccidentados.DataBind()
    End Sub

    Private Sub EliminarCarga()
        lstCargaAccidentados.RemoveAll(AddressOf verificarSeleccionadoCarga)
        griListaCarga.DataBind()
        griCargaAccidentada.DataBind()
    End Sub

    Private Sub DetalleMenu()
        fcEAT.Tabs(0).Enabled = IIf(ds_UA_MA.Tables(0).Rows.Count = 0, True, False)
        fcEAT.Tabs(1).Enabled = IIf(ds_UA_MA.Tables(0).Rows.Count = 0, True, False)
        fcEAT.Tabs(2).Enabled = IIf(ds_UA_MA.Tables(0).Rows.Count = 0, True, False)
        fcEAT.Tabs(3).Enabled = IIf(ds_UA_MA.Tables(0).Rows.Count = 0, False, True)
        mnDetalle.Tools("Agregar").SharedProps.Visible = IIf(ds_UA_MA.Tables(0).Rows.Count = 1, True, False)
        If ds_UA_MA.Tables(0).Rows.Count = 0 Then
            fcEAT.Tabs(0).Selected = True
        Else
            fcEAT.Tabs(3).Selected = True
        End If
    End Sub

    Private Sub AgregarDetalle(ByVal lsId As String)
        Try
            Select Case fcEAT.SelectedTab.Index
                Case 0
                    'AgregarEquipo(lsId)
                Case 1
                    'AgregarArea(lsId)
                Case 2
                    AgregarTrabajador(lsId)
            End Select
            DetalleMenu()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarTrabajador(ByVal lsId As String)
        Try
            Dim _cant As Integer = 0
            For Each oeTrabajador As e_Trabajador In lstTrabajadores.Where(Function(item) item.Id = lsId)
                Dim row As DataRow
                row = ds_UA_MA.Tables(0).NewRow
                row("IdOrdenAsignacion") = ""
                row("Seleccion") = False
                row("IdUnidadAsignacion") = oeTrabajador.Id
                row("IndUnidadAsignacion") = "T"
                row("UnidadAsignada") = oeTrabajador.oePersona.NombreCompleto
                row("TipoUnidad") = oeTrabajador.oeCargo.Nombre
                ds_UA_MA.Tables(0).Rows.Add(row)
                ds_UA_MA.Tables(0).AcceptChanges()
                _cant += 1
            Next
            ds_UA_MA.AcceptChanges()
            If _cant > 0 Then
                oeAccidente.Modificado = True
                'grid_UA_Material.DataBind()
                'griArea.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function verificarSeleccionadoTrabajador(ByVal oeAccTrab As e_AccidentePersona) As Boolean
        Try
            If Not String.IsNullOrEmpty(oeAccTrab.IdTrabajador) AndAlso oeAccTrab.Seleccion Then
                Dim oeTrabajador As New e_Trabajador
                oeTrabajador.TipoOperacion = ""
                oeTrabajador.Id = oeAccTrab.IdTrabajador
                oeTrabajador.Activo = True
                oeTrabajador = olTrabajador.Obtener(oeTrabajador)
                lstTrabajadores.Add(oeTrabajador)
            End If
            Return oeAccTrab.Seleccion
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Function verificarSeleccionadoEquipo(ByVal oeAccEqu As e_AccidenteVehiculo) As Boolean
        Try
            If Not String.IsNullOrEmpty(oeAccEqu.IdVehiculo) AndAlso oeAccEqu.Seleccion Then
                Dim oeVehiculo As New e_Vehiculo
                oeVehiculo.TipoOperacion = "A"
                oeVehiculo.Id = oeAccEqu.IdVehiculo
                oeVehiculo.Activo = True
                oeVehiculo = olVehiculo.Obtener(oeVehiculo)
                lstVehiculos.Add(oeVehiculo)
            End If
            Return oeAccEqu.Seleccion
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Function verificarSeleccionadoMaterial(ByVal oeAccMat As e_AccidenteMaterial) As Boolean
        Try
            If Not String.IsNullOrEmpty(oeAccMat.IdMaterial) AndAlso oeAccMat.Seleccion Then
                Dim oeMaterial As New e_Material
                oeMaterial.TipoOperacion = "5"
                oeMaterial.Id = oeAccMat.IdMaterial
                oeMaterial.Activo = True
                oeMaterial = olMaterial.ObtenerMaterialSegunAlmacen(oeMaterial)
                lstMaterial.Add(oeMaterial)
            End If
            Return oeAccMat.Seleccion
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Function verificarSeleccionadoCarga(ByVal oeAccCar As e_AccidenteCarga) As Boolean
        Try
            If Not String.IsNullOrEmpty(oeAccCar.IdMaterial) AndAlso oeAccCar.Seleccion Then
                Dim oeMaterial As New e_Material
                oeMaterial.TipoOperacion = "G"
                oeMaterial.Id = oeAccCar.IdMaterial
                oeMaterial.Activo = True
                oeMaterial = olMaterial.Obtener(oeMaterial)
                lstCarga.Add(oeMaterial)
            End If
            Return oeAccCar.Seleccion
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Sub ListarMateriales(ByVal grilla As ISL.Controles.Grilla, ByVal Material As String, ByVal tipo As String)
        oeMaterial = New e_Material
        oeMaterial.Activo = True

        oeMaterial.Nombre = Material
        If tipo = 0 Then
            oeMaterial.TipoOperacion = "G"
            lstMaterial = olMaterial.Listar(oeMaterial)
            grilla.DataSource = lstMaterial
        Else
            oeMaterial.TipoOperacion = "R"
            lstCarga = olMaterial.Listar(oeMaterial)
            grilla.DataSource = lstCarga
        End If
        grilla.DisplayLayout.Bands(0).Columns("IndDivisible").Hidden = True
        grilla.DisplayLayout.Bands(0).Columns("SubAlmacen").Hidden = True
    End Sub

#End Region

#Region "Menú contextual"

    ''' <summary>
    ''' Método que permite asociar el menú contextual del formulario con la grilla principal
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AsociarMenu()
        griListaAccidente.ContextMenuStrip = MenuContextual1
    End Sub

    ''' <summary>
    ''' Evento que permite especificar que rutina se va a ejecutar al seleccionar la opción Nuevo del menú contextual
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertarToolStripMenuItem.Click
        Nuevo()
    End Sub

    ''' <summary>
    ''' Evento que permite especificar que rutina se va a ejecutar al seleccionar la opción Actualizar del menú contextual
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        Editar()
    End Sub

    ''' <summary>
    ''' Evento que permite especificar que rutina se va a ejecutar al seleccionar la opción Eliminar del menú contextual
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
    End Sub

    ''' <summary>
    ''' Configuración de las opciones que va a mostrar el menú contextual
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("InsertarToolStripMenuItem").Visible = True
        If griListaAccidente.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("EditarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("EditarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    ''' <summary>
    ''' Método que inicializa el control de tiempo al mover el mouse sobre el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frm_Accidente_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    ''' <summary>
    ''' Método que actualiza automáticamente la grilla al mover el mouse sobre ella después de un tiempo de inactividad (por defecto 10 segundos)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    ''' 
    Private Sub griListaAccidente_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griListaAccidente.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

End Class