'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_TipoMovimientoInventario
    Implements Il_TipoMovimientoInventario

    Private odTipoMovimientoInventario As New d_TipoMovimientoInventario
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeTipoMovimientoInventario As e_TipoMovimientoInventario) As Boolean Implements Il_TipoMovimientoInventario.Eliminar
        Try
            Return odTipoMovimientoInventario.Eliminar(oeTipoMovimientoInventario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoMovimientoInventario As e_TipoMovimientoInventario) As Boolean Implements Il_TipoMovimientoInventario.Guardar
        Try
            If Validar(oeTipoMovimientoInventario) Then
                Return odTipoMovimientoInventario.Guardar(oeTipoMovimientoInventario)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeTipoMovimientoInventario As e_TipoMovimientoInventario) As System.Collections.Generic.List(Of e_TipoMovimientoInventario) Implements Il_TipoMovimientoInventario.Listar
        Try
            Return odTipoMovimientoInventario.Listar(oeTipoMovimientoInventario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoMovimientoInventario As e_TipoMovimientoInventario) As e_TipoMovimientoInventario Implements Il_TipoMovimientoInventario.Obtener
        Try
            Return odTipoMovimientoInventario.Obtener(oeTipoMovimientoInventario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeTipoMovimientoInventario As e_TipoMovimientoInventario) As Boolean Implements Il_TipoMovimientoInventario.Validar
        Try
            With oeTipoMovimientoInventario
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "Debe ingresar el codigo")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar el nombre")
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Abreviatura, "Debe ingresar la abreviatura")
                ValidarDuplicado(.Id, .Codigo, "codigo")
                ValidarDuplicado(.Id, .Nombre, "nombre")
                ValidarDuplicado(.Id, .Abreviatura, "abreviatura")
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean Implements Il_TipoMovimientoInventario.ValidarDuplicado
        Dim oeTipoMovimientoInventario As New e_TipoMovimientoInventario
        Try
            If valor = "" Then
                Return False
            Else
                Select Case campo
                    Case "codigo"
                        oeTipoMovimientoInventario.Codigo = valor
                    Case "nombre"
                        oeTipoMovimientoInventario.Nombre = valor
                    Case "abreviatura"
                        oeTipoMovimientoInventario.Abreviatura = valor
                End Select
                oeTipoMovimientoInventario = odTipoMovimientoInventario.Obtener(oeTipoMovimientoInventario)
                If Not oeTipoMovimientoInventario.Id Is Nothing And oeTipoMovimientoInventario.Id <> id Then Throw New Exception("Ya existe el(la) " & campo & " :" & valor)
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
