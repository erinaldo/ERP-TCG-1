Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_SaldoCtaCorriente

    Implements Il_SaldoCtaCorriente

    Dim odSaldoCtaCorriente As New d_SaldoCtaCorriente
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeSaldoCtaCorriente As EntidadesWCF.e_SaldoCtaCorriente) As Boolean Implements Il_SaldoCtaCorriente.Eliminar
        Try
            Return odSaldoCtaCorriente.Eliminar(oeSaldoCtaCorriente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeSaldoCtaCorriente As EntidadesWCF.e_SaldoCtaCorriente) As Boolean Implements Il_SaldoCtaCorriente.Guardar
        Try
            If Validar(oeSaldoCtaCorriente) Then
                Return odSaldoCtaCorriente.Guardar(oeSaldoCtaCorriente)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeSaldoCtaCorriente As EntidadesWCF.e_SaldoCtaCorriente) As System.Collections.Generic.List(Of EntidadesWCF.e_SaldoCtaCorriente) Implements Il_SaldoCtaCorriente.Listar
        Try
            Return odSaldoCtaCorriente.Listar(oeSaldoCtaCorriente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeSaldoCtaCorriente As EntidadesWCF.e_SaldoCtaCorriente) As EntidadesWCF.e_SaldoCtaCorriente Implements Il_SaldoCtaCorriente.Obtener
        Try
            Return odSaldoCtaCorriente.Obtener(oeSaldoCtaCorriente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeSaldoCtaCorriente As EntidadesWCF.e_SaldoCtaCorriente) As Boolean Implements Il_SaldoCtaCorriente.Validar
        Try
            With oeSaldoCtaCorriente
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
