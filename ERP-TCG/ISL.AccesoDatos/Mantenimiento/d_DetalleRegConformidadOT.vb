Imports ISL.EntidadesWCF
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
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("MAN.Isp_DetalleRegConformidadOT_Listar", "", _
            oeDetalleRegConformidadOT.Id, oeDetalleRegConformidadOT.IdOT, oeDetalleRegConformidadOT.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeDetalleRegConformidadOT = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDetalleRegConformidadOT
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleRegConformidadOT As e_DetalleRegConformidadOT) As DataSet
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ldDetalleRegConformidadOT As New List(Of e_DetalleRegConformidadOT)
            Dim ds As DataSet
            With oeDetalleRegConformidadOT
                ds = sqlhelper.ExecuteDataset("MAN.Isp_DetalleRegConformidadOT_Listar" _
                                              , .TipoOperacion _
                                              , .Id _
                                              , .IdOT _
                                              , .IdRegConformidadOT _
                                              , .Activo _
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
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeDetalleRegConformidadOT
                sqlhelper.ExecuteNonQuery("MAN.Isp_DetalleRegConformidadOT_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdOT _
                        , .IdRegConformidadOT _
                        , .Activo _
                        , .UsuarioCreacion _
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
