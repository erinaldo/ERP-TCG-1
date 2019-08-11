

' NOTA: si cambia aquí el nombre de clase "e_IncidenciasAutentificadas", también debe actualizar la referencia a "e_IncidenciasAutentificadas" tanto en Web.config como en el archivo .svc asociado.
<DataContract()> _
Public Class e_IncidenciasAutentificadas
    Implements Ie_IncidenciasAutentificadas

    'Public Sub DoWork() Implements Ie_IncidenciasAutentificadas.DoWork
    'End Sub
#Region "Declaracion de Variables"

    Private _Id As String
    Private _IdArea As String
    Private _IdActividadNegocio As String
    Private _IdResponsableAutoriza As String
    Private _IdUsuarioIncidente As String
    Private _Referencia As String
    Private _FechaReferencia As Date
    Private _Glosa As String
    Private _Activo As Boolean
    Private _Indicador As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public TipoPerfil As String
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
    Public Property IdArea() As String
        Get
            Return _IdArea
        End Get
        Set(ByVal value As String)
            _IdArea = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdActividadNegocio() As String
        Get
            Return _IdActividadNegocio
        End Get
        Set(ByVal value As String)
            _IdActividadNegocio = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdResponsableAutoriza() As String
        Get
            Return _IdResponsableAutoriza
        End Get
        Set(ByVal value As String)
            _IdResponsableAutoriza = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdUsuarioIncidente() As String
        Get
            Return _IdUsuarioIncidente
        End Get
        Set(ByVal value As String)
            _IdUsuarioIncidente = value
        End Set
    End Property

    Public Property Referencia() As String
        Get
            Return _Referencia
        End Get
        Set(ByVal value As String)
            _Referencia = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaReferencia() As Date
        Get
            Return _FechaReferencia
        End Get
        Set(ByVal value As Date)
            _FechaReferencia = value
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _Glosa
        End Get
        Set(ByVal value As String)
            _Glosa = value
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
    <DataMember()> _
    Public Property Indicador() As String
        Get
            Return _Indicador
        End Get
        Set(ByVal value As String)
            _Indicador = value
        End Set
    End Property
#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        Id = ""
        IdResponsableAutoriza = ""
        Activo = True
    End Sub

    Public Sub New(ByVal ls_Id As String, _
                   ByVal ls_IdArea As String, _
                   ByVal ls_IdActividadNegocio As String, _
                   ByVal ls_IdResponsableAutoriza As String, _
                   ByVal ls_IdUsuarioIncidente As String, _
                   ByVal ls_Referencia As String, _
                   ByVal ld_FechaReferencia As Date, _
                   ByVal ls_Glosa As String, _
                   ByVal lb_Actico As Boolean)
        _Id = ls_Id
        _IdArea = ls_IdArea
        _IdActividadNegocio = ls_IdActividadNegocio
        _IdResponsableAutoriza = ls_IdResponsableAutoriza
        _IdUsuarioIncidente = ls_IdUsuarioIncidente
        _Referencia = ls_Referencia
        _FechaReferencia = ld_FechaReferencia
        _Glosa = ls_Glosa
        _Activo = lb_Actico
    End Sub

#End Region

End Class


