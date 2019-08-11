' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_ProcesarTarifasProceso" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_ProcesarTarifasProceso.svc o l_ProcesarTarifasProceso.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ProcesarTarifasProceso

    Implements Il_ProcesarTarifasProceso

    'Public Sub DoWork() Implements Il_ProcesarTarifasProceso.DoWork
    'End Sub

    Dim odProcesarTarifasProceso As New d_ProcesarTarifasProceso

    Public Function Eliminar(ByVal oeProcesarTarifasProceso As e_ProcesarTarifasProceso) As Boolean Implements Il_ProcesarTarifasProceso.Eliminar
        Try
            Return odProcesarTarifasProceso.Eliminar(oeProcesarTarifasProceso)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeProcesarTarifasProceso As e_ProcesarTarifasProceso) As Boolean Implements Il_ProcesarTarifasProceso.Guardar
        Try
            Return odProcesarTarifasProceso.Guardar(oeProcesarTarifasProceso)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeProcesarTarifasProceso As e_ProcesarTarifasProceso) As System.Collections.Generic.List(Of e_ProcesarTarifasProceso) Implements Il_ProcesarTarifasProceso.Listar
        Try
            Return odProcesarTarifasProceso.Listar(oeProcesarTarifasProceso)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeProcesarTarifasProceso As e_ProcesarTarifasProceso) As e_ProcesarTarifasProceso Implements Il_ProcesarTarifasProceso.Obtener
        Try
            Return odProcesarTarifasProceso.Obtener(oeProcesarTarifasProceso)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeProcesarTarifasProceso As e_ProcesarTarifasProceso) As Boolean Implements Il_ProcesarTarifasProceso.Validar
        Try
            oeProcesarTarifasProceso = odProcesarTarifasProceso.Obtener(oeProcesarTarifasProceso)
            If oeProcesarTarifasProceso.Id <> "" Then
                Throw New Exception("Verifique los datos ingresados")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
