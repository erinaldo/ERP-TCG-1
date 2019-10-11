'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
''' <summary>
''' Clase que se encarga de gestionar los tipos de movimiento de inventario en almacen.
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla TipoMovimientoInventario,Capa del Sistema: Capa de Acceso a Datos.</remarks>

Public Class d_TipoMovimientoInventario
    Private sqlhelper As New SqlHelper

    Private oeTipoMovimientoInventario As New e_TipoMovimientoInventario
    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_TipoMovimientoInventario y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeTipoMovimientoInventario) de tipo e_TipoMovimientoInventario</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Cargar(ByVal fila As DataRow) As e_TipoMovimientoInventario
        Try
            oeTipoMovimientoInventario = New e_TipoMovimientoInventario( _
                                                                        fila("Id"), _
                                                                        fila("Codigo"), _
                                                                        fila("Nombre"), _
                                                                        fila("Abreviatura"), _
                                                                        fila("Activo"))
            Return oeTipoMovimientoInventario
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene un tipo de movimiento de inventario, el cual es consultado por el procedimiento almacenado ALM.Isp_TipoMovimientoInventario_Listar
    ''' enviando su id del tipo de movimiento de inventario.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_TipoMovimientoInventario.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoMovimientoInventario">Recibe una variable oeTipoMovimientoInventario de tipo e_TipoMovimientoInventario</param>
    ''' <returns>Devuelve una varible oeTipoMovimientoInventario de tipo e_TipoMovimientoInventario</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Obtener(ByVal oeTipoMovimientoInventario As e_TipoMovimientoInventario) As e_TipoMovimientoInventario
        Try
            Dim ds As New DataSet
            With oeTipoMovimientoInventario
                ds = sqlhelper.ExecuteDataset("ALM.Isp_TipoMovimientoInventario_Listar", _
                                              "", _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Abreviatura)
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeTipoMovimientoInventario = Cargar(ds.Tables(0).Rows(0))
            Else
                oeTipoMovimientoInventario = New e_TipoMovimientoInventario
            End If
            Return oeTipoMovimientoInventario
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_TipoMovimientoInventario, el cual es consultado por el procedimiento almacenado ALM.Isp_TipoMovimientoInventario_Listar
    ''' enviando sus atributos del tipo de movimiento de inventario.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoMovimientoInventario">Recibe una Variable oeTipoMovimientoInventario de tipo e_TipoMovimientoInventario</param>
    ''' <returns>Devuelve una lista generica(lista) de objetos de tipo e_TipoMovimientoInventario</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeTipoMovimientoInventario As e_TipoMovimientoInventario) As List(Of e_TipoMovimientoInventario)
        Try
            Dim ds As New DataSet
            Dim lista As New List(Of e_TipoMovimientoInventario)
            With oeTipoMovimientoInventario
                ds = sqlhelper.ExecuteDataset("ALM.Isp_TipoMovimientoInventario_Listar", _
                                              "", _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Abreviatura, _
                                              .Activo)
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each fila As DataRow In ds.Tables(0).Rows
                    oeTipoMovimientoInventario = Cargar(fila)
                    lista.Add(oeTipoMovimientoInventario)
                Next
            End If
            Return lista
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los tipo de movimiento de inventario,a travez del procedimiento almacenado
    ''' ALM.Isp_TipoMovimientoInventario_IAE,por el cual van a ser enviados y registrados los datos del tipo de movimiento de material y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoMovimientoInventario">Recibe una variable oeTipoMovimientoInventario de tipo e_TipoMovimientoInventario </param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro 
    ''' de tipo de documento es positiva= true sino false Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Guardar(ByVal oeTipoMovimientoInventario As e_TipoMovimientoInventario) As Boolean
        Try
            With oeTipoMovimientoInventario
                sqlhelper.ExecuteNonQuery("ALM.Isp_TipoMovimientoInventario_IAE",
                                          .TipoOperacion,
                                          .PrefijoID _
                                          , .Id,
                                          .Codigo,
                                          .Nombre,
                                          .Abreviatura,
                                          .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un tipo de movimiento de inventario,a travez del procedimiento almacenado
    ''' ALM.Isp_TipoMovimientoInventario_IAE,por el cual va a ser enviado el id del tipo de movimiento de inventario, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoMovimientoInventario">Recibe una variable oeTipoMovimientoInventario de tipo objeto e_TipoMovimientoInventario</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Eliminar(ByVal oeTipoMovimientoInventario As e_TipoMovimientoInventario) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("ALM.Isp_TipoMovimientoInventario_IAE", _
                                      "E", _
                                      "", _
                                      oeTipoMovimientoInventario.Id)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function
End Class
