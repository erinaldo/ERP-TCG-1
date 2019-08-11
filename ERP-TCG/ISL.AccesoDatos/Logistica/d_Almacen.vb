Imports ISL.EntidadesWCF
Imports System.Transactions
''' <summary>
''' Clase que gestiona los almacenes del sistema, se define como un lugar o espacio físico para el almacenaje de bienes
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla Almacen,Capa del Sistema: Capa de Datos.</remarks>
Public Class d_Almacen
    Private sqlhelper As New SqlHelper

    Private oeAlmacen As New e_Almacen
    Dim odDetalleZona As New d_Zona
    Private oeSubAlmacen As e_SubAlmacen, odSubAlmacen As New d_SubAlmacen

    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_Almacen y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="fila">Recibe una variable fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeAlmacen) de tipo e_Almacen</returns>
    ''' <remarks>Capa del Sistema:Capa Datos</remarks>
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

    ''' <summary>
    ''' Metodo que obtiene un almacen, el cual es consultado por el procedimiento almacenado ALM.Isp_Almacen_Listar
    ''' enviando su id del almacen.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_Almacen.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeAlmacen">Recibe una variable oeAlmacen de tipo e_Almacen</param>
    ''' <returns>Devuelve una varible oeAlmacen de tipo e_Almacen</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa Datos</remarks>
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

    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_Almacen, el cual es consultado por el procedimiento almacenado ALM.Isp_Almacen_Listar
    ''' enviando sus atributos del almacen.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeAlmacen">Recibe una Variable oeAlmacen de tipo e_Almacen </param>
    ''' <returns>Devuelve una lista generica(ldAlmacen) de objetos de tipo e_Almacen</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa Datos</remarks>
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

    ''' <summary>
    ''' Metodo que se encargara de registrar los datos del almacen,a travez del procedimiento almacenado
    ''' ALM.Isp_Almacen_IAE,por el cual van a ser enviados y registrados los datos del almacen y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeAlmacen">Recibe una variable oeAlmacen de tipo e_Almacen</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro
    '''  de tipo de documento es positiva= true sino false Capa del Sistema:Capa Datos</remarks>
    Public Function Guardar(ByVal oeAlmacen As e_Almacen) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                With oeAlmacen
                    stResultado = sqlhelper.ExecuteScalar("ALM.Isp_Almacen_IAE", _
                                              .TipoOperacion, _
                                              d_DatosConfiguracion.PrefijoID, _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Abreviatura, _
                                              .Activo, _
                                              .Capacidad, _
                                              .Direccion, _
                                              .Propio, _
                                              .Lotizable, _
                                              .IdCentro, _
                                              .Ubigeo, _
                                              .IdProveedor).ToString.Split("_")
                    If Not .lstZona Is Nothing Then
                        For Each Detalle As e_Zona In .lstZona
                            Detalle.IdAlmacen = stResultado(0)
                            If Detalle.TipoOperacion <> "I" Then Detalle.TipoOperacion = .TipoOperacion
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

    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro de almacen,a travez del procedimiento almacenado
    ''' ALM.Isp_Almacen_IA,por el cual va a ser enviado el id del almacen a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeAlmacen">Recibe una variable oeAlmacen de tipo objeto e_Almacen</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa Datos</remarks>
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
