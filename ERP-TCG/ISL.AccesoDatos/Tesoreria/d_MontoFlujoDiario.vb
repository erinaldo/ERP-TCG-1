Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_MontoFlujoDiario
    Private sqlhelper As New SqlHelper
    Dim oeMFDDetalle As New e_MontoFlujoDiario_Det
    Dim odMFDDetalle As New d_MontoFlujoDiario_Det

    Private Function Cargar(ByVal o_fila As DataRow) As e_MontoFlujoDiario
        Try
            Dim oeMontoFlujoDiario = New e_MontoFlujoDiario( _
                             o_fila("Id").ToString _
                             , o_fila("IdFlujoCaja").ToString _
                             , o_fila("FlujoCaja").ToString _
                             , o_fila("IdTipoVehiculo").ToString _
                             , o_fila("TipoVehiculo").ToString _
                             , o_fila("IdRuta").ToString _
                             , o_fila("Ruta").ToString _
                             , o_fila("Monto").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeMontoFlujoDiario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMontoFlujoDiario As e_MontoFlujoDiario) As e_MontoFlujoDiario

        Try
            Dim ds As DataSet
            With oeMontoFlujoDiario
                ds = sqlhelper.ExecuteDataset("TES.Isp_MontoFlujoDiario_Listar", "", .Id, .IdFlujoCaja, .IdTipoVehiculo, .IdRuta)
            End With

            If ds.Tables(0).Rows.Count > 0 Then
                oeMontoFlujoDiario = Cargar(ds.Tables(0).Rows(0))
            End If
            oeMFDDetalle = New e_MontoFlujoDiario_Det
            oeMFDDetalle.IdMontoFlujoDiario = oeMontoFlujoDiario.Id
            oeMontoFlujoDiario.leMontoFlujoDiarioDet = odMFDDetalle.Listar(oeMFDDetalle)
            Return oeMontoFlujoDiario
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMontoFlujoDiario As e_MontoFlujoDiario) As List(Of e_MontoFlujoDiario)
        Try
            Dim ldMontoFlujoDiario As New List(Of e_MontoFlujoDiario)
            Dim ds As DataSet
            With oeMontoFlujoDiario
                ds = sqlhelper.ExecuteDataset("TES.Isp_MontoFlujoDiario_Listar", "" _
                        , .Id _
                        , .IdFlujoCaja _
                        , .IdTipoVehiculo _
                        , .IdRuta _
                        , .Monto _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeMontoFlujoDiario = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeMontoFlujoDiario = Cargar(o_Fila)
                ldMontoFlujoDiario.Add(oeMontoFlujoDiario)
            Next
            Return ldMontoFlujoDiario
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMontoFlujoDiario As e_MontoFlujoDiario) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim id As String = ""
            Using TransScope As New TransactionScope()
                With oeMontoFlujoDiario
                    id = sqlhelper.ExecuteScalar("TES.Isp_MontoFlujoDiario_IAE", .TipoOperacion, _
                            .Id _
                            , .IdFlujoCaja _
                            , .IdTipoVehiculo _
                            , .IdRuta _
                            , .Monto _
                            , .FechaCreacion _
                            , .UsuarioCreacion _
                            , .Activo _
                            , .PrefijoID _
                        )
                End With
                If oeMontoFlujoDiario.leMontoFlujoDiarioDet IsNot Nothing Then
                    For Each oe As e_MontoFlujoDiario_Det In oeMontoFlujoDiario.leMontoFlujoDiarioDet
                        oe.IdMontoFlujoDiario = id
                        If oe.TipoOperacion = "E" Then odMFDDetalle.Eliminar(oe)
                        odMFDDetalle.Guardar(oe)
                    Next
                End If
                TransScope.Complete()
            End Using
            Return True

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeMontoFlujoDiario As e_MontoFlujoDiario) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_MontoFlujoDiario_IAE", "E", oeMontoFlujoDiario.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
