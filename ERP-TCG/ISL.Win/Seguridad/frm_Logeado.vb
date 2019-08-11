Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_Logeado
    Inherits ISL.Win.frm_MenuPadre

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Logeado = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Logeado()
        End If
        instancia.Activate()
        Return instancia

    End Function

#Region "Declaracion de Variables"

    Dim oeControlUsuario As New e_ControlUsuario
    Dim olControlUsuario As New l_ControlUsuario
    Dim _ingresando_datos As Boolean = False

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Instancia"
            If griLogeo.Rows.Count > 0 Then
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
            Else
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    'Public Overrides Sub Nuevo()
    '    MostrarTabs(1, ficLogeo, 1)
    '    Inicializar()
    '    oeArea.TipoOperacion = "I"
    '    oeArea.Modificado = False
    '    txtCodigo.Focus()
    '    Operacion = "Nuevo"
    '    MyBase.Nuevo()
    'End Sub

    Public Overrides Sub Editar()
        Mostrar()
        oeControlUsuario.TipoOperacion = "A"
        oeControlUsuario.Modificado = False
        'txtCodigo.Focus()
        Operacion = "Editar"
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Public Overrides Sub Guardar()
        Try
            If Not Guardando() Then MostrarTabs(1, ficLogeo, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeControlUsuario.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            MostrarTabs(0, ficLogeo, 2)
                            _ingresando_datos = False
                            Consultar(_Activo)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficLogeo, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficLogeo, 2)
                        _ingresando_datos = False
                        Consultar(_Activo)
                End Select
            Else
                MostrarTabs(0, ficLogeo, 2)
                _ingresando_datos = False
                Consultar(_Activo)
            End If
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    'Public Overrides Sub Eliminar()
    '    MyBase.Eliminar()
    'End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If griLogeo.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griLogeo)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Logeado_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case _Operacion
            Case "Nuevo"
                Nuevo()

            Case "Editar"
                Editar()

            Case "Inicializa"
                If _Activo Then
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                Else
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                End If
        End Select
    End Sub

    Private Sub frm_Logeado_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Logeado_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Select Case Operacion
            'Case "Nuevo"
            '    Me.Activate()
            '    Me.Cancelar()

            Case "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_Logeado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            colorSalida.Color = Color.Gainsboro
            etiSalida.Appearance.BackColor = colorSalida.Color
            fecFecha.Value = Date.Now.Date
            fecFechaFin.Value = Date.Now.Date
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            CargarCombo()
            cboUsuario.Enabled = False
            colorSalida.Enabled = False
            MostrarTabs(0, ficLogeo)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griLogeo_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griLogeo.DoubleClick
        If griLogeo.Rows.Count > 0 Then Editar()
    End Sub

    'Private Sub numAmpliacion_ValidationError(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.ValidationErrorEventArgs) Handles numAmpliacion.ValidationError
    '    oeControlUsuario.Ampliacion = numAmpliacion.Value
    'End Sub

    Private Sub numAmpliacion_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numAmpliacion.ValueChanged
        oeControlUsuario.Ampliacion = numAmpliacion.Value
    End Sub

    Private Sub colorSalida_ColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colorSalida.ColorChanged
        etiSalida.Appearance.BackColor = colorSalida.Color
    End Sub

    Private Sub verUsuario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verUsuario.CheckedChanged
        'CargaUsuario()
        cboUsuario.Enabled = verUsuario.Checked
        colorSalida.Enabled = verUsuario.Checked
    End Sub

    Private Sub cboArea_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboArea.ValueChanged
        Try
            Dim oeUsu As New e_Usuario
            Dim olUsu As New l_Usuario
            Dim loListar As New List(Of e_Usuario)
            oeUsu.oeArea.Id = cboArea.Value
            oeUsu.Controlado = -1
            loListar = olUsu.Listar(oeUsu)

            For Each oeUserAux In loListar
                oeUserAux.Login = oeUserAux.oePersona.NombreCompleto
            Next

            loListar = loListar.OrderBy(Function(item) item.Login).ToList

            LlenarCombo(cboUsuario, "Login", loListar, -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            oeControlUsuario = New e_ControlUsuario
            With griLogeo
                oeControlUsuario.TipoOperacion = "L"
                oeControlUsuario.IdUsuario = ""
                oeControlUsuario.Salida = -1
                oeControlUsuario.FechaInicio = fecFecha.DateTime.Date
                oeControlUsuario.FechaSalida = fecFechaFin.DateTime.Date
                oeControlUsuario.IdArea = cboArea.Value
                If verUsuario.Checked Then oeControlUsuario.IdUsuario = cboUsuario.Value : oeControlUsuario.Salida = -1
                .DataSource = olControlUsuario.Listar(oeControlUsuario)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Salida").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox

                For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLogeo.Rows
                    If Fila.Cells("Salida").Value = 1 Then Fila.Appearance.BackColor = colorSalida.Color
                Next

                'Ubica el cursor el el primer registro de la grilla
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
        griLogeo.Focus()
    End Sub

    Private Sub Inicializar()
        'txtCodigo.Text = String.Empty
        'txtNombre.Text = String.Empty
        'txtAbreviatura.Text = String.Empty
        'verActivo.Checked = True
        'AsociarMenu()
    End Sub

    Private Sub Mostrar()
        Try
            If griLogeo.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeControlUsuario.Id = griLogeo.ActiveRow.Cells("Id").Value.ToString
                oeControlUsuario = olControlUsuario.Obtener(oeControlUsuario)
                txtNombreCompleto.Text = oeControlUsuario.NombreCompleto
                fecFechaInicio.Value = oeControlUsuario.FechaInicio
                fecFechaSalida.Value = oeControlUsuario.FechaSalida
                numAmpliacion.Value = oeControlUsuario.Ampliacion
                verSalida.Checked = oeControlUsuario.Salida
                MostrarTabs(1, ficLogeo, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function Guardando() As Boolean
        Try
            oeControlUsuario.IdUsuario = gUsuarioSGI.Id
            If olControlUsuario.Guardar(oeControlUsuario) <> "" Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, ficLogeo, 2)
                Consultar(_Activo)
                griLogeo.Focus()
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    Private Sub Enfocar(ByVal excepcion As String)
        'If excepcion.Contains("Codigo") Then
        '    txtCodigo.Focus()
        'End If
        'If excepcion.Contains("Nombre") Then
        '    txtNombre.Focus()
        'End If
    End Sub

    Private Sub CargarCombo()
        Try
            Dim oeArea As New e_Area
            Dim olArea As New l_Area
            Dim leArea As New List(Of e_Area)
            oeArea.Id = ""
            oeArea.Nombre = "TODOS"
            leArea.Add(oeArea)
            oeArea = New e_Area
            leArea.AddRange(olArea.Listar(oeArea))
            LlenarCombo(cboArea, "Nombre", leArea, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_Logeado_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griLogeo_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griLogeo.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

End Class