' NOTA: si cambia aquí el nombre de clase "l_Liquidacion", también debe actualizar la referencia a "l_Liquidacion" tanto en Web.config como en el archivo .svc asociado.
Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Liquidacion
    Implements Il_Liquidacion

    Dim odLiquidacion As New d_Liquidaciones
    'Public Sub DoWork() Implements Il_Liquidacion.DoWork
    'End Sub
    Public Function Obtener(ByVal oeLiquidacion As e_Liquidaciones) As e_Liquidaciones Implements Il_Liquidacion.Obtener
        Try
            Return odLiquidacion.Obtener(oeLiquidacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeLiquidacion As e_Liquidaciones) As List(Of e_Liquidaciones) Implements Il_Liquidacion.Listar
        Try
            Return odLiquidacion.Listar(oeLiquidacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeLiquidacion As e_Liquidaciones) As Boolean Implements Il_Liquidacion.Guardar
        Try
            Return odLiquidacion.Guardar(oeLiquidacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeLiquidacion As e_Liquidaciones) As Boolean Implements Il_Liquidacion.Eliminar
        Try
            Return odLiquidacion.Eliminar(oeLiquidacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ObtenerLiquidacionDetalle(ByVal oeLiquidacionDetalle As e_LiquidacionDetalle) As e_LiquidacionDetalle Implements Il_Liquidacion.ObtenerLiquidacionDetalle
        Try
            Return odLiquidacion.ObtenerLiquidacionDetalle(oeLiquidacionDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarLiquidacionDetalle(ByVal oeLiquidacionDetalle As e_LiquidacionDetalle) As List(Of e_LiquidacionDetalle) Implements Il_Liquidacion.ListarLiquidacionDetalle
        Try
            Return odLiquidacion.ListarLiquidacionDetalle(oeLiquidacionDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarLiquidacionDetalle(ByVal oeLiquidacionDetalle As e_LiquidacionDetalle) As Boolean Implements Il_Liquidacion.GuardarLiquidacionDetalle
        Try
            Return odLiquidacion.GuardarLiquidacionDetalle(oeLiquidacionDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function EliminarLiquidacionDetalle(ByVal oeLiquidacionDetalle As e_LiquidacionDetalle) As Boolean Implements Il_Liquidacion.EliminarLiquidacionDetalle
        Try
            Return odLiquidacion.EliminarLiquidacionDetalle(oeLiquidacionDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function


End Class
