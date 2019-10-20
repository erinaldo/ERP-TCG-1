'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_TrabajoSQL
    Implements Il_TrabajoSQL
    Dim odTrabajoSQL As New d_TrabajoSQL
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Guardar(ByVal oeTrabajoSQL As e_TrabajoSQL) As Boolean Implements Il_TrabajoSQL.Guardar
        Try
            If Validar(oeTrabajoSQL) Then
                Return odTrabajoSQL.Guardar(oeTrabajoSQL)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTrabajoSQL As e_TrabajoSQL) As System.Collections.Generic.List(Of e_TrabajoSQL) Implements Il_TrabajoSQL.Listar
        Try
            Return odTrabajoSQL.Listar(oeTrabajoSQL)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarProcedimiento(ByVal NombreProcedimiento As String) As System.Data.DataTable Implements Il_TrabajoSQL.ListarProcedimiento
        Try
            Return odTrabajoSQL.ListarProcedimiento(NombreProcedimiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeTrabajoSQL As e_TrabajoSQL) As e_TrabajoSQL Implements Il_TrabajoSQL.Obtener
        Try
            Return odTrabajoSQL.Obtener(oeTrabajoSQL)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTrabajoSQL As e_TrabajoSQL) As Boolean Implements Il_TrabajoSQL.Validar
        Try
            With oeTrabajoSQL
                l_FuncionesGenerales.ValidarCampoNoNulo(.Comando, "No ha Ingresado Nombre")
                If .Comando.Contains("INSERT") Or .Comando.Contains("DELETE") Or .Comando.Contains("UPDATE") Then Throw New Exception("Ingrese un Comando Correcto")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
