Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_GuiasControl
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_GuiasControl
        Try
            Dim oeGuiasControl = New e_GuiasControl( _
                             o_fila("Id").ToString _
                             , o_fila("PlacaAntigua").ToString _
                              , o_fila("PlacaActual").ToString _
                             , o_fila("IdVehiculo").ToString _
                             , o_fila("Serie").ToString _
                             , o_fila("Correlativo").ToString _
                             , o_fila("Observacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("StockGuias").ToString _
                             , CInt(o_fila("StockGuias").ToString) \ 50 _
                             , o_fila("Flota").ToString)
            Return oeGuiasControl
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeGuiasControl As e_GuiasControl) As e_GuiasControl
        Try
            Dim ds As DataSet
            With oeGuiasControl
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_GuiasControl_Listar]", _
                                                          "", _
                                                          .Id, _
                                                          .IdVehiculo, _
                                                          .Serie)
            End With

            If ds.Tables(0).Rows.Count > 0 Then
                oeGuiasControl = Cargar(ds.Tables(0).Rows(0))
            Else
                oeGuiasControl = New e_GuiasControl
            End If
            Return oeGuiasControl
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGuiasControl As e_GuiasControl) As List(Of e_GuiasControl)
        Try
            Dim ldGuiasControl As New List(Of e_GuiasControl)
            Dim ds As DataSet
            With oeGuiasControl
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_GuiasControl_Listar]", _
                                              "" _
                                                , .Id _
                                                , .IdVehiculo _
                                                , .Serie _
                                                , .Correlativo)
            End With

            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeGuiasControl = Cargar(o_Fila)
                    ldGuiasControl.Add(oeGuiasControl)
                Next
            Else
                ldGuiasControl = New List(Of e_GuiasControl)
            End If
            Return ldGuiasControl
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGuiasControl As e_GuiasControl) As Boolean
        Dim stResultado() As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Using transScope As New TransactionScope()
                With oeGuiasControl
                    stResultado = sqlhelper.ExecuteScalar("[OPE].[Isp_GuiasControl_IAE]",
                                                 .TipoOperacion,
                                                .PrefijoID,
                                                .Id _
                                                , .IdVehiculo _
                                                , .Serie _
                                                , .Correlativo _
                                                , .Observacion _
                                                , .UsuarioCreacion _
                                                , .Activo).ToString.Split("_")
                End With

                For Each GuiasControl As e_GuiasTalonarios In oeGuiasControl.GuiasTalanonarios
                    GuiasControl.TipoOperacion = oeGuiasControl.TipoOperacion
                    GuiasControl.IdGuiasControl = stResultado(0)
                    Guardar(GuiasControl)
                Next
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeGuiasControl As e_GuiasControl) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeGuiasControl.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Private Function CargarGuiasTalonarios(ByVal o_fila As DataRow) As e_GuiasTalonarios
        Try
            Dim oeGuiasTalonarios = New e_GuiasTalonarios( _
                             o_fila("Id").ToString _
                             , o_fila("IdGuiasControl").ToString _
                             , o_fila("Inicial").ToString _
                             , o_fila("Final").ToString _
                             , o_fila("FechaIngreso").ToString _
                             , o_fila("Anulado").ToString _
                             , o_fila("Terminado").ToString _
                             , o_fila("Observacion").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeGuiasTalonarios
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeGuiasTalonarios As e_GuiasTalonarios) As e_GuiasTalonarios

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("OPE].[Isp_GuiasTalonarios_Listar]", _
                                          "", _
                                          oeGuiasTalonarios.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeGuiasTalonarios = CargarGuiasTalonarios(ds.Tables(0).Rows(0))
            Else
                oeGuiasTalonarios = New e_GuiasTalonarios
            End If
            Return oeGuiasTalonarios
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGuiasTalonarios As e_GuiasTalonarios) As List(Of e_GuiasTalonarios)
        Try
            Dim ldGuiasTalonarios As New List(Of e_GuiasTalonarios)
            Dim ds As DataSet
            With oeGuiasTalonarios
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_GuiasTalonarios_Listar]", _
                                                "" _
                                                , .Id _
                                                , .IdGuiasControl _
                                                , .Inicial _
                                                , .Final _
                                                , .Activo)
            End With
            oeGuiasTalonarios = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeGuiasTalonarios = CargarGuiasTalonarios(o_Fila)
                    ldGuiasTalonarios.Add(oeGuiasTalonarios)
                Next
            Else
                ldGuiasTalonarios = New List(Of e_GuiasTalonarios)
            End If
            Return ldGuiasTalonarios
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGuiasTalonarios As e_GuiasTalonarios) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeGuiasTalonarios
                sqlhelper.ExecuteNonQuery("[OPE].[Isp_GuiasTalonarios_IAE]",
                                           .TipoOperacion,
                                           .PrefijoID,
                                            .Id _
                                            , .IdGuiasControl _
                                            , .Inicial _
                                            , .Final _
                                            , .FechaIngreso _
                                            , .Anulado _
                                            , .Terminado _
                                            , .Observacion _
                                            , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeGuiasTalonarios As e_GuiasTalonarios) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeGuiasTalonarios.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
