Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Compra
    Implements Il_Compra

    Dim odCompra As New d_Compra

    Public Function Eliminar(ByVal oeCompra As EntidadesWCF.e_Compra) As Boolean Implements Il_Compra.Eliminar
        Try
            Return odCompra.Eliminar(oeCompra)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCompra As EntidadesWCF.e_Compra) As Boolean Implements Il_Compra.Guardar
        Try
            If Validar(oeCompra) Then
                Return odCompra.Guardar(oeCompra)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCompra As EntidadesWCF.e_Compra) As System.Collections.Generic.List(Of EntidadesWCF.e_Compra) Implements Il_Compra.Listar
        Try
            Return odCompra.Listar(oeCompra)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeCompra As EntidadesWCF.e_Compra) As EntidadesWCF.e_Compra Implements Il_Compra.Obtener
        Try
            Return odCompra.Obtener(oeCompra)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeCompra As EntidadesWCF.e_Compra) As Boolean Implements Il_Compra.Validar
        Try
            With oeCompra
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CrearDT() As Data.DataTable Implements Il_Compra.CrearDT
        Dim Compra As New Data.DataTable
        With Compra
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("AnoEmisionAduana", Type.GetType("System.Int32")))
            .Columns.Add(New Data.DataColumn("Base1", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Igv1", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Base2", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Igv2", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Base3", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Igv3", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Isc", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("OtrosTributos", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("NoGravadas", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("IdMovimientoDocumento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("IdTipoCompra", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdTipoPago", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Percepcion", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Detraccion", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Retencion", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("PercepcionPorc", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("DetraccionPorc", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("RetencionPorc", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("IndTipoOperacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Glosa", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("ImpRenta", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("CobraCajaChica", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("IdMotivoDocumento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("NroRegImprime", Type.GetType("System.String")))
        End With
        Return Compra
    End Function

End Class
