Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
' NOTA: si cambia aquí el nombre de clase "l_CaracteristicaMaterial", también debe actualizar la referencia a "l_CaracteristicaMaterial" tanto en Web.config como en el archivo .svc asociado.
Public Class l_CaracteristicaMaterial
    Implements Il_CaracteristicaMaterial

    Dim odCaracteristicaMaterial As New d_CaracteristicaMaterial

    Public Function Obtener(ByVal oeCaracteristicaMaterial As e_CaracteristicaMaterial) As e_CaracteristicaMaterial Implements Il_CaracteristicaMaterial.Obtener
        Try
            Return odCaracteristicaMaterial.Obtener(oeCaracteristicaMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCaracteristicaMaterial As e_CaracteristicaMaterial) As List(Of e_CaracteristicaMaterial) Implements Il_CaracteristicaMaterial.Listar
        Try
            Return odCaracteristicaMaterial.Listar(oeCaracteristicaMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeCaracteristicaMaterial As e_CaracteristicaMaterial) As Boolean Implements Il_CaracteristicaMaterial.Validar
        Try
            With oeCaracteristicaMaterial
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeCaracteristicaMaterial As e_CaracteristicaMaterial) As Boolean Implements Il_CaracteristicaMaterial.Guardar
        Try
            If Validar(oeCaracteristicaMaterial) Then
                Return odCaracteristicaMaterial.Guardar(oeCaracteristicaMaterial)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeCaracteristicaMaterial As e_CaracteristicaMaterial) As Boolean Implements Il_CaracteristicaMaterial.Eliminar
        Try
            Return odCaracteristicaMaterial.Eliminar(oeCaracteristicaMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
