'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Bitacora
    Implements Il_Bitacora

    Dim odBitacora As New d_Bitacora
    Public Function Guardar(ByVal l_Bitacora As List(Of e_Bitacora), ByVal PrefijoID As String) As Boolean Implements Il_Bitacora.Guardar
        Try
            If l_Bitacora.Count > 0 Then
                Return odBitacora.Guardar(l_Bitacora, PrefijoID)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
    'VerificarExistenciaDeDetalles
    Public Function VerificarExistenciaDeDetalles(ByVal l_Bitacora As List(Of e_Bitacora)) As Boolean
        Try
            Return odBitacora.VerificarExistenciaDeDetalles(l_Bitacora)
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
