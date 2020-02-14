''' <summary>
''' Clase: Empresa;
''' Autor: Erick Nevado Barrios
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Empresa
    Implements Ie_Empresa
    Implements IEquatable(Of e_Empresa)
    Implements IPropiedadesBasicas

#Region "Definicion de Variables"

    Private _id As String
    Private _codigo As String
    Private _ruc As String
    Private _nombre As String
    Private _abreviatura As String
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _IdDireccionTanqueo As String
    Private _idTipoEmpresa As String
    Private _oeTipoEmpresa As String
    Private _IndAgentePercepcion As Integer
    Private _IndAgenteRetencion As Integer
    Private _IndBuenContribuyente As Integer
    Private _IndCanjeDocumento As Integer
    Private _IndAceptaLetras As Integer
    Private _IndAceptaCheque As Integer
    Private _Morosidad As Decimal
    Private _Credito As Decimal
    Private _IndNivelComercial As Integer
    Private _IndClasificacion As Integer
    Private _IndRelacionada As Integer
    Private _DireccionFiscal As String
    Private _moneda As New e_Moneda

    Private _indCategoriaEmpresaSGI As Integer

    <DataMember()> _
    Public oeClienteProveedor As New e_ClienteProveedor
    <DataMember()> _
    Public leDireccionEP As New List(Of e_Direccion_EmpresaPersona)
    <DataMember()> _
    Public leEmail As New List(Of e_Email)
    <DataMember()> _
    Public leTelefono As New List(Of e_Telefono)
    <DataMember()> _
    Public leTipoPago As New List(Of e_PersonaEmpresa_TipoPago)

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public TipoBusca As Integer
    <DataMember()> _
    Public CargaCompleta As Boolean = False
    Public Event DatoCambiado()
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    <DataMember()> _
    Public leContactos As New List(Of e_Persona)
    <DataMember()>
    Public Property CorreoEnvioXml() As String = ""
    <DataMember()>
    Public Property CorreoEnvioXml2() As String = ""
#End Region

#Region "Constructor"

    Public Sub New()
        _id = ""
        _codigo = ""
        _abreviatura = ""
        _nombre = ""
        _activo = True
        _ruc = ""
        _usuariocreacion = ""
        _IdDireccionTanqueo = ""
        TipoOperacion = ""
        _IndAgentePercepcion = 0
        _IndAgenteRetencion = 0
        _IndBuenContribuyente = 0
        _IndCanjeDocumento = 0
        _IndAceptaLetras = 0
        _IndAceptaCheque = 0
        _Morosidad = 0
        _Credito = 0
        _IndNivelComercial = 0
        _IndClasificacion = 0
        _IndRelacionada = 0
        _DireccionFiscal = String.Empty
        CorreoEnvioXml = ""
        CorreoEnvioXml2 = ""
    End Sub

    Public Sub New(ByVal Id As String, ByVal Codigo As String, _
                   ByVal Ruc As String, ByVal Nombre As String, ByVal Abreviatura As String _
              , ByVal UsuarioCreacion As String, ByVal Activo As Boolean _
              , ByVal IdTipoEmpresa As String, ByVal TipoEmpresa As String _
              , ByVal ls_IdDireccionTanqueo As String, IdMoneda As String, Moneda As String _
              , li_IndAgentePercepcion As Integer _
              , li_IndAgenteRetencion As Integer, li_IndBuenContribuyente As Integer _
              , li_IndCanjeDocumento As Integer, li_IndAceptaLetras As Integer _
              , li_IndAceptaCheque As Integer, ld_Morosidad As Decimal, ld_Credito As Decimal _
              , li_IndNivelComercial As Integer, li_IndClasificacion As Integer, li_IndRelacionada As Integer, ls_DireccionFiscal As String)
        _id = Id
        _codigo = Codigo
        _ruc = Ruc
        _nombre = Nombre
        _abreviatura = Abreviatura
        _usuariocreacion = UsuarioCreacion
        _activo = Activo
        _idTipoEmpresa = IdTipoEmpresa
        _oeTipoEmpresa = TipoEmpresa
        _moneda.Id = IdMoneda
        _moneda.Nombre = Moneda
        _IdDireccionTanqueo = ls_IdDireccionTanqueo
        _IndAgentePercepcion = li_IndAgentePercepcion
        _IndAgenteRetencion = li_IndAgenteRetencion
        _IndBuenContribuyente = li_IndBuenContribuyente
        _IndCanjeDocumento = li_IndCanjeDocumento
        _IndAceptaLetras = li_IndAceptaLetras
        _IndAceptaCheque = li_IndAceptaCheque
        _Morosidad = ld_Morosidad
        _Credito = ld_Credito
        _IndNivelComercial = li_IndNivelComercial
        _IndClasificacion = li_IndClasificacion
        _IndRelacionada = li_IndRelacionada
        _DireccionFiscal = ls_DireccionFiscal

    End Sub

#End Region

#Region "Propiedad"

    <DataMember()> _
    Public Property Id() As String Implements IPropiedadesBasicas.Id
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoEmpresa() As String
        Get
            Return _idTipoEmpresa
        End Get
        Set(ByVal value As String)
            _idTipoEmpresa = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoEmpresa() As String
        Get
            Return _oeTipoEmpresa
        End Get
        Set(ByVal value As String)
            _oeTipoEmpresa = value
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String Implements IPropiedadesBasicas.Codigo
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ruc() As String
        Get
            Return _ruc
        End Get
        Set(ByVal value As String)
            _ruc = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String Implements IPropiedadesBasicas.Nombre
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Abreviatura() As String
        Get
            Return _abreviatura
        End Get
        Set(ByVal value As String)
            _abreviatura = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdDireccionTanqueo() As String
        Get
            Return _IdDireccionTanqueo
        End Get
        Set(ByVal value As String)
            _IdDireccionTanqueo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean Implements IPropiedadesBasicas.Activo
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
        End Set
    End Property

    <DataMember()> _
    Public Property IndAgentePercepcion() As Integer
        Get
            Return _IndAgentePercepcion
        End Get
        Set(value As Integer)
            _IndAgentePercepcion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndAgenteRetencion() As Integer
        Get
            Return _IndAgenteRetencion
        End Get
        Set(value As Integer)
            _IndAgenteRetencion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndBuenContribuyente() As Integer
        Get
            Return _IndBuenContribuyente
        End Get
        Set(value As Integer)
            _IndBuenContribuyente = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndCanjeDocumento() As Integer
        Get
            Return _IndCanjeDocumento
        End Get
        Set(value As Integer)
            _IndCanjeDocumento = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndAceptaLetras() As Integer
        Get
            Return _IndAceptaLetras
        End Get
        Set(value As Integer)
            _IndAceptaLetras = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndAceptaCheque() As Integer
        Get
            Return _IndAceptaCheque
        End Get
        Set(value As Integer)
            _IndAceptaCheque = value
        End Set
    End Property

    <DataMember()> _
    Public Property Morosidad() As Decimal
        Get
            Return _Morosidad
        End Get
        Set(value As Decimal)
            _Morosidad = value
        End Set
    End Property

    <DataMember()> _
    Public Property Credito() As Decimal
        Get
            Return _Credito
        End Get
        Set(value As Decimal)
            _Credito = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndNivelComercial() As Integer
        Get
            Return _IndNivelComercial
        End Get
        Set(value As Integer)
            _IndNivelComercial = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndClasificacion() As Integer
        Get
            Return _IndClasificacion
        End Get
        Set(value As Integer)
            _IndClasificacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMoneda() As String
        Get
            Return _moneda.Id
        End Get
        Set(ByVal value As String)
            _moneda.Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Moneda() As String
        Get
            Return _moneda.Nombre
        End Get
        Set(ByVal value As String)
            _moneda.Nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndCategoriaEmpresaSGI() As Integer
        Get
            Return _indCategoriaEmpresaSGI
        End Get
        Set(ByVal value As Integer)
            _indCategoriaEmpresaSGI = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndRelacionada() As Integer
        Get
            Return _IndRelacionada
        End Get
        Set(ByVal value As Integer)
            _IndRelacionada = value
        End Set
    End Property

    <DataMember()> _
    Public Property DireccionFiscal() As String
        Get
            Return _DireccionFiscal
        End Get
        Set(ByVal value As String)
            _DireccionFiscal = value
        End Set
    End Property

#End Region

    Public Overloads Function Equals(ByVal oeEmpresa As e_Empresa) As Boolean Implements System.IEquatable(Of e_Empresa).Equals

        Select Case oeEmpresa.TipoBusca
            Case 1 : If Me.Id = oeEmpresa.Id Then Return True
            Case 2 : If Me.Abreviatura.Trim = oeEmpresa.Abreviatura.Trim Then Return True
            Case 3 : If Me.Nombre = oeEmpresa.Nombre Then Return True
        End Select
        Return False
    End Function

    Public Function Obtener(ByVal empresa As e_Empresa) As e_Empresa Implements Ie_Empresa.Obtener
        Return empresa
    End Function

End Class


