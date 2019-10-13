'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF

Public Class l_TipoHorario
    Implements Il_TipoHorario

    Dim odTipoHorario As New d_TipoHorario

    Public Function Obtener(ByVal oeTipoHorario As e_TipoHorario) As e_TipoHorario Implements Il_TipoHorario.Obtener
        Try
            Return odTipoHorario.Obtener(oeTipoHorario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoHorario As e_TipoHorario) As List(Of e_TipoHorario) Implements Il_TipoHorario.Listar
        Try
            Return odTipoHorario.Listar(oeTipoHorario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ComboGrilla(ByVal loTipoHorario As List(Of e_TipoHorario)) As Object Implements Il_TipoHorario.ComboGrilla
        Try
            Return odTipoHorario.ComboGrilla(loTipoHorario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTipoHorario As e_TipoHorario) As Boolean Implements Il_TipoHorario.Validar
        Try
            With oeTipoHorario
                ValidarNombre(oeTipoHorario.Id, oeTipoHorario.Nombre)
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeTipoHorario As e_TipoHorario) As Boolean Implements Il_TipoHorario.Guardar
        Try
            If Validar(oeTipoHorario) Then
                Return odTipoHorario.Guardar(oeTipoHorario)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeTipoHorario As e_TipoHorario) As Boolean Implements Il_TipoHorario.Eliminar
        Try
            Return odTipoHorario.Eliminar(oeTipoHorario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarNombre(ByVal Id As String, ByVal Nombre As String) As Boolean Implements Il_TipoHorario.ValidarNombre
        Try
            If Nombre = "" Then Throw New Exception("Ingrese Nombre")
            Dim oeTipo As New e_TipoHorario
            oeTipo.TipoOperacion = "1"
            oeTipo.Nombre = Nombre
            oeTipo.Activo = True
            oeTipo = odTipoHorario.Obtener(oeTipo)
            If oeTipo.Id <> "" Then
                If Id = "" OrElse oeTipo.Id <> Id Then
                    Throw New Exception("Ya existe: " & Nombre)
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
