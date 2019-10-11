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

Public Class l_ProduccionPiloto
    Implements Il_ProduccionPiloto

    Private odProduccionPiloto As New d_ProduccionPiloto
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeProduccionPiloto As EntidadesWCF.e_ProduccionPiloto) As Boolean Implements Il_ProduccionPiloto.Eliminar
        Try
            Return odProduccionPiloto.Eliminar(oeProduccionPiloto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeProduccionPiloto As EntidadesWCF.e_ProduccionPiloto) As Boolean Implements Il_ProduccionPiloto.Guardar
        Try
            If Validar(oeProduccionPiloto) Then
                Return odProduccionPiloto.Guardar(oeProduccionPiloto)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeProduccionPiloto As EntidadesWCF.e_ProduccionPiloto) As List(Of EntidadesWCF.e_ProduccionPiloto) Implements Il_ProduccionPiloto.Listar
        Try
            Return odProduccionPiloto.Listar(oeProduccionPiloto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeProduccionPiloto As EntidadesWCF.e_ProduccionPiloto) As EntidadesWCF.e_ProduccionPiloto Implements Il_ProduccionPiloto.Obtener
        Try
            Return odProduccionPiloto.Obtener(oeProduccionPiloto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeProduccionPiloto As EntidadesWCF.e_ProduccionPiloto) As Boolean Implements Il_ProduccionPiloto.Validar
        Try
            With oeProduccionPiloto
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdPlanilla, "Seleccionar Planilla")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdConceptoPonderado, "Seleccionar Ponderado")
                If .leDetalle.Count = 0 Then Throw New Exception("Debe Cargar Datos")
                If .IdEstado = "1CH00009" And .leBonoProd.Count = 0 Then Throw New Exception("Debe Consolidar Datos")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
