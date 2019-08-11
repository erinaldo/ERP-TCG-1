Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_TipoCompra
    Implements Il_TipoCompra

    Dim odTipoCompra As New d_TipoCompra

    Public Function Eliminar(ByVal oeTipoCompra As EntidadesWCF.e_TipoCompra) As Boolean Implements Il_TipoCompra.Eliminar
        Try
            Return odTipoCompra.Eliminar(oeTipoCompra)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoCompra As EntidadesWCF.e_TipoCompra) As Boolean Implements Il_TipoCompra.Guardar
        Try
            If Validar(oeTipoCompra) Then
                Return odTipoCompra.Guardar(oeTipoCompra)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoCompra As EntidadesWCF.e_TipoCompra) As System.Collections.Generic.List(Of EntidadesWCF.e_TipoCompra) Implements Il_TipoCompra.Listar
        Try
            Return odTipoCompra.Listar(oeTipoCompra)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoCompra As EntidadesWCF.e_TipoCompra) As EntidadesWCF.e_TipoCompra Implements Il_TipoCompra.Obtener
        Try
            Return odTipoCompra.Obtener(oeTipoCompra)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTipoCompra As EntidadesWCF.e_TipoCompra) As Boolean Implements Il_TipoCompra.Validar
        Try
            With oeTipoCompra
                'ValidarDuplicado(.Id, .Ejercicio, "Ejercicio")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    'Public Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean Implements Il_TipoCompra.ValidarDuplicado

    'End Function

End Class
