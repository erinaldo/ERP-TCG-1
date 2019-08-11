Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_EstadoOT
    Implements Il_EstadoOT

    Dim odEstadoOT As New d_EstadoOT

    Public Function Eliminar(ByVal oeEstadoOT As EntidadesWCF.e_EstadoOT) As Boolean Implements Il_EstadoOT.Eliminar
        Try
            Return odEstadoOT.Eliminar(oeEstadoOT)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeEstadoOT As EntidadesWCF.e_EstadoOT) As Boolean Implements Il_EstadoOT.Guardar
        Try
            If Validar(oeEstadoOT) Then
                Return odEstadoOT.Guardar(oeEstadoOT)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeEstadoOT As EntidadesWCF.e_EstadoOT) As System.Collections.Generic.List(Of EntidadesWCF.e_EstadoOT) Implements Il_EstadoOT.Listar
        Try
            Return odEstadoOT.Listar(oeEstadoOT)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeEstadoOT As EntidadesWCF.e_EstadoOT) As EntidadesWCF.e_EstadoOT Implements Il_EstadoOT.Obtener
        Try
            Return odEstadoOT.Obtener(oeEstadoOT)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeEstadoOT As EntidadesWCF.e_EstadoOT) As Boolean Implements Il_EstadoOT.Validar
        Try
            With oeEstadoOT
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
