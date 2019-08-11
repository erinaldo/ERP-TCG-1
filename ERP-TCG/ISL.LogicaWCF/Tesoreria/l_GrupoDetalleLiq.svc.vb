Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_GrupoDetalleLiq
    Implements Il_GrupoDetalleLiq
    Dim odGrupoDetalleLiq As New d_GrupoDetalleLiq

    Public Function Eliminar(ByVal oeGrupoDetalleLiq As EntidadesWCF.e_GrupoDetalleLiq) As Boolean Implements Il_GrupoDetalleLiq.Eliminar
        Try
            Return odGrupoDetalleLiq.Eliminar(oeGrupoDetalleLiq)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGrupoDetalleLiq As EntidadesWCF.e_GrupoDetalleLiq) As Boolean Implements Il_GrupoDetalleLiq.Guardar
        Try
            If Validar(oeGrupoDetalleLiq) Then
                Return odGrupoDetalleLiq.Guardar(oeGrupoDetalleLiq)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGrupoDetalleLiq As EntidadesWCF.e_GrupoDetalleLiq) As System.Collections.Generic.List(Of EntidadesWCF.e_GrupoDetalleLiq) Implements Il_GrupoDetalleLiq.Listar
        Try
            Return odGrupoDetalleLiq.Listar(oeGrupoDetalleLiq)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeGrupoDetalleLiq As EntidadesWCF.e_GrupoDetalleLiq) As EntidadesWCF.e_GrupoDetalleLiq Implements Il_GrupoDetalleLiq.Obtener
        Try
            Return odGrupoDetalleLiq.Obtener(oeGrupoDetalleLiq)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeGrupoDetalleLiq As EntidadesWCF.e_GrupoDetalleLiq) As Boolean Implements Il_GrupoDetalleLiq.Validar
        Try
            With oeGrupoDetalleLiq
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
