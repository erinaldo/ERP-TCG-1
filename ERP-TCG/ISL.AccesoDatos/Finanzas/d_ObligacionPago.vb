Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient
Public Class d_ObligacionPago
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_ObligacionPago
        Try
            Dim oeObligacionPago = New e_ObligacionPago( _
                             o_Fila("Id").ToString _
                             , o_Fila("IdMovimientoCajaBanco").ToString _
                             , o_Fila("IdObligacionFinanciera").ToString _
                             , o_Fila("NroCuota").ToString _
                             , o_Fila("FechaInicial").ToString _
                             , o_Fila("MontoInicialMN").ToString _
                             , o_Fila("MontoInicialME").ToString _
                             , o_Fila("IndCancelado").ToString _
                             , o_Fila("FechaFinal").ToString _
                             , o_Fila("MontoFinalMN").ToString _
                             , o_Fila("MontoFinalME").ToString _
                             , o_Fila("Activo").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
            )
            Return oeObligacionPago
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeObligacionPago As e_ObligacionPago) As e_ObligacionPago

        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("FIN.Isp_ObligacionPago_Listar", "", _
            Left(d_DatosConfiguracion.PrefijoID, 1), "", oeObligacionPago.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeObligacionPago = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeObligacionPago
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeObligacionPago As e_ObligacionPago) As List(Of e_ObligacionPago)
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ldObligacionPago As New List(Of e_ObligacionPago)
            Dim ds As DataSet
            With oeObligacionPago
                ds = sqlhelper.ExecuteDataset("FIN.Isp_ObligacionPago_Listar", .TipoOperacion _
        , Left(d_DatosConfiguracion.PrefijoID, 1), "" _
                        , .Id _
                        , .IdMovimientoCajaBanco _
                        , .IdObligacionFinanciera _
                        , .NroCuota _
                        , .FechaInicial _
                        , .MontoInicialMN _
                        , .MontoInicialME _
                        , .IndCancelado _
                        , .FechaFinal _
                        , .MontoFinalMN _
                        , .MontoFinalME _
                        , .Activo _
                        , .UsuarioCreacion _
                        )
            End With
            oeObligacionPago = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeObligacionPago = Cargar(o_Fila)
                    ldObligacionPago.Add(oeObligacionPago)
                Next
            End If
            Return ldObligacionPago
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeObligacionPago As e_ObligacionPago) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado() As String
            With oeObligacionPago
                stResultado = sqlhelper.ExecuteScalar("FIN.Isp_ObligacionPago_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdMovimientoCajaBanco _
                        , .IdObligacionFinanciera _
                        , .NroCuota _
                        , .FechaInicial _
                        , .MontoInicialMN _
                        , .MontoInicialME _
                        , .IndCancelado _
                        , .FechaFinal _
                        , .MontoFinalMN _
                        , .MontoFinalME _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .MacPCLocalCreacion _
                    ).ToString.Split("_")
                oeObligacionPago.Id = stResultado(0)
                If Not .OeAsientoMov_ObligFin Is Nothing Then
                    If .OeAsientoMov_ObligFin.TipoOperacion <> "" Then
                        Dim odAsientoMov_ObligaFin As New d_AsientoMov_ObligacionFin
                        .OeAsientoMov_ObligFin.IdObligacionPago = oeObligacionPago.Id
                        .OeAsientoMov_ObligFin.IdAsientoMovimiento = oeObligacionPago._IdAsientoMovimiento
                        odAsientoMov_ObligaFin.Guardar(.OeAsientoMov_ObligFin)
                    End If
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeObligacionPago As e_ObligacionPago) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("FIN.Isp_ObligacionPago_IAE", "E", _
             "", oeObligacionPago.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
