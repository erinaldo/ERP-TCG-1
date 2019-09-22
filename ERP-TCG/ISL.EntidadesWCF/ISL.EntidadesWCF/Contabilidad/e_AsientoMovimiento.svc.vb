<DataContract()> _
Public Class e_AsientoMovimiento
    Implements Ie_AsientoMovimiento
    Implements IEquatable(Of e_AsientoMovimiento)

#Region "Propiedad"

    Private _id As String
    Private _idasiento As String
    Private _idcuentacontable As String
    Private _glosa As String
    Private _debemn As Double
    Private _habermn As Double
    Private _debeme As Double
    Private _haberme As Double
    Private _idusuariocrea As String
    Private _fechacreacion As Date
    Private _activo As Boolean
    <DataMember()> _
    Public DivideAnalisis As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public MovimientoAnalisis As New List(Of e_MovimientoAnalisis)
    <DataMember()> _
    Public MovimientoCajaBanco As New e_MovimientoCajaBanco
    <DataMember()> _
    Public MovimientoDocumento As New e_MovimientoDocumento
    <DataMember()> _
    Public DocumentoRetencion As New e_DocumentoRetencion

    <DataMember()> _
    Public AsMov_MovDoc As New e_AsientoMov_MovDoc
    <DataMember()> _
    Public AsMov_ObligacionFin As New e_AsientoMov_ObligacionFin
    <DataMember()> _
    Public ObligacionFinanciera As New e_ObligacionFinanciera
    <DataMember()> _
    Public ObligacionFin As New e_ObligacionFin

    <DataMember()> _
    Public GrupoAsiento As New e_Grupo_Asiento
    <DataMember()> _
    Public DataTableAnalisis As New DataTable
    <DataMember()> _
    Public Editable As Boolean = True
    <DataMember()> _
    Public _IdMovimientoCajaBanco As String
    <DataMember()> _
    Public BandGuardMasivo As Boolean
    <DataMember()> _
    Public Fila As String = ""
    <DataMember()> _
    Public oeCuentaCP As New e_CuentaxCyP

    <DataMember()> _
    Public IndDocumento As Boolean = False
    <DataMember()> _
    Public IndPagoCobro As Boolean = False
    <DataMember()> _
    Public IndMovCajaBanco As Boolean = False

    Public Event DatoCambiado()
    Private _NroLinea As Integer

    <DataMember()> _
    Public Property NroLinea() As Integer
        Get
            Return _NroLinea
        End Get
        Set(ByVal value As Integer)
            _NroLinea = value
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
    Public Property IdAsiento() As String
        Get
            Return _idasiento
        End Get
        Set(ByVal value As String)
            _idasiento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaContable() As String
        Get
            Return _idcuentacontable
        End Get
        Set(ByVal value As String)
            _idcuentacontable = value
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
    Public Property DebeMN() As Double
        Get
            Return _debemn
        End Get
        Set(ByVal value As Double)
            _debemn = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property HaberMN() As Double
        Get
            Return _habermn
        End Get
        Set(ByVal value As Double)
            _habermn = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property DebeME() As Double
        Get
            Return _debeme
        End Get
        Set(ByVal value As Double)
            _debeme = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property HaberME() As Double
        Get
            Return _haberme
        End Get
        Set(ByVal value As Double)
            _haberme = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdUsuarioCrea() As String
        Get
            Return _idusuariocrea
        End Get
        Set(ByVal value As String)
            _idusuariocrea = value
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

#End Region

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        DivideAnalisis = True
        Activo = True
        FechaCreacion = Date.Parse("01/01/1901")
        Editable = True
        BandGuardMasivo = False
        IdCuentaContable = ""
        TipoOperacion = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdAsiento As String _
              , ByVal ls_IdCuentaContable As String _
              , ByVal ls_Glosa As String _
              , ByVal ln_DebeMN As Double _
              , ByVal ln_HaberMN As Double _
              , ByVal ln_DebeME As Double _
              , ByVal ln_HaberME As Double _
              , ByVal ls_IdUsuarioCrea As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal lb_Activo As Boolean _
              , ByVal lsNroLinea As Integer _
           )
        _id = ls_Id
        _idasiento = ls_IdAsiento
        _idcuentacontable = ls_IdCuentaContable
        _glosa = ls_Glosa
        _debemn = ln_DebeMN
        _habermn = ln_HaberMN
        _debeme = ln_DebeME
        _haberme = ln_HaberME
        _idusuariocrea = ls_IdUsuarioCrea
        _fechacreacion = ld_FechaCreacion
        _activo = lb_Activo
        _NroLinea = lsNroLinea
    End Sub

#End Region

#Region "Métodos"

    Public Function Equals1(ByVal other As e_AsientoMovimiento) As Boolean Implements System.IEquatable(Of e_AsientoMovimiento).Equals
        If other.MovimientoDocumento.Id <> "" Then
            If Me.IdAsiento = other.IdAsiento And Me.Id = other.Id Then
                Return True
            Else
                Return False
            End If
        Else
            If Me.IdAsiento = other.IdAsiento And Me.IdCuentaContable = other.IdCuentaContable And Me.Glosa = other.Glosa And Me.NroLinea = other.NroLinea Then
                Return True
            Else
                Return False
            End If
        End If

    End Function

    Public Function Obtener(ByVal asientoMovimiento As e_AsientoMovimiento) As e_AsientoMovimiento Implements Ie_AsientoMovimiento.Obtener
        Return asientoMovimiento
    End Function

#End Region

End Class
