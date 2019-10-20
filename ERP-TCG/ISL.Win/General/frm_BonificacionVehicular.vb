'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win.UltraWinGrid


Public Class frm_BonificacionVehicular
    Inherits frm_MenuPadre


#Region "Inicializar el formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_BonificacionVehicular = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_BonificacionVehicular()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Declaración de Variables"
    Dim _ingresando_datos As Boolean
    Dim oeVehiculo As New e_Vehiculo
    Dim olVehiculo As New l_Vehiculo
    Dim lstVehiculo As New List(Of e_Vehiculo)
    Dim oeDocumentoVehicular As New e_DocumentoVehicular
    Dim olDocumentoVehicular As New l_DocumentoVehicular
    Dim oeBonificacionVehiculo As New e_BonificacionVehiculo
    Dim olBonificacionVehiculo As New l_BonificacionVehiculo
    Dim oeDetalleDocumento As New e_DetalleDocumentoVehiculo
    Dim olDetalleDocumento As New l_DetalleDocumentoVehiculo
    Dim IdTipoDocumento As String = "1CH000000053"
    Dim IdEmpresaCertificadora As String = "1CH000005057"

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If grid_Bonos.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Operacion = "Nuevo"
        oeDocumentoVehicular = New e_DocumentoVehicular
        oeDocumentoVehicular.TipoOperacion = "I"
        oeDocumentoVehicular.UsuarioCreacion = gUsuarioSGI.Id
        Inicializar()
        MostrarTabs(1, tcBonificacion, 1)
        txtResolucion.Focus()
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        Try
            Operacion = "Editar"
            oeDocumentoVehicular = New e_DocumentoVehicular
            If grid_Bonos.ActiveRow.Band.Index = 0 Then
                EditarBonificacion()
                MostrarTabs(1, tcBonificacion, 1)
                txtResolucion.Focus()
                Operacion = "Editar"
                MyBase.Editar()
            Else
                Throw New Exception("Seleccione un Registro válido")
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarBonificacion() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcBonificacion, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            MostrarTabs(0, tcBonificacion, 2)
            _ingresando_datos = False
            Consultar(True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If grid_Bonos.ActiveRow.Band.Index = 0 Then

                If MessageBox.Show("Esta seguro de eliminar la bonificación vehicular N°: " & _
                grid_Bonos.ActiveRow.Cells("Numero").Value.ToString.Trim & "?", _
                "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    oeDocumentoVehicular.TipoOperacion = "E"
                    oeDocumentoVehicular.Id = grid_Bonos.ActiveRow.Cells("Id").Value
                    olDocumentoVehicular.Eliminar(oeDocumentoVehicular)
                    Consultar(True)
                End If
            Else
                Throw New Exception("Seleccione un seguro para poder eliminarlo")
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            Exportar_Excel(grid_Bonos)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_BonificacionVehicular_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub

    Private Sub frm_BonificacionVehicular_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_BonificacionVehicular_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            Me.Activate()
            Me.Cancelar()
        End If
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub CmbFilTracto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbFilTracto.ValueChanged
        MostrarDetalleVehiculo()
        If oeDocumentoVehicular.ldDetalleDocVeh.Count = 0 Then
            oeDetalleDocumento = New e_DetalleDocumentoVehiculo
            oeDetalleDocumento.Activo = True
            oeDetalleDocumento.IdVehiculo = CmbFilTracto.Value
            oeDetalleDocumento.IndTipoVehiculo = 0
            oeDetalleDocumento.UsuarioCreacion = ObtenerPerfilPrincipal.Id
            oeDocumentoVehicular.ldDetalleDocVeh.Add(oeDetalleDocumento)
        Else
            For Each odd In oeDocumentoVehicular.ldDetalleDocVeh.Where(Function(item) item.Activo = True).ToList
                odd.Activo = True
                odd.IdVehiculo = CmbFilTracto.Value
                odd.IndTipoVehiculo = 0
                odd.UsuarioCreacion = ObtenerPerfilPrincipal.Id
            Next
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try

            Dim nro As Integer = 0
            ValidarPosiciones(CmbEje.Value)

            nro = oeDocumentoVehicular.ldBonoVeh.Where(Function(ITEM) ITEM.Eje = CmbEje.Value).Count
            oeBonificacionVehiculo = New e_BonificacionVehiculo
            If nro = 0 Then
                oeBonificacionVehiculo.Activo = True
                oeBonificacionVehiculo.BonificacionEje = ndBonificacionEje.Value
                oeBonificacionVehiculo.ClaseNeumatico = CmbNeumatico.Value
                oeBonificacionVehiculo.Eje = CmbEje.Value
                oeBonificacionVehiculo.FechaCreacion = Date.Now()
                oeBonificacionVehiculo.Id = ""
                oeBonificacionVehiculo.IdDocumentoVehicular = IIf(Operacion = "Nuevo", "", oeDocumentoVehicular.Id)
                oeBonificacionVehiculo.KgEje = ndKgEje.Value
                oeBonificacionVehiculo.KgNeumatico = ndKgNeumatico.Value
                oeBonificacionVehiculo.KgSuspension = ndKgSuspension.Value
                oeBonificacionVehiculo.PesoEje = ndPesoEje.Value
                oeBonificacionVehiculo.TipoSuspension = CmbSuspension.Value
                oeDocumentoVehicular.ldBonoVeh.Add(oeBonificacionVehiculo)
            Else
                For Each obj In oeDocumentoVehicular.ldBonoVeh.Where(Function(item) item.Eje = CmbEje.Value)
                    obj.Activo = True
                    obj.BonificacionEje = ndBonificacionEje.Value
                    obj.ClaseNeumatico = CmbNeumatico.Value
                    obj.Eje = CmbEje.Value
                    obj.FechaCreacion = Date.Now()
                    obj.IdDocumentoVehicular = IIf(Operacion = "Nuevo", "", oeDocumentoVehicular.Id)
                    obj.KgEje = ndKgEje.Value
                    obj.KgNeumatico = ndKgNeumatico.Value
                    obj.KgSuspension = ndKgSuspension.Value
                    obj.PesoEje = ndPesoEje.Value
                    obj.TipoSuspension = CmbSuspension.Value
                Next
            End If

            Grid_BonosDetalles.DataSource = oeDocumentoVehicular.ldBonoVeh.Where(Function(item) item.Activo = True).ToList
            Grid_BonosDetalles.DataBind()

            LimpiarBonificacionDetalle()

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Try
            Dim oeBono = New e_BonificacionVehiculo
            If Grid_BonosDetalles.Rows.Count > 0 Then
                oeBono.Eje = Grid_BonosDetalles.ActiveRow.Cells("Eje").Value
                If Grid_BonosDetalles.ActiveRow.Cells("Id").Value = "" Then
                    oeDocumentoVehicular.ldBonoVeh.Remove(oeBono)
                Else
                    For Each obj In oeDocumentoVehicular.ldBonoVeh.Where(Function(item) item.Eje = oeBono.Eje)
                        obj.Activo = False
                    Next
                End If
            Else
                Throw New Exception("No existe ninguna fila para eliminar")
            End If

            Grid_BonosDetalles.DataSource = oeDocumentoVehicular.ldBonoVeh.Where(Function(item) item.Activo = True).ToList
            Grid_BonosDetalles.DataBind()

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Grid_BonosDetalles_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs)
        Try
            Grid_BonosDetalles.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub grid_Bonos_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grid_Bonos.DoubleClickRow
        Editar()
    End Sub

#End Region

#Region "Métodos"

    Private Sub Inicializar()
        Try
            LlenarCombos()
            dtp_FEmision.Value = Date.Now
            dtp_FTermino.Value = Date.Now.AddYears(1)
            txtResolucion.Value = ""
            TxtNumero.Value = ""
            txtGlosa.Value = ""
            ndBonificacionFinal.Value = 0.0
            ndPesoFinal.Value = 0.0
            ndPorcentajeFinal.Value = 0.0
            OptMotorizado.Checked = True
            LimpiarBonificacionDetalle()
            oeDocumentoVehicular.ldBonoVeh.Clear()
            oeDocumentoVehicular.ldDetalleDocVeh.Clear()
            Grid_BonosDetalles.DataSource = oeDocumentoVehicular.ldBonoVeh
            Grid_BonosDetalles.DataBind()
            oeDocumentoVehicular = New e_DocumentoVehicular
            oeDocumentoVehicular.Id = ""
            CmbFilTracto.Value = ""
            If Operacion = "Nuevo" Then
                oeDocumentoVehicular.TipoOperacion = "I"
            ElseIf Operacion = "Editar" Then
                oeDocumentoVehicular.TipoOperacion = "A"
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub LlenarCombos()
        Try
            oeVehiculo.Id = ""
            oeVehiculo.Placa = "NINGUNA"
            lstVehiculo.Add(oeVehiculo)
            oeVehiculo = New e_Vehiculo
            oeVehiculo.TipoOperacion = "A"
            oeVehiculo.Motriz = -1
            oeVehiculo.Activo = True
            lstVehiculo.AddRange(olVehiculo.Listar(oeVehiculo))
            LlenarComboMaestro(CmbFilTracto, lstVehiculo, 0)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub MostrarDetalleVehiculo()
        Try
            If CmbFilTracto.Value <> "" Then
                Dim oeVeh As New e_Vehiculo
                oeVeh = lstVehiculo.Where(Function(item) item.Id = CmbFilTracto.Value)(0)
                TxtPlaca.Value = oeVeh.Placa
                TxtCategoria.Value = oeVeh.NroMTC
                TxtMarca.Value = oeVeh.Marca
                TxtModelo.Value = oeVeh.Modelo
                TxtAñoFabri.Value = oeVeh.AnioFabricacion
                TxtSerie.Value = oeVeh.NroSerieChasis
                TxtMotor.Value = oeVeh.NroSerieMotor
                TxtNroEjes.Value = oeVeh.NroEjes
                TxtNroRuedas.Value = oeVeh.NroNeumaticos
            Else
                TxtPlaca.Value = ""
                TxtCategoria.Value = ""
                TxtMarca.Value = ""
                TxtModelo.Value = ""
                TxtAñoFabri.Value = ""
                TxtSerie.Value = ""
                TxtMotor.Value = ""
                TxtNroEjes.Value = ""
                TxtNroRuedas.Value = ""
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarBonificacion() As Boolean
        Try
            oeDocumentoVehicular.Activo = True
            oeDocumentoVehicular.IdTipoDocumento = IdTipoDocumento
            oeDocumentoVehicular.Numero = TxtNumero.Value
            oeDocumentoVehicular.NroResolucion = txtResolucion.Value
            oeDocumentoVehicular.IdEmpresaEmisora = IdEmpresaCertificadora
            oeDocumentoVehicular.FechaEmision = dtp_FEmision.Value
            oeDocumentoVehicular.FechaVencimiento = dtp_FTermino.Value
            oeDocumentoVehicular.Peso = ndPesoFinal.Value
            oeDocumentoVehicular.Bonificacion = ndBonificacionFinal.Value
            oeDocumentoVehicular.Porcentaje = ndPorcentajeFinal.Value
            oeDocumentoVehicular.Descripcion = txtGlosa.Value
            oeDocumentoVehicular.UsuarioCreacion = ObtenerPerfilPrincipal.Id
            oeDocumentoVehicular.Importe = 0.0

            For Each obj In oeDocumentoVehicular.ldBonoVeh
                If obj.Eje = "DELANTERO" Then
                    obj.Eje = "D0"
                ElseIf obj.Eje = "POSTERIOR 1" Then
                    obj.Eje = "P1"
                ElseIf obj.Eje = "POSTERIOR 2" Then
                    obj.Eje = "P2"
                ElseIf obj.Eje = "POSTERIOR 3" Then
                    obj.Eje = "P3"
                ElseIf obj.Eje = "POSTERIOR 4" Then
                    obj.Eje = "P4"
                End If
            Next
            oeDocumentoVehicular.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olDocumentoVehicular.Guardar(oeDocumentoVehicular) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, tcBonificacion, 2)
                Consultar(True)
                grid_Bonos.Focus()
                Return True
            End If
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeDocumentoVehicular = New e_DocumentoVehicular

            oeDocumentoVehicular.Activo = True
            oeDocumentoVehicular.TipoOperacion = "B"
            oeDocumentoVehicular.IdVehiculo = ""
            oeDocumentoVehicular.IdEmpresaEmisora = ""
            oeDocumentoVehicular.IndVigencia = IIf(chk_Vigentes.Checked, True, False)
            Dim ds As DataSet = olDocumentoVehicular.ListarDts(oeDocumentoVehicular)

            grid_Bonos.DataSource = ds

            Me.Cursor = Cursors.WaitCursor

            grid_Bonos.DisplayLayout.UseFixedHeaders = True
            grid_Bonos.DisplayLayout.Override.FixedHeaderIndicator = FixedHeaderIndicator.None
            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In grid_Bonos.Rows
                If Date.Now.AddDays(NumeroDias.Value) > fila.Cells("FechaVencimiento").Value And fila.Cells("FechaVencimiento").Value > Date.Now Then
                    fila.CellAppearance.BackColor = Me.ColorPinta.Color
                End If
            Next

            If grid_Bonos.Rows.Count > 0 Then
                grid_Bonos.Focus()
                grid_Bonos.Rows.Item(0).Selected = True
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub EditarBonificacion()
        Try
            Inicializar()
            oeDocumentoVehicular.Activo = True
            oeDocumentoVehicular.TipoOperacion = "O"
            oeDocumentoVehicular.Id = grid_Bonos.ActiveRow.Cells("Id").Value
            oeDocumentoVehicular = olDocumentoVehicular.Obtener(oeDocumentoVehicular)
            txtResolucion.Value = oeDocumentoVehicular.NroResolucion
            TxtNumero.Value = oeDocumentoVehicular.Numero
            dtp_FEmision.Value = oeDocumentoVehicular.FechaEmision
            dtp_FTermino.Value = oeDocumentoVehicular.FechaVencimiento
            txtGlosa.Value = oeDocumentoVehicular.Descripcion
            ndBonificacionFinal.Value = oeDocumentoVehicular.Bonificacion
            ndPesoFinal.Value = oeDocumentoVehicular.Peso
            ndPorcentajeFinal.Value = oeDocumentoVehicular.Porcentaje
            oeDocumentoVehicular.TipoOperacion = "A"

            oeDocumentoVehicular.ldDetalleDocVeh.Clear()
            oeDetalleDocumento.TipoOperacion = "B"
            oeDetalleDocumento.Id = ""
            oeDetalleDocumento.IdDocumento = oeDocumentoVehicular.Id
            oeDocumentoVehicular.ldDetalleDocVeh = olDetalleDocumento.Listar(oeDetalleDocumento)
            For Each obj In oeDocumentoVehicular.ldDetalleDocVeh
                If obj.IndTipoVehiculo = "1" Then
                    OptMotorizado.Checked = True
                ElseIf obj.IndTipoVehiculo = "2" Then
                    OptRemolcadorDelantero.Checked = True
                ElseIf obj.IndTipoVehiculo = "3" Then
                    OptRemolcadorPosterior.Checked = True
                End If
                CmbFilTracto.Value = obj.IdVehiculo
            Next

            oeDocumentoVehicular.ldBonoVeh.Clear()
            oeBonificacionVehiculo.TipoOperacion = "1"
            oeBonificacionVehiculo.Id = ""
            oeBonificacionVehiculo.IdDocumentoVehicular = oeDocumentoVehicular.Id
            oeDocumentoVehicular.ldBonoVeh = olBonificacionVehiculo.Listar(oeBonificacionVehiculo)
            For Each obj In oeDocumentoVehicular.ldBonoVeh
                If obj.Eje = "D0" Then obj.Eje = "DELANTERO"
                If obj.Eje = "P1" Then obj.Eje = "POSTERIOR 1"
                If obj.Eje = "P2" Then obj.Eje = "POSTERIOR 2"
                If obj.Eje = "P3" Then obj.Eje = "POSTERIOR 3"
                If obj.Eje = "P4" Then obj.Eje = "POSTERIOR 4"
            Next
            Grid_BonosDetalles.DataSource = oeDocumentoVehicular.ldBonoVeh.Where(Function(item) item.Activo = True).ToList
            Grid_BonosDetalles.DataBind()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ValidarPosiciones(ByVal Posicion As String)
        Try
            If Posicion = "DELANTERO" Then
                If oeDocumentoVehicular.ldBonoVeh.Where(Function(item) item.Eje = "DELANTERO" And item.Activo = True).Count = 1 Then
                    Throw New Exception("Ya existe un DELANTERO registrado")
                End If
            ElseIf Posicion = "POSTERIOR 1" Then
                If oeDocumentoVehicular.ldBonoVeh.Where(Function(item) item.Eje = "POSTERIOR 1" And item.Activo = True).Count = 1 Then
                    Throw New Exception("Ya existe un POSTERIOR 1 registrado")
                End If
            ElseIf Posicion = "POSTERIOR 2" Then
                If oeDocumentoVehicular.ldBonoVeh.Where(Function(item) item.Eje = "POSTERIOR 2" And item.Activo = True).Count = 1 Then
                    Throw New Exception("Ya existe un POSTERIOR 2 registrado")
                End If
            ElseIf Posicion = "POSTERIOR 3" Then
                If oeDocumentoVehicular.ldBonoVeh.Where(Function(item) item.Eje = "POSTERIOR 3" And item.Activo = True).Count = 1 Then
                    Throw New Exception("Ya existe un POSTERIOR 3 registrado")
                End If
            ElseIf Posicion = "POSTERIOR 4" Then
                If oeDocumentoVehicular.ldBonoVeh.Where(Function(item) item.Eje = "POSTERIOR 4" And item.Activo = True).Count = 1 Then
                    Throw New Exception("Ya existe un POSTERIOR 4 registrado")
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LimpiarBonificacionDetalle()
        Try
            ndKgEje.Value = 0.0
            ndKgNeumatico.Value = 0.0
            ndKgSuspension.Value = 0.0
            ndBonificacionEje.Value = 0.0
            ndPesoEje.Value = 0.0
            CmbEje.SelectedIndex = 0
            CmbSuspension.SelectedIndex = 0
            CmbNeumatico.SelectedIndex = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Menú Contextual"

    Private Sub MenuBonificaciones_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuBonificaciones.Opening
        Try
            MenuBonificaciones.Items(0).Visible = True
            MenuBonificaciones.Items(1).Visible = False
            MenuBonificaciones.Items(2).Visible = False
            If grid_Bonos.Selected.Rows.Count > 0 Then
                MenuBonificaciones.Items(1).Visible = True
                MenuBonificaciones.Items(2).Visible = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
    End Sub
#End Region

End Class