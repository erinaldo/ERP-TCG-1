<DataContract()> _
Public Class e_DetalleModelo_Referencia
    Implements Ie_DetalleModelo_Referencia
    Implements IEquatable(Of e_DetalleModelo_Referencia)

#Region "Declaracion de Variables"

    Private _id As String
    Private _iddetalleasientomodelo As String
    Private _tiporeferencia As Integer
    Private _referencia As String
    Private _idreferencia As String
    Private _nombre As String
    Private _formula As String
    Private _observacion As String
    Private _idconfiguracioncolumna As String
    Private _cuenta As String
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _usuariomodifica As String
    Private _fechamodifica As Date
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Equivale As Integer
    <DataMember()> _
    Public Fila As String

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
    Public Property IdDetalleAsientoModelo() As String
        Get
            Return _iddetalleasientomodelo
        End Get
        Set(ByVal value As String)
            _iddetalleasientomodelo = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoReferencia() As Integer
        Get
            Return _tiporeferencia
        End Get
        Set(ByVal value As Integer)
            _tiporeferencia = value
        End Set
    End Property

    <DataMember()> _
    Public Property Referencia() As String
        Get
            Return _referencia
        End Get
        Set(ByVal value As String)
            _referencia = value
        End Set
    End Property

    <DataMember()> _
Public Property IdReferencia() As String
        Get
            Return _idreferencia
        End Get
        Set(ByVal value As String)
            _idreferencia = value
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property Formula() As String
        Get
            Return _formula
        End Get
        Set(ByVal value As String)
            _formula = value
        End Set
    End Property

    <DataMember()> _
    Public Property Observacion() As String
        Get
            Return _observacion
        End Get
        Set(ByVal value As String)
            _observacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdConfiguracionColumna() As String
        Get
            Return _idconfiguracioncolumna
        End Get
        Set(ByVal value As String)
            _idconfiguracioncolumna = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cuenta() As String
        Get
            Return _cuenta
        End Get
        Set(ByVal value As String)
            _cuenta = value
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
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
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
    Public Property FechaModifica() As Date
        Get
            Return _fechamodifica
        End Get
        Set(ByVal value As Date)
            _fechamodifica = value
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

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _iddetalleasientomodelo = String.Empty
        _tiporeferencia = 0
        _referencia = String.Empty
        _idreferencia = String.Empty
        _nombre = String.Empty
        _formula = String.Empty
        _observacion = String.Empty
        _idconfiguracioncolumna = String.Empty
        _cuenta = String.Empty
        _usuariocreacion = String.Empty
        _fechacreacion = #1/1/1901#
        _usuariomodifica = String.Empty
        _fechamodifica = #1/1/1901#
        _activo = True
        Fila = String.Empty
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdDetalleAsientoModelo As String _
              , ByVal ln_TipoReferencia As Integer _
              , ByVal ls_Referencia As String _
              , ByVal ls_IdReferencia As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_Formula As String _
              , ByVal ls_Observacion As String _
              , ByVal ls_IdConfiguracionColumna As String _
              , ByVal ls_Cuenta As String _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioModifica As String _
              , ByVal ld_FechaModifica As Date _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_Fila As String _
           )
        _id = ls_Id
        _iddetalleasientomodelo = ls_IdDetalleAsientoModelo
        _tiporeferencia = ln_TipoReferencia
        _referencia = ls_Referencia
        _idreferencia = ls_IdReferencia
        _nombre = ls_Nombre
        _formula = ls_Formula
        _observacion = ls_Observacion
        _idconfiguracioncolumna = ls_IdConfiguracionColumna
        _cuenta = ls_Cuenta
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _usuariomodifica = ls_UsuarioModifica
        _fechamodifica = ld_FechaModifica
        _activo = lb_Activo
        Fila = ls_Fila
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(detallemodeloreferencia As e_DetalleModelo_Referencia) As e_DetalleModelo_Referencia Implements Ie_DetalleModelo_Referencia.Obtener
        Return detallemodeloreferencia
    End Function

    Public Overloads Function Equals(ByVal oeDMRef As e_DetalleModelo_Referencia) As Boolean Implements System.IEquatable(Of e_DetalleModelo_Referencia).Equals
        Select Case oeDMRef.Equivale
            Case 0 : If Me.Id = oeDMRef.Id Then Return True
            Case 1 : If Me.TipoReferencia = oeDMRef.TipoReferencia And Me.IdReferencia = oeDMRef.IdReferencia Then Return True
            Case 2 : If Me.Cuenta = oeDMRef.Cuenta Then Return True
        End Select
        Return False
    End Function

#End Region

End Class
