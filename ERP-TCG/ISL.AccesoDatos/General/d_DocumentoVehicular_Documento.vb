Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_DocumentoVehicular_Documento
    Private sqlhelper As New SqlHelper
    Dim odDocVehDocPago As New d_DocVehDocPago

    Private Function Cargar(ByVal o_fila As DataRow) As e_DocumentoVehicular_Documento
        Try
            Dim oeDocVeh_Doc = New e_DocumentoVehicular_Documento( _
                               o_fila("Id").ToString _
                             , o_fila("IdDocumentoVehicular").ToString _
                             , o_fila("Tipo").ToString _
                             , o_fila("Numero").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("AfectaPoliza").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("Monto").ToString _
                             , o_fila("Saldo").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Aplica").ToString _
                                     )
            Return oeDocVeh_Doc
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeDocVeh_Doc As e_DocumentoVehicular_Documento) As List(Of e_DocumentoVehicular_Documento)
        Try
            Dim ldDocVeh_Doc As New List(Of e_DocumentoVehicular_Documento)
            Dim ds As DataSet
            With oeDocVeh_Doc
                ds = sqlhelper.ExecuteDataset("STD.Isp_DocumentoVehicular_Documento_Listar" _
                        , .TipoOperacion _
                        , .Id _
                        , .IdDocumentoVehicular _
                        , .Activo _
                        )
            End With
            oeDocVeh_Doc = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDocVeh_Doc = Cargar(o_Fila)
                    ldDocVeh_Doc.Add(oeDocVeh_Doc)
                Next
            End If
            Return ldDocVeh_Doc
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDocVeh_Doc As e_DocumentoVehicular_Documento) As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado As String = ""
            With oeDocVeh_Doc
                stResultado = sqlhelper.ExecuteScalar("STD.Isp_DocumentoVehicularDocumento_IAE" _
                                              , .TipoOperacion, d_DatosConfiguracion.PrefijoID _
                                            , .Id _
                                            , .IdDocumentoVehicular _
                                            , .Tipo _
                                            , .Numero _
                                            , .Fecha _
                                            , .AfectaPoliza _
                                            , .Glosa _
                                            , .Activo _
                                            , .UsuarioCreacion _
                                            , .Monto _
                                            , .Saldo _
                                            , .Aplica _
                    )
                If .leDocVehDocPago.Count > 0 Then
                    For Each obj In .leDocVehDocPago
                        odDocVehDocPago.Guardar(obj)
                    Next
                End If
            End With
            Return stResultado
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function ComboGrilla(ByVal Lista As List(Of e_DocumentoVehicular_Documento))
        Dim ds = New DataTable
        ds.Columns.Add("Id")
        ds.Columns.Add("Nombre")
        For Each item As e_DocumentoVehicular_Documento In Lista
            Dim newRow As DataRow = ds.NewRow()
            newRow("Id") = item.Id
            newRow("Nombre") = item.Numero
            ds.Rows.Add(newRow)
        Next
        Return ds
    End Function


End Class
