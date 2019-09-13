Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_RevisionTecnica
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_RevisionTecnica
        Try
            Dim oeRevisionTecnica = New e_RevisionTecnica( _
                             o_fila("Id").ToString _
                             , o_fila("IdDocumentoVehicular").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("Calificacion").ToString _
                             , o_fila("Activo").ToString _
                              )
            Return oeRevisionTecnica
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeRevisionTecnica As e_RevisionTecnica) As List(Of e_RevisionTecnica)
        Try
            Dim ldRevisionTecnica As New List(Of e_RevisionTecnica)
            Dim ds As DataSet
            With oeRevisionTecnica
                ds = sqlhelper.ExecuteDataset("STD.Isp_RevisionTecnica_Listar" _
                        , .TipoOperacion _
                        , .Id _
                        , .IdDocumentoVehicular _
                        , .Activo _
                        )
            End With
            oeRevisionTecnica = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeRevisionTecnica = Cargar(o_Fila)
                    ldRevisionTecnica.Add(oeRevisionTecnica)
                Next
            End If
            Return ldRevisionTecnica
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeRevisionTecnica As e_RevisionTecnica) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeRevisionTecnica
                sqlhelper.ExecuteNonQuery("STD.Isp_RevisionTecnica_IAE" _
                                              , .TipoOperacion, _
                                              .PrefijoID _
                                            , .Id _
                                            , .IdDocumentoVehicular _
                                            , .Codigo _
                                            , .Descripcion _
                                            , .Calificacion _
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

End Class
