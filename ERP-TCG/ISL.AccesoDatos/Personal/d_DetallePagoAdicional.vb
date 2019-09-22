Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_DetallePagoAdicional

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_DetallePagoAdicional
        Try
            Dim oeDetallePagoAdicional = New e_DetallePagoAdicional( _
                             o_fila("Id").ToString _
                             , o_fila("IdPagoAdicional").ToString _
                             , o_fila("IdPlanilla").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Dni").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("Sueldo") _
                             , o_fila("AsignacionFamiliar") _
                             , o_fila("IndTipo") _
                             , o_fila("Cantidad") _
                             , o_fila("Monto") _
                             , o_fila("Redondeo") _
                             , o_fila("DiasVacaciones") _
                             , o_fila("DiasFalta") _
                             , o_fila("DiasDescanso") _
                             , o_fila("TotalPagar") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo") _
            )
            oeDetallePagoAdicional.HorasExtras = o_fila("HorasExtras")
            oeDetallePagoAdicional.MinutosExtras = o_fila("MinutosExtras")
            oeDetallePagoAdicional.Tipo = o_fila("Tipo")

            'If (oeDetallePagoAdicional.IndTipo = 0) Then oeDetallePagoAdicional.Tipo = "HORAS EXTRAS 25%"
            'If (oeDetallePagoAdicional.IndTipo = 1) Then oeDetallePagoAdicional.Tipo = "HORAS EXTRAS 35%"
            'If (oeDetallePagoAdicional.IndTipo = 2) Then oeDetallePagoAdicional.Tipo = "HORARIO NOCTURNO"
            'If (oeDetallePagoAdicional.IndTipo = 3) Then oeDetallePagoAdicional.Tipo = "BONO POR ALIMENTACIÓN"
            'If (oeDetallePagoAdicional.IndTipo = 4) Then oeDetallePagoAdicional.Tipo = "SUBSIDIOS"
            'If (oeDetallePagoAdicional.IndTipo = 5) Then oeDetallePagoAdicional.Tipo = "SEMÁFORO"
            'If (oeDetallePagoAdicional.IndTipo = 6) Then oeDetallePagoAdicional.Tipo = "MOVILIDAD (CALIZA)"
            'If (oeDetallePagoAdicional.IndTipo = 7) Then oeDetallePagoAdicional.Tipo = "SUBSIDIOS (MATERNIDAD)"
            Return oeDetallePagoAdicional
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetallePagoAdicional As e_DetallePagoAdicional) As e_DetallePagoAdicional

        Try
            Dim ds As DataSet
            With oeDetallePagoAdicional
                ds = sqlhelper.ExecuteDataset("PER.Isp_DetallePagoAdicional_Listar", .TipoOperacion, .Id)
            End With
            If ds.Tables(0).rows.Count > 0 Then
                oeDetallePagoAdicional = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDetallePagoAdicional
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetallePagoAdicional As e_DetallePagoAdicional) As List(Of e_DetallePagoAdicional)
        Try
            Dim ldDetallePagoAdicional As New List(Of e_DetallePagoAdicional)
            Dim ds As DataSet
            With oeDetallePagoAdicional
                ds = sqlhelper.ExecuteDataset("PER.Isp_DetallePagoAdicional_Listar", .TipoOperacion _
                        , .Id _
                        , .IdPagoAdicional _
                        , .IdTrabajador _
                        , .IndTipo _
                        , .Cantidad _
                        , .Monto _
                        , .Redondeo _
                        , .DiasVacaciones _
                        , .DiasFalta _
                        , .DiasDescanso _
                        , .TotalPagar _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                        )
            End With
            oeDetallePagoAdicional = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeDetallePagoAdicional = Cargar(o_Fila)
                ldDetallePagoAdicional.Add(oeDetallePagoAdicional)
            Next
            Return ldDetallePagoAdicional
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetallePagoAdicional As e_DetallePagoAdicional) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeDetallePagoAdicional
                sqlhelper.ExecuteNonQuery("PER.Isp_DetallePagoAdicional_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdPagoAdicional _
                        , .IdTrabajador _
                        , .Sueldo _
                        , .AsignacionFamiliar _
                        , .IndTipo _
                        , .Cantidad _
                        , .Monto _
                        , .Redondeo _
                        , .DiasVacaciones _
                        , .DiasFalta _
                        , .DiasDescanso _
                        , .TotalPagar _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                        , .HorasExtras _
                        , .MinutosExtras _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarMasivo(ByVal dtDetPA As DataTable) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            sqlhelper.InsertarMasivo("PER.DetallePagoAdicional", dtDetPA)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetallePagoAdicional As e_DetallePagoAdicional) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_DetallePagoAdicional_IAE", "E", _
             "", oeDetallePagoAdicional.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "PER.DetallePagoAdicional", PrefijoID
                                  )
            Return stResultado
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
