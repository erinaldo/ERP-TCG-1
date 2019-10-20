'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win.UltraWinGrid

Public Class frm_CuponesSeguros

    Private Shared instancia As frm_CuponesSeguros = Nothing

#Region "clase"

    Class CustomMergedCellEvaluator
        Implements Infragistics.Win.UltraWinGrid.IMergedCellEvaluator

        Function ShouldCellsBeMerged(ByVal row1 As UltraGridRow, ByVal row2 As UltraGridRow, ByVal column As UltraGridColumn) As Boolean Implements IMergedCellEvaluator.ShouldCellsBeMerged
            Dim Id1 As String = DirectCast(row1.GetCellValue("Id"), String)
            Dim Id2 As String = DirectCast(row2.GetCellValue("Id"), String)
            Return Id1 = Id2
        End Function
    End Class

#End Region

#Region "Inicializacion de Formulario"

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_CuponesSeguros()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de Variables"

    Dim leCuotaListado As New List(Of e_CuotaDocumentoVehiculo)
    Dim leCuotaSeleccion As New List(Of e_CuotaDocumentoVehiculo)
    Dim leDocRefListado As New List(Of e_DocumentoVehicular_Documento)
    Dim leDocRefSeleccion As New List(Of e_DocumentoVehicular_Documento)
    Dim leCuotaNueva As New List(Of e_CuotaDocumentoVehiculo)
    Dim IdDocumento As String = ""
    Dim IdMoneda As String = ""
    Dim oeDocumento As New e_DocumentoVehicular
    Dim olDocumento As New l_DocumentoVehicular
    Dim leDocumento As New List(Of e_DocumentoVehicular)

    Dim leCuotaMovimientoPago As New List(Of e_CuotaDocVehPago)
    Dim olCuotaMovimientoPago As New l_CuotaDocVehPago
    Dim oeCuotaMovimientoPago As New e_CuotaDocVehPago

#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            MostrarTabs(1, TabContenido, 1)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            TabContenido.Tabs(0).Enabled = False
            TabContenido.Tabs(1).Enabled = True
            Inicializar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            ListarCuotas()
            If GridCuotas.Rows.Count = 0 Then
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            Else
                ControlBoton(1, 1, 1, 0, 0, 0, 1, 1, 1)
            End If
            TabContenido.Tabs(0).Enabled = True
            TabContenido.Tabs(1).Enabled = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarCanjeCuotas() Then
                mensajeEmergente.Confirmacion("Se registro correctamente", False)
                MostrarTabs(0, TabContenido)
                If GridCuotas.Rows.Count = 0 Then
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                Else
                    ControlBoton(1, 1, 1, 0, 0, 0, 1, 1, 1)
                End If
                TabContenido.Tabs(0).Enabled = True
                TabContenido.Tabs(1).Enabled = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Consultar(True)
            MostrarTabs(0, TabContenido, 1)
            TabContenido.Tabs(1).Enabled = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
           
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If GridCuotas.Rows.Count > 0 Then
                Exportar_Excel(GridCuotas)
            Else
                Throw New Exception("No existen filas a exportar.")
            End If
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Try
            Throw New Exception("No disponible temporalmente.")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Metodos"

    Private Sub Inicializar()
        Try
            rbMesVencimiento.Checked = True
            rbFechasVencimiento.Checked = False
            DtpFechaDesde.Value = Date.Now().AddMonths(-1)
            DtpFechaHasta.Value = Date.Now()
            cboMes.Value = 1
            Año.Año = Year(Date.Now)
            LlenarComboPoliza()
            IdDocumento = ""
            dtpFechaNuevoCupon.Value = Date.Now()
            Fecha.Value = Date.Now()
            DecTC.Value = TipoCambio(Fecha.Value)(0)
            leDocRefListado.Clear()
            leDocRefSeleccion.Clear()
            leCuotaNueva.Clear()
            leCuotaListado.Clear()
            leCuotaSeleccion.Clear()
            MostrarSubtotales()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarCuotas()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim oeCuotaDocVeh As New e_CuotaDocumentoVehiculo
            Dim olCuotaDocVeh As New l_CuotaDocumentoVehiculo
            If RbtPendienteAdm.Checked Then
                oeCuotaDocVeh.IndVigencia = "A"
            ElseIf RbtPendienteCon.Checked Then
                oeCuotaDocVeh.IndVigencia = "C"
            Else
                oeCuotaDocVeh.IndVigencia = ""
            End If
            If rbFechasVencimiento.Checked Then
                oeCuotaDocVeh.TipoOperacion = "C"
                oeCuotaDocVeh.FechaDesde = DtpFechaDesde.Value
                oeCuotaDocVeh.FechaHasta = DtpFechaHasta.Value
            End If
            If rbMesVencimiento.Checked Then
                oeCuotaDocVeh.TipoOperacion = "V"
                oeCuotaDocVeh.FechaHasta = Date.Parse("01/" + cboMes.Value.ToString + "/" + Año.Año.ToString)
            End If
            GridCuotas.DataSource = olCuotaDocVeh.ListarDts(oeCuotaDocVeh).Tables(0)
            GridCuotas.DataBind()
            leCuotaMovimientoPago.Clear()
            GridMovimientoAdministrativo.DataSource = leCuotaMovimientoPago
            GridMovimientoContable.DataSource = leCuotaMovimientoPago
            GridMovimientoAdministrativo.DataBind()
            GridMovimientoContable.DataBind()
            ugb_Espera.Visible = False
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub LlenarComboPoliza()
        Try
            oeDocumento.TipoOperacion = "C"
            leDocumento.Clear()
            leDocumento = olDocumento.Listar(oeDocumento)
            LlenarCombo(CboFilPoliza, "Numero", leDocumento, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MostrarSubtotales()
        Try
            Dim totalCuotaAgregada As Double = 0.0
            Dim totalSaldoaFavor As Double = 0.0
            Dim totalCuotaNueva As Double = 0.0
            totalCuotaAgregada = leCuotaSeleccion.Sum(Function(i) i.MontoOpera)
            Nd_CuotasAgregadas.Value = Math.Round(totalCuotaAgregada, 2)
            totalSaldoaFavor = leDocRefSeleccion.Sum(Function(i) i.Aplica)
            nd_SaldoaFavor.Value = Math.Round(totalSaldoaFavor, 2)
            nd_MontoaCanjear.Value = Nd_CuotasAgregadas.Value - nd_SaldoaFavor.Value
            totalCuotaNueva = leCuotaNueva.Sum(Function(i) i.Monto)
            nd_MontoCuotaNueva.Value = Math.Round(totalCuotaNueva, 2)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarCupon()
        Try
            Dim oeCupon As New e_CuotaDocumentoVehiculo
            oeCupon = Grid_CuotaLista.ActiveRow.ListObject
            leCuotaListado.Remove(oeCupon)
            oeCupon.PrefijoID = gs_PrefijoIdSucursal '@0001
            leCuotaSeleccion.Add(oeCupon)
            Grid_CuotaLista.DataBind()
            Grid_CuotaSel.DataBind()
            MostrarSubtotales()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarCupon()
        Try
            Dim oeCupon As New e_CuotaDocumentoVehiculo
            oeCupon = Grid_CuotaSel.ActiveRow.ListObject
            leCuotaSeleccion.Remove(oeCupon)
            oeCupon.PrefijoID = gs_PrefijoIdSucursal '@0001
            leCuotaListado.Add(oeCupon)
            Grid_CuotaLista.DataBind()
            Grid_CuotaSel.DataBind()
            MostrarSubtotales()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarDocumento()
        Try
            Dim oeDocumento As New e_DocumentoVehicular_Documento
            oeDocumento = Grid_DocRefLista.ActiveRow.ListObject
            leDocRefListado.Remove(oeDocumento)
            oeDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
            leDocRefSeleccion.Add(oeDocumento)
            Grid_DocRefLista.DataBind()
            Grid_DocRefSel.DataBind()
            MostrarSubtotales()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarDocumento()
        Try
            Dim oeDocumento As New e_DocumentoVehicular_Documento
            oeDocumento = Grid_DocRefSel.ActiveRow.ListObject
            leDocRefSeleccion.Remove(oeDocumento)
            oeDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
            leDocRefListado.Add(oeDocumento)
            Grid_DocRefLista.DataBind()
            Grid_DocRefSel.DataBind()
            MostrarSubtotales()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarCuponNuevo()
        Try
            If TxtCuponNuevo.Value = "" Then Throw New Exception("Ingrese un número al cupón.")
            Dim oeCuota As New e_CuotaDocumentoVehiculo
            oeCuota.Id = ""
            oeCuota.TipoOperacion = "I"
            oeCuota.Activo = 1
            oeCuota.Glosa = TxtCuponNuevo.Value
            oeCuota.Fecha = dtpFechaNuevoCupon.Value
            oeCuota.Monto = ndCuotaNuevoCupon.Value
            oeCuota.SaldoAdministrativo = oeCuota.Monto
            oeCuota.SaldoContable = oeCuota.Monto
            oeCuota.IdDocVeh_Doc = ""
            oeCuota.IdDocumento = ""
            oeCuota.PrefijoID = gs_PrefijoIdSucursal '@0001
            leCuotaNueva.Add(oeCuota)
            Grid_CuotaNueva.DataSource = leCuotaNueva
            Grid_CuotaNueva.DataBind()
            MostrarSubtotales()
            TxtCuponNuevo.Value = ""
            dtpFechaNuevoCupon.Value = DateAdd(DateInterval.Month, 1, dtpFechaNuevoCupon.Value)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarCuponNuevo()
        Try
            Dim oeCuota As New e_CuotaDocumentoVehiculo
            oeCuota = Grid_CuotaNueva.ActiveRow.ListObject()
            leCuotaNueva.Remove(oeCuota)
            Grid_CuotaNueva.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidarCanjeCuotas()
        Try
            If nd_MontoaCanjear.Value = 0 Or nd_MontoCuotaNueva.Value = 0 Then
                Throw New Exception("Montos para el canje de cuotas no pueden ser 0.0")
            End If
            If leCuotaSeleccion.Count = 0 Or leDocRefSeleccion.Count = 0 Or leCuotaNueva.Count = 0 Then
                Throw New Exception("Ingrese detalles a Cupones//Docs//Nuevos cupones.")
            End If
            If (nd_MontoaCanjear.Value - nd_MontoCuotaNueva.Value) < -0.1 And (nd_MontoaCanjear.Value - nd_MontoCuotaNueva.Value) > 0.1 Then
                Throw New Exception("Monto para canjear es distinto al de las nuevas cuotas")
            End If
            If DecTC.Value = 0.0 Then Throw New Exception("Tipo de cambio no puede ser 0.0")
            If Fecha.Value > Date.Now() Then Throw New Exception("Fecha no puede ser mayor a la actual.")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function GuardarCanjeCuotas()
        Try
            If ValidarCanjeCuotas() Then
                Dim RelacionCupon As String = ""
                For i = 0 To leCuotaSeleccion.Count - 1
                    If i = 0 Then
                        RelacionCupon = leCuotaSeleccion(0).Glosa
                    Else
                        RelacionCupon = RelacionCupon + ", " + leCuotaSeleccion(i).Glosa
                    End If
                Next
                Dim RelacionDocRef As String = ""
                For i = 0 To leDocRefSeleccion.Count - 1
                    If i = 0 Then
                        RelacionDocRef = leDocRefSeleccion(0).Numero
                    Else
                        RelacionDocRef = RelacionDocRef + ", " + leDocRefSeleccion(i).Numero
                    End If
                Next
                For Each obj In leCuotaNueva
                    obj.IdDocumento = IdDocumento
                    obj.IdUsuarioCreacion = gUsuarioSGI.Id
                    obj.PrefijoID = gs_PrefijoIdSucursal '@0001
                Next
                Dim oeCuotaMov As New e_CuotaDocVeh_Movimiento
                Dim olCuotaMov As New l_CuotaDocVeh_Movimiento
                oeCuotaMov.TipoOperacion = "I"
                oeCuotaMov.Tipo = "T"
                oeCuotaMov.Glosa = "CANJE DE CUOTAS: " + RelacionCupon + ". POR APLICACION DE SALDOS A FAVOR DE DOCS.:" + RelacionDocRef + "."
                oeCuotaMov.Fecha = Fecha.Value
                oeCuotaMov.IdMovimientoDocumento = ""
                oeCuotaMov.IdMovimientoCajaBanco = ""
                oeCuotaMov.IdMoneda = IdMoneda
                oeCuotaMov.TipoCambio = DecTC.Value
                If IdMoneda = "1CH01" Then
                    oeCuotaMov.MontoMN = nd_MontoCuotaNueva.Value
                    oeCuotaMov.MontoME = nd_MontoCuotaNueva.Value / DecTC.Value
                ElseIf IdMoneda = "1CH02" Then
                    oeCuotaMov.MontoMN = nd_MontoCuotaNueva.Value * DecTC.Value
                    oeCuotaMov.MontoME = nd_MontoCuotaNueva.Value
                End If
                oeCuotaMov.Activo = 1
                oeCuotaMov.UsuarioCreacion = gUsuarioSGI.Id
                oeCuotaMov.leCuota.Clear()
                oeCuotaMov.leDocumento.Clear()
                oeCuotaMov.leCuotasNuevas.Clear()
                oeCuotaMov.leCuota = leCuotaSeleccion
                oeCuotaMov.leDocumento = leDocRefSeleccion
                oeCuotaMov.leCuotasNuevas = leCuotaNueva
                oeCuotaMov.FechaCeacion = Date.Now()
                oeCuotaMov.PrefijoID = gs_PrefijoIdSucursal '@0001
                olCuotaMov.GuardarCancelacion(oeCuotaMov)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Eventos"

    Private Sub GridCuotas_InitializeLayout(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles GridCuotas.InitializeLayout
        Try
            e.Layout.Bands(0).Columns("Aseguradora").MergedCellStyle = MergedCellStyle.Always
            e.Layout.Bands(0).Columns("NumeroDocumento").MergedCellStyle = MergedCellStyle.Always
            e.Layout.Bands(0).Columns("Moneda").MergedCellStyle = MergedCellStyle.Always
            e.Layout.Bands(0).Columns("NumeroDoc_Documento").MergedCellStyle = MergedCellStyle.Always
            e.Layout.Bands(0).Columns("GlosaDoc_Documento").MergedCellStyle = MergedCellStyle.Always
            For Each col As UltraGridColumn In GridCuotas.DisplayLayout.Bands(0).Columns
                If col.Key <> "Id" Then e.Layout.Bands(0).Columns(col.Key).MergedCellEvaluator = New CustomMergedCellEvaluator()
            Next
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_CuponesSeguros_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            instancia = Nothing
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_CuponesSeguros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            TabContenido.Tabs(1).Enabled = False
            Inicializar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub rbFechasVencimiento_CheckedChanged(sender As Object, e As EventArgs) Handles rbFechasVencimiento.CheckedChanged
        If rbFechasVencimiento.Checked = True Then
            GroupFechaVencimiento.Enabled = True
            GroupMesVencimiento.Enabled = False
        Else
            GroupFechaVencimiento.Enabled = False
            GroupMesVencimiento.Enabled = True
        End If
    End Sub

    Private Sub rbMesVencimiento_CheckedChanged(sender As Object, e As EventArgs) Handles rbMesVencimiento.CheckedChanged
        If rbMesVencimiento.Checked Then
            GroupFechaVencimiento.Enabled = False
            GroupMesVencimiento.Enabled = True
        Else
            GroupFechaVencimiento.Enabled = True
            GroupMesVencimiento.Enabled = False
        End If
    End Sub

    Private Sub BtnConsultaPoliza_Click(sender As Object, e As EventArgs) Handles BtnConsultaPoliza.Click
        Try
            If CboFilPoliza.SelectedIndex <> -1 Then
                If IdDocumento <> "" Then
                    If MessageBox.Show("Al listar la Póliza se limpiarán todas las cuotas agregadas, desea continuar ?", _
                        Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                        Exit Try
                    End If
                End If
                IdDocumento = CboFilPoliza.Value
                IdMoneda = leDocumento.Where(Function(i) i.Id = IdDocumento)(0).IdMoneda
                leCuotaSeleccion.Clear()
                leCuotaListado.Clear()
                leDocRefSeleccion.Clear()
                leDocRefSeleccion.Clear()
                Dim oeCuotaDoc As New e_CuotaDocumentoVehiculo
                Dim olCuotaDoc As New l_CuotaDocumentoVehiculo
                oeCuotaDoc.IdDocumento = IdDocumento
                oeCuotaDoc.TipoOperacion = "2"
                leCuotaListado = olCuotaDoc.Listar(oeCuotaDoc)
                Grid_CuotaLista.DataSource = leCuotaListado
                Grid_CuotaLista.DataBind()
                Grid_CuotaSel.DataSource = leCuotaSeleccion
                Grid_CuotaSel.DataBind()
                Dim oeDocRef As New e_DocumentoVehicular_Documento
                Dim olDocRef As New l_DocumentoVehicular_Documento
                oeDocRef.TipoOperacion = "2"
                oeDocRef.IdDocumentoVehicular = IdDocumento
                leDocRefListado = olDocRef.Listar(oeDocRef)
                Grid_DocRefLista.DataSource = leDocRefListado
                Grid_DocRefLista.DataBind()
                Grid_DocRefSel.DataSource = leDocRefSeleccion
                Grid_DocRefSel.DataBind()
            Else
                Throw New Exception("Seleccione una póliza.")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Grid_CuotaLista_KeyDown(sender As Object, e As KeyEventArgs) Handles Grid_CuotaLista.KeyDown
        Try
            With Grid_CuotaLista
                If e.KeyValue = Keys.Enter Or e.KeyValue = Keys.Down Then
                    .PerformAction(UltraGridAction.ExitEditMode, False, False)
                    .PerformAction(UltraGridAction.BelowCell, False, False)
                    e.Handled = True
                    .PerformAction(UltraGridAction.EnterEditMode, False, False)
                ElseIf e.KeyValue = Keys.Up Then
                    .PerformAction(UltraGridAction.ExitEditMode, False, False)
                    .PerformAction(UltraGridAction.AboveCell, False, False)
                    e.Handled = True
                    .PerformAction(UltraGridAction.EnterEditMode, False, False)
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Grid_CuotaSel_KeyDown(sender As Object, e As KeyEventArgs) Handles Grid_CuotaSel.KeyDown
        Try
            With Grid_CuotaSel
                If e.KeyValue = Keys.Enter Or e.KeyValue = Keys.Down Then
                    .PerformAction(UltraGridAction.ExitEditMode, False, False)
                    .PerformAction(UltraGridAction.BelowCell, False, False)
                    e.Handled = True
                    .PerformAction(UltraGridAction.EnterEditMode, False, False)
                ElseIf e.KeyValue = Keys.Up Then
                    .PerformAction(UltraGridAction.ExitEditMode, False, False)
                    .PerformAction(UltraGridAction.AboveCell, False, False)
                    e.Handled = True
                    .PerformAction(UltraGridAction.EnterEditMode, False, False)
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Grid_DocRefLista_KeyDown(sender As Object, e As KeyEventArgs) Handles Grid_DocRefLista.KeyDown
        Try
            With Grid_DocRefLista
                If e.KeyValue = Keys.Enter Or e.KeyValue = Keys.Down Then
                    .PerformAction(UltraGridAction.ExitEditMode, False, False)
                    .PerformAction(UltraGridAction.BelowCell, False, False)
                    e.Handled = True
                    .PerformAction(UltraGridAction.EnterEditMode, False, False)
                ElseIf e.KeyValue = Keys.Up Then
                    .PerformAction(UltraGridAction.ExitEditMode, False, False)
                    .PerformAction(UltraGridAction.AboveCell, False, False)
                    e.Handled = True
                    .PerformAction(UltraGridAction.EnterEditMode, False, False)
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Grid_DocRefSel_KeyDown(sender As Object, e As KeyEventArgs) Handles Grid_DocRefSel.KeyDown
        Try
            With Grid_DocRefSel
                If e.KeyValue = Keys.Enter Or e.KeyValue = Keys.Down Then
                    .PerformAction(UltraGridAction.ExitEditMode, False, False)
                    .PerformAction(UltraGridAction.BelowCell, False, False)
                    e.Handled = True
                    .PerformAction(UltraGridAction.EnterEditMode, False, False)
                ElseIf e.KeyValue = Keys.Up Then
                    .PerformAction(UltraGridAction.ExitEditMode, False, False)
                    .PerformAction(UltraGridAction.AboveCell, False, False)
                    e.Handled = True
                    .PerformAction(UltraGridAction.EnterEditMode, False, False)
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Grid_CuotaLista_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles Grid_CuotaLista.DoubleClickRow
        Try
            If Len(Grid_CuotaLista.ActiveRow.Cells("Id").Value.ToString) > 0 Then
                AgregarCupon()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Grid_CuotaSel_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles Grid_CuotaSel.DoubleClickRow
        Try
            If Len(Grid_CuotaSel.ActiveRow.Cells("Id").Value.ToString) > 0 Then
                QuitarCupon()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Grid_DocRefSel_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles Grid_DocRefSel.DoubleClickRow
        Try
            If Len(Grid_DocRefSel.ActiveRow.Cells("Id").Value.ToString) > 0 Then
                QuitarDocumento()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Grid_DocRefLista_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles Grid_DocRefLista.DoubleClickRow
        Try
            If Len(Grid_DocRefLista.ActiveRow.Cells("Id").Value.ToString) > 0 Then
                AgregarDocumento()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub BtnAgregarCupon_Click(sender As Object, e As EventArgs) Handles BtnAgregarCupon.Click
        Try
            AgregarCuponNuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub QuitarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitarToolStripMenuItem.Click
        Try
            If Grid_CuotaNueva.Rows.Count > 0 Then
                QuitarCuponNuevo()
            Else
                Throw New Exception("No hay cupón  posible de eliminar")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Fecha_Validated(sender As Object, e As EventArgs) Handles Fecha.Validated
        Try
            If DecTC.Value = 0 Then
                DecTC.Value = TipoCambio(Fecha.Value)(0)
            Else
                If MessageBox.Show("Desea Cambiar al Tipo de Cambio del dia?", "Mensaje del sistema", _
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) _
                   = Windows.Forms.DialogResult.Yes Then
                    DecTC.Value = TipoCambio(Fecha.Value)(0)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Grid_CuotaSel_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles Grid_CuotaSel.AfterCellUpdate
        Try
            If Len(Grid_CuotaSel.ActiveRow.Cells("Id").Value.ToString) > 0 Then
                Dim saldomenor As Double = 0.0
                With Grid_CuotaSel
                    If .ActiveRow.Cells("SaldoAdministrativo").Value > .ActiveRow.Cells("SaldoContable").Value Then
                        saldomenor = .ActiveRow.Cells("SaldoContable").Value
                    ElseIf .ActiveRow.Cells("SaldoContable").Value > .ActiveRow.Cells("SaldoAdministrativo").Value Then
                        saldomenor = .ActiveRow.Cells("SaldoAdministrativo").Value
                    Else
                        saldomenor = .ActiveRow.Cells("SaldoAdministrativo").Value
                    End If

                    If Math.Round(.ActiveRow.Cells("MontoOpera").Value, 2) > Math.Round(saldomenor, 2) Then
                        .ActiveRow.Cells("MontoOpera").Value = saldomenor
                    End If
                End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Grid_CuotaSel_CellChange(sender As Object, e As CellEventArgs) Handles Grid_CuotaSel.CellChange
        Try
            Grid_CuotaSel.UpdateData()
            MostrarSubtotales()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Grid_CuotaLista_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles Grid_CuotaLista.AfterCellUpdate
        Try
            If Len(Grid_CuotaLista.ActiveRow.Cells("Id").Value.ToString) > 0 Then
                Dim saldomenor As Double = 0.0
                With Grid_CuotaLista
                    If .ActiveRow.Cells("SaldoAdministrativo").Value > .ActiveRow.Cells("SaldoContable").Value Then
                        saldomenor = .ActiveRow.Cells("SaldoContable").Value
                    ElseIf .ActiveRow.Cells("SaldoContable").Value > .ActiveRow.Cells("SaldoAdministrativo").Value Then
                        saldomenor = .ActiveRow.Cells("SaldoAdministrativo").Value
                    Else
                        saldomenor = .ActiveRow.Cells("SaldoAdministrativo").Value
                    End If

                    If Math.Round(.ActiveRow.Cells("MontoOpera").Value, 2) > Math.Round(saldomenor, 2) Then
                        .ActiveRow.Cells("MontoOpera").Value = saldomenor
                    End If
                End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Grid_CuotaLista_CellChange(sender As Object, e As CellEventArgs) Handles Grid_CuotaLista.CellChange
        Try
            Grid_CuotaLista.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Grid_DocRefSel_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles Grid_DocRefSel.AfterCellUpdate
        Try
            If Len(Grid_DocRefSel.ActiveRow.Cells("Id").Value.ToString) > 0 Then
                Dim saldomenor As Double = 0.0
                With Grid_DocRefSel
                    saldomenor = .ActiveRow.Cells("Saldo").Value
                    If Math.Round(.ActiveRow.Cells("Aplica").Value, 2) > Math.Round(saldomenor, 2) Then
                        .ActiveRow.Cells("Aplica").Value = saldomenor
                    End If
                End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Grid_DocRefSel_CellChange(sender As Object, e As CellEventArgs) Handles Grid_DocRefSel.CellChange
        Try
            Grid_DocRefSel.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Grid_DocRefLista_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles Grid_DocRefLista.AfterCellUpdate
        Try
            If Len(Grid_DocRefLista.ActiveRow.Cells("Id").Value.ToString) > 0 Then
                Dim saldomenor As Double = 0.0
                With Grid_DocRefLista
                    saldomenor = .ActiveRow.Cells("Saldo").Value
                    If Math.Round(.ActiveRow.Cells("Aplica").Value, 2) > Math.Round(saldomenor, 2) Then
                        .ActiveRow.Cells("Aplica").Value = saldomenor
                    End If
                End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Grid_DocRefLista_CellChange(sender As Object, e As CellEventArgs) Handles Grid_DocRefLista.CellChange
        Try
            Grid_DocRefLista.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub GridCuotas_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles GridCuotas.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            e.Cancel = True
            mensajeEmergente.Problema("No tiene permisos paa eliminar un requerimiento")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub GridCuotas_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles GridCuotas.DoubleClickRow
        Try
            oeCuotaMovimientoPago.Activo = 1
            oeCuotaMovimientoPago.Id = ""
            oeCuotaMovimientoPago.IdCuota = GridCuotas.ActiveRow.Cells("IdCuota").Value
            oeCuotaMovimientoPago.IdCuotaDocVeh_Mov = ""
            oeCuotaMovimientoPago.TipoOperacion = "L"
            leCuotaMovimientoPago = olCuotaMovimientoPago.Listar(oeCuotaMovimientoPago)
            GridMovimientoAdministrativo.DataSource = leCuotaMovimientoPago.Where(Function(item) item.IdCuotaDocVeh_Mov = "T" Or item.IdCuotaDocVeh_Mov = "A").ToList
            CalcularTotales(GridMovimientoAdministrativo, "Monto")
            GridMovimientoAdministrativo.DataBind()
            GridMovimientoContable.DataSource = leCuotaMovimientoPago.Where(Function(item) item.IdCuotaDocVeh_Mov = "T" Or item.IdCuotaDocVeh_Mov = "C").ToList
            CalcularTotales(GridMovimientoContable, "Monto")
            GridMovimientoContable.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

    Private Sub frm_CuponesSeguros_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            If TabContenido.Tabs(0).Selected = True Then
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            ElseIf TabContenido.Tabs(1).Selected = True Then
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_CuponesSeguros_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub
End Class