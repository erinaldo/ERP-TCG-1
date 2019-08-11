Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_AccidenteVehiculo
    Implements Il_AccidenteVehiculo

    Dim odAccidenteVehiculo As New d_AccidenteVehiculo
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function EliminacionDefinitiva(ByVal oeAccidenteVehiculo As EntidadesWCF.e_AccidenteVehiculo) As Boolean Implements Il_AccidenteVehiculo.EliminacionDefinitiva
        Try
            Return odAccidenteVehiculo.EliminacionDefinitiva(oeAccidenteVehiculo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeAccidenteVehiculo As EntidadesWCF.e_AccidenteVehiculo) As Boolean Implements Il_AccidenteVehiculo.Eliminar
        Try
            Return odAccidenteVehiculo.Eliminar(oeAccidenteVehiculo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAccidenteVehiculo As EntidadesWCF.e_AccidenteVehiculo) As Boolean Implements Il_AccidenteVehiculo.Guardar
        Try
            If Validar(oeAccidenteVehiculo) Then
                Return odAccidenteVehiculo.Guardar(oeAccidenteVehiculo)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAccidenteVehiculo As EntidadesWCF.e_AccidenteVehiculo) As System.Collections.Generic.List(Of EntidadesWCF.e_AccidenteVehiculo) Implements Il_AccidenteVehiculo.Listar
        Try
            Return odAccidenteVehiculo.Listar(oeAccidenteVehiculo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeAccidenteVehiculo As EntidadesWCF.e_AccidenteVehiculo) As EntidadesWCF.e_AccidenteVehiculo Implements Il_AccidenteVehiculo.Obtener
        Try
            Return odAccidenteVehiculo.Obtener(oeAccidenteVehiculo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeAccidenteVehiculo As EntidadesWCF.e_AccidenteVehiculo) As Boolean Implements Il_AccidenteVehiculo.Validar
        Try
            With oeAccidenteVehiculo
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdAccidente, "Debe especificarse a qué Accidente está vinculada el Vehiculo")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Placa, "Debe especificar la placa de rodaje del Vehiculo que está relacionado al accidente")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
