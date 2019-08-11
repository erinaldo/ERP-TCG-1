Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF

<DataContract(), Serializable()> _
Public Class l_LimiteCredito
    Implements Il_LimiteCredito
    Dim odLimiteCredito As New d_LimiteCredito

    Public Function Obtener(ByVal oeLimiteCredito As e_LimiteCredito) As e_LimiteCredito Implements Il_LimiteCredito.Obtener
        Try
            Return odLimiteCredito.Obtener(oeLimiteCredito)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeLimiteCredito As e_LimiteCredito) As List(Of e_LimiteCredito) Implements Il_LimiteCredito.Listar
        Try
            Return odLimiteCredito.Listar(oeLimiteCredito)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Function Validar(ByVal oeLimiteCredito As e_LimiteCredito) As Boolean
        Try
            With oeLimiteCredito
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeLimiteCredito As e_LimiteCredito) As Boolean Implements Il_LimiteCredito.Guardar
        Try
            If Validar(oeLimiteCredito) Then
                Return odLimiteCredito.Guardar(oeLimiteCredito)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeLimiteCredito As e_LimiteCredito) As Boolean Implements Il_LimiteCredito.Eliminar
        Try
            Return odLimiteCredito.Eliminar(oeLimiteCredito)
        Catch ex As Exception
            Throw
        End Try
    End Function


End Class
