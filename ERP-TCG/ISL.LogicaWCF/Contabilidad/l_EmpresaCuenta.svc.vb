Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_EmpresaCuenta
    Implements Il_EmpresaCuenta

    Dim odEmpresaCuenta As New d_EmpresaCuenta

    Public Function Eliminar(ByVal oeEmpresaCuenta As EntidadesWCF.e_EmpresaCuenta) As Boolean Implements Il_EmpresaCuenta.Eliminar
        Try
            Return odEmpresaCuenta.Eliminar(oeEmpresaCuenta)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeEmpresaCuenta As EntidadesWCF.e_EmpresaCuenta) As Boolean Implements Il_EmpresaCuenta.Guardar
        Try
            If Validar(oeEmpresaCuenta) Then
                Return odEmpresaCuenta.Guardar(oeEmpresaCuenta)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeEmpresaCuenta As EntidadesWCF.e_EmpresaCuenta) As System.Collections.Generic.List(Of EntidadesWCF.e_EmpresaCuenta) Implements Il_EmpresaCuenta.Listar
        Try
            Return odEmpresaCuenta.Listar(oeEmpresaCuenta)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeEmpresaCuenta As EntidadesWCF.e_EmpresaCuenta) As EntidadesWCF.e_EmpresaCuenta Implements Il_EmpresaCuenta.Obtener
        Try
            Return odEmpresaCuenta.Obtener(oeEmpresaCuenta)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeEmpresaCuenta As EntidadesWCF.e_EmpresaCuenta) As Boolean Implements Il_EmpresaCuenta.Validar
        Try
            With oeEmpresaCuenta
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
