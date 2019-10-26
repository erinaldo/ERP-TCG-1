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

<DataContract(), Serializable()> _
Public Class l_MontoFlujoDiario
    Implements Il_MontoFlujoDiario
    Dim odMontoFlujoDiario As New d_MontoFlujoDiario
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeMontoFlujoDiario As e_MontoFlujoDiario) As Boolean Implements Il_MontoFlujoDiario.Eliminar
        Try
            Return odMontoFlujoDiario.Eliminar(oeMontoFlujoDiario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMontoFlujoDiario As e_MontoFlujoDiario) As Boolean Implements Il_MontoFlujoDiario.Guardar
        Try
            If Validar(oeMontoFlujoDiario) Then
                Return odMontoFlujoDiario.Guardar(oeMontoFlujoDiario)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMontoFlujoDiario As e_MontoFlujoDiario) As System.Collections.Generic.List(Of e_MontoFlujoDiario) Implements Il_MontoFlujoDiario.Listar
        Try
            Return odMontoFlujoDiario.Listar(oeMontoFlujoDiario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMontoFlujoDiario As e_MontoFlujoDiario) As e_MontoFlujoDiario Implements Il_MontoFlujoDiario.Obtener
        Try
            Return odMontoFlujoDiario.Obtener(oeMontoFlujoDiario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMontoFlujoDiario As e_MontoFlujoDiario) As Boolean Implements Il_MontoFlujoDiario.Validar
        Try
            With oeMontoFlujoDiario
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdRuta, "Ingrese Ruta")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdTipoVehiculo, "Ingrese Tipo Vehiculo")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdFlujoCaja, "Ingrese Flujo Caja")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
