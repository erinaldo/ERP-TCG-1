Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_DetalleProduccionPiloto

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_DetalleProduccionPiloto
        Try
            Dim oeDetalleProduccionPiloto = New e_DetalleProduccionPiloto( _
                             o_fila("Id").ToString _
                             , o_fila("IdProduccionPiloto").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Dni").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("Ocupacion").ToString _
                             , o_fila("IndRuta") _
                             , o_fila("DiasTrabajados") _
                             , o_fila("DiasInduccion") _
                             , o_fila("Renumeracion") _
                             , o_fila("AsignacionFamiliar") _
                             , o_fila("Descuentos") _
                             , o_fila("IngresoNeto") _
                             , o_fila("Produccion") _
                             , o_fila("Reintegro") _
                             , o_fila("TotalProduccion") _
                             , o_fila("BonoProduccion") _
                             , o_fila("ListaPorcentaje").ToString _
                             , o_fila("TotalPonderado") _
                             , o_fila("ProduccionCaja") _
                             , o_fila("MontoProduccion") _
                             , o_fila("DescuentoSancion") _
                             , o_fila("NetoBonoProduccion") _
                             , o_fila("Regularizacion") _
                             , o_fila("TotalCaja") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifca") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo") _
            )
            Return oeDetalleProduccionPiloto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleProduccionPiloto As e_DetalleProduccionPiloto) As e_DetalleProduccionPiloto

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_DetalleProduccionPiloto_Listar", "", oeDetalleProduccionPiloto.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeDetalleProduccionPiloto = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDetalleProduccionPiloto
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleProduccionPiloto As e_DetalleProduccionPiloto) As List(Of e_DetalleProduccionPiloto)
        Try
            Dim ldDetalleProduccionPiloto As New List(Of e_DetalleProduccionPiloto)
            Dim ds As DataSet
            With oeDetalleProduccionPiloto
                ds = sqlhelper.ExecuteDataset("PER.Isp_DetalleProduccionPiloto_Listar", "" _
                        , .Id _
                        , .IdProduccionPiloto _
                        , .IdTrabajador _
                        , .IndRuta _
                        , .DiasTrabajados _
                        , .DiasInduccion _
                        , .Renumeracion _
                        , .BonoFijo2 _
                        , .BonoFijo _
                        , .IngresoNeto _
                        , .Produccion _
                        , .Reintegro _
                        , .TotalProduccion _
                        , .BonoProduccion _
                        , .TotalPonderado _
                        , .ProduccionCaja _
                        , .MontoProduccion _
                        , .DescuentoSancion _
                        , .NetoBonoProduccion _
                        , .Regularizacion _
                        , .TotalCaja _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifca _
                        , .UsuarioModifica _
                        , .Activo _
                        )
            End With
            oeDetalleProduccionPiloto = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeDetalleProduccionPiloto = Cargar(o_Fila)
                ldDetalleProduccionPiloto.Add(oeDetalleProduccionPiloto)
            Next
            Return ldDetalleProduccionPiloto
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleProduccionPiloto As e_DetalleProduccionPiloto) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeDetalleProduccionPiloto
                sqlhelper.ExecuteNonQuery("PER.Isp_DetalleProduccionPiloto_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdProduccionPiloto _
                        , .IdTrabajador _
                        , .IndRuta _
                        , .DiasTrabajados _
                        , .DiasInduccion _
                        , .Renumeracion _
                        , .BonoFijo2 _
                        , .BonoFijo _
                        , .IngresoNeto _
                        , .Produccion _
                        , .Reintegro _
                        , .ListaPorcentaje _
                        , .TotalProduccion _
                        , .BonoProduccion _
                        , .TotalPonderado _
                        , .ProduccionCaja _
                        , .MontoProduccion _
                        , .DescuentoSancion _
                        , .NetoBonoProduccion _
                        , .Regularizacion _
                        , .TotalCaja _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifca _
                        , .UsuarioModifica _
                        , .Activo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetalleProduccionPiloto As e_DetalleProduccionPiloto) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_DetalleProduccionPiloto_IAE", "E", _
             "", oeDetalleProduccionPiloto.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
