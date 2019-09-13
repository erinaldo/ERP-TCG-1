<DataContract()> _
Public Class e_ControlPermisos
    Implements Ie_ControlPermisos
    Implements ICloneable

#Region "Propiedad"

    Private _id As String
    Private _idtrabajador As String
    Private _idarea As String
    Private _area As String
    Private _fecha As Date
    Private _fechasalida As Date
    Private _fechaingreso As Date
    Private _observacion As String
    Private _tipopermiso As Integer
    Private _indconfirmasalida As Boolean
    Private _fechaconfirmasalida As Date
    Private _indconfirmaingreso As Boolean
    Private _fechaconfirmaingreso As Date
    Private _idjefearea As String
    Private _idjefeadministracion As String
    Private _idsituacionadministrativa As String
    Private _motivo As String
    Private _idocupacion As String
    Private _ocupacion As String
    Private _idcentro As String
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _activo As Boolean
    Private _diasexcedidos As Integer
    Private _diaspermiso As Integer
    Private _jefearea As String
    Private _trabajador As String
    Private _jefeadministracion As String
    Private _codigo As String
    Private _indpapeleta As Boolean
    Private _indventa As Boolean
    Private _fechainiciovtavacaciones As Date
    Private _fechafinvtavacaciones As Date
    Private _diasvendidos As Integer
    Private _totaldias As Integer
    Private _indgoce As Boolean

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
    Public Property IdCentro() As String
        Get
            Return _idcentro
        End Get
        Set(ByVal value As String)
            _idcentro = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdOcupacion() As String
        Get
            Return _idocupacion
        End Get
        Set(ByVal value As String)
            _idocupacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Ocupacion() As String
        Get
            Return _ocupacion
        End Get
        Set(ByVal value As String)
            _ocupacion = value
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
    Public Property IdSituacionAdministrativa() As String
        Get
            Return _idsituacionadministrativa
        End Get
        Set(ByVal value As String)
            _idsituacionadministrativa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndPapeleta() As Boolean
        Get
            Return _indpapeleta
        End Get
        Set(ByVal value As Boolean)
            _indpapeleta = value
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
    Public Property DiasVendidos() As Integer
        Get
            Return _diasvendidos
        End Get
        Set(ByVal value As Integer)
            _diasvendidos = value
        End Set
    End Property

    <DataMember()> _
    Public Property JefeArea() As String
        Get
            Return _jefearea
        End Get
        Set(ByVal value As String)
            _jefearea = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndVenta() As Boolean
        Get
            Return _indventa
        End Get
        Set(ByVal value As Boolean)
            _indventa = value
        End Set
    End Property

    <DataMember()> _
    Public Property JefeAdministracion() As String
        Get
            Return _jefeadministracion
        End Get
        Set(ByVal value As String)
            _jefeadministracion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property DiasExcedidos() As Integer
        Get
            Return _diasexcedidos
        End Get
        Set(ByVal value As Integer)
            _diasexcedidos = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaFinVtaVacaciones() As Date
        Get
            Return _fechafinvtavacaciones
        End Get
        Set(ByVal value As Date)
            _fechafinvtavacaciones = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInicioVtaVacaciones() As Date
        Get
            Return _fechainiciovtavacaciones
        End Get
        Set(ByVal value As Date)
            _fechainiciovtavacaciones = value
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
    Public Property FechaSalida() As Date
        Get
            Return _fechasalida
        End Get
        Set(ByVal value As Date)
            _fechasalida = value
            RaiseEvent DatoCambiado()
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
    Public Property Motivo() As String
        Get
            Return _motivo
        End Get
        Set(ByVal value As String)
            _motivo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Observacion() As String
        Get
            Return _observacion
        End Get
        Set(ByVal value As String)
            _observacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property DiasPermiso() As Integer
        Get
            Return _diaspermiso
        End Get
        Set(ByVal value As Integer)
            _diaspermiso = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoPermiso() As Integer
        Get
            Return _tipopermiso
        End Get
        Set(ByVal value As Integer)
            _tipopermiso = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndConfirmaSalida() As Boolean
        Get
            Return _indconfirmasalida
        End Get
        Set(ByVal value As Boolean)
            _indconfirmasalida = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaConfirmaSalida() As Date
        Get
            Return _fechaconfirmasalida
        End Get
        Set(ByVal value As Date)
            _fechaconfirmasalida = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndConfirmaIngreso() As Boolean
        Get
            Return _indconfirmaingreso
        End Get
        Set(ByVal value As Boolean)
            _indconfirmaingreso = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaConfirmaIngreso() As Date
        Get
            Return _fechaconfirmaingreso
        End Get
        Set(ByVal value As Date)
            _fechaconfirmaingreso = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdJefeArea() As String
        Get
            Return _idjefearea
        End Get
        Set(ByVal value As String)
            _idjefearea = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdJefeAdministracion() As String
        Get
            Return _idjefeadministracion
        End Get
        Set(ByVal value As String)
            _idjefeadministracion = value
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
    Public Property TotalDias() As Integer
        Get
            Return _totaldias
        End Get
        Set(ByVal value As Integer)
            _totaldias = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndGoce() As Boolean
        Get
            Return _indgoce
        End Get
        Set(ByVal value As Boolean)
            _indgoce = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        Id = ""
        IdTrabajador = ""
        IdCentro = ""
        IdOcupacion = ""
        Ocupacion = ""
        Trabajador = ""
        IdSituacionAdministrativa = ""
        IndPapeleta = False
        Codigo = ""
        DiasVendidos = 0
        JefeArea = ""
        IndVenta = False
        JefeAdministracion = ""
        DiasExcedidos = 0
        FechaInicioVtaVacaciones = #1/1/1901#
        FechaFinVtaVacaciones = #1/1/1901#
        IdArea = ""
        Area = ""
        Fecha = #1/1/1901#
        FechaSalida = #1/1/1901#
        FechaIngreso = #1/1/1901#
        Motivo = ""
        Observacion = ""
        DiasPermiso = 0
        TipoPermiso = 0
        IndConfirmaSalida = False
        FechaConfirmaSalida = #1/1/1901#
        IndConfirmaIngreso = False
        FechaConfirmaIngreso = #1/1/1901#
        IdJefeArea = ""
        IdJefeAdministracion = ""
        UsuarioCreacion = ""
        FechaCreacion = #1/1/1901#
        Activo = True
        TotalDias = 0
        IndGoce = False
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ls_IdArea As String _
              , ByVal ls_IdSituacionAdministrativa As String _
              , ByVal ld_Fecha As Date _
              , ByVal ld_FechaSalida As Date _
              , ByVal ld_FechaRetorno As Date _
              , ByVal ls_Motivo As String _
              , ByVal ls_Observacion As String _
              , ByVal ln_TipoPermiso As Integer _
              , ByVal ln_IndConfirmaSalida As Boolean _
              , ByVal ld_FechaConfirmaSalida As Date _
              , ByVal ln_IndConfirmaIngreso As Boolean _
              , ByVal ld_FechaConfirmaIngreso As Date _
              , ByVal ls_IdJefeArea As String _
              , ByVal ls_IdJefeAdministracion As String _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal lb_Activo As Boolean _
              , ByVal li_DiasExcedidos As Integer _
              , ByVal li_DiasPermiso As Integer _
              , ByVal ls_Trabajador As String _
              , ByVal ls_JefeArea As String _
              , ByVal ls_JefeAdministracion As String _
              , ByVal ls_Area As String _
              , ByVal ls_Codigo As String _
              , ByVal lb_IndPapeleta As Boolean _
              , ByVal ls_IdOcupacion As String _
              , ByVal ls_Ocupacion As String _
              , ByVal lb_IndVenta As Boolean _
              , ByVal ld_FechaInicioVta As Date _
              , ByVal ld_FechaFinVta As Date _
              , ByVal li_DiasVendidos As Integer _
              , ByVal ln_TotalDias As Integer _
              , ByVal lb_IndGoce As Boolean)
        _id = ls_Id
        _idtrabajador = ls_IdTrabajador
        _idarea = ls_IdArea
        _fecha = ld_Fecha
        _idocupacion = ls_IdOcupacion
        _ocupacion = ls_Ocupacion
        _idsituacionadministrativa = ls_IdSituacionAdministrativa
        _fechasalida = ld_FechaSalida
        _fechaingreso = ld_FechaRetorno
        _motivo = ls_Motivo
        _observacion = ls_Observacion
        _tipopermiso = ln_TipoPermiso
        _indconfirmasalida = ln_IndConfirmaSalida
        _fechaconfirmasalida = ld_FechaConfirmaSalida
        _indconfirmaingreso = ln_IndConfirmaIngreso
        _fechaconfirmaingreso = ld_FechaConfirmaIngreso
        _idjefearea = ls_IdJefeArea
        _idjefeadministracion = ls_IdJefeAdministracion
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _activo = lb_Activo
        _diasexcedidos = li_DiasExcedidos
        _diaspermiso = li_DiasPermiso
        _trabajador = ls_Trabajador
        _jefearea = ls_JefeArea
        _jefeadministracion = ls_JefeAdministracion
        _area = ls_Area
        _codigo = ls_Codigo
        _indpapeleta = lb_IndPapeleta
        _indventa = lb_IndVenta
        _fechainiciovtavacaciones = ld_FechaInicioVta
        _fechafinvtavacaciones = ld_FechaFinVta
        _diasvendidos = li_DiasVendidos
        _totaldias = ln_TotalDias
        _indgoce = lb_IndGoce
    End Sub

#End Region

    Public Function Obtener(ByVal controlpermisos As e_ControlPermisos) As e_ControlPermisos Implements Ie_ControlPermisos.Obtener
        Return controlpermisos
    End Function

    Public Function Clone() As Object Implements ICloneable.Clone
        Return CType(MyBase.MemberwiseClone, e_ControlPermisos)
    End Function

End Class



