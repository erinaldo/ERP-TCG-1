
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_FecLetras
    Implements Il_FecLetras

    Public Function CrearDT() As System.Data.DataTable Implements Il_FecLetras.CrearDT
        Dim FecLetras As New Data.DataTable
        With FecLetras
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdObligacionFinanciera", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IndClienteProveedor", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdClienteProveedor", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("NroLetra", Type.GetType("System.String")))
        End With
        Return FecLetras
    End Function

End Class
