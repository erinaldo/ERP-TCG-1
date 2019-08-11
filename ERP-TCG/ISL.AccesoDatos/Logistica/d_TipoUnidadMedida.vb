Imports ISL.EntidadesWCF
''' <summary>
''' Clase que se encarga de gestionar las unidades de medidad de los articulos en almacen 
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla TipoUnidadMedida,Capa del Sistema: Capa de Acceso a Datos.</remarks>

Public Class d_TipoUnidadMedida
    Private sqlhelper As New SqlHelper

    Private oeTipoUnidadMedida As New e_TipoUnidadMedida
    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_TipoUnidadMedida y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeTipoUnidadMedida) de tipo e_TipoUnidadMedida</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Cargar(ByVal fila As DataRow) As e_TipoUnidadMedida
        Try
            oeTipoUnidadMedida = New e_TipoUnidadMedida( _
                                                        fila("Id"), _
                                                        fila("Codigo"), _
                                                        fila("Nombre"), _
                                                        fila("Abreviatura"), _
                                                        fila("Activo"))
            Return oeTipoUnidadMedida
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una unidad de medida, el cual es consultado por el procedimiento almacenado ALM.Isp_TipoUnidadMedida_Listar
    ''' enviando su id del tipo de unidad de medida.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_TipoUnidadMedida.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoUnidadMedida">Recibe una variable oeTipoUnidadMedida de tipo e_TipoUnidadMedida</param>
    ''' <returns>Devuelve una varible oeTipoUnidadMedida de tipo e_TipoUnidadMedida</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Obtener(ByVal oeTipoUnidadMedida As e_TipoUnidadMedida) As e_TipoUnidadMedida
        Try
            Dim ds As New DataSet
            With oeTipoUnidadMedida
                ds = sqlhelper.ExecuteDataset("ALM.Isp_TipoUnidadMedida_Listar", _
                                              "", _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Abreviatura)
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeTipoUnidadMedida = Cargar(ds.Tables(0).Rows(0))
            Else
                oeTipoUnidadMedida = New e_TipoUnidadMedida
            End If
            Return oeTipoUnidadMedida
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_TipoUnidadMedida, el cual es consultado por el procedimiento almacenado ALM.Isp_TipoUnidadMedida_Listar
    ''' enviando sus atributos de la unidad de medida.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoUnidadMedida">Recibe una Variable oeTipoUnidadMedida de tipo e_TipoUnidadMedida</param>
    ''' <returns>Devuelve una lista generica(lista) de objetos de tipo e_TipoUnidadMedida</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Listar(ByVal oeTipoUnidadMedida As e_TipoUnidadMedida) As List(Of e_TipoUnidadMedida)
        Try
            Dim ds As New DataSet
            Dim lista As New List(Of e_TipoUnidadMedida)
            With oeTipoUnidadMedida
                ds = sqlhelper.ExecuteDataset("ALM.Isp_TipoUnidadMedida_Listar", _
                                              "", _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Abreviatura, _
                                              .Activo)
            End With
            If ds.Tables.Count > 0 Then
                For Each fila As DataRow In ds.Tables(0).Rows
                    oeTipoUnidadMedida = Cargar(fila)
                    lista.Add(oeTipoUnidadMedida)
                Next
                '    Return lista
                'Else
                '    Return Nothing
            End If
            Return lista
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar la unidad de medida,a travez del procedimiento almacenado
    ''' ALM.Isp_TipoUnidadMedida_IAE,por el cual van a ser enviados y registrados los datos del tipo de material y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoUnidadMedida">Recibe una variable oeTipoUnidadMedida de tipo e_TipoUnidadMedida </param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro 
    ''' de tipo de documento es positiva= true sino false Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Guardar(ByVal oeTipoUnidadMedida As e_TipoUnidadMedida) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            With oeTipoUnidadMedida
                sqlhelper.ExecuteNonQuery("ALM.Isp_TipoUnidadMedida_IAE", _
                                          .TipoOperacion, _
                                          d_DatosConfiguracion.PrefijoID _
                                          , .Id, _
                                          .Codigo, _
                                          .Nombre, _
                                          .Abreviatura, _
                                          .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar una unidad de medida,a travez del procedimiento almacenado
    ''' ALM.Isp_TipoUnidadMedida_IAE,por el cual va a ser enviado el id de la unidad de medida, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoUnidadMedida">Recibe una variable oeTipoUnidadMedida de tipo objeto e_TipoUnidadMedida</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Eliminar(ByVal oeTipoUnidadMedida As e_TipoUnidadMedida) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("ALM.Isp_TipoUnidadMedida_IAE", _
                                      "E", _
                                      "", _
                                      oeTipoUnidadMedida.Id)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function
End Class
