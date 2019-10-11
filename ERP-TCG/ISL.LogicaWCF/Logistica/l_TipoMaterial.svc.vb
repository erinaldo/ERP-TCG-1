'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_TipoMaterial
    Implements Il_TipoMaterial
    Dim odTipoMaterial As New d_TipoMaterial
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeTipoMaterial As EntidadesWCF.e_TipoMaterial) As Boolean Implements Il_TipoMaterial.Eliminar
        Try
            Return odTipoMaterial.Eliminar(oeTipoMaterial)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoMaterial As EntidadesWCF.e_TipoMaterial) As Boolean Implements Il_TipoMaterial.Guardar
        Try
            If Validar(oeTipoMaterial) Then
                Return odTipoMaterial.Guardar(oeTipoMaterial)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeTipoMaterial As EntidadesWCF.e_TipoMaterial) As System.Collections.Generic.List(Of EntidadesWCF.e_TipoMaterial) Implements Il_TipoMaterial.Listar
        Try
            Return odTipoMaterial.Listar(oeTipoMaterial)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoMaterial As EntidadesWCF.e_TipoMaterial) As EntidadesWCF.e_TipoMaterial Implements Il_TipoMaterial.Obtener
        Try
            Return odTipoMaterial.Obtener(oeTipoMaterial)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeTipoMaterial As EntidadesWCF.e_TipoMaterial) As Boolean Implements Il_TipoMaterial.Validar
        Try
            With oeTipoMaterial
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

    Public Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean Implements Il_TipoMaterial.ValidarDuplicado
        Dim oeTipoMaterial As New e_TipoMaterial
        Try
            If String.IsNullOrEmpty(valor) Then
                Return False
            Else
                Select Case campo
                    Case "codigo"
                        oeTipoMaterial.Codigo = valor
                    Case "nombre"
                        oeTipoMaterial.Nombre = valor
                    Case "abreviatura"
                        oeTipoMaterial.Abreviatura = valor
                End Select
                oeTipoMaterial = odTipoMaterial.Obtener(oeTipoMaterial)
                If Not oeTipoMaterial.Id Is Nothing And oeTipoMaterial.Id <> id Then Throw New Exception("Ya existe el(la) " & campo & " :" & valor)
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
