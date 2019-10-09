


<DataContract()> _
Public Class e_DetalleDocumentoVehiculo
    Implements Ie_DetalleDocumentoVehiculo
    Implements IEquatable(Of e_DetalleDocumentoVehiculo)

#Region "Propiedad"

    Private _id As String
    Private _idvehiculo As String
    Private _iddocumento As String
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _prima As Double
    Private _deremision As Double
    Private _igv As Double
    Private _total As Double
    Private _EmpresaPropietaria As String
    Private _placa As String
    Private _indexcluido As Boolean
    Private _fechaemision As Date
    Private _fechavencimiento As Date
    Private _indtipovehiculo As String
    Private _fechaexclusion As Date
    Private _iddocveh_doc As String
    Private _iddocveh_doc2 As String
    Private _nroseriemotor As String
    Private _nroseriechasis As String
    Private _comision As Double
    <DataMember()> _
    Public TipoOperacion As String
    Private _Seleccion As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

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
    Public Property IdVehiculo() As String
        Get
            Return _idvehiculo
        End Get
        Set(ByVal value As String)
            _idvehiculo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdDocumento() As String
        Get
            Return _iddocumento
        End Get
        Set(ByVal value As String)
            _iddocumento = value
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
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

    <DataMember()> _
Public Property Prima() As Double
        Get
            Return _prima
        End Get
        Set(ByVal value As Double)
            _prima = value
        End Set
    End Property

    <DataMember()> _
Public Property DerEmision() As Double
        Get
            Return _deremision
        End Get
        Set(ByVal value As Double)
            _deremision = value
        End Set
    End Property

    <DataMember()> _
Public Property Igv() As Double
        Get
            Return _igv
        End Get
        Set(ByVal value As Double)
            _igv = value
        End Set
    End Property

    <DataMember()> _
Public Property Total() As Double
        Get
            Return _total
        End Get
        Set(ByVal value As Double)
            _total = value
        End Set
    End Property

    <DataMember()> _
Public Property EmpresaPropietaria() As String
        Get
            Return _EmpresaPropietaria
        End Get
        Set(ByVal value As String)
            _EmpresaPropietaria = value
        End Set
    End Property

    <DataMember()> _
Public Property Placa() As String
        Get
            Return _placa
        End Get
        Set(ByVal value As String)
            _placa = value
        End Set
    End Property

    <DataMember()> _
Public Property Seleccion() As Boolean
        Get
            Return _Seleccion
        End Get
        Set(ByVal value As Boolean)
            _Seleccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndExcluido() As Boolean
        Get
            Return _indexcluido
        End Get
        Set(ByVal value As Boolean)
            _indexcluido = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaEmision() As Date
        Get
            Return _fechaemision
        End Get
        Set(ByVal value As Date)
            _fechaemision = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaVencimiento() As Date
        Get
            Return _fechavencimiento
        End Get
        Set(ByVal value As Date)
            _fechavencimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndTipoVehiculo() As String
        Get
            Return _indtipovehiculo
        End Get
        Set(ByVal value As String)
            _indtipovehiculo = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaExclusion() As Date
        Get
            Return _fechaexclusion
        End Get
        Set(ByVal value As Date)
            _fechaexclusion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdDocVeh_Doc() As String
        Get
            Return _iddocveh_doc
        End Get
        Set(ByVal value As String)
            _iddocveh_doc = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdDocVeh_Doc2() As String
        Get
            Return _iddocveh_doc2
        End Get
        Set(ByVal value As String)
            _iddocveh_doc2 = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroSerieMotor() As String
        Get
            Return _nroseriemotor
        End Get
        Set(ByVal value As String)
            _nroseriemotor = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroSerieChasis() As String
        Get
            Return _nroseriechasis
        End Get
        Set(ByVal value As String)
            _nroseriechasis = value
        End Set
    End Property

    <DataMember()> _
    Public Property Comision() As Double
        Get
            Return _comision
        End Get
        Set(ByVal value As Double)
            _comision = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Public Sub New()
        EmpresaPropietaria = ""
        Seleccion = False
        Placa = ""
        IndExcluido = False
        IndTipoVehiculo = 0
        FechaEmision = "01/01/1991"
        FechaVencimiento = "01/01/1991"
        IdDocVeh_Doc = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdVehiculo As String _
              , ByVal ls_IdDocumento As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_Prima As Double _
              , ByVal ld_Comision As Double _
              , ByVal ld_DerEmision As Double _
              , ByVal ld_Igv As Double _
              , ByVal ld_Total As Double _
              , ByVal ls_Placa As String _
              , ByVal ls_EmpresaPropietaria As String _
              , ByVal lb_IndExcluido As Boolean _
              , ByVal ld_fechaemision As Date _
              , ByVal ld_fechavencimiento As Date _
              , ByVal ls_indtipovehiculo As String _
              , ByVal ld_fechaexclusion As Date _
              , ByVal ls_IdDocVeh_Doc As String _
              , ByVal ls_IdDocVeh_Doc2 As String _
              , ByVal ls_NroSerieMotor As String _
              , ByVal ls_NroSerieChasis As String _
           )
        _id = ls_Id
        _idvehiculo = ls_IdVehiculo
        _iddocumento = ls_IdDocumento
        _activo = lb_Activo
        _prima = ld_Prima
        _comision = ld_Comision
        _deremision = ld_DerEmision
        _igv = ld_Igv
        _total = ld_Total
        _placa = ls_Placa
        _EmpresaPropietaria = ls_EmpresaPropietaria
        _indexcluido = lb_IndExcluido
        _fechaemision = ld_fechaemision
        _fechavencimiento = ld_fechavencimiento
        _indtipovehiculo = ls_indtipovehiculo
        _fechaexclusion = ld_fechaexclusion
        _iddocveh_doc = ls_IdDocVeh_Doc
        _iddocveh_doc2 = ls_IdDocVeh_Doc2
        _nroseriemotor = ls_NroSerieMotor
        _nroseriechasis = ls_NroSerieChasis
    End Sub

#End Region

    Public Overloads Function Equals(ByVal oeDDV As e_DetalleDocumentoVehiculo) As Boolean Implements IEquatable(Of e_DetalleDocumentoVehiculo).Equals
        If Me.IdVehiculo = oeDDV.IdVehiculo Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Obtener(ByVal detalleDocumentoVehiculo As e_DetalleDocumentoVehiculo) As e_DetalleDocumentoVehiculo Implements Ie_DetalleDocumentoVehiculo.Obtener
        Return detalleDocumentoVehiculo
    End Function

End Class


