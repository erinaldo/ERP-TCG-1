Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ImagenesDocumentos
    Private sqlhelper As New SqlHelper
    'Private odDocumentoVehiculoDetalle As New d_DocumentoVehiculoDetalle
    'Private oeDocumentoVehiculoDetalle As New e_DocumentoVehiculoDetalle

    Private Function Cargar(ByVal o_fila As DataRow) As e_ImagenesDocumentos
        Try
            Dim oeImagenesDocumentosVehiculos = New e_ImagenesDocumentos(o_fila("Id").ToString _
                             , o_fila("RutaImagen").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("IdVehiculo").ToString _
                             , o_fila("NroDocumento").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Placa").ToString _
                             , o_fila("TipoDocumento").ToString _
                             , o_fila("IdTipoDocumento").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaVencimiento").ToString _
                             , o_fila("FechaModificacion").ToString _
                             , o_fila("Vencimiento").ToString _
                             , o_fila("IndVigente").ToString)
            oeImagenesDocumentosVehiculos.Identificador = o_fila("Id").ToString.Trim
            oeImagenesDocumentosVehiculos.ModeloFuncional = o_fila("ModeloFuncional").ToString.Trim
            oeImagenesDocumentosVehiculos.FechaVigencia = o_fila("FechaVigencia").ToString
            oeImagenesDocumentosVehiculos.TipoOperacion = "I"
            oeImagenesDocumentosVehiculos.UsuarioModificacion = o_fila("UsuarioModificacion").ToString

            'oeDocumentoVehiculoDetalle = New e_DocumentoVehiculoDetalle
            'oeDocumentoVehiculoDetalle.TipoOperacion = "G"
            'oeDocumentoVehiculoDetalle.IdTipoDocumento = oeImagenesDocumentosVehiculos.IdTipoDocumento
            'oeDocumentoVehiculoDetalle.IdDocumento = oeImagenesDocumentosVehiculos.Id
            'oeImagenesDocumentosVehiculos.ListaDetalle = odDocumentoVehiculoDetalle.Listar(oeDocumentoVehiculoDetalle)

            Return oeImagenesDocumentosVehiculos
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeImagenesDocumentosVehiculos As e_ImagenesDocumentos) As e_ImagenesDocumentos
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SPC.Isp_ImagenesDocumentos_Listar", "", oeImagenesDocumentosVehiculos.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeImagenesDocumentosVehiculos = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeImagenesDocumentosVehiculos
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeImagenesDocumentosVehiculos As e_ImagenesDocumentos) As List(Of e_ImagenesDocumentos)
        Try
            Dim ldImagenesDocumentosVehiculos As New List(Of e_ImagenesDocumentos)
            Dim ds As DataSet
            With oeImagenesDocumentosVehiculos
                ds = sqlhelper.ExecuteDataset("SPC.Isp_ImagenesDocumentos_Listar", .TipoOperacion _
                        , .Id, .IdVehiculo, .IdTipoDocumento, .NroDocumento, .FechaCreacion, .FechaFin, IIf(.Identificador = "", 2, .Identificador))
            End With
            oeImagenesDocumentosVehiculos = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeImagenesDocumentosVehiculos = Cargar(o_Fila)
                ldImagenesDocumentosVehiculos.Add(oeImagenesDocumentosVehiculos)
            Next
            Return ldImagenesDocumentosVehiculos
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeImagenesDocumentosVehiculos As e_ImagenesDocumentos) As Boolean
        Try
            Dim stResultado() As String
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Using transScope As New TransactionScope()
                With oeImagenesDocumentosVehiculos
                    stResultado = sqlhelper.ExecuteScalar("SPC.Isp_ImagenesDocumentos_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                            .Id, IIf(.RutaImagen Is Nothing, "", .RutaImagen), IIf(.NroDocumento Is Nothing, "", .NroDocumento), _
                            IIf(.Descripcion Is Nothing, "", .Descripcion), IIf(.IdVehiculo Is Nothing, "", .IdVehiculo), _
                            IIf(.IdTrabajador Is Nothing, "", .IdTrabajador), IIf(.IdTipoDocumento Is Nothing, "", .IdTipoDocumento) _
                            , IIf(.UsuarioCreacion Is Nothing, "", .UsuarioCreacion), .FechaVencimiento, .FechaVigencia, .IndVigente).ToString.Split("_")
                End With
                'Try
                '    If oeImagenesDocumentosVehiculos.TipoOperacion = "I" And oeImagenesDocumentosVehiculos.RutaImagen.Trim.Length > 0 Then
                '        sqlhelper.ExecuteNonQuery("[SPC].[Isp_SincronizarDocumentoVehiculo]", oeImagenesDocumentosVehiculos.RutaImagen)
                '    End If
                'Catch ex As Exception
                'End Try
                'If oeImagenesDocumentosVehiculos.TipoOperacion = "I" Then
                '    sqlhelper.ExecuteNonQuery("SPC.Isp_DocumentoVehiculoDetalle_IAE", "T", _
                '                          "", oeImagenesDocumentosVehiculos.UsuarioCreacion, "", "", oeImagenesDocumentosVehiculos.IdTipoDocumento, stResultado(0))

                '    For Each item In oeImagenesDocumentosVehiculos.ListaDetalle
                '        item.IdDocumento = stResultado(0)
                '        odDocumentoVehiculoDetalle.Guardar(item)
                '    Next
                'End If
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeImagenesDocumentosVehiculos As e_ImagenesDocumentos) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SPC.Isp_ImagenesDocumentos_IAE", "E", _
             "", oeImagenesDocumentosVehiculos.Id, "", "", "", "", "", "", oeImagenesDocumentosVehiculos.UsuarioCreacion, Now, Now, 1)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarDesdeDocumentoVehicular(ByVal oeDocumentoVehicular As e_DocumentoVehicular) As Boolean
        Try
            Dim oeImagenesDocumentosVehiculos As New e_ImagenesDocumentos
            Dim lista As New List(Of e_ImagenesDocumentos)
            oeImagenesDocumentosVehiculos.TipoOperacion = ""
            lista = Listar(oeImagenesDocumentosVehiculos)
            Dim listaAux = lista.Where(Function(x) x.IdTrabajador = oeDocumentoVehicular.Id)
            If listaAux.Count > 1 Then Throw New Exception("Existe más de 1 registro en imágenes documentos.")
            If listaAux.Count = 0 Then
                oeImagenesDocumentosVehiculos.Id = ""
                oeImagenesDocumentosVehiculos.IndVigente = 1
            End If
            If listaAux.Count = 1 Then
                oeImagenesDocumentosVehiculos = listaAux(0)
            End If

            oeImagenesDocumentosVehiculos.TipoOperacion = "I"
            oeImagenesDocumentosVehiculos.IdTrabajador = oeDocumentoVehicular.Id
            oeImagenesDocumentosVehiculos.NroDocumento = oeDocumentoVehicular.Numero
            oeImagenesDocumentosVehiculos.Descripcion = oeDocumentoVehicular.Descripcion
            oeImagenesDocumentosVehiculos.IdVehiculo = oeDocumentoVehicular.ldDetalleDocVeh(0).IdVehiculo
            oeImagenesDocumentosVehiculos.FechaVencimiento = oeDocumentoVehicular.FechaVencimiento
            oeImagenesDocumentosVehiculos.FechaVigencia = oeDocumentoVehicular.FechaEmision
            oeImagenesDocumentosVehiculos.UsuarioCreacion = oeDocumentoVehicular.UsuarioCreacion
            oeImagenesDocumentosVehiculos.IdTipoDocumento = oeDocumentoVehicular.IdTipoDocumento
            oeImagenesDocumentosVehiculos.Activo = True

            Return Guardar(oeImagenesDocumentosVehiculos)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EliminarDesdeDocumentoVehicular(ByVal oeDocumentoVehicular As e_DocumentoVehicular) As Boolean
        Try
            Dim oeImagenesDocumentosVehiculos As New e_ImagenesDocumentos
            Dim lista As New List(Of e_ImagenesDocumentos)
            oeImagenesDocumentosVehiculos.TipoOperacion = ""
            lista = Listar(oeImagenesDocumentosVehiculos)
            Dim listaAux = lista.Where(Function(x) x.IdTrabajador.Trim = oeDocumentoVehicular.Id.Trim)
            If listaAux.Count > 1 Then Throw New Exception("Existe más de 1 registro en imágenes documentos.")
            If listaAux.Count = 1 Then
                oeImagenesDocumentosVehiculos = listaAux(0)
                Return Eliminar(oeImagenesDocumentosVehiculos)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Sincronizar(ByVal oeImagenesDocumentosVehiculos As e_ImagenesDocumentos) As e_ImagenesDocumentos
        Try
            Dim ldImagenesDocumentosVehiculos As New List(Of e_ImagenesDocumentos)
            Dim stResultado As String = ""
            With oeImagenesDocumentosVehiculos
                stResultado = sqlhelper.ExecuteScalar("SPC.Isp_ImagenesDocumentos_Listar", .TipoOperacion)
            End With
            If stResultado <> "0" Then Throw New Exception("Error al sincronizar.")
            Return oeImagenesDocumentosVehiculos
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
