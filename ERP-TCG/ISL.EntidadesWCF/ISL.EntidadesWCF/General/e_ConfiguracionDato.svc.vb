<DataContract()> _
Public Class e_ConfiguracionDato
    Implements Ie_ConfiguracionDato
    Implements IEquatable(Of e_ConfiguracionDato)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idcolumna As String
    Private _columna As String
    Private _clave As Integer
    Private _nrofila As Integer
    Private _descripcion As String
    Private _tiporeferencia As String
    Private _idreferencia As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _fechamodifica As Date
    Private _usuariomodifica As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()>
    Public TipoBusca As Integer
    <DataMember()>
    Public PrefijoID As String = ""

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
    Public Property IdColumna() As String
        Get
            Return _idcolumna
        End Get
        Set(ByVal value As String)
            _idcolumna = value
        End Set
    End Property

    <DataMember()> _
    Public Property Columna() As String
        Get
            Return _columna
        End Get
        Set(ByVal value As String)
            _columna = value
        End Set
    End Property

    <DataMember()> _
    Public Property Clave() As Integer
        Get
            Return _clave
        End Get
        Set(ByVal value As Integer)
            _clave = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroFila() As Integer
        Get
            Return _nrofila
        End Get
        Set(ByVal value As Integer)
            _nrofila = value
        End Set
    End Property

    <DataMember()> _
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoReferencia() As String
        Get
            Return _tiporeferencia
        End Get
        Set(ByVal value As String)
            _tiporeferencia = value
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

#Region "Contructor"

    Public Sub New()
        _id = String.Empty
        _idcolumna = String.Empty
        _columna = String.Empty
        _clave = 0
        _nrofila = 0
        _descripcion = String.Empty
        _tiporeferencia = String.Empty
        _idreferencia = String.Empty
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _fechamodifica = #1/1/1901#
        _usuariomodifica = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
          ByVal ls_Id As String _
          , ByVal ls_IdColumna As String _
          , ByVal ls_Columna As String _
          , ByVal lb_Clave As Boolean _
          , ByVal ln_NroFila As Integer _
          , ByVal ls_Descripcion As String _
          , ByVal ls_TipoReferencia As String _
          , ByVal ls_IdReferencia As String _
          , ByVal ld_FechaCreacion As Date _
          , ByVal ls_UsuarioCreacion As String _
          , ByVal ld_FechaModifica As Date _
          , ByVal ls_UsuarioModifica As String _
          , ByVal lb_Activo As Boolean _
       )
        _id = ls_Id
        _idcolumna = ls_IdColumna
        _columna = ls_Columna
        _clave = IIf(lb_Clave, 1, 0)
        _nrofila = ln_NroFila
        _descripcion = ls_Descripcion
        _tiporeferencia = ls_TipoReferencia
        _idreferencia = ls_IdReferencia
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
        _activo = lb_Activo
        TipoOperacion = String.Empty
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(configuraciondato As e_ConfiguracionDato) As e_ConfiguracionDato Implements Ie_ConfiguracionDato.Obtener
        Return configuraciondato
    End Function

    Public Overloads Function Equals(ByVal oeConCol As e_ConfiguracionDato) As Boolean Implements System.IEquatable(Of e_ConfiguracionDato).Equals
        Select Case oeConCol.TipoBusca
            Case 1 : If Me.Id = oeConCol.Id Then Return True
            Case 2 : If Me.IdColumna = oeConCol.IdColumna And Me.NroFila = oeConCol.NroFila Then Return True
        End Select
        Return False
    End Function

#End Region

End Class
