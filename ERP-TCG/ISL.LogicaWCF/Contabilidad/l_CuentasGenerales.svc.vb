Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_CuentasGenerales
    Implements Il_CuentasGenerales

    Dim odCuentasGenerales As New d_CuentasGenerales

    Public Function Eliminar(ByVal oeCuentasGenerales As e_CuentasGenerales) As Boolean Implements Il_CuentasGenerales.Eliminar
        Try
            Return odCuentasGenerales.Eliminar(oeCuentasGenerales)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCuentasGenerales As e_CuentasGenerales) As Boolean Implements Il_CuentasGenerales.Guardar
        Try
            If Validar(oeCuentasGenerales) Then
                Return odCuentasGenerales.Guardar(oeCuentasGenerales)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCuentasGenerales As e_CuentasGenerales) As System.Collections.Generic.List(Of e_CuentasGenerales) Implements Il_CuentasGenerales.Listar
        Try
            Return odCuentasGenerales.Listar(oeCuentasGenerales)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeCuentasGenerales As e_CuentasGenerales) As e_CuentasGenerales Implements Il_CuentasGenerales.Obtener
        Try
            Return odCuentasGenerales.Obtener(oeCuentasGenerales)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeCuentasGenerales As e_CuentasGenerales) As Boolean Implements Il_CuentasGenerales.Validar
        Try
            With oeCuentasGenerales
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
