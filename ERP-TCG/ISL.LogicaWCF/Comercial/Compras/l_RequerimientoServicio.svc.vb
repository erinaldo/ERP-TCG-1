Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_RequerimientoServicio
    Implements Il_RequerimientoServicio

    Dim odRequerimientoServicio As New d_RequerimientoServicio

    Public Function Guardar(ByVal oeRequerimientoServicio As EntidadesWCF.e_RequerimientoServicio) As Boolean Implements Il_RequerimientoServicio.Guardar
        Try
            If Validar(oeRequerimientoServicio) Then
                Return odRequerimientoServicio.Guardar(oeRequerimientoServicio)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeRequerimientoServicio As EntidadesWCF.e_RequerimientoServicio) As System.Collections.Generic.List(Of EntidadesWCF.e_RequerimientoServicio) Implements Il_RequerimientoServicio.Listar
        Try
            Return odRequerimientoServicio.Listar(oeRequerimientoServicio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeRequerimientoServicio As EntidadesWCF.e_RequerimientoServicio) As EntidadesWCF.e_RequerimientoServicio Implements Il_RequerimientoServicio.Obtener
        Try
            Return odRequerimientoServicio.Obtener(oeRequerimientoServicio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeRequerimientoServicio As EntidadesWCF.e_RequerimientoServicio) As Boolean Implements Il_RequerimientoServicio.Validar
        Try
            With oeRequerimientoServicio
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
