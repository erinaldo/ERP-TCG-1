Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos
Imports System.Runtime.Serialization

''' <summary>
''' Clase de la capa lógica para validar datos del objeto Distrito
''' </summary>
''' <remarks></remarks>
<DataContract(), Serializable()> _
Public Class l_Distrito
    Implements Il_Distrito

    Private oeDistrito As New e_Distrito
    Private odDistrito As New d_Distrito
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    ''' <summary>
    ''' Eliminar un Distrito
    ''' </summary>
    ''' <param name="oeDistrito"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Eliminar(ByVal oeDistrito As e_Distrito) As Boolean Implements Il_Distrito.Eliminar
        Try
            Return odDistrito.Eliminar(oeDistrito)
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Guardar la información de un Distrito
    ''' </summary>
    ''' <param name="oeDistrito"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Guardar(ByVal oeDistrito As e_Distrito) As Boolean Implements Il_Distrito.Guardar
        Try
            If Validar(oeDistrito) Then
                Return odDistrito.Guardar(oeDistrito)
            End If
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Método para obtener una lista de Distritos
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Listar(ByVal oeDistrito As e_Distrito) As System.Collections.Generic.List(Of e_Distrito) Implements Il_Distrito.Listar
        Try
            Return odDistrito.Listar(oeDistrito)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Método para obtener un Distrito específico
    ''' </summary>
    ''' <param name="oeDistrito"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal oeDistrito As e_Distrito) As e_Distrito Implements Il_Distrito.Obtener
        Try
            Return odDistrito.Obtener(oeDistrito)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Método para validar los datos del objeto Distrito
    ''' </summary>
    ''' <param name="oeDistrito"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Validar(ByVal oeDistrito As e_Distrito) As Boolean Implements Il_Distrito.Validar
        Try
            With oeDistrito
                l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "Debe ingresar el código del Distrito")
                l_FuncionesGenerales.ValidarCampoNoNulo(.CodigoDepartamento, "Debe ingresar el código del departamento a que pertenece el Distrito")
                l_FuncionesGenerales.ValidarCampoNoNulo(.CodigoProvincia, "Debe ingresar el código de la provincia a que pertenece el Distrito")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar el nombre del Distrito")
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
