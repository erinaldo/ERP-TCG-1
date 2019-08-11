Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos

<DataContract(), Serializable()>
Public Class l_KmMack
    Implements Il_KmMack

    Private odKmMack As d_KmMack

    Public Function Obtener(ByVal oeKmMack As e_KmMack) As e_KmMack Implements Il_KmMack.Obtener
        Try
            odKmMack = New d_KmMack
            Return odKmMack.Obtener(oeKmMack)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeKmMack As e_KmMack) As List(Of e_KmMack) Implements Il_KmMack.Listar
        Try
            odKmMack = New d_KmMack
            Return odKmMack.Listar(oeKmMack)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeKmMack As e_KmMack) As Boolean Implements Il_KmMack.Guardar
        Try
            odKmMack = New d_KmMack
            Dim bol_guardado As Boolean = False
            If Validar(oeKmMack) Then
                bol_guardado = odKmMack.Guardar(oeKmMack)
            End If
            Return bol_guardado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeKmMack As e_KmMack) As Boolean Implements Il_KmMack.Eliminar
        Try
            odKmMack = New d_KmMack
            Return odKmMack.Eliminar(oeKmMack)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Validar(ByVal oeKmMack As e_KmMack) As Boolean
        Try
            With oeKmMack
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
