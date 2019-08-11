Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_GrupoDetalle
    Implements Il_GrupoDetalle
    Dim odGrupoDetalle As New d_GrupoDetalle

    Public Function Eliminar(ByVal oeGrupoDetalle As EntidadesWCF.e_GrupoDetalle) As Boolean Implements Il_GrupoDetalle.Eliminar
        Try
            Return odGrupoDetalle.Eliminar(oeGrupoDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGrupoDetalle As EntidadesWCF.e_GrupoDetalle) As Boolean Implements Il_GrupoDetalle.Guardar
        Try
            If Validar(oeGrupoDetalle) Then
                Return odGrupoDetalle.Guardar(oeGrupoDetalle)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGrupoDetalle As EntidadesWCF.e_GrupoDetalle) As System.Collections.Generic.List(Of EntidadesWCF.e_GrupoDetalle) Implements Il_GrupoDetalle.Listar
        Try
            Return odGrupoDetalle.Listar(oeGrupoDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDesc(ByVal oeGrupoDetalle As EntidadesWCF.e_GrupoDetalle) As System.Collections.Generic.List(Of EntidadesWCF.e_GrupoDetalle) Implements Il_GrupoDetalle.ListarDesc
        Try
            Return odGrupoDetalle.ListarDesc(oeGrupoDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarFlete(ByVal oeGrupoDetalle As EntidadesWCF.e_GrupoDetalle) As System.Collections.Generic.List(Of EntidadesWCF.e_GrupoDetalle) Implements Il_GrupoDetalle.ListarFlete
        Try
            Return odGrupoDetalle.ListarFlete(oeGrupoDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarLiq(ByVal oeGrupoDetalle As EntidadesWCF.e_GrupoDetalle) As System.Collections.Generic.List(Of EntidadesWCF.e_GrupoDetalle) Implements Il_GrupoDetalle.ListarLiq
        Try
            Return odGrupoDetalle.ListarLiq(oeGrupoDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeGrupoDetalle As EntidadesWCF.e_GrupoDetalle) As EntidadesWCF.e_GrupoDetalle Implements Il_GrupoDetalle.Obtener
        Try
            Return odGrupoDetalle.Obtener(oeGrupoDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeGrupoDetalle As EntidadesWCF.e_GrupoDetalle) As Boolean Implements Il_GrupoDetalle.Validar
        Try
            With oeGrupoDetalle
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
