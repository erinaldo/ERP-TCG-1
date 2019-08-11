Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_AsientoMovimiento
    Implements Il_AsientoMovimiento

    Dim odAsientoMovimiento As New d_AsientoMovimiento

    Public Function CrearDT() As System.Data.DataTable Implements Il_AsientoMovimiento.CrearDT
        Dim AsientoMovimiento As New Data.DataTable
        With AsientoMovimiento
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdAsiento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdCuentaContable", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Glosa", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("DebeMN", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("HaberMN", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("DebeME", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("HaberME", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("IdUsuarioCrea", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("NroLinea", Type.GetType("System.Decimal")))
            '.Columns.Add(New Data.DataColumn("CodigoUnicoOperacion", Type.GetType("System.String")))
        End With
        Return AsientoMovimiento
    End Function

    Public Function Eliminar(ByVal oeAsientoMovimiento As EntidadesWCF.e_AsientoMovimiento) As Boolean Implements Il_AsientoMovimiento.Eliminar
        Try
            Return odAsientoMovimiento.Eliminar(oeAsientoMovimiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAsientoMovimiento As EntidadesWCF.e_AsientoMovimiento) As Boolean Implements Il_AsientoMovimiento.Guardar
        Try
            If Validar(oeAsientoMovimiento) Then
                Return odAsientoMovimiento.Guardar(oeAsientoMovimiento)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAsientoMovimiento As EntidadesWCF.e_AsientoMovimiento) As System.Collections.Generic.List(Of EntidadesWCF.e_AsientoMovimiento) Implements Il_AsientoMovimiento.Listar
        Try
            Return odAsientoMovimiento.Listar(oeAsientoMovimiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeAsientoMovimiento As EntidadesWCF.e_AsientoMovimiento) As EntidadesWCF.e_AsientoMovimiento Implements Il_AsientoMovimiento.Obtener
        Try
            Return odAsientoMovimiento.Obtener(oeAsientoMovimiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener2(ByVal oeAsientoMovimiento As EntidadesWCF.e_AsientoMovimiento) As EntidadesWCF.e_AsientoMovimiento Implements Il_AsientoMovimiento.Obtener2
        Try
            Return odAsientoMovimiento.Obtener2(oeAsientoMovimiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeAsientoMovimiento As EntidadesWCF.e_AsientoMovimiento) As Boolean Implements Il_AsientoMovimiento.Validar
        Try
            With oeAsientoMovimiento
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
