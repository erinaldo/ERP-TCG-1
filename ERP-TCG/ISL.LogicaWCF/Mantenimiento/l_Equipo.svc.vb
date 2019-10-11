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
Public Class l_Equipo
    Implements Il_Equipo

    Dim odEquipo As New d_Equipo
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeEquipo As EntidadesWCF.e_Equipo) As Boolean Implements Il_Equipo.Eliminar
        Try
            Return odEquipo.Eliminar(oeEquipo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeEquipo As EntidadesWCF.e_Equipo) As Boolean Implements Il_Equipo.Guardar
        Try
            If Validar(oeEquipo) Then
                Return odEquipo.Guardar(oeEquipo)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeEquipo As EntidadesWCF.e_Equipo) As System.Collections.Generic.List(Of EntidadesWCF.e_Equipo) Implements Il_Equipo.Listar
        Try
            Return odEquipo.Listar(oeEquipo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeEquipo As EntidadesWCF.e_Equipo) As EntidadesWCF.e_Equipo Implements Il_Equipo.Obtener
        Try
            Return odEquipo.Obtener(oeEquipo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeEquipo As EntidadesWCF.e_Equipo) As Boolean Implements Il_Equipo.Validar
        Try
            With oeEquipo
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar nombre del documento")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdTipoEquipo, "Seleccione un tipo de equipo")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdMarca, "Seleccione una marca")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdModelo, "Seleccione un modelo")
                ValidarDuplicado(.Id, .Nombre)
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal ls_Id As String, ByVal ls_Nombre As String) As Boolean Implements Il_Equipo.ValidarDuplicado
        Try
            Dim oeEquipo As New e_Equipo
            oeEquipo.Nombre = ls_Nombre
            oeEquipo = odEquipo.Obtener(oeEquipo)
            If oeEquipo.Id <> "" Then
                If ls_Id = "" OrElse oeEquipo.Id <> ls_Id Then
                    Throw New Exception("Ya existe: " & ls_Nombre)
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
