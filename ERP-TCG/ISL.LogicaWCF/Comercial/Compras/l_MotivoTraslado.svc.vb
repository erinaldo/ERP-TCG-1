Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_MotivoTraslado
    Implements Il_MotivoTraslado

    Dim odMotivoTraslado As New d_MotivoTraslado

    Public Function Eliminar(ByVal oeMotivoTraslado As EntidadesWCF.e_MotivoTraslado) As Boolean Implements Il_MotivoTraslado.Eliminar
        Try
            Return odMotivoTraslado.Eliminar(oeMotivoTraslado)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMotivoTraslado As EntidadesWCF.e_MotivoTraslado) As Boolean Implements Il_MotivoTraslado.Guardar
        Try
            If Validar(oeMotivoTraslado) Then
                Return odMotivoTraslado.Guardar(oeMotivoTraslado)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMotivoTraslado As EntidadesWCF.e_MotivoTraslado) As System.Collections.Generic.List(Of EntidadesWCF.e_MotivoTraslado) Implements Il_MotivoTraslado.Listar
        Try
            Return odMotivoTraslado.Listar(oeMotivoTraslado)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMotivoTraslado As EntidadesWCF.e_MotivoTraslado) As EntidadesWCF.e_MotivoTraslado Implements Il_MotivoTraslado.Obtener
        Try
            Return odMotivoTraslado.Obtener(oeMotivoTraslado)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMotivoTraslado As EntidadesWCF.e_MotivoTraslado) As Boolean Implements Il_MotivoTraslado.Validar
        Try
            With oeMotivoTraslado
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
