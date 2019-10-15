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
Public Class l_BolsaRuta
    Implements Il_BolsaRuta

    Dim odBolsaRuta As New d_BolsaRuta
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeBolsaRuta As EntidadesWCF.e_BolsaRuta) As Boolean Implements Il_BolsaRuta.Eliminar
        Try
            Return odBolsaRuta.Eliminar(oeBolsaRuta)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeBolsaRuta As EntidadesWCF.e_BolsaRuta) As Boolean Implements Il_BolsaRuta.Guardar
        Try
            If Validar(oeBolsaRuta) Then
                Return odBolsaRuta.Guardar(oeBolsaRuta)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeBolsaRuta As EntidadesWCF.e_BolsaRuta) As System.Collections.Generic.List(Of EntidadesWCF.e_BolsaRuta) Implements Il_BolsaRuta.Listar
        Try
            Return odBolsaRuta.Listar(oeBolsaRuta)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeBolsaRuta As EntidadesWCF.e_BolsaRuta) As EntidadesWCF.e_BolsaRuta Implements Il_BolsaRuta.Obtener
        Try
            Return odBolsaRuta.Obtener(oeBolsaRuta)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeBolsaRuta As EntidadesWCF.e_BolsaRuta) As Boolean Implements Il_BolsaRuta.Validar
        Try
            With oeBolsaRuta
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdRuta, "Seleccione Ruta")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdTipoVehiculo, "Seleccione Tipo de Vehículo")
                l_FuncionesGenerales.ValidarCampoNoNulo(.MontoMinimo, "Ingrese Monto Minimo")
                l_FuncionesGenerales.ValidarCampoNoNulo(.MontoNormal, "Ingrese Monto Normal")
                l_FuncionesGenerales.ValidarCampoNoNulo(.MontoMaximo, "Ingrese Monto Maximo")
                ValidarDuplicado(.Id, .IdRuta, .IdTipoVehiculo)
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal ID As String, ByVal IDRUTA As String, ByVal IDTIPOVEHICULO As String) As Boolean Implements Il_BolsaRuta.ValidarDuplicado
        Try
            Dim oeBolsaRuta As New e_BolsaRuta
            oeBolsaRuta.IdRuta = IDRUTA
            oeBolsaRuta.IdTipoVehiculo = IDTIPOVEHICULO
            oeBolsaRuta = odBolsaRuta.Obtener(oeBolsaRuta)
            If oeBolsaRuta.Id <> "" Then
                If ID = "" OrElse oeBolsaRuta.Id <> ID Then
                    Throw New Exception("Ya se asignó monto a la ruta: " & oeBolsaRuta.Ruta)
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
