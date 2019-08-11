Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_DetallePagoCajaTrabajador
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_DetallePagoCajaTrabajador
        Try
            Dim oeDetallePagoCajaTrabajador = New e_DetallePagoCajaTrabajador( _
                             o_fila("Id").ToString _
                             , o_fila("IdPagoCajaTrabajador").ToString _
                             , o_fila("IdPlanilla").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Dni").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("IndTipo") _
                             , o_fila("Monto") _
                             , o_fila("Redondeo") _
                             , o_fila("TotalPagar") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo") _
            )
            oeDetallePagoCajaTrabajador.Tipo = o_fila("Tipo").ToString
            Return oeDetallePagoCajaTrabajador
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetallePagoCajaTrabajador As e_DetallePagoCajaTrabajador) As e_DetallePagoCajaTrabajador

        Try
            Dim ds As DataSet
            With oeDetallePagoCajaTrabajador
                ds = sqlhelper.ExecuteDataset("PER.Isp_DetallePagoCajaTrabajador_Listar", .TipoOperacion, .Id)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeDetallePagoCajaTrabajador = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDetallePagoCajaTrabajador
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetallePagoCajaTrabajador As e_DetallePagoCajaTrabajador) As List(Of e_DetallePagoCajaTrabajador)
        Try
            Dim ldDetallePagoCajaTrabajador As New List(Of e_DetallePagoCajaTrabajador)
            Dim ds As DataSet
            With oeDetallePagoCajaTrabajador
                ds = sqlhelper.ExecuteDataset("PER.Isp_DetallePagoCajaTrabajador_Listar", .TipoOperacion _
                        , .Id _
                        , .IdPagoCajaTrabajador _
                        , .IdTrabajador _
                        , .IndTipo _
                        , .Monto _
                        , .Redondeo _
                        , .TotalPagar _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                        )
            End With
            oeDetallePagoCajaTrabajador = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeDetallePagoCajaTrabajador = Cargar(o_Fila)
                ldDetallePagoCajaTrabajador.Add(oeDetallePagoCajaTrabajador)
            Next
            Return ldDetallePagoCajaTrabajador
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetallePagoCajaTrabajador As e_DetallePagoCajaTrabajador) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeDetallePagoCajaTrabajador
                sqlhelper.ExecuteNonQuery("PER.Isp_DetallePagoCajaTrabajador_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdPagoCajaTrabajador _
                        , .IdTrabajador _
                        , .IndTipo _
                        , .Monto _
                        , .Redondeo _
                        , .TotalPagar _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarMasivo(ByVal dtDetPA As DataTable) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            sqlhelper.InsertarMasivo("PER.DetallePagoCajaTrabajador", dtDetPA)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetallePagoCajaTrabajador As e_DetallePagoCajaTrabajador) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_DetallePagoCajaTrabajador_IAE", "E", _
             "", oeDetallePagoCajaTrabajador.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function UltimoIdInserta() As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "PER.DetallePagoCajaTrabajador", d_DatosConfiguracion.PrefijoID _
                                  )
            Return stResultado
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function
End Class
