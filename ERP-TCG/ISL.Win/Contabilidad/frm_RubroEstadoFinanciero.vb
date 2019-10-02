'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_RubroEstadoFinanciero
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_RubroEstadoFinanciero = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_RubroEstadoFinanciero()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeRubroEEFF As e_RubroEstadoFinanciero, olRubroEEFF As l_RubroEstadoFinanciero, leRubroEEFF As List(Of e_RubroEstadoFinanciero)
    Private oeDetalle As e_RubroEstadoFinanciero_Detalle, leDetalle As List(Of e_RubroEstadoFinanciero_Detalle)
    Private oeDetCuenta As e_RubroEEFFDetalle_CuentaContable, leDetCuenta As List(Of e_RubroEEFFDetalle_CuentaContable), leDCCAux As List(Of e_RubroEEFFDetalle_CuentaContable)
    Private oeCuenta As e_CuentaContable, olCuenta As l_CuentaContable, leCuenta As List(Of e_CuentaContable)
    Private leCuentaSel As List(Of e_CuentaContable), leRubroSel As List(Of e_CuentaContable)
    Private lb_Load As Boolean, lb_Editar As Boolean
    Private ToolTipInfo As UltraWinToolTip.UltraToolTipInfo
    Private ToolTip As UltraWinToolTip.UltraToolTipManager

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            mt_Listar()
            If griRubroEEFF.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            oeRubroEEFF = New e_RubroEstadoFinanciero
            oeRubroEEFF.TipoOperacion = "I"
            oeRubroEEFF.Activo = True
            mt_Inicializar()
            txtCodigo.Focus()
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
            MostrarTabs(1, ficRubroEEFF, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            If griRubroEEFF.Selected.Rows.Count = 0 Then Throw New Exception("¡Seleccione un Registro!")
            If griRubroEEFF.ActiveRow.Index = -1 Then Throw New Exception("¡Seleccione un Registro!")
            mt_Inicializar()
            oeRubroEEFF = New e_RubroEstadoFinanciero
            oeRubroEEFF.Id = griRubroEEFF.ActiveRow.Cells("Id").Value
            oeRubroEEFF.CargaCompleta = True
            oeRubroEEFF = olRubroEEFF.Obtener(oeRubroEEFF)
            oeRubroEEFF.TipoOperacion = "A"
            txtCodigo.Text = oeRubroEEFF.Codigo.Trim
            txtNombre.Text = oeRubroEEFF.Nombre.Trim
            txtNroRegistro.Text = oeRubroEEFF.NroRegistro.Trim
            txtEstructuraArchivo.Text = oeRubroEEFF.EstructuraArchivo.Trim
            leDetalle = oeRubroEEFF.leDetalle
            mt_CargarDetalle(leDetalle)
            leDetCuenta = oeRubroEEFF.leCuenta
            If griDetalle.Rows.Count > 0 Then mt_ControlSubBoton(1, 1, 0, 0, 1) Else mt_ControlSubBoton(1, 0, 0, 0, 0)
            txtCodigo.Focus()
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
            MostrarTabs(1, ficRubroEEFF, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            gfc_ValidarError(Me, txtCodigo.Name, txtNroRegistro.Name, txtNombre.Name, txtEstructuraArchivo.Name)
            oeRubroEEFF.Codigo = txtCodigo.Text.Trim
            oeRubroEEFF.NroRegistro = txtNroRegistro.Text.Trim
            oeRubroEEFF.Nombre = txtNombre.Text.Trim
            oeRubroEEFF.EstructuraArchivo = txtEstructuraArchivo.Text.Trim
            oeRubroEEFF.leDetalle = leDetalle
            oeRubroEEFF.leCuenta = leDetCuenta
            If oeRubroEEFF.TipoOperacion = "I" Then oeRubroEEFF.UsuarioCrea = gUsuarioSGI.Id Else oeRubroEEFF.UsuarioModifica = gUsuarioSGI.Id
            oeRubroEEFF.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olRubroEEFF.Guardar(oeRubroEEFF) Then
                mensajeEmergente.Confirmacion("Se guardo correctamente los datos", True)
                MostrarTabs(0, ficRubroEEFF, 0)
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                MostrarTabs(0, ficRubroEEFF, 0)
                Consultar(True)
            End If
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

#End Region

#Region "Eventos"

    Private Sub frm_RubroEstadoFinanciero_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If ficRubroEEFF.SelectedTab.Index = 0 Then
            If griRubroEEFF.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Else
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
        End If
    End Sub

    Private Sub frm_RubroEstadoFinanciero_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_RubroEstadoFinanciero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mt_InicializarLogicas()
            mt_CargarIconos()
            mt_CargarCombos()
            lb_Load = True
            mt_CargarRubro(New List(Of e_RubroEstadoFinanciero))
            mt_CargarDetalle(New List(Of e_RubroEstadoFinanciero_Detalle))
            mt_CargarCuenta(New List(Of e_CuentaContable))
            mt_CargarRubros(New List(Of e_CuentaContable))
            lb_Load = False
            MostrarTabs(0, ficRubroEEFF, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griRubroEEFF_DoubleClick(sender As Object, e As EventArgs) Handles griRubroEEFF.DoubleClick
        Editar()
    End Sub

    Private Sub utmDetalle_ToolClick(sender As Object, e As UltraWinToolbars.ToolClickEventArgs) Handles utmDetalle.ToolClick
        Try
            Select Case e.Tool.Key
                Case "Agregar"
                    oeDetalle = New e_RubroEstadoFinanciero_Detalle
                    oeDetalle.TipoOperacion = "I" : oeDetalle.Activo = True
                    mt_InicializarDetalle()
                    lb_Editar = True
                    txtCodigoDet.Focus()
                    mt_ControlSubBoton(0, 0, 1, 1, 0)
                    MostrarTabs(1, ficDetalle, 1)
                Case "Editar"
                    mt_EditarDetalle()
                Case "Grabar"
                    oeDetalle.Codigo = txtCodigoDet.Text.Trim
                    oeDetalle.IndTotal = IIf(chkTotal.Checked, 1, 0)
                    oeDetalle.Descripcion = txtDescripcion.Text.Trim
                    oeDetalle.Nivel = numNivel.Value
                    oeDetalle.Linea = numLinea.Value
                    oeDetalle.Identificador = oeDetalle.GeneraIdenticador
                    If cboDepende.SelectedIndex > -1 Then
                        Dim oeAux = cboDepende.SelectedItem.ListObject
                        oeDetalle.IdDepende = cboDepende.Value
                        oeDetalle.Depende = cboDepende.Text.Trim
                        oeDetalle.IdentificaPadre = oeAux.Identificador
                        oeDetalle.Identificador = oeAux.Identificador & oeDetalle.GeneraIdenticador
                    End If
                    oeDetalle.Superior = IIf(chkSuperior.Checked, 1, 0)
                    oeDetalle.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If oeDetalle.TipoOperacion = "I" Then
                        leDetalle.Add(oeDetalle)
                    Else
                        If oeDetalle.Id.Trim.Length > 0 Then
                            oeDetalle.TipoOperacion = "A" : oeDetalle.UsuarioModifica = gUsuarioSGI.Id
                        Else
                            oeDetalle.TipoOperacion = "I" : oeDetalle.UsuarioCrea = gUsuarioSGI.Id
                        End If
                    End If
                    mt_CargarDetalle(leDetalle)
                    griDetalle.DataBind()
                    mt_GuardarCuentas()
                    MostrarTabs(0, ficDetalle, 0)
                    If griDetalle.Rows.Count > 0 Then mt_ControlSubBoton(1, 1, 0, 0, 1) Else mt_ControlSubBoton(1, 0, 0, 0, 0)
                Case "Cancelar"
                    If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", _
                              MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        MostrarTabs(0, ficDetalle, 0)
                        mt_CargarDetalle(leDetalle)
                        If griDetalle.Rows.Count > 0 Then mt_ControlSubBoton(1, 1, 0, 0, 1) Else mt_ControlSubBoton(1, 0, 0, 0, 0)
                    End If
                Case "Quitar"
                    If griDetalle.Selected.Rows.Count = 0 Then Throw New Exception("¡Seleccione un Registro!")
                    If griDetalle.ActiveRow.Index = -1 Then Throw New Exception("¡Seleccione un Registro!")
                    oeDetalle = New e_RubroEstadoFinanciero_Detalle
                    oeDetalle.Id = griDetalle.ActiveRow.Cells("Id").Value
                    oeDetalle.Codigo = griDetalle.ActiveRow.Cells("Codigo").Value
                    oeDetalle.Nivel = griDetalle.ActiveRow.Cells("Nivel").Value
                    oeDetalle.Linea = griDetalle.ActiveRow.Cells("Linea").Value
                    oeDetalle.TipoBusca = 2
                    If leDetalle.Contains(oeDetalle) Then
                        oeDetalle = leDetalle.Item(leDetalle.IndexOf(oeDetalle))
                        If oeDetalle.Id.Trim.Length > 0 Then
                            oeDetalle.TipoOperacion = "E" : oeDetalle.Activo = False
                            oeDetalle.Nivel = oeDetalle.Nivel * -1 : oeDetalle.Linea = oeDetalle.Linea * -1
                        Else
                            oeDetalle.TipoBusca = 2
                            leDetalle.Remove(oeDetalle)
                        End If
                    End If
                    mt_CargarDetalle(leDetalle)
                    griDetalle.DataBind()
                    If griDetalle.Rows.Count > 0 Then mt_ControlSubBoton(1, 1, 0, 0, 1) Else mt_ControlSubBoton(1, 0, 0, 0, 0)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub numNivel_ValueChanged(sender As Object, e As EventArgs) Handles numNivel.ValueChanged
        Try
            Dim leAux = leDetalle.Where(Function(it) it.Activo).ToList
            If leAux.Count > 0 Then
                LlenarCombo(cboDepende, "Descripcion", leAux.Where(Function(it) it.Nivel = (numNivel.Value - 1) And it.Superior = 1).ToList, -1)
                Dim leNivel = leAux.Where(Function(it) it.Nivel = numNivel.Value).ToList
                If leNivel.Count > 0 Then
                    'numLinea.MaxValue = leAux.Where(Function(it) it.Nivel = numNivel.Value).Max(Function(it) it.Linea) + 1
                    numLinea.Value = leAux.Where(Function(it) it.Nivel = numNivel.Value).Max(Function(it) it.Linea) + 1
                Else
                    numLinea.Value = 1
                    'numLinea.MaxValue = 1
                End If
            Else
                numLinea.Value = 1
                'numLinea.MaxValue = 1
                LlenarCombo(cboDepende, "Descripcion", New List(Of e_RubroEstadoFinanciero_Detalle), -1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griCuentaContable_CellChange(sender As Object, e As UltraWinGrid.CellEventArgs) Handles griCuentaContable.CellChange
        griCuentaContable.UpdateData()
    End Sub

    Private Sub griCuentaContable_AfterCellUpdate(sender As Object, e As UltraWinGrid.CellEventArgs) Handles griCuentaContable.AfterCellUpdate
        Try
            If lb_Editar Then
                With griCuentaContable
                    If .ActiveCell.Row.Index > -1 Then
                        If .ActiveCell.Column.Key = "Seleccion" Then
                            oeDetCuenta = New e_RubroEEFFDetalle_CuentaContable
                            oeDetCuenta.NroCuenta = .Rows(.ActiveCell.Row.Index).Cells("Cuenta").Value
                            oeDetCuenta.Identificador = oeDetalle.Identificador
                            oeDetCuenta.TipoBusca = 2
                            If .ActiveCell.Value Then
                                If leDCCAux.Contains(oeDetCuenta) Then
                                    oeDetCuenta = leDCCAux.Item(leDCCAux.IndexOf(oeDetCuenta))
                                    If oeDetCuenta.TipoOperacion = "E" Then
                                        oeDetCuenta.TipoOperacion = "I" : oeDetCuenta.Activo = True
                                    End If
                                Else
                                    oeDetCuenta.Id = oeDetalle.Id
                                    oeDetCuenta.Identificador = oeDetalle.Identificador
                                    oeDetCuenta.TipoOperacion = "I" : oeDetCuenta.Activo = True
                                    oeDetCuenta.UsuarioCrea = gUsuarioSGI.Id
                                    leDCCAux.Add(oeDetCuenta)
                                End If
                            Else
                                If leDCCAux.Contains(oeDetCuenta) Then
                                    oeDetCuenta = leDCCAux.Item(leDCCAux.IndexOf(oeDetCuenta))
                                    If oeDetCuenta.Id.Trim.Length > 0 Then
                                        oeDetCuenta.TipoOperacion = "E" : oeDetCuenta.Activo = False
                                        oeDetCuenta.UsuarioModifica = gUsuarioSGI.Id
                                    Else
                                        leDCCAux.Remove(oeDetCuenta)
                                    End If
                                End If
                            End If
                        End If
                    End If
                End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griRubros_AfterCellUpdate(sender As Object, e As UltraWinGrid.CellEventArgs) Handles griRubros.AfterCellUpdate
        Try
            If lb_Editar Then
                With griRubros
                    If .ActiveCell.Row.Index > -1 Then
                        If .ActiveCell.Column.Key = "Seleccion" Then
                            oeDetCuenta = New e_RubroEEFFDetalle_CuentaContable
                            oeDetCuenta.NroCuenta = .Rows(.ActiveCell.Row.Index).Cells("Cuenta").Value
                            oeDetCuenta.Identificador = oeDetalle.Identificador
                            oeDetCuenta.TipoBusca = 2
                            If .ActiveCell.Value Then
                                If leDCCAux.Contains(oeDetCuenta) Then
                                    oeDetCuenta = leDCCAux.Item(leDCCAux.IndexOf(oeDetCuenta))
                                    If oeDetCuenta.TipoOperacion = "E" Then
                                        oeDetCuenta.TipoOperacion = "I" : oeDetCuenta.Activo = True
                                    End If
                                Else
                                    oeDetCuenta.Id = oeDetalle.Id
                                    oeDetCuenta.Identificador = oeDetalle.Identificador
                                    oeDetCuenta.TipoOperacion = "I" : oeDetCuenta.Activo = True
                                    oeDetCuenta.UsuarioCrea = gUsuarioSGI.Id
                                    leDCCAux.Add(oeDetCuenta)
                                End If
                            Else
                                If leDCCAux.Contains(oeDetCuenta) Then
                                    oeDetCuenta = leDCCAux.Item(leDCCAux.IndexOf(oeDetCuenta))
                                    If oeDetCuenta.Id.Trim.Length > 0 Then
                                        oeDetCuenta.TipoOperacion = "E" : oeDetCuenta.Activo = False
                                        oeDetCuenta.UsuarioModifica = gUsuarioSGI.Id
                                    Else
                                        leDCCAux.Remove(oeDetCuenta)
                                    End If
                                End If
                            End If
                        End If
                    End If
                End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griRubros_CellChange(sender As Object, e As UltraWinGrid.CellEventArgs) Handles griRubros.CellChange
        griRubros.UpdateData()
    End Sub

    Private Sub griDetalle_DoubleClick(sender As Object, e As EventArgs) Handles griDetalle.DoubleClick
        Try
            mt_EditarDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub chkTotal_CheckedChanged(sender As Object, e As EventArgs) Handles chkTotal.CheckedChanged
        If chkTotal.Checked Then MostrarTabs(1, ficSubDetalle, 1) Else MostrarTabs(0, ficSubDetalle, 0)
    End Sub

    Private Sub griDetalle_MouseEnterElement(sender As Object, e As UIElementEventArgs) Handles griDetalle.MouseEnterElement
        Try
            If griDetalle.Rows.Count > 0 Then
                Dim Celda As UltraGridCell = TryCast(e.Element.GetContext(GetType(UltraGridCell), True), UltraGridCell)
                Dim ls_Mensaje As String = ""
                If Celda IsNot Nothing Then
                    ToolTip.HideToolTip()
                    If Celda.Row.Index > -1 AndAlso Celda.Column.Key = "Descripcion" Then
                        'ToolTip = New UltraWinToolTip.UltraToolTipManager
                        'ToolTipInfo = New UltraWinToolTip.UltraToolTipInfo
                        ToolTipInfo.ToolTipTitle = griDetalle.Rows(Celda.Row.Index).Cells("Identificador").Value
                        For Each _oeDet In leDetCuenta.Where(Function(it) it.Identificador = griDetalle.Rows(Celda.Row.Index).Cells("Identificador").Value And it.Activo).ToList
                            'ls_Mensaje = ls_Mensaje & "(*) " & _oeDet.NroCuenta & vbTab
                            ls_Mensaje = ls_Mensaje & "(*) " & _oeDet.NroCuenta & ", "
                        Next
                        ToolTipInfo.ToolTipText = ls_Mensaje
                        ToolTipInfo.ToolTipImage = ToolTipImage.Info
                        'ToolTip.SetUltraToolTip(griDetalle, ToolTipInfo)
                        'ToolTip.ShowToolTip(griDetalle)
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub mt_Listar()
        Try
            oeRubroEEFF = New e_RubroEstadoFinanciero : leRubroEEFF = New List(Of e_RubroEstadoFinanciero)
            leRubroEEFF = olRubroEEFF.Listar(oeRubroEEFF)
            mt_CargarRubro(leRubroEEFF)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_InicializarLogicas()
        Try
            olRubroEEFF = New l_RubroEstadoFinanciero
            olCuenta = New l_CuentaContable
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarIconos()
        Try
            For Each Item In gLstIconos
                Select Case Item.Nombre
                    Case "Agregar"
                        utmDetalle.Tools("Agregar").SharedProps.AppearancesSmall.Appearance.Image = Item.Icono
                    Case "Modificar"
                        utmDetalle.Tools("Editar").SharedProps.AppearancesSmall.Appearance.Image = Item.Icono
                    Case "Grabar"
                        utmDetalle.Tools("Grabar").SharedProps.AppearancesSmall.Appearance.Image = Item.Icono
                    Case "Cancelar"
                        utmDetalle.Tools("Cancelar").SharedProps.AppearancesSmall.Appearance.Image = Item.Icono
                    Case "Quitar"
                        utmDetalle.Tools("Quitar").SharedProps.AppearancesSmall.Appearance.Image = Item.Icono
                End Select
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarCombos()
        Try
            oeCuenta = New e_CuentaContable : olCuenta = New l_CuentaContable
            oeCuenta.Activo = True
            oeCuenta.Ejercicio = ObtenerFechaServidor().Year
            leCuenta = olCuenta.Listar(oeCuenta)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarRubro(ByVal leRubro As List(Of e_RubroEstadoFinanciero))
        Try
            If lb_Load Then griRubroEEFF.ResetDisplayLayout()
            griRubroEEFF.DataSource = leRubro
            griRubroEEFF.Text = "REGISTRO DE RUBROS"
            If lb_Load Then
                ConfiguraGrilla(griRubroEEFF, "Tahoma", True, UIElementBorderStyle.Default)
                OcultarColumna2(griRubroEEFF, False, "NroRegistro", "Codigo", "Nombre", "EstructuraArchivo")
                griRubroEEFF.DisplayLayout.Bands(0).Columns("Nombre").Width = 450
                griRubroEEFF.DisplayLayout.Bands(0).Columns("EstructuraArchivo").Width = 270
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarDetalle(ByVal leRDetalle As List(Of e_RubroEstadoFinanciero_Detalle))
        Try
            If lb_Load Then griDetalle.ResetDisplayLayout()
            griDetalle.DataSource = leRDetalle.OrderBy(Function(it) it.Identificador).ToList
            griDetalle.Text = ""
            If lb_Load Then
                ConfiguraGrilla(griDetalle, "Tahoma", True, UIElementBorderStyle.Default)
                OcultarColumna2(griDetalle, False, "Identificador", "Nivel", "Linea", "Descripcion", "Codigo", "IndTotal")
                FormatoColumna(griDetalle, "", UltraWinGrid.ColumnStyle.CheckBox, HAlign.Default, "IndTotal")
                griDetalle.DisplayLayout.Bands(0).Columns("Descripcion").Width = 450
                griDetalle.DisplayLayout.Bands(0).Columns("Identificador").Width = 200
                griDetalle.DisplayLayout.Bands(0).Columns("IndTotal").Header.Caption = "Totalizador"
            End If
            Dim ln_Nivel As Integer = 0
            For Each fil In griDetalle.Rows
                ln_Nivel = fil.Cells("Nivel").Value
                Select Case ln_Nivel
                    Case 1 : fil.Appearance.BackColor = Color.LightSkyBlue
                    Case 2 : fil.Appearance.BackColor = Color.LightSteelBlue
                    Case 3 : fil.Appearance.BackColor = Color.LightBlue
                End Select
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarCuenta(ByVal leCta As List(Of e_CuentaContable))
        Try
            If lb_Load Then griCuentaContable.ResetDisplayLayout()
            griCuentaContable.DataSource = leCta
            griCuentaContable.Text = ""
            If lb_Load Then
                ConfiguraGrilla(griCuentaContable, "Tahoma", True, UIElementBorderStyle.Default, "Seleccion")
                OcultarColumna2(griCuentaContable, False, "Seleccion", "Cuenta", "Nombre")
                griCuentaContable.DisplayLayout.Bands(0).Columns("Nombre").Width = 450
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarRubros(ByVal leCta As List(Of e_CuentaContable))
        Try
            If lb_Load Then griRubros.ResetDisplayLayout()
            griRubros.DataSource = leCta
            griRubros.Text = ""
            If lb_Load Then
                ConfiguraGrilla(griRubros, "Tahoma", True, UIElementBorderStyle.Default, "Seleccion")
                OcultarColumna2(griRubros, False, "Seleccion", "Cuenta", "Nombre")
                griRubros.DisplayLayout.Bands(0).Columns("Nombre").Width = 450
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Inicializar()
        txtCodigo.Text = String.Empty
        txtNroRegistro.Text = String.Empty
        txtNombre.Text = String.Empty
        txtEstructuraArchivo.Text = String.Empty
        ToolTip = New UltraWinToolTip.UltraToolTipManager
        ToolTipInfo = New UltraWinToolTip.UltraToolTipInfo
        ToolTip.SetUltraToolTip(griDetalle, ToolTipInfo)
        ToolTip.ShowToolTip(griDetalle)
        leDetalle = New List(Of e_RubroEstadoFinanciero_Detalle)
        mt_CargarDetalle(leDetalle)
        leDetCuenta = New List(Of e_RubroEEFFDetalle_CuentaContable)
        leCuentaSel = New List(Of e_CuentaContable)
        leCuentaSel.AddRange(leCuenta.Where(Function(it) it.Movimiento).ToList)
        mt_CargarCuenta(leCuentaSel)
        leRubroSel = New List(Of e_CuentaContable)
        mt_CargarRubros(leRubroSel)
        gmt_InicializarError(Me)
        MostrarTabs(0, ficDetalle, 0)
        mt_ControlSubBoton(1, 0, 0, 0, 0)
    End Sub

    Private Sub mt_InicializarDetalle()
        Dim leAux = leDetalle.Where(Function(it) it.Activo).ToList
        If leAux.Count > 0 Then
            numNivel.MaxValue = leAux.Max(Function(it) it.Nivel) + 1
            numNivel.Value = leAux.Max(Function(it) it.Nivel) + 1
            numNivel_ValueChanged(Nothing, Nothing)
        Else
            numNivel.MaxValue = 1
            'numLinea.MaxValue = 1
            numNivel.Value = 1
            numLinea.Value = 1
        End If
        cboDepende.SelectedIndex = -1
        txtCodigoDet.Text = String.Empty
        chkTotal.Checked = False
        chkSuperior.Checked = False
        txtDescripcion.Text = String.Empty
        lb_Editar = False
        leCuentaSel = New List(Of e_CuentaContable)
        leCuentaSel.AddRange(leCuenta.Where(Function(it) it.Movimiento).ToList)
        mt_CargarCuenta(leCuentaSel)
        For Each _Fil In griCuentaContable.Rows.Where(Function(it) it.Cells("Seleccion").Value).ToList
            _Fil.Cells("Seleccion").Value = False
        Next
        griCuentaContable.UpdateData()
        leRubroSel = New List(Of e_CuentaContable)
        For Each _oeDet In leDetalle.Where(Function(it) it.Activo = True And it.IndTotal = 0 And it.Codigo.Trim.Length > 0).ToList
            oeCuenta = New e_CuentaContable
            oeCuenta.Id = _oeDet.Id
            oeCuenta.Cuenta = _oeDet.Codigo
            oeCuenta.Nombre = _oeDet.Descripcion
            oeCuenta.Naturaleza = _oeDet.Identificador
            leRubroSel.Add(oeCuenta)
        Next
        mt_CargarRubros(leRubroSel)
        For Each _Fil In griRubros.Rows.Where(Function(it) it.Cells("Seleccion").Value).ToList
            _Fil.Cells("Seleccion").Value = False
        Next
        griRubros.UpdateData()
        lb_Editar = True
        leDCCAux = New List(Of e_RubroEEFFDetalle_CuentaContable)
        MostrarTabs(0, ficSubDetalle, 0)
    End Sub

    Private Sub mt_ControlSubBoton(lb_Agregar As Boolean, lb_Modificar As Boolean, lb_Grabar As Boolean, lb_Cancelar As Boolean, lb_Quitar As Boolean)
        Try
            utmDetalle.Tools("Agregar").SharedProps.Enabled = lb_Agregar
            utmDetalle.Tools("Editar").SharedProps.Enabled = lb_Modificar
            utmDetalle.Tools("Grabar").SharedProps.Enabled = lb_Grabar
            utmDetalle.Tools("Cancelar").SharedProps.Enabled = lb_Cancelar
            utmDetalle.Tools("Quitar").SharedProps.Enabled = lb_Quitar
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_EditarDetalle()
        Try
            If griDetalle.Selected.Rows.Count = 0 Then Throw New Exception("¡Seleccione un Registro!")
            If griDetalle.ActiveRow.Index = -1 Then Throw New Exception("¡Seleccione un Registro!")
            mt_InicializarDetalle()
            oeDetalle = New e_RubroEstadoFinanciero_Detalle
            oeDetalle = griDetalle.ActiveRow.ListObject
            oeDetalle.TipoOperacion = "A"
            txtCodigoDet.Text = oeDetalle.Codigo.Trim
            chkTotal.Checked = IIf(oeDetalle.IndTotal = 1, True, False)
            txtDescripcion.Text = oeDetalle.Descripcion.Trim
            numNivel.Value = oeDetalle.Nivel
            numLinea.Value = oeDetalle.Linea
            chkSuperior.Checked = IIf(oeDetalle.Superior = 1, True, False)
            If oeDetalle.Depende.Trim.Length > 0 Then
                cboDepende.Text = oeDetalle.Depende.Trim
            End If
            lb_Editar = False
            If oeDetalle.IndTotal = 0 Then mt_LlenarCuentas() Else mt_LlenarRubros()
            lb_Editar = True
            numNivel.Focus()
            mt_ControlSubBoton(0, 0, 1, 1, 0)
            MostrarTabs(1, ficDetalle, 1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_LlenarCuentas()
        Try
            leDCCAux.AddRange(leDetCuenta.Where(Function(it) it.Identificador = oeDetalle.Identificador).ToList)
            For Each _oeCC In leDCCAux.Where(Function(it) it.Activo).ToList
                Dim _Fil = griCuentaContable.Rows.Where(Function(it) it.Cells("Cuenta").Value = _oeCC.NroCuenta).ToList
                If _Fil.Count > 0 Then
                    _Fil(0).Cells("Seleccion").Value = True
                End If
            Next
            griCuentaContable.UpdateData()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_LlenarRubros()
        Try
            leDCCAux.AddRange(leDetCuenta.Where(Function(it) it.Identificador = oeDetalle.Identificador).ToList)
            For Each _oeCC In leDCCAux.Where(Function(it) it.Activo).ToList
                Dim _Fil = griRubros.Rows.Where(Function(it) it.Cells("Cuenta").Value = _oeCC.NroCuenta).ToList
                If _Fil.Count > 0 Then
                    _Fil(0).Cells("Seleccion").Value = True
                End If
            Next
            griRubros.UpdateData()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_GuardarCuentas()
        Try
            For Each _oeDCCAct In leDCCAux.Where(Function(it) it.TipoOperacion.Trim <> "" And it.TipoOperacion <> "I").ToList
                Dim _leObj = leDetCuenta.Where(Function(it) it.Identificador = _oeDCCAct.Identificador And it.NroCuenta = _oeDCCAct.NroCuenta).ToList
                If _leObj.Count > 0 Then
                    _leObj(0).TipoOperacion = _oeDCCAct.TipoOperacion
                    _leObj(0).Activo = _oeDCCAct.Activo
                    _leObj(0).UsuarioModifica = _oeDCCAct.UsuarioModifica
                    _leObj(0).PrefijoID = gs_PrefijoIdSucursal '@0001
                End If
            Next
            leDetCuenta.AddRange(leDCCAux.Where(Function(it) it.TipoOperacion.Trim <> "" And it.TipoOperacion = "I").ToList)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class