Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_GuiaRemisionRemitente_Detalle
    Implements Il_GuiaRemisionRemitente_Detalle

    Dim odGuiaRemitente As d_GuiaRemisionRemitente_Detalle

    Public Function Eliminar(ByVal oeGuiaRemitente_Detalle As e_GuiaRemisionRemitente_Detalle) As Boolean Implements Il_GuiaRemisionRemitente_Detalle.Eliminar
        Try
            odGuiaRemitente = New d_GuiaRemisionRemitente_Detalle
            Return odGuiaRemitente.Eliminar(oeGuiaRemitente_Detalle)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeGuiaRemitente_Detalle As e_GuiaRemisionRemitente_Detalle) As Boolean Implements Il_GuiaRemisionRemitente_Detalle.Guardar
        Try
            odGuiaRemitente = New d_GuiaRemisionRemitente_Detalle
            If Validar(oeGuiaRemitente_Detalle) Then
                Return odGuiaRemitente.Guardar(oeGuiaRemitente_Detalle)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeGuiaRemitente_Detalle As e_GuiaRemisionRemitente_Detalle) As System.Collections.Generic.List(Of e_GuiaRemisionRemitente_Detalle) Implements Il_GuiaRemisionRemitente_Detalle.Listar
        Try
            odGuiaRemitente = New d_GuiaRemisionRemitente_Detalle
            Return odGuiaRemitente.Listar(oeGuiaRemitente_Detalle)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDT(ByVal oeGuiaRemitente_Detalle As e_GuiaRemisionRemitente_Detalle) As DataTable Implements Il_GuiaRemisionRemitente_Detalle.ListarDT
        Try
            odGuiaRemitente = New d_GuiaRemisionRemitente_Detalle
            Return odGuiaRemitente.ListarDT(oeGuiaRemitente_Detalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeGuiaRemitente_Detalle As e_GuiaRemisionRemitente_Detalle) As e_GuiaRemisionRemitente_Detalle Implements Il_GuiaRemisionRemitente_Detalle.Obtener
        Try
            odGuiaRemitente = New d_GuiaRemisionRemitente_Detalle
            Return odGuiaRemitente.Obtener(oeGuiaRemitente_Detalle)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Validar(ByVal oeGuiaRemitente_Detalle As e_GuiaRemisionRemitente_Detalle) As Boolean
        Try
            With oeGuiaRemitente_Detalle
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
