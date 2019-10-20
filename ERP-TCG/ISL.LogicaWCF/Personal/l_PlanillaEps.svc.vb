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

Public Class l_PlanillaEps
    Implements Il_PlanillaEps

    Private odPlanillaEps As New d_PlanillaEps
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oePlanillaEps As e_PlanillaEps) As Boolean Implements Il_PlanillaEps.Eliminar
        Try
            Return odPlanillaEps.Eliminar(oePlanillaEps)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oePlanillaEps As e_PlanillaEps) As Boolean Implements Il_PlanillaEps.Guardar
        Try
            If Validar(oePlanillaEps) Then
                Return odPlanillaEps.Guardar(oePlanillaEps)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oePlanillaEps As e_PlanillaEps) As List(Of e_PlanillaEps) Implements Il_PlanillaEps.Listar
        Try
            Return odPlanillaEps.Listar(oePlanillaEps)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oePlanillaEps As e_PlanillaEps) As e_PlanillaEps Implements Il_PlanillaEps.Obtener
        Try
            Return odPlanillaEps.Obtener(oePlanillaEps)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oePlanillaEps As e_PlanillaEps) As Boolean Implements Il_PlanillaEps.Validar
        Try
            With oePlanillaEps
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "No ha Ingresado Codigo")
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "No ha Ingresado Nombre")
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Abreviatura, "No ha Ingresado Abreviatura")
                'If .leHistorial.Where(Function(it) it.Vigencia = 1).Count = 0 Then Throw New Exception("No ha ingresado valor")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarLista(lePlanillaEps As List(Of e_PlanillaEps)) As Boolean Implements Il_PlanillaEps.GuardarLista
        Try
            Return odPlanillaEps.GuardarLista(lePlanillaEps)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EliminarLista(lePlanillaEps As List(Of e_PlanillaEps)) As Boolean Implements Il_PlanillaEps.EliminarLista
        Try
            Return odPlanillaEps.EliminarLista(lePlanillaEps)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
