' NOTA: si cambia aquí el nombre de clase "l_IncidenciasAutentificadas", también debe actualizar la referencia a "l_IncidenciasAutentificadas" tanto en Web.config como en el archivo .svc asociado.
Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_IncidenciasAutentificadas
    Implements Il_IncidenciasAutentificadas

    'Public Sub DoWork() Implements Il_IncidenciasAutentificadas.DoWork
    'End Sub

    Private odIncidenciasAutentificadas As New d_IncidenciasAutentificadas

    Public Function Validar(ByVal oeIncidenciasAutentificadas As e_IncidenciasAutentificadas) As Boolean Implements Il_IncidenciasAutentificadas.Validar
        Try
            With oeIncidenciasAutentificadas

            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeIncidenciasAutentificas As e_IncidenciasAutentificadas) As e_IncidenciasAutentificadas Implements Il_IncidenciasAutentificadas.Obtener
        Try
            Return odIncidenciasAutentificadas.Obtener(oeIncidenciasAutentificas)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeIncidenciasAutentificadas As e_IncidenciasAutentificadas) As List(Of e_IncidenciasAutentificadas) Implements Il_IncidenciasAutentificadas.Listar
        Try
            Return odIncidenciasAutentificadas.Listar(oeIncidenciasAutentificadas)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeIncidenciasAutentificadas As e_IncidenciasAutentificadas) As Boolean Implements Il_IncidenciasAutentificadas.Guardar
        Try
            If Validar(oeIncidenciasAutentificadas) Then
                Return odIncidenciasAutentificadas.Guardar(oeIncidenciasAutentificadas)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeIncidenciasAutentificadas As e_IncidenciasAutentificadas) As Boolean Implements Il_IncidenciasAutentificadas.Eliminar
        Try
            Return odIncidenciasAutentificadas.Eliminar(oeIncidenciasAutentificadas)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
