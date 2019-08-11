Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_TipoDocumento
    Implements Il_TipoDocumento

    Dim odTipoDocumento As New d_TipoDocumento
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function ComboGrilla(ByVal TipoDocumento As System.Collections.Generic.List(Of EntidadesWCF.e_TipoDocumento)) As Object Implements Il_TipoDocumento.ComboGrilla
        Try
            Return odTipoDocumento.ComboGrilla(TipoDocumento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ComboGrillaCodigo(ByVal TipoDocumento As System.Collections.Generic.List(Of EntidadesWCF.e_TipoDocumento)) As Object
        Try
            Dim ds = New DataTable
            ds.Columns.Add("Id")
            ds.Columns.Add("Codigo")
            For Each item As e_TipoDocumento In TipoDocumento
                Dim newRow As DataRow = ds.NewRow()
                newRow("Id") = item.Id
                newRow("Codigo") = item.Codigo
                ds.Rows.Add(newRow)
            Next
            Return ds
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeTipoDocumento As EntidadesWCF.e_TipoDocumento) As Boolean Implements Il_TipoDocumento.Eliminar
        Try
            Return odTipoDocumento.Eliminar(oeTipoDocumento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoDocumento As EntidadesWCF.e_TipoDocumento) As Boolean Implements Il_TipoDocumento.Guardar
        Try
            If Validar(oeTipoDocumento) Then
                Return odTipoDocumento.Guardar(oeTipoDocumento)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoDocumento As EntidadesWCF.e_TipoDocumento) As System.Collections.Generic.List(Of EntidadesWCF.e_TipoDocumento) Implements Il_TipoDocumento.Listar
        Try
            Return odTipoDocumento.Listar(oeTipoDocumento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoDocumento As EntidadesWCF.e_TipoDocumento) As EntidadesWCF.e_TipoDocumento Implements Il_TipoDocumento.Obtener
        Try
            Return odTipoDocumento.Obtener(oeTipoDocumento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTipoDocumento As EntidadesWCF.e_TipoDocumento) As Boolean Implements Il_TipoDocumento.Validar
        Try
            With oeTipoDocumento
                l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "Debe ingresar codigo SUNAT")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar nombre del tipo de documento")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Abreviatura, "Debe ingresar la abreviatura del tipo de documento")
                ValidarDuplicado(.Id, .Nombre)
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Validar que no se dupliquen los Tipos de documentos
    ''' </summary>
    ''' <param name="id"></param>
    ''' <param name="valor"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ValidarDuplicado(ByVal id As String, ByVal valor As String) As Boolean Implements Il_TipoDocumento.ValidarDuplicado
        Dim oeTipoDocumento As New e_TipoDocumento
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(valor, "No se ha definido que información se va a verificar si existe")
            oeTipoDocumento.Nombre = valor
            oeTipoDocumento = odTipoDocumento.Obtener(oeTipoDocumento)
            If Not String.IsNullOrEmpty(oeTipoDocumento.Id) And oeTipoDocumento.Id <> id Then Throw New Exception("El tipo de documento " & valor & ", ya se encuentra registrado")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
