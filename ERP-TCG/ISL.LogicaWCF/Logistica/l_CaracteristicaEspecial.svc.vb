' NOTA: si cambia aquí el nombre de clase "l_CaracteristicaEspecial", también debe actualizar la referencia a "l_CaracteristicaEspecial" tanto en Web.config como en el archivo .svc asociado.
Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF

Public Class l_CaracteristicaEspecial
    Implements Il_CaracteristicaEspecial

    Dim odCaracteristicaEspecial As New d_CaracteristicaEspecial

    Public Function Obtener(ByVal oeCaracteristicaEspecial As e_CaracteristicaEspecial) As e_CaracteristicaEspecial Implements Il_CaracteristicaEspecial.Obtener
        Try
            Return odCaracteristicaEspecial.Obtener(oeCaracteristicaEspecial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCaracteristicaEspecial As e_CaracteristicaEspecial) As List(Of e_CaracteristicaEspecial) Implements Il_CaracteristicaEspecial.Listar
        Try
            Return odCaracteristicaEspecial.Listar(oeCaracteristicaEspecial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeCaracteristicaEspecial As e_CaracteristicaEspecial) As Boolean Implements Il_CaracteristicaEspecial.Validar
        Try
            With oeCaracteristicaEspecial
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeCaracteristicaEspecial As e_CaracteristicaEspecial) As Boolean Implements Il_CaracteristicaEspecial.Guardar
        Try
            If Validar(oeCaracteristicaEspecial) Then
                Return odCaracteristicaEspecial.Guardar(oeCaracteristicaEspecial)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeCaracteristicaEspecial As e_CaracteristicaEspecial) As Boolean Implements Il_CaracteristicaEspecial.Eliminar
        Try
            Return odCaracteristicaEspecial.Eliminar(oeCaracteristicaEspecial)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
