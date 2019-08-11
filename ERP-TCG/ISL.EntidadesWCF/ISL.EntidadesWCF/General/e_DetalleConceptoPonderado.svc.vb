<DataContract()> _
Public Class e_DetalleConceptoPonderado
    Implements Ie_DetalleConceptoPonderado
    Implements IEquatable(Of e_DetalleConceptoPonderado)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idconceptoponderado As String
    Private _nroorden As Integer
    Private _codigo As String
    Private _nombre As String
    Private _abreviatura As String
    Private _porcentaje As Double
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _fechamodifica As Date
    Private _usuariomodifica As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Equivale As Integer

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
    Public Property IdConceptoPonderado() As String
        Get
            Return _idconceptoponderado
        End Get
        Set(ByVal value As String)
            _idconceptoponderado = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroOrden() As Integer
        Get
            Return _nroorden
        End Get
        Set(ByVal value As Integer)
            _nroorden = value
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property Abreviatura() As String
        Get
            Return _abreviatura
        End Get
        Set(ByVal value As String)
            _abreviatura = value
        End Set
    End Property

    <DataMember()> _
    Public Property Porcentaje() As Double
        Get
            Return _porcentaje
        End Get
        Set(ByVal value As Double)
            _porcentaje = value
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
    Public Property FechaModifica() As Date
        Get
            Return _fechamodifica
        End Get
        Set(ByVal value As Date)
            _fechamodifica = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioModifica() As String
        Get
            Return _usuariomodifica
        End Get
        Set(ByVal value As String)
            _usuariomodifica = value
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

#Region "Contructor"

    Public Sub New()
        _id = String.Empty
        _idconceptoponderado = String.Empty
        _codigo = String.Empty
        _nombre = String.Empty
        _abreviatura = String.Empty
        _porcentaje = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _fechamodifica = #1/1/1901#
        _usuariomodifica = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdConceptoPonderado As String _
              , ByVal ln_NroOrden As Integer _
              , ByVal ls_Codigo As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_Abreviatura As String _
              , ByVal ln_Porcentaje As Double _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaModifica As Date _
              , ByVal ls_UsuarioModifica As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idconceptoponderado = ls_IdConceptoPonderado
        _nroorden = ln_NroOrden
        _codigo = ls_Codigo
        _nombre = ls_Nombre
        _abreviatura = ls_Abreviatura
        _porcentaje = ln_Porcentaje
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(DetalleConceptoPonderado As e_DetalleConceptoPonderado) As e_DetalleConceptoPonderado Implements Ie_DetalleConceptoPonderado.Obtener
        Return DetalleConceptoPonderado
    End Function

    Public Overloads Function Equals(ByVal oeDCP As e_DetalleConceptoPonderado) As Boolean Implements System.IEquatable(Of e_DetalleConceptoPonderado).Equals
        Select Case oeDCP.Equivale
            Case 1 : If Me.Id = oeDCP.Id Then Return True
            Case 2 : If Me.Codigo = oeDCP.Codigo Then Return True
            Case 3 : If Me.Abreviatura = oeDCP.Abreviatura Then Return True
        End Select
        Return False
    End Function

#End Region



End Class
