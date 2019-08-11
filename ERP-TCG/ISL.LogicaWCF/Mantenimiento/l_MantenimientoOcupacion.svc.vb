Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_MantenimientoOcupacion
    Implements Il_MantenimientoOcupacion

    Dim odMantenimientoOcupacion As New d_MantenimientoOcupacion

    Public Function Eliminar(ByVal oeMantenimientoOcupacion As EntidadesWCF.e_MantenimientoOcupacion) As Boolean Implements Il_MantenimientoOcupacion.Eliminar
        Try
            Return odMantenimientoOcupacion.Eliminar(oeMantenimientoOcupacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMantenimientoOcupacion As EntidadesWCF.e_MantenimientoOcupacion) As Boolean Implements Il_MantenimientoOcupacion.Guardar
        Try
            If Validar(oeMantenimientoOcupacion) Then
                Return odMantenimientoOcupacion.Guardar(oeMantenimientoOcupacion)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMantenimientoOcupacion As EntidadesWCF.e_MantenimientoOcupacion) As System.Collections.Generic.List(Of EntidadesWCF.e_MantenimientoOcupacion) Implements Il_MantenimientoOcupacion.Listar
        Try
            Return odMantenimientoOcupacion.Listar(oeMantenimientoOcupacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMantenimientoOcupacion As EntidadesWCF.e_MantenimientoOcupacion) As EntidadesWCF.e_MantenimientoOcupacion Implements Il_MantenimientoOcupacion.Obtener
        Try
            Return odMantenimientoOcupacion.Obtener(oeMantenimientoOcupacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMantenimientoOcupacion As EntidadesWCF.e_MantenimientoOcupacion) As Boolean Implements Il_MantenimientoOcupacion.Validar
        Try
            With oeMantenimientoOcupacion
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
