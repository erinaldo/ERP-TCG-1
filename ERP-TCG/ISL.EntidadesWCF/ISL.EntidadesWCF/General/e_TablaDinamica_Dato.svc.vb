' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_TablaDinamica_Dato" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_TablaDinamica_Dato.svc o e_TablaDinamica_Dato.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ISL.EntidadesWCF

Public Class e_TablaDinamica_Dato
    Implements Ie_Orden_Documento
    Implements IEquatable(Of e_TablaDinamica_Dato)

#Region "Declaración de variables"

    Private _Id As String
    Private _IdColumna As String
    Private _Columna As String
    Private _Clave As Integer
    Private _NroFila As Integer
    Private _Descripcion As String
    Private _TipoReferencia As String
    Private _IdReferencia As String
    Private _FechaCrea As Date
    Private _UsuarioCrea As String
    Private _FechaModifica As Date
    Private _UsuarioModifica As String
    Private _Activo As Boolean

    Public TipoOperacion As String
    Public TipoBusca As Integer

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        _Id = ""
        _IdColumna = ""
        _Columna = ""
        _Clave = 0
        _NroFila = 0
        _Descripcion = ""
        _TipoReferencia = ""
        _IdReferencia = ""
        _FechaCrea = #1/1/1901#
        _UsuarioCrea = ""
        _FechaModifica = #1/1/1901#
        _UsuarioModifica = ""
        _Activo = True
    End Sub

    Public Sub New(
              ByVal ls_Id As String _
              , ByVal ls_IdColumna As String _
              , ByVal ls_Columna As String _
              , ByVal lb_Clave As Boolean _
              , ByVal ln_NroFila As Integer _
              , ByVal ls_Descripcion As String _
              , ByVal ls_TipoReferencia As String _
              , ByVal ls_IdReferencia As String _
              , ByVal ld_FechaCrea As Date _
              , ByVal ls_UsuarioCrea As String _
              , ByVal ld_FechaModifica As Date _
              , ByVal ls_UsuarioModifica As String _
              , ByVal lb_Activo As Boolean
           )
        _Id = ls_Id
        _IdColumna = ls_IdColumna
        _Columna = ls_Columna
        _Clave = lb_Clave
        _NroFila = ln_NroFila
        _Descripcion = ls_Descripcion
        _TipoReferencia = ls_TipoReferencia
        _IdReferencia = ls_IdReferencia
        _FechaCrea = ld_FechaCrea
        _UsuarioCrea = ls_UsuarioCrea
        _FechaModifica = ld_FechaModifica
        _UsuarioModifica = ls_UsuarioModifica
        _Activo = lb_Activo
        TipoOperacion = ""
    End Sub

#End Region

#Region "Propiedades"

    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    Public Property IdColumna() As String
        Get
            Return _IdColumna
        End Get
        Set(ByVal value As String)
            _IdColumna = value
        End Set
    End Property

    Public Property Columna() As String
        Get
            Return _Columna
        End Get
        Set(ByVal value As String)
            _Columna = value
        End Set
    End Property

    Public Property Clave() As Integer
        Get
            Return _Clave
        End Get
        Set(ByVal value As Integer)
            _Clave = value
        End Set
    End Property

    Public Property NroFila() As Integer
        Get
            Return _NroFila
        End Get
        Set(ByVal value As Integer)
            _NroFila = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property TipoReferencia() As String
        Get
            Return _TipoReferencia
        End Get
        Set(ByVal value As String)
            _TipoReferencia = value
        End Set
    End Property

    Public Property IdReferencia() As String
        Get
            Return _IdReferencia
        End Get
        Set(ByVal value As String)
            _IdReferencia = value
        End Set
    End Property

    Public Property FechaCrea() As Date
        Get
            Return _FechaCrea
        End Get
        Set(ByVal value As Date)
            _FechaCrea = value
        End Set
    End Property

    Public Property UsuarioCrea() As String
        Get
            Return _UsuarioCrea
        End Get
        Set(ByVal value As String)
            _UsuarioCrea = value
        End Set
    End Property

    Public Property FechaModifica() As Date
        Get
            Return _FechaModifica
        End Get
        Set(ByVal value As Date)
            _FechaModifica = value
        End Set
    End Property

    Public Property UsuarioModifica() As String
        Get
            Return _UsuarioModifica
        End Get
        Set(ByVal value As String)
            _UsuarioModifica = value
        End Set
    End Property

    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Overloads Function Equals(ByVal oeConCol As e_TablaDinamica_Dato) As Boolean Implements System.IEquatable(Of e_TablaDinamica_Dato).Equals
        Select Case oeConCol.TipoBusca
            Case 1 : If Me.Id = oeConCol.Id Then Return True
            Case 2 : If Me.IdColumna = oeConCol.IdColumna And Me.NroFila = oeConCol.NroFila Then Return True
            Case 3 : If Me.TipoReferencia = oeConCol.TipoReferencia Then Return True
        End Select
        Return False
    End Function

    Public Function Obtener(orden_Documento As e_Orden_Documento) As e_Orden_Documento Implements Ie_Orden_Documento.Obtener
        Throw New NotImplementedException()
    End Function

#End Region
End Class
