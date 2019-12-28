
Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos
Imports ERP.LogicaWCF

<DataContract(), Serializable()>
Public Class l_Lado
    Implements Il_Lado
    Private odLado As New d_Lado

    Public Function Obtener(ByVal Item As e_Lado) As e_Lado
        Try
            Return odLado.Obtener(Item)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal Item As e_Lado) As List(Of e_Lado) Implements Il_Lado.Listar
        Try
            Return odLado.Listar(Item)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal Item As e_Lado) As e_Lado Implements Il_Lado.Guardar
        Try
            Validar(Item)
            Item = odLado.Guardar(Item)
            Return Item
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal Item As e_Lado) As Boolean Implements Il_Lado.Eliminar
        Try
            Return odLado.Eliminar(Item)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Function Validar(ByVal Item As e_Lado) As Boolean
        Try
            With Item
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Il_Lado_Obtener(oeLado As e_Lado) As e_Lado Implements Il_Lado.Obtener
        Throw New NotImplementedException()
    End Function
End Class