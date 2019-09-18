<DataContract()> _
Public Class e_Asiento
    Implements Ie_Asiento

#Region "Propiedad"

    Private _id As String
    Private _idperiodo As String
    Private _idtipoasiento As String
    Private _nroasiento As String
    Private _fecha As Date
    Private _glosa As String
    Private _glosaimprime As String
    Private _idmoneda As String
    Private _tipocambio As Double
    Private _totaldebe As Double
    Private _totalhaber As Double
    Private _idusuariobloquea As String
    Private _idusuariocrea As String
    Private _idestado As String
    Private _idasientoextorno As String
    Private _fechacreacion As Date
    Private _activo As Boolean
    Private _indorigen As Integer

    <DataMember()> _
    Public _IdMovimientoCajaBanco As String
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public AsientoMovimiento As New List(Of e_AsientoMovimiento)
    <DataMember()> _
    Public Asiento_MovDoc As New e_Asiento_MovDoc
    <DataMember()> _
    Public AsientoReferencia As New e_AsientoReferencia
    <DataMember()> _
    Public oeLiquidacionTrabajador_Asiento As New e_LiquidacionTrabajador_Asiento
    <DataMember()> _
    Public _Mes As Integer
    <DataMember()> _
    Public _Ejercicio As Integer
    <DataMember()> _
    Public IdRetencion As String
    <DataMember()> _
    Public IdentificaAsiento As String
    <DataMember()> _
    Public dtAsiMov As Data.DataTable
    <DataMember()> _
    Public dtAsiMovDoc As Data.DataTable
    <DataMember()>
    Public PrefijoID As String = ""
    Public Event DatoCambiado()

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
    Public Property IdPeriodo() As String
        Get
            Return _idperiodo
        End Get
        Set(ByVal value As String)
            _idperiodo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoAsiento() As String
        Get
            Return _idtipoasiento
        End Get
        Set(ByVal value As String)
            _idtipoasiento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NroAsiento() As String
        Get
            Return _nroasiento
        End Get
        Set(ByVal value As String)
            _nroasiento = value
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
    Public Property GlosaImprime() As String
        Get
            Return _glosaimprime
        End Get
        Set(ByVal value As String)
            _glosaimprime = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdMoneda() As String
        Get
            Return _idmoneda
        End Get
        Set(ByVal value As String)
            _idmoneda = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoCambio() As Double
        Get
            Return _tipocambio
        End Get
        Set(ByVal value As Double)
            _tipocambio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TotalDebe() As Double
        Get
            Return _totaldebe
        End Get
        Set(ByVal value As Double)
            _totaldebe = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TotalHaber() As Double
        Get
            Return _totalhaber
        End Get
        Set(ByVal value As Double)
            _totalhaber = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdUsuarioBloquea() As String
        Get
            Return _idusuariobloquea
        End Get
        Set(ByVal value As String)
            _idusuariobloquea = value
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
    Public Property IdAsientoExtorno() As String
        Get
            Return _idasientoextorno
        End Get
        Set(ByVal value As String)
            _idasientoextorno = value
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
    Public Property IndOrigen() As Integer
        Get
            Return _indorigen
        End Get
        Set(ByVal value As Integer)
            _indorigen = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        Id = ""
        Activo = True
        Fecha = Date.Parse("01/01/1901")
        FechaCreacion = Date.Parse("01/01/1901")
        IdUsuarioBloquea = ""
        IndOrigen = 0
        IdentificaAsiento = String.Empty
        IdPeriodo = ""
        IdTipoAsiento = ""
        NroAsiento = ""
        IdAsientoExtorno = String.Empty
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdPeriodo As String _
              , ByVal ls_TipoAsiento As String _
              , ByVal ls_NroAsiento As String _
              , ByVal ld_Fecha As Date _
              , ByVal ls_Glosa As String _
              , ByVal ls_GlosaImprime As String _
              , ByVal ls_IdMoneda As String _
              , ByVal ln_TipoCambio As Double _
              , ByVal ln_TotalDebe As Double _
              , ByVal ln_TotalHaber As Double _
              , ByVal ls_IdUsuarioBloquea As String _
              , ByVal ls_IdUsuarioCrea As String _
              , ByVal ls_IdEstado As String _
              , ByVal ls_IdAsientoExtorno As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal lb_Activo As Boolean _
              , ByVal li_IndOrigen As Integer _
              , ByVal ls_IdentificaAsiento As String _
           )
        _id = ls_Id
        _idperiodo = ls_IdPeriodo
        _idtipoasiento = ls_TipoAsiento
        _nroasiento = ls_NroAsiento
        _fecha = ld_Fecha
        _glosa = ls_Glosa
        _glosaimprime = ls_GlosaImprime
        _idmoneda = ls_IdMoneda
        _tipocambio = ln_TipoCambio
        _totaldebe = ln_TotalDebe
        _totalhaber = ln_TotalHaber
        _idusuariobloquea = ls_IdUsuarioBloquea
        _idusuariocrea = ls_IdUsuarioCrea
        _idestado = ls_IdEstado
        _idasientoextorno = ls_IdAsientoExtorno
        _fechacreacion = ld_FechaCreacion
        _activo = lb_Activo
        _indorigen = li_IndOrigen
        IdentificaAsiento = ls_IdentificaAsiento
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal asiento As e_Asiento) As e_Asiento Implements Ie_Asiento.Obtener
        Return asiento
    End Function

#End Region

End Class
