Imports ERP.EntidadesWCF

Public Class d_ComprobantePagoElectronico
    Private SQL As New SqlHelper
    Private DS As New DataSet

    Public Function Listar(ByVal item As e_ComprobantePagoElectronico) As List(Of e_ComprobantePagoElectronico)
        Try
            Dim Lista As New List(Of e_ComprobantePagoElectronico)
            Dim ds As DataSet = ExecuteLST(item)
            item = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    item = Cargar(o_Fila)
                    Lista.Add(item)
                Next
            End If
            Return Lista
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal item As e_ComprobantePagoElectronico) As e_ComprobantePagoElectronico
        Try
            Dim Lista As New List(Of e_ComprobantePagoElectronico)
            Dim ds As DataSet = ExecuteLST(item)
            item = New e_ComprobantePagoElectronico
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    item = Cargar(o_Fila)
                Next
            End If
            Return item
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ExecuteLST(ByVal Item As e_ComprobantePagoElectronico) As DataSet
        Try
            Dim ds As DataSet
            With Item
                ds = SQL.ExecuteDataset("CON.ComprobantePagoElectronico_LST" _
                , .TipoOperacion _
                , "" _
                , "" _
                , .Id
                )
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Cargar(ByVal o_fila As DataRow) As e_ComprobantePagoElectronico
        Try
            Dim Item = New e_ComprobantePagoElectronico(
                         o_fila("Id").ToString _
    , o_fila("IdEmpresaSis").ToString _
    , o_fila("IdCentro").ToString _
    , o_fila("TipoOperacion").ToString _
    , o_fila("TipoDocumento").ToString _
    , o_fila("Documento").ToString _
    , o_fila("FechaEmision").ToString _
    , o_fila("FechaVencimiento").ToString _
    , o_fila("Moneda").ToString _
    , o_fila("MontoLetras").ToString _
    , o_fila("NombreComercial").ToString _
    , o_fila("RazonSocial").ToString _
    , o_fila("DomFiscal").ToString _
    , o_fila("IndMatServ").ToString _
    , o_fila("Total").ToString _
    , o_fila("SubTotal").ToString _
    , o_fila("TotalIGV").ToString _
    , o_fila("TotalISC").ToString _
    , o_fila("TotalExo").ToString _
    , o_fila("TotalGratis").ToString _
    , o_fila("TotalOtros").ToString _
    , o_fila("TotalInafecto").ToString _
    , o_fila("RUCEmisor").ToString _
    , o_fila("CentroEmisor").ToString _
    , o_fila("DocumentoReceptor").ToString _
    , o_fila("Receptor").ToString _
    , o_fila("DireccionReceptor").ToString _
    , o_fila("UrbReceptor").ToString _
    , o_fila("ProvinciaReceptor").ToString _
    , o_fila("DepartamentoReceptor").ToString _
    , o_fila("UbigeoReceptor").ToString _
    , o_fila("DistritoReceptor").ToString _
    , o_fila("DctoGlobal").ToString _
    , o_fila("PorcentajeDcto").ToString _
    , o_fila("CodigoMotivo").ToString _
    , o_fila("Motivo").ToString _
    , o_fila("Glosa").ToString _
    , o_fila("DocumentoAsoc").ToString _
    , o_fila("TipoDocAsoc").ToString _
    , o_fila("FechaDocAsoc").ToString _
    , o_fila("Hash").ToString _
    , o_fila("RptaSunat").ToString _
    , o_fila("RutaZip").ToString _
    , o_fila("NombreArchivo").ToString _
    , o_fila("Usuario").ToString _
    , o_fila("IdResumen").ToString _
    , o_fila("IdEstadoSunat").ToString
      )

            Return Item
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
