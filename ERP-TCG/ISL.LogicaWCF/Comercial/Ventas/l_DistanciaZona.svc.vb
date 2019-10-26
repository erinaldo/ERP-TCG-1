'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()>
Public Class l_DistanciaZona
    Implements Il_DistanciaZona

    Dim odDistanciaZona As New d_DistanciaZona

    'Public Sub DoWork() Implements Il_DistanciaZona.DoWork
    'End Sub
    Public Function Obtener(oeDistanciaZona As e_DistanciaZona) As e_DistanciaZona Implements Il_DistanciaZona.Obtener
        Try
            Return odDistanciaZona.Obtener(oeDistanciaZona)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeDistanciaZona As e_DistanciaZona) As List(Of e_DistanciaZona) Implements Il_DistanciaZona.Listar
        Try
            Return odDistanciaZona.Listar(oeDistanciaZona)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oeDistanciaZona As e_DistanciaZona) As Boolean Implements Il_DistanciaZona.Guardar
        Try
            Return odDistanciaZona.Guardar(oeDistanciaZona)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(oeDistanciaZona As e_DistanciaZona) As Boolean Implements Il_DistanciaZona.Eliminar
        Try
            Return odDistanciaZona.Eliminar(oeDistanciaZona)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
