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

''' <summary>
''' Clase de la lógica de negocios para Banco
''' </summary>
''' <remarks></remarks>
<DataContract(), Serializable()> _
Public Class l_Banco
    Implements Il_Banco

    Dim odBanco As New d_Banco
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    ''' <summary>
    ''' Lógica para eliminar un banco
    ''' </summary>
    ''' <param name="oeBanco"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Eliminar(ByVal oeBanco As e_Banco) As Boolean Implements Il_Banco.Eliminar
        Try
            Return odBanco.Eliminar(oeBanco)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Lógica necesaria para guardar información de un banco
    ''' </summary>
    ''' <param name="oeBanco"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Guardar(ByVal oeBanco As e_Banco) As Boolean Implements Il_Banco.Guardar
        Try
            If Validar(oeBanco) Then
                Return odBanco.Guardar(oeBanco)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Lógica necesaria para listar un banco
    ''' </summary>
    ''' <param name="oeBanco"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Listar(ByVal oeBanco As e_Banco) As System.Collections.Generic.List(Of e_Banco) Implements Il_Banco.Listar
        Try
            Return odBanco.Listar(oeBanco)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Lógica para obtener un banco específico a partir de algunos datos básicos
    ''' </summary>
    ''' <param name="oeBanco"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal oeBanco As e_Banco) As e_Banco Implements Il_Banco.Obtener
        Try
            Return odBanco.Obtener(oeBanco)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Lógica necesaria para validar un banco
    ''' </summary>
    ''' <param name="oeBanco"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Validar(ByVal oeBanco As e_Banco) As Boolean Implements Il_Banco.Validar
        Try
            With oeBanco
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar el nombre del Banco")
                ValidarDuplicado(.Id, .Nombre, "nombre")
                ValidarDuplicado(.Id, .Codigo, "codigo")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Validar que no se dupliquen los bancos
    ''' </summary>
    ''' <param name="id"></param>
    ''' <param name="valor"></param>
    ''' <param name="campo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean Implements Il_Banco.ValidarDuplicado
        Dim oeBanco As New e_Banco
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(valor, "No se ha definido que información se va a verificar si existe")
            l_FuncionesGenerales.ValidarCampoNoNulo(campo, "No se ha especificado el campo que se va a validar")
            Select Case campo
                Case "codigo"
                    oeBanco.Codigo = valor
                Case "nombre"
                    oeBanco.Nombre = valor
            End Select
            oeBanco = odBanco.Obtener(oeBanco)
            If Not String.IsNullOrEmpty(oeBanco.Id) And oeBanco.Id <> id Then Throw New Exception("Ya existe el(la) " & campo & " :" & valor)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
