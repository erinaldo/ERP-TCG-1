<DataContract()> _
Public Class e_Neumatico
    Implements Ie_Neumatico

#Region "Propiedad"

    Private _id As String
    Private _material As String
    Private _codigo As String
    Private _idtipo As String
    Private _tipo As String
    Private _idmedida As String
    Private _medida As String
    Private _idmarca As String
    Private _marca As String
    Private _iddiseño As String
    Private _diseño As String
    Private _fechaingreso As Date
    Private _kilometrajeactual As Double
    Private _costototalsoles As Double
    Private _costototaldolares As Double
    Private _costocascodolares As Double
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _proveedor As String
    Private _cocadaMinima As Double
    Private _tipobanda As String
    Private _dot As String
    Private _tipocambio As Double
    Private _fechaingresoalmacen As Date
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()> _
    Public lstVidaNeumatico As New List(Of e_VidaNeumatico)

    <DataMember()> _
    Public leVidaNeu As New List(Of e_VidaNeumatico)
    <DataMember()> _
    Public leOperacionNeu As New List(Of e_OperacionNeumatico)
    <DataMember()> _
    Public oeDetalleOrdenNeu As New e_DetalleOrdenNeumatico

    Public Event DatoCambiado()

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMaterial() As String
        Get
            Return _material
        End Get
        Set(ByVal value As String)
            _material = value
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipo() As String
        Get
            Return _idtipo
        End Get
        Set(ByVal value As String)
            _idtipo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value

        End Set
    End Property

    <DataMember()> _
    Public Property IdMedida() As String
        Get
            Return _idmedida
        End Get
        Set(ByVal value As String)
            _idmedida = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Medida() As String
        Get
            Return _medida
        End Get
        Set(ByVal value As String)
            _medida = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdMarca() As String
        Get
            Return _idmarca
        End Get
        Set(ByVal value As String)
            _idmarca = value
        End Set
    End Property

    <DataMember()> _
    Public Property Marca() As String
        Get
            Return _marca
        End Get
        Set(ByVal value As String)
            _marca = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdDiseño() As String
        Get
            Return _iddiseño
        End Get
        Set(ByVal value As String)
            _iddiseño = value
        End Set
    End Property

    <DataMember()> _
    Public Property Diseño() As String
        Get
            Return _diseño
        End Get
        Set(ByVal value As String)
            _diseño = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaIngreso() As Date
        Get
            Return _fechaingreso
        End Get
        Set(ByVal value As Date)
            _fechaingreso = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property KilometrajeActual() As Double
        Get
            Return _kilometrajeactual
        End Get
        Set(ByVal value As Double)
            _kilometrajeactual = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CostoTotalSoles() As Double
        Get
            Return _costototalsoles
        End Get
        Set(ByVal value As Double)
            _costototalsoles = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CostoTotalDolares() As Double
        Get
            Return _costototaldolares
        End Get
        Set(ByVal value As Double)
            _costototaldolares = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CostoCascoDolares() As Double
        Get
            Return _costocascodolares
        End Get
        Set(ByVal value As Double)
            _costocascodolares = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CocadaMinima() As Double
        Get
            Return _cocadaMinima
        End Get
        Set(ByVal value As Double)
            _cocadaMinima = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoBanda() As String
        Get
            Return _tipobanda
        End Get
        Set(ByVal value As String)
            _tipobanda = value
        End Set
    End Property

    <DataMember()> _
    Public Property DOT() As String
        Get
            Return _dot
        End Get
        Set(ByVal value As String)
            _dot = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoCambio() As Double
        Get
            Return _tipocambio
        End Get
        Set(ByVal value As Double)
            _tipocambio = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaIngresoAlmacen() As Date
        Get
            Return _fechaingresoalmacen
        End Get
        Set(ByVal value As Date)
            _fechaingresoalmacen = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdProveedor() As String
        Get
            Return _proveedor
        End Get
        Set(ByVal value As String)
            _proveedor = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _material = String.Empty
        _codigo = String.Empty
        _idtipo = String.Empty
        _idmedida = String.Empty
        _medida = String.Empty
        _idmarca = String.Empty
        _marca = String.Empty
        _tipo = String.Empty
        _iddiseño = String.Empty
        _diseño = String.Empty
        _fechaingreso = #1/1/1901#
        _fechaingresoalmacen = #1/1/1901#
        _proveedor = String.Empty
        _costototalsoles = 0
        _costototaldolares = 0
        _costocascodolares = 0
        _cocadaMinima = 0
        _activo = True
        _usuariocreacion = String.Empty
        _tipobanda = String.Empty
        _dot = String.Empty
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdMaterial As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_IdMarca As String _
              , ByVal ls_Marca As String _
              , ByVal ls_IdTipo As String _
              , ByVal ls_Tipo As String _
              , ByVal ls_IdMedida As String _
              , ByVal ls_Medida As String _
              , ByVal ls_IdDiseño As String _
              , ByVal ls_Diseño As String _
              , ByVal ld_FechaIngreso As Date _
              , ByVal ln_KilometrajeActual As Double _
              , ByVal ls_IdProveedor As String _
              , ByVal ln_CostoTotalSoles As Double _
              , ByVal ln_CostoTotalDolares As Double _
              , ByVal ln_CostoCascoDolares As Double _
              , ByVal ln_CocadaMinima As Double _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ls_TipoBanda As String _
              , ByVal ls_DOT As String _
           )
        _id = ls_Id
        _material = ls_IdMaterial
        _codigo = ls_Codigo
        _idtipo = ls_IdTipo
        _tipo = ls_Tipo
        _idmedida = ls_IdMedida
        _medida = ls_Medida
        _idmarca = ls_IdMarca
        _marca = ls_Marca
        _iddiseño = ls_IdDiseño
        _diseño = ls_Diseño
        _fechaingreso = ld_FechaIngreso
        _kilometrajeactual = ln_KilometrajeActual
        _proveedor = ls_IdProveedor
        _costototalsoles = ln_CostoTotalSoles
        _costototaldolares = ln_CostoTotalDolares
        _cocadaMinima = ln_CocadaMinima
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _costocascodolares = ln_CostoCascoDolares
        _tipobanda = ls_TipoBanda
        _dot = ls_DOT
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_Neumatico
    ''' </summary>
    ''' <param name="neumatico"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal neumatico As e_Neumatico) As e_Neumatico Implements Ie_Neumatico.Obtener
        Return neumatico
    End Function

#End Region

End Class
