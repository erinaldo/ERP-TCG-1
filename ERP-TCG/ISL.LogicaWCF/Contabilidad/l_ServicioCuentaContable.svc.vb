Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ServicioCuentaContable
    Implements Il_ServicioCuentaContable

    Dim odServicioCuentaContable As New d_ServicioCuentaContable

    Public Function Eliminar(ByVal oeServicioCuentaContable As EntidadesWCF.e_ServicioCuentaContable) As Boolean Implements Il_ServicioCuentaContable.Eliminar
        Try
            Return odServicioCuentaContable.Eliminar(oeServicioCuentaContable)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeServicioCuentaContable As EntidadesWCF.e_ServicioCuentaContable) As Boolean Implements Il_ServicioCuentaContable.Guardar
        Try
            If Validar(oeServicioCuentaContable) Then
                Return odServicioCuentaContable.Guardar(oeServicioCuentaContable)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeServicioCuentaContable As EntidadesWCF.e_ServicioCuentaContable) As System.Collections.Generic.List(Of EntidadesWCF.e_ServicioCuentaContable) Implements Il_ServicioCuentaContable.Listar
        Try
            Return odServicioCuentaContable.Listar(oeServicioCuentaContable)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeServicioCuentaContable As EntidadesWCF.e_ServicioCuentaContable) As EntidadesWCF.e_ServicioCuentaContable Implements Il_ServicioCuentaContable.Obtener
        Try
            Return odServicioCuentaContable.Obtener(oeServicioCuentaContable)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeServicioCuentaContable As EntidadesWCF.e_ServicioCuentaContable) As Boolean Implements Il_ServicioCuentaContable.Validar
        Try
            With oeServicioCuentaContable
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

End Class
