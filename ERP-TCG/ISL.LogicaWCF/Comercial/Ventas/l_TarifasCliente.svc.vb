' NOTA: si cambia aquí el nombre de clase "l_TarifasCliente", también debe actualizar la referencia a "l_TarifasCliente" tanto en Web.config como en el archivo .svc asociado.

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_TarifasCliente
    Implements Il_TarifasCliente

    'Public Sub DoWork() Implements Il_TarifasCliente.DoWork
    'End Sub

    Dim odTarifasCliente As New d_TarifasCliente

    Public Function Eliminar(ByVal oeTarifasCliente As e_TarifasCliente) As Boolean Implements Il_TarifasCliente.Eliminar
        Try
            Return odTarifasCliente.Eliminar(oeTarifasCliente)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeTarifasCliente As e_TarifasCliente) As Boolean Implements Il_TarifasCliente.Guardar
        Try
            Return odTarifasCliente.Guardar(oeTarifasCliente)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeTarifasCliente As e_TarifasCliente) As System.Collections.Generic.List(Of e_TarifasCliente) Implements Il_TarifasCliente.Listar
        Try
            Return odTarifasCliente.Listar(oeTarifasCliente)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarTarifas(ByVal oeTarifasCliente As e_TarifasCliente) As DataTable Implements Il_TarifasCliente.ListarTarifas
        Try
            Return odTarifasCliente.ListarTarifas(oeTarifasCliente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeTarifasCliente As e_TarifasCliente) As e_TarifasCliente Implements Il_TarifasCliente.Obtener
        Try
            Return odTarifasCliente.Obtener(oeTarifasCliente)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeTarifasCliente As e_TarifasCliente) As Boolean Implements Il_TarifasCliente.Validar
        Try
            oeTarifasCliente = odTarifasCliente.Obtener(oeTarifasCliente)
            If oeTarifasCliente.Id <> "" Then
                Throw New Exception("Verifique los datos ingresados (Cliente/Origen/Destino/TipoVehiculo/TipoCarga/Material) ya existe una tarifa")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
