<DataContract()> _
Public Class e_Combo
    Implements Ie_Combo
    Implements IEquatable(Of e_Combo)

#Region "Propiedad"

    Private _id As String
    Private _nombre As String
    Private _Descripcion As String
    Private _extras As ArrayList

    Public TipoOperacion As String = ""
    Public IdEmpresaSis As String = ""
    Public Tipo As Integer = 0
    <DataMember()> _
    Public Fecha As Date = Date.Parse("01/01/1901")

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
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Extras() As ArrayList
        Get
            Return _extras
        End Get
        Set(ByVal value As ArrayList)
            _extras = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Sub New()
        Id = ""
        Nombre = ""
        Descripcion = ""
        Extras = New ArrayList
    End Sub

    Public Sub New(ByVal ls_Id As String, ByVal ls_Nombre As String, ByVal ls_Descripcion As String)
        _id = ls_Id
        _nombre = ls_Nombre
        _Descripcion = ls_Descripcion
    End Sub

    Public Sub New(ByVal ls_Id As String, ByVal ls_Nombre As String, ByVal ls_Descripcion As String, ByVal array As ArrayList)
        _id = ls_Id
        _nombre = ls_Nombre
        _Descripcion = ls_Descripcion
        _extras = array
    End Sub

#End Region

#Region "Métodos"

    Public Sub Dispose()
        Id = ""
        Nombre = ""
        Descripcion = ""
        Extras = New ArrayList
    End Sub

    ''' <summary>
    ''' Obtener una entidad de tipo e_Combo
    ''' </summary>
    ''' <param name="combo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal combo As e_Combo) As e_Combo Implements Ie_Combo.Obtener
        Return combo
    End Function

    Public Function Equals1(ByVal other As e_Combo) As Boolean Implements System.IEquatable(Of e_Combo).Equals
        Select Case other.Tipo
            Case 0
                If Me.Id.Trim = other.Id.Trim Then Return True
            Case 1
                If Me.Nombre.Trim = other.Nombre.Trim Then Return True
            Case 2
                If Me.Descripcion.Trim = other.Descripcion Then Return True
            Case 3
                If Me.Id.Trim = other.Id And Me.Nombre.Trim = other.Nombre Then Return True
            Case 4
                If Me.Nombre.Trim = other.Nombre And Me.Descripcion.Trim = other.Descripcion Then Return True
            Case 5
                If Me.Id.Trim = other.Id.Trim And Me.Descripcion.Trim = other.Descripcion.Trim Then Return True
        End Select
        Return False
    End Function

#End Region

End Class


