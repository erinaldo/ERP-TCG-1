' NOTA: si cambia aquí el nombre de clase "Il_ComunAyuda", también debe actualizar la referencia a "Il_ComunAyuda" tanto en Web.config como en el archivo .svc asociado.
Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ComunAyuda
    Implements Il_ComunAyuda

    Public Sub DoWork() Implements Il_ComunAyuda.DoWork
    End Sub

End Class
