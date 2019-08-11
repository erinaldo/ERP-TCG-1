Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_TipoCarga
    Implements Il_TipoCarga

    Dim odTipoCarga As New d_TipoCarga

    Public Function ComboGrilla(ByVal ListaTipoCarga As System.Collections.Generic.List(Of EntidadesWCF.e_TipoCarga)) As Object Implements Il_TipoCarga.ComboGrilla
        Try
            Return odTipoCarga.ComboGrilla(ListaTipoCarga)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeTipoCarga As EntidadesWCF.e_TipoCarga) As Boolean Implements Il_TipoCarga.Eliminar
        Try
            Return odTipoCarga.Eliminar(oeTipoCarga)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoCarga As EntidadesWCF.e_TipoCarga) As Boolean Implements Il_TipoCarga.Guardar
        Try
            If Validar(oeTipoCarga) Then
                Return odTipoCarga.Guardar(oeTipoCarga)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoCarga As EntidadesWCF.e_TipoCarga) As System.Collections.Generic.List(Of EntidadesWCF.e_TipoCarga) Implements Il_TipoCarga.Listar
        Try
            Return odTipoCarga.Listar(oeTipoCarga)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoCarga As EntidadesWCF.e_TipoCarga) As EntidadesWCF.e_TipoCarga Implements Il_TipoCarga.Obtener
        Try
            Return odTipoCarga.Obtener(oeTipoCarga)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTipoCarga As EntidadesWCF.e_TipoCarga) As Boolean Implements Il_TipoCarga.Validar
        Try
            With oeTipoCarga
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
