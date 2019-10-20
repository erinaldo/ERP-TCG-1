Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_TipoEquipo
    Implements Il_TipoEquipo

    Dim odTipoEquipo As New d_TipoEquipo
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeTipoEquipo As e_TipoEquipo) As Boolean Implements Il_TipoEquipo.Eliminar
        Try
            Return odTipoEquipo.Eliminar(oeTipoEquipo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoEquipo As e_TipoEquipo) As Boolean Implements Il_TipoEquipo.Guardar
        Try
            If Validar(oeTipoEquipo) Then
                Return odTipoEquipo.Guardar(oeTipoEquipo)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoEquipo As e_TipoEquipo) As System.Collections.Generic.List(Of e_TipoEquipo) Implements Il_TipoEquipo.Listar
        Try
            Return odTipoEquipo.Listar(oeTipoEquipo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoEquipo As e_TipoEquipo) As e_TipoEquipo Implements Il_TipoEquipo.Obtener
        Try
            Return odTipoEquipo.Obtener(oeTipoEquipo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTipoEquipo As e_TipoEquipo) As Boolean Implements Il_TipoEquipo.Validar
        Try
            With oeTipoEquipo
                l_FuncionesGenerales.ValidarCampoNoNulo(oeTipoEquipo.Nombre, "No se ha definido el nombre del tipo de equipo")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
