Imports ISL.EntidadesWCF
Imports System.Transactions
Public Class d_Peaje
    Private sqlhelper As SqlHelper

    Private Function Cargar(o_fila As DataRow) As e_Peaje
        Try
            Dim oePeaje = New e_Peaje With {
                        .Id = o_fila("Id").ToString _
                        , .Codigo = o_fila("Codigo").ToString _
                        , .Nombre = o_fila("Nombre").ToString _
                        , .Ubicacion = o_fila("Ubicacion").ToString _
                        , .IdEmpresa = o_fila("IdEmpresa").ToString _
                        , .Empresa = o_fila("Empresa").ToString _
                        , .IdLugar = o_fila("IdLugar").ToString _
                        , .Lugar = o_fila("Lugar").ToString _
                        , .IndPagoIda = o_fila("IndPagoIda") _
                        , .IndPagoRetorno = o_fila("IndPagoRetorno") _
                        , .Glosa = o_fila("Glosa").ToString _
                        , .UsuarioCreacion = o_fila("UsuarioCreacion").ToString _
                        , .FechaCreacion = o_fila("FechaCreacion") _
                        , .UsuarioModificacion = o_fila("UsuarioModificacion").ToString _
                        , .FechaModificacion = o_fila("FechaModificacion") _
                        , .Activo = o_fila("Activo") _
            }
            Return oePeaje
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oePeaje As e_Peaje) As e_Peaje
        Try
            sqlhelper = New SqlHelper
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_Peaje_Listar", _
                                          "GEN", _
                                          oePeaje.Id, "", "", "", "", oePeaje.IdLugar)
            If ds.Tables(0).Rows.Count > 0 Then
                If ds.Tables(0).Rows.Count > 1 Then
                    Throw New Exception("Error Obtener retorna mas de un valor")
                Else
                    oePeaje = Cargar(ds.Tables(0).Rows(0))
                End If
            Else
                oePeaje = New e_Peaje
            End If
            Return oePeaje
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oePeaje As e_Peaje) As List(Of e_Peaje)
        Try
            sqlhelper = New SqlHelper
            Dim ldPeaje As New List(Of e_Peaje)
            Dim ds As DataSet
            With oePeaje
                ds = sqlhelper.ExecuteDataset("[STD].[Isp_Peaje_Listar]", _
                                              .TipoOperacion _
                                            , .Id _
                                            , .Codigo _
                                            , .Nombre _
                                            , .Ubicacion _
                                            , .IdEmpresa _
                                            , .IdLugar _
                                            , .IndPagoIda _
                                            , .IndPagoRetorno _
                                            , .Glosa _
                                            , .Activo)
            End With
            oePeaje = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oePeaje = Cargar(o_Fila)
                ldPeaje.Add(oePeaje)
            Next
            Return ldPeaje
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oePeaje As e_Peaje) As Boolean
        Try
            sqlhelper = New SqlHelper
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ldPeajeTarifa As New d_PeajeTarifa
            Dim IdResultado As String = ""
            Using TransScope As New TransactionScope
                With oePeaje
                    IdResultado = sqlhelper.ExecuteScalar("STD.Isp_Peaje_IAE", _
                                              .TipoOperacion _
                                                , .PrefijoID _
                                                , .Id _
                                                , .Codigo _
                                                , .Nombre _
                                                , .Ubicacion _
                                                , .IdEmpresa _
                                                , .IdLugar _
                                                , .IndPagoIda _
                                                , .IndPagoRetorno _
                                                , .Glosa _
                                                , .Activo _
                                                , .UsuarioCreacion)
                    .Id = IdResultado
                    For Each Tarifa As e_PeajeTarifa In .ListaTarifa
                        With Tarifa
                            If .TipoOperacion = "E" Then
                                ldPeajeTarifa.Eliminar(Tarifa)
                            Else
                                .TipoOperacion = "I"
                                Tarifa.IdPeaje = oePeaje.Id
                                ldPeajeTarifa.Guardar(Tarifa)
                            End If
                        End With
                    Next
                End With
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oePeaje As e_Peaje, bolTarifa As Boolean) As Boolean
        Try
            sqlhelper = New SqlHelper
            Using TransScope As New TransactionScope
                With oePeaje
                    sqlhelper.ExecuteScalar("STD.Isp_Peaje_IAE", _
                                              "E" _
                                                , "" _
                                                , .Id _
                                                , .Codigo _
                                                , .Nombre _
                                                , .Ubicacion _
                                                , .IdEmpresa _
                                                , .IdLugar _
                                                , .IndPagoIda _
                                                , .IndPagoRetorno _
                                                , .Glosa _
                                                , .Activo _
                                                , .UsuarioCreacion)
                End With
                If bolTarifa Then
                    Dim ldPeajeTarifa As New d_PeajeTarifa
                    For Each Tarifa As e_PeajeTarifa In oePeaje.ListaTarifa
                        ldPeajeTarifa.Eliminar(Tarifa)
                    Next
                End If
                TransScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
