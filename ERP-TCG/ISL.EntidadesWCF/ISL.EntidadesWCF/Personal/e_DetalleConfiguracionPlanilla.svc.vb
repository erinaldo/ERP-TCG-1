<DataContract()> _
Public Class e_DetalleConfiguracionPlanilla
    Implements Ie_DetalleConfiguracionPlanilla
    Implements IEquatable(Of e_DetalleConfiguracionPlanilla)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idconfiguracionplanilla As String
    Private _idaportedescuento As String
    Private _aportedescuento As String
    Private _abreviatura As String
    Private _tipo As Integer
    Private _nombretipo As String
    Private _indTotal As Integer
    Private _nombretotal As String
    Private _nroorden As Integer
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _fechamodifica As Date
    Private _usuariomodifica As String
    Private _activo As Boolean
    Private _codigosunat As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
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
    Public Property IdConfiguracionPlanilla() As String
        Get
            Return _idconfiguracionplanilla
        End Get
        Set(ByVal value As String)
            _idconfiguracionplanilla = value
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
    Public Property AporteDescuento() As String
        Get
            Return _aportedescuento
        End Get
        Set(ByVal value As String)
            _aportedescuento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Abreviatura() As String
        Get
            Return _abreviatura
        End Get
        Set(ByVal value As String)
            _abreviatura = value
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
    Public Property NombreTipo() As String
        Get
            Select Case Tipo
                Case 1 : _nombretipo = "INGRESO"
                Case 2 : _nombretipo = "DEDUCCION"
                Case 3 : _nombretipo = "APORTE"
                Case 4 : _nombretipo = "NETO"
            End Select
            Return _nombretipo
        End Get
        Set(ByVal value As String)
            _nombretipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndTotal() As Integer
        Get
            Return _indTotal
        End Get
        Set(ByVal value As Integer)
            _indTotal = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoTotal() As String
        Get
            Select Case IndTotal
                Case 0 : _nombretotal = "NINGUNO"
                Case 1 : _nombretotal = "SUBTOTAL"
                Case 2 : _nombretotal = "GENERAL"
            End Select
            Return _nombretotal
        End Get
        Set(ByVal value As String)
            _nombretotal = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroOrden() As Integer
        Get
            Return _nroorden
        End Get
        Set(ByVal value As Integer)
            _nroorden = value
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

    <DataMember()> _
    Public Property CodigoSunat() As String
        Get
            Return _codigosunat
        End Get
        Set(ByVal value As String)
            _codigosunat = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _idconfiguracionplanilla = String.Empty
        _idaportedescuento = String.Empty
        _aportedescuento = String.Empty
        _abreviatura = String.Empty
        _tipo = -1
        _indTotal = 0
        _nroorden = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _fechamodifica = #1/1/1901#
        _usuariocreacion = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
          ByVal ls_Id As String _
          , ByVal ls_IdConfiguracionPlanilla As String _
          , ByVal ls_IdAporteDescuento As String _
          , ByVal ls_AporteDescuento As String _
          , ByVal ls_Abreviatura As String _
          , ByVal ln_Tipo As Integer _
          , ByVal ln_IndTotal As Integer _
          , ByVal ln_NroOrden As Integer _
          , ByVal ld_FechaCreacion As Date _
          , ByVal ls_UsuarioCreacion As String _
          , ByVal ld_FechaModifica As Date _
          , ByVal ls_UsuarioModifica As String _
          , ByVal lb_Activo As Boolean _
       )
        _id = ls_Id
        _idconfiguracionplanilla = ls_IdConfiguracionPlanilla
        _idaportedescuento = ls_IdAporteDescuento
        _aportedescuento = ls_AporteDescuento
        _abreviatura = ls_Abreviatura
        _tipo = ln_Tipo
        _indTotal = ln_IndTotal
        _nroorden = ln_NroOrden
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function obtener(oeDetalleConfiguracionPlanilla As e_DetalleConfiguracionPlanilla) As e_DetalleConfiguracionPlanilla Implements Ie_DetalleConfiguracionPlanilla.obtener
        Return oeDetalleConfiguracionPlanilla
    End Function

    Public Overloads Function Equals(ByVal oeDetalleConPla As e_DetalleConfiguracionPlanilla) As Boolean Implements System.IEquatable(Of e_DetalleConfiguracionPlanilla).Equals
        Select Case oeDetalleConPla.Equivale
            Case 1 : If Me.Id = oeDetalleConPla.Id Then Return True
            Case 2 : If Me.IdAporteDescuento = oeDetalleConPla.IdAporteDescuento Then Return True
        End Select
        Return False
    End Function

#End Region


End Class
