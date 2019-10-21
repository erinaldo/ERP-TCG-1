'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Infragistics.Win.UltraWinGrid

Public Class frm_MetasCombustible

    Inherits frm_MenuPadre

#Region "Declaración de variables"
    Private Shared instancia As frm_MetasCombustible = Nothing
    Private Shared Operacion As String
    Dim _ingresando_datos As Boolean
    Dim oeMetasCombustible As New e_MetasCombustible, olMetasCombustible As New l_MetasCombustible
    Dim lstMetasCombustible As New List(Of e_MetasCombustible)
    Dim oeMarca As New e_Marca, olMarca As New l_Marca
    Dim oeModelo As New e_Modelo, olModelo As New l_Modelo
#End Region
    
    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_MetasCombustible()

        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If grid_MetasCombustible.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            Operacion = "Nuevo"
            oeMetasCombustible = New e_MetasCombustible
            Inicializar()
            oeMetasCombustible.TipoOperacion = "I"
            oeMetasCombustible.UsuarioCreacion = gUsuarioSGI.Id
            oeMetasCombustible.Activo = True
            MostrarTabs(1, tcMetas, 1)
            cmbMarcaTracto.Focus()
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            MostrarMeta()
            oeMetasCombustible.TipoOperacion = "A"
            cmbMarcaTracto.Focus()
            Operacion = "Editar"
            MyBase.Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarMeta() Then
                MyBase.Guardar()
            Else
                MostrarTabs(0, tcMetas, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeMetasCombustible.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarMeta() Then
                            MostrarTabs(0, tcMetas, 2)
                            _ingresando_datos = False
                            Consultar(True)
                        Else
                            _ingresando_datos = True
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcMetas, 2)
                        _ingresando_datos = False
                        Consultar(True)
                    Case Windows.Forms.DialogResult.Cancel
                        _ingresando_datos = True
                End Select
            Else
                MostrarTabs(0, tcMetas, 2)
                _ingresando_datos = False
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try

            If ValidarGrilla(grid_MetasCombustible, "Metas") Then
                oeMetasCombustible.Id = grid_MetasCombustible.ActiveRow.Cells("Id").Value
                oeMetasCombustible = olMetasCombustible.Obtener(oeMetasCombustible)
                If oeMetasCombustible.Activo Then
                    If MessageBox.Show("¿Esta seguro de eliminar la meta?", _
                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        oeMetasCombustible.TipoOperacion = "E"
                        olMetasCombustible.Eliminar(oeMetasCombustible)
                        Consultar(True)
                    End If
                Else
                    Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                End If
            End If

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

            If grid_MetasCombustible.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grid_MetasCombustible)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        'MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_MetasCombustible_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gf_AsignarEventoSeleccionarTexto(Me)
        gmt_ConfigurarEventoKeyEnter_Tab(Me)
        LlenaComboMarcaTracto()
        LlenaComboMarcaCarreta()
    End Sub

    Private Sub frm_MetasCombustible_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_MetasCombustible_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub btnCrearRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearRuta.Click
        Dim frm As New frm_CrearRuta(Me.txt_Ruta.Text, Me.txt_Pesos.Text)
        frm.StartPosition = FormStartPosition.CenterScreen
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.txt_Ruta.Text = frm.txt_Ruta.Text
            Me.txt_Pesos.Text = frm.txt_Pesos.Text
        End If
    End Sub

    Public Sub LlenaComboMarcaTracto()
        Try
            oeMarca = New e_Marca
            oeMarca.TipoMarca = 1
            oeMarca.Activo = True
            LlenarComboMaestro(cmbMarcaTracto, olMarca.Listar(oeMarca), -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub LlenaComboMarcaCarreta()
        Try
            oeMarca = New e_Marca
            oeMarca.TipoMarca = 1
            oeMarca.Activo = True
            LlenarComboMaestro(cmbMarcaCarreta, olMarca.Listar(oeMarca), -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cmbMarca_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMarcaTracto.ValueChanged
        Try
            oeModelo = New e_Modelo
            oeModelo.IdMarca = cmbMarcaTracto.Value
            oeModelo.Activo = True
            oeMetasCombustible.IdMarcaTracto = oeModelo.IdMarca
            LlenarComboMaestro(cmbModeloTracto, olModelo.Listar(oeModelo), -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ndRendimiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndRendimiento.ValueChanged
        oeMetasCombustible.Rendimiento = ndRendimiento.Value
    End Sub

    Private Sub ndDistancia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndDistancia.ValueChanged
        oeMetasCombustible.Distancia = ndDistancia.Value
    End Sub

    Private Sub txt_Ruta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Ruta.ValueChanged
        oeMetasCombustible.Ruta = Me.txt_Ruta.Text
    End Sub

    Private Sub txt_Pesos_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Pesos.ValueChanged
        oeMetasCombustible.Pesos = Me.txt_Pesos.Text
    End Sub

    Private Sub cmbModeloTracto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbModeloTracto.ValueChanged
        oeMetasCombustible.IdModeloTracto = cmbModeloTracto.Value
    End Sub

    Private Sub cmdModeloCarreta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbModeloCarreta.ValueChanged
        oeMetasCombustible.IdModeloCarreta = cmbModeloCarreta.Value
    End Sub

    Private Sub cmbMarcaCarreta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMarcaCarreta.ValueChanged
        Try
            oeModelo = New e_Modelo
            oeModelo.IdMarca = cmbMarcaCarreta.Value
            oeModelo.Activo = True
            oeMetasCombustible.IdMarcaCarreta = oeModelo.IdMarca
            LlenarComboMaestro(cmbModeloCarreta, olModelo.Listar(oeModelo), -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub grid_MetasCombustible_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grid_MetasCombustible.DoubleClickRow
        Editar()
    End Sub
#End Region

#Region "Metodos y Funciones"
    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeMetasCombustible = New e_MetasCombustible

            oeMetasCombustible.TipoOperacion = ""
            oeMetasCombustible.Activo = Activo
            'lstMetasCombustible.AddRange(olMetasCombustible.Listar(oeMetasCombustible))
            grid_MetasCombustible.DataSource = olMetasCombustible.Listar(oeMetasCombustible)
            If grid_MetasCombustible.Rows.Count > 0 Then
                grid_MetasCombustible.Focus()
                grid_MetasCombustible.Rows.Item(0).Selected = True
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        grid_MetasCombustible.Focus()
    End Sub

    Private Sub Inicializar()
        txtCodigo.Text = String.Empty
        txt_Ruta.Text = String.Empty
        txt_Pesos.Text = String.Empty
        cmbMarcaTracto.SelectedIndex = -1
        cmbModeloTracto.SelectedIndex = -1
        cmbMarcaCarreta.SelectedIndex = -1
        cmbModeloCarreta.SelectedIndex = -1
        ndRendimiento.Value = Nothing
        ndDistancia.Value = Nothing
    End Sub

    Private Sub MostrarMeta()
        Try
            If grid_MetasCombustible.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeMetasCombustible.Id = grid_MetasCombustible.ActiveRow.Cells("Id").Value.ToString
                oeMetasCombustible = olMetasCombustible.Obtener(oeMetasCombustible)
                txtCodigo.Text = oeMetasCombustible.Codigo
                cmbMarcaTracto.Value = oeMetasCombustible.IdMarcaTracto
                cmbModeloTracto.Value = oeMetasCombustible.IdModeloTracto
                cmbMarcaCarreta.Value = oeMetasCombustible.IdMarcaCarreta
                cmbModeloCarreta.Value = oeMetasCombustible.IdModeloCarreta
                ndRendimiento.Value = oeMetasCombustible.Rendimiento
                ndDistancia.Value = oeMetasCombustible.Distancia
                txt_Ruta.Text = oeMetasCombustible.Ruta
                txt_Pesos.Text = oeMetasCombustible.Pesos
                MostrarTabs(1, tcMetas, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarMeta() As Boolean
        Try
            oeMetasCombustible.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olMetasCombustible.Guardar(oeMetasCombustible) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, tcMetas, 2)
                Consultar(True)
                grid_MetasCombustible.Focus()
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

    Private Sub mnuDuplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDuplicar.Click
        DuplicarMeta()
    End Sub

    Private Sub DuplicarMeta()
        Try
            If grid_MetasCombustible.Rows.Count > 0 Then
                With grid_MetasCombustible.ActiveRow
                    Me.txt_Ruta.Text = .Cells("Ruta").Value
                    Me.txt_Pesos.Text = .Cells("Pesos").Value
                    ndDistancia.Value = .Cells("Distancia").Value
                    ndRendimiento.Value = .Cells("Rendimiento").Value
                    cmbMarcaTracto.Value = .Cells("IdMarcaTracto").Value
                    cmbModeloTracto.Value = .Cells("IdModeloTracto").Value
                    cmbMarcaCarreta.Value = .Cells("IdMarcaCarreta").Value
                    cmbModeloCarreta.Value = .Cells("IdModeloCarreta").Value
                    LlenaMeta(.Index + 1)
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub LlenaMeta(ByVal pos As Integer)
        oeMetasCombustible = New e_MetasCombustible
        oeMetasCombustible.TipoOperacion = "I"
        oeMetasCombustible.Ruta = Me.txt_Ruta.Text
        oeMetasCombustible.Pesos = Me.txt_Pesos.Text
        oeMetasCombustible.Distancia = ndDistancia.Value
        oeMetasCombustible.Rendimiento = ndRendimiento.Value
        oeMetasCombustible.IdModeloTracto = cmbModeloTracto.Value
        oeMetasCombustible.IdModeloCarreta = cmbModeloCarreta.Value
        lstMetasCombustible.Insert(pos, oeMetasCombustible)
        grid_MetasCombustible.DataBind()
    End Sub

    Sub LlenarMetasDesdeCombustible(ByVal oeMetas As e_MetasCombustible)
        Try
            Inicializar()
            txt_Ruta.Value = oeMetas.Ruta
            txt_Pesos.Value = oeMetas.Pesos
            ndRendimiento.Value = oeMetas.Rendimiento
            ndDistancia.Value = oeMetas.Distancia
            cmbMarcaTracto.Value = oeMetas.IdMarcaTracto
            cmbModeloTracto.Value = oeMetas.IdModeloTracto
            cmbMarcaCarreta.Value = oeMetas.IdMarcaCarreta
            cmbModeloCarreta.Value = oeMetas.IdModeloCarreta
        Catch ex As Exception
            mensajeEmergente.Problema("No se pudo llenar los datos", True)
        End Try
    End Sub

End Class