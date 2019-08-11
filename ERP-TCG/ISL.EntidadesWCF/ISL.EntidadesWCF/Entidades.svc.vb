' NOTA: si cambia aquí el nombre de clase "Entidades", también debe actualizar la referencia a "Entidades" tanto en Web.config como en el archivo .svc asociado.
Public Class Entidades
    Implements IEntidades

#Region "Declaración de variables"


#End Region

#Region "Métodos"

    ''' <summary>
    ''' Retorna una entidad de tipo Departamento
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Departamento() As e_Departamento Implements IEntidades.Departamento
        Return New e_Departamento
    End Function

    ''' <summary>
    ''' Retorna una lista de departamentos
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Departamentos() As System.Collections.Generic.List(Of e_Departamento) Implements IEntidades.Departamentos
        Return New List(Of e_Departamento)
    End Function

#End Region

End Class
