Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_TipoVenta
    Implements Il_TipoVenta

    Dim odTipoVenta As New d_TipoVenta

    Public Function Eliminar(ByVal oeTipoVenta As EntidadesWCF.e_TipoVenta) As Boolean Implements Il_TipoVenta.Eliminar
        Try
            Return odTipoVenta.Eliminar(oeTipoVenta)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoVenta As EntidadesWCF.e_TipoVenta) As Boolean Implements Il_TipoVenta.Guardar
        Try
            If Validar(oeTipoVenta) Then
                Return odTipoVenta.Guardar(oeTipoVenta)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoVenta As EntidadesWCF.e_TipoVenta) As System.Collections.Generic.List(Of EntidadesWCF.e_TipoVenta) Implements Il_TipoVenta.Listar
        Try
            Return odTipoVenta.Listar(oeTipoVenta)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoVenta As EntidadesWCF.e_TipoVenta) As EntidadesWCF.e_TipoVenta Implements Il_TipoVenta.Obtener
        Try
            Return odTipoVenta.Obtener(oeTipoVenta)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTipoVenta As EntidadesWCF.e_TipoVenta) As Boolean Implements Il_TipoVenta.Validar
        Try
            With oeTipoVenta
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
