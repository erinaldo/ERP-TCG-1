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

Public Class d_DetallePlanillaVacaciones

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_DetallePlanillaVacaciones
        Try
            Dim oeDetallePlanillaVacaciones = New e_DetallePlanillaVacaciones( _
                             o_fila("Id").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Dni").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("IdPlanillaVacaciones").ToString _
                             , o_fila("Sueldo") _
                             , o_fila("AsignacionFamiliar") _
                             , o_fila("Produccion1") _
                             , o_fila("Produccion2") _
                             , o_fila("Produccion3") _
                             , o_fila("Produccion4") _
                             , o_fila("Produccion5") _
                             , o_fila("Produccion6") _
                             , o_fila("IndPromBono") _
                             , o_fila("DiasVacaciones") _
                             , o_fila("TotalPagar") _
                             , o_fila("IndAdelanto") _
                             , o_fila("MontoAdelanto") _
                             , o_fila("MontoDescuento") _
                             , o_fila("DiasComprados") _
                             , o_fila("MontoComprado") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo") _
            )
            Return oeDetallePlanillaVacaciones
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetallePlanillaVacaciones As e_DetallePlanillaVacaciones) As e_DetallePlanillaVacaciones

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_DetallePlanillaVacaciones_Listar", "", oeDetallePlanillaVacaciones.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeDetallePlanillaVacaciones = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDetallePlanillaVacaciones
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetallePlanillaVacaciones As e_DetallePlanillaVacaciones) As List(Of e_DetallePlanillaVacaciones)
        Try
            Dim ldPlanillaVacaciones As New List(Of e_DetallePlanillaVacaciones)
            Dim ds As DataSet
            With oeDetallePlanillaVacaciones
                ds = sqlhelper.ExecuteDataset("PER.Isp_DetallePlanillaVacaciones_Listar", .TipoOperacion _
                        , .Id _
                        , .IdTrabajador _
                        , .IdPlanillaVacaciones _
                        , .Sueldo _
                        , .AsignacionFamiliar _
                        , .Produccion1 _
                        , .Produccion2 _
                        , .Produccion3 _
                        , .Produccion4 _
                        , .Produccion5 _
                        , .Produccion6 _
                        , .DiasVacaciones _
                        , .TotalPagar _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                        )
            End With
            oeDetallePlanillaVacaciones = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeDetallePlanillaVacaciones = Cargar(o_Fila)
                ldPlanillaVacaciones.Add(oeDetallePlanillaVacaciones)
            Next
            Return ldPlanillaVacaciones
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetallePlanillaVacaciones As e_DetallePlanillaVacaciones) As Boolean
        Try
            With oeDetallePlanillaVacaciones
                sqlhelper.ExecuteNonQuery("PER.Isp_DetallePlanillaVacaciones_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdTrabajador _
                        , .IdPlanillaVacaciones _
                        , .Sueldo _
                        , .AsignacionFamiliar _
                        , .Produccion1 _
                        , .Produccion2 _
                        , .Produccion3 _
                        , .Produccion4 _
                        , .Produccion5 _
                        , .Produccion6 _
                        , .IndPromBono _
                        , .DiasVacaciones _
                        , .TotalPagar _
                        , .IndAdelanto _
                        , .MontoAdelanto _
                        , .MontoDescuento _
                        , .DiasComprados _
                        , .MontoComprado _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetallePlanillaVacaciones As e_DetallePlanillaVacaciones) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_DetallePlanillaVacaciones_IAE", "E", _
             "", oeDetallePlanillaVacaciones.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
