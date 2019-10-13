

<DataContract()> _
Public Class e_Flete
    Implements Ie_Flete

#Region "Propiedad"
    Private _id As String
    Private _idruta As String
    Private _idtipovehiculo As String
    Private _idcliente As String
    Private _idTipoCarga As String
    Private _estimado As Double
    Private _descripcionestimado As String
    Private _contrato As Double
    Private _descripcioncontrato As String
    Private _tecnico As Double
    Private _descripciontecnico As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Public Event DatoCambiado()

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
    Public Property IdRuta() As String
        Get
            Return _idruta
        End Get
        Set(ByVal value As String)
            _idruta = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoVehiculo() As String
        Get
            Return _idtipovehiculo
        End Get
        Set(ByVal value As String)
            _idtipovehiculo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cliente() As String
        Get
            Return _idcliente
        End Get
        Set(ByVal value As String)
            _idcliente = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoCarga() As String
        Get
            Return _idTipoCarga
        End Get
        Set(ByVal value As String)
            _idTipoCarga = value
        End Set
    End Property

    <DataMember()> _
    Public Property Estimado() As Double
        Get
            Return _estimado
        End Get
        Set(ByVal value As Double)
            _estimado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property DescripcionEstimado() As String
        Get
            Return _descripcionestimado
        End Get
        Set(ByVal value As String)
            _descripcionestimado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Contrato() As Double
        Get
            Return _contrato
        End Get
        Set(ByVal value As Double)
            _contrato = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property DescripcionContrato() As String
        Get
            Return _descripcioncontrato
        End Get
        Set(ByVal value As String)
            _descripcioncontrato = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Tecnico() As Double
        Get
            Return _tecnico
        End Get
        Set(ByVal value As Double)
            _tecnico = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property DescripcionTecnico() As String
        Get
            Return _descripciontecnico
        End Get
        Set(ByVal value As String)
            _descripciontecnico = value
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
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        Id = ""
        IdRuta = ""
        TipoVehiculo = ""
        TipoCarga = ""
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdRuta As String _
              , ByVal ls_IdTipoVehiculo As String _
              , ByVal ls_IdCliente As String _
              , ByVal ls_IdTipoCarga As String _
              , ByVal ln_Estimado As Double _
              , ByVal ls_DescripcionEstimado As String _
              , ByVal ln_Contrato As Double _
              , ByVal ls_DescripcionContrato As String _
              , ByVal ln_Tecnico As Double _
              , ByVal ls_DescripcionTecnico As String _
              , ByVal lb_Activo As Boolean)
        _id = ls_Id
        _idruta = ls_IdRuta
        _idtipovehiculo = ls_IdTipoVehiculo
        _idcliente = ls_IdCliente
        _idTipoCarga = ls_IdTipoCarga
        _estimado = ln_Estimado
        _descripcionestimado = ls_DescripcionEstimado
        _contrato = ln_Contrato
        _descripcioncontrato = ls_DescripcionContrato
        _tecnico = ln_Tecnico
        _descripciontecnico = ls_DescripcionTecnico
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal flete As e_Flete) As e_Flete Implements Ie_Flete.Obtener
        Return flete
    End Function

End Class


