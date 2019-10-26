Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_TipoVia
    Implements Il_TipoVia
    Dim odTipoVia As New d_TipoVia

    Public Function Eliminar(ByVal oeTipoVia As e_TipoVia) As Boolean Implements Il_TipoVia.Eliminar
        Try
            Return odTipoVia.Eliminar(oeTipoVia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoVia As e_TipoVia) As Boolean Implements Il_TipoVia.Guardar
        Try
            If Validar(oeTipoVia) Then
                Return odTipoVia.Guardar(oeTipoVia)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoVia As e_TipoVia) As System.Collections.Generic.List(Of e_TipoVia) Implements Il_TipoVia.Listar
        Try
            Return odTipoVia.Listar(oeTipoVia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoVia As e_TipoVia) As e_TipoVia Implements Il_TipoVia.Obtener
        Try
            Return odTipoVia.Obtener(oeTipoVia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTipoVia As e_TipoVia) As Boolean Implements Il_TipoVia.Validar
        Try
            With oeTipoVia
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
