Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_BonificacionVehiculo
    Implements Il_BonificacionVehiculo

    Dim odBonificacionVehiculo As New d_BonificacionVehiculo


    Public Function Listar(ByVal oeBonificacionVehiculo As e_BonificacionVehiculo) As List(Of e_BonificacionVehiculo) Implements Il_BonificacionVehiculo.Listar
        Try
            Return odBonificacionVehiculo.Listar(oeBonificacionVehiculo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeBonificacionVehiculo As e_BonificacionVehiculo) As Boolean Implements Il_BonificacionVehiculo.Validar
        Try
            With oeBonificacionVehiculo
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeBonificacionVehiculo As e_BonificacionVehiculo) As Boolean Implements Il_BonificacionVehiculo.Guardar
        Try
            If Validar(oeBonificacionVehiculo) Then
                Return odBonificacionVehiculo.Guardar(oeBonificacionVehiculo)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function


End Class
