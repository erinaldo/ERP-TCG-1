Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos
Imports ERP.LogicaWCF

<DataContract(), Serializable()>
Public Class l_MovimientoDocumento_Impresion
    Implements Il_MovimientoDocumento_Impresion
    Private odMovimientoDocumento_Impresion As New d_MovimientoDocumento_Impresion

    Public Function Obtener(ByVal Item As e_MovimientoDocumento_Impresion) As e_MovimientoDocumento_Impresion Implements Il_MovimientoDocumento_Impresion.Obtener
        Try
            Return odMovimientoDocumento_Impresion.Obtener(Item)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal Item As e_MovimientoDocumento_Impresion) As List(Of e_MovimientoDocumento_Impresion) Implements Il_MovimientoDocumento_Impresion.Listar
        Try
            Return odMovimientoDocumento_Impresion.Listar(Item)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal Item As e_MovimientoDocumento_Impresion) As e_MovimientoDocumento_Impresion Implements Il_MovimientoDocumento_Impresion.Guardar
        Try
            Validar(Item)
            Item = odMovimientoDocumento_Impresion.Guardar(Item)
            Return Item
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal Item As e_MovimientoDocumento_Impresion) As Boolean Implements Il_MovimientoDocumento_Impresion.Eliminar
        Try
            Return odMovimientoDocumento_Impresion.Eliminar(Item)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Function Validar(ByVal Item As e_MovimientoDocumento_Impresion) As Boolean
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