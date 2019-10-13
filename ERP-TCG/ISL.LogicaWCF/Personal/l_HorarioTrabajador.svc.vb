'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF

Public Class l_HorarioTrabajador
    Implements Il_HorarioTrabajador

    Dim odHorarioTrabajador As New d_HorarioTrabajador

    Public Function Obtener(ByVal oeHorarioTrabajador As e_HorarioTrabajador) As e_HorarioTrabajador Implements Il_HorarioTrabajador.Obtener
        Try
            Return odHorarioTrabajador.Obtener(oeHorarioTrabajador)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDS(ByVal oeHorarioTrabajador As e_HorarioTrabajador) As System.Data.DataSet Implements Il_HorarioTrabajador.ListarDS
        Try
            Return odHorarioTrabajador.ListarDS(oeHorarioTrabajador)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeHorarioTrabajador As e_HorarioTrabajador) As List(Of e_HorarioTrabajador) Implements Il_HorarioTrabajador.Listar
        Try
            Return odHorarioTrabajador.Listar(oeHorarioTrabajador)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal loHorarioTrabajador As List(Of e_HorarioTrabajador)) As Boolean Implements Il_HorarioTrabajador.Validar
        Try
            
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal loHorarioTrabajador As List(Of e_HorarioTrabajador)) As Boolean Implements Il_HorarioTrabajador.Guardar
        Try
            If Validar(loHorarioTrabajador) Then
                Return odHorarioTrabajador.Guardar(loHorarioTrabajador)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeHorarioTrabajador As e_HorarioTrabajador) As Boolean Implements Il_HorarioTrabajador.Eliminar
        Try
            Return odHorarioTrabajador.Eliminar(oeHorarioTrabajador)
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
