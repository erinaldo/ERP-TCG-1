
' NOTA: si cambia aquí el nombre de clase "e_RegistrosEditados", también debe actualizar la referencia a "e_RegistrosEditados" tanto en Web.config como en el archivo .svc asociado.
<DataContract()> _
Public Class e_RegistrosEditados
    Implements Ie_RegistrosEditados

    'Public Sub DoWork() Implements Ie_RegistrosEditados.DoWork
    'End Sub

#Region "Declaración de variables"
    Private _Id As String
    Private _IdTabla As String
    Private _IdRegistro As String
    Private _Referencia As String
    Private _UsuarioEdita As String
    Private _FechaEditado As Date
    Private _FechaModificado As Date
    Private _IndEditado As Boolean
    Private _Activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
#End Region

#Region "Propiedades"
    <DataMember()> _
    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTabla() As String
        Get
            Return _IdTabla
        End Get
        Set(ByVal value As String)
            _IdTabla = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdRegistro() As String
        Get
            Return _IdRegistro
        End Get
        Set(ByVal value As String)
            _IdRegistro = value
        End Set
    End Property

    <DataMember()> _
    Public Property Referencia() As String
        Get
            Return _Referencia
        End Get
        Set(ByVal value As String)
            _Referencia = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioEdita() As String
        Get
            Return _UsuarioEdita
        End Get
        Set(ByVal value As String)
            _UsuarioEdita = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaEditado() As Date
        Get
            Return _FechaEditado
        End Get
        Set(ByVal value As Date)
            _FechaEditado = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaModificado() As Date
        Get
            Return _FechaModificado
        End Get
        Set(ByVal value As Date)
            _FechaModificado = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndEditado() As Boolean
        Get
            Return _IndEditado
        End Get
        Set(ByVal value As Boolean)
            _IndEditado = value
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = "I"
        Id = ""
        IndEditado = 0
        FechaModificado = Date.Now
        Activo = True
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdTabla As String _
              , ByVal ls_IdRegistro As String _
              , ByVal ls_Referencia As String _
              , ByVal ls_UsuarioEdita As String _
              , ByVal ld_FechaEditado As Date _
              , ByVal ld_FechaModificado As Date _
              , ByVal lb_IndEditado As Boolean _
              , ByVal lb_Activo As Boolean)
        _Id = ls_Id
        _IdTabla = ls_IdTabla
        _IdRegistro = ls_IdRegistro
        _Referencia = ls_Referencia
        _UsuarioEdita = ls_UsuarioEdita
        _FechaEditado = ld_FechaEditado
        _FechaModificado = ld_FechaModificado
        _IndEditado = lb_IndEditado
        _Activo = lb_Activo
    End Sub
#End Region

#Region "Métodos"


    Public Function Obtener(ByVal RegistrosEditados As e_RegistrosEditados) As e_RegistrosEditados Implements Ie_RegistrosEditados.Obtener
        Return RegistrosEditados
    End Function

#End Region

End Class
