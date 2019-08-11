' NOTA: si cambia aquí el nombre de clase "l_ChequesTalonarios", también debe actualizar la referencia a "l_ChequesTalonarios" tanto en Web.config como en el archivo .svc asociado.
Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF

Public Class l_ChequesTalonarios
    Implements Il_ChequesTalonarios

    Dim odChequesTalonarios As New d_ChequesTalonarios

    Public Function Obtener(ByVal oeChequesTalonarios As e_ChequesTalonarios) As e_ChequesTalonarios Implements Il_ChequesTalonarios.Obtener
        Try
            Return odChequesTalonarios.Obtener(oeChequesTalonarios)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeChequesTalonarios As e_ChequesTalonarios) As List(Of e_ChequesTalonarios) Implements Il_ChequesTalonarios.Listar
        Try
            Return odChequesTalonarios.Listar(oeChequesTalonarios)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeChequesTalonarios As e_ChequesTalonarios) As Boolean Implements Il_ChequesTalonarios.Validar
        Try
            With oeChequesTalonarios
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeChequesTalonarios As e_ChequesTalonarios) As Boolean Implements Il_ChequesTalonarios.Guardar
        Try
            If Validar(oeChequesTalonarios) Then
                Return odChequesTalonarios.Guardar(oeChequesTalonarios)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeChequesTalonarios As e_ChequesTalonarios) As Boolean Implements Il_ChequesTalonarios.Eliminar
        Try
            Return odChequesTalonarios.Eliminar(oeChequesTalonarios)
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
