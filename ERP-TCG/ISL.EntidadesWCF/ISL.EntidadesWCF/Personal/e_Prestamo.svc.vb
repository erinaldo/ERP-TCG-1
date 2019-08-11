<DataContract()> _
Public Class e_Prestamo
    Implements Ie_Prestamo
    Implements IEquatable(Of e_Prestamo)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idtrabajador As String
    Private _glosa As String
    Private _monto As Double
    Private _saldo As Double
    Private _cantidadcuotas As Integer
    Private _cancelado As Integer
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _idconcepto As String
    Private _activo As Boolean
    Private _trabajador As String
    Private _fecha As Date
    Private _fechacese As Date
    Private _ConceptoPrestamo As String
    Private _glosacancelado As String
    Private _fechacancelado As Date
    Private _fechaintegracion As Date
    Private _idctabancaria As String
    Private _idestado As String
    Private _estado As String
    Private _usuarioaprueba As String
    Private _fechaaprueba As Date

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public _anio As String
    <DataMember()> _
    Public _mes As String
    <DataMember()> _
    Public _CadenaId As String
    <DataMember()> _
    Public Equivale As Integer

    <DataMember()> _
    Public leDetalle As New List(Of e_PrestamoDetalle)
    <DataMember()> _
    Public leSancion As New List(Of e_Prestamo_Sancion)
    <DataMember()> _
    Public leHistorial As New List(Of e_PrestamoDetalle)

    <DataMember()> _
    Public fecInicio As Date
    <DataMember()> _
    Public fecFin As Date

    Public lsGruposDescuentos As String

    <DataMember()> _
    Public Dni As String
    <DataMember()> _
    Public CtaBancaria As e_CuentaBancaria
    <DataMember()> _
    Public oePeriodo As e_Periodo
    <DataMember()> _
    Public _MontoAux As Double
    <DataMember()> _
    Public IndProv As String


    Public Event DatoCambiado()

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
    Public Property FechaCese() As Date
        Get
            Return _fechacese
        End Get
        Set(ByVal value As Date)
            _fechacese = value
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
    Public Property Monto() As Double
        Get
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Saldo() As Double
        Get
            Return _saldo
        End Get
        Set(ByVal value As Double)
            _saldo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadCuotas() As Integer
        Get
            Return _cantidadcuotas
        End Get
        Set(ByVal value As Integer)
            _cantidadcuotas = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Cancelado() As Integer
        Get
            Return _cancelado
        End Get
        Set(ByVal value As Integer)
            _cancelado = value
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
    Public Property IdConcepto() As String
        Get
            Return _idconcepto
        End Get
        Set(ByVal value As String)
            _idconcepto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Concepto() As String
        Get
            Return _ConceptoPrestamo
        End Get
        Set(ByVal value As String)
            _ConceptoPrestamo = value
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

    <DataMember()> _
    Public Property GlosaCancelado() As String
        Get
            Return _glosacancelado
        End Get
        Set(ByVal value As String)
            _glosacancelado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCancelado() As Date
        Get
            Return _fechacancelado
        End Get
        Set(ByVal value As Date)
            _fechacancelado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaIntegracion() As Date
        Get
            Return _fechaintegracion
        End Get
        Set(ByVal value As Date)
            _fechaintegracion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCtaBancaria() As String
        Get
            Return _idctabancaria
        End Get
        Set(ByVal value As String)
            _idctabancaria = value
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
    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioAprueba() As String
        Get
            Return _usuarioaprueba
        End Get
        Set(ByVal value As String)
            _usuarioaprueba = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaAprueba() As Date
        Get
            Return _fechaaprueba
        End Get
        Set(ByVal value As Date)
            _fechaaprueba = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _idtrabajador = String.Empty
        _glosa = String.Empty
        _monto = 0
        _saldo = 0
        _cantidadcuotas = 0
        _cancelado = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _idconcepto = String.Empty
        _activo = True
        _trabajador = String.Empty
        _fecha = #1/1/1901#
        _fechacese = #1/1/1901#
        _ConceptoPrestamo = String.Empty
        fecInicio = #1/1/1901#
        fecFin = #1/1/1901#
        _glosacancelado = String.Empty
        _fechacancelado = #1/1/1901#
        _fechaintegracion = #1/1/1901#
        _idctabancaria = String.Empty
        _idestado = String.Empty
        _estado = String.Empty
        _usuarioaprueba = String.Empty
        _fechaaprueba = #1/1/1901#
        TipoOperacion = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ls_Trabajador As String _
              , ByVal ls_Glosa As String _
              , ByVal ln_Monto As Double _
              , ByVal ln_Saldo As Double _
              , ByVal ln_CantidadCuotas As Integer _
              , ByVal lb_Cancelado As Boolean _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ls_IdConcepto As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_Fecha As Date _
              , ByVal ld_FechaCese As Date _
              , ByVal ls_ConceptoPrestamo As String _
              , ByVal ls_GlosaCancelado As String _
              , ByVal ld_FechaCancelado As Date _
              , ByVal ld_FechaIntegracion As Date _
            , ByVal ls_Dni As String _
            , ByVal ls_IdCtaBancaria As String _
            , ByVal ls_IdEstado As String _
            , ByVal ls_Estado As String _
            , ByVal ls_UsuarioAprueba As String _
            , ByVal ld_FechaAprueba As Date _
           )
        Dni = ls_Dni
        _id = ls_Id
        _idtrabajador = ls_IdTrabajador
        _glosa = ls_Glosa
        _monto = ln_Monto
        _saldo = ln_Saldo
        _cantidadcuotas = ln_CantidadCuotas
        _cancelado = IIf(lb_Cancelado, 1, 0)
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _idconcepto = ls_IdConcepto
        _activo = lb_Activo
        _trabajador = ls_Trabajador
        _fecha = ld_Fecha
        _fechacese = ld_FechaCese
        _ConceptoPrestamo = ls_ConceptoPrestamo
        _glosacancelado = ls_GlosaCancelado
        _fechacancelado = ld_FechaCancelado
        _fechaintegracion = ld_FechaIntegracion
        _idctabancaria = ls_IdCtaBancaria
        _idestado = ls_IdEstado
        _estado = ls_Estado
        _usuarioaprueba = ls_UsuarioAprueba
        _fechaaprueba = ld_FechaAprueba
    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal prestamo As e_Prestamo) As e_Prestamo Implements Ie_Prestamo.Obtener
        Return prestamo
    End Function

    Public Overloads Function Equals(ByVal oePrest As e_Prestamo) As Boolean Implements IEquatable(Of ISL.EntidadesWCF.e_Prestamo).Equals
        Select Case oePrest.Equivale
            Case 0 : If Me.Id.Trim = oePrest.Id.Trim Then Return True
        End Select
        Return False
    End Function

#End Region

End Class

