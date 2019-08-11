Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_OrdenAprobacion
    Implements Il_OrdenAprobacion

    Dim odOrdenAprobacion As New d_OrdenAprobacion

    Public Function Listar(ByVal oeOrdenAprobacion As EntidadesWCF.e_OrdenAprobacion) As System.Collections.Generic.List(Of EntidadesWCF.e_OrdenAprobacion) Implements Il_OrdenAprobacion.Listar
        Try
            Return odOrdenAprobacion.Listar(oeOrdenAprobacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeOrdenAprobacion As EntidadesWCF.e_OrdenAprobacion) As EntidadesWCF.e_OrdenAprobacion Implements Il_OrdenAprobacion.Obtener
        Try
            Return odOrdenAprobacion.Obtener(oeOrdenAprobacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
