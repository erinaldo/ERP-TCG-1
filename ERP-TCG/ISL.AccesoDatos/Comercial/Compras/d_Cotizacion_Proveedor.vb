Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient


Public Class d_Cotizacion_Proveedor

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Cotizacion_Proveedor
        Try
            Dim oe = New e_Cotizacion_Proveedor(o_fila("Seleccion").ToString _
                             , o_fila("Id").ToString _
                             , o_fila("IdCotizacion").ToString _
                             , o_fila("IdProveedor").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("Proveedor").ToString _
                             , o_fila("Email").ToString _
                             , o_fila("Contacto").ToString _
                             , o_fila("CodigoProveedor").ToString _
                             , o_fila("IndAprobado").ToString)
            Return oe
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oe As e_Cotizacion_Proveedor) As e_Cotizacion_Proveedor

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CMP.Isp_Cotizacion_Proveedor_Listar", "", oe.Id, oe.IdCotizacion, "", oe.IndAprobado)
            If ds.Tables.Count > 0 Then
                oe = Cargar(ds.Tables(0).Rows(0))
                Return oe
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oe As e_Cotizacion_Proveedor) As List(Of e_Cotizacion_Proveedor)
        Try
            Dim ld As New List(Of e_Cotizacion_Proveedor)
            Dim ds As DataSet
            With oe
                ds = sqlhelper.ExecuteDataset("CMP.Isp_Cotizacion_Proveedor_Listar", .Tipooperacion _
                        , .Id _
                        , .IdCotizacion _
                        , .IdProveedor _
                        , .IndAprobado)
            End With
            oe = Nothing
            If ds.Tables.Count = 0 Then Throw New Exception("Información no regitrada")
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oe = Cargar(o_Fila)
                ld.Add(oe)
            Next
            Return ld
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oe As e_Cotizacion_Proveedor) As Boolean
        Try
            Dim odCotizacionDetalleMar As New d_CotizacionDetalleMat
            Dim odCotizacionDetalleSer As New d_CotizacionDetalleSer
            Dim stResultado() As String
            With oe
                stResultado = sqlhelper.ExecuteScalar("CMP.Isp_Cotizacion_Proveedor_IAE", .Tipooperacion, .PrefijoID,
                        .Id _
                        , .IdCotizacion _
                        , .IdProveedor _
                        , .IndAprobado _
                        , .Activo _
                        , .UsuarioCreacion
                    ).ToString.Split()

                For Each Detalle As e_CotizacionDetalleMat In .lstCotizacionDetalleMat
                    Detalle.IdCotizacionProveedor = stResultado(0) : Detalle.TipoOperacion = .Tipooperacion
                    odCotizacionDetalleMar.Guardar(Detalle)
                Next

                For Each detalleser As e_CotizacionDetalleSer In .lstCotizacionDetalleSer
                    detalleser.IdCotizacionProveedor = stResultado(0)
                    If detalleser.TipoOperacion = "" Then detalleser.TipoOperacion = .Tipooperacion
                    odCotizacionDetalleSer.Guardar(detalleser)
                Next
            End With
            Return True
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

    Public Function Eliminar(ByVal oe As e_Cotizacion_Proveedor) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CMP.Isp_Cotizacion_Proveedor_IAE", "E", _
             "", oe.Id)
            Return True
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

End Class
