Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ConfiguracionMTC
    Implements Il_ConfiguracionMTC

    Dim odConfiguracionMTC As New d_ConfiguracionMTC

    Public Function Eliminar(ByVal oeConfiguracionMTC As e_ConfiguracionMTC) As Boolean Implements Il_ConfiguracionMTC.Eliminar
        Try
            Return odConfiguracionMTC.Eliminar(oeConfiguracionMTC)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeConfiguracionMTC As e_ConfiguracionMTC) As Boolean Implements Il_ConfiguracionMTC.Guardar
        Try
            If Validar(oeConfiguracionMTC) Then
                Return odConfiguracionMTC.Guardar(oeConfiguracionMTC)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeConfiguracionMTC As e_ConfiguracionMTC) As System.Collections.Generic.List(Of e_ConfiguracionMTC) Implements Il_ConfiguracionMTC.Listar
        Try
            Return odConfiguracionMTC.Listar(oeConfiguracionMTC)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeConfiguracionMTC As e_ConfiguracionMTC) As e_ConfiguracionMTC Implements Il_ConfiguracionMTC.Obtener
        Try
            Return odConfiguracionMTC.Obtener(oeConfiguracionMTC)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeConfiguracionMTC As e_ConfiguracionMTC) As Boolean Implements Il_ConfiguracionMTC.Validar
        Try
            With oeConfiguracionMTC
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
