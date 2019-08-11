Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_PlanillaPiloto" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_PlanillaPiloto.svc o l_PlanillaPiloto.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_PlanillaPiloto
    Implements Il_PlanillaPiloto

    Dim odPlanillaPiloto As New d_PlanillaPiloto

    Public Function Obtener(ByVal oePlanillaPiloto As e_PlanillaPiloto) As e_PlanillaPiloto Implements Il_PlanillaPiloto.Obtener
        Try
            Return odPlanillaPiloto.Obtener(oePlanillaPiloto)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oePlanillaPiloto As e_PlanillaPiloto) As List(Of e_PlanillaPiloto) Implements Il_PlanillaPiloto.Listar
        Try
            Return odPlanillaPiloto.Listar(oePlanillaPiloto)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oePlanillaPiloto As e_PlanillaPiloto) As Boolean Implements Il_PlanillaPiloto.Validar
        Try
            With oePlanillaPiloto
                If .TipoOperacion = "I" Then
                    Dim oePlaPil As New e_PlanillaPiloto
                    oePlaPil.TipoOperacion = "1"
                    oePlaPil.Id = .IdPlanilla
                    oePlaPil = odPlanillaPiloto.Obtener(oePlaPil)
                    If oePlaPil.Id <> "" Then
                        Throw New Exception("Ya Generó una Planilla de Pilotos con la Planilla Actual: " & oePlaPil.Planilla)
                    End If
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oePlanillaPiloto As e_PlanillaPiloto) As Boolean Implements Il_PlanillaPiloto.Guardar
        Try
            If Validar(oePlanillaPiloto) Then
                Return odPlanillaPiloto.Guardar(oePlanillaPiloto)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oePlanillaPiloto As e_PlanillaPiloto) As Boolean Implements Il_PlanillaPiloto.Eliminar
        Try
            Return odPlanillaPiloto.Eliminar(oePlanillaPiloto)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDS(ByVal oePlanillaPiloto As e_PlanillaPiloto) As System.Data.DataSet Implements Il_PlanillaPiloto.ListarDS
        Try
            Return odPlanillaPiloto.ListarDS(oePlanillaPiloto)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
