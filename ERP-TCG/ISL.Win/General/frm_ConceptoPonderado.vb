Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_ConceptoPonderado
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ConceptoPonderado = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ConceptoPonderado()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeConceptoPond As New e_ConceptoPonderado, olConceptoPond As New l_ConceptoPonderado, leConceptoPond As New List(Of e_ConceptoPonderado)
    Private oeDetalleCP As New e_DetalleConceptoPonderado, olDetalleCP As New l_DetalleConceptoPonderado, leDetalleCP As New List(Of e_DetalleConceptoPonderado)
    Private oeAccionUsuario As New e_ActividadRestringida_Usuario
    Private _opeCP As String = "", _acl As String = "", _estado As String = "", coddet As String = ""

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            Listar()
            If griConceptoPonderado.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            _acl = gAccionSistema.NUEVO.ToString
            If VerificaAccion(_acl) Then
                _opeCP = "GENERADA"
                oeConceptoPond = New e_ConceptoPonderado
                oeConceptoPond.TipoOperacion = "I"
                oeConceptoPond.Activo = True
                Inicializa()
                txtCodigo.Text = fn_ObtenerCodigo()
                coddet = fn_ObtenerCodDet()
                MostrarTabs(1, ficConceptoPond)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            _acl = gAccionSistema.EDITAR.ToString
            If VerificaAccion(_acl) Then
                _opeCP = "GENERADA"
                Inicializa()
                Mostrar()
                oeConceptoPond.TipoOperacion = "A"
                MostrarTabs(1, ficConceptoPond)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            Dim formulario As frm_AutenticarTrabajador
            formulario = New frm_AutenticarTrabajador
            formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
            If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                Throw New Exception("Ingrese un Clave Correcta")
            Else
                RecolectaDatos()
                oeConceptoPond.UsuarioCreacion = gUsuarioSGI.Id
                If olConceptoPond.Guardar(oeConceptoPond) Then
                    mensajeEmergente.Confirmacion("El Registro se Guardo correctamente!!", True)
                    MostrarTabs(0, ficConceptoPond)
                    Consultar(True)
                End If
            End If
        Catch ex As Exception
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", _
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            MostrarTabs(0, ficConceptoPond)
            Consultar(True)
        End If
    End Sub

    Public Overrides Sub Eliminar()

    End Sub

    Public Overrides Sub Exportar()

    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ConceptoPonderado_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Select Case ficConceptoPond.SelectedTab.Index
            Case 0
                If griConceptoPonderado.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        End Select

    End Sub

    Private Sub frm_ConceptoPonderado_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ConceptoPonderado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            leConceptoPond = New List(Of e_ConceptoPonderado)
            CargarConceptoPonderado(leConceptoPond)
            MostrarTabs(0, ficConceptoPond)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            RecolectaDatosDet()
            If olDetalleCP.Validar(oeDetalleCP) Then
                oeDetalleCP.Equivale = 2
                If leDetalleCP.Contains(oeDetalleCP) Then
                    Dim _oeAux = leDetalleCP.Item(leDetalleCP.IndexOf(oeDetalleCP))
                    If _oeAux.Id <> "" Then
                        _oeAux.TipoOperacion = "A"
                        _oeAux.UsuarioModifica = gUsuarioSGI.Id
                        _oeAux.Activo = True
                    Else
                        _oeAux.TipoOperacion = "I"
                        _oeAux.UsuarioCreacion = gUsuarioSGI.Id
                        _oeAux.Activo = True
                    End If
                Else
                    oeDetalleCP.TipoOperacion = "I"
                    oeDetalleCP.UsuarioCreacion = gUsuarioSGI.Id
                    oeDetalleCP.Activo = True
                    leDetalleCP.Add(oeDetalleCP)
                End If
                CargarDetalle(leDetalleCP)
                MostrarTabs(0, ficDetalle)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje del Sistema", MessageBoxButtons.YesNo, _
                           MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            MostrarTabs(0, ficDetalle)
        End If
    End Sub

    Private Sub griDetalle_DoubleClick(sender As Object, e As EventArgs) Handles griDetalle.DoubleClick
        Try
            EditarDetalle()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griConceptoPonderado_DoubleClick(sender As Object, e As EventArgs) Handles griConceptoPonderado.DoubleClick
        If griConceptoPonderado.Selected.Rows.Count > 0 Then Editar()
    End Sub

#End Region

#Region "Metodos"

    Private Sub Listar()
        Try
            oeConceptoPond = New e_ConceptoPonderado
            oeConceptoPond.TipoOperacion = ""
            oeConceptoPond.Activo = True
            leConceptoPond = olConceptoPond.Listar(oeConceptoPond)
            CargarConceptoPonderado(leConceptoPond)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarConceptoPonderado(leConPond As List(Of e_ConceptoPonderado))
        Try
            With griConceptoPonderado

                .ResetDisplayLayout()

                .Text = "REGISTROS DE CONCEPTO PONDERADO"

                .DataSource = leConPond

                OcultarColumna(griConceptoPonderado, True, "Id", "FechaCreacion", "UsuarioCreacion", "FechaModifica", _
                               "UsuarioModifica", "Activo", "Tipo", "Vigente")

                .DisplayLayout.Bands(0).Columns("Nombre").Width = 300

                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializa()
        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        leDetalleCP = New List(Of e_DetalleConceptoPonderado)
        CargarDetalle(leDetalleCP)
        MostrarTabs(0, ficDetalle)
    End Sub

    Private Sub Mostrar()
        Try
            oeConceptoPond = New e_ConceptoPonderado
            oeConceptoPond.TipoOperacion = ""
            oeConceptoPond.Id = griConceptoPonderado.ActiveRow.Cells("Id").Value
            oeConceptoPond = olConceptoPond.Obtener(oeConceptoPond)
            With oeConceptoPond
                txtCodigo.Text = .Codigo
                txtNombre.Text = .Nombre
                leDetalleCP = .leDetalle
                CargarDetalle(leDetalleCP)
                coddet = fn_ObtenerCodDet()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDetalle(leDet As List(Of e_DetalleConceptoPonderado))
        Try
            With griDetalle

                .ResetDisplayLayout()

                .Text = "REGISTROS DETALLE DE: " & txtNombre.Text.Trim

                Dim _leAux = leDet.Where(Function(it) it.Activo = True).ToList

                ndPonderado.Value = _leAux.Sum(Function(it) it.Porcentaje)

                If ndPonderado.Value > 100 Then chkExcluir.Checked = True

                .DataSource = _leAux

                OcultarColumna(griDetalle, True, "Id", "IdConceptoPonderado", "FechaCreacion", "UsuarioCreacion", "FechaModifica", "UsuarioModifica", "Activo")
                ExcluirColumna(griDetalle, "Id", "IdConceptoPonderado")

                FormatoColumna(griDetalle, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Porcentaje")

                .DisplayLayout.Bands(0).Columns("NroOrden").Width = 50
                .DisplayLayout.Bands(0).Columns("Codigo").Width = 50
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 250
                .DisplayLayout.Bands(0).Columns("Abreviatura").Width = 100
                .DisplayLayout.Bands(0).Columns("Porcentaje").Width = 70

                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

            End With

            CalcularTotales(griDetalle, "Porcentaje")

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fn_ObtenerCodigo() As String
        Try
            Dim str As String = ""
            Dim oeCP As New e_ConceptoPonderado
            oeCP.TipoOperacion = "U"
            oeCP = olConceptoPond.Obtener(oeCP)
            If oeCP IsNot Nothing AndAlso oeCP.Codigo <> "" Then
                str = oeCP.Codigo
            End If
            Return str
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fn_ObtenerCodDet() As String
        Try
            Dim str As String = ""
            Dim oeDCP As New e_DetalleConceptoPonderado
            oeDCP.TipoOperacion = "U"
            oeDCP = olDetalleCP.Obtener(oeDCP)
            If oeDCP IsNot Nothing AndAlso oeDCP.Codigo <> "" Then
                str = oeDCP.Codigo
            End If
            Return str
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function VerificaAccion(_accion As String) As Boolean
        Try
            If gUsuarioSGI.leARUsuario.Count > 0 Then
                oeAccionUsuario = New e_ActividadRestringida_Usuario
                oeAccionUsuario.IdActividadNegocio = pIdActividadNegocio
                oeAccionUsuario.AccionSistema = _accion
                oeAccionUsuario.Equivale = 1
                If gUsuarioSGI.leARUsuario.Contains(oeAccionUsuario) Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub RecolectaDatos()
        oeConceptoPond.Codigo = txtCodigo.Text
        oeConceptoPond.Nombre = txtNombre.Text
        oeConceptoPond.Vigente = 1
        oeConceptoPond.Tipo = 0
        oeConceptoPond.leDetalle = leDetalleCP
        oeConceptoPond.lbExcluir = chkExcluir.Checked
    End Sub

    Private Sub RecolectaDatosDet()
        oeDetalleCP.Codigo = txtCodigoDet.Text
        oeDetalleCP.Nombre = txtNombreDet.Text
        oeDetalleCP.Abreviatura = txtAbreviaturaDet.Text
        oeDetalleCP.Porcentaje = ndPorcentaje.Value
        oeDetalleCP.NroOrden = nroOrden.Value
    End Sub

    Private Sub EditarDetalle()
        Try
            oeDetalleCP = New e_DetalleConceptoPonderado
            oeDetalleCP.Codigo = griDetalle.ActiveRow.Cells("Codigo").Value
            oeDetalleCP.Equivale = 2
            If leDetalleCP.Contains(oeDetalleCP) Then
                oeDetalleCP = leDetalleCP.Item(leDetalleCP.IndexOf(oeDetalleCP))
                txtCodigoDet.Text = oeDetalleCP.Codigo
                txtNombreDet.Text = oeDetalleCP.Nombre
                txtAbreviaturaDet.Text = oeDetalleCP.Abreviatura
                ndPorcentaje.Value = oeDetalleCP.Porcentaje
                nroOrden.Value = oeDetalleCP.NroOrden
                MostrarTabs(1, ficDetalle)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Menu Contextual"

    Private Sub mcConceptoPond_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mcConceptoPond.Opening
        mcConceptoPond.Items("tsmiNuevo").Enabled = True
        If griConceptoPonderado.Selected.Rows.Count > 0 Then
            mcConceptoPond.Items("tsmiEditar").Enabled = True
            mcConceptoPond.Items("tsmiEliminar").Enabled = True
        Else
            mcConceptoPond.Items("tsmiEditar").Enabled = False
            mcConceptoPond.Items("tsmiEliminar").Enabled = False
        End If
    End Sub

    Private Sub tsmiNuevo_Click(sender As Object, e As EventArgs) Handles tsmiNuevo.Click
        Try
            Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiEditar_Click(sender As Object, e As EventArgs) Handles tsmiEditar.Click
        Try
            Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiEliminar_Click(sender As Object, e As EventArgs) Handles tsmiEliminar.Click
        Try
            Eliminar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mcDetalle_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mcDetalle.Opening
        mcDetalle.Items("tsmiAgregar").Enabled = True
        mcDetalle.Items("tsmiQuitar").Enabled = IIf(griDetalle.Selected.Rows.Count > 0, True, False)
        mcDetalle.Items("tsmiModificar").Enabled = IIf(griDetalle.Selected.Rows.Count > 0, True, False)
    End Sub

    Private Sub tsmiAgregar_Click(sender As Object, e As EventArgs) Handles tsmiAgregar.Click
        Try
            Dim _nro As Integer = 0
            txtCodigoDet.Text = String.Empty
            txtCodigoDet.ReadOnly = True
            txtNombreDet.Text = String.Empty
            txtAbreviaturaDet.Text = String.Empty
            nroOrden.Value = griDetalle.Rows.Count + 1
            ndPorcentaje.Value = 1
            If coddet <> "" Then
                oeDetalleCP = New e_DetalleConceptoPonderado
                oeDetalleCP.Equivale = 2
                oeDetalleCP.Codigo = coddet
                If leDetalleCP.Contains(oeDetalleCP) Then
                    _nro = CInt(coddet)
                    _nro = _nro + 1
                    coddet = FormatoDocumento(_nro.ToString, coddet.Length)
                End If
                txtCodigoDet.Text = coddet
            End If
            txtNombreDet.Focus()
            oeDetalleCP = New e_DetalleConceptoPonderado
            MostrarTabs(1, ficDetalle)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiModificar_Click(sender As Object, e As EventArgs) Handles tsmiModificar.Click
        Try
            EditarDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiQuitar_Click(sender As Object, e As EventArgs) Handles tsmiQuitar.Click
        Try
            If griDetalle.Selected.Rows.Count > 0 Then
                oeDetalleCP = New e_DetalleConceptoPonderado
                oeDetalleCP.Codigo = griDetalle.ActiveRow.Cells("Codigo").Value
                oeDetalleCP.Equivale = 2
                If leDetalleCP.Contains(oeDetalleCP) Then
                    oeDetalleCP = leDetalleCP.Item(leDetalleCP.IndexOf(oeDetalleCP))
                    If MessageBox.Show("¿Desea Eliminar el Registro: " & oeDetalleCP.Nombre & "?", "Mensaje de Sistema", _
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        If oeDetalleCP.Id <> "" Then
                            oeDetalleCP.TipoOperacion = "E"
                            oeDetalleCP.Activo = False
                        Else
                            leDetalleCP.Remove(oeDetalleCP)
                        End If
                        CargarDetalle(leDetalleCP)
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

End Class