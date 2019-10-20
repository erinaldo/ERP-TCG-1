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

Public Class d_DetalleDocumentoVehiculo
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_DetalleDocumentoVehiculo
        Try
            Dim oeDetalleDocumentoVehiculo = New e_DetalleDocumentoVehiculo( _
                             o_fila("Id").ToString _
                             , o_fila("IdVehiculo").ToString _
                             , o_fila("IdDocumento").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Prima").ToString _
                             , o_fila("Comision").ToString _
                             , o_fila("DerEmision").ToString _
                             , o_fila("Igv").ToString _
                             , o_fila("Total").ToString _
                             , o_fila("Placa").ToString _
                             , o_fila("EmpresaPropietaria").ToString _
                             , o_fila("IndExcluido").ToString _
                             , o_fila("FechaEmision").ToString _
                             , o_fila("FechaVencimiento").ToString _
                             , o_fila("IndTipoVehiculo").ToString _
                             , o_fila("FechaExclusion").ToString _
                             , o_fila("IdDocVeh_Doc").ToString _
                             , o_fila("IdDocVeh_Doc2").ToString _
                             , o_fila("NroSerieMotor").ToString _
                             , o_fila("NroSerieChasis").ToString _
                             )
            Return oeDetalleDocumentoVehiculo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleDocumentoVehiculo As e_DetalleDocumentoVehiculo) As e_DetalleDocumentoVehiculo
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", oeDetalleDocumentoVehiculo.Id)
            If ds.Tables.Count > 0 Then
                oeDetalleDocumentoVehiculo = Cargar(ds.Tables(0).Rows(0))
                Return oeDetalleDocumentoVehiculo
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleDocumentoVehiculo As e_DetalleDocumentoVehiculo) As List(Of e_DetalleDocumentoVehiculo)
        Try
            Dim ldDetalleDocumentoVehiculo As New List(Of e_DetalleDocumentoVehiculo)
            Dim ds As DataSet
            With oeDetalleDocumentoVehiculo
                ds = sqlhelper.ExecuteDataset("STD.Isp_DetalleDocumentoVehicular_Listar" _
                        , .TipoOperacion _
                        , .Id _
                        , .IdVehiculo _
                        , .IdDocumento _
                        , .Activo _
                        , .UsuarioCreacion _
                        )
            End With
            oeDetalleDocumentoVehiculo = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDetalleDocumentoVehiculo = Cargar(o_Fila)
                    ldDetalleDocumentoVehiculo.Add(oeDetalleDocumentoVehiculo)
                Next
            End If
            Return ldDetalleDocumentoVehiculo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleDocumentoVehiculo As e_DetalleDocumentoVehiculo) As Boolean
        Try
            With oeDetalleDocumentoVehiculo
                sqlhelper.ExecuteNonQuery("STD.Isp_DetalleDocumentoVehiculo_IAE" _
                                         , .TipoOperacion, .PrefijoID _
                                          , .Id _
                        , .IdVehiculo _
                        , .IdDocumento _
                        , .Prima _
                        , .Comision _
                        , .DerEmision _
                        , .Igv _
                        , .Total _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .IndExcluido _
                        , .FechaEmision _
                        , .FechaVencimiento _
                        , .IndTipoVehiculo _
                        , .FechaExclusion _
                        , .IdDocVeh_Doc _
                        , .IdDocVeh_Doc2
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetalleDocumentoVehiculo As e_DetalleDocumentoVehiculo) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeDetalleDocumentoVehiculo.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
