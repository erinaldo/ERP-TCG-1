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

Public Class d_AccidenteFoto
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_AccidenteFoto
        Try
            Dim oeAccidenteFoto = New e_AccidenteFoto( _
                             o_fila("Id").ToString _
                             , o_fila("IdAccidente").ToString _
                             , o_fila("Foto") _
                             , o_fila("FechaFoto").ToString _
                             , o_fila("Descripcion").ToString)
            Return oeAccidenteFoto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeAccidenteFoto As e_AccidenteFoto) As e_AccidenteFoto

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SPC.Isp_Accidente_Foto_Listar", "", oeAccidenteFoto.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeAccidenteFoto = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeAccidenteFoto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeAccidenteFoto As e_AccidenteFoto) As List(Of e_AccidenteFoto)
        Try
            Dim ldAccidenteFoto As New List(Of e_AccidenteFoto)
            Dim ds As DataSet
            With oeAccidenteFoto
                ds = sqlhelper.ExecuteDataset("SPC.Isp_Accidente_Foto_Listar", "" _
                        , .Id _
                        , .IdAccidente)
            End With
            oeAccidenteFoto = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeAccidenteFoto = Cargar(o_Fila)
                ldAccidenteFoto.Add(oeAccidenteFoto)
            Next
            Return ldAccidenteFoto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeAccidenteFoto As e_AccidenteFoto) As Boolean
        Try
            Dim ms As New IO.MemoryStream
            With oeAccidenteFoto
                .Foto.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                sqlhelper.ExecuteNonQuery("SPC.Isp_Accidente_Foto_IAE", .TipoOperacion, .PrefijoID,
                    .Id _
                    , .IdAccidente _
                    , ms.ToArray() _
                    , .FechaFoto _
                    , .Descripcion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeAccidenteFoto As e_AccidenteFoto) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SPC.Isp_Accidente_Foto_IAE", "E", _
             "", oeAccidenteFoto.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
