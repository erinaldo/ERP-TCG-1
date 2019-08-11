Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_MantenimientoServicio
    Implements Il_MantenimientoServicio

    Dim odMantenimientoServicio As New d_MantenimientoServicio

    Public Function Eliminar(ByVal oeMantenimientoServicio As EntidadesWCF.e_MantenimientoServicio) As Boolean Implements Il_MantenimientoServicio.Eliminar
        Try
            Return odMantenimientoServicio.Eliminar(oeMantenimientoServicio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMantenimientoServicio As EntidadesWCF.e_MantenimientoServicio) As Boolean Implements Il_MantenimientoServicio.Guardar
        Try
            If Validar(oeMantenimientoServicio) Then
                Return odMantenimientoServicio.Guardar(oeMantenimientoServicio)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMantenimientoServicio As EntidadesWCF.e_MantenimientoServicio) As System.Collections.Generic.List(Of EntidadesWCF.e_MantenimientoServicio) Implements Il_MantenimientoServicio.Listar
        Try
            Return odMantenimientoServicio.Listar(oeMantenimientoServicio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMantenimientoServicio As EntidadesWCF.e_MantenimientoServicio) As EntidadesWCF.e_MantenimientoServicio Implements Il_MantenimientoServicio.Obtener
        Try
            Return odMantenimientoServicio.Obtener(oeMantenimientoServicio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMantenimientoServicio As EntidadesWCF.e_MantenimientoServicio) As Boolean Implements Il_MantenimientoServicio.Validar
        Try
            With oeMantenimientoServicio
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
