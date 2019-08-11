Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
' NOTA: si cambia aquí el nombre de clase "l_AccidenteCarga", también debe actualizar la referencia a "l_AccidenteCarga" tanto en Web.config como en el archivo .svc asociado.
Public Class l_AccidenteCarga
    Implements Il_AccidenteCarga

    Dim odAccidenteCarga As New d_AccidenteCarga

    Public Function Obtener(ByVal oeAccidenteCarga As e_AccidenteCarga) As e_AccidenteCarga Implements Il_AccidenteCarga.Obtener
        Try
            Return odAccidenteCarga.Obtener(oeAccidenteCarga)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAccidenteCarga As e_AccidenteCarga) As List(Of e_AccidenteCarga) Implements Il_AccidenteCarga.Listar
        Try
            Return odAccidenteCarga.Listar(oeAccidenteCarga)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeAccidenteCarga As e_AccidenteCarga) As Boolean Implements Il_AccidenteCarga.Validar
        Try
            With oeAccidenteCarga
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeAccidenteCarga As e_AccidenteCarga) As Boolean Implements Il_AccidenteCarga.Guardar
        Try
            If Validar(oeAccidenteCarga) Then
                Return odAccidenteCarga.Guardar(oeAccidenteCarga)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeAccidenteCarga As e_AccidenteCarga) As Boolean Implements Il_AccidenteCarga.Eliminar
        Try
            Return odAccidenteCarga.Eliminar(oeAccidenteCarga)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
