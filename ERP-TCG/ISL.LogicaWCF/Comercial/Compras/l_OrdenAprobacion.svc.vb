Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_OrdenAprobacion
    Implements Il_OrdenAprobacion

    Dim odOrdenAprobacion As New d_OrdenAprobacion

    Public Function Listar(ByVal oeOrdenAprobacion As e_OrdenAprobacion) As System.Collections.Generic.List(Of e_OrdenAprobacion) Implements Il_OrdenAprobacion.Listar
        Try
            Return odOrdenAprobacion.Listar(oeOrdenAprobacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeOrdenAprobacion As e_OrdenAprobacion) As e_OrdenAprobacion Implements Il_OrdenAprobacion.Obtener
        Try
            Return odOrdenAprobacion.Obtener(oeOrdenAprobacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
