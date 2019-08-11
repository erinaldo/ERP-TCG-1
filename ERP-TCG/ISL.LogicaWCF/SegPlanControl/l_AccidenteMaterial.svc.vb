Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
' NOTA: si cambia aquí el nombre de clase "l_AccidenteMaterial", también debe actualizar la referencia a "l_AccidenteMaterial" tanto en Web.config como en el archivo .svc asociado.
Public Class l_AccidenteMaterial
    Implements Il_AccidenteMaterial

    Dim odAccidenteMaterial As New d_AccidenteMaterial

    Public Function Obtener(ByVal oeAccidenteMaterial As e_AccidenteMaterial) As e_AccidenteMaterial Implements Il_AccidenteMaterial.Obtener
        Try
            Return odAccidenteMaterial.Obtener(oeAccidenteMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAccidenteMaterial As e_AccidenteMaterial) As List(Of e_AccidenteMaterial) Implements Il_AccidenteMaterial.Listar
        Try
            Return odAccidenteMaterial.Listar(oeAccidenteMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeAccidenteMaterial As e_AccidenteMaterial) As Boolean Implements Il_AccidenteMaterial.Validar
        Try
            With oeAccidenteMaterial
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeAccidenteMaterial As e_AccidenteMaterial) As Boolean Implements Il_AccidenteMaterial.Guardar
        Try
            If Validar(oeAccidenteMaterial) Then
                Return odAccidenteMaterial.Guardar(oeAccidenteMaterial)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeAccidenteMaterial As e_AccidenteMaterial) As Boolean Implements Il_AccidenteMaterial.Eliminar
        Try
            Return odAccidenteMaterial.Eliminar(oeAccidenteMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
