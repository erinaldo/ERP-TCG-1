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
Public Class l_Trabajador
    Implements Il_Trabajador
    Dim odTrabajador As New d_Trabajador
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function ComboGrilla(ByVal ListaTrabajador As System.Collections.Generic.List(Of EntidadesWCF.e_Trabajador)) As Object Implements Il_Trabajador.ComboGrilla
        Try
            Return odTrabajador.ComboGrilla(ListaTrabajador)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Elimininación definitiva de toda la información del trabajador
    ''' </summary>
    ''' <param name="oeTrabajador"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function EliminacionDefinitiva(ByVal oeTrabajador As EntidadesWCF.e_Trabajador) As Boolean Implements Il_Trabajador.EliminacionDefinitiva
        Try
            If Validar(oeTrabajador) Then
                odTrabajador.EliminacionDefinitiva(oeTrabajador)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Eliminación lógica de la información del Trabajador
    ''' </summary>
    ''' <param name="oeTrabajador">Objeto Trabajador</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Eliminar(ByVal oeTrabajador As EntidadesWCF.e_Trabajador) As Boolean Implements Il_Trabajador.Eliminar
        Try
            If Validar(oeTrabajador) Then
                odTrabajador.Eliminar(oeTrabajador)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Guardar Trabajador
    ''' </summary>
    ''' <param name="oeTrabajador">Objeto Trabajador</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Guardar(ByVal oeTrabajador As EntidadesWCF.e_Trabajador) As Boolean Implements Il_Trabajador.Guardar
        Try
            If Validar(oeTrabajador) Then
                Return odTrabajador.Guardar(oeTrabajador)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Listar Trabajador
    ''' </summary>
    ''' <param name="oeTrabajador">Objeto Trabajador</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Listar(ByVal oeTrabajador As EntidadesWCF.e_Trabajador) As System.Collections.Generic.List(Of EntidadesWCF.e_Trabajador) Implements Il_Trabajador.Listar
        Try
            Return odTrabajador.Listar(oeTrabajador)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar2(ByVal oeTrabajador As EntidadesWCF.e_Trabajador) As System.Collections.Generic.List(Of EntidadesWCF.e_Trabajador) Implements Il_Trabajador.Listar2
        Try
            Return odTrabajador.Listar2(oeTrabajador)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarOnomasticos(ByVal mes As String, Optional ByVal dia As String = "") As System.Collections.Generic.List(Of EntidadesWCF.e_Onomastico) Implements Il_Trabajador.ListarOnomasticos
        Try
            Return odTrabajador.ListarOnomasticos(mes, dia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Obtiene Trabajador
    ''' </summary>
    ''' <param name="oeTrabajador">Objeto Trabajador</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal oeTrabajador As EntidadesWCF.e_Trabajador) As EntidadesWCF.e_Trabajador Implements Il_Trabajador.Obtener
        Try
            Return odTrabajador.Obtener(oeTrabajador)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ObtenerObjeto(ByVal oeTrabajador As EntidadesWCF.e_Trabajador) As EntidadesWCF.e_Trabajador Implements Il_Trabajador.ObtenerObjeto
        Try
            Return odTrabajador.ObtenerObjeto(oeTrabajador)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Validar Trabajador
    ''' </summary>
    ''' <param name="oeTrabajador">Objeto Trabajador</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Validar(ByVal oeTrabajador As EntidadesWCF.e_Trabajador) As Boolean Implements Il_Trabajador.Validar
        Try
            With oeTrabajador
                l_FuncionesGenerales.ValidarCampoNoNulo(.oePersona.Dni, "No ha Ingresado Dni")
                l_FuncionesGenerales.ValidarCampoNoNulo(.oePersona.ApellidoPaterno, "No ha Ingresado Apellido Paterno")
                l_FuncionesGenerales.ValidarCampoNoNulo(.oePersona.ApellidoMaterno, "No ha Ingresado Apellido Materno")
                l_FuncionesGenerales.ValidarCampoNoNulo(.oePersona.Nombre, "No ha Ingresado Nombre")
                l_FuncionesGenerales.ValidarNumero(oeTrabajador.leOcupacionTrabajador.Count, "Falta ingresar la Ocupación de: " & oeTrabajador.oePersona.NombreCompleto)
                Dim ocupacionPrincipal As Integer = 0
                For Each ocupac As e_OcupacionTrabajador In oeTrabajador.leOcupacionTrabajador
                    If ocupac.Principal Then
                        ocupacionPrincipal = ocupacionPrincipal + 1
                    End If
                Next
                If ocupacionPrincipal = 0 Then Throw New Exception("No se ha precisado la ocupación principal de " & oeTrabajador.oePersona.NombreCompleto)
                If ocupacionPrincipal > 1 Then Throw New Exception(oeTrabajador.oePersona.NombreCompleto.Trim & ", registra más de una ocupación principal")
                Return True
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Validar Codigo
    ''' </summary>
    ''' <param name="Codigo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ValidarCodigo(ByVal Codigo As String) As Boolean Implements Il_Trabajador.ValidarCodigo
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(Codigo, "No se ha ingresado: Codigo")
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Validar RutaImagen
    ''' </summary>
    ''' <param name="RutaImagen"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ValidarRutaImagen(ByVal RutaImagen As String) As Boolean Implements Il_Trabajador.ValidarRutaImagen
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(RutaImagen, "No se ha Ingresado: RutaImagen")
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function ValidarTrabajador(ByVal Id As String) As Boolean Implements Il_Trabajador.ValidarTrabajador
        Try
            Dim oeTrabajador As New e_Trabajador
            oeTrabajador.TipoOperacion = ""
            oeTrabajador.Id = Id
            oeTrabajador = odTrabajador.Obtener(oeTrabajador)
            If oeTrabajador.Id = "" Then
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CargarDatosGenerales(oeTrabajador As e_Trabajador) As DataSet Implements Il_Trabajador.CargarDatosGenerales
        Try
            Return odTrabajador.CargarDatosGenerales(oeTrabajador)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Migrar(oeTrabajador As e_Trabajador) As Boolean Implements Il_Trabajador.Migrar
        Try
            Return odTrabajador.Migrar(oeTrabajador)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Overloads Function CambiarClaveSeguridad(oeTrabajador As e_Trabajador) As Boolean Implements Il_Trabajador.GambiarClaveSeguridad
        Try
            Return odTrabajador.CambiarClaveSeguridad(oeTrabajador)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
