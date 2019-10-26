Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ControlPersonaVehiculoES
    Implements Il_ControlPersonaVehiculoES

    Dim odControlPersonaVehiculoES As New d_ControlPersonaVehiculoES

    Public Function Eliminar(ByVal oeControlPersonaVehiculoES As e_ControlPersonaVehiculoES) As Boolean Implements Il_ControlPersonaVehiculoES.Eliminar
        Try
            Return odControlPersonaVehiculoES.Eliminar(oeControlPersonaVehiculoES)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeControlPersonaVehiculoES As e_ControlPersonaVehiculoES) As Boolean Implements Il_ControlPersonaVehiculoES.Guardar
        Try
            If Validar(oeControlPersonaVehiculoES) Then
                Return odControlPersonaVehiculoES.Guardar(oeControlPersonaVehiculoES)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeControlPersonaVehiculoES As e_ControlPersonaVehiculoES) As System.Collections.Generic.List(Of e_ControlPersonaVehiculoES) Implements Il_ControlPersonaVehiculoES.Listar
        Try
            Return odControlPersonaVehiculoES.Listar(oeControlPersonaVehiculoES)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarTablas(ByVal oeControlPersonaVehiculoES As e_ControlPersonaVehiculoES) As System.Data.DataSet Implements Il_ControlPersonaVehiculoES.ListarTablas
        Try
            Return odControlPersonaVehiculoES.Listar_Tablas(oeControlPersonaVehiculoES)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeControlPersonaVehiculoES As e_ControlPersonaVehiculoES) As e_ControlPersonaVehiculoES Implements Il_ControlPersonaVehiculoES.Obtener
        Try
            Return odControlPersonaVehiculoES.Obtener(oeControlPersonaVehiculoES)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeControlPersonaVehiculoES As e_ControlPersonaVehiculoES) As Boolean Implements Il_ControlPersonaVehiculoES.Validar
        Try
            With oeControlPersonaVehiculoES
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
