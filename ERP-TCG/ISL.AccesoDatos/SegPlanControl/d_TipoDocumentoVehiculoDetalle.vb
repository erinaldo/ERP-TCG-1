Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_TipoDocumentoVehiculoDetalle
    Private sqlhelper As New SqlHelper


    Private Function Cargar(ByVal o_fila As DataRow) As e_TipoDocumentoVehiculoDetalle
        Try
            Dim oeTipoDocumentoVehiculoDetalle = New e_TipoDocumentoVehiculoDetalle()
            oeTipoDocumentoVehiculoDetalle.Id = o_fila("Id").ToString.Trim
            oeTipoDocumentoVehiculoDetalle.Codigo = o_fila("Codigo").ToString.Trim
            oeTipoDocumentoVehiculoDetalle.IdTipoDocumento = o_fila("IdTipoDocumento").ToString.Trim
            oeTipoDocumentoVehiculoDetalle.TipoDocumento = o_fila("TipoDocumento").ToString.Trim
            oeTipoDocumentoVehiculoDetalle.IdCliente = o_fila("IdCliente").ToString.Trim
            oeTipoDocumentoVehiculoDetalle.Cliente = o_fila("Cliente").ToString.Trim
            oeTipoDocumentoVehiculoDetalle.IdMaterial = o_fila("IdMaterial").ToString.Trim
            oeTipoDocumentoVehiculoDetalle.Material = o_fila("Material").ToString.Trim
            oeTipoDocumentoVehiculoDetalle.IndTodosCliente = o_fila("IndTodosCliente").ToString.Trim
            oeTipoDocumentoVehiculoDetalle.IndTodosMaterial = o_fila("IndTodosMaterial").ToString.Trim
            oeTipoDocumentoVehiculoDetalle.FechaCreacion = o_fila("FechaCreacion").ToString.Trim
            oeTipoDocumentoVehiculoDetalle.UsuarioCreacion = o_fila("UsuarioCreacion").ToString.Trim
            oeTipoDocumentoVehiculoDetalle.Activo = o_fila("Activo").ToString.Trim
            oeTipoDocumentoVehiculoDetalle.FechaModifica = o_fila("FechaModifica").ToString.Trim
            oeTipoDocumentoVehiculoDetalle.UsuarioModifica = o_fila("UsuarioModifica").ToString.Trim
            Return oeTipoDocumentoVehiculoDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoDocumentoVehiculoDetalle As e_TipoDocumentoVehiculoDetalle) As e_TipoDocumentoVehiculoDetalle
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SPC.Isp_TipoDocumentoVehiculoDetalle_Listar", "O", oeTipoDocumentoVehiculoDetalle.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeTipoDocumentoVehiculoDetalle = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeTipoDocumentoVehiculoDetalle
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoDocumentoVehiculoDetalle As e_TipoDocumentoVehiculoDetalle) As List(Of e_TipoDocumentoVehiculoDetalle)
        Try
            Dim ldTipoDocumentoVehiculoDetalle As New List(Of e_TipoDocumentoVehiculoDetalle)
            Dim ds As DataSet
            With oeTipoDocumentoVehiculoDetalle
                ds = sqlhelper.ExecuteDataset("SPC.Isp_TipoDocumentoVehiculoDetalle_Listar", .TipoOperacion _
                        , .Id _
                        , .Codigo _
                        , .IdTipoDocumento _
                        , .IdCliente _
                        , .IdMaterial _
                        , .FechaDesde _
                        , .FechaHasta _
                        )
            End With
            oeTipoDocumentoVehiculoDetalle = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeTipoDocumentoVehiculoDetalle = Cargar(o_Fila)
                ldTipoDocumentoVehiculoDetalle.Add(oeTipoDocumentoVehiculoDetalle)
            Next
            Return ldTipoDocumentoVehiculoDetalle
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoDocumentoVehiculoDetalle As e_TipoDocumentoVehiculoDetalle) As Boolean
        Try
            Dim stResultado() As String
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeTipoDocumentoVehiculoDetalle
                stResultado = sqlhelper.ExecuteScalar("SPC.Isp_TipoDocumentoVehiculoDetalle_IAE", .TipoOperacion, .PrefijoID, _
                                                       .UsuarioCreacion _
                                                       , .Id _
                                                        , .Codigo _
                                                        , .IdTipoDocumento _
                                                        , .IdCliente _
                                                        , .IdMaterial _
                                                        , .IndTodosCliente _
                                                        , .IndTodosMaterial _
                                                    ).ToString.Split("_")
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Guardar(ByVal Lista As List(Of e_TipoDocumentoVehiculoDetalle)) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            If Lista.Count < 1 Then Return True
            Using transScope As New TransactionScope()
                sqlhelper.ExecuteNonQuery("SPC.Isp_TipoDocumentoVehiculoDetalle_IAE", "T", _
                                          "", Lista(0).UsuarioCreacion, "", "", Lista(0).IdTipoDocumento)

                For Each item In Lista
                    Guardar(item)
                Next
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeTipoDocumentoVehiculoDetalle As e_TipoDocumentoVehiculoDetalle) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SPC.Isp_TipoDocumentoVehiculoDetalle_IAE", "E", _
             "", oeTipoDocumentoVehiculoDetalle.UsuarioCreacion, oeTipoDocumentoVehiculoDetalle.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function



End Class
