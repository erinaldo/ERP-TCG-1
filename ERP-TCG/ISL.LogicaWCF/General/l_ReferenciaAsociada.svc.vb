Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()>
Public Class l_ReferenciaAsociada
    Implements Il_ReferenciaAsociada

    Private odReferenciaAsociada As New d_ReferenciaAsociada

    Public Function Eliminar(ByVal oeReferenciaAsociada As e_ReferenciaAsociada) As Boolean Implements Il_ReferenciaAsociada.Eliminar
        'Try
        '    Return odReferenciaAsociada.Eliminar(oeReferenciaAsociada)
        'Catch ex As Exception
        '    Throw
        'End Try
        Return True
    End Function

    Public Function Guardar(ByVal oeReferenciaAsociada As e_ReferenciaAsociada) As Boolean Implements Il_ReferenciaAsociada.Guardar
        Try
            Return odReferenciaAsociada.Guardar(oeReferenciaAsociada)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeReferenciaAsociada As e_ReferenciaAsociada) As List(Of e_ReferenciaAsociada) Implements Il_ReferenciaAsociada.Listar
        Try
            Return odReferenciaAsociada.Listar(oeReferenciaAsociada)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeReferenciaAsociada As e_ReferenciaAsociada) As e_ReferenciaAsociada Implements Il_ReferenciaAsociada.Obtener
        Try
            Return odReferenciaAsociada.Obtener(oeReferenciaAsociada)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
