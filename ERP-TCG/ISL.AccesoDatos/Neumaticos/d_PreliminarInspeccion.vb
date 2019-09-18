Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_PreliminarInspeccion
    Private sqlhelper As New SqlHelper
    Private oeDetallePre As New e_DetallePreliminar
    Private odDetallePre As New d_DetallePreliminar

    Private Function Cargar(ByVal o_fila As DataRow) As e_PreliminarInspeccion
        Try
            Dim oePreliminarInspeccion = New e_PreliminarInspeccion( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Periodo").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("FechaEnvio") _
                             , o_fila("FechaTermino") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Usuario").ToString _
                             , o_fila("Activo") _
            )
            Return oePreliminarInspeccion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oePreliminarInspeccion As e_PreliminarInspeccion) As e_PreliminarInspeccion

        Try
            Dim ds As DataSet
            With oePreliminarInspeccion
                ds = sqlhelper.ExecuteDataset("NEU.Isp_PreliminarInspeccion_Listar", .TipoOperacion, .Anio, .Mes, .Id)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oePreliminarInspeccion = Cargar(ds.Tables(0).Rows(0))
                oeDetallePre = New e_DetallePreliminar
                oeDetallePre.TipoOperacion = ""
                oeDetallePre.IdPreliminarInspeccion = oePreliminarInspeccion.Id
                oePreliminarInspeccion.leDetallePre = odDetallePre.Listar(oeDetallePre)
            End If
            Return oePreliminarInspeccion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oePreliminarInspeccion As e_PreliminarInspeccion) As List(Of e_PreliminarInspeccion)
        Try
            Dim ldPreliminarInsp As New List(Of e_PreliminarInspeccion)
            Dim ds As DataSet
            With oePreliminarInspeccion
                ds = sqlhelper.ExecuteDataset("NEU.Isp_PreliminarInspeccion_Listar", .TipoOperacion _
                        , .Anio _
                        , .Mes _
                        )
            End With
            oePreliminarInspeccion = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oePreliminarInspeccion = Cargar(o_Fila)
                    ldPreliminarInsp.Add(oePreliminarInspeccion)
                Next
            End If
            Return ldPreliminarInsp
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oePreliminarInspeccion As e_PreliminarInspeccion) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim id As String
            Using TransScope As New TransactionScope()
                With oePreliminarInspeccion
                    id = sqlhelper.ExecuteScalar("NEU.Isp_PreliminarInspeccion_IAE", .TipoOperacion, .PrefijoID, _
                            .Id _
                            , .Codigo _
                            , .Periodo _
                            , .IdEstado _
                            , .FechaCreacion _
                            , .UsuarioCreacion _
                            , .Activo _
                        )
                    .Id = id
                    For Each oeDet In .leDetallePre
                        oeDet.IdPreliminarInspeccion = .Id
                        If String.IsNullOrEmpty(oeDet.Id) Then
                            oeDet.TipoOperacion = "I"
                            oeDet.Confirmado = 0
                        Else
                            oeDet.TipoOperacion = "A"
                        End If
                        odDetallePre.Guardar(oeDet)
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

    Public Function Enviar(ByVal oePreliminarInspeccion As e_PreliminarInspeccion) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim odReq As New d_Requerimiento
            Dim id As String
            Using TransScope As New TransactionScope()
                With oePreliminarInspeccion
                    id = sqlhelper.ExecuteScalar("NEU.Isp_PreliminarInspeccion_IAE", .TipoOperacion, .PrefijoID, _
                            .Id _
                            , .Codigo _
                            , .Periodo _
                            , .IdEstado _
                            , .FechaCreacion _
                            , .UsuarioCreacion _
                            , .Activo _
                        )
                    .Id = id

                    If .oeRequerimiento IsNot Nothing AndAlso .oeRequerimiento.TipoOperacion <> "" Then
                        odReq.Guardar(.oeRequerimiento)
                    End If

                End With
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
