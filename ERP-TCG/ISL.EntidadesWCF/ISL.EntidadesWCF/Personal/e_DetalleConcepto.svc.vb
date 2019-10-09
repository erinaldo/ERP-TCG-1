<DataContract()> _
Public Class e_DetalleConcepto
    Implements Ie_DetalleConcepto
    Implements IEquatable(Of e_DetalleConcepto)

#Region "Declaracion de Variables"

    Private _id As String
    Private _iddetalleplanilla As String
    Private _idaportedescuento As String
    Private _codapordesc As String
    Private _idtrabajador As String
    Private _trabajador As String
    Private _importe As Double
    Private _tipo As Integer
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _fechamodifica As Date
    Private _usuariomodifica As String
    Private _activo As Boolean

    Private _area As String
    Private _ocupacion As String
    Private _unidad As String
    Private _gerencia As String
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Equivale As String
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Area() As String
        Get
            Return _area
        End Get
        Set(ByVal value As String)
            _area = value
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
    Public Property Unidad() As String
        Get
            Return _unidad
        End Get
        Set(ByVal value As String)
            _unidad = value
        End Set
    End Property

    <DataMember()> _
    Public Property Gerencia() As String
        Get
            Return _gerencia
        End Get
        Set(ByVal value As String)
            _gerencia = value
        End Set
    End Property
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
    Public Property IdDetallePlanilla() As String
        Get
            Return _iddetalleplanilla
        End Get
        Set(ByVal value As String)
            _iddetalleplanilla = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdAporteDescuento() As String
        Get
            Return _idaportedescuento
        End Get
        Set(ByVal value As String)
            _idaportedescuento = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodAporDesc() As String
        Get
            Return _codapordesc
        End Get
        Set(ByVal value As String)
            _codapordesc = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTrabajador() As String
        Get
            Return _idTrabajador
        End Get
        Set(ByVal value As String)
            _idtrabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property Trabajador() As String
        Get
            Return _trabajador
        End Get
        Set(ByVal value As String)
            _trabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property Importe() As Double
        Get
            Return _importe
        End Get
        Set(ByVal value As Double)
            _importe = value
        End Set
    End Property

    <DataMember()> _
    Public Property Tipo() As Integer
        Get
            Return _tipo
        End Get
        Set(ByVal value As Integer)
            _tipo = value
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
    Public Property FechaModifica() As Date
        Get
            Return _fechamodifica
        End Get
        Set(ByVal value As Date)
            _fechamodifica = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioModifica() As String
        Get
            Return _usuariomodifica
        End Get
        Set(ByVal value As String)
            _usuariomodifica = value
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

#Region "Contructores"

    Public Sub New()
        _id = String.Empty
        _iddetalleplanilla = String.Empty
        _idaportedescuento = String.Empty
        _idtrabajador = String.Empty
        _trabajador = String.Empty
        _importe = 0
        _tipo = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _fechamodifica = #1/1/1901#
        _usuariomodifica = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
          ByVal ls_Id As String _
          , ByVal ls_IdDetallePlanilla As String _
          , ByVal ls_IdAporteDescuento As String _
          , ByVal ls_CodAporDesc As String _
          , ByVal ls_IdTrabajador As String _
          , ByVal ls_Trabajador As String _
          , ByVal ln_Importe As Double _
          , ByVal ln_Tipo As Integer _
          , ByVal ld_FechaCreacion As Date _
          , ByVal ls_UsuarioCreacion As String _
          , ByVal ld_FechaModifica As Date _
          , ByVal ls_UsuarioModifica As String _
          , ByVal lb_Activo As Boolean _
       )
        _id = ls_Id
        _iddetalleplanilla = ls_IdDetallePlanilla
        _idaportedescuento = ls_IdAporteDescuento
        _codapordesc = ls_CodAporDesc
        _idtrabajador = ls_IdTrabajador
        _trabajador = ls_Trabajador
        _importe = ln_Importe
        _tipo = ln_Tipo
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function obtener(oeDetalleConcepto As e_DetalleConcepto) As e_DetalleConcepto Implements Ie_DetalleConcepto.obtener
        Return oeDetalleConcepto
    End Function

    Public Overloads Function Equals(ByVal oeDetCon As e_DetalleConcepto) As Boolean Implements System.IEquatable(Of e_DetalleConcepto).Equals
        Select Case oeDetCon.Equivale
            Case 1 : If Me.Id = oeDetCon.Id Then Return True
            Case 2 : If Me.CodAporDesc = oeDetCon.CodAporDesc Then Return True
            Case 3 : If Me.IdTrabajador = oeDetCon.IdTrabajador And Me.CodAporDesc = oeDetCon.CodAporDesc Then Return True
        End Select
        Return False
    End Function

#End Region


End Class
