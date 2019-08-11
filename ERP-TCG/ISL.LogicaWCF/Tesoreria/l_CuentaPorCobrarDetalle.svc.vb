Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_CuentaPorCobrarDetalle
    Implements Il_CuentaPorCobrarDetalle

    Dim odCuentaPorCobrarDetalle As New d_CuentaPorCobrarDetalle
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeCuentaPorCobrarDetalle As EntidadesWCF.e_CuentaPorCobrarDetalle) As Boolean Implements Il_CuentaPorCobrarDetalle.Eliminar
        Try
            Return odCuentaPorCobrarDetalle.Eliminar(oeCuentaPorCobrarDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCuentaPorCobrarDetalle As EntidadesWCF.e_CuentaPorCobrarDetalle) As Boolean Implements Il_CuentaPorCobrarDetalle.Guardar
        Try
            If Validar(oeCuentaPorCobrarDetalle) Then
                Return odCuentaPorCobrarDetalle.Guardar(oeCuentaPorCobrarDetalle)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCuentaPorCobrarDetalle As EntidadesWCF.e_CuentaPorCobrarDetalle) As System.Collections.Generic.List(Of EntidadesWCF.e_CuentaPorCobrarDetalle) Implements Il_CuentaPorCobrarDetalle.Listar
        Try
            Return odCuentaPorCobrarDetalle.Listar(oeCuentaPorCobrarDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeCuentaPorCobrarDetalle As EntidadesWCF.e_CuentaPorCobrarDetalle) As EntidadesWCF.e_CuentaPorCobrarDetalle Implements Il_CuentaPorCobrarDetalle.Obtener
        Try
            Return odCuentaPorCobrarDetalle.Obtener(oeCuentaPorCobrarDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeCuentaPorCobrarDetalle As EntidadesWCF.e_CuentaPorCobrarDetalle) As Boolean Implements Il_CuentaPorCobrarDetalle.Validar
        Try
            With oeCuentaPorCobrarDetalle
                l_FuncionesGenerales.ValidarCampoNoNulo(.Concepto, "Ingrese Glosa")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdTipoPago, "Seleccione el modo de pago")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
