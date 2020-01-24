
'=====================================================================================================
'=== CAPA : ACCESO A DATOS ===========================================================================
'=====================================================================================================
Imports ERP.EntidadesWCF
Public Class d_DetalleDocumento_css
    Private SQL As New SqlHelper
    Private DS As New DataSet
    Public Function Obtener(ByVal Item As e_DetalleDocumento_css) As e_DetalleDocumento_css
        Try
            Dim ds As DataSet = ExecuteLST(Item)
            If ds.Tables(0).Rows.Count > 0 Then
                Item = Cargar(ds.Tables(0).Rows(0))
            End If
            Return Item
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal item As e_DetalleDocumento_css) As List(Of e_DetalleDocumento_css)
        Try
            Dim ldDetalleDocumento_css As New List(Of e_DetalleDocumento_css)
            Dim ds As DataSet = ExecuteLST(item)
            item = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    item = Cargar(o_Fila)
                    ldDetalleDocumento_css.Add(item)
                Next
            End If
            Return ldDetalleDocumento_css
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal Item As e_DetalleDocumento_css) As e_DetalleDocumento_css
        Try
            'Using transScope As New TransactionScope()
            Dim stResultado() As String
            With Item
                stResultado = SQL.ExecuteScalar("[CON].[DetalleDocumento_IAE]" _
                        , .TipoOperacion _
                        , .PrefijoID _
                        , .Id _
                        , .IdMovimientoDocumento _
                        , .IndServicioMaterial _
                        , .IdMaterialServicio _
                        , .Cantidad _
                        , .PrecioUnitario _
                        , .IndGravado _
                        , .Valor _
                        , .Igv _
                        , .IdOperacionDetalle _
                        , .IdVehiculo _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .IdUnidadMedida _
                        , .FactorRefUni _
                        , .IdViaje _
                        , .Consolidado _
                        , .IndConsolidado _
                        , .GlosaConsolidado _
                        , .IdGastoOperacion _
                        , .Monto_Anticipo
                    ).ToString.Split("_")
                .Id = stResultado(0)
            End With
            'transScope.Complete()
            'End Using
            Return Item
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal Item As e_DetalleDocumento_css) As Boolean
        Try
            With Item
                SQL.ExecuteNonQuery("[CON].[DetalleDocumento_IAE]" _
                       , "E" _
                       , "" _
                       , .Id _
                       , .IdMovimientoDocumento _
                       , .IndServicioMaterial _
                       , .IdMaterialServicio _
                       , .Cantidad _
                       , .PrecioUnitario _
                       , .IndGravado _
                       , .Valor _
                       , .Igv _
                       , .IdOperacionDetalle _
                       , .IdVehiculo _
                       , .Activo _
                       , .UsuarioCreacion _
                       , .FechaCreacion _
                       , .IdUnidadMedida _
                       , .FactorRefUni _
                       , .IdViaje _
                       , .Consolidado _
                       , .IndConsolidado _
                       , .GlosaConsolidado _
                       , .IdGastoOperacion _
                       , .Monto_Anticipo
                   )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#Region "Operaciones Basicas"

    Private Function Cargar(ByVal o_fila As DataRow) As e_DetalleDocumento_css
        Try
            Dim Item = New e_DetalleDocumento_css(
                             o_fila("Id").ToString _
                             , o_fila("IdMovimientoDocumento").ToString _
                             , o_fila("IndServicioMaterial").ToString _
                             , o_fila("IdMaterialServicio").ToString _
                             , o_fila("Cantidad").ToString _
                             , o_fila("PrecioUnitario").ToString _
                             , o_fila("IndGravado").ToString _
                             , o_fila("Valor").ToString _
                             , o_fila("Igv").ToString _
                             , o_fila("IdOperacionDetalle").ToString _
                             , o_fila("IdVehiculo").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("IdUnidadMedida").ToString _
                             , o_fila("FactorRefUni").ToString _
                             , o_fila("IdViaje").ToString _
                             , o_fila("Consolidado").ToString _
                             , o_fila("IndConsolidado").ToString _
                             , o_fila("GlosaConsolidado").ToString _
                             , o_fila("IdGastoOperacion").ToString _
                             , o_fila("Monto_Anticipo").ToString
            )
            Return Item
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Function ExecuteLST(ByVal Item As e_DetalleDocumento_css) As DataSet
        Try
            Dim ds As DataSet
            With Item
                ds = SQL.ExecuteDataset("[CON].[DetalleDocumento_LST]" _
                        , .TipoOperacion _
                        , "" _
                        , "" _
                        , .Id _
                        , .IdMovimientoDocumento _
                        , .IndServicioMaterial _
                        , .IdMaterialServicio _
                        , .Cantidad _
                        , .PrecioUnitario _
                        , .IndGravado _
                        , .Valor _
                        , .Igv _
                        , .IdOperacionDetalle _
                        , .IdVehiculo _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .IdUnidadMedida _
                        , .FactorRefUni _
                        , .IdViaje _
                        , .Consolidado _
                        , .IndConsolidado _
                        , .GlosaConsolidado _
                        , .IdGastoOperacion _
                        , .Monto_Anticipo
                        )
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

End Class
