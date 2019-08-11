Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_EstadoRequerimiento
    Implements Il_EstadoRequerimiento

    Dim odEstadoRequerimiento As New d_EstadoRequerimiento

    Public Function Eliminar(ByVal oeEstadoRequerimiento As EntidadesWCF.e_EstadoRequerimiento) As Boolean Implements Il_EstadoRequerimiento.Eliminar
        Try
            Return odEstadoRequerimiento.Eliminar(oeEstadoRequerimiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeEstadoRequerimiento As EntidadesWCF.e_EstadoRequerimiento) As Boolean Implements Il_EstadoRequerimiento.Guardar
        Try
            If Validar(oeEstadoRequerimiento) Then
                Return odEstadoRequerimiento.Guardar(oeEstadoRequerimiento)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeEstadoRequerimiento As EntidadesWCF.e_EstadoRequerimiento) As System.Collections.Generic.List(Of EntidadesWCF.e_EstadoRequerimiento) Implements Il_EstadoRequerimiento.Listar
        Try
            Return odEstadoRequerimiento.Listar(oeEstadoRequerimiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeEstadoRequerimiento As EntidadesWCF.e_EstadoRequerimiento) As EntidadesWCF.e_EstadoRequerimiento Implements Il_EstadoRequerimiento.Obtener
        Try
            Return odEstadoRequerimiento.Obtener(oeEstadoRequerimiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeEstadoRequerimiento As EntidadesWCF.e_EstadoRequerimiento) As Boolean Implements Il_EstadoRequerimiento.Validar
        Try
            With oeEstadoRequerimiento
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
