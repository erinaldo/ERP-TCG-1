Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_InformeDetrac_Det

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_InformeDetrac_Det
        Try
            Dim oeInformeDetrac_Det = New e_InformeDetrac_Det( _
                             o_fila("Id").ToString _
                             , o_fila("IdInformeDetrac").ToString _
                             , o_fila("IdVenta").ToString _
                             , o_fila("Monto").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Serie").ToString _
                             , o_fila("Numero").ToString _
                             , o_fila("RazonSocial").ToString _
                             , o_fila("FechaEmision") _
                             , o_fila("Total") _
                             , o_fila("RUC").ToString _
                             , o_fila("NroInforme").ToString _
            )
            Return oeInformeDetrac_Det
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeInformeDetrac_Det As e_InformeDetrac_Det) As e_InformeDetrac_Det

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_InformeDetrac_Det_Listar", "", oeInformeDetrac_Det.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeInformeDetrac_Det = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeInformeDetrac_Det
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeInformeDetrac_Det As e_InformeDetrac_Det) As List(Of e_InformeDetrac_Det)
        Try
            Dim ldInformeDetrac_Det As New List(Of e_InformeDetrac_Det)
            Dim ds As DataSet
            With oeInformeDetrac_Det
                ds = sqlhelper.ExecuteDataset("CON.Isp_InformeDetrac_Det_Listar", "" _
                        , .Id _
                        , .IdInformeDetrac _
                        , .IdVenta _
                        , .Monto _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeInformeDetrac_Det = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeInformeDetrac_Det = Cargar(o_Fila)
                ldInformeDetrac_Det.Add(oeInformeDetrac_Det)
            Next
            Return ldInformeDetrac_Det
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeInformeDetrac_Det As e_InformeDetrac_Det) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeInformeDetrac_Det
                sqlhelper.ExecuteNonQuery("CON.Isp_InformeDetrac_Det_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdInformeDetrac _
                        , .IdVenta _
                        , .Monto _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeInformeDetrac_Det As e_InformeDetrac_Det) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_InformeDetrac_Det_IAE", "E", _
             "", oeInformeDetrac_Det.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
