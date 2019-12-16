Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos

<DataContract(), Serializable()>
Public Class l_EmpresaDescuento
    Implements Il_EmpresaDescuento
    Private odEmpresaDescuento As New d_EmpresaDescuento

    Public Function Obtener(ByVal oeEmpresaDescuento As e_EmpresaDescuento) As e_EmpresaDescuento Implements Il_EmpresaDescuento.Obtener

        Try
            Return odEmpresaDescuento.Obtener(oeEmpresaDescuento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeEmpresaDescuento As e_EmpresaDescuento) As List(Of e_EmpresaDescuento) Implements Il_EmpresaDescuento.Listar
        Try
            Return odEmpresaDescuento.Listar(oeEmpresaDescuento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeEmpresaDescuento As e_EmpresaDescuento) As Boolean Implements Il_EmpresaDescuento.Guardar
        Try
            Dim bol_guardado As Boolean = False
            If Validar(oeEmpresaDescuento) Then
                bol_guardado = odEmpresaDescuento.Guardar(oeEmpresaDescuento)
            End If
            Return bol_guardado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeEmpresaDescuento As e_EmpresaDescuento) As Boolean Implements Il_EmpresaDescuento.Eliminar
        Try
            Return odEmpresaDescuento.Eliminar(oeEmpresaDescuento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Function Validar(ByVal oeEmpresaDescuento As e_EmpresaDescuento) As Boolean
        Try
            With oeEmpresaDescuento
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class