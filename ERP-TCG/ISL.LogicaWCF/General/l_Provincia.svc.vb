'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

''' <summary>
''' Clase de la capa lógica para validar datos del objeto Provincia
''' </summary>
''' <remarks></remarks>
<DataContract(), Serializable()> _
Public Class l_Provincia
    Implements Il_Provincia

    Private oeProvincia As New e_Provincia
    Private odProvincia As New d_Provincia
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    ''' <summary>
    ''' Método para validar los datos del objeto Provincia
    ''' </summary>
    ''' <param name="oeProvincia"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Eliminar(ByVal oeProvincia As EntidadesWCF.e_Provincia) As Boolean Implements Il_Provincia.Eliminar
        Try
            If String.IsNullOrEmpty(oeProvincia.Id) Then Throw New Exception("Falta especificar el Id de la provincia que se va a eliminar")
            Return odProvincia.Eliminar(oeProvincia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Guardar la información de un Provincia
    ''' </summary>
    ''' <param name="oeProvincia"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Guardar(ByVal oeProvincia As EntidadesWCF.e_Provincia) As Boolean Implements Il_Provincia.Guardar
        Try
            If Validar(oeProvincia) Then
                Return odProvincia.Guardar(oeProvincia)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Método para obtener una lista de Provincias
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Listar(ByVal oeProvincia As EntidadesWCF.e_Provincia) As System.Collections.Generic.List(Of EntidadesWCF.e_Provincia) Implements Il_Provincia.Listar
        Try
            Return odProvincia.Listar(oeProvincia)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Método para obtener un Provincia específico
    ''' </summary>
    ''' <param name="oeProvincia"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal oeProvincia As EntidadesWCF.e_Provincia) As EntidadesWCF.e_Provincia Implements Il_Provincia.Obtener
        Try
            Return odProvincia.Obtener(oeProvincia)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeProvincia As EntidadesWCF.e_Provincia) As Boolean Implements Il_Provincia.Validar
        Try
            With oeProvincia
                l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "Debe ingresar el código de la Provincia")
                l_FuncionesGenerales.ValidarCampoNoNulo(.CodigoDepartamento, "Debe ingresar el código del departamento a que pertenece la Provincia")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar el nombre del Provincia")
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
