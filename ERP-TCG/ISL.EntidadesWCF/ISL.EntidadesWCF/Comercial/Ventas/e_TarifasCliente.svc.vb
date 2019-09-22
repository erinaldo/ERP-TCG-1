


' NOTA: si cambia aquí el nombre de clase "e_TarifasCliente", también debe actualizar la referencia a "e_TarifasCliente" tanto en Web.config como en el archivo .svc asociado.

<DataContract()> _
Public Class e_TarifasCliente
    Implements Ie_TarifasCliente

    'Public Sub DoWork() Implements Ie_TarifasCliente.DoWork
    'End Sub

#Region "Propiedad"
    Private _Id As String
    Private _IdCliente As String
    Private _IdTipoRuta As String
    Private _IdTipoVehiculo As String
    Private _Tarifa As Double
    Private _IndConsolidado As Integer
    Private _Observacion As String
    Private _UsuarioCreacion As String
    Private _Activo As Boolean
    Private _IdOrigen As String
    Private _IdDestino As String
    Private _FechaInicio As Date
    Private _FechaFin As Date
    Private _IndHistorial As Integer
    Private _IndActual As Integer
    Private _Porcentaje As Double
    Private _IdTipoCarga As String
    Private _IndCarga As Integer
    Private _IndDescarga As Integer
    Private _IndContraEntrega As Integer
    Private _IndVariable As Integer
    Private _IndOtros As Integer
    Private _FInicioCampaña As Date
    Private _FFinCampaña As Date
    Private _IdMaterial As String
    Private _AceptaComision As Boolean
    Private _IndMaterial As Boolean
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()>
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()> _
    Public e_ListaTarifasCliente As New List(Of e_TarifasCliente)

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
    Public Property IdCliente() As String
        Get
            Return _IdCliente
        End Get
        Set(ByVal value As String)
            _IdCliente = value
        End Set
    End Property
    <DataMember()> _
    Public Property IdTipoRuta() As String
        Get
            Return _IdTipoRuta
        End Get
        Set(ByVal value As String)
            _IdTipoRuta = value
        End Set
    End Property
    <DataMember()> _
    Public Property IdTipoVehiculo() As String
        Get
            Return _IdTipoVehiculo
        End Get
        Set(ByVal value As String)
            _IdTipoVehiculo = value
        End Set
    End Property
    <DataMember()> _
    Public Property Tarifa() As Double
        Get
            Return _Tarifa.ToString("###,##0.0000")
        End Get
        Set(ByVal value As Double)
            _Tarifa = value
        End Set
    End Property
    <DataMember()> _
    Public Property IndConsolidado() As Integer
        Get
            Return _IndConsolidado
        End Get
        Set(ByVal value As Integer)
            _IndConsolidado = value
        End Set
    End Property
    <DataMember()> _
    Public Property Observacion() As String
        Get
            Return _Observacion
        End Get
        Set(ByVal value As String)
            _Observacion = value
        End Set
    End Property
    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _UsuarioCreacion
        End Get
        Set(ByVal value As String)
            _UsuarioCreacion = value

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
    Public Property IdOrigen() As String
        Get
            Return _IdOrigen
        End Get
        Set(ByVal value As String)
            _IdOrigen = value
        End Set
    End Property
    <DataMember()> _
    Public Property IdDestino() As String
        Get
            Return _IdDestino
        End Get
        Set(ByVal value As String)
            _IdDestino = value
        End Set
    End Property
    <DataMember()> _
    Public Property FechaInicio() As Date
        Get
            Return _FechaInicio
        End Get
        Set(ByVal value As Date)
            _FechaInicio = value
        End Set
    End Property
    <DataMember()> _
    Public Property FechaFin() As Date
        Get
            Return _FechaFin
        End Get
        Set(ByVal value As Date)
            _FechaFin = value
        End Set
    End Property
    <DataMember()> _
    Public Property IndHistorial() As Integer
        Get
            Return _IndHistorial
        End Get
        Set(ByVal value As Integer)
            _IndHistorial = value
        End Set
    End Property
    <DataMember()> _
    Public Property IndActual() As Integer
        Get
            Return _IndActual
        End Get
        Set(ByVal value As Integer)
            _IndActual = value
        End Set
    End Property
    <DataMember()> _
    Public Property Porcentaje() As Double
        Get
            Return _Porcentaje
        End Get
        Set(ByVal value As Double)
            _Porcentaje = value
        End Set
    End Property
    <DataMember()> _
    Public Property IdTipoCarga() As String
        Get
            Return _IdTipoCarga

        End Get
        Set(value As String)
            _IdTipoCarga = value
        End Set
    End Property
    <DataMember()> _
    Public Property IndCarga() As Integer
        Get
            Return _IndCarga
        End Get
        Set(value As Integer)
            _IndCarga = value
        End Set
    End Property
    <DataMember()> _
    Public Property IndDescarga() As Integer
        Get
            Return _IndDescarga
        End Get
        Set(value As Integer)
            _IndDescarga = value
        End Set
    End Property
    <DataMember()> _
    Public Property IndContraEntrega() As Integer
        Get
            Return _IndContraEntrega
        End Get
        Set(value As Integer)
            _IndContraEntrega = value
        End Set
    End Property
    <DataMember()> _
    Public Property IndVariable() As Integer
        Get
            Return _IndVariable
        End Get
        Set(value As Integer)
            _IndVariable = value
        End Set
    End Property
    <DataMember()> _
    Public Property IndOtros() As Integer
        Get
            Return _IndOtros
        End Get
        Set(value As Integer)
            _IndOtros = value
        End Set
    End Property
    <DataMember()> _
    Public Property FInicioCampaña() As Date
        Get
            Return _FInicioCampaña
        End Get
        Set(ByVal value As Date)
            _FInicioCampaña = value
        End Set
    End Property
    <DataMember()> _
    Public Property FFinCampaña() As Date
        Get
            Return _FFinCampaña
        End Get
        Set(ByVal value As Date)
            _FFinCampaña = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMaterial() As String
        Get
            Return _IdMaterial
        End Get
        Set(ByVal value As String)
            _IdMaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property AceptaComision() As Boolean
        Get
            Return _AceptaComision
        End Get
        Set(ByVal value As Boolean)
            _AceptaComision = value
        End Set
    End Property
    <DataMember()> _
    Public Property IndMaterial() As Boolean
        Get
            Return _IndMaterial
        End Get
        Set(ByVal value As Boolean)
            _IndMaterial = value
        End Set
    End Property
#End Region

#Region "Constructor"

    Public Sub New()
        Activo = True
        TipoOperacion = ""
        Id = ""
        IdOrigen = ""
        IdDestino = ""
        FechaInicio = Date.Now
        FechaFin = Date.Now
        IndHistorial = 1
        IndActual = 1
        Tarifa = 0
        Porcentaje = 1
        IdTipoVehiculo = ""
        IdTipoCarga = ""
        IndConsolidado = 0
        FInicioCampaña = Date.Now
        FFinCampaña = Date.Now
    End Sub

    Public Sub New( _
          ByVal ls_Id As String _
          , ByVal ls_IdCliente As String _
          , ByVal ls_IdTipoRuta As String _
          , ByVal ls_IdTipoVehiculo As String _
          , ByVal ln_Tarifa As Double _
          , ByVal ln_IndConsolidado As Integer _
          , ByVal ls_Observacion As String _
          , ByVal ls_UsuarioCreacion As String _
          , ByVal lb_Activo As Boolean _
          , ByVal ls_IdOrigen As String _
          , ByVal ls_IdDestino As String _
          , ByVal ld_FechaInicio As Date _
          , ByVal ld_FechaFin As Date _
          , ByVal li_IndHistorial As Integer _
          , ByVal li_IndActual As Integer _
          , ByVal ld_Porcentaje As Double _
          , ByVal ls_IdTipoCarga As String _
          , ByVal li_IndCarga As Integer _
          , ByVal li_IndDescarga As Integer _
          , ByVal li_IndContraEntrega As Integer _
          , ByVal li_IndVariable As Integer _
          , ByVal li_IndOtros As Integer _
          , ByVal ld_FInicioCampaña As Date _
          , ByVal ld_FFinCampaña As Date)
        _Id = ls_Id
        _IdCliente = ls_IdCliente
        _IdTipoRuta = ls_IdTipoRuta
        _IdTipoVehiculo = ls_IdTipoVehiculo
        _Tarifa = ln_Tarifa
        _IndConsolidado = ln_IndConsolidado
        _Observacion = ls_Observacion
        _UsuarioCreacion = ls_UsuarioCreacion
        _Activo = lb_Activo
        _IdOrigen = ls_IdOrigen
        _IdDestino = ls_IdDestino
        _FechaInicio = ld_FechaInicio
        _FechaFin = ld_FechaFin
        _IndHistorial = li_IndHistorial
        _IndActual = li_IndActual
        _Porcentaje = ld_Porcentaje
        _IdTipoCarga = ls_IdTipoCarga
        _IndCarga = li_IndCarga
        _IndDescarga = li_IndDescarga
        _IndContraEntrega = li_IndContraEntrega
        _IndVariable = li_IndVariable
        _IndOtros = li_IndOtros
        _FInicioCampaña = ld_FInicioCampaña
        _FFinCampaña = ld_FFinCampaña
    End Sub
#End Region

    Public Function Obtener(ByVal TarifasCliente As e_TarifasCliente) As e_TarifasCliente Implements Ie_TarifasCliente.Obtener
        Return TarifasCliente
    End Function

End Class


