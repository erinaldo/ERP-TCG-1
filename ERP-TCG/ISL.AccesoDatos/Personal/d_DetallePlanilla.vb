Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_DetallePlanilla

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_DetallePlanilla
        Try
            Dim oeDetallePlanilla = New e_DetallePlanilla( _
                             o_fila("Id").ToString _
                             , o_fila("IdPlanilla").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Dni").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("IdCentro").ToString _
                             , o_fila("Centro").ToString _
                             , o_fila("IdArea").ToString _
                             , o_fila("Area").ToString _
                             , o_fila("IdOcupacion").ToString _
                             , o_fila("Ocupacion").ToString _
                             , o_fila("IndRuta") _
                             , o_fila("IndEstado") _
                             , o_fila("IndHijo") _
                             , o_fila("IdEmpresaAFP") _
                             , o_fila("EmpresaAFP") _
                             , o_fila("IndTipoAFP") _
                             , o_fila("IndTipoAux") _
                             , o_fila("DiasFaltas") _
                             , o_fila("DiasDescanso") _
                             , o_fila("DiasVacaciones") _
                             , o_fila("DiasCompra") _
                             , o_fila("IdCuentaCorriente").ToString _
                             , o_fila("CuentaCorriente").ToString _
                             , o_fila("IdBanco").ToString _
                             , o_fila("Ingresos") _
                             , o_fila("Deducciones") _
                             , o_fila("Aportes") _
                             , o_fila("ImportePagar") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo") _
            )

            oeDetallePlanilla.IsPagado = IIf(IsNumeric(o_fila("IsPagado")), o_fila("IsPagado"), False)
            oeDetallePlanilla.IndTipo = IIf(IsNumeric(o_fila("IndTipo")), o_fila("IndTipo"), -1)
            oeDetallePlanilla.Gerencia = IIf(Not o_fila("Gerencia") Is DBNull.Value, o_fila("Gerencia"), "NO ASIGNADO")
            oeDetallePlanilla.Unidad = IIf(Not o_fila("Unidad") Is DBNull.Value, o_fila("Unidad"), "NO ASIGNADO")
            Return oeDetallePlanilla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetallePlanilla As e_DetallePlanilla) As e_DetallePlanilla

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_DetallePlanilla_Listar", "", oeDetallePlanilla.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeDetallePlanilla = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDetallePlanilla
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetallePlanilla As e_DetallePlanilla) As List(Of e_DetallePlanilla)
        Try
            Dim ldDetallePlanilla As New List(Of e_DetallePlanilla)
            Dim ds As DataSet
            With oeDetallePlanilla
                ds = sqlhelper.ExecuteDataset("PER.Isp_DetallePlanilla_Listar", .TipoOperacion _
                        , .Id _
                        , .IdPlanilla _
                        , .IdTrabajador _
                        , .Ingresos _
                        , .Deducciones _
                        , .Aportes _
                        , .ImportePagar _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                        )
            End With
            oeDetallePlanilla = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeDetallePlanilla = Cargar(o_Fila)
                ldDetallePlanilla.Add(oeDetallePlanilla)
            Next
            Return ldDetallePlanilla
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetallePlanilla As e_DetallePlanilla) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeDetallePlanilla
                sqlhelper.ExecuteNonQuery("PER.Isp_DetallePlanilla_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdPlanilla _
                        , .IdTrabajador _
                        , .IdCentro _
                        , .IdArea _
                        , .IdOcupacion _
                        , .IndRuta _
                        , .IndEstado _
                        , .IndHijo _
                        , .IdEmpresaAFP _
                        , .IndTipoAFP _
                        , .IndTipoAux _
                        , .DiasFaltas _
                        , .DiasDescanso _
                        , .DiasVacaciones _
                        , .DiasCompra _
                        , .IdCuentaCorriente _
                        , .Ingresos _
                        , .Deducciones _
                        , .Aportes _
                        , .ImportePagar _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                        , .IsPagado _
                        , .IndTipo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarMasivo(ByVal dtDetallePlanilla As DataTable) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            sqlhelper.InsertarMasivo("PER.DetallePlanilla", dtDetallePlanilla)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetallePlanilla As e_DetallePlanilla) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_DetallePlanilla_IAE", "E", _
             "", oeDetallePlanilla.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function UltimoIdInserta() As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "PER.DetallePlanilla", d_DatosConfiguracion.PrefijoID)
            Return stResultado
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
