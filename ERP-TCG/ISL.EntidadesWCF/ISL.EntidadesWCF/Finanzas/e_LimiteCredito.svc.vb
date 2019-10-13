' NOTA: si cambia aquí el nombre de clase "e_LimiteCredito", también debe actualizar la referencia a "e_LimiteCredito" tanto en Web.config como en el archivo .svc asociado.
Public Class e_LimiteCredito
    Implements Ie_LimiteCredito

#Region "Propiedad"

    Private _id As String
    Private _idempresabanco As String
    Private _idtipodocumento As String
    Private _montocreditomn As Double
    Private _fechainicial As Date
    Private _fechafinal As Date
    Private _activo As Boolean
    Private _tipocambio As Double
    Private _montocreditome As Double
    Private _idmoneda As String

    Public TipoOperacion As String
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Event DatoCambiado()

    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Public Property IdEmpresaBanco() As String
        Get
            Return _idempresabanco
        End Get
        Set(ByVal value As String)
            _idempresabanco = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property IdTipoDocumento() As String
        Get
            Return _idtipodocumento
        End Get
        Set(ByVal value As String)
            _idtipodocumento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property MontoCreditoMN() As Double
        Get
            Return _montocreditomn
        End Get
        Set(ByVal value As Double)
            _montocreditomn = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property FechaInicial() As Date
        Get
            Return _fechainicial
        End Get
        Set(ByVal value As Date)
            _fechainicial = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property FechaFinal() As Date
        Get
            Return _fechafinal
        End Get
        Set(ByVal value As Date)
            _fechafinal = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property TipoCambio() As Double
        Get
            Return _tipocambio
        End Get
        Set(ByVal value As Double)
            _tipocambio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property MontoCreditoME() As Double
        Get
            Return _montocreditome
        End Get
        Set(ByVal value As Double)
            _montocreditome = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property IdMoneda() As String
        Get
            Return _idmoneda
        End Get
        Set(ByVal value As String)
            _idmoneda = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
        FechaInicial = Date.Parse("01/01/1901")
        FechaFinal = Date.Parse("01/01/1901")
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdEmpresaBanco As String _
              , ByVal ls_IdTipoDocumento As String _
              , ByVal ln_MontoCreditoMN As Double _
              , ByVal ld_FechaInicial As Date _
              , ByVal ld_FechaFinal As Date _
              , ByVal lb_Activo As Boolean _
              , ByVal ln_TipoCambio As Double _
              , ByVal ln_MontoCreditoME As Double _
              , ByVal ls_IdMoneda As String _
           )
        _id = ls_Id
        _idempresabanco = ls_IdEmpresaBanco
        _idtipodocumento = ls_IdTipoDocumento
        _montocreditomn = ln_MontoCreditoMN
        _fechainicial = ld_FechaInicial
        _fechafinal = ld_FechaFinal
        _activo = lb_Activo
        _tipocambio = ln_TipoCambio
        _montocreditome = ln_MontoCreditoME
        _idmoneda = ls_IdMoneda
    End Sub

    Public Function Obtener(ByVal LimiteCredito As e_LimiteCredito) As e_LimiteCredito Implements Ie_LimiteCredito.Obtener
        Return LimiteCredito
    End Function

#End Region

End Class
