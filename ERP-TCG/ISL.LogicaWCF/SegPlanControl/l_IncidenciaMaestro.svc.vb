'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF

Public Class l_IncidenciaMaestro
    Implements Il_IncidenciaMaestro

    Public Sub DoWork() Implements Il_IncidenciaMaestro.DoWork
    End Sub

    Dim odIncidenciaMaestro As New d_IncidenciaMaestro

    Public Function Obtener(ByVal oeIncidenciaMaestro As e_IncidenciaMaestro) As e_IncidenciaMaestro Implements Il_IncidenciaMaestro.Obtener
        Try
            Return odIncidenciaMaestro.Obtener(oeIncidenciaMaestro)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeIncidenciaMaestro As e_IncidenciaMaestro) As List(Of e_IncidenciaMaestro) Implements Il_IncidenciaMaestro.Listar
        Try
            Return odIncidenciaMaestro.Listar(oeIncidenciaMaestro)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeIncidenciaMaestro As e_IncidenciaMaestro) As Boolean Implements Il_IncidenciaMaestro.Validar
        Try
            With oeIncidenciaMaestro
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeIncidenciaMaestro As e_IncidenciaMaestro) As Boolean Implements Il_IncidenciaMaestro.Guardar
        Try
            If Validar(oeIncidenciaMaestro) Then
                Return odIncidenciaMaestro.Guardar(oeIncidenciaMaestro)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeIncidenciaMaestro As e_IncidenciaMaestro) As Boolean Implements Il_IncidenciaMaestro.Eliminar
        Try
            Return odIncidenciaMaestro.Eliminar(oeIncidenciaMaestro)
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
