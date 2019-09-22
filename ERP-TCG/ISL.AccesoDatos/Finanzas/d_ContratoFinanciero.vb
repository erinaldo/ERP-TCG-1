Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ContratoFinanciero
    Private sqlhelper As New SqlHelper
    Dim odObligacionFin As New d_ObligacionFinanciera

    Private Function Cargar(ByVal o_fila As DataRow) As e_ContratoFinanciero
        Try
            Dim oeContratoFinanciero = New e_ContratoFinanciero( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("IdTipoDocumento").ToString _
                             , o_fila("IdEmpresaBanco").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("FechaEmision").ToString _
                             , o_fila("FechaVencimiento").ToString _
                             , o_fila("NroCuotas").ToString _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("TipoCambio").ToString _
                             , o_fila("MontoMN").ToString _
                             , o_fila("MontoME").ToString _
                             , o_fila("TasaInteres").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Cuo")
            )
            Return oeContratoFinanciero
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeContratoFinanciero As e_ContratoFinanciero) As e_ContratoFinanciero

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("FIN.ISP_ContratoFinanciero_Listar", "", oeContratoFinanciero.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeContratoFinanciero = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeContratoFinanciero
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeContratoFinanciero As e_ContratoFinanciero) As List(Of e_ContratoFinanciero)
        Try
            Dim ldContratoFinanciero As New List(Of e_ContratoFinanciero)
            Dim ds As DataSet
            With oeContratoFinanciero
                ds = sqlhelper.ExecuteDataset("FIN.ISP_ContratoFinanciero_Listar", "" _
                        , .Id _
                        , .Codigo _
                        , .IdTipoDocumento _
                        , .IdEmpresaBanco _
                        , .Glosa _
                        , .FechaEmision _
                        , .FechaVencimiento _
                        , .NroCuotas _
                        , .IdMoneda _
                        , .TipoCambio _
                        , .MontoMN _
                        , .MontoME _
                        , .TasaInteres _
                        , .Activo _
                        , .Usuario _
                                        )
            End With
            oeContratoFinanciero = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeContratoFinanciero = Cargar(o_Fila)
                ldContratoFinanciero.Add(oeContratoFinanciero)
            Next
            Return ldContratoFinanciero
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDS(ByVal oeContratoFinanciero As e_ContratoFinanciero) As Data.DataSet
        Try
            Dim ldContratoFinanciero As New List(Of e_ContratoFinanciero)
            Dim ds As DataSet
            With oeContratoFinanciero
                ds = sqlhelper.ExecuteDataset("FIN.ISP_ContratoFinanciero_Listar", .TipoOperacion _
                        , .Id _
                        , .Codigo _
                        , .IdTipoDocumento _
                        , .IdEmpresaBanco _
                        , .FechaEmision _
                        , .FechaVencimiento _
                        , .IdMoneda _
                        , .Activo _
                        , .Usuario _
                                        )
            End With
            oeContratoFinanciero = Nothing
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeContratoFinanciero As e_ContratoFinanciero) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                With oeContratoFinanciero
                    stResultado = sqlhelper.ExecuteScalar("FIN.Isp_ContratoFinanciero_IAE", _
                                                          .TipoOperacion, _
                                                          .PrefijoID _
                            , .Id _
                            , .Codigo _
                            , .IdTipoDocumento _
                            , .IdEmpresaBanco _
                            , .Glosa _
                            , .FechaEmision _
                            , .FechaVencimiento _
                            , .NroCuotas _
                            , .IdMoneda _
                            , .TipoCambio _
                            , .MontoMN _
                            , .MontoME _
                            , .TasaInteres _
                            , .Activo _
                            , .Usuario _
                            , .Comision _
                        ).ToString.Split("_")

                    'Registra Detalle
                    For Each oeObligacionFin As e_ObligacionFin In .lstObligacionesFin
                        oeObligacionFin.IdContrato = stResultado(0)
                        oeObligacionFin.Usuario = .Usuario
                        oeObligacionFin.TipoOperacion = IIf(String.IsNullOrEmpty(oeObligacionFin.Id), "I", .TipoOperacion)
                        odObligacionFin.Guardar(oeObligacionFin)
                    Next

                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeContratoFinanciero As e_ContratoFinanciero) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeContratoFinanciero.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
