Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF

Public Class l_DetalleLibroElectronico
    Implements Il_DetalleLibroElectronico

    Dim odDetalleLibroElectronico As New d_DetalleLibroElectronico

    Public Function Eliminar(ByVal oeDetalleLibroElectronico As e_DetalleLibroElectronico) As Boolean Implements Il_DetalleLibroElectronico.Eliminar
        Try
            Return odDetalleLibroElectronico.Eliminar(oeDetalleLibroElectronico)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleLibroElectronico As e_DetalleLibroElectronico) As Boolean Implements Il_DetalleLibroElectronico.Guardar
        Try
            Return odDetalleLibroElectronico.Guardar(oeDetalleLibroElectronico)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarMasivo(ByVal NombreTabla As String, ByVal Dt As System.Data.DataTable) As Boolean Implements Il_DetalleLibroElectronico.GuardarMasivo
        Try
            Return odDetalleLibroElectronico.GuardarMasivo(Dt)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleLibroElectronico As e_DetalleLibroElectronico) As System.Collections.Generic.List(Of e_DetalleLibroElectronico) Implements Il_DetalleLibroElectronico.Listar
        Try
            Return odDetalleLibroElectronico.Listar(oeDetalleLibroElectronico)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleLibroElectronico As e_DetalleLibroElectronico) As e_DetalleLibroElectronico Implements Il_DetalleLibroElectronico.Obtener
        Try
            Return odDetalleLibroElectronico.Obtener(oeDetalleLibroElectronico)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeDetalleLibroElectronico As e_DetalleLibroElectronico) As Boolean Implements Il_DetalleLibroElectronico.Validar
        Try

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CrearDT() As System.Data.DataTable Implements Il_DetalleLibroElectronico.CrearDT
        Dim DetalleLE As New Data.DataTable
        With DetalleLE
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdLibroElectronico", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdMovimientoDocumento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Periodo", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("CodigoUnicoOperacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("NumeroCorrelativo", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaEmision", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("FechaVencimiento", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("TipoDocumento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("SerieDoc", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("AnioEmisionDUA", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("NumeroDoc", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("NumeroDoc2", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("TipoDocIdentidad", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("NumeroDocIdentidad", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Denominacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("SubTotal1", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("IGV1", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("SubTotal2", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("IGV2", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("SubTotal3", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("IGV3", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("NoGravada", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("ISC", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("OtrosTributos", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Total", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("TipoCambio", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("FechaEmisionAso", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("TipoDocumentoAso", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("SerieAso", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("NumeroDocAso", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("NumeroDocAso2", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaEmisionDetraccion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("NroConstanciaDetraccion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("CodigoDuaDsi", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("ValorFob", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("NroCorrelativoVenta", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("NroCorrelativoCompra", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("NroCorrelativoConsignacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Retencion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Indicador", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
        End With
        Return DetalleLE
    End Function

End Class
