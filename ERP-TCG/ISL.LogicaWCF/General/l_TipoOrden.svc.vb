Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_TipoOrden
    Implements Il_TipoOrden

    Dim odTipoOrden As New d_TipoOrden
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeTipoOrden As EntidadesWCF.e_TipoOrden) As Boolean Implements Il_TipoOrden.Eliminar
        Try
            Return odTipoOrden.Eliminar(oeTipoOrden)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoOrden As EntidadesWCF.e_TipoOrden) As Boolean Implements Il_TipoOrden.Guardar
        Try
            If Validar(oeTipoOrden) Then
                Return odTipoOrden.Guardar(oeTipoOrden)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeTipoOrden As EntidadesWCF.e_TipoOrden) As System.Collections.Generic.List(Of EntidadesWCF.e_TipoOrden) Implements Il_TipoOrden.Listar
        Try
            Return odTipoOrden.Listar(oeTipoOrden)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoOrden As EntidadesWCF.e_TipoOrden) As EntidadesWCF.e_TipoOrden Implements Il_TipoOrden.Obtener
        Try
            Return odTipoOrden.Obtener(oeTipoOrden)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeTipoOrden As EntidadesWCF.e_TipoOrden) As Boolean Implements Il_TipoOrden.Validar
        Try
            With oeTipoOrden
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar el nombre")
                ValidarDuplicado(.Id, .Codigo, "codigo")
                ValidarDuplicado(.Id, .Nombre, "nombre")
                ValidarDuplicado(.Id, .Abreviatura, "abreviatura")
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean Implements Il_TipoOrden.ValidarDuplicado
        Dim oeTipoOrden As New e_TipoOrden
        Try
            If valor = "" Then
                Return False
            Else
                Select Case campo
                    Case "codigo"
                        oeTipoOrden.Codigo = valor
                    Case "nombre"
                        oeTipoOrden.Nombre = valor
                    Case "abreviatura"
                        oeTipoOrden.Abreviatura = valor
                End Select
                oeTipoOrden = odTipoOrden.Obtener(oeTipoOrden)
                If Not oeTipoOrden.Id Is Nothing And oeTipoOrden.Id <> id Then Throw New Exception("Ya existe el(la) " & campo & " :" & valor)
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
