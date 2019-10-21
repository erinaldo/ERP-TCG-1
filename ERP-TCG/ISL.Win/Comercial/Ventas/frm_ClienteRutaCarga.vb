'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================


Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource
Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices
Imports Infragistics.Win.UltraWinGrid.UltraGridAction

Public Class frm_ClienteRutaCarga
    Inherits frm_MenuPadre

#Region "Inicializacion del Formulario"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ClienteRutaCarga = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ClienteRutaCarga()
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de Variables"

    Private WithEvents oeClienteRuta As New e_ClienteRutaCarga
    Dim olClienteRuta As New l_ClienteRutaCarga
    Dim _ingresando_datos As Boolean = False

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griClienteCarga.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            oeClienteRuta.TipoOperacion = "I"
            MostrarTabs(1, ficClienteRutaCarga, 1)
            Inicializar()
            cboCliente.Focus()
            Operacion = "Nuevo"
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            If griClienteCarga.Selected.Rows.Count > 0 Then
                Inicializar()
                Mostrar()
                MostrarTabs(1, ficClienteRutaCarga, 1)
                cboCliente.Focus()
                Operacion = "Editar"
                ControlBoton(0, 0, 0, 1, 1)
            End If      
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarClienteRuta() Then
                mensajeEmergente.Confirmacion("La Informacion ha Sido Guardada Correctamente", True)
                MostrarTabs(0, ficClienteRutaCarga)
                Listar(True)
            Else
                MostrarTabs(1, ficClienteRutaCarga, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeClienteRuta.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarClienteRuta() Then
                            MostrarTabs(0, ficClienteRutaCarga, 2)
                            _ingresando_datos = False
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficClienteRutaCarga, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficClienteRutaCarga, 2)
                        _ingresando_datos = False
                        Operacion = "Inicializa"
                        MyBase.Consultar(True)
                End Select
            Else
                MostrarTabs(0, ficClienteRutaCarga, 2)
                _ingresando_datos = False
                Operacion = "Inicializa"
                MyBase.Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griClienteCarga
                oeClienteRuta = New e_ClienteRutaCarga
                oeClienteRuta.Id = .ActiveRow.Cells("Id").Value
                oeClienteRuta = olClienteRuta.Obtener(oeClienteRuta)
                If oeClienteRuta.Activo Then
                    If MessageBox.Show("Esta seguro de eliminar el registro?", _
                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        oeClienteRuta.TipoOperacion = "E"
                        olClienteRuta.Eliminar(oeClienteRuta)
                        Consultar(True)
                    End If
                Else
                    Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griClienteCarga.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griClienteCarga)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ClienteRutaCarga_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Select Case ficClienteRutaCarga.SelectedTab.Index
            Case 0
                If griClienteCarga.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1)
        End Select
    End Sub

    Private Sub frm_ClienteRutaCarga_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ClienteRutaCarga_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_ClienteRutaCarga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarCombos()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griClienteCarga_DoubleClick(sender As Object, e As EventArgs) Handles griClienteCarga.DoubleClick
        Editar()
    End Sub

    Private Sub ToolStripMenuEditar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuEditar.Click
        Editar()
    End Sub

    Private Sub ToolStripMenuNuevo_Click(sender As Object, e As EventArgs) Handles ToolStripMenuNuevo.Click
        Nuevo()
    End Sub

    Private Sub ToolStripMenuEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuEliminar.Click
        Eliminar()
    End Sub

#End Region

#Region "Metodos"

    Private Sub Inicializar()
        Try
            oeClienteRuta = New e_ClienteRutaCarga
            cboCliente.SelectedIndex = -1
            cboOrigen.SelectedIndex = -1
            cboDestino.SelectedIndex = -1
            cboMaterial.SelectedIndex = -1
            rbSi.Checked = True
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar(Activo As Boolean)
        Try
            oeClienteRuta = New e_ClienteRutaCarga
            oeClienteRuta.IdCliente = cboClienteBuscar.Value
            oeClienteRuta.IdOrigen = cboLugarBOri.Value
            oeClienteRuta.IdDestino = cboLugarBDes.Value
            griClienteCarga.DataSource = olClienteRuta.Listar(oeClienteRuta)
            If griClienteCarga.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            Else
                ControlBoton(1, 1)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarClienteRuta() As Boolean
        Try
            LlenaObjeto()
            oeClienteRuta.PrefijoID = gs_PrefijoIdSucursal '@0001
            If Not olClienteRuta.Guardar(oeClienteRuta) Then
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Mostrar()
        Try
            oeClienteRuta.Id = griClienteCarga.ActiveRow.Cells("Id").Value
            oeClienteRuta = olClienteRuta.Obtener(oeClienteRuta)
            With oeClienteRuta
                cboCliente.Value = .IdCliente
                cboOrigen.Value = .IdOrigen
                cboDestino.Value = .IdDestino
                cboMaterial.Value = .IdMaterial
                If .IndCuenta = 1 Then
                    rbSi.Checked = True
                Else
                    rbNo.Checked = True
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaObjeto()
        Try
            With oeClienteRuta
                If Operacion = "Nuevo" Then
                    .TipoOperacion = "I"
                Else
                    .TipoOperacion = "A"
                End If
                .IdCliente = cboCliente.Value
                .IdOrigen = cboOrigen.Value
                .IdDestino = cboDestino.Value
                .IdMaterial = cboMaterial.Value
                .IndCuenta = IIf(rbSi.Checked, 1, 0)
                .UsuarioCreacion = gUsuarioSGI.Id
                .FechaCreacion = ObtenerFechaServidor()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarCombos()
        Try
            Dim lo As New List(Of e_Combo)
            Dim oe As New e_Combo
            LlenarComboMaestro(cboCliente, ClientesPublic, -1)
            LlenarComboMaestro(cboOrigen, LugaresPublic, -1)
            LlenarComboMaestro(cboDestino, LugaresPublic, -1)
            LlenarComboMaestro(cboMaterial, MaterialesPublic.Where(Function(i) i.Descripcion.Trim = "OPERACIONESC" Or i.Descripcion.Trim = "MERMA").ToList.OrderBy(Function(i) i.Nombre).ToList, -1)
            oe.Id = ""
            oe.Nombre = "TODOS"
            lo.Add(oe)
            lo.AddRange(LugaresPublic)
            LlenarComboMaestro(cboLugarBDes, lo, 0)
            LlenarComboMaestro(cboLugarBOri, lo, 0)
            lo = New List(Of e_Combo)
            lo.Add(oe)
            lo.AddRange(ClientesPublic)
            LlenarComboMaestro(cboClienteBuscar, lo, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CargarDesdeSeguros(IdCliente As String, IdOrigen As String, IdDestino As String, IdMaterial As String)
        Try
            Nuevo()
            cboCliente.Value = IdCliente
            cboOrigen.Value = IdOrigen
            cboDestino.Value = IdDestino
            cboMaterial.Value = IdMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

End Class