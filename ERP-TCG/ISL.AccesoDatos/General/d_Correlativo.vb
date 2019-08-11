Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

''' <summary>
''' Clase que permite el acceso a datos de la entidad Correlativo, utilizado en la generación de numeración de vales de tesorería
''' </summary>
''' <remarks></remarks>
Public Class d_Correlativo
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_Correlativo
        Try
            Dim oeCorrelativo = New e_Correlativo( _
                             o_fila("Prefijo").ToString _
                             , o_fila("IdTipoDocumento").ToString _
                             , o_fila("Numero").ToString _
                             , o_fila("Serie").ToString _
                             , o_fila("Tipo"))
            Return oeCorrelativo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCorrelativo As e_Correlativo) As e_Correlativo
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_Correlativo_Listar", oeCorrelativo.TipoOperacion, oeCorrelativo.Prefijo, oeCorrelativo.IdTipoDocumento)
            oeCorrelativo = New e_Correlativo
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeCorrelativo = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCorrelativo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ObtenerLocal(ByVal oeCorrelativo As e_Correlativo) As e_Correlativo
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_CorrelativoLocal_Listar", oeCorrelativo.TipoOperacion, oeCorrelativo.Prefijo, oeCorrelativo.IdTipoDocumento, 0, 0, oeCorrelativo.Tipo)
            oeCorrelativo = New e_Correlativo
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeCorrelativo = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCorrelativo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCorrelativo As e_Correlativo) As List(Of e_Correlativo)
        Try
            Dim ldCorrelativo As New List(Of e_Correlativo)
            Dim ds As DataSet
            With oeCorrelativo
                ds = sqlhelper.ExecuteDataset("STD.Isp_Correlativo_Listar", .TipoOperacion _
                        , .Prefijo _
                        , .IdTipoDocumento _
                        , .Numero _
                        , .Serie _
                        )
            End With
            oeCorrelativo = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCorrelativo = Cargar(o_Fila)
                    ldCorrelativo.Add(oeCorrelativo)
                Next
                Return ldCorrelativo
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCorrelativo As e_Correlativo) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeCorrelativo
                sqlhelper.ExecuteNonQuery("STD.Isp_Correlativo_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .IdTipoDocumento _
                        , .Numero _
                        , .Serie )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarLocal(ByVal oeCorrelativo As e_Correlativo) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeCorrelativo
                sqlhelper.ExecuteNonQuery("STD.Isp_CorrelativoLocal_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .IdTipoDocumento _
                        , .Numero _
                        , .Serie _
                        , .Tipo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class