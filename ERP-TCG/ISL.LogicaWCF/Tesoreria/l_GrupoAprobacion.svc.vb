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

' NOTA: si cambia aquí el nombre de clase "l_GrupoAprobacion", también debe actualizar la referencia a "l_GrupoAprobacion" tanto en Web.config como en el archivo .svc asociado.
Public Class l_GrupoAprobacion
    Implements Il_GrupoAprobacion

    Dim odGrupoAprobacion As New d_GrupoAprobacion

    Public Function Obtener(ByVal oeGrupoAprobacion As e_GrupoAprobacion) As e_GrupoAprobacion Implements Il_GrupoAprobacion.Obtener
        Try
            Return odGrupoAprobacion.Obtener(oeGrupoAprobacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGrupoAprobacion As e_GrupoAprobacion) As System.Data.DataSet Implements Il_GrupoAprobacion.Listar
        Try
            Return odGrupoAprobacion.Listar(oeGrupoAprobacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDetalle(ByVal oeGrupoAprobacion As e_GrupoAprobacion) As List(Of e_GrupoAprobacion) Implements Il_GrupoAprobacion.ListarDetalle
        Try
            Return odGrupoAprobacion.ListarDetalle(oeGrupoAprobacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeGrupoAprobacion As e_GrupoAprobacion) As Boolean Implements Il_GrupoAprobacion.Validar
        Try
            With oeGrupoAprobacion
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeGrupoAprobacion As e_GrupoAprobacion) As Boolean Implements Il_GrupoAprobacion.Guardar
        Try
            If Validar(oeGrupoAprobacion) Then
                Return odGrupoAprobacion.Guardar(oeGrupoAprobacion)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeGrupoAprobacion As e_GrupoAprobacion) As Boolean Implements Il_GrupoAprobacion.Eliminar
        Try
            Return odGrupoAprobacion.Eliminar(oeGrupoAprobacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
