

Imports ISL.EntidadesWCF
''' <summary>
''' Clase que se encarga de gestionar la medida de material de los articulos en almacen.
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla AsignarMovimientoInventarioAlmacen,Capa del Sistema: Capa de Datos.</remarks>

Public Class d_MovimientoInventarioAlmacen
    Private sqlhelper As New SqlHelper

    Private oeMovimientoInventarioAlmacen As New e_MovimientoInventarioAlmacen
    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_AsignarMovimientoInventarioAlmacen y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeMovimientoInventarioAlmacen) de tipo e_AsignarMovimientoInventarioAlmacen</returns>
    ''' <remarks>Capa del Sistema:Capa Datos</remarks>
    Public Function Cargar(ByVal fila As DataRow) As e_MovimientoInventarioAlmacen
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim oeMovimientoInventarioAlmacen = New e_MovimientoInventarioAlmacen( _
                                                                              fila("Seleccion"), _
                                                                              fila("Id"), _
                                                                              fila("IdCentro"), _
                                                                              fila("Centro"), _
                                                                              fila("IdAlmacen"), _
                                                                              fila("Almacen"), _
                                                                              fila("IdMovimientoInventario"), _
                                                                              fila("MovimientoInventario"), _
                                                                              fila("Activo"))
            Return oeMovimientoInventarioAlmacen
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una medida de material, el cual es consultado por el procedimiento almacenado ALM.Isp_AsignarMovimientoInventarioAlmacen_Listar
    ''' enviando su id de la medida de material.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_AsignarMovimientoInventarioAlmacen.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeMovimientoInventarioAlmacen">Recibe una variable oeMovimientoInventarioAlmacen de tipo e_AsignarMovimientoInventarioAlmacen</param>
    ''' <returns>Devuelve una varible oeMovimientoInventarioAlmacen de tipo e_AsignarMovimientoInventarioAlmacen</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa Datos</remarks>

    Public Function Obtener(ByVal oeMovimientoInventarioAlmacen As e_MovimientoInventarioAlmacen) As e_MovimientoInventarioAlmacen
        Try
            Dim ds As New DataSet
            With oeMovimientoInventarioAlmacen
                ds = sqlhelper.ExecuteDataset("ALM.Isp_MovimientoInventarioAlmacen_Listar1", _
                                              .TipoOperacion, _
                                              .Id)
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeMovimientoInventarioAlmacen = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMovimientoInventarioAlmacen
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarDetalle(ByVal oeMovimientoInventarioAlmacen As e_MovimientoInventarioAlmacen) As Boolean
        Dim d_DatosConfiguracion As New d_DatosConfiguracion
        Try
            With oeMovimientoInventarioAlmacen
                sqlhelper.ExecuteNonQuery("[ALM].[Isp_MovimientoInventarioAlmacen_IAE]", _
                                          "I", _
                                          d_DatosConfiguracion.PrefijoID, _
                                          .Id, _
                                          .IdAlmacen, _
                                          .IdMovimientoInventario, _
                                          .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_AsignarMovimientoInventarioAlmacen, el cual es consultado por el procedimiento almacenado ALM.Isp_AsignarMovimientoInventarioAlmacen_Listar
    ''' enviando sus atributos de la medida de material.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeMovimientoInventarioAlmacen">Recibe una Variable oeMovimientoInventarioAlmacen de tipo e_AsignarMovimientoInventarioAlmacen</param>
    ''' <returns>Devuelve una lista generica(lista) de objetos de tipo e_AsignarMovimientoInventarioAlmacen</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa Datos</remarks>

    Public Function Listar(ByVal oeMovimientoInventarioAlmacen As e_MovimientoInventarioAlmacen) As List(Of e_MovimientoInventarioAlmacen)
        Try
            Dim ds As DataSet
            Dim lista As New List(Of e_MovimientoInventarioAlmacen)
            With oeMovimientoInventarioAlmacen
                ds = sqlhelper.ExecuteDataset("ALM.Isp_MovimientoInventarioAlmacen_Listar1", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .IdAlmacen, _
                                              .IdMovimientoInventario, _
                                              .Activo)
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each fila As DataRow In ds.Tables(0).Rows
                    oeMovimientoInventarioAlmacen = Cargar(fila)
                    lista.Add(oeMovimientoInventarioAlmacen)
                Next
            End If
            Return lista
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Metodo que se encargara de registrar los datos de la medida de material,a travez del procedimiento almacenado
    ''' ALM.Isp_AsignarMovimientoInventarioAlmacen_IAE,por el cual van a ser enviados y registrados los datos de la medida de material y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="listaObj">Recibe una variable oeMovimientoInventarioAlmacen de tipo e_AsignarMovimientoInventarioAlmacen </param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro 
    ''' de tipo de documento es positiva= true sino false Capa del Sistema:Capa Datos</remarks>
    Public Function Guardar(ByVal listaObj As List(Of e_MovimientoInventarioAlmacen)) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            For Each Detalle As e_MovimientoInventarioAlmacen In listaObj
                GuardarDetalle(Detalle)
            Next

            Return True

        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro del tipo de la medida de material,a travez del procedimiento almacenado
    ''' ALM.Isp_AsignarMovimientoInventarioAlmacen_IAE,por el cual va a ser enviado el id de la medida de material a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeMovimientoInventarioAlmacen">Recibe una variable oeMovimientoInventarioAlmacen de tipo objeto e_AsignarMovimientoInventarioAlmacen</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa Datos</remarks>

    Public Function Eliminar(ByVal oeMovimientoInventarioAlmacen As e_MovimientoInventarioAlmacen) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("ALM.Isp_MovimientoInventarioAlmacen_IAE", _
                                      "E", _
                                      "", _
                                      oeMovimientoInventarioAlmacen.Id)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Guardar(ByVal oeMovimientoInventarioAlmacen As e_MovimientoInventarioAlmacen) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            With oeMovimientoInventarioAlmacen
                sqlhelper.ExecuteNonQuery("ALM.Isp_MovimientoInventarioAlmacen_IAE", _
                                          .TipoOperacion, _
                                          d_DatosConfiguracion.PrefijoID, _
                                          .Id, _
                                          .IdAlmacen, _
                                          .IdMovimientoInventario, _
                                          .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class


