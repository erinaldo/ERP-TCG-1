Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_AjusteDiferenciaTipoCambio
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaracion de Variables"

    Dim _ComboPeriodo As Boolean = False
    Private Shared Operacion As String
    Private Datata As DataTable
    Private lsTipoOperacion As String
    Private oePeriodo As e_Periodo, oePeriodoGuarda As e_Periodo
    Private oeAjuste As New e_AjusteTC, olAjuste As New l_Asiento, leAjuste As List(Of e_AjusteTC), leDetalle As New List(Of e_AjusteTC)
    Private leAjusteGuardar As New List(Of e_AjusteTC)
    Private oeAsientoModel As New e_AsientoModelo, olAsientoModel As New l_AsientoModelo, leAsientoModel As New List(Of e_AsientoModelo)
    Private oeAsientoModGan As e_AsientoModelo, oeAsientoModPer As e_AsientoModelo
    Private oeReferencia As New e_AsientoModelo_Referencia, olReferencia As New l_AsientoModelo_Referencia, leReferencia As New List(Of e_AsientoModelo_Referencia)
    Private DTReferencia As Data.DataTable, dtAux As Data.DataTable

#End Region

#Region "Instancia"

    Private Shared instancia As frm_AjusteDiferenciaTipoCambio = Nothing

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_AjusteDiferenciaTipoCambio()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar()
            ControlBoton(1, 0, 0, 1, 0, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            Ajuste()
            ControlBoton(1, 0, 0, 1, 0, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    Public Overrides Sub Exportar()
        Try

            If gridComprobanteDiario.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(gridComprobanteDiario)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub Año1_DatoCambiado() Handles Año1.DatoCambiado
        Try
            ComboPerido()
            'LimpiaGrid(gridComprobanteDiario, odAjusteTipoCambio)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Año2_DatoCambiado() Handles Año2.DatoCambiado
        Try
            ComboPerido2()
            'LimpiaGrid(gridComprobanteDiario, odAjusteTipoCambio)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_ComprobanteDiario_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 1, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_ComprobanteDiario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ComprobanteDiario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frmAjusteDiferenciaTipoCambio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Año1.Año = Date.Now.Date.Year
            _ComboPeriodo = True
            ComboPerido()
            CargarAsiento()
            ComboPerido2()
            MostrarTabs(0, ficAjusteTipoCambio)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridComprobanteDiario_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles gridComprobanteDiario.CellChange
        gridComprobanteDiario.UpdateData()
    End Sub

    Private Sub btnRetornar_Click(sender As Object, e As EventArgs) Handles btnRetornar.Click
        MostrarTabs(0, ficAjusteTipoCambio)
    End Sub

    Private Sub gridComprobanteDiario_DoubleClick(sender As Object, e As EventArgs) Handles gridComprobanteDiario.DoubleClick
        Try
            oeAjuste = New e_AjusteTC : leDetalle = New List(Of e_AjusteTC)
            If gridComprobanteDiario.Selected.Rows.Count > 0 Then
                oeAjuste.TipoOperacion = IIf(rbtObligacion.Checked, "DE2", "DE1")
                oeAjuste.IdMovimientoDocumento = gridComprobanteDiario.ActiveRow.Cells("IdMovDoc").Value
                oeAjuste.IdPeriodo = gridComprobanteDiario.ActiveRow.Cells("CuentaContable").Value
                leDetalle = olAjuste.ListarAjusteTC(oeAjuste)
                CargarDetalleTC(leDetalle)
                If leDetalle.Count > 0 Then
                    ndTotalDebe.Value = Math.Round(leDetalle.Sum(Function(it) it.Debe), 4)
                    ndTotalHaber.Value = Math.Round(leDetalle.Sum(Function(it) it.Haber), 4)
                    ndTotalFinal.Value = Math.Round(ndTotalDebe.Value - ndTotalHaber.Value, 4)
                Else
                    ndTotalDebe.Value = 0 : ndTotalHaber.Value = 0 : ndTotalHaber.Value = 0
                End If
                MostrarTabs(1, ficAjusteTipoCambio)
            Else
                Throw New Exception("Seleccione un Registro")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboPeriodoGuarda_ValueChanged(sender As Object, e As EventArgs) Handles cboPeriodoGuarda.ValueChanged
        If cboPeriodoGuarda.SelectedIndex > -1 Then
            oePeriodoGuarda = cboPeriodoGuarda.Items(cboPeriodoGuarda.SelectedIndex).ListObject
        End If
    End Sub

    Private Sub cboMes_ValueChanged(sender As Object, e As EventArgs) Handles cboMes.ValueChanged
        If cboMes.SelectedIndex > -1 Then
            oePeriodo = cboMes.Items(cboMes.SelectedIndex).ListObject
        End If
    End Sub

#End Region

#Region "Métodos"

    Private Sub Ajuste()
        Try
            Dim _ban As Boolean = False
            Dim _Monto As Double = 0
            Dim ls_IdVinculado As String, ls_IdGanancia As String, ls_IdPerdida As String
            If oePeriodoGuarda.Mes <> cboMes.Text Then
                Throw New Exception("El ajuste Consultado es a: " & oePeriodo.Mes.ToString & " y no se puede grabar en el periodo: " & cboMes.Text)
            End If
            'Filtra DtReferencia
            dtAux = New Data.DataTable
            Dim _rwAux() As Data.DataRow
            Dim cadSQL As String = String.Empty
            'cadSQL = "TipoRef1 = 11 AND Ref1 = '" & IIf(lsTipoOperacion = "COO", "COBRO", IIf(lsTipoOperacion = "PAA", "PAGO", "OBLIGACION")) & "' "
            cadSQL = "TipoRef1 = 11 AND Ref1 = '" & IIf(lsTipoOperacion = "ACL", "COBRO", IIf(lsTipoOperacion = "APV", "PAGO", "OBLIGACION")) & "' "
            _rwAux = DTReferencia.Select(cadSQL, "")
            If _rwAux.Count = 0 Then Throw New Exception("No tiene configuracion contable")
            dtAux = _rwAux.CopyToDataTable
            'Obtiene Asiento Modelo por Referencia Ganancia
            oeAsientoModGan = New e_AsientoModelo
            oeAsientoModGan.TipoOperacion = "" : oeAsientoModGan.Activo = True
            oeAsientoModGan.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
            oeAsientoModGan.Ejercicio = oePeriodoGuarda.Ejercicio
            oeAsientoModGan = olAsientoModel.Obtener(oeAsientoModGan)
            If oeAsientoModGan.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
            oeAsientoModGan.IndVinculado = IIf(oeAsientoModGan.Nombre.Contains("GANANCIA"), True, False)
            oeAsientoModGan.UsuarioCreacion = gUsuarioSGI.Id
            oeAsientoModGan.IdPeriodo = oePeriodoGuarda.Id
            oeAsientoModGan.FechaMov = gf_InicioFinMes("F", oePeriodoGuarda.Ejercicio, oePeriodoGuarda.Mes)
            'If lsTipoOperacion = "OBB" Then oeAsientoModGan.Tipo = 3
            If lsTipoOperacion = "AOB" Then oeAsientoModGan.Tipo = 3
            ls_IdGanancia = oeAsientoModGan.Id
            ls_IdVinculado = oeAsientoModGan.IdVinculado
            'Obtiene Asiento Modelo por Referencia Perdida
            oeAsientoModPer = New e_AsientoModelo
            oeAsientoModPer.TipoOperacion = "" : oeAsientoModPer.Activo = True
            oeAsientoModPer.Id = ls_IdVinculado
            oeAsientoModPer.Ejercicio = oePeriodoGuarda.Ejercicio
            oeAsientoModPer = olAsientoModel.Obtener(oeAsientoModPer)
            If oeAsientoModPer.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
            oeAsientoModPer.IndVinculado = IIf(oeAsientoModPer.Nombre.Contains("GANANCIA"), True, False)
            oeAsientoModPer.UsuarioCreacion = gUsuarioSGI.Id
            oeAsientoModPer.IdPeriodo = oePeriodoGuarda.Id
            oeAsientoModPer.FechaMov = gf_InicioFinMes("F", oePeriodoGuarda.Ejercicio, oePeriodoGuarda.Mes)
            'If lsTipoOperacion = "OBB" Then oeAsientoModPer.Tipo = 3
            If lsTipoOperacion = "AOB" Then oeAsientoModPer.Tipo = 3
            ls_IdPerdida = oeAsientoModPer.Id
            ' Llenar Asientos Modelos
            leAsientoModel = New List(Of e_AsientoModelo)

            leAsientoModel.Add(oeAsientoModGan)
            leAsientoModel.Add(oeAsientoModPer)
            ' Cargar Datos

            'If lsTipoOperacion = "COO" Or lsTipoOperacion = "PAA" Then
            Dim cont As Integer = 0
            Dim oeAsiento As e_Asiento
            Dim olAsiento As l_Asiento
            Dim lstAsiento As List(Of e_Asiento)
            If lsTipoOperacion = "ACL" Or lsTipoOperacion = "APV" Then
                For Each obj In gridComprobanteDiario.Rows.Where(Function(x) x.Cells("Seleccionar").Value = True And x.Cells("Ajuste").Value <> 0).ToList
                    oeAsiento = New e_Asiento
                    With oeAsiento
                        .Glosa = "AJUSTE TC " & obj.Cells("Tipo").Value & "/" & obj.Cells("Serie").Value & obj.Cells("Numero").Value & " " & obj.Cells("Cliente").Value
                        .TotalDebe = Math.Abs(obj.Cells("Ajuste").Value)
                        .TotalHaber = Math.Abs(obj.Cells("Ajuste").Value)
                        .IdPeriodo = oePeriodoGuarda.Id
                        .Id = obj.Cells("IdMovDoc").Value
                        .TipoOperacion = "C"
                    End With
                    lstAsiento = New List(Of e_Asiento)
                    olAsiento = New l_Asiento
                    lstAsiento = olAsiento.Listar(oeAsiento)
                    If lstAsiento.Count = 0 Then
                        cont += 1
                        leAjusteGuardar = New List(Of e_AjusteTC)
                        oeAjuste = New e_AjusteTC
                        'oeAjuste.IdMovimientoDocumento = obj("Id")
                        oeAjuste.IdMovimientoDocumento = obj.Cells("IdMovDoc").Value
                        '_Monto = obj("MN")
                        _Monto = obj.Cells("Ajuste").Value
                        Select Case lsTipoOperacion
                            'Case "COO"
                            Case "ACL"
                                If _Monto > 0 Then
                                    oeAjuste.Debe = Math.Abs(_Monto) : oeAjuste.Haber = 0
                                Else
                                    oeAjuste.Debe = 0 : oeAjuste.Haber = Math.Abs(_Monto)
                                End If
                                ' Case "PAA"
                            Case "APV"
                                If _Monto > 0 Then
                                    oeAjuste.Debe = 0 : oeAjuste.Haber = Math.Abs(_Monto)
                                Else
                                    oeAjuste.Debe = Math.Abs(_Monto) : oeAjuste.Haber = 0
                                End If
                        End Select
                        oeAjuste.Glosa = "AJUSTE TC " & obj.Cells("Tipo").Value & "/" & obj.Cells("Serie").Value & obj.Cells("Numero").Value & " " & obj.Cells("Cliente").Value
                        oeAjuste.Cuenta = obj.Cells("CuentaContable").Value
                        oeAjuste.IdAsientoModelo = IIf(oeAjuste.Haber > 0, ls_IdPerdida, ls_IdGanancia)
                        leAjusteGuardar.Add(oeAjuste)
                        If olAjuste.GuardarAjusteTC(leAsientoModel, leAjusteGuardar) Then _ban = True Else _ban = False
                    End If
                Next
                If leAjusteGuardar.Count = 0 Then Throw New Exception("¡No se han Seleccionado Registros!")
                'Guardar Datos de Tipo Cambio
                If _ban Then
                    mensajeEmergente.Confirmacion("¡Los Datos se guardaron correctamente!", True)
                    Consultar(True)
                Else
                    If cont = 0 Then
                        mensajeEmergente.Confirmacion("¡No se guardaron los cambios. El Ajuste de Cambio para el periodo seleccionado ya ha sido registrado!", True)
                        Consultar(True)
                    End If
                End If
            Else
                For Each obj In gridComprobanteDiario.Rows.Where(Function(x) x.Cells("Seleccionar").Value = True And x.Cells("Ajuste").Value <> 0)
                    oeAsiento = New e_Asiento
                    With oeAsiento
                        .Glosa = "AJUSTE TC " & obj.Cells("Tipo").Value & "/" & obj.Cells("Serie").Value & obj.Cells("Numero").Value & " " & obj.Cells("Cliente").Value
                        .TotalDebe = Math.Abs(obj.Cells("Ajuste").Value)
                        .TotalHaber = Math.Abs(obj.Cells("Ajuste").Value)
                        .IdPeriodo = oePeriodoGuarda.Id
                        .Id = obj.Cells("IdMovDoc").Value
                        .TipoOperacion = "C"
                    End With
                    lstAsiento = New List(Of e_Asiento)
                    olAsiento = New l_Asiento
                    lstAsiento = olAsiento.Listar(oeAsiento)
                    If lstAsiento.Count = 0 Then
                        cont += 1
                        leAjusteGuardar = New List(Of e_AjusteTC)
                        oeAjuste = New e_AjusteTC
                        'oeAjuste.IdMovimientoDocumento = obj("Id")
                        oeAjuste.IdMovimientoDocumento = obj.Cells("IdMovDoc").Value
                        '_Monto = obj("MN")
                        _Monto = obj.Cells("Ajuste").Value
                        If _Monto > 0 Then
                            oeAjuste.Debe = 0 : oeAjuste.Haber = Math.Abs(_Monto)
                        Else
                            oeAjuste.Debe = Math.Abs(_Monto) : oeAjuste.Haber = 0
                        End If
                        oeAjuste.Glosa = "AJUSTE TC " & obj.Cells("Tipo").Value & "/" & obj.Cells("Serie").Value & obj.Cells("Numero").Value & " " & obj.Cells("Cliente").Value
                        oeAjuste.Cuenta = obj.Cells("CuentaContable").Value
                        oeAjuste.IdAsientoModelo = IIf(oeAjuste.Haber > 0, ls_IdPerdida, ls_IdGanancia)
                        leAjusteGuardar.Add(oeAjuste)
                        If olAjuste.GuardarAjusteTC(leAsientoModel, leAjusteGuardar) Then _ban = True Else _ban = False
                    End If
                Next
                'Guardar Datos de Tipo Cambio
                If _ban Then
                    mensajeEmergente.Confirmacion("¡Los Datos se guardaron correctamente!", True)
                    Consultar(True)
                Else
                    If cont = 0 Then
                        mensajeEmergente.Confirmacion("¡No se guardaron los cambios. El Ajuste de Cambio para el periodo seleccionado ya ha sido registrado!", True)
                        Consultar(True)
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboPerido()
        Try
            If _ComboPeriodo = True Then
                Dim olPeriodo As New l_Periodo
                Dim lePeriodo As New List(Of e_Periodo)
                oePeriodo = New e_Periodo
                oePeriodo.Ejercicio = Año1.Año
                oePeriodo.Activo = True
                lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))
                LlenaComboMes(cboMes, lePeriodo)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboPerido2()
        Try
            If _ComboPeriodo = True Then
                Dim olPeriodo2 As New l_Periodo
                Dim lePeriodo2 As New List(Of e_Periodo)
                oePeriodo = New e_Periodo
                oePeriodo.Ejercicio = Año2.Año
                oePeriodo.Activo = True
                lePeriodo2.AddRange(olPeriodo2.Listar(oePeriodo))
                LlenaComboMes(cboPeriodoGuarda, lePeriodo2)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            lsTipoOperacion = ""
            If rbtCliente.Checked Then
                'lsTipoOperacion = "COO"
                lsTipoOperacion = "ACL"
            ElseIf rbtProveedor.Checked Then
                'lsTipoOperacion = "PAA"
                lsTipoOperacion = "APV"
            ElseIf rbtObligacion.Checked Then
                'lsTipoOperacion = "OBB"
                lsTipoOperacion = "AOB"
            End If
            'oePeriodo = cboMes.Items(cboMes.SelectedIndex).ListObject
            Dim olDoc As New l_MovimientoDocumento
            Datata = olDoc.ListarAjusteTipoCambio(lsTipoOperacion, "", cboMes.Value, Año1.Año)
            gridComprobanteDiario.DataSource = Datata
            gridComprobanteDiario.DataBind()
            leDetalle = New List(Of e_AjusteTC)
            CargarDetalleTC(leDetalle)
            MostrarTabs(0, ficAjusteTipoCambio)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub CargarDetalleTC(leDet As List(Of e_AjusteTC))
        Try
            With griDetalle
                .ResetDisplayLayout()
                .DataSource = leDet
                OcultarColumna(griDetalle, True, "IdMovimientoDocumento", "IdPeriodo", "TipoDocumento", "Serie", "Numero")
                .DisplayLayout.Bands(0).Columns("Glosa").Width = 350
                .DisplayLayout.Bands(0).Columns("TipoAsiento").Width = 75
                .DisplayLayout.Bands(0).Columns("Periodo").Width = 75
                .DisplayLayout.Bands(0).Columns("NroAsiento").Width = 75
                .DisplayLayout.Bands(0).Columns("Glosa").Width = 350
                .DisplayLayout.Bands(0).Columns("TipoCambio").Width = 75
                FormatoColumna(griDetalle, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Debe", "Haber")
                FormatoColumna(griDetalle, "#,##0.000", ColumnStyle.Double, HAlign.Right, "TipoCambio")
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
            CalcularTotales(griDetalle, "Debe", "Haber")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarAsiento()
        'Cargar Asiento Modelo Referencia
        oeReferencia = New e_AsientoModelo_Referencia
        oeReferencia.TipoOperacion = "N" : oeReferencia.Activo = True : oeReferencia.IdReferencia = pIdActividadNegocio
        leReferencia = olReferencia.Listar(oeReferencia)
        'Cargar DT Referencia
        If leReferencia.Count > 0 Then DTReferencia = GeneraDTRef(leReferencia)
    End Sub

#End Region

End Class
