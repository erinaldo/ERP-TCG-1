<DataContract()> _
Public Class e_ActividadRestringida_Usuario
    Implements Ie_ActividadRestringida_Usuario
    Implements IEquatable(Of e_ActividadRestringida_Usuario)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idactividadrestringida As String
    Private _accionsistema As String
    Private _actividadrestringida As String
    Private _idusuario As String
    Private _fechacreacion As Date
    Private _activo As Boolean
    Private _idprocesonegocio As String
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public IdActividadNegocio As String
    <DataMember()> _
    Public CodigoAccion As String
    <DataMember()> _
    Public Equivale As Integer = 0

    Event DatoCambiado()

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
    Public Property IdActividadRestringida() As String
        Get
            Return _idactividadrestringida
        End Get
        Set(ByVal value As String)
            _idactividadrestringida = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property AccionSistema() As String
        Get
            Return _accionsistema
        End Get
        Set(ByVal value As String)
            _accionsistema = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property ActividadRestringida() As String
        Get
            Return _actividadrestringida
        End Get
        Set(ByVal value As String)
            _actividadrestringida = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdUsuario() As String
        Get
            Return _idusuario
        End Get
        Set(ByVal value As String)
            _idusuario = value
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
    Public Property IdProcesoNegocio() As String
        Get
            Return _idprocesonegocio
        End Get
        Set(ByVal value As String)
            _idprocesonegocio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        _id = String.Empty
        _idactividadrestringida = String.Empty
        _idusuario = String.Empty
        _fechacreacion = #1/1/1901#
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdActividadRestringida As String _
              , ByVal ls_AccionSistema As String _
              , ByVal ls_ActividadRestringida As String _
              , ByVal ls_IdActividadNegocio As String _
              , ByVal ls_CodigoAccion As String _
              , ByVal ls_IdUsuario As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idactividadrestringida = ls_IdActividadRestringida
        _actividadrestringida = ls_ActividadRestringida
        IdActividadNegocio = ls_IdActividadNegocio
        _accionsistema = ls_AccionSistema
        CodigoAccion = ls_CodigoAccion
        _idusuario = ls_IdUsuario
        _fechacreacion = ld_FechaCreacion
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal actividadrestringida_usuario As e_ActividadRestringida_Usuario) As e_ActividadRestringida_Usuario Implements Ie_ActividadRestringida_Usuario.Obtener
        Return actividadrestringida_usuario
    End Function

    Public Overloads Function Equals(ByVal oe As e_ActividadRestringida_Usuario) As Boolean Implements System.IEquatable(Of e_ActividadRestringida_Usuario).Equals
        Select Case oe.Equivale
            Case 0 : If Me.IdActividadRestringida = oe.IdActividadRestringida Then Return True
            Case 1 : If Me.IdActividadNegocio = oe.IdActividadNegocio And Me.AccionSistema = oe.AccionSistema Then Return True
        End Select
        Return False
    End Function

End Class
