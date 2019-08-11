Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

''' <summary>
''' Clase de la capa lógica para validar datos del objeto departamento
''' </summary>
''' <remarks></remarks>
Public Class l_Departamento
    Implements Il_Departamento

    Private oeDepartamento As New e_Departamento
    Private odDepartamento As New d_Departamento
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    ''' <summary>
    ''' Eliminar un departamento
    ''' </summary>
    ''' <param name="oeDepartamento"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Eliminar(ByVal oeDepartamento As EntidadesWCF.e_Departamento) As Boolean Implements Il_Departamento.Eliminar
        Try
            Return odDepartamento.Eliminar(oeDepartamento)
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Guardar la información de un departamento
    ''' </summary>
    ''' <param name="oeDepartamento"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Guardar(ByVal oeDepartamento As EntidadesWCF.e_Departamento) As Boolean Implements Il_Departamento.Guardar
        Try
            If Validar(oeDepartamento) Then
                Return odDepartamento.Guardar(oeDepartamento)
            End If
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Método para obtener una lista de departamentos
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Listar(ByVal oeDepartamento As EntidadesWCF.e_Departamento) As System.Collections.Generic.List(Of EntidadesWCF.e_Departamento) Implements Il_Departamento.Listar
        Try
            Return odDepartamento.Listar(oeDepartamento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Método para obtener un departamento específico
    ''' </summary>
    ''' <param name="oeDepartamento"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal oeDepartamento As EntidadesWCF.e_Departamento) As e_Departamento Implements Il_Departamento.Obtener
        Try
            Return odDepartamento.Obtener(oeDepartamento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Método para validar los datos del objeto departamento
    ''' </summary>
    ''' <param name="oeDepartamento"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Validar(ByVal oeDepartamento As EntidadesWCF.e_Departamento) As Boolean Implements Il_Departamento.Validar
        Try
            With oeDepartamento
                l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "Debe ingresar el código del deparmento")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar el nombre del departamento")
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class
