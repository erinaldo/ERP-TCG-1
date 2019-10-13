'Imports System.Object.mi

<DataContract()> _
Public Class e_AccidenteFoto
    Implements Ie_AccidenteFoto

#Region "Declaración de variables"

    Private _id As String
    Private _idAccidente As String
    Private _foto As System.Drawing.Image
    Private _fechaFoto As Date
    Private _descripcion As String
    <DataMember()> _
    Public Modificado As Boolean = False
    <DataMember()> _
    Public TipoOperacion As String

    Public Event DatoCambiado()

    'Private convert As Microsoft.
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

#End Region

#Region "Constructores"

    ''' <summary>
    ''' Crear un objeto de tipo Accidente
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()
        _id = String.Empty
    End Sub


    Sub New(ByVal id As String, ByVal idAccidente As String, ByVal foto As System.Byte(), ByVal fechaFoto As Date, ByVal descripcion As String)
        _id = id
        _idAccidente = idAccidente
        Dim ms As New IO.MemoryStream(foto)
        _foto = System.Drawing.Image.FromStream(ms)
        _fechaFoto = fechaFoto
        _descripcion = descripcion
    End Sub

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
    Public Property IdAccidente() As String
        Get
            Return _idAccidente
        End Get
        Set(ByVal value As String)
            _idAccidente = value
        End Set
    End Property

    <DataMember()> _
    Public Property Foto() As System.Drawing.Image
        Get
            Return _foto
        End Get
        Set(ByVal value As System.Drawing.Image)
            _foto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaFoto() As Date
        Get
            Return _fechaFoto
        End Get
        Set(ByVal value As Date)
            _fechaFoto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal accidenteFoto As e_AccidenteFoto) As e_AccidenteFoto Implements Ie_AccidenteFoto.Obtener
        Return accidenteFoto
    End Function

#End Region


End Class
