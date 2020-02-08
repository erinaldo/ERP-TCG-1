Imports ERP.EntidadesWCF
Public Class d_ComprobantePagoElectronico_Resumen
    Private SQL As New SqlHelper
    Private DS As New DataSet
    Public Function Obtener(ByVal Item As e_ComprobantePagoElectronico_Resumen) As e_ComprobantePagoElectronico_Resumen
        Try
            Dim ds As DataSet = ExecuteLST(Item)
            If ds.Tables(0).Rows.Count > 0 Then
                Item = Cargar(ds.Tables(0).Rows(0))
            End If
            Return Item
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal item As e_ComprobantePagoElectronico_Resumen) As List(Of e_ComprobantePagoElectronico_Resumen)
        Try
            Dim ldComprobantePagoElectronico_Resumen As New List(Of e_ComprobantePagoElectronico_Resumen)
            Dim ds As DataSet = ExecuteLST(item)
            item = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    item = Cargar(o_Fila)
                    ldComprobantePagoElectronico_Resumen.Add(item)
                Next
            End If
            Return ldComprobantePagoElectronico_Resumen
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal Item As e_ComprobantePagoElectronico_Resumen) As e_ComprobantePagoElectronico_Resumen
        Try
            'Using transScope As New TransactionScope()
            Dim stResultado() As String
            With Item
                stResultado = SQL.ExecuteScalar("[CON].[Isp_ComprobantePagoElectronico_Resumen_IAE]" _
                        , .TipoOperacion _
                        , .PrefijoID _
                        , .Id _
                        , .IdEmpresaSis _
                        , .TipoResumen _
                        , .FechaResumen _
                        , .FechaDocumentos _
                        , .Correlativo _
                        , .Ticket _
                        , .Hash_RSA _
                        , .Rpta_Sunat _
                        , .Ruta_XML _
                        , .IdEstado _
                        , .UsuarioCrea _
                        , .FechaCrea _
                        , .UsuarioModifica _
                        , .FechaModifica _
                        , .Activo
                    ).ToString.Split("_")
                .Id = stResultado(0)
            End With
            'transScope.Complete()
            'End Using
            Return Item
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal Item As e_ComprobantePagoElectronico_Resumen) As Boolean
        Try
            With Item
                SQL.ExecuteNonQuery("[CON].[ComprobantePagoElectronico_Resumen_IAE]" _
                       , "E" _
                       , "" _
                       , .Id _
                       , .IdEmpresaSis _
                       , .TipoResumen _
                       , .FechaResumen _
                       , .FechaDocumentos _
                       , .Correlativo _
                       , .Ticket _
                       , .Hash_RSA _
                       , .Rpta_Sunat _
                       , .Ruta_XML _
                       , .IdEstado _
                       , .UsuarioCrea _
                       , .FechaCrea _
                       , .UsuarioModifica _
                       , .FechaModifica _
                       , .Activo
                   )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#Region "Operaciones Basicas"

    Private Function Cargar(ByVal o_fila As DataRow) As e_ComprobantePagoElectronico_Resumen
        Try
            Dim Item = New e_ComprobantePagoElectronico_Resumen(
                             o_fila("Id").ToString _
                             , o_fila("IdEmpresaSis").ToString _
                             , o_fila("TipoResumen").ToString _
                             , o_fila("FechaResumen").ToString _
                             , o_fila("FechaDocumentos").ToString _
                             , o_fila("Correlativo").ToString _
                             , o_fila("Ticket").ToString _
                             , o_fila("Hash_RSA").ToString _
                             , o_fila("Rpta_Sunat").ToString _
                             , o_fila("Ruta_XML").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("UsuarioCrea").ToString _
                             , o_fila("FechaCrea").ToString _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("FechaModifica").ToString _
                             , o_fila("Activo").ToString
            )
            Return Item
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ExecuteLST(ByVal Item As e_ComprobantePagoElectronico_Resumen) As DataSet
        Try
            Dim ds As DataSet
            With Item
                ds = SQL.ExecuteDataset("[CON].[Isp_ComprobantePagoElectronico_Resumen_Listar]" _
                        , .TipoOperacion _
                        , .IdEmpresaSis _
                        , .TipoResumen _
                        , .FechaResumen)
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

End Class
