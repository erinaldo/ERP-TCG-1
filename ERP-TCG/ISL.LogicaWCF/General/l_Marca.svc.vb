'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Marca
    Implements Il_Marca

    Dim odMarca As New d_Marca
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function ComboGrilla(loMarca As List(Of e_Marca)) As Object Implements Il_Marca.ComboGrilla
        Try
            Return odMarca.ComboGrilla(loMarca)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeMarca As EntidadesWCF.e_Marca) As Boolean Implements Il_Marca.Eliminar
        Try
            Return odMarca.Eliminar(oeMarca)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMarca As EntidadesWCF.e_Marca) As Boolean Implements Il_Marca.Guardar
        Try
            If Validar(oeMarca) Then
                Return odMarca.Guardar(oeMarca)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMarca As EntidadesWCF.e_Marca) As System.Collections.Generic.List(Of EntidadesWCF.e_Marca) Implements Il_Marca.Listar
        Try
            Return odMarca.Listar(oeMarca)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMarca As EntidadesWCF.e_Marca) As EntidadesWCF.e_Marca Implements Il_Marca.Obtener
        Try
            Return odMarca.Obtener(oeMarca)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMarca As EntidadesWCF.e_Marca) As Boolean Implements Il_Marca.Validar
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(oeMarca.Nombre, "Debe ingresar nombre de la marca")
            ValidarDuplicado(oeMarca.Id, oeMarca.Nombre)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal ls_Id As String, ByVal ls_Nombre As String) As Boolean Implements Il_Marca.ValidarDuplicado
        Try
            Dim objMarca As New e_Marca
            objMarca.Nombre = ls_Nombre
            objMarca.Activo = True
            objMarca = odMarca.Obtener(objMarca)
            If Not objMarca Is Nothing Then
                If ls_Id = "" OrElse objMarca.Id <> ls_Id Then Throw New Exception("Ya existe: " & ls_Nombre)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
