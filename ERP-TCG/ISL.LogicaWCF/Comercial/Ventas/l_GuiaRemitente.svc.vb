Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_GuiaRemitente
    Implements Il_GuiaRemitente

    Dim odGuiaRemitente As New d_GuiaRemitente

    Public Function Eliminar(ByVal oeGuiaRemitente As e_GuiaRemitente) As Boolean Implements Il_GuiaRemitente.Eliminar
        Try
            Return odGuiaRemitente.Eliminar(oeGuiaRemitente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGuiaRemitente As e_GuiaRemitente) As Boolean Implements Il_GuiaRemitente.Guardar
        Try
            If Validar(oeGuiaRemitente) Then
                Return odGuiaRemitente.Guardar(oeGuiaRemitente)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGuiaRemitente As e_GuiaRemitente) As System.Collections.Generic.List(Of e_GuiaRemitente) Implements Il_GuiaRemitente.Listar
        Try
            Return odGuiaRemitente.Listar(oeGuiaRemitente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDS(ByVal oeGuiaRemitente As e_GuiaRemitente) As System.Collections.Generic.List(Of e_GuiaRemitente) Implements Il_GuiaRemitente.ListarDS
        Try
            Return odGuiaRemitente.ListarDS(oeGuiaRemitente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeGuiaRemitente As e_GuiaRemitente) As e_GuiaRemitente Implements Il_GuiaRemitente.Obtener
        Try
            Return odGuiaRemitente.Obtener(oeGuiaRemitente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeGuiaRemitente As e_GuiaRemitente) As Boolean Implements Il_GuiaRemitente.Validar
        Try
            With oeGuiaRemitente
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
