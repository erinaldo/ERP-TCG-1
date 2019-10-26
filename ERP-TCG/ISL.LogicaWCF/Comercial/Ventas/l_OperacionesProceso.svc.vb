' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_OperacionesProceso" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_OperacionesProceso.svc o l_OperacionesProceso.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_OperacionesProceso
    Implements Il_OperacionesProceso

    Dim odOperacionesProceso As New d_OperacionesProceso
    Dim odOperacionesProcesoDetalle As New d_OperacionesProcesoDetalle
    Dim odProcesarTarifasProceso As New d_ProcesarTarifasProceso

    Public Function Obtener(ByVal oeOperacionesProceso As e_OperacionesProceso) As e_OperacionesProceso Implements Il_OperacionesProceso.Obtener
        Try
            Return odOperacionesProceso.Obtener(oeOperacionesProceso)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOperacionesProceso As e_OperacionesProceso) As List(Of e_OperacionesProceso) Implements Il_OperacionesProceso.Listar
        Try
            Return odOperacionesProceso.Listar(oeOperacionesProceso)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeOperacionesProceso As e_OperacionesProceso) As Boolean Implements Il_OperacionesProceso.Validar
        Try
            With oeOperacionesProceso
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeOperacionesProceso As e_OperacionesProceso) As Boolean Implements Il_OperacionesProceso.Guardar
        Try
            If Validar(oeOperacionesProceso) Then
                Return odOperacionesProceso.Guardar(oeOperacionesProceso)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeOperacionesProceso As e_OperacionesProceso) As Boolean Implements Il_OperacionesProceso.Eliminar
        Try
            Return odOperacionesProceso.Eliminar(oeOperacionesProceso)
        Catch ex As Exception
            Throw
        End Try
    End Function

    'Clase OperacionProcesoDetalle
    Public Function ObtenerDetalle(ByVal oeOperacionesProcesoDetalle As e_OperacionesProcesoDetalle) As e_OperacionesProcesoDetalle Implements Il_OperacionesProceso.ObtenerDetalle
        Try
            Return odOperacionesProcesoDetalle.Obtener(oeOperacionesProcesoDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDetalle(ByVal oeOperacionesProcesoDetalle As e_OperacionesProcesoDetalle) As List(Of e_OperacionesProcesoDetalle) Implements Il_OperacionesProceso.ListarDetalle
        Try
            Return odOperacionesProcesoDetalle.Listar(oeOperacionesProcesoDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarDetalle(ByVal oeOperacionesProcesoDetalle As e_OperacionesProcesoDetalle) As Boolean Implements Il_OperacionesProceso.ValidarDetalle
        Try
            With oeOperacionesProcesoDetalle
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarDetalle(ByVal oeOperacionesProcesoDetalle As e_OperacionesProcesoDetalle) As Boolean Implements Il_OperacionesProceso.GuardarDetalle
        Try
            If ValidarDetalle(oeOperacionesProcesoDetalle) Then
                Return odOperacionesProcesoDetalle.Guardar(oeOperacionesProcesoDetalle)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function EliminarDetalle(ByVal oeOperacionesProcesoDetalle As e_OperacionesProcesoDetalle) As Boolean Implements Il_OperacionesProceso.EliminarDetalle
        Try
            Return odOperacionesProcesoDetalle.Eliminar(oeOperacionesProcesoDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
