Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_MontoFlujoDiario_Det

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_MontoFlujoDiario_Det
        Try
            Dim oeMontoFlujoDiario_Det = New e_MontoFlujoDiario_Det( _
                             o_Fila("Id").ToString _
                             , o_Fila("IdMontoFlujoDiario").ToString _
                             , o_Fila("Tipo").ToString _
                             , o_Fila("MontoPromedio").ToString _
                             , o_Fila("FechaCreacion").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
                             , o_Fila("Activo").ToString _
            )
            Return oeMontoFlujoDiario_Det
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMontoFlujoDiario_Det As e_MontoFlujoDiario_Det) As e_MontoFlujoDiario_Det

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_MontoFlujoDiario_Det_Listar", "", oeMontoFlujoDiario_Det.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeMontoFlujoDiario_Det = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMontoFlujoDiario_Det
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMontoFlujoDiario_Det As e_MontoFlujoDiario_Det) As List(Of e_MontoFlujoDiario_Det)
        Try
            Dim ldMontoFlujoDiario_Det As New List(Of e_MontoFlujoDiario_Det)
            Dim ds As DataSet
            With oeMontoFlujoDiario_Det
                ds = sqlhelper.ExecuteDataset("TES.Isp_MontoFlujoDiario_Det_Listar", "" _
                        , .Id _
                        , .IdMontoFlujoDiario _
                        , .Tipo _
                        , .MontoPromedio _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeMontoFlujoDiario_Det = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeMontoFlujoDiario_Det = Cargar(o_Fila)
                ldMontoFlujoDiario_Det.Add(oeMontoFlujoDiario_Det)
            Next
            Return ldMontoFlujoDiario_Det
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMontoFlujoDiario_Det As e_MontoFlujoDiario_Det) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeMontoFlujoDiario_Det
                sqlhelper.ExecuteNonQuery("TES.Isp_MontoFlujoDiario_Det_IAE", .TipoOperacion, _
                        .Id _
                        , .IdMontoFlujoDiario _
                        , .Tipo _
                        , .MontoPromedio _
                        , .UsuarioCreacion _
                        , .Activo _
                        , d_DatosConfiguracion.PrefijoID _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeMontoFlujoDiario_Det As e_MontoFlujoDiario_Det) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_MontoFlujoDiario_Det_IAE", "E", oeMontoFlujoDiario_Det.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
