

<DataContract()> _
Public Class e_Concepto_Prestamo
    Implements Ie_Concepto_Prestamo
    Implements IEquatable(Of e_Concepto_Prestamo)

#Region "Declaracion de Variables"

    Private _id As String
    Private _codigo As String
    Private _nombre As String
    Private _tipo As String
    Private _idconceptopadre As String
    Private _idarea As String
    Private _NombreArea As String
    Private _activo As Boolean
    Private _fechacreacion As Date
    Private _usuariocreacion As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

    <DataMember()> _
    Public leConceptoSancion As List(Of e_Concepto_Prestamo)

    Public Event DatoCambiado()

#End Region

#Region "Propiedad"

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
    Public Property Tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdConceptoPadre() As String
        Get
            Return _idconceptopadre
        End Get
        Set(ByVal value As String)
            _idconceptopadre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdArea() As String
        Get
            Return _idarea
        End Get
        Set(ByVal value As String)
            _idarea = value
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

    <DataMember()> _
    Public Property NombreArea() As String
        Get
            Return _NombreArea
        End Get
        Set(ByVal value As String)
            _NombreArea = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _codigo = String.Empty
        _nombre = String.Empty
        _tipo = String.Empty
        _idconceptopadre = String.Empty
        _idarea = String.Empty
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _activo = True
        TipoOperacion = String.Empty
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_Tipo As String _
              , ByVal ls_IdConceptoPadre As String _
              , ByVal ls_IdArea As String _
              , ByVal ls_NombreArea As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
           )
        _id = ls_Id
        _codigo = ls_Codigo
        _nombre = ls_Nombre
        _tipo = ls_Tipo
        _idconceptopadre = ls_IdConceptoPadre
        _idarea = ls_IdArea
        _NombreArea = ls_NombreArea
        _activo = lb_Activo
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
    End Sub

#End Region

#Region "Métodos"

    Public Overloads Function Equals(ByVal oeConcepPrest As e_Concepto_Prestamo) _
 As Boolean Implements IEquatable(Of ISL.EntidadesWCF.e_Concepto_Prestamo).Equals
        If Me.Id = oeConcepPrest.Id Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Obtener(ByVal concepto_prestamo As e_Concepto_Prestamo) As e_Concepto_Prestamo Implements Ie_Concepto_Prestamo.Obtener
        Return concepto_prestamo
    End Function

#End Region

End Class
