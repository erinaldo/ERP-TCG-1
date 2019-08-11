Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient
''' <summary>
''' Clase que 
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla Tipo Orden Compra,Capa del Sistema: Capa de Acceso a Datos.</remarks>
Public Class d_ModeloFuncionalVehiculo
    Private sqlhelper As New SqlHelper


    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_ModeloFuncionalVehiculo y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeModeloFuncionalVehiculo) de tipo e_ModeloFuncionalVehiculo</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Cargar(ByVal o_fila As DataRow) As e_ModeloFuncionalVehiculo
        Try
            Dim oeModeloFuncionalVehiculo = New e_ModeloFuncionalVehiculo( _
                               o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeModeloFuncionalVehiculo
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene un modelo funcional del vehiculo, el cual es consultado por el procedimiento almacenado 
    ''' STD.Isp_ModeloFuncionalVehiculo_Listar enviando su id del modelo funcional del vehiculo.Una vez obtenido el 
    ''' registro consultado es cargado y devuelto en un objeto de tipo e_ModeloFuncionalVehiculo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeModeloFuncionalVehiculo">Recibe una variable oeModeloFuncionalVehiculo de tipo e_ModeloFuncionalVehiculo</param>
    ''' <returns>Devuelve una varible oeModeloFuncionalVehiculo de tipo e_ModeloFuncionalVehiculo</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeModeloFuncionalVehiculo As e_ModeloFuncionalVehiculo) As e_ModeloFuncionalVehiculo

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("STD.Isp_ModeloFuncionalVehiculo_Listar", "", oeModeloFuncionalVehiculo.Id)
            If ds.Tables.Count > 0 Then
                oeModeloFuncionalVehiculo = Cargar(ds.Tables(0).Rows(0))
                Return oeModeloFuncionalVehiculo
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de modelo funcional del vehiculo, el cual es consultado por el 
    ''' procedimiento almacenado STD.Isp_TipoDocumento_Listar enviando sus atributos del tipo de documento.Una vez obtenido
    ''' los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeModeloFuncionalVehiculo">Recibe una Variable oeModeloFuncionalVehiculo de tipo e_ModeloFuncionalVehiculo </param>
    ''' <returns>Devuelve una lista generica(ldModeloFuncionalVehiculo) de objetos de tipo e_ModeloFuncionalVehiculo</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeModeloFuncionalVehiculo As e_ModeloFuncionalVehiculo) As List(Of e_ModeloFuncionalVehiculo)
        Try
            Dim ldModeloFuncionalVehiculo As New List(Of e_ModeloFuncionalVehiculo)
            Dim ds As DataSet
            With oeModeloFuncionalVehiculo
                ds = SqlHelper.ExecuteDataset("STD.Isp_ModeloFuncionalVehiculo_Listar", "" _
                        , .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .Activo _
                        )
            End With
            oeModeloFuncionalVehiculo = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeModeloFuncionalVehiculo = Cargar(o_Fila)
                    ldModeloFuncionalVehiculo.Add(oeModeloFuncionalVehiculo)
                Next
                Return ldModeloFuncionalVehiculo
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los datos del modelo funcional del vehiculo,a travez del procedimiento almacenado
    ''' [STD].[Isp_ModeloFuncionalVehiculo_IAE],por el cual van a ser enviados y registrados los datos del modelo funcional del 
    ''' vehiculo y obtendremos una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeModeloFuncionalVehiculo">Recibe una variable oeModeloFuncionalVehiculo de tipo e_ModeloFuncionalVehiculo</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro del modelo
    ''' funcional del vehiculo es positiva= true sino false 
    '''Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeModeloFuncionalVehiculo As e_ModeloFuncionalVehiculo) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            With oeModeloFuncionalVehiculo
                sqlhelper.ExecuteNonQuery("[STD].[Isp_ModeloFuncionalVehiculo_IAE]", .TipoOperacion, d_DatosConfiguracion.PrefijoID _
                        , .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro del modelo funcional del vehiculo,a travez del procedimiento almacenado
    ''' ,por el cual va a ser enviado el id del modelo funcional vehicular a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeModeloFuncionalVehiculo">Recibe una variable oeModeloFuncionalVehiculo de tipo objeto e_ModeloFuncionalVehiculo</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Eliminar(ByVal oeModeloFuncionalVehiculo As e_ModeloFuncionalVehiculo) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("[STD].[Isp_ModeloFuncionalVehiculo_IAE]", oeModeloFuncionalVehiculo.TipoOperacion, _
             "", oeModeloFuncionalVehiculo.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
