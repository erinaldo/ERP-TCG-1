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
Public Class l_GrupoSancion
    Implements Il_GrupoSancion

    Dim odGrupoSancion As New d_GrupoSancion

    Public Function Eliminar(ByVal oeGrupoSancion As EntidadesWCF.e_GrupoSancion) As Boolean Implements Il_GrupoSancion.Eliminar
        Try
            Return odGrupoSancion.Eliminar(oeGrupoSancion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGrupoSancion As EntidadesWCF.e_GrupoSancion) As Boolean Implements Il_GrupoSancion.Guardar
        Try
            If Validar(oeGrupoSancion) Then
                If oeGrupoSancion.Estado <> "GENERADA" Then
                    For Each oeDetalle As e_Sancion In oeGrupoSancion.leDetalle
                        oeDetalle.PrefijoID = oeGrupoSancion.PrefijoID '@0001
                        If oeDetalle.TipoOperacion <> "E" Then
                            oeDetalle.TipoOperacion = "A"
                            oeDetalle.Activo = True
                            oeDetalle.IdEstado = oeGrupoSancion.IdEstado
                        End If
                    Next
                End If
                Return odGrupoSancion.Guardar(oeGrupoSancion)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGrupoSancion As EntidadesWCF.e_GrupoSancion) As System.Collections.Generic.List(Of EntidadesWCF.e_GrupoSancion) Implements Il_GrupoSancion.Listar
        Try
            Return odGrupoSancion.Listar(oeGrupoSancion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDS(ByVal oeGrupoSancion As EntidadesWCF.e_GrupoSancion) As System.Data.DataSet Implements Il_GrupoSancion.ListarDS
        Try
            Return odGrupoSancion.ListarDS(oeGrupoSancion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeGrupoSancion As EntidadesWCF.e_GrupoSancion) As EntidadesWCF.e_GrupoSancion Implements Il_GrupoSancion.Obtener
        Try
            Return odGrupoSancion.Obtener(oeGrupoSancion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ObtenerGrupoGenerado(ByVal oeGrupoSancion As EntidadesWCF.e_GrupoSancion) As EntidadesWCF.e_GrupoSancion Implements Il_GrupoSancion.ObtenerGrupoGenerado
        Try
            Return odGrupoSancion.ObtenerGrupoGenerado(oeGrupoSancion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeGrupoSancion As EntidadesWCF.e_GrupoSancion) As Boolean Implements Il_GrupoSancion.Validar
        Try
            With oeGrupoSancion
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

End Class
