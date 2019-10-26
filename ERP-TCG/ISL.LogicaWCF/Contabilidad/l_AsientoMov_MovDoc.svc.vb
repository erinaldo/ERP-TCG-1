Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_AsientoMov_MovDoc
    Implements Il_AsientoMov_MovDoc

    Public Function CrearDT() As System.Data.DataTable Implements Il_AsientoMov_MovDoc.CrearDT
        Dim Analisis As New Data.DataTable
        With Analisis
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdMovimientoDocumento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdAsientoMovimiento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdCuentaxCyP", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
        End With
        Return Analisis
    End Function


    Dim odAsientoMov_MovDoc As New d_AsientoMov_MovDoc

    Public Function Eliminar(ByVal oeAsientoMov_MovDoc As e_AsientoMov_MovDoc) As Boolean Implements Il_AsientoMov_MovDoc.Eliminar
        Try
            Return odAsientoMov_MovDoc.Eliminar(oeAsientoMov_MovDoc)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAsientoMov_MovDoc As e_AsientoMov_MovDoc) As Boolean Implements Il_AsientoMov_MovDoc.Guardar
        Try
            If Validar(oeAsientoMov_MovDoc) Then
                Return odAsientoMov_MovDoc.Guardar(oeAsientoMov_MovDoc)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAsientoMov_MovDoc As e_AsientoMov_MovDoc) As System.Collections.Generic.List(Of e_AsientoMov_MovDoc) Implements Il_AsientoMov_MovDoc.Listar
        Try
            Return odAsientoMov_MovDoc.Listar(oeAsientoMov_MovDoc)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeAsientoMov_MovDoc As e_AsientoMov_MovDoc) As e_AsientoMov_MovDoc Implements Il_AsientoMov_MovDoc.Obtener
        Try
            Return odAsientoMov_MovDoc.Obtener(oeAsientoMov_MovDoc)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeAsientoMov_MovDoc As e_AsientoMov_MovDoc) As Boolean Implements Il_AsientoMov_MovDoc.Validar
        Try
            With oeAsientoMov_MovDoc
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
