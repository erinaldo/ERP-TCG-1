Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_LiquidacionTrabajador_Asiento
    Implements Il_LiquidacionTrabajador_Asiento

    Dim odLiquidacionTrabajador_Asiento As New d_LiquidacionTrabajador_Asiento
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Guardar(ByVal oeLiquidacionTrabajador_Asiento As EntidadesWCF.e_LiquidacionTrabajador_Asiento) As Boolean Implements Il_LiquidacionTrabajador_Asiento.Guardar
        Try
            Return odLiquidacionTrabajador_Asiento.Guardar(oeLiquidacionTrabajador_Asiento)

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeLiquidacionTrabajador_Asiento As EntidadesWCF.e_LiquidacionTrabajador_Asiento) As List(Of e_LiquidacionTrabajador_Asiento) Implements Il_LiquidacionTrabajador_Asiento.Listar
        Try
            Return odLiquidacionTrabajador_Asiento.Listar(oeLiquidacionTrabajador_Asiento)

        Catch ex As Exception
            Throw
        End Try
    End Function
End Class

