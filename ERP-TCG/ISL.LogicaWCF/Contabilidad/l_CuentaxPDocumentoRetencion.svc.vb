Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_CuentaxPDocumentoRetencion
    Implements Il_CuentaxPDocumentoRetencion

    Dim odCuentaxPDocumentoRetencion As New d_CuentaxPDocumentoRetencion

    Public Function Eliminar(ByVal oeCuentaxPDocumentoRetencion As e_CuentaxPDocumentoRetencion) As Boolean Implements Il_CuentaxPDocumentoRetencion.Eliminar
        Try
            Return odCuentaxPDocumentoRetencion.Eliminar(oeCuentaxPDocumentoRetencion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCuentaxPDocumentoRetencion As e_CuentaxPDocumentoRetencion) As Boolean Implements Il_CuentaxPDocumentoRetencion.Guardar
        Try
            If Validar(oeCuentaxPDocumentoRetencion) Then
                Return odCuentaxPDocumentoRetencion.Guardar(oeCuentaxPDocumentoRetencion)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCuentaxPDocumentoRetencion As e_CuentaxPDocumentoRetencion) As System.Collections.Generic.List(Of e_CuentaxPDocumentoRetencion) Implements Il_CuentaxPDocumentoRetencion.Listar
        Try
            Return odCuentaxPDocumentoRetencion.Listar(oeCuentaxPDocumentoRetencion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeCuentaxPDocumentoRetencion As e_CuentaxPDocumentoRetencion) As e_CuentaxPDocumentoRetencion Implements Il_CuentaxPDocumentoRetencion.Obtener
        Try
            Return odCuentaxPDocumentoRetencion.Obtener(oeCuentaxPDocumentoRetencion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeCuentaxPDocumentoRetencion As e_CuentaxPDocumentoRetencion) As Boolean Implements Il_CuentaxPDocumentoRetencion.Validar
        Try
            With oeCuentaxPDocumentoRetencion
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
