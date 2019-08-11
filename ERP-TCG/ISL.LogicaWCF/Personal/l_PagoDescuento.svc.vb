Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos

Public Class l_PagoDescuento
    Implements Il_PagoDescuento

    Dim odPagoDescuento As New d_PagoDescuento

    Public Function Listar(ByVal oePagoDescuento As EntidadesWCF.e_PagoDescuento) As System.Collections.Generic.List(Of EntidadesWCF.e_PagoDescuento) Implements Il_PagoDescuento.Listar
        Try
            Return odPagoDescuento.Listar(oePagoDescuento)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
