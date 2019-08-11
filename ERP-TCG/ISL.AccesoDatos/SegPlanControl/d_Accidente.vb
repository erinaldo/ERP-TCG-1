Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Accidente

    Private sqlhelper As New SqlHelper
    'Private oeAccidente As e_Accidente

    Private Function Cargar(ByVal o_fila As DataRow) As e_Accidente
        Try
            Dim oeAccidente = New e_Accidente( _
            o_fila("Id"), o_fila("Fecha"), o_fila("Hora"), o_fila("idTipoAccidente"), o_fila("Lugar"),
            o_fila("Detalle"), o_fila("TipoAccidente"), o_fila("NombreLugar"), o_fila("Activo"))
            Return oeAccidente
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function Obtener(ByVal oeAccidente As e_Accidente) As e_Accidente
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SPC.Isp_Accidente_Listar", "", oeAccidente.Id)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeAccidente = Cargar(ds.Tables(0).Rows(0))
            Else
                oeAccidente = New e_Accidente
            End If
            Return oeAccidente
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeAccidente As e_Accidente) As List(Of e_Accidente)
        Try
            Dim ldAccidente As New List(Of e_Accidente)
            Dim ds As DataSet
            With oeAccidente
                ds = sqlhelper.ExecuteDataset("SPC.Isp_Accidente_Listar", "", .Id, .Fecha, _
                        .IdTipoAccidente, .Lugar, .Activo)
            End With
            oeAccidente = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeAccidente = Cargar(o_Fila)
                    ldAccidente.Add(oeAccidente)
                Next
                Return ldAccidente
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAccidente As e_Accidente) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim id As String = ""
            Dim odAccidenteMaterial As New d_AccidenteMaterial
            Dim odAccidenteVehiculo As New d_AccidenteVehiculo
            Dim odAccidenteCarga As New d_AccidenteCarga
            Dim odAccidenteTrabajador As New d_AccidentePersona
            Dim odAccidenteFoto As New d_AccidenteFoto
            Using transcope As New TransactionScope
                With oeAccidente
                    id = sqlhelper.ExecuteScalar("SPC.Isp_Accidente_IAE", .TipoOperacion, _
                    d_DatosConfiguracion.PrefijoID, .Id, .Fecha, .Hora, .IdTipoAccidente, .Lugar, .Detalle)
                    For Each acctra As e_AccidentePersona In .loTrabajadoresAccidentados
                        If acctra.TipoOperacion = "" Then acctra.TipoOperacion = .TipoOperacion
                        acctra.IdAccidente = id
                        odAccidenteTrabajador.Guardar(acctra)
                    Next
                    For Each accequ As e_AccidenteVehiculo In .loEquiposAccidentados
                        If accequ.TipoOperacion = "" Then accequ.TipoOperacion = .TipoOperacion
                        accequ.IdAccidente = id
                        odAccidenteVehiculo.Guardar(accequ)
                    Next
                    For Each accmat As e_AccidenteMaterial In .loMaterialesAccidentados
                        If accmat.TipoOperacion = "" Then accmat.TipoOperacion = .TipoOperacion
                        accmat.IdAccidente = id
                        odAccidenteMaterial.Guardar(accmat)
                    Next
                    For Each acccar As e_AccidenteCarga In .loCargaAccidentados
                        If acccar.TipoOperacion = "" Then acccar.TipoOperacion = .TipoOperacion
                        acccar.IdAccidente = id
                        odAccidenteCarga.Guardar(acccar)
                    Next
                    For Each accfot As e_AccidenteFoto In .loFotosAccidentados
                        If accfot.TipoOperacion = "" Then accfot.TipoOperacion = .TipoOperacion
                        accfot.IdAccidente = id
                        odAccidenteFoto.Guardar(accfot)
                    Next
                End With
                transcope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeAccidente As e_Accidente) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SPC.Isp_Accidente_IAE", "E", oeAccidente.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
