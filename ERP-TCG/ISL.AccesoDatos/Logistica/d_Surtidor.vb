Imports ISL.EntidadesWCF

Public Class d_Surtidor

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal fila As DataRow) As e_Surtidor
        Try
            Dim oeSurticor = New e_Surtidor(fila("Numero"), _
                                    fila("Cara"), _
                                    fila("Manguera").ToString, _
                                    fila("Galones"), _
                                    fila("Fecha").ToString)
            Return oeSurticor
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeSurtidor As e_Surtidor) As e_Surtidor

        Try
            Dim ds As DataSet
            With oeSurtidor
                ds = sqlhelper.ExecuteDataset( _
                                                "ALM.Isp_Surtidor_Listar", _
                                                  .TipoOperacion _
                                                  )
            End With
            If ds.Tables.Count > 0 Then
                oeSurtidor = Cargar(ds.Tables(0).Rows(0))
                Return oeSurtidor
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeSurtidor As e_Surtidor) As List(Of e_Surtidor)
        Try
            Dim ds As DataSet
            Dim lista As New List(Of e_Surtidor)
            With oeSurtidor
                ds = sqlhelper.ExecuteDataset("ALM.Isp_Surtidor_Listar", _
                                               .TipoOperacion _
                                                  )
            End With
            If ds.Tables.Count > 0 Then
                For Each fila As DataRow In ds.Tables(0).Rows
                    oeSurtidor = Cargar(fila)
                    lista.Add(oeSurtidor)
                Next
            End If
            Return lista
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
