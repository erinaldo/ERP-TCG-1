Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF

''' <summary>
''' Control creado para obtener la lista de distritos de un departamento y provincia específicos
''' </summary>
''' <remarks></remarks>
Public Class Distrito

#Region "Declaración de variables"

    Public Delegate Sub DatosCambiadosEventHandler(ByVal idDistrito As String, ByVal NombreDistrito As String)
    Public Event DatosCambiados As DatosCambiadosEventHandler

#End Region

#Region "Inicialización del control"

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        cboDistrito.ValueMember = "Id"
        cboDistrito.DisplayMember = "Nombre"

    End Sub

#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Id de la Provincia
    ''' </summary>
    ''' <remarks></remarks>
    Private _Id As String
    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
            cboDistrito.Value = value
        End Set
    End Property

    Private _codigoDepartamento As String
    Public Property CodigoDepartamento() As String
        Get
            Return _codigoDepartamento
        End Get
        Set(ByVal value As String)
            _codigoDepartamento = value
        End Set
    End Property

    Private _codigoProvincia As String
    Public Property CodigoProvincia() As String
        Get
            Return _codigoProvincia
        End Get
        Set(ByVal value As String)
            _codigoProvincia = value
        End Set
    End Property

    ''' <summary>
    ''' Código del distrito
    ''' </summary>
    ''' <remarks></remarks>
    Private _codigo As String
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    ''' <summary>
    ''' Nombre del distrito
    ''' </summary>
    ''' <remarks></remarks>
    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
            Dim index As Integer = cboDistrito.FindString(value)
            cboDistrito.SelectedIndex = index
        End Set
    End Property

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Listar los distritos de un lugar específico
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Listar()
        Try
            cboDistrito.Clear()
            Dim oeDistrito As New e_Distrito
            Dim olDistrito As New l_Distrito
            If String.IsNullOrEmpty(CodigoDepartamento) Then CodigoDepartamento = "01"
            If String.IsNullOrEmpty(CodigoProvincia) Then CodigoProvincia = "01"
            oeDistrito.CodigoDepartamento = CodigoDepartamento
            oeDistrito.CodigoProvincia = CodigoProvincia
            oeDistrito.Activo = True
            cboDistrito.DataSource = olDistrito.Listar(oeDistrito)
            cboDistrito.SelectedIndex = 0
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    ''' <summary>
    ''' Método para seleccionar un distrito específico del combo a partir de su id
    ''' </summary>
    ''' <param name="id">Id del Distrito</param>
    ''' <remarks></remarks>
    Public Sub Seleccionar(ByVal id As String)
        Try
            If cboDistrito.Items.Count = 0 Then Listar()
            cboDistrito.Value = id.Substring(0, 6)
            cboDistrito.Refresh()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub cboDistrito_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDistrito.SelectionChanged
        If cboDistrito.ReadOnly = False Then
            If cboDistrito.Items.Count > 0 AndAlso Not String.IsNullOrEmpty(cboDistrito.Value) Then
                Codigo = cboDistrito.Value
                Id = Codigo
                Nombre = cboDistrito.Text
                RaiseEvent DatosCambiados(Id, Nombre)
            End If
        End If
    End Sub

    Private Sub Distrito_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
        Try
            Listar()
            If Not String.IsNullOrEmpty(Id) Then
                Seleccionar(Id)
            End If
            cboDistrito.Refresh()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class
