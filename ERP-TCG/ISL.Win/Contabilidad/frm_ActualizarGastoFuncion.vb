'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_ActualizarGastoFuncion

#Region "Inicializar"

    Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub New(ls_TipoGasto As String, ls_Cuenta As String, ls_NombreCuenta As String, ln_Ejercicio As Integer, ls_IdPeriodo As String, ls_IdItemGasto As String)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _TipoGasto = ls_TipoGasto
        _Cuenta = ls_Cuenta
        _NombreCuenta = ls_NombreCuenta
        _Ejercicio = ln_Ejercicio
        _IdPeriodo = ls_IdPeriodo
        _IdItemGasto = ls_IdItemGasto

    End Sub

#End Region

#Region "Declaracion de Variables"

    Private oeGastoFuncion As e_TablaContableDet, olGastoFuncion As l_TablaContableDet, leGastoFuncion As List(Of e_TablaContableDet)
    Private oeCtaContable As e_CuentaContable, olCtaContable As l_CuentaContable, leCtaContable As List(Of e_CuentaContable)
    Private oeItemGasto As e_ItemGasto, olItemGasto As l_ItemGasto
    Private oeGastoAsiento As e_GastoAsiento, olGastoAsiento As l_GastoAsiento, leGastoAsiento As List(Of e_GastoAsiento)
    Private _TipoGasto As String, _Cuenta As String, _NombreCuenta As String, _IdPeriodo As String, _IdItemGasto As String
    Private _Ejercicio As Integer
    Public mensajeEmergente As New c_Alertas
    Private ds As DataSet
    Private _Imagen As System.Drawing.Bitmap

#End Region

#Region "Eventos"

    Private Sub frm_ActualizarGastoFuncion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mt_InicializarLogica()
            mt_CargarIconos()
            mt_CargarCombos()
            cboTipoGasto.Text = _TipoGasto.Trim
            cboCuenta.Value = _Cuenta.Trim
            txtCuenta.Text = _NombreCuenta.Trim
            mt_CargarDatos()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDatos_ClickCellButton(sender As Object, e As CellEventArgs) Handles griDatos.ClickCellButton
        Try
            If griDatos.ActiveRow.Index > -1 Then
                If MessageBox.Show("¿Desea Actualizar?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    If IsDBNull(griDatos.ActiveRow.Cells("IdItemGasto").Value) Then Throw New Exception("¡Seleccione un item Gastos!")
                    Dim oeMovAsi As New e_MovimientoAnalisis, olMovAsi As New l_MovimientoAnalisis
                    oeMovAsi.TipoOperacion = "Z"
                    oeMovAsi.Id = griDatos.ActiveRow.Cells("IdMovimientoAnalisis").Value
                    oeMovAsi.IdItemGasto = griDatos.ActiveRow.Cells("IdItemGasto").Value
                    oeMovAsi.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olMovAsi.Guardar(oeMovAsi) Then
                        mensajeEmergente.Confirmacion("¡Se Actualizo Correctamente!")
                        griDatos.UpdateData()
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub mt_InicializarLogica()
        olGastoFuncion = New l_TablaContableDet
        olCtaContable = New l_CuentaContable
        olItemGasto = New l_ItemGasto
        olGastoAsiento = New l_GastoAsiento
    End Sub

    Private Sub mt_CargarIconos()
        Try
            For Each oItem In gLstIconos
                Select Case oItem.Nombre
                    Case "Grabar" : _Imagen = oItem.Icono
                End Select
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarCombos()
        Try
            ' Cargar Gasto Funcion
            oeGastoFuncion = New e_TablaContableDet : leGastoFuncion = New List(Of e_TablaContableDet)
            oeGastoFuncion.TipoOperacion = "N"
            oeGastoFuncion.Nombre = "GASTO FUNCION"
            oeGastoFuncion.Activo = True
            oeGastoFuncion.Logico2 = 1
            leGastoFuncion = olGastoFuncion.Listar(oeGastoFuncion)
            LlenarCombo(cboTipoGasto, "Nombre", leGastoFuncion, -1)
            ' Cargar Cuentas
            oeCtaContable = New e_CuentaContable : leCtaContable = New List(Of e_CuentaContable)
            oeCtaContable.Ejercicio = _Ejercicio
            oeCtaContable.Movimiento = 1
            leCtaContable = olCtaContable.Listar(oeCtaContable)
            LlenarCombo(cboCuenta, "Cuenta", leCtaContable, -1)
            ' Cargar Item Gasto
            oeItemGasto = New e_ItemGasto
            oeItemGasto.IdCuentaContable = _Cuenta
            oeItemGasto.Ejercicio = _Ejercicio
            oeItemGasto.Activo = True
            ds = olItemGasto.ListarDS(oeItemGasto)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarDatos()
        Try
            oeGastoAsiento = New e_GastoAsiento : leGastoAsiento = New List(Of e_GastoAsiento)
            oeGastoAsiento.TipoOperacion = "1"
            oeGastoAsiento.IdPeriodo = _IdPeriodo
            oeGastoAsiento.IdGastoOperacion = cboTipoGasto.Value
            oeGastoAsiento.IdCuentaContable = _Cuenta.Trim
            oeGastoAsiento.IdItemGasto = _IdItemGasto
            griDatos.ResetDisplayLayout()
            griDatos.DataSource = olGastoAsiento.ListarGAFAnalisis(oeGastoAsiento)
            CrearComboGrid("IdItemGasto", "Nombre", griDatos, ds.Tables(0), True)
            ConfiguraGrilla(griDatos, "Tahoma", True, UIElementBorderStyle.Default, "IdItemGasto", "Editar")
            OcultarColumna2(griDatos, False, "NroAsiento", "Cuenta", "IdItemGasto", "Editar", "Glosa")
            griDatos.DisplayLayout.Bands(0).Columns("NroAsiento").Width = 70
            griDatos.DisplayLayout.Bands(0).Columns("Cuenta").Width = 60
            griDatos.DisplayLayout.Bands(0).Columns("Editar").Width = 35
            griDatos.DisplayLayout.Bands(0).Columns("IdItemGasto").Width = 250
            griDatos.DisplayLayout.Bands(0).Columns("Glosa").Width = 400
            FormatoColumna(griDatos, "", ColumnStyle.Button, HAlign.Default, "Editar")
            griDatos.DisplayLayout.Bands(0).Columns("Editar").CellButtonAppearance.Image = _Imagen
            griDatos.DisplayLayout.Bands(0).Columns("Editar").CellButtonAppearance.ImageHAlign = HAlign.Center
            griDatos.DisplayLayout.Bands(0).Columns("Editar").ButtonDisplayStyle = UltraWinGrid.ButtonDisplayStyle.Always

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class