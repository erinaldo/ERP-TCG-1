Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_MaterialCuentaContable
    Implements Il_MaterialCuentaContable

    Dim odMaterialCuentaContable As New d_MaterialCuentaContable

    Public Function Eliminar(ByVal oeMaterialCuentaContable As EntidadesWCF.e_MaterialCuentaContable) As Boolean Implements Il_MaterialCuentaContable.Eliminar
        Try
            Return odMaterialCuentaContable.Eliminar(oeMaterialCuentaContable)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMaterialCuentaContable As EntidadesWCF.e_MaterialCuentaContable) As Boolean Implements Il_MaterialCuentaContable.Guardar
        Try
            If Validar(oeMaterialCuentaContable) Then
                Return odMaterialCuentaContable.Guardar(oeMaterialCuentaContable)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMaterialCuentaContable As EntidadesWCF.e_MaterialCuentaContable) As System.Collections.Generic.List(Of EntidadesWCF.e_MaterialCuentaContable) Implements Il_MaterialCuentaContable.Listar
        Try
            Return odMaterialCuentaContable.Listar(oeMaterialCuentaContable)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMaterialCuentaContable As EntidadesWCF.e_MaterialCuentaContable) As EntidadesWCF.e_MaterialCuentaContable Implements Il_MaterialCuentaContable.Obtener
        Try
            Return odMaterialCuentaContable.Obtener(oeMaterialCuentaContable)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMaterialCuentaContable As EntidadesWCF.e_MaterialCuentaContable) As Boolean Implements Il_MaterialCuentaContable.Validar
        Try
            With oeMaterialCuentaContable
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function
End Class
