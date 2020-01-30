Imports ERP.EntidadesWCF

Public Class d_ComprobantePagoElectronico_Detalle
    Private SQL As New SqlHelper
    Private DS As New DataSet

    Public Function Listar(ByVal item As e_ComprobantePagoElectronico_Detalle) As List(Of e_ComprobantePagoElectronico_Detalle)
        Try
            Dim ldMovimientoDocumento_Impresion As New List(Of e_ComprobantePagoElectronico_Detalle)
            Dim ds As DataSet = ExecuteLST(item)
            item = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    item = Cargar(o_Fila)
                    ldMovimientoDocumento_Impresion.Add(item)
                Next
            End If
            Return ldMovimientoDocumento_Impresion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ExecuteLST(ByVal Item As e_ComprobantePagoElectronico_Detalle) As DataSet
        Try
            Dim ds As DataSet
            With Item
                ds = SQL.ExecuteDataset("CON.ComprobantePagoElectronico_Detalle_LST" _
                , "GEN" _
                , "" _
                , "" _
                , .IdDocumento
                )
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Cargar(ByVal o_fila As DataRow) As e_ComprobantePagoElectronico_Detalle
        Try
            Dim Item = New e_ComprobantePagoElectronico_Detalle(
                         o_fila("IdDocumento").ToString _
    , o_fila("IdMaterial").ToString _
    , o_fila("IndMaterial_Servicio").ToString _
    , o_fila("UMedida").ToString _
    , o_fila("Cantidad").ToString _
    , o_fila("Producto").ToString _
    , o_fila("IndIGV").ToString _
    , o_fila("IndInafecta").ToString _
    , o_fila("IndExonerada").ToString _
    , o_fila("IndISC").ToString _
    , o_fila("IndIVAP").ToString _
    , o_fila("TotalIGV").ToString _
    , o_fila("TotalInafecta").ToString _
    , o_fila("TotalExonerada").ToString _
    , o_fila("TotalISC").ToString _
    , o_fila("TotalIVAP").ToString _
    , o_fila("CostoUnitario").ToString _
    , o_fila("PrecioUnitario").ToString _
    , o_fila("PrecioTotal").ToString _
    , o_fila("CostoTotal").ToString
        )
            Return Item
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
