
<DataContract()> _
Public Class e_ActividadRestringida
    Implements Ie_ActividadRestringida
    Implements IEquatable(Of e_ActividadRestringida)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idactividadnegocio As String
    Private _procesonegocio As String
    Private _actividadnegocio As String
    Private _idaccionsistema As String
    Private _fechacreacion As Date
    Private _activo As Boolean
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public IdProcesoNegocio As String
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
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
    Public Property IdActividadNegocio() As String
        Get
            Return _idactividadnegocio
        End Get
        Set(ByVal value As String)
            _idactividadnegocio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
Public Property ProcesoNegocio() As String
        Get
            Return _procesonegocio
        End Get
        Set(ByVal value As String)
            _procesonegocio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
Public Property ActividadNegocio() As String
        Get
            Return _actividadnegocio
        End Get
        Set(ByVal value As String)
            _actividadnegocio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdAccionSistema() As String
        Get
            Return _idaccionsistema
        End Get
        Set(ByVal value As String)
            _idaccionsistema = value
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
        _idactividadnegocio = String.Empty
        _procesonegocio = String.Empty
        _actividadnegocio = String.Empty
        _idaccionsistema = String.Empty
        _fechacreacion = #1/1/1901#
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdActividadNegocio As String _
              , ByVal ls_IdProcesoNegocio As String _
              , ByVal ls_ProcesoNegocio As String _
              , ByVal ls_ActividadNegocio As String _
              , ByVal ls_IdAccionSistema As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idactividadnegocio = ls_IdActividadNegocio
        IdProcesoNegocio = ls_IdProcesoNegocio
        _procesonegocio = ls_ProcesoNegocio
        _actividadnegocio = ls_ActividadNegocio
        _idaccionsistema = ls_IdAccionSistema
        _fechacreacion = ld_FechaCreacion
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal actividadrestringida As e_ActividadRestringida) As e_ActividadRestringida Implements Ie_ActividadRestringida.Obtener
        Return actividadrestringida
    End Function

    Public Overloads Function Equals(ByVal oe As e_ActividadRestringida) _
    As Boolean Implements System.IEquatable(Of e_ActividadRestringida).Equals
        If Me.IdActividadNegocio = oe.IdActividadNegocio Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region



End Class
