Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Movimiento
    Implements Il_Movimiento
    Dim odMovimiento As New d_Movimiento

    Public Function Eliminar(ByVal oeMovimiento As EntidadesWCF.e_Movimiento) As Boolean Implements Il_Movimiento.Eliminar
        Try
            Return odMovimiento.Eliminar(oeMovimiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMovimiento As EntidadesWCF.e_Movimiento, oeMov As e_Movimiento) As Boolean Implements Il_Movimiento.Guardar
        Try
            Return odMovimiento.GuardarMovimiento(oeMovimiento, oeMov)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarDobleMovimiento(ByVal loMovimiento As List(Of e_Movimiento), oeMov As e_Movimiento) As Boolean Implements Il_Movimiento.GuardarDobleMovimiento
        Try
            Return odMovimiento.GuardarDobleMovimiento(loMovimiento, oeMov)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarDsctoExtorno(ByVal oeMovimiento As EntidadesWCF.e_Movimiento) As Boolean Implements Il_Movimiento.GuardarDsctoExtorno
        Try
            Return odMovimiento.GuardarDsctoExtorno(oeMovimiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeMovimiento As EntidadesWCF.e_Movimiento) As System.Collections.Generic.List(Of EntidadesWCF.e_Movimiento) Implements Il_Movimiento.Listar
        Try
            Return odMovimiento.Listar(oeMovimiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDscto(ByVal oeMovimiento As EntidadesWCF.e_Movimiento) As System.Collections.Generic.List(Of EntidadesWCF.e_Movimiento) Implements Il_Movimiento.ListarDscto
        Try
            Return odMovimiento.ListarDscto(oeMovimiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMovimiento As EntidadesWCF.e_Movimiento) As EntidadesWCF.e_Movimiento Implements Il_Movimiento.Obtener
        Try
            Return odMovimiento.Obtener(oeMovimiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerMovimiento(ByVal oeMovimiento As EntidadesWCF.e_Movimiento) As EntidadesWCF.e_Movimiento Implements Il_Movimiento.ObtenerMovimiento
        Try
            Return odMovimiento.ObtenerMovimiento(oeMovimiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function LiquidarHabilitar(ByVal loMovimiento As List(Of EntidadesWCF.e_Movimiento)) As Boolean Implements Il_Movimiento.LiquidarHabilitar
        Try
            Return odMovimiento.LiquidarHabilitarLista(loMovimiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarSimple(ByVal oeMovimiento As EntidadesWCF.e_Movimiento) As Boolean Implements Il_Movimiento.GuardarSimple
        Try
            Return odMovimiento.GuardarSimple(oeMovimiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
