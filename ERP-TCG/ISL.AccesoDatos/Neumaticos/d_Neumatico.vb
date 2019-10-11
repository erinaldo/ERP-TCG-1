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

Public Class d_Neumatico
    Private sqlhelper As New SqlHelper
    Dim odVidaNeumatico As New d_VidaNeumatico
    Dim oeVidaNeu As New e_VidaNeumatico
    Dim oeOperacionNeu As New e_OperacionNeumatico
    Dim odOperacionNeu As New d_OperacionNeumatico
    Dim odDetalleON As New d_DetalleOrdenNeumatico

    Private Function Cargar(ByVal o_fila As DataRow) As e_Neumatico
        Try
            Dim oeNeumatico = New e_Neumatico( _
                             o_fila("Id").ToString _
                             , o_fila("IdMaterial").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("IdMarca").ToString _
                             , o_fila("Marca").ToString _
                             , o_fila("IdTipo").ToString _
                             , o_fila("Tipo").ToString _
                             , o_fila("IdMedida").ToString _
                             , o_fila("Medida").ToString _
                             , o_fila("IdDiseño").ToString _
                             , o_fila("Diseño").ToString _
                             , o_fila("FechaIngreso").ToString _
                             , o_fila("KilometrajeActual").ToString _
                             , o_fila("IdProveedor").ToString _
                             , o_fila("CostoTotalSoles").ToString _
                             , o_fila("CostoTotalDolares").ToString _
                             , o_fila("CostoCascoDolares").ToString _
                             , o_fila("CocadaMinima") _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("TipoBanda").ToString _
                             , o_fila("DOT").ToString _
            )
            Return oeNeumatico
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeNeumatico As e_Neumatico) As e_Neumatico

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[NEU].[Isp_Neumatico_Listar]", oeNeumatico.TipoOperacion, _
                                          oeNeumatico.Id, oeNeumatico.Codigo)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeNeumatico = Cargar(ds.Tables(0).Rows(0))
                oeVidaNeu = New e_VidaNeumatico
                oeVidaNeu.TipoOperacion = "L"
                oeVidaNeu.IdNeumatico = oeNeumatico.Id
                oeVidaNeu.Activo = True
                oeNeumatico.leVidaNeu = odVidaNeumatico.Listar(oeVidaNeu)
                oeOperacionNeu = New e_OperacionNeumatico
                oeOperacionNeu.TipoOperacion = "L"
                oeOperacionNeu.IdVidaNeumatico = oeNeumatico.Id
                oeOperacionNeu.Activo = True
                oeNeumatico.leOperacionNeu = odOperacionNeu.Listar(oeOperacionNeu)
            Else
                oeNeumatico = New e_Neumatico
            End If
            Return oeNeumatico
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeNeumatico As e_Neumatico) As List(Of e_Neumatico)
        Try
            Dim ldNeumatico As New List(Of e_Neumatico)
            Dim ds As DataSet
            With oeNeumatico
                ds = sqlhelper.ExecuteDataset("[NEU].[Isp_Neumatico_Listar]", .TipoOperacion _
                        , .Id _
                        , .Codigo _
                        , .IdMaterial _
                        , .IdDiseño _
                        , .FechaIngreso _
                        , .KilometrajeActual _
                        , .IdProveedor _
                        , .CostoTotalSoles _
                        , .CostoTotalDolares _
                        , .CostoCascoDolares _
                        , .CocadaMinima _
                        , .Activo _
                        , .UsuarioCreacion _
                                          )
            End With
            oeNeumatico = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeNeumatico = Cargar(o_Fila)
                    ldNeumatico.Add(oeNeumatico)
                Next
            End If
            Return ldNeumatico
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDS(ByVal oeNeumatico As e_Neumatico) As Data.DataSet
        Try
            Dim ds As DataSet
            With oeNeumatico
                ds = sqlhelper.ExecuteDataset("[NEU].[Isp_Neumatico_Listar]", .TipoOperacion _
                         , .Id _
                         , .Codigo _
                         , .IdMaterial _
                         , .IdDiseño _
                         , .FechaIngreso _
                         , .KilometrajeActual _
                         , .IdProveedor _
                         , .CostoTotalSoles _
                         , .CostoTotalDolares _
                         , .CostoCascoDolares _
                         , .CocadaMinima _
                         , .Activo _
                         , .UsuarioCreacion _
                                           )
            End With
            oeNeumatico = New e_Neumatico
            Return ds
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeNeumatico As e_Neumatico) As Boolean
        Try
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                With oeNeumatico
                    Dim cadena() As String = oeNeumatico.Codigo.Split(","c)
                    For i As Integer = 0 To cadena.Length - 1
                        stResultado = sqlhelper.ExecuteScalar("[NEU].[Isp_Neumatico_IAE]", .TipoOperacion,
                                              .PrefijoID,
                            .Id _
                            , .IdMaterial _
                            , cadena(i).ToString _
                            , .IdDiseño _
                            , .FechaIngreso _
                            , .KilometrajeActual _
                            , .IdProveedor _
                            , .CostoTotalSoles _
                            , .CostoTotalDolares _
                            , .CostoCascoDolares _
                            , .CocadaMinima _
                            , .Activo _
                            , .UsuarioCreacion _
                            , .TipoBanda _
                            , .DOT).ToString.Split("_")

                        For Each VidaNeu As e_VidaNeumatico In .lstVidaNeumatico
                            VidaNeu.IdNeumatico = stResultado(0) : VidaNeu.UsuarioCreacion = .UsuarioCreacion
                            VidaNeu.TipoOperacion = IIf(String.IsNullOrEmpty(VidaNeu.Id), "I", VidaNeu.TipoOperacion)
                            VidaNeu.PrefijoID = oeNeumatico.PrefijoID '@0001
                            odVidaNeumatico.Guardar(VidaNeu)
                        Next

                        If .oeDetalleOrdenNeu IsNot Nothing Then
                            .oeDetalleOrdenNeu.PrefijoID = oeNeumatico.PrefijoID '@0001
                            odDetalleON.Guardar(.oeDetalleOrdenNeu)
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

    Public Function ConfirmarNeu(ByVal oeNeumatico As e_Neumatico) As Boolean
        Try
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                With oeNeumatico
                    Dim id() As String = oeNeumatico.Id.Split(","c)
                    Dim cod() As String = oeNeumatico.Codigo.Split(","c)
                    For i As Integer = 0 To id.Length - 1
                        stResultado = sqlhelper.ExecuteScalar("[NEU].[Isp_Neumatico_IAE]", .TipoOperacion,
                                              .PrefijoID,
                            id(i).ToString _
                            , .IdMaterial _
                            , cod(i).ToString _
                            , .IdDiseño _
                            , .FechaIngreso _
                            , .KilometrajeActual _
                            , .IdProveedor _
                            , .CostoTotalSoles _
                            , .CostoTotalDolares _
                            , .CostoCascoDolares _
                            , .CocadaMinima _
                            , .Activo _
                            , .UsuarioCreacion _
                            , .TipoBanda _
                            , .DOT
                                             ).ToString.Split("_")

                        For Each VidaNeu As e_VidaNeumatico In .lstVidaNeumatico
                            VidaNeu.IdNeumatico = stResultado(0) : VidaNeu.UsuarioCreacion = .UsuarioCreacion
                            VidaNeu.TipoOperacion = "I"
                            VidaNeu.PrefijoID = oeNeumatico.PrefijoID '@0001
                            odVidaNeumatico.Guardar(VidaNeu)
                        Next

                        If .oeDetalleOrdenNeu IsNot Nothing Then
                            .oeDetalleOrdenNeu.TipoOperacion = "A"
                            .oeDetalleOrdenNeu.IdNeumatico = stResultado(0)
                            .oeDetalleOrdenNeu.PrefijoID = oeNeumatico.PrefijoID '@0001
                            odDetalleON.Guardar(.oeDetalleOrdenNeu)
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

    Public Function PreGuardar(ByVal oeNeumatico As e_Neumatico) As Boolean
        Try
            Dim stResultado() As String
            With oeNeumatico
                Dim cadena() As String = oeNeumatico.Codigo.Split(","c)
                For i As Integer = 0 To cadena.Length - 1
                    stResultado = sqlhelper.ExecuteScalar("[NEU].[Isp_Neumatico_IAE]", .TipoOperacion,
                                          .PrefijoID,
                        .Id _
                        , .IdMaterial _
                        , cadena(i).ToString _
                        , .IdDiseño _
                        , .FechaIngreso _
                        , .KilometrajeActual _
                        , .IdProveedor _
                        , .CostoTotalSoles _
                        , .CostoTotalDolares _
                        , .CostoCascoDolares _
                        , .CocadaMinima _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .TipoBanda _
                        , .DOT _
                        , .TipoCambio _
                        , .FechaIngresoAlmacen
                                         ).ToString.Split("_")
                    oeNeumatico.Id = stResultado(0)
                Next
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeNeumatico As e_Neumatico) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[NEU].[Isp_Neumatico_IAE]", "E", "", oeNeumatico.Id)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
