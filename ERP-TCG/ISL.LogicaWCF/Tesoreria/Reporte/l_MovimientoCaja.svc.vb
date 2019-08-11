Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF

Public Class l_MovimientoCaja
    Implements Il_MovimientoCaja
    Dim odMovimientoCaja As New d_MovimientoCaja

    Public Function Listar(ByVal oeMovimientoCaja As EntidadesWCF.e_MovimientoCaja) As System.Collections.Generic.List(Of EntidadesWCF.e_MovimientoCaja) Implements Il_MovimientoCaja.Listar
        Try
            Return odMovimientoCaja.Listar(oeMovimientoCaja)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMovimientoCaja As EntidadesWCF.e_MovimientoCaja) As EntidadesWCF.e_MovimientoCaja Implements Il_MovimientoCaja.Obtener
        Try
            Return odMovimientoCaja.Obtener(oeMovimientoCaja)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
