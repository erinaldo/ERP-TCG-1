Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_Transferencia
    Implements Il_Transferencia

    Dim odTransferencia As New d_Transferencia

    Public Function Eliminar(ByVal oeTransferencia As e_Transferencia) As Boolean Implements Il_Transferencia.Eliminar
        Try
            Return odTransferencia.Eliminar(oeTransferencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTransferencia As e_Transferencia) As Boolean Implements Il_Transferencia.Guardar
        Try
            If Validar(oeTransferencia) Then
                Return odTransferencia.Guardar(oeTransferencia)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTransferencia As e_Transferencia) As System.Collections.Generic.List(Of e_Transferencia) Implements Il_Transferencia.Listar
        Try
            Return odTransferencia.Listar(oeTransferencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeTransferencia As e_Transferencia) As e_Transferencia Implements Il_Transferencia.Obtener
        Try
            Return odTransferencia.Obtener(oeTransferencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTransferencia As e_Transferencia) As Boolean Implements Il_Transferencia.Validar
        Try
            With oeTransferencia
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
