<DataContract()> _
Public Class e_DetallePreliminar
    Implements Ie_DetallePreliminar
    Implements IEquatable(Of e_DetallePreliminar)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idpreliminarinspeccion As String
    Private _idoperacionneu As String
    Private _centro As String
    Private _codoperacion As String
    Private _placa As String
    Private _motriz As Integer
    Private _codneumatico As String
    Private _marca As String
    Private _modelo As String
    Private _tipomedida As String
    Private _medida As String
    Private _tipobanda As String
    Private _posicion As Integer
    Private _cocada As Double
    Private _kilometraje As Double
    Private _fechaoperacion As Date
    Private _cocadaminima As Double
    Private _idmarcar As String
    Private _idmedidar As String
    Private _iddiseniopedido As String
    Private _tipobandapedido As String
    Private _confirmado As Integer
    Private _observacion As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _idvidaneumatico As String
    Private _idMaterial As String
    Private _indcolor As Double
    Private _dot As String
    Private _flota As String
    <DataMember()> _
   Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public Periodo As String
    <DataMember()>
    Public PrefijoID As String = ""

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
    Public Property IdPreliminarInspeccion() As String
        Get
            Return _idpreliminarinspeccion
        End Get
        Set(ByVal value As String)
            _idpreliminarinspeccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdOperacionNeu() As String
        Get
            Return _idoperacionneu
        End Get
        Set(ByVal value As String)
            _idoperacionneu = value
        End Set
    End Property

    <DataMember()> _
 Public Property Centro() As String
        Get
            Select Case Left(_idoperacionneu, 3)
                Case "1CH" : _centro = "BASE CHICLAYO"
                Case "1PY" : _centro = "BASE PACASMAYO"
            End Select
            Return _centro
        End Get
        Set(ByVal value As String)
            _centro = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodOperacion() As String
        Get
            Return _codoperacion
        End Get
        Set(ByVal value As String)
            _codoperacion = value
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
    Public Property Tipo() As String
        Get
            Dim _tipo As String = ""
            Select Case _motriz
                Case 1 : _tipo = "TRACTO"
                Case 0 : _tipo = "CARRETA"
            End Select
            Return _tipo
        End Get
        Set(ByVal value As String)
            _motriz = value
        End Set
    End Property

    <DataMember()> _
    Public Property Flota() As String
        Get
            Return _flota
        End Get
        Set(ByVal value As String)
            _flota = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodNeumatico() As String
        Get
            Return _codneumatico
        End Get
        Set(ByVal value As String)
            _codneumatico = value
        End Set
    End Property

    <DataMember()> _
    Public Property Marca() As String
        Get
            Return _marca
        End Get
        Set(ByVal value As String)
            _marca = value
        End Set
    End Property

    <DataMember()> _
    Public Property Modelo() As String
        Get
            Return _modelo
        End Get
        Set(ByVal value As String)
            _modelo = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoMedida() As String
        Get
            Return _tipomedida
        End Get
        Set(ByVal value As String)
            _tipomedida = value
        End Set
    End Property

    <DataMember()> _
    Public Property Medida() As String
        Get
            Return _medida
        End Get
        Set(ByVal value As String)
            _medida = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoBanda() As String
        Get
            Return _tipobanda
        End Get
        Set(ByVal value As String)
            _tipobanda = value
        End Set
    End Property

    <DataMember()> _
    Public Property Posicion() As Integer
        Get
            Return _posicion
        End Get
        Set(ByVal value As Integer)
            _posicion = value
        End Set
    End Property

    <DataMember()> _
    Public Property DOT() As String
        Get
            Return _dot
        End Get
        Set(ByVal value As String)
            _dot = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cocada() As Double
        Get
            Return _cocada
        End Get
        Set(ByVal value As Double)
            _cocada = value
        End Set
    End Property

    <DataMember()> _
   Public Property Kilometraje() As Double
        Get
            Return _kilometraje
        End Get
        Set(ByVal value As Double)
            _kilometraje = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaOperacion() As Date
        Get
            Return _fechaoperacion
        End Get
        Set(ByVal value As Date)
            _fechaoperacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property CocadaMinima() As Double
        Get
            Return _cocadaminima
        End Get
        Set(ByVal value As Double)
            _cocadaminima = value
        End Set
    End Property

    <DataMember()> _
Public Property MarcaRecomendada() As String
        Get
            Return _idmarcar
        End Get
        Set(ByVal value As String)
            _idmarcar = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdDisenioPedido() As String
        Get
            Return _iddiseniopedido
        End Get
        Set(ByVal value As String)
            _iddiseniopedido = value
        End Set
    End Property

    <DataMember()> _
Public Property TipoBandaPedido() As String
        Get
            Return _tipobandapedido
        End Get
        Set(ByVal value As String)
            _tipobandapedido = value
        End Set
    End Property

    <DataMember()> _
    Public Property MedidaRecomendada() As String
        Get
            Return _idmedidar
        End Get
        Set(ByVal value As String)
            _idmedidar = value
        End Set
    End Property

    <DataMember()> _
    Public Property Confirmado() As Integer
        Get
            Return _confirmado
        End Get
        Set(ByVal value As Integer)
            _confirmado = value
        End Set
    End Property

    <DataMember()> _
    Public Property Observacion() As String
        Get
            Return _observacion
        End Get
        Set(ByVal value As String)
            _observacion = value
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

    <DataMember()> _
    Public Property IdVidaNeumatico() As String
        Get
            Return _idvidaneumatico
        End Get
        Set(ByVal value As String)
            _idvidaneumatico = value
        End Set
    End Property

    <DataMember()> _
   Public Property IdMaterial() As String
        Get
            Return _idMaterial
        End Get
        Set(ByVal value As String)
            _idMaterial = value
        End Set
    End Property

    <DataMember()> _
   Public Property IndColor() As String
        Get
            _indcolor = _cocada - _cocadaminima
            Return _indcolor
        End Get
        Set(ByVal value As String)
            _indcolor = value
        End Set
    End Property

#End Region

#Region "Contructor"

    Public Sub New()
        _id = String.Empty
        _idpreliminarinspeccion = String.Empty
        _idoperacionneu = String.Empty
        _codneumatico = String.Empty
        _placa = String.Empty
        _codneumatico = String.Empty
        _marca = String.Empty
        _modelo = String.Empty
        _medida = String.Empty
        _posicion = 0
        _cocada = 0
        _kilometraje = 0
        _fechaoperacion = #1/1/1901#
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _cocadaminima = 0
        _idmarcar = String.Empty
        _idmedidar = String.Empty
        _iddiseniopedido = String.Empty
        _confirmado = 0
        _observacion = String.Empty
        _dot = String.Empty
        _activo = True
        _tipomedida = String.Empty
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdPreliminarInspeccion As String _
              , ByVal ls_IdOperacionNeu As String _
              , ByVal ls_CodOperacion As String _
              , ByVal ls_Placa As String _
              , ByVal ln_Motriz As Integer _
              , ByVal ls_CodNeumatico As String _
              , ByVal ls_Marca As String _
              , ByVal ls_Modelo As String _
              , ByVal ls_Medida As String _
              , ByVal ls_TipoBanda As String _
              , ByVal ln_Posicion As Integer _
              , ByVal ln_Cocada As Double _
              , ByVal ln_Kilometraje As Double _
              , ByVal ld_FechaOperacion As Date _
              , ByVal ln_CocadaMinima As Double _
              , ByVal ls_IdMarcaR As String _
              , ByVal ls_IdMedidaR As String _
              , ByVal ls_IdDisenioPedido As String _
              , ByVal ls_TipoBandaPedido As String _
              , ByVal ln_Confirmado As Integer _
              , ByVal ls_Observacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_IdVidaNeumatico As String _
              , ByVal ls_IdMaterial As String _
              , ByVal ls_DOT As String _
              , ByVal ls_Flota As String _
           )
        _id = ls_Id
        _idpreliminarinspeccion = ls_IdPreliminarInspeccion
        _idoperacionneu = ls_IdOperacionNeu
        _codoperacion = ls_CodOperacion
        _placa = ls_Placa
        _motriz = ln_Motriz
        _codneumatico = ls_CodNeumatico
        _marca = ls_Marca
        _modelo = ls_Modelo
        _medida = ls_Medida
        _tipobanda = ls_TipoBanda
        _posicion = ln_Posicion
        _cocada = ln_Cocada
        _kilometraje = ln_Kilometraje
        _fechaoperacion = ld_FechaOperacion
        _cocadaminima = ln_CocadaMinima
        _idmarcar = ls_IdMarcaR
        _idmedidar = ls_IdMedidaR
        _iddiseniopedido = ls_IdDisenioPedido
        _tipobandapedido = ls_TipoBandaPedido
        _confirmado = ln_Confirmado
        _observacion = ls_Observacion
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
        _idvidaneumatico = ls_IdVidaNeumatico
        _idMaterial = ls_IdMaterial
        _dot = ls_DOT
        _flota = ls_Flota
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal detallepreliminar As e_DetallePreliminar) As e_DetallePreliminar Implements Ie_DetallePreliminar.Obtener
        Return detallepreliminar
    End Function

    Public Overloads Function Equals(ByVal oeDetPreliminar As e_DetallePreliminar) _
As Boolean Implements System.IEquatable(Of e_DetallePreliminar).Equals
        If Me.IdVidaNeumatico = oeDetPreliminar.IdVidaNeumatico Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region

End Class
