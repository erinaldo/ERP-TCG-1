Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_DetalleInventario
    Implements Il_DetalleInventario

    Dim odInventario As New d_DetalleInventario

    Public Function Listar(ByVal oeDetalleInventario As EntidadesWCF.e_DetalleInventario) As System.Collections.Generic.List(Of EntidadesWCF.e_DetalleInventario) Implements Il_DetalleInventario.Listar
        Try
            Return odInventario.Listar(oeDetalleInventario)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
