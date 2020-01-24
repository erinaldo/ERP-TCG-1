Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos

<DataContract(), Serializable()>
Public Class l_DetalleDocumento_css
    Implements Il_DetalleDocumento_css
    Private odDetalleDocumento_css As New d_DetalleDocumento_css

    Public Function Obtener(ByVal Item As e_DetalleDocumento_css) As e_DetalleDocumento_css Implements Il_DetalleDocumento_css.Obtener
        Try
            Return odDetalleDocumento_css.Obtener(Item)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal Item As e_DetalleDocumento_css) As List(Of e_DetalleDocumento_css) Implements Il_DetalleDocumento_css.Listar
        Try
            Return odDetalleDocumento_css.Listar(Item)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal Item As e_DetalleDocumento_css) As e_DetalleDocumento_css Implements Il_DetalleDocumento_css.Guardar
        Try
            Validar(Item)
            Item = odDetalleDocumento_css.Guardar(Item)
            Return Item
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal Item As e_DetalleDocumento_css) As Boolean Implements Il_DetalleDocumento_css.Eliminar
        Try
            Return odDetalleDocumento_css.Eliminar(Item)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Function Validar(ByVal Item As e_DetalleDocumento_css) As Boolean
        Try
            With Item
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class