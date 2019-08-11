Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_MotivoDocumento
    Implements Il_MotivoDocumento
    Dim odMotivoDocumento As New d_MotivoDocumento

    Public Function ComboGrilla(ByVal ListaMotivoDocumento As System.Collections.Generic.List(Of EntidadesWCF.e_MotivoDocumento)) As Object Implements Il_MotivoDocumento.ComboGrilla
        Try
            Return odMotivoDocumento.ComboGrilla(ListaMotivoDocumento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeMotivoDocumento As EntidadesWCF.e_MotivoDocumento) As Boolean Implements Il_MotivoDocumento.Eliminar
        Try
            Return odMotivoDocumento.Eliminar(oeMotivoDocumento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMotivoDocumento As EntidadesWCF.e_MotivoDocumento) As Boolean Implements Il_MotivoDocumento.Guardar
        Try
            If Validar(oeMotivoDocumento) Then
                Return odMotivoDocumento.Guardar(oeMotivoDocumento)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMotivoDocumento As EntidadesWCF.e_MotivoDocumento) As System.Collections.Generic.List(Of EntidadesWCF.e_MotivoDocumento) Implements Il_MotivoDocumento.Listar
        Try
            Return odMotivoDocumento.Listar(oeMotivoDocumento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMotivoDocumento As EntidadesWCF.e_MotivoDocumento) As EntidadesWCF.e_MotivoDocumento Implements Il_MotivoDocumento.Obtener
        Try
            Return odMotivoDocumento.Obtener(oeMotivoDocumento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMotivoDocumento As EntidadesWCF.e_MotivoDocumento) As Boolean Implements Il_MotivoDocumento.Validar
        Try
            With oeMotivoDocumento
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function
End Class
