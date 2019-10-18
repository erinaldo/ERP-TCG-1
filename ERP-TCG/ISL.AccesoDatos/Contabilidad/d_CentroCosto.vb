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

Public Class d_CentroCosto

    'Private oeCentroCosto As e_CentroCosto
    Private sqlhelper As New SqlHelper
    Private odCCUbicaciones As New d_CentroCostoUbicaciones

    Public Function Cargar(ByVal o_fila As DataRow) As e_CentroCosto
        Try
            Dim oeCentroCosto = New e_CentroCosto(o_fila("Id").ToString _
                 , o_fila("Codigo").ToString _
                 , o_fila("Nombre").ToString _
                 , o_fila("Abreviatura").ToString _
                 , o_fila("UsuarioCreacion").ToString _
                 , o_fila("FechaCreacion").ToString _
                 , o_fila("IdArea").ToString _
                 , o_fila("IdVehiculo").ToString _
                 , o_fila("IdCentro").ToString _
                 , o_fila("IndActivoFijo").ToString _
                 , o_fila("IndDiario").ToString _
                 , o_fila("IndCompra").ToString _
                 , o_fila("IndVenta").ToString _
                 , o_fila("Vehiculo").ToString)
            Return oeCentroCosto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCentroCosto As e_CentroCosto) As e_CentroCosto
        Try
            Dim ds As DataSet
            With oeCentroCosto
                ds = sqlhelper.ExecuteDataset("CON.Isp_CentroCosto_Listar", _
                                                .TipoOperacion, _
                                                .Id, _
                                                .IdArea, _
                                                .IdVehiculo, _
                                                .Codigo, _
                                                .Nombre)
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeCentroCosto = Cargar(ds.Tables(0).Rows(0))
            Else
                oeCentroCosto = New e_CentroCosto
            End If
            Return oeCentroCosto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCentroCosto As e_CentroCosto) As List(Of e_CentroCosto)
        Try
            Dim olTipoMantenimiento As New List(Of e_CentroCosto)
            Dim ds As DataSet
            With oeCentroCosto
                ds = sqlhelper.ExecuteDataset("[CON].[Isp_CentroCosto_Listar]", _
                                                .TipoOperacion, _
                                                .Id, _
                                                .Codigo, _
                                                .Nombre, _
                                                .IdArea, _
                                                .IdVehiculo, _
                                                .IdCentro, _
                                                .IndActivoFijo, _
                                                .IndDiario, _
                                                .IndCompra, _
                                                .IndVenta)
            End With
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCentroCosto = Cargar(o_Fila)
                    olTipoMantenimiento.Add(oeCentroCosto)
                Next
            End If
            Return olTipoMantenimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCentroCosto As e_CentroCosto) As Boolean
        Dim stResultado() As String
        Try
            Using transScope As New TransactionScope()
                With oeCentroCosto
                    stResultado = sqlhelper.ExecuteScalar("CON.Isp_CentroCosto_IAE", _
                                            .TipoOperacion, _
                                            .PrefijoID, _
                                            .Id, _
                                            .Codigo, _
                                            .Nombre, _
                                            .Abreviatura, _
                                            .IdArea, _
                                            .IdVehiculo, _
                                            .IdCentro, _
                                            .IndActivoFijo, _
                                            .IndDiario, _
                                            .IndCompra, _
                                            .IndVenta, _
                                            .UsuarioCreacion).ToString.Split("_")

                    If .ListUbicaciones.Count > 0 Then
                        For Each Ubicaciones As e_CentroCostoUbicaciones In .ListUbicaciones
                            Ubicaciones.TipoOperacion = "I"
                            Ubicaciones.IdCentroCosto = stResultado(0)
                            Ubicaciones.UsuarioCreacion = .UsuarioCreacion
                            Ubicaciones.PrefijoID = oeCentroCosto.PrefijoID '@0001
                            odCCUbicaciones.Guardar(Ubicaciones)
                        Next
                    End If
                End With
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeCentroCosto As e_CentroCosto) As Boolean
        Try
            With oeCentroCosto
                sqlhelper.ExecuteNonQuery("CON.Isp_CentroCosto_IAE", "E", _
                                          "", _
                                          .Id, _
                                          .Codigo, _
                                            .Nombre, _
                                            .Abreviatura, _
                                            .IdArea, _
                                            .IdVehiculo, _
                                            .IdCentro, _
                                            .IndActivoFijo, _
                                            .IndDiario, _
                                            .IndCompra, _
                                            .IndVenta, _
                                            .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ComboGrilla(ByVal oeCentroCosto As e_CentroCosto)
        Dim ds = New DataTable
        ds.Columns.Add("Id")
        ds.Columns.Add("Nombre")
        For Each item As e_CentroCosto In Listar(oeCentroCosto)
            Dim newRow As DataRow = ds.NewRow()
            newRow("Id") = item.Id
            newRow("Nombre") = item.Nombre
            ds.Rows.Add(newRow)
        Next
        Return ds
    End Function
End Class
