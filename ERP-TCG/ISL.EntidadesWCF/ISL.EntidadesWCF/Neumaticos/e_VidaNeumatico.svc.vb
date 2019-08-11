<DataContract()> _
Public Class e_VidaNeumatico
    Implements Ie_VidaNeumatico
    Implements IEquatable(Of e_VidaNeumatico)

#Region "Declaracion de Variables"

    Private _id As String
    Private _neumatico As String
    Private _cocadamin As Double
    Private _codneumatico As String
    Private _costocasodol As Double
    Private _iddisenio As String
    Private _disenio As String
    Private _idmarca As String
    Private _marca As String
    Private _idmedida As String
    Private _medida As String
    Private _kmactual As Double
    Private _nrovida As Integer
    Private _fechaingreso As Date
    Private _condicion As String
    Private _estadoactual As String
    Private _ubicacion As String
    Private _kilometraje As Double
    Private _ribete1 As Double
    Private _ribete2 As Double
    Private _ribete3 As Double
    Private _ribete4 As Double
    Private _cocada As Double
    Private _cocadaoriginal As Double
    Private _costosoles As Double
    Private _costodolares As Double
    Private _idproveedor As String
    Private _proveedor
    Private _vigente As Integer
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _fechafinvida As Date
    Private _iddisenoneu As String
    Private _indlugar As Integer
    Private _lugar As String
    Private _indlog As Integer
    Private _Almacen As String
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public leOpeNeuAux As New List(Of e_OperacionNeumatico)
    <DataMember()> _
    Public Equivale As Integer = 0
    <DataMember()> _
    Public ls_IdMaterial As String

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
    Public Property IdNeumatico() As String
        Get
            Return _neumatico
        End Get
        Set(ByVal value As String)
            _neumatico = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoNeumatico() As String
        Get
            Return _codneumatico
        End Get
        Set(ByVal value As String)
            _codneumatico = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMarca() As String
        Get
            Return _idmarca
        End Get
        Set(ByVal value As String)
            _idmarca = value
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
    Public Property IdMedida() As String
        Get
            Return _idmedida
        End Get
        Set(ByVal value As String)
            _idmedida = value
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
    Public Property IdDiseño() As String
        Get
            Return _iddisenio
        End Get
        Set(ByVal value As String)
            _iddisenio = value
        End Set
    End Property

    <DataMember()> _
    Public Property Diseño() As String
        Get
            Return _disenio
        End Get
        Set(ByVal value As String)
            _disenio = value
        End Set
    End Property

    <DataMember()> _
    Public Property KmTotalNeumatico() As Double
        Get
            Return _kmactual
        End Get
        Set(ByVal value As Double)
            _kmactual = value
        End Set
    End Property

    <DataMember()> _
    Public Property Condicion() As String
        Get
            Return _condicion
        End Get
        Set(ByVal value As String)
            _condicion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NroVida() As Integer
        Get
            Return _nrovida
        End Get
        Set(ByVal value As Integer)
            _nrovida = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaIngreso() As Date
        Get
            Return _fechaingreso
        End Get
        Set(ByVal value As Date)
            _fechaingreso = value
        End Set
    End Property

    <DataMember()> _
    Public Property EstadoActual() As String
        Get
            Return _estadoactual
        End Get
        Set(ByVal value As String)
            _estadoactual = value
        End Set
    End Property

    <DataMember()> _
    Public Property Ubicacion() As String
        Get
            Return _ubicacion
        End Get
        Set(ByVal value As String)
            _ubicacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Kilometraje() As Double
        Get
            Return _kilometraje
        End Get
        Set(ByVal value As Double)
            _kilometraje = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ribete1() As Double
        Get
            Return _ribete1
        End Get
        Set(ByVal value As Double)
            _ribete1 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ribete2() As Double
        Get
            Return _ribete2
        End Get
        Set(ByVal value As Double)
            _ribete2 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ribete3() As Double
        Get
            Return _ribete3
        End Get
        Set(ByVal value As Double)
            _ribete3 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ribete4() As Double
        Get
            Return _ribete4
        End Get
        Set(ByVal value As Double)
            _ribete4 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Cocada() As Double
        Get
            Return _cocada
        End Get
        Set(ByVal value As Double)
            _cocada = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CocadaOriginal() As Double
        Get
            Return _cocadaoriginal
        End Get
        Set(ByVal value As Double)
            _cocadaoriginal = value
        End Set
    End Property

    <DataMember()> _
    Public Property CostoSoles() As Double
        Get
            Return _costosoles
        End Get
        Set(ByVal value As Double)
            _costosoles = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CostoDolares() As Double
        Get
            Return _costodolares
        End Get
        Set(ByVal value As Double)
            _costodolares = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CostoDolxMilKm() As Double
        Get
            Return Math.Round((_costodolares / _kilometraje) * 1000, 2)
        End Get
        Set(ByVal value As Double)
        End Set
    End Property
    '--------------------------------------------------------------
    <DataMember()> _
    Public Property CostoCascoDolares() As Double
        Get
            Return _costocasodol
        End Get
        Set(ByVal value As Double)
            _costocasodol = value
        End Set
    End Property

    <DataMember()> _
    Public Property CocadaMinima() As Double
        Get
            Return _cocadamin
        End Get
        Set(ByVal value As Double)
            _cocadamin = value
        End Set
    End Property

    <DataMember()> _
    Public Property CostoActualDolares() As Double
        Get
            Return Math.Round((_costodolares - CostoCascoDolares) * (_cocada - CocadaMinima) / (_cocadaoriginal - CocadaMinima), 2)
        End Get
        Set(ByVal value As Double)
        End Set
    End Property

    <DataMember()> _
   Public Property KmProyectado() As Double
        Get
            Return Math.Round((_kilometraje / (_cocadaoriginal - _cocada)) * (_cocadaoriginal - CocadaMinima), 2)
        End Get
        Set(ByVal value As Double)
        End Set
    End Property

    '--------------------------------------------------------------

    <DataMember()> _
    Public Property IdProveedor() As String
        Get
            Return _idproveedor
        End Get
        Set(ByVal value As String)
            _idproveedor = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Proveedor() As String
        Get
            Return _proveedor
        End Get
        Set(ByVal value As String)
            _proveedor = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Vigente() As Integer
        Get
            Return _vigente
        End Get
        Set(ByVal value As Integer)
            _vigente = value
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
    Public Property FechaFinVida() As Date
        Get
            Return _fechafinvida
        End Get
        Set(ByVal value As Date)
            _fechafinvida = value
        End Set
    End Property

    <DataMember()> _
Public Property IdDisenoNeu() As String
        Get
            Return _iddisenoneu
        End Get
        Set(ByVal value As String)
            _iddisenoneu = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndLugar() As Integer
        Get
            Return _indlugar
        End Get
        Set(ByVal value As Integer)
            _indlugar = value
        End Set
    End Property

    <DataMember()> _
    Public Property Lugar() As String
        Get
            Select Case IndLugar
                Case 0 : _lugar = "PACASMAYO"
                Case 1 : _lugar = "LIMA"
                Case 2 : _lugar = "CHICLAYO"
                Case 3 : _lugar = "PIURA"
            End Select
            Return _lugar
        End Get
        Set(ByVal value As String)
            _lugar = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndLog() As Integer
        Get
            Return _indlog
        End Get
        Set(ByVal value As Integer)
            _indlog = value
        End Set
    End Property

    <DataMember()> _
    Public Property Almacen() As String
        Get
            Select Case IndLog
                Case 0 : _Almacen = "STAND-BY"
                Case 1 : _Almacen = "STOCK"
            End Select
            Return _Almacen
        End Get
        Set(ByVal value As String)
            _Almacen = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()

        _id = String.Empty
        _neumatico = String.Empty
        _codneumatico = String.Empty
        _iddisenio = String.Empty
        _disenio = String.Empty
        _idmarca = String.Empty
        _marca = String.Empty
        _idmedida = String.Empty
        _medida = String.Empty
        _kmactual = 0
        _kilometraje = 0
        _costocasodol = 0
        _costodolares = 0
        _costosoles = 0

        _nrovida = 0
        _fechaingreso = #1/1/1901#
        _condicion = String.Empty
        _estadoactual = String.Empty
        _ubicacion = String.Empty
        _kilometraje = 0
        _ribete1 = 0
        _ribete2 = 0
        _ribete3 = 0
        _ribete4 = 0
        _cocada = 0
        _cocadaoriginal = 0
        _idproveedor = String.Empty
        _proveedor = String.Empty
        _vigente = 0
        _activo = True
        _usuariocreacion = String.Empty

        _fechafinvida = #1/1/1901#
        _iddisenoneu = String.Empty
        _indlugar = 0
        _indlog = 0

        TipoOperacion = String.Empty

    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdNeumatico As String _
              , ByVal ls_CodigoeNeumatico As String _
              , ByVal ls_IdDiseño As String _
              , ByVal ls_Diseño As String _
              , ByVal ls_IdMarca As String _
              , ByVal ls_Marca As String _
              , ByVal ls_IdMedida As String _
              , ByVal ls_Medida As String _
              , ByVal ld_KmTotalNeu As Double _
              , ByVal ld_CostoCascoDol As Double _
              , ByVal ld_CocadaMimina As Double _
              , ByVal ln_NroVida As Integer _
              , ByVal ld_FechaIngreso As Date _
              , ByVal ls_Condicion As String _
              , ByVal ls_EstadoActual As String _
              , ByVal ls_Ubicacion As String _
              , ByVal ln_KM As Double _
              , ByVal ln_Ribete1 As Double _
              , ByVal ln_Ribete2 As Double _
              , ByVal ln_Ribete3 As Double _
              , ByVal ln_Ribete4 As Double _
              , ByVal ln_Cocada As Double _
              , ByVal ln_CocadaOriginal As Double _
              , ByVal ln_CostoSoles As Double _
              , ByVal ln_CostoDolares As Double _
              , ByVal ls_IdProveedor As String _
              , ByVal ls_Proveedor As String _
              , ByVal ln_Vigente As Integer _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaFinVida As Date _
              , ByVal ls_IdDisenoNeu As String _
              , ByVal ln_IndLugar As Integer _
              , ByVal ln_IndLog As Integer _
           )

        _id = ls_Id
        _neumatico = ls_IdNeumatico
        _codneumatico = ls_CodigoeNeumatico
        _disenio = ls_Diseño
        _iddisenio = ls_IdDiseño
        _marca = ls_Marca
        _idmarca = ls_IdMarca
        _medida = ls_Medida
        _idmedida = ls_IdMedida
        _kmactual = ld_KmTotalNeu
        _costocasodol = ld_CostoCascoDol
        _cocadamin = ld_CocadaMimina

        _nrovida = ln_NroVida
        _fechaingreso = ld_FechaIngreso
        _condicion = ls_Condicion
        _estadoactual = ls_EstadoActual
        _ubicacion = ls_Ubicacion
        _kilometraje = ln_KM
        _ribete1 = ln_Ribete1
        _ribete2 = ln_Ribete2
        _ribete3 = ln_Ribete3
        _ribete4 = ln_Ribete4
        _cocada = ln_Cocada
        _cocadaoriginal = ln_CocadaOriginal
        _costosoles = ln_CostoSoles
        _costodolares = ln_CostoDolares
        _idproveedor = ls_IdProveedor
        _proveedor = ls_Proveedor
        _vigente = ln_Vigente
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion

        _fechafinvida = ld_FechaFinVida
        _iddisenoneu = ls_IdDisenoNeu

        _indlugar = ln_IndLugar
        _indlog = ln_IndLog

    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_VidaNeumatico
    ''' </summary>
    ''' <param name="vidaNeumatico"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal vidaNeumatico As e_VidaNeumatico) As e_VidaNeumatico Implements Ie_VidaNeumatico.Obtener
        Return vidaNeumatico
    End Function

    Public Overloads Function Equals(ByVal oeVidaNeu As e_VidaNeumatico) As Boolean Implements System.IEquatable(Of e_VidaNeumatico).Equals
        Select Case oeVidaNeu.Equivale
            Case 0 : If Me.Id = oeVidaNeu.Id Then Return True
            Case 1 : If Me.Vigente = oeVidaNeu.Vigente Then Return True
        End Select
        Return False
    End Function

#End Region

End Class
