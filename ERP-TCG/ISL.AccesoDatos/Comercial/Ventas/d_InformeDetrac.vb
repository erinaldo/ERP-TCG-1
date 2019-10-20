'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_InformeDetrac

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_InformeDetrac
        Try
            Dim oeInformeDetrac = New e_InformeDetrac( _
                             o_Fila("Id").ToString _
                             , o_Fila("NroInforme").ToString _
                             , o_Fila("Total").ToString _
                             , o_Fila("Glosa").ToString _
                             , o_Fila("Fecha").ToString _
                             , o_Fila("Activo").ToString _
                             , o_Fila("FechaCreacion").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
            )
            Return oeInformeDetrac
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeInformeDetrac As e_InformeDetrac) As e_InformeDetrac

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.ISP_InformeDetrac_Listar", "", oeInformeDetrac.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeInformeDetrac = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeInformeDetrac
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeInformeDetrac As e_InformeDetrac) As List(Of e_InformeDetrac)
        Try
            Dim ldInformeDetrac As New List(Of e_InformeDetrac)
            Dim ds As DataSet
            With oeInformeDetrac
                ds = sqlhelper.ExecuteDataset("CON.ISP_InformeDetrac_Listar", "" _
                        , .Id _
                        , .NroInforme _
                        , .Total _
                        , .Glosa _
                        , .Fecha _
                        , .Activo _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        )
            End With
            oeInformeDetrac = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeInformeDetrac = Cargar(o_Fila)
                ldInformeDetrac.Add(oeInformeDetrac)
            Next
            Return ldInformeDetrac
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByRef oeInformeDetrac As e_InformeDetrac) As Boolean
        Try
            Dim odInformeDet As New d_InformeDetrac_Det
            Dim odDetracDet As New d_Detraccion_Det
            Dim oeDetracDet As New e_Detraccion_Det
            Dim stResultado() As String
            Using TransScope As New TransactionScope()
                With oeInformeDetrac
                    stResultado = sqlhelper.ExecuteScalar("CON.ISP_InformeDetrac_IAE", .TipoOperacion, .PrefijoID,
                            .Id _
                            , .NroInforme _
                            , .Total _
                            , .Glosa _
                            , .Fecha _
                            , .Activo _
                            , .FechaCreacion _
                            , .UsuarioCreacion
                        ).ToString.Split("_")

                    For Each oeInformeDet As e_InformeDetrac_Det In .leInformeDetrac
                        oeInformeDet.IdInformeDetrac = stResultado(0)
                        oeInformeDet.PrefijoID = oeInformeDetrac.PrefijoID '@0001
                        odInformeDet.Guardar(oeInformeDet)
                        oeDetracDet = New e_Detraccion_Det
                        oeDetracDet.PrefijoID = oeInformeDetrac.PrefijoID '@0001
                        oeDetracDet.IdVenta = oeInformeDet.IdVenta
                        oeDetracDet.Monto = oeInformeDet.Monto
                        oeDetracDet.UsuarioCreacion = oeInformeDet.UsuarioCreacion
                        oeDetracDet.Pendiente = True
                        oeDetracDet.TipoOperacion = "I"
                        odDetracDet.Guardar(oeDetracDet)
                    Next
                    .Id = stResultado(0)
                End With
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeInformeDetrac As e_InformeDetrac) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_InformeDetrac_IAE", "E", _
             "", oeInformeDetrac.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
