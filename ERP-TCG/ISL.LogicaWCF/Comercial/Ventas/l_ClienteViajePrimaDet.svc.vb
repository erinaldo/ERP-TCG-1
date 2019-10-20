Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_ClienteViajePrimaDet" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_ClienteViajePrimaDet.svc o l_ClienteViajePrimaDet.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_ClienteViajePrimaDet
    Implements Il_ClienteViajePrimaDet

    Dim odClienteViajePrimaDet As New d_ClienteViajePrimaDet

    Public Function Eliminar(oeClienteViajePrimaDet As e_ClienteViajePrimaDet) As Boolean Implements Il_ClienteViajePrimaDet.Eliminar
        Try
            Return odClienteViajePrimaDet.Eliminar(oeClienteViajePrimaDet)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeClienteViajePrimaDet As e_ClienteViajePrimaDet) As Boolean Implements Il_ClienteViajePrimaDet.Guardar
        Try
            Return odClienteViajePrimaDet.Guardar(oeClienteViajePrimaDet)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeClienteViajePrimaDet As e_ClienteViajePrimaDet) As List(Of e_ClienteViajePrimaDet) Implements Il_ClienteViajePrimaDet.Listar
        Try
            Return odClienteViajePrimaDet.Listar(oeClienteViajePrimaDet)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oeClienteViajePrimaDet As e_ClienteViajePrimaDet) As e_ClienteViajePrimaDet Implements Il_ClienteViajePrimaDet.Obtener
        Try
            Return odClienteViajePrimaDet.Obtener(oeClienteViajePrimaDet)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CrearDT() As System.Data.DataTable Implements Il_ClienteViajePrimaDet.CrearDT
        Dim oeClienteViajePrimaDet As New Data.DataTable
        With oeClienteViajePrimaDet
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdClienteViajePrima", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdViaje", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdOperacionDetalle", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdCliente", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdOrigen", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdDestino", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdMaterial", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IndAsegurado", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
        End With
        Return oeClienteViajePrimaDet
    End Function

End Class