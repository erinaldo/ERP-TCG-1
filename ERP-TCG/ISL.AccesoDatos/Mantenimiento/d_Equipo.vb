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

Public Class d_Equipo

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Equipo
        Try
            Dim oeEquipo = New e_Equipo( _
                              o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("IdTipoEquipo").ToString _
                             , o_fila("Tipo Equipo").ToString _
                             , o_fila("IdMarca").ToString _
                             , o_fila("Marca").ToString _
                             , o_fila("IdModelo").ToString _
                             , o_fila("Modelo").ToString _
                             , o_fila("IdVehiculo").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("Activo") _
                             )
            Return oeEquipo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeEquipo As e_Equipo) As e_Equipo
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("MAN.Isp_Equipo_Listar", oeEquipo.TipoOperacion, oeEquipo.Id, oeEquipo.Nombre)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeEquipo = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeEquipo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeEquipo As e_Equipo) As List(Of e_Equipo)
        Try
            Dim ldEquipo As New List(Of e_Equipo)
            Dim ds As DataSet
            With oeEquipo
                ds = sqlhelper.ExecuteDataset("MAN.Isp_Equipo_Listar", .TipoOperacion _
                        , .Id _
                         , .Nombre _
                        , .Codigo _
                        , .IdTipoEquipo _
                        , .IdMarca _
                        , .IdModelo _
                        , .IdVehiculo _
                        , .Activo _
                        , .Descripcion)
            End With
            oeEquipo = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeEquipo = Cargar(o_Fila)
                    ldEquipo.Add(oeEquipo)
                Next
            End If
            Return ldEquipo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeEquipo As e_Equipo) As Boolean
        Try
            With oeEquipo
                sqlhelper.ExecuteNonQuery("MAN.Isp_Equipo_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .Codigo _
                        , .Nombre _
                        , .IdTipoEquipo _
                        , .IdMarca _
                        , .IdModelo _
                        , .IdVehiculo _
                        , .Activo _
                        , .Descripcion _
                        , .UsuarioCreacion
                        )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeEquipo As e_Equipo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("MAN.Isp_Equipo_IAE", "E", _
             "", oeEquipo.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
