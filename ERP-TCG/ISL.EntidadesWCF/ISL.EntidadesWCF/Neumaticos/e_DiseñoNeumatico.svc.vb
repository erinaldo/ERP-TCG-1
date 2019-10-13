<DataContract()> _
Public Class e_DiseñoNeumatico
    Implements Ie_DiseñoNeumatico

#Region "Constructor"

    Public Sub New()
        Activo = True
        _cocadaminima = 0
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdMarca As String _
              , ByVal ls_Marca As String _
              , ByVal ls_IdMedidaNeumatico As String _
              , ByVal ls_MedidaNeumatico As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_Codigo As String _
              , ByVal ln_NroLonas As Integer _
              , ByVal ln_Ribete1 As Double _
              , ByVal ln_Ribete2 As Double _
              , ByVal ln_Ribete3 As Double _
              , ByVal ln_Ribete4 As Double _
              , ByVal ln_Cocada As Double _
              , ByVal ln_CocadaMinima As Double _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
           )
        _id = ls_Id
        _idmarca = ls_IdMarca
        _marca = ls_Marca
        _idmedida = ls_IdMedidaNeumatico
        _medida = ls_MedidaNeumatico
        _nombre = ls_Nombre
        _codigo = ls_Codigo
        _nrolonas = ln_NroLonas
        _ribete1 = ln_Ribete1
        _ribete2 = ln_Ribete2
        _ribete3 = ln_Ribete3
        _ribete4 = ln_Ribete4
        _cocada = ln_Cocada
        _cocadaminima = ln_CocadaMinima
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
    End Sub

#End Region

#Region "Propiedad"

    Private _id As String
    Private _marca As String
    Private _idmarca As String
    Private _idmedida As String
    Private _medida As String
    Private _nombre As String
    Private _codigo As String
    Private _nrolonas As Integer
    Private _ribete1 As Double
    Private _ribete2 As Double
    Private _ribete3 As Double
    Private _ribete4 As Double
    Private _cocada As Double
    Private _cocadaminima As Double
    Private _activo As Boolean
    Private _usuariocreacion As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
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
    Public Property IdMarca() As String
        Get
            Return _idmarca
        End Get
        Set(ByVal value As String)
            _idmarca = value
            RaiseEvent DatoCambiado()
        End Set
    End Property


    <DataMember()> _
    Public Property Marca() As String
        Get
            Return _marca
        End Get
        Set(ByVal value As String)
            _marca = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdMedidaNeumatico() As String
        Get
            Return _idmedida
        End Get
        Set(ByVal value As String)
            _idmedida = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property MedidaNeumatico() As String
        Get
            Return _medida
        End Get
        Set(ByVal value As String)
            _medida = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroLonas() As Integer
        Get
            Return _nrolonas
        End Get
        Set(ByVal value As Integer)
            _nrolonas = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ribete1() As Double
        Get
            Return _ribete1
        End Get
        Set(ByVal value As Double)
            _ribete1 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ribete2() As Double
        Get
            Return _ribete2
        End Get
        Set(ByVal value As Double)
            _ribete2 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ribete3() As Double
        Get
            Return _ribete3
        End Get
        Set(ByVal value As Double)
            _ribete3 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ribete4() As Double
        Get
            Return _ribete4
        End Get
        Set(ByVal value As Double)
            _ribete4 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Cocada() As Double
        Get
            Return _cocada
        End Get
        Set(ByVal value As Double)
            _cocada = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
Public Property CocadaMinima() As Double
        Get
            Return _cocadaminima
        End Get
        Set(ByVal value As Double)
            _cocadaminima = value
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

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_DiseñoNeumatico
    ''' </summary>
    ''' <param name="diseñoNeumatico"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal diseñoNeumatico As e_DiseñoNeumatico) As e_DiseñoNeumatico Implements Ie_DiseñoNeumatico.Obtener
        Return diseñoNeumatico
    End Function

#End Region

End Class
