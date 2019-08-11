Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF

Public Class l_Auditoria
    Implements Il_Auditoria

    Dim odAuditoria As New d_Auditoria
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Guardar(ByVal oeAuditoria As EntidadesWCF.e_Auditoria) As Boolean Implements Il_Auditoria.Guardar
        Try
            Return odAuditoria.Guardar(oeAuditoria)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAuditoria As EntidadesWCF.e_Auditoria) As System.Collections.Generic.List(Of EntidadesWCF.e_Auditoria) Implements Il_Auditoria.Listar
        Try
            Return odAuditoria.Listar(oeAuditoria)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeAuditoria As EntidadesWCF.e_Auditoria) As EntidadesWCF.e_Auditoria Implements Il_Auditoria.Obtener
        Try
            Return odAuditoria.Obtener(oeAuditoria)
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
