Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos

<DataContract(), Serializable()>
Public Class l_KmMackDet
    Implements Il_KmMackDet

    Private odKmMackDet As d_KmMackDet

    Public Function Obtener(ByVal oeKmMackDet As e_KmMackDet) As e_KmMackDet Implements Il_KmMackDet.Obtener
        Try
            odKmMackDet = New d_KmMackDet
            Return odKmMackDet.Obtener(oeKmMackDet)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeKmMackDet As e_KmMackDet) As List(Of e_KmMackDet) Implements Il_KmMackDet.Listar
        Try
            odKmMackDet = New d_KmMackDet
            Return odKmMackDet.Listar(oeKmMackDet)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeKmMackDet As e_KmMackDet) As Boolean Implements Il_KmMackDet.Guardar
        Try
            odKmMackDet = New d_KmMackDet
            Dim bol_guardado As Boolean = False
            If Validar(oeKmMackDet) Then
                bol_guardado = odKmMackDet.Guardar(oeKmMackDet)
            End If
            Return bol_guardado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeKmMackDet As e_KmMackDet) As Boolean Implements Il_KmMackDet.Eliminar
        Try
            odKmMackDet = New d_KmMackDet
            Return odKmMackDet.Eliminar(oeKmMackDet)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Validar(ByVal oeKmMackDet As e_KmMackDet) As Boolean
        Try
            With oeKmMackDet
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
