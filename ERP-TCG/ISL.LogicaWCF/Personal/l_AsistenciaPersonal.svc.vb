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

Public Class l_AsistenciaPersonal
    Implements Il_AsistenciaPersonal

    Dim odAsistenciaPersonal As New d_AsistenciaPersonal

    Public Function Obtener(ByVal oeAsistenciaPersonal As e_AsistenciaPersonal) As e_AsistenciaPersonal Implements Il_AsistenciaPersonal.Obtener
        Try
            Return odAsistenciaPersonal.Obtener(oeAsistenciaPersonal)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeAsistenciaPersonal As e_AsistenciaPersonal) As List(Of e_AsistenciaPersonal) Implements Il_AsistenciaPersonal.Listar
        Try
            Return odAsistenciaPersonal.Listar(oeAsistenciaPersonal)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeAsistenciaPersonal As e_AsistenciaPersonal) As Boolean Implements Il_AsistenciaPersonal.Validar
        Try
            With oeAsistenciaPersonal
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeAsistenciaPersonal As e_AsistenciaPersonal) As Boolean Implements Il_AsistenciaPersonal.Guardar
        Try
            If Validar(oeAsistenciaPersonal) Then
                Return odAsistenciaPersonal.Guardar(oeAsistenciaPersonal)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeAsistenciaPersonal As e_AsistenciaPersonal) As Boolean Implements Il_AsistenciaPersonal.Eliminar
        Try
            Return odAsistenciaPersonal.Eliminar(oeAsistenciaPersonal)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
