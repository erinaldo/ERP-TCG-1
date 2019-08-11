''' <summary>
''' Entidad para almacenar la información de Tipos de documento
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_TipoDocumento
    Implements Ie_TipoDocumento
    Implements IPropiedadesBasicas
    Implements IEquatable(Of e_TipoDocumento)


#Region "Declaración de variables"

    Private _Id As String
    'Private _Codigo As String
    Private _codigo As String
    Private _Nombre As String
    Private _Abreviatura As String
    Private _Activo As Boolean
    <DataMember()> _
    Public IndIGV As Integer

    <DataMember()> _
    Public leDocumentoImpuesto As New List(Of e_DocumentoImpuesto)

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean = False
    <DataMember()> _
    Public Equivale As Integer

    Public Event DatoCambiado()

#End Region

#Region "Constructores"

    Public Sub New()
        _Id = ""
        _codigo = ""
        _Nombre = ""
        _Abreviatura = ""
        TipoOperacion = ""
        _Activo = True
    End Sub

    ''' <summary>
    ''' Creación de una entidad TipoDocumento
    ''' </summary>
    ''' <param name="Id"></param>
    ''' <param name="Codigo">Código SUNAT</param>
    ''' <param name="Nombre"></param>
    ''' <param name="Abreviatura"></param>
    ''' <param name="Activo"></param>
    ''' <param name="lnIndIgv"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Id As String, ByVal Codigo As String, ByVal Nombre As String, _
                   ByVal Abreviatura As String, ByVal Activo As Boolean, ByVal lnIndIgv As Integer)
        _Id = Id
        _codigo = Codigo
        _Abreviatura = Abreviatura
        _Nombre = Nombre
        _Activo = Activo
        IndIGV = lnIndIgv
    End Sub

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Id() As String Implements IPropiedadesBasicas.Id
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    '<DataMember()> _
    'Public Property Codigo() As String
    '    Get
    '        Return _Codigo
    '    End Get
    '    Set(ByVal value As String)
    '        _Codigo = value
    '        RaiseEvent DatoCambiado()
    '    End Set
    'End Property

    ''' <summary>
    ''' Código SUNAT
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Codigo() As String Implements IPropiedadesBasicas.Codigo
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String Implements IPropiedadesBasicas.Nombre
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Abreviatura() As String
        Get
            Return _Abreviatura
        End Get
        Set(ByVal value As String)
            _Abreviatura = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean Implements IPropiedadesBasicas.Activo
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal tipoDocumento As e_TipoDocumento) As e_TipoDocumento Implements Ie_TipoDocumento.Obtener
        Return tipoDocumento
    End Function

    Public Overloads Function Equals(ByVal oeTipDoc As e_TipoDocumento) As Boolean Implements System.IEquatable(Of e_TipoDocumento).Equals
        Select Case oeTipDoc.Equivale
            Case 0 : If Me.Id = oeTipDoc.Id Then Return True
        End Select
        Return False
    End Function

#End Region

End Class


