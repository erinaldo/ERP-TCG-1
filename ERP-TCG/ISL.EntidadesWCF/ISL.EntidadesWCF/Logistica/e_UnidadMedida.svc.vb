<DataContract()> _
Public Class e_UnidadMedida
    Implements Ie_UnidadMedida

#Region "Declaración de variables"
    Private _Id As String
    Private _Codigo As String = String.Empty
    Private _Nombre As String
    Private _Abreviatura As String = String.Empty
    Private _Activo As Boolean
    Private _Factor As Decimal
    Private _Base As Boolean
    Private _idTipoUnidadMedida As String
    Private _TipoUnidadMedida As String
    Private _Asignado As Boolean
    Private _Modificado As Boolean = False
    Private _TipoOperacion As String
    <DataMember()>
    Public PrefijoID As String = ""
#End Region

#Region "Constructor"
    Sub New()

    End Sub

    Sub New(ByVal Id As String, _
            ByVal Codigo As String, _
            ByVal Nombre As String, _
            ByVal Abreviatura As String, _
            ByVal Activo As Boolean, _
            ByVal IdTipoUnidadMedida As String, _
            ByVal Factor As Decimal, _
            ByVal Base As Boolean, _
            ByVal NombreTipoUnidadMedida As String)
        _Id = Id
        _Codigo = Codigo
        _Nombre = Nombre
        _Abreviatura = Abreviatura
        _Activo = Activo
        _Factor = Factor
        _Base = Base
        _idTipoUnidadMedida = IdTipoUnidadMedida
        _TipoUnidadMedida = NombreTipoUnidadMedida
    End Sub
#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property Abreviatura() As String
        Get
            Return _Abreviatura
        End Get
        Set(ByVal value As String)
            _Abreviatura = value
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Factor() As Decimal
        Get
            Return _Factor
        End Get
        Set(ByVal value As Decimal)
            _Factor = value
        End Set
    End Property

    <DataMember()> _
    Public Property Base() As Boolean
        Get
            Return _Base
        End Get
        Set(ByVal value As Boolean)
            _Base = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoUnidadMedida() As String
        Get
            Return _idTipoUnidadMedida
        End Get
        Set(ByVal value As String)
            _idTipoUnidadMedida = value
        End Set
    End Property

    <DataMember()> _
    Public Property NombreTipoUnidadMedida() As String
        Get
            Return _TipoUnidadMedida
        End Get
        Set(ByVal value As String)
            _TipoUnidadMedida = value
        End Set
    End Property

    <DataMember()> _
    Public Property Asignado() As Boolean
        Get
            Return _Asignado
        End Get
        Set(ByVal value As Boolean)
            _Asignado = value
        End Set
    End Property


    <DataMember()> _
    Public Property Modificado() As Boolean
        Get
            Return _Modificado
        End Get
        Set(ByVal value As Boolean)
            _Modificado = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoOperacion() As String
        Get
            Return _TipoOperacion
        End Get
        Set(ByVal value As String)
            _TipoOperacion = value
        End Set
    End Property

#End Region

    Public Function Obtener(ByVal unidadMedida As e_UnidadMedida) As e_UnidadMedida Implements Ie_UnidadMedida.Obtener
        Return unidadMedida
    End Function

End Class
