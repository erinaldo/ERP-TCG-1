Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Cuota
    Implements Il_Cuota

    Dim odCuota As New d_Cuota
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Overloads Function Eliminar(ByVal oeCuota As EntidadesWCF.e_Cuota) As Boolean Implements Il_Cuota.Eliminar
        Try
            If Validar(oeCuota) Then
                odCuota.Eliminar(oeCuota)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Overloads Function Guardar(ByVal oeCuota As EntidadesWCF.e_Cuota) As Boolean Implements Il_Cuota.Guardar
        Try
            If Validar(oeCuota) Then
                Return odCuota.Guardar(oeCuota)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Listar Coutas
    ''' </summary>
    ''' <param name="oeCuota">Objeto Couta</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Listar(ByVal oeCuota As EntidadesWCF.e_Cuota) As System.Collections.Generic.List(Of EntidadesWCF.e_Cuota) Implements Il_Cuota.Listar
        Try
            Return odCuota.Listar(oeCuota)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Overloads Function Obtener(ByVal oeCuota As EntidadesWCF.e_Cuota) As EntidadesWCF.e_Cuota Implements Il_Cuota.Obtener
        Try
            Return odCuota.Obtener(oeCuota)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeCuota As EntidadesWCF.e_Cuota) As Boolean Implements Il_Cuota.Validar
        Try
            'l_FuncionesGenerales.ValidarCampoNoNulo(oeCuota.NombreCompleto, "Error Dato No Encontrado")
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Validar Codigo
    ''' </summary>
    ''' <param name="Codigo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ValidarCodigo(ByVal Codigo As String) As Boolean Implements Il_Cuota.ValidarCodigo
        Try
            If String.IsNullOrEmpty(Codigo) Then Throw New Exception("No se ha ingresado: Codigo")
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
    Public Function ValidarRutaImagen(ByVal RutaImagen As String) As Boolean Implements Il_Cuota.ValidarRutaImagen
        Try
            If String.IsNullOrEmpty(RutaImagen) Then Throw New Exception("No se ha Ingresado: RutaImagen")
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
