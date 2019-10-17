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
Public Class l_TipoGasto
    Implements Il_TipoGasto
    Dim odTipoGasto As New d_TipoGasto
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeTipoGasto As EntidadesWCF.e_TipoGasto) As Boolean Implements Il_TipoGasto.Eliminar
        Try
            Return odTipoGasto.Eliminar(oeTipoGasto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoGasto As EntidadesWCF.e_TipoGasto) As Boolean Implements Il_TipoGasto.Guardar
        Try
            If Validar(oeTipoGasto) Then
                Return odTipoGasto.Guardar(oeTipoGasto)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoGasto As EntidadesWCF.e_TipoGasto) As System.Data.DataSet Implements Il_TipoGasto.Listar
        Try
            Dim odTipoGasto As New d_TipoGasto
            Return odTipoGasto.Listar(oeTipoGasto)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar2(ByVal oeTipoGasto As EntidadesWCF.e_TipoGasto) As System.Collections.Generic.List(Of EntidadesWCF.e_TipoGasto) Implements Il_TipoGasto.Listar2
        Try
            Return odTipoGasto.Listar2(oeTipoGasto)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDetalle(ByVal oeTipoGastoDetalle As EntidadesWCF.e_TipoGastoDetalle) As System.Collections.Generic.List(Of EntidadesWCF.e_TipoGastoDetalle) Implements Il_TipoGasto.ListarDetalle
        Try
            Return odTipoGasto.ListarDetalle(oeTipoGastoDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoGasto As EntidadesWCF.e_TipoGasto) As EntidadesWCF.e_TipoGasto Implements Il_TipoGasto.Obtener
        Try
            Return odTipoGasto.Obtener(oeTipoGasto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTipoGasto As EntidadesWCF.e_TipoGasto) As Boolean Implements Il_TipoGasto.Validar
        Try
            With oeTipoGasto
                l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "Ingrese el codigo")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Ingrese un nombre")
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Abreviatura, "Ingrese la abreviatura")
                ValidarDuplicado(.Id, .Nombre)
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal ID As String, ByVal NOMBRE As String) As Boolean Implements Il_TipoGasto.ValidarDuplicado
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(NOMBRE, "No ha Ingresado")
            Dim oeTipoGasto As New e_TipoGasto
            ' oeBanco.Id = ID
            oeTipoGasto.Nombre = NOMBRE
            oeTipoGasto.Activo = True
            oeTipoGasto = odTipoGasto.Obtener(oeTipoGasto)
            If oeTipoGasto.Id <> "" Then
                If ID = "" OrElse oeTipoGasto.Id <> ID Then
                    Throw New Exception("Ya existe: " & NOMBRE)
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
