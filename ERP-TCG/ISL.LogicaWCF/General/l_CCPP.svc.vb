Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

''' <summary>
''' Clase de la capa lógica para validar datos del objeto CCPP
''' </summary>
''' <remarks></remarks>
<DataContract(), Serializable()> _
Public Class l_CCPP
    Implements Il_CCPP

    Private oeCCPP As New e_CCPP
    Private odCCPP As New d_CCPP
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    ''' <summary>
    ''' Eliminar un CCPP
    ''' </summary>
    ''' <param name="oeCCPP"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Eliminar(ByVal oeCCPP As EntidadesWCF.e_CCPP) As Boolean Implements Il_CCPP.Eliminar
        Try
            Return odCCPP.Eliminar(oeCCPP)
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Guardar la información de un CCPP
    ''' </summary>
    ''' <param name="oeCCPP"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Guardar(ByVal oeCCPP As EntidadesWCF.e_CCPP) As Boolean Implements Il_CCPP.Guardar
        Try
            If Validar(oeCCPP) Then
                Return odCCPP.Guardar(oeCCPP)
            End If
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Método para obtener una lista de CCPPs
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Listar(ByVal oeCCPP As EntidadesWCF.e_CCPP) As System.Collections.Generic.List(Of EntidadesWCF.e_CCPP) Implements Il_CCPP.Listar
        Try
            Return odCCPP.Listar(oeCCPP)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Método para obtener un CCPP específico
    ''' </summary>
    ''' <param name="oeCCPP"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal oeCCPP As EntidadesWCF.e_CCPP) As EntidadesWCF.e_CCPP Implements Il_CCPP.Obtener
        Try
            Return odCCPP.Obtener(oeCCPP)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Método para validar los datos del objeto CCPP
    ''' </summary>
    ''' <param name="oeCCPP"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Validar(ByVal oeCCPP As EntidadesWCF.e_CCPP) As Boolean Implements Il_CCPP.Validar
        Try
            With oeCCPP
                l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "Debe ingresar el código del CCPP")
                l_FuncionesGenerales.ValidarCampoNoNulo(.CodigoDepartamento, "Debe ingresar el código del departamento a que pertenece el CCPP")
                l_FuncionesGenerales.ValidarCampoNoNulo(.CodigoProvincia, "Debe ingresar el código de la provincia a que pertenece el CCPP")
                l_FuncionesGenerales.ValidarCampoNoNulo(.CodigoDistrito, "Debe ingresar el código del distrito a que pertenece el CCPP")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar el nombre del CCPP")
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
