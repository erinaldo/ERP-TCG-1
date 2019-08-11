Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_LiquidacionTrabajador_Asiento", también debe actualizar la referencia a "Il_LiquidacionTrabajador_Asiento" en Web.config.
<ServiceContract()> _
Public Interface Il_LiquidacionTrabajador_Asiento
    Function Guardar(ByVal oeLiquidacionTrabajador_Asiento As e_LiquidacionTrabajador_Asiento) As Boolean
    Function Listar(ByVal oeLiquidacionTrabajador_Asiento As e_LiquidacionTrabajador_Asiento) As List(Of e_LiquidacionTrabajador_Asiento)

End Interface
