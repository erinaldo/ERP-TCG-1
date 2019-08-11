Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Prestamo_Sancion
    Implements Il_Prestamo_Sancion

    Dim odPrestamoSancion As New d_Prestamo_Sancion

    Public Function Obtener(ByVal oePrestamoSancion As e_Prestamo_Sancion) As e_Prestamo_Sancion Implements Il_Prestamo_Sancion.Obtener
        Try
            Return odPrestamoSancion.Obtener(oePrestamoSancion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oePrestamoSancion As e_Prestamo_Sancion) As List(Of e_Prestamo_Sancion) Implements Il_Prestamo_Sancion.Listar
        Try
            Return odPrestamoSancion.Listar(oePrestamoSancion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oePrestamoSancion As e_Prestamo_Sancion) As Boolean Implements Il_Prestamo_Sancion.Validar
        Try
            With oePrestamoSancion
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oePrestamoSancion As e_Prestamo_Sancion) As Boolean Implements Il_Prestamo_Sancion.Guardar
        Try
            If Validar(oePrestamoSancion) Then
                Return odPrestamoSancion.Guardar(oePrestamoSancion)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oePrestamoSancion As e_Prestamo_Sancion) As Boolean Implements Il_Prestamo_Sancion.Eliminar
        Try
            Return odPrestamoSancion.Eliminar(oePrestamoSancion)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
