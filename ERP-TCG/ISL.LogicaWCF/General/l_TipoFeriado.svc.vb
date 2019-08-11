Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

Public Class l_TipoFeriado
    Implements Il_TipoFeriado

    Dim odTipoFeriado As New d_TipoFeriado

    Public Function Obtener(ByVal oeTipoFeriado As e_TipoFeriado) As e_TipoFeriado Implements Il_TipoFeriado.Obtener
        Try
            Return odTipoFeriado.Obtener(oeTipoFeriado)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoFeriado As e_TipoFeriado) As List(Of e_TipoFeriado) Implements Il_TipoFeriado.Listar
        Try
            Return odTipoFeriado.Listar(oeTipoFeriado)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTipoFeriado As e_TipoFeriado) As Boolean Implements Il_TipoFeriado.Validar
        Try
            With oeTipoFeriado
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoFeriado As e_TipoFeriado) As Boolean Implements Il_TipoFeriado.Guardar
        Try
            If Validar(oeTipoFeriado) Then
                Return odTipoFeriado.Guardar(oeTipoFeriado)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeTipoFeriado As e_TipoFeriado) As Boolean Implements Il_TipoFeriado.Eliminar
        Try
            Return odTipoFeriado.Eliminar(oeTipoFeriado)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
