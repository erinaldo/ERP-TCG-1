Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

''' <summary>
''' Control creado para obtener la lista de provincias de un departamento específico
''' </summary>
''' <remarks></remarks>
Public Class Provincia

#Region "Declaración de variables"

    Public Delegate Sub DatosCambiadosEventHandler(ByVal idProvincia As String, ByVal NombreProvincia As String)
    Public Event DatosCambiados As DatosCambiadosEventHandler

#End Region

#Region "Inicialización del control"

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        cboProvincia.ValueMember = "Id"
        cboProvincia.DisplayMember = "Nombre"

    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Actualiza la lista de provincias a partir del código del departamento
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Listar()
        Try
            cboProvincia.Clear()
            Dim oeProvincia As New e_Provincia
            Dim olProvincia As New l_Provincia
            If String.IsNullOrEmpty(CodigoDepartamento) Then CodigoDepartamento = "01"
            oeProvincia.CodigoDepartamento = CodigoDepartamento
            oeProvincia.Activo = True
            cboProvincia.DataSource = olProvincia.Listar(oeProvincia)
            cboProvincia.SelectedIndex = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Método para seleccionar una provincia específica del combo a partir de su id
    ''' </summary>
    ''' <param name="id">Id de la Provincia</param>
    ''' <remarks></remarks>
    Public Sub Seleccionar(ByVal id As String)
        Try
            If cboProvincia.Items.Count = 0 Then Listar()
            cboProvincia.Value = id.Substring(0, 4) + "00"
            cboProvincia.Refresh()
        Catch ex As Exception
            Throw ex
        End Try
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
            cboProvincia.Value = value
        End Set
    End Property

    ''' <summary>
    ''' Código del departamento al que pertenece la provincia
    ''' </summary>
    ''' <remarks></remarks>
    Private _codigoDepartamento As String
    Public Property CodigoDepartamento() As String
        Get
            Return _codigoDepartamento
        End Get
        Set(ByVal value As String)
            _codigoDepartamento = value
        End Set
    End Property

    ''' <summary>
    ''' Código de la Provincia
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
    ''' Nombre de la Provincia
    ''' </summary>
    ''' <remarks></remarks>
    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
            Dim index As Integer = cboProvincia.FindString(value)
            cboProvincia.SelectedIndex = index
        End Set
    End Property

#End Region

#Region "Eventos"

    Private Sub Provincia_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
        Try
            Listar()
            If Not String.IsNullOrEmpty(Id) Then Seleccionar(Id)
            cboProvincia.Refresh()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Evento que se ejecuta cada vez que se modifica una provincia
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cboProvincia_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProvincia.SelectionChanged

        If cboProvincia.ReadOnly = False andalso cboProvincia.Items.Count > 0 AndAlso Not String.IsNullOrEmpty(cboProvincia.Value) Then
            Codigo = cboProvincia.Value
            Id = Codigo.Substring(0, 4) + "00"
            Nombre = cboProvincia.Text
            RaiseEvent DatosCambiados(Id, Nombre)
        End If

    End Sub

#End Region

    Private Sub cboProvincia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProvincia.ValueChanged

    End Sub
End Class
