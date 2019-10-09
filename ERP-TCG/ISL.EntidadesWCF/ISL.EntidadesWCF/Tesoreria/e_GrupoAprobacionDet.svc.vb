


' NOTA: si cambia aquí el nombre de clase "e_GrupoAprobacionDet", también debe actualizar la referencia a "e_GrupoAprobacionDet" tanto en Web.config como en el archivo .svc asociado.
Public Class e_GrupoAprobacionDet
    Implements Ie_GrupoAprobacionDet

#Region "Propiedad"

    Private _id As String
    Private _idgrupoaprobacion As String
    Private _idgrupo As String
    Private _grupo As String
    Private _glosa As String
    Private _importe As Double
    Private _activo As Boolean
    Private _seleccion As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()>
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

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
    Public Property Seleccion() As Boolean
        Get
            Return _seleccion
        End Get
        Set(ByVal value As Boolean)
            _seleccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdGrupoAprobacion() As String
        Get
            Return _idgrupoaprobacion
        End Get
        Set(ByVal value As String)
            _idgrupoaprobacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdGrupo() As String
        Get
            Return _idgrupo
        End Get
        Set(ByVal value As String)
            _idgrupo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _grupo
        End Get
        Set(ByVal value As String)
            _grupo = value
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
    Public Property Importe() As Double
        Get
            Return _importe
        End Get
        Set(ByVal value As Double)
            _importe = value
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

#End Region

#Region "Constructor"

    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdGrupoAprobacion As String _
              , ByVal ls_IdGrupo As String _
              , ByVal ls_Glosa As String _
              , ByVal ln_Importe As Double _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_Codigo As String)
        _id = ls_Id
        _idgrupoaprobacion = ls_IdGrupoAprobacion
        _idgrupo = ls_IdGrupo
        _glosa = ls_Glosa
        _importe = ln_Importe
        _activo = lb_Activo
        _grupo = ls_Codigo
    End Sub

#End Region

    Public Function Obtener(ByVal grupoaprobaciondet As e_GrupoAprobacionDet) As e_GrupoAprobacionDet Implements Ie_GrupoAprobacionDet.Obtener
        Return grupoaprobaciondet
    End Function

End Class

