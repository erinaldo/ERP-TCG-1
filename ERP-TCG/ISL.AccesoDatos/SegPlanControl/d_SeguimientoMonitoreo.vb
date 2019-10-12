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

Public Class d_SeguimientoMonitoreo
    Private sqlhelper As New SqlHelper
    Dim odOperacion As New d_Operacion
    Dim odSeguimiento As New d_Seguimiento

    Private Function Cargar(ByVal o_fila As DataRow) As e_SeguimientoMonitoreo
        Try
            Dim oeSeguimientoMonitoreo = New e_SeguimientoMonitoreo()
            oeSeguimientoMonitoreo.Seleccion = False
            oeSeguimientoMonitoreo.Id = o_fila("Id").ToString.Trim
            oeSeguimientoMonitoreo.Codigo = o_fila("Codigo").ToString.Trim
            oeSeguimientoMonitoreo.IdViaje = o_fila("IdViaje").ToString.Trim
            oeSeguimientoMonitoreo.IdOperador = o_fila("IdOperador").ToString.Trim
            oeSeguimientoMonitoreo.Operador = o_fila("Operador").ToString.Trim
            oeSeguimientoMonitoreo.Fecha = o_fila("Fecha").ToString.Trim
            oeSeguimientoMonitoreo.FechaAproxLlegada = o_fila("FechaAproxLlegada").ToString.Trim
            oeSeguimientoMonitoreo.FechaEntrega = o_fila("FechaEntrega").ToString.Trim
            oeSeguimientoMonitoreo.Glosa = o_fila("Glosa").ToString.Trim
            oeSeguimientoMonitoreo.IdUbicacion = o_fila("IdUbicacion").ToString.Trim
            oeSeguimientoMonitoreo.Ubicacion = o_fila("Ubicacion").ToString.Trim
            oeSeguimientoMonitoreo.ReferenciaLugar = o_fila("ReferenciaLugar").ToString.Trim
            oeSeguimientoMonitoreo.Estado = o_fila("Estado").ToString.Trim
            oeSeguimientoMonitoreo.NombreEstado = o_fila("NombreEstado").ToString.Trim
            oeSeguimientoMonitoreo.FechaCreacion = o_fila("FechaCreacion").ToString.Trim
            oeSeguimientoMonitoreo.UsuarioCreacion = o_fila("UsuarioCreacion").ToString.Trim
            oeSeguimientoMonitoreo.Activo = o_fila("Activo").ToString.Trim
            oeSeguimientoMonitoreo.FechaModifica = o_fila("FechaModifica").ToString.Trim
            oeSeguimientoMonitoreo.UsuarioModifica = o_fila("UsuarioModifica").ToString.Trim


            Dim objViaje As New e_Viaje
            objViaje.Id = oeSeguimientoMonitoreo.IdViaje.Trim
            'objViaje.TipoOperacion = "G"
            objViaje.TipoOperacion = "0"
            oeSeguimientoMonitoreo.oeViaje = odOperacion.ObtenerViaje(objViaje)

            Dim objSeguimiento As New e_Seguimiento
            Dim lisSeguimiento As New List(Of e_Seguimiento)
            objSeguimiento.IdViaje = oeSeguimientoMonitoreo.IdViaje.Trim
            objSeguimiento.TipoOperacion = ""
            lisSeguimiento = odSeguimiento.Listar(objSeguimiento)
            oeSeguimientoMonitoreo.oeSeguimiento = lisSeguimiento(0)

            Return oeSeguimientoMonitoreo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeSeguimientoMonitoreo As e_SeguimientoMonitoreo) As e_SeguimientoMonitoreo
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SPC.Isp_SeguimientoMonitoreo_Listar", oeSeguimientoMonitoreo.TipoOperacion, oeSeguimientoMonitoreo.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeSeguimientoMonitoreo = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeSeguimientoMonitoreo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeSeguimientoMonitoreo As e_SeguimientoMonitoreo) As List(Of e_SeguimientoMonitoreo)
        Try
            Dim ldSeguimientoMonitoreo As New List(Of e_SeguimientoMonitoreo)
            Dim ds As DataSet
            With oeSeguimientoMonitoreo
                ds = sqlhelper.ExecuteDataset("SPC.Isp_SeguimientoMonitoreo_Listar", .TipoOperacion _
                        , .Id _
                        , .Codigo _
                        , .IdViaje _
                        , .IdOperador _
                        , .IdUbicacion _
                        , .Estado _
                        , .FechaDesde _
                        , .FechaHasta _
                        )
            End With
            oeSeguimientoMonitoreo = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeSeguimientoMonitoreo = Cargar(o_Fila)
                ldSeguimientoMonitoreo.Add(oeSeguimientoMonitoreo)
            Next
            Return ldSeguimientoMonitoreo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeSeguimientoMonitoreo As e_SeguimientoMonitoreo) As Boolean
        Try
            Dim stResultado() As String
            With oeSeguimientoMonitoreo
                stResultado = sqlhelper.ExecuteScalar("SPC.Isp_SeguimientoMonitoreo_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .UsuarioCreacion _
                        , .Codigo _
                        , .IdViaje _
                        , .Fecha _
                        , .FechaAproxLlegada _
                        , .FechaEntrega _
                        , .IdUbicacion _
                        , .ReferenciaLugar _
                        , .IdOperador _
                        , .Glosa _
                        , .Estado _
                    ).ToString.Split("_")
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeSeguimientoMonitoreo As e_SeguimientoMonitoreo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SPC.Isp_SeguimientoMonitoreo_IAE", "E", _
             "", oeSeguimientoMonitoreo.Id, oeSeguimientoMonitoreo.UsuarioCreacion)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
