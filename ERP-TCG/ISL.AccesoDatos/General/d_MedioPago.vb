Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_MedioPago
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_MedioPago
        Try
            Dim oeMedioPago = New e_MedioPago( _
                             o_fila("Id").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("IdTipoAsiento").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Codigo").ToString _
            )
            Return oeMedioPago
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMedioPago As e_MedioPago) As e_MedioPago

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STP.ISD_MedioPago_Listar", "", oeMedioPago.Id)
            oeMedioPago = New e_MedioPago
            If ds.Tables.Count > 0 Then
                oeMedioPago = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMedioPago
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMedioPago As e_MedioPago) As List(Of e_MedioPago)
        Try
            Dim ldMedioPago As New List(Of e_MedioPago)
            Dim ds As DataSet
            With oeMedioPago
                ds = sqlhelper.ExecuteDataset("STD.ISP_MedioPago_Listar", "" _
                        , .Id _
                        , .Nombre _
                        , .Abreviatura _
                        , .IdTipoAsiento _
                        , .Activo _
                        )
            End With
            oeMedioPago = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMedioPago = Cargar(o_Fila)
                    ldMedioPago.Add(oeMedioPago)
                Next
                Return ldMedioPago
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMedioPago As e_MedioPago) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeMedioPago
                sqlhelper.ExecuteNonQuery("STD.ISP_MedioPago_Listar_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .Nombre _
                        , .Abreviatura _
                        , .IdTipoAsiento _
                        , .Activo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeMedioPago As e_MedioPago) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.ISP_MedioPago_Listar_IAE", "E", _
             "", oeMedioPago.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
