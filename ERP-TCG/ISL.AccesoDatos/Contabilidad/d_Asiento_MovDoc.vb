Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Asiento_MovDoc
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Asiento_MovDoc
        Try
            Dim oeAsiento_MovDoc = New e_Asiento_MovDoc( _
                             o_fila("Id").ToString _
                             , o_fila("IdAsiento").ToString _
                             , o_fila("IdMovimientoDocumento").ToString _
                             , o_fila("Activo").ToString)
            Return oeAsiento_MovDoc
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeAsiento_MovDoc As e_Asiento_MovDoc) As e_Asiento_MovDoc

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_Asiento_MovDoc_Listar", "", oeAsiento_MovDoc.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeAsiento_MovDoc = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeAsiento_MovDoc
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAsiento_MovDoc As e_Asiento_MovDoc) As List(Of e_Asiento_MovDoc)
        Try
            Dim ldAsiento_MovDoc As New List(Of e_Asiento_MovDoc)
            Dim ds As DataSet
            With oeAsiento_MovDoc
                ds = sqlhelper.ExecuteDataset("CON.Isp_Asiento_MovDoc_Listar", "" _
                                                , .Id _
                                                , .IdAsiento _
                                                , .IdMovimientoDocumento _
                                                , .Activo)
            End With
            oeAsiento_MovDoc = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeAsiento_MovDoc = Cargar(o_Fila)
                    ldAsiento_MovDoc.Add(oeAsiento_MovDoc)
                Next
            End If
            Return ldAsiento_MovDoc
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAsiento_MovDoc As e_Asiento_MovDoc) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeAsiento_MovDoc
                sqlhelper.ExecuteNonQuery("CON.Isp_Asiento_MovDoc_IAE", _
                                          .TipoOperacion, _
                                          .PrefijoID, _
                                            .Id _
                                            , .IdAsiento _
                                            , .IdMovimientoDocumento _
                                            , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeAsiento_MovDoc As e_Asiento_MovDoc) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_Asiento_MovDoc_IAE", "E", _
             "", oeAsiento_MovDoc.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "CON.Asiento_MovDoc", PrefijoID)
            Return stResultado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
