'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win.UltraWinGrid

Public Class frm_Trabajo
    Inherits ISL.Win.frm_MenuPadre

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Trabajo = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Trabajo()
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaracion de Variables"
    Dim oeTrabajoSQL As New e_TrabajoSQL
    Dim olTrabajoSQL As New l_TrabajoSQL
    Dim _ingresando_datos As Boolean = False
    Dim oeEmail As New e_Email
    Dim olEmail As New l_Email
    Dim Esquema As String()
    Dim Procedimiento As String()
    Dim Emails As String()
    Dim lEmails As New ListBox
#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griTrabajoSQL.Rows.Count > 0 Then
                ' MyBase.Consultar(Activo)
                ControlBoton(1, 0, 1, 0, 0, 0, 0, 0, 1)
            Else
                'MyBase.Consultar()
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    'Public Overrides Sub Nuevo()
    '    MostrarTabs(1, ficAlerta, 1)
    '    Inicializar()
    '    oeAlerta.TipoOperacion = "I"
    '    oeAlerta.Modificado = False
    '    txtGlosa.Focus()
    '    Operacion = "Nuevo"
    '    MyBase.Nuevo()
    'End Sub

    Public Overrides Sub Editar()
        Mostrar()
        oeTrabajoSQL.TipoOperacion = "A"
        oeTrabajoSQL.Modificado = False
        'txtGlosa.Focus()
        Operacion = "Editar"
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            'LlenarDatos()
            If Guardando() Then
                'MyBase.Guardar()
                ControlBoton(1, 0, 1, 0, 0, 0, 0, 0, 1)
            Else
                MostrarTabs(1, ficTrabajoSQL, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeTrabajoSQL.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            MostrarTabs(0, ficTrabajoSQL, 2)
                            _ingresando_datos = False
                            Consultar(_Activo)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficTrabajoSQL, 1)
                        End If
                        'Exit Sub
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficTrabajoSQL, 2)
                        _ingresando_datos = False
                        Consultar(_Activo)
                        'Exit Sub
                End Select
            Else
                MostrarTabs(0, ficTrabajoSQL, 2)
                _ingresando_datos = False
                Consultar(_Activo)
                'Exit Sub
            End If
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    'Public Overrides Sub Eliminar()
    '    Try
    '        With griAlerta
    '            If Not ValidarGrilla(griAlerta, "Alerta") Then Exit Sub
    '            oeAlerta.Id = .ActiveRow.Cells("ID").Value
    '            oeAlerta = olAlerta.Obtener(oeAlerta)
    '            If oeAlerta.Activo Then
    '                If MessageBox.Show("Esta seguro de eliminar la Alerta: " & _
    '                         .ActiveRow.Cells("NombreCompleto").Value.ToString & " ?", _
    '                         "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
    '                    oeAlerta.TipoOperacion = "E"
    '                    olAlerta.Eliminar(oeAlerta)
    '                    Consultar(True)
    '                End If
    '            Else
    '                Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
    '            End If
    '        End With
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message)
    '    End Try
    'End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If griTrabajoSQL.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griTrabajoSQL)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Trabajo_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_Trabajo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Trabajo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_Trabajo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        Tiempo1.Enabled = False
        MostrarTabs(0, ficTrabajoSQL)
        txtComando.CharacterCasing = CharacterCasing.Normal
        InicializaTiempo()
        'griAlerta.ContextMenuStrip = MenuContextual1
    End Sub

    Private Sub griTrabajoSQL_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griTrabajoSQL.DoubleClick
        Editar()
    End Sub

    Private Sub txtComando_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtComando.ValueChanged
        oeTrabajoSQL.Comando = txtComando.Text.Trim
    End Sub

    Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click
        Dim cadena() As String = Split(txtComando.Text.Trim, "[")
        Esquema = Split(cadena(1), "]")
        Procedimiento = Split(cadena(2), "]")
        Try
            Dim dt As DataTable = olTrabajoSQL.ListarProcedimiento(Procedimiento(0))
            If dt.Rows.Count > 0 Then
                With griParametros
                    .ResetDisplayLayout()
                    .DataSource = dt
                    .DisplayLayout.Bands(0).Columns("PARAMETER_NAME").Header.Caption = "Parametro"
                    .DisplayLayout.Bands(0).Columns("DATA_TYPE").Header.Caption = "Tipo Dato"
                    .DisplayLayout.Bands(0).Columns("CHARACTER_MAXIMUM_LENGTH").Header.Caption = "Longitud"
                    .DisplayLayout.Bands(0).Columns.Add("Valor", "Valor")
                    .DisplayLayout.Bands(0).Columns("Valor").DataType = System.Type.GetType("System.String")
                    .DisplayLayout.Bands(0).Columns("Valor").Width = 300
                    .DisplayLayout.Bands(0).Columns("Valor").CellAppearance.BackColor = Color.Yellow
                    .DisplayLayout.UseFixedHeaders = True
                    .DisplayLayout.Bands(0).Columns("PARAMETER_NAME").Header.Fixed = True
                    .DisplayLayout.Bands(0).Columns("CHARACTER_MAXIMUM_LENGTH").Hidden = True
                    .DisplayLayout.Bands(0).Columns("PARAMETER_NAME").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    .DisplayLayout.Bands(0).Columns("DATA_TYPE").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    .DisplayLayout.Bands(0).Columns("CHARACTER_MAXIMUM_LENGTH").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    Dim Parametros() As String = Split(Procedimiento(1), ",")
                    For i As Integer = 0 To Parametros.Length - 1
                        Select Case .Rows(i).Cells("DATA_TYPE").Value
                            Case "decimal", "float", "int", "smallint", "bit", "numeric", "bigint", "money", "smallmoney", "tinyint", "real"
                                .Rows(i).Cells("valor").Value = Parametros(i).Trim
                            Case Else
                                Dim valor As String = Parametros(i).Trim
                                valor = valor.Substring(1, valor.Length - 2)
                                .Rows(i).Cells("valor").Value = valor
                        End Select
                    Next
                    .UpdateData()
                    Emails = Split(.Rows(.Rows.Count - 1).Cells("valor").Value, ";")
                    lEmails.Items.Clear()
                    For j As Integer = 0 To Emails.Length - 1
                        lEmails.Items.Add(Emails(j))
                    Next
                    Dim p As Integer = lEmails.Items.Count
                    MostrarEmails(lEmails)
                End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub verHabilitado_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verHabilitado.CheckedChanged
        oeTrabajoSQL.Habilitado = verHabilitado.Checked
    End Sub

    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
        If griParametros.Rows.Count > 1 Then
            Try
                Dim cadena As String = ""
                For Each fila As UltraGridRow In griParametros.Rows
                    Select Case fila.Cells("DATA_TYPE").Value
                        Case "decimal", "float", "int", "smallint", "bit", "numeric", "bigint", "money", "smallmoney", "tinyint", "real"
                            cadena = cadena + fila.Cells("valor").Value + ", "
                        Case Else
                            cadena = cadena + "'" + fila.Cells("valor").Value + "', "
                    End Select
                Next
                txtComando.Text = "EXEC [" & Esquema(0) & "].[" & Procedimiento(0) & "] " & cadena.Substring(0, cadena.Length - 2)
            Catch ex As Exception
                mensajeEmergente.Problema(ex.Message)
            End Try
        End If
        
    End Sub

    Private Sub griEmail_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griEmail.CellChange
        With griEmail
            .UpdateData()
            Dim NombreEmail As String = ""
            If .ActiveRow.Cells("Selec").Activated Then
                NombreEmail = .ActiveRow.Cells("Nombre").Value
                If .ActiveRow.Cells("Selec").Value Then
                    lEmails.Items.Add(NombreEmail)
                Else
                    lEmails.Items.Remove(NombreEmail)
                End If
                LlenarEmails(lEmails)
            End If
        End With
    End Sub

#End Region

#Region "Metodos"

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            oeTrabajoSQL = New e_TrabajoSQL
            With griTrabajoSQL
                .DataSource = olTrabajoSQL.Listar(oeTrabajoSQL)

                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griTrabajoSQL.Focus()
    End Sub

    Private Sub Inicializar()
        Try
            txtNombre.Text = String.Empty
            txtDescripcion.Text = String.Empty
            txtPaso.Text = String.Empty
            txtComando.Text = String.Empty
            griParametros.DataSource = Nothing
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Mostrar()
        Try
            If griTrabajoSQL.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeTrabajoSQL.Id = griTrabajoSQL.ActiveRow.Cells("Id").Value.ToString
                oeTrabajoSQL = olTrabajoSQL.Obtener(oeTrabajoSQL)
                txtNombre.Text = oeTrabajoSQL.Nombre
                txtDescripcion.Text = oeTrabajoSQL.Descripcion
                txtPaso.Text = oeTrabajoSQL.Paso
                txtComando.Text = oeTrabajoSQL.Comando
                verHabilitado.Checked = oeTrabajoSQL.Habilitado
                ListarEmail()
                MostrarTabs(1, ficTrabajoSQL, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function Guardando() As Boolean
        Try
            'oeAlerta.UsuarioCreacion = gUsuarioSGI.Id
            oeTrabajoSQL.PrefijoID = gs_PrefijoIdSucursal '@0001
            If Not olTrabajoSQL.Guardar(oeTrabajoSQL) Then
                Return False
            End If
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
            MostrarTabs(0, ficTrabajoSQL, 2)
            Consultar(_Activo)
            griTrabajoSQL.Focus()
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("Comando") Then
            txtComando.Focus()
        End If
    End Sub

    Private Sub ListarEmail()
        Try
            With griEmail

                oeEmail.TipoPersonaEmpresa = 1
                oeEmail.Principal = -1

                .ResetDisplayLayout()
                .DataSource = olEmail.Listar(oeEmail)

                .DisplayLayout.Bands(0).Columns.Add("Selec", "Seleccionar")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Selec").Width = 60

                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdPersonaEmpresa").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("TipoPersonaEmpresa").Hidden = True
                .DisplayLayout.Bands(0).Columns("Principal").Hidden = True

                .DisplayLayout.Bands(0).Columns("Nombre").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 250
                .DisplayLayout.Bands(0).Columns("NombreCompleto").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("NombreCompleto").Width = 250

                .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow

            End With
            
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub MostrarEmails(ByVal Lista As ListBox)
        For x As Integer = 0 To Lista.Items.Count - 1
            For Each Fila As UltraGridRow In griEmail.Rows
                If Fila.Cells("Nombre").Value = Lista.Items(x).ToString Then
                    Fila.Cells("Selec").Value = True
                    Exit For
                End If
            Next
        Next
        griEmail.UpdateData()
    End Sub

    Private Sub LlenarEmails(ByVal Lista As ListBox)
        Dim cadena As String = ""
        For x As Integer = 0 To Lista.Items.Count - 1
            cadena = cadena & Lista.Items(x).ToString & ";"
        Next
        If cadena <> "" Then cadena = cadena.Substring(0, cadena.Length - 1)
        griParametros.Rows(griParametros.Rows.Count - 1).Cells("valor").Value = cadena
        griParametros.UpdateData()
    End Sub

#End Region

End Class