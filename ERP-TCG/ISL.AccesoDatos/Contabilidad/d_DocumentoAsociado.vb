Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_DocumentoAsociado
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_DocumentoAsociado
        Try
            Dim oeDocumentoAsociado = New e_DocumentoAsociado(o_fila("Id").ToString _
                             , o_fila("IdMovimientoDocumento").ToString _
                             , o_fila("IdMovimientoDocumentoAsoc").ToString _
                             , o_fila("IndAfectaDocumento") _
                             , o_fila("Activo").ToString)
            oeDocumentoAsociado.Monto_Operar = o_fila("MontoOperar")
            oeDocumentoAsociado.Monto_Desc = o_fila("MontoDesc")
            Return oeDocumentoAsociado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDocumentoAsociado As e_DocumentoAsociado) As e_DocumentoAsociado

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_DocumentoAsociado_Listar", oeDocumentoAsociado.TipoOperacion, oeDocumentoAsociado.Id, _
                                          oeDocumentoAsociado.IdMovimientoDocumento, _
                                          oeDocumentoAsociado.IdMovimientoDocumentoAsoc, _
                                          oeDocumentoAsociado.Activo)
            If ds.Tables(0).rows.Count > 0 Then
                oeDocumentoAsociado = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDocumentoAsociado
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDocumentoAsociado As e_DocumentoAsociado) As List(Of e_DocumentoAsociado)
        Try
            Dim ldDocumentoAsociado As New List(Of e_DocumentoAsociado)
            Dim ds As DataSet
            With oeDocumentoAsociado
                ds = sqlhelper.ExecuteDataset("CON.Isp_DocumentoAsociado_Listar", IIf(.TipoOperacion Is DBNull.Value, "", .TipoOperacion) _
                        , .Id _
                        , .IdMovimientoDocumento _
                        , .IdMovimientoDocumentoAsoc _
                        , .Activo _
                        )
            End With
            oeDocumentoAsociado = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDocumentoAsociado = Cargar(o_Fila)
                    ldDocumentoAsociado.Add(oeDocumentoAsociado)
                Next
            End If
            Return ldDocumentoAsociado
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDocAsoc(ByVal oeDocumentoAsociado As e_DocumentoAsociado) As List(Of e_MovimientoDocumento)
        Try
            Dim ldDocumentoAsociado As New List(Of e_MovimientoDocumento)
            Dim ds As DataSet
            With oeDocumentoAsociado
                ds = sqlhelper.ExecuteDataset("CON.Isp_DocumentoAsociado_Listar", IIf(.TipoOperacion Is DBNull.Value, "", .TipoOperacion) _
                        , .Id _
                        , .IdMovimientoDocumento _
                        , .IdMovimientoDocumentoAsoc _
                        , .Activo _
                        )
            End With
            oeDocumentoAsociado = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDocumentoAsociado = Cargar(o_Fila)

                    Dim oeMovDoc As New e_MovimientoDocumento
                    Dim odMovDoc As New d_MovimientoDocumento
                    oeMovDoc.Id = oeDocumentoAsociado.IdMovimientoDocumentoAsoc
                    oeMovDoc = odMovDoc.Obtener(oeMovDoc)
                    oeMovDoc.IdDocAsoc = oeDocumentoAsociado.Id
                    ldDocumentoAsociado.Add(oeMovDoc)

                Next
            End If
            Return ldDocumentoAsociado
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDocumentoAsociado As e_DocumentoAsociado) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeDocumentoAsociado
                sqlhelper.ExecuteNonQuery("CON.Isp_DocumentoAsociado_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdMovimientoDocumento _
                        , .IdMovimientoDocumentoAsoc _
                        , .IndAfectaDocumento _
                        , .Activo _
                        , .Monto_Operar _
                        , .Monto_Desc _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDocumentoAsociado As e_DocumentoAsociado) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_DocumentoAsociado_IAE", "E", _
             "", oeDocumentoAsociado.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
