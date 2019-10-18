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

Public Class d_Modelo
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Modelo
        Try
            Dim oeModeloVehiculo = New e_Modelo(
                             o_fila("Seleccion").ToString _
                               , o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("Activo").ToString _
                              , o_fila("IdMarca").ToString _
                             , o_fila("Marca").ToString _
                            , o_fila("MarcaModelo").ToString _
                            , o_fila("IndEmpresa").ToString _
                            , o_fila("IndSunarp").ToString)
            Return oeModeloVehiculo
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Obtener(ByVal oeModeloVehiculo As e_Modelo) As e_Modelo
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_ModeloVehiculo_Listar",
                                          "",
                                          oeModeloVehiculo.Id,
                                          oeModeloVehiculo.Nombre)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeModeloVehiculo = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeModeloVehiculo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeModeloVehiculo As e_Modelo) As List(Of e_Modelo)
        Try
            Dim ldModeloVehiculo As New List(Of e_Modelo)
            Dim ds As DataSet
            With oeModeloVehiculo
                ds = sqlhelper.ExecuteDataset("STD.Isp_ModeloVehiculo_Listar",
                                              .TipoOperacion _
                                                , .Id _
                                                , .Nombre _
                                                , .Codigo _
                                                , .Abreviatura _
                                                , .IdMarca)
            End With
            oeModeloVehiculo = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeModeloVehiculo = Cargar(o_Fila)
                    ldModeloVehiculo.Add(oeModeloVehiculo)
                Next
            Else
                ldModeloVehiculo = New List(Of e_Modelo)
            End If
            Return ldModeloVehiculo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeModeloVehiculo As e_Modelo) As Boolean
        Try
            With oeModeloVehiculo
                sqlhelper.ExecuteNonQuery("[STD].[Isp_ModeloVehiculo_IAE]",
                                          .TipoOperacion,
                                          .PrefijoID _
                                        , .Id _
                                        , .Codigo _
                                        , .Nombre _
                                        , .Abreviatura _
                                        , .IdMarca _
                                        , .IndEmpresa _
                                        , .IndSunarp)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeModeloVehiculo As e_Modelo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[STD].[Isp_ModeloVehiculo_IAE]",
                                      oeModeloVehiculo.TipoOperacion,
                                        "",
                                        oeModeloVehiculo.Id)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function ComboGrilla(ByVal loModelo As List(Of e_Modelo))
        Try
            Dim ds = New DataTable
            ds.Columns.Add("Id")
            ds.Columns.Add("Nombre")
            For Each item As e_Modelo In loModelo
                Dim newRow As DataRow = ds.NewRow()
                newRow("Id") = item.Id
                newRow("Nombre") = item.Nombre
                ds.Rows.Add(newRow)
            Next
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class


