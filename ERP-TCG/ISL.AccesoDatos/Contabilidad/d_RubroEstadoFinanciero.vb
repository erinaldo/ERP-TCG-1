Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_RubroEstadoFinanciero
    Private sqlhelper As New SqlHelper
    Private d_DatosConfiguracion As New d_DatosConfiguracion
    Private oeDetalle As e_RubroEstadoFinanciero_Detalle, odDetalle As New d_RubroEstadoFinanciero_Detalle
    Private oeCuenta As e_RubroEEFFDetalle_CuentaContable, odCuenta As New d_RubroEEFFDetalle_CuentaContable

    Private Function Cargar(ByVal o_fila As DataRow) As e_RubroEstadoFinanciero
        Try
            Dim oeRubroEstadoFinanciero = New e_RubroEstadoFinanciero( _
                             o_Fila("Id").ToString _
                             , o_Fila("Codigo").ToString _
                             , o_Fila("NroRegistro").ToString _
                             , o_Fila("Nombre").ToString _
                             , o_Fila("EstructuraArchivo").ToString _
                             , o_Fila("FechaCrea").ToString _
                             , o_Fila("UsuarioCrea").ToString _
                             , o_Fila("FechaModifica").ToString _
                             , o_Fila("UsuarioModifica").ToString _
                             , o_Fila("Activo").ToString _
            )
            Return oeRubroEstadoFinanciero
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ExecuteLST(ByVal oeRubroEstadoFinanciero As e_RubroEstadoFinanciero) As DataSet
        Try
            Dim ds As DataSet
            With oeRubroEstadoFinanciero
                ds = sqlhelper.ExecuteDataset("[CON].[Isp_RubroEstadoFinanciero_Listar]" _
                        , .TipoOperacion _
                        , .Id _
                        , .Codigo _
                        , .NroRegistro _
                        , .Nombre _
                        , .EstructuraArchivo _
                        , .Activo _
                        )
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeRubroEstadoFinanciero As e_RubroEstadoFinanciero) As e_RubroEstadoFinanciero
        Try
            Dim ds As DataSet = ExecuteLST(oeRubroEstadoFinanciero)
            Dim IndCargar As Boolean = oeRubroEstadoFinanciero.CargaCompleta
            If ds.Tables(0).rows.Count > 0 Then
                oeRubroEstadoFinanciero = Cargar(ds.Tables(0).Rows(0))
                oeRubroEstadoFinanciero.leDetalle = New List(Of e_RubroEstadoFinanciero_Detalle)
                oeRubroEstadoFinanciero.leCuenta = New List(Of e_RubroEEFFDetalle_CuentaContable)
                If IndCargar Then
                    oeDetalle = New e_RubroEstadoFinanciero_Detalle
                    oeDetalle.IdRubroEstadoFinanciero = oeRubroEstadoFinanciero.Id
                    oeRubroEstadoFinanciero.leDetalle = odDetalle.Listar(oeDetalle)
                    oeCuenta = New e_RubroEEFFDetalle_CuentaContable
                    oeCuenta.TipoOperacion = "R"
                    oeCuenta.IdRubroEEFFDetalle = oeRubroEstadoFinanciero.Id
                    oeRubroEstadoFinanciero.leCuenta = odCuenta.Listar(oeCuenta)
                End If
            End If
            Return oeRubroEstadoFinanciero
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeRubroEstadoFinanciero As e_RubroEstadoFinanciero) As List(Of e_RubroEstadoFinanciero)
        Try
            Dim ldRubroEstadoFinanciero As New List(Of e_RubroEstadoFinanciero)
            Dim ds As DataSet = ExecuteLST(oeRubroEstadoFinanciero)
            oeRubroEstadoFinanciero = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeRubroEstadoFinanciero = Cargar(o_Fila)
                    ldRubroEstadoFinanciero.Add(oeRubroEstadoFinanciero)
                Next
            End If
            Return ldRubroEstadoFinanciero
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeRubroEstadoFinanciero As e_RubroEstadoFinanciero) As Boolean
        Try
            Using transScope As New TransactionScope()
                Dim stResultado() As String
                With oeRubroEstadoFinanciero
                    stResultado = sqlhelper.ExecuteScalar("[CON].[Isp_RubroEstadoFinanciero_IAE]" _
                            , .TipoOperacion _
                            , d_DatosConfiguracion.PrefijoID _
                            , .Id _
                            , .Codigo _
                            , .NroRegistro _
                            , .Nombre _
                            , .EstructuraArchivo _
                            , .FechaCrea _
                            , .UsuarioCrea _
                            , .FechaModifica _
                            , .UsuarioModifica _
                            , .Activo _
                        ).ToString.Split("_")
                    .Id = stResultado(0)
                    For Each oeDet In .leDetalle.OrderBy(Function(it) it.Identificador).Where(Function(it) it.TipoOperacion.Trim <> "").ToList
                        If oeDet.TipoOperacion = "E" Then
                            odDetalle.Eliminar(oeDet)
                        Else
                            If oeDet.Nivel > 1 Then
                                oeDetalle = New e_RubroEstadoFinanciero_Detalle
                                oeDetalle.Identificador = oeDet.IdentificaPadre
                                oeDetalle.TipoBusca = 3
                                If .leDetalle.Contains(oeDetalle) Then
                                    oeDetalle = .leDetalle.Item(.leDetalle.IndexOf(oeDetalle))
                                    oeDet.IdDepende = oeDetalle.Id
                                End If
                            Else
                                oeDet.IdDepende = String.Empty
                            End If
                            oeDet.IdRubroEstadoFinanciero = .Id
                            odDetalle.Guardar(oeDet)
                        End If
                    Next
                    For Each oeCC In .leCuenta.Where(Function(it) it.TipoOperacion.Trim <> "").ToList
                        If oeCC.TipoOperacion = "E" Then
                            odCuenta.Eliminar(oeCC)
                        Else
                            oeDetalle = New e_RubroEstadoFinanciero_Detalle
                            oeDetalle.Identificador = oeCC.Identificador
                            oeDetalle.TipoBusca = 3
                            If .leDetalle.Contains(oeDetalle) Then
                                oeDetalle = .leDetalle.Item(.leDetalle.IndexOf(oeDetalle))
                                oeCC.IdRubroEEFFDetalle = oeDetalle.Id
                            End If
                            odCuenta.Guardar(oeCC)
                        End If
                    Next
                End With
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeRubroEstadoFinanciero As e_RubroEstadoFinanciero) As Boolean
        Try
            With oeRubroEstadoFinanciero
                sqlhelper.ExecuteNonQuery("[CON].[Isp_RubroEstadoFinanciero_IAE]" _
                       , "E" _
                       , "" _
                       , .Id _
                       , .Codigo _
                       , .NroRegistro _
                       , .Nombre _
                       , .EstructuraArchivo _
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
