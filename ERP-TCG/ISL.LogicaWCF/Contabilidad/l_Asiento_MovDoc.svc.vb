Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Asiento_MovDoc
    Implements Il_Asiento_MovDoc

    Dim odAsiento_MovDoc As New d_Asiento_MovDoc

    Public Function Eliminar(ByVal oeAsiento_MovDoc As e_Asiento_MovDoc) As Boolean Implements Il_Asiento_MovDoc.Eliminar
        Try
            Return odAsiento_MovDoc.Eliminar(oeAsiento_MovDoc)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAsiento_MovDoc As e_Asiento_MovDoc) As Boolean Implements Il_Asiento_MovDoc.Guardar
        Try
            Return odAsiento_MovDoc.Guardar(oeAsiento_MovDoc)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAsiento_MovDoc As e_Asiento_MovDoc) As System.Collections.Generic.List(Of e_Asiento_MovDoc) Implements Il_Asiento_MovDoc.Listar
        Try
            Return odAsiento_MovDoc.Listar(oeAsiento_MovDoc)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeAsiento_MovDoc As e_Asiento_MovDoc) As e_Asiento_MovDoc Implements Il_Asiento_MovDoc.Obtener
        Try
            Return odAsiento_MovDoc.Obtener(oeAsiento_MovDoc)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CrearDT() As System.Data.DataTable Implements Il_Asiento_MovDoc.CrearDT
        Dim AsientoMovimientoDocumento As New Data.DataTable
        With AsientoMovimientoDocumento
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdAsiento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdMovimientoDocumento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
        End With
        Return AsientoMovimientoDocumento
    End Function

End Class
