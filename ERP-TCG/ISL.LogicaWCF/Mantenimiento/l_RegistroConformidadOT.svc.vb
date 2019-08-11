Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_RegistroConformidadOT
    Implements Il_RegistroConformidadOT

    Dim odRegistroConformidadOT As New d_RegistroConformidadOT

    Public Function Eliminar(ByVal oeRegistroConformidadOT As EntidadesWCF.e_RegistroConformidadOT) As Boolean Implements Il_RegistroConformidadOT.Eliminar
        Try
            Return odRegistroConformidadOT.Eliminar(oeRegistroConformidadOT)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeRegistroConformidadOT As EntidadesWCF.e_RegistroConformidadOT) As Boolean Implements Il_RegistroConformidadOT.Guardar
        Try
            If Validar(oeRegistroConformidadOT) Then
                Return odRegistroConformidadOT.Guardar(oeRegistroConformidadOT)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeRegistroConformidadOT As EntidadesWCF.e_RegistroConformidadOT) As System.Collections.Generic.List(Of EntidadesWCF.e_RegistroConformidadOT) Implements Il_RegistroConformidadOT.Listar
        Try
            Return odRegistroConformidadOT.Listar(oeRegistroConformidadOT)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeRegistroConformidadOT As EntidadesWCF.e_RegistroConformidadOT) As EntidadesWCF.e_RegistroConformidadOT Implements Il_RegistroConformidadOT.Obtener
        Try
            Return odRegistroConformidadOT.Obtener(oeRegistroConformidadOT)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeRegistroConformidadOT As EntidadesWCF.e_RegistroConformidadOT) As Boolean Implements Il_RegistroConformidadOT.Validar
        Try
            With oeRegistroConformidadOT
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
