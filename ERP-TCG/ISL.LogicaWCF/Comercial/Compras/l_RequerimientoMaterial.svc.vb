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
Public Class l_RequerimientoMaterial
    Implements Il_RequerimientoMaterial

    Dim odRequerimientoMaterial As New d_RequerimientoMaterial

    Public Function Guardar(ByVal oeRequerimientoMaterial As e_RequerimientoMaterial) As Boolean Implements Il_RequerimientoMaterial.Guardar
        Try
            If Validar(oeRequerimientoMaterial) Then
                Return odRequerimientoMaterial.Guardar(oeRequerimientoMaterial)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeRequerimientoMaterial As e_RequerimientoMaterial) As System.Collections.Generic.List(Of e_RequerimientoMaterial) Implements Il_RequerimientoMaterial.Listar
        Try
            Return odRequerimientoMaterial.Listar(oeRequerimientoMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeRequerimientoMaterial As e_RequerimientoMaterial) As e_RequerimientoMaterial Implements Il_RequerimientoMaterial.Obtener
        Try
            Return odRequerimientoMaterial.Obtener(oeRequerimientoMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeRequerimientoMaterial As e_RequerimientoMaterial) As Boolean Implements Il_RequerimientoMaterial.Validar
        Try
            With oeRequerimientoMaterial
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
