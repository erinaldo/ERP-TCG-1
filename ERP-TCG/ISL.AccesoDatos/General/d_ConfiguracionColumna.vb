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

Public Class d_ConfiguracionColumna

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_ConfiguracionColumna
        Try
            Dim oeConfiguracionColumna = New e_ConfiguracionColumna( _
                             o_fila("Id").ToString _
                             , o_fila("IdTabla").ToString _
                             , o_fila("NroOrden") _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("TipoDato").ToString _
                             , o_fila("Longitud").ToString _
                             , o_fila("IndClave") _
                             , o_fila("ValorDefecto").ToString _
                             , o_fila("Obligatorio") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo") _
            )
            Return oeConfiguracionColumna
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeConfiguracionColumna As e_ConfiguracionColumna) As e_ConfiguracionColumna

        Try
            Dim ds As DataSet
            With oeConfiguracionColumna
                ds = sqlhelper.ExecuteDataset("STD.Isp_ConfiguracionColumna_Listar", .TipoOperacion, .Id)
            End With
            If ds.Tables(0).rows.Count > 0 Then
                oeConfiguracionColumna = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeConfiguracionColumna
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeConfiguracionColumna As e_ConfiguracionColumna) As List(Of e_ConfiguracionColumna)
        Try
            Dim ldConfiguracionColumna As New List(Of e_ConfiguracionColumna)
            Dim ds As DataSet
            With oeConfiguracionColumna
                ds = sqlhelper.ExecuteDataset("STD.Isp_ConfiguracionColumna_Listar", .TipoOperacion _
                        , .Id _
                        , .IdTabla _
                        , .Codigo _
                        , .Nombre _
                        , .Descripcion _
                        , .TipoDato _
                        , .Longitud _
                        , .IndClave _
                        , .ValorDefecto _
                        , .Activo _
                        )
            End With
            oeConfiguracionColumna = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeConfiguracionColumna = Cargar(o_Fila)
                ldConfiguracionColumna.Add(oeConfiguracionColumna)
            Next
            Return ldConfiguracionColumna
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeConfiguracionColumna As e_ConfiguracionColumna) As Boolean
        Try

            With oeConfiguracionColumna
                sqlhelper.ExecuteNonQuery("STD.Isp_ConfiguracionColumna_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdTabla _
                        , .NroOrden _
                        , .Codigo _
                        , .Nombre _
                        , .Descripcion _
                        , .TipoDato _
                        , .Longitud _
                        , .IndClave _
                        , .ValorDefecto _
                        , .Obligatorio _
                        , .UsuarioCreacion _
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

    Public Function Eliminar(ByVal oeConfiguracionColumna As e_ConfiguracionColumna) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_ConfiguracionColumna_IAE", "E", _
             "", oeConfiguracionColumna.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
