'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions

Public Class d_Historial
    Private sqlhelper As New SqlHelper
    Dim odHistorialInventario As New d_HistorialInventario
    Private Function Cargar(ByVal o_fila As DataRow) As e_Historial
        Try
            Dim oeHistorial = New e_Historial( _
                             o_fila("Id").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("IdSubAlmacen").ToString _
                             , o_fila("SubAlmacen").ToString _
                             , o_fila("IdAlmacen").ToString _
                             , o_fila("Almacen").ToString _
                              , o_fila("IdCentro").ToString _
                             , o_fila("Centro").ToString _
                             , o_fila("Activo").ToString _
            )

            Return oeHistorial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeHistorial As e_Historial) As e_Historial

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("ALM.Isp_Historial_Listar", "", oeHistorial.Id)
            If ds.Tables.Count > 0 Then
                oeHistorial = Cargar(ds.Tables(0).Rows(0))
                Return oeHistorial
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeHistorial As e_Historial) As List(Of e_Historial)
        Try
            Dim ldHistorial As New List(Of e_Historial)
            Dim ds As DataSet
            With oeHistorial
                ds = sqlhelper.ExecuteDataset("ALM.Isp_Historial_Listar", "" _
                        , .Id _
                        , .IdSubAlmacen _
                        , .Activo _
                        , ._fechaInicio _
                        , ._fechaFin _
                        )

            End With
            oeHistorial = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeHistorial = Cargar(o_Fila)
                    ldHistorial.Add(oeHistorial)
                Next
                Return ldHistorial
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeHistorial As e_Historial) As Boolean
        Try
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                With oeHistorial
                    stResultado = sqlhelper.ExecuteScalar("ALM.Isp_Historial_IAE", .TipoOperacion, .PrefijoID,
                            .Id _
                            , .IdSubAlmacen _
                            , .Fecha _
                            , .Activo _
                            , .UsuarioCreacion _
                            , .Glosa
                        ).ToString.Split("_")

                    For Each Detalle As e_HistorialInventario In .lstHistorialInventario
                        Detalle.IdHistorial = stResultado(0)
                        Detalle.TipoOperacion = .TipoOperacion
                        odHistorialInventario.Guardar(Detalle)
                    Next

                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Public Async Sub GuardaDetalle(id As String, tipoope As String, lista As List(Of e_HistorialInventario))

    '    For Each Detalle As e_HistorialInventario In lista
    '        Detalle.IdHistorial = id
    '        Detalle.TipoOperacion = tipoope
    '        odHistorialInventario.Guardar(Detalle)
    '    Next

    'End Sub

    Public Function Eliminar(ByVal oeHistorial As e_Historial) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("ALM.Isp_Historial_IAE", "E", _
             "", oeHistorial.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "ALM.Historial", PrefijoID)
            Return IIf(stResultado Is Nothing, PrefijoID & "000000001", stResultado)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardaMasivo(DTHistorial As DataTable, DTHistorialInventario As DataTable) As Boolean
        Using Transaction As New TransactionScope
            If DTHistorial.Rows.Count > 0 Then sqlhelper.InsertarMasivo("ALM.Historial", DTHistorial)
            If DTHistorialInventario.Rows.Count > 0 Then sqlhelper.InsertarMasivo("ALM.Historial_Inventario", DTHistorialInventario)
            Transaction.Complete()
        End Using
        Return True
    End Function

End Class
