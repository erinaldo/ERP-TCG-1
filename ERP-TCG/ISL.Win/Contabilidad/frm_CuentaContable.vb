Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF

Public Class frm_CuentaContable
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaración de variables"

    Private WithEvents oeCuentaContable As New e_CuentaContable
    Private olCuentaContable As New l_CuentaContable
    Private oeCuentaAsociada As New e_CuentaAsociada

    Private olTablaContableDet As New l_TablaContableDet, oeTablaContableDet As New e_TablaContableDet
    Private leCuentaCtableAsociada As New List(Of e_CuentaContable)
    Private oeGastoFuncion As New e_TablaContableDet

    Dim oeCombo As e_Combo
    Dim olCombo As l_Combo
    Dim ListGastoFuncion As List(Of e_Combo)

    Private Shared instancia As frm_CuentaContable = Nothing

#End Region

#Region "Definición del Formulario base"

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_CuentaContable()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            If gridCuentaContable.Rows.Count > 0 Then
                MyBase.Consultar(Activo) 'activa desactiva botonera
            Else
                MyBase.Consultar() 'activa desactiva botonera
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Inicializar()
        oeCuentaContable.Ejercicio = Año1.Año
        etiPeriodo.Text = "Periodo: " + oeCuentaContable.Ejercicio.ToString
        oeCuentaContable.TipoOperacion = "I"
        oeCuentaContable.Modificado = False
        txtCuenta.Focus()
        MyBase.Nuevo() 'activa desactiva botonera
    End Sub

    Public Overrides Sub Editar()
        Try
            If ValidarGrilla(gridCuentaContable, "Cuenta Contable") Then
                If gridCuentaContable.ActiveRow.Cells("Id").Value.ToString <> "" Then
                    Inicializar()
                    Mostrar()
                    oeCuentaContable.TipoOperacion = "A"
                    oeCuentaContable.Modificado = False
                    txtNombre.Focus()
                    MyBase.Editar()
                Else
                    Throw New Exception("Seleccione una Fila!")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarCuenta() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcCuentaContable)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeCuentaContable.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If Not GuardarCuenta() Then
                            MostrarTabs(1, tcCuentaContable)
                            Consultar(_Activo) 'activa desactiva botonera
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcCuentaContable)
                        Consultar(_Activo) 'activa desactiva botonera
                End Select
            Else
                MostrarTabs(0, tcCuentaContable)
                Consultar(_Activo) 'activa desactiva botonera
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With gridCuentaContable
                If ValidarGrilla(gridCuentaContable, "Cuenta Contable") Then
                    If .ActiveRow.Cells("Id").Value.ToString <> "" Then
                        oeCuentaContable.Id = .ActiveRow.Cells("Id").Value
                        oeCuentaContable = olCuentaContable.Obtener(oeCuentaContable)
                        If oeCuentaContable.Activo Then
                            If MessageBox.Show("Esta seguro de eliminar la Cuenta: " & _
                                     .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeCuentaContable.TipoOperacion = "E"
                                olCuentaContable.Eliminar(oeCuentaContable)
                                Consultar(_Activo)
                            End If
                        Else
                            Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                        End If
                    Else
                        Throw New Exception("Seleccione una Fila!")
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
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
            If gridCuentaContable.Rows.Count = 0 Then Throw New Exception("No hay ninguna Cuenta Contable para exportar al Excel")
            Exportar_Excel(gridCuentaContable)

            If griCuentaDetalle.Rows.Count = 0 Then Throw New Exception("No hay ningún detalle de Cuenta Contable para exportar al Excel")
            Exportar_Excel(griCuentaDetalle)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Métodos"

    Private Sub Inicializar()
        oeCuentaContable = New e_CuentaContable
        txtNombre.Text = String.Empty : txtCuenta.Text = String.Empty : cboCuentaCorriente.Value = "" : cboNaturaleza.SelectedIndex = -1
        cboTipoDocumento.Value = "" : chkAnalisis1.Checked = False : chkAnalisis2.Checked = False : chkGastoFuncion.Checked = False
        chkBanco.Checked = False : chkConciliacion.Checked = False : chkCuentaImputable.Checked = False : chkFecEmision.Checked = False
        chkFecVenc.Checked = False : chkFlujoCaja.Checked = False : chkMonedaExt.Checked = False : chkNroDoc.Checked = False
        chkRuta.Checked = False : chkSerieDoc.Checked = False : chkTipoDocumento.Checked = False : chkTracto.Checked = False
        chkTransportista.Checked = False : chkDebe.Checked = False : chkHaber.Checked = False : agrAnalisis.Enabled = True : chkCentroCosto.Checked = False
        agrPartidaCuenta.Enabled = True : agrCajaBanco.Enabled = True : agrDatosSecundario.Enabled = True : agrRefDoc.Enabled = True
        tcDatosCuenta.Tabs(0).Selected = True : cboCuenta.SelectedIndex = -1
        LimpiaGrid(griCuentaDetalle, UltraDataSource3)
        verActivo.Checked = oeCuentaContable.Activo
        verActivo.Visible = Not oeCuentaContable.Activo
        MostrarTabs(1, tcCuentaContable, 1)
    End Sub

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeCuentaContable = New e_CuentaContable
            oeCuentaContable.Activo = Activo
            oeCuentaContable.Ejercicio = Año1.Año
            LimpiaGrid(gridCuentaContable, ogdPlanCuenta)
            With gridCuentaContable
                .DataSource = olCuentaContable.Listar(oeCuentaContable)
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

    Private Sub Mostrar()
        Try
            If gridCuentaContable.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                oeCuentaContable.Id = gridCuentaContable.ActiveRow.Cells("Id").Value.ToString
                oeCuentaContable = olCuentaContable.Obtener(oeCuentaContable)
                With oeCuentaContable
                    etiPeriodo.Text = "Periodo: " + .Ejercicio.ToString
                    txtNombre.Text = .Nombre
                    txtCuenta.Text = .Cuenta
                    chkAnalisis1.Checked = .Analisis01
                    chkAnalisis2.Checked = .Analisis02
                    chkGastoFuncion.Checked = .GastoFuncion
                    chkBanco.Checked = .Banco
                    chkConciliacion.Checked = .Conciliacion
                    chkCuentaImputable.Checked = .Movimiento
                    chkFecEmision.Checked = .FechaEmision
                    chkFecVenc.Checked = .FechaVencimiento
                    chkFlujoCaja.Checked = .FlujoCaja
                    chkMonedaExt.Checked = .MonedaExtrangera
                    chkNroDoc.Checked = .NroDocumento
                    chkRuta.Checked = .Ruta
                    chkSerieDoc.Checked = .Serie
                    chkTipoDocumento.Checked = IIf(.TipoDocGeneral.Trim <> "", True, False)
                    cboNaturaleza.Value = .Naturaleza
                    cboTipoDocumento.Value = .TipoDocGeneral.Trim
                    cboCuentaCorriente.Value = .TipoCuentaCorriente.Trim
                    chkTesoreria.Checked = oeCuentaContable.Tesoreria
                    chkTracto.Checked = oeCuentaContable.Tracto
                    chkTransportista.Checked = oeCuentaContable.Trabajador
                    chkCentroCosto.Checked = oeCuentaContable.CentroCosto
                    verActivo.Checked = .Activo
                    verActivo.Visible = Not .Activo
                    Select Case .PartidaAnalisis
                        Case 0 : chkDebe.Checked = True : chkHaber.Checked = True
                        Case 1 : chkDebe.Checked = True : chkHaber.Checked = False
                        Case 2 : chkDebe.Checked = False : chkHaber.Checked = True
                        Case Else : chkDebe.Checked = False : chkHaber.Checked = False
                    End Select
                    cboGFAnalisis.Text = .IdTablaContableDet
                    CargaCuentaAsociadas(oeCuentaContable.CuentaAsociada)
                End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function GuardarCuenta() As Boolean
        Try
            If ValidaCuenta() Then
                If chkDebe.Checked Then
                    oeCuentaContable.PartidaAnalisis = IIf(chkHaber.Checked, 0, 1)
                Else
                    oeCuentaContable.PartidaAnalisis = IIf(chkHaber.Checked, 2, -1)
                End If
                If chkGastoFuncion.Checked = True Then
                    If cboGFAnalisis.Text.Trim = "" Then
                        Throw New Exception("Seleccion Gasto funcion generico para esta cuenta.")
                    End If
                End If
                oeCuentaContable.IdTablaContableDet = cboGFAnalisis.Value
                olCuentaContable.Guardar(oeCuentaContable)
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente", True)
                MostrarTabs(0, tcCuentaContable, 2)
                Consultar(True)
                gridCuentaContable.Focus()
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub r_HabilitaDeshabilitaGrupo()
        Dim lbBand As Boolean = True
        If chkConciliacion.Checked = True Or chkFlujoCaja.Checked = True Then
            chkSerieDoc.Checked = False : chkFecVenc.Checked = False : agrRefDoc.Enabled = False : chkTracto.Checked = False
            chkRuta.Checked = False : chkTransportista.Checked = False : chkBanco.Checked = False : chkAnalisis1.Checked = False : chkCentroCosto.Checked = False
            chkAnalisis2.Checked = False : chkGastoFuncion.Checked = False : agrAnalisis.Enabled = False
            chkDebe.Checked = False : chkHaber.Checked = False : agrPartidaCuenta.Enabled = False
            lbBand = False
        ElseIf chkSerieDoc.Checked = True Or chkFecVenc.Checked = True Then
            chkConciliacion.Checked = False : chkFlujoCaja.Checked = False : agrCajaBanco.Enabled = False : chkTracto.Checked = False
            chkRuta.Checked = False : chkTransportista.Checked = False : chkBanco.Checked = False : chkAnalisis1.Checked = False : chkCentroCosto.Checked = False
            chkAnalisis2.Checked = False : chkGastoFuncion.Checked = False : agrAnalisis.Enabled = False
            chkDebe.Checked = False : chkHaber.Checked = False : agrPartidaCuenta.Enabled = False
            lbBand = False
        ElseIf chkTracto.Checked = True Or chkRuta.Checked = True Or chkTransportista.Checked = True Or chkBanco.Checked = True Or chkAnalisis1.Checked = True _
            Or chkAnalisis2.Checked = True Or chkGastoFuncion.Checked = True Or chkDebe.Checked = True Or chkHaber.Checked = True Or chkCentroCosto.Checked = True Then
            chkFecEmision.Checked = False : chkNroDoc.Checked = False : chkConciliacion.Checked = False : chkFlujoCaja.Checked = False
            chkSerieDoc.Checked = False : chkFecVenc.Checked = False : cboTipoDocumento.Value = "" : agrCajaBanco.Enabled = False
            agrRefDoc.Enabled = False : chkTipoDocumento.Checked = False : chkNroDoc.Checked = False : chkFecEmision.Checked = False
            agrDatosSecundario.Enabled = False
            lbBand = False
        ElseIf chkTipoDocumento.Checked = True Or chkNroDoc.Checked = True Or chkFecEmision.Checked = True Then
            agrCajaBanco.Enabled = True : agrRefDoc.Enabled = True : agrDatosSecundario.Enabled = True : chkTracto.Checked = False
            chkRuta.Checked = False : chkTransportista.Checked = False : chkBanco.Checked = False : chkAnalisis1.Checked = False : chkCentroCosto.Checked = False
            chkAnalisis2.Checked = False : chkGastoFuncion.Checked = False : agrAnalisis.Enabled = False
            chkDebe.Checked = False : chkHaber.Checked = False : agrPartidaCuenta.Enabled = False
            lbBand = False
        End If
        If lbBand = True Then
            agrCajaBanco.Enabled = True : agrRefDoc.Enabled = True : agrAnalisis.Enabled = True
            agrDatosSecundario.Enabled = True : agrPartidaCuenta.Enabled = True
        End If
    End Sub

    Private Sub LlenarCombos()
        Try
            ComboNaturaleza()
            ComboCuentaCorriente()
            ComboDocumentoContable()
            ListGastoFuncion = New List(Of e_Combo)
            oeCombo = New e_Combo
            oeCombo.Nombre = "GASTO FUNCION"
            ListGastoFuncion.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
            LlenarComboMaestro(cboGFAnalisis, ListGastoFuncion, 0)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ComboNaturaleza()
        Try
            oeTablaContableDet = New e_TablaContableDet
            Dim leTablaContableDet As New List(Of e_TablaContableDet)
            oeTablaContableDet.TipoOperacion = "N"
            oeTablaContableDet.Nombre = "TIPO DE CUENTA CONTABLE" 'tipo de cuenta o naturaleza
            oeTablaContableDet.Activo = True
            leTablaContableDet.AddRange(olTablaContableDet.Listar(oeTablaContableDet))
            '--------------------- para llenar combo en grilla    
            gridCuentaContable.DisplayLayout.ValueLists.Add("Naturaleza")
            With gridCuentaContable.DisplayLayout.ValueLists("Naturaleza").ValueListItems
                .Clear()
                For Each oeTD As e_TablaContableDet In leTablaContableDet
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("Naturaleza", "Nombre", gridCuentaContable, True)
            '------------------------------------------
            With cboNaturaleza
                .DisplayMember = "Nombre"
                .ValueMember = "Id"
                .DataSource = leTablaContableDet
            End With
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ComboCuentaCorriente()
        Try
            Dim leTablaContableDet As New List(Of e_TablaContableDet)
            oeTablaContableDet = New e_TablaContableDet
            oeTablaContableDet.Id = ""
            oeTablaContableDet.Nombre = "NINGUNO"
            leTablaContableDet.Add(oeTablaContableDet)
            oeTablaContableDet = New e_TablaContableDet
            oeTablaContableDet.TipoOperacion = "N"
            oeTablaContableDet.Nombre = "TIPO DE CUENTA CORRIENTE" 'Tipo de cuenta Corriente
            oeTablaContableDet.Activo = True
            leTablaContableDet.AddRange(olTablaContableDet.Listar(oeTablaContableDet))
            With cboCuentaCorriente
                .DisplayMember = "Nombre"
                .ValueMember = "Id"
                .DataSource = leTablaContableDet
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboDocumentoContable()
        Try
            Dim leTablaContableDet As New List(Of e_TablaContableDet)
            oeTablaContableDet = New e_TablaContableDet
            oeTablaContableDet.Id = ""
            oeTablaContableDet.Nombre = "NINGUNO"
            leTablaContableDet.Add(oeTablaContableDet)
            oeTablaContableDet = New e_TablaContableDet
            oeTablaContableDet.TipoOperacion = "N"
            oeTablaContableDet.Nombre = "TIPO DE DOCUMENTO GENERAL" 'tipo de Documento general
            oeTablaContableDet.Activo = True
            leTablaContableDet.AddRange(olTablaContableDet.Listar(oeTablaContableDet))
            With cboTipoDocumento
                .DisplayMember = "Nombre"
                .ValueMember = "Id"
                .DataSource = leTablaContableDet
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboCuenta()
        Try
            With cboCuenta
                If .Items.Count < 1 Then
                    Dim oeCuentaCtable As New e_CuentaContable

                    oeCuentaCtable.Activo = True
                    oeCuentaCtable.Movimiento = 1
                    oeCuentaCtable.Ejercicio = Año1.Año
                    leCuentaCtableAsociada.AddRange(olCuentaContable.Listar(oeCuentaCtable))
                    '---------------------para llenar combo en grilla
                    With griCuentaDetalle.DisplayLayout
                        If .Bands(0).Columns.Exists("IdCuentaAsociada") Then
                            .ValueLists.Clear()
                            .ValueLists.Add("IdCuentaAsociada")
                        End If
                    End With
                    With griCuentaDetalle.DisplayLayout.ValueLists("IdCuentaAsociada").ValueListItems
                        .Clear()
                        For Each oeCC As e_CuentaContable In leCuentaCtableAsociada
                            .Add(oeCC.Id, oeCC.Cuenta)
                        Next
                    End With
                    CrearComboGrid3("IdCuentaAsociada", "Cuenta", griCuentaDetalle, True)
                    '------------------------------------------
                    .ValueMember = "Id"
                    .DisplayMember = "Cuenta"
                    .DataSource = leCuentaCtableAsociada
                End If

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidaCuentaAsociada() As Boolean
        Try
            ValidarOpciones(opcDebeHaber, "Debe/Haber")
            ValidarCombo(cboCuenta, "Cuenta")
            Return True
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function ValidaCuenta() As Boolean
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(txtCuenta.Text, "Ingrese el Número de Cuenta")
            l_FuncionesGenerales.ValidarCampoNoNulo(txtNombre.Text, "Nombre de Cuenta")
            ValidarCombo(cboNaturaleza, "Naturaleza")
            Return True
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub CargaCuentaAsociadas(ByVal oe_CA As List(Of e_CuentaAsociada))
        Try
            With griCuentaDetalle
                LimpiaGrid(griCuentaDetalle, UltraDataSource3)
                Dim leCuentaAsociadaActivos As New List(Of e_CuentaAsociada)
                '-----------obtengo lista de objetos activos
                leCuentaAsociadaActivos = oe_CA.Where(Function(item) item.TipoOperacion <> "E").ToList
                '-----------------
                .DataSource = leCuentaAsociadaActivos
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
            End With
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AgregarCuentaAsociada()
        Try
            If ValidaCuentaAsociada() Then
                'Inicializo objeto
                oeCuentaAsociada = New e_CuentaAsociada
                '---
                '---capturo datos a ingresa-----
                With oeCuentaAsociada
                    .Id = ""
                    .IdCuentaContable = oeCuentaContable.Id
                    .IdCuentaAsociada = cboCuenta.Value
                    .DebeHaber = opcDebeHaber.Value
                    .GastoFuncion = cboGastoFuncion.Value
                    .Activo = True
                    .TipoOperacion = "I"
                End With
                '-----------------------
                With oeCuentaContable
                    If .TipoOperacion = "I" Then ' cuando inserto o nuevo cabecera y detalles
                        If Not .CuentaAsociada.Contains(oeCuentaAsociada) Then
                            ' si no esta en la lista o no esta contenido AGREGOOO
                            .CuentaAsociada.Add(oeCuentaAsociada)
                        Else
                            Throw New Exception("Ya existe esta Cuenta")
                        End If
                    ElseIf .TipoOperacion = "A" Then ' cuando actualizo o edito el objeto
                        If Not .CuentaAsociada.Contains(oeCuentaAsociada) Then
                            ' si no esta en la lista o no esta contenido AGREGOOO
                            .CuentaAsociada.Add(oeCuentaAsociada)
                        Else
                            '-------BUSCA OBJETO EN LA LISTA DE OBJETOS
                            oeCuentaAsociada = .CuentaAsociada.Item(.CuentaAsociada.IndexOf(oeCuentaAsociada))
                            '---------
                            If oeCuentaAsociada.TipoOperacion = "E" Then 'Existe en la BD y esta para eliminarse
                                ' la dejo como estaba al inicio(carga)
                                oeCuentaAsociada.TipoOperacion = ""
                            Else
                                Throw New Exception("Ya existe esta Cuenta")
                            End If
                        End If
                    End If
                    'recargo grilla
                    CargaCuentaAsociadas(.CuentaAsociada)
                End With
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EliminarCuentaAsociada()
        Try
            If griCuentaDetalle.Rows.Count > 0 AndAlso Not griCuentaDetalle.ActiveRow.ListObject Is Nothing Then
                With oeCuentaContable
                    'inicialializo mi objeto
                    oeCuentaAsociada = New e_CuentaAsociada
                    '---Obtengo O CAPTURO objeto de la grilla 
                    oeCuentaAsociada = griCuentaDetalle.ActiveRow.ListObject
                    '----------------------

                    If .TipoOperacion = "I" Then 'cuando inserto o nuevo objeto cabecera y detalles
                        '-----remuevo o elimino de mi lista de objetos
                        .CuentaAsociada.Remove(oeCuentaAsociada)
                        '-------------------
                    ElseIf .TipoOperacion = "A" Then ' cuando actualizo o edito el objeto
                        If oeCuentaAsociada.Id <> "" Then '---viene de BD
                            '-----Solo cambio tipo de operacion para desactivar ya que viene de BD
                            oeCuentaAsociada.TipoOperacion = "E"
                            '--------------------
                        Else '-----no viene de BD
                            '-----remuevo de mi lista de objetos
                            .CuentaAsociada.Remove(oeCuentaAsociada)
                            '----------------------------
                        End If
                    End If

                    CargaCuentaAsociadas(.CuentaAsociada) '----recargo mi grilla
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub GastoFuncion()
        If cboGastoFuncion.Items.Count = 0 Then
            oeTablaContableDet = New e_TablaContableDet
            Dim leTablaContableDet As New List(Of e_TablaContableDet)
            oeTablaContableDet.TipoOperacion = "N"
            oeTablaContableDet.Nombre = "GASTO FUNCION" 'tipo de cuenta o naturaleza
            oeTablaContableDet.Activo = True
            oeTablaContableDet.Logico3 = True 'destino
            leTablaContableDet.AddRange(olTablaContableDet.Listar(oeTablaContableDet))
            '--------------------- para llenar combo en grilla    
            griCuentaDetalle.DisplayLayout.ValueLists.Add("GastoFuncion")
            With griCuentaDetalle.DisplayLayout.ValueLists("GastoFuncion").ValueListItems
                .Clear()
                For Each oeTD As e_TablaContableDet In leTablaContableDet
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("GastoFuncion", "Nombre", griCuentaDetalle, True)
            '------------------------------------------
            With cboGastoFuncion
                .DisplayMember = "Nombre"
                .ValueMember = "Id"
                .DataSource = leTablaContableDet
            End With
        End If

    End Sub

    Private Sub CargaAsociadaSegunGastoFuncion()
        Try
            ValidarCombo(cboGastoFuncion, "Gasto Funcion")
            Dim leCC As New List(Of e_CuentaContable)
            leCC = leCuentaCtableAsociada.Where(Function(item) item.Cuenta = oeGastoFuncion.Texto2).ToList
            opcDebeHaber.Value = "D"
            cboCuenta.Value = leCC.Item(0).Id
            AgregarCuentaAsociada()

            leCC = New List(Of e_CuentaContable)
            leCC = leCuentaCtableAsociada.Where(Function(item) item.Cuenta = oeGastoFuncion.Texto3).ToList
            opcDebeHaber.Value = "H"
            cboCuenta.Value = leCC.Item(0).Id
            AgregarCuentaAsociada()

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

#End Region

#Region "Eventos"

    Private Sub oeCuentaContable_DatoCambiado() Handles oeCuentaContable.DatoCambiado
        oeCuentaContable.Modificado = True
    End Sub

    Private Sub frm_CuentaContable_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
       
    End Sub

    Private Sub frm_CuentaContable_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_CuentaContable_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case _Operacion
            Case "Nuevo", "Editar"
                Me.Activate()
                Me.Cancelar()

        End Select
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub CuentaContable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            olCombo = New l_Combo
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            MostrarTabs(0, tcCuentaContable)
            gridCuentaContable.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
            gridCuentaContable.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
            LlenarCombos()
            Año1.Año = Date.Now.Year
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griCuentaDetalle_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griCuentaDetalle.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub gridCuentaContable_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles gridCuentaContable.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub gridCuentaContable_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridCuentaContable.DoubleClick
        If gridCuentaContable.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub gridCuentaContable_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridCuentaContable.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub EliminaCabecera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminaCabecera.Click
        Try
            Eliminar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtCuenta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuenta.ValueChanged
        oeCuentaContable.Cuenta = txtCuenta.Text.Trim
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        oeCuentaContable.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub cmb_Naturaleza_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNaturaleza.SelectionChanged
        oeCuentaContable.Naturaleza = cboNaturaleza.Value
    End Sub

    Private Sub cmbTipoDocumento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoDocumento.SelectionChanged
        oeCuentaContable.TipoDocGeneral = cboTipoDocumento.Value
    End Sub

    Private Sub chkCuentaImputable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCuentaImputable.CheckedChanged
        oeCuentaContable.Movimiento = chkCuentaImputable.Checked
    End Sub

    Private Sub chkMonedaExt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMonedaExt.CheckedChanged
        oeCuentaContable.MonedaExtrangera = IIf(chkMonedaExt.Checked = True, 1, 0)
    End Sub

    Private Sub chkConciliacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkConciliacion.CheckedChanged
        oeCuentaContable.Conciliacion = IIf(chkConciliacion.Checked = True, 1, 0)
        r_HabilitaDeshabilitaGrupo()
    End Sub

    Private Sub chkFlujoCaja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFlujoCaja.CheckedChanged
        oeCuentaContable.FlujoCaja = IIf(chkFlujoCaja.Checked = True, 1, 0)
        r_HabilitaDeshabilitaGrupo()
    End Sub

    Private Sub chkFecEmision_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecEmision.CheckedChanged
        oeCuentaContable.FechaEmision = IIf(chkFecEmision.Checked = True, 1, 0)
        r_HabilitaDeshabilitaGrupo()
    End Sub

    Private Sub chkNroDoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNroDoc.CheckedChanged
        oeCuentaContable.NroDocumento = IIf(chkNroDoc.Checked = True, 1, 0)
        r_HabilitaDeshabilitaGrupo()
    End Sub

    Private Sub chkSerieDoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSerieDoc.CheckedChanged
        oeCuentaContable.Serie = IIf(chkSerieDoc.Checked = True, 1, 0)
        r_HabilitaDeshabilitaGrupo()
    End Sub

    Private Sub chkFecVenc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecVenc.CheckedChanged
        oeCuentaContable.FechaVencimiento = IIf(chkFecVenc.Checked = True, 1, 0)
        r_HabilitaDeshabilitaGrupo()
    End Sub

    Private Sub chkTracto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTracto.CheckedChanged
        oeCuentaContable.Tracto = IIf(chkTracto.Checked = True, 1, 0)
        r_HabilitaDeshabilitaGrupo()
    End Sub

    Private Sub chkRuta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRuta.CheckedChanged
        oeCuentaContable.Ruta = IIf(chkRuta.Checked = True, 1, 0)
        r_HabilitaDeshabilitaGrupo()
    End Sub

    Private Sub chkAnalisis1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAnalisis1.CheckedChanged
        oeCuentaContable.Analisis01 = IIf(chkAnalisis1.Checked = True, 1, 0)
        r_HabilitaDeshabilitaGrupo()
    End Sub

    Private Sub chkAnalisis2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAnalisis2.CheckedChanged
        oeCuentaContable.Analisis02 = IIf(chkAnalisis2.Checked = True, 1, 0)
        r_HabilitaDeshabilitaGrupo()
    End Sub

    Private Sub chkTransportista_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTransportista.CheckedChanged
        oeCuentaContable.Trabajador = IIf(chkTransportista.Checked = True, 1, 0)
        r_HabilitaDeshabilitaGrupo()
    End Sub

    Private Sub chkBanco_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBanco.CheckedChanged
        oeCuentaContable.Banco = IIf(chkBanco.Checked = True, 1, 0)
        r_HabilitaDeshabilitaGrupo()
    End Sub

    Private Sub chkTipoDocumento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTipoDocumento.CheckedChanged
        cboTipoDocumento.Enabled = chkTipoDocumento.Checked
        If chkTipoDocumento.Checked = False Then cboTipoDocumento.Value = ""
        r_HabilitaDeshabilitaGrupo()
    End Sub

    Private Sub chk_Tesoreria_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTesoreria.CheckedChanged
        oeCuentaContable.Tesoreria = IIf(chkTesoreria.Checked = True, 1, 0)
    End Sub

    Private Sub chkGastoFuncion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGastoFuncion.CheckedChanged
        If chkGastoFuncion.Checked = True Then
            oeCuentaContable.GastoFuncion = 1
            GastoFuncion()
            GroupBox2.Enabled = True
            GroupBox1.Enabled = False
        Else
            oeCuentaContable.GastoFuncion = 0
            GroupBox1.Enabled = True
            GroupBox2.Enabled = False
            cboGFAnalisis.Value = ""
        End If
        r_HabilitaDeshabilitaGrupo()
    End Sub

    Private Sub cmbCuentaCorriente_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCuentaCorriente.SelectionChanged
        oeCuentaContable.TipoCuentaCorriente = cboCuentaCorriente.Value
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeCuentaContable.Activo = verActivo.Checked
    End Sub

    Private Sub DatosCuenta_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles tcDatosCuenta.SelectedTabChanged
        If e.Tab.Index = 1 Then ComboCuenta()

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            If GroupBox1.Enabled = True Then
                AgregarCuentaAsociada()
            ElseIf GroupBox2.Enabled = True Then
                CargaAsociadaSegunGastoFuncion()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mnuEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEliminar.Click
        EliminarCuentaAsociada()
    End Sub

    Private Sub AgregarToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        Editar()
    End Sub

    Private Sub cboGastoFuncion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGastoFuncion.ValueChanged
        Dim i As Integer = cboGastoFuncion.SelectedIndex
        oeGastoFuncion = cboGastoFuncion.Items(i).ListObject
    End Sub

    Private Sub chkDebe_CheckedChanged(sender As Object, e As EventArgs) Handles chkDebe.CheckedChanged
        r_HabilitaDeshabilitaGrupo()
    End Sub

    Private Sub chkHaber_CheckedChanged(sender As Object, e As EventArgs) Handles chkHaber.CheckedChanged
        r_HabilitaDeshabilitaGrupo()
    End Sub

    Private Sub chkCentroCosto_CheckedChanged(sender As Object, e As EventArgs) Handles chkCentroCosto.CheckedChanged
        oeCuentaContable.CentroCosto = IIf(chkCentroCosto.Checked = True, 1, 0)
        r_HabilitaDeshabilitaGrupo()
    End Sub

#End Region

    Private Sub cboGFAnalisis_InitializeLayout(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboGFAnalisis.InitializeLayout
        With cboGFAnalisis.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("Nombre").Hidden = False
            .Columns("Nombre").Header.Caption = "Nombre"
            .Columns("Nombre").Width = 300
            .Columns("Descripcion").Hidden = True
        End With
    End Sub
End Class
