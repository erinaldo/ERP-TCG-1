Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_GuiaTransportista
    Implements Il_GuiaTransportista

    Dim odGuiaTransportista As New d_GuiaTransportista

    Public Function Eliminar(ByVal oeGuiaTransportista As EntidadesWCF.e_GuiaTransportista) As Boolean Implements Il_GuiaTransportista.Eliminar
        Try
            Return odGuiaTransportista.Eliminar(oeGuiaTransportista)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGuiaTransportista As EntidadesWCF.e_GuiaTransportista) As Boolean Implements Il_GuiaTransportista.Guardar
        Try
            'If Validar(oeGuiaTransportista) Then
            Return odGuiaTransportista.Guardar(oeGuiaTransportista)
            'End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarSeguimiento(ByVal oeGuiaTransportista As EntidadesWCF.e_Seguimiento) As Boolean Implements Il_GuiaTransportista.GuardarSeguimiento
        Try
            'If Validar(oeGuiaTransportista) Then
            Return odGuiaTransportista.Guardar(oeGuiaTransportista)
            'End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGuiaTransportista As EntidadesWCF.e_GuiaTransportista) As System.Collections.Generic.List(Of EntidadesWCF.e_GuiaTransportista) Implements Il_GuiaTransportista.Listar
        Try
            Return odGuiaTransportista.Listar(oeGuiaTransportista)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDS(ByVal oeGuiaTransportista As EntidadesWCF.e_GuiaTransportista) As System.Collections.Generic.List(Of EntidadesWCF.e_GuiaTransportista) Implements Il_GuiaTransportista.ListarDS
        Try
            Return odGuiaTransportista.ListarDS(oeGuiaTransportista)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarInformeGrt(ByVal oeGuiaTransportista As EntidadesWCF.e_GuiaTransportista) As System.Data.DataTable Implements Il_GuiaTransportista.ListarInformeGrt
        Try
            Return odGuiaTransportista.ListarInformeGrt(oeGuiaTransportista)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeGuiaTransportista As EntidadesWCF.e_GuiaTransportista) As EntidadesWCF.e_GuiaTransportista Implements Il_GuiaTransportista.Obtener
        Try
            Return odGuiaTransportista.Obtener(oeGuiaTransportista)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeGuiaTransportista As EntidadesWCF.e_GuiaTransportista) As Boolean Implements Il_GuiaTransportista.Validar
        Try
            With oeGuiaTransportista
                For Each operacion As e_OperacionDetalle In oeGuiaTransportista.OperacionDetalle
                    If operacion.Flete = 0 Then Throw New Exception("El monto del flete no puede ser 0")
                Next
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
