Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ItemGasto
    Implements Il_ItemGasto

    Dim odItemGasto As New d_ItemGasto

    Public Function Buscar(ByVal oeItemGasto As e_ItemGasto) As Boolean Implements Il_ItemGasto.Buscar
        Try
            Return odItemGasto.Buscar(oeItemGasto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeItemGasto As e_ItemGasto) As Boolean Implements Il_ItemGasto.Eliminar
        Try
            Return odItemGasto.Eliminar(oeItemGasto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeItemGasto As e_ItemGasto) As Boolean Implements Il_ItemGasto.Guardar
        Try
            If Validar(oeItemGasto) Then
                Return odItemGasto.Guardar(oeItemGasto)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeItemGasto As e_ItemGasto) As System.Collections.Generic.List(Of e_ItemGasto) Implements Il_ItemGasto.Listar
        Try
            Return odItemGasto.Listar(oeItemGasto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDS(oeItemGasto As e_ItemGasto) As DataSet Implements Il_ItemGasto.ListarDS
        Try
            Return odItemGasto.ListarDS(oeItemGasto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarBind(ByVal oeItemGasto As e_ItemGasto) As System.ComponentModel.BindingList(Of e_ItemGasto) Implements Il_ItemGasto.ListarBind
        Try
            Return odItemGasto.ListarBind(oeItemGasto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeItemGasto As e_ItemGasto) As e_ItemGasto Implements Il_ItemGasto.Obtener
        Try
            Return odItemGasto.Obtener(oeItemGasto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeItemGasto As e_ItemGasto) As Boolean Implements Il_ItemGasto.Validar
        Try
            With oeItemGasto
                If .TipoOperacion = "I" And .Id = "" Then
                    Dim oeIG As New e_ItemGasto
                    Dim leIG As New List(Of e_ItemGasto)
                    oeIG.Nombre = .Nombre
                    leIG.AddRange(Listar(oeIG))
                    If leIG.Count < 0 Then
                        Throw New Exception("Este nombre ya existe: " & .Nombre)
                    End If
                End If
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
