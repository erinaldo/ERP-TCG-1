Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_TipoPago
    Implements Il_TipoPago

    Dim odTipoPago As New d_TipoPago
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeTipoPago As EntidadesWCF.e_TipoPago) As Boolean Implements Il_TipoPago.Eliminar
        Try
            Return odTipoPago.Eliminar(oeTipoPago)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoPago As EntidadesWCF.e_TipoPago) As Boolean Implements Il_TipoPago.Guardar
        Try
            If Validar(oeTipoPago) Then
                Return odTipoPago.Guardar(oeTipoPago)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoPago As EntidadesWCF.e_TipoPago) As System.Collections.Generic.List(Of EntidadesWCF.e_TipoPago) Implements Il_TipoPago.Listar
        Try
            Return odTipoPago.Listar(oeTipoPago)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoPago As EntidadesWCF.e_TipoPago) As EntidadesWCF.e_TipoPago Implements Il_TipoPago.Obtener
        Try
            Return odTipoPago.Obtener(oeTipoPago)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTipoPago As EntidadesWCF.e_TipoPago) As Boolean Implements Il_TipoPago.Validar
        Try
            With oeTipoPago
                l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "Debe ingresar codigo del tipo de pago")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar nombre del tipo de pago")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Abreviatura, "Debe ingresar abreviatura  del tipo de pago")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
