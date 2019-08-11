Imports ISL.EntidadesWCF
Imports System.Transactions

Public Class d_HistorialInventario
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_HistorialInventario
        Try
            Dim oeHistorialInventario = New e_HistorialInventario( _
                             o_fila("Id").ToString _
                             , o_fila("IdHistorial").ToString _
                             , o_fila("IdMaterial").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Material").ToString _
                             , o_fila("IdUnidadMedida").ToString _
                             , o_fila("UnidadMedida").ToString _
                             , o_fila("CantidadFinal").ToString _
                             , o_fila("ValorUnitario").ToString _
                             , o_fila("ValorTotal").ToString _
                             , o_fila("Fecha").ToString _
            )
            Return oeHistorialInventario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeHistorialInventario As e_HistorialInventario) As e_HistorialInventario

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("ALM.Isp_HistorialInventario_Listar", "", oeHistorialInventario.Id)
            If ds.Tables.Count > 0 Then
                oeHistorialInventario = Cargar(ds.Tables(0).Rows(0))
                Return oeHistorialInventario
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeHistorialInventario As e_HistorialInventario) As List(Of e_HistorialInventario)
        Try
            Dim ldHistorialInventario As New List(Of e_HistorialInventario)
            Dim ds As DataSet
            With oeHistorialInventario
                ds = sqlhelper.ExecuteDataset("ALM.Isp_HistorialInventario_Listar", "" _
                        , .Id _
                        , .IdHistorial _
                        , .IdMaterial _
                        , .IdUnidadMedida _
                        , .CantidadFinal _
                        , .ValorUnitario _
                        , .ValorTotal _
                        , .Activo _
                        )
            End With
            oeHistorialInventario = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeHistorialInventario = Cargar(o_Fila)
                    ldHistorialInventario.Add(oeHistorialInventario)
                Next
                Return ldHistorialInventario
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function Listar_Inventario(ByVal oeInventario As e_Inventario) As List(Of e_HistorialInventario)
        Try
            Dim ldHistorialInventario As New List(Of e_HistorialInventario)
            Dim ds As DataSet
            Dim oeHistorialInventario As New e_HistorialInventario
            With oeInventario
                ds = sqlhelper.ExecuteDataset("ALM.Isp_Inventario_Listar", .TipoOperacion _
                        , .Id _
                        , .IdMaterial _
                        , .IdSubAlmacen _
                        , .CantidadInicial _
                        , .CantidadIngreso _
                        , .CantidadSalida _
                        , .CantidadFinal _
                        , .ValorUnitario _
                        , .ValorTotal _
                        , .FechaCreacion _
                        , "" _
                        , .StockMayor _
                        , "01/01/1901" _
                        , "01/01/1901" _
                        , True)
            End With
            oeInventario = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeHistorialInventario = Cargar(o_Fila)
                    ldHistorialInventario.Add(oeHistorialInventario)
                Next
                Return ldHistorialInventario
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeHistorialInventario As e_HistorialInventario) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeHistorialInventario
                sqlhelper.ExecuteNonQuery("ALM.Isp_HistorialInventario_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdHistorial _
                        , .IdMaterial _
                        , .IdUnidadMedida _
                        , .CantidadFinal _
                        , .ValorUnitario _
                        , .ValorTotal _
                        , .Fecha _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeHistorialInventario As e_HistorialInventario) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("ALM.Isp_HistorialInventario_IAE", "E", _
             "", oeHistorialInventario.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function UltimoIdInserta() As String
        Try
            Dim stResultado As String
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "ALM.Historial_Inventario", d_DatosConfiguracion.PrefijoID)
            Return IIf(stResultado Is Nothing, d_DatosConfiguracion.PrefijoID & "000000001", stResultado)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class