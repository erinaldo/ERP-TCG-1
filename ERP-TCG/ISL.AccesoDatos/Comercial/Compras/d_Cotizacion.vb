Imports ISL.EntidadesWCF
Imports System.Transactions

''' <summary>
''' Clase que controla los metodos de accesos la tabla cotizacion.  
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Las cotizaciones se realizan a los diferentes proveedores,Capa del Sistema:Capa de Acceso a Datos</remarks>
Public Class d_Cotizacion

    Private oeCotizacion As e_Cotizacion
    Private sqlhelper As New SqlHelper
    Dim odCotizacionDetalle As New d_CotizacionDetalleMat
    Dim odCotizacionDetalleSer As New d_CotizacionDetalleSer
    Dim odCotizacionProveedor As New d_Cotizacion_Proveedor

    Private Function Cargar(ByVal o_fila As DataRow) As e_Cotizacion
        Try
            Dim oeCotizacion = New e_Cotizacion(o_fila("Id") _
                           , o_fila("Codigo") _
                           , o_fila("Glosa") _
                           , o_fila("Activo") _
                           , o_fila("UsuarioCreacion") _
                           , o_fila("FechaCreacion") _
                           , o_fila("Moneda") _
                           , o_fila("IdMoneda") _
                           , o_fila("IndMaterialServicio") _
                           , o_fila("IdEstado") _
                           , o_fila("Estado") _
                           , o_fila("IdProveedor") _
                           , o_fila("Proveedor") _
                           , o_fila("IdEquipo") _
                           , o_fila("Equipo") _
                           , o_fila("Importe"))
            Return oeCotizacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCotizacion As e_Cotizacion) As e_Cotizacion
        Try
            Dim ds As DataSet
            With oeCotizacion
                ds = sqlhelper.ExecuteDataset("CMP.Isp_Cotizacion_Listar", .TipoOperacion _
                                                                        , .Id)
            End With
            If ds.Tables.Count > 0 Then
                oeCotizacion = Cargar(ds.Tables(0).Rows(0))                
            End If
            Return oeCotizacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCotizacion As e_Cotizacion) As List(Of e_Cotizacion)
        Try
            Dim ldTipoMantenimiento As New List(Of e_Cotizacion)
            Dim ds As DataSet
            With oeCotizacion
                ds = sqlhelper.ExecuteDataset("CMP.ISP_Cotizacion_Listar", .TipoOperacion _
                                                                         , .Id _
                                                                         , .IndMaterialServicio _
                                                                         , .FechaInicio _
                                                                         , .FechaFinal)
            End With            
            oeCotizacion = Nothing
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCotizacion = Cargar(o_Fila)
                    ldTipoMantenimiento.Add(oeCotizacion)
                Next                
            End If
            Return ldTipoMantenimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDataSet(ByVal desde As Date, ByVal hasta As Date, ByVal estado As Boolean) As DataSet
        Try
            Dim ds As DataSet = sqlhelper.ExecuteDataset("CMP.ISP_Cotizacion_Listar", "L", String.Empty, String.Empty, _
                        String.Empty, desde, String.Empty, estado, hasta)
            If ds.Tables.Count = 0 Then Throw New Exception("Información no regitrada")
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCotizacion As e_Cotizacion) As Boolean
        Try
            Dim resultado As Boolean = False
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                With oeCotizacion
                    stResultado = sqlhelper.ExecuteScalar("CMP.Isp_Cotizacion_IAE" _
                            , .TipoOperacion _
                            , .PrefijoID _
                            , .Id _
                            , .Codigo _
                            , .Glosa _
                            , .Activo _
                            , .UsuarioCreacion _
                            , .IdMoneda _
                            , .IndMaterialServicio _
                            , .IdEstado _
                            , .IdProveedor _
                            , .IdEquipo _
                            , .Importe).ToString.Split()
                    For Each Detalle As e_Cotizacion_Proveedor In .lstCotizacionProveedor
                        Detalle.IdCotizacion = stResultado(0) : Detalle.Tipooperacion = .TipoOperacion
                        odCotizacionProveedor.Guardar(Detalle)
                    Next
                    resultado = True
                End With
                transScope.Complete()
            End Using
            Return resultado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeCotizacion As e_Cotizacion) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CMP.Isp_Cotizacion_IAE", "E", "", oeCotizacion.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class