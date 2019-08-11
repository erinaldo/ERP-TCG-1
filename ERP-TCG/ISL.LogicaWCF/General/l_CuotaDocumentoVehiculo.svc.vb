Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_CuotaDocumentoVehiculo
    Implements Il_CuotaDocumentoVehiculo

    Dim odCuotaDocumentoVehiculo As New d_CuotaDocumentoVehiculo

    Public Function Listar(ByVal oeCuotaDocumentoVehiculo As e_CuotaDocumentoVehiculo) As List(Of e_CuotaDocumentoVehiculo) Implements Il_CuotaDocumentoVehiculo.Listar
        Try
            Return odCuotaDocumentoVehiculo.Listar(oeCuotaDocumentoVehiculo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDts(ByVal oeCuotaDocVeh As EntidadesWCF.e_CuotaDocumentoVehiculo) As System.Data.DataSet Implements Il_CuotaDocumentoVehiculo.ListarDts
        Try
            Dim dts As New DataSet
            dts = odCuotaDocumentoVehiculo.ListarDts(oeCuotaDocVeh)
            Return dts
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeCuotaDocumentoVehiculo As e_CuotaDocumentoVehiculo) As Boolean Implements Il_CuotaDocumentoVehiculo.Validar
        Try
            With oeCuotaDocumentoVehiculo
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCuotaDocumentoVehiculo As e_CuotaDocumentoVehiculo) As Boolean Implements Il_CuotaDocumentoVehiculo.Guardar
        Try
            If Validar(oeCuotaDocumentoVehiculo) Then
                Return odCuotaDocumentoVehiculo.Guardar(oeCuotaDocumentoVehiculo)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
