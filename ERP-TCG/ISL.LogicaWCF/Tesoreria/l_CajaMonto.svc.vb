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
Public Class l_CajaMonto
    Implements Il_CajaMonto

    Dim odCajaMonto As New d_CajaMonto
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeCajaMonto As e_CajaMonto) As Boolean Implements Il_CajaMonto.Eliminar
        Try
            Return odCajaMonto.Eliminar(oeCajaMonto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCajaMonto As e_CajaMonto) As Boolean Implements Il_CajaMonto.Guardar
        Try
            If Validar(oeCajaMonto) Then
                Return odCajaMonto.Guardar(oeCajaMonto)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCajaMonto As e_CajaMonto) As System.Collections.Generic.List(Of e_CajaMonto) Implements Il_CajaMonto.Listar
        Try
            Return odCajaMonto.Listar(oeCajaMonto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeCajaMonto As e_CajaMonto) As e_CajaMonto Implements Il_CajaMonto.Obtener
        Try
            Return odCajaMonto.Obtener(oeCajaMonto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeCajaMonto As e_CajaMonto) As Boolean Implements Il_CajaMonto.Validar
        Try
            With oeCajaMonto
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdCaja, "Seleccione caja")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdCuentaBancaria, "seleccione cuenta bancaria")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Fecha, "Ingrese fecha")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
