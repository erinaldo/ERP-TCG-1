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
Public Class l_PlanillaVacaciones
    Implements Il_PlanillaVacaciones

    Private odPlanillaVacaciones As New d_PlanillaVacaciones
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oePlanillaVacaciones As EntidadesWCF.e_PlanillaVacaciones) As Boolean Implements Il_PlanillaVacaciones.Eliminar
        Try
            Return odPlanillaVacaciones.Eliminar(oePlanillaVacaciones)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oePlanillaVacaciones As EntidadesWCF.e_PlanillaVacaciones) As Boolean Implements Il_PlanillaVacaciones.Guardar
        Try
            If Validar(oePlanillaVacaciones) Then
                Return odPlanillaVacaciones.Guardar(oePlanillaVacaciones)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oePlanillaVacaciones As EntidadesWCF.e_PlanillaVacaciones) As List(Of EntidadesWCF.e_PlanillaVacaciones) Implements Il_PlanillaVacaciones.Listar
        Try
            Return odPlanillaVacaciones.Listar(oePlanillaVacaciones)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oePlanillaVacaciones As EntidadesWCF.e_PlanillaVacaciones) As EntidadesWCF.e_PlanillaVacaciones Implements Il_PlanillaVacaciones.Obtener
        Try
            Return odPlanillaVacaciones.Obtener(oePlanillaVacaciones)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oePlanillaVacaciones As EntidadesWCF.e_PlanillaVacaciones) As Boolean Implements Il_PlanillaVacaciones.Validar
        Try
            With oePlanillaVacaciones
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdPlanilla, "No ha Seleccionado Planilla Asociada")
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "No ha Ingresado Nombre")
                'If .leHistorial.Where(Function(it) it.Vigencia = 1).Count = 0 Then Throw New Exception("No ha ingresado valor")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
