Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_DetalleConfiguracionNeumatico", también debe actualizar la referencia a "Il_DetalleConfiguracionNeumatico" en Web.config.
<ServiceContract()> _
Public Interface Il_DetalleConfiguracionNeumatico

    <OperationContract()> _
    Function Obtener(ByVal oeDetalleConfiguracionNeumatico As e_DetalleConfiguracionNeumatico) As e_DetalleConfiguracionNeumatico

    <OperationContract()> _
    Function Listar(ByVal oeDetalleConfiguracionNeumatico As e_DetalleConfiguracionNeumatico) As List(Of e_DetalleConfiguracionNeumatico)

    <OperationContract()> _
    Function Validar(ByVal oeDetalleConfiguracionNeumatico As e_DetalleConfiguracionNeumatico) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDetalleConfiguracionNeumatico As e_DetalleConfiguracionNeumatico) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDetalleConfiguracionNeumatico As e_DetalleConfiguracionNeumatico) As Boolean

End Interface
