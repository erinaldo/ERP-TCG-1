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
Public Class l_ProcesoFlujoCaja
    Implements Il_ProcesoFlujoCaja

    Dim odProcesoFlujoCaja As New d_ProcesoFlujoCaja

    Public Function Eliminar(ByVal oeProcesoFlujoCaja As e_ProcesoFlujoCaja) As Boolean Implements Il_ProcesoFlujoCaja.Eliminar
        Try
            Return odProcesoFlujoCaja.Eliminar(oeProcesoFlujoCaja)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeProcesoFlujoCaja As e_ProcesoFlujoCaja) As Boolean Implements Il_ProcesoFlujoCaja.Guardar
        Try
            If Validar(oeProcesoFlujoCaja) Then
                Return odProcesoFlujoCaja.Guardar(oeProcesoFlujoCaja)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeProcesoFlujoCaja As e_ProcesoFlujoCaja) As System.Collections.Generic.List(Of e_ProcesoFlujoCaja) Implements Il_ProcesoFlujoCaja.Listar
        Try
            Return odProcesoFlujoCaja.Listar(oeProcesoFlujoCaja)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeProcesoFlujoCaja As e_ProcesoFlujoCaja) As e_ProcesoFlujoCaja Implements Il_ProcesoFlujoCaja.Obtener
        Try
            Return odProcesoFlujoCaja.Obtener(oeProcesoFlujoCaja)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeProcesoFlujoCaja As e_ProcesoFlujoCaja) As Boolean Implements Il_ProcesoFlujoCaja.Validar
        Try
            With oeProcesoFlujoCaja
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
