Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
' NOTA: si cambia aquí el nombre de clase "l_ControlEntregaMaterial", también debe actualizar la referencia a "l_ControlEntregaMaterial" tanto en Web.config como en el archivo .svc asociado.
Public Class l_ControlEntregaMaterial
    Implements Il_ControlEntregaMaterial

    Dim odControlEntregaMaterial As New d_ControlEntregaMaterial

    Public Function Obtener(ByVal oeControlEntregaMaterial As e_ControlEntregaMaterial) As e_ControlEntregaMaterial Implements Il_ControlEntregaMaterial.Obtener
        Try
            Return odControlEntregaMaterial.Obtener(oeControlEntregaMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeControlEntregaMaterial As e_ControlEntregaMaterial) As List(Of e_ControlEntregaMaterial) Implements Il_ControlEntregaMaterial.Listar
        Try
            Return odControlEntregaMaterial.Listar(oeControlEntregaMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeControlEntregaMaterial As e_ControlEntregaMaterial) As Boolean Implements Il_ControlEntregaMaterial.Validar
        Try
            With oeControlEntregaMaterial
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeControlEntregaMaterial As e_ControlEntregaMaterial) As Boolean Implements Il_ControlEntregaMaterial.Guardar
        Try
            If Validar(oeControlEntregaMaterial) Then
                Return odControlEntregaMaterial.Guardar(oeControlEntregaMaterial)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeControlEntregaMaterial As e_ControlEntregaMaterial) As Boolean Implements Il_ControlEntregaMaterial.Eliminar
        Try
            Return odControlEntregaMaterial.Eliminar(oeControlEntregaMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
