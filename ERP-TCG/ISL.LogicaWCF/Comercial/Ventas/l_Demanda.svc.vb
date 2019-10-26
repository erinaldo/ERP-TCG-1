Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization
Imports System.Transactions

<DataContract(), Serializable()> _
Public Class l_Demanda
    Implements Il_Demanda

    Dim odDemanda As New d_Demanda
    Dim oeCombo As New e_Combo
    Dim odCombo As New d_Combo
    Dim olBitacora As New l_Bitacora

    Public Function Eliminar(ByVal oeDemanda As e_Demanda) As Boolean Implements Il_Demanda.Eliminar
        Try
            Return odDemanda.Eliminar(oeDemanda)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Cancelar(ByVal oeDemanda As e_Demanda) As Boolean Implements Il_Demanda.Cancelar
        Try
            Return odDemanda.Cancelar(oeDemanda)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeDemanda As e_Demanda) As Boolean Implements Il_Demanda.Guardar
        Try
            If Validar(oeDemanda) Then
                Return odDemanda.Guardar(oeDemanda)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Tania
    Public Function GuardarDemandaPredemanda(ByVal oeDemanda As e_Demanda) As Boolean
        Try
            If Validar(oeDemanda) Then
                odDemanda.GuardarDemandaPredemanda(oeDemanda)
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GuardarObservacion(ByVal oeDemanda As e_Demanda) As Boolean
        Try
            Return odDemanda.GuardarObservacion(oeDemanda)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ConfirmarDemanda(ByVal oeDemanda As e_Demanda) As Boolean
        Try
            Return odDemanda.ConfirmarDemanda(oeDemanda)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeDemanda As e_Demanda) As System.Collections.Generic.List(Of e_Demanda) Implements Il_Demanda.Listar
        Try
            Return odDemanda.Listar(oeDemanda)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDataSet(ByVal oeDemanda As e_Demanda) As System.Data.DataSet Implements Il_Demanda.ListarDataSet
        Return odDemanda.ListarDataSet(oeDemanda)
    End Function

    Public Function ListarDemandaRapidaDataSet(ByVal oeDemanda As e_Demanda) As System.Data.DataSet
        Return odDemanda.ListarDemandaRapidaDataSet(oeDemanda)
    End Function

    Public Function ListarDetalle(ByVal oeDemandaDetalle As e_DemandaDetalle, Optional ByVal Usuario As String = "") As System.Collections.Generic.List(Of e_DemandaDetalle)
        Try
            Return odDemanda.ListarDetalle(oeDemandaDetalle, Usuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ListarDetalle(ByVal oeDemandaDetalle As e_DemandaDetalle) As System.Collections.Generic.List(Of e_DemandaDetalle) Implements Il_Demanda.ListarDetalle
        Try
            Return odDemanda.ListarDetalle(oeDemandaDetalle)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDemanda As e_Demanda) As e_Demanda Implements Il_Demanda.Obtener
        Try
            Return odDemanda.Obtener(oeDemanda)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerDetalle(ByVal oeDemandaDetalle As e_DemandaDetalle) As e_DemandaDetalle Implements Il_Demanda.ObtenerDetalle
        Try
            Return odDemanda.ObtenerDetalle(oeDemandaDetalle)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeDemanda As e_Demanda) As Boolean Implements Il_Demanda.Validar
        Try
            With oeDemanda
                If .TipoOperacion <> "C" Then
                    ValidarRuta(oeDemanda.IdRuta)
                    ValidarTipoVehiculo(oeDemanda.IdTipoVehiculo)
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarCarga(ByVal Id As String) As Boolean Implements Il_Demanda.ValidarCarga
        Try
            Dim oeTipoCarga As New e_TipoCarga
            Dim odTipoCarga As New d_TipoCarga
            oeTipoCarga.Id = Id
            oeTipoCarga = odTipoCarga.Obtener(oeTipoCarga)
            If String.IsNullOrEmpty(oeTipoCarga.Id) Then Throw New Exception("Tipo Carga seleccionado no existe")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarCliente(ByVal Id As String) As Boolean Implements Il_Demanda.ValidarCliente
        Try
            oeCombo.Id = Id
            oeCombo.Nombre = "Clientes"
            oeCombo = odCombo.Obtener(oeCombo)
            If String.IsNullOrEmpty(oeCombo.Id) Then Throw New Exception("El Cliente seleccionado no existe")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarComisionista(ByVal Id As String) As Boolean Implements Il_Demanda.ValidarComisionista
        Try
            oeCombo.Id = Id
            oeCombo.Nombre = "Comisionistas"
            oeCombo = odCombo.Obtener(oeCombo)
            If String.IsNullOrEmpty(oeCombo.Id) Then Throw New Exception("El Comisionista seleccionado no existe")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarDemandaCodigo(ByVal Codigo As String) As Boolean Implements Il_Demanda.ValidarDemandaCodigo
        Try
            Dim oeDemanda As New e_Demanda
            oeDemanda.TipoOperacion = "2"
            oeDemanda.Codigo = Codigo
            oeDemanda = odDemanda.Obtener(oeDemanda)
            If String.IsNullOrEmpty(oeDemanda.Id) Then Throw New Exception("Id de la Demanda no se encuentra registrado")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarDetalle(ByVal oeDemandaDetalle As e_DemandaDetalle) As Boolean Implements Il_Demanda.ValidarDetalle
        Try
            With oeDemandaDetalle
                ValidarCliente(oeDemandaDetalle.Cliente)
                ValidarComisionista(oeDemandaDetalle.Comisionista)
                ValidarCarga(oeDemandaDetalle.IdTipoCarga)
                ValidarMaterial(oeDemandaDetalle.Material)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarMaterial(ByVal Id As String) As Boolean Implements Il_Demanda.ValidarMaterial
        Try
            oeCombo.Id = Id
            oeCombo.Nombre = "Materiales"
            oeCombo = odCombo.Obtener(oeCombo)
            If oeCombo.Id = "" Then
                Throw New Exception("Material seleccionado no existe")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarRuta(ByVal Id As String) As Boolean Implements Il_Demanda.ValidarRuta
        Try
            oeCombo.Id = Id
            oeCombo.Nombre = "Rutas"
            oeCombo = odCombo.Obtener(oeCombo)
            If oeCombo.Id = "" Then
                Throw New Exception("Ruta seleccionado no existe")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarTipoVehiculo(ByVal Id As String) As Boolean Implements Il_Demanda.ValidarTipoVehiculo
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

    Public Function RevertirDemanda(ByVal oeDemanda As e_Demanda) As Boolean
        Try
            Return odDemanda.RevertirDemanda(oeDemanda)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GuardarDemandasEnviadas(ByVal oeDemanda As e_Demanda) As Boolean
        Try
            Return odDemanda.GuardarDemandasEnviadas(oeDemanda)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
