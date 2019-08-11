Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_GastoViatico
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_GastoViatico
        Try
            Dim oeGastoViatico = New e_GastoViatico( _
                             o_fila("Id").ToString _
                             , o_fila("IdViaje").ToString _
                             , o_fila("Fecha") _
                             , o_fila("IndZona") _
                             , o_fila("IdCuentaCorriente").ToString _
                             , o_fila("TipoConductor") _
                             , o_fila("IndDesayuno") _
                             , o_fila("IndAlmuerzo") _
                             , o_fila("IndCena") _
                             , o_fila("Monto") _
                             , o_fila("IdEstado") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo") _
            )
            Return oeGastoViatico
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeGastoViatico As e_GastoViatico) As e_GastoViatico

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_GastoViatico_Listar", "", oeGastoViatico.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeGastoViatico = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeGastoViatico
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGastoViatico As e_GastoViatico) As List(Of e_GastoViatico)
        Try
            Dim ldGastoViatico As New List(Of e_GastoViatico)
            Dim ds As DataSet
            With oeGastoViatico
                ds = sqlhelper.ExecuteDataset("TES.Isp_GastoViatico_Listar", "" _
                        , .Id _
                        , .IdViaje _
                        , .Fecha _
                        , .IndZona _
                        , .IdCuentaCorriente _
                        , .TipoConductor _
                        , .IndDesayuno _
                        , .IndAlmuerzo _
                        , .IndCena _
                        , .Monto _
                        , .IdEstado _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeGastoViatico = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeGastoViatico = Cargar(o_Fila)
                ldGastoViatico.Add(oeGastoViatico)
            Next
            Return ldGastoViatico
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGastoViatico As e_GastoViatico) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeGastoViatico
                sqlhelper.ExecuteNonQuery("TES.ISP_GastoViatico_IAE", .TipoOperacion, _
                        .Id _
                        , .IdViaje _
                        , .Fecha _
                        , .IndZona _
                        , .IdCuentaCorriente _
                        , .TipoConductor _
                        , .IndDesayuno _
                        , .IndAlmuerzo _
                        , .IndCena _
                        , .Monto _
                        , .IdEstado _
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

    Public Function Eliminar(ByVal oeGastoViatico As e_GastoViatico) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.ISP_GastoViatico_IAE", "E", oeGastoViatico.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
