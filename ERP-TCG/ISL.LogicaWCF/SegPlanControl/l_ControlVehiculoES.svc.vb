'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ControlVehiculoES
    Implements Il_ControlVehiculoES

    Dim odControlVehiculoES As New d_ControlVehiculoES

    Public Function Eliminar(ByVal oeControlVehiculoES As e_ControlVehiculoES) As Boolean Implements Il_ControlVehiculoES.Eliminar
        Try
            Return odControlVehiculoES.Eliminar(oeControlVehiculoES)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeControlVehiculoES As e_ControlVehiculoES) As Boolean Implements Il_ControlVehiculoES.Guardar
        Try
            If Validar(oeControlVehiculoES) Then
                Return odControlVehiculoES.Guardar(oeControlVehiculoES)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarLista(ByVal lstControlVehiculoES As List(Of e_ControlVehiculoES)) As Boolean Implements Il_ControlVehiculoES.GuardarLista
        Try
            For Each obj As e_ControlVehiculoES In lstControlVehiculoES
                Validar(obj)
            Next
            Return odControlVehiculoES.GuardarLista(lstControlVehiculoES)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeControlVehiculoES As e_ControlVehiculoES) As System.Collections.Generic.List(Of e_ControlVehiculoES) Implements Il_ControlVehiculoES.Listar
        Try
            Return odControlVehiculoES.Listar(oeControlVehiculoES)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeControlVehiculoES As e_ControlVehiculoES) As e_ControlVehiculoES Implements Il_ControlVehiculoES.Obtener
        Try
            Return odControlVehiculoES.Obtener(oeControlVehiculoES)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeControlVehiculoES As e_ControlVehiculoES) As Boolean Implements Il_ControlVehiculoES.Validar
        Try
            With oeControlVehiculoES
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
