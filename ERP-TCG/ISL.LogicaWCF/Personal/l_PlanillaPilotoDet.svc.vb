Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_PlanillaPilotoDet" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_PlanillaPilotoDet.svc o l_PlanillaPilotoDet.svc.vb en el Explorador de soluciones e inicie la depuración.

Public Class l_PlanillaPilotoDet
    Implements Il_PlanillaPilotoDet

    Dim odPlanillaPilotoDet As New d_PlanillaPilotoDet

    Public Function Obtener(ByVal oePlanillaPilotoDet As e_PlanillaPilotoDet) As e_PlanillaPilotoDet Implements Il_PlanillaPilotoDet.Obtener
        Try
            Return odPlanillaPilotoDet.Obtener(oePlanillaPilotoDet)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oePlanillaPilotoDet As e_PlanillaPilotoDet) As List(Of e_PlanillaPilotoDet) Implements Il_PlanillaPilotoDet.Listar
        Try
            Return odPlanillaPilotoDet.Listar(oePlanillaPilotoDet)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oePlanillaPilotoDet As e_PlanillaPilotoDet) As Boolean Implements Il_PlanillaPilotoDet.Validar
        Try
            With oePlanillaPilotoDet
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oePlanillaPilotoDet As e_PlanillaPilotoDet) As Boolean Implements Il_PlanillaPilotoDet.Guardar
        Try
            If Validar(oePlanillaPilotoDet) Then
                Return odPlanillaPilotoDet.Guardar(oePlanillaPilotoDet)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
