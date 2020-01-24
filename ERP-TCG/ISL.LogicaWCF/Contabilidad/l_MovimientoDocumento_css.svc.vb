'=====================================================================================================
'=== CAPA : LOGICA ===================================================================================
'=====================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos

<DataContract(), Serializable()>
Public Class l_MovimientoDocumento_css
    Implements Il_MovimientoDocumento_css
    Private odMovimientoDocumento_css As New d_MovimientoDocumento_css

    Public Function Obtener(ByVal Item As e_MovimientoDocumento_css) As e_MovimientoDocumento_css Implements Il_MovimientoDocumento_css.Obtener
        Try
            Return odMovimientoDocumento_css.Obtener(Item)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal Item As e_MovimientoDocumento_css) As List(Of e_MovimientoDocumento_css) Implements Il_MovimientoDocumento_css.Listar
        Try
            Return odMovimientoDocumento_css.Listar(Item)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal Item As e_MovimientoDocumento_css) As e_MovimientoDocumento_css Implements Il_MovimientoDocumento_css.Guardar
        Try
            Validar(Item)
            Item = odMovimientoDocumento_css.Guardar(Item)
            Return Item
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal Item As e_MovimientoDocumento_css) As Boolean Implements Il_MovimientoDocumento_css.Eliminar
        Try
            Return odMovimientoDocumento_css.Eliminar(Item)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Function Validar(ByVal Item As e_MovimientoDocumento_css) As Boolean
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