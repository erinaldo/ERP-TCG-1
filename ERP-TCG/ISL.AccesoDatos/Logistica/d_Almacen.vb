'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions


Public Class d_Almacen
    Private sqlhelper As New SqlHelper

    Private oeAlmacen As New e_Almacen
    Dim odDetalleZona As New d_Zona
    Private oeSubAlmacen As e_SubAlmacen, odSubAlmacen As New d_SubAlmacen

    Public Function Cargar(ByVal fila As DataRow) As e_Almacen
        Try
            Dim oeAlmacen = New e_Almacen(fila("Seleccion"), fila("Id"), fila("Codigo"), fila("Nombre"), _
                                          fila("Abreviatura"), fila("Activo"), fila("Capacidad"), fila("Direccion"), _
                                          fila("Propio"), fila("Lotizable"), fila("Tipo"), fila("IdCentro"), _
                                          fila("Centro"), fila("Ubigeo"), fila("IdProveedor"))
            Return oeAlmacen
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Obtener(ByVal oeAlmacen As e_Almacen) As e_Almacen
        Try
            Dim ds As DataSet
            Dim lb_Cargar As Boolean = oeAlmacen.CargaCompleta
            With oeAlmacen
                ds = sqlhelper.ExecuteDataset( _
                                              "ALM.Isp_Almacen_Listar", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Abreviatura _
                                              )
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeAlmacen = Cargar(ds.Tables(0).Rows(0))
                If lb_Cargar Then
                    oeSubAlmacen = New e_SubAlmacen
                    oeSubAlmacen.TipoOperacion = String.Empty
                    oeSubAlmacen.Activo = True
                    oeSubAlmacen.IdAlmacen = oeAlmacen.Id
                    oeAlmacen.leSubAlmacen = New List(Of e_SubAlmacen)
                    oeAlmacen.leSubAlmacen = odSubAlmacen.Listar(oeSubAlmacen)
                End If
            Else
                oeAlmacen = New e_Almacen
            End If
            Return oeAlmacen
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Listar(ByVal oeAlmacen As e_Almacen) As List(Of e_Almacen)
        Try
            Dim ds As DataSet
            Dim lista As New List(Of e_Almacen)
            With oeAlmacen
                ds = sqlhelper.ExecuteDataset("ALM.Isp_Almacen_Listar", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Abreviatura, _
                                              .Activo, _
                                              .Capacidad, _
                                              .Direccion, _
                                              .Propio, _
                                              .Lotizable, _
                                              .IdCentro)
            End With
            If ds.Tables.Count > 0 Then
                For Each fila As DataRow In ds.Tables(0).Rows
                    oeAlmacen = Cargar(fila)
                    lista.Add(oeAlmacen)
                Next
            End If
            Return lista
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeAlmacen As e_Almacen) As Boolean
        Try
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                With oeAlmacen
                    stResultado = sqlhelper.ExecuteScalar("ALM.Isp_Almacen_IAE",
                                              .TipoOperacion,
                                              .PrefijoID,
                                              .Id,
                                              .Codigo,
                                              .Nombre,
                                              .Abreviatura,
                                              .Activo,
                                              .Capacidad,
                                              .Direccion,
                                              .Propio,
                                              .Lotizable,
                                              .IdCentro,
                                              .Ubigeo,
                                              .IdProveedor).ToString.Split("_")
                    If Not .lstZona Is Nothing Then
                        For Each Detalle As e_Zona In .lstZona
                            Detalle.IdAlmacen = stResultado(0)
                            If Detalle.TipoOperacion <> "I" Then Detalle.TipoOperacion = .TipoOperacion
                            Detalle.PrefijoID = oeAlmacen.PrefijoID '@0001
                            odDetalleZona.Guardar(Detalle)
                        Next
                    End If
                    'For Each _oeSubAlm In .leSubAlmacen.Where(Function(it) it.TipoOperacion.Trim <> "").ToList
                    '    _oeSubAlm.IdAlmacen = .Id
                    '    odSubAlmacen.Guardar(_oeSubAlm)
                    'Next
                    For Each _oeSubAlm In .leSubAlmacen
                        If _oeSubAlm.TipoOperacion.Trim Is Nothing Then Continue For
                        If _oeSubAlm.TipoOperacion.Trim = "" Then Continue For
                        _oeSubAlm.IdAlmacen = .Id
                        _oeSubAlm.PrefijoID = oeAlmacen.PrefijoID '@0001
                        odSubAlmacen.Guardar(_oeSubAlm)
                    Next
                    transScope.Complete()
                    Return True
                End With
            End Using
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeAlmacen As e_Almacen) As Boolean
        Try
            With oeAlmacen
                Dim stResultado() As String
                stResultado = sqlhelper.ExecuteScalar("ALM.Isp_Almacen_IAE", _
                                          "E", _
                                          "", _
                                          oeAlmacen.Id).ToString.Split("_")
                Dim Detalle As New e_Zona
                Detalle.IdAlmacen = stResultado(0)
                Detalle.TipoOperacion = oeAlmacen.TipoOperacion
                odDetalleZona.Eliminar(Detalle)
                Return True
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
