Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization
Imports System.Transactions

<DataContract(), Serializable()> _
Public Class l_RubroEEFFDetalle_CuentaContable
    Implements Il_RubroEEFFDetalle_CuentaContable

    Private odRubroEEFFDetalle_CuentaContable As New d_RubroEEFFDetalle_CuentaContable

    Public Function Obtener(ByVal oeRubroEEFFDetalle_CuentaContable As e_RubroEEFFDetalle_CuentaContable) As e_RubroEEFFDetalle_CuentaContable Implements Il_RubroEEFFDetalle_CuentaContable.Obtener

        Try
            oeRubroEEFFDetalle_CuentaContable = odRubroEEFFDetalle_CuentaContable.Obtener(oeRubroEEFFDetalle_CuentaContable)
            Return oeRubroEEFFDetalle_CuentaContable
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeRubroEEFFDetalle_CuentaContable As e_RubroEEFFDetalle_CuentaContable) As List(Of e_RubroEEFFDetalle_CuentaContable) Implements Il_RubroEEFFDetalle_CuentaContable.Listar
        Try
            Dim lstRubroEEFFDetalle_CuentaContable As New List(Of e_RubroEEFFDetalle_CuentaContable)
            lstRubroEEFFDetalle_CuentaContable = odRubroEEFFDetalle_CuentaContable.Listar(oeRubroEEFFDetalle_CuentaContable)
            Return lstRubroEEFFDetalle_CuentaContable
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeRubroEEFFDetalle_CuentaContable As e_RubroEEFFDetalle_CuentaContable) As Boolean Implements Il_RubroEEFFDetalle_CuentaContable.Guardar
        Try
            Dim bol_guardado As Boolean = False
            If Validar(oeRubroEEFFDetalle_CuentaContable) Then
                bol_guardado = odRubroEEFFDetalle_CuentaContable.Guardar(oeRubroEEFFDetalle_CuentaContable)
            End If
            Return bol_guardado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeRubroEEFFDetalle_CuentaContable As e_RubroEEFFDetalle_CuentaContable) As Boolean Implements Il_RubroEEFFDetalle_CuentaContable.Eliminar
        Try
            Return odRubroEEFFDetalle_CuentaContable.Eliminar(oeRubroEEFFDetalle_CuentaContable)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Validar(ByVal oeRubroEEFFDetalle_CuentaContable As e_RubroEEFFDetalle_CuentaContable) As Boolean
        Try
            With oeRubroEEFFDetalle_CuentaContable
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
