Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Planilla

    Private sqlhelper As New SqlHelper
    Private oeDetallePla As New e_DetallePlanilla
    Private odDetallePla As New d_DetallePlanilla
    Private oeDetalleCon As New e_DetalleConcepto
    Private odDetalleCon As New d_DetalleConcepto

    Private Function Cargar(ByVal o_fila As DataRow) As e_Planilla
        Try
            Dim oePlanilla = New e_Planilla( _
                             o_fila("Id").ToString _
                             , o_fila("IdPeriodo").ToString _
                             , o_fila("IdConfiguracion").ToString _
                             , o_fila("Periodo").ToString _
                             , o_fila("Ejercicio") _
                             , o_fila("Mes") _
                             , o_fila("Codigo").ToString _
                             , o_fila("FechaInicio") _
                             , o_fila("FechaFin") _
                             , o_fila("Tipo") _
                             , o_fila("Importe") _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo") _
            )
            Return oePlanilla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oePlanilla As e_Planilla) As e_Planilla

        Try
            Dim ds As DataSet
            Dim bandCargar As Boolean = oePlanilla.IndCargaCompleto
            With oePlanilla
                ds = sqlhelper.ExecuteDataset("PER.Isp_Planilla_Listar", .TipoOperacion, .Id, .IdPeriodo)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oePlanilla = Cargar(ds.Tables(0).Rows(0))
                If bandCargar Then
                    oeDetallePla = New e_DetallePlanilla
                    oeDetallePla.TipoOperacion = ""
                    oeDetallePla.IdPlanilla = oePlanilla.Id
                    oeDetallePla.Activo = True
                    oePlanilla.leDetalle = odDetallePla.Listar(oeDetallePla)
                    oeDetalleCon = New e_DetalleConcepto
                    oeDetalleCon.TipoOperacion = "T"
                    oeDetalleCon.IdDetallePlanilla = oePlanilla.Id
                    oeDetallePla.Activo = True
                    oePlanilla.leDetalleConcepto = odDetalleCon.Listar(oeDetalleCon)
                End If
            End If
            Return oePlanilla
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ObtenerUltimaPlanilla(ByVal oePlanilla As e_Planilla) As e_Planilla
        Try
            Dim ds As DataSet
            With oePlanilla
                ds = sqlhelper.ExecuteDataset("PER.Isp_Planilla_Listar", .TipoOperacion, "", "", "", "", Date.Parse("01/01/1901"), Date.Parse("01/01/1901"), _
                                               -1, 0, .IdEstado)
            End With
            oePlanilla = New e_Planilla
            If ds.Tables(0).Rows.Count > 0 Then
                oePlanilla = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oePlanilla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oePlanilla As e_Planilla) As List(Of e_Planilla)
        Try
            Dim ldPlanilla As New List(Of e_Planilla)
            Dim ds As DataSet
            With oePlanilla
                ds = sqlhelper.ExecuteDataset("PER.Isp_Planilla_Listar", "" _
                        , .Id _
                        , .IdPeriodo _
                        , .IdConfiguracion _
                        , .Codigo _
                        , .FechaInicio _
                        , .FechaFin _
                        , .Tipo _
                        , .Importe _
                        , .IdEstado _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                        )
            End With
            oePlanilla = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oePlanilla = Cargar(o_Fila)
                ldPlanilla.Add(oePlanilla)
            Next
            Return ldPlanilla
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oePlanilla As e_Planilla) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim _id As String = ""
            With oePlanilla
                _id = sqlhelper.ExecuteScalar("PER.Isp_Planilla_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdPeriodo _
                        , .IdConfiguracion _
                        , .Codigo _
                        , .FechaInicio _
                        , .FechaFin _
                        , .Tipo _
                        , .Importe _
                        , .IdEstado _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                    )

                If .dsDetalle IsNot Nothing AndAlso .dsDetalle.Rows.Count > 0 Then
                    For Each filDet As DataRow In .dsDetalle.Rows
                        filDet("IdPlanilla") = _id
                    Next
                    odDetallePla.GuardarMasivo(.dsDetalle)
                End If

                If .dsDetCon IsNot Nothing AndAlso .dsDetCon.Rows.Count > 0 Then
                    odDetalleCon.GuardarMasivo(.dsDetCon)
                End If

                Dim _leDetAux = .leDetalle.Where(Function(it) it.TipoOperacion <> "I").ToList
                If _leDetAux.Count > 0 Then
                    For Each oeDetPla In _leDetAux
                        oeDetPla.IdPlanilla = _id
                        oeDetPla.UsuarioModifica = .UsuarioModifica
                        If oeDetPla.TipoOperacion = "E" Then
                            odDetallePla.Eliminar(oeDetPla)
                        Else
                            odDetallePla.Guardar(oeDetPla)
                        End If
                    Next
                End If

                'For Each oeDetCon In .leDetalleConcepto
                '    oeDetCon.Id
                'Next
                
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oePlanilla As e_Planilla) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_Planilla_IAE", "E", _
             "", oePlanilla.Id, "", "", "", #1/1/1901#, #1/1/1901#, 0, 0, "", #1/1/1901#, "", #1/1/1901#, oePlanilla.UsuarioModifica)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
