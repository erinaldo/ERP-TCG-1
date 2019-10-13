<DataContract()> _
Public Class e_Direccion_EmpresaPersona
    Implements Ie_Direccion_EmpresaPersona
    Implements IEquatable(Of e_Direccion_EmpresaPersona)

#Region "Declaracion de Variables"

    Private _id As String
    Private _nomdireccion As String
    Private _tipopersonaempresa As Integer
    Private _idpersonaempresa As String
    Private _principal As Integer
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public _nombredd As String
    <DataMember()> _
    Public _nombrepp As String
    <DataMember()> _
    Public _nombredi As String
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public oeDireccion As New e_Direccion
    <DataMember()> _
    Public Equivale As String = ""

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
    Public Property Nombre() As String
        Get
            Return NombreDir1()
        End Get
        Set(ByVal value As String)
            _nomdireccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoPersonaEmpresa() As Integer
        Get
            Return _tipopersonaempresa
        End Get
        Set(ByVal value As Integer)
            _tipopersonaempresa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdPersonaEmpresa() As String
        Get
            Return _idpersonaempresa
        End Get
        Set(ByVal value As String)
            _idpersonaempresa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Principal() As Integer
        Get
            Return _principal
        End Get
        Set(ByVal value As Integer)
            _principal = value
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

    '<DataMember()> _
    'Public Property IdLugar() As String
    '    Get
    '        Return _idlugar
    '    End Get
    '    Set(ByVal value As String)
    '        _idlugar = value
    '        RaiseEvent DatoCambiado()
    '    End Set
    'End Property

    '<DataMember()> _
    'Public Property Lugar() As String
    '    Get
    '        Return _lugar
    '    End Get
    '    Set(ByVal value As String)
    '        _lugar = value
    '        RaiseEvent DatoCambiado()
    '    End Set
    'End Property

    '<DataMember()> _
    'Public Property CentroCosto() As String
    '    Get
    '        Return _CentroCosto
    '    End Get
    '    Set(ByVal value As String)
    '        _CentroCosto = value
    '        RaiseEvent DatoCambiado()
    '    End Set
    'End Property

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        _id = String.Empty
        _tipopersonaempresa = 0
        _idpersonaempresa = String.Empty
        _principal = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _activo = True
        'NombreCCPP = ""
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdDireccion As String _
              , ByVal ls_IdTipoVia As String _
              , ByVal ls_TipoVia As String _
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
              , ByVal ls_TipoZona As String _
              , ByVal ls_Zona As String _
              , ByVal ls_Referencia As String _
              , ByVal ls_CCPP As String _
              , ByVal ls_NombreCCPP As String _
              , ByVal ls_NombreDD As String _
              , ByVal ls_NombrePP As String _
              , ByVal ls_NombreDI As String _
              , ByVal ln_TipoPersonaEmpresa As Integer _
              , ByVal ls_IdPersonaEmpresa As String _
              , ByVal lb_Principal As Boolean _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_IdLugar As String _
              , ByVal ls_Lugar As String _
              , ByVal ls_CentroCosto As String _
              , ByVal ln_CentroAsistenciaEsSalud As Integer)
        _id = ls_Id
        _nombredd = ls_NombreDD
        _nombrepp = ls_NombrePP
        _nombredi = ls_NombreDI
        _tipopersonaempresa = ln_TipoPersonaEmpresa
        _idpersonaempresa = ls_IdPersonaEmpresa
        _principal = IIf(lb_Principal, 1, 0)
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
        TipoOperacion = ""

        oeDireccion.Id = ls_IdDireccion
        oeDireccion.IdTipoVia = ls_IdTipoVia
        oeDireccion.TipoVia = ls_TipoVia
        oeDireccion.Via = ls_Via
        oeDireccion.Numero = ln_Numero
        oeDireccion.Departamento = ls_Departamento
        oeDireccion.NumeroInterior = ls_NumeroInterior
        oeDireccion.Manzana = ls_Manzana
        oeDireccion.Lote = ls_Lote
        oeDireccion.Kilometro = ls_Kilometro
        oeDireccion.Block = ls_Block
        oeDireccion.Etapa = ls_Etapa
        oeDireccion.IdTipoZona = ls_IdTipoZona
        oeDireccion.TipoZona = ls_TipoZona
        oeDireccion.Zona = ls_Zona
        oeDireccion.CCPP = ls_CCPP
        oeDireccion.NombreCCPP = ls_NombreCCPP
        oeDireccion.Referencia = ls_Referencia
        oeDireccion.IdLugar = ls_IdLugar
        oeDireccion.Lugar = ls_Lugar
        oeDireccion.CentroCosto = ls_CentroCosto
        oeDireccion.CentroAsistenciaEsSalud = ln_CentroAsistenciaEsSalud

    End Sub

#End Region

#Region "Metodos"

    Public Overloads Function Equals(ByVal oeDireccionEP As e_Direccion_EmpresaPersona) As Boolean Implements System.IEquatable(Of e_Direccion_EmpresaPersona).Equals
        Select Case oeDireccionEP.Equivale
            Case "1"
                If Me.Nombre = oeDireccionEP.Nombre Then Return True
            Case "2"
                If Me.Id = oeDireccionEP.Id Then Return True
            Case "3"
                If Me.oeDireccion.Id = oeDireccionEP.oeDireccion.Id.Trim Then Return True
            Case Else
                If Me.Id = oeDireccionEP.Id OrElse Me.oeDireccion.Id = oeDireccionEP.oeDireccion.Id Then Return True
        End Select
        Return False
    End Function

    Public Function Obtener(ByVal direccion_EmpresaPersona As e_Direccion_EmpresaPersona) As e_Direccion_EmpresaPersona Implements Ie_Direccion_EmpresaPersona.Obtener
        Return direccion_EmpresaPersona
    End Function

    Public Function NombreDir1() As String
        Return oeDireccion.DireccionCompleta & " " & _nombredd & " - " & _nombrepp & " - " & _nombredi
    End Function

    Public Function NombreDir2() As String
        Return oeDireccion.DireccionCompleta & " " & _nombredi & " - " & _nombrepp & " - " & _nombredd
    End Function

#End Region

End Class


