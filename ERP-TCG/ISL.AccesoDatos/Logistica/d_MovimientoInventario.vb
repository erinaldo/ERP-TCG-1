'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
''' <summary>
''' Clase que se encarga de gestionar los movimientos de inventario en almacen.
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla MovimientoInventario,Capa del Sistema: Capa de Acceso a Datos.</remarks>

Public Class d_MovimientoInventario
    Private sqlhelper As New SqlHelper

    Public oeMovimientoInventario As New e_MovimientoInventario
    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_MovimientoInventario y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeMovimientoInventario) de tipo e_MovimientoInventario</returns>
    ''' <remarks>Capa del Sistema:Capa Datos</remarks>
    Public Function Cargar(ByVal fila As DataRow) As e_MovimientoInventario
        Try
            Dim oeMovimientoInventario = New e_MovimientoInventario( _
                                        fila("Seleccion"), _
                                        fila("Id"), _
                                        fila("Codigo"), _
                                        fila("Nombre"), _
                                        fila("Abreviatura"), _
                                        fila("Activo"), _
                                        fila("TipoMovimientoInventario"), _
                                        fila("IdTipoMovimientoInventario"), _
                                        fila("IndDevolucion"))
            Return oeMovimientoInventario
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene un movimiento de inventario, el cual es consultado por el procedimiento almacenado ALM.Isp_MovimientoInventario_Listar
    ''' enviando su id del movimiento de inventario.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_MovimientoInventario.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeMovimientoInventario">Recibe una variable oeMovimientoInventario de tipo e_MovimientoInventario</param>
    ''' <returns>Devuelve una varible oeFamiliaMaterial de tipo e_FamiliaMaterial</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa Datos</remarks>

    Public Function Obtener(ByVal oeMovimientoInventario As e_MovimientoInventario) As e_MovimientoInventario
        Try
            Dim ds As DataSet
            With oeMovimientoInventario
                ds = sqlhelper.ExecuteDataset("ALM.Isp_MovimientoInventario_Listar", _
                                              "", _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Abreviatura)
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeMovimientoInventario = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMovimientoInventario
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_MovimientoInventario, el cual es consultado por el procedimiento almacenado ALM.Isp_MovimientoInventario_Listar
    ''' enviando sus atributos del movimiento de inventario.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeMovimientoInventario">Recibe una Variable oeMovimientoInventario de tipo e_MovimientoInventario</param>
    ''' <returns>Devuelve una lista generica(lista) de objetos de tipo e_MovimientoInventario</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa Datos</remarks>

    Public Function Listar(ByVal oeMovimientoInventario As e_MovimientoInventario) As List(Of e_MovimientoInventario)
        Try
            Dim ds As New DataSet
            Dim lista As New List(Of e_MovimientoInventario)
            With oeMovimientoInventario
                ds = sqlhelper.ExecuteDataset("ALM.Isp_MovimientoInventario_Listar", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Abreviatura, _
                                              .Activo)
                If ds.Tables.Count > 0 Then
                    For Each fila As DataRow In ds.Tables(0).Rows
                        oeMovimientoInventario = Cargar(fila)
                        lista.Add(oeMovimientoInventario)
                    Next
                End If
                Return lista
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los datos del movimiento de inventario,a travez del procedimiento almacenado
    ''' ALM.Isp_MovimientoInventario_IAE,por el cual van a ser enviados y registrados los datos del movimiento de inventario y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeMovimientoInventario">Recibe una variable oeMovimientoInventario de tipo e_MovimientoInventario </param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro 
    ''' de tipo de documento es positiva= true sino false Capa del Sistema:Capa Datos</remarks>

    Public Function Guardar(ByVal oeMovimientoInventario As e_MovimientoInventario) As Boolean
        Try
            With oeMovimientoInventario
                sqlhelper.ExecuteNonQuery("ALM.Isp_MovimientoInventario_IAE",
                                          .TipoOperacion,
                                          .PrefijoID,
                                          .Id,
                                          .Codigo,
                                          .Nombre,
                                          .Abreviatura,
                                          .Activo,
                                          .IdTipoMovimientoInventario)
                Return True
            End With
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un movimiento de inventario,a travez del procedimiento almacenado
    ''' ALM.Isp_MovimientoInventario_IAE,por el cual va a ser enviado el id del movimiento de inventario a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeMovimientoInventario">Recibe una variable oeMovimientoInventario de tipo objeto e_MovimientoInventario</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa Datos</remarks>

    Public Function Eliminar(ByVal oeMovimientoInventario As e_MovimientoInventario) As Boolean
        Try
            With oeMovimientoInventario
                sqlhelper.ExecuteNonQuery("ALM.Isp_MovimientoInventario_IAE", _
                                          "E", _
                                          "", _
                                          .Id)
                Return True
            End With
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function
End Class
