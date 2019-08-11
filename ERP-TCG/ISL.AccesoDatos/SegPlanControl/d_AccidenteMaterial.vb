Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_AccidenteMaterial
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_AccidenteMaterial
        Try
            Dim oeAccidenteMaterial = New e_AccidenteMaterial( _
                             o_fila("Id").ToString _
                             , o_fila("IdMaterial").ToString _
                             , o_fila("Detalle").ToString _
                             , o_fila("Observacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("IdAccidente").ToString _
                             , o_fila("Material").ToString)
            Return oeAccidenteMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeAccidenteMaterial As e_AccidenteMaterial) As e_AccidenteMaterial

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", oeAccidenteMaterial.Id)
            If ds.Tables.Count > 0 Then
                oeAccidenteMaterial = Cargar(ds.Tables(0).Rows(0))
                Return oeAccidenteMaterial
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAccidenteMaterial As e_AccidenteMaterial) As List(Of e_AccidenteMaterial)
        Try
            Dim ldAccidenteMaterial As New List(Of e_AccidenteMaterial)
            Dim ds As DataSet
            With oeAccidenteMaterial
                ds = sqlhelper.ExecuteDataset("SPC.Isp_Accidente_Material_Listar", .TipoOperacion _
                        , .Id _
                        , .IdMaterial _
                        , .Detalle _
                        , .Observacion _
                        , .Activo _
                        , .IdAccidente _
                        )
            End With
            oeAccidenteMaterial = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeAccidenteMaterial = Cargar(o_Fila)
                    ldAccidenteMaterial.Add(oeAccidenteMaterial)
                Next
                Return ldAccidenteMaterial
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAccidenteMaterial As e_AccidenteMaterial) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeAccidenteMaterial
                sqlhelper.ExecuteNonQuery("SPC.Isp_Accidente_Material_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdMaterial _
                        , .Detalle _
                        , .Observacion _
                        , .Activo _
                        , .IdAccidente _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeAccidenteMaterial As e_AccidenteMaterial) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeAccidenteMaterial.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
