Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_OrdenAprobacion
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_OrdenAprobacion
        Try
            Dim oeOrdenAprobacion = New e_OrdenAprobacion( _
                             o_fila("Id").ToString _
                             , o_fila("IdOrden").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("FechaAprobacion").ToString _
                             , o_fila("IndAprobacion").ToString _
                             , o_fila("IndBloqueo").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString)
            Return oeOrdenAprobacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeOrdenAprobacion As e_OrdenAprobacion) As e_OrdenAprobacion
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CMP.Isp_OrdenAprobacion_Listar", "", oeOrdenAprobacion.Id, oeOrdenAprobacion.IdOrden)
            If ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0 Then
                oeOrdenAprobacion = Cargar(ds.Tables(0).Rows(0))
                Return oeOrdenAprobacion
            Else
                Return oeOrdenAprobacion
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOrdenAprobacion As e_OrdenAprobacion) As List(Of e_OrdenAprobacion)
        Try
            Dim ldOrdenAprobacion As New List(Of e_OrdenAprobacion)
            Dim ds As DataSet
            With oeOrdenAprobacion
                ds = sqlhelper.ExecuteDataset("CMP.Isp_OrdenAprobacion_Listar", "" _
                        , .Id _
                        , .IdOrden _
                        , .IdTrabajador _
                        , .FechaAprobacion _
                        , .IndAprobacion _
                        , .IndBloqueo _
                        , .Activo _
                        , .UsuarioCreacion)
            End With
            oeOrdenAprobacion = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeOrdenAprobacion = Cargar(o_Fila)
                    ldOrdenAprobacion.Add(oeOrdenAprobacion)
                Next
                Return ldOrdenAprobacion
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOrdenAprobacion As e_OrdenAprobacion) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeOrdenAprobacion
                sqlhelper.ExecuteNonQuery("CMP.Isp_OrdenAprobacion_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdOrden _
                        , .IdTrabajador _
                        , .FechaAprobacion _
                        , .IndAprobacion _
                        , .IndBloqueo _
                        , .Activo _
                        , .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeOrdenAprobacion As e_OrdenAprobacion) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CMP.Isp_OrdenAprobacion_IAE", "E", _
             "", oeOrdenAprobacion.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class

