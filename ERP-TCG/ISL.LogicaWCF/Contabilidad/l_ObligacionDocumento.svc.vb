' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "Il_ObligacionDocumento" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Il_ObligacionDocumento.svc o Il_ObligacionDocumento.svc.vb en el Explorador de soluciones e inicie la depuración.

Imports System.Runtime.Serialization
Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos
<DataContract(), Serializable()> _
Public Class l_ObligacionDocumento
    Implements Il_ObligacionDocumento

    Private od_ObligFin_MovDoc As New d_ObligacionDocumento
    Public Function CrearDT() As System.Data.DataTable Implements Il_ObligacionDocumento.CrearDT

        Dim ObligacionDocumento As New Data.DataTable
        With ObligacionDocumento
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdMovimientoDocumento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdObligacionFinanciera", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("MontoMN", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("MontoME", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("IdCuentaxCyP", Type.GetType("System.String")))
        End With
        Return ObligacionDocumento
    End Function

    Public Function Listar(oe_ObligFin_MovDoc As e_ObligacionDocumento) As List(Of EntidadesWCF.e_ObligacionDocumento) Implements Il_ObligacionDocumento.Listar
        Try
            Return od_ObligFin_MovDoc.Listar(oe_ObligFin_MovDoc)
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
