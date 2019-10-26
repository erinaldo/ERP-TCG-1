Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_MedioPago
    Implements Il_MedioPago

    Dim odMedioPago As New d_MedioPago

    Public Function Eliminar(ByVal oeMedioPago As e_MedioPago) As Boolean Implements Il_MedioPago.Eliminar
        Try
            Return odMedioPago.Eliminar(oeMedioPago)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMedioPago As e_MedioPago) As Boolean Implements Il_MedioPago.Guardar
        Try
            If Validar(oeMedioPago) Then
                Return odMedioPago.Guardar(oeMedioPago)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMedioPago As e_MedioPago) As System.Collections.Generic.List(Of e_MedioPago) Implements Il_MedioPago.Listar
        Try
            Return odMedioPago.Listar(oeMedioPago)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMedioPago As e_MedioPago) As e_MedioPago Implements Il_MedioPago.Obtener
        Try
            Return odMedioPago.Obtener(oeMedioPago)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMedioPago As e_MedioPago) As Boolean Implements Il_MedioPago.Validar
        Try
            With oeMedioPago
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function
End Class
