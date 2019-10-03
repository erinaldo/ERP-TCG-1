


<DataContract()> _
Public Class e_GastoViatico
    Implements Ie_GastoViatico
    Implements IEquatable(Of e_GastoViatico)

#Region "Declaracion de variables"

    Private _id As String
    Private _idviaje As String
    Private _fecha As Date
    Private _indzona As Integer
    Private _idcuentacorriente As String
    Private _tipoconductor As Integer
    Private _inddesayuno As Integer
    Private _indalmuerzo As Integer
    Private _indcena As Integer
    Private _monto As Double
    Private _idestado As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
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
    Public Property IdViaje() As String
        Get
            Return _idviaje
        End Get
        Set(ByVal value As String)
            _idviaje = value
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
    Public Property IndZona() As Integer
        Get
            Return _indzona
        End Get
        Set(ByVal value As Integer)
            _indzona = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaCorriente() As String
        Get
            Return _idcuentacorriente
        End Get
        Set(ByVal value As String)
            _idcuentacorriente = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoConductor() As Integer
        Get
            Return _tipoconductor
        End Get
        Set(ByVal value As Integer)
            _tipoconductor = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndDesayuno() As Integer
        Get
            Return _inddesayuno
        End Get
        Set(ByVal value As Integer)
            _inddesayuno = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndAlmuerzo() As Integer
        Get
            Return _indalmuerzo
        End Get
        Set(ByVal value As Integer)
            _indalmuerzo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndCena() As Integer
        Get
            Return _indcena
        End Get
        Set(ByVal value As Integer)
            _indcena = value
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
    Public Property IdEstado() As String
        Get
            Return _idestado
        End Get
        Set(ByVal value As String)
            _idestado = value
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
        _id = ""
        _idviaje = ""
        _indzona = -1
        _idcuentacorriente = ""
        _tipoconductor = -1
        _inddesayuno = -1
        _indalmuerzo = -1
        _indcena = -1
        _monto = 0
        _fecha = #1/1/1901#
        _fechacreacion = #1/1/1901#
        _usuariocreacion = ""
        _activo = True
        _idestado = ""
        TipoOperacion = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdViaje As String _
              , ByVal ld_Fecha As Date _
              , ByVal ln_IndZona As Integer _
              , ByVal ls_IdCuentaCorriente As String _
              , ByVal ln_TipoConductor As Integer _
              , ByVal ln_IndDesayuno As Integer _
              , ByVal ln_IndAlmuerzo As Integer _
              , ByVal ln_IndCena As Integer _
              , ByVal ln_Monto As Double _
              , ByVal ls_IdEstado As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idviaje = ls_IdViaje
        _fecha = ld_Fecha
        _indzona = ln_IndZona
        _idcuentacorriente = ls_IdCuentaCorriente
        _tipoconductor = ln_TipoConductor
        _inddesayuno = ln_IndDesayuno
        _indalmuerzo = ln_IndAlmuerzo
        _indcena = ln_IndCena
        _monto = ln_Monto
        _idestado = ls_IdEstado
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Overloads Function Equals(ByVal oeGastoViatico As e_GastoViatico) _
    As Boolean Implements IEquatable(Of e_GastoViatico).Equals
        If Me.Fecha = oeGastoViatico.Fecha AndAlso Me.IdCuentaCorriente = oeGastoViatico.IdCuentaCorriente Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Obtener(ByVal gastoViatico As e_GastoViatico) As e_GastoViatico Implements Ie_GastoViatico.Obtener
        Return gastoViatico
    End Function

#End Region

End Class

