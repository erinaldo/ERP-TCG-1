

''' <summary>
''' Entidad para trabajar con la tabla de ubicaciones geográficas (UBIGEO) estandar
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Ubigeo
    Implements Ie_Ubigeo

#Region "Propiedades"

    ''' <summary>
    ''' Id de la ubicación geográfica (ubigeo)
    ''' </summary>
    ''' <remarks></remarks>
    Private _id As String
    <DataMember()> _
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    ''' <summary>
    ''' Nombre del lugar
    ''' </summary>
    ''' <remarks></remarks>
    Private _nombre As String
    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal ubigeo As e_Ubigeo) As e_Ubigeo Implements Ie_Ubigeo.Obtener
        Return ubigeo
    End Function

#End Region

End Class


