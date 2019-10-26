Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Movimiento_Flete
    Implements Il_Movimiento_Flete
    Dim odMovimiento_Flete As New d_Movimiento_Flete

    Public Function Eliminar(ByVal oeMovimiento_Flete As e_Movimiento_Flete) As Boolean Implements Il_Movimiento_Flete.Eliminar
        Try
            Return odMovimiento_Flete.Eliminar(oeMovimiento_Flete)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMovimiento_Flete As e_Movimiento_Flete) As Boolean Implements Il_Movimiento_Flete.Guardar
        Try
            If Validar(oeMovimiento_Flete) Then
                Return odMovimiento_Flete.Guardar(oeMovimiento_Flete)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMovimiento_Flete As e_Movimiento_Flete) As System.Collections.Generic.List(Of e_Movimiento_Flete) Implements Il_Movimiento_Flete.Listar
        Try
            Return odMovimiento_Flete.Listar(oeMovimiento_Flete)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMovimiento_Flete As e_Movimiento_Flete) As e_Movimiento_Flete Implements Il_Movimiento_Flete.Obtener
        Try
            Return odMovimiento_Flete.Obtener(oeMovimiento_Flete)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMovimiento_Flete As e_Movimiento_Flete) As Boolean Implements Il_Movimiento_Flete.Validar
        Try
            With oeMovimiento_Flete
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
