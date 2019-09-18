Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_MovCuentaCte_Asiento

    Private sqlhelper As New SqlHelper
    Private d_DatosConfiguracion As New d_DatosConfiguracion

    Private Function Cargar(ByVal o_fila As DataRow) As e_MovCuentaCte_Asiento
        Try
            Dim oeMovCuentaCte_Asiento = New e_MovCuentaCte_Asiento( _
                             o_Fila("Id").ToString _
                             , o_Fila("IdMovCuentaCte").ToString _
                             , o_Fila("IdAsiento").ToString _
                             , o_Fila("Activo").ToString _
            )
            Return oeMovCuentaCte_Asiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMovCuentaCte_Asiento As e_MovCuentaCte_Asiento) As e_MovCuentaCte_Asiento

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_MovCuentaCte_Asiento_Listar", "", oeMovCuentaCte_Asiento.Id, oeMovCuentaCte_Asiento.IdMovCuentaCte)
            If ds.Tables(0).rows.Count > 0 Then
                oeMovCuentaCte_Asiento = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMovCuentaCte_Asiento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMovCuentaCte_Asiento As e_MovCuentaCte_Asiento) As List(Of e_MovCuentaCte_Asiento)
        Try
            Dim ldMovCuentaCte_Asiento As New List(Of e_MovCuentaCte_Asiento)
            Dim ds As DataSet
            With oeMovCuentaCte_Asiento
                ds = sqlhelper.ExecuteDataset("TES.Isp_MovCuentaCte_Asiento_Listar", "" _
                        , .Id _
                        , .IdMovCuentaCte _
                        , .IdAsiento _
                        , .Activo _
                        )
            End With
            oeMovCuentaCte_Asiento = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeMovCuentaCte_Asiento = Cargar(o_Fila)
                ldMovCuentaCte_Asiento.Add(oeMovCuentaCte_Asiento)
            Next
            Return ldMovCuentaCte_Asiento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMovCuentaCte_Asiento As e_MovCuentaCte_Asiento, ByVal oeAsiento As e_Asiento) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            If oeAsiento.TipoOperacion = "I" Then
                Dim odAsiento As New d_Asiento
                odAsiento.Guardar(oeAsiento, Nothing, False)
                With oeMovCuentaCte_Asiento
                    .IdAsiento = oeAsiento.Id
                    sqlhelper.ExecuteNonQuery("TES.Isp_MovCuentaCte_Asiento_IAE", .TipoOperacion, .PrefijoID, _
                            .Id _
                            , .IdMovCuentaCte _
                            , .IdAsiento _
                            , .Activo _
                        )
                End With
            End If
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeMovCuentaCte_Asiento As e_MovCuentaCte_Asiento) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_MovCuentaCte_Asiento_IAE", "E", _
             "", oeMovCuentaCte_Asiento.Id, oeMovCuentaCte_Asiento.IdMovCuentaCte)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "TES.MovCuentaCte_Asiento", PrefijoID
                                  )
            Return IIf(stResultado Is Nothing, PrefijoID & "000000000001", stResultado)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
