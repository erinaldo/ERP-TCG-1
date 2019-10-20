' NOTA: si cambia aquí el nombre de clase "l_CodigoBarraMaterial", también debe actualizar la referencia a "l_CodigoBarraMaterial" tanto en Web.config como en el archivo .svc asociado.
Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF

Public Class l_CodigoBarraMaterial
    Implements Il_CodigoBarraMaterial

    Dim odCodigoBarraMaterial As New d_CodigoBarraMaterial

    Public Function Obtener(ByVal oeCodigoBarraMaterial As e_CodigoBarraMaterial) As e_CodigoBarraMaterial Implements Il_CodigoBarraMaterial.Obtener
        Try
            Return odCodigoBarraMaterial.Obtener(oeCodigoBarraMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCodigoBarraMaterial As e_CodigoBarraMaterial) As List(Of e_CodigoBarraMaterial) Implements Il_CodigoBarraMaterial.Listar
        Try
            Return odCodigoBarraMaterial.Listar(oeCodigoBarraMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCodigoBarraMaterial As e_CodigoBarraMaterial) As Boolean Implements Il_CodigoBarraMaterial.Guardar
        Try
            Return odCodigoBarraMaterial.Guardar(oeCodigoBarraMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeCodigoBarraMaterial As e_CodigoBarraMaterial) As Boolean Implements Il_CodigoBarraMaterial.Eliminar
        Try
            Return odCodigoBarraMaterial.Eliminar(oeCodigoBarraMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
