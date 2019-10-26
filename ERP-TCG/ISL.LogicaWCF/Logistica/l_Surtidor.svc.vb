Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos
Imports System.Runtime.Serialization

Public Class l_Surtidor
    Implements Il_Surtidor
    Dim odSurtidor As New d_Surtidor

    Public Function Listar(ByVal oeSurtidor As e_Surtidor) As List(Of e_Surtidor) Implements Il_Surtidor.Listar
        Try
            Return odSurtidor.Listar(oeSurtidor)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeSurtidor As e_Surtidor) As e_Surtidor Implements Il_Surtidor.Obtener
        Try
            Return odSurtidor.Obtener(oeSurtidor)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
