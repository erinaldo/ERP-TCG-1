Imports ISL.EntidadesWCF
''' <summary>
''' Clase que gestiona los detalles de tipo de gastos.
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla TipoGastoDetalle,Capa del Sistema: Capa de Acceso a Datos.</remarks>

Public Class d_TipoGastoDetalle
    Private sqlhelper As New SqlHelper

    Private oeTipoGastoDetalle As e_TipoGastoDetalle

    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_TipoGastoDetalle y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeTipoGastodetalle) de tipo e_TipoGastoDetalle</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Private Function Cargar(ByVal o_fila As DataRow) As e_TipoGastoDetalle
        Try
            Dim oeTipoGastodetalle = New e_TipoGastoDetalle( _
            o_fila("Id"), o_fila("IdTipoGasto"), o_fila("IdFlujoGasto"), o_fila("FlujoGasto"), o_fila("Activo"))
            Return oeTipoGastodetalle
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    ''' <summary>
    ''' Metodo que obtiene un detalle de tipo de gasto, el cual es consultado por el procedimiento almacenado TES.Isp_TipoGastoDetalle_Listar
    ''' enviando su id del detalle del tipo de gasto.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_TipoGastoDetalle.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoGastodetalle">Recibe una variable oeTipoGastodetalle de tipo e_TipoGastoDetalle</param>
    ''' <returns>Devuelve una varible oeTipoGastodetalle de tipo e_TipoGastoDetalle</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeTipoGastodetalle As e_TipoGastoDetalle) As e_TipoGastoDetalle
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_TipoGastoDetalle_Listar", oeTipoGastodetalle.TipoOperacion, oeTipoGastodetalle.Id)
            If ds.Tables.Count > 0 Then
                oeTipoGastodetalle = Cargar(ds.Tables(0).Rows(0))
                Return oeTipoGastodetalle
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
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

    Public Function Listar(ByVal oeTipoGastodetalle As e_TipoGastoDetalle) As List(Of e_TipoGastoDetalle)
        Try
            Dim ldTipoGastodetalle As New List(Of e_TipoGastoDetalle)
            Dim ds As DataSet
            With oeTipoGastodetalle
                ds = sqlhelper.ExecuteDataset("TES.Isp_TipoGastoDetalle_Listar", oeTipoGastodetalle.TipoOperacion, .Id, .IdTipoGasto, _
                        .IdFlujoCaja, .Activo)
            End With
            oeTipoGastodetalle = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTipoGastodetalle = Cargar(o_Fila)
                    ldTipoGastodetalle.Add(oeTipoGastodetalle)
                Next
                Return ldTipoGastodetalle
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los datos del detalle tipo de gastos ,a travez del procedimiento almacenado
    ''' TES.Isp_TipoGastoDetalle_IAE,por el cual van a ser enviados y registrados los datos del detalle de tipo de gastos y
    ''' obtendremos una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoGastoDetalle">Recibe una variable oeTipoGastoDetalle de tipo e_TipoGastoDetalle</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I",Si la confirmacion del registro de
    '''  tipo de gasto es positiva= true sino false Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeTipoGastoDetalle As e_TipoGastoDetalle) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            With oeTipoGastoDetalle
                sqlhelper.ExecuteNonQuery("TES.Isp_TipoGastoDetalle_IAE", "I", _
                .Id, .IdTipoGasto, .IdFlujoCaja, .Activo, d_DatosConfiguracion.PrefijoID)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro del detalle tipo de gasto,a travez del procedimiento almacenado
    ''' TES.Isp_TipoGastoDetalle_IAE,por el cual va a ser enviado el id del detalle tipo de gasto a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoGasto">Recibe una variable oeTipoGasto de tipo objeto e_TipoGastoDetalle</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Eliminar(ByVal oeTipoGasto As e_TipoGastoDetalle) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("TES.Isp_TipoGastoDetalle_IAE", "E", oeTipoGasto.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
