Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_ConceptoPrestamo
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"


    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ConceptoPrestamo = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ConceptoPrestamo
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Dim oeConceptoPrestamo As New e_Concepto_Prestamo
    Dim olConceptoPrestamo As New l_Concepto_Prestamo
    Dim leConceptoPretsamo As New List(Of e_Concepto_Prestamo)
    Dim _ingresando_datos As Boolean = False

    Dim oeConceptoSancion As New e_Concepto_Prestamo
    Dim leConceptoSancion As New List(Of e_Concepto_Prestamo)

    Dim oeArea As New e_Area
    Dim olArea As New l_Area

    Dim BandConsul As Boolean
    Dim opersanc As String = ""
    Private _opeCP As String = "", _acl As String = ""

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"

            If griConceptoPrestamo.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            _acl = gAccionSistema.NUEVO.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                MostrarTabs(1, ficConceptoPrestamo, 1)
                Inicializar()
                oeConceptoPrestamo.TipoOperacion = "I"
                oeConceptoPrestamo.Tipo = "1"
                oeConceptoPrestamo.Modificado = False
                txtCodigo.Text = ObtieneCodigo("1")
                txtNombre.Focus()
                Operacion = "Nuevo"
                MyBase.Nuevo()
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
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                Mostrar()
                oeConceptoPrestamo.TipoOperacion = "A"
                oeConceptoPrestamo.Modificado = False
                txtNombre.Focus()
                Operacion = "Editar"
                MyBase.Editar()
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            _acl = gAccionSistema.ELIMINAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then

            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If Guardando() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficConceptoPrestamo, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeConceptoPrestamo.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            MostrarTabs(0, ficConceptoPrestamo, 2)
                            _ingresando_datos = False
                            Consultar(_Activo)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficConceptoPrestamo, 1)
                        End If

                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficConceptoPrestamo, 2)
                        _ingresando_datos = False
                        Consultar(_Activo)
                End Select
            Else
                MostrarTabs(0, ficConceptoPrestamo, 2)
                _ingresando_datos = False
                Consultar(_Activo)
            End If
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            _acl = gAccionSistema.EXPORTAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                If griConceptoPrestamo.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                Exportar_Excel(griConceptoPrestamo)

                MyBase.Exportar()
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ConceptoPrestamo_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case Operacion
            Case "Nuevo"
                Nuevo()
            Case "Editar"
                Editar()
            Case "Inicializa"
                If griConceptoPrestamo.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
        End Select
    End Sub

    Private Sub frm_ConceptoPrestamo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ConceptoPrestamo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub frm_ConceptoPrestamo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            BandConsul = True
            CargarConceptoPrestamo(New List(Of e_Concepto_Prestamo), 1)
            CargarConceptoPrestamo(New List(Of e_Concepto_Prestamo), 2)
            BandConsul = False
            CargarCombo()
            MostrarTabs(0, ficConceptoPrestamo)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        oeConceptoPrestamo.Nombre = txtNombre.Value
    End Sub

    Private Sub griConceptoSancion_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griConceptoSancion.DoubleClick
        If griConceptoSancion.Rows.Count > 0 Then EditarSancion()
    End Sub

    Private Sub txtCodigoSanc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoSanc.ValueChanged
        oeConceptoSancion.Codigo = txtCodigoSanc.Text.Trim
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        oeConceptoPrestamo.Codigo = txtCodigo.Text
    End Sub

    Private Sub txtNombreSanc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreSanc.ValueChanged
        oeConceptoSancion.Nombre = txtNombreSanc.Text.Trim
    End Sub

    Private Sub cboArea_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboArea.ValueChanged
        If cboArea.SelectedIndex > -1 Then oeConceptoSancion.IdArea = cboArea.Value : oeConceptoSancion.NombreArea = cboArea.Text
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        agrConceptoSancion.Expanded = False
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim oe As New e_Concepto_Prestamo
        If oeConceptoSancion.Id = "" Then
            oe.TipoOperacion = "I"
            oe.Activo = 1
            oe.Tipo = 2
            oe.IdArea = oeConceptoSancion.IdArea
            oe.NombreArea = oeConceptoSancion.NombreArea
            oe.Nombre = oeConceptoSancion.Nombre
            oe.Codigo = oeConceptoSancion.Codigo
            oe.UsuarioCreacion = gUsuarioSGI.Id
            If griConceptoSancion.Rows.Count = 0 Then CargarConceptoPrestamo(leConceptoSancion, 2)
            leConceptoSancion.Add(oe)
            CargarConceptoPrestamo(leConceptoSancion, 2)
            griConceptoSancion.DataBind()
            If MessageBox.Show("¿Desea seguir agregando Concepto de Sanciones?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                Inicializar_ConceptoSancion()
            Else
                agrConceptoSancion.Expanded = False
            End If
        Else
            oe = leConceptoSancion.Item(leConceptoSancion.IndexOf(oeConceptoSancion))
            oe.TipoOperacion = "A"
            oe.Activo = 1
            oe.IdArea = oeConceptoSancion.IdArea
            oe.NombreArea = oeConceptoSancion.NombreArea
            oe.Nombre = oeConceptoSancion.Nombre
            oe.Codigo = oeConceptoSancion.Codigo
            oe.UsuarioCreacion = gUsuarioSGI.Id
            oe.Tipo = 2
            CargarConceptoPrestamo(leConceptoSancion, 2)
            MessageBox.Show("Su informacion ha sido Editada correctamente", "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            agrConceptoSancion.Expanded = False
        End If
    End Sub

    Private Sub griConceptoPrestamo_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griConceptoPrestamo.DoubleClick
        If griConceptoPrestamo.Rows.Count > 0 Then Editar()
    End Sub

#End Region

#Region "Metodo"

    Public Sub CargarConceptoPrestamo(ByVal leConcepPre As List(Of e_Concepto_Prestamo), ByVal tip_cons As Integer)
        Try
            If tip_cons = 1 Then
                griConceptoPrestamo.DataSource = leConcepPre
            Else
                Dim leActivo As New List(Of e_Concepto_Prestamo)
                leActivo = leConcepPre.Where(Function(item) item.TipoOperacion <> "E").ToList
                griConceptoSancion.DataSource = leActivo
            End If

            If BandConsul Then ConfiguraGrilla(tip_cons)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try

            oeConceptoPrestamo = New e_Concepto_Prestamo
            oeConceptoPrestamo.Tipo = 1
            CargarConceptoPrestamo(olConceptoPrestamo.Listar(oeConceptoPrestamo), 1)

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try

        griConceptoPrestamo.Focus()

    End Sub

    Private Sub Inicializar()
        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        oeConceptoPrestamo = New e_Concepto_Prestamo
        leConceptoSancion = New List(Of e_Concepto_Prestamo)
        CargarConceptoPrestamo(leConceptoSancion, 2)
        agrConceptoSancion.Expanded = False
    End Sub

    Private Sub Mostrar()
        Try
            If griConceptoPrestamo.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeConceptoPrestamo.Id = griConceptoPrestamo.ActiveRow.Cells("Id").Value.ToString
                oeConceptoPrestamo = olConceptoPrestamo.Obtener(oeConceptoPrestamo)
                txtCodigo.Text = oeConceptoPrestamo.Codigo
                txtNombre.Text = oeConceptoPrestamo.Nombre
                leConceptoSancion = oeConceptoPrestamo.leConceptoSancion
                CargarConceptoPrestamo(leConceptoSancion, 2)
                MostrarTabs(1, ficConceptoPrestamo, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function ObtieneCodigo(ByVal tipo As String) As String
        Try
            Dim oeCP As New e_Concepto_Prestamo
            oeCP.Tipo = tipo
            oeCP.TipoOperacion = "C"
            oeCP = olConceptoPrestamo.Obtener(oeCP)
            Return oeCP.Codigo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CargarCombo()
        Try
            oeArea = New e_Area
            oeArea.Activo = 1
            oeArea.TipoOperacion = ""
            LlenarCombo(cboArea, "Nombre", olArea.Listar(oeArea), -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function Guardando() As Boolean
        Try
            oeConceptoPrestamo.UsuarioCreacion = gUsuarioSGI.Id
            oeConceptoPrestamo.leConceptoSancion = leConceptoSancion
            If olConceptoPrestamo.Guardar(oeConceptoPrestamo) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, ficConceptoPrestamo, 2)
                Consultar(_Activo)
                griConceptoPrestamo.Focus()
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            'Enfocar(ex.Message)
        End Try
    End Function

    Private Sub Inicializar_ConceptoSancion()
        oeConceptoSancion = New e_Concepto_Prestamo
        txtCodigoSanc.Text = String.Empty
        txtNombreSanc.Text = String.Empty
        If gUsuarioSGI.Controlado > 0 Then
            cboArea.Text = gUsuarioSGI.oeArea.Nombre
            oeConceptoPrestamo.IdArea = cboArea.Value
            cboArea.ReadOnly = True
        Else
            cboArea.SelectedIndex = -1
            cboArea.ReadOnly = False
        End If

        If opersanc = "Adiciona" Then
            If leConceptoSancion.Count > 0 Then
                Dim var As Integer = leConceptoSancion(leConceptoSancion.Count - 1).Codigo
                var = var + 1
                txtCodigoSanc.Text = FormatoDocumento(var, 6)
            Else
                txtCodigoSanc.Text = ObtieneCodigo(2)
            End If
        End If

    End Sub

    Private Sub EditarSancion()
        agrConceptoSancion.Expanded = True
        Inicializar_ConceptoSancion()
        oeConceptoSancion = griConceptoSancion.ActiveRow.ListObject
        txtCodigoSanc.Text = oeConceptoSancion.Codigo
        txtNombreSanc.Text = oeConceptoSancion.Nombre
        cboArea.Value = oeConceptoSancion.IdArea
        opersanc = "Editar"
    End Sub

    Private Sub ConfiguraGrilla(ByVal Tipo As Integer)
        Try
            Dim grilla As New UltraGrid
            Select Case Tipo
                Case 1 : grilla = griConceptoPrestamo
                Case 2 : grilla = griConceptoSancion
            End Select
            With grilla

                OcultarColumna(grilla, True, "Id", "Tipo", "IdArea", "IdConceptoPadre", "Activo", "FechaCreacion", "UsuarioCreacion")

                If Tipo = 1 Then .DisplayLayout.Bands(0).Columns("NombreArea").Hidden = True

                .DisplayLayout.Bands(0).Columns("NombreArea").Header.Caption = "Area"
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 300
                .DisplayLayout.Bands(0).Columns("NombreArea").Width = 250

                .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow

                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#End Region

#Region "Menu Contextual"

    Private Sub mnuConceptoSancion_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuConceptoSancion.Opening
        mnuConceptoSancion.Items("tsmiAgregar").Visible = True
        mnuConceptoSancion.Items("tsmiEditar").Visible = False
        mnuConceptoSancion.Items("tsmiQuitar").Visible = False
        If griConceptoSancion.Rows.Count > 0 Then
            mnuConceptoSancion.Items("tsmiEditar").Visible = True
            mnuConceptoSancion.Items("tsmiQuitar").Visible = True
        End If
    End Sub

    Private Sub tsmiAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiAgregar.Click
        opersanc = "Adiciona"
        agrConceptoSancion.Expanded = True
        Inicializar_ConceptoSancion()
    End Sub

    Private Sub tsmiEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEditar.Click
        EditarSancion()
    End Sub

    Private Sub tsmiQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiQuitar.Click
        If MessageBox.Show("¿Desea eliminar este registro?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            Dim oe As New e_Concepto_Prestamo
            oe = griConceptoSancion.ActiveRow.ListObject
            oe = leConceptoSancion.Item(leConceptoSancion.IndexOf(oe))
            If oe.Id <> "" Then
                oe.TipoOperacion = "E"
            Else
                leConceptoSancion.Remove(oe)
            End If
            CargarConceptoPrestamo(leConceptoSancion, 2)
        End If
    End Sub

#End Region

End Class