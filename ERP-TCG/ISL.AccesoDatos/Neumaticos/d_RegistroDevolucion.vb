Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_RegistroDevolucion
    Private sqlhelper As New SqlHelper
    Private odDetalleRD As New d_DetalleRegistroDevolucion
    Private oeDetalleRD As New e_DetalleRegistroDevolucion

    Private Function Cargar(ByVal o_fila As DataRow) As e_RegistroDevolucion
        Try
            Dim oeRegistroDevolucion = New e_RegistroDevolucion( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("TipoOperacion").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("IdClienteProveedor").ToString _
                             , o_fila("ClienteProveedor").ToString _
                             , o_fila("IdResponsable").ToString _
                             , o_fila("Responsable").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeRegistroDevolucion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeRegistroDevolucion As e_RegistroDevolucion) As e_RegistroDevolucion

        Try
            Dim ds As DataSet
            With oeRegistroDevolucion
                ds = sqlhelper.ExecuteDataset("NEU.Isp_RegistroDevolucion_Listar", .TipoOperacion, .Id, .Codigo, .Fecha, .Tipo)
            End With

            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeRegistroDevolucion = Cargar(ds.Tables(0).Rows(0))
                oeDetalleRD = New e_DetalleRegistroDevolucion
                oeDetalleRD.TipoOperacion = String.Empty
                oeDetalleRD.IdRegistroDevolucion = oeRegistroDevolucion.Id
                oeRegistroDevolucion.leDetalleRD = odDetalleRD.Listar(oeDetalleRD)
            End If

            Return oeRegistroDevolucion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeRegistroDevolucion As e_RegistroDevolucion) As List(Of e_RegistroDevolucion)
        Try
            Dim ldRegistroDevolucion As New List(Of e_RegistroDevolucion)
            Dim ds As DataSet
            With oeRegistroDevolucion
                ds = sqlhelper.ExecuteDataset("NEU.Isp_RegistroDevolucion_Listar", .TipoOperacion _
                        , .Id _
                        , .Codigo _
                        , .Fecha _
                        , .Tipo _
                        , .IdEstado _
                        , .IdClienteProveedor _
                        , .IdResponsable _
                        , .Descripcion _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeRegistroDevolucion = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeRegistroDevolucion = Cargar(o_Fila)
                ldRegistroDevolucion.Add(oeRegistroDevolucion)
            Next
            Return ldRegistroDevolucion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeRegistroDevolucion As e_RegistroDevolucion) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim _id As String
            Using TransScope As New TransactionScope()
                With oeRegistroDevolucion
                    _id = sqlhelper.ExecuteScalar("NEU.Isp_RegistroDevolucion_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                            .Id _
                            , .Codigo _
                            , .Fecha _
                            , .Tipo _
                            , .IdEstado _
                            , .IdClienteProveedor _
                            , .IdResponsable _
                            , .Descripcion _
                            , .FechaCreacion _
                            , .UsuarioCreacion _
                            , .Activo _
                        )

                    .Id = _id

                    For Each oeDetalle In .leDetalleRD
                        oeDetalle.IdRegistroDevolucion = .Id
                        oeDetalle.UsuarioCreacion = .UsuarioCreacion
                        oeDetalle.TipoOperacion = IIf(oeDetalle.Id <> "", "A", "I")
                        odDetalleRD.Guardar(oeDetalle)
                    Next

                End With
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeRegistroDevolucion As e_RegistroDevolucion) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("NEU.Isp_RegistroDevolucion_IAE", "E", _
             "", oeRegistroDevolucion.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
