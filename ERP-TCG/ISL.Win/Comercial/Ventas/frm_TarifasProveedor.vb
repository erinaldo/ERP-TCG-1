'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_TarifasProveedor
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializacion del Formulario"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_TarifasProveedor()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    Public WithEvents oeTarifasProveedor As New e_TarifasProveedor
    Private olTarifasProveedor As New l_TarifasProveedor
    Private loTarifasProveedor As New List(Of e_TarifasProveedor)

    Private IdProveedorObj As String = ""
    Private IdFlujoCajaObj As String = ""
    Private IdMaterialObj As String = ""
    Private IdClienteObj As String = ""

    Private Shared instancia As frm_TarifasProveedor = Nothing

#End Region

#Region "Metodo"

    Public Sub Listar(ByVal IdProveedor As String, ByVal IdFlujoCaja As String, IdMaterial As String, IdCliente As String)
        Try
            oeTarifasProveedor = New e_TarifasProveedor
            IdProveedorObj = IdProveedor
            IdFlujoCajaObj = IdFlujoCaja
            IdMaterialObj = IdMaterial
            IdClienteObj = IdCliente
            oeTarifasProveedor.TipoOperacion = ""
            oeTarifasProveedor.IdProveedor = IdProveedor
            oeTarifasProveedor.IdFlujoCaja = IdFlujoCaja
            oeTarifasProveedor.IdCliente = IdCliente
            oeTarifasProveedor.IdMaterial = IdMaterial
            loTarifasProveedor = olTarifasProveedor.Listar(oeTarifasProveedor)
            griTarifasProveedor.DataSource = loTarifasProveedor
            If loTarifasProveedor.Count > 0 Then
                griTarifasProveedor.Rows(0).Activated = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub SeleccionarTarifa()
        Try
            If griTarifasProveedor.Rows.Count > 0 Then
                oeTarifasProveedor = New e_TarifasProveedor
                oeTarifasProveedor = griTarifasProveedor.ActiveRow.ListObject
            End If
            Me.Close()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub LlenarLugar()
        Try
            LlenarCombo(cboLugar, "Nombre", LugaresPublic, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub griTarifasProveedor_DoubleClick(sender As Object, e As EventArgs) Handles griTarifasProveedor.DoubleClick
        Try
            SeleccionarTarifa()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griTarifasProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles griTarifasProveedor.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                SeleccionarTarifa()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InsertarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarToolStripMenuItem.Click
        Try
            If IdProveedorObj = "" Then Throw New Exception("Seleccione Proveedor en Movimiento")
            If IdFlujoCajaObj = "" Then Throw New Exception("Seleccione Flujo de Caja en Movimiento")
            If IdFlujoCajaObj <> "1CH000000020" And IdFlujoCajaObj <> "1CH000000266" And IdFlujoCajaObj <> "1CH000000199" Then Throw New Exception("Solo Puede Agregar Tarifas a GASTOS DE ESTIBA Y DESESTIBA o ALQUILER DE MONTACARGA")
            MostrarTabs(1, Ficha1, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_TarifasProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LlenarLugar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAprobar_Click(sender As Object, e As EventArgs) Handles btnAprobar.Click
        Try
            oeTarifasProveedor.TipoOperacion = "I"
            oeTarifasProveedor.IdProveedor = IdProveedorObj
            oeTarifasProveedor.IdFlujoCaja = IdFlujoCajaObj
            oeTarifasProveedor.IdCliente = IdClienteObj
            oeTarifasProveedor.IdMaterial = IdMaterialObj
            oeTarifasProveedor.Importe = numImporte.Value
            oeTarifasProveedor.IdLugar = cboLugar.Value
            oeTarifasProveedor.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olTarifasProveedor.Guardar(oeTarifasProveedor) Then
                mensajeEmergente.Confirmacion("La Informacion ha Sido Guardada Correctamente")
                MostrarTabs(0, Ficha1, 0)
                Listar(IdProveedorObj, IdFlujoCajaObj, IdMaterialObj, IdClienteObj)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Boton1_Click(sender As Object, e As EventArgs) Handles Boton1.Click
        MostrarTabs(0, Ficha1, 0)
        Listar(IdProveedorObj, IdFlujoCajaObj, IdMaterialObj, IdClienteObj)
    End Sub

    Private Sub griTarifasProveedor_ClickCellButton(sender As Object, e As CellEventArgs) Handles griTarifasProveedor.ClickCellButton
        Try
            Select Case e.Cell.Column.Key
                Case "Importe"
                    Dim oeTraPro As New e_TarifasProveedor
                    oeTraPro.TipoOperacion = "A"
                    oeTraPro.Importe = griTarifasProveedor.ActiveRow.Cells("Importe").Value
                    oeTraPro.Id = griTarifasProveedor.ActiveRow.Cells("Id").Value
                    oeTraPro.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olTarifasProveedor.Guardar(oeTraPro) Then
                        mensajeEmergente.Confirmacion("La Informacion ha Sido Actualizada Correctamente")
                        Listar(IdProveedorObj, IdFlujoCajaObj, IdMaterialObj, IdClienteObj)
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griTarifasProveedor_CellChange(sender As Object, e As CellEventArgs) Handles griTarifasProveedor.CellChange
        griTarifasProveedor.UpdateData()
    End Sub

    Private Sub ExportarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarToolStripMenuItem.Click
        If griTarifasProveedor.Rows.Count > 0 Then
            Exportar_Excel(griTarifasProveedor)
        End If
    End Sub

#End Region

End Class