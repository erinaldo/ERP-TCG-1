Imports ISL.EntidadesWCF
Imports System.Data.SqlClient

Public Class d_AsientoReferencia

    Dim d_DatosConfiguracion As d_DatosConfiguracion
    Dim bd As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_AsientoReferencia
        Try
            Dim oeAsientoReferencia = New e_AsientoReferencia( _
                             o_fila("Id").ToString _
                             , o_fila("IdAsiento").ToString _
                             , o_fila("IdReferencia").ToString _
                             , o_fila("TipoReferencia").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("Activo").ToString)
            Return oeAsientoReferencia
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ExecuteLST(ByVal oeAsientoReferencia As e_AsientoReferencia) As DataSet
        Try
            Dim ds As DataSet
            With oeAsientoReferencia
                ds = bd.ExecuteDataset("[CON].[Isp_AsientoReferencia_Listar]" _
                        , .TipoOperacion _
                        , .Id _
                        , .IdAsiento _
                        , .IdReferencia _
                        , .TipoReferencia)
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeAsientoReferencia As e_AsientoReferencia) As e_AsientoReferencia
        Try
            Dim ds As DataSet = ExecuteLST(oeAsientoReferencia)
            If ds.Tables(0).Rows.Count > 0 Then
                oeAsientoReferencia = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeAsientoReferencia
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeAsientoReferencia As e_AsientoReferencia) As List(Of e_AsientoReferencia)
        Try
            Dim ldAsientoReferencia As New List(Of e_AsientoReferencia)
            Dim ds As DataSet = ExecuteLST(oeAsientoReferencia)
            oeAsientoReferencia = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeAsientoReferencia = Cargar(o_Fila)
                    ldAsientoReferencia.Add(oeAsientoReferencia)
                Next
            End If
            Return ldAsientoReferencia
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeAsientoReferencia As e_AsientoReferencia) As Boolean
        Try
            d_DatosConfiguracion = New d_DatosConfiguracion
            Dim stResultado() As String
            With oeAsientoReferencia
                stResultado = bd.ExecuteScalar("[CON].[Isp_AsientoReferencia_IAE]", .TipoOperacion, d_DatosConfiguracion.PrefijoID _
                        , .Id, .IdAsiento, .IdReferencia, .TipoReferencia).ToString.Split("_")
                .Id = stResultado(0)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeAsientoReferencia As e_AsientoReferencia) As Boolean
        Try
            With oeAsientoReferencia
                bd.ExecuteNonQuery("[CON].[Isp_AsientoReferencia_IAE]", "E", "", .Id)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UltimoIdInserta() As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado As String
            stResultado = bd.ExecuteScalar("STD.Isp_UltimoId_Inserta", "CON.AsientoReferencia", d_DatosConfiguracion.PrefijoID)
            Return IIf(stResultado Is Nothing, d_DatosConfiguracion.PrefijoID & "0000000000001", stResultado)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
