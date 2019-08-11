Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Flota_Cuota
    Implements Il_Flota_Cuota

    Dim odFlotaCuota As New d_Flota_Cuota

    Public Function Eliminar(oeFlota_Cuota As e_Flota_Cuota) As Boolean Implements Il_Flota_Cuota.Eliminar
        Try
            Return odFlotaCuota.Eliminar(oeFlota_Cuota)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeFlota_Cuota As e_Flota_Cuota) As Boolean Implements Il_Flota_Cuota.Guardar
        Try
            If Validar(oeFlota_Cuota) Then
                Return odFlotaCuota.Guardar(oeFlota_Cuota)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeFlota_Cuota As e_Flota_Cuota) As List(Of e_Flota_Cuota) Implements Il_Flota_Cuota.Listar
        Try
            Return odFlotaCuota.Listar(oeFlota_Cuota)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeFlota_Cuota As e_Flota_Cuota) As e_Flota_Cuota Implements Il_Flota_Cuota.Obtener
        Try
            Return odFlotaCuota.Obtener(oeFlota_Cuota)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeFlota_Cuota As e_Flota_Cuota) As Boolean Implements Il_Flota_Cuota.Validar
        Try
            With oeFlota_Cuota
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

End Class
