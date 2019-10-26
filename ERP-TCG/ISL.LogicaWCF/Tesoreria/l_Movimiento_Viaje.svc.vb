Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Movimiento_Viaje
    Implements Il_Movimiento_Viaje
    Dim odMovimiento_Viaje As New d_Movimiento_Viaje

    Public Function Eliminar(ByVal oeMovimiento_Viaje As e_Movimiento_Viaje) As Boolean Implements Il_Movimiento_Viaje.Eliminar
        Try
            Return odMovimiento_Viaje.Eliminar(oeMovimiento_Viaje)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMovimiento_Viaje As e_Movimiento_Viaje) As Boolean Implements Il_Movimiento_Viaje.Guardar
        Try
            If Validar(oeMovimiento_Viaje) Then
                Return odMovimiento_Viaje.Guardar(oeMovimiento_Viaje)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMovimiento_Viaje As e_Movimiento_Viaje) As System.Collections.Generic.List(Of e_Movimiento_Viaje) Implements Il_Movimiento_Viaje.Listar
        Try
            Return odMovimiento_Viaje.Listar(oeMovimiento_Viaje)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMovimiento_Viaje As e_Movimiento_Viaje) As e_Movimiento_Viaje Implements Il_Movimiento_Viaje.Obtener
        Try
            Return odMovimiento_Viaje.Obtener(oeMovimiento_Viaje)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMovimiento_Viaje As e_Movimiento_Viaje) As Boolean Implements Il_Movimiento_Viaje.Validar
        Try
            With oeMovimiento_Viaje
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
