'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ProcesoGlosa
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_ProcesoGlosa
        Try
            Dim oeProcesoGlosa = New e_ProcesoGlosa( _
                             o_fila("Id").ToString _
                             , o_fila("IdProcesoNegocio").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("ProcesoNegocio").ToString _
                             , o_fila("UsuarioCreacion").ToString _
            )
            Return oeProcesoGlosa
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeProcesoGlosa As e_ProcesoGlosa) As e_ProcesoGlosa
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.ISP_ProcesoGlosa_Listar", "",
            oeProcesoGlosa.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeProcesoGlosa = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeProcesoGlosa
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeProcesoGlosa As e_ProcesoGlosa) As List(Of e_ProcesoGlosa)
        Try
            Dim ldProcesoGlosa As New List(Of e_ProcesoGlosa)
            Dim ds As DataSet
            With oeProcesoGlosa
                ds = sqlhelper.ExecuteDataset("STD.ISP_ProcesoGlosa_Listar", "" _
                        , .Id _
                        , .IdProcesoNegocio _
                        , .ProcesoNegocio _
                        , .Nombre _
                        , .Activo
                        )
            End With
            oeProcesoGlosa = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeProcesoGlosa = Cargar(o_Fila)
                    ldProcesoGlosa.Add(oeProcesoGlosa)
                Next
            End If
            Return ldProcesoGlosa
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal loProcesoGlosa As List(Of e_ProcesoGlosa)) As Boolean
        Try
            Using transScope As New TransactionScope()
                For Each Lista As e_ProcesoGlosa In loProcesoGlosa
                    sqlhelper.ExecuteNonQuery("STD.ISP_ProcesoGlosa_IAE", Lista.TipoOperacion, Lista.PrefijoID,
                             Lista.Id _
                            , Lista.IdProcesoNegocio _
                            , Lista.Nombre _
                            , Lista.Activo _
                            , Lista.UsuarioCreacion
                        )
                Next
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeProcesoGlosa As e_ProcesoGlosa) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.ISP_ProcesoGlosa_IAE", "E", _
             "", oeProcesoGlosa.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class