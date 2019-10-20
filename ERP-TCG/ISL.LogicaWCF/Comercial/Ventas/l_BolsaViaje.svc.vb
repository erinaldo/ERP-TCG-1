Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_BolsaViaje
    Implements Il_BolsaViaje

    Dim odBolsaViaje As New d_BolsaViaje

    Public Function Eliminar(ByVal oeBolsaViaje As e_BolsaViaje) As Boolean Implements Il_BolsaViaje.Eliminar
        Try
            Return odBolsaViaje.Eliminar(oeBolsaViaje)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeBolsaViaje As e_BolsaViaje) As Boolean Implements Il_BolsaViaje.Guardar
        Try
            If Validar(oeBolsaViaje) Then
                Return odBolsaViaje.Guardar(oeBolsaViaje)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeBolsaViaje As e_BolsaViaje) As System.Collections.Generic.List(Of e_BolsaViaje) Implements Il_BolsaViaje.Listar
        Try
            Return odBolsaViaje.Listar(oeBolsaViaje)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeBolsaViaje As e_BolsaViaje) As e_BolsaViaje Implements Il_BolsaViaje.Obtener
        Try
            Return odBolsaViaje.Obtener(oeBolsaViaje)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeBolsaViaje As e_BolsaViaje) As Boolean Implements Il_BolsaViaje.Validar
        Try
            With oeBolsaViaje
                ValidarTipoVehiculo(oeBolsaViaje.TipoVehiculo)
                ValidarConceptoGasto(oeBolsaViaje.ConceptoGasto)
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarConceptoGasto(ByVal Id As String) As Boolean Implements Il_BolsaViaje.ValidarConceptoGasto
        Try
            Dim oeConceptoGasto As New e_ConceptoGasto
            Dim odConceptoGasto As New d_ConceptoGasto
            oeConceptoGasto.Id = Id
            oeConceptoGasto = odConceptoGasto.Obtener(oeConceptoGasto)
            If oeConceptoGasto.Id = "" Then
                Throw New Exception("Concepto Gasto seleccionado no existe")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarTipoVehiculo(ByVal Id As String) As Boolean Implements Il_BolsaViaje.ValidarTipoVehiculo
        Try
            Dim oeTipoVehiculo As New e_TipoVehiculo
            Dim odTipoVehiculo As New d_TipoVehiculo
            oeTipoVehiculo.Id = Id
            oeTipoVehiculo = odTipoVehiculo.Obtener(oeTipoVehiculo)
            If oeTipoVehiculo.Id = "" Then
                Throw New Exception("Tipo Vehiculo seleccionado no existe")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
