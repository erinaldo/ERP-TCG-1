Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Dispositivo
    Implements Il_Dispositivo

    Dim odDispositivo As New d_Dispositivo

    Public Function Eliminar(ByVal oeDispositivo As EntidadesWCF.e_Dispositivo) As Boolean Implements Il_Dispositivo.Eliminar
        Try
            Return odDispositivo.Eliminar(oeDispositivo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDispositivo As EntidadesWCF.e_Dispositivo) As Boolean Implements Il_Dispositivo.Guardar
        Try
            If Validar(oeDispositivo) Then
                Return odDispositivo.Guardar(oeDispositivo)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDispositivo As EntidadesWCF.e_Dispositivo) As System.Collections.Generic.List(Of EntidadesWCF.e_Dispositivo) Implements Il_Dispositivo.Listar
        Try
            Return odDispositivo.Listar(oeDispositivo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeDispositivo As EntidadesWCF.e_Dispositivo) As EntidadesWCF.e_Dispositivo Implements Il_Dispositivo.Obtener
        Try
            Return odDispositivo.Obtener(oeDispositivo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeDispositivo As EntidadesWCF.e_Dispositivo) As Boolean Implements Il_Dispositivo.Validar
        Try
            With oeDispositivo
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
