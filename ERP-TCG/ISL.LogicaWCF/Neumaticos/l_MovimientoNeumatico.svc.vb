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
Public Class l_MovimientoNeumatico
    Implements Il_MovimientoNeumatico

    Dim odMovimientoNeumatico As New d_MovimientoNeumatico

    Public Function Eliminar(ByVal oeMovimientoNeumatico As e_MovimientoNeumatico) As Boolean Implements Il_MovimientoNeumatico.Eliminar
        Try
            Return odMovimientoNeumatico.Eliminar(oeMovimientoNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMovimientoNeumatico As e_MovimientoNeumatico) As Boolean Implements Il_MovimientoNeumatico.Guardar
        Try
            If Validar(oeMovimientoNeumatico) Then
                Return odMovimientoNeumatico.Guardar(oeMovimientoNeumatico)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMovimientoNeumatico As e_MovimientoNeumatico) As System.Collections.Generic.List(Of e_MovimientoNeumatico) Implements Il_MovimientoNeumatico.Listar
        Try
            Return odMovimientoNeumatico.Listar(oeMovimientoNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeVidaNeumatico_Motivo As e_MovimientoNeumatico) As e_MovimientoNeumatico Implements Il_MovimientoNeumatico.Obtener
        Try
            Return odMovimientoNeumatico.Obtener(oeVidaNeumatico_Motivo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMovimientoNeumatico As e_MovimientoNeumatico) As Boolean Implements Il_MovimientoNeumatico.Validar
        Try
            With oeMovimientoNeumatico
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
