'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Perfil
    Implements Il_Perfil
    Dim odPerfil As New d_Perfil
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oePerfil As EntidadesWCF.e_Perfil) As Boolean Implements Il_Perfil.Eliminar
        Try
            Return odPerfil.Eliminar(oePerfil)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oePerfil As EntidadesWCF.e_Perfil) As Boolean Implements Il_Perfil.Guardar
        Try
            If Validar(oePerfil) Then
                Return odPerfil.Guardar(oePerfil)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oePerfil As EntidadesWCF.e_Perfil) As System.Collections.Generic.List(Of EntidadesWCF.e_Perfil) Implements Il_Perfil.Listar
        Try
            Return odPerfil.Listar(oePerfil)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oePerfil As EntidadesWCF.e_Perfil) As EntidadesWCF.e_Perfil Implements Il_Perfil.Obtener
        Try
            Return odPerfil.Obtener(oePerfil)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oePerfil As EntidadesWCF.e_Perfil) As Boolean Implements Il_Perfil.Validar
        Try
            With oePerfil
                l_FuncionesGenerales.ValidarCampoNoNulo(oePerfil.Nombre, "No se ha Ingresado Codigo")
                l_FuncionesGenerales.ValidarCampoNoNulo(oePerfil.Nombre, "No se ha Ingresado Nombre")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
