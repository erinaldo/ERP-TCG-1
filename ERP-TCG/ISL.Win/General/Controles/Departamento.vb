Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF

''' <summary>
''' Control creado para generar una lista de departamentos del Perú
''' </summary>
''' <remarks></remarks>
Public Class Departamento

#Region "Declaración de variables"

    Public Delegate Sub DatosCambiadosEventHandler(ByVal idDepartamento As String, ByVal NombreDepartamento As String)
    Public Event DatosCambiados As DatosCambiadosEventHandler

#End Region

#Region "Inicialización del control"

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'ListaDepartamentos()

        cboDepartamento.ValueMember = "Id"
        cboDepartamento.DisplayMember = "Nombre"

    End Sub

#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Id del Departamento
    ''' </summary>
    ''' <remarks></remarks>
    Private _Id As String
    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
            cboDepartamento.Value = value
        End Set
    End Property

    ''' <summary>
    ''' Código del Departamento
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
    ''' Nombre del departamento
    ''' </summary>
    ''' <remarks></remarks>
    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
            Dim index As Integer = cboDepartamento.FindString(value)
            cboDepartamento.SelectedIndex = index
        End Set
    End Property

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Actualiza la lista de departamentos
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Listar()
        Try
            cboDepartamento.Clear()
            Dim oeDepartamento As New e_Departamento
            Dim olDepartamento As New l_Departamento
            oeDepartamento.Activo = True
            cboDepartamento.DataSource = olDepartamento.Listar(oeDepartamento)
            If cboDepartamento.Items.Count > 0 Then cboDepartamento.SelectedIndex = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Método para seleccionar un departamento específica del combo a partir de su id
    ''' </summary>
    ''' <param name="id">Id del Departamento</param>
    ''' <remarks></remarks>
    Public Sub Seleccionar(ByVal id As String)
        Try
            If cboDepartamento.Items.Count = 0 Then Listar()
            cboDepartamento.Value = id.Substring(0, 2) + "0000"
            cboDepartamento.Refresh()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Evento que se ejecuta cada vez que se modifica el departamento
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cboDepartamento_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDepartamento.SelectionChanged
        If cboDepartamento.ReadOnly = False AndAlso cboDepartamento.Items.Count > 0 AndAlso Not String.IsNullOrEmpty(cboDepartamento.Value) Then
            Codigo = cboDepartamento.Value
            Id = Codigo.Substring(0, 2) + "0000"
            Nombre = cboDepartamento.Text
            RaiseEvent DatosCambiados(Id, Nombre)
        End If
    End Sub

#End Region

End Class
