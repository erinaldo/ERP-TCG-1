'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_DetalleConcepto

    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_DetalleConcepto
        Try
            Dim oeDetalleConcepto = New e_DetalleConcepto( _
                             o_fila("Id").ToString _
                             , o_fila("IdDetallePlanilla").ToString _
                             , o_fila("IdAporteDescuento").ToString _
                             , o_fila("CodAporDesc").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("Importe") _
                             , o_fila("Tipo") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo") _
            )
            oeDetalleConcepto.Gerencia = o_fila("Gerencia").ToString()
            oeDetalleConcepto.Area = o_fila("Area").ToString
            oeDetalleConcepto.Unidad = o_fila("Unidad").ToString
            oeDetalleConcepto.Ocupacion = o_fila("Ocupacion").ToString
            Return oeDetalleConcepto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleConcepto As e_DetalleConcepto) As e_DetalleConcepto

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_DetalleConcepto_Listar", "", oeDetalleConcepto.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeDetalleConcepto = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDetalleConcepto
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleConcepto As e_DetalleConcepto) As List(Of e_DetalleConcepto)
        Try
            Dim ldDetalleConcepto As New List(Of e_DetalleConcepto)
            Dim ds As DataSet
            With oeDetalleConcepto
                ds = sqlhelper.ExecuteDataset("PER.Isp_DetalleConcepto_Listar", .TipoOperacion _
                        , .Id _
                        , .IdDetallePlanilla _
                        , .IdAporteDescuento _
                        , .Importe _
                        , .Tipo _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                        )
            End With
            oeDetalleConcepto = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeDetalleConcepto = Cargar(o_Fila)
                ldDetalleConcepto.Add(oeDetalleConcepto)
            Next
            Return ldDetalleConcepto
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleConcepto As e_DetalleConcepto) As Boolean
        Try
            With oeDetalleConcepto
                sqlhelper.ExecuteNonQuery("PER.Isp_DetalleConcepto_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdDetallePlanilla _
                        , .IdAporteDescuento _
                        , .Importe _
                        , .Tipo _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarMasivo(ByVal dtDetalleConcepto As DataTable) As Boolean
        Try
            sqlhelper.InsertarMasivo("PER.DetalleConcepto", dtDetalleConcepto)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetalleConcepto As e_DetalleConcepto) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_DetalleConcepto_IAE", "E", _
             "", oeDetalleConcepto.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "PER.DetalleConcepto", PrefijoID)
            Return stResultado
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
