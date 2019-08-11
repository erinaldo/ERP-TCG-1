Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ControlCargaVehiculoES
    Implements Il_ControlCargaVehiculoES

    Dim odControlCargaVehiculoES As New d_ControlCargaVehiculoES

    Public Function Eliminar(ByVal oeControlCargaVehiculoES As EntidadesWCF.e_ControlCargaVehiculoES) As Boolean Implements Il_ControlCargaVehiculoES.Eliminar
        Try
            Return odControlCargaVehiculoES.Eliminar(oeControlCargaVehiculoES)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeControlCargaVehiculoES As EntidadesWCF.e_ControlCargaVehiculoES) As Boolean Implements Il_ControlCargaVehiculoES.Guardar
        Try
            If Validar(oeControlCargaVehiculoES) Then
                Return odControlCargaVehiculoES.Guardar(oeControlCargaVehiculoES)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeControlCargaVehiculoES As EntidadesWCF.e_ControlCargaVehiculoES) As System.Collections.Generic.List(Of EntidadesWCF.e_ControlCargaVehiculoES) Implements Il_ControlCargaVehiculoES.Listar
        Try
            Return odControlCargaVehiculoES.Listar(oeControlCargaVehiculoES)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeControlCargaVehiculoES As EntidadesWCF.e_ControlCargaVehiculoES) As EntidadesWCF.e_ControlCargaVehiculoES Implements Il_ControlCargaVehiculoES.Obtener
        Try
            Return odControlCargaVehiculoES.Obtener(oeControlCargaVehiculoES)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeControlCargaVehiculoES As EntidadesWCF.e_ControlCargaVehiculoES) As Boolean Implements Il_ControlCargaVehiculoES.Validar
        Try
            With oeControlCargaVehiculoES
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
