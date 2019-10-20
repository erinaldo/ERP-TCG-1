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

Public Class d_Gasto_Caja
    Private sqlhelper As New SqlHelper
    Private odGastoVehiculo As New d_GastoVehiculo

    Private Function Cargar(ByVal o_fila As DataRow) As e_Gasto_Caja
        Try
            Dim oeGasto_Caja = New e_Gasto_Caja( _
                             o_fila("id").ToString _
                             , o_fila("IdRuta").ToString _
                             , o_fila("IdPiloto").ToString _
                             , o_fila("UsuarioAutoriza").ToString _
                             , o_fila("CentroGasto").ToString _
                             , o_fila("IdTipoGasto").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeGasto_Caja
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeGasto_Caja As e_Gasto_Caja) As e_Gasto_Caja
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_Gasto_Caja_Listar", "", oeGasto_Caja.id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeGasto_Caja = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeGasto_Caja
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeGasto_Caja As e_Gasto_Caja) As List(Of e_Gasto_Caja)
        Try
            Dim ldGasto_Caja As New List(Of e_Gasto_Caja)
            Dim ds As DataSet
            With oeGasto_Caja
                ds = sqlhelper.ExecuteDataset("TES.Isp_Gasto_Caja_Listar", "" _
                        , .id _
                        , .IdRuta _
                        , .IdPiloto _
                        , .UsuarioAutoriza _
                        , .CentroGasto _
                        , .IdTipoGasto _
                        , .IdTrabajador _
                        , .Activo _
                        )
            End With
            oeGasto_Caja = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeGasto_Caja = Cargar(o_Fila)
                ldGasto_Caja.Add(oeGasto_Caja)
            Next
            Return ldGasto_Caja
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeGasto_Caja As e_Gasto_Caja) As Boolean
        Try
            Dim id As String = ""
            With oeGasto_Caja
                id = sqlhelper.ExecuteScalar("TES.Isp_Gasto_Caja_IAE", .TipoOperacion,
                        .id _
                        , .IdGastoOperacion _
                        , .IdRuta _
                        , .IdPiloto _
                        , .UsuarioAutoriza _
                        , .CentroGasto _
                        , .IdTipoGasto _
                        , .IdTrabajador _
                        , .IdPlaca _
                        , .Activo _
                        , .PrefijoID _
                        , .IndCompraAlmacen _
                        , .IdArea)
                For Each gasveh As e_GastoVehiculo In .loGastoVehiculo
                    gasveh.Id = ""
                    gasveh.TipoOperacion = "I"
                    gasveh.IdGastoCaja = id
                    gasveh.PrefijoID = oeGasto_Caja.PrefijoID '@0001
                    odGastoVehiculo.Guardar(gasveh)
                Next
            End With
            Return True
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

    Public Function Eliminar(ByVal oeGasto_Caja As e_Gasto_Caja) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_Gasto_Caja_IAE", "E", oeGasto_Caja.id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
