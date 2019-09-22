
''' <summary>
''' Clase creada para implementar la dirección de trabajadores
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Direccion
    Implements Ie_Direccion

#Region "Declaracion de Variables"

    Private _id As String
    Private _idtipovia As String
    Private _tipovia As String
    Private _via As String
    Private _numero As String
    Private _departamento As String
    Private _numerointerior As String
    Private _manzana As String
    Private _lote As String
    Private _kilometro As String
    Private _block As String
    Private _etapa As String
    Private _idtipozona As String
    Private _tipozona As String
    Private _zona As String
    Private _referencia As String
    Private _ccpp As String
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _nombreccpp As String
    Private _nombreUbigeo As String
    Private _nombre As String
    Private _idlugar As String
    Private _lugar As String
    Private _CentroCosto As String
    Private _centroasistenciaessalud As Integer
    Private _IdPais As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
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
    Public Property IdTipoVia() As String
        Get
            Return _idtipovia
        End Get
        Set(ByVal value As String)
            _idtipovia = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoVia() As String
        Get
            Return _tipovia
        End Get
        Set(ByVal value As String)
            _tipovia = value
        End Set
    End Property

    <DataMember()> _
    Public Property Via() As String
        Get
            Return _via
        End Get
        Set(ByVal value As String)
            _via = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Departamento() As String
        Get
            Return _departamento
        End Get
        Set(ByVal value As String)
            _departamento = value
        End Set
    End Property

    <DataMember()> _
    Public Property NumeroInterior() As String
        Get
            Return _numerointerior
        End Get
        Set(ByVal value As String)
            _numerointerior = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Manzana() As String
        Get
            Return _manzana
        End Get
        Set(ByVal value As String)
            _manzana = value
        End Set
    End Property

    <DataMember()> _
    Public Property Lote() As String
        Get
            Return _lote
        End Get
        Set(ByVal value As String)
            _lote = value
        End Set
    End Property

    <DataMember()> _
    Public Property Kilometro() As String
        Get
            Return _kilometro
        End Get
        Set(ByVal value As String)
            _kilometro = value
        End Set
    End Property

    <DataMember()> _
    Public Property Block() As String
        Get
            Return _block
        End Get
        Set(ByVal value As String)
            _block = value
        End Set
    End Property

    <DataMember()> _
    Public Property Etapa() As String
        Get
            Return _etapa
        End Get
        Set(ByVal value As String)
            _etapa = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoZona() As String
        Get
            Return _idtipozona
        End Get
        Set(ByVal value As String)
            _idtipozona = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoZona()
        Get
            Return _tipozona
        End Get
        Set(ByVal value)
            _tipozona = value
        End Set
    End Property

    <DataMember()> _
    Public Property Zona() As String
        Get
            Return _zona
        End Get
        Set(ByVal value As String)
            _zona = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return DireccionCompleta()
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property Referencia() As String
        Get
            Return _referencia
        End Get
        Set(ByVal value As String)
            _referencia = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CCPP() As String
        Get
            Return _ccpp
        End Get
        Set(ByVal value As String)
            _ccpp = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NombreUbigeo() As String
        Get
            Return _nombreUbigeo
        End Get
        Set(ByVal value As String)
            _nombreUbigeo = value
        End Set
    End Property

    <DataMember()> _
    Public Property NombreCCPP() As String
        Get
            Return _nombreccpp
        End Get
        Set(ByVal value As String)
            _nombreccpp = value
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
    Public Property IdLugar() As String
        Get
            Return _idlugar
        End Get
        Set(ByVal value As String)
            _idlugar = value
        End Set
    End Property

    <DataMember()> _
    Public Property Lugar() As String
        Get
            Return _lugar
        End Get
        Set(ByVal value As String)
            _lugar = value
        End Set
    End Property

    <DataMember()> _
   Public Property CentroCosto() As String
        Get
            Return _CentroCosto
        End Get
        Set(ByVal value As String)
            _CentroCosto = value
        End Set
    End Property

    <DataMember()> _
    Public Property CentroAsistenciaEsSalud() As Integer
        Get
            Return _centroasistenciaessalud
        End Get
        Set(ByVal value As Integer)
            _centroasistenciaessalud = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdPais() As String
        Get
            Return _IdPais
        End Get
        Set(ByVal value As String)
            _IdPais = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _idtipovia = String.Empty
        _via = String.Empty
        _numero = String.Empty
        _departamento = String.Empty
        _numerointerior = String.Empty
        _manzana = String.Empty
        _lote = String.Empty
        _kilometro = String.Empty
        _block = String.Empty
        _etapa = String.Empty
        _centroasistenciaessalud = 0
        _idtipozona = String.Empty
        _zona = String.Empty
        _referencia = String.Empty
        _ccpp = String.Empty
        _activo = True
        _usuariocreacion = String.Empty
        _fechacreacion = #1/1/1901#
        _nombreccpp = String.Empty
        _idlugar = String.Empty
        _lugar = String.Empty
        _IdPais = String.Empty
        TipoOperacion = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdTipoVia As String _
              , ByVal ls_Via As String _
              , ByVal ln_Numero As String _
              , ByVal ls_Departamento As String _
              , ByVal ls_NumeroInterior As String _
              , ByVal ls_Manzana As String _
              , ByVal ls_Lote As String _
              , ByVal ls_Kilometro As String _
              , ByVal ls_Block As String _
              , ByVal ls_Etapa As String _
              , ByVal ls_IdTipoZona As String _
              , ByVal ls_Zona As String _
              , ByVal ls_Referencia As String _
              , ByVal ls_CCPP As String _
              , ByVal ls_NombreCCPP As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_IdLugar As String _
              , ByVal ls_Lugar As String _
              , ByVal ls_CentroCosto As String _
              , ByVal ln_CentroAsistenciaEsSalud As Integer _
              , ByVal ls_IdPais As String)

        _id = ls_Id
        _idtipovia = ls_IdTipoVia
        _via = ls_Via
        _numero = ln_Numero
        _departamento = ls_Departamento
        _numerointerior = ls_NumeroInterior
        _manzana = ls_Manzana
        _lote = ls_Lote
        _kilometro = ls_Kilometro
        _block = ls_Block
        _etapa = ls_Etapa
        _idtipozona = ls_IdTipoZona
        _zona = ls_Zona
        _referencia = ls_Referencia
        _ccpp = ls_CCPP
        _nombreccpp = ls_NombreCCPP
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _idlugar = ls_IdLugar
        _lugar = ls_Lugar
        _CentroCosto = ls_CentroCosto
        _centroasistenciaessalud = ln_CentroAsistenciaEsSalud
        _IdPais = ls_IdPais
    End Sub

#End Region

#Region "Metodo"

    Public Function DireccionCompleta() As String
        Dim _dir As String
        _dir = _tipovia & " " & _via
        If _numero.Trim <> "" Then _dir = _dir & " NRO. " & _numero
        If _departamento.Trim <> "" Then _dir = _dir & " DPTO. " & _departamento
        If _numerointerior.Trim <> "" Then _dir = _dir & " INT. " & _numerointerior
        If _manzana.Trim <> "" Then _dir = _dir & " MZA. " & _manzana
        If _lote.Trim <> "" Then _dir = _dir & " LT. " & _lote
        If _kilometro.Trim <> "" Then _dir = _dir & " KM. " & _kilometro
        If _block.Trim <> "" Then _dir = _dir & " " & _block
        If _etapa.Trim <> "" Then _dir = _dir & " " & _etapa
        _dir = _dir & " " & _tipozona & " " & _zona
        Return _dir
    End Function

    Public Function Obtener(ByVal direccion As e_Direccion) As e_Direccion Implements Ie_Direccion.Obtener
        Return direccion
    End Function

#End Region

End Class


