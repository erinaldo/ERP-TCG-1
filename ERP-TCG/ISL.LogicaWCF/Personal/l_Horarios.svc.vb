'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF

Public Class l_Horarios
    Implements Il_Horarios

    Dim odHorarios As New d_Horarios

    Public Function Obtener(ByVal oeHorarios As e_Horarios) As e_Horarios Implements Il_Horarios.Obtener
        Try
            Return odHorarios.Obtener(oeHorarios)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeHorarios As e_Horarios) As List(Of e_Horarios) Implements Il_Horarios.Listar
        Try
            Return odHorarios.Listar(oeHorarios)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeHorarios As e_Horarios) As Boolean Implements Il_Horarios.Validar
        Try
            With oeHorarios
                If oeHorarios.TipoOperacion = "I" Then ValidarTipo(oeHorarios.IdTipoHorario)
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeHorarios As e_Horarios) As Boolean Implements Il_Horarios.Guardar
        Try
            If Validar(oeHorarios) Then
                Return odHorarios.Guardar(oeHorarios)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeHorarios As e_Horarios) As Boolean Implements Il_Horarios.Eliminar
        Try
            Return odHorarios.Eliminar(oeHorarios)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarTipo(ByVal IdTipoHorario As String) As Boolean Implements Il_Horarios.ValidarTipo
        Try
            Dim oeHorarios As New e_Horarios
            oeHorarios.TipoOperacion = "1"
            oeHorarios.IdTipoHorario = IdTipoHorario
            oeHorarios.Activo = True
            oeHorarios = odHorarios.Obtener(oeHorarios)
            If oeHorarios.Id <> "" Then
                Throw New Exception("Ya existe el tipo: " & oeHorarios.TipoHorario)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
