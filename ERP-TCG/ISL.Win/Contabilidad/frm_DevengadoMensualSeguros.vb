'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF

Public Class frm_DevengadoMensualSeguros
    Inherits frm_MenuPadre

#Region "Declaración de variables"

    Private oePeriodo As New e_Periodo
    Private dtPolizas As DataTable
    Private dtSoat As DataTable
    Private oeMoneda As New e_Moneda

    Private Shared instancia As frm_DevengadoMensualSeguros = Nothing
    Private Shared Operacion As String

#End Region

#Region "Definición del Formulario base"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_DevengadoMensualSeguros()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            If tcSeguros.Tabs(0).Selected = True And tcSeguros.Tabs(1).Selected = False Then
                Listar("OPE")
            ElseIf tcSeguros.Tabs(1).Selected = True And tcSeguros.Tabs(0).Selected = False Then
                Listar("DVS")
            End If
            Operacion = "Inicializa"

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            Dim olAsiento As New l_Asiento
            ValidarCombo(cboMoneda, "Moneda")
            ValidarCombo(cboMes, "Mes")
            If decTC.Value = 0 Then
                Throw New Exception("Ingrese tipo de cambio")
            End If
            If tcSeguros.Tabs(0).Selected = True And tcSeguros.Tabs(1).Selected = False Then
                olAsiento.GuardarSegurosDevengados(dtPolizas, oePeriodo, gUsuarioSGI.Id, oeMoneda, decTC.Value, "POLIZA", gs_PrefijoIdSucursal)
            ElseIf tcSeguros.Tabs(1).Selected = True And tcSeguros.Tabs(0).Selected = False Then
                olAsiento.GuardarSegurosDevengados(dtSoat, oePeriodo, gUsuarioSGI.Id, oeMoneda, decTC.Value, "SOAT", gs_PrefijoIdSucursal)
            End If
            mensajeEmergente.Confirmacion("Ingreso correcto de seguros")
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
            If tcSeguros.Tabs(0).Selected = True And tcSeguros.Tabs(1).Selected = False Then
                If gridPolizas.Rows.Count = 0 Then Throw New Exception("No hay ninguna Cuenta General para exportar al Excel")
                Exportar_Excel(gridPolizas)
            ElseIf tcSeguros.Tabs(1).Selected = True And tcSeguros.Tabs(0).Selected = False Then
                If GridSoat.Rows.Count = 0 Then Throw New Exception("No hay ninguna Cuenta General para exportar al Excel")
                Exportar_Excel(GridSoat)
            End If

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Métodos"

    Private Sub Listar(ByVal Tipo As String)
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim olAsiento As New l_Asiento
            If tcSeguros.Tabs(0).Selected = True And tcSeguros.Tabs(1).Selected = False Then
                dtPolizas = olAsiento.ListarDevengadoSeguros(dtpFechaVenc.Value, Tipo, "")
                gridPolizas.DataSource = dtPolizas
                gridPolizas.DataBind()
            ElseIf tcSeguros.Tabs(1).Selected = True And tcSeguros.Tabs(0).Selected = False Then
                dtSoat = olAsiento.ListarDevengadoSeguros(oePeriodo.FechaInicio, Tipo, "")

                Dim fechainicio As Date = oePeriodo.FechaInicio
                Dim fechafin As Date = oePeriodo.FechaInicio.AddMonths(1)
                Dim dias As Integer = DateDiff(DateInterval.Day, fechainicio, fechafin)

                For Each RegSoat As DataRow In dtSoat.Rows
                    If RegSoat.Item("FechaVencimiento") < fechafin Then

                    Else
                        RegSoat.Item("TotalAsientoMes") = dias * RegSoat.Item("ImporteBI") / RegSoat.Item("Dias")
                    End If
                Next

                dtSoat.AcceptChanges()
                Grid_Soat.DataSource = dtSoat
                Grid_Soat.DataBind()
            End If
        Catch ex As Exception
            Throw ex
            Me.Cursor = Cursors.Default
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mostrar_totales(ByVal oFila As DataRowView)
        Try
            oFila.Item("TotalxVehiculo") = oFila.Item("Devengado") / oFila.Item("Total")
            oFila.Item("TotalAsiento") = oFila.Item("Devengado") * (oFila.Item("Total") - oFila.Item("Excluido")) / oFila.Item("Total")

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ComboPerido()
        Try
            If oePeriodo.Ejercicio <> Año1.Año Then
                oePeriodo = New e_Periodo
                Dim olPeriodo As New l_Periodo
                Dim lePeriodo As New List(Of e_Periodo)
                oePeriodo.Ejercicio = Año1.Año
                oePeriodo.Activo = True
                lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))
                With cboMes
                    .DisplayMember = "Mes"
                    .ValueMember = "Id"
                    .DataSource = lePeriodo
                    If .Items.Count > 0 Then
                        .Text = Date.Now.Month
                    End If
                End With
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ComboMoneda()
        Try

            Dim olMoneda As New l_Moneda
            Dim leMoneda As New List(Of e_Moneda)
            oeMoneda.Activo = True
            leMoneda.AddRange(olMoneda.Listar(oeMoneda))
            With cboMoneda
                .DisplayMember = "Nombre"
                .ValueMember = "Id"
                .DataSource = leMoneda
            End With
            cboMoneda.Value = "1CH02"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_CuentasGenerales_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 1, 0, 0, 0, 1, 1)
    End Sub

    Private Sub frm_CuentasGenerales_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_CuentasGenerales_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case Operacion
            Case "Nuevo"
                Me.Activate()
                Me.Cancelar()

            Case "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        If Not e.Cancel Then
            ControlBoton(1, 0, 0, 1, 0, 0, 0, 1, 1)
        End If
    End Sub

    Private Sub frm_CuentasGenerales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ControlBoton(1, 0, 0, 1, 0, 0, 0, 1, 1)
            InicializaTiempo()
            Me.Año1.Año = Date.Now.Year
            ComboPerido()
            ComboMoneda()

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub gridPolizas_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles gridPolizas.CellChange
        Try
            gridPolizas.UpdateData()
            Dim ofila As DataRowView = gridPolizas.ActiveRow.ListObject
            If IsNumeric(ofila.Item("Excluido")) Then
                gridPolizas.UpdateData()
                If ofila.Item("Excluido") > ofila.Item("Total") Then
                    e.Cell.Value = 0
                    gridPolizas.UpdateData()
                    Throw New Exception("El monto ingresado es mayor al total de vehiculos")
                End If
                mostrar_totales(ofila)
            Else
                e.Cell.Value = 0
                mostrar_totales(ofila)
                gridPolizas.UpdateData()
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboMes_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMes.ValueChanged
        If cboMes.SelectedIndex <> -1 Then
            oePeriodo = cboMes.Items(cboMes.SelectedIndex).ListObject
        End If
    End Sub

    Private Sub cboMoneda_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMoneda.ValueChanged
        If cboMoneda.SelectedIndex <> -1 Then
            oeMoneda = cboMoneda.Items(cboMoneda.SelectedIndex).ListObject
        End If
    End Sub

    Private Sub dtpFechaVenc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaVenc.ValueChanged
        Try
            If decTC.Value = 0 Then
                decTC.Value = TipoCambio(dtpFechaVenc.Value)(0)
            Else
                If MessageBox.Show("Desea Cambiar al Tipo de Cambio del dia?", "Mensaje del sistema", _
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) _
                   = Windows.Forms.DialogResult.Yes Then
                    decTC.Value = TipoCambio(dtpFechaVenc.Value)(0)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

    Private Sub chkCalculadora_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCalculadora.CheckedChanged
        If chkCalculadora.Checked Then
            If tcSeguros.Tabs(0).Selected = True And tcSeguros.Tabs(1).Selected = False Then
                For i As Integer = 0 To dtPolizas.Rows.Count - 1
                    dtPolizas.Rows(i).Item("Seleccion") = 1
                Next
            ElseIf tcSeguros.Tabs(1).Selected = True And tcSeguros.Tabs(0).Selected = False Then
                For i As Integer = 0 To dtSoat.Rows.Count - 1
                    dtSoat.Rows(i).Item("Seleccion") = 1
                Next
            End If
        Else
            If tcSeguros.Tabs(0).Selected = True And tcSeguros.Tabs(1).Selected = False Then
                For i As Integer = 0 To dtPolizas.Rows.Count - 1
                    dtPolizas.Rows(i).Item("Seleccion") = 0
                Next
            ElseIf tcSeguros.Tabs(1).Selected = True And tcSeguros.Tabs(0).Selected = False Then
                For i As Integer = 0 To dtSoat.Rows.Count - 1
                    dtSoat.Rows(i).Item("Seleccion") = 0
                Next
            End If
        End If
    End Sub

    Private Sub tcSeguros_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles tcSeguros.SelectedTabChanged
        Try
            If tcSeguros.Tabs(0).Selected = True Then
                cboMoneda.Value = "1CH02"
            ElseIf tcSeguros.Tabs(1).Selected = True Then
                cboMoneda.Value = "1CH01"
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub


    Private Sub Año1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Año1.Validated
        ComboPerido()
    End Sub

End Class
