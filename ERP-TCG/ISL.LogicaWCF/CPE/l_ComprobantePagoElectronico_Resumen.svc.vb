Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos

<DataContract(), Serializable()>
Public Class l_ComprobantePagoElectronico_Resumen
    Implements Il_ComprobantePagoElectronico_Resumen
    Private odComprobantePagoElectronico_Resumen As New d_ComprobantePagoElectronico_Resumen

    Public Function Obtener(ByVal Item As e_ComprobantePagoElectronico_Resumen) As e_ComprobantePagoElectronico_Resumen Implements Il_ComprobantePagoElectronico_Resumen.Obtener
        Try
            Return odComprobantePagoElectronico_Resumen.Obtener(Item)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal Item As e_ComprobantePagoElectronico_Resumen) As List(Of e_ComprobantePagoElectronico_Resumen) Implements Il_ComprobantePagoElectronico_Resumen.Listar
        Try
            Return odComprobantePagoElectronico_Resumen.Listar(Item)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal Item As e_ComprobantePagoElectronico_Resumen) As e_ComprobantePagoElectronico_Resumen Implements Il_ComprobantePagoElectronico_Resumen.Guardar
        Try
            Validar(Item)
            Item = odComprobantePagoElectronico_Resumen.Guardar(Item)
            Return Item
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal Item As e_ComprobantePagoElectronico_Resumen) As Boolean Implements Il_ComprobantePagoElectronico_Resumen.Eliminar
        Try
            Return odComprobantePagoElectronico_Resumen.Eliminar(Item)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Function Validar(ByVal Item As e_ComprobantePagoElectronico_Resumen) As Boolean
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