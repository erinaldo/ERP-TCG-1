Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization
' NOTA: si cambia aquí el nombre de clase "l_GrupoAprobacionDet", también debe actualizar la referencia a "l_GrupoAprobacionDet" tanto en Web.config como en el archivo .svc asociado.
Public Class l_GrupoAprobacionDet
    Implements Il_GrupoAprobacionDet

    Dim odGrupoAprobacionDet As New d_GrupoAprobacionDet

    Public Function Obtener(ByVal oeGrupoAprobacionDet As e_GrupoAprobacionDet) As e_GrupoAprobacionDet Implements Il_GrupoAprobacionDet.Obtener
        Try
            Return odGrupoAprobacionDet.Obtener(oeGrupoAprobacionDet)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGrupoAprobacionDet As e_GrupoAprobacionDet) As List(Of e_GrupoAprobacionDet) Implements Il_GrupoAprobacionDet.Listar
        Try
            Return odGrupoAprobacionDet.Listar(oeGrupoAprobacionDet)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeGrupoAprobacionDet As e_GrupoAprobacionDet) As Boolean Implements Il_GrupoAprobacionDet.Validar
        Try
            With oeGrupoAprobacionDet
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeGrupoAprobacionDet As e_GrupoAprobacionDet) As Boolean Implements Il_GrupoAprobacionDet.Guardar
        Try
            If Validar(oeGrupoAprobacionDet) Then
                Return odGrupoAprobacionDet.Guardar(oeGrupoAprobacionDet)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeGrupoAprobacionDet As e_GrupoAprobacionDet) As Boolean Implements Il_GrupoAprobacionDet.Eliminar
        Try
            Return odGrupoAprobacionDet.Eliminar(oeGrupoAprobacionDet)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
