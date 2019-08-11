Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_HistorialInventario
    Implements Il_HistorialInventario

    Dim odHistorialInventario As New d_HistorialInventario

    Public Function Eliminar(ByVal oeHistorialInventario As EntidadesWCF.e_HistorialInventario) As Boolean Implements Il_HistorialInventario.Eliminar
        Try
            Return odHistorialInventario.Eliminar(oeHistorialInventario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeHistorialInventario As EntidadesWCF.e_HistorialInventario) As Boolean Implements Il_HistorialInventario.Guardar
        Try
            If Validar(oeHistorialInventario) Then
                Return odHistorialInventario.Guardar(oeHistorialInventario)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeHistorialInventario As EntidadesWCF.e_HistorialInventario) As System.Collections.Generic.List(Of EntidadesWCF.e_HistorialInventario) Implements Il_HistorialInventario.Listar
        Try
            Return odHistorialInventario.Listar(oeHistorialInventario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar_Inventario(ByVal oeInventario As EntidadesWCF.e_Inventario) As System.Collections.Generic.List(Of EntidadesWCF.e_HistorialInventario) Implements Il_HistorialInventario.Listar_Inventario
        Try
            Return odHistorialInventario.Listar_Inventario(oeInventario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeHistorialInventario As EntidadesWCF.e_HistorialInventario) As EntidadesWCF.e_HistorialInventario Implements Il_HistorialInventario.Obtener
        Try
            Return odHistorialInventario.Obtener(oeHistorialInventario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeHistorialInventario As EntidadesWCF.e_HistorialInventario) As Boolean Implements Il_HistorialInventario.Validar
        Try
            With oeHistorialInventario
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CrearDT() As DataTable Implements Il_HistorialInventario.CrearDT
        Dim HistorialInventario As New Data.DataTable
        With HistorialInventario
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdHistorial", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdMaterial", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdUnidadMedida", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("CantidadFinal", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("ValorUnitario", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("ValorTotal", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Fecha", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
        End With
        Return HistorialInventario
    End Function

End Class
