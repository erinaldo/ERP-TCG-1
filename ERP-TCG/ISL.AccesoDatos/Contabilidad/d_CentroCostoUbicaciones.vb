Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_CentroCostoUbicaciones
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_CentroCostoUbicaciones
        Try
            Dim oeCentroCostoUbicaciones = New e_CentroCostoUbicaciones( _
                             o_fila("Id").ToString _
                             , o_fila("IdCentroCosto").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("DescripcionDetallada").ToString _
                             , o_fila("Activo").ToString)
            Return oeCentroCostoUbicaciones
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCentroCostoUbicaciones As e_CentroCostoUbicaciones) As e_CentroCostoUbicaciones

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_CentroCostoUbicaciones_Listar", "", oeCentroCostoUbicaciones.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeCentroCostoUbicaciones = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCentroCostoUbicaciones
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCentroCostoUbicaciones As e_CentroCostoUbicaciones) As List(Of e_CentroCostoUbicaciones)
        Try
            Dim ldCentroCostoUbicaciones As New List(Of e_CentroCostoUbicaciones)
            Dim ds As DataSet
            With oeCentroCostoUbicaciones
                ds = sqlhelper.ExecuteDataset("CON.Isp_CentroCostoUbicaciones_Listar", _
                                              .TipoOperacion _
                                            , .Id _
                                            , .IdCentroCosto _
                                            , .Nombre)
            End With
            oeCentroCostoUbicaciones = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeCentroCostoUbicaciones = Cargar(o_Fila)
                ldCentroCostoUbicaciones.Add(oeCentroCostoUbicaciones)
            Next
            Return ldCentroCostoUbicaciones
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCentroCostoUbicaciones As e_CentroCostoUbicaciones) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeCentroCostoUbicaciones
                sqlhelper.ExecuteNonQuery("CON.Isp_CentroCostoUbicaciones_IAE", _
                                          .TipoOperacion, _
                                          .PrefijoID, _
                                            .Id _
                                            , .IdCentroCosto _
                                            , .Nombre _
                                            , .DescripcionDetallada _
                                            , .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeCentroCostoUbicaciones As e_CentroCostoUbicaciones) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_CentroCostoUbicaciones_IAE", "E", _
             "", oeCentroCostoUbicaciones.Id)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
