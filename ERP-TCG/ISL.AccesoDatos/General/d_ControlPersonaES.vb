Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ControlPersonaES
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_ControlPersonaES
        Try
            Dim oeControlPersonaES = New e_ControlPersonaES( _
                             o_Fila("Id").ToString _
                             , o_Fila("Ingreso").ToString _
                             , o_Fila("Salida").ToString _
                             , o_Fila("DNI").ToString _
                             , o_Fila("Nombre").ToString _
                             , o_Fila("IndTrabajador").ToString _
                             , o_Fila("FechaCreacion").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
                             , o_Fila("Activo").ToString _
            )
            Return oeControlPersonaES
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeControlPersonaES As e_ControlPersonaES) As e_ControlPersonaES

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", oeControlPersonaES.Id)
            If ds.Tables.Count > 0 Then
                oeControlPersonaES = Cargar(ds.Tables(0).Rows(0))
                Return oeControlPersonaES
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeControlPersonaES As e_ControlPersonaES) As List(Of e_ControlPersonaES)
        Try
            Dim ldControlPersonaES As New List(Of e_ControlPersonaES)
            Dim ds As DataSet
            With oeControlPersonaES
                ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "" _
                        , .Id _
                        , .Ingreso _
                        , .Salida _
                        , .DNI _
                        , .Nombre _
                        , .IndTrabajador _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeControlPersonaES = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeControlPersonaES = Cargar(o_Fila)
                    ldControlPersonaES.Add(oeControlPersonaES)
                Next
                Return ldControlPersonaES
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeControlPersonaES As e_ControlPersonaES) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeControlPersonaES
                SqlHelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .Ingreso _
                        , .Salida _
                        , .DNI _
                        , .Nombre _
                        , .IndTrabajador _
                        , .FechaCreacion _
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

    Public Function Eliminar(ByVal oeControlPersonaES As e_ControlPersonaES) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeControlPersonaES.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
