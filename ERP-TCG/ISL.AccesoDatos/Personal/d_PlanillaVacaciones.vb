Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_PlanillaVacaciones

    Private sqlhelper As New SqlHelper
    Private oeDetalle As New e_DetallePlanillaVacaciones
    Private odDetalle As New d_DetallePlanillaVacaciones

    Private Function Cargar(ByVal o_fila As DataRow) As e_PlanillaVacaciones
        try
            Dim oePlanillaVacaciones = New e_PlanillaVacaciones( _
                             o_fila("Id").ToString _
                             , o_fila("IdPlanilla").ToString _
                             , o_fila("Planilla").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Monto") _
                             , o_fila("Descripcion").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo") _
            )
            Return oePlanillaVacaciones
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oePlanillaVacaciones As e_PlanillaVacaciones) As e_PlanillaVacaciones

        Try
            Dim ds As DataSet
            With oePlanillaVacaciones
                ds = sqlhelper.ExecuteDataset("PER.Isp_PlanillaVacaciones_Listar", .TipoOperacion, .Id, .IdPlanilla _
                        , .Codigo _
                        , .Monto _
                        , .Descripcion _
                        , .IdEstado _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oePlanillaVacaciones = Cargar(ds.Tables(0).Rows(0))
                oeDetalle = New e_DetallePlanillaVacaciones
                oeDetalle.TipoOperacion = ""
                oeDetalle.Activo = True
                oeDetalle.IdPlanillaVacaciones = oePlanillaVacaciones.Id
                oePlanillaVacaciones.leDetalle = odDetalle.Listar(oeDetalle)
            End If
            Return oePlanillaVacaciones
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oePlanillaVacaciones As e_PlanillaVacaciones) As List(Of e_PlanillaVacaciones)
        try
            Dim ldPlanillaVacaciones As New List(Of e_PlanillaVacaciones)
            Dim ds As DataSet
            With oePlanillaVacaciones
                ds = sqlhelper.ExecuteDataset("PER.Isp_PlanillaVacaciones_Listar", .TipoOperacion _
                        , .Id _
                        , .IdPlanilla _
                        , .Codigo _
                        , .Monto _
                        , .Descripcion _
                        , .IdEstado _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                        )
            End With
            oePlanillaVacaciones = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oePlanillaVacaciones = Cargar(o_Fila)
                ldPlanillaVacaciones.Add(oePlanillaVacaciones)
            Next
            Return ldPlanillaVacaciones
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oePlanillaVacaciones As e_PlanillaVacaciones) As Boolean
         try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim _idplavac As String = ""
            Using TransScope As New TransactionScope()
                With oePlanillaVacaciones
                    _idplavac = sqlhelper.ExecuteScalar("PER.Isp_PlanillaVacaciones_IAE", .TipoOperacion, .PrefijoID, _
                            .Id _
                            , .IdPlanilla _
                            , .Codigo _
                            , .Monto _
                            , .Descripcion _
                            , .IdEstado _
                            , .FechaCreacion _
                            , .UsuarioCreacion _
                            , .FechaModifica _
                            , .UsuarioModifica _
                            , .Activo _
                        )

                    For Each oeDet In .leDetalle
                        oeDet.IdPlanillaVacaciones = _idplavac
                        If oeDet.TipoOperacion <> "" Then
                            If oeDet.TipoOperacion = "E" Then
                                odDetalle.Eliminar(oeDet)
                            Else
                                odDetalle.Guardar(oeDet)
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

    Public Function Eliminar(ByVal oePlanillaVacaciones As e_PlanillaVacaciones) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_PlanillaVacaciones_IAE", "E", _
             "", oePlanillaVacaciones.Id, "", "", 0, "", "", #1/1/1901#, "", #1/1/1901#, oePlanillaVacaciones.UsuarioModifica)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function


End Class
