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

Public Class l_AccionSistema
    Implements Il_AccionSistema
    Dim odAccionSistema As New d_AccionSistema
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeAccionSistema As EntidadesWCF.e_AccionSistema) As Boolean Implements Il_AccionSistema.Eliminar
        Try
            Return odAccionSistema.Eliminar(oeAccionSistema)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAccionSistema As EntidadesWCF.e_AccionSistema) As Boolean Implements Il_AccionSistema.Guardar
        Try
            If Validar(oeAccionSistema) Then
                Return odAccionSistema.Guardar(oeAccionSistema)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAccionSistema As EntidadesWCF.e_AccionSistema) As System.Collections.Generic.List(Of EntidadesWCF.e_AccionSistema) Implements Il_AccionSistema.Listar
        Try
            Return odAccionSistema.Listar(oeAccionSistema)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeAccionSistema As EntidadesWCF.e_AccionSistema) As EntidadesWCF.e_AccionSistema Implements Il_AccionSistema.Obtener
        Try
            Return odAccionSistema.Obtener(oeAccionSistema)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeAccionSistema As EntidadesWCF.e_AccionSistema) As Boolean Implements Il_AccionSistema.Validar
        Try
            With oeAccionSistema
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "No ha Ingresado Nombre: ")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Descripcion, "No ha Ingresado Descripción: ")
                If .leActividadRestringida.Count = 0 Then Throw New Exception("Debe Seleccionar al menos una Actividad")
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
