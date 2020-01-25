<DataContract()> _
Public Class e_ResumenAsistencia
    Implements Ie_ResumenAsistencia
    Implements IEquatable(Of e_ResumenAsistencia)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idplanilla As String
    Private _idtrabajador As String
    Private _dni As String
    Private _trabajador As String
    Private _indtipo As Integer
    Private _tipo As String
    Private _cantidad As Double
    Private _gozedehaber As Integer
    Private _fechainicio As Date
    Private _fechatermino As Date
    Private _observacion As String
    Private _diasnetos As Integer
    Private _indtipoaux As Integer
    Private _idestado As String
    Private _estado As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _fechamodifica As Date
    Private _usuariomodifica As String
    Private _activo As Boolean
    Private _codigosuspencion As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Equivale As Integer
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
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
    Public Property IdPlanilla() As String
        Get
            Return _idplanilla
        End Get
        Set(ByVal value As String)
            _idplanilla = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTrabajador() As String
        Get
            Return _idtrabajador
        End Get
        Set(ByVal value As String)
            _idtrabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property Dni() As String
        Get
            Return _dni
        End Get
        Set(ByVal value As String)
            _dni = value
        End Set
    End Property

    <DataMember()> _
    Public Property Trabajador() As String
        Get
            Return _trabajador
        End Get
        Set(ByVal value As String)
            _trabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndTipo() As Integer
        Get
            Return _indtipo
        End Get
        Set(ByVal value As Integer)
            _indtipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Tipo() As String
        Get
            Select Case _indtipo
                Case 0 : _tipo = "FALTAS"
                Case 1 : _tipo = "DESCANSOS"
                Case 2 : _tipo = "VACACIONES"
                Case 3 : _tipo = "COMPRA VACACIONES"
                Case 4 : _tipo = "HORAS EXTRAS 25%"
                Case 5 : _tipo = "HORAS EXTRAS 35%"
                Case 6 : _tipo = "HORAS DE NOCTURNA"
                Case 7 : _tipo = "LICENCIA POR PATERNIDAD"
            End Select
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cantidad() As Double
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Double)
            _cantidad = value
        End Set
    End Property

    <DataMember()> _
    Public Property GozedeHaber() As Integer
        Get
            Return _gozedehaber
        End Get
        Set(ByVal value As Integer)
            _gozedehaber = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInicio() As Date
        Get
            Return _fechainicio
        End Get
        Set(ByVal value As Date)
            _fechainicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaTermino() As Date
        Get
            Return _fechatermino
        End Get
        Set(ByVal value As Date)
            _fechatermino = value
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
    Public Property DiasNetos() As Integer
        Get
            Return _diasnetos
        End Get
        Set(ByVal value As Integer)
            _diasnetos = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndTipoAux() As Integer
        Get
            Return _indtipoaux
        End Get
        Set(ByVal value As Integer)
            _indtipoaux = value
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
    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
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

    <DataMember()> _
    Public Property CodigoSuspension() As String
        Get
            Return _codigosuspencion
        End Get
        Set(ByVal value As String)
            _codigosuspencion = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _idplanilla = String.Empty
        _idtrabajador = String.Empty
        _indtipo = -1
        _cantidad = 0
        _gozedehaber = -1
        _fechainicio = #1/1/1901#
        _fechatermino = #1/1/1901#
        _observacion = String.Empty
        _diasnetos = 0
        _indtipoaux = 0
        _idestado = String.Empty
        _estado = String.Empty
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _fechamodifica = #1/1/1901#
        _usuariomodifica = String.Empty
        _activo = True
        _codigosuspencion = String.Empty
    End Sub

    Public Sub New( _
          ByVal ls_Id As String _
          , ByVal ls_IdPlanilla As String _
          , ByVal ls_IdTrabajador As String _
          , ByVal ls_Dni As String _
          , ByVal ls_Trabajador As String _
          , ByVal ln_IndTipo As Integer _
          , ByVal ln_Cantidad As Double _
          , ByVal ln_GozedeHaber As Integer _
          , ByVal ld_FechaInicio As Date _
          , ByVal ld_FechaTermino As Date _
          , ByVal ls_Observacion As String _
          , ByVal ln_DiasNetos As Integer _
          , ByVal ln_IndTipoAux As Integer _
          , ByVal ls_IdEstado As String _
          , ByVal ls_Estado As String _
          , ByVal ld_FechaCreacion As Date _
          , ByVal ls_UsuarioCreacion As String _
          , ByVal ld_FechaModifica As Date _
          , ByVal ls_UsuarioModifica As String _
          , ByVal lb_Activo As Boolean _
       )
        _id = ls_Id
        _idplanilla = ls_IdPlanilla
        _idtrabajador = ls_IdTrabajador
        _dni = ls_Dni
        _trabajador = ls_Trabajador
        _indtipo = ln_IndTipo
        _cantidad = ln_Cantidad
        _gozedehaber = ln_GozedeHaber
        _fechainicio = ld_FechaInicio
        _fechatermino = ld_FechaTermino
        _observacion = ls_Observacion
        _diasnetos = ln_DiasNetos
        _indtipoaux = ln_IndTipoAux
        _idestado = ls_IdEstado
        _estado = ls_Estado
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function obtener(oeResumenAsistencia As e_ResumenAsistencia) As e_ResumenAsistencia Implements Ie_ResumenAsistencia.obtener
        Return oeResumenAsistencia
    End Function

    Public Overloads Function Equals(ByVal oeRA As e_ResumenAsistencia) As Boolean Implements System.IEquatable(Of e_ResumenAsistencia).Equals
        Select Case oeRA.Equivale
            Case 1 : If Me.Id = oeRA.Id Then Return True
            Case 2 : If Me.IdTrabajador = oeRA.IdTrabajador Then Return True
        End Select
        Return False
    End Function

#End Region

End Class
