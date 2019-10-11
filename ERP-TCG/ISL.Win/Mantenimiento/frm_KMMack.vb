'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF

Public Class frm_KMMack
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_KMMack = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_KMMack()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Variables"

    Private oeKmMack As e_KmMack : Private olKmMack As l_KmMack : Private loKmMack As List(Of e_KmMack)
    Private oeKmMackDet As e_KmMackDet : Private olKmMackDet As l_KmMackDet : Private loKmMackDet As List(Of e_KmMackDet)

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Listar()
            Tiempo1.Enabled = True
            ControlBotones()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            Operacion = "Nuevo"
            Inicializar()
            CargarEquipos()
            SeleccionTabs(1, ficKmMack)
            ControlBotones()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            If griKmMack.Selected.Rows.Count > 0 Then
                Operacion = "Editar"
                Inicializar()
                Mostrar()
                MostrarTabs(1, ficKmMack, 1)
                ControlBotones()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarKm() Then
                mensajeEmergente.Confirmacion("La Informacion ha Sido Guardada Correctamente", True)
                MostrarTabs(0, ficKmMack, 0)
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            SeleccionTabs(0, ficKmMack)
            Consultar(True)
            ControlBotones()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If ficKmMack.Tabs(0).Selected AndAlso griKmMack.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griKmMack)
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

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_KMMack_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ControlBotones()
    End Sub

    Private Sub frm_KMMack_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_KMMack_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_KMMack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gmt_ConfigurarEventoKeyEnter_Tab(Me)
        gf_AsignarEventoSeleccionarTexto(Me)
        DateTimePicker1.Value = Date.Now.AddMonths(-10)
        InicializaLogicas()
    End Sub

    Private Sub griKmMackDet_AfterCellUpdate(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griKmMackDet.AfterCellUpdate
        Try
            If griKmMackDet.Rows.Count > 0 Then
                Dim Inicio As Double = 0
                Dim Fin As Double = 0
                Select Case e.Cell.Column.Key
                    Case "KmInicial", "KmFinal"
                        With griKmMackDet.Rows(e.Cell.Row.Index)
                            Inicio = .Cells("KmInicial").Value
                            Fin = .Cells("KmFinal").Value
                            .Cells("KmTotal").Value = Fin - Inicio
                            .Cells("Importe").Value = Math.Round(.Cells("KmTotal").Value * numCostoxKm.Value, 4)
                        End With
                End Select
                Totales()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griKmMackDet_CellChange(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griKmMackDet.CellChange
        griKmMackDet.UpdateData()
    End Sub

    Private Sub griKmMackDet_KeyDown(sender As Object, e As KeyEventArgs) Handles griKmMackDet.KeyDown
        With griKmMackDet
            Dim int As Integer = .ActiveRow.Index
            If e.KeyCode = Keys.Down Then
                If .Rows(int).Cells("KmInicial").IsActiveCell Or .Rows(int).Cells("KmFinal").IsActiveCell Then
                    .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ExitEditMode, False, False)
                    .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.BelowCell, False, False)
                    e.Handled = True
                    .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                End If
            End If
            If e.KeyCode = Keys.Up Then
                If .Rows(int).Cells("KmInicial").IsActiveCell Or .Rows(int).Cells("KmFinal").IsActiveCell Then
                    .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ExitEditMode, False, False)
                    .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.AboveCell, False, False)
                    e.Handled = True
                    .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                End If
            End If
        End With
    End Sub

    Private Sub griKmMack_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles griKmMack.DoubleClickRow
        Try
            Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtSerie_Validated(sender As Object, e As EventArgs) Handles txtSerie.Validated
        txtSerie.Text = FormatoDocumento(txtSerie.Text.Trim, 4)
    End Sub

    Private Sub txtNumero_Validated(sender As Object, e As EventArgs) Handles txtNumero.Validated
        txtNumero.Text = FormatoDocumento(txtNumero.Text.Trim, 10)
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        numTC.Value = TipoCambio(dtpFecha.Value, True)(0)
    End Sub

#End Region

#Region "Metodos"

    Private Sub InicializaLogicas()
        olKmMack = New l_KmMack
        olKmMackDet = New l_KmMackDet
    End Sub

    Private Sub Inicializar()
        oeKmMack = New e_KmMack
        oeKmMackDet = New e_KmMackDet
        loKmMackDet = New List(Of e_KmMackDet)
        griKmMackDet.DataSource = loKmMackDet
        griKmMackDet.DataBind()
        txtCodigo.Text = String.Empty
        txtEstado.Text = "POR GENERAR"
        dtpFecha.Value = Date.Now
        numCostoxKm.Value = 0.0322
        numTC.Value = TipoCambio(dtpFecha.Value, True)(0)
        numTotal.Value = 0
        txtSerie.Text = String.Empty
        txtNumero.Text = String.Empty
    End Sub

    Private Sub ControlBotones()
        Select Case ficKmMack.SelectedTab.Index
            Case 0
                If griKmMack.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 1, 0, 1, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 1)
        End Select
    End Sub

    Private Sub Listar()
        Try
            oeKmMack = New e_KmMack
            loKmMack = New List(Of e_KmMack)
            oeKmMack.Fecha = DateTimePicker1.Value
            oeKmMack.FechaCreacion = DateTimePicker2.Value
            loKmMack = olKmMack.Listar(oeKmMack)
            griKmMack.DataSource = loKmMack
            griKmMack.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Mostrar()
        Try
            oeKmMack.Id = griKmMack.ActiveRow.Cells("Id").Value
            oeKmMack.TipoOperacion = ""
            oeKmMack = olKmMack.Obtener(oeKmMack)
            txtCodigo.Value = oeKmMack.Codigo
            txtEstado.Text = oeKmMack.Estado
            dtpFecha.Value = oeKmMack.Fecha
            numCostoxKm.Value = oeKmMack.CostoKm
            numTC.Value = oeKmMack.TipoCambio
            numTotal.Value = oeKmMack.Total
            txtSerie.Value = oeKmMack.Serie
            txtNumero.Value = oeKmMack.Numero
            oeKmMackDet.IdKmMack = oeKmMack.Id
            oeKmMackDet.TipoOperacion = ""
            loKmMackDet = olKmMackDet.Listar(oeKmMackDet)
            griKmMackDet.DataSource = loKmMackDet
            griKmMackDet.DataBind()
            Totales()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarKm() As Boolean
        Try
            LlenaObjeto()
            oeKmMack.PrefijoID = gs_PrefijoIdSucursal '@0001
            If Not olKmMack.Guardar(oeKmMack) Then Return False
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub LlenaObjeto()
        Try
            If ValidarKm() Then
                With oeKmMack
                    .TipoOperacion = IIf(Operacion = "Nuevo", "I", "A")
                    .Codigo = txtCodigo.Text
                    .IdEstado = "1CH00014"
                    .Fecha = dtpFecha.Value
                    .CostoKm = numCostoxKm.Value
                    .TipoCambio = numTC.Value
                    .Total = numTotal.Value
                    .Serie = FormatoDocumento(txtSerie.Text, 4)
                    .Numero = FormatoDocumento(txtNumero.Text, 10)
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .loKmMackDet = New List(Of e_KmMackDet)
                    .loKmMackDet.AddRange(loKmMackDet)
                End With
            End If        
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidarKm() As Boolean
        Try
            For Each oe In loKmMackDet
                If oe.Importe < 0 Then Throw New Exception("Importe Negativo. Verificar")
            Next
            If numTC.Value = 0 Then Throw New Exception("Ingrese Tipo Cambio")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CargarEquipos()
        Try
            oeKmMack = New e_KmMack
            oeKmMack.TipoOperacion = "1"
            oeKmMack = olKmMack.Obtener(oeKmMack)
            txtCodigo.Text = FormatoDocumento(CStr(CInt(oeKmMack.Codigo) + 1), 8)
            oeKmMackDet = New e_KmMackDet
            oeKmMackDet.TipoOperacion = "1"
            loKmMackDet = olKmMackDet.Listar(oeKmMackDet)
            griKmMackDet.DataSource = loKmMackDet
            griKmMack.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Totales()
        Try
            numTotal.Value = loKmMackDet.Sum(Function(i) i.Importe)
            CalcularTotales(griKmMackDet, "Importe")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class