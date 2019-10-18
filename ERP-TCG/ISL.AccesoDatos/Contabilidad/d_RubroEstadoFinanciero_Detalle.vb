'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_RubroEstadoFinanciero_Detalle
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_RubroEstadoFinanciero_Detalle
        Try
            Dim oeRubroEstadoFinanciero_Detalle = New e_RubroEstadoFinanciero_Detalle( _
                             o_fila("Id").ToString _
                             , o_fila("IdRubroEstadoFinanciero").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("Identificador").ToString _
                             , o_fila("Nivel").ToString _
                             , o_fila("Linea").ToString _
                             , o_fila("Superior").ToString _
                             , o_fila("IdDepende").ToString _
                             , o_fila("Depende").ToString _
                             , o_fila("IndTotal").ToString _
                             , o_fila("FechaCrea").ToString _
                             , o_fila("UsuarioCrea").ToString _
                             , o_fila("FechaModifica").ToString _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeRubroEstadoFinanciero_Detalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ExecuteLST(ByVal oeRubroEstadoFinanciero_Detalle As e_RubroEstadoFinanciero_Detalle) As DataSet
        Try
            Dim ds As DataSet
            With oeRubroEstadoFinanciero_Detalle
                ds = sqlhelper.ExecuteDataset("[CON].[Isp_RubroEstadoFinanciero_Detalle_Listar]" _
                        , .TipoOperacion _
                        , .Id _
                        , .IdRubroEstadoFinanciero _
                        , .Codigo _
                        , .Descripcion _
                        , .IdDepende _
                        , .IndTotal _
                        , .Activo _
                        )
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeRubroEstadoFinanciero_Detalle As e_RubroEstadoFinanciero_Detalle) As e_RubroEstadoFinanciero_Detalle
        Try
            Dim ds As DataSet = ExecuteLST(oeRubroEstadoFinanciero_Detalle)
            If ds.Tables(0).rows.Count > 0 Then
                oeRubroEstadoFinanciero_Detalle = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeRubroEstadoFinanciero_Detalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeRubroEstadoFinanciero_Detalle As e_RubroEstadoFinanciero_Detalle) As List(Of e_RubroEstadoFinanciero_Detalle)
        Try
            Dim ldRubroEstadoFinanciero_Detalle As New List(Of e_RubroEstadoFinanciero_Detalle)
            Dim ds As DataSet = ExecuteLST(oeRubroEstadoFinanciero_Detalle)
            oeRubroEstadoFinanciero_Detalle = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeRubroEstadoFinanciero_Detalle = Cargar(o_Fila)
                    ldRubroEstadoFinanciero_Detalle.Add(oeRubroEstadoFinanciero_Detalle)
                Next
            End If
            Return ldRubroEstadoFinanciero_Detalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeRubroEstadoFinanciero_Detalle As e_RubroEstadoFinanciero_Detalle) As Boolean
        Try
            'Using transScope As New TransactionScope()
            Dim stResultado() As String
            With oeRubroEstadoFinanciero_Detalle
                stResultado = sqlhelper.ExecuteScalar("[CON].[Isp_RubroEstadoFinanciero_Detalle_IAE]" _
                        , .TipoOperacion _
                        , .PrefijoID _
                        , .Id _
                        , .IdRubroEstadoFinanciero _
                        , .Codigo _
                        , .Descripcion _
                        , .Identificador _
                        , .Nivel _
                        , .Linea _
                        , .Superior _
                        , .IdDepende _
                        , .IndTotal _
                        , .FechaCrea _
                        , .UsuarioCrea _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                    ).ToString.Split("_")
                .Id = stResultado(0)
            End With
            'transScope.Complete()
            'End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeRubroEstadoFinanciero_Detalle As e_RubroEstadoFinanciero_Detalle) As Boolean
        Try
            'With oeRubroEstadoFinanciero_Detalle
            '    sqlhelper.ExecuteNonQuery("[CON].[Isp_RubroEstadoFinanciero_Detalle_IAE]" _
            '           , "E" _
            '           , "" _
            '           , .Id _
            '           , .IdRubroEstadoFinanciero _
            '           , .Codigo _
            '           , .Descripcion _
            '           , .IdDepende _
            '           , .IndTotal _
            '           , .FechaCrea _
            '           , .UsuarioCrea _
            '           , .FechaModifica _
            '           , .UsuarioModifica _
            '           , .Activo _
            '       )
            'End With

            With oeRubroEstadoFinanciero_Detalle
                sqlhelper.ExecuteNonQuery("[CON].[Isp_RubroEstadoFinanciero_Detalle_IAE]" _
                      , "E" _
                        , "" _
                        , .Id _
                        , .IdRubroEstadoFinanciero _
                        , .Codigo _
                        , .Descripcion _
                        , .Identificador _
                        , .Nivel _
                        , .Linea _
                        , .Superior _
                        , .IdDepende _
                        , .IndTotal _
                        , .FechaCrea _
                        , .UsuarioCrea _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                   )
            End With

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
