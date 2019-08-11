Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_PrioridadIncidencia
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_PrioridadIncidencia
        Try
            Dim oePrioridadIncidencia = New e_PrioridadIncidencia( _
                             o_Fila("Id").ToString _
                             , o_Fila("Nombre").ToString _
                             , o_Fila("Nivel").ToString _
                             , o_Fila("Activo").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
                             , o_Fila("FechaCreacion").ToString _
                             , o_Fila("FechaModifica").ToString _
                             , o_Fila("UsuarioModifica").ToString _
            )
            Return oePrioridadIncidencia
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oePrioridadIncidencia As e_PrioridadIncidencia) As e_PrioridadIncidencia

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SPC.Isp_PrioridadIncidencia_Listar", "", oePrioridadIncidencia.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oePrioridadIncidencia = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oePrioridadIncidencia
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oePrioridadIncidencia As e_PrioridadIncidencia) As List(Of e_PrioridadIncidencia)
        Try
            Dim ldPrioridadIncidencia As New List(Of e_PrioridadIncidencia)
            Dim ds As DataSet
            With oePrioridadIncidencia
                ds = sqlhelper.ExecuteDataset("SPC.Isp_PrioridadIncidencia_Listar", "" _
                        , .Id _
                        , .Nombre _
                        , .Nivel _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        )
            End With
            oePrioridadIncidencia = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oePrioridadIncidencia = Cargar(o_Fila)
                ldPrioridadIncidencia.Add(oePrioridadIncidencia)
            Next
            Return ldPrioridadIncidencia
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oePrioridadIncidencia As e_PrioridadIncidencia) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oePrioridadIncidencia
                sqlhelper.ExecuteNonQuery("SPC.Isp_PrioridadIncidencia_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .Nombre _
                        , .Nivel _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oePrioridadIncidencia As e_PrioridadIncidencia) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SPC.Isp_PrioridadIncidencia_IAE", "E", _
             "", oePrioridadIncidencia.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
