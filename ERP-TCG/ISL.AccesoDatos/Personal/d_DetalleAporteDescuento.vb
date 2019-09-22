Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient


Public Class d_DetalleAporteDescuento
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_DetalleAporteDescuento
        Try
            Dim oeDetalleAporteDescuento = New e_DetalleAporteDescuento( _
                             o_fila("Id").ToString _
                             , o_fila("IdAporteDescuento").ToString _
                             , o_fila("UnidadCalculo").ToString _
                             , o_fila("MontoCalculo") _
                             , o_fila("IdFormula").ToString _
                             , o_fila("FechaActividad") _
                             , o_fila("FechaInactividad") _
                             , o_fila("Vigencia") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo") _
            )
            Return oeDetalleAporteDescuento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleAporteDescuento As e_DetalleAporteDescuento) As e_DetalleAporteDescuento

        Try
            Dim ds As DataSet
            With oeDetalleAporteDescuento
                ds = sqlhelper.ExecuteDataset("PER.Isp_DetalleAporteDescuento_Listar", .TipoOperacion, .Id)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeDetalleAporteDescuento = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDetalleAporteDescuento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleAporteDescuento As e_DetalleAporteDescuento) As List(Of e_DetalleAporteDescuento)
        Try
            Dim ldDetalleAporteDescuento As New List(Of e_DetalleAporteDescuento)
            Dim ds As DataSet
            With oeDetalleAporteDescuento
                ds = sqlhelper.ExecuteDataset("PER.Isp_DetalleAporteDescuento_Listar", "" _
                        , .Id _
                        , .IdAporteDescuento _
                        , .UnidadCalculo _
                        , .MontoCalculo _
                        , .IdFormula _
                        , .FechaActividad _
                        , .FechaInactividad _
                        , .Vigencia _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeDetalleAporteDescuento = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeDetalleAporteDescuento = Cargar(o_Fila)
                ldDetalleAporteDescuento.Add(oeDetalleAporteDescuento)
            Next
            Return ldDetalleAporteDescuento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleAporteDescuento As e_DetalleAporteDescuento) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim _id As String
            With oeDetalleAporteDescuento
                _id = sqlhelper.ExecuteScalar("PER.Isp_DetalleAporteDescuento_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdAporteDescuento _
                        , .UnidadCalculo _
                        , .MontoCalculo _
                        , .IdFormula _
                        , .FechaActividad _
                        , .FechaInactividad _
                        , .Vigencia _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                    )
                .Id = _id
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function ActualizarHistorial(ByVal oeDetallleAporteDescuento As e_DetalleAporteDescuento) As Boolean
        Try
            With oeDetallleAporteDescuento
                sqlhelper.ExecuteNonQuery("PER.Isp_DetalleAporteDescuento_IAE", "U", _
             "", .Id, .IdAporteDescuento)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function


    Public Function Eliminar(ByVal oeDetalleAporteDescuento As e_DetalleAporteDescuento) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_DetalleAporteDescuento_IAE", "E", _
             "", oeDetalleAporteDescuento.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
