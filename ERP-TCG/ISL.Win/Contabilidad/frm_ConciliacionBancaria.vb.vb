'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win.UltraWinGrid

Public Class frm_ConciliacionBancaria
    Inherits frm_MenuPadre

#Region "Instancia"

    Private Shared instancia As frm_ConciliacionBancaria = Nothing
    Private Shared Operacion As String

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ConciliacionBancaria()
        End If
        instancia.Activate()
        Return instancia

    End Function

#End Region

#Region "Declaracion de Variables"

    Private leMovimientosBancarios As New List(Of e_MovimientoCajaBanco)
    Private olMovimientosBancarios As New l_MovimientoCajaBanco
    Private oeMovimientosBancarios As New e_MovimientoCajaBanco
    Private leCtaBancaria As New List(Of e_CuentaBancaria)
    Private oeCtaBancaria As New e_CuentaBancaria
    Private oePeriodo As New e_Periodo
    Private olPeriodo As New l_Periodo
    Private _ComboPeriodo As Boolean = False

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            If gridMovimientoBancarios.Rows.Count > 0 Then
                ControlBoton(1, 0, 0, 1, 0, 0, 0, 1, 1) 'activa desactiva botonera
            Else
                ControlBoton(1, 0, 0, 1, 0, 0, 0, 1, 1) 'activa desactiva botonera
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        'Inicializar()
        MyBase.Nuevo() 'activa desactiva botonera
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarConciliacion() Then
                ControlBoton(1, 0, 0, 1, 0, 0, 0, 1, 1) 'activa desactiva botonera
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            ControlBoton(1, 0, 0, 1, 0, 0, 0, 1, 1) 'activa desactiva botonera
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If gridMovimientoBancarios.Rows.Count = 0 Then Throw New Exception("No hay ninguna Conciliación Bancaria para exportar al Excel")
            Exportar_Excel(gridMovimientoBancarios)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Function GuardarConciliacion() As Boolean
        Try
            If VerificarRegistroSeleccionado() Then
                oeMovimientosBancarios = New e_MovimientoCajaBanco
                With oeMovimientosBancarios
                    For Each obj As e_MovimientoCajaBanco In leMovimientosBancarios
                        If obj.Seleccion = True Then
                            ._Ids = ._Ids + obj.Id + ","
                        End If
                    Next
                    ._Ids = Strings.Left(._Ids, Strings.Len(._Ids) - 1)
                    .TipoOperacion = IIf(chkConciliado.Checked, "X", "C")
                    .IdPeriodoConcilia = cboMes.Value
                End With
                oeMovimientosBancarios.PrefijoID = gs_PrefijoIdSucursal '@0001
                olMovimientosBancarios.GuardarConciliacion(oeMovimientosBancarios)
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente", True)
                Consultar(True)
                Return True
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Function VerificarRegistroSeleccionado() As Boolean
        Try
            Dim leMovBanc As New List(Of e_MovimientoCajaBanco)
            leMovBanc = leMovimientosBancarios.Where(Function(item) item.Seleccion = True).ToList
            If leMovBanc.Count = 0 Then Throw New Exception("Seleccione al menos un registro")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            ' Inicializar y Validar Datos
            DecSaldoInicial.Value = 0
            DecTotalCheck.Value = 0
            DecSaldoFinal.Value = 0
            ValidarCombo(cboCtaBancaria, "Cuenta Bancaria")
            Me.Cursor = Cursors.WaitCursor
            If chkConciliado.Checked Then
                ' Obtener Registros Conciliados
                If cboMes.SelectedIndex = -1 Then Throw New Exception("¡Seleccione Mes!")
                oeMovimientosBancarios = New e_MovimientoCajaBanco
                oeMovimientosBancarios.Activo = 1
                oeMovimientosBancarios.TipoOperacion = "X"
                oeMovimientosBancarios.IdCuentaBancaria = oeCtaBancaria.Id
                oeMovimientosBancarios.IdPeriodoConcilia = cboMes.Value
                leMovimientosBancarios.Clear()
                leMovimientosBancarios.AddRange(olMovimientosBancarios.Listar(oeMovimientosBancarios))
            Else
                ' Obtener Saldo de Cuenta Bancaria
                oeMovimientosBancarios = New e_MovimientoCajaBanco
                oeMovimientosBancarios.Activo = Activo
                oeMovimientosBancarios._Conciliado = 1
                oeMovimientosBancarios._Ejercicio = Año1.Año
                oeMovimientosBancarios.IdCuentaBancaria = cboCtaBancaria.Value
                oeMovimientosBancarios.TipoOperacion = "S"
                leMovimientosBancarios.Clear()
                leMovimientosBancarios.AddRange(olMovimientosBancarios.Listar(oeMovimientosBancarios))
                If leMovimientosBancarios.Count > 0 Then
                    If oeCtaBancaria.IdMoneda = "1CH01" Then 'SOLES
                        DecSaldoInicial.Value = leMovimientosBancarios(0).TotalMN
                    Else
                        DecSaldoInicial.Value = leMovimientosBancarios(0).TotalME
                    End If
                Else
                    DecSaldoInicial.Value = 0
                End If
                ' Obtener Registros Pendientes por Conciliar
                oeMovimientosBancarios.TipoOperacion = ""
                oeMovimientosBancarios._Conciliado = 0
                leMovimientosBancarios.Clear()
                leMovimientosBancarios.AddRange(olMovimientosBancarios.Listar(oeMovimientosBancarios))
                leMovimientosBancarios.OrderBy(Function(i) i.Fecha).ToList()
            End If
            'Ubica el cursor en el primer registro de la grilla
            With gridMovimientoBancarios
                .DataBind()
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CargaMaestros()
        FlujoCaja()
        CuentaBancaria()
        MedioPago()
        ComboPerido()
    End Sub

    Private Sub FlujoCaja()
        Try
            Dim oeFlujo As New e_FlujoCaja
            Dim leFlujo As New List(Of e_FlujoCaja)
            Dim olFlujo As New l_FlujoCaja
            oeFlujo.Activo = True
            leFlujo.AddRange(olFlujo.Listar(oeFlujo))
            '--------------------- para llenar combo en grilla    
            With gridMovimientoBancarios.DisplayLayout
                If .Bands(0).Columns.Exists("IdFlujoCaja") Then
                    .ValueLists.Clear()
                    .ValueLists.Add("IdFlujoCaja")
                End If
            End With
            With gridMovimientoBancarios.DisplayLayout.ValueLists("IdFlujoCaja").ValueListItems
                .Clear()
                For Each oeTD As e_FlujoCaja In leFlujo
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdFlujoCaja", "Nombre", gridMovimientoBancarios, True)
            '------------------------------------------

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CuentaBancaria()
        Try
            If cboCtaBancaria.Items.Count = 0 Then
                Dim oeCtaBancaria As New e_CuentaBancaria
                Dim olCtaBancaria As New l_CuentaBancaria
                oeCtaBancaria.Activo = True
                leCtaBancaria.AddRange(olCtaBancaria.Listar(oeCtaBancaria))
                '--------------------- para llenar combo en grilla    
                With gridMovimientoBancarios.DisplayLayout
                    If .Bands(0).Columns.Exists("IdCuentaBancaria") Then
                        .ValueLists.Clear()
                        .ValueLists.Add("IdCuentaBancaria")
                    End If
                End With
                With gridMovimientoBancarios.DisplayLayout.ValueLists("IdCuentaBancaria").ValueListItems
                    .Clear()
                    For Each oeTD As e_CuentaBancaria In leCtaBancaria
                        .Add(oeTD.Id, oeTD.NumeroCuenta)
                    Next
                End With
                CrearComboGrid3("IdCuentaBancaria", "NumeroCuenta", gridMovimientoBancarios, True)
                '------------------------------------------
                With cboCtaBancaria
                    .ValueMember = "Id"
                    .DisplayMember = "BancoCuenta"
                    .DataSource = leCtaBancaria
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MedioPago()
        Try
            Dim oeMedioPago As New e_MedioPago
            Dim olMedioPago As New l_MedioPago
            Dim leMedioPago As New List(Of e_MedioPago)
            oeMedioPago.Activo = True
            leMedioPago.AddRange(olMedioPago.Listar(oeMedioPago))
            '--------------------- para llenar combo en grilla    
            With gridMovimientoBancarios.DisplayLayout
                If .Bands(0).Columns.Exists("IdMedioPago") Then
                    .ValueLists.Clear()
                    .ValueLists.Add("IdMedioPago")
                End If
            End With
            With gridMovimientoBancarios.DisplayLayout.ValueLists("IdMedioPago").ValueListItems
                .Clear()
                For Each oeTD As e_MedioPago In leMedioPago
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdMedioPago", "Nombre", gridMovimientoBancarios, True)
            '------------------------------------------

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboPerido()
        Try
            If _ComboPeriodo = True Then
                Dim lePeriodo As New List(Of e_Periodo)
                lePeriodo.AddRange(ObtenerPeriodoActivo(Año1.Año))

                LlenaComboMes(cboMes, lePeriodo)

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SumarTotales()
        Try
            Dim SumaDeCheck As Double = 0
            For Each obj As e_MovimientoCajaBanco In leMovimientosBancarios
                If obj.Seleccion = True Then
                    If oeCtaBancaria.IdMoneda = "1CH01" Then 'SOLES
                        SumaDeCheck = SumaDeCheck + obj.TotalMN
                    Else
                        SumaDeCheck = SumaDeCheck + obj.TotalME
                    End If
                End If
            Next
            DecTotalCheck.Value = SumaDeCheck
            DecSaldoFinal.Value = DecSaldoInicial.Value + SumaDeCheck
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub Año1_DatoCambiado() Handles Año1.DatoCambiado
        Try
            ComboPerido()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_ConciliacionBancaria_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 1, 0, 0, 0, 1, 1)
    End Sub

    Private Sub frm_ConciliacionBancaria_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ConciliacionBancaria_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case _Operacion
            Case "Nuevo"
                Me.Activate()
                Me.Cancelar()

            Case "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_ConciliacionBancaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
        gridMovimientoBancarios.DataSource = leMovimientosBancarios
        _ComboPeriodo = True
        CargaMaestros()
    End Sub

    Private Sub gridMovimientoBancarios_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles gridMovimientoBancarios.CellChange
        Try
            If Not IsDBNull(gridMovimientoBancarios.ActiveRow.Cells("Id").Value) Then
                gridMovimientoBancarios.UpdateData()
                SumarTotales()
                If gridMovimientoBancarios.ActiveRow.Cells("Seleccion").Value = True Then
                    gridMovimientoBancarios.ActiveRow.CellAppearance.BackColor = Color.Moccasin
                Else
                    gridMovimientoBancarios.ActiveRow.CellAppearance.BackColor = Color.White
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboCtaBancaria_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCtaBancaria.ValueChanged
        Dim i As Integer = cboCtaBancaria.SelectedIndex
        oeCtaBancaria = New e_CuentaBancaria
        oeCtaBancaria = cboCtaBancaria.Items(i).ListObject
    End Sub

    Private Sub gridMovimientoBancarios_BeforeRowsDeleted(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles gridMovimientoBancarios.BeforeRowsDeleted
        Try
            e.Cancel = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridMovimientoBancarios_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles gridMovimientoBancarios.DoubleClickRow
        If Not IsNothing(gridMovimientoBancarios.ActiveRow.Cells("Id")) Then
            If gridMovimientoBancarios.ActiveRow.Cells("Seleccion").Value = True Then
                gridMovimientoBancarios.ActiveRow.Cells("Seleccion").Value = False
            Else
                gridMovimientoBancarios.ActiveRow.Cells("Seleccion").Value = True
            End If
            gridMovimientoBancarios.UpdateData()
            SumarTotales()
            If gridMovimientoBancarios.ActiveRow.Cells("Seleccion").Value = True Then
                gridMovimientoBancarios.ActiveRow.CellAppearance.BackColor = Color.Moccasin
            Else
                gridMovimientoBancarios.ActiveRow.CellAppearance.BackColor = Color.White
            End If
        End If
    End Sub

    Private Sub gridMovimientoBancarios_AfterHeaderCheckStateChanged(sender As Object, e As Infragistics.Win.UltraWinGrid.AfterHeaderCheckStateChangedEventArgs) Handles gridMovimientoBancarios.AfterHeaderCheckStateChanged
        Try
            Dim column As UltraGridColumn = e.Column
            Dim rows As RowsCollection = e.Rows
            Dim checkStateValue = column.GetHeaderCheckedState(rows)
            For Each row In gridMovimientoBancarios.Rows.Where(Function(item) item.IsFilteredOut = False)
                row.Cells("Seleccion").Value = checkStateValue
            Next
            gridMovimientoBancarios.UpdateData()
            SumarTotales()
            For i = 0 To gridMovimientoBancarios.Rows.Count - 1
                If gridMovimientoBancarios.Rows(i).Cells("Seleccion").Value = True Then
                    gridMovimientoBancarios.Rows(i).CellAppearance.BackColor = Color.Moccasin
                Else
                    gridMovimientoBancarios.Rows(i).CellAppearance.BackColor = Color.White
                End If
            Next
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub chkConciliado_CheckedChanged(sender As Object, e As EventArgs) Handles chkConciliado.CheckedChanged
        If gridMovimientoBancarios.Rows.Count > 0 Then
            leMovimientosBancarios.Clear()
            gridMovimientoBancarios.DataSource = leMovimientosBancarios
            gridMovimientoBancarios.DataBind()
        End If
    End Sub

#End Region

End Class
