Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Denominacion
    Implements Il_Denominacion
    Dim odDenominacion As New d_Denominacion

    Public Function Eliminar(ByVal oeDenominacion As EntidadesWCF.e_Denominacion) As Boolean Implements Il_Denominacion.Eliminar
        Try
            Return odDenominacion.Eliminar(oeDenominacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDenominacion As EntidadesWCF.e_Denominacion) As Boolean Implements Il_Denominacion.Guardar
        Try
            If Validar(oeDenominacion) Then
                Return odDenominacion.Guardar(oeDenominacion)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDenominacion As EntidadesWCF.e_Denominacion) As System.Collections.Generic.List(Of EntidadesWCF.e_Denominacion) Implements Il_Denominacion.Listar
        Try
            Return odDenominacion.Listar(oeDenominacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeDenominacion As EntidadesWCF.e_Denominacion) As EntidadesWCF.e_Denominacion Implements Il_Denominacion.Obtener
        Try
            Return odDenominacion.Obtener(oeDenominacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeDenominacion As EntidadesWCF.e_Denominacion) As Boolean Implements Il_Denominacion.Validar
        Try
            With oeDenominacion
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
