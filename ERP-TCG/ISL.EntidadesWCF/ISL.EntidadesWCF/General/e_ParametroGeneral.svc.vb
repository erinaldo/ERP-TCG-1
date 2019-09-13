

<DataContract()> _
Public Class e_ParametroGeneral
    Implements Ie_ParametroGeneral

#Region "Propiedad"

    Private _id As String
    Private _nombre As String
    Private _texto As String
    Private _numero As Double

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    Public Event DatoCambiado()

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
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Texto() As String
        Get
            Return _texto
        End Get
        Set(ByVal value As String)
            _texto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Numero() As Double
        Get
            Return _numero
        End Get
        Set(ByVal value As Double)
            _numero = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()

    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_Texto As String _
              , ByVal ln_Numero As Double _
           )
        _id = ls_Id
        _nombre = ls_Nombre
        _texto = ls_Texto
        _numero = ln_Numero
    End Sub

#End Region

    Public Function Obtener(ByVal parametroGeneral As e_ParametroGeneral) As e_ParametroGeneral Implements Ie_ParametroGeneral.Obtener
        Return parametroGeneral
    End Function

End Class


