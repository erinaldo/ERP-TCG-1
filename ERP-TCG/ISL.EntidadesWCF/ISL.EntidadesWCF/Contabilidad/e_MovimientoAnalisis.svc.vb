<DataContract()> _
Public Class e_MovimientoAnalisis
    Implements Ie_MovimientoAnalisis
    Implements IEquatable(Of e_MovimientoAnalisis)
    Implements ICloneable

#Region "Declaración de variables"

    Private _id As String
    Private _idcentrocosto As String
    Private _iditemgasto As String
    Private _idtrabajador As String
    Private _trabajador As String
    Private _idvehiculo As String
    Private _vehiculo As String
    Private _idruta As String
    Private _ruta As String
    Private _idbanco As String
    Private _idanalisis1 As String
    Private _idanalisis2 As String
    Private _activo As Boolean
    Private _idasientomovimiento As String
    Private _Monto As Double
    Private _Saldo As Double
    Private _IdOrigenProrrateo As String
    ''' <summary>
    ''' Variable que muestra que existen movimiento de analisis relacionado
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember()> _
    Public _IdMovimientoAnalisis As String
    <DataMember()>
    Public PrefijoID As String = ""
    ''' <summary>
    ''' Cuando Codigo de analisis trae codigo el saldo se cambia a Cero
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember()> _
    Public _CambiaSaldo As Boolean
    ''' <summary>
    ''' Saldo que quedara cuando se ejecute el cambio de saldo
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember()> _
    Public _SaldoFinal As Double

    ''' <summary>
    ''' Se agrego para compras y doc x Rendir
    ''' </summary>
    ''' <remarks></remarks>
    Private _IdCuentaContable As String
    Private _cuentacte As String

    ''' <summary>
    ''' para busquedas por ejercicio en documentos por rendir
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Ejercicio As Integer

    '-------variables de ayuda---------
    Private _IdMoneda As String
    Private _IdPeriodo As String
    Private _idUsuarioCrea As String
    Private _UsuarioCrea As String
    Private _IdGastoFuncion As String
    ''' <summary>
    ''' Para documentos por rendir, objeto necesita tener el saldo sin IGV
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember()> _
    Public SaldoSinIgv As Double = 0
    '----------------------------------
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

    ''' <summary>
    ''' Variables para modulo de Prorrateo
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember()> _
    Public _ListaV As String
    <DataMember()> _
    Public GastoFuncion As e_TablaContableDet

    <DataMember()> _
    Public IdTipoCompraParaCompra As String

    Private _TipoAsiento As String
    Private _NroAsiento As String
    Private _Glosa As String
    Private _Fecha As Date

    <DataMember()> _
    Public _TipoGuardarMasivo As String

    <DataMember()> _
    Public Equivale As Integer
    <DataMember()> _
    Public NroFila As Integer

    Public Event DatoCambiado()

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoAsiento() As String
        Get
            Return _TipoAsiento
        End Get
        Set(ByVal value As String)
            _TipoAsiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroAsiento() As String
        Get
            Return _NroAsiento
        End Get
        Set(ByVal value As String)
            _NroAsiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _Glosa
        End Get
        Set(ByVal value As String)
            _Glosa = value
        End Set
    End Property

    ''' <summary>
    ''' Para Documentos por rendir lista(Operacion R)
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property IdMoneda() As String
        Get
            Return _IdMoneda
        End Get
        Set(ByVal value As String)
            _IdMoneda = value
        End Set
    End Property
    ''' <summary>
    ''' Para Documentos por rendir lista(Operacion R)
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property IdPeriodo() As String
        Get
            Return _IdPeriodo
        End Get
        Set(ByVal value As String)
            _IdPeriodo = value
        End Set
    End Property
    ''' <summary>
    ''' Para Documentos por rendir lista(Operacion R)
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    <DataMember()> _
    Public Property IdUsuarioCrea() As String
        Get
            Return _idUsuarioCrea
        End Get
        Set(ByVal value As String)
            _idUsuarioCrea = value
        End Set
    End Property
    ''' <summary>
    ''' Para Documentos por rendir lista(Operacion R)
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property UsuarioCrea() As String
        Get
            Return _UsuarioCrea
        End Get
        Set(ByVal value As String)
            _UsuarioCrea = value
        End Set
    End Property

    <DataMember()> _
    Public Property Saldo() As Double
        Get
            Return _Saldo
        End Get
        Set(ByVal value As Double)
            _Saldo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Monto() As Double
        Get
            Return _Monto
        End Get
        Set(ByVal value As Double)
            _Monto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

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
    Public Property IdCentroCosto() As String
        Get
            Return _idcentrocosto
        End Get
        Set(ByVal value As String)
            _idcentrocosto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdItemGasto() As String
        Get
            Return _iditemgasto
        End Get
        Set(ByVal value As String)
            _iditemgasto = value
            RaiseEvent DatoCambiado()
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
    Public Property IdVehiculo() As String
        Get
            Return _idvehiculo
        End Get
        Set(ByVal value As String)
            _idvehiculo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Vehiculo() As String
        Get
            Return _vehiculo
        End Get
        Set(ByVal value As String)
            _vehiculo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdRuta() As String
        Get
            Return _idruta
        End Get
        Set(ByVal value As String)
            _idruta = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ruta() As String
        Get
            Return _ruta
        End Get
        Set(ByVal value As String)
            _ruta = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdBanco() As String
        Get
            Return _idbanco
        End Get
        Set(ByVal value As String)
            _idbanco = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdAnalisis1() As String
        Get
            Return _idanalisis1
        End Get
        Set(ByVal value As String)
            _idanalisis1 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdAnalisis2() As String
        Get
            Return _idanalisis2
        End Get
        Set(ByVal value As String)
            _idanalisis2 = value
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
    Public Property IdAsientoMovimiento() As String
        Get
            Return _idasientomovimiento
        End Get
        Set(ByVal value As String)
            _idasientomovimiento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaContable() As String
        Get
            Return _IdCuentaContable
        End Get
        Set(ByVal value As String)
            _IdCuentaContable = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cuenta() As String
        Get
            Return _cuentacte
        End Get
        Set(ByVal value As String)
            _cuentacte = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdGastoFuncion() As String
        Get
            Return _IdGastoFuncion
        End Get
        Set(ByVal value As String)
            _IdGastoFuncion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdOrigenProrrateo() As String
        Get
            Return _IdOrigenProrrateo
        End Get
        Set(ByVal value As String)
            _IdOrigenProrrateo = value
        End Set
    End Property
#End Region

#Region "Constructor"

    Public Sub New()
        _activo = True
        _CambiaSaldo = False
        _SaldoFinal = 0
        TipoOperacion = ""
        _Fecha = Date.Parse("01/01/1901")
        _idvehiculo = ""
        _IdOrigenProrrateo = ""
        _id = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdCentroCosto As String _
              , ByVal ls_IdItemGasto As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ls_IdVehiculo As String _
              , ByVal ls_IdRuta As String _
              , ByVal ls_IdBanco As String _
              , ByVal ls_IdAnalisis1 As String _
              , ByVal ls_IdAnalisis2 As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_IdAsientoMovimiento As String _
              , ByVal ln_Monto As Double _
              , ByVal ls_IdCuentaContable As String _
              , ByVal ls_Saldo As Double _
            , ByVal ls_IdMoneda As String _
            , ByVal ls_IdPeriodo As String _
            , ByVal ls_IdUsuarioCrea As String _
            , ByVal ls_UsuarioCrea As String _
            , ByVal ls_ApellidoPaterno As String _
            , ByVal ls_ApellidoMaterno As String _
            , ByVal ls_Nombre As String _
            , ByVal ls_Origen As String _
            , ByVal ls_Destino As String _
            , ByVal ls_Placa As String _
            , ByVal ls_Cuenta As String _
            , ByVal ls_IdGastoFuncion As String _
            , ByVal ls_TipoAsiento As String _
            , ByVal ls_NroAsiento As String _
            , ByVal ls_Glosa As String _
             , ByVal ls_Fecha As Date _
              , ByVal lsIdTipoCompraParaCompra As String _
           )
        IdTipoCompraParaCompra = lsIdTipoCompraParaCompra
        _TipoAsiento = ls_TipoAsiento
        _NroAsiento = ls_NroAsiento
        _Glosa = ls_Glosa
        _IdGastoFuncion = ls_IdGastoFuncion
        _trabajador = ls_ApellidoPaterno + " " + ls_ApellidoMaterno + ", " + ls_Nombre
        _ruta = ls_Origen + " - " + ls_Destino
        _vehiculo = ls_Placa
        _UsuarioCrea = ls_UsuarioCrea
        _cuentacte = ls_Cuenta

        _Saldo = ls_Saldo
        _Monto = ln_Monto
        _id = ls_Id
        _idcentrocosto = ls_IdCentroCosto
        _iditemgasto = ls_IdItemGasto
        _idtrabajador = ls_IdTrabajador
        _idvehiculo = ls_IdVehiculo
        _idruta = ls_IdRuta
        _idbanco = ls_IdBanco
        _idanalisis1 = ls_IdAnalisis1
        _idanalisis2 = ls_IdAnalisis2
        _activo = lb_Activo
        _idasientomovimiento = ls_IdAsientoMovimiento
        _IdCuentaContable = ls_IdCuentaContable
        _IdMoneda = ls_IdMoneda
        _IdPeriodo = ls_IdPeriodo
        _idUsuarioCrea = ls_IdUsuarioCrea
        _Fecha = ls_Fecha
    End Sub

#End Region

#Region "Métodos"

    Public Function Equals1(ByVal other As e_MovimientoAnalisis) As Boolean Implements System.IEquatable(Of e_MovimientoAnalisis).Equals
        Select Case other.Equivale
            Case 0
                If Me.IdAsientoMovimiento = other.IdAsientoMovimiento And Me.IdCuentaContable = other.IdCuentaContable _
                   And Me.IdCentroCosto = other.IdCentroCosto And Me.IdItemGasto = other.IdItemGasto And Me.IdTrabajador = other.IdTrabajador _
                   And Me.IdVehiculo = other.IdVehiculo And Me.IdRuta = other.IdRuta And Me.IdBanco = other.IdBanco _
                   And Me.IdAnalisis1 = other.IdAnalisis1 And Me.IdAnalisis2 = other.IdAnalisis2 _
                   And Me.IdGastoFuncion = other.IdGastoFuncion Then
                    Return True
                End If
            Case 1
                If Me.NroFila = other.NroFila Then Return True
        End Select
        Return False
    End Function

    Public Function Clone() As Object Implements System.ICloneable.Clone
        Dim oeMovAn As New e_MovimientoAnalisis
        oeMovAn = Me.MemberwiseClone
        oeMovAn._IdCuentaContable = Me._IdCuentaContable.Clone
        oeMovAn._iditemgasto = Me._iditemgasto.Clone
        oeMovAn._idanalisis1 = Me._idanalisis1.Clone
        oeMovAn._idanalisis2 = Me._idanalisis2.Clone
        oeMovAn._idbanco = Me._idbanco.Clone
        oeMovAn._idruta = Me._idruta.Clone
        oeMovAn._idvehiculo = Me._idvehiculo.Clone
        oeMovAn._idtrabajador = Me._idtrabajador.Clone
        oeMovAn._idcentrocosto = Me._idcentrocosto.Clone
        oeMovAn._IdGastoFuncion = Me._IdGastoFuncion.Clone
        Return oeMovAn
    End Function

    Public Function Obtener(ByVal movimientoAnalisis As e_MovimientoAnalisis) As e_MovimientoAnalisis Implements Ie_MovimientoAnalisis.Obtener
        Return movimientoAnalisis
    End Function

#End Region

End Class
