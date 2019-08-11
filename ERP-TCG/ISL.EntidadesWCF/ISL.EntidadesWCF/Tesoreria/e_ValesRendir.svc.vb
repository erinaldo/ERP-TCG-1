


<DataContract()> _
Public Class e_ValesRendir
    Implements Ie_ValesRendir

#Region "Propiedad"

    Private _id As String
    Private _idtrabajador As String
    Private _trabajador As String
    Private _autoriza As String
    Private _glosa As String
    Private _importe As Double
    Private _nrovale As String
    Private _fecha As Date
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _idTrabajadorAutoriza As String
    Private _activo As Boolean
    Private _indrendido As Boolean
    Private _idvale As String
    Private _centro As New e_Centro
    Private _referencia As String
    Private _egreso As Double
    Private _ingreso As Double
    Private _seleccion As Boolean

    <DataMember()> _
    Public IdCuentaCorriente As String
    <DataMember()> _
    Public IdCaja As String = ""
    <DataMember()> _
    Public IndCerrado As String
    <DataMember()> _
    Public FechaCierre As Date
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

    Event DatoCambiado()

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Seleccion() As Boolean
        Get
            Return _seleccion
        End Get
        Set(ByVal value As Boolean)
            _seleccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Ingreso() As Double
        Get
            Return _ingreso
        End Get
        Set(ByVal value As Double)
            _ingreso = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
Public Property Egreso() As Double
        Get
            Return _egreso
        End Get
        Set(ByVal value As Double)
            _egreso = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As String
        Get
            Return _activo
        End Get
        Set(ByVal value As String)
            _activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdVale() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Referencia() As String
        Get
            Return _referencia
        End Get
        Set(ByVal value As String)
            _referencia = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Trabajador() As String
        Get
            Return _trabajador
        End Get
        Set(ByVal value As String)
            _trabajador = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Autoriza() As String
        Get
            Return _autoriza
        End Get
        Set(ByVal value As String)
            _autoriza = value
            RaiseEvent DatoCambiado()
        End Set
    End Property


    <DataMember()> _
    Public Property IdTrabajadorAutoriza() As String
        Get
            Return _idTrabajadorAutoriza
        End Get
        Set(ByVal value As String)
            _idTrabajadorAutoriza = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTrabajador() As String
        Get
            Return _idtrabajador
        End Get
        Set(ByVal value As String)
            _idtrabajador = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Importe() As Double
        Get
            Return _importe
        End Get
        Set(ByVal value As Double)
            _importe = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NroVale() As String
        Get
            Return _nrovale
        End Get
        Set(ByVal value As String)
            _nrovale = value
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
    Public Property IndRendido() As Boolean
        Get
            Return _indrendido
        End Get
        Set(ByVal value As Boolean)
            _indrendido = value
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
    Public Property IdCentro() As String
        Get
            Return _centro.Id
        End Get
        Set(ByVal value As String)
            _centro.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Centro() As String
        Get
            Return _centro.Nombre
        End Get
        Set(ByVal value As String)
            _centro.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property


#End Region

#Region "Constructor"
    Public Sub New()
        _id = ""
        _idtrabajador = ""
        _glosa = ""
        _importe = 0
        _fecha = Date.Parse("01/01/1901")
        _fechacreacion = Date.Parse("01/01/1901")
        FechaCierre = Date.Parse("01/01/1901")
        _usuariocreacion = ""
        _idTrabajadorAutoriza = ""
        _indrendido = 0
        _nrovale = ""
        _seleccion = False
    End Sub

    Public Sub New(ByVal lb_Seleccion As Boolean _
              , ByVal ls_Id As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ls_Trabajador As String _
              , ByVal ls_Glosa As String _
              , ByVal ln_Importe As Double _
              , ByVal ls_NroVale As String _
              , ByVal ld_Fecha As Date _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ls_IdTrabajadorAutoriza As String _
              , ByVal ls_Autoriza As String _
              , ByVal lb_IndRendido As Boolean _
              , ByVal ls_IdCentro As String _
              , ByVal ls_Centro As String _
              , ByVal ls_Referencia As String _
              , ByVal ld_Ingreso As Double _
              , ByVal ld_Egreso As Double)
        _seleccion = lb_Seleccion
        _id = ls_Id
        _idtrabajador = ls_IdTrabajador
        _trabajador = ls_Trabajador
        _glosa = ls_Glosa
        _importe = ln_Importe
        _nrovale = ls_NroVale
        _fecha = ld_Fecha
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _idTrabajadorAutoriza = ls_IdTrabajadorAutoriza
        _autoriza = ls_Autoriza
        _indrendido = lb_IndRendido
        _centro.Id = ls_IdCentro
        _centro.Nombre = ls_Centro
        _referencia = ls_Referencia
        _ingreso = ld_Ingreso
        _egreso = ld_Egreso
    End Sub
#End Region

    Public Function Obtener(ByVal valesrendir As e_ValesRendir) As e_ValesRendir Implements Ie_ValesRendir.Obtener
        Return valesrendir
    End Function

End Class

