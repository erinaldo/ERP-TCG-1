Imports ISL.EntidadesWCF
''' <summary>
''' Clase que se encarga de gestionar las unidades de medidad de los articulos en almacen 
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla UnidadMedida,Capa del Sistema: Capa de Acceso a Datos.</remarks>

Public Class d_UnidadMedida
    Private sqlhelper As New SqlHelper

    Private oeUnidadMedida As New e_UnidadMedida
    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_UnidadMedida y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeUnidadMedida) de tipo e_UnidadMedida</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Cargar(ByVal fila As DataRow) As e_UnidadMedida
        Try
            oeUnidadMedida = New e_UnidadMedida( _
                                                fila("Id"), _
                                                fila("Codigo"), _
                                                fila("Nombre"), _
                                                fila("Abreviatura"), _
                                                fila("Activo"), _
                                                fila("IdTipoUnidadMedida"), _
                                                fila("Factor"), _
                                                fila("Base"), _
                                                fila("NombreTipoUnidadMedida"))
            Return oeUnidadMedida
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una unidad de medida, el cual es consultado por el procedimiento almacenado ALM.Isp_UnidadMedida_Listar
    ''' enviando su id del tipo de unidad de medida.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_UnidadMedida.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeUnidadMedida">Recibe una variable oeUnidadMedida de tipo e_UnidadMedida</param>
    ''' <returns>Devuelve una varible oeUnidadMedida de tipo e_UnidadMedida</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Obtener(ByVal oeUnidadMedida As e_UnidadMedida) As e_UnidadMedida
        Try
            Dim ds As DataSet
            With oeUnidadMedida
                'ds = sqlhelper.ExecuteDataset("ALM.Isp_UnidadMedida_Listar", "", .Id, .Codigo, .Nombre, .Abreviatura)
                ds = sqlhelper.ExecuteDataset("ALM.Isp_UnidadMedida_Listar", _
                                              "", _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Abreviatura)
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeUnidadMedida = Cargar(ds.Tables(0).Rows(0))
            Else
                oeUnidadMedida = New e_UnidadMedida
            End If
            Return oeUnidadMedida
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_UnidadMedida, el cual es consultado por el procedimiento almacenado ALM.Isp_UnidadMedida_Listar
    ''' enviando sus atributos de la unidad de medida.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeUnidadMedida">Recibe una Variable oeUnidadMedida de tipo e_UnidadMedida</param>
    ''' <returns>Devuelve una lista generica(lista) de objetos de tipo e_UnidadMedida</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Listar(ByVal oeUnidadMedida As e_UnidadMedida) As List(Of e_UnidadMedida)
        Try
            Dim ds As New DataSet
            Dim lista As New List(Of e_UnidadMedida)
            With oeUnidadMedida
                ds = sqlhelper.ExecuteDataset("ALM.Isp_UnidadMedida_Listar", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Abreviatura, _
                                              .Activo, _
                                              .IdTipoUnidadMedida, _
                                              .Factor, _
                                              .Base, _
                                              .Asignado)
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each fila As DataRow In ds.Tables(0).Rows
                    oeUnidadMedida = Cargar(fila)
                    lista.Add(oeUnidadMedida)
                Next
            End If
            Return lista
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarD(ByVal oeUnidadMedida As e_UnidadMedida) As DataSet
        Try
            With oeUnidadMedida
                'Return sqlhelper.ExecuteDataset("ALM.Isp_UnidadMedida_ListarD", "", .Id, .Codigo, .Nombre, .Abreviatura, _
                '                               True, .Activo, .Asignado)
                Return sqlhelper.ExecuteDataset("ALM.Isp_UnidadMedida_Listar", _
                                                "L", _
                                                .Id, _
                                                .Codigo, _
                                                .Nombre, _
                                                .Abreviatura, _
                                                .Activo, _
                                                .IdTipoUnidadMedida, _
                                                .Factor, _
                                                .Base, _
                                                .Asignado)

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que se encargara de registrar la unidad de medida,a travez del procedimiento almacenado
    ''' ALM.Isp_UnidadMedida_IAE,por el cual van a ser enviados y registrados los datos del tipo de material y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeUnidadMedida">Recibe una variable oeUnidadMedida de tipo e_UnidadMedida </param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro 
    ''' de tipo de documento es positiva= true sino false Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Guardar(ByVal oeUnidadMedida As e_UnidadMedida) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            With oeUnidadMedida
                sqlhelper.ExecuteNonQuery("ALM.Isp_UnidadMedida_IAE", _
                                          .TipoOperacion, _
                                          .PrefijoID, _
                                          .Id, _
                                          .Codigo, _
                                          .Nombre, _
                                          .Abreviatura, _
                                          .Activo, _
                                          .IdTipoUnidadMedida, _
                                          .Factor, _
                                          .Base, _
                                          .Asignado)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar una unidad de medida,a travez del procedimiento almacenado
    ''' ALM.Isp_UnidadMedida_IAE,por el cual va a ser enviado el id de la unidad de medida, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeUnidadMedida">Recibe una variable oeUnidadMedida de tipo objeto e_UnidadMedida</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Eliminar(ByVal oeUnidadMedida As e_UnidadMedida) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("ALM.Isp_UnidadMedida_IAE", _
                                      "E", _
                                      "", _
                                      oeUnidadMedida.Id)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function ComboGrilla(ByVal oeUnidadMedida As e_UnidadMedida)
        Try
            Dim ds = New DataTable
            ds.Columns.Add("Id")
            ds.Columns.Add("Nombre")
            For Each item As e_UnidadMedida In ListarUMR(oeUnidadMedida)
                Dim newRow As DataRow = ds.NewRow()
                newRow("Id") = item.Id
                newRow("Nombre") = item.Nombre
                ds.Rows.Add(newRow)
            Next
            If ds.Rows.Count = 0 Then Throw New Exception("Información no registrada")
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarUMR(ByVal oeUnidadMedida As e_UnidadMedida) As List(Of e_UnidadMedida)
        Try
            Dim ds As New DataSet
            Dim lista As New List(Of e_UnidadMedida)
            With oeUnidadMedida
                ds = sqlhelper.ExecuteDataset("ALM.Isp_UnidadMedida_Listar", _
                                              "", _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Abreviatura, _
                                              .Activo, _
                                              .IdTipoUnidadMedida)
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each fila As DataRow In ds.Tables(0).Rows
                    oeUnidadMedida = Cargar(fila)
                    lista.Add(oeUnidadMedida)
                Next
            End If
            Return lista
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
