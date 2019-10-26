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
Public Class l_Gerencia
    Implements Il_Gerencia

    Dim odGerencia As New d_Gerencia
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeGerencia As e_Gerencia) As Boolean Implements Il_Gerencia.Eliminar
        Try
            Return odGerencia.Eliminar(oeGerencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGerencia As e_Gerencia) As Boolean Implements Il_Gerencia.Guardar
        Try
            If Validar(oeGerencia) Then
                Return odGerencia.Guardar(oeGerencia)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGerencia As e_Gerencia) As System.Collections.Generic.List(Of e_Gerencia) Implements Il_Gerencia.Listar
        Try
            Return odGerencia.Listar(oeGerencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeGerencia As e_Gerencia) As e_Gerencia Implements Il_Gerencia.Obtener
        Try
            Return odGerencia.Obtener(oeGerencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeGerencia As e_Gerencia) As Boolean Implements Il_Gerencia.Validar
        Try
            With oeGerencia
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "No ha Ingresado Nombre")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class



