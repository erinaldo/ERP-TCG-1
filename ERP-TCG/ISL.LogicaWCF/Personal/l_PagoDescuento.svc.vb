Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos

Public Class l_PagoDescuento
    Implements Il_PagoDescuento

    Dim odPagoDescuento As New d_PagoDescuento

    Public Function Listar(ByVal oePagoDescuento As e_PagoDescuento) As System.Collections.Generic.List(Of e_PagoDescuento) Implements Il_PagoDescuento.Listar
        Try
            Return odPagoDescuento.Listar(oePagoDescuento)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
