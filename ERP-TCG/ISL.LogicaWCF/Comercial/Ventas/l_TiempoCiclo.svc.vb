Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_TiempoCiclo
    Implements Il_TiempoCiclo

    Dim odTiempoCiclo As New d_TiempoCiclo

    Public Function Eliminar(ByVal oeTiempoCiclo As EntidadesWCF.e_TiempoCiclo) As Boolean Implements Il_TiempoCiclo.Eliminar
        Try
            Return odTiempoCiclo.Eliminar(oeTiempoCiclo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeTiempoCiclo As EntidadesWCF.e_TiempoCiclo) As Boolean Implements Il_TiempoCiclo.Guardar
        Try
            If Validar(oeTiempoCiclo) Then
                Return odTiempoCiclo.Guardar(oeTiempoCiclo)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeTiempoCiclo As EntidadesWCF.e_TiempoCiclo) As System.Collections.Generic.List(Of EntidadesWCF.e_TiempoCiclo) Implements Il_TiempoCiclo.Listar
        Try
            Return odTiempoCiclo.Listar(oeTiempoCiclo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTiempoCiclo As EntidadesWCF.e_TiempoCiclo) As EntidadesWCF.e_TiempoCiclo Implements Il_TiempoCiclo.Obtener
        Try
            Return odTiempoCiclo.Obtener(oeTiempoCiclo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeTiempoCiclo As EntidadesWCF.e_TiempoCiclo) As Boolean Implements Il_TiempoCiclo.Validar
        Try
            With oeTiempoCiclo
                ValidarTipoVehiculo(oeTiempoCiclo.TipoVehiculo)
                ValidarCliente(oeTiempoCiclo.Cliente)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarCliente(ByVal Id As String) As Boolean Implements Il_TiempoCiclo.ValidarCliente
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

    Public Function ValidarTipoVehiculo(ByVal Id As String) As Boolean Implements Il_TiempoCiclo.ValidarTipoVehiculo
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
