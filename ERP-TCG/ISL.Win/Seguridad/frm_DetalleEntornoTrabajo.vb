'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Infragistics.Win

Public Class frm_DetalleEntornoTrabajo

    Inherits frm_MenuPadre

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_DetalleEntornoTrabajo = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_DetalleEntornoTrabajo()
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaracion de Variables"

    Dim oeEntornoTrabajo As New e_EntornoTrabajo
    Dim olEntornoTrabajo As New l_EntornoTrabajo

    Dim leDetalleEntorno As New List(Of e_DetalleEntornoTrabajo)
    Dim leTemp As New List(Of e_DetalleEntornoTrabajo)
    Dim idDe As String = ""

#End Region

#Region "Botones"

    Public Overrides Sub Guardar()
        Try
            Dim olDetalleEntorno As New l_DetalleEntornoTrabajo
            If olDetalleEntorno.GuardarLista(leDetalleEntorno) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
                Me.Close()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        Me.Close()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_DetalleEntornoTrabajo_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
    End Sub

    Private Sub frm_DetalleEntornoTrabajo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        instancia = Nothing
    End Sub

    Private Sub frm_DetalleEntornoTrabajo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        'AsociarMenu()
        Listar(True)
        Mostrar()
    End Sub

    Private Sub griDetalleEntorno_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griDetalleEntorno.CellChange
        Try
            With griDetalleEntorno
                If .ActiveRow.Cells("Selec").Activated Then
                    Dim oeDetalleEntorno As New e_DetalleEntornoTrabajo
                    oeDetalleEntorno.PrefijoID = gs_PrefijoIdSucursal '@0001
                    oeDetalleEntorno.IdEntornoTrabajo = .ActiveRow.Cells("Id").Value
                    If Not leDetalleEntorno.Contains(oeDetalleEntorno) Then
                        oeDetalleEntorno.IdUsuario = gUsuarioSGI.Id
                        leDetalleEntorno.Add(oeDetalleEntorno)
                    Else
                        oeDetalleEntorno = leDetalleEntorno.Item(leDetalleEntorno.IndexOf(oeDetalleEntorno))
                        oeDetalleEntorno.Activo = Not .ActiveRow.Cells("Selec").Value
                    End If
                End If
            End With

        Catch ex As Exception
            Throw ex
        End Try
        griDetalleEntorno.UpdateData()
    End Sub

#End Region

#Region "Metodos"

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            oeEntornoTrabajo = New e_EntornoTrabajo
            With griDetalleEntorno
                oeEntornoTrabajo.Activo = Activo
                .DataSource = olEntornoTrabajo.Listar(oeEntornoTrabajo)
                .DisplayLayout.Bands(0).Columns.Add("Selec", "Seleccionar")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True

                .DisplayLayout.Bands(0).Columns("Codigo").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("Nombre").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit

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
        griDetalleEntorno.Focus()
    End Sub

    Public Sub Mostrar()

        Try
            Dim oeDetalleEstado As New e_DetalleEntornoTrabajo
            Dim olDetalleEstado As New l_DetalleEntornoTrabajo

            oeDetalleEstado.IdUsuario = gUsuarioSGI.Id

            leDetalleEntorno = olDetalleEstado.Listar(oeDetalleEstado)

            If leDetalleEntorno.Count > 0 Then
                For Each oe As e_DetalleEntornoTrabajo In leDetalleEntorno
                    oe.PrefijoID = gs_PrefijoIdSucursal '@0001
                    For Each Fila As UltraWinGrid.UltraGridRow In griDetalleEntorno.Rows
                        If Fila.Cells("Id").Value = oe.IdEntornoTrabajo And oe.Activo Then
                            Fila.Cells("Selec").Value = True
                            Exit For
                        End If
                    Next
                Next
            End If
            griDetalleEntorno.UpdateData()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    'Public Sub Llenar()
    '    Try
    '        leTemp = New List(Of e_DetalleEntornoTrabajo)
    '        For Each Fila As UltraWinGrid.UltraGridRow In griDetalleEntorno.Rows
    '            If Fila.Cells("Selec").Value Then
    '                Dim oeDetalleEntorno As New e_DetalleEntornoTrabajo
    '                'idDe = Fila.Cells("Id").Value
    '                'Dim oe As e_DetalleEntornoTrabajo = leDetalleEstado.Find(AddressOf BuscaId)
    '                'If oe IsNot Nothing Then oeDetalleEntorno.Id = oe.Id
    '                oeDetalleEntorno.IdEntornoTrabajo = Fila.Cells("Id").Value
    '                oeDetalleEntorno.IdUsuario = gUsuarioSGI.Id
    '                leTemp.Add(oeDetalleEntorno)
    '                oeDetalleEntorno = Nothing
    '            End If
    '        Next
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Function BuscaId(ByVal oeDETemp As e_DetalleEntornoTrabajo) As Boolean
    '    Try
    '        Dim band As Boolean = False
    '        If oeDETemp.IdEntornoTrabajo = idDE And oeDETemp.IdUsuario = gUsuarioSGI.Id Then
    '            band = True
    '        End If
    '        Return band
    '    Catch ex As Exception
    'mensajeEmergente.Problema(ex.Message)
    '    End Try

    'End Function

#End Region

    'Private Sub griDetalleEntorno_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griDetalleEntorno.InitializeLayout
    '    agrDetalleEntorno.Text = "Total de entornos de trabajo: " & e.Layout.Rows.Count
    'End Sub

End Class