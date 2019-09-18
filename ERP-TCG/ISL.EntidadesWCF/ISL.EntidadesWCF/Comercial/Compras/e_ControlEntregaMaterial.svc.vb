

' NOTA: si cambia aquí el nombre de clase "e_ControlEntregaMaterial", también debe actualizar la referencia a "e_ControlEntregaMaterial" tanto en Web.config como en el archivo .svc asociado.
<DataContract()> _
Public Class e_ControlEntregaMaterial
    Implements Ie_ControlEntregaMaterial

#Region "Propiedad"

    Private _id As String
    Private _idrequerimientomaterial As String
    Private _idordenmaterialingreso As String
    Private _idordenmaterialsalida As String
    Private _idtrabajador As String
    Private _trabajador As String
    Private _cantidadentregada As Double
    Private _idunidadmedida As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _material As String
    Private _codigo As String
    Private _nroorden As String
    Private _tipoorden As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
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
    Public Property IdRequerimientoMaterial() As String
        Get
            Return _idrequerimientomaterial
        End Get
        Set(ByVal value As String)
            _idrequerimientomaterial = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdOrdenMaterialSalida() As String
        Get
            Return _idordenmaterialsalida
        End Get
        Set(ByVal value As String)
            _idordenmaterialsalida = value
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadEntregada() As Double
        Get
            Return _cantidadentregada
        End Get
        Set(ByVal value As Double)
            _cantidadentregada = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NroOrden() As String
        Get
            Return _nroorden
        End Get
        Set(ByVal value As String)
            _nroorden = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdOrdenMaterialIngreso() As String
        Get
            Return _idordenmaterialingreso
        End Get
        Set(ByVal value As String)
            _idordenmaterialingreso = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoOrden() As String
        Get
            Return _tipoorden
        End Get
        Set(ByVal value As String)
            _tipoorden = value
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
    Public Property IdTrabajador() As String
        Get
            Return _idtrabajador
        End Get
        Set(ByVal value As String)
            _idtrabajador = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Trabajador() As String
        Get
            Return _trabajador
        End Get
        Set(ByVal value As String)
            _trabajador = value
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
    Public Property IdUnidadMedida() As String
        Get
            Return _idunidadmedida
        End Get
        Set(ByVal value As String)
            _idunidadmedida = value
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
        IdOrdenMaterialIngreso = ""
        IdOrdenMaterialSalida = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ln_CantidadEntregada As Double _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ls_Material As String _
              , ByVal ls_Trabajador As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_NroOrden As String _
              , ByVal ls_TipoOrden As String)
        _id = ls_Id
        _cantidadentregada = ln_CantidadEntregada
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _material = ls_Material
        _trabajador = ls_Trabajador
        _codigo = ls_Codigo
        _nroorden = ls_NroOrden
        _tipoorden = ls_TipoOrden
    End Sub

#End Region

    Public Function Obtener(ByVal controlentregamaterial As e_ControlEntregaMaterial) As e_ControlEntregaMaterial Implements Ie_ControlEntregaMaterial.Obtener
        Return controlentregamaterial
    End Function

End Class


