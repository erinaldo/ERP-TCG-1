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
Public Class l_ProcesoGlosa
    Implements Il_ProcesoGlosa

    Dim odProcesoGlosa As New d_ProcesoGlosa

    Public Function Eliminar(ByVal oeProcesoGlosa As EntidadesWCF.e_ProcesoGlosa) As Boolean Implements Il_ProcesoGlosa.Eliminar
        Try
            Return odProcesoGlosa.Eliminar(oeProcesoGlosa)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal loProcesoGlosa As System.Collections.Generic.List(Of EntidadesWCF.e_ProcesoGlosa)) As Boolean Implements Il_ProcesoGlosa.Guardar
        Try
            Return odProcesoGlosa.Guardar(loProcesoGlosa)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeProcesoGlosa As EntidadesWCF.e_ProcesoGlosa) As System.Collections.Generic.List(Of EntidadesWCF.e_ProcesoGlosa) Implements Il_ProcesoGlosa.Listar
        Try
            Return odProcesoGlosa.Listar(oeProcesoGlosa)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeProcesoGlosa As EntidadesWCF.e_ProcesoGlosa) As EntidadesWCF.e_ProcesoGlosa Implements Il_ProcesoGlosa.Obtener
        Try
            Return odProcesoGlosa.Obtener(oeProcesoGlosa)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeProcesoGlosa As EntidadesWCF.e_ProcesoGlosa) As Boolean Implements Il_ProcesoGlosa.Validar
        Try
            With oeProcesoGlosa
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
