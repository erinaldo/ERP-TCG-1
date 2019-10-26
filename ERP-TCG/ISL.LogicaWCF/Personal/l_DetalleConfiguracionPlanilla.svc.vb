Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_DetalleConfiguracionPlanilla
    Implements Il_DetalleConfiguracionPlanilla

    Private odDetalleConfiguracionPlanilla As New d_DetalleConfiguracionPlanilla
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeDetalleConfiguracionPlanilla As e_DetalleConfiguracionPlanilla) As Boolean Implements Il_DetalleConfiguracionPlanilla.Eliminar
        Try
            Return odDetalleConfiguracionPlanilla.Eliminar(oeDetalleConfiguracionPlanilla)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeDetalleConfiguracionPlanilla As e_DetalleConfiguracionPlanilla) As Boolean Implements Il_DetalleConfiguracionPlanilla.Guardar
        Try
            If Validar(oeDetalleConfiguracionPlanilla) Then
                Return odDetalleConfiguracionPlanilla.Guardar(oeDetalleConfiguracionPlanilla)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeDetalleConfiguracionPlanilla As e_DetalleConfiguracionPlanilla) As List(Of e_DetalleConfiguracionPlanilla) Implements Il_DetalleConfiguracionPlanilla.Listar
        Try
            Return odDetalleConfiguracionPlanilla.Listar(oeDetalleConfiguracionPlanilla)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeDetalleConfiguracionPlanilla As e_DetalleConfiguracionPlanilla) As e_DetalleConfiguracionPlanilla Implements Il_DetalleConfiguracionPlanilla.Obtener
        Try
            Return odDetalleConfiguracionPlanilla.Obtener(oeDetalleConfiguracionPlanilla)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeDetalleConfiguracionPlanilla As e_DetalleConfiguracionPlanilla) As Boolean Implements Il_DetalleConfiguracionPlanilla.Validar
        Try
            With oeDetalleConfiguracionPlanilla
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "No ha Ingresado Codigo")
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "No ha Ingresado Nombre")
                'If .leHistorial.Where(Function(it) it.Vigencia = 1).Count = 0 Then Throw New Exception("No ha ingresado valor")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
