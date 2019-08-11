Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_FecLetras
    Private sqlhelper As New SqlHelper

    Public Function UltimoIdInserta() As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "FIN.FecLetras", d_DatosConfiguracion.PrefijoID _
                                  )
            Return IIf(stResultado Is Nothing, d_DatosConfiguracion.PrefijoID & "000000000001", stResultado)
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Guardar(ByVal oeFecLetras As e_FecLetras) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeFecLetras
                sqlhelper.ExecuteNonQuery("FIN.Isp_Fec_Letras_IAE ", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdObligacionFinanciera _
                        , .IndClienteProveedor _
                        , .IdClienteProveedor _
                        , .Activo _
                        , .NroLetra _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
