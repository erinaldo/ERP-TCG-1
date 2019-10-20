Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF
''' <summary>
''' Control creado para seleccionar los tipos de documentos asociados a un proceso específico
''' </summary>
''' <remarks></remarks>
Public Class TipoDocumento

    Public Delegate Sub DatosCambiadosEventHandler(ByVal idTipoDocumento As String, ByVal TipoDocumento As String)
    Public Event DatosCambiados As DatosCambiadosEventHandler

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        cboTipoDocumento.ValueMember = "idTipoDocumento"
        cboTipoDocumento.DisplayMember = "TipoDocumento"

    End Sub

#Region "Propiedades"

    Private _idProceso As String
    Public Property IdProceso() As String
        Get
            Return _idProceso
        End Get
        Set(ByVal value As String)
            _idProceso = value
            Listar(value)
        End Set
    End Property

    Private _proceso As String
    Public Property Proceso() As String
        Get
            Return _proceso
        End Get
        Set(ByVal value As String)
            _proceso = value
        End Set
    End Property

    Private _idTipoDocumento As String
    Public Property IdTipoDocumento() As String
        Get
            Return _idTipoDocumento
        End Get
        Set(ByVal value As String)
            _idTipoDocumento = value
        End Set
    End Property

    Private _tipoDocumento As String
    Public Property TipoDocumento() As String
        Get
            Return _tipoDocumento
        End Get
        Set(ByVal value As String)
            _tipoDocumento = value
            Dim index As Integer = cboTipoDocumento.FindString(value)
            cboTipoDocumento.SelectedIndex = index
        End Set
    End Property
#End Region

#Region "Métodos"

    ''' <summary>
    ''' Actualiza la lista de departamentos
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Listar(Optional ByVal idProceso As String = "1CH000000001")
        Try
            cboTipoDocumento.Clear()
            Dim oeProcesoTipoDocumento As New e_ProcesoTipoDocumento
            Dim oltipoProcesoDocumento As New l_ProcesoTipoDocumento
            oeProcesoTipoDocumento.Activo = True
            oeProcesoTipoDocumento.IdProceso = idProceso
            cboTipoDocumento.DataSource = oltipoProcesoDocumento.Listar(oeProcesoTipoDocumento)
            If cboTipoDocumento.Items.Count > 0 Then cboTipoDocumento.SelectedIndex = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Método para seleccionar un documento específico del combo a partir de su id
    ''' </summary>
    ''' <param name="idProceso">Id del proceso asociado al documento</param>
    ''' <param name="idTipoDocumento">Id del documento específico</param>
    ''' <remarks></remarks>
    Public Sub Seleccionar(ByVal idProceso As String, ByVal idTipoDocumento As String)
        Try
            If cboTipoDocumento.Items.Count = 0 Then
                Listar(idProceso)
            End If
            cboTipoDocumento.Value = idTipoDocumento
            cboTipoDocumento.Refresh()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub cboTipoDocumento_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoDocumento.SelectionChanged
        If cboTipoDocumento.ReadOnly = False Then
            If cboTipoDocumento.Items.Count > 0 AndAlso Not String.IsNullOrEmpty(cboTipoDocumento.Value) Then
                IdTipoDocumento = cboTipoDocumento.Value
                TipoDocumento = cboTipoDocumento.Text
                RaiseEvent DatosCambiados(IdTipoDocumento, TipoDocumento)
            End If
        End If
    End Sub

#End Region

End Class
