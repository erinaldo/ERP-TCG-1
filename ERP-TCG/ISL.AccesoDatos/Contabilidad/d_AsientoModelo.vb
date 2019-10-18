Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_AsientoModelo

    Private sqlhelper As New SqlHelper
    Private oeDetalle As New e_DetalleAsientoModelo, odDetalle As New d_DetalleAsientoModelo
    Private oeAMActividad As New e_AsientoModelo_ActividadNegocio, odAMActividad As New d_AsientoModelo_ActividadNegocio
    Private oeAMReferencia As New e_AsientoModelo_Referencia, odAMReferencia As New d_AsientoModelo_Referencia
    Private oeDMReferencia As New e_DetalleModelo_Referencia, odDMReferencia As New d_DetalleModelo_Referencia

    Private Function Cargar(ByVal o_fila As DataRow) As e_AsientoModelo
        Try
            Dim oeAsientoModelo = New e_AsientoModelo( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("Moneda").ToString _
                             , o_fila("Cuentas").ToString _
                             , o_fila("IdTipoAsiento").ToString _
                             , o_fila("TipoAsiento").ToString _
                             , o_fila("IdVinculado").ToString _
                             , o_fila("Fila").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioModificacion").ToString _
                             , o_fila("FechaModificacion") _
                             , o_fila("Activo") _
            )
            Return oeAsientoModelo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeAsientoModelo As e_AsientoModelo) As e_AsientoModelo
        Try
            Dim ds As DataSet
            Dim ln_Ejercicio As Integer = oeAsientoModelo.Ejercicio
            With oeAsientoModelo
                ds = sqlhelper.ExecuteDataset("CON.Isp_AsientoModelo_Listar", .TipoOperacion, .Id)
            End With
            If ds.Tables(0).rows.Count > 0 Then
                oeAsientoModelo = Cargar(ds.Tables(0).Rows(0))
                'Cargar Detalles de Asiento Modelo
                oeDetalle = New e_DetalleAsientoModelo
                oeDetalle.TipoOperacion = "" : oeDetalle.Activo = True
                oeDetalle.IdAsientoModelo = oeAsientoModelo.Id : oeDetalle.Ejercicio = ln_Ejercicio
                oeAsientoModelo.leDetalle = odDetalle.Listar(oeDetalle)
                'Cargar Actividades de Asiento Modelo
                oeAMActividad = New e_AsientoModelo_ActividadNegocio
                oeAMActividad.TipoOperacion = "" : oeAMActividad.Activo = True
                oeAMActividad.IdAsientoModelo = oeAsientoModelo.Id
                oeAsientoModelo.leAMActiviad = odAMActividad.Listar(oeAMActividad)
                'Cargar Referencias de Asiento Modelo
                oeAMReferencia = New e_AsientoModelo_Referencia
                oeAMReferencia.TipoOperacion = "A" : oeAMReferencia.Activo = True
                oeAMReferencia.IdReferencia = oeAsientoModelo.Id
                oeAsientoModelo.leAMReferencia = odAMReferencia.Listar(oeAMReferencia)
                ' Cargar Referencias de Detalle Asiento Modelo
                oeDMReferencia = New e_DetalleModelo_Referencia
                oeDMReferencia.TipoOperacion = "A" : oeDMReferencia.Activo = True
                oeDMReferencia.Observacion = oeAsientoModelo.Id
                oeAsientoModelo.leDMReferencia = odDMReferencia.Listar(oeDMReferencia)
            End If
            Return oeAsientoModelo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAsientoModelo As e_AsientoModelo) As List(Of e_AsientoModelo)
        Try
            Dim ldAsientoModelo As New List(Of e_AsientoModelo)
            Dim ds As DataSet
            With oeAsientoModelo
                ds = sqlhelper.ExecuteDataset("CON.Isp_AsientoModelo_Listar", .TipoOperacion _
                        , .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .IdMoneda _
                        , .Cuentas _
                        , .IdTipoAsiento _
                        , .IdVinculado _
                        , .Fila _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .UsuarioModificacion _
                        , .FechaModificacion _
                        , .Activo _
                        )
            End With
            oeAsientoModelo = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeAsientoModelo = Cargar(o_Fila)
                ldAsientoModelo.Add(oeAsientoModelo)
            Next
            Return ldAsientoModelo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAsientoModelo As e_AsientoModelo) As Boolean
        Try
            Dim _idAM() As String
            Using TransScope As New TransactionScope()
                With oeAsientoModelo
                    _idAM = sqlhelper.ExecuteScalar("CON.Isp_AsientoModelo_IAE", .TipoOperacion, .PrefijoID,
                            .Id _
                            , .Codigo _
                            , .Nombre _
                            , .Abreviatura _
                            , .IdMoneda _
                            , .Cuentas _
                            , .IdTipoAsiento _
                            , .IdVinculado _
                            , .Fila _
                            , .UsuarioCreacion _
                            , .FechaCreacion _
                            , .UsuarioModificacion _
                            , .FechaModificacion _
                            , .Activo
                        ).ToString.Split("_")
                    'Guadar Detalle de Asiento Modelo
                    For Each oeDet In .leDetalle
                        oeDet.IdAsientoModelo = _idAM(0)
                        oeDet.leDMReferencia = .leDMReferencia.Where(Function(it) it.Fila = oeDet.Codigo).ToList
                        oeDet.PrefijoID = oeAsientoModelo.PrefijoID '@0001
                        Select Case oeDet.TipoOperacion
                            Case "I", "A" : odDetalle.Guardar(oeDet)
                            Case "E" : odDetalle.Eliminar(oeDet)
                        End Select
                    Next
                    'Guardar Actividad de Asiento Modelo
                    For Each oeActividad In .leAMActiviad
                        oeActividad.IdAsientoModelo = _idAM(0)
                        oeActividad.leReferencia = .leAMReferencia.Where(Function(it) it.IdActividad = oeActividad.IdActividadNegocio).ToList
                        oeActividad.PrefijoID = oeAsientoModelo.PrefijoID '@0001
                        Select Case oeActividad.TipoOperacion
                            Case "I", "A" : odAMActividad.Guardar(oeActividad)
                            Case "E" : odAMActividad.Eliminar(oeActividad)
                        End Select
                    Next
                End With
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeAsientoModelo As e_AsientoModelo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_AsientoModelo_IAE", "E", _
             "", oeAsientoModelo.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
