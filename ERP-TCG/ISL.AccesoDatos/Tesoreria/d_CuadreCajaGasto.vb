Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_CuadreCajaGasto
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_CuadreCajaGasto
        Try
            Dim oeCuadreCajaGasto = New e_CuadreCajaGasto(o_fila("Id").ToString _
                             , o_fila("IdCuadreCaja").ToString _
                             , o_fila("IdTipoDocumento").ToString _
                             , o_fila("TipoDocumento").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("Importe").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("Activo").ToString)
            Return oeCuadreCajaGasto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCuadreCajaGasto As e_CuadreCajaGasto) As e_CuadreCajaGasto

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[TES].[Isp_CuadreCajaGasto_Listar]", "", oeCuadreCajaGasto.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeCuadreCajaGasto = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCuadreCajaGasto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCuadreCajaGasto As e_CuadreCajaGasto) As List(Of e_CuadreCajaGasto)
        Try
            Dim ldCuadreCajaGasto As New List(Of e_CuadreCajaGasto)
            Dim ds As DataSet
            With oeCuadreCajaGasto
                ds = sqlhelper.ExecuteDataset("[TES].[Isp_CuadreCajaGasto_Listar]", "" _
                        , .Id _
                        , .IdCuadreCaja _
                        , .IdTipoDocumento)
            End With
            oeCuadreCajaGasto = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeCuadreCajaGasto = Cargar(o_Fila)
                ldCuadreCajaGasto.Add(oeCuadreCajaGasto)
            Next
            Return ldCuadreCajaGasto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCuadreCajaGasto As e_CuadreCajaGasto) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeCuadreCajaGasto
                sqlhelper.ExecuteNonQuery("[TES].[Isp_CuadreCajaGasto_IAE]", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdCuadreCaja _
                        , .IdTipoDocumento _
                        , .Fecha _
                        , .Importe _
                        , .Glosa _
                        , .Activo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

    Public Function Eliminar(ByVal oeCuadreCajaGasto As e_CuadreCajaGasto) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[TES].[Isp_CuadreCajaGasto_IAE]", "E", _
             "", oeCuadreCajaGasto.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
