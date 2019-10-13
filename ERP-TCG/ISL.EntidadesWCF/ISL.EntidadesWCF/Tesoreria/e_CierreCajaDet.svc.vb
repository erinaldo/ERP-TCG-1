' NOTA: si cambia aquí el nombre de clase "e_CierreCajaDet", también debe actualizar la referencia a "e_CierreCajaDet" tanto en Web.config como en el archivo .svc asociado.

<DataContract()> _
Public Class e_CierreCajaDet
    Implements Ie_CierreCajaDet

#Region "Propiedad"

    Private _id As String
    Private _idcierrecaja As New e_CierreCaja
    Private _glosa As String
    Private _ingreso As Double
    Private _egreso As Double
    Private _voucher As String
    Private _fecha As Date

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
    Public Property IdCierreCaja() As String
        Get
            Return _idcierrecaja.Id
        End Get
        Set(ByVal value As String)
            _idcierrecaja.Id = value
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
    Public Property Voucher() As String
        Get
            Return _voucher
        End Get
        Set(ByVal value As String)
            _voucher = value
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

#End Region

#Region "Constructor"

    Public Sub New()

    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdCierreCaja As String _
              , ByVal ls_Glosa As String _
              , ByVal ln_Ingreso As Double _
              , ByVal ln_Egreso As Double _
              , ByVal ls_Voucher As String _
              , ByVal ld_Fecha As Date _
           )
        _id = ls_Id
        _idcierrecaja.Id = ls_IdCierreCaja
        _glosa = ls_Glosa
        _ingreso = ln_Ingreso
        _egreso = ln_Egreso
        _voucher = ls_Voucher
        _fecha = ld_Fecha
    End Sub

#End Region

    Public Function Obtener(ByVal cierrecajadet As e_CierreCajaDet) As e_CierreCajaDet Implements Ie_CierreCajaDet.Obtener
        Return cierrecajadet
    End Function

End Class
