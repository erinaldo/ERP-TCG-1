Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ControlVehiculoES
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_ControlVehiculoES
        Try
            Dim oeControlVehiculoES = New e_ControlVehiculoES( _
                             o_Fila("Id").ToString _
                             , o_Fila("Ingreso").ToString _
                             , o_Fila("Salida").ToString _
                             , o_Fila("Placa").ToString _
                             , o_Fila("IndIsl").ToString _
                             , o_Fila("FechaCreacion").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
                             , o_Fila("Activo").ToString _
            )
            Return oeControlVehiculoES
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeControlVehiculoES As e_ControlVehiculoES) As e_ControlVehiculoES

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", oeControlVehiculoES.Id)
            If ds.Tables.Count > 0 Then
                oeControlVehiculoES = Cargar(ds.Tables(0).Rows(0))
                Return oeControlVehiculoES
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeControlVehiculoES As e_ControlVehiculoES) As List(Of e_ControlVehiculoES)
        Try
            Dim ldControlVehiculoES As New List(Of e_ControlVehiculoES)
            Dim ds As DataSet
            With oeControlVehiculoES
                ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "" _
                        , .Id _
                        , .Ingreso _
                        , .Salida _
                        , .Placa _
                        , .IndIsl _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeControlVehiculoES = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeControlVehiculoES = Cargar(o_Fila)
                    ldControlVehiculoES.Add(oeControlVehiculoES)
                Next
                Return ldControlVehiculoES
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeControlVehiculoES As e_ControlVehiculoES) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeControlVehiculoES
                SqlHelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .Ingreso _
                        , .Salida _
                        , .Placa _
                        , .IndIsl _
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

    Public Function GuardarLista(ByVal lstControlVehiculoES As List(Of e_ControlVehiculoES)) As Boolean
        Try
            For Each obj As e_ControlVehiculoES In lstControlVehiculoES
                Guardar(obj)
            Next
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeControlVehiculoES As e_ControlVehiculoES) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeControlVehiculoES.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
