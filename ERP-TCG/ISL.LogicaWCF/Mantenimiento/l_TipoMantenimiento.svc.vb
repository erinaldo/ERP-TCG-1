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
Public Class l_TipoMantenimiento
    Implements Il_TipoMantenimiento

    Dim odTipoMantenimiento As New d_TipoMantenimiento
    Dim l_FuncionesGenerales As New l_FuncionesGenerales


    Public Function Eliminar(ByVal oeTipoMantenimiento As EntidadesWCF.e_TipoMantenimiento) As Boolean Implements Il_TipoMantenimiento.Eliminar
        Try
            Return odTipoMantenimiento.Eliminar(oeTipoMantenimiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoMantenimiento As EntidadesWCF.e_TipoMantenimiento) As Boolean Implements Il_TipoMantenimiento.Guardar
        Try
            If Validar(oeTipoMantenimiento) Then
                Return odTipoMantenimiento.Guardar(oeTipoMantenimiento)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoMantenimiento As EntidadesWCF.e_TipoMantenimiento) As System.Collections.Generic.List(Of EntidadesWCF.e_TipoMantenimiento) Implements Il_TipoMantenimiento.Listar
        Try
            Return odTipoMantenimiento.Listar(oeTipoMantenimiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoMantenimiento As EntidadesWCF.e_TipoMantenimiento) As EntidadesWCF.e_TipoMantenimiento Implements Il_TipoMantenimiento.Obtener
        Try
            Return odTipoMantenimiento.Obtener(oeTipoMantenimiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTipoMantenimiento As EntidadesWCF.e_TipoMantenimiento) As Boolean Implements Il_TipoMantenimiento.Validar
        Try
            With oeTipoMantenimiento
                l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "Debe ingresar codigo")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar nombre")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Abreviatura, "Debe ingresar abreviatura")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
