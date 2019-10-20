'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient
Public Class d_ModeloFuncionalVehiculo
    Private sqlhelper As New SqlHelper

    Public Function Cargar(ByVal o_fila As DataRow) As e_ModeloFuncionalVehiculo
        Try
            Dim oeModeloFuncionalVehiculo = New e_ModeloFuncionalVehiculo(
                               o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("Activo").ToString
            )
            Return oeModeloFuncionalVehiculo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeModeloFuncionalVehiculo As e_ModeloFuncionalVehiculo) As e_ModeloFuncionalVehiculo

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_ModeloFuncionalVehiculo_Listar", "", oeModeloFuncionalVehiculo.Id)
            If ds.Tables.Count > 0 Then
                oeModeloFuncionalVehiculo = Cargar(ds.Tables(0).Rows(0))
                Return oeModeloFuncionalVehiculo
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeModeloFuncionalVehiculo As e_ModeloFuncionalVehiculo) As List(Of e_ModeloFuncionalVehiculo)
        Try
            Dim ldModeloFuncionalVehiculo As New List(Of e_ModeloFuncionalVehiculo)
            Dim ds As DataSet
            With oeModeloFuncionalVehiculo
                ds = sqlhelper.ExecuteDataset("STD.Isp_ModeloFuncionalVehiculo_Listar", "" _
                        , .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .Activo
                        )
            End With
            oeModeloFuncionalVehiculo = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeModeloFuncionalVehiculo = Cargar(o_Fila)
                    ldModeloFuncionalVehiculo.Add(oeModeloFuncionalVehiculo)
                Next
                Return ldModeloFuncionalVehiculo
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeModeloFuncionalVehiculo As e_ModeloFuncionalVehiculo) As Boolean
        Try
            With oeModeloFuncionalVehiculo
                sqlhelper.ExecuteNonQuery("[STD].[Isp_ModeloFuncionalVehiculo_IAE]", .TipoOperacion, .PrefijoID _
                        , .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function


    Public Function Eliminar(ByVal oeModeloFuncionalVehiculo As e_ModeloFuncionalVehiculo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[STD].[Isp_ModeloFuncionalVehiculo_IAE]", oeModeloFuncionalVehiculo.TipoOperacion,
             "", oeModeloFuncionalVehiculo.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
