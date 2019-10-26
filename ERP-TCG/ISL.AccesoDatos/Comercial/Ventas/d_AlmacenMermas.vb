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

Public Class d_AlmacenMermas
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_AlmacenMermas
        Try
            Dim oeAlmacenMermas = New e_AlmacenMermas(o_fila("Id").ToString _
                                                      , o_fila("IdIngresoSalidaMermas").ToString _
                             , o_fila("IdMaterial").ToString _
                             , o_fila("IdUnidadMedida").ToString _
                             , o_fila("FactorConversion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("PrecioVenta").ToString _
                             , o_fila("Stock").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Material").ToString)

            Return oeAlmacenMermas
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeAlmacenMermas As e_AlmacenMermas) As e_AlmacenMermas
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("OPE.Isp_AlmacenMermas_Listar", _
                                          "", _
                                          oeAlmacenMermas.Id, _
                                          oeAlmacenMermas.IdMaterial)
            If ds.Tables(0).rows.Count > 0 Then
                oeAlmacenMermas = Cargar(ds.Tables(0).Rows(0))
            Else
                oeAlmacenMermas = New e_AlmacenMermas
            End If
            Return oeAlmacenMermas
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeAlmacenMermas As e_AlmacenMermas) As List(Of e_AlmacenMermas)
        Try
            Dim ldAlmacenMermas As New List(Of e_AlmacenMermas)
            Dim ds As DataSet
            With oeAlmacenMermas
                ds = sqlhelper.ExecuteDataset("OPE.Isp_AlmacenMermas_Listar", _
                                              .TipoOperacion _
                                                , .Id _
                                                , .IdMaterial, .IdCentro)
            End With
            oeAlmacenMermas = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeAlmacenMermas = Cargar(o_Fila)
                    ldAlmacenMermas.Add(oeAlmacenMermas)
                Next
            Else
                ldAlmacenMermas = New List(Of e_AlmacenMermas)
            End If
            Return ldAlmacenMermas
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeAlmacenMermas As e_AlmacenMermas) As Boolean
        Try
            With oeAlmacenMermas
                sqlhelper.ExecuteNonQuery("OPE.Isp_AlmacenMermas_IAE",
                                          .TipoOperacion,
                                          .PrefijoID,
                                            .Id _
                                            , .IdIngresoSalidaMermas _
                                            , .IdMaterial _
                                            , .IdUnidadMedida _
                                            , .FactorConversion _
                                            , .UsuarioCreacion _
                                            , .PrecioVenta _
                                            , .Stock _
                                            , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeAlmacenMermas As e_AlmacenMermas) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("OPE.Isp_AlmacenMermas_IAE", "E", _
             "", oeAlmacenMermas.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
