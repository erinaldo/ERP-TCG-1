Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_FondoFijo
    Implements Il_FondoFijo

    Dim odFondoFijo As New d_FondoFijo

    Public Function Eliminar(ByVal oeFondoFijo As EntidadesWCF.e_FondoFijo) As Boolean Implements Il_FondoFijo.Eliminar
        Try
            Return odFondoFijo.Eliminar(oeFondoFijo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeFondoFijo As EntidadesWCF.e_FondoFijo) As Boolean Implements Il_FondoFijo.Guardar
        Try
            If Validar(oeFondoFijo) Then
                Return odFondoFijo.Guardar(oeFondoFijo)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeFondoFijo As EntidadesWCF.e_FondoFijo) As System.Collections.Generic.List(Of EntidadesWCF.e_FondoFijo) Implements Il_FondoFijo.Listar
        Try
            Return odFondoFijo.Listar(oeFondoFijo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeFondoFijo As EntidadesWCF.e_FondoFijo) As EntidadesWCF.e_FondoFijo Implements Il_FondoFijo.Obtener
        Try
            Return odFondoFijo.Obtener(oeFondoFijo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeFondoFijo As EntidadesWCF.e_FondoFijo) As Boolean Implements Il_FondoFijo.Validar
        Try
            Dim _ban As Boolean = True
            With oeFondoFijo
                '---------VALIDARRRRRRRRRR-------------
                If .FondoFijo <= 0 Then _ban = False : Throw New Exception("Fondo Fijo  debe ser mayor a 0.")
                If .Glosa.Trim Is String.Empty Then _ban = False : Throw New Exception("Ingrese Glosa de Registro de Fondo Fijo.")
            End With
            Return _ban
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
