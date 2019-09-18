


' NOTA: si cambia aquí el nombre de clase "e_ConceptoIngresos", también debe actualizar la referencia a "e_ConceptoIngresos" tanto en Web.config como en el archivo .svc asociado.
<DataContract()> _
Public Class e_ConceptoIngresos
    Implements Ie_ConceptoIngresos
    Implements IEquatable(Of e_ConceptoIngresos)

#Region "Declaracion de Variable"

    Private _id As String
    Private _nombre As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public IdProcesoNegocio As String
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
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Nombre As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _nombre = ls_Nombre
        _activo = lb_Activo
    End Sub

#End Region

    Public Overloads Function Equals(ByVal oeConceptoIngresos As e_ConceptoIngresos) _
    As Boolean Implements System.IEquatable(Of e_ConceptoIngresos).Equals
        If Me.Id = oeConceptoIngresos.Id Then Return True
        Return False
    End Function

    Public Function Obtener(ByVal conceptoingresos As e_ConceptoIngresos) As e_ConceptoIngresos Implements Ie_ConceptoIngresos.Obtener
        Return conceptoingresos
    End Function
End Class

