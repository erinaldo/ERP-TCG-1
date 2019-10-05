'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Servicio
    Implements Il_Servicio

    Dim odServicio As New d_Servicio

    Public Function Eliminar(ByVal oeServicio As EntidadesWCF.e_Servicio) As Boolean Implements Il_Servicio.Eliminar
        Try
            Return odServicio.Eliminar(oeServicio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeServicio As EntidadesWCF.e_Servicio) As Boolean Implements Il_Servicio.Guardar
        Try
            If Validar(oeServicio) Then
                Return odServicio.Guardar(oeServicio)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeServicio As EntidadesWCF.e_Servicio) As System.Collections.Generic.List(Of EntidadesWCF.e_Servicio) Implements Il_Servicio.Listar
        Try
            Return odServicio.Listar(oeServicio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeServicio As EntidadesWCF.e_Servicio) As EntidadesWCF.e_Servicio Implements Il_Servicio.Obtener
        Try
            Return odServicio.Obtener(oeServicio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeServicio As EntidadesWCF.e_Servicio) As Boolean Implements Il_Servicio.Validar
        Try
            With oeServicio
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
