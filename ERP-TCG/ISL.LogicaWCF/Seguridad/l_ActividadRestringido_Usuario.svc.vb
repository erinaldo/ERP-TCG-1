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

Public Class l_ActividadRestringido_Usuario
    Implements Il_ActividadRestringido_Usuario

    Dim odActividadRestringido_Usuario As d_ActividadRestringido_Usuario

    Public Function Eliminar(ByVal oeActividadRestringida_Usuario As e_ActividadRestringida_Usuario) As Boolean Implements Il_ActividadRestringido_Usuario.Eliminar
        Try
            odActividadRestringido_Usuario = New d_ActividadRestringido_Usuario
            Return odActividadRestringido_Usuario.Eliminar(oeActividadRestringida_Usuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeActividadRestringida_Usuario As e_ActividadRestringida_Usuario) As Boolean Implements Il_ActividadRestringido_Usuario.Guardar
        Try
            odActividadRestringido_Usuario = New d_ActividadRestringido_Usuario
            If Validar(oeActividadRestringida_Usuario) Then
                Return odActividadRestringido_Usuario.Guardar(oeActividadRestringida_Usuario)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeActividadRestringida_Usuario As e_ActividadRestringida_Usuario) As System.Collections.Generic.List(Of e_ActividadRestringida_Usuario) Implements Il_ActividadRestringido_Usuario.Listar
        Try
            odActividadRestringido_Usuario = New d_ActividadRestringido_Usuario
            Return odActividadRestringido_Usuario.Listar(oeActividadRestringida_Usuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeActividadRestringida_Usuario As e_ActividadRestringida_Usuario) As e_ActividadRestringida_Usuario Implements Il_ActividadRestringido_Usuario.Obtener
        Try
            odActividadRestringido_Usuario = New d_ActividadRestringido_Usuario
            Return odActividadRestringido_Usuario.Obtener(oeActividadRestringida_Usuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeActividadRestringida_Usuario As e_ActividadRestringida_Usuario) As Boolean Implements Il_ActividadRestringido_Usuario.Validar
        Try

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarLista(ByVal leActividadRestringida_Usuario As System.Collections.Generic.List(Of e_ActividadRestringida_Usuario)) As Boolean Implements Il_ActividadRestringido_Usuario.GuardarLista
        Try
            odActividadRestringido_Usuario = New d_ActividadRestringido_Usuario
            Return odActividadRestringido_Usuario.GuardarLista(leActividadRestringida_Usuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarLista2(ByVal leActividadRestringida_Usuario As System.Collections.Generic.List(Of e_ActividadRestringida_Usuario)) As Boolean Implements Il_ActividadRestringido_Usuario.GuardarLista2
        Try
            odActividadRestringido_Usuario = New d_ActividadRestringido_Usuario
            Return odActividadRestringido_Usuario.GuardarLista2(leActividadRestringida_Usuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarActividadNegocio(ByVal oeActividadRestringida_Usuario As e_ActividadRestringida_Usuario) As System.Collections.Generic.List(Of e_ActividadRestringida_Usuario)
        Try
            odActividadRestringido_Usuario = New d_ActividadRestringido_Usuario
            Return odActividadRestringido_Usuario.Listar(oeActividadRestringida_Usuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
