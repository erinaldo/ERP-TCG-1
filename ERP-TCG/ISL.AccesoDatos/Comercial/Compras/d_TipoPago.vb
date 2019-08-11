Imports ISL.EntidadesWCF
''' <summary>
''' Clase que indica los tipos de pago al realizar una compra que se requieren por ejemplo: contado,credito,etc.  
''' Fecha Actualizada:31/10/2011.
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla Tipo de Pago,Capa del Sistema:Capa de Acceso a Datos</remarks>

Public Class d_TipoPago

    Private oetipoPago As e_TipoPago
    Private sqlhelper As New SqlHelper

    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_TipoPago y enviada al metodo que lo utilizo.
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeTipoDocumento) de tipo e_TipoDocumento</returns>
    ''' <remarks>Capa del Sistema:Capa del Sistema:Capa de Acceso a Datos</remarks>
    Private Function Cargar(ByVal o_fila As DataRow) As e_TipoPago
        Try
            Dim oeTipoPago = New e_TipoPago( _
            o_fila("Id"), o_fila("Codigo"), o_fila("Nombre"), o_fila("Abreviatura"), _
            o_fila("Activo"), o_fila("Dias"))
            Return oeTipoPago
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    ''' <summary>
    ''' Metodo que obtiene un tipo de pago, el cual es consultado por el procedimiento almacenado CMP.ISP_TipoPago_Listar
    ''' enviando su id del tipo de pago.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_TipoPago.
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoPago">Recibe una variable oeTipoPago de tipo e_TipoPago</param>
    ''' <returns>Devuelve una varible oetipoPago de tipo e_TipoPago</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeTipoPago As e_TipoPago) As e_TipoPago
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CMP.ISP_TipoPago_Listar", "", oeTipoPago.Id, oeTipoPago.Codigo, oeTipoPago.Nombre)
            If ds.Tables.Count > 0 Then
                oetipoPago = Cargar(ds.Tables(0).Rows(0))
                Return oetipoPago
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_TipoPago, el cual es consultado por el procedimiento almacenado CMP.ISP_TipoPago_Listar
    ''' enviando sus atributos del tipo de pago.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' </summary>
    ''' <param name="oeTipoPago">Recibe una Variable oeTipoPago de tipo e_TipoPago </param>
    ''' <returns>Devuelve una lista generica(ldTipoMantenimiento) de objetos de tipo e_TipoPago</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeTipoPago As e_TipoPago) As List(Of e_TipoPago)
        Try
            Dim ldTipoMantenimiento As New List(Of e_TipoPago)
            Dim ds As DataSet
            With oeTipoPago
                ds = sqlhelper.ExecuteDataset("CMP.ISP_TipoPago_Listar", .TipoOperacion, .Id, .Codigo, _
                        .Nombre, .Abreviatura, .Activo, .IdClienteProveedor, .TipoClienteProveedor)
            End With
            oeTipoPago = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTipoPago = Cargar(o_Fila)
                    ldTipoMantenimiento.Add(oeTipoPago)
                Next
                Return ldTipoMantenimiento
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los datos del tipo de pago,a travez del procedimiento almacenado
    ''' CMP.Isp_TipoPago_IAE,por el cual van a ser enviados y registrados los datos del tipo de pago y
    ''' obtendremos una respuesta de confirmacion del registro guardado.
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoPago">Recibe una variable oeTipoPago de tipo e_TipoPago</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro
    '''  de tipo de documento es positiva= true sino false Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeTipoPago As e_TipoPago) As Boolean
        Dim d_DatosConfiguracion As New d_DatosConfiguracion
        Try
            With oeTipoPago
                sqlhelper.ExecuteNonQuery("CMP.Isp_TipoPago_IAE", .TipoOperacion, _
                d_DatosConfiguracion.PrefijoID, .Id, .Codigo, .Nombre, .Abreviatura, _
                 .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro del tipo de pago,a travez del procedimiento almacenado
    ''' CMP.Isp_TipoPago_IAE,por el cual va a ser enviado el id del tipo de pago a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoPago">Recibe una variable oeTipoPago de tipo objeto e_TipoPago</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Eliminar(ByVal oeTipoPago As e_TipoPago) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("CMP.Isp_TipoPago_IAE", "E", "", _
                                      oeTipoPago.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
