Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_MedidaNeumatico
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_MedidaNeumatico
        Try
            Dim oeMedidaNeumatico = New e_MedidaNeumatico( _
                             o_fila("Id").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("IdTipoNeumatico").ToString _
                             , o_fila("TipoNeumatico").ToString _
                             , o_fila("IdTipoMedida").ToString _
                             , o_fila("TipoMedida").ToString _
                             , o_fila("DiametroAro").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
            )
            Return oeMedidaNeumatico
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMedidaNeumatico As e_MedidaNeumatico) As e_MedidaNeumatico

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[NEU].[Isp_MedidaNeumatico_Listar]", "", oeMedidaNeumatico.Id)
            If ds.Tables.Count > 0 Then
                oeMedidaNeumatico = Cargar(ds.Tables(0).Rows(0))
                Return oeMedidaNeumatico
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMedidaNeumatico As e_MedidaNeumatico) As List(Of e_MedidaNeumatico)
        Try
            Dim ldMedidaNeumatico As New List(Of e_MedidaNeumatico)
            Dim ds As DataSet
            With oeMedidaNeumatico
                ds = sqlhelper.ExecuteDataset("[NEU].[Isp_MedidaNeumatico_Listar]", .TipoOperacion _
                        , .Id _
                        , .Nombre _
                        , .IdTipoNeumatico _
                        , .DiametroAro _
                        , .Activo _
                        , .UsuarioCreacion _
                                  )
            End With
            oeMedidaNeumatico = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMedidaNeumatico = Cargar(o_Fila)
                    ldMedidaNeumatico.Add(oeMedidaNeumatico)
                Next
            End If
            Return ldMedidaNeumatico
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMedidaNeumatico As e_MedidaNeumatico) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeMedidaNeumatico
                sqlhelper.ExecuteNonQuery("[NEU].[Isp_MedidaNeumatico_IAE]", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .Nombre _
                        , .IdTipoNeumatico _
                        , .IdTipoMedida _
                        , .DiametroAro _
                        , .Activo _
                        , .UsuarioCreacion _
                               )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeMedidaNeumatico As e_MedidaNeumatico) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[NEU].[Isp_MedidaNeumatico_IAE]", "E", _
             "", oeMedidaNeumatico.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
