Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_CategoriaServicio
    Implements Il_CategoriaServicio

    Dim odCategoriaServicio As New d_CategoriaServicio
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeCategoriaServicio As EntidadesWCF.e_CategoriaServicio) As Boolean Implements Il_CategoriaServicio.Eliminar
        Try
            Return odCategoriaServicio.Eliminar(oeCategoriaServicio)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCategoriaServicio As EntidadesWCF.e_CategoriaServicio) As Boolean Implements Il_CategoriaServicio.Guardar
        Try
            If Validar(oeCategoriaServicio) Then
                Return odCategoriaServicio.Guardar(oeCategoriaServicio)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCategoriaServicio As EntidadesWCF.e_CategoriaServicio) As System.Collections.Generic.List(Of EntidadesWCF.e_CategoriaServicio) Implements Il_CategoriaServicio.Listar
        Try
            Return odCategoriaServicio.Listar(oeCategoriaServicio)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCategoriaServicio As EntidadesWCF.e_CategoriaServicio) As EntidadesWCF.e_CategoriaServicio Implements Il_CategoriaServicio.Obtener
        Try
            Return odCategoriaServicio.Obtener(oeCategoriaServicio)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeCategoriaServicio As EntidadesWCF.e_CategoriaServicio) As Boolean Implements Il_CategoriaServicio.Validar
        Try
            With oeCategoriaServicio
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar nombre")
                If .TipoOperacion = "I" Then ValidarDuplicado(.Id, .Nombre)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal ID As String, ByVal NOMBRE As String) As Boolean Implements Il_CategoriaServicio.ValidarDuplicado
        Try
            'l_FuncionesGenerales.ValidarCampoNoNulo(NOMBRE, "No ha Ingresado el nombre de la categoría de servicio")
            Dim oeCategoriaServicio As New e_CategoriaServicio
            oeCategoriaServicio.Nombre = NOMBRE
            oeCategoriaServicio.Activo = True
            oeCategoriaServicio = odCategoriaServicio.Obtener(oeCategoriaServicio)
            If Not oeCategoriaServicio Is Nothing Then
                If ID = "" OrElse oeCategoriaServicio.Id <> ID Then
                    Throw New Exception("La categoría de servicio: " & NOMBRE & ", ya se encuentra registrada")
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
