Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frm_CertificadoHabilitacion
    Inherits frm_MenuPadre

#Region "Inicializar el formulario"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Shared Instancia As frm_CertificadoHabilitacion = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_CertificadoHabilitacion()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Declaración de Variables"

    Dim _ingresando_datos As Boolean
    Dim oeDocumentoVehicular As New e_DocumentoVehicular
    Dim olDocumentoVehicular As New l_DocumentoVehicular
    Dim oeDetalleDocumentoVehicular As New e_DetalleDocumentoVehiculo
    Dim olDetalleDocumentoVehiculo As New l_DetalleDocumentoVehiculo
    Dim oeVehiculo As New e_Vehiculo
    Dim olVehiculo As New l_Vehiculo
    Dim lstVehiculo As New List(Of e_Vehiculo)
    Dim lstVehiculo2 As New List(Of e_Vehiculo)

#End Region

#Region "Botones"


    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If Grid_ListadoCO.Rows.Count > 0 Then
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
            Inicializar()
            MostrarTabs(1, tc_DocumentosVehiculares, 1)
            oeDocumentoVehicular.TipoOperacion = "I"
            Operacion = "Nuevo"
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Operacion = "Editar"
            oeDocumentoVehicular = New e_DocumentoVehicular
            If Grid_ListadoCO.ActiveRow.Band.Index = 0 Then
                EditarCertificado()
                MostrarTabs(1, tc_DocumentosVehiculares, 1)
                TxtNroCO.Focus()
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
            If GuardarDocumento() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tc_DocumentosVehiculares, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            MostrarTabs(0, tc_DocumentosVehiculares, 2)
            ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            _ingresando_datos = False
            Consultar(True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With Grid_ListadoCO
                If Grid_ListadoCO.ActiveRow.Band.Index = 0 And Grid_ListadoCO.ActiveRow.Cells("Id").Value.ToString <> "" Then
                    If MessageBox.Show("Esta seguro de eliminar el certificado de habilitación N°: " & _
                    .ActiveRow.Cells("Numero").Value.ToString.Trim & " ?", _
                    "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        oeDocumentoVehicular.TipoOperacion = "E"
                        oeDocumentoVehicular.Id = .ActiveRow.Cells("Id").Value
                        olDocumentoVehicular.Eliminar(oeDocumentoVehicular)
                        Consultar(True)
                    End If
                Else
                    Throw New Exception("Seleccione una revisión para poder eliminarlo")
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If Grid_ListadoCO.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(Grid_ListadoCO)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Procedimientos"

    Private Sub LlenarCombos()
        Try
            LlenarTracto()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarTracto()
        Try
            oeVehiculo = New e_Vehiculo
            oeVehiculo.Id = ""
            oeVehiculo.Placa = "NINGUNO"
            lstVehiculo.Add(oeVehiculo)
            oeVehiculo = New e_Vehiculo
            oeVehiculo.TipoOperacion = "A"
            oeVehiculo.Motriz = -1
            oeVehiculo.Activo = True
            lstVehiculo.AddRange(olVehiculo.Listar(oeVehiculo))
            LlenarComboMaestro(CmbTractoCO, lstVehiculo, 0)

            oeVehiculo = New e_Vehiculo
            oeVehiculo.Id = ""
            oeVehiculo.Placa = "TODOS"
            lstVehiculo2.Add(oeVehiculo)
            oeVehiculo = New e_Vehiculo
            oeVehiculo.TipoOperacion = "A"
            oeVehiculo.Motriz = -1
            oeVehiculo.Activo = True
            lstVehiculo2.AddRange(olVehiculo.Listar(oeVehiculo))
            LlenarComboMaestro(CmbFilTracto, lstVehiculo2, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializar()
        Try
            CmbTractoCO.Value = ""
            dtpEmisionCO.Value = Date.Now()
            dtpVencimientoCO.Value = Date.Now().AddYears(1)
            TxtPartidaCO.Value = ""
            TxtHabilitacionCO.Value = ""
            TxtGlosaCO.Value = ""
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MostrarDetalleCO()
        Try
            If CmbTractoCO.Value <> "" Then
                Dim oeVeh As New e_Vehiculo
                oeVeh = lstVehiculo.Where(Function(item) item.Id = CmbTractoCO.Value)(0)
                ClaseCO.Value = oeVeh.TipoVehiculo
                MarcaCO.Value = oeVeh.Marca
                EjesCO.Value = oeVeh.NroEjes
                PesoNetoCO.Value = " -- "
                CargaUtilCO.Value = " -- "
                PesoBrutoCO.Value = " -- "
                LargoCO.Value = oeVeh.Largo
                AnchoCO.Value = oeVeh.Ancho
                AltoCO.Value = oeVeh.Alto
                AñoCO.Value = oeVeh.AnioFabricacion
                SerieCO.Value = oeVeh.NroSerieChasis
            Else
                ClaseCO.Value = ""
                MarcaCO.Value = ""
                EjesCO.Value = ""
                PesoNetoCO.Value = ""
                CargaUtilCO.Value = ""
                PesoBrutoCO.Value = ""
                LargoCO.Value = ""
                AnchoCO.Value = ""
                AltoCO.Value = ""
                AñoCO.Value = ""
                SerieCO.Value = ""
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeDocumentoVehicular = New e_DocumentoVehicular
            With Grid_ListadoCO
                oeDocumentoVehicular.Activo = True
                oeDocumentoVehicular.TipoOperacion = "T"
                oeDocumentoVehicular.IdVehiculo = CmbFilTracto.Value
                oeDocumentoVehicular.IdEmpresaEmisora = ""
                oeDocumentoVehicular.IndVigencia = IIf(chk_Vigentes.Checked, True, False)
                oeDocumentoVehicular.TipoDocumento = "1CH000000052"
                Dim ds As DataSet = olDocumentoVehicular.ListarDts(oeDocumentoVehicular)
                .DataSource = ds

                Me.Cursor = Cursors.WaitCursor
                With .DisplayLayout
                    .UseFixedHeaders = True
                    .Override.FixedHeaderIndicator = FixedHeaderIndicator.None
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In Grid_ListadoCO.Rows
                        If Date.Now.AddDays(numDias.Value) > fila.Cells("FechaVencimiento").Value And fila.Cells("FechaVencimiento").Value > Date.Now Then
                            fila.CellAppearance.BackColor = Me.ColorVencimiento.Color
                        End If
                    Next
                End With
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function GuardarDocumento() As Boolean
        Try
            If oeDocumentoVehicular.ldDetalleDocVeh.Where(Function(i) i.Activo = True And i.IdVehiculo <> "").Count() = 0 Then Throw New Exception("Especifique la unidad de la revisión técnica.")
            oeDocumentoVehicular.IdTipoDocumento = "1CH000000052"
            oeDocumentoVehicular.IdEmpresaEmisora = "1CH000003780"
            oeDocumentoVehicular.FechaEmision = dtpEmisionCO.Value
            oeDocumentoVehicular.FechaVencimiento = dtpVencimientoCO.Value
            oeDocumentoVehicular.Numero = TxtNroCO.Value
            oeDocumentoVehicular.NroResolucion = TxtPartidaCO.Value
            oeDocumentoVehicular.Resultado = TxtHabilitacionCO.Value
            oeDocumentoVehicular.Descripcion = TxtGlosaCO.Value
            oeDocumentoVehicular.UsuarioCreacion = gUsuarioSGI.Id
            If olDocumentoVehicular.Guardar(oeDocumentoVehicular) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, tc_DocumentosVehiculares, 2)
                Consultar(True)
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub EditarCertificado()
        Try
            Inicializar()
            oeDocumentoVehicular.Activo = True
            oeDocumentoVehicular.TipoOperacion = "O"
            oeDocumentoVehicular.Id = Grid_ListadoCO.ActiveRow.Cells("Id").Value()
            oeDocumentoVehicular = olDocumentoVehicular.Obtener(oeDocumentoVehicular)
            oeDocumentoVehicular.TipoOperacion = "A"

            oeDetalleDocumentoVehicular.TipoOperacion = "O"
            oeDetalleDocumentoVehicular.Id = ""
            oeDetalleDocumentoVehicular.IdDocumento = oeDocumentoVehicular.Id
            oeDocumentoVehicular.ldDetalleDocVeh = olDetalleDocumentoVehiculo.Listar(oeDetalleDocumentoVehicular)

            TxtNroCO.Value = oeDocumentoVehicular.Numero
            dtpEmisionCO.Value = oeDocumentoVehicular.FechaEmision
            dtpVencimientoCO.Value = oeDocumentoVehicular.FechaVencimiento
            TxtGlosaCO.Value = oeDocumentoVehicular.Descripcion
            TxtPartidaCO.Value = oeDocumentoVehicular.NroResolucion
            TxtHabilitacionCO.Value = oeDocumentoVehicular.Resultado
            CmbTractoCO.Value = oeDocumentoVehicular.ldDetalleDocVeh(0).IdVehiculo

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_CertificadoHabilitacion_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            If tc_DocumentosVehiculares.Tabs(0).Selected = True Then
                If Grid_ListadoCO.Rows.Count() = 0 Then
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                Else
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                End If
            ElseIf tc_DocumentosVehiculares.Tabs(1).Selected = True Then
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub frm_CertificadoHabilitacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LlenarCombos()
            Inicializar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub frm_CertificadoHabilitacion_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_CertificadoHabilitacion_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            Me.Activate()
            Me.Cancelar()
        End If
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub CmbTractoCO_ValueChanged(sender As Object, e As EventArgs) Handles CmbTractoCO.ValueChanged
        Try
            MostrarDetalleCO()
            If oeDocumentoVehicular.ldDetalleDocVeh.Count = 0 Then
                oeDetalleDocumentoVehicular = New e_DetalleDocumentoVehiculo
                oeDetalleDocumentoVehicular.Activo = IIf(CmbTractoCO.Value = "", False, True)
                oeDetalleDocumentoVehicular.IdVehiculo = CmbTractoCO.Value
                oeDetalleDocumentoVehicular.IndTipoVehiculo = ""
                oeDetalleDocumentoVehicular.UsuarioCreacion = ObtenerPerfilPrincipal.Id
                oeDocumentoVehicular.ldDetalleDocVeh.Add(oeDetalleDocumentoVehicular)
            Else
                For Each odd In oeDocumentoVehicular.ldDetalleDocVeh
                    odd.Activo = IIf(CmbTractoCO.Value = "", False, True)
                    odd.IdVehiculo = CmbTractoCO.Value
                    odd.IndTipoVehiculo = 0
                    odd.UsuarioCreacion = ObtenerPerfilPrincipal.Id
                Next
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Grid_ListadoCO_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles Grid_ListadoCO.DoubleClickRow
        Try
            If Grid_ListadoCO.ActiveRow.Cells("Id").Value.ToString <> "" Then
                Operacion = "Editar"
                oeDocumentoVehicular = New e_DocumentoVehicular
                If Grid_ListadoCO.ActiveRow.Band.Index = 0 Then
                    EditarCertificado()
                    MostrarTabs(1, tc_DocumentosVehiculares, 1)
                    TxtNroCO.Focus()
                    MyBase.Editar()
                Else
                    Throw New Exception("Seleccione una fila válida.")
                End If
            Else
                Throw New Exception("Seleccione una fila válida")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub dtpVencimientoCO_Validated(sender As Object, e As EventArgs) Handles dtpVencimientoCO.Validated
        Try
            If dtpVencimientoCO.Value <= dtpEmisionCO.Value Then
                dtpVencimientoCO.Value = dtpEmisionCO.Value.AddYears(1)
                Throw New Exception("Fecha de Vencimiento no puede ser menor a la de Emisión.")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Grid_ListadoCO_MouseEnterElement(sender As Object, e As UIElementEventArgs) Handles Grid_ListadoCO.MouseEnterElement
        Try
            If Grid_ListadoCO.Rows.Count > 0 Then
                Dim celda As UltraGridCell = TryCast(e.Element.GetContext(GetType(UltraGridCell), True), UltraGridCell)
                If Not celda Is Nothing Then
                    If celda.Column.Key = "FechaVencimiento" AndAlso Not IsDBNull(celda.Value) Then
                        Dim diasRetrazo As Integer = DateDiff(DateInterval.Day, Date.Now, celda.Value)
                        If diasRetrazo > 0 Then
                            Dim mensaje As String = diasRetrazo.ToString & " días para vencer"
                            Dim tipInfo As New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo(mensaje, Infragistics.Win.ToolTipImage.Default, "Información", Infragistics.Win.DefaultableBoolean.True)
                            UltraToolTipManager1.SetUltraToolTip(Grid_ListadoCO, tipInfo)
                            UltraToolTipManager1.ShowToolTip(Grid_ListadoCO)
                        End If
                    Else
                        UltraToolTipManager1.HideToolTip()
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

End Class