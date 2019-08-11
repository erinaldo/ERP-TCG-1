Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF

<DataContract(), Serializable()> _
Public Class l_CatalagoCodigoSunat
    Implements Il_CatalagoCodigoSunat

    Dim odCatalagoCodigoSunat As New d_CatalagoCodigoSunat

    Public Function Obtener(ByVal oeCatalagoCodigoSunat As e_CatalagoCodigoSunat) As e_CatalagoCodigoSunat Implements Il_CatalagoCodigoSunat.Obtener
        Try
            Return odCatalagoCodigoSunat.Obtener(oeCatalagoCodigoSunat)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCatalagoCodigoSunat As e_CatalagoCodigoSunat) As List(Of e_CatalagoCodigoSunat) Implements Il_CatalagoCodigoSunat.Listar
        Try
            Return odCatalagoCodigoSunat.Listar(oeCatalagoCodigoSunat)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeCatalagoCodigoSunat As e_CatalagoCodigoSunat) As Boolean Implements Il_CatalagoCodigoSunat.Validar
        Try
            With oeCatalagoCodigoSunat
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeCatalagoCodigoSunat As e_CatalagoCodigoSunat) As Boolean Implements Il_CatalagoCodigoSunat.Guardar
        Try
            If Validar(oeCatalagoCodigoSunat) Then
                Return odCatalagoCodigoSunat.Guardar(oeCatalagoCodigoSunat)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeCatalagoCodigoSunat As e_CatalagoCodigoSunat) As Boolean Implements Il_CatalagoCodigoSunat.Eliminar
        Try
            Return odCatalagoCodigoSunat.Eliminar(oeCatalagoCodigoSunat)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
