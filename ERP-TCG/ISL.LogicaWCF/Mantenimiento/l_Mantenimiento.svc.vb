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
Public Class l_Mantenimiento
    Implements Il_Mantenimiento

    Dim odMantenimiento As New d_Mantenimiento
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeMantenimiento As e_Mantenimiento) As Boolean Implements Il_Mantenimiento.Eliminar
        Try
            Return odMantenimiento.Eliminar(oeMantenimiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMantenimiento As e_Mantenimiento) As Boolean Implements Il_Mantenimiento.Guardar
        Try
            If Validar(oeMantenimiento) Then
                Return odMantenimiento.Guardar(oeMantenimiento)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMantenimiento As e_Mantenimiento) As System.Collections.Generic.List(Of e_Mantenimiento) Implements Il_Mantenimiento.Listar
        Try
            Return odMantenimiento.Listar(oeMantenimiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDS(ByVal oeMantenimiento As e_Mantenimiento) As System.Data.DataSet Implements Il_Mantenimiento.ListarDS
        Try
            Return odMantenimiento.ListarDS(oeMantenimiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarProyeccionMantenimiento(ByVal ls_IdMarca As String, ByVal ls_IdModelo As String, ByVal ls_TipoProyeccion As String) As System.Data.DataSet Implements Il_Mantenimiento.ListarProyeccionMantenimiento
        Try
            Return odMantenimiento.ListarProyeccionMantenimiento(ls_IdMarca, ls_IdModelo, ls_TipoProyeccion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMantenimiento As e_Mantenimiento) As e_Mantenimiento Implements Il_Mantenimiento.Obtener
        Try
            Return odMantenimiento.Obtener(oeMantenimiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMantenimiento As e_Mantenimiento) As Boolean Implements Il_Mantenimiento.Validar
        Try
            With oeMantenimiento
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar nombre del mantenimiento")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdTipoMantenimiento, "Seleccione un tipo de mantenimiento")
                If oeMantenimiento.TipoMantenimiento = "PREVENTIVO" Then
                    l_FuncionesGenerales.ValidarNumero(.Cantidad, "Debe ingresar una cantidad")
                    l_FuncionesGenerales.ValidarCampoNoNulo(.IdUnidadMedida, "Seleccione una unidad medida")
                End If
                l_FuncionesGenerales.ValidarNumero(.lstDetalleEquipo.Count, "El mantenimiento no contiene ningún equipo")
                ValidarDuplicado(.Id, .Nombre)
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal ls_Id As String, ByVal ls_Nombre As String) As Boolean Implements Il_Mantenimiento.ValidarDuplicado
        Try
            Dim oeMantenimiento As New e_Mantenimiento
            oeMantenimiento.Nombre = ls_Nombre
            oeMantenimiento.Activo = True
            oeMantenimiento = odMantenimiento.Obtener(oeMantenimiento)
            If Not oeMantenimiento Is Nothing Then
                If ls_Id = "" OrElse oeMantenimiento.Id <> ls_Id Then
                    Throw New Exception("Ya existe: " & ls_Nombre)
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarProyMant(ByVal oeProyMant As e_ProyMantenimiento) As System.Collections.Generic.List(Of e_ProyMantenimiento) Implements Il_Mantenimiento.ListarProyMant
        Try
            Return odMantenimiento.ListarProyMant(oeProyMant)
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
