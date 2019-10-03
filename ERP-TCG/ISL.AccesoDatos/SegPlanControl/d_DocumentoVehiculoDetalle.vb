Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_DocumentoVehiculoDetalle
    Private sqlhelper As New SqlHelper


    Private Function Cargar(ByVal o_fila As DataRow) As e_DocumentoVehiculoDetalle
        Try
            Dim oeDocumentoVehiculoDetalle = New e_DocumentoVehiculoDetalle()
            oeDocumentoVehiculoDetalle.Id = o_fila("Id").ToString.Trim
            oeDocumentoVehiculoDetalle.Codigo = o_fila("Codigo").ToString.Trim
            oeDocumentoVehiculoDetalle.IdTipoDocumento = o_fila("IdTipoDocumento").ToString.Trim
            oeDocumentoVehiculoDetalle.TipoDocumento = o_fila("TipoDocumento").ToString.Trim
            oeDocumentoVehiculoDetalle.IdDocumento = o_fila("IdDocumento").ToString.Trim
            oeDocumentoVehiculoDetalle.IdCliente = o_fila("IdCliente").ToString.Trim
            oeDocumentoVehiculoDetalle.Cliente = o_fila("Cliente").ToString.Trim
            oeDocumentoVehiculoDetalle.IdMaterial = o_fila("IdMaterial").ToString.Trim
            oeDocumentoVehiculoDetalle.Material = o_fila("Material").ToString.Trim
            oeDocumentoVehiculoDetalle.IndTodosCliente = o_fila("IndTodosCliente").ToString.Trim
            oeDocumentoVehiculoDetalle.IndTodosMaterial = o_fila("IndTodosMaterial").ToString.Trim
            oeDocumentoVehiculoDetalle.FechaCreacion = o_fila("FechaCreacion").ToString.Trim
            oeDocumentoVehiculoDetalle.UsuarioCreacion = o_fila("UsuarioCreacion").ToString.Trim
            oeDocumentoVehiculoDetalle.Activo = o_fila("Activo").ToString.Trim
            oeDocumentoVehiculoDetalle.FechaModifica = o_fila("FechaModifica").ToString.Trim
            oeDocumentoVehiculoDetalle.UsuarioModifica = o_fila("UsuarioModifica").ToString.Trim
            Return oeDocumentoVehiculoDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDocumentoVehiculoDetalle As e_DocumentoVehiculoDetalle) As e_DocumentoVehiculoDetalle
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SPC.Isp_DocumentoVehiculoDetalle_Listar", "O", oeDocumentoVehiculoDetalle.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeDocumentoVehiculoDetalle = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDocumentoVehiculoDetalle
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDocumentoVehiculoDetalle As e_DocumentoVehiculoDetalle) As List(Of e_DocumentoVehiculoDetalle)
        Try
            Dim ldDocumentoVehiculoDetalle As New List(Of e_DocumentoVehiculoDetalle)
            Dim ds As DataSet
            With oeDocumentoVehiculoDetalle
                ds = sqlhelper.ExecuteDataset("SPC.Isp_DocumentoVehiculoDetalle_Listar", .TipoOperacion _
                        , .Id _
                        , .Codigo _
                        , .IdTipoDocumento _
                        , .IdDocumento _
                        , .IdCliente _
                        , .IdMaterial _
                        , .FechaDesde _
                        , .FechaHasta _
                        )
            End With
            oeDocumentoVehiculoDetalle = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeDocumentoVehiculoDetalle = Cargar(o_Fila)
                ldDocumentoVehiculoDetalle.Add(oeDocumentoVehiculoDetalle)
            Next
            Return ldDocumentoVehiculoDetalle
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDocumentoVehiculoDetalle As e_DocumentoVehiculoDetalle) As Boolean
        Try
            Dim stResultado() As String
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeDocumentoVehiculoDetalle
                stResultado = sqlhelper.ExecuteScalar("SPC.Isp_DocumentoVehiculoDetalle_IAE", .TipoOperacion, .PrefijoID, _
                                                       .UsuarioCreacion _
                                                       , .Id _
                                                        , .Codigo _
                                                        , .IdTipoDocumento _
                                                        , .IdDocumento _
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

    Public Function Guardar(ByVal Lista As List(Of e_DocumentoVehiculoDetalle)) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            If Lista.Count < 1 Then Return True
            Using transScope As New TransactionScope()
                For Each item In Lista
                    sqlhelper.ExecuteNonQuery("SPC.Isp_DocumentoVehiculoDetalle_IAE", "T", _
                                          "", item.UsuarioCreacion, "", "", item.IdTipoDocumento, item.IdDocumento)
                Next
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

    Public Function Eliminar(ByVal oeDocumentoVehiculoDetalle As e_DocumentoVehiculoDetalle) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SPC.Isp_DocumentoVehiculoDetalle_IAE", "E", _
             "", oeDocumentoVehiculoDetalle.UsuarioCreacion, oeDocumentoVehiculoDetalle.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
