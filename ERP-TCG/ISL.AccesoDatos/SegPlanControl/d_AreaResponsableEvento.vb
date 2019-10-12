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

Public Class d_AreaResponsableEvento
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_AreaResponsableEvento
        Try
            Dim oeAreaResponsableEvento = New e_AreaResponsableEvento()
            oeAreaResponsableEvento.Id = o_fila("Id").ToString.Trim
            oeAreaResponsableEvento.Codigo = o_fila("Codigo").ToString.Trim
            oeAreaResponsableEvento.IdEvento = o_fila("IdEvento").ToString.Trim
            oeAreaResponsableEvento.IdTipoEvento = o_fila("IdTipoEvento").ToString.Trim
            oeAreaResponsableEvento.IdArea = o_fila("IdArea").ToString.Trim
            oeAreaResponsableEvento.Area = o_fila("Area").ToString.Trim
            oeAreaResponsableEvento.Glosa = o_fila("Glosa").ToString.Trim
            oeAreaResponsableEvento.IdEstado = o_fila("Estado").ToString.Trim
            oeAreaResponsableEvento.Estado = o_fila("NombreEstado").ToString.Trim
            oeAreaResponsableEvento.FechaCreacion = o_fila("FechaCreacion").ToString.Trim
            oeAreaResponsableEvento.UsuarioCreacion = o_fila("UsuarioCreacion").ToString.Trim
            oeAreaResponsableEvento.Activo = o_fila("Activo").ToString.Trim
            oeAreaResponsableEvento.FechaModifica = o_fila("FechaModifica").ToString.Trim
            oeAreaResponsableEvento.UsuarioModifica = o_fila("UsuarioModifica").ToString.Trim

            Dim odAlarma As New d_Alarma
            Dim odAccidente As New d_AccidenteIncidencia
            Dim odIncidente As New d_Incidente
            Dim odRobo As New d_Robo

            If oeAreaResponsableEvento.IdTipoEvento.Trim = "2" Then
                Dim oeAlarma As New e_Alarma
                oeAlarma.Id = oeAreaResponsableEvento.IdEvento
                oeAlarma = odAlarma.Obtener(oeAlarma)
                oeAreaResponsableEvento.CodigoEvento = oeAlarma.Codigo
                oeAreaResponsableEvento.IdViaje = oeAlarma.IdViaje
                oeAreaResponsableEvento.CodigoViaje = oeAlarma.CodigoViaje
                oeAreaResponsableEvento.Tracto = oeAlarma.Tracto
                oeAreaResponsableEvento.FechaIncidencia = oeAlarma.Fecha
                oeAreaResponsableEvento.Descripcion = oeAlarma.Descripcion
                oeAreaResponsableEvento.IdTipo = oeAlarma.IdTipo
                oeAreaResponsableEvento.Tipo = oeAlarma.Tipo
                oeAreaResponsableEvento.TipoEvento = oeAlarma.TipoEvento
            ElseIf oeAreaResponsableEvento.IdTipoEvento.Trim = "3" Then
                Dim oeAccidente As New e_AccidenteIncidencia
                oeAccidente.Id = oeAreaResponsableEvento.IdEvento
                oeAccidente = odAccidente.Obtener(oeAccidente)
                oeAreaResponsableEvento.CodigoEvento = oeAccidente.Codigo
                oeAreaResponsableEvento.IdViaje = oeAccidente.IdViaje
                oeAreaResponsableEvento.CodigoViaje = oeAccidente.CodigoViaje
                oeAreaResponsableEvento.Tracto = oeAccidente.Tracto
                oeAreaResponsableEvento.FechaIncidencia = oeAccidente.Fecha
                oeAreaResponsableEvento.Descripcion = oeAccidente.Descripcion
                oeAreaResponsableEvento.IdTipo = oeAccidente.IdTipo
                oeAreaResponsableEvento.Tipo = oeAccidente.Tipo
                oeAreaResponsableEvento.TipoEvento = oeAccidente.TipoEvento
            ElseIf oeAreaResponsableEvento.IdTipoEvento.Trim = "7" Then
                Dim oeIncidente As New e_Incidente
                oeIncidente.Id = oeAreaResponsableEvento.IdEvento
                oeIncidente = odIncidente.Obtener(oeIncidente)
                oeAreaResponsableEvento.CodigoEvento = oeIncidente.Codigo
                oeAreaResponsableEvento.IdViaje = oeIncidente.IdViaje
                oeAreaResponsableEvento.CodigoViaje = oeIncidente.CodigoViaje
                oeAreaResponsableEvento.Tracto = oeIncidente.Tracto
                oeAreaResponsableEvento.FechaIncidencia = oeIncidente.Fecha
                oeAreaResponsableEvento.Descripcion = oeIncidente.Descripcion
                oeAreaResponsableEvento.IdTipo = oeIncidente.IdTipo
                oeAreaResponsableEvento.Tipo = oeIncidente.Tipo
                oeAreaResponsableEvento.TipoEvento = oeIncidente.TipoEvento
            ElseIf oeAreaResponsableEvento.IdTipoEvento.Trim = "6" Then
                Dim oeRobo As New e_Robo
                oeRobo.Id = oeAreaResponsableEvento.IdEvento
                oeRobo = odRobo.Obtener(oeRobo)
                oeAreaResponsableEvento.CodigoEvento = oeRobo.Codigo
                oeAreaResponsableEvento.IdViaje = oeRobo.IdViaje
                oeAreaResponsableEvento.CodigoViaje = oeRobo.CodigoViaje
                oeAreaResponsableEvento.Tracto = oeRobo.Tracto
                oeAreaResponsableEvento.FechaIncidencia = oeRobo.Fecha
                oeAreaResponsableEvento.Descripcion = oeRobo.Descripcion
                oeAreaResponsableEvento.IdTipo = oeRobo.IdTipo
                oeAreaResponsableEvento.Tipo = oeRobo.Tipo
                oeAreaResponsableEvento.TipoEvento = oeRobo.TipoEvento
            End If
            Return oeAreaResponsableEvento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeAreaResponsableEvento As e_AreaResponsableEvento) As e_AreaResponsableEvento

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SPC.Isp_AreaResponsableEvento_Listar", "", oeAreaResponsableEvento.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeAreaResponsableEvento = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeAreaResponsableEvento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAreaResponsableEvento As e_AreaResponsableEvento) As List(Of e_AreaResponsableEvento)
        Try
            Dim ldAreaResponsableEvento As New List(Of e_AreaResponsableEvento)
            Dim ds As DataSet
            With oeAreaResponsableEvento
                ds = sqlhelper.ExecuteDataset("SPC.Isp_AreaResponsableEvento_Listar", "", .Id, .Codigo, .IdEvento, .IdArea, .IdTipoEvento, .UsuarioCreacion, .Activo)
            End With
            oeAreaResponsableEvento = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeAreaResponsableEvento = Cargar(o_Fila)
                ldAreaResponsableEvento.Add(oeAreaResponsableEvento)
            Next
            Return ldAreaResponsableEvento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAreaResponsableEvento As e_AreaResponsableEvento) As Boolean
        Try
            Dim stResultado() As String
            With oeAreaResponsableEvento
                stResultado = sqlhelper.ExecuteNonQuery("SPC.Isp_AreaResponsableEvento_IAE", _
                                                        .TipoOperacion, _
                                                        .PrefijoID, _
                                                        .Id, _
                                                        .Codigo, _
                                                        .IdEvento, _
                                                        .IdArea.Trim, _
                                                        .IdTipoEvento.Trim, _
                                                        .Glosa, _
                                                        .UsuarioCreacion, _
                                                        .Activo).ToString.Split("_")
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarGlosa(ByVal oeAreaResponsableEvento As e_AreaResponsableEvento) As Boolean
        Try
            Dim stResultado() As String
            With oeAreaResponsableEvento
                stResultado = sqlhelper.ExecuteNonQuery("SPC.Isp_AreaResponsableEvento_IAE", _
                                                        .TipoOperacion, _
                                                        "", _
                                                        .Id, _
                                                        "", _
                                                        "", _
                                                        "", _
                                                        "".Trim, _
                                                        .Glosa, _
                                                        .UsuarioCreacion, _
                                                        1).ToString.Split("_")
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarEstado(ByVal oeAreaResponsableEvento As e_AreaResponsableEvento) As Boolean
        Try
            Dim stResultado() As String
            With oeAreaResponsableEvento
                stResultado = sqlhelper.ExecuteNonQuery("SPC.Isp_AreaResponsableEvento_IAE", _
                                                        .TipoOperacion, _
                                                        "", _
                                                        .Id, _
                                                        "", _
                                                        "", _
                                                        "", _
                                                        "", _
                                                        .Glosa, _
                                                        .UsuarioCreacion, _
                                                        1, _
                                                        .IdEstado).ToString.Split("_")
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeAreaResponsableEvento As e_AreaResponsableEvento) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SPC.Isp_AreaResponsableEvento_IAE", "E", _
             "", oeAreaResponsableEvento.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
