Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_RetencionImpresa
    Implements Il_RetencionImpresa

    Dim odRetImpresa As d_RetencionImpresa

    Public Function Listar(oeRetImpresa As EntidadesWCF.e_RetencionImpresa) As System.Collections.Generic.List(Of EntidadesWCF.e_RetencionImpresa) Implements Il_RetencionImpresa.Listar
        Try
            odRetImpresa = New d_RetencionImpresa
            Return odRetImpresa.Listar(oeRetImpresa)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(lo As List(Of EntidadesWCF.e_RetencionImpresa)) As Boolean Implements Il_RetencionImpresa.Guardar
        Try
            odRetImpresa = New d_RetencionImpresa
            Return odRetImpresa.Guardar(lo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
