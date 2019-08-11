Imports ISL.EntidadesWCF
''' <summary>
''' Clase que indica los tipos de orden compra que se requieren por ejemplo: orden de compra normal,
''' orden de compra por consignacion,etc.  
''' Fecha Actualizada:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla Tipo Orden Compra,Capa del Sistema:Capa de Acceso a Datos</remarks>


Public Class d_TipoOrdenCompra

    Private sqlhelper As New SqlHelper

    Private oetipoOrdenCompra As e_TipoOrdenCompra

    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_TipoOrdenCompra y enviada al metodo que lo utilizo.
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeTipoPago) de tipo e_TipoOrdenCompra</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Private Function Cargar(ByVal o_fila As DataRow) As e_TipoOrdenCompra
        Try
            Dim oeTipoPago = New e_TipoOrdenCompra( _
            o_fila("Id"), o_fila("Codigo"), o_fila("Nombre"), o_fila("Abreviatura"), _
            o_fila("Activo"))
            Return oeTipoPago
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    ''' <summary>
    ''' Metodo que obtiene un tipo orden de compra, el cual es consultado por el procedimiento almacenado CMP.ISP_TipoOrdenCompra_Listar
    ''' enviando su id del tipo orden de compra.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo oeTipoPago.
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoPago">Recibe una variable oeTipoPago de tipo e_TipoOrdenCompra</param>
    ''' <returns>Devuelve una varible oeTipoPago de tipo e_TipoOrdenCompra</returns>
    ''' <remarks>Si el dataset ds no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeTipoPago As e_TipoOrdenCompra) As e_TipoOrdenCompra
        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("CMP.ISP_TipoOrdenCompra_Listar", "", oeTipoPago.Id)
            If ds.Tables.Count > 0 Then
                oeTipoPago = Cargar(ds.Tables(0).Rows(0))
                Return oeTipoPago
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_TipoOrdenCompra, el cual es consultado por el procedimiento almacenado CMP.ISP_TipoOrdenCompra_Listar
    ''' enviando sus atributos del tipo de documento.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' </summary>
    ''' <param name="oeTipoPago">Recibe una Variable oeTipoPago  de tipo e_TipoOrdenCompra </param>
    ''' <returns>Devuelve una lista generica(ldTipoMantenimiento) de objetos de tipo e_TipoOrdenCompra </returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeTipoPago As e_TipoOrdenCompra) As List(Of e_TipoOrdenCompra)
        Try
            Dim ldTipoMantenimiento As New List(Of e_TipoOrdenCompra)
            Dim ds As DataSet
            With oeTipoPago
                ds = SqlHelper.ExecuteDataset("CMP.ISP_TipoOrdenCompra_Listar", "", .Id, .Codigo, _
                        .Nombre, .Abreviatura, .Activo)
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
    ''' Metodo que se encargara de registrar los datos del tipo de orden de compra,a travez del procedimiento almacenado
    ''' CMP.Isp_TipoOrdenCompra_IAE,por el cual van a ser enviados y registrados los datos del tipo de orden de compra y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoPago">Recibe una variable oeTipoPago de tipo e_TipoOrdenCompra </param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro de tipo 
    ''' de documento es positiva= true sino false Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeTipoPago As e_TipoOrdenCompra) As Boolean
        Dim d_DatosConfiguracion As New d_DatosConfiguracion

        Try
            With oeTipoPago
                SqlHelper.ExecuteNonQuery("CMP.Isp_TipoOrdenCompra_IAE", .TipoOperacion, _
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
    ''' Metodo que se encargara de desactivar un regitro del tipo de orden de compra,a travez del procedimiento almacenado
    ''' CMP.Isp_TipoOrdenCompra_IAE,por el cual va a ser enviado el id del tipo de orden de compra a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoPago">Recibe una variable oeTipoDocumento de tipo objeto e_TipoDocumento</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Eliminar(ByVal oeTipoPago As e_TipoOrdenCompra) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("CMP.Isp_TipoOrdenCompra_IAE", "E", "", _
                                      oeTipoPago.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
