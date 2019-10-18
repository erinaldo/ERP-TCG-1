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

Public Class d_CatalagoCodigoSunat

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_CatalagoCodigoSunat
        Try
            Dim oeCatalagoCodigoSunat = New e_CatalagoCodigoSunat( _
                             o_fila("Id").ToString _
                             , o_fila("CodigoTabla").ToString _
                             , o_fila("CodigoElemento").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("CodigoSunat").ToString _
                             , o_fila("CodigoAlterno").ToString _
                             , o_fila("UsuarioCrea").ToString _
                             , o_fila("FechaCrea").ToString _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("FechaModifica").ToString _
            )
            Return oeCatalagoCodigoSunat
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCatalagoCodigoSunat As e_CatalagoCodigoSunat) As e_CatalagoCodigoSunat
        Try
            Dim ds As DataSet
            With oeCatalagoCodigoSunat
                ds = sqlhelper.ExecuteDataset("CON.Isp_CatalagoCodigoSunat_Listar", "", .Id, .CodigoTabla, .CodigoElemento, .Descripcion, .CodigoSunat, .CodigoAlterno)
            End With
            If ds.Tables(0).rows.Count > 0 Then
                oeCatalagoCodigoSunat = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCatalagoCodigoSunat
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCatalagoCodigoSunat As e_CatalagoCodigoSunat) As List(Of e_CatalagoCodigoSunat)
        Try
            Dim ldCatalagoCodigoSunat As New List(Of e_CatalagoCodigoSunat)
            Dim ds As DataSet
            With oeCatalagoCodigoSunat
                ds = sqlhelper.ExecuteDataset("CON.Isp_CatalagoCodigoSunat_Listar", "" _
                        , .Id _
                        , .CodigoTabla _
                        , .CodigoElemento _
                        , .Descripcion _
                        , .CodigoSunat _
                        , .CodigoAlterno
                        )
            End With
            oeCatalagoCodigoSunat = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeCatalagoCodigoSunat = Cargar(o_Fila)
                ldCatalagoCodigoSunat.Add(oeCatalagoCodigoSunat)
            Next
            Return ldCatalagoCodigoSunat
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCatalagoCodigoSunat As e_CatalagoCodigoSunat) As Boolean
        Try
            With oeCatalagoCodigoSunat
                sqlhelper.ExecuteNonQuery("CON.Isp_CatalagoCodigoSunat_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .CodigoTabla _
                        , .CodigoElemento _
                        , .Descripcion _
                        , .CodigoSunat _
                        , .CodigoAlterno _
                        , .UsuarioCrea _
                        , .FechaCrea _
                        , .UsuarioModifica _
                        , .FechaModifica
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeCatalagoCodigoSunat As e_CatalagoCodigoSunat) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_CatalagoCodigoSunat_IAE", "E", _
             "", oeCatalagoCodigoSunat.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
