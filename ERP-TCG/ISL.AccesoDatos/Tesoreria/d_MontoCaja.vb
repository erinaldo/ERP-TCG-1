Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_MontoCaja

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_MontoCaja
        Try
            Dim oeMontoCaja = New e_MontoCaja( _
                             o_fila("Id").ToString _
                             , o_fila("IdCaja").ToString _
                             , o_fila("Caja").ToString _
                             , o_fila("Monto").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("ApellidoPaterno") & " " & o_fila("ApellidoMaterno") & ", " & o_fila("Nombre") _
                             , o_fila("Activo").ToString _
            )
            Return oeMontoCaja
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMontoCaja As e_MontoCaja) As e_MontoCaja

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_MontoCaja_Listar", "", oeMontoCaja.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeMontoCaja = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMontoCaja
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMontoCaja As e_MontoCaja) As List(Of e_MontoCaja)
        Try
            Dim ldMontoCaja As New List(Of e_MontoCaja)
            Dim ds As DataSet
            With oeMontoCaja
                ds = sqlhelper.ExecuteDataset("TES.Isp_MontoCaja_Listar", "" _
                        , .Id _
                        , .IdCaja _
                        , .Monto _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeMontoCaja = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeMontoCaja = Cargar(o_Fila)
                ldMontoCaja.Add(oeMontoCaja)
            Next
            Return ldMontoCaja
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMontoCaja As e_MontoCaja) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeMontoCaja
                sqlhelper.ExecuteNonQuery("TES.Isp_MontoCaja_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdCaja _
                        , .Monto _
                        , .UsuarioCreacion _
                        , .Activo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeMontoCaja As e_MontoCaja) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_MontoCaja_IAE", "E", oeMontoCaja.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
