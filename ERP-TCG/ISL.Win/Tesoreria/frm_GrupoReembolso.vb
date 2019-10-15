'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win.UltraWinGrid

Public Class frm_GrupoReembolso
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_GrupoReembolso = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_GrupoReembolso()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de variables"

    Dim oeGrupo As New e_Grupo
    Dim olGrupo As New l_Grupo
    Dim olGrupoAsiento As New l_Grupo_Asiento
    Dim oeGrupoAsiento As New e_Grupo_Asiento
    Dim loGrupoAsiento As New List(Of e_Grupo_Asiento)
    Dim oeTipoMedio As New e_MedioPago
    Private EjercicioBanderaCtaBancari As Integer

    Private oeAsientoModelo, oeAsientoModeloGrupo As New e_AsientoModelo
    Private olAsientoModelo As New l_AsientoModelo
    Private loAsientoModelo As New List(Of e_AsientoModelo)

    Private oeReferencia As New e_AsientoModelo_Referencia
    Private olReferencia As New l_AsientoModelo_Referencia
    Private loReferencia As New List(Of e_AsientoModelo_Referencia)
    Private dtReferencia As New DataTable


#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try

            If griDatos.Rows.Count > 0 Then
                If MessageBox.Show("Existen grupos agregados, desea eliminarlos", "Mensaje del Sistema", _
               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
               = Windows.Forms.DialogResult.Yes Then
                    loGrupoAsiento = New List(Of e_Grupo_Asiento)
                    LlenarLista(loGrupoAsiento)
                Else
                    Exit Sub
                End If
            Else
                loGrupoAsiento = New List(Of e_Grupo_Asiento)
                LlenarLista(loGrupoAsiento)
            End If

            ' LlenarLista(loGrupoAsiento)
            ListarGrupos()
            If loGrupoAsiento.Count > 0 Then MostrarGrupo()
            If griGrupo.DisplayLayout.Rows.Count > 0 Then
                ControlBoton(1, 0, 0, 1, 0, 0, 1, 0, 1)
            Else
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            Dim oeAsiento As New e_Asiento
            Dim oePeriodo As New e_Periodo
            Dim olPeriodo As New l_Periodo
            oePeriodo.Mes = Month(FecFechaReembolso.Value)
            oePeriodo.Ejercicio = Year(FecFechaReembolso.Value)
            oePeriodo = olPeriodo.Obtener(oePeriodo)

            With oeAsiento
                .TipoCambio = decTipoCambio.Value
                .Fecha = FecFechaReembolso.Value
                .IdPeriodo = oePeriodo.Id
                .IdUsuarioCrea = gUsuarioSGI.Id
            End With

            oeGrupoAsiento = New e_Grupo_Asiento
            With oeGrupoAsiento
                .IdCheque = cboCheques.Value
                .NroCheque = cboCheques.Text
                .IdCtaBancaria = cboCuentaBancaria.Value
                .IdTipoMedio = oeTipoMedio.Id
                .IdFlujoCaja = cboFlujoCaja.Value
            End With
            oeGrupoAsiento.loGrupoAsiento = New List(Of e_Grupo_Asiento)
            oeGrupoAsiento.loGrupoAsiento.AddRange(loGrupoAsiento)
            ObtenerAsientoModelo(cboMoneda.Value, oePeriodo.Ejercicio)

            Dim obj(12) As Object
            'obj(0) = oeTipoMedio.IdTipoAsiento
            'obj(1) = cboCuentaCtble.Value
            'obj(2) = cboCuentaBancaria.Value
            'obj(3) = cboMoneda.Value
            'obj(4) = cboFlujoCaja.Value
            'obj(5) = FecFechaReembolso.Value
            'obj(6) = decTipoCambio.Value
            'obj(7) = decImporteSoles.Value
            'obj(8) = decImporteDolares.Value
            'obj(9) = cboCheques.Text
            'obj(10) = gUsuarioSGI.Id
            'obj(11) = oeTipoMedio.Id
            'obj(12) = cboCheques.Value

            ValidarCombo(cboMedioPago, "Medio de Pago")
            ValidarCombo(cboCuentaCtble, "Cuenta Contable de pago")
            ValidarCombo(cboCuentaBancaria, "Nro de cuenta Corriente")
            ValidarCombo(cboMoneda, "Moneda")
            ValidarCombo(cboFlujoCaja, "Flujo de Caja")
            l_FuncionesGenerales.ValidarNumero(decTipoCambio.Value, "Tipo de Cambio")
            oeGrupoAsiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            oeAsiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olGrupoAsiento.GuardarAsiento(oeGrupoAsiento, oeAsiento) Then
                Dim lsCodigo As String = oeAsiento._IdMovimientoCajaBanco
                If lsCodigo <> "" Then
                    Dim frm As New frm_ImprimeTransferencia(lsCodigo)
                    frm.ShowDialog()
                    frm = Nothing
                End If
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                loGrupoAsiento = New List(Of e_Grupo_Asiento)
                LlenarLista(loGrupoAsiento)
                Consultar(_Activo)
                btnSeleccionar.Tag = "Selec"
                btnSeleccionar.Text = "Agregar Todo"
                btnSeleccionar.Appearance.Image = My.Resources.Agregar
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griDatos.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griDatos)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try
            Dim oeMoneda As New e_Moneda
            Dim olMoneda As New l_Moneda
            LlenarCombo(cboMoneda, "Abreviatura", olMoneda.Listar(oeMoneda), -1)

            Dim oeMedioPago As New e_MedioPago
            Dim olMedioPago As New l_MedioPago
            LlenarCombo(cboMedioPago, "Nombre", olMedioPago.Listar(oeMedioPago), 1)

            Cuentas()
            'CargarCuentaCorriente()

            Dim oeFlujoCaja As New e_FlujoCaja
            Dim olFlujoCaja As New l_FlujoCaja
            LlenarCombo(cboFlujoCaja, "Nombre", olFlujoCaja.Listar(oeFlujoCaja), -1)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Cuentas()
        Try
            Dim oeCtaCtble As New e_CuentaContable
            Dim olCtaCtble As New l_CuentaContable
            oeCtaCtble.Movimiento = 1
            oeCtaCtble.FlujoCaja = 1
            oeCtaCtble.Ejercicio = Year(FecFechaReembolso.Value)
            LlenarCombo(cboCuentaCtble, "Nombre", olCtaCtble.Listar(oeCtaCtble), 6)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub CargarCuentaCorriente()
        Try
            Dim oeCtaCte As New e_CuentaBancaria
            Dim olCtaCte As New l_CuentaBancaria
            oeCtaCte.IdCuentaContable = cboCuentaCtble.Value 'Relacionada con Cuenta COntale
            oeCtaCte.Activo = True
            oeCtaCte.Ejercicio = Date.Parse(FecFechaReembolso.Value).Year
            oeCtaCte.TipoOperacion = "C"

            LlenarCombo(cboCuentaBancaria, "BancoCuenta", olCtaCte.Listar(oeCtaCte), -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarGrupos()
        Try
            If cboCheques.SelectedIndex = -1 Then
                mensajeEmergente.Problema("Seleccion Nro de Cheque")
                Exit Sub
            Else
                oeGrupo.TipoOperacion = "5"
                oeGrupo.Estado = "ENVIADO"
                oeGrupo.IdChequexCobrar = cboCheques.Value
                griGrupo.ResetDisplayLayout()
                griGrupo.DataSource = olGrupo.Listar(oeGrupo)

                With griGrupo.DisplayLayout

                    .Bands(0).Columns.Add("Selec", "Seleccionar")
                    .Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                    .Bands(0).Columns("Selec").DefaultCellValue = False
                    .Bands(0).Columns("Selec").Header.VisiblePosition = 1
                    .Bands(0).Columns("Id").Hidden = True
                    .Bands(0).Columns("FechaReembolso").Hidden = True
                    .Bands(0).Columns("IdCentro").Hidden = True
                    .Bands(0).Columns("IdEstado").Hidden = True
                    .Bands(0).Columns("Estado").Hidden = True
                    .Bands(0).Columns("Activo").Hidden = True
                    .Bands(0).Columns("IdCaja").Hidden = True
                    .Bands(0).Columns("IdPeriodo").Hidden = True
                    .Bands(0).Columns("FechaCreacion").Hidden = True
                    .Bands(0).Columns("UsuarioCreacion").Hidden = True
                    .Bands(0).Columns("ImportePagar").Hidden = True
                    .Bands(0).Columns("IdCuentaCorriente").Hidden = True
                    .Bands(0).Columns("Saldo").Hidden = True
                    .Bands(0).Columns("NroCheque").Hidden = True
                    .Bands(0).Columns("Seleccion").Hidden = True

                    .Bands(0).Columns("Codigo").Width = 150
                    .Bands(0).Columns("GlosaEnvio").Width = 400
                    .Bands(0).Columns("Tipo").Width = 50

                    .Bands(0).Columns("ImporteTotal").Style = ColumnStyle.Double
                    .Bands(0).Columns("Saldo").Style = ColumnStyle.Double

                    .Bands(0).Columns("ImporteTotal").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                    .Bands(0).Columns("Saldo").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right

                    .Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                    .Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
                    .Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex

                    For Each Columna As UltraGridColumn In griGrupo.DisplayLayout.Bands(0).Columns
                        If Not Columna.Key = "Selec" Then Columna.CellClickAction = CellClickAction.RowSelect : Columna.CellActivation = Activation.NoEdit
                    Next

                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarLista(ByVal loLista As List(Of e_Grupo_Asiento))
        Try

            griDatos.DataSource = loLista

            With griDatos.DisplayLayout

                .Bands(0).Columns("Id").Hidden = True
                .Bands(0).Columns("Activo").Hidden = True
                .Bands(0).Columns("IdGrupo").Hidden = True
                .Bands(0).Columns("IdAsientoMovimiento").Hidden = True
                .Bands(0).Columns("FechaCreacion").Hidden = True
                .Bands(0).Columns("UsuarioCreacion").Hidden = True
                .Bands(0).Columns("Saldo").Hidden = True

                .Bands(0).Columns("GlosaEnvio").Width = 250

                .Bands(0).Columns("ImporteTotal").Style = ColumnStyle.Double
                .Bands(0).Columns("ImportePagar").Style = ColumnStyle.Double

                .Bands(0).Columns("ImporteTotal").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(0).Columns("ImportePagar").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right

                .Bands(0).Columns("ImportePagar").CellAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))

                .Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex

                For Each Columna As UltraGridColumn In griDatos.DisplayLayout.Bands(0).Columns
                    If Not Columna.Key = "ImportePagar" Then Columna.CellClickAction = CellClickAction.RowSelect : Columna.CellActivation = Activation.NoEdit
                Next

            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarGrupo(ByVal oe As e_Grupo_Asiento, ByVal o_Fila As UltraGridRow)
        Try
            If Not loGrupoAsiento.Contains(oe) Then
                'oe.IdGrupo = oeGrupoAsiento.Id
                oe.Codigo = o_Fila.Cells("Codigo").Value
                oe.Tipo = o_Fila.Cells("Tipo").Value
                oe.Fecha = o_Fila.Cells("Fecha").Value
                oe.FechaEnvio = o_Fila.Cells("FechaEnvio").Value
                oe.ImporteTotal = o_Fila.Cells("ImporteTotal").Value
                oe.Saldo = o_Fila.Cells("Saldo").Value
                oe.GlosaEnvio = o_Fila.Cells("GlosaEnvio").Value
                oe.Centro = o_Fila.Cells("Centro").Value
                oe.ImportePagar = o_Fila.Cells("ImportePagar").Value
                oe.UsuarioCreacion = gUsuarioSGI.Id
                oe.TipoOperacion = "I"
                oe._IdEstado = o_Fila.Cells("IdEstado").Value
                If griDatos.Rows.Count < 1 Then LlenarLista(loGrupoAsiento)
                oe.PrefijoID = gs_PrefijoIdSucursal '@0001
                loGrupoAsiento.Add(oe)
            Else
                If oe.TipoOperacion = "E" Then
                    oe.TipoOperacion = ""
                    For Each fila As UltraGridRow In griDatos.Rows
                        If fila.Cells("Id").Value = oe.IdGrupo Then
                            fila.Hidden = False
                            Exit For
                        End If
                    Next
                Else
                    Throw New Exception("El Grupo: " & o_Fila.Cells("Id").Value & " ya esta Asignada")
                End If
            End If
            CalcularTotales()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarGrupo(ByVal oe As e_Grupo_Asiento)
        Try
            If oe.Id <> "" Then
                oe.TipoOperacion = "E"
                For Each fila As UltraGridRow In griDatos.Rows
                    If fila.Cells("Id").Value = oe.IdGrupo Then
                        fila.Hidden = True
                        Exit For
                    End If
                Next
            Else
                loGrupoAsiento.Remove(oe)
            End If
            CalcularTotales()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CalcularTotales()
        decImporteSoles.Value = 0.0
        For Each GrupoAsiento As e_Grupo_Asiento In loGrupoAsiento
            decImporteSoles.Value += GrupoAsiento.ImportePagar
        Next
        decImporteDolares.Value = decImporteSoles.Value / decTipoCambio.Value
    End Sub

    Private Sub MostrarGrupo()
        Try
            For Each oe As e_Grupo_Asiento In loGrupoAsiento
                For Each Fila As UltraGridRow In griGrupo.Rows
                    If Fila.Cells("Id").Value = oe.IdGrupo Then
                        Fila.Cells("Selec").Value = True
                        Exit For
                    End If
                Next
            Next
            griGrupo.UpdateData()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_GrupoReembolso_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If griGrupo.DisplayLayout.Rows.Count > 0 Then
            ControlBoton(1, 0, 0, 1, 0, 0, 1, 0, 1)
        Else
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_GrupoReembolso_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_GrupoReembolso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CargarCombos()
            LlenarLista(loGrupoAsiento)
            btnSeleccionar.Tag = "Selec"
            decTipoCambio.Value = TipoCambio(Date.Now, True)(0)
            cboCuentaBancaria.Focus()
            EjercicioBanderaCtaBancari = Date.Parse(FecFechaReembolso.Value).Year
            AsientosContables()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboCuentaCtble_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuentaCtble.ValueChanged
        If cboCuentaCtble.SelectedIndex <> -1 Then
            CargarCuentaCorriente()
            cboMoneda.SelectedIndex = IIf(cboCuentaCtble.Text.Contains("M.N."), 0, 1)
        End If
    End Sub

    Private Sub griGrupo_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griGrupo.CellChange
        Try
            l_FuncionesGenerales.ValidarNumero(decTipoCambio.Value, "Tipo de Cambio")
            With griGrupo
                .UpdateData()
                If .ActiveRow.Cells("Selec").Activated Then
                    oeGrupoAsiento = New e_Grupo_Asiento
                    Dim Fila As UltraGridRow
                    oeGrupoAsiento.IdGrupo = .ActiveRow.Cells("Id").Value
                    Fila = .ActiveRow
                    If .ActiveRow.Cells("Selec").Value Then
                        AgregarGrupo(oeGrupoAsiento, Fila)
                    Else
                        QuitarGrupo(oeGrupoAsiento)
                    End If
                End If
            End With
            griDatos.DataBind()
            CalcularTotales()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        Try
            l_FuncionesGenerales.ValidarNumero(decTipoCambio.Value, "Tipo de Cambio")
            Dim oeGA As New e_Grupo_Asiento
            Dim var As Integer = 0
            If griGrupo.Rows.Count > 0 Then
                If btnSeleccionar.Tag = "Selec" Then
                    For Each fila As UltraGridRow In griGrupo.Rows
                        If Not fila.Cells("Selec").Value Then
                            fila.Cells("Selec").Value = True
                            oeGA = New e_Grupo_Asiento
                            oeGA.IdGrupo = fila.Cells("Id").Value
                            AgregarGrupo(oeGA, fila)
                            var = 1
                        End If
                    Next
                    If var = 0 Then Throw New Exception("Todos los Registros estan Seleccionados")
                    btnSeleccionar.Tag = "NoSelec"
                    btnSeleccionar.Text = "Quitar Todo"
                    btnSeleccionar.Appearance.Image = My.Resources.SymbolDelete
                Else
                    For Each fila As UltraGridRow In griGrupo.Rows
                        If fila.Cells("Selec").Value Then
                            fila.Cells("Selec").Value = False
                            oeGA = New e_Grupo_Asiento
                            oeGA.IdGrupo = fila.Cells("Id").Value
                            QuitarGrupo(oeGA)
                        End If
                    Next
                    btnSeleccionar.Tag = "Selec"
                    btnSeleccionar.Text = "Agregar Todo"
                    btnSeleccionar.Appearance.Image = My.Resources.Agregar
                End If
            End If
            griDatos.DataBind()
            griGrupo.UpdateData()
            CalcularTotales()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griDatos_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griDatos.CellChange
        Try
            l_FuncionesGenerales.ValidarNumero(decTipoCambio.Value, "Tipo de Cambio")
            'If IsNumeric(e.Cell.Text) Then
            Dim oe As New e_Grupo_Asiento
            oe = griDatos.ActiveRow.ListObject
            If oe.ImportePagar > oe.Saldo Then
                griDatos.ActiveRow.Cells("ImportePagar").Value = griDatos.ActiveRow.Cells("Saldo").Value
                Throw New Exception("El Importe a Pagar no puede ser mayor al Saldo")
            End If
            griDatos.UpdateData()
            CalcularTotales()
            'End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Private Sub griGrupo_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griGrupo.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub FecFechaReembolso_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles FecFechaReembolso.Validated
        Try
            If EjercicioBanderaCtaBancari <> Date.Parse(FecFechaReembolso.Value).Year Then
                EjercicioBanderaCtaBancari = Date.Parse(FecFechaReembolso.Value).Year
                'leCuentaBancaria.Clear()
                cboCuentaBancaria.SelectedIndex = -1
                cboCuentaCtble.SelectedIndex = -1
                cboCuentaBancaria.DataSource = Nothing
                cboCuentaCtble.DataSource = Nothing
                'oeCtaBancaria = New e_CuentaBancaria
                'oeCtaCble = New e_CuentaContable
                Cuentas()
                'CargarCuentaCorriente()
            End If
            decTipoCambio.Value = TipoCambio(FecFechaReembolso.Value, True)(0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub QuitarDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarDocumento.Click
        Try
            If griDatos.Selected.Rows.Count > 0 Then
                'Dim Fila As UltraGridRow
                oeGrupoAsiento = New e_Grupo_Asiento
                oeGrupoAsiento.IdGrupo = griDatos.ActiveRow.Cells("IdGrupo").Value
                'Fila = griGrupo.ActiveRow
                QuitarGrupo(oeGrupoAsiento)
                griGrupo.ActiveRow.Cells("Selec").Value = False
                griGrupo.UpdateData()
                griDatos.DataBind()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub MenuAgregados_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuAgregados.Opening
        MenuAgregados.Items("QuitarDocumento").Visible = IIf(griDatos.Selected.Rows.Count > 0, True, False)
    End Sub

    Private Sub cboTipoPago_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMedioPago.ValueChanged
        oeTipoMedio = New e_MedioPago
        Dim i As Integer = cboMedioPago.SelectedIndex
        oeTipoMedio = cboMedioPago.Items(i).ListObject
    End Sub

#End Region

#Region "Asiento Contable"

    Private Sub AsientosContables()
        AsientoModelo()
        dtReferencia = GeneraDTRef(loReferencia)
    End Sub

    Private Sub AsientoModelo()
        oeAsientoModelo = New e_AsientoModelo
        loAsientoModelo = New List(Of e_AsientoModelo)
        oeAsientoModelo.TipoOperacion = "A" : oeAsientoModelo.Activo = True : oeAsientoModelo.Nombre = pIdActividadNegocio
        loAsientoModelo = olAsientoModelo.Listar(oeAsientoModelo)

        oeReferencia = New e_AsientoModelo_Referencia
        loReferencia = New List(Of e_AsientoModelo_Referencia)
        oeReferencia.TipoOperacion = "N" : oeReferencia.Activo = True : oeReferencia.IdReferencia = pIdActividadNegocio
        loReferencia = olReferencia.Listar(oeReferencia)
    End Sub

    Public Sub ObtenerAsientoModelo(IdMoneda As String, Ejercicio As Integer)
        Try
            Dim dtAux = New Data.DataTable
            Dim _rwAux() As Data.DataRow
            Dim cadSQL As String = String.Empty
            cadSQL = "TipoRef1 = 4 AND IdRef1 = '" & IdMoneda & "'"
            _rwAux = dtReferencia.Select(cadSQL, "")
            If _rwAux.Count = 0 Then Throw New Exception("Error en el Modelo de Asiento Contable. Verificar")
            dtAux = _rwAux.CopyToDataTable
            oeAsientoModeloGrupo = New e_AsientoModelo
            oeAsientoModeloGrupo.TipoOperacion = ""
            oeAsientoModeloGrupo.Activo = True
            oeAsientoModeloGrupo.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
            oeAsientoModeloGrupo = olAsientoModelo.Obtener(oeAsientoModeloGrupo)
            oeGrupoAsiento.loAsientoModelo = New List(Of e_AsientoModelo)
            oeAsientoModeloGrupo.PrefijoID = gs_PrefijoIdSucursal '@0001
            oeGrupoAsiento.loAsientoModelo.Add(oeAsientoModeloGrupo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

    Private Sub cboCuentaBancaria_Validated(sender As Object, e As EventArgs) Handles cboCuentaBancaria.Validated
        If cboCuentaBancaria.SelectedIndex <> -1 Then
            Dim oeCheque As New e_ChequeEmitido
            Dim olCheque As New l_ChequeEmitido
            oeCheque.TipoOperacion = "2"
            oeCheque.Fecha = Date.Parse("01/01/1901")
            oeCheque.FechaCreacion = Date.Parse("01/01/1901")
            oeCheque.IdCuentaBancaria = cboCuentaBancaria.Value
            LlenarCombo(cboCheques, "NroCheque", olCheque.Listar(oeCheque), -1)
        End If
    End Sub

End Class