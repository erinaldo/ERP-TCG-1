

' NOTA: si cambia aquí el nombre de clase "e_MaterialesNegociadosDet", también debe actualizar la referencia a "e_MaterialesNegociadosDet" tanto en Web.config como en el archivo .svc asociado.
<DataContract()> _
Public Class e_MaterialesNegociadosDet
    Implements Ie_MaterialesNegociadosDet
    Implements IEquatable(Of e_MaterialesNegociadosDet)

#Region "Propiedad"

    Private _id As String
    Private _seleccion As Boolean
    Private _idmaterialesnegociados As String
    Private _idmaterial As String
    Private _codmaterial As String
    Private _material As String
    Private _idmoneda As String
    Private _precio As Double
    Private _glosa As String
    Private _activo As Boolean
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _vigente As Boolean
    Private _fechafin As Date
    Private _fechainicio As Date

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

    Event DatoCambiado()

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
    Public Property IdMaterialesNegociados() As String
        Get
            Return _idmaterialesnegociados
        End Get
        Set(ByVal value As String)
            _idmaterialesnegociados = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Vigente() As Boolean
        Get
            Return _vigente
        End Get
        Set(ByVal value As Boolean)
            _vigente = value
        End Set
    End Property

    <DataMember()> _
    Public Property Seleccion() As Boolean
        Get
            Return _seleccion
        End Get
        Set(ByVal value As Boolean)
            _seleccion = value
        End Set
    End Property

    <DataMember()> _
   Public Property Material() As String
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
            Return _codmaterial
        End Get
        Set(ByVal value As String)
            _codmaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMaterial() As String
        Get
            Return _idmaterial
        End Get
        Set(ByVal value As String)
            _idmaterial = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdMoneda() As String
        Get
            Return _idmoneda
        End Get
        Set(ByVal value As String)
            _idmoneda = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Precio() As Double
        Get
            Return _precio
        End Get
        Set(ByVal value As Double)
            _precio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInicio() As Date
        Get
            Return _fechainicio
        End Get
        Set(ByVal value As Date)
            _fechainicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaFin() As Date
        Get
            Return _fechafin
        End Get
        Set(ByVal value As Date)
            _fechafin = value
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
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
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
        TipoOperacion = ""
        Id = ""
        FechaCreacion = Date.Parse("01/01/1901")
        FechaInicio = Date.Parse("01/01/1901")
        FechaFin = Date.Parse("01/01/1901")
        Activo = True
    End Sub

    Public Sub New(ByVal lb_Seleccion As Boolean _
              , ByVal ls_Id As String _
              , ByVal ls_IdMaterialesNegociados As String _
              , ByVal ls_IdMaterial As String _
              , ByVal ls_Material As String _
              , ByVal ls_IdMoneda As String _
              , ByVal ln_Precio As Double _
              , ByVal ls_Glosa As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_FechaCreacion As Date _
          , ByVal ls_UsuarioCreacion As String _
          , ByVal ls_Codigo As String _
          , ByVal lb_Vigente As Boolean _
          , ByVal ld_FechaInicio As Date _
          , ByVal ld_FechaFin As Date)
        _seleccion = lb_Seleccion
        _id = ls_Id
        _idmaterialesnegociados = ls_IdMaterialesNegociados
        _idmaterial = ls_IdMaterial
        _material = ls_Material
        _idmoneda = ls_IdMoneda
        _precio = ln_Precio
        _glosa = ls_Glosa
        _activo = lb_Activo
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _codmaterial = ls_Codigo
        _vigente = lb_Vigente
        _fechainicio = ld_FechaInicio
        _fechafin = ld_FechaFin
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal materialesnegociadosdet As e_MaterialesNegociadosDet) As e_MaterialesNegociadosDet Implements Ie_MaterialesNegociadosDet.Obtener
        Return materialesnegociadosdet
    End Function

    Public Overloads Function Equals(ByVal oeMatNegDet As e_MaterialesNegociadosDet) As Boolean Implements IEquatable(Of ISL.EntidadesWCF.e_MaterialesNegociadosDet).Equals
        If Me.IdMaterial.Trim = oeMatNegDet.IdMaterial.Trim Then Return True
        Return False
    End Function

#End Region
    
End Class


