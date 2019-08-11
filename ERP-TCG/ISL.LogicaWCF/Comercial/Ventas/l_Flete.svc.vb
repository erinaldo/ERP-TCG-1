Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Flete
    Implements Il_Flete

    Dim odFlete As New d_Flete

    Public Function Obtener(ByVal oeFlete As EntidadesWCF.e_Flete) As EntidadesWCF.e_Flete Implements Il_Flete.Obtener
        Try
            Return odFlete.Obtener(oeFlete)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeFlete As EntidadesWCF.e_Flete) As System.Collections.Generic.List(Of EntidadesWCF.e_Flete) Implements Il_Flete.Listar
        Try
            Return odFlete.Listar(oeFlete)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeFlete As EntidadesWCF.e_Flete) As Boolean Implements Il_Flete.Guardar
        Try
            If Validar(oeFlete) Then
                Return odFlete.Guardar(oeFlete)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeFlete As EntidadesWCF.e_Flete) As Boolean Implements Il_Flete.Eliminar
        Try
            Return odFlete.Eliminar(oeFlete)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeFlete As EntidadesWCF.e_Flete) As Boolean Implements Il_Flete.Validar
        Try
            With oeFlete
                ValidarTipoVehiculo(oeFlete.TipoVehiculo)
                ValidarCliente(oeFlete.Cliente)
                ValidarCarga(oeFlete.TipoCarga)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarCarga(ByVal Id As String) As Boolean Implements Il_Flete.ValidarCarga
        Try
            Dim oeTipoCarga As New e_TipoCarga
            Dim odTipoCarga As New d_TipoCarga
            oeTipoCarga.Id = Id
            oeTipoCarga = odTipoCarga.Obtener(oeTipoCarga)
            If oeTipoCarga.Id = "" Then
                Throw New Exception("Tipo Carga seleccionado no existe")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarCliente(ByVal Id As String) As Boolean Implements Il_Flete.ValidarCliente
        Try
            Dim oeCliente As New e_Cliente
            Dim odCliente As New d_Cliente
            oeCliente.Id = Id
            oeCliente = odCliente.Obtener(oeCliente)
            If oeCliente.Id = "" Then
                Throw New Exception("Cliente seleccionado no existe")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarTipoVehiculo(ByVal Id As String) As Boolean Implements Il_Flete.ValidarTipoVehiculo
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

    Public Function ListarTarifas(ByVal oeFlete As e_Flete) As DataTable Implements Il_Flete.ListarTarifas
        Try
            Return odFlete.ListarTarifas(oeFlete)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
