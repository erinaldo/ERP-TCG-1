


<DataContract()> _
Public Class e_GrupoSancion
    Implements Ie_GrupoSancion

#Region "Declaracion de variables"

    Private _id As String
    Private _codigo As String
    Private _idarea As String
    Private _area As String
    Private _fecha As Date
    Private _glosa As String
    Private _monto As Double
    Private _activo As Boolean
    Private _idestado As String
    Private _estado As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _Tipo As Integer

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public leDetalle As New List(Of e_Sancion)
    <DataMember()> _
    Public _NombreEstado As String = ""
    <DataMember()> _
    Public _CadenaId As String = ""
    <DataMember()> _
    Public _fecDesde As Date = #1/1/1901#
    <DataMember()> _
    Public _fecHasta As Date = #1/1/1901#

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
    Public Property Area() As String
        Get
            Return _area
        End Get
        Set(ByVal value As String)
            _area = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
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
    Public Property Monto() As Double
        Get
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
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
    Public Property IdEstado() As String
        Get
            Return _idestado
        End Get
        Set(ByVal value As String)
            _idestado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
   Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
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
    Public Property Tipo() As Integer
        Get
            Return _Tipo
        End Get
        Set(ByVal value As Integer)
            _Tipo = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()

        _id = String.Empty
        _codigo = String.Empty
        _idarea = String.Empty
        _area = String.Empty
        _fecha = #1/1/1901#
        _glosa = String.Empty
        _monto = 0
        _activo = True
        _idestado = String.Empty
        _estado = String.Empty
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _Tipo = 0
        TipoOperacion = String.Empty

    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_IdArea As String _
              , ByVal ls_Area As String _
              , ByVal ld_Fecha As Date _
              , ByVal ls_Glosa As String _
              , ByVal ln_Monto As Double _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_IdEstado As String _
              , ByVal ls_Estado As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ln_Tipo As Integer _
           )
        _id = ls_Id
        _codigo = ls_Codigo
        _idarea = ls_IdArea
        _area = ls_Area
        _fecha = ld_Fecha
        _glosa = ls_Glosa
        _monto = ln_Monto
        _activo = lb_Activo
        _idestado = ls_IdEstado
        _estado = ls_Estado
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _Tipo = ln_Tipo
    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal gruposancion As e_GrupoSancion) As e_GrupoSancion Implements Ie_GrupoSancion.Obtener
        Return gruposancion
    End Function

#End Region

End Class

