''' <summary>
''' Clase para definir la entidad: Telefono
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Telefono
    Implements Ie_Telefono
    Implements IEquatable(Of e_Telefono)
    Implements IPropiedadesBasicas

#Region "Declaracion de Variables"

    Private _id As String
    Private _tipo As String
    Private _nomtipo As String
    Private _tipopersonaempresa As Integer
    Private _idpersonaempresa As String
    Private _codigolargadistancia As String
    Private _nombre As String
    Private _principal As Integer
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _idOperadorTelefonico As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Equivale As Integer

#End Region

#Region "Propiedad"

    <DataMember()> _
    Public Property Id() As String Implements IPropiedadesBasicas.Id
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property NomTipo() As String
        Get
            Select Case _tipo
                Case "1" : _nomtipo = "MOVIL"
                Case "2" : _nomtipo = "FIJO"
            End Select
            Return _nomtipo
        End Get
        Set(ByVal value As String)
            _nomtipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoPersonaEmpresa() As Integer
        Get
            Return _tipopersonaempresa
        End Get
        Set(ByVal value As Integer)
            _tipopersonaempresa = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdPersonaEmpresa() As String
        Get
            Return _idpersonaempresa
        End Get
        Set(ByVal value As String)
            _idpersonaempresa = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoLargaDistancia() As String Implements IPropiedadesBasicas.Codigo
        Get
            Return _codigolargadistancia
        End Get
        Set(ByVal value As String)
            _codigolargadistancia = value
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String Implements IPropiedadesBasicas.Nombre
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property Principal() As Integer
        Get
            Return _principal
        End Get
        Set(ByVal value As Integer)
            _principal = value
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
    Public Property Activo() As Boolean Implements IPropiedadesBasicas.Activo
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdOperadorTelefonico() As String
        Get
            Return _idOperadorTelefonico
        End Get
        Set(ByVal value As String)
            _idOperadorTelefonico = value
        End Set
    End Property
#End Region

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _tipo = String.Empty
        _codigolargadistancia = String.Empty
        _nombre = String.Empty
        _idpersonaempresa = String.Empty
        _tipopersonaempresa = -1
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _principal = 0
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Tipo As String _
              , ByVal ln_TipoPersonaEmpresa As Integer _
              , ByVal ls_IdPersonaEmpresa As String _
              , ByVal ls_CodigoLargaDistancia As String _
              , ByVal ls_Nombre As String _
              , ByVal ln_Principal As Integer _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _tipo = ls_Tipo
        _tipopersonaempresa = ln_TipoPersonaEmpresa
        _idpersonaempresa = ls_IdPersonaEmpresa
        _codigolargadistancia = ls_CodigoLargaDistancia
        _nombre = ls_Nombre
        _principal = ln_Principal
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal telefono As e_Telefono) As e_Telefono Implements Ie_Telefono.Obtener
        Return telefono
    End Function

    Public Function NumeroCompleto() As String
        Dim _num As String
        If _tipo = "2" Then
            If _codigolargadistancia.Trim <> "" Then
                _num = _codigolargadistancia & " - " & _nombre
            Else
                _num = _nombre
            End If
        Else
            _num = _nombre
        End If
        Return _num
    End Function

    Public Overloads Function Equals(ByVal oeTel As e_Telefono) _
 As Boolean Implements System.IEquatable(Of e_Telefono).Equals
        Select Case oeTel.Equivale
            Case 1 : If Me.Id = oeTel.Id Then Return True
            Case 2 : If Me.Nombre = oeTel.Nombre Then Return True
            Case 3 : If Me.NumeroCompleto = oeTel.NumeroCompleto Then Return True
        End Select
        Return False
    End Function

#End Region

End Class


