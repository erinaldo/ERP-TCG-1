Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_OperacionNeumatico
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_OperacionNeumatico
        Try
            Dim oeOperacionNeumatico = New e_OperacionNeumatico( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("IdVidaNeumatico").ToString _
                             , o_fila("IdNeumatico").ToString _
                             , o_fila("CodigoNeumatico").ToString _
                             , o_fila("Marca").ToString _
                             , o_fila("Medida").ToString _
                             , o_fila("Diseño").ToString _
                             , o_fila("IdVehiculo").ToString _
                             , o_fila("Placa").ToString _
                             , o_fila("IdMotivo").ToString _
                             , o_fila("Motivo").ToString _
                             , o_fila("IndMontaje").ToString _
                             , o_fila("IndInspeccion").ToString _
                             , o_fila("Posicion").ToString _
                             , o_fila("FechaOperacion").ToString _
                             , o_fila("KmVehiculo") _
                             , o_fila("KmNeumatico") _
                             , o_fila("Ribete1").ToString _
                             , o_fila("Ribete2").ToString _
                             , o_fila("Ribete3").ToString _
                             , o_fila("Ribete4").ToString _
                             , o_fila("Cocada").ToString _
                             , o_fila("Presion").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("IdResponsable").ToString _
                             , o_fila("IdConductor").ToString _
            )
            Return oeOperacionNeumatico
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeOperacionNeumatico As e_OperacionNeumatico) As e_OperacionNeumatico
        Try
            Dim ds As DataSet
            With oeOperacionNeumatico
                ds = sqlhelper.ExecuteDataset("[NEU].[Isp_OperacionNeumatico_Listar]", .TipoOperacion, _
                                          .Id _
                                          , .IdVidaNeumatico _
                                          , .IdVehiculo _
                                          , .Codigo _
                                          , .IdMotivo _
                                          , .IndMontaje _
                                          , .IndInspeccion _
                                          , .Posicion)
            End With
            
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeOperacionNeumatico = Cargar(ds.Tables(0).Rows(0))
            Else
                oeOperacionNeumatico = New e_OperacionNeumatico
            End If
            Return oeOperacionNeumatico
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOperacionNeumatico As e_OperacionNeumatico) As List(Of e_OperacionNeumatico)
        Try
            Dim ldOperacionNeumatico As New List(Of e_OperacionNeumatico)
            Dim ds As DataSet
            With oeOperacionNeumatico 
                ds = sqlhelper.ExecuteDataset("[NEU].[Isp_OperacionNeumatico_Listar]", .TipoOperacion _
                        , .Id _
                        , .IdVidaNeumatico _
                        , .IdVehiculo _
                        , .Codigo _
                        , .IdMotivo _
                        , .IndMontaje _
                        , .IndInspeccion _
                        , .Posicion _
                        , .Cocada _
                        , .FechaOperacion _
                        , .KmVehiculo _
                        , .KmNeumatico _
                        , .Ribete1 _
                        , .Ribete2 _
                        , .Ribete3 _
                        , .Ribete4 _
                        , .Presion _
                        , .Descripcion _
                        , .Activo _
                        , .UsuarioCreacion _
                        )
            End With
            oeOperacionNeumatico = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeOperacionNeumatico = Cargar(o_Fila)
                    ldOperacionNeumatico.Add(oeOperacionNeumatico)
                Next
            End If
            Return ldOperacionNeumatico
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOperacionNeumatico As e_OperacionNeumatico) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeOperacionNeumatico
                sqlhelper.ExecuteNonQuery("[NEU].[Isp_OperacionNeumatico_IAE]", .TipoOperacion, d_DatosConfiguracion.PrefijoID _
                , .Operacion _
                , .Id _
                , .IdVehiculo _
                        , .IdVidaNeumatico _
                        , .Codigo _
                        , .IdMotivo _
                        , .IndMontaje _
                        , .IndInspeccion _
                        , .Posicion _
                        , .Cocada _
                        , .FechaOperacion _
                        , .KmVehiculo _
                        , .KmNeumatico _
                        , .Ribete1 _
                        , .Ribete2 _
                        , .Ribete3 _
                        , .Ribete4 _
                        , .Presion _
                        , IIf(.IndObservacion > 0, .Descripcion & "|" & .IndObservacion, .Descripcion) _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .IdResponsable _
                        , .IdConductor _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarLista(leOperacionNeumatico As List(Of e_OperacionNeumatico)) As Boolean
        Try
            Using TransScope As New TransactionScope()
                For Each oeOpeNeu In leOperacionNeumatico
                    Guardar(oeOpeNeu)
                Next
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeOperacionNeumatico As e_OperacionNeumatico) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[NEU].[Isp_OperacionNeumatico_IAE]", oeOperacionNeumatico.TipoOperacion, _
                         "", "", oeOperacionNeumatico.Id)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
