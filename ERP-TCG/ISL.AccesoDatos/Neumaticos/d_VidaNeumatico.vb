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

Public Class d_VidaNeumatico
    Private sqlhelper As New SqlHelper
    Private odOperacionNeu As New d_OperacionNeumatico

    Private Function Cargar(ByVal o_fila As DataRow) As e_VidaNeumatico
        Try
            Dim oeVidaNeumatico = New e_VidaNeumatico( _
                             o_fila("Id").ToString _
                             , o_fila("IdNeumatico").ToString _
                             , o_fila("CodigoNeumatico").ToString _
                             , o_fila("IdDiseño").ToString _
                             , o_fila("Diseño").ToString _
                              , o_fila("IdMarca").ToString _
                              , o_fila("Marca").ToString _
                              , o_fila("IdMedida").ToString _
                              , o_fila("Medida").ToString _
                              , o_fila("KmTotalNeumatico") _
                              , o_fila("CostoCascoDolares") _
                              , o_fila("CocadaMinima") _
                             , o_fila("NroVida").ToString _
                             , o_fila("FechaIngreso").ToString _
                             , o_fila("Condicion").ToString _
                             , o_fila("EstadoActual").ToString _
                              , o_fila("Ubicacion").ToString _
                             , o_fila("Kilometraje").ToString _
                             , o_fila("Ribete1").ToString _
                             , o_fila("Ribete2").ToString _
                             , o_fila("Ribete3").ToString _
                             , o_fila("Ribete4").ToString _
                             , o_fila("Cocada").ToString _
                             , o_fila("CocadaOriginal").ToString _
                             , o_fila("CostoSoles").ToString _
                             , o_fila("CostoDolares").ToString _
                             , o_fila("IdProveedor").ToString _
                             , o_fila("Proveedor").ToString _
                             , o_fila("Vigente").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaFinVida") _
                             , o_fila("IdDiseno").ToString _
                             , o_fila("IndLugar") _
                             , o_fila("IndLog") _
                                     )
            Return oeVidaNeumatico
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeVidaNeumatico As e_VidaNeumatico) As e_VidaNeumatico

        Try
            Dim ds As DataSet
            With oeVidaNeumatico
                ds = sqlhelper.ExecuteDataset("[NEU].[Isp_VidaNeumatico_Listar]", .TipoOperacion, .Id, .IdNeumatico)
            End With

            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeVidaNeumatico = Cargar(ds.Tables(0).Rows(0))
            Else
                oeVidaNeumatico = New e_VidaNeumatico
            End If
            Return oeVidaNeumatico
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeVidaNeumatico As e_VidaNeumatico) As List(Of e_VidaNeumatico)
        Try
            Dim ldVidaNeumatico As New List(Of e_VidaNeumatico)
            Dim ds As DataSet
            With oeVidaNeumatico
                ds = sqlhelper.ExecuteDataset("[NEU].[Isp_VidaNeumatico_Listar]", .TipoOperacion _
                        , .Id _
                        , .IdNeumatico _
                        , .NroVida _
                        , .FechaIngreso _
                        , .Condicion _
                        , .EstadoActual _
                        , .Ubicacion _
                        , .Kilometraje _
                        , .Ribete1 _
                        , .Ribete2 _
                        , .Ribete3 _
                        , .Ribete4 _
                        , .Cocada _
                        , .CostoSoles _
                        , .CostoDolares _
                        , .IdProveedor _
                        , .Vigente _
                        , .Activo _
                        , .UsuarioCreacion _
                        )
            End With
            oeVidaNeumatico = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeVidaNeumatico = Cargar(o_Fila)
                    ldVidaNeumatico.Add(oeVidaNeumatico)
                Next
            End If
            Return ldVidaNeumatico
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeVidaNeumatico As e_VidaNeumatico) As e_VidaNeumatico
        Try
            Dim stResultado() As String
            With oeVidaNeumatico
                stResultado = sqlhelper.ExecuteScalar("[NEU].[Isp_VidaNeumatico_IAE]", .TipoOperacion,
                                                      .PrefijoID,
                        .Id _
                        , .IdNeumatico _
                        , .NroVida _
                        , .FechaIngreso _
                        , .Condicion _
                        , .EstadoActual _
                        , .Ubicacion _
                        , .Kilometraje _
                        , .Ribete1 _
                        , .Ribete2 _
                        , .Ribete3 _
                        , .Ribete4 _
                        , .Cocada _
                        , .CocadaOriginal _
                        , .CostoSoles _
                        , .CostoDolares _
                        , .IdProveedor _
                        , .Vigente _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .FechaFinVida _
                        , .IdDisenoNeu _
                        , .IndLugar _
                        , .IndLog _
                        , .ls_IdMaterial _
                        , .Marca
                    ).ToString.Split("_")
            End With
            oeVidaNeumatico.Id = stResultado(0).ToString
            Return oeVidaNeumatico
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeVidaNeumatico As e_VidaNeumatico) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[NEU].[Isp_VidaNeumatico_IAE]", "E", "", oeVidaNeumatico.Id)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ActualizaKM(ByVal oeVidaNeumatico As e_VidaNeumatico) As Boolean
        Try
            Dim id As String = ""
            Using TransScope As New TransactionScope()
                With oeVidaNeumatico
                    id = sqlhelper.ExecuteScalar("[NEU].[Isp_VidaNeumatico_IAE]", .TipoOperacion,
                                                          .PrefijoID,
                            .Id _
                            , .IdNeumatico _
                            , .NroVida _
                            , .FechaIngreso _
                            , .Condicion _
                            , .EstadoActual _
                            , .Ubicacion _
                            , .Kilometraje _
                            , .Ribete1 _
                            , .Ribete2 _
                            , .Ribete3 _
                            , .Ribete4 _
                            , .Cocada _
                            , .CocadaOriginal _
                            , .CostoSoles _
                            , .CostoDolares _
                            , .IdProveedor _
                            , .Vigente _
                            , .Activo _
                            , .UsuarioCreacion _
                            , .FechaFinVida _
                            , .IdDisenoNeu _
                            , .IndLugar _
                            , .IndLog
                        )
                    For Each oeAux In .leOpeNeuAux
                        oeAux.PrefijoID = oeVidaNeumatico.PrefijoID '@0001
                        odOperacionNeu.Guardar(oeAux)
                    Next
                End With
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
