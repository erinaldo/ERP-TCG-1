'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_DetalleDocumento
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_DetalleDocumento
        Try
            Dim oe = New e_DetalleDocumento( _
                             o_fila("Id").ToString _
                             , o_fila("IdMovimientoDocumento").ToString _
                             , o_fila("IndServicioMaterial").ToString _
                             , o_fila("IdMaterialServicio").ToString _
                             , o_fila("Cantidad").ToString _
                             , o_fila("PrecioUnitario").ToString _
                             , o_fila("Total").ToString _
                             , o_fila("IndGravado").ToString _
                             , o_fila("Igv").ToString _
                             , o_fila("Valor").ToString _
                             , o_fila("IdOperacionDetalle").ToString _
                             , o_fila("IdVehiculo").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("IdUnidadMedida").ToString _
                             , o_fila("UnidadMedida").ToString _
                             , o_fila("IdTipoUnidadMedida").ToString _
                             , o_fila("IdMaterialServicio").ToString _
                             , o_fila("MaterialServicio").ToString _
                             , o_fila("CodigoMaterialServicio").ToString _
                             , o_fila("Porcentaje").ToString _
                             , o_fila("IdCuentaContableCompra").ToString _
                             , o_fila("IdTipoCompra").ToString _
                             , o_fila("IdCuentaContableDebe").ToString _
                             , o_fila("IdCuentaContableHaber").ToString _
                             , o_fila("IdItemGasto").ToString _
                             , o_fila("FactorRefUni") _
                             , o_fila("SubAlm").ToString _
                             , o_fila("IndPropiedad") _
                             , o_fila("IdCuentaContableActivo").ToString _
                             , o_fila("IdAlmacen").ToString _
            )
            oe.Monto_Anticipo = o_fila("Monto_Anticipo").ToString
            Return oe
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Obtener(ByVal oe As e_DetalleDocumento) As e_DetalleDocumento
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_DetalleDocumento_Listar" _
                                          , oe.TipoOperacion _
                                          , oe.Id _
                                          , oe.IdMovimientoDocumento _
                                          )
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

    Public Function Listar(ByVal oe As e_DetalleDocumento) As List(Of e_DetalleDocumento)
        Try
            Dim cont As Integer = 0
            Dim ld As New List(Of e_DetalleDocumento)
            Dim ds As DataSet
            With oe
                ds = sqlhelper.ExecuteDataset("CON.Isp_DetalleDocumento_Listar", .TipoOperacion _
                        , .Id _
                        , .IdMovimientoDocumento _
                        , .IndServicioMaterial _
                        , .IdMaterialServicio _
                        , .IndGravado _
                        , .IdOperacionDetalle _
                        , .IdVehiculo _
                        , .Activo _
                        , .UsuarioCreacion _
                        )
            End With
            oe = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oe = Cargar(o_Fila)
                    cont += 1 : oe.Pos = cont
                    ld.Add(oe)
                Next
            End If
            Return ld
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleDocumento As e_DetalleDocumento) As Boolean
        Try
            Dim idDetalle As String = ""
            With oeDetalleDocumento
                idDetalle = sqlhelper.ExecuteScalar("CON.Isp_DetalleDocumento_IAE", .TipoOperacion _
                    , .PrefijoID _
                    , .Id, .IdMovimientoDocumento, .IndServicioMaterial, .IdMaterialServicio, .IdUnidadMedida _
                    , .Cantidad, .Precio, .IndGravado, .Igv, .Subtotal, .IdOperacionDetalle, .IdVehiculo _
                    , .Activo, .UsuarioCreacion, .FechaCreacion, .FactorRefUni, .IdViaje, .IdRegistroConsCombustible _
                    , .IdGastoOperacion, .Monto_Anticipo)
                .Id = idDetalle
            End With
            Return True

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EjecutarMasivo(ByVal NombreTabla As String, ByVal dt As Data.DataTable) As Integer
        Dim s_Trans As SqlTransaction
        Dim cn As SqlConnection = New SqlConnection(sqlhelper.connectionString)
        cn.Open()
        s_Trans = cn.BeginTransaction
        Try
            Using copy As New SqlBulkCopy(cn)
                copy.BatchSize = 500
                copy.DestinationTableName = NombreTabla
                copy.WriteToServer(dt)
                copy.Close()
            End Using
            s_Trans.Commit()
            cn.Close()
            Return 1
        Catch ex As Exception
            s_Trans.Rollback()
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            Return -1
        End Try
    End Function
    Public Function Eliminar(ByVal oe As e_DetalleDocumento) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_DetalleDocumento_IAE", "E", _
             "", oe.Id, oe.IdMovimientoDocumento)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
    ''' <summary>
    ''' Trae Ultimo id de la tabla CON.MovimientoAnalisis para casos de insercion masiva
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "CON.DetalleDocumento", PrefijoID
                                  )
            Return stResultado
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarMasivo(ByVal dtDetalleDoc As DataTable) As Boolean
        Try
            sqlhelper.InsertarMasivo("CON.DetalleDocumento", dtDetalleDoc)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
