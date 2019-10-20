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
Public Class frm_ParticipacionAcciones
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Shared instancia As frm_ParticipacionAcciones = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ParticipacionAcciones()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"
    Dim _ComboPeriodo As Boolean = False
    Dim _ingresando_datos As Boolean = False
    Private oePeriodo As e_Periodo

    Private oeTrabajador As New e_Trabajador
    Private olTrabajador As New l_Trabajador
    Private lstTrabajador As New List(Of e_Trabajador)

    Private oeConcepto As New e_Concepto
    Private olConcepto As New l_Concepto
    Private lstConcepto As New List(Of e_Concepto)

    Private oeParticipacionAccion As New e_ParticipacionAccion
    Private olParticipacionAccion As New l_ParticipacionAccion
    Private lstParticipacionAccion As New List(Of e_ParticipacionAccion)

    Private objPeriodo As New e_Periodo
#End Region

#Region "Botones"
    Public Overrides Sub Eliminar()
        Try
            If ugParticipantes.ActiveRow.Index <> -1 Then
                If ugParticipantes.Rows(ugParticipantes.ActiveRow.Index).Cells("Activo").Value = True Then
                    Operacion = "Eliminar"
                    Editar_Participante()
                Else
                    mensajeEmergente.Problema("Registro de accionista ya ha sido dado de Baja.")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim objPeriodo As New e_Periodo
            oeParticipacionAccion = New e_ParticipacionAccion
            oeParticipacionAccion.TipoOperacion = ""
            lstParticipacionAccion = olParticipacionAccion.Listar(oeParticipacionAccion)
            ugParticipantes.DataSource = lstParticipacionAccion
            Cargar_Capital()
            If ugParticipantes.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                lstParticipacionAccion = lstParticipacionAccion.Where(Function(g) g.Activo = True).ToList
                Dim acciones As Decimal = lstParticipacionAccion.Sum(Function(g) g.NroAcciones)
                decValorB.Value = (decCapitalB.Value / acciones)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If Operacion = "Nuevo" Then
                If Validar_ExisteParticipante() = False Then
                    If MessageBox.Show("Esta seguro de guardar Accionista?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
                        GuardarParticipante()
                    End If
                Else
                    If MessageBox.Show("Accionista ya se encuentra registrado, está seguro de agregar acciones?.", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
                        GuardarParticipante()
                    End If
                End If
            ElseIf Operacion = "Editar" Then
                If MessageBox.Show("Esta seguro de actualizar datos de Accionista?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
                    GuardarParticipante()
                    Cancelar()
                End If
            ElseIf Operacion = "Eliminar" Then
                If MessageBox.Show("Está seguro de dar Baja al Accionista?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
                    oeParticipacionAccion = New e_ParticipacionAccion
                    oeParticipacionAccion.Activo = True
                    oeParticipacionAccion.TipoOperacion = "E"
                    oeParticipacionAccion.FechaBaja = FechaBaja.Value
                    oeParticipacionAccion.UsuarioCreacion = gUsuarioSGI.Id
                    oeParticipacionAccion.Id = ugParticipantes.Rows(ugParticipantes.ActiveRow.Index).Cells("Id").Value
                    oeParticipacionAccion.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olParticipacionAccion.Guardar(oeParticipacionAccion) Then
                        mensajeEmergente.Confirmacion("Registro de Accionista Eliminado.", True)
                    End If
                    Cancelar()
                Else
                    Cancelar()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            'Enfocar(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            MostrarTabs(0, ficParticipacion)
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            Habilitar_Controles(True)
            Operacion = "Inicializa"
            Consultar(True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            Habilitar_Controles(True)
            NuevoParticipante()
            Operacion = "Nuevo"
            cboTrabajador.Enabled = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            If ugParticipantes.ActiveRow.Index <> -1 Then
                If ugParticipantes.Rows(ugParticipantes.ActiveRow.Index).Cells("Activo").Value = True Then
                    Habilitar_Controles(True)
                    Operacion = "Editar"
                    Editar_Participante()
                Else
                    mensajeEmergente.Problema("Registro de accionista no se puede editar, ya ha sido dado de Baja.")
                End If
            End If
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
            '_acl = gAccionSistema.EXPORTAR.ToString
            'If ValidarAcl(_acl, pIdActividadNegocio) Then
            'If griOrganigrama.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            'ExportarGrillaAExcel(griOrganigrama, "Estructura_Organizacional")
            MyBase.Exportar()
            '
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"
    Private Sub frm_Ocupacion_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Ocupacion_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case Operacion
            Case "Nuevo"
                Me.Activate()
                Me.Cancelar()
            Case "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_ParticipacionAcciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _ComboPeriodo = True
        MostrarTabs(0, ficParticipacion)
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        CargarConcepto()
        LlenaCombosTrabajadores()
        CargarDocumentos()
    End Sub

    Private Sub cboTrabajador_Enter(sender As Object, e As EventArgs) Handles cboTrabajador.Enter
        If cboTrabajador.SelectedIndex <> -1 Then
            Dim oeTrabajadorAux As New e_Trabajador
            oeTrabajador.TipoOperacion = ""
            oeTrabajadorAux.Id = cboTrabajador.Value
            txtDocumento.Value = olTrabajador.Listar(oeTrabajadorAux).Item(0).oePersona.Dni
            If Not txtDocumento.Value Is String.Empty Then cboTipoDoc.SelectedIndex = 1 Else cboTipoDoc.Text = "DOCUMENTO NACIONAL DE IDENTIDAD (DNI)"
        End If
    End Sub

    Private Sub cboTrabajador_ValueChanged(sender As Object, e As EventArgs) Handles cboTrabajador.ValueChanged
        If cboTrabajador.SelectedIndex <> -1 Then
            Dim oeTrabajadorAux As New e_Trabajador
            oeTrabajador.TipoOperacion = ""
            oeTrabajadorAux.Id = cboTrabajador.Value
            txtDocumento.Value = olTrabajador.Listar(oeTrabajadorAux).Item(0).oePersona.Dni
            If Not txtDocumento.Value Is String.Empty Then cboTipoDoc.SelectedIndex = 1 Else cboTipoDoc.Text = "DOCUMENTO NACIONAL DE IDENTIDAD (DNI)"
        End If
    End Sub

    Private Sub frm_ParticipacionAcciones_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If ficParticipacion.Tabs(0).Active Then
            If ugParticipantes.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Else
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        End If
    End Sub
#End Region

#Region "Métodos"
    
    Private Sub CargarConcepto()
        Try
            oeConcepto = New e_Concepto
            oeConcepto.Prefijo = "35"
            lstConcepto = olConcepto.Listar(oeConcepto)
            LlenarCombo(cboTipoAccion, "Nombre", lstConcepto, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDocumentos()
        Try
            oeConcepto = New e_Concepto
            oeConcepto.Prefijo = "36"
            lstConcepto = olConcepto.Listar(oeConcepto)
            LlenarCombo(cboTipoDoc, "Nombre", lstConcepto, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlenaCombosTrabajadores()
        Try
            Dim loTrabajador As New List(Of e_Trabajador)
            oeTrabajador = New e_Trabajador
            oeTrabajador.TipoOperacion = ""
            loTrabajador.AddRange(olTrabajador.Listar(oeTrabajador))
            Dim _leTrabAux = From le In loTrabajador Select le.Id, le.oePersona.NombreCompleto
            LlenarCombo(cboTrabajador, "NombreCompleto", _leTrabAux.ToList, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Cargar_Capital()
        Dim capital As Decimal = 0.0
        Dim objPeriodo As New e_Periodo
        Dim olAsiento As New l_Asiento
        Dim dt As DataTable = olAsiento.ListarEEFF(Date.Now.Year, Date.Now.Month, "50")
        capital = Math.Abs(CDbl(dt.Compute("Sum(TMN)", "Cuenta = '50'")))
        decCapitalB.Value = capital
    End Sub

    Private Sub LimpiarControles()
        txtDocumento.Value = String.Empty
        txtNroAccion.Value = 0
        cboTipoAccion.Text = ""
        cboTrabajador.Text = ""
        cboTipoDoc.Text = ""
        Fecha.Value = Date.Now
    End Sub

    Private Sub NuevoParticipante()
        If MessageBox.Show("Desea Agregar Accionista?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
            MostrarTabs(1, ficParticipacion, 1)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            'Cargar_Capital()
            LimpiarControles()
        End If
    End Sub

    Private Sub Cargar_Datos()
        oeParticipacionAccion = New e_ParticipacionAccion
        With oeParticipacionAccion
            .TipoOperacion = "L"
            .Id = ugParticipantes.Rows(ugParticipantes.ActiveRow.Index).Cells("Id").Value
        End With
        oeParticipacionAccion = olParticipacionAccion.Listar(oeParticipacionAccion).Item(0)
        cboTrabajador.Value = oeParticipacionAccion.IdTrabajador
        cboTipoDoc.Value = oeParticipacionAccion.TipoDoc
        txtDocumento.Value = oeParticipacionAccion.NroDoc
        txtNroAccion.Value = oeParticipacionAccion.NroAcciones
        cboTipoAccion.Value = oeParticipacionAccion.TipoAccion
        Fecha.Value = oeParticipacionAccion.Fecha
    End Sub

    Private Function Validar_Datos()
        Dim _ban As Boolean = True
        l_FuncionesGenerales.ValidarCampoNoNulo(oeParticipacionAccion.IdTrabajador, "Seleciona Accionista.")
        l_FuncionesGenerales.ValidarCampoNoNulo(oeParticipacionAccion.TipoDoc, "Seleccione Tipo de Documento.")
        l_FuncionesGenerales.ValidarCampoNoNulo(oeParticipacionAccion.NroDoc, "Ingrese Número de Documento.")
        l_FuncionesGenerales.ValidarCampoNoNulo(oeParticipacionAccion.NroAcciones, "Ingrese Número de Acciones.")
        If oeParticipacionAccion.NroAcciones <= 0 Then
            _ban = False
            mensajeEmergente.Problema("El Número de Accionbes debe ser mayor a 0.")
        End If
        l_FuncionesGenerales.ValidarCampoNoNulo(oeParticipacionAccion.TipoAccion, "Seleccione Tipo de Acción.")
        Return _ban
    End Function

    Private Sub GuardarParticipante()
        If Operacion = "Nuevo" Then oeParticipacionAccion = New e_ParticipacionAccion
        With oeParticipacionAccion
            .TipoOperacion = IIf(Operacion = "Nuevo", "I", "A")
            .NroAcciones = txtNroAccion.Value
            .TipoAccion = cboTipoAccion.Value
            .IdTrabajador = cboTrabajador.Value
            .UsuarioCreacion = gUsuarioSGI.Id
            .Activo = True
            .TipoDoc = cboTipoDoc.Value
            .NroDoc = txtDocumento.Value
            .PorcParticipacion = 0.0
            .Fecha = Fecha.Value
            .FechaBaja = #1/1/1901#
        End With
        If Validar_Datos() Then
            olParticipacionAccion = New l_ParticipacionAccion
            oeParticipacionAccion.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olParticipacionAccion.Guardar(oeParticipacionAccion) Then
                mensajeEmergente.Confirmacion("Registro de Accionista Correcto.", True)
                Cancelar()
            End If
        End If
    End Sub

    Private Function Validar_ExisteParticipante() As Boolean
        oeParticipacionAccion = New e_ParticipacionAccion
        With oeParticipacionAccion
            .TipoOperacion = "B"
            .IdTrabajador = cboTrabajador.Value
            '.IdPeriodo = objPeriodo.Id
        End With
        olParticipacionAccion = New l_ParticipacionAccion
        If olParticipacionAccion.Listar(oeParticipacionAccion).Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Editar_Participante()
        If Operacion = "Editar" Then
            If MessageBox.Show("Desea editar registro de participante?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
                MostrarTabs(1, ficParticipacion, 1)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
                'Cargar_Capital()
                'LimpiarControles()
                Operacion = "Editar"
                Cargar_Datos()
                cboTrabajador.Enabled = False
            Else
                Operacion = "Inicializa"
            End If
        ElseIf Operacion = "Eliminar" Then
            If MessageBox.Show("Desea dar de baja registro de participante?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
                MostrarTabs(1, ficParticipacion, 1)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
                'Cargar_Capital()
                'LimpiarControles()
                Operacion = "Eliminar"
                Cargar_Datos()
                Habilitar_Controles(False)
            Else
                Operacion = "Inicializa"
            End If
        End If
    End Sub

    Private Sub Habilitar_Controles(Optional _ban As Boolean = True)
        eFechaBaja.Visible = Not (_ban)
        FechaBaja.Visible = Not (_ban)
        cboTrabajador.Enabled = _ban
        cboTipoDoc.Enabled = _ban
        cboTipoAccion.Enabled = _ban
        txtDocumento.Enabled = _ban
        txtNroAccion.Enabled = _ban
        Fecha.Enabled = _ban
    End Sub
#End Region


    Private Sub cboTipoDoc_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoDoc.ValueChanged
        Try
            If cboTrabajador.SelectedIndex <> -1 Then
                If cboTipoDoc.Text = "DOCUMENTO NACIONAL DE IDENTIDAD (DNI)" Then
                    Dim oeTrabajadorAux As New e_Trabajador
                    oeTrabajadorAux.Id = cboTrabajador.Value
                    txtDocumento.Value = olTrabajador.Listar(oeTrabajadorAux).Item(0).oePersona.Dni
                    txtDocumento.ReadOnly = True
                Else
                    txtDocumento.Value = ""
                    txtDocumento.ReadOnly = False
                End If
            Else
                cboTipoDoc.Text = ""
                cboTrabajador.Focus()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub ugParticipantes_DoubleClickRow(sender As Object, e As UltraWinGrid.DoubleClickRowEventArgs) Handles ugParticipantes.DoubleClickRow
        Editar()
    End Sub

    Private Sub frm_ParticipacionAcciones_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub MenuContextual1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("NuevoToolStripMenuItem").Visible = 1
        MenuContextual1.Items("EditarToolStripMenuItem").Visible = 0
        MenuContextual1.Items("EliminarToolStripMenuItem").Visible = 0
        If ugParticipantes.Selected.Rows.Count > 0 Then
            If ugParticipantes.ActiveRow.Cells("Activo").Value = True Then
                MenuContextual1.Items("EliminarToolStripMenuItem").Visible = 1
                MenuContextual1.Items("EditarToolStripMenuItem").Visible = 1
            Else
                MenuContextual1.Items("EliminarToolStripMenuItem").Visible = 0
                MenuContextual1.Items("EditarToolStripMenuItem").Visible = 0
            End If
        End If
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
    End Sub
End Class
