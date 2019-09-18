


<DataContract()> _
Public Class e_Banco
    Implements Ie_Banco
    Implements ICloneable

#Region "Declaración de variables"

    Private _Id As String
    Private _Codigo As String
    Private _Nombre As String
    Private _Abreviatura As String
    Private _Activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean = False
    <DataMember()>
    Public PrefijoID As String = ""
    Public Event DatoCambiado()

#End Region

#Region "Constructores"

    ''' <summary>
    ''' Crear un objeto de tipo Banco
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()
        _Id = String.Empty
        _Activo = True
    End Sub

    ''' <summary>
    ''' Crear un objeto de tipo Banco a partir de sus datos básicos
    ''' </summary>
    ''' <param name="Id">Id del Banco</param>
    ''' <param name="Codigo">Código SUNAT del Banco</param>
    ''' <param name="Nombre">Nombre del Banco</param>
    ''' <param name="Abreviatura">Abreviatura o siglas del Banco</param>
    ''' <param name="Activo">Indicador que precisa si el Banco se utiliza o no en el sistema</param>
    ''' <remarks></remarks>
    Sub New(ByVal Id As String, ByVal Codigo As String, ByVal Nombre As String, ByVal Abreviatura As String, ByVal Activo As Integer)
        _Id = Id
        _Codigo = Codigo
        _Nombre = Nombre
        _Abreviatura = Abreviatura
        _Activo = Activo
    End Sub

#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Propiedad para almacenar el Id del Banco
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad para almacenar el código SUNAT del banco
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    ''' <summary>
    ''' Propiedad para almacenar el nombre del Banco
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    ''' <summary>
    ''' Propiedad para almacenar la abreviatura o siglas del Banco
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' Indicador que precisa si el Banco se utiliza o no en el sistema
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Métodos"

    Public Function Clone() As Object Implements System.ICloneable.Clone
        Return MyBase.MemberwiseClone()
    End Function

    Public Function Obtener(ByVal banco As e_Banco) As e_Banco Implements Ie_Banco.Obtener
        Return banco
    End Function

#End Region

End Class

