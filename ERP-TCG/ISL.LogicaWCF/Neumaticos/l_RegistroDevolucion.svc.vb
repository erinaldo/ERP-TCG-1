Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_RegistroDevolucion
    Implements Il_RegistroDevolucion

    Dim odRegistroDevolucion As New d_RegistroDevolucion

    Public Function Eliminar(ByVal oeregistrodevolucion As EntidadesWCF.e_RegistroDevolucion) As Boolean Implements Il_RegistroDevolucion.Eliminar
        Try
            Return odRegistroDevolucion.Eliminar(oeregistrodevolucion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeregistrodevolucion As EntidadesWCF.e_RegistroDevolucion) As Boolean Implements Il_RegistroDevolucion.Guardar
        Try
            If Validar(oeregistrodevolucion) Then
                Return odRegistroDevolucion.Guardar(oeregistrodevolucion)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeregistrodevolucion As EntidadesWCF.e_RegistroDevolucion) As System.Collections.Generic.List(Of EntidadesWCF.e_RegistroDevolucion) Implements Il_RegistroDevolucion.Listar
        Try
            Return odRegistroDevolucion.Listar(oeregistrodevolucion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeregistrodevolucion As EntidadesWCF.e_RegistroDevolucion) As EntidadesWCF.e_RegistroDevolucion Implements Il_RegistroDevolucion.Obtener
        Try
            Return odRegistroDevolucion.Obtener(oeregistrodevolucion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeregistrodevolucion As EntidadesWCF.e_RegistroDevolucion) As Boolean Implements Il_RegistroDevolucion.Validar
        Try
            With oeregistrodevolucion
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
