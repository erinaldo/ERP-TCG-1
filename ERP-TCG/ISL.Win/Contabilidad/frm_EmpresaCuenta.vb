'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF

Public Class frm_EmpresaCuenta
    Inherits ISL.Win.frm_MenuPadre
    Private WithEvents oeEmpresaCuenta As New e_EmpresaCuenta
    Private olEmpresaCuenta As New l_EmpresaCuenta
    Private oeCuenta As New e_CuentaContable
    Private _TipoCtaCte As String
    Private leCliente As New List(Of e_Cliente)
    Private leProveedor As New List(Of e_Proveedor)
    Private CargaListar As Boolean = False
    Private Shared instancia As frm_EmpresaCuenta = Nothing
    Private Ejercicio As Integer

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_EmpresaCuenta()
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            If grid_EmpresaCuenta.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Inicializar()
        oeEmpresaCuenta.TipoOperacion = "I"
        oeEmpresaCuenta.Modificado = False
        cboCuenta.Focus()
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        Try
            If ValidarGrilla(grid_EmpresaCuenta, "Empresa Cuenta") Then
                If grid_EmpresaCuenta.ActiveRow.Cells("Id").Value.ToString <> "" Then
                    Inicializar()
                    MostrarEmpresaCuenta()
                    oeEmpresaCuenta.TipoOperacion = "A"
                    oeEmpresaCuenta.Modificado = False
                    MyBase.Editar()
                Else
                    Throw New Exception("Seleccione una Fila!")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarEmpresaCuenta() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcEmpresaCuenta, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeEmpresaCuenta.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If Not GuardarEmpresaCuenta() Then
                            MostrarTabs(1, tcEmpresaCuenta)
                            Consultar(_Activo) 'activa desactiva botonera
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcEmpresaCuenta, 2)
                        Consultar(_Activo)
                End Select
            Else
                MostrarTabs(0, tcEmpresaCuenta, 2)
                Consultar(_Activo)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With grid_EmpresaCuenta
                If ValidarGrilla(grid_EmpresaCuenta, "Relacion Empresa Cuenta") Then
                    If .ActiveRow.Cells("Id").Value.ToString <> "" Then
                        oeEmpresaCuenta.Id = .ActiveRow.Cells("ID").Value
                        If oeEmpresaCuenta.Activo Then
                            If MessageBox.Show("Esta seguro de eliminar esta Relacion ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeEmpresaCuenta.TipoOperacion = "E"
                                olEmpresaCuenta.Eliminar(oeEmpresaCuenta)
                                Consultar(_Activo)
                            End If
                        Else
                            Throw New Exception("La informacion se encuentra eliminada en " & Me.Text)
                        End If
                    Else
                        Throw New Exception("Seleccione una Fila!")
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try

            If grid_EmpresaCuenta.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grid_EmpresaCuenta)

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

    Private Sub Inicializar()
        oeEmpresaCuenta = New e_EmpresaCuenta
        oeEmpresaCuenta.IndCompraVenta = 1
        oeEmpresaCuenta.Ejercicio = Año2.Año
        cboCuenta.SelectedIndex = -1
        cboCliente.SelectedIndex = -1
        cboProveedor.SelectedIndex = -1
        cboMoneda.SelectedIndex = -1
        OpcTipo.CheckedIndex = 0
        verActivo.Checked = True
        verActivo.Visible = Not oeEmpresaCuenta.Activo
        If Ejercicio <> Año2.Año Then
            ComboCuenta()
        End If
        MostrarTabs(1, tcEmpresaCuenta, 1)

    End Sub

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeEmpresaCuenta = New e_EmpresaCuenta
            oeEmpresaCuenta.Activo = Activo
            oeEmpresaCuenta.Ejercicio = Año2.Año
            oeEmpresaCuenta.IndCompraVenta = IIf(OpcBusqueda.CheckedIndex = 0, 1, 2)
            LimpiaGrid(grid_EmpresaCuenta, UltraDataSource2)
            FormatoGrillaClienteProveedor()
            With grid_EmpresaCuenta
                .DataSource = olEmpresaCuenta.Listar(oeEmpresaCuenta)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("IndCompraVenta").Hidden = True

                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Me.Cursor = Cursors.Default
        Finally
            Me.Cursor = Cursors.Default
        End Try
        grid_EmpresaCuenta.Focus()
    End Sub

    Private Function GuardarEmpresaCuenta() As Boolean
        Try
            oeEmpresaCuenta.PrefijoID = gs_PrefijoIdSucursal '@0001
            If ValidarEmpresaCuenta() AndAlso olEmpresaCuenta.Guardar(oeEmpresaCuenta) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente")
                MostrarTabs(0, tcEmpresaCuenta, 2)
                Consultar(_Activo)
                grid_EmpresaCuenta.Focus()
                Return True
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Function ValidarEmpresaCuenta() As Boolean
        Try
            ValidarCombo(cboCuenta, "Cuenta")
            If OpcBusqueda.CheckedIndex = 1 Then
                ValidarCombo(cboCliente, "Empresa")
            Else
                ValidarCombo(cboProveedor, "Empresa")
            End If

            ValidarCombo(cboMoneda, "Moneda")
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Return False
        End Try
    End Function

    Private Sub MostrarEmpresaCuenta()
        Try
            If grid_EmpresaCuenta.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                oeEmpresaCuenta.Id = grid_EmpresaCuenta.ActiveRow.Cells("Id").Value.ToString
                oeEmpresaCuenta = olEmpresaCuenta.Obtener(oeEmpresaCuenta)
                cboCuenta.Value = oeEmpresaCuenta.IdCuentaContable
                cboMoneda.Value = oeEmpresaCuenta.IdMoneda
                verActivo.Checked = oeEmpresaCuenta.Activo
                If oeEmpresaCuenta.IndCompraVenta = 1 Then
                    OpcTipo.CheckedIndex = 0
                    cboProveedor.Visible = True
                    cboCliente.Visible = False
                    cboProveedor.Value = oeEmpresaCuenta.IdProveedorCliente
                ElseIf oeEmpresaCuenta.IndCompraVenta = 2 Then
                    OpcTipo.CheckedIndex = 1
                    cboProveedor.Visible = False
                    cboCliente.Visible = True
                    cboCliente.Value = oeEmpresaCuenta.IdProveedorCliente
                End If
                verActivo.Visible = Not oeEmpresaCuenta.Activo
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ComboCuenta()
        Try
            With cboCuenta
                If Ejercicio <> Año2.Año Then
                    Ejercicio = Año2.Año
                    Dim oeCuentaCtable As New e_CuentaContable
                    Dim leCuentaCtable As New List(Of e_CuentaContable)
                    Dim olCuentaContable As New l_CuentaContable
                    oeCuentaCtable.Activo = True
                    oeCuentaCtable.Movimiento = 1
                    oeCuentaCtable.Ejercicio = Año2.Año
                    oeCuentaCtable.TipoOperacion = "C"
                    leCuentaCtable.AddRange(olCuentaContable.Listar(oeCuentaCtable))
                    '-------------------------------------------------------
                    grid_EmpresaCuenta.DisplayLayout.ValueLists.Add("IdCuentaContable")
                    With grid_EmpresaCuenta.DisplayLayout.ValueLists("IdCuentaContable").ValueListItems
                        .Clear()
                        For Each oeTD As e_CuentaContable In leCuentaCtable
                            .Add(oeTD.Id, oeTD.Cuenta)
                        Next
                    End With
                    CrearComboGrid3("IdCuentaContable", "Cuenta", grid_EmpresaCuenta, True)
                    '------------------------------------------
                    .ValueMember = "Id"
                    .DisplayMember = "Cuenta"
                    .DataSource = leCuentaCtable
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboMoneda()
        Try
            If cboMoneda.Items.Count = 0 Then
                Dim oeMoneda As New e_Moneda
                Dim olMoneda As New l_Moneda
                Dim leMoneda As New List(Of e_Moneda)
                oeMoneda.Activo = True
                leMoneda.AddRange(olMoneda.Listar(oeMoneda))
                '--------------------- para llenar combo en grilla    
                grid_EmpresaCuenta.DisplayLayout.ValueLists.Add("IdMoneda")
                With grid_EmpresaCuenta.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                    .Clear()
                    For Each oeTD As e_Moneda In leMoneda
                        .Add(oeTD.Id, oeTD.Abreviatura)
                    Next
                End With
                CrearComboGrid3("IdMoneda", "Abreviatura", grid_EmpresaCuenta, True)
                '------------------------------------------
                With cboMoneda
                    .DisplayMember = "Nombre"
                    .ValueMember = "Id"
                    .DataSource = leMoneda
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboCliente()
        Try
            If cboCliente.Items.Count = 0 Then
                Dim oeCliente As New e_Cliente
                Dim olCliente As New l_Cliente
                oeCliente.Activo = True
                oeCliente.Comisionista = -1
                leCliente.AddRange(olCliente.Listar(oeCliente))
                With cboCliente
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = leCliente
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboProveedor()
        Try
            If cboProveedor.Items.Count = 0 Then
                Dim oeProveedor As New e_Proveedor
                Dim olProveedor As New l_Proveedor
                oeProveedor.Activo = True
                leProveedor.AddRange(olProveedor.Listar(oeProveedor))
                With cboProveedor
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = leProveedor
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub FormatoGrillaClienteProveedor()
        If OpcBusqueda.CheckedIndex = 1 Then
            '--------------------- para llenar combo en grilla    
            With grid_EmpresaCuenta.DisplayLayout
                If .Bands(0).Columns.Exists("IdProveedorCliente") Then
                    .ValueLists.Clear()
                    .ValueLists.Add("IdProveedorCliente")
                End If
            End With
            With grid_EmpresaCuenta.DisplayLayout.ValueLists("IdProveedorCliente").ValueListItems
                .Clear()
                For Each oeTD As e_Cliente In leCliente
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdProveedorCliente", "Nombre", grid_EmpresaCuenta, True)
            '------------------------------------------
        Else
            '--------------------- para llenar combo en grilla    
            With grid_EmpresaCuenta.DisplayLayout
                If .Bands(0).Columns.Exists("IdProveedorCliente") Then
                    .ValueLists.Clear()
                    .ValueLists.Add("IdProveedorCliente")
                End If
            End With
            With grid_EmpresaCuenta.DisplayLayout.ValueLists("IdProveedorCliente").ValueListItems
                .Clear()
                For Each oeTD As e_Proveedor In leProveedor
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdProveedorCliente", "Nombre", grid_EmpresaCuenta, True)
            '------------------------------------------
        End If
    End Sub

#End Region

#Region "Eventos"

    Private Sub oeEmpresaCuenta_DatoCambiado() Handles oeEmpresaCuenta.DatoCambiado
        oeEmpresaCuenta.Modificado = True
    End Sub

    Private Sub frm_EmpresaCuenta_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_EmpresaCuenta_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If _Operacion = "Nuevo" Or _Operacion = "Editar" Then
            Me.Activate()
            Me.Cancelar()
        End If
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_EmpresaCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            MostrarTabs(0, tcEmpresaCuenta)
            Año2.Año = Date.Now.Year
            ComboMoneda()
            ComboCliente()
            ComboProveedor()
            ComboCuenta()
            CargaListar = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub grid_EmpresaCuenta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        If grid_EmpresaCuenta.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub grid_EmpresaCuenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        TeclaPulsada(e)
    End Sub

    Private Sub grid_EmpresaCuenta_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs)
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub mnuEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEliminar.Click
        Eliminar()
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        Editar()
    End Sub

    Private Sub cboCuenta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCuenta.ValueChanged
        oeEmpresaCuenta.IdCuentaContable = cboCuenta.Value
    End Sub

    Private Sub cboCuenta_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuenta.Validated
        If cboCuenta.SelectedIndex <> -1 Then
            oeCuenta = New e_CuentaContable
            With cboCuenta
                Dim i As Integer = .SelectedIndex
                oeCuenta = .Items(i).ListObject
            End With
            If oeCuenta.TipoCuentaCorriente = "1CH000010" Then 'clientes
                cboCliente.Visible = True
                cboProveedor.Visible = False
                OpcTipo.CheckedIndex = 1
                OpcTipo.Enabled = False
            ElseIf oeCuenta.TipoCuentaCorriente = "1CH000011" Then 'Proveedores
                cboProveedor.Visible = True
                cboCliente.Visible = False
                OpcTipo.CheckedIndex = 0
                OpcTipo.Enabled = False
            Else
                cboCliente.Visible = False
                cboProveedor.Visible = False
                OpcTipo.Enabled = True
            End If
            If oeCuenta.MonedaExtranjera = 1 Then
                cboMoneda.Text = "DOLARES"
            Else
                cboMoneda.Text = "SOLES"
            End If
        End If
    End Sub

    Private Sub cboCtaCte_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCliente.ValueChanged
        oeEmpresaCuenta.IdProveedorCliente = cboCliente.Value
    End Sub

    Private Sub cboProveedor_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProveedor.ValueChanged
        oeEmpresaCuenta.IdProveedorCliente = cboProveedor.Value
    End Sub

    Private Sub cboMoneda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoneda.ValueChanged
        oeEmpresaCuenta.IdMoneda = cboMoneda.Value
    End Sub

    Private Sub OpcTipo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpcTipo.ValueChanged
        oeEmpresaCuenta.IndCompraVenta = IIf(OpcTipo.CheckedIndex = 0, 1, 2)
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeEmpresaCuenta.Activo = verActivo.Checked
    End Sub

    Private Sub Año2_DatoCambiado() Handles Año2.DatoCambiado
        Try
            If CargaListar Then Listar(True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

#End Region

End Class
