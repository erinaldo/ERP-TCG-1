Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_DetallePLanillaVacaciones
    Implements Il_DetallePlanillaVacaciones

    Private odDetallePlanillaVacaciones As New d_DetallePlanillaVacaciones
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeDetallePlanillaVacaciones As EntidadesWCF.e_DetallePlanillaVacaciones) As Boolean Implements Il_DetallePlanillaVacaciones.Eliminar
        Try
            Return odDetallePlanillaVacaciones.Eliminar(oeDetallePlanillaVacaciones)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeDetallePlanillaVacaciones As EntidadesWCF.e_DetallePlanillaVacaciones) As Boolean Implements Il_DetallePlanillaVacaciones.Guardar
        Try
            If Validar(oeDetallePlanillaVacaciones) Then
                Return odDetallePlanillaVacaciones.Guardar(oeDetallePlanillaVacaciones)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeDetallePlanillaVacaciones As EntidadesWCF.e_DetallePlanillaVacaciones) As List(Of EntidadesWCF.e_DetallePlanillaVacaciones) Implements Il_DetallePlanillaVacaciones.Listar
        Try
            Return odDetallePlanillaVacaciones.Listar(oeDetallePlanillaVacaciones)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeDetallePlanillaVacaciones As EntidadesWCF.e_DetallePlanillaVacaciones) As EntidadesWCF.e_DetallePlanillaVacaciones Implements Il_DetallePlanillaVacaciones.Obtener
        Try
            Return odDetallePlanillaVacaciones.Obtener(oeDetallePlanillaVacaciones)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeDetallePlanillaVacaciones As EntidadesWCF.e_DetallePlanillaVacaciones) As Boolean Implements Il_DetallePlanillaVacaciones.Validar
        Try
            With oeDetallePlanillaVacaciones
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
