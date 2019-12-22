' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_CierreTurno_Detalle" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_CierreTurno_Detalle.svc o e_CierreTurno_Detalle.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ERP.EntidadesWCF

Public Class e_CierreTurno_Detalle
    Implements Ie_CierreTurno_Detalle

    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    <DataMember()>
    Public TipoOperacion As String
    <DataMember()>
    Public Modificado As Boolean = False
    <DataMember()>
    Public Equivale As Integer
    <DataMember()>
    Public IndPrincipal As Integer
    <DataMember()>
    Public CargaCompleta As Boolean

    Public Event DatoCambiado()
#Region "Declaración de variables"

    Private _Id As String
    Private _IdEmpresaSis As String
    Private _IdSucursal As String
    Private _IdCierreTurno As String
    Private _Grupo As String
    Private _Rubro As String
    Private _Descripcion As String
    Private _IdConcepto As String
    Private _Concepto As String
    Private _ValorInicial As Double
    Private _ValorFinal As Double
    Private _ValorDiferencia As Double
    Private _ValorERP As Double
    Private _ValorReal As Double
    Private _ValorAux1 As Double
    Private _ValorAux2 As Double
    Private _Glosa As String
    Private _UsuarioCrea As String
    Private _FechaCrea As Date
    Private _UsuarioModifica As String
    Private _FechaModifica As Date
    Private _Activo As Boolean

#End Region
#Region "Constructor"
    Public Sub New()
        TipoOperacion = ""
        _Id = ""
        _IdEmpresaSis = ""
        _IdSucursal = ""
        _IdCierreTurno = ""
        _Grupo = ""
        _Rubro = ""
        _Descripcion = ""
        _IdConcepto = ""
        _Concepto = ""
        _ValorInicial = 0
        _ValorFinal = 0
        _ValorDiferencia = 0
        _ValorERP = 0
        _ValorReal = 0
        _ValorAux1 = 0
        _ValorAux2 = 0
        _Glosa = ""
        _UsuarioCrea = ""
        _FechaCrea = #01/01/1901#
        _UsuarioModifica = ""
        _FechaModifica = #01/01/1901#
        _Activo = True
    End Sub

    Public Sub New(
          ByVal ls_Id As String _
          , ByVal ls_IdEmpresaSis As String _
          , ByVal ls_IdSucursal As String _
          , ByVal ls_IdCierreTurno As String _
          , ByVal ls_Grupo As String _
          , ByVal ls_Rubro As String _
          , ByVal ls_Descripcion As String _
          , ByVal ls_IdConcepto As String _
          , ByVal ls_Concepto As String _
          , ByVal ln_ValorInicial As Double _
          , ByVal ln_ValorFinal As Double _
          , ByVal ln_ValorDiferencia As Double _
          , ByVal ln_ValorERP As Double _
          , ByVal ln_ValorReal As Double _
          , ByVal ln_ValorAux1 As Double _
          , ByVal ln_ValorAux2 As Double _
          , ByVal ls_Glosa As String _
          , ByVal ls_UsuarioCrea As String _
          , ByVal ld_FechaCrea As Date _
          , ByVal ls_UsuarioModifica As String _
          , ByVal ld_FechaModifica As Date _
          , ByVal lb_Activo As Boolean
       )
        _Id = ls_Id
        _IdEmpresaSis = ls_IdEmpresaSis
        _IdSucursal = ls_IdSucursal
        _IdCierreTurno = ls_IdCierreTurno
        _Grupo = ls_Grupo
        _Rubro = ls_Rubro
        _Descripcion = ls_Descripcion
        _IdConcepto = ls_IdConcepto
        _Concepto = ls_Concepto
        _ValorInicial = ln_ValorInicial
        _ValorFinal = ln_ValorFinal
        _ValorDiferencia = ln_ValorDiferencia
        _ValorERP = ln_ValorERP
        _ValorReal = ln_ValorReal
        _ValorAux1 = ln_ValorAux1
        _ValorAux2 = ln_ValorAux2
        _Glosa = ls_Glosa
        _UsuarioCrea = ls_UsuarioCrea
        _FechaCrea = ld_FechaCrea
        _UsuarioModifica = ls_UsuarioModifica
        _FechaModifica = ld_FechaModifica
        _Activo = lb_Activo
    End Sub

    Public Sub DoWork() Implements Ie_CierreTurno_Detalle.DoWork
        Throw New NotImplementedException()
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

    Public Property IdEmpresaSis() As String
        Get
            Return _IdEmpresaSis
        End Get
        Set(ByVal value As String)
            _IdEmpresaSis = value
        End Set
    End Property

    Public Property IdSucursal() As String
        Get
            Return _IdSucursal
        End Get
        Set(ByVal value As String)
            _IdSucursal = value
        End Set
    End Property

    Public Property IdCierreTurno() As String
        Get
            Return _IdCierreTurno
        End Get
        Set(ByVal value As String)
            _IdCierreTurno = value
        End Set
    End Property

    Public Property Grupo() As String
        Get
            Return _Grupo
        End Get
        Set(ByVal value As String)
            _Grupo = value
        End Set
    End Property

    Public Property Rubro() As String
        Get
            Return _Rubro
        End Get
        Set(ByVal value As String)
            _Rubro = value
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

    Public Property IdConcepto() As String
        Get
            Return _IdConcepto
        End Get
        Set(ByVal value As String)
            _IdConcepto = value
        End Set
    End Property

    Public Property Concepto() As String
        Get
            Return _Concepto
        End Get
        Set(ByVal value As String)
            _Concepto = value
        End Set
    End Property

    Public Property ValorInicial() As Double
        Get
            Return _ValorInicial
        End Get
        Set(ByVal value As Double)
            _ValorInicial = value
        End Set
    End Property

    Public Property ValorFinal() As Double
        Get
            Return _ValorFinal
        End Get
        Set(ByVal value As Double)
            _ValorFinal = value
        End Set
    End Property

    Public Property ValorDiferencia() As Double
        Get
            Return _ValorDiferencia
        End Get
        Set(ByVal value As Double)
            _ValorDiferencia = value
        End Set
    End Property

    Public Property ValorERP() As Double
        Get
            Return _ValorERP
        End Get
        Set(ByVal value As Double)
            _ValorERP = value
        End Set
    End Property

    Public Property ValorReal() As Double
        Get
            Return _ValorReal
        End Get
        Set(ByVal value As Double)
            _ValorReal = value
        End Set
    End Property

    Public Property ValorAux1() As Double
        Get
            Return _ValorAux1
        End Get
        Set(ByVal value As Double)
            _ValorAux1 = value
        End Set
    End Property

    Public Property ValorAux2() As Double
        Get
            Return _ValorAux2
        End Get
        Set(ByVal value As Double)
            _ValorAux2 = value
        End Set
    End Property

    Public Property Glosa() As String
        Get
            Return _Glosa
        End Get
        Set(ByVal value As String)
            _Glosa = value
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

    Public Property FechaCrea() As Date
        Get
            Return _FechaCrea
        End Get
        Set(ByVal value As Date)
            _FechaCrea = value
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

    Public Property FechaModifica() As Date
        Get
            Return _FechaModifica
        End Get
        Set(ByVal value As Date)
            _FechaModifica = value
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

End Class
