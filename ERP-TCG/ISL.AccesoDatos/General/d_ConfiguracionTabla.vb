Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ConfiguracionTabla

    Private sqlhelper As New SqlHelper
    Private oeConfColumna As e_ConfiguracionColumna, odConfColumna As New d_ConfiguracionColumna
    Private oeConfDato As e_ConfiguracionDato, odConfDato As New d_ConfiguracionDato

    Private Function Cargar(ByVal o_fila As DataRow) As e_ConfiguracionTabla
        Try
            Dim oeConfiguracionTabla = New e_ConfiguracionTabla( _
                             o_fila("Id").ToString _
                             , o_fila("Esquema").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("Maestra") _
                             , o_fila("Limpiar") _
                             , o_fila("Insertar") _
                             , o_fila("Actualizar") _
                             , o_fila("NroOrden") _
                             , o_fila("IndTipo") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo") _
            )
            Return oeConfiguracionTabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeConfiguracionTabla As e_ConfiguracionTabla) As e_ConfiguracionTabla
        Try
            Dim ds As DataSet
            Dim lb_Carga As Boolean = oeConfiguracionTabla.CargaCompleta
            With oeConfiguracionTabla
                ds = sqlhelper.ExecuteDataset("STD.Isp_ConfiguracionTabla_Listar", .TipoOperacion, .Id, .Esquema, .Codigo, .Nombre)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeConfiguracionTabla = Cargar(ds.Tables(0).Rows(0))
                If oeConfiguracionTabla.Id.Trim <> "" AndAlso lb_Carga Then
                    ' Cargar Columnas de la Tabla
                    oeConfColumna = New e_ConfiguracionColumna
                    oeConfColumna.TipoOperacion = "" : oeConfColumna.IdTabla = oeConfiguracionTabla.Id : oeConfiguracionTabla.Activo = True
                    oeConfiguracionTabla.leColumna = odConfColumna.Listar(oeConfColumna)
                    ' Cargar Datos de la Tabla
                    oeConfDato = New e_ConfiguracionDato
                    oeConfDato.TipoOperacion = "T" : oeConfDato.IdColumna = oeConfiguracionTabla.Id : oeConfDato.Activo = True
                    oeConfiguracionTabla.leDato = odConfDato.Listar(oeConfDato)
                End If
            End If
            Return oeConfiguracionTabla
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeConfiguracionTabla As e_ConfiguracionTabla) As List(Of e_ConfiguracionTabla)
        Try
            Dim ldConfiguracionTabla As New List(Of e_ConfiguracionTabla)
            Dim ds As DataSet
            With oeConfiguracionTabla
                ds = sqlhelper.ExecuteDataset("STD.Isp_ConfiguracionTabla_Listar", .TipoOperacion _
                        , .Id _
                        , .Esquema _
                        , .Codigo _
                        , .Nombre _
                        , .Descripcion _
                        , .Maestra _
                        , .Limpiar _
                        , .Insertar _
                        , .Actualizar _
                        , .NroOrden _
                        , .IndTipo _
                        , .Activo _
                        )
            End With
            oeConfiguracionTabla = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeConfiguracionTabla = Cargar(o_Fila)
                ldConfiguracionTabla.Add(oeConfiguracionTabla)
            Next
            Return ldConfiguracionTabla
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeConfiguracionTabla As e_ConfiguracionTabla) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim id As String = ""
            Using TransScope As New TransactionScope()
                With oeConfiguracionTabla
                    id = sqlhelper.ExecuteScalar("STD.Isp_ConfiguracionTabla_IAE", .TipoOperacion, .PrefijoID, _
                            .Id _
                            , .Esquema _
                            , .Codigo _
                            , .Nombre _
                            , .Descripcion _
                            , .Maestra _
                            , .Limpiar _
                            , .Insertar _
                            , .Actualizar _
                            , .NroOrden _
                            , .IndTipo _
                            , .UsuarioCreacion _
                            , .UsuarioModifica _
                            , .Activo _
                        )
                    For Each oeCCol In .leColumna.Where(Function(it) it.TipoOperacion.Trim <> "").ToList
                        oeCCol.IdTabla = id
                        oeCCol.PrefijoID = .PrefijoID '@0001
                        If oeCCol.TipoOperacion = "E" Then
                            odConfColumna.Eliminar(oeCCol)
                        Else
                            odConfColumna.Guardar(oeCCol)
                        End If
                    Next
                    For Each oeCDat In .leDato.Where(Function(it) it.TipoOperacion.Trim <> "" And it.TipoOperacion.Trim <> "I").ToList
                        oeCDat.PrefijoID = .PrefijoID '@0001
                        If oeCDat.TipoOperacion = "E" Then odConfDato.Eliminar(oeCDat)
                        If oeCDat.TipoOperacion = "A" Then odConfDato.Guardar(oeCDat)
                    Next
                    If .dsCDato.Rows.Count > 0 Then odConfDato.GuardarMasivo(.dsCDato)
                    oeConfDato = New e_ConfiguracionDato
                    oeConfDato.TipoOperacion = "C" : oeConfDato.Activo = True : oeConfDato.IdReferencia = .Id
                    oeConfDato.PrefijoID = .PrefijoID '@0001
                    odConfDato.Guardar(oeConfDato)
                End With
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeConfiguracionTabla As e_ConfiguracionTabla) As Boolean
        Try
            With oeConfiguracionTabla
                sqlhelper.ExecuteNonQuery("STD.Isp_ConfiguracionTabla_IAE", "E", _
             "", .Id _
             , .Esquema _
                            , .Codigo _
                            , .Nombre _
                            , .Descripcion _
                            , .Maestra _
                            , .Limpiar _
                            , .Insertar _
                            , .Actualizar _
                            , .NroOrden _
                            , .IndTipo _
                            , .UsuarioCreacion _
                            , .UsuarioModifica _
                            , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
