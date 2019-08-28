﻿Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos
Imports System.Runtime.Serialization
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_DistanciaZona" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_DistanciaZona.svc o l_DistanciaZona.svc.vb en el Explorador de soluciones e inicie la depuración.
<DataContract(), Serializable()> _
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