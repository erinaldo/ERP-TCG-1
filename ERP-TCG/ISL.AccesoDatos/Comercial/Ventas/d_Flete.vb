'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions
''' <summary>
''' Clase que gestiona el flete de la empresa
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla Flete,Capa del Sistema: Capa de Acceso a Datos.</remarks>
Public Class d_Flete

    Private sqlhelper As New SqlHelper

    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_Flete y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeFlete) de tipo e_Flete</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Cargar(ByVal o_fila As DataRow) As e_Flete
        Try
            Dim oeFlete = New e_Flete( _
                             o_fila("Id").ToString _
                             , o_fila("IdRuta").ToString _
                             , o_fila("TipoVehiculo").ToString _
                             , o_fila("Cliente").ToString _
                             , o_fila("TipoCarga").ToString _
                             , o_fila("Estimado").ToString _
                             , o_fila("DescripcionEstimado").ToString _
                             , o_fila("Contrato").ToString _
                             , o_fila("DescripcionContrato").ToString _
                             , o_fila("Tecnico").ToString _
                             , o_fila("DescripcionTecnico").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeFlete
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene un flete, el cual es consultado por el procedimiento almacenado XXX.ISP_XXXXXX_Listar
    ''' enviando su id del flete.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_Flete.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeFlete">Recibe una variable oeFlete de tipo e_Flete</param>
    ''' <returns>Devuelve una varible oeFlete de tipo e_Flete</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeFlete As e_Flete) As e_Flete
        Try
            Dim ds As DataSet
            With oeFlete
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_Flete_Listar]", _
                                                        .TipoOperacion _
                                                        , .Id _
                                                        , .IdRuta _
                                                        , .TipoVehiculo _
                                                        , .Cliente _
                                                        , .TipoCarga)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeFlete = Cargar(ds.Tables(0).Rows(0))
            Else
                oeFlete = New e_Flete
            End If
            Return oeFlete
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_Flete, el cual es consultado por el procedimiento 
    ''' almacenadoXXX.ISP_XXXXXX_Listar enviando sus atributos del flete.Una vez obtenido los registros son cargados y 
    ''' devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeFlete">Recibe una Variable oeFlete de tipo e_Flete </param>
    ''' <returns>Devuelve una lista generica(ldFlete) de objetos de tipo e_Flete</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeFlete As e_Flete) As List(Of e_Flete)
        Try
            Dim ldFlete As New List(Of e_Flete)
            Dim ds As DataSet
            With oeFlete
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_Flete_Listar]", _
                                                 .TipoOperacion _
                                                , .Id _
                                                , .IdRuta _
                                                , .TipoVehiculo _
                                                , .Cliente _
                                                , .TipoCarga)
            End With
            oeFlete = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeFlete = Cargar(o_Fila)
                    ldFlete.Add(oeFlete)
                Next
            Else
                ldFlete = New List(Of e_Flete)
            End If
            Return ldFlete
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los datos del flete,a travez del procedimiento almacenado
    ''' XXX.ISP_XXXXXXXXXXXXXXX_IAE,por el cual van a ser enviados y registrados los datos del flete y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeFlete">Recibe una variable oeFlete de tipo e_Flete</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro 
    ''' del flete es positiva= true sino false 
    '''Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeFlete As e_Flete) As Boolean
        Try
            With oeFlete
                sqlhelper.ExecuteNonQuery("[OPE].[Isp_Flete_IAE]",
                                          "I",
                                          .PrefijoID,
                                            .Id _
                                            , .IdRuta _
                                            , .TipoVehiculo _
                                            , .Cliente _
                                            , .TipoCarga _
                                            , .Estimado _
                                            , .DescripcionEstimado _
                                            , .Contrato _
                                            , .DescripcionContrato _
                                            , .Tecnico _
                                            , .DescripcionTecnico)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarTarifas(ByVal oeFlete As e_Flete) As DataTable
        Try
            Dim tabla As DataTable
            With oeFlete
                tabla = sqlhelper.ExecuteDataset("[OPE].[Isp_Flete_Listar]", _
                                                  .TipoOperacion, _
                                                  .Id, _
                                                  .IdRuta).Tables(0)
            End With
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro del flete,a travez del procedimiento almacenado
    ''' XXX.ISP_XXXXXXXXXXXXXXX_IAE,por el cual va a ser enviado el id del cliente a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeFlete">Recibe una variable oeFlete de tipo objeto e_Flete</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Eliminar(ByVal oeFlete As e_Flete) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[OPE].[Isp_Flete_IAE]", _
                                     "E", _
                                      "", _
                                      oeFlete.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class

