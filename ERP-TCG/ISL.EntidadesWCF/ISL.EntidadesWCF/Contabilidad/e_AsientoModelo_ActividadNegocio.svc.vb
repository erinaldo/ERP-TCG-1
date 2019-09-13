<DataContract()> _
Public Class e_AsientoModelo_ActividadNegocio
    Implements Ie_AsientoModelo_ActividadNegocio
    Implements IEquatable(Of e_AsientoModelo_ActividadNegocio)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idasientomodelo As String
    Private _idactividadnegocio As String
    Private _procesonegocio As String
    Private _actividadnegocio As String
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
    Public leReferencia As New List(Of e_AsientoModelo_Referencia)
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
    Public Property IdAsientoModelo() As String
        Get
            Return _idasientomodelo
        End Get
        Set(ByVal value As String)
            _idasientomodelo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdActividadNegocio() As String
        Get
            Return _idactividadnegocio
        End Get
        Set(ByVal value As String)
            _idactividadnegocio = value
        End Set
    End Property

    <DataMember()> _
    Public Property ProcesoNegocio() As String
        Get
            Return _procesonegocio
        End Get
        Set(ByVal value As String)
            _procesonegocio = value
        End Set
    End Property

    <DataMember()> _
    Public Property ActividadNegocio() As String
        Get
            Return _actividadnegocio
        End Get
        Set(ByVal value As String)
            _actividadnegocio = value
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
        _idasientomodelo = String.Empty
        _idactividadnegocio = String.Empty
        _procesonegocio = String.Empty
        _actividadnegocio = String.Empty
        _usuariocreacion = String.Empty
        _fechacreacion = #1/1/1901#
        _usuariomodifica = String.Empty
        _fechamodifica = #1/1/1901#
        _activo = True
        TipoOperacion = String.Empty
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdAsientoModelo As String _
              , ByVal ls_IdActividadNegocio As String _
              , ByVal ls_ProcesoNegocio As String _
              , ByVal ls_ActividadNegocio As String _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioModifica As String _
              , ByVal ld_FechaModifica As Date _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idasientomodelo = ls_IdAsientoModelo
        _idactividadnegocio = ls_IdActividadNegocio
        _procesonegocio = ls_ProcesoNegocio
        _actividadnegocio = ls_ActividadNegocio
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _usuariomodifica = ls_UsuarioModifica
        _fechamodifica = ld_FechaModifica
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(asientomodeloactividadnegocio As e_AsientoModelo_ActividadNegocio) As e_AsientoModelo_ActividadNegocio Implements Ie_AsientoModelo_ActividadNegocio.Obtener
        Return asientomodeloactividadnegocio
    End Function

    Public Overloads Function Equals(ByVal oeAMActNeg As e_AsientoModelo_ActividadNegocio) As Boolean Implements IEquatable(Of ISL.EntidadesWCF.e_AsientoModelo_ActividadNegocio).Equals
        Select Case oeAMActNeg.Equivale
            Case 0 : If Me.Id.Trim = oeAMActNeg.Id.Trim Then Return True
            Case 1 : If Me.IdActividadNegocio.Trim = oeAMActNeg.IdActividadNegocio.Trim Then Return True
        End Select
        Return False
    End Function

#End Region

End Class
