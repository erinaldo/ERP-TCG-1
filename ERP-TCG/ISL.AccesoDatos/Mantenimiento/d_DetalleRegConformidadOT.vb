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

Public Class d_DetalleRegConformidadOT
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_DetalleRegConformidadOT
        Try
            Dim oeDetalleRegConformidadOT = New e_DetalleRegConformidadOT( _
                             o_Fila("Id").ToString _
                             , o_Fila("IdOT").ToString _
                             , o_Fila("IdRegConformidadOT").ToString _
                             , o_Fila("Activo").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
                             , o_Fila("FechaCreacion").ToString _
            )
            Return oeDetalleRegConformidadOT
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleRegConformidadOT As e_DetalleRegConformidadOT) As e_DetalleRegConformidadOT

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("MAN.Isp_DetalleRegConformidadOT_Listar", "",
            oeDetalleRegConformidadOT.Id, oeDetalleRegConformidadOT.IdOT, oeDetalleRegConformidadOT.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeDetalleRegConformidadOT = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDetalleRegConformidadOT
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleRegConformidadOT As e_DetalleRegConformidadOT) As DataSet
        Try
            Dim ldDetalleRegConformidadOT As New List(Of e_DetalleRegConformidadOT)
            Dim ds As DataSet
            With oeDetalleRegConformidadOT
                ds = sqlhelper.ExecuteDataset("MAN.Isp_DetalleRegConformidadOT_Listar" _
                                              , .TipoOperacion _
                                              , .Id _
                                              , .IdOT _
                                              , .IdRegConformidadOT _
                                              , .Activo
                                              )
            End With
            oeDetalleRegConformidadOT = Nothing
            Return ds
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleRegConformidadOT As e_DetalleRegConformidadOT) As Boolean
        Try
            With oeDetalleRegConformidadOT
                sqlhelper.ExecuteNonQuery("MAN.Isp_DetalleRegConformidadOT_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdOT _
                        , .IdRegConformidadOT _
                        , .Activo _
                        , .UsuarioCreacion
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetalleRegConformidadOT As e_DetalleRegConformidadOT) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("MAN.Isp_DetalleRegConformidadOT_IAE", "E", _
             "", oeDetalleRegConformidadOT.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
