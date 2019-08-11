Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization


<DataContract(), Serializable()> _
Public Class l_ConfiguracionSis
    Implements Il_ConfiguracionSis

    Dim odConfiguracionSis As New d_ConfiguracionSis

    Public Function Eliminar(ByVal oeConfiguracionSis As EntidadesWCF.e_ConfiguracionSis) As Boolean Implements Il_ConfiguracionSis.Eliminar
        Try
            Return odConfiguracionSis.Eliminar(oeConfiguracionSis)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeConfiguracionSis As EntidadesWCF.e_ConfiguracionSis) As Boolean Implements Il_ConfiguracionSis.Guardar
        Try
            If Validar(oeConfiguracionSis) Then
                Return odConfiguracionSis.Guardar(oeConfiguracionSis)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeConfiguracionSis As EntidadesWCF.e_ConfiguracionSis) As System.Collections.Generic.List(Of EntidadesWCF.e_ConfiguracionSis) Implements Il_ConfiguracionSis.Listar
        Try
            Return odConfiguracionSis.Listar(oeConfiguracionSis)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeConfiguracionSis As EntidadesWCF.e_ConfiguracionSis) As EntidadesWCF.e_ConfiguracionSis Implements Il_ConfiguracionSis.Obtener
        Try
            Return odConfiguracionSis.Obtener(oeConfiguracionSis)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeConfiguracionSis As EntidadesWCF.e_ConfiguracionSis) As Boolean Implements Il_ConfiguracionSis.Validar
        Try
            With oeConfiguracionSis
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
