Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_HistorialRechazoOC
    Implements Il_HistorialRechazoOC

    Dim odHistorialRechazoOC As New d_HistorialRechazoOC

    Public Function Obtener(ByVal oeHistorialRechazoOC As e_HistorialRechazoOC) As e_HistorialRechazoOC
        Try
            Return odHistorialRechazoOC.Obtener(oeHistorialRechazoOC)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeHistorialRechazoOC As e_HistorialRechazoOC) As List(Of e_HistorialRechazoOC)
        Try
            Return odHistorialRechazoOC.Listar(oeHistorialRechazoOC)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeHistorialRechazoOC As e_HistorialRechazoOC) As Boolean
        Try
            With oeHistorialRechazoOC
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeHistorialRechazoOC As e_HistorialRechazoOC) As Boolean
        Try
            If Validar(oeHistorialRechazoOC) Then
                Return odHistorialRechazoOC.Guardar(oeHistorialRechazoOC)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeHistorialRechazoOC As e_HistorialRechazoOC) As Boolean
        Try
            Return odHistorialRechazoOC.Eliminar(oeHistorialRechazoOC)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub DoWork() Implements Il_HistorialRechazoOC.DoWork
    End Sub

End Class
    


