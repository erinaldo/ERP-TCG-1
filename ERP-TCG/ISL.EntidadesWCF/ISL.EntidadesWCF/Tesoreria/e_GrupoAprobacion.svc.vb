


' NOTA: si cambia aquí el nombre de clase "e_GrupoAprobacion", también debe actualizar la referencia a "e_GrupoAprobacion" tanto en Web.config como en el archivo .svc asociado.
Public Class e_GrupoAprobacion
    Implements Ie_GrupoAprobacion

#Region "Propiedad"

    Private _id As String
    Private _glosa As String
    Private _idcheque As String
    Private _nrocheque As String
    Private _importe As Double
    Private _activo As Boolean
    Private _fecha As Date
    Private _fechacreacion As Date
    Private _fechaaprobacion As Date
    Private _usuariocreacion As String
    Private _trabajador As String
    Private _idestado As String
    Private _estado As String
    Private _trabajadoraprobacion As String
    Private _codigo As String
    Private _glosagrupo As String
    Private _codigogrupo As String
    Private _cuentabancaria As String
    Private _importetotal As Double

    Public loListaGrupoAprobacionDet As New List(Of e_GrupoAprobacionDet)
    Public oeChequeEmitido As New e_ChequeEmitido

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()>
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

    Event DatoCambiado()

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
    Public Property ImporteTotal() As Double
        Get
            Return _importetotal
        End Get
        Set(ByVal value As Double)
            _importetotal = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCheque() As String
        Get
            Return _idcheque
        End Get
        Set(ByVal value As String)
            _idcheque = value
            RaiseEvent DatoCambiado()
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
    Public Property GlosaGrupo() As String
        Get
            Return _glosagrupo
        End Get
        Set(ByVal value As String)
            _glosagrupo = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoGrupo() As String
        Get
            Return _codigogrupo
        End Get
        Set(ByVal value As String)
            _codigogrupo = value
        End Set
    End Property

    <DataMember()> _
    Public Property CuentaBancaria() As String
        Get
            Return _cuentabancaria
        End Get
        Set(ByVal value As String)
            _cuentabancaria = value
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property TrabajadorAprobacion() As String
        Get
            Return _trabajadoraprobacion
        End Get
        Set(ByVal value As String)
            _trabajadoraprobacion = value
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
    Public Property Importe() As Double
        Get
            Return _importe
        End Get
        Set(ByVal value As Double)
            _importe = value

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
    Public Property FechaAprobacion() As Date
        Get
            Return _fechaaprobacion
        End Get
        Set(ByVal value As Date)
            _fechaaprobacion = value
            RaiseEvent DatoCambiado()
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
    Public Property IdTrabajadorAprobacion() As String
        Get
            Return _trabajador
        End Get
        Set(ByVal value As String)
            _trabajador = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NroCheque() As String
        Get
            Return _nrocheque
        End Get
        Set(ByVal value As String)
            _nrocheque = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Glosa As String _
              , ByVal ls_IdCheque As String _
              , ByVal ln_Importe As Double _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_Fecha As Date _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ld_FechaAprobacion As Date _
              , ByVal ld_UsuarioCreacion As String _
              , ByVal ls_IdTrabajadorAprobacion As String _
              , ByVal ls_TrabajadorAprobacion As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_GlosaGrupo As String _
              , ByVal ls_CodigoGrupo As String _
              , ByVal ls_CuentaBancaria As String _
              , ByVal ld_ImporteTotal As Double _
              , ByVal ls_NroCheque As String)
        _codigo = ls_Codigo
        _glosagrupo = ls_GlosaGrupo
        _nrocheque = ls_NroCheque
        _codigogrupo = ls_CodigoGrupo
        _cuentabancaria = ls_CuentaBancaria
        _importetotal = ld_ImporteTotal
        _id = ls_Id
        _glosa = ls_Glosa
        _idcheque = ls_IdCheque
        _importe = ln_Importe
        _activo = lb_Activo
        _fecha = ld_Fecha
        _fechacreacion = ld_FechaCreacion
        _fechaaprobacion = ld_FechaAprobacion
        _usuariocreacion = ld_UsuarioCreacion
        _trabajador = ls_IdTrabajadorAprobacion
        _trabajadoraprobacion = ls_TrabajadorAprobacion
    End Sub

#End Region

    Public Function Obtener(ByVal grupoaprobacion As e_GrupoAprobacion) As e_GrupoAprobacion Implements Ie_GrupoAprobacion.Obtener
        Return grupoaprobacion
    End Function

End Class

