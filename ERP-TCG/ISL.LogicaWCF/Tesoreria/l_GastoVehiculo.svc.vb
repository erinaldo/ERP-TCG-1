' NOTA: si cambia aquí el nombre de clase "l_GastoVehiculo", también debe actualizar la referencia a "l_GastoVehiculo" tanto en Web.config como en el archivo .svc asociado.
Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_GastoVehiculo
    Implements Il_GastoVehiculo

    Dim odGastoVehiculo As New d_GastoVehiculo

    Public Function Obtener(ByVal oeGastoVehiculo As e_GastoVehiculo) As e_GastoVehiculo Implements Il_GastoVehiculo.Obtener
        Try
            Return odGastoVehiculo.Obtener(oeGastoVehiculo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGastoVehiculo As e_GastoVehiculo) As List(Of e_GastoVehiculo) Implements Il_GastoVehiculo.Listar
        Try
            Return odGastoVehiculo.Listar(oeGastoVehiculo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeGastoVehiculo As e_GastoVehiculo) As Boolean Implements Il_GastoVehiculo.Validar
        Try
            With oeGastoVehiculo
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeGastoVehiculo As e_GastoVehiculo) As Boolean Implements Il_GastoVehiculo.Guardar
        Try
            If Validar(oeGastoVehiculo) Then
                Return odGastoVehiculo.Guardar(oeGastoVehiculo)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeGastoVehiculo As e_GastoVehiculo) As Boolean Implements Il_GastoVehiculo.Eliminar
        Try
            Return odGastoVehiculo.Eliminar(oeGastoVehiculo)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
