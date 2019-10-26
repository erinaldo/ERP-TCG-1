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

Public Class frm_ContabilidadConsumoMaterial

#Region "Inicialización del formulario"

    Private Shared Instancia As frm_ContabilidadConsumoMaterial = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Instancia = New frm_ContabilidadConsumoMaterial
            Operacion = "Inicializa"
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Definicion de Variables"

    Dim oeCentro As New e_Centro, olCentro As New l_Centro
    Dim oeAlmacen As New e_Almacen, olAlmacen As New l_Almacen
    Dim oeSubAlmacen As New e_SubAlmacen, olSubAlmacen As New l_SubAlmacen
    Dim oeDetalleInv As New e_DetalleInventario, olDetalleInv As New l_DetalleInventario
    Dim oeRegistroInv As New e_RegistroInventario, olRegistroInv As New l_RegistroInventario
    Dim oeInventarioValorizado As New e_InventarioValorizado
    Dim oeHistorialInventario As New e_HistorialInventario
    Dim oeHistorial As New e_Historial
    Dim oeInventario As New e_Inventario, olInventario As New l_Inventario
    'Dim lstInventario As New List(Of e_Inventario)

    Dim olAsiento As New l_Asiento

    Dim oeDetalleAsignacion As New e_DetalleAsignacion, olDetalleAsignacion As New l_DetalleAsignacion
    Dim lstDetalleAsignacion As New List(Of e_DetalleAsignacion)

    Private muestraBotones As Integer = 1

    Dim dsRegistroInv As New DataSet
    Private oePeriodo As New e_Periodo
    Private _ComboPeriodo As Boolean = False
    Private dtConsumo As DataTable
    Private fecUltimoDia As Date
    Private gs_IdSubAlmacen As String
#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            muestraBotones = 1
            Operacion = "Inicializa"
            Tiempo1.Enabled = True
            If griListaSubAlmacen.Selected.Rows.Count > 0 Then Listar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            muestraBotones = 1
            Mostrar_Botones()
            MostrarTabs(0, ficInventario, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarConsumo() Then
                mensajeEmergente.Confirmacion("Se registro correctamente")
                LimpiaGrid(gridConsumo, UltraDataSource1)
                MyBase.Guardar()
                Operacion = ""
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If gridConsumo.Rows.Count = 0 Then Throw New Exception("No existen registros para exportar.")
            Exportar_Excel(gridConsumo)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub Listar()
        Try
            ValidarCombo(cboMes, "Mes")
            oePeriodo = New e_Periodo
            oePeriodo.TipoOperacion = "C"
            oePeriodo.Ejercicio = Año1.Año
            oePeriodo.Mes = cboMes.Text
            gs_IdSubAlmacen = griListaSubAlmacen.ActiveRow.Cells("Id").Value
            dtConsumo = olAsiento.ListarConsumoMaterial(oePeriodo, gs_IdSubAlmacen)
            gridConsumo.DataSource = dtConsumo
            CalcularTotales(gridConsumo, "Total")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboPeriodo()
        Try
            If _ComboPeriodo Then
                Dim lePeriodo As New List(Of e_Periodo)
                lePeriodo.AddRange(ObtenerPeriodoActivo(Año1.Año))
                LlenaComboMes(cboMes, lePeriodo)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Iniciar()
        Try
            cboCentro.SelectedIndex = -1
            cboAlmacen.SelectedIndex = -1
            ComboCentro()
            Mostrar_Botones()
            _ComboPeriodo = True
            Año1.Año = Date.Now.Year
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ComboCentro()
        Try
            oeCentro.TipoOperacion = ""
            oeCentro.Activo = True
            LlenarComboMaestro(cboCentro, olCentro.Listar(oeCentro), -1)
            cboCentro.Value = ObtenerCentro.Id
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboAlmacen(ByVal idCentro As String)
        Try
            oeAlmacen.TipoOperacion = ""
            oeAlmacen.Activo = True
            oeAlmacen.IdCentro = idCentro
            LlenarComboMaestro(cboAlmacen, olAlmacen.Listar(oeAlmacen), -1)
            If cboAlmacen.Items.Count = 0 Then
                griListaSubAlmacen.DataSource = odSubAlmacen
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LimpiaCombo(ByVal cboCombo As ISL.Controles.Combo)
        If cboCombo.Items.Count > 0 Then
            cboCombo.Items.Clear()
        End If
    End Sub

    Private Sub ListarSubAlmacen()
        Try
            Me.Cursor = Cursors.WaitCursor
            oeSubAlmacen = New e_SubAlmacen
            oeSubAlmacen.IdAlmacen = cboAlmacen.Value
            With griListaSubAlmacen
                oeSubAlmacen.TipoOperacion = "A"
                If Not String.IsNullOrEmpty(oeSubAlmacen.IdAlmacen) Then
                    .DataSource = olSubAlmacen.Listar_SubAlmacen(oeSubAlmacen)
                End If
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

    Private Sub Mostrar_Botones()
        Select Case muestraBotones
            Case 1
                ControlBoton(1, 0, 0, 1, 0, 0, 0, 1, 1)
            Case 2
                ControlBoton(1, 0, 0, 1, 0, 0, 0, 1, 1)
        End Select
    End Sub

    'Valorizado
    Private Sub CabeceraValorizado()
        muestraBotones = 2
        MostrarTabs(1, ficInventario, 1)
        Mostrar_Botones()
    End Sub

    Private Function GuardarConsumo() As Boolean
        Try
            If gridConsumo.Rows.Count = 0 Then Throw New Exception("No existen registros para procesar")
            If dtConsumo.Rows.Count = 0 Then Throw New Exception("No existen registros para procesar")
            Dim olAsiento As New l_Asiento
            Dim TipoC As Double = TipoCambio(Date.Now, True)(0)
            Return olAsiento.GenerarAsientoConsumo(dtConsumo, gs_IdSubAlmacen, TipoC, cboMes.Value, fecUltimoDia, gUsuarioSGI.Id, gs_PrefijoIdSucursal)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Eventos"

    Private Sub cboCentro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCentro.ValueChanged
        LimpiaCombo(cboAlmacen)
        ComboAlmacen(cboCentro.Value)
    End Sub

    Private Sub cboAlmacen_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAlmacen.ValueChanged
        Try
            ListarSubAlmacen()
            Mostrar_Botones()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub frm_Inventario_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Mostrar_Botones()
    End Sub

    Private Sub frm_Inventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_Inventario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_Inventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Iniciar()
    End Sub

    Private Sub griListaSubAlmacen_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaSubAlmacen.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub Año1_DatoCambiado() Handles Año1.DatoCambiado
        ComboPeriodo()
    End Sub

    Private Sub cboMes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMes.ValueChanged
        If cboMes.SelectedIndex <> -1 Then
            Dim oeP As New e_Periodo
            oeP = cboMes.Items(cboMes.SelectedIndex).ListObject
            FecUltimoDia = oeP.FechaFin
        End If
    End Sub

    Private Sub griListaSubAlmacen_DoubleClick(sender As Object, e As EventArgs) Handles griListaSubAlmacen.DoubleClick
        If griListaSubAlmacen.Selected.Rows.Count > 0 Then Listar()
    End Sub

#End Region

End Class
