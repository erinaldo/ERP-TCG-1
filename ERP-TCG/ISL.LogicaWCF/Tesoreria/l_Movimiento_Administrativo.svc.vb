Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Movimiento_Administrativo
    Implements Il_Movimiento_Administrativo
    Dim odMovimiento_Administrativo As New d_Movimiento_Administrativo

    Public Function Eliminar(ByVal oeMovimiento_Administrativo As EntidadesWCF.e_Movimiento_Administrativo) As Boolean Implements Il_Movimiento_Administrativo.Eliminar
        Try
            Return odMovimiento_Administrativo.Eliminar(oeMovimiento_Administrativo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMovimiento_Administrativo As EntidadesWCF.e_Movimiento_Administrativo) As Boolean Implements Il_Movimiento_Administrativo.Guardar
        Try
            If Validar(oeMovimiento_Administrativo) Then
                Return odMovimiento_Administrativo.Guardar(oeMovimiento_Administrativo)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMovimiento_Administrativo As EntidadesWCF.e_Movimiento_Administrativo) As System.Collections.Generic.List(Of EntidadesWCF.e_Movimiento_Administrativo) Implements Il_Movimiento_Administrativo.Listar
        Try
            Return odMovimiento_Administrativo.Listar(oeMovimiento_Administrativo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMovimiento_Administrativo As EntidadesWCF.e_Movimiento_Administrativo) As EntidadesWCF.e_Movimiento_Administrativo Implements Il_Movimiento_Administrativo.Obtener
        Try
            Return odMovimiento_Administrativo.Obtener(oeMovimiento_Administrativo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMovimiento_Administrativo As EntidadesWCF.e_Movimiento_Administrativo) As Boolean Implements Il_Movimiento_Administrativo.Validar
        Try
            With oeMovimiento_Administrativo
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
