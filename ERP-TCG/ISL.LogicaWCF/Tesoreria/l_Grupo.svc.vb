Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Grupo
    Implements Il_Grupo
    Dim odGrupo As New d_Grupo
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeGrupo As EntidadesWCF.e_Grupo) As Boolean Implements Il_Grupo.Eliminar
        Try
            Return odGrupo.Eliminar(oeGrupo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Enviar(ByVal oeGrupo As EntidadesWCF.e_Grupo) As Boolean Implements Il_Grupo.Enviar
        Try
            If Validar(oeGrupo) Then
                Return odGrupo.Enviar(oeGrupo)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGrupo As EntidadesWCF.e_Grupo) As Boolean Implements Il_Grupo.Guardar
        Try
            Dim Band As Boolean = False
            If Validar(oeGrupo) Then
                If odGrupo.Guardar(oeGrupo) <> "" Then Band = True
            End If
            Return Band
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeGrupo As EntidadesWCF.e_Grupo) As System.Collections.Generic.List(Of EntidadesWCF.e_Grupo) Implements Il_Grupo.Listar
        Try
            Return odGrupo.Listar(oeGrupo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeGrupo As EntidadesWCF.e_Grupo) As EntidadesWCF.e_Grupo Implements Il_Grupo.Obtener
        Try
            Return odGrupo.Obtener(oeGrupo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeGrupo As EntidadesWCF.e_Grupo) As Boolean Implements Il_Grupo.Validar
        Try
            With oeGrupo
                l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "Ingrese Codigo de Grupo")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdCentro, "Ingrese Centro")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
