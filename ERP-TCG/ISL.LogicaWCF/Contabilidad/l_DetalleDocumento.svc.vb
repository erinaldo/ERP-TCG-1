Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_DetalleDocumento
    Implements Il_DetalleDocumento

    Dim odDetalleDocumento As New d_DetalleDocumento

    Public Function CrearDT() As System.Data.DataTable Implements Il_DetalleDocumento.CrearDT
        Dim DetalleDoc As New Data.DataTable
        With DetalleDoc
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdMovimientoDocumento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IndServicioMaterial", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdMaterialServicio", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Cantidad", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("PrecioUnitario", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("IndGravado", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("Valor", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Igv", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("IdOperacionDetalle", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdVehiculo", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("IdUnidadMedida", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FactorRefUni", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("IdViaje", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Consolidado", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("IndConsolidado", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("GlosaConsolidado", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Monto_Anticipo", Type.GetType("System.Decimal")))
        End With
        Return DetalleDoc
    End Function

    Public Function Eliminar(ByVal oeDetalleDocumento As e_DetalleDocumento) As Boolean Implements Il_DetalleDocumento.Eliminar
        Try
            Return odDetalleDocumento.Eliminar(oeDetalleDocumento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleDocumento As e_DetalleDocumento) As Boolean Implements Il_DetalleDocumento.Guardar
        Try
            If Validar(oeDetalleDocumento) Then
                Return odDetalleDocumento.Guardar(oeDetalleDocumento)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleDocumento As e_DetalleDocumento) As System.Collections.Generic.List(Of e_DetalleDocumento) Implements Il_DetalleDocumento.Listar
        Try
            Return odDetalleDocumento.Listar(oeDetalleDocumento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleDocumento As e_DetalleDocumento) As e_DetalleDocumento Implements Il_DetalleDocumento.Obtener
        Try
            Return odDetalleDocumento.Obtener(oeDetalleDocumento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeDetalleDocumento As e_DetalleDocumento) As Boolean Implements Il_DetalleDocumento.Validar
        Try
            With oeDetalleDocumento
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
