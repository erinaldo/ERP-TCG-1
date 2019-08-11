''' <summary>
''' Entidad creada para suplir una tabla que contenga datos sobre sexo
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Sexo
    Implements Ie_Sexo

#Region "Constructores"

    ''' <summary>
    ''' Crea una nueva entidad de tipo sexo 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

    End Sub

    ''' <summary>
    ''' Creación de un componente de sexo a partir de su Id
    ''' </summary>
    ''' <param name="idSexo">Id de Sexo: 1 = Masculino , 2 = Femenino</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal idSexo As Integer)
        Try
            If ValidaIdSexo(idSexo) Then
                AsignaValor(idSexo)
            Else
                Throw New Exception("El valor de sexo ingresado no es correcto")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Creación de un componente de sexo a partir de su descripción
    ''' </summary>
    ''' <param name="sexo"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal sexo As String)
        Try
            If ValidaNombreSexo(sexo) Then
                AsignaValores(sexo)
            Else
                Throw New Exception("El valor de sexo ingresado no es correcto")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Id del Sexo 1 = Masculino -  2 = Femenino
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
    ''' Definición de Sexo - Masculino o Femenino
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

    ''' <summary>
    ''' Abreviatura del sexo - M = Masculino  - F = Femenino
    ''' </summary>
    ''' <remarks></remarks>
    Private _abreviatura As String
    <DataMember()> _
    Public Property Abreviatura() As String
        Get
            Return _abreviatura
        End Get
        Set(ByVal value As String)
            _abreviatura = value
        End Set
    End Property

#End Region

#Region "Métodos"

    Private Function ValidaNombreSexo(ByVal sexo As String) As Boolean
        Dim nombreSexoValido As Boolean = False
        If sexo = "Masculino" Or sexo = "Femenino" Or sexo = "1" Or sexo = "2" Then
            nombreSexoValido = True
        End If
        Return nombreSexoValido
    End Function

    Private Function ValidaIdSexo(ByVal idSexo As Integer) As Boolean
        Dim IdSexoValido As Boolean = False
        If idSexo = 1 Or idSexo = 2 Then
            IdSexoValido = True
        End If
        Return IdSexoValido
    End Function

    ''' <summary>
    ''' Asigna valores de sexo a partir de su Id
    ''' </summary>
    ''' <param name="idSexo">Id del Sexo</param>
    ''' <remarks></remarks>
    Public Sub AsignaValor(ByVal idSexo As Integer) Implements Ie_Sexo.AsignaValor
        Select Case idSexo
            Case 1
                CreaMasculino()
            Case 2
                CrearFemenino()
        End Select
    End Sub

    ''' <summary>
    ''' Asigna valores de sexo a partir de una descripción
    ''' </summary>
    ''' <param name="sexo"></param>
    ''' <remarks></remarks>
    Public Sub AsignaValores(ByVal sexo As String) Implements Ie_Sexo.AsignaValores
        Try
            Select Case sexo.Substring(0, 1)
                Case "M"
                    CreaMasculino()
                Case "F"
                    CrearFemenino()
                Case "1"
                    CreaMasculino()
                Case "2"
                    CrearFemenino()
                Case Else
                    Throw New Exception("Sexo incorrecto")
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Crea un hombre
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CreaMasculino()
        _id = "1"
        _nombre = "Masculino"
        _abreviatura = "M"
    End Sub

    ''' <summary>
    ''' Crea una mujer
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CrearFemenino()
        _id = "2"
        _nombre = "Femenino"
        _abreviatura = "F"
    End Sub

    Public Function Obtener(ByVal sexo As e_Sexo) As e_Sexo Implements Ie_Sexo.Obtener
        Return sexo
    End Function

#End Region

End Class


