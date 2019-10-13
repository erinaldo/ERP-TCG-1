''' <summary>
''' Clase para definir la entidad: Moneda
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Moneda
    Implements Ie_Moneda
    Implements IEquatable(Of e_Moneda)
    Implements IPropiedadesBasicas

#Region "Propiedades"

    Private _id As String
    Private _codigo As String
    Private _nombre As String
    Private _abreviatura As String
    Private _idpais As String
    Private _activo As Boolean

    <DataMember()>
    Public TipoOperacion As String
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

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
    Public Property Codigo() As String Implements IPropiedadesBasicas.Codigo
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
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
    Public Property Abreviatura() As String
        Get
            Return _abreviatura
        End Get
        Set(ByVal value As String)
            _abreviatura = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdPais() As String
        Get
            Return _idpais
        End Get
        Set(ByVal value As String)
            _idpais = value
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

#End Region

#Region "Constructor"
    Sub New()
        TipoOperacion = ""
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_Abreviatura As String _
              , ByVal ls_IdPais As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _codigo = ls_Codigo
        _nombre = ls_Nombre
        _abreviatura = ls_Abreviatura
        _idpais = ls_IdPais
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal moneda As e_Moneda) As e_Moneda Implements Ie_Moneda.Obtener
        Return moneda
    End Function

    Public Overloads Function Equals(ByVal oeMoneda As e_Moneda) As Boolean Implements System.IEquatable(Of e_Moneda).Equals
        If Me.Nombre = oeMoneda.Nombre Then
            Return True
        ElseIf Me.Id = oeMoneda.Id Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region

End Class


