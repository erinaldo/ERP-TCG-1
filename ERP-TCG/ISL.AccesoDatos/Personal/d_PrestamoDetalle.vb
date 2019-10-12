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

Public Class d_PrestamoDetalle

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_PrestamoDetalle
        Try
            Dim oePrestamoDetalle = New e_PrestamoDetalle( _
                             o_fila("Id").ToString _
                             , o_fila("IdPrestamo").ToString _
                             , o_fila("Fecha") _
                             , o_fila("NroCuota").ToString _
                             , o_fila("Cancelado").ToString _
                             , o_fila("Importe").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Anio").ToString _
                             , o_fila("Mes").ToString _
                             , o_fila("DobleMes") _
                             , o_fila("Anulado") _
                             , o_fila("FechaAnulado") _
                             , o_fila("Glosa").ToString _
                             , o_fila("PeriodoEjecucion").ToString _
            )
            Return oePrestamoDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oePrestamoDetalle As e_PrestamoDetalle) As e_PrestamoDetalle

        Try
            Dim ds As DataSet
            With oePrestamoDetalle
                ds = sqlhelper.ExecuteDataset("TES.Isp_PrestamoDetalle_Listar", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .IdPrestamo, _
                                              .NroCuota, _
                                              .Cancelado, _
                                              .Importe, _
                                              .Activo, _
                                              .FechaCreacion, _
                                              .UsuarioCreacion, _
                                              .Fecha, _
                                              .Anio, _
                                              .Mes, _
                                              .DobleMes, _
                                              .Anulado)
            End With
            If ds.Tables(0).rows.Count > 0 Then
                oePrestamoDetalle = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oePrestamoDetalle
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oePrestamoDetalle As e_PrestamoDetalle) As List(Of e_PrestamoDetalle)
        Try
            Dim ldPrestamoDetalle As New List(Of e_PrestamoDetalle)
            Dim ds As DataSet
            With oePrestamoDetalle
                ds = sqlhelper.ExecuteDataset("TES.Isp_PrestamoDetalle_Listar", .TipoOperacion _
                        , .Id _
                        , .IdPrestamo _
                        , .NroCuota _
                        , .Cancelado _
                        , .Importe _
                        , .Activo _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , #1/1/1901# _
                        , "" _
                        , "" _
                        , -1 _
                        , .Anulado _
                        )
            End With
            oePrestamoDetalle = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oePrestamoDetalle = Cargar(o_Fila)
                ldPrestamoDetalle.Add(oePrestamoDetalle)
            Next
            Return ldPrestamoDetalle
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Ejecutar(ByVal oePrestamoDetalle As e_PrestamoDetalle, ByVal lePrestamo As List(Of e_Prestamo)) As Boolean
        Try
            Dim odPrestamo As New d_Prestamo
            Dim oePrest As New e_Prestamo
            Using transScope As New TransactionScope
                Guardar(oePrestamoDetalle)
                If Not lePrestamo Is Nothing Then
                    odPrestamo.GuardarLista(lePrestamo, "", "")
                End If
                oePrest.TipoOperacion = "S"
                odPrestamo.Guardar(oePrest, False)
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Guardar(ByVal oePrestamoDetalle As e_PrestamoDetalle) As Boolean
        Try
            With oePrestamoDetalle
                sqlhelper.ExecuteNonQuery("TES.Isp_PrestamoDetalle_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdPrestamo _
                        , .NroCuota _
                        , .Cancelado _
                        , .Importe _
                        , .Activo _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Fecha _
                        , .Anio _
                        , .Mes _
                        , .DobleMes _
                        , .Anulado _
                        , .FechaAnulado _
                        , .Glosa _
                        , .CadIdPrestDet _
                        , .PeriodoEjec
                    )


            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarLista(ByVal lePrestamoDet As List(Of e_PrestamoDetalle)) As Boolean
        Try
            Using transScope As New TransactionScope
                For Each oePrestDet As e_PrestamoDetalle In lePrestamoDet
                    Select Case oePrestDet.TipoOperacion
                        Case "I", "A"
                            Guardar(oePrestDet)
                        Case "E"
                            Eliminar(oePrestDet)
                    End Select
                Next
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oePrestamoDetalle As e_PrestamoDetalle) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_PrestamoDetalle_IAE", "E", _
             "", oePrestamoDetalle.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
