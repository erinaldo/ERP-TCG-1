Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_SituacionAdministrativa
    Implements Il_SituacionAdministrativa

    Private odSituacionAdministrativa As New d_SituacionAdministrativa
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    ''' <summary>
    ''' Eliminar un SituacionAdministrativa especificado
    ''' </summary>
    ''' <param name="oeSituacionAdministrativa"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Eliminar(ByVal oeSituacionAdministrativa As EntidadesWCF.e_SituacionAdministrativa) As Boolean Implements Il_SituacionAdministrativa.Eliminar
        Try
            Return odSituacionAdministrativa.Eliminar(oeSituacionAdministrativa)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Guardar la información del SituacionAdministrativa
    ''' </summary>
    ''' <param name="oeSituacionAdministrativa"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Guardar(ByVal oeSituacionAdministrativa As EntidadesWCF.e_SituacionAdministrativa) As Boolean Implements Il_SituacionAdministrativa.Guardar
        Try
            If Validar(oeSituacionAdministrativa) Then
                Return odSituacionAdministrativa.Guardar(oeSituacionAdministrativa)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Método para obtener una lista de SituacionAdministrativas
    ''' </summary>
    ''' <param name="oeSituacionAdministrativa"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Listar(ByVal oeSituacionAdministrativa As EntidadesWCF.e_SituacionAdministrativa) As System.Collections.Generic.List(Of EntidadesWCF.e_SituacionAdministrativa) Implements Il_SituacionAdministrativa.Listar
        Try
            Return odSituacionAdministrativa.Listar(oeSituacionAdministrativa)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Método para obtener un SituacionAdministrativa específico
    ''' </summary>
    ''' <param name="oeSituacionAdministrativa"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal oeSituacionAdministrativa As EntidadesWCF.e_SituacionAdministrativa) As EntidadesWCF.e_SituacionAdministrativa Implements Il_SituacionAdministrativa.Obtener
        Try
            Return odSituacionAdministrativa.Obtener(oeSituacionAdministrativa)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Método que valida los datos correctos del SituacionAdministrativa
    ''' </summary>
    ''' <param name="oeSituacionAdministrativa"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Validar(ByVal oeSituacionAdministrativa As EntidadesWCF.e_SituacionAdministrativa) As Boolean Implements Il_SituacionAdministrativa.Validar
        Try
            With oeSituacionAdministrativa
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar el nombre del SituacionAdministrativa")
                ValidarDuplicado(.Id, .Codigo, "codigo")
                ValidarDuplicado(.Id, .Nombre, "nombre")
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Validar que no se dupliquen los SituacionAdministrativas
    ''' </summary>
    ''' <param name="id"></param>
    ''' <param name="valor"></param>
    ''' <param name="campo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean Implements Il_SituacionAdministrativa.ValidarDuplicado
        Dim oeSituacionAdministrativa As New e_SituacionAdministrativa
        Try
            If String.IsNullOrEmpty(valor) Then Throw New Exception("No se ha definido que información se va a verificar si existe")
            If String.IsNullOrEmpty(campo) Then Throw New Exception("No se ha especificado el campo que se va a validar")
            Select Case campo
                Case "codigo"
                    oeSituacionAdministrativa.Codigo = valor
                Case "nombre"
                    oeSituacionAdministrativa.Nombre = valor
            End Select
            oeSituacionAdministrativa = odSituacionAdministrativa.Obtener(oeSituacionAdministrativa)
            If Not oeSituacionAdministrativa.Id Is Nothing And oeSituacionAdministrativa.Id <> id Then Throw New Exception("Ya existe el(la) " & campo & " :" & valor)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
