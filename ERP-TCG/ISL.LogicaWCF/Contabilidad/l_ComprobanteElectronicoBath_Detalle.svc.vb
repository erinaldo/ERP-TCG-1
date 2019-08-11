Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF

<DataContract(), Serializable()> _
Public Class l_ComprobanteElectronicoBath_Detalle
    Implements Il_ComprobanteElectronicoBath_Detalle

    Dim odComprobanteElectronicoBath_Detalle As New d_ComprobanteElectronicoBath_Detalle

    Public Function Eliminar(oeComprobanteElectronicoBath_Detalle As e_ComprobanteElectronicoBath_Detalle) As Boolean Implements Il_ComprobanteElectronicoBath_Detalle.Eliminar
        Try
            Return odComprobanteElectronicoBath_Detalle.Eliminar(oeComprobanteElectronicoBath_Detalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeComprobanteElectronicoBath_Detalle As e_ComprobanteElectronicoBath_Detalle) As Boolean Implements Il_ComprobanteElectronicoBath_Detalle.Guardar
        Try
            If Validar(oeComprobanteElectronicoBath_Detalle) Then
                Return odComprobanteElectronicoBath_Detalle.Guardar(oeComprobanteElectronicoBath_Detalle)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeComprobanteElectronicoBath_Detalle As e_ComprobanteElectronicoBath_Detalle) As List(Of e_ComprobanteElectronicoBath_Detalle) Implements Il_ComprobanteElectronicoBath_Detalle.Listar
        Try
            Return odComprobanteElectronicoBath_Detalle.Listar(oeComprobanteElectronicoBath_Detalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeComprobanteElectronicoBath_Detalle As e_ComprobanteElectronicoBath_Detalle) As e_ComprobanteElectronicoBath_Detalle Implements Il_ComprobanteElectronicoBath_Detalle.Obtener
        Try
            Return odComprobanteElectronicoBath_Detalle.Obtener(oeComprobanteElectronicoBath_Detalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeComprobanteElectronicoBath_Detalle As e_ComprobanteElectronicoBath_Detalle) As Boolean Implements Il_ComprobanteElectronicoBath_Detalle.Validar
        Try
            With oeComprobanteElectronicoBath_Detalle
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
