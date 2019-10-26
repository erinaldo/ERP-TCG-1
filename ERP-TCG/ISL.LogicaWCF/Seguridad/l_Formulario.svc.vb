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
Public Class l_Formulario
    Implements Il_Formulario

    Dim odFormulario As New d_Formulario
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeFormulario As e_Formulario) As Boolean Implements Il_Formulario.Eliminar
        Try
            Return odFormulario.Eliminar(oeFormulario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeFormulario As e_Formulario) As Boolean Implements Il_Formulario.Guardar
        Try
            If Validar(oeFormulario) Then
                Return odFormulario.Guardar(oeFormulario)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeFormulario As e_Formulario) As System.Collections.Generic.List(Of e_Formulario) Implements Il_Formulario.Listar
        Try
            Return odFormulario.Listar(oeFormulario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarPadre(ByVal oeFormulario As e_Formulario) As System.Collections.Generic.List(Of e_Formulario) Implements Il_Formulario.ListarPadre
        Try
            Return odFormulario.ListarPadre(oeFormulario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeFormulario As e_Formulario) As e_Formulario Implements Il_Formulario.Obtener
        Try
            Return odFormulario.Obtener(oeFormulario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeFormulario As e_Formulario) As Boolean Implements Il_Formulario.Validar
        Try
            With oeFormulario
                l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "No ha Ingresado Codigo: ")
                ValidarNombre(.Id, .Nombre)
                l_FuncionesGenerales.ValidarCampoNoNulo(.Descripcion, "No ha Ingresado Descripción: ")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarNombre(ByVal Id As String, ByVal Nombre As String) As Boolean Implements Il_Formulario.ValidarNombre
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(Nombre, "No ha Ingresado Nombre: ")
            Dim oeFormulario As New e_Formulario
            oeFormulario.Nombre = Nombre
            oeFormulario.Activo = True
            oeFormulario = odFormulario.Obtener(oeFormulario)
            If oeFormulario.Id <> "" Then
                If Id = "" OrElse oeFormulario.Id <> Id Then
                    Throw New Exception("Ya existe: " & Nombre)
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
