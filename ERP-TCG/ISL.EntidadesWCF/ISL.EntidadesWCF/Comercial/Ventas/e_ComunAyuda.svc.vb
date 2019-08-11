

' NOTA: si cambia aquí el nombre de clase "ComunAyuda", también debe actualizar la referencia a "ComunAyuda" tanto en Web.config como en el archivo .svc asociado.
<DataContract()> _
Public Class e_ComunAyuda
    Implements Ie_ComunAyuda

    Private _id As String
    Private _nombre As String

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

    Public Sub New()

    End Sub

    Public Sub New(ByVal l_id As String, _
                   ByVal l_nombre As String)
        _id = l_id
        _nombre = l_nombre
    End Sub

    Public Function Obtener(ByVal ComunAyuda As e_ComunAyuda) As e_ComunAyuda Implements Ie_ComunAyuda.Obtener
        Return ComunAyuda
    End Function

    Public Sub DoWork() Implements Ie_ComunAyuda.DoWork
    End Sub

End Class


