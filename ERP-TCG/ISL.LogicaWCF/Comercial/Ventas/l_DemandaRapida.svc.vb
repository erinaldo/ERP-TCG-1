Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization
Imports System.Transactions

<DataContract(), Serializable()> _
Public Class l_DemandaRapida
    Implements Il_DemandaRapida

    Dim odDemandaRapida As New d_DemandaRapida
    Dim oeCombo As New e_Combo
    Dim odCombo As New d_Combo
    Dim olBitacora As New l_Bitacora
    Public Function Eliminar(ByVal oeDemandaRapida As e_DemandaRapida) As Boolean Implements Il_DemandaRapida.Eliminar
        Try
                odDemandaRapida.Eliminar(oeDemandaRapida)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Cancelar(ByVal oeDemandaRapida As e_DemandaRapida) As Boolean
        Try
            odDemandaRapida.Cancelar(oeDemandaRapida)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function CambioDeEstado(ByVal oeDemandaRapida As e_DemandaRapida) As Boolean
        Try
            Return odDemandaRapida.CambioDeEstado(oeDemandaRapida)
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function Guardar(ByVal oeDemandaRapida As e_DemandaRapida) As Boolean Implements Il_DemandaRapida.Guardar
        Try
            If Validar(oeDemandaRapida) Then
                Return odDemandaRapida.Guardar(oeDemandaRapida)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDemandaRapida As e_DemandaRapida) As System.Collections.Generic.List(Of e_DemandaRapida) Implements Il_DemandaRapida.Listar
        Try
            Return odDemandaRapida.Listar(oeDemandaRapida)
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function ListarDemandarapida(ByVal oeDemandaRapida As e_DemandaRapida) As System.Collections.Generic.List(Of e_DemandaRapida)
        Try
            Return odDemandaRapida.ListarDemandaRapida(oeDemandaRapida)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeDemandaRapida As e_DemandaRapida) As e_DemandaRapida Implements Il_DemandaRapida.Obtener
        Try
            Return odDemandaRapida.Obtener(oeDemandaRapida)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeDemandaRapida As e_DemandaRapida) As Boolean Implements Il_DemandaRapida.Validar
        Try
            With oeDemandaRapida
                ValidarRuta(oeDemandaRapida.IdRuta)
                ValidarCliente(oeDemandaRapida.IdCliente)
                ValidarComision(oeDemandaRapida.IdComisionista)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarCliente(ByVal Id As String) As Boolean Implements Il_DemandaRapida.ValidarCliente
        Try
            oeCombo.Id = Id
            oeCombo.Nombre = "Clientes"
            oeCombo = odCombo.Obtener(oeCombo)
            If oeCombo.Id = "" Then
                Throw New Exception("Cliente seleccionado no existe")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarComision(ByVal Id As String) As Boolean Implements Il_DemandaRapida.ValidarComision
        Try
            oeCombo.Id = Id
            oeCombo.Nombre = "Comisionistas"
            oeCombo = odCombo.Obtener(oeCombo)
            If oeCombo.Id = "" Then
                Throw New Exception("Comisionista seleccionado no existe")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarRuta(ByVal Id As String) As Boolean Implements Il_DemandaRapida.ValidarRuta
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
End Class
