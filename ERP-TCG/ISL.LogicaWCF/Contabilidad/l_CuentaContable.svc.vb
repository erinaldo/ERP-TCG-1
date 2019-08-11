Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_CuentaContable
    Implements Il_CuentaContable

    Dim odCuentaContable As New d_CuentaContable

    Public Function Eliminar(ByVal oeCuentaContable As EntidadesWCF.e_CuentaContable) As Boolean Implements Il_CuentaContable.Eliminar
        Try
            Return odCuentaContable.Eliminar(oeCuentaContable)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCuentaContable As EntidadesWCF.e_CuentaContable) As Boolean Implements Il_CuentaContable.Guardar
        Try
            If Validar(oeCuentaContable) Then
                Return odCuentaContable.Guardar(oeCuentaContable)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCuentaContable As EntidadesWCF.e_CuentaContable) As System.Collections.Generic.List(Of EntidadesWCF.e_CuentaContable) Implements Il_CuentaContable.Listar
        Try
            Return odCuentaContable.Listar(oeCuentaContable)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCuentaContable As EntidadesWCF.e_CuentaContable) As EntidadesWCF.e_CuentaContable Implements Il_CuentaContable.Obtener
        Try
            Return odCuentaContable.Obtener(oeCuentaContable)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeCuentaContable As EntidadesWCF.e_CuentaContable) As Boolean Implements Il_CuentaContable.Validar
        Try
            With oeCuentaContable
                If oeCuentaContable.TipoOperacion = "I" Then
                    Dim leCuentaContable As New List(Of e_CuentaContable)
                    Dim oeCC As New e_CuentaContable
                    oeCC.Cuenta = oeCuentaContable.Cuenta
                    oeCC.Cuenta = oeCuentaContable.Ejercicio
                    leCuentaContable.AddRange(Listar(oeCC))
                    If leCuentaContable.Count > 0 Then
                        Throw New Exception("Esta numero de cuenta ya existe: " & leCuentaContable(0).Nombre)
                    End If
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ComboGrilla(ByVal oeCuentaContable As EntidadesWCF.e_CuentaContable) As Object Implements Il_CuentaContable.ComboGrilla
        Try
            Return odCuentaContable.ComboGrilla(oeCuentaContable)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
