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

Public Class d_TipoMantenimiento
    Private sqlhelper As New SqlHelper

    Private oetipoMantenimiento As e_TipoMantenimiento

    Private Function Cargar(ByVal o_fila As DataRow) As e_TipoMantenimiento
        Try
            Dim oeTipoMantenimiento = New e_TipoMantenimiento( _
            o_fila("Id"), o_fila("Codigo"), o_fila("Nombre"), o_fila("Abreviatura"), _
            o_fila("Descripcion"), o_fila("Activo"))
            Return oeTipoMantenimiento
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function Obtener(ByVal oeTipoMantenimiento As e_TipoMantenimiento) As e_TipoMantenimiento
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("MAN.ISP_TipoMantenimiento_Listar", "", oeTipoMantenimiento.Id)
            If ds.Tables.Count > 0 Then
                oetipoMantenimiento = Cargar(ds.Tables(0).Rows(0))
                Return oetipoMantenimiento
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoMantenimiento As e_TipoMantenimiento) As List(Of e_TipoMantenimiento)
        Try
            Dim ldTipoMantenimiento As New List(Of e_TipoMantenimiento)
            Dim ds As DataSet
            With oeTipoMantenimiento
                ds = sqlhelper.ExecuteDataset("MAN.ISP_TipoMantenimiento_Listar", "", .Id, .Codigo, _
                        .Nombre, .Abreviatura, .Descripcion, .Activo)
            End With
            oeTipoMantenimiento = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTipoMantenimiento = Cargar(o_Fila)
                    ldTipoMantenimiento.Add(oeTipoMantenimiento)
                Next
            End If
            Return ldTipoMantenimiento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoMantenimiento As e_TipoMantenimiento) As Boolean

        Try
            With oeTipoMantenimiento
                sqlhelper.ExecuteNonQuery("MAN.Isp_TipoMantenimiento_IAE", .TipoOperacion,
                .PrefijoID, .Id, .Codigo, .Nombre, .Abreviatura,
                .Descripcion, .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeTipoMantenimiento As e_TipoMantenimiento) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("MAN.Isp_TipoMantenimiento_IAE", "E", "", _
                                      oeTipoMantenimiento.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
