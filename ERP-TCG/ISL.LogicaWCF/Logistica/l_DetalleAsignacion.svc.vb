Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_DetalleAsignacion
    Implements Il_DetalleAsignacion

    Dim odDetalleAsignacion As New d_DetalleAsignacion

    Public Function Listar(ByVal oeDetalleAsignacion As EntidadesWCF.e_DetalleAsignacion) As System.Collections.Generic.List(Of EntidadesWCF.e_DetalleAsignacion) Implements Il_DetalleAsignacion.Listar
        Try
            Return odDetalleAsignacion.Listar(oeDetalleAsignacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleAsignacion As EntidadesWCF.e_DetalleAsignacion) As EntidadesWCF.e_DetalleAsignacion Implements Il_DetalleAsignacion.Obtener
        Try
            Return odDetalleAsignacion.Obtener(oeDetalleAsignacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
