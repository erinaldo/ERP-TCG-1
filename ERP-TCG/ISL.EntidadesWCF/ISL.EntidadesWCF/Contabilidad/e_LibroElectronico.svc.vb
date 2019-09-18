<DataContract()> _
Public Class e_LibroElectronico
    Implements Ie_LibroElectronico

#Region "Declaracion de Variables"

    Private _id As String
    Private _idperiodo As String
    Private _idtablacontabledet As String
    Private _idestado As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _observacion As String
    Private _subtotal1 As Double
    Private _subtotal2 As Double
    Private _subtotal3 As Double
    Private _subtotal4 As Double
    Private _subtotal5 As Double

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public leDetallePLE As New List(Of e_DetalleLibroElectronico)
    <DataMember()> _
     Public dtDetalleLE As DataTable
    <DataMember()>
    Public PrefijoID As String = ""
    Event DatoCambiado()

#End Region

#Region "Propiedad"

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
    Public Property IdPeriodo() As String
        Get
            Return _idperiodo
        End Get
        Set(ByVal value As String)
            _idperiodo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTablaContableDet() As String
        Get
            Return _idtablacontabledet
        End Get
        Set(ByVal value As String)
            _idtablacontabledet = value
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
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
Public Property Observacion() As String
        Get
            Return _observacion
        End Get
        Set(ByVal value As String)
            _observacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
Public Property SubTotal1() As Double
        Get
            Return _subtotal1
        End Get
        Set(ByVal value As Double)
            _subtotal1 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
Public Property SubTotal2() As Double
        Get
            Return _subtotal2
        End Get
        Set(ByVal value As Double)
            _subtotal2 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
Public Property SubTotal3() As Double
        Get
            Return _subtotal3
        End Get
        Set(ByVal value As Double)
            _subtotal3 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
Public Property SubTotal4() As Double
        Get
            Return _subtotal4
        End Get
        Set(ByVal value As Double)
            _subtotal4 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
Public Property SubTotal5() As Double
        Get
            Return _subtotal5
        End Get
        Set(ByVal value As Double)
            _subtotal5 = value
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
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        Activo = True
        _fechacreacion = #1/1/1901#
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdPeriodo As String _
              , ByVal ls_IdTablaContableDet As String _
              , ByVal ls_IdEstado As String _
              , ByVal ls_Observacion As String _
              , ByVal ln_SubTotal1 As Double _
              , ByVal ln_SubTotal2 As Double _
              , ByVal ln_SubTotal3 As Double _
              , ByVal ln_SubTotal4 As Double _
              , ByVal ln_SubTotal5 As Double _
            , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idperiodo = ls_IdPeriodo
        _idtablacontabledet = ls_IdTablaContableDet
        _idestado = ls_IdEstado
        _observacion = ls_Observacion
        _subtotal1 = ln_SubTotal1
        _subtotal2 = ln_SubTotal2
        _subtotal3 = ln_SubTotal3
        _subtotal4 = ln_SubTotal4
        _subtotal5 = ln_SubTotal5
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region


    Public Function Obtener(ByVal libroelectronico As e_LibroElectronico) As e_LibroElectronico Implements Ie_LibroElectronico.Obtener
        Return libroelectronico
    End Function

End Class
