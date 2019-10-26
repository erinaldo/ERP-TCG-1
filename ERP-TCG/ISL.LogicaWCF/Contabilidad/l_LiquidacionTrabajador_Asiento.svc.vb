'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_LiquidacionTrabajador_Asiento
    Implements Il_LiquidacionTrabajador_Asiento

    Dim odLiquidacionTrabajador_Asiento As New d_LiquidacionTrabajador_Asiento
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Guardar(ByVal oeLiquidacionTrabajador_Asiento As e_LiquidacionTrabajador_Asiento) As Boolean Implements Il_LiquidacionTrabajador_Asiento.Guardar
        Try
            Return odLiquidacionTrabajador_Asiento.Guardar(oeLiquidacionTrabajador_Asiento)

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeLiquidacionTrabajador_Asiento As e_LiquidacionTrabajador_Asiento) As List(Of e_LiquidacionTrabajador_Asiento) Implements Il_LiquidacionTrabajador_Asiento.Listar
        Try
            Return odLiquidacionTrabajador_Asiento.Listar(oeLiquidacionTrabajador_Asiento)

        Catch ex As Exception
            Throw
        End Try
    End Function
End Class

