﻿Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_GRR_Venta
    Implements Il_GRR_Venta

    Dim odGuiaRemitente As d_GRR_Venta

    Public Function Eliminar(ByVal oeGuiaRemitente As e_GRR_Venta) As Boolean Implements Il_GRR_Venta.Eliminar
        Try
            odGuiaRemitente = New d_GRR_Venta
            Return odGuiaRemitente.EliminarAnular(oeGuiaRemitente)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeGuiaRemitente As e_GRR_Venta) As Boolean Implements Il_GRR_Venta.Guardar
        Try
            odGuiaRemitente = New d_GRR_Venta
            If Validar(oeGuiaRemitente) Then
                Return odGuiaRemitente.Guardar(oeGuiaRemitente)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeGuiaRemitente As e_GRR_Venta) As System.Collections.Generic.List(Of e_GRR_Venta) Implements Il_GRR_Venta.Listar
        Try
            odGuiaRemitente = New d_GRR_Venta
            Return odGuiaRemitente.Listar(oeGuiaRemitente)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDT(ByVal oeGuiaRemitente As e_GRR_Venta) As DataTable Implements Il_GRR_Venta.ListarDT
        Try
            odGuiaRemitente = New d_GRR_Venta
            Return odGuiaRemitente.ListarDT(oeGuiaRemitente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeGuiaRemitente As e_GRR_Venta) As e_GRR_Venta Implements Il_GRR_Venta.Obtener
        Try
            odGuiaRemitente = New d_GRR_Venta
            Return odGuiaRemitente.Obtener(oeGuiaRemitente)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Validar(ByVal oeGuiaRemitente As e_GRR_Venta) As Boolean
        Try
            With oeGuiaRemitente
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
