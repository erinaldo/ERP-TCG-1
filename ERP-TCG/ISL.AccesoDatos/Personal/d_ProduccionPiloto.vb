Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ProduccionPiloto

    Private sqlhelper As New SqlHelper
    Private oeDetPP As New e_DetalleProduccionPiloto, odDetPP As New d_DetalleProduccionPiloto
    Private oeBonoProd As New e_BonificacionProduccion, odBonoProd As New d_BonificacionProduccion

    Private Function Cargar(ByVal o_fila As DataRow) As e_ProduccionPiloto
        Try
            Dim oeProduccionPiloto = New e_ProduccionPiloto( _
                             o_fila("Id").ToString _
                             , o_fila("IdPlanilla").ToString _
                             , o_fila("Planilla").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("IdConceptoPonderado").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Monto") _
                             , o_fila("Descripcion").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo") _
            )
            Return oeProduccionPiloto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeProduccionPiloto As e_ProduccionPiloto) As e_ProduccionPiloto
        Try
            Dim ds As DataSet
            With oeProduccionPiloto
                ds = sqlhelper.ExecuteDataset("PER.Isp_ProduccionPiloto_Listar", .TipoOperacion _
                                         , .Id _
                                           , .IdPlanilla _
                                           , .IdEstado _
                                           , .Codigo _
                                           , .Monto _
                                           , .Descripcion _
                                           , .FechaCreacion _
                                           , .UsuarioCreacion _
                                           , .FechaModifica _
                                           , .UsuarioModifica _
                                           , .Activo _
                                           )
            End With
            If ds.Tables(0).rows.Count > 0 Then
                oeProduccionPiloto = Cargar(ds.Tables(0).Rows(0))
                If oeProduccionPiloto.Id <> "" Then
                    oeDetPP = New e_DetalleProduccionPiloto
                    oeDetPP.TipoOperacion = "" : oeDetPP.IdProduccionPiloto = oeProduccionPiloto.Id
                    oeDetPP.Activo = True : oeDetPP.IndRuta = -1
                    oeProduccionPiloto.leDetalle = odDetPP.Listar(oeDetPP)
                    oeBonoProd = New e_BonificacionProduccion
                    oeBonoProd.TipoOperacion = "" : oeBonoProd.IdPlanilla = oeProduccionPiloto.IdPlanilla : oeBonoProd.Activo = True
                    oeProduccionPiloto.leBonoProd = odBonoProd.Listar(oeBonoProd)
                End If
            End If
            Return oeProduccionPiloto
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeProduccionPiloto As e_ProduccionPiloto) As List(Of e_ProduccionPiloto)
        Try
            Dim ldProduccionPiloto As New List(Of e_ProduccionPiloto)
            Dim ds As DataSet
            With oeProduccionPiloto
                ds = sqlhelper.ExecuteDataset("PER.Isp_ProduccionPiloto_Listar", "" _
                        , .Id _
                        , .IdPlanilla _
                        , .IdEstado _
                        , .Codigo _
                        , .Monto _
                        , .Descripcion _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                        )
            End With
            oeProduccionPiloto = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeProduccionPiloto = Cargar(o_Fila)
                ldProduccionPiloto.Add(oeProduccionPiloto)
            Next
            Return ldProduccionPiloto
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeProduccionPiloto As e_ProduccionPiloto) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim _idpp As String = ""
            Using TransScope As New TransactionScope()
                With oeProduccionPiloto
                    _idpp = sqlhelper.ExecuteScalar("PER.Isp_ProduccionPiloto_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                            .Id _
                            , .IdPlanilla _
                            , .IdEstado _
                            , .IdConceptoPonderado _
                            , .Codigo _
                            , .Monto _
                            , .Descripcion _
                            , .FechaCreacion _
                            , .UsuarioCreacion _
                            , .FechaModifica _
                            , .UsuarioModifica _
                            , .Activo _
                        )

                    For Each oeDetAux In .leDetalle
                        oeDetAux.IdProduccionPiloto = _idpp
                        If oeDetAux.TipoOperacion <> "" Then
                            If oeDetAux.TipoOperacion = "E" Then
                                odDetPP.Eliminar(oeDetAux)
                            Else
                                odDetPP.Guardar(oeDetAux)
                            End If
                        End If
                    Next

                    For Each oeBPAux In .leBonoProd
                        oeBPAux.IdPlanilla = .IdPlanilla
                        If oeBPAux.TipoOperacion <> "" Then
                            If oeBPAux.TipoOperacion = "E" Then
                                odBonoProd.Eliminar(oeBPAux)
                            Else
                                odBonoProd.Guardar(oeBPAux)
                            End If
                        End If
                    Next

                    '''''''''''''''''''''''''''''''''''''''
                    'replicar faltas a movimiento personal 
                    ''''''''''''''''''''''''''''''''''''''''
                    'periodo                    
                    Dim oeResumenAsis As New e_ResumenAsistencia
                    Dim odResumenAsis As New d_ResumenAsistencia
                    Dim leResumenAsis As New List(Of e_ResumenAsistencia)

                    Dim diasNotrabajadosMP As Integer
                    Dim diasNotrabajadosBP As Integer
                    Dim diasDiferencias As Integer
                    Dim indicadorNuevo As Boolean
                    oeResumenAsis.TipoOperacion = ""
                    oeResumenAsis.Activo = True
                    oeResumenAsis.IdPlanilla = oeProduccionPiloto.IdPlanilla
                    oeResumenAsis.IndTipo = -1
                    oeResumenAsis.GozedeHaber = -1
                    leResumenAsis = odResumenAsis.Listar(oeResumenAsis)
                    'Dim listaAux = leResumenAsis.Where(Function(x) x.IndTipoAux <> 0 And x.IndTipo = 2)
                    For Each oeDetAux In .leDetalle
                        If oeDetAux.TipoOperacion <> "" And oeDetAux.IndRuta = 0 Then
                            'listaResumenAsisAux = New List(Of e_ResumenAsistencia)
                            Dim listaResumenAsisAux = leResumenAsis.Where(Function(x) x.IdTrabajador = oeDetAux.IdTrabajador)

                            If oeDetAux.TipoOperacion = "E" Then
                                'quitar faltas Por bono producción
                                For Each j In listaResumenAsisAux
                                    If j.Observacion = "POR BONO PRODUCCION" Then
                                        j.TipoOperacion = "E"
                                        j.UsuarioCreacion = oeDetAux.UsuarioModifica
                                        j.UsuarioModifica = oeDetAux.UsuarioModifica
                                        odResumenAsis.Eliminar(j)
                                    End If
                                Next
                            Else
                                diasNotrabajadosMP = 0
                                For Each i In listaResumenAsisAux
                                    If i.IndTipo = 2 And i.IndTipoAux = 1 Then Continue For
                                    diasNotrabajadosMP = diasNotrabajadosMP + i.Cantidad
                                Next
                                diasNotrabajadosBP = 30 - oeDetAux.DiasTrabajados
                                diasDiferencias = diasNotrabajadosBP - diasNotrabajadosMP
                                If diasDiferencias > 0 Then
                                    'agregamos falta
                                    indicadorNuevo = True
                                    For Each j In listaResumenAsisAux
                                        If j.Observacion = "POR BONO PRODUCCION" Then
                                            indicadorNuevo = False
                                            j.TipoOperacion = "A"
                                            j.Cantidad = j.Cantidad + diasDiferencias
                                            j.UsuarioCreacion = oeDetAux.UsuarioModifica
                                            j.UsuarioModifica = oeDetAux.UsuarioModifica
                                            odResumenAsis.Guardar(j)
                                            Exit For
                                        End If
                                    Next
                                    If indicadorNuevo Then
                                        oeResumenAsis = New e_ResumenAsistencia
                                        With oeResumenAsis
                                            .TipoOperacion = "I"
                                            .Id = String.Empty
                                            .IdTrabajador = oeDetAux.IdTrabajador
                                            .Trabajador = ""
                                            .Dni = ""
                                            .IndTipo = 0
                                            .CodigoSuspension = ""
                                            .Cantidad = diasDiferencias
                                            .FechaInicio = "01/01/1901"
                                            .FechaTermino = "01/01/1901"
                                            .Observacion = "POR BONO PRODUCCION"
                                            .DiasNetos = 0
                                            .IndTipoAux = 1
                                            .IdPlanilla = oeProduccionPiloto.IdPlanilla
                                            .UsuarioCreacion = oeDetAux.UsuarioCreacion
                                            .UsuarioModifica = oeDetAux.UsuarioCreacion
                                            .GozedeHaber = 0
                                            .IdEstado = "1CH00009"
                                            .Activo = True
                                        End With
                                        odResumenAsis.Guardar(oeResumenAsis)
                                    End If
                                End If
                                If diasDiferencias < 0 Then
                                    diasDiferencias = diasDiferencias * -1
                                    'quitamos falta
                                    indicadorNuevo = True
                                    For Each j In listaResumenAsisAux
                                        If j.Observacion = "POR BONO PRODUCCION" Then
                                            If j.Cantidad < diasDiferencias Then diasDiferencias = j.Cantidad
                                            indicadorNuevo = False
                                            j.TipoOperacion = "A"
                                            j.Cantidad = j.Cantidad - diasDiferencias
                                            j.UsuarioCreacion = oeDetAux.UsuarioModifica
                                            j.UsuarioModifica = oeDetAux.UsuarioModifica
                                            odResumenAsis.Guardar(j)
                                            Exit For
                                        End If
                                    Next
                                End If

                            End If
                        End If
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

    Public Function Eliminar(ByVal oeProduccionPiloto As e_ProduccionPiloto) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_ProduccionPiloto_IAE", "E", _
             "", oeProduccionPiloto.Id, "", "", "", "", 0, "", #1/1/1901#, "", #1/1/1901#, oeProduccionPiloto.UsuarioModifica)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
