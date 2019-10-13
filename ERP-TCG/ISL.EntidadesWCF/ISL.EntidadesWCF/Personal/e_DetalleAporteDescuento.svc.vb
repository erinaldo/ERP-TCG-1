<DataContract()> _
Public Class e_DetalleAporteDescuento
    Implements Ie_DetalleAporteDescuento
    Implements IEquatable(Of e_DetalleAporteDescuento)
    Implements IDisposable

#Region "Declaracion de Variables"

    Private _id As String
    Private _idaportedescuento As String
    Private _unidadcalculo As String
    Private _montocalculo As Double
    Private _idformula As String
    Private _fechaactividad As Date
    Private _fechainactividad As Date
    Private _vigencia As Integer
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Equivale As Integer
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
#End Region

#Region "Propiedades"

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
    Public Property IdAporteDescuento() As String
        Get
            Return _idaportedescuento
        End Get
        Set(ByVal value As String)
            _idaportedescuento = value
        End Set
    End Property

    <DataMember()> _
    Public Property UnidadCalculo() As String
        Get
            Return _unidadcalculo
        End Get
        Set(ByVal value As String)
            _unidadcalculo = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoCalculo() As Double
        Get
            Return _montocalculo
        End Get
        Set(ByVal value As Double)
            _montocalculo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdFormula() As String
        Get
            Return _idformula
        End Get
        Set(ByVal value As String)
            _idformula = value
        End Set
    End Property

    Public Property FechaActividad() As Date
        Get
            Return _fechaactividad
        End Get
        Set(ByVal value As Date)
            _fechaactividad = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInactividad() As Date
        Get
            Return _fechainactividad
        End Get
        Set(ByVal value As Date)
            _fechainactividad = value
        End Set
    End Property

    <DataMember()> _
    Public Property Vigencia() As Integer
        Get
            Return _vigencia
        End Get
        Set(ByVal value As Integer)
            _vigencia = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
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

#End Region

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _idaportedescuento = String.Empty
        _unidadcalculo = String.Empty
        _montocalculo = 0
        _idformula = String.Empty
        _fechaactividad = #1/1/1901#
        _fechainactividad = #1/1/1901#
        _vigencia = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdAporteDescuento As String _
              , ByVal ls_UnidadCalculo As String _
              , ByVal ln_MontoCalculo As Double _
              , ByVal ls_IdFormula As String _
              , ByVal ld_FechaActividad As Date _
              , ByVal ld_FechaInactividad As Date _
              , ByVal lb_Vigencia As Integer _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idaportedescuento = ls_IdAporteDescuento
        _unidadcalculo = ls_UnidadCalculo
        _montocalculo = ln_MontoCalculo
        _idformula = ls_IdFormula
        _fechaactividad = ld_FechaActividad
        _fechainactividad = ld_FechaInactividad
        _vigencia = lb_Vigencia
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function obtener(oeDetalleAporteDescuento As e_DetalleAporteDescuento) As e_DetalleAporteDescuento Implements Ie_DetalleAporteDescuento.obtener
        Return oeDetalleAporteDescuento
    End Function

    Public Overloads Function Equals(ByVal oeDetAD As e_DetalleAporteDescuento) As Boolean Implements System.IEquatable(Of e_DetalleAporteDescuento).Equals
        Select Case oeDetAD.Equivale
            Case 1 : If Me.Id = oeDetAD.Id Then Return True
            Case 2 : If Me.IdAporteDescuento = oeDetAD.IdAporteDescuento Then Return True
        End Select
        Return False
    End Function

#End Region

#Region "IDisposable Support"

    Private disposedValue As Boolean ' Para detectar llamadas redundantes

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: eliminar estado administrado (objetos administrados).
            End If

            ' TODO: liberar recursos no administrados (objetos no administrados) e invalidar Finalize() below.
            ' TODO: Establecer campos grandes como Null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: invalidar Finalize() sólo si la instrucción Dispose(ByVal disposing As Boolean) anterior tiene código para liberar recursos no administrados.
    'Protected Overrides Sub Finalize()
    '    ' No cambie este código. Ponga el código de limpieza en la instrucción Dispose(ByVal disposing As Boolean) anterior.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' Visual Basic agregó este código para implementar correctamente el modelo descartable.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' No cambie este código. Coloque el código de limpieza en Dispose(disposing As Boolean).
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

#End Region

End Class
