Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

''' <summary>
''' Control creado para generar una lista de Relaciones Laborales con la empresa
''' </summary>
''' <remarks></remarks>
Public Class TipoRelacionLaboral

#Region "Declaración de variables"

    Public Delegate Sub DatosCambiadosEventHandler(ByVal idTipoRelacionLaboral As String, ByVal NombreTipoRelacionLaboral As String)
    Public Event DatosCambiados As DatosCambiadosEventHandler

#End Region

#Region "Inicialización del control"

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'ListaDepartamentos()

        cboTipoRelacionLaboral.ValueMember = "Id"
        cboTipoRelacionLaboral.DisplayMember = "Nombre"

    End Sub

#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Id del Estado Civil
    ''' </summary>
    ''' <remarks></remarks>
    Private _id As String
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
            cboTipoRelacionLaboral.Value = value
        End Set
    End Property

    ''' <summary>
    ''' Nombre o descripción de la relación laboral
    ''' </summary>
    ''' <remarks></remarks>
    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
            Dim index As Integer = cboTipoRelacionLaboral.FindString(value)
            cboTipoRelacionLaboral.SelectedIndex = index
        End Set
    End Property

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Actualiza la lista de Estados Civiles
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Listar()
        Try
            cboTipoRelacionLaboral.Clear()
            Dim oeConceptosGenerales As New e_ConceptosGenerales
            Dim olConceptosGenerales As New l_ConceptosGenerales
            oeConceptosGenerales.Activo = True
            oeConceptosGenerales.IdProcesoNegocio = "1SI000000002"
            cboTipoRelacionLaboral.DataSource = olConceptosGenerales.Listar(oeConceptosGenerales)
            If cboTipoRelacionLaboral.Items.Count > 0 Then cboTipoRelacionLaboral.SelectedIndex = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Método para seleccionar un estado civil específico del combo a partir de su id
    ''' </summary>
    ''' <param name="id">Id de la relación laboral</param>
    ''' <remarks></remarks>
    Public Sub Seleccionar(ByVal id As String)
        Try
            If cboTipoRelacionLaboral.Items.Count = 0 Then Listar()
            cboTipoRelacionLaboral.Value = id
            cboTipoRelacionLaboral.Refresh()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Evento que se ejecuta cada vez que se modifica el Estado Civil
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cboTipoRelacionLaboral_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipoRelacionLaboral.SelectionChanged
        If cboTipoRelacionLaboral.ReadOnly = False AndAlso cboTipoRelacionLaboral.Items.Count > 0 AndAlso Not String.IsNullOrEmpty(cboTipoRelacionLaboral.Value) Then
            Id = cboTipoRelacionLaboral.Value
            Nombre = cboTipoRelacionLaboral.Text
            RaiseEvent DatosCambiados(Id, Nombre)
        End If
    End Sub

#End Region

End Class
