Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ObligacionPago
    Implements Il_ObligacionPago

    Dim odObligacionPago As New d_ObligacionPago

    Public Function Eliminar(ByVal oeObligacionPago As e_ObligacionPago) As Boolean Implements Il_ObligacionPago.Eliminar
        Try
            Return odObligacionPago.Eliminar(oeObligacionPago)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeObligacionPago As e_ObligacionPago) As Boolean Implements Il_ObligacionPago.Guardar
        Try
            If Validar(oeObligacionPago) Then
                Return odObligacionPago.Guardar(oeObligacionPago)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeObligacionPago As e_ObligacionPago) As System.Collections.Generic.List(Of e_ObligacionPago) Implements Il_ObligacionPago.Listar
        Try
            Return odObligacionPago.Listar(oeObligacionPago)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeObligacionPago As e_ObligacionPago) As e_ObligacionPago Implements Il_ObligacionPago.Obtener
        Try
            Return odObligacionPago.Obtener(oeObligacionPago)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeObligacionPago As e_ObligacionPago) As Boolean Implements Il_ObligacionPago.Validar
        Try
            With oeObligacionPago
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
