Imports ISL.EntidadesWCF
''' <summary>
''' Clase que gestiona los diversos movimientos de entrada y salida del personal o empleados de la empresa
''' Fecha de Actualizacion:06/12/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla MovimientoPersonal,Capa del Sistema: Capa de Acceso a Datos.</remarks>
Public Class d_MovimientoPersonal

    Private oeMovimientoPersonal As New e_MovimientoPersonal
    Private sqlhelper As New SqlHelper

    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_MovimientoPersonal y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:06/12/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeMovimientoPersonal) de tipo e_MovimientoPersonal</returns>
    ''' <remarks>Capa del Sistema:Capa Datos</remarks>
    Private Function Cargar(ByVal o_fila As DataRow) As e_MovimientoPersonal
        Try
            Dim oeMovimientoPersonal = New e_MovimientoPersonal( _
                 o_fila("Id").ToString _
                 , o_fila("IdTrabajador").ToString _
                 , o_fila("ApellidoPaterno").ToString _
                 , o_fila("ApellidoMaterno").ToString _
                 , o_fila("Nombre").ToString _
                 , o_fila("FechaInicio").ToString _
                 , o_fila("Dias").ToString _
                 , o_fila("FechaFin").ToString _
                 , o_fila("Retorno").ToString _
                 , o_fila("FechaRetorno").ToString _
                 , o_fila("IdSituacionAdministrativa").ToString _
                 , o_fila("Situacion").ToString _
                 , o_fila("Observacion").ToString _
                 , o_fila("Activo").ToString _
                 , o_fila("FechaCreacion").ToString _
                 , o_fila("UsuarioCreacion").ToString _
)
            If Not IsDate(o_fila("FechaRetorno")) Then
                oeMovimientoPersonal.FechaRetorno = Date.Now
            End If
            Return oeMovimientoPersonal
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene un MovimientoPersonal de establecimiento, el cual es consultado por el procedimiento almacenado PER.Isp_MovimientoPersonal_Listar
    ''' enviando su id del MovimientoPersonal.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_MovimientoPersonal.
    ''' Fecha de Actualizacion:06/12/2011
    ''' </summary>
    ''' <param name="oeMovimientoPersonal">Recibe una variable oeMovimientoPersonal de tipo e_MovimientoPersonal</param>
    ''' <returns>Devuelve una varible oeMovimientoPersonal de tipo e_MovimientoPersonal</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeMovimientoPersonal As e_MovimientoPersonal) As e_MovimientoPersonal
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_MovimientoPersonal_Listar", "", oeMovimientoPersonal.Id, oeMovimientoPersonal.IdTrabajador, oeMovimientoPersonal.IdSituacionAdministrativa, oeMovimientoPersonal.Activo)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeMovimientoPersonal = Cargar(ds.Tables(0).Rows(0))
            Else
                oeMovimientoPersonal = New e_MovimientoPersonal
            End If
            Return oeMovimientoPersonal
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_MovimientoPersonal, el cual es consultado por el procedimiento almacenado PER.Isp_MovimientoPersonal_Listar
    ''' enviando sus atributos del MovimientoPersonal.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:06/12/2011
    ''' </summary>
    ''' <param name="oeMovimientoPersonal">Recibe una Variable oeMovimientoPersonal de tipo e_MovimientoPersonal </param>
    ''' <returns>Devuelve una lista generica(lista) de objetos de tipo e_MovimientoPersonal</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeMovimientoPersonal As e_MovimientoPersonal) As List(Of e_MovimientoPersonal)
        Try
            Dim ldMovimientoPersonal As New List(Of e_MovimientoPersonal)
            Dim ds As DataSet
            With oeMovimientoPersonal
                ds = sqlhelper.ExecuteDataset("PER.Isp_MovimientoPersonal_Listar", "" _
                                        , .Id _
                                        , .IdTrabajador _
                                        , .IdSituacionAdministrativa _
                                        , .Activo _
                                        , .Retorno _
                                       , .FechaDesde, _
                                        .FechaHasta)

                If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                    For Each fila As DataRow In ds.Tables(0).Rows
                        oeMovimientoPersonal = Cargar(fila)
                        ldMovimientoPersonal.Add(oeMovimientoPersonal)
                    Next
                End If
            End With
            Return ldMovimientoPersonal

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que se encargara de registrar los datos del MovimientoPersonal,a travez del procedimiento almacenado
    ''' PER.Isp_MovimientoPersonal_IAE,por el cual van a ser enviados y registrados los datos del MovimientoPersonal y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:06/12/2011
    ''' </summary>
    ''' <param name="oeMovimientoPersonal">Recibe una variable oeMovimientoPersonal de tipo e_MovimientoPersonal</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro de 
    ''' MovimientoPersonal es positiva= true sino false Capa del Sistema:Capa Datos</remarks>
    Public Function Guardar(ByVal oeMovimientoPersonal As e_MovimientoPersonal) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeMovimientoPersonal
                sqlhelper.ExecuteNonQuery("PER.Isp_MovimientoPersonal_IAE", _
                                          .TipoOperacion, _
                                          d_DatosConfiguracion.PrefijoID, _
                                        .Id _
                                        , .IdTrabajador _
                                        , .IdSituacionAdministrativa _
                                        , .FechaInicio _
                                        , .NroDias _
                                        , .FechaFin _
                                        , .Retorno _
                                        , .FechaRetorno _
                                        , .Observacion _
                                        , .UsuarioCreacion _
                                        , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro de MovimientoPersonal,a travez del procedimiento almacenado
    ''' PER.Isp_MovimientoPersonal_IAE,por el cual va a ser enviado el id del MovimientoPersonal a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:06/12/2011
    ''' </summary>
    ''' <param name="oeMovimientoPersonal">Recibe una variable oeMovimientoPersonal de tipo objeto e_MovimientoPersonal</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Eliminar(ByVal oeMovimientoPersonal As e_MovimientoPersonal) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_MovimientoPersonal_IAE", _
                                      "E", _
                                        "", _
                                        oeMovimientoPersonal.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class

