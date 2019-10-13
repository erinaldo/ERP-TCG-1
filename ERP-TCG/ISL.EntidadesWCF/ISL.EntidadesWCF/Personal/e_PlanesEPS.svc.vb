<DataContract()> _
Public Class e_PlanesEPS
    Implements Ie_PlanesEPS
    Implements IEquatable(Of e_PlanesEPS)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idempresa As String
    Private _empresa As String
    Private _codigo As String
    Private _nombre As String
    Private _descripcion As String
    Private _precio As Double
    Private _adicional1 As Double
    Private _adicional2 As Double
    Private _adicional3 As Double
    Private _adicional4 As Double
    Private _adicional5 As Double
    Private _montomayorhijo As Double
    Private _vigente As Integer
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Equivale As Integer
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
#End Region

#Region "Propiedades"

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
     Public Property IdEmpresa() As String
        Get
            Return _idempresa
        End Get
        Set(ByVal value As String)
            _idempresa = value
        End Set
    End Property

    <DataMember()> _
    Public Property Empresa() As String
        Get
            Return _empresa
        End Get
        Set(ByVal value As String)
            _empresa = value
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
     Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    <DataMember()> _
     Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    <DataMember()> _
     Public Property Precio() As Double
        Get
            Return _precio
        End Get
        Set(ByVal value As Double)
            _precio = value
        End Set
    End Property

    <DataMember()> _
    Public Property Adicional1() As Double
        Get
            Return _adicional1
        End Get
        Set(ByVal value As Double)
            _adicional1 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Adicional2() As Double
        Get
            Return _adicional2
        End Get
        Set(ByVal value As Double)
            _adicional2 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Adicional3() As Double
        Get
            Return _adicional3
        End Get
        Set(ByVal value As Double)
            _adicional3 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Adicional4() As Double
        Get
            Return _adicional4
        End Get
        Set(ByVal value As Double)
            _adicional4 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Adicional5() As Double
        Get
            Return _adicional5
        End Get
        Set(ByVal value As Double)
            _adicional5 = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoHijoMayor() As Double
        Get
            Return _montomayorhijo
        End Get
        Set(ByVal value As Double)
            _montomayorhijo = value
        End Set
    End Property

    <DataMember()> _
     Public Property Vigente() As Integer
        Get
            Return _vigente
        End Get
        Set(ByVal value As Integer)
            _vigente = value
        End Set
    End Property

    <DataMember()> _
     Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
        End Set
    End Property

    <DataMember()> _
     Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
        End Set
    End Property

    <DataMember()> _
     Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _idempresa = String.Empty
        _empresa = String.Empty
        _codigo = String.Empty
        _nombre = String.Empty
        _descripcion = String.Empty
        _precio = 0
        _adicional1 = 0
        _adicional2 = 0
        _adicional3 = 0
        _adicional4 = 0
        _adicional5 = 0
        _montomayorhijo = 0
        _vigente = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdEmpresa As String _
              , ByVal ls_Empresa As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_Descripcion As String _
              , ByVal ln_Precio As Double _
              , ByVal ln_Adicional1 As Double _
              , ByVal ln_Adicional2 As Double _
              , ByVal ln_Adicional3 As Double _
              , ByVal ln_Adicional4 As Double _
              , ByVal ln_Adicional5 As Double _
              , ByVal ln_MontoHijoMayor As Double _
              , ByVal ln_Vigente As Integer _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idempresa = ls_IdEmpresa
        _empresa = ls_Empresa
        _codigo = ls_Codigo
        _nombre = ls_Nombre
        _descripcion = ls_Descripcion
        _precio = ln_Precio
        _adicional1 = ln_Adicional1
        _adicional2 = ln_Adicional2
        _adicional3 = ln_Adicional3
        _adicional4 = ln_Adicional4
        _adicional5 = ln_Adicional5
        _montomayorhijo = ln_MontoHijoMayor
        _vigente = ln_Vigente
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function obtener(oePlanesEPS As e_PlanesEPS) As e_PlanesEPS Implements Ie_PlanesEPS.obtener
        Return oePlanesEPS
    End Function

    Public Overloads Function Equals(ByVal oePES As e_PlanesEPS) As Boolean Implements System.IEquatable(Of e_PlanesEPS).Equals
        Select Case oePES.Equivale
            Case 1 : If Me.Id = oePES.Id Then Return True
            Case 2 : If Me.Codigo = oePES.Codigo Then Return True
            Case 3 : If Me.Nombre = oePES.Nombre Then Return True
        End Select
        Return False
    End Function

#End Region

End Class
