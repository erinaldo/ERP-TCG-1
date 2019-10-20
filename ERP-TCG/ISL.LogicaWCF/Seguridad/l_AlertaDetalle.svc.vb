Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_AlertaDetalle
    Implements Il_AlertaDetalle
    Dim odAlertaDetalle As New d_AlertaDetalle

    Public Function Eliminar(ByVal oeAlertaDetalle As e_AlertaDetalle) As Boolean Implements Il_AlertaDetalle.Eliminar
        Try
            Return odAlertaDetalle.Eliminar(oeAlertaDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAlertaDetalle As e_AlertaDetalle) As Boolean Implements Il_AlertaDetalle.Guardar
        Try
            If Validar(oeAlertaDetalle) Then
                Return odAlertaDetalle.Guardar(oeAlertaDetalle)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAlertaDetalle As e_AlertaDetalle) As System.Collections.Generic.List(Of e_AlertaDetalle) Implements Il_AlertaDetalle.Listar
        Try
            Return odAlertaDetalle.Listar(oeAlertaDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeAlertaDetalle As e_AlertaDetalle) As e_AlertaDetalle Implements Il_AlertaDetalle.Obtener
        Try
            Return odAlertaDetalle.Obtener(oeAlertaDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeAlertaDetalle As e_AlertaDetalle) As Boolean Implements Il_AlertaDetalle.Validar
        Try
            With oeAlertaDetalle
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
