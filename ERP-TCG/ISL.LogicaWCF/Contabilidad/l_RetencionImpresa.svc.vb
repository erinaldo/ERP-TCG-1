Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_RetencionImpresa
    Implements Il_RetencionImpresa

    Dim odRetImpresa As d_RetencionImpresa

    Public Function Listar(oeRetImpresa As e_RetencionImpresa) As System.Collections.Generic.List(Of e_RetencionImpresa) Implements Il_RetencionImpresa.Listar
        Try
            odRetImpresa = New d_RetencionImpresa
            Return odRetImpresa.Listar(oeRetImpresa)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(lo As List(Of e_RetencionImpresa)) As Boolean Implements Il_RetencionImpresa.Guardar
        Try
            odRetImpresa = New d_RetencionImpresa
            Return odRetImpresa.Guardar(lo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
