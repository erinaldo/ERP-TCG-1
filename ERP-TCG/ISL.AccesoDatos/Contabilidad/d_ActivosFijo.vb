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

Public Class d_ActivosFijo

    Private sqlhelper As New SqlHelper
    Private odAFCuentaContable As New d_ActivoFijo_CuentaContable
    Private odDepreciacionAF As New d_DepreciacionActivoFijo
    Private odReadecuacionAF As New d_ReadecuacionActivoFijo
    Private odAsiento As New d_Asiento


    Private Function Cargar(Fila As DataRow) As e_ActivoFijo
        Try
            Dim oeActivoFijo = New e_ActivoFijo With {
                             .Id = Fila("Id").ToString() _
                             , .IdSedeEmpresa = Fila("IdSedeEmpresa").ToString().Trim() _
                             , .IdResponsable = Fila("IdResponsable").ToString() _
                             , .Codigo = Fila("Codigo").ToString() _
                             , .IdEstado = Fila("IdEstado").ToString() _
                             , .FechaPropiedad = Fila("FechaPropiedad") _
                             , .IdPropiedadActual = Fila("IdPropiedadActual").ToString() _
                             , .DescripcionResumida = Fila("DescripcionResumida").ToString() _
                             , .DescripcionDetallada = Fila("DescripcionDetallada").ToString() _
                             , .IdPeriodo = Fila("IdPeriodo").ToString() _
                             , .FechaIngreso = Fila("FechaIngreso") _
                             , .IndFecActivacion = Fila("IndFecActivacion") _
                             , .FechaActivacion = Fila("FechaActivacion") _
                             , .IdConceptoIngreso = Fila("IdConceptoIngreso").ToString() _
                             , .IdGrupoActivo = Fila("IdGrupoActivo").ToString() _
                             , .IdSubGrupoActivo = Fila("IdSubGrupoActivo").ToString() _
                             , .IdModelo = Fila("IdModelo").ToString() _
                             , .IdCentroCosto = Fila("IdCentroCosto").ToString() _
                             , .IdUbicacion = Fila("IdUbicacion").ToString() _
                             , .IdMaterial = Fila("IdMaterial").ToString() _
                             , .Cantidad = Fila("Cantidad") _
                             , .IndDepreciable = Fila("IndDepreciable") _
                             , .IndRevalorizable = Fila("IndRevalorizable") _
                             , .IndPertenencia = Fila("IndPertenencia") _
                             , .VidaUtil = Fila("VidaUtil") _
                             , .FechaCompra = Fila("FechaCompra") _
                             , .IndDocumento = Fila("IndDocumento") _
                             , .IdDocumento = Fila("IdDocumento").ToString().Trim() _
                             , .ValorCompra = Fila("ValorCompra") _
                             , .FechaSituacion = Fila("FechaSituacion") _
                             , .ValorLibro = Fila("ValorLibro") _
                             , .RevalorizacionAcumulada = Fila("RevalorizacionAcumulada") _
                             , .DepreciacionAcumulada = Fila("DepreciacionAcumulada") _
                             , .VidaUtilRemanente = Fila("VidaUtilRemanente") _
                             , .AnhoMesRevalorizacion = Fila("AnhoMesRevalorizacion") _
                             , .AnhoMesDepreciacion = Fila("AnhoMesDepreciacion") _
                             , .IndBaja = Fila("IndBaja") _
                             , .FechaBaja = Fila("FechaBaja") _
                             , .IdConceptoBaja = Fila("IdConceptoBaja").ToString() _
                             , .DescripcionBaja = Fila("DescripcionBaja").ToString() _
                             , .FichaTecnica = Fila("FichaTecnica") _
                             , .Activo = Fila("Activo") _
                             , .UsuarioCreacion = Fila("UsuarioCreacion").ToString() _
                             , .FechaCreacion = Fila("FechaCreacion") _
                             , .UsuarioModificacion = Fila("UsuarioModificacion").ToString() _
                             , .FechaModificacion = Fila("FechaModificacion") _
                             , .Periodo = Fila("Periodo").ToString() _
                             , .GrupoActivo = Fila("GrupoActivo").ToString() _
                             , .SubGrupoActivo = Fila("SubGrupoActivo").ToString() _
                             , .ValorResidual = Fila("ValorResidual") _
                             , .IndReclasificado = Fila("IndReclasificado") _
                             , .IdAFReclasifica = Fila("IdAFReclasifica").ToString() _
                             , .IdDocumentoBaja = Fila("IdDocumentoBaja").ToString() _
                             , .IdAsientoBaja = Fila("IdAsientoBaja").ToString() _
                             , .IdAsientoReclasificacion = Fila("IdAsientoReclasificacion").ToString() _
                             , .Depreciacion2014 = Fila("Dep2014") _
                             , .Depreciacion2015 = Fila("Dep2015") _
                             , .Costo2012 = Fila("Costo2012") _
                           , .IdActivoFijoDepende = Fila("IdActivoFijoDepende") _
            }
            Return oeActivoFijo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ExecuteLST(oeActivoFijo As e_ActivoFijo) As DataSet
        Try
            Dim ds As DataSet
            With oeActivoFijo
                ds = sqlhelper.ExecuteDataset("[CON].[Isp_ActivoFijo_Listar]" _
                        , .TipoOperacion _
                        , .Id _
                        , .IdSedeEmpresa _
                        , .IdResponsable _
                        , .Codigo _
                        , .IdEstado _
                        , .FechaPropiedad _
                        , .IdPropiedadActual _
                        , .DescripcionResumida _
                        , .DescripcionDetallada _
                        , .IdPeriodo _
                        , .FechaIngreso _
                        , .IndFecActivacion _
                        , .FechaActivacion _
                        , .IdConceptoIngreso _
                        , .IdGrupoActivo _
                        , .IdSubGrupoActivo _
                        , .IdModelo _
                        , .IdCentroCosto _
                        , .IdUbicacion _
                        , .IdMaterial _
                        , .Cantidad _
                        , .IndDepreciable _
                        , .IndRevalorizable _
                        , .IndPertenencia _
                        , .VidaUtil _
                        , .FechaCompra _
                        , .IndDocumento _
                        , .IdDocumento _
                        , .ValorCompra _
                        , .FechaSituacion _
                        , .ValorLibro _
                        , .RevalorizacionAcumulada _
                        , .DepreciacionAcumulada _
                        , .VidaUtilRemanente _
                        , .AnhoMesRevalorizacion _
                        , .AnhoMesDepreciacion _
                        , .IndBaja _
                        , .FechaBaja _
                        , .IdConceptoBaja _
                        , .DescripcionBaja _
                        , .FichaTecnica _
                        , .Activo _
                        , .ValorResidual
                        )
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oeActivoFijo As e_ActivoFijo) As e_ActivoFijo
        Try
            Dim ds As DataSet = ExecuteLST(oeActivoFijo)
            If ds.Tables(0).rows.Count > 0 Then
                oeActivoFijo = Cargar(ds.Tables(0).Rows(0))
            Else
                oeActivoFijo = New e_ActivoFijo
            End If
            Return oeActivoFijo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

   Public Function Listar(oeActivoFijo As e_ActivoFijo) As List(Of e_ActivoFijo)
        Try
            Dim lstActivoFijo As New List(Of e_ActivoFijo)
            Dim ds As DataSet = ExecuteLST(oeActivoFijo)
            oeActivoFijo = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeActivoFijo = Cargar(o_Fila)
                    lstActivoFijo.Add(oeActivoFijo)
                Next
            End If
            Return lstActivoFijo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeActivoFijo As e_ActivoFijo) As Boolean
        Try
            Using transScope As New TransactionScope()
                With oeActivoFijo
                    Dim IdAsientoReclasificacion As String = String.Empty
                    If oeActivoFijo.IndReclasificando Then
                        IdAsientoReclasificacion = oeActivoFijo.IdAsientoReclasificacion
                        oeActivoFijo.IdAsientoReclasificacion = String.Empty
                    End If
                    Dim IdResultado As String
                    IdResultado = sqlhelper.ExecuteScalar("[CON].[Isp_ActivoFijo_IAE]" _
                                , .TipoOperacion _
                                , .PrefijoID _
                                , .Id _
                                , .IdSedeEmpresa _
                                , .IdResponsable _
                                , .Codigo _
                                , .IdEstado _
                                , .FechaPropiedad _
                                , .IdPropiedadActual _
                                , .DescripcionResumida _
                                , .DescripcionDetallada _
                                , .IdPeriodo _
                                , .FechaIngreso _
                                , .IndFecActivacion _
                                , .FechaActivacion _
                                , .IdConceptoIngreso _
                                , .IdGrupoActivo _
                                , .IdSubGrupoActivo _
                                , .IdModelo _
                                , .IdCentroCosto _
                                , .IdUbicacion _
                                , .IdMaterial _
                                , .Cantidad _
                                , .IndDepreciable _
                                , .IndRevalorizable _
                                , .IndPertenencia _
                                , .VidaUtil _
                                , .FechaCompra _
                                , .IndDocumento _
                                , .IdDocumento _
                                , .ValorCompra _
                                , .FechaSituacion _
                                , .ValorLibro _
                                , .RevalorizacionAcumulada _
                                , .DepreciacionAcumulada _
                                , .VidaUtilRemanente _
                                , .AnhoMesRevalorizacion _
                                , .AnhoMesDepreciacion _
                                , .IndBaja _
                                , .FechaBaja _
                                , .IdConceptoBaja _
                                , .DescripcionBaja _
                                , .FichaTecnica _
                                , .Activo _
                                , .UsuarioCreacion _
                                , .ValorResidual _
                                , .IndReclasificado _
                                , .IdAFReclasifica _
                                , .IdDocumentoBaja _
                                , .IdAsientoBaja _
                                , .IdAsientoReclasificacion _
                                , .Depreciacion2014 _
                                , .Depreciacion2015 _
                                , .Costo2012 _
                                , .IdActivoFijoDepende _
                            ).ToString()
                    .Id = IdResultado
                    For Each AFCuentaContable As e_ActivoFijo_CuentaContable In .ListAF_CuentaContable
                        Dim lb_Readeacuacion As Boolean = False
                        With AFCuentaContable
                            .UsuarioCreacion = oeActivoFijo.UsuarioCreacion
                            .PrefijoID = oeActivoFijo.PrefijoID '@0001
                            If .TipoOperacion = "E" Then
                                odAFCuentaContable.Eliminar(AFCuentaContable)
                            Else
                                lb_Readeacuacion = AFCuentaContable.IndReadecuacion
                                .TipoOperacion = "I"
                                .IdActivoFijo = oeActivoFijo.Id
                                odAFCuentaContable.Guardar(AFCuentaContable)
                            End If
                        End With
                    Next
                    For Each Readecuacion As e_ReadecuacionActivoFijo In .ListReadecuacionAF
                        With Readecuacion
                            .UsuarioCreacion = oeActivoFijo.UsuarioCreacion
                            .PrefijoID = oeActivoFijo.PrefijoID '@0001
                            If .TipoOperacion = "E" Then
                                odReadecuacionAF.Eliminar(Readecuacion)
                            Else
                                .TipoOperacion = "I"
                                .IdActivoFijo = oeActivoFijo.Id
                                odReadecuacionAF.Guardar(Readecuacion)
                            End If
                        End With
                    Next
                    If .IndReclasificando Then
                        'Actualizar el IndReclasificado y el IdAFReclasifica
                        Dim oeAFReclasificado As New e_ActivoFijo
                        oeAFReclasificado.TipoOperacion = "R"
                        oeAFReclasificado.Id = .IdAFReclasificado
                        oeAFReclasificado.IndReclasificado = True
                        oeAFReclasificado.IdAFReclasifica = .Id
                        oeAFReclasificado.UsuarioCreacion = .UsuarioCreacion
                        oeAFReclasificado.IdAsientoReclasificacion = IdAsientoReclasificacion
                        oeAFReclasificado.PrefijoID = oeActivoFijo.PrefijoID '@0001
                        Guardar(oeAFReclasificado)
                    End If
                End With
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeActivoFijo As e_ActivoFijo) As Boolean
        Try
            'Using transScope As New TransactionScope()
            'If oeActivoFijo.ListDepreciacionAF.Count > 0 Then
            '    For Each Depreciacion As e_DepreciacionActivoFijo In oeActivoFijo.ListDepreciacionAF
            '        Depreciacion.TipoOperacion = "E"
            '        Depreciacion.UsuarioCreacion = oeActivoFijo.UsuarioCreacion
            '        odDepreciacionAF.Eliminar(Depreciacion)
            '    Next
            '    odAsiento.Eliminar(oeActivoFijo.AsientoAF)
            'Else
            With oeActivoFijo
                sqlhelper.ExecuteNonQuery("[CON].[Isp_ActivoFijo_IAE]" _
                                           , "E" _
                                           , "" _
                                           , .Id _
                                           , .IdSedeEmpresa _
                                           , .IdResponsable _
                                           , .Codigo _
                                           , .IdEstado _
                                           , .FechaPropiedad _
                                           , .IdPropiedadActual _
                                           , .DescripcionResumida _
                                           , .DescripcionDetallada _
                                           , .IdPeriodo _
                                           , .FechaIngreso _
                                           , .IndFecActivacion _
                                           , .FechaActivacion _
                                           , .IdConceptoIngreso _
                                           , .IdGrupoActivo _
                                           , .IdSubGrupoActivo _
                                           , .IdModelo _
                                           , .IdCentroCosto _
                                           , .IdUbicacion _
                                           , .IdMaterial _
                                           , .Cantidad _
                                           , .IndDepreciable _
                                           , .IndRevalorizable _
                                           , .IndPertenencia _
                                           , .VidaUtil _
                                           , .FechaCompra _
                                           , .IndDocumento _
                                           , .IdDocumento _
                                           , .ValorCompra _
                                           , .FechaSituacion _
                                           , .ValorLibro _
                                           , .RevalorizacionAcumulada _
                                           , .DepreciacionAcumulada _
                                           , .VidaUtilRemanente _
                                           , .AnhoMesRevalorizacion _
                                           , .AnhoMesDepreciacion _
                                           , .IndBaja _
                                           , .FechaBaja _
                                           , .IdConceptoBaja _
                                           , .DescripcionBaja _
                                           , .FichaTecnica _
                                           , .Activo _
                                           , .UsuarioCreacion _
                                           , .ValorResidual _
                                           , .IndReclasificado _
                                           , .IdAFReclasifica _
                                           , .Depreciacion2014 _
                                           , .Depreciacion2015 _
                                           , .Costo2012 _
                                       )
            End With
            'End If
            'transScope.Complete()
            Return True
            'End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class

