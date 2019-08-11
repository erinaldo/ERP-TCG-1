Imports ISL.EntidadesWCF

Public Class d_AccidenteVehiculo

    Private sqlhelper As New SqlHelper

    Private oeAccidenteVehiculo As e_AccidenteVehiculo

    Private Function Cargar(ByVal o_fila As DataRow) As e_AccidenteVehiculo
        Try
            Dim oeAccidenteVehiculo = New e_AccidenteVehiculo( _
            o_fila("Id"), o_fila("idAccidente"), o_fila("Placa"), o_fila("PropiedadISL"), o_fila("Detalle"), o_fila("Observaciones"), o_fila("Activo"))
            Return oeAccidenteVehiculo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeAccidenteVehiculo As e_AccidenteVehiculo) As e_AccidenteVehiculo
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SPC.Isp_AccidenteVehiculo_Listar", "", oeAccidenteVehiculo.Id)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeAccidenteVehiculo = Cargar(ds.Tables(0).Rows(0))
            Else
                oeAccidenteVehiculo = New e_AccidenteVehiculo
            End If
            Return oeAccidenteVehiculo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeAccidenteVehiculo As e_AccidenteVehiculo) As List(Of e_AccidenteVehiculo)
        Try
            Dim ldAccidente As New List(Of e_AccidenteVehiculo)
            Dim ds As DataSet
            With oeAccidenteVehiculo
                ds = sqlhelper.ExecuteDataset("SPC.Isp_Accidente_Vehiculo_Listar", .TipoOperacion, .Id, .IdAccidente)
            End With
            oeAccidenteVehiculo = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeAccidenteVehiculo = Cargar(o_Fila)
                    ldAccidente.Add(oeAccidenteVehiculo)
                Next
                Return ldAccidente
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeAccidenteVehiculo As e_AccidenteVehiculo) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            With oeAccidenteVehiculo
                sqlhelper.ExecuteNonQuery("SPC.Isp_Accidente_Vehiculo_IAE", .TipoOperacion, _
                d_DatosConfiguracion.PrefijoID, .Id, .IdAccidente, .IdVehiculo, .PropiedadISL, .Detalle, .Observacion)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeAccidenteVehiculo As e_AccidenteVehiculo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SPC.Isp_AccidenteVehiculo_IAE", "E", oeAccidenteVehiculo.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EliminacionDefinitiva(ByVal oeAccidenteVehiculo As e_AccidenteVehiculo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SPC.Isp_AccidenteVehiculo_IAE", "X", oeAccidenteVehiculo.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class
