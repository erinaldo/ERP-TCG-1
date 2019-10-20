'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_TipoUnidadMedida
    Implements Il_TipoUnidadMedida
    Private odTipoUnidadMedida As New d_TipoUnidadMedida
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeTipoUnidadMedida As e_TipoUnidadMedida) As Boolean Implements Il_TipoUnidadMedida.Eliminar
        Try
            Return odTipoUnidadMedida.Eliminar(oeTipoUnidadMedida)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoUnidadMedida As e_TipoUnidadMedida) As Boolean Implements Il_TipoUnidadMedida.Guardar
        Try
            If Validar(oeTipoUnidadMedida) Then
                Return odTipoUnidadMedida.Guardar(oeTipoUnidadMedida)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeTipoUnidadMedida As e_TipoUnidadMedida) As System.Collections.Generic.List(Of e_TipoUnidadMedida) Implements Il_TipoUnidadMedida.Listar
        Try
            Return odTipoUnidadMedida.Listar(oeTipoUnidadMedida)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoUnidadMedida As e_TipoUnidadMedida) As e_TipoUnidadMedida Implements Il_TipoUnidadMedida.Obtener
        Try
            Return odTipoUnidadMedida.Obtener(oeTipoUnidadMedida)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeTipoUnidadMedida As e_TipoUnidadMedida) As Boolean Implements Il_TipoUnidadMedida.Validar
        Try
            With oeTipoUnidadMedida
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

    Public Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean Implements Il_TipoUnidadMedida.ValidarDuplicado
        Dim oeTipoUnidadMedida As New e_TipoUnidadMedida
        Try
            If valor = "" Then
                Return False
            Else
                Select Case campo
                    Case "codigo"
                        oeTipoUnidadMedida.Codigo = valor
                    Case "nombre"
                        oeTipoUnidadMedida.Nombre = valor
                    Case "abreviatura"
                        oeTipoUnidadMedida.Abreviatura = valor
                End Select
                oeTipoUnidadMedida = odTipoUnidadMedida.Obtener(oeTipoUnidadMedida)
                If Not oeTipoUnidadMedida.Id Is Nothing And oeTipoUnidadMedida.Id <> id Then Throw New Exception("Ya existe el(la) " & campo & " :" & valor)
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
