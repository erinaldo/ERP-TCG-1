Imports ISL.EntidadesWCF
Imports System.Transactions
''' <summary>
''' Clase que gestiona los diferentes tipos de gastos que se presentan en tesoreria.  
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla TipoGasto,Capa del sistema:Capa de Acceso a Datos</remarks>
Public Class d_TipoGasto
    Private sqlhelper As New SqlHelper

    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_TipoGasto y enviada al metodo que lo utilizo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeTipoGasto) de tipo e_TipoGasto </returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Cargar(ByVal o_fila As DataRow) As e_TipoGasto
        Try
            Dim oeTipoGasto = New e_TipoGasto( _
                                o_fila("Id"), _
                                o_fila("Codigo"), _
                                o_fila("Nombre"), _
                                o_fila("Abreviatura"), _
                                o_fila("Activo"), _
                                o_fila("UsuarioCreacion"))
            Return oeTipoGasto
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene un tipo de gasto, el cual es consultado por el procedimiento almacenado TES.Isp_TipoGasto_Listar
    ''' enviando su id del tipo de pago.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_TipoGasto.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoGasto">Recibe una variable oeTipoGasto de tipo e_TipoGasto</param>
    ''' <returns>Devuelve una varible oeTipoGasto de tipo e_TipoGasto</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeTipoGasto As e_TipoGasto) As e_TipoGasto
        Try
            Dim ds As New Data.DataSet
            With oeTipoGasto
                ds = sqlhelper.ExecuteDataset("TES.Isp_TipoGasto_ListarCD", "", .Id, .Codigo, .Nombre, .Abreviatura, .Activo)
            End With
            oeTipoGasto = New e_TipoGasto
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeTipoGasto = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeTipoGasto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar2(ByVal oeTipoGasto As e_TipoGasto) As List(Of e_TipoGasto)
        Try
            Dim ldTipoGasto As New List(Of e_TipoGasto)
            Dim ds As DataSet
            With oeTipoGasto
                ds = sqlhelper.ExecuteDataset("TES.Isp_TipoGasto_Listar", "", .Id, .Codigo, _
                        .Nombre, .Abreviatura, .Activo)
            End With
            oeTipoGasto = Nothing
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTipoGasto = Cargar(o_Fila)
                    ldTipoGasto.Add(oeTipoGasto)
                Next
            End If
            Return ldTipoGasto
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    ''' <summary>
    ''' Metodo que obtiene un dataset de objetos de tipo e_TipoGasto, el cual es consultado por el procedimiento almacenado TES.Isp_TipoGasto_ListarCD
    ''' enviando sus atributos del tipo de gasto.Una vez obtenido los registros son devueltos en un dataset.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoGasto">Recibe una Variable oeTipoGasto de tipo e_TipoGasto</param>
    ''' <returns>Devuelve un dataset</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeTipoGasto As e_TipoGasto) As DataSet
        Try
            Dim ds As DataSet
            With oeTipoGasto
                ds = sqlhelper.ExecuteDataset("TES.Isp_TipoGasto_ListarCD", "", .Id, .Codigo, _
                            .Nombre, .Abreviatura, .Activo)
                Return ds
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_TipoGastoDetalle, el cual es consultado por el procedimiento almacenado TES.Isp_TipoGastoDetalle_Listar
    ''' enviando sus atributos del detalle del tipo de gasto.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoGastoDetalle">Recibe una Variable oeTipoGasto de tipo </param>
    ''' <returns>Devuelve una lista generica(ldTipoGastoDetalle) de objetos de tipo e_TipoGastoDetalle</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function ListarDetalle(ByVal oeTipoGastoDetalle As e_TipoGastoDetalle) As List(Of e_TipoGastoDetalle)
        Try
            Dim ldTipoGastoDetalle As New List(Of e_TipoGastoDetalle)
            Dim ds As DataSet
            With oeTipoGastoDetalle
                ds = SqlHelper.ExecuteDataset("TES.Isp_TipoGastoDetalle_Listar", "" _
                        , .Id _
                        , .IdTipoGasto _
                        , .IdFlujoCaja _
                        , .Activo)
            End With
            oeTipoGastoDetalle = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTipoGastoDetalle = CargarDetalle(o_Fila)
                    ldTipoGastoDetalle.Add(oeTipoGastoDetalle)
                Next
                Return ldTipoGastoDetalle
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_TipoGastoDetalle y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeTipoGastoDetalle) de tipo e_TipoGastoDetalle</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Private Function CargarDetalle(ByVal o_fila As DataRow) As e_TipoGastoDetalle
        Try
            Dim oeTipoGastoDetalle = New e_TipoGastoDetalle(o_fila("Id"), _
                                o_fila("IdTipoGasto"), _
                                o_fila("IdFlujoGasto"), _
                                o_fila("FlujoGasto"), _
                                o_fila("Activo"))
            Return oeTipoGastoDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los datos del tipo de gastos ,a travez del procedimiento almacenado
    ''' TES.Isp_TipoGasto_IAE,por el cual van a ser enviados y registrados los datos del tipo de gastos y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoGasto">Recibe una variable oeTipoGasto de tipo e_TipoGasto</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro de
    '''  tipo de gasto es positiva= true sino false Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeTipoGasto As e_TipoGasto) As Boolean
        Dim stResultado() As String
        Dim d_DatosConfiguracion As New d_DatosConfiguracion

        Try
            Using transScope As New TransactionScope()
                With oeTipoGasto
                    stResultado = SqlHelper.ExecuteScalar("TES.Isp_TipoGasto_IAE", _
                                                          .TipoOperacion, _
                                                          "A", _
                                                          .Id, _
                                                          .Codigo, _
                                                          .Nombre, _
                                                          .Abreviatura, _
                                                          .Activo, _
                                                          .Usuario, _
                                                          .PrefijoID).ToString.Split("_")
                End With
                For Each Detalle As e_TipoGastoDetalle In oeTipoGasto.oeTipoGastoDetalle
                    Detalle.IdTipoGasto = stResultado(0)
                    GuardarDetalle(Detalle)
                Next
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los datos detalles del tipo de gastos ,a travez del procedimiento almacenado
    ''' TES.Isp_TipoGastoDetalle_IAE,por el cual van a ser enviados y registrados los detalles del tipo de gastos y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoGastoDetalle">Recibe una variable oeTipoGasto de tipo e_TipoGasto</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I",Si la confirmacion del registro del
    ''' detalle tipo de gasto es positiva= true, si hay una excepcion el valor sera false,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function GuardarDetalle(ByVal oeTipoGastoDetalle As e_TipoGastoDetalle) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            With oeTipoGastoDetalle
                sqlhelper.ExecuteNonQuery("TES.Isp_TipoGastoDetalle_IAE", "I", _
                                          .Id, _
                                          .IdTipoGasto, _
                                          .IdFlujoCaja, _
                                          .Activo, _
                                          .PrefijoID)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro del tipo de gasto,a travez del procedimiento almacenado
    ''' TES.Isp_TipoGasto_IAE,por el cual va a ser enviado el id del tipo de gasto a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoGasto">Recibe una variable oeTipoGasto de tipo objeto e_TipoGasto</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Eliminar(ByVal oeTipoGasto As e_TipoGasto) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_TipoGasto_IAE", oeTipoGasto.TipoOperacion, "", oeTipoGasto.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
