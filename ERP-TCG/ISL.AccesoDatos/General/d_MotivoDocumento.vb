'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF

Public Class d_MotivoDocumento
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_MotivoDocumento
        Try
            Dim oeMotivoDocumento = New e_MotivoDocumento( _
                             o_fila("Id").ToString _
                             , o_fila("IdTipoDocumento").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeMotivoDocumento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMotivoDocumento As e_MotivoDocumento) As e_MotivoDocumento
        Try
            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_MotivoDocumento_Listar", _
                                          oeMotivoDocumento.TipoOperacion, _
                                          oeMotivoDocumento.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeMotivoDocumento = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMotivoDocumento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeMotivoDocumento As e_MotivoDocumento) As List(Of e_MotivoDocumento)
        Try
            Dim ldMotivoDocumento As New List(Of e_MotivoDocumento)
            Dim ds As DataSet
            With oeMotivoDocumento
                ds = sqlhelper.ExecuteDataset("STD.Isp_MotivoDocumento_Listar", .TipoOperacion, _
                                              .Id _
                                            , .Codigo _
                                            , .Nombre _
                                            , .Activo _
                                            , .IdTipoDocumento)
            End With
            oeMotivoDocumento = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMotivoDocumento = Cargar(o_Fila)
                    ldMotivoDocumento.Add(oeMotivoDocumento)
                Next
            Else
                ldMotivoDocumento = New List(Of e_MotivoDocumento)
            End If
            Return ldMotivoDocumento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMotivoDocumento As e_MotivoDocumento) As Boolean
        Try
            With oeMotivoDocumento
                sqlhelper.ExecuteNonQuery("STD.Isp_MotivoDocumento_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdTipoDocumento _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeMotivoDocumento As e_MotivoDocumento) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeMotivoDocumento.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function ComboGrilla(ByVal ListaMotivoDocumento As List(Of e_MotivoDocumento))
        Dim ds = New DataTable
        ds.Columns.Add("Id")
        ds.Columns.Add("Nombre")
        For Each item As e_MotivoDocumento In ListaMotivoDocumento
            Dim newRow As DataRow = ds.NewRow()
            newRow("Id") = item.Id
            newRow("Nombre") = item.Nombre
            ds.Rows.Add(newRow)
        Next
        Return ds
    End Function

End Class