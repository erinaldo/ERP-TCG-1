Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Actividad
    Implements Il_Actividad

    Dim odActividad As New d_Actividad
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeActividad As EntidadesWCF.e_Actividad) As Boolean Implements Il_Actividad.Eliminar
        Try
            Return odActividad.Eliminar(oeActividad)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeActividad As EntidadesWCF.e_Actividad) As Boolean Implements Il_Actividad.Guardar
        Try
            If Validar(oeActividad) Then
                Return odActividad.Guardar(oeActividad)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeActividad As EntidadesWCF.e_Actividad) As System.Collections.Generic.List(Of EntidadesWCF.e_Actividad) Implements Il_Actividad.Listar
        Try
            Return odActividad.Listar(oeActividad)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeActividad As EntidadesWCF.e_Actividad) As EntidadesWCF.e_Actividad Implements Il_Actividad.Obtener
        Try
            Return odActividad.Obtener(oeActividad)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeActividad As EntidadesWCF.e_Actividad) As Boolean Implements Il_Actividad.Validar
        Try
            With oeActividad
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar nombre")
                ValidarDuplicado(.Id, .Nombre)
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal IdActividad As String, ByVal Nombre As String) As Boolean Implements Il_Actividad.ValidarDuplicado
        Try
            Dim oeActividad As New e_Actividad
            oeActividad.Nombre = Nombre
            oeActividad.Activo = True
            oeActividad = odActividad.Obtener(oeActividad)
            If Not oeActividad Is Nothing Then
                If IdActividad = "" OrElse oeActividad.Id <> IdActividad Then
                    Throw New Exception("La actividad: " & Nombre & ", ya se encuentra registrada")
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
