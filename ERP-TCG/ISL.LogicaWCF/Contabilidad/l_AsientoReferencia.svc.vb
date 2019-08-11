Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos

Public Class l_AsientoReferencia
    Implements Il_AsientoReferencia

    Private odAsientoReferencia As d_AsientoReferencia

    Public Function Obtener(oeAsientoReferencia As e_AsientoReferencia) As e_AsientoReferencia Implements Il_AsientoReferencia.Obtener
        Try
            odAsientoReferencia = New d_AsientoReferencia
            Return odAsientoReferencia.Obtener(oeAsientoReferencia)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeAsientoReferencia As e_AsientoReferencia) As List(Of e_AsientoReferencia) Implements Il_AsientoReferencia.Listar
        Try
            odAsientoReferencia = New d_AsientoReferencia
            Return odAsientoReferencia.Listar(oeAsientoReferencia)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oeAsientoReferencia As e_AsientoReferencia) As Boolean Implements Il_AsientoReferencia.Guardar
        Try
            odAsientoReferencia = New d_AsientoReferencia
            Dim bol_guardado As Boolean = False
            bol_guardado = odAsientoReferencia.Guardar(oeAsientoReferencia)
            Return bol_guardado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(oeAsientoReferencia As e_AsientoReferencia) As Boolean Implements Il_AsientoReferencia.Eliminar
        Try
            odAsientoReferencia = New d_AsientoReferencia
            Return odAsientoReferencia.Eliminar(oeAsientoReferencia)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CrearDT() As System.Data.DataTable Implements Il_AsientoReferencia.CrearDT
        Dim Referencia As New Data.DataTable
        With Referencia
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdAsiento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdReferencia", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("TipoReferencia", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
        End With
        Return Referencia
    End Function

End Class
