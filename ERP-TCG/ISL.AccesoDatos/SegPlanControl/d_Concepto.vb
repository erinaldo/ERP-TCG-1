Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Concepto
    Private sqlhelper As New SqlHelper
    Private odAreaTipoEvento As New d_AreaTipoEvento

    Private Function Cargar(ByVal o_fila As DataRow) As e_Concepto
        Try
            Dim oeConcepto = New e_Concepto()
            oeConcepto.Id = o_fila("Id").ToString.Trim
            oeConcepto.Codigo = o_fila("Codigo").ToString.Trim
            oeConcepto.Prefijo = o_fila("Prefijo").ToString.Trim
            oeConcepto.Correlativo = o_fila("Correlativo").ToString.Trim
            oeConcepto.Nombre = o_fila("Nombre").ToString.Trim
            oeConcepto.Descripcion = o_fila("Descripcion").ToString.Trim
            oeConcepto.Valor1 = o_fila("Valor1").ToString.Trim
            oeConcepto.Valor2 = o_fila("Valor2").ToString.Trim
            oeConcepto.Valor3 = o_fila("Valor3").ToString.Trim
            oeConcepto.FechaCreacion = o_fila("FechaCreacion").ToString.Trim
            oeConcepto.UsuarioCreacion = o_fila("UsuarioCreacion").ToString.Trim
            oeConcepto.Activo = o_fila("Activo").ToString.Trim
            oeConcepto.FechaModifica = o_fila("FechaModifica").ToString.Trim
            oeConcepto.UsuarioModifica = o_fila("UsuarioModifica").ToString.Trim

            Return oeConcepto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeConcepto As e_Concepto) As e_Concepto
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SPC.Isp_Concepto_Listar", "", oeConcepto.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeConcepto = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeConcepto
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeConcepto As e_Concepto) As List(Of e_Concepto)
        Try
            Dim ldConcepto As New List(Of e_Concepto)
            Dim ds As DataSet
            With oeConcepto
                ds = sqlhelper.ExecuteDataset("SPC.Isp_Concepto_Listar", "", .Id, .Codigo, .Prefijo, .Correlativo, .Nombre, .Descripcion _
                                              , .Valor1, .Valor2, .Valor3, .UsuarioCreacion, .Activo, .UsuarioModifica)
            End With
            oeConcepto = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeConcepto = Cargar(o_Fila)
                ldConcepto.Add(oeConcepto)
            Next
            Return ldConcepto
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeConcepto As e_Concepto) As Boolean
        Try
            'Dim stResultado() As String
            'Dim d_DatosConfiguracion As New d_DatosConfiguracion
            'With oeConcepto
            '    stResultado = sqlhelper.ExecuteNonQuery("SPC.Isp_Concepto_IAE", _
            '                                            .TipoOperacion, _
            '                                            d_DatosConfiguracion.PrefijoID, _
            '                                            .Id, _
            '                                            .Codigo, _
            '                                            .IdEvento, _
            '                                            .IdArea, _
            '                                            .IdTipoEvento, _
            '                                            .UsuarioCreacion, _
            '                                            .Activo).ToString.Split("_")
            'End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Guardar(ByVal oeConcepto As e_Concepto, ByVal listaAreaTipoEvento As List(Of e_AreaTipoEvento)) As Boolean
        Try
            Dim stResultado() As String
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Using transScope As New TransactionScope()
                With oeConcepto
                    stResultado = sqlhelper.ExecuteScalar("SPC.Isp_Concepto_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                            .Id _
                            , .Codigo _
                            , .Prefijo _
                            , .Correlativo _
                            , .Nombre _
                            , .Descripcion _
                            , .Valor1 _
                            , .Valor2 _
                            , .Valor3 _
                            , .UsuarioCreacion _
                        ).ToString.Split("_")

                    Dim oeAreaTipoEvento As New e_AreaTipoEvento
                    oeAreaTipoEvento.TipoOperacion = "U"
                    oeAreaTipoEvento.IdTipoEvento = oeConcepto.Prefijo.Trim
                    oeAreaTipoEvento.IdTipo = stResultado(0).Trim
                    oeAreaTipoEvento.UsuarioCreacion = oeConcepto.UsuarioCreacion
                    odAreaTipoEvento.Eliminar(oeAreaTipoEvento)

                    If listaAreaTipoEvento.Count > 0 Then
                        For Each AreaTipoEvento As e_AreaTipoEvento In listaAreaTipoEvento
                            AreaTipoEvento.IdTipo = stResultado(0)
                            AreaTipoEvento.IdTipoEvento = oeConcepto.Prefijo
                            AreaTipoEvento.TipoOperacion = oeConcepto.TipoOperacion.Trim
                            AreaTipoEvento.UsuarioCreacion = oeConcepto.UsuarioCreacion.Trim
                            odAreaTipoEvento.Guardar(AreaTipoEvento)
                        Next
                    End If
                    transScope.Complete()
                End With
            End Using
            
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeConcepto As e_Concepto) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SPC.Isp_Concepto_IAE", "E", _
             "", oeConcepto.Id, "", "", 0, "", "", "", "", "", oeConcepto.UsuarioCreacion)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function EliminarTipoEvento(ByVal oeConcepto As e_Concepto) As Boolean
        Try
            Using transScope As New TransactionScope()

                Dim oeAreaTipoEvento As New e_AreaTipoEvento
                oeAreaTipoEvento.TipoOperacion = "U"
                oeAreaTipoEvento.Id = ""
                oeAreaTipoEvento.Codigo = ""
                oeAreaTipoEvento.IdArea = ""
                oeAreaTipoEvento.Glosa = ""
                oeAreaTipoEvento.IdTipoEvento = oeConcepto.Prefijo.Trim
                oeAreaTipoEvento.IdTipo = oeConcepto.Valor1.Trim
                oeAreaTipoEvento.UsuarioCreacion = oeConcepto.UsuarioCreacion
                odAreaTipoEvento.Guardar(oeAreaTipoEvento)

                sqlhelper.ExecuteNonQuery("SPC.Isp_Concepto_IAE", "E", _
             "", oeConcepto.Id, "", "", 0, "", "", "", "", "", oeConcepto.UsuarioCreacion)

                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function ComboGrilla(ByVal oeConcepto As e_Concepto)
        Try
            Dim ds As DataSet
            With oeConcepto
                ds = sqlhelper.ExecuteDataset("SPC.Isp_Concepto_Listar", "", .Id, "", .Prefijo, .Correlativo, "", "" _
                                              , "", "", "", "", .Activo, "")
            End With
            oeConcepto = Nothing
            Return ds.Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
