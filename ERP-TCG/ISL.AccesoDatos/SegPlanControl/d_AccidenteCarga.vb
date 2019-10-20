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
Public Class d_AccidenteCarga
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_AccidenteCarga
        Try
            Dim oee_AccidenteCarga = New e_AccidenteCarga( _
                             o_fila("Id").ToString _
                             , o_fila("IdAccidente").ToString _
                             , o_fila("IdMaterial").ToString _
                             , o_fila("Detalle").ToString _
                             , o_fila("Observacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Material").ToString)
            Return oee_AccidenteCarga
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oee_AccidenteCarga As e_AccidenteCarga) As e_AccidenteCarga

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", oee_AccidenteCarga.Id)
            If ds.Tables.Count > 0 Then
                oee_AccidenteCarga = Cargar(ds.Tables(0).Rows(0))
                Return oee_AccidenteCarga
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oee_AccidenteCarga As e_AccidenteCarga) As List(Of e_AccidenteCarga)
        Try
            Dim lde_AccidenteCarga As New List(Of e_AccidenteCarga)
            Dim ds As DataSet
            With oee_AccidenteCarga
                ds = sqlhelper.ExecuteDataset("SPC.Isp_Accidente_Carga_Listar", .TipoOperacion _
                        , .Id _
                        , .IdAccidente _
                        , .IdMaterial _
                        , .Detalle _
                        , .Observacion _
                        , .Activo _
                        )
            End With
            oee_AccidenteCarga = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oee_AccidenteCarga = Cargar(o_Fila)
                    lde_AccidenteCarga.Add(oee_AccidenteCarga)
                Next
                Return lde_AccidenteCarga
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oee_AccidenteCarga As e_AccidenteCarga) As Boolean
        Try
            With oee_AccidenteCarga
                sqlhelper.ExecuteNonQuery("SPC.Isp_Accidente_Carga_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdAccidente _
                        , .IdMaterial _
                        , .Detalle _
                        , .Observacion _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oee_AccidenteCarga As e_AccidenteCarga) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oee_AccidenteCarga.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
