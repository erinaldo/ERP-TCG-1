Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_TipoOrdenCompra
    Implements Il_TipoOrdenCompra

    Dim odTipoOrdenCompra As New d_TipoOrdenCompra
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeTipoOrdenCompra As EntidadesWCF.e_TipoOrdenCompra) As Boolean Implements Il_TipoOrdenCompra.Eliminar
        Try
            Return odTipoOrdenCompra.Eliminar(oeTipoOrdenCompra)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoOrdenCompra As EntidadesWCF.e_TipoOrdenCompra) As Boolean Implements Il_TipoOrdenCompra.Guardar
        Try
            If Validar(oeTipoOrdenCompra) Then
                Return odTipoOrdenCompra.Guardar(oeTipoOrdenCompra)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoOrdenCompra As EntidadesWCF.e_TipoOrdenCompra) As System.Collections.Generic.List(Of EntidadesWCF.e_TipoOrdenCompra) Implements Il_TipoOrdenCompra.Listar
        Try
            Return odTipoOrdenCompra.Listar(oeTipoOrdenCompra)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoOrdenCompra As EntidadesWCF.e_TipoOrdenCompra) As EntidadesWCF.e_TipoOrdenCompra Implements Il_TipoOrdenCompra.Obtener
        Try
            Return odTipoOrdenCompra.Obtener(oeTipoOrdenCompra)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTipoOrdenCompra As EntidadesWCF.e_TipoOrdenCompra) As Boolean Implements Il_TipoOrdenCompra.Validar
        Try
            With oeTipoOrdenCompra
                l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "Debe ingresar codigo")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar nombre")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Abreviatura, "Debe ingresar abreviatura")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
