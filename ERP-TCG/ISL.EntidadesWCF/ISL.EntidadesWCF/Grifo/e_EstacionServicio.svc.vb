Imports ERP.EntidadesWCF

<DataContract()>
Public Class e_EstacionServicio
    Implements Ie_EstacionServicio
    Implements IEquatable(Of e_EstacionServicio)

#Region "Declaracion de Variables"

    <DataMember()>
    Public TipoOperacion As String
    <DataMember()>
    Public PrefijoID As String

#End Region

#Region "Propiedades"

    <DataMember()>
    Property Id As Integer = -1
    <DataMember()>
    Property IdEmpresaSis As String = ""
    <DataMember()>
    Property IdSucursal As String = ""
    <DataMember()>
    Property Nombre As String = ""
    <DataMember()>
    Property Estado As Integer = -1
    <DataMember()>
    Property Usuario As String = ""
    <DataMember()>
    Property Activo As Integer = -1

#End Region

#Region "Metodos"

    Public Function Obtener(estacionservicio As e_EstacionServicio) As e_EstacionServicio Implements Ie_EstacionServicio.Obtener
        Return estacionservicio
    End Function

    Public Overloads Function Equals(other As e_EstacionServicio) As Boolean Implements IEquatable(Of e_EstacionServicio).Equals
        If Me.Id = other.Id Then Return True
        Return False
    End Function


#End Region



End Class
