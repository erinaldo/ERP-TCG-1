Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

''' <summary>
''' Control creado para generar una lista de Estados Civiles
''' </summary>
''' <remarks></remarks>
Public Class EstadoCivil

#Region "Declaración de variables"

    Public Delegate Sub DatosCambiadosEventHandler(ByVal idEstadoCivil As String, ByVal NombreEstadoCivil As String)
    Public Event DatosCambiados As DatosCambiadosEventHandler

#End Region

#Region "Inicialización del control"

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'ListaDepartamentos()

        cboEstadoCivil.ValueMember = "Id"
        cboEstadoCivil.DisplayMember = "Nombre"

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
            cboEstadoCivil.Value = value
        End Set
    End Property

    ''' <summary>
    ''' Nombre o descripción del estado civil
    ''' </summary>
    ''' <remarks></remarks>
    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
            Dim index As Integer = cboEstadoCivil.FindString(value)
            cboEstadoCivil.SelectedIndex = index
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
            cboEstadoCivil.Clear()
            Dim oeConceptosGenerales As New e_ConceptosGenerales
            Dim olConceptosGenerales As New l_ConceptosGenerales
            oeConceptosGenerales.Activo = True
            oeConceptosGenerales.IdProcesoNegocio = "1CH000000031"
            cboEstadoCivil.DataSource = olConceptosGenerales.Listar(oeConceptosGenerales)
            If cboEstadoCivil.Items.Count > 0 Then cboEstadoCivil.SelectedIndex = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Método para seleccionar un estado civil específico del combo a partir de su id
    ''' </summary>
    ''' <param name="id">Id del Estado Civil</param>
    ''' <remarks></remarks>
    Public Sub Seleccionar(ByVal id As String)
        Try
            If cboEstadoCivil.Items.Count = 0 Then Listar()
            cboEstadoCivil.Value = id
            cboEstadoCivil.Refresh()
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
    Private Sub cboEstadoCivil_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboEstadoCivil.SelectionChanged
        If cboEstadoCivil.ReadOnly = False AndAlso cboEstadoCivil.Items.Count > 0 AndAlso Not String.IsNullOrEmpty(cboEstadoCivil.Value) Then
            Id = cboEstadoCivil.Value
            Nombre = cboEstadoCivil.Text
            RaiseEvent DatosCambiados(Id, Nombre)
        End If
    End Sub

#End Region

End Class
