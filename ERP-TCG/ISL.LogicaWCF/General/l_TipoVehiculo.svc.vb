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
Public Class l_TipoVehiculo
    Implements Il_TipoVehiculo

    Dim oeTipoVehiculo As e_TipoVehiculo
    Dim odTipoVehiculo As d_TipoVehiculo
    Dim l_FuncionesGenerales As l_FuncionesGenerales

    Public Function ComboGrilla(ByVal ListaTipoVehiculo As System.Collections.Generic.List(Of EntidadesWCF.e_TipoVehiculo)) As Object Implements Il_TipoVehiculo.ComboGrilla
        Try
            odTipoVehiculo = New d_TipoVehiculo
            Return odTipoVehiculo.ComboGrilla(ListaTipoVehiculo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeTipoVehiculo As EntidadesWCF.e_TipoVehiculo) As Boolean Implements Il_TipoVehiculo.Eliminar
        Try
            odTipoVehiculo = New d_TipoVehiculo
            Return odTipoVehiculo.Eliminar(oeTipoVehiculo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoVehiculo As EntidadesWCF.e_TipoVehiculo) As Boolean Implements Il_TipoVehiculo.Guardar
        Try
            odTipoVehiculo = New d_TipoVehiculo
            If Validar(oeTipoVehiculo) Then
                Return odTipoVehiculo.Guardar(oeTipoVehiculo)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeTipoVehiculo As EntidadesWCF.e_TipoVehiculo) As System.Collections.Generic.List(Of EntidadesWCF.e_TipoVehiculo) Implements Il_TipoVehiculo.Listar
        Try
            odTipoVehiculo = New d_TipoVehiculo
            Return odTipoVehiculo.Listar(oeTipoVehiculo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoVehiculo As EntidadesWCF.e_TipoVehiculo) As EntidadesWCF.e_TipoVehiculo Implements Il_TipoVehiculo.Obtener
        Try
            odTipoVehiculo = New d_TipoVehiculo
            Return odTipoVehiculo.Obtener(oeTipoVehiculo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTipoVehiculo As EntidadesWCF.e_TipoVehiculo) As Boolean Implements Il_TipoVehiculo.Validar
        Try
            If oeTipoVehiculo.TipoOperacion <> "1" Then
                l_FuncionesGenerales = New l_FuncionesGenerales
                With oeTipoVehiculo
                    l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar nombre")
                    ValidarDuplicado(.Id, .Nombre)
                End With
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal ls_Id As String, ByVal ls_Nombre As String) As Boolean Implements Il_TipoVehiculo.ValidarDuplicado
        Try
            odTipoVehiculo = New d_TipoVehiculo
            oeTipoVehiculo = New e_TipoVehiculo
            oeTipoVehiculo.Nombre = ls_Nombre
            oeTipoVehiculo = odTipoVehiculo.Obtener(oeTipoVehiculo)
            If Not oeTipoVehiculo Is Nothing Then
                If ls_Id = "" OrElse oeTipoVehiculo.Id <> ls_Id Then
                    Throw New Exception("Ya existe: " & ls_Nombre)
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
