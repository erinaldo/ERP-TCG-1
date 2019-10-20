Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF

''' <summary>
''' Control creado para generar una lista de centros poblados a partir de su departamento, provincia y distrito
''' </summary>
''' <remarks></remarks>
Public Class CentroPoblado

#Region "Declaración de variables"

    Public Delegate Sub DatosCambiadosEventHandler(ByVal idCentroPoblado As String, ByVal NombreCentroPoblado As String)
    Public Event DatosCambiados As DatosCambiadosEventHandler

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        cboCentroPoblado.ValueMember = "Id"
        cboCentroPoblado.DisplayMember = "Nombre"

    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Listar los CentroPoblados de un lugar específico
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Listar()
        Try
            cboCentroPoblado.Clear()
            Dim oeCentroPoblado As New e_CCPP
            Dim olCentroPoblado As New l_CCPP
            If String.IsNullOrEmpty(CodigoDepartamento) Then CodigoDepartamento = "01"
            If String.IsNullOrEmpty(CodigoProvincia) Then CodigoProvincia = "01"
            If String.IsNullOrEmpty(CodigoDistrito) Then CodigoDistrito = "01"

            With oeCentroPoblado
                .CodigoDepartamento = CodigoDepartamento
                .CodigoProvincia = CodigoProvincia
                .CodigoDistrito = CodigoDistrito
                .Activo = True
                .TipoOperacion = ""
                .Id = ""
            End With

            cboCentroPoblado.DataSource = olCentroPoblado.Listar(oeCentroPoblado)
            cboCentroPoblado.SelectedIndex = 0

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    ''' <summary>
    ''' Método para seleccionar un CentroPoblado específico del combo a partir de su id
    ''' </summary>
    ''' <param name="id">Id del CentroPoblado</param>
    ''' <remarks></remarks>
    Public Sub Seleccionar(ByVal id As String)
        Try
            Listar()
            cboCentroPoblado.Value = id
            cboCentroPoblado.Refresh()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Id del Centro poblado
    ''' </summary>
    ''' <remarks></remarks>
    Private _Id As String
    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
            cboCentroPoblado.Value = value
        End Set
    End Property

    ''' <summary>
    ''' Código del departamento donde se encuentra el centro poblado
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
    ''' Código de la provincia donde se encuentra el centro poblado
    ''' </summary>
    ''' <remarks></remarks>
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
    ''' Código del distrito donde se encuentra el centro poblado
    ''' </summary>
    ''' <remarks></remarks>
    Private _codigoDistrito As String
    Public Property CodigoDistrito() As String
        Get
            Return _codigoDistrito
        End Get
        Set(ByVal value As String)
            _codigoDistrito = value
        End Set
    End Property

    ''' <summary>
    ''' Código del Centro Poblado
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
    ''' Nombre del centro poblado
    ''' </summary>
    ''' <remarks></remarks>
    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
            Dim index As Integer = cboCentroPoblado.FindString(value)
            cboCentroPoblado.SelectedIndex = index
        End Set
    End Property

#End Region

#Region "Eventos"

    Private Sub CentroPoblado_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
        Try
            Listar()
            If Not String.IsNullOrEmpty(Id) Then Seleccionar(Id)
            cboCentroPoblado.Refresh()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Evento que se ejecuta cada vez que se modifica el centro poblado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cboCentroPoblado_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCentroPoblado.SelectionChanged
        If cboCentroPoblado.ReadOnly = False andalso cboCentroPoblado.Items.Count > 0 AndAlso Not String.IsNullOrEmpty(cboCentroPoblado.Value) Then
            Codigo = cboCentroPoblado.Value
            Id = Codigo
            Nombre = cboCentroPoblado.Text
            RaiseEvent DatosCambiados(Id, Nombre)
        End If

    End Sub

#End Region


End Class
