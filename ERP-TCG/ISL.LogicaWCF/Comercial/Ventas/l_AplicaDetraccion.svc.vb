Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_AplicaDetraccion
    Implements Il_AplicaDetraccion

    Dim odAplicaDetraccion As New d_AplicaDetraccion

    Public Function Listar(ByVal oeAplicaDetraccion As e_AplicaDetraccion) As System.Collections.Generic.List(Of e_AplicaDetraccion) Implements Il_AplicaDetraccion.Listar
        Try
            Return odAplicaDetraccion.Listar(oeAplicaDetraccion)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
