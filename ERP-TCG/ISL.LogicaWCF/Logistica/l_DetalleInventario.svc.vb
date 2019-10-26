Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_DetalleInventario
    Implements Il_DetalleInventario

    Dim odInventario As New d_DetalleInventario

    Public Function Listar(ByVal oeDetalleInventario As e_DetalleInventario) As System.Collections.Generic.List(Of e_DetalleInventario) Implements Il_DetalleInventario.Listar
        Try
            Return odInventario.Listar(oeDetalleInventario)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
