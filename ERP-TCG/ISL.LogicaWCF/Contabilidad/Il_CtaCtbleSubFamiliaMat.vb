Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_CtaCtbleSubFamiliaMat" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_CtaCtbleSubFamiliaMat

    <OperationContract()> _
    Function Obtener(ByVal oeCtaCtbleSubFamiliaMat As e_CtaCtbleSubFamiliaMat) As e_CtaCtbleSubFamiliaMat

    <OperationContract()> _
    Function Listar(ByVal oeCtaCtbleSubFamiliaMat As e_CtaCtbleSubFamiliaMat) As List(Of e_CtaCtbleSubFamiliaMat)

    <OperationContract()> _
    Function Validar(ByVal oeCtaCtbleSubFamiliaMat As e_CtaCtbleSubFamiliaMat) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCtaCtbleSubFamiliaMat As e_CtaCtbleSubFamiliaMat) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCtaCtbleSubFamiliaMat As e_CtaCtbleSubFamiliaMat) As Boolean

End Interface
