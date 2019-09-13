Imports ISL.EntidadesWCF
Public Class d_EstadoOrden
    Private sqlhelper As New SqlHelper

    Private oeEstadoOrden As New e_EstadoOrden
    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_EstadoOrden y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeEstadoOrden) de tipo e_EstadoOrden</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Cargar(ByVal fila As DataRow) As e_EstadoOrden
        Try
            Dim oeEstadoOrden = New e_EstadoOrden(fila("Id"), _
                                                  fila("Nombre"), _
                                                  fila("Activo"))
            Return oeEstadoOrden
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene un tipo de material, el cual es consultado por el procedimiento almacenado ALM.Isp_EstadoOrden_Listar
    ''' enviando su id del tipo de material.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_EstadoOrden.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeEstadoOrden">Recibe una variable oeEstadoOrden de tipo e_EstadoOrden</param>
    ''' <returns>Devuelve una varible oeEstadoOrden de tipo e_EstadoOrden</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Obtener(ByVal oeEstadoOrden As e_EstadoOrden) As e_EstadoOrden
        Try
            Dim ds As New DataSet
            With oeEstadoOrden
                ds = sqlhelper.ExecuteDataset("ALM.Isp_EstadoOrden_Listar", _
                                              "", _
                                              .Id, _
                                              .Nombre)
            End With

            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeEstadoOrden = Cargar(ds.Tables(0).Rows(0))
            Else
                oeEstadoOrden = New e_EstadoOrden
            End If
            Return oeEstadoOrden
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_EstadoOrden, el cual es consultado por el procedimiento almacenado ALM.Isp_EstadoOrden_Listar
    ''' enviando sus atributos del tipo de material.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeEstadoOrden">Recibe una Variable oeEstadoOrden de tipo e_EstadoOrden</param>
    ''' <returns>Devuelve una lista generica(lista) de objetos de tipo e_EstadoOrden</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Listar(ByVal oeEstadoOrden As e_EstadoOrden) As List(Of e_EstadoOrden)
        Try
            Dim ds As New DataSet
            Dim lista As New List(Of e_EstadoOrden)
            With oeEstadoOrden
                ds = sqlhelper.ExecuteDataset("ALM.Isp_EstadoOrden_Listar", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .Nombre, _
                                              .Activo)
                If ds.Tables.Count > 0 Then
                    For Each fila As DataRow In ds.Tables(0).Rows
                        oeEstadoOrden = Cargar(fila)
                        lista.Add(oeEstadoOrden)
                    Next
                    '    Return lista
                    'Else
                    '    Return Nothing
                End If
                Return lista
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los tipos de material,a travez del procedimiento almacenado
    ''' ALM.Isp_EstadoOrden_IAE,por el cual van a ser enviados y registrados los datos del tipo de material y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeEstadoOrden">Recibe una variable oeEstadoOrden de tipo e_EstadoOrden </param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro 
    ''' de tipo de documento es positiva= true sino false Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Guardar(ByVal oeEstadoOrden As e_EstadoOrden) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            With oeEstadoOrden
                sqlhelper.ExecuteNonQuery("ALM.Isp_EstadoOrden_IAE", _
                                          .TipoOperacion, _
                                          .PrefijoID, _
                                          .Id, _
                                          .Nombre, _
                                          .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un tipo de material,a travez del procedimiento almacenado
    ''' ALM.Isp_EstadoOrden_IAE,por el cual va a ser enviado el id del tipo de material a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeEstadoOrden">Recibe una variable oeEstadoOrden de tipo objeto e_EstadoOrden</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Eliminar(ByVal oeEstadoOrden As e_EstadoOrden) As Boolean
        Try
            With oeEstadoOrden
                sqlhelper.ExecuteNonQuery("ALM.Isp_EstadoOrden_IAE", _
                                          "E", _
                                          "", _
                                          .Id)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
