Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF

<DataContract(), Serializable()> _
Public Class l_ComprobanteElectronico
    Implements Il_ComprobanteElectronico

    Dim odComprobanteElectronico As New d_ComprobanteElectronico

    Public Function Eliminar(oeComprobanteElectronico As e_ComprobanteElectronico) As Boolean Implements Il_ComprobanteElectronico.Eliminar
        Try
            Return odComprobanteElectronico.Eliminar(oeComprobanteElectronico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeComprobanteElectronico As e_ComprobanteElectronico) As Boolean Implements Il_ComprobanteElectronico.Guardar
        Try
            If Validar(oeComprobanteElectronico) Then
                Return odComprobanteElectronico.Guardar(oeComprobanteElectronico)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeComprobanteElectronico As e_ComprobanteElectronico) As List(Of e_ComprobanteElectronico) Implements Il_ComprobanteElectronico.Listar
        Try
            Return odComprobanteElectronico.Listar(oeComprobanteElectronico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeComprobanteElectronico As e_ComprobanteElectronico) As e_ComprobanteElectronico Implements Il_ComprobanteElectronico.Obtener
        Try
            Return odComprobanteElectronico.Obtener(oeComprobanteElectronico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeComprobanteElectronico As e_ComprobanteElectronico) As Boolean Implements Il_ComprobanteElectronico.Validar
        Try
            With oeComprobanteElectronico
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
