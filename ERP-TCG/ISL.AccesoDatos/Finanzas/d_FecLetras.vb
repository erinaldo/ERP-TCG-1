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

Public Class d_FecLetras
    Private sqlhelper As New SqlHelper

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "FIN.FecLetras", PrefijoID
                                  )
            Return IIf(stResultado Is Nothing, PrefijoID & "000000000001", stResultado)
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Guardar(ByVal oeFecLetras As e_FecLetras) As Boolean
        Try
            With oeFecLetras
                sqlhelper.ExecuteNonQuery("FIN.Isp_Fec_Letras_IAE ", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdObligacionFinanciera _
                        , .IndClienteProveedor _
                        , .IdClienteProveedor _
                        , .Activo _
                        , .NroLetra
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
