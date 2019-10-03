Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_MotivoCese
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_MotivoCese
        Try
            Dim oeMotivoCese = New e_MotivoCese( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
            )
            Return oeMotivoCese
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMotivoCese As e_MotivoCese) As e_MotivoCese
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_MotivoCese_Listar", "", oeMotivoCese.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeMotivoCese = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMotivoCese
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMotivoCese As e_MotivoCese) As List(Of e_MotivoCese)
        Try
            Dim ldMotivoCese As New List(Of e_MotivoCese)
            Dim ds As DataSet
            With oeMotivoCese
                ds = sqlhelper.ExecuteDataset("STD.Isp_MotivoCese_Listar", "" _
                        , .Id)
            End With
            oeMotivoCese = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeMotivoCese = Cargar(o_Fila)
                ldMotivoCese.Add(oeMotivoCese)
            Next
            Return ldMotivoCese
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMotivoCese As e_MotivoCese) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeMotivoCese
                sqlhelper.ExecuteNonQuery("STD.Isp_MotivoCese_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .Nombre _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeMotivoCese As e_MotivoCese) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_MotivoCese_IAE", "E", _
             "", oeMotivoCese.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
