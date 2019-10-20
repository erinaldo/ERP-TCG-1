Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF

<DataContract(), Serializable()> _
Public Class l_ComprobanteElectronicoBath
    Implements Il_ComprobanteElectronicoBath

    Dim odComprobanteElectronicoBath As New d_ComprobanteElectronicoBath

    Public Function Eliminar(oeComprobanteElectronicoBath As e_ComprobanteElectronicoBath) As Boolean Implements Il_ComprobanteElectronicoBath.Eliminar
        Try
            Return odComprobanteElectronicoBath.Eliminar(oeComprobanteElectronicoBath)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeComprobanteElectronicoBath As e_ComprobanteElectronicoBath) As Boolean Implements Il_ComprobanteElectronicoBath.Guardar
        Try
            If Validar(oeComprobanteElectronicoBath) Then
                Return odComprobanteElectronicoBath.Guardar(oeComprobanteElectronicoBath)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeComprobanteElectronicoBath As e_ComprobanteElectronicoBath) As List(Of e_ComprobanteElectronicoBath) Implements Il_ComprobanteElectronicoBath.Listar
        Try
            Return odComprobanteElectronicoBath.Listar(oeComprobanteElectronicoBath)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeComprobanteElectronicoBath As e_ComprobanteElectronicoBath) As e_ComprobanteElectronicoBath Implements Il_ComprobanteElectronicoBath.Obtener
        Try
            Return odComprobanteElectronicoBath.Obtener(oeComprobanteElectronicoBath)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeComprobanteElectronicoBath As e_ComprobanteElectronicoBath) As Boolean Implements Il_ComprobanteElectronicoBath.Validar
        Try
            With oeComprobanteElectronicoBath
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Function ListarTicket(oeComprobanteElectronicoBath As e_ComprobanteElectronicoBath) As DataSet
        Return odComprobanteElectronicoBath.ListarTicket(oeComprobanteElectronicoBath)
    End Function

End Class
