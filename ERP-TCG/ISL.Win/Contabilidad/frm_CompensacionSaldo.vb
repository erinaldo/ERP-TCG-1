'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win.UltraWinGrid

Public Class frm_CompensacionSaldo
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaración de Variables"

    Private oeMovimientoDocumento As New e_MovimientoDocumento
    Private olMovimientoDocumento As New l_MovimientoDocumento
    Private oePeriodo As New e_Periodo
    Private olPeriodo As New l_Periodo
    Private leMD As New List(Of e_MovimientoAnalisis)
    Private leMovAnalisisAgrega As New List(Of e_MovimientoAnalisis)

    Private Shared instancia As frm_CompensacionSaldo = Nothing
    Private Shared Operacion As String

    Private leMovDoc As New List(Of e_MovimientoDocumento)
    Private leMovDocAgregado As New List(Of e_MovimientoDocumento)

    Dim leCP As New List(Of e_Combo)
    Private GrillaAgre As Boolean = False
    Private leTipoDoc As New List(Of e_TipoDocumento)

#End Region

#Region "Inicialización de formulario"

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_CompensacionSaldo()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            If chkPersonalCtas.Checked Then
                ValidarCombo(cboClienteProveedor, "Cuenta Corriente")
                If leCP.Where(Function(i) i.Id = cboClienteProveedor.Value).Count = 0 Then Throw New Exception("Seleccione una Cuenta Corriente válida.")
                Listar2()
                Listar(Activo)
            Else
                If chkPersonal.Checked Then
                    Listar2()
                Else
                    ValidarCombo(cboClienteProveedor, "Cuenta Corriente")
                    If leCP.Where(Function(i) i.Id = cboClienteProveedor.Value).Count = 0 Then Throw New Exception("Seleccione una Cuenta Corriente válida.")
                    Listar(Activo)
                End If
            End If
            ControlBoton(1, 0, 0, 1, 1, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarCancelacion() Then
                MyBase.Guardar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeMovimientoDocumento.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        'If Not GuardarCobranza() Then
                        '    Consultar(True) 'activa desactiva botonera
                        'End If
                    Case Windows.Forms.DialogResult.No
                        Consultar(True) 'activa desactiva botonera
                End Select
            Else
                Consultar(True) 'activa desactiva botonera
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    Public Overrides Sub Exportar()
        Try
            Throw New Exception("No es posible exportar desde este módulo")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Métodos"

    Private Function GuardarCancelacion() As Boolean
        Try
            If ValidarCancelacion() Then
                Dim lobj(4) As Object
                lobj(0) = FecFecha.Value
                lobj(1) = decTC.Value
                lobj(2) = cboMoneda.Value
                lobj(3) = gUsuarioSGI.Id
                lobj(4) = MacPCLocal()

                If chkPersonalCtas.Checked Then
                    For Each obj As e_MovimientoDocumento In leMovDocAgregado
                        Dim oeMdoc As New e_TipoDocumento
                        oeMdoc = leTipoDoc.Where(Function(item) item.Id = obj.IdTipoDocumento).ToList(0)
                        obj.oeTipoDocumento = oeMdoc
                        obj.PrefijoID = gs_PrefijoIdSucursal '@0001
                    Next
                    If olMovimientoDocumento.GuardarAnalisisYDocumento(leMovAnalisisAgrega, leMovDocAgregado, lobj) Then
                        mensajeEmergente.Confirmacion("Se registró correctamente")
                        leMovAnalisisAgrega.Clear()
                        GridPersonalAgregado.DataBind()
                        leMovDocAgregado.Clear()
                        gridCobranzaAgregado.DataBind()
                        Listar(True)
                        Listar2()
                    End If
                Else
                    If chkPersonal.Checked Then
                        If olMovimientoDocumento.GuardarCancelacionMovimientoAnalisis(leMovAnalisisAgrega, lobj) Then
                            mensajeEmergente.Confirmacion("Se registró correctamente")
                            leMovAnalisisAgrega.Clear()
                            GridPersonalAgregado.DataBind()
                            Listar2()
                        End If
                    Else
                        For Each obj As e_MovimientoDocumento In leMovDocAgregado
                            Dim oeMdoc As New e_TipoDocumento
                            oeMdoc = leTipoDoc.Where(Function(item) item.Id = obj.IdTipoDocumento).ToList(0)
                            obj.oeTipoDocumento = oeMdoc
                            obj.PrefijoID = gs_PrefijoIdSucursal '@0001
                        Next
                        If olMovimientoDocumento.GuardarCancelacion(leMovDocAgregado, lobj) Then
                            mensajeEmergente.Confirmacion("Se registró correctamente")
                            leMovDocAgregado.Clear()
                            gridCobranzaAgregado.DataBind()
                            Listar(True)
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidarCancelacion() As Boolean
        Try
            ValidarCombo(cboMoneda, "Moneda")
            l_FuncionesGenerales.ValidarNumero(decTC.Value, "Tipo de cambio")
            If chkPersonalCtas.Checked Then
                If leMovDocAgregado.Count <> 1 Then Throw New Exception("Ingrese 1 detalle documento")
                If leMovAnalisisAgrega.Count <> 1 Then Throw New Exception("Ingrese 1 detalle de personal")
                ValidarMovimientoAgregado(leMovAnalisisAgrega)
                ValidarDocumentoAgregado(leMovDocAgregado)
            Else
                If chkPersonal.Checked Then
                    ValidarMovimientoAgregado(leMovAnalisisAgrega)
                    Dim Perio As String = ""
                    For Each obj As e_MovimientoAnalisis In leMovAnalisisAgrega
                        If Month(obj.Fecha) > Month(FecFecha.Value) Then
                            Throw New Exception("Existe un linea que pertenece al periodo sgt de la cancelacion, asiento:" & obj.NroAsiento)
                        End If
                    Next
                Else
                    ValidarCombo(cboClienteProveedor, "Cuenta Cte")
                    ValidarDocumentoAgregado(leMovDocAgregado)
                End If
            End If

            If Math.Round(CDbl(EtiImporteSoles.Text), 2) > 0.01 Or Math.Round(CDbl(EtiImporteSoles.Text), 2) < -0.01 Or Math.Round(CDbl(EtiImporteDolares.Text), 2) > 0.01 Or Math.Round(CDbl(EtiImporteDolares.Text), 2) < -0.01 Then
                Throw New Exception("Los importes soles y dólares deben ser cero")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarDocumentoAgregado(ByVal movimientosDocumento As List(Of EntidadesWCF.e_MovimientoDocumento)) As Boolean
        Try
            If chkPersonal.Checked = False And chkPersonalCtas.Checked = False Then
                If movimientosDocumento.Count < 2 Then Throw New Exception("Ingrese al menos 2 detalles")
            End If
            For Each obj As e_MovimientoDocumento In movimientosDocumento
                If (obj.Saldo > 0 And obj.MontoOperar < 0) Or (obj.Saldo < 0 And obj.MontoOperar > 0) Then Throw New Exception("los signos de la columna saldo y monto agregado no son iguales")
                If obj.MontoOperar = 0 Then Throw New Exception("El monto a cancelar es cero")
                If Math.Round(Math.Abs(obj.Saldo), 2) < Math.Round(Math.Abs(obj.MontoOperar), 2) Then Throw New Exception("El monto a cancelar es mayor al saldo")
            Next
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarMovimientoAgregado(ByVal movimiento As List(Of e_MovimientoAnalisis)) As Boolean
        Try
            If chkPersonal.Checked Then
                If movimiento.Count < 2 Then Throw New Exception("Ingrese al menos 2 detalles")
            End If
            For Each obj As e_MovimientoAnalisis In movimiento
                If (obj.Saldo > 0 And obj.Monto < 0) Or (obj.Saldo < 0 And obj.Monto > 0) Then Throw New Exception("los signos de la columna saldo y monto agregado no son iguales")
                If obj.Monto = 0 Then Throw New Exception("El monto a cancelar es cero")
                If Math.Round(Math.Abs(obj.Saldo), 2) < Math.Round(Math.Abs(obj.Monto), 2) Then Throw New Exception("El monto a cancelar es mayor al saldo")
            Next
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Listar2()
        Try
            Me.Cursor = Cursors.WaitCursor
            If GridPersonalAgregado.Rows.Count > 0 Then
                If MessageBox.Show("Existe Documentos agregados desea eliminarlos", "Mensaje del Sistema", _
               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
               = Windows.Forms.DialogResult.Yes Then
                    leMovAnalisisAgrega.Clear()
                    mostrar_totales()
                Else
                    Exit Sub
                End If
            Else
                leMovAnalisisAgrega.Clear()
                mostrar_totales()
            End If

            Dim oeMD As New e_MovimientoAnalisis
            Dim olMovAnalisis As New l_MovimientoAnalisis
            oeMD.Activo = True
            oeMD.Ejercicio = Date.Parse(FecFecha.Value).Year
            oeMD.TipoOperacion = "R"
            leMD.Clear()
            leMD.AddRange(olMovAnalisis.Listar(oeMD))
            gridDetallePersonal.DataSource = leMD
            gridDetallePersonal.DataBind()

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        gridDetallePersonal.Focus()
    End Sub

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            If chkEmpresas.Checked = False Then
                If gridCobranzaAgregado.Rows.Count > 0 Then
                    If MessageBox.Show("Existen Documentos agregados, desea eliminarlos", "Mensaje del Sistema", _
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        LimpiarGrillaAgregados()
                    Else
                        Exit Sub
                    End If
                Else
                    LimpiarGrillaAgregados()
                End If
            End If

            Me.Cursor = Cursors.WaitCursor
            oeMovimientoDocumento = New e_MovimientoDocumento
            With oeMovimientoDocumento
                .Activo = Activo
                .IdPeriodo = ""
                .Ejercicio = Date.Parse(FecFecha.Value).Year
                .TipoOperacion = "CAN"
                .IdClienteProveedor = cboClienteProveedor.Value
                If OptClientes.Checked = True Then
                    ._Operador = 1
                ElseIf OptProveedores.Checked = True Then
                    ._Operador = -1
                End If
            End With
            leMovDoc.Clear()
            leMovDoc.AddRange(olMovimientoDocumento.Listar(oeMovimientoDocumento))

            CrearComboGrid3("IdClienteProveedor", "Nombre", gridCobranza, True)
            CrearComboGrid3("IdClienteProveedor", "Nombre", gridCobranzaAgregado, True)

            gridCobranza.DataBind()
            mostrar_totales()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
            gridCobranza.Focus()
        End Try
    End Sub

    Private Sub LimpiarGrillaAgregados()
        leMovDocAgregado.Clear()
        EtiImporteSoles.Text = 0
        EtiImporteDolares.Text = 0
        gridCobranzaAgregado.DataBind()
    End Sub

    Private Sub LlenaTipoCompraVenta()
        Try
            '--------------------- para llenar combo en grilla    
            gridCobranza.DisplayLayout.ValueLists.Add("IndCompraVenta")
            With gridCobranza.DisplayLayout.ValueLists("IndCompraVenta").ValueListItems
                .Clear()
                '1:Compra, 2:Venta, 3:Personal, 4:Proveedor, 5:Cliente
                .Add("1", "Compra")
                .Add("2", "Venta")
                .Add("4", "Proveedor")
                .Add("5", "Cliente")
            End With
            CrearComboGrid3("IndCompraVenta", "Tipo", gridCobranza, True)
            '--------------------- para llenar combo en grilla    
            gridCobranzaAgregado.DisplayLayout.ValueLists.Add("IndCompraVenta")
            With gridCobranzaAgregado.DisplayLayout.ValueLists("IndCompraVenta").ValueListItems
                .Clear()
                '1:Compra, 2:Venta, 3:Personal, 4:Proveedor, 5:Cliente
                .Add("1", "Compra")
                .Add("2", "Venta")
                .Add("4", "Proveedor")
                .Add("5", "Cliente")
            End With
            CrearComboGrid3("IndCompraVenta", "Tipo", gridCobranzaAgregado, True)
            '-------------------------------

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboPerido()
        Try

            Dim oePeriodo As New e_Periodo
            Dim olPeriodo As New l_Periodo
            Dim lePeriodo As New List(Of e_Periodo)
            oePeriodo.Ejercicio = Date.Parse(FecFecha.Value).Year
            oePeriodo.Activo = True
            lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))
            '--------------------- para llenar combo en grilla    
            GridPersonalAgregado.DisplayLayout.ValueLists.Add("IdPeriodo")
            With GridPersonalAgregado.DisplayLayout.ValueLists("IdPeriodo").ValueListItems
                .Clear()
                For Each oeTD As e_Periodo In lePeriodo
                    .Add(oeTD.Id, oeTD.Codigo)
                Next
            End With
            CrearComboGrid3("IdPeriodo", "Codigo", GridPersonalAgregado, True)
            '------------------------------------------
            '--------------------- para llenar combo en grilla    
            gridDetallePersonal.DisplayLayout.ValueLists.Add("IdPeriodo")
            With gridDetallePersonal.DisplayLayout.ValueLists("IdPeriodo").ValueListItems
                .Clear()
                For Each oeTD As e_Periodo In lePeriodo
                    .Add(oeTD.Id, oeTD.Codigo)
                Next
            End With
            CrearComboGrid3("IdPeriodo", "Codigo", gridDetallePersonal, True)
            '------------------------------------------


        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub LlenaMoneda()
        Try

            Dim oeMoneda As New e_Moneda
            Dim olMoneda As New l_Moneda
            Dim leMoneda As New List(Of e_Moneda)
            oeMoneda.Activo = True
            leMoneda.AddRange(olMoneda.Listar(oeMoneda))
            '--------------------- para llenar combo en grilla    
            GridPersonalAgregado.DisplayLayout.ValueLists.Add("IdMoneda")
            With GridPersonalAgregado.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                .Clear()
                For Each oeTD As e_Moneda In leMoneda
                    .Add(oeTD.Id, oeTD.Abreviatura)
                Next
            End With
            CrearComboGrid3("IdMoneda", "Abreviatura", GridPersonalAgregado, True)
            '--------------------- para llenar combo en grilla    
            gridDetallePersonal.DisplayLayout.ValueLists.Add("IdMoneda")
            With gridDetallePersonal.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                .Clear()
                For Each oeTD As e_Moneda In leMoneda
                    .Add(oeTD.Id, oeTD.Abreviatura)
                Next
            End With
            CrearComboGrid3("IdMoneda", "Abreviatura", gridDetallePersonal, True)
            '--------------------- para llenar combo en grilla    
            gridCobranza.DisplayLayout.ValueLists.Add("IdMoneda")
            With gridCobranza.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                .Clear()
                For Each oeTD As e_Moneda In leMoneda
                    .Add(oeTD.Id, oeTD.Abreviatura)
                Next
            End With
            CrearComboGrid3("IdMoneda", "Abreviatura", gridCobranza, True)
            '--------------------- para llenar combo en grilla    
            gridCobranzaAgregado.DisplayLayout.ValueLists.Add("IdMoneda")
            With gridCobranzaAgregado.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                .Clear()
                For Each oeTD As e_Moneda In leMoneda
                    .Add(oeTD.Id, oeTD.Abreviatura)
                Next
            End With
            CrearComboGrid3("IdMoneda", "Abreviatura", gridCobranzaAgregado, True)
            '-------------------------------
            With cboMoneda
                .ValueMember = "Id"
                .DisplayMember = "Abreviatura"
                .DataSource = leMoneda
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaTipoDocumentoOperacion()
        Try
            Dim oeTipoDoc As New e_TipoDocumento
            leTipoDoc = New List(Of e_TipoDocumento)
            Dim olTipoDoc As New l_TipoDocumento
            oeTipoDoc.Activo = True
            oeTipoDoc.TipoOperacion = "C" 'proceso contabilidad
            leTipoDoc.AddRange(olTipoDoc.Listar(oeTipoDoc))
            '--------------------- para llenar combo en grilla    
            gridCobranza.DisplayLayout.ValueLists.Add("IdTipoDocumento")
            With gridCobranza.DisplayLayout.ValueLists("IdTipoDocumento").ValueListItems
                .Clear()
                For Each oeTD As e_TipoDocumento In leTipoDoc
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdTipoDocumento", "Nombre", gridCobranza, True)
            '------------------------------------------
            '--------------------- para llenar combo en grilla    
            gridCobranzaAgregado.DisplayLayout.ValueLists.Add("IdTipoDocumento")
            With gridCobranzaAgregado.DisplayLayout.ValueLists("IdTipoDocumento").ValueListItems
                .Clear()
                For Each oeTD As e_TipoDocumento In leTipoDoc
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdTipoDocumento", "Nombre", gridCobranzaAgregado, True)
            '------------------------------------------

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarComboCP()
        Try
            gridCobranza.DisplayLayout.ValueLists.Add("IdClienteProveedor")
            gridCobranzaAgregado.DisplayLayout.ValueLists.Add("IdClienteProveedor")

            LECP.CLEAR()
            leCP.AddRange(ProveedorPublic)
            leCP.AddRange(ClientesPublic)

            With gridCobranza.DisplayLayout.ValueLists("IdClienteProveedor").ValueListItems
                For Each oeTD As e_Combo In leCP
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            With gridCobranzaAgregado.DisplayLayout.ValueLists("IdClienteProveedor").ValueListItems
                For Each oeTD As e_Combo In leCP
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarDetalle()
        Try
            l_FuncionesGenerales.ValidarNumero(decTC.Value, "Tipo de Cambio")
            If gridCobranzaAgregado.Rows.Count > 1 Then
                Throw New Exception("Solo pueden aplicarse a dos documentos")
            End If
            If gridCobranza.Rows.Count > 0 AndAlso Not gridCobranza.ActiveRow.ListObject Is Nothing Then
                'Inicializo(objeto)
                oeMovimientoDocumento = New e_MovimientoDocumento
                '---capturo datos a ingresar-----
                oeMovimientoDocumento = gridCobranza.ActiveRow.ListObject
                oeMovimientoDocumento.TipoOperacion = "I"
                '-----------------------
                If oeMovimientoDocumento.Saldo < 0 Then
                    'mensajeEmergente.Confirmacion("Se reemplazará el tipo de cambio", True)
                    decTC.Value = oeMovimientoDocumento.TipoCambio
                End If
                If ValidarAgregarDetalle() Then
                    With leMovDocAgregado
                        If Not .Contains(oeMovimientoDocumento) Then
                            ' si no esta en la lista o no esta contenido AGREGOOO
                            .Add(oeMovimientoDocumento.Clonar)
                        Else
                            Throw New Exception("Ya existe este documento asociado")
                        End If
                    End With
                    If leMovDocAgregado.Count = 2 Then
                        MontoNegativo()
                    End If
                    mostrar_totales()
                    gridCobranzaAgregado.DataBind()

                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub MontoNegativo()
        Dim MontoOperar As Double = 0
        For Each oeMovimientoDocumento As e_MovimientoDocumento In leMovDocAgregado
            With oeMovimientoDocumento
                If .Saldo < 0 Then
                    MontoOperar = .MontoOperar
                End If
            End With
        Next
        For Each oeMovimientoDocumento As e_MovimientoDocumento In leMovDocAgregado
            With oeMovimientoDocumento
                If .Saldo > 0 Then
                    If Math.Abs(MontoOperar) > .MontoOperar Then
                        MontoOperar = -.MontoOperar
                    Else
                        .MontoOperar = Math.Abs(MontoOperar)
                    End If

                End If
            End With
        Next
    End Sub

    Private Sub Mostrar_totales()
        Try
            Dim importeMN As Double = 0
            Dim importeME As Double = 0
            If chkPersonalCtas.Checked Then
                For Each oeMovAnalis As e_MovimientoAnalisis In leMovAnalisisAgrega
                    With oeMovAnalis
                        If .IdMoneda = "1CH01" Then
                            importeMN = importeMN + .Monto
                            importeME = importeME + .Monto / decTC.Value
                        Else
                            importeMN = importeMN + .Monto * decTC.Value
                            importeME = importeME + .Monto
                        End If
                    End With
                Next
                For Each oeMovimientoDocumento As e_MovimientoDocumento In leMovDocAgregado
                    With oeMovimientoDocumento
                        If .IdMoneda = "1CH01" Then
                            importeMN = importeMN + .MontoOperar
                            importeME = importeME + .MontoOperar / decTC.Value
                        Else
                            importeMN = importeMN + .MontoOperar * decTC.Value
                            importeME = importeME + .MontoOperar
                        End If
                    End With
                Next
            Else
                If chkPersonal.Checked Then
                    For Each oeMovAnalis As e_MovimientoAnalisis In leMovAnalisisAgrega
                        With oeMovAnalis
                            If .IdMoneda = "1CH01" Then
                                importeMN = importeMN + .Monto
                                importeME = importeME + .Monto / decTC.Value
                            Else
                                importeMN = importeMN + .Monto * decTC.Value
                                importeME = importeME + .Monto
                            End If
                        End With
                    Next
                Else
                    For Each oeMovimientoDocumento As e_MovimientoDocumento In leMovDocAgregado
                        With oeMovimientoDocumento
                            If .IdMoneda = "1CH01" Then
                                importeMN = importeMN + .MontoOperar
                                importeME = importeME + .MontoOperar / decTC.Value
                            Else
                                importeMN = importeMN + .MontoOperar * decTC.Value
                                importeME = importeME + .MontoOperar
                            End If
                        End With
                    Next
                End If

            End If

            importeME = Math.Round(importeME, 4)
            importeMN = Math.Round(importeMN, 4)
            EtiImporteSoles.Text = importeMN.ToString
            EtiImporteDolares.Text = importeME.ToString

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidarAgregarDetalle() As Boolean
        Try
            ValidarGrilla(gridCobranza, "Compensacion de saldos")
            If Not gridCobranza.ActiveRow Is Nothing AndAlso gridCobranza.ActiveRow.Cells("Id").Value.ToString = "" Then Throw New Exception("Seleccione una fila")
            If chkEmpresas.Checked = False Then
                If gridCobranzaAgregado.Rows.Count > 0 Then 'Verificar que solo pueda ingresar Pagos de un solo cliente
                    If gridCobranzaAgregado.Rows.Item(0).Cells("IdClienteProveedor").Value <> oeMovimientoDocumento.IdClienteProveedor Then
                        Throw New Exception("Solo puede agregar Documentos de un Solo Cliente/Proveedor")
                    End If
                End If
            End If
            l_FuncionesGenerales.ValidarNumero(decTC.Value, "Tipo de Cambio")
            If oeMovimientoDocumento.FechaEmision.Date > FecFecha.Value Then Throw New Exception("La fecha del documento es mayor a la fecha del asiento")

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidarAgregarDetalle(ByVal oeMA As e_MovimientoAnalisis) As Boolean
        Try
            ValidarGrilla(gridDetallePersonal, "Documentos x Rendir")

            If gridDetallePersonal.ActiveRow Is Nothing Then Throw New Exception("Seleccione una fila")

            l_FuncionesGenerales.ValidarCampoNoNulo(gridDetallePersonal.ActiveRow.Cells("Id").Value.ToString, "Seleccione una fila")

            l_FuncionesGenerales.ValidarNumero(decTC.Value, "Tipo de cambio")

            'If DecSinIgv.Value >= DecTotalImponible.Value + DecNoGravada.Value Then Throw New Exception("El Importe debe ser menor o igual al monto del documento")

            If oeMA.IdMoneda <> cboMoneda.Value Then Throw New Exception("Tiene que ser moneda soles")

            'If oeMA.Saldo <= 0 Then Throw New Exception("Saldo mayor a cero")

            'l_FuncionesGenerales.ValidarNumero(DecTotalDoc.Value, "Importe Doc")

            Return True

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub QuitarDetalle()
        Try
            If gridCobranzaAgregado.Rows.Count <= 0 Then Throw New Exception("Seleccione una fila")
            ValidarGrilla(gridCobranzaAgregado, "Documentos x Rendir agregados")
            If gridCobranzaAgregado.ActiveRow Is Nothing Then Throw New Exception("Seleccione una fila")
            If Not gridCobranzaAgregado.ActiveRow.ListObject Is Nothing AndAlso gridCobranzaAgregado.ActiveRow.Cells("Id").Value.ToString = "" Then Throw New Exception("Seleccione una fila")
            'inicialializo mi objeto
            oeMovimientoDocumento = New e_MovimientoDocumento
            '---Obtengo O CAPTURO objeto de la grilla 
            oeMovimientoDocumento = gridCobranzaAgregado.ActiveRow.ListObject
            '----------------------
            With leMovDocAgregado
                '-----remuevo o elimino de mi lista de objetos
                .Remove(oeMovimientoDocumento)
                '-------------------
            End With
            gridCobranzaAgregado.DataBind()
            mostrar_totales()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Private Sub AgregarDetalle2()
        Try

            If gridDetallePersonal.Rows.Count > 0 And Not gridDetallePersonal.ActiveRow.ListObject Is Nothing Then
                Dim oeMovAnalisis2 As New e_MovimientoAnalisis
                oeMovAnalisis2 = gridDetallePersonal.ActiveRow.ListObject
                oeMovAnalisis2.TipoOperacion = "I"
                oeMovAnalisis2.PrefijoID = gs_PrefijoIdSucursal '@0001
                '-----------------------
                If ValidarAgregarDetalle(oeMovAnalisis2) Then
                    With leMovAnalisisAgrega
                        If Not .Contains(oeMovAnalisis2) Then
                            .Add(oeMovAnalisis2.Clone)
                            .Item(.Count - 1).Monto = oeMovAnalisis2.Saldo
                        Else
                            Throw New Exception("Ya existe este documento asociado")
                        End If
                    End With
                    mostrar_totales()
                End If
                GridPersonalAgregado.DataSource = leMovAnalisisAgrega
                GridPersonalAgregado.DataBind()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub QuitarDetalle2()
        Try
            If GridPersonalAgregado.Rows.Count > 0 Then
                ValidarGrilla(GridPersonalAgregado, "Documentos x Rendir agregados")
                If GridPersonalAgregado.ActiveRow.ListObject Is Nothing Then Throw New Exception("Seleccione una fila")
                l_FuncionesGenerales.ValidarCampoNoNulo(GridPersonalAgregado.ActiveRow.Cells("Id").Value.ToString, "Seleccione una fila")
                'inicialializo mi objeto
                Dim oeMovAnalisis2 As New e_MovimientoAnalisis
                '---Obtengo O CAPTURO objeto de la grilla 
                oeMovAnalisis2 = GridPersonalAgregado.ActiveRow.ListObject
                '----------------------
                With leMovAnalisisAgrega
                    '-----remuevo o elimino de mi lista de objetos
                    .Remove(oeMovAnalisis2)
                    '-------------------
                End With
                mostrar_totales()
            End If
            GridPersonalAgregado.DataSource = leMovAnalisisAgrega
            GridPersonalAgregado.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ActualizarCP()
        Try
            If OptClientes.Checked = True Then
                LlenarComboMaestro(cboClienteProveedor, ClientesPublic, 0)
            End If
            If OptProveedores.Checked = True Then
                LlenarComboMaestro(cboClienteProveedor, ProveedorPublic, 0)
            End If
            cboClienteProveedor.Value = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_CompensacionSaldo_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 1, 1, 0, 0, 0, 1)

    End Sub

    Private Sub frm_CompensacionSaldo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_CompensacionSaldo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If _Operacion = "Nuevo" Or _Operacion = "Editar" Then
            Me.Activate()
            Me.Cancelar()
        End If
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_CompensacionSaldo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ControlBoton(1, 0, 0, 1, 0, 0, 0, 1, 1)
            ComboPerido()
            LlenaMoneda()
            LlenaTipoDocumentoOperacion()
            LlenarComboCP()
            gridCobranzaAgregado.DataSource = leMovDocAgregado
            gridCobranza.DataSource = leMovDoc
            LlenaTipoCompraVenta()
            gridCobranzaAgregado.Visible = True
            GridPersonalAgregado.Visible = False
            gridCobranzaAgregado.Dock = DockStyle.Fill
            GridPersonalAgregado.Dock = DockStyle.None
            gridCobranza.Visible = True
            gridDetallePersonal.Visible = False
            gridCobranza.Dock = DockStyle.Fill
            gridDetallePersonal.Dock = DockStyle.None

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridCobranza_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridCobranza.DoubleClick
        Try
            AgregarDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridCobranzaAgregado_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles gridCobranzaAgregado.CellChange
        Try
            l_FuncionesGenerales.ValidarNumero(decTC.Value, "Tipo de Cambio")

            If IsNumeric(e.Cell.Value) Then

                gridCobranzaAgregado.UpdateData()
                mostrar_totales()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub decTC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decTC.ValueChanged
        Try
            mostrar_totales()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub AgregarDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarDocumento.Click
        Try
            AgregarDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub QuitarDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarDocumento.Click
        Try
            QuitarDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub FecFecha_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles FecFecha.Validated
        Try
            decTC.Value = TipoCambio(FecFecha.Value, True)(0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub chkPersonal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPersonal.CheckedChanged
        If chkPersonal.Checked Then
            chkPersonalCtas.Checked = False
            gridCobranzaAgregado.Visible = False
            GridPersonalAgregado.Visible = True
            gridCobranzaAgregado.Dock = DockStyle.None
            GridPersonalAgregado.Dock = DockStyle.Fill
            gridCobranza.Visible = False
            gridDetallePersonal.Visible = True
            gridCobranza.Dock = DockStyle.None
            gridDetallePersonal.Dock = DockStyle.Fill
            chkEmpresas.Visible = False
            mostrar_totales()
        Else
            gridCobranzaAgregado.Visible = True
            GridPersonalAgregado.Visible = False
            gridCobranzaAgregado.Dock = DockStyle.Fill
            GridPersonalAgregado.Dock = DockStyle.None
            gridCobranza.Visible = True
            gridDetallePersonal.Visible = False
            gridCobranza.Dock = DockStyle.Fill
            gridDetallePersonal.Dock = DockStyle.None
            chkEmpresas.Visible = True
            mostrar_totales()
        End If
    End Sub

    Private Sub gridDetallePersonal_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridDetallePersonal.DoubleClick
        AgregarDetalle2()
    End Sub

    Private Sub EliminarAnalisis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarAnalisis.Click
        QuitarDetalle2()
    End Sub

    Private Sub GridPersonalAgregado_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles GridPersonalAgregado.AfterCellUpdate
        Try
            l_FuncionesGenerales.ValidarNumero(decTC.Value, "Tipo de Cambio")

            If IsNumeric(e.Cell.Value) Then
                mostrar_totales()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub chkPersonalCtas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPersonalCtas.CheckedChanged
        If chkPersonalCtas.Checked Then
            chkPersonal.Checked = False
            gridCobranza.Visible = True
            gridCobranzaAgregado.Visible = True
            GridPersonalAgregado.Visible = True
            gridDetallePersonal.Visible = True
            gridCobranza.Dock = DockStyle.Left
            gridCobranzaAgregado.Dock = DockStyle.Left
            gridDetallePersonal.Dock = DockStyle.Fill
            GridPersonalAgregado.Dock = DockStyle.Fill
            gridCobranza.Width = 600
            gridCobranzaAgregado.Width = 600
            mostrar_totales()
            chkEmpresas.Visible = False
        Else
            mostrar_totales()
            gridCobranza.Visible = True
            gridCobranzaAgregado.Visible = True
            GridPersonalAgregado.Visible = False
            gridDetallePersonal.Visible = False
            gridCobranza.Dock = DockStyle.Fill
            gridCobranzaAgregado.Dock = DockStyle.Fill
            chkEmpresas.Visible = True
        End If
    End Sub

    Private Sub cboClienteProveedor_InitializeLayout(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboClienteProveedor.InitializeLayout
        Try
            With cboClienteProveedor.DisplayLayout.Bands(0)
                .Columns("Id").Hidden = True
                .Columns("Descripcion").Hidden = True
                .Columns("Nombre").Hidden = False
                .Columns("Nombre").Width = 350
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboClienteProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboClienteProveedor.KeyPress
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                cboClienteProveedor.PerformAction(UltraComboAction.Dropdown)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboClienteProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles cboClienteProveedor.KeyDown
        Try
            With CType(sender, Infragistics.Win.UltraWinGrid.UltraCombo)
                If e.KeyData = Keys.Delete Then
                    .Text = ""
                End If
            End With
            If e.KeyCode = Keys.Enter Then
                If OptProveedores.Checked = True Then
                    If cboClienteProveedor.Text.Trim = "" Then
                        cboClienteProveedor.DataSource = Nothing
                        cboClienteProveedor.DataSource = ProveedorPublic
                    Else
                        cboClienteProveedor.DataSource = Nothing
                        cboClienteProveedor.DataSource = ProveedorPublic.Where(Function(Item) Item.Nombre.Contains(cboClienteProveedor.Text.Trim)).ToList
                    End If
                ElseIf OptClientes.Checked = True Then
                    If cboClienteProveedor.Text.Trim = "" Then
                        cboClienteProveedor.DataSource = Nothing
                        cboClienteProveedor.DataSource = ClientesPublic
                    Else
                        cboClienteProveedor.DataSource = Nothing
                        cboClienteProveedor.DataSource = ClientesPublic.Where(Function(Item) Item.Nombre.Contains(cboClienteProveedor.Text.Trim)).ToList
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub OptClientes_CheckedChanged(sender As Object, e As EventArgs) Handles OptClientes.CheckedChanged
        Try
            If OptClientes.Checked Then
                ActualizarCP()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub OptProveedores_CheckedChanged(sender As Object, e As EventArgs) Handles OptProveedores.CheckedChanged
        Try
            If OptProveedores.Checked Then
                ActualizarCP()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub FecFecha_ValueChanged(sender As Object, e As EventArgs) Handles FecFecha.ValueChanged
        Try
            decTC.Value = TipoCambio(FecFecha.Value, True)(0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

End Class