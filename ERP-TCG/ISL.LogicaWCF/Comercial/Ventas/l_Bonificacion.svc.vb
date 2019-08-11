Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization
' NOTA: si cambia aquí el nombre de clase "l_Bonificacion", también debe actualizar la referencia a "l_Bonificacion" tanto en Web.config como en el archivo .svc asociado.

<DataContract(), Serializable()> _
Public Class l_Bonificacion
    Implements Il_Bonificacion

    Dim odBonificacion As New d_Bonificacion

    'Public Sub DoWork() Implements Il_Bonificacion.DoWork
    'End Sub

    Public Function Obtener(ByVal oeBonificacion As e_Bonificacion) As e_Bonificacion Implements Il_Bonificacion.Obtener
        Try
            Return odBonificacion.Obtener(oeBonificacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeBonificacion As e_Bonificacion) As List(Of e_Bonificacion) Implements Il_Bonificacion.Listar
        Try
            Return odBonificacion.Listar(oeBonificacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeBonificacion As e_Bonificacion) As Boolean Implements Il_Bonificacion.Guardar
        Try
            Return odBonificacion.Guardar(oeBonificacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Elimiar(ByVal oeBonificacion As e_Bonificacion) As Boolean Implements Il_Bonificacion.Eliminar
        Try
            Return odBonificacion.Eliminar(oeBonificacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
