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

Public Class d_AporteDescuento

    Private sqlhelper As New SqlHelper
    Private oeHistorial As New e_DetalleAporteDescuento
    Private odHistorial As New d_DetalleAporteDescuento

    Private Function Cargar(ByVal o_fila As DataRow) As e_AporteDescuento
        Try
            Dim oeAporteDescuento = New e_AporteDescuento( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("AporteDescuento") _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeAporteDescuento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeAporteDescuento As e_AporteDescuento) As e_AporteDescuento
        Try
            Dim ds As DataSet
            With oeAporteDescuento
                ds = sqlhelper.ExecuteDataset("PER.Isp_AporteDescuento_Listar", .TipoOperacion, .Id)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeAporteDescuento = Cargar(ds.Tables(0).Rows(0))
                oeHistorial = New e_DetalleAporteDescuento
                oeHistorial.TipoOperacion = ""
                oeHistorial.Activo = True
                oeHistorial.Vigencia = -1
                oeHistorial.IdAporteDescuento = oeAporteDescuento.Id
                oeAporteDescuento.leHistorial = odHistorial.Listar(oeHistorial)
            End If
            Return oeAporteDescuento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAporteDescuento As e_AporteDescuento) As List(Of e_AporteDescuento)
        Try
            Dim ldAporteDescuento As New List(Of e_AporteDescuento)
            Dim ds As DataSet
            With oeAporteDescuento
                ds = sqlhelper.ExecuteDataset("PER.Isp_AporteDescuento_Listar", .TipoOperacion _
                        , .Id _
                        , .Codigo _
                        , .Nombre _
                        , CInt(.AporteDescuento) _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeAporteDescuento = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeAporteDescuento = Cargar(o_Fila)
                ldAporteDescuento.Add(oeAporteDescuento)
            Next
            Return ldAporteDescuento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAporteDescuento As e_AporteDescuento) As Boolean
        Try
            Dim odDetalle As New d_DetalleAporteDescuento
            Dim _oeTemp As New e_DetalleAporteDescuento
            Dim _bnd As Boolean = False
            Dim _id As String
            With oeAporteDescuento
                _id = sqlhelper.ExecuteScalar("PER.Isp_AporteDescuento_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .AporteDescuento _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo
                    )
                .Id = _id
                For Each oeDet In .leHistorial
                    oeDet.IdAporteDescuento = _id
                    oeDet.PrefijoID = oeAporteDescuento.PrefijoID '@0001
                    odDetalle.Guardar(oeDet)
                    If oeDet.TipoOperacion = "I" AndAlso .leHistorial.Count > 1 Then
                        _oeTemp = oeDet
                        _bnd = True
                    End If
                Next

                If _bnd Then odDetalle.ActualizarHistorial(_oeTemp)

            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeAporteDescuento As e_AporteDescuento) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_AporteDescuento_IAE", "E", _
             "", oeAporteDescuento.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
