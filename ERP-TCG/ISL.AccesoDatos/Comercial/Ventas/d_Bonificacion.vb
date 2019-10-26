'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Bonificacion
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_Bonificacion
        Try
            Dim oeBonificacion = New e_Bonificacion( _
                             o_Fila("Id").ToString _
                             , o_Fila("IdVehiculo").ToString _
                             , o_Fila("Numero").ToString _
                             , o_Fila("Porcentaje").ToString _
                             , o_Fila("IndBonificacion").ToString _
                             , o_Fila("Observacion").ToString _
                             , o_Fila("Activo").ToString _
            )
            Return oeBonificacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeBonificacion As e_Bonificacion) As e_Bonificacion
        Try
            Dim ds As DataSet
            With oeBonificacion
                ds = sqlhelper.ExecuteDataset("OPE.Isp_Bonificacion_Listar", _
                                                          "", _
                                                          .Id)
            End With

            If ds.Tables(0).Rows.Count > 0 Then
                oeBonificacion = Cargar(ds.Tables(0).Rows(0))
            Else
                oeBonificacion = New e_Bonificacion
            End If
            Return oeBonificacion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeBonificacion As e_Bonificacion) As List(Of e_Bonificacion)
        Try
            Dim ldBonificacion As New List(Of e_Bonificacion)
            Dim ds As DataSet
            With oeBonificacion
                ds = sqlhelper.ExecuteDataset("OPE.Isp_Bonificacion_Listar", "" _
                                                , .Id _
                                                , .IdVehiculo _
                                                , .Numero _
                                                , .Porcentaje _
                                                , .IndBonificacion)
            End With
            oeBonificacion = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeBonificacion = Cargar(o_Fila)
                    ldBonificacion.Add(oeBonificacion)
                Next
            Else
                ldBonificacion = New List(Of e_Bonificacion)
            End If
            Return ldBonificacion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeBonificacion As e_Bonificacion) As Boolean
        Try
            With oeBonificacion
                sqlhelper.ExecuteNonQuery("OPE.Isp_Bonificacion_IAE",
                                          .TipoOperacion,
                                          .PrefijoID,
                                          .Id _
                                        , .IdVehiculo _
                                        , .Numero _
                                        , .Porcentaje _
                                        , .IndBonificacion _
                                        , .Observacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeBonificacion As e_Bonificacion) As Boolean
        Try
            With oeBonificacion
                sqlhelper.ExecuteNonQuery("OPE.Isp_Bonificacion_IAE", _
                                          "E", _
                                          "", _
                                          .Id)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
