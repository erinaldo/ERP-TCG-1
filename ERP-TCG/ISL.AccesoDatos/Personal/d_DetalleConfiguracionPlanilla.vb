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

Public Class d_DetalleConfiguracionPlanilla

    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_DetalleConfiguracionPlanilla
        Try
            Dim oeDetalleConfiguracionPlanilla = New e_DetalleConfiguracionPlanilla( _
                             o_fila("Id").ToString _
                             , o_fila("IdConfiguracionPlanilla").ToString _
                             , o_fila("IdAporteDescuento").ToString _
                             , o_fila("AporteDescuento").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("Tipo") _
                             , o_fila("IndTotal") _
                             , o_fila("NroOrden") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo") _
            )
            oeDetalleConfiguracionPlanilla.CodigoSunat = o_fila("IdReferencia").ToString
            Return oeDetalleConfiguracionPlanilla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleConfiguracionPlanilla As e_DetalleConfiguracionPlanilla) As e_DetalleConfiguracionPlanilla

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_DetalleConfiguracionPlanilla_Listar", "", oeDetalleConfiguracionPlanilla.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeDetalleConfiguracionPlanilla = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDetalleConfiguracionPlanilla
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleConfiguracionPlanilla As e_DetalleConfiguracionPlanilla) As List(Of e_DetalleConfiguracionPlanilla)
        Try
            Dim ldDetalleConfiguracionPlanilla As New List(Of e_DetalleConfiguracionPlanilla)
            Dim ds As DataSet
            With oeDetalleConfiguracionPlanilla
                ds = sqlhelper.ExecuteDataset("PER.Isp_DetalleConfiguracionPlanilla_Listar", .TipoOperacion _
                        , .Id _
                        , .IdConfiguracionPlanilla _
                        , .IdAporteDescuento _
                        , .Tipo _
                        , .NroOrden _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                        )
            End With
            oeDetalleConfiguracionPlanilla = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeDetalleConfiguracionPlanilla = Cargar(o_Fila)
                ldDetalleConfiguracionPlanilla.Add(oeDetalleConfiguracionPlanilla)
            Next
            Return ldDetalleConfiguracionPlanilla
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleConfiguracionPlanilla As e_DetalleConfiguracionPlanilla) As Boolean
        Try
            With oeDetalleConfiguracionPlanilla
                sqlhelper.ExecuteNonQuery("PER.Isp_DetalleConfiguracionPlanilla_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdConfiguracionPlanilla _
                        , .IdAporteDescuento _
                        , .Tipo _
                        , .IndTotal _
                        , .NroOrden _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                        , .CodigoSunat
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetalleConfiguracionPlanilla As e_DetalleConfiguracionPlanilla) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_DetalleConfiguracionPlanilla_IAE", "E", _
             "", oeDetalleConfiguracionPlanilla.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
