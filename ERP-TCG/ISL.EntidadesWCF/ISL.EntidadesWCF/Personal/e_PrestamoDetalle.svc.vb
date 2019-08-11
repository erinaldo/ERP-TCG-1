<DataContract()> _
Public Class e_PrestamoDetalle
    Implements Ie_PrestamoDetalle
    Implements IEquatable(Of e_PrestamoDetalle)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idprestamo As String
    Private _nrocuota As String
    Private _cancelado As Integer
    Private _importe As Double
    Private _activo As Boolean
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _fecha As Date
    Private _anio As String
    Private _mes As String
    Private _doblemes As Integer
    Private _anulado As Integer
    Private _fechaanulado As Date
    Private _glosa As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

    <DataMember()> _
    Public TipoEqui As Integer
    <DataMember()> _
    Public MontoPrest As Double
    <DataMember()> _
    Public CadIdPrestDet As String
    <DataMember()> _
    Public oePreiodo As e_Periodo
    <DataMember()> _
    Public PeriodoEjec As String
    <DataMember()> _
    Public Equivale As Integer
    <DataMember()> _
    Public IndProv As String

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
    Public Property IdPrestamo() As String
        Get
            Return _idprestamo
        End Get
        Set(ByVal value As String)
            _idprestamo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As String
        Get
            Return _fecha
        End Get
        Set(ByVal value As String)
            _fecha = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NroCuota() As String
        Get
            Return _nrocuota
        End Get
        Set(ByVal value As String)
            _nrocuota = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Cancelado() As Integer
        Get
            Return _cancelado
        End Get
        Set(ByVal value As Integer)
            _cancelado = value
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

    <DataMember()> _
    Public Property Anio() As String
        Get
            Return _anio
        End Get
        Set(ByVal value As String)
            _anio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Mes() As String
        Get
            Return _mes
        End Get
        Set(ByVal value As String)
            _mes = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property DobleMes() As Integer
        Get
            Return _doblemes
        End Get
        Set(ByVal value As Integer)
            _doblemes = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Anulado() As Integer
        Get
            Return _anulado
        End Get
        Set(ByVal value As Integer)
            _anulado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaAnulado() As Date
        Get
            Return _fechaanulado
        End Get
        Set(ByVal value As Date)
            _fechaanulado = value
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
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _idprestamo = String.Empty
        _cancelado = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _nrocuota = String.Empty
        _activo = True
        _anio = String.Empty
        _mes = String.Empty
        _fecha = #1/1/1901#
        _doblemes = 0
        _anulado = 0
        _fechaanulado = #1/1/1901#
        _glosa = String.Empty
        CadIdPrestDet = String.Empty
        TipoOperacion = String.Empty
        PeriodoEjec = String.Empty
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdPrestamo As String _
              , ByVal ld_Fecha As Date _
              , ByVal ls_NroCuota As String _
              , ByVal ln_Cancelado As Integer _
              , ByVal ln_Importe As Double _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ls_Anio As String _
              , ByVal ls_Mes As String _
              , ByVal ln_DobleMes As Integer _
              , ByVal ln_Anulado As Integer _
              , ByVal ld_FechaAnulado As Date _
              , ByVal ls_Glosa As String _
              , ByVal ls_PeriodoEjec As String _
           )
        _id = ls_Id
        _idprestamo = ls_IdPrestamo
        _fecha = ld_Fecha
        _nrocuota = ls_NroCuota
        _cancelado = ln_Cancelado
        _importe = ln_Importe
        _activo = lb_Activo
        _anio = ls_Anio
        _mes = ls_Mes
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _doblemes = ln_DobleMes
        _anulado = ln_Anulado
        _fechaanulado = ld_FechaAnulado
        _glosa = ls_Glosa
        PeriodoEjec = ls_PeriodoEjec
        TipoOperacion = String.Empty
    End Sub

#End Region

#Region "Métodos"

    Public Overloads Function Equals(ByVal oePD As e_PrestamoDetalle) As Boolean Implements IEquatable(Of ISL.EntidadesWCF.e_PrestamoDetalle).Equals
        Select Case oePD.Equivale
            Case 0 : If Me.NroCuota.Trim = oePD.NroCuota.Trim Then Return True
            Case 1 : If Me.Id.Trim = oePD.Id.Trim Then Return True
            Case 2 : If Me.IdPrestamo.Trim = oePD.IdPrestamo.Trim And Me.NroCuota.Trim = oePD.NroCuota.Trim Then Return True
        End Select
        Return False
    End Function

    Public Function Obtener(ByVal prestamodetalle As e_PrestamoDetalle) As e_PrestamoDetalle Implements Ie_PrestamoDetalle.Obtener
        Return prestamodetalle
    End Function

#End Region

End Class

