Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient
''' <summary>
''' Clase que gestiona los requerimientos de las diferentes areas de la empresa de manera mas directa.
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla PreDemanda,Capa del Sistema: Capa de Acceso a Datos.</remarks>
Public Class d_DemandaRapida

    Private sqlhelper As New SqlHelper
    Dim odBitacora As New d_Bitacora
    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_DemandaRapida y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeDemandaRapida) de tipo e_DemandaRapida</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Cargar(ByVal o_fila As DataRow) As e_DemandaRapida
        Try
            Dim oeDemandaRapida = New e_DemandaRapida(o_fila("Seleccion").ToString, _
                                    o_fila("Id").ToString _
                                    , o_fila("Codigo").ToString _
                                    , o_fila("FechaAtendida").ToString _
                                    , "" _
                                    , "" _
                                    , "" _
                                    , "" _
                                    , o_fila("IdRuta").ToString _
                                    , o_fila("Ruta").ToString _
                                    , o_fila("UsuarioCreacion").ToString _
                                    , o_fila("Usuario").ToString _
                                    , o_fila("IdEstado").ToString _
                                    , o_fila("Estado").ToString _
                                    , o_fila("Activo").ToString _
                                    , o_fila("Observacion").ToString _
                                    , o_fila("IdDemanda").ToString _
                                    , o_fila("UsuarioModifica").ToString _
                                    , o_fila("Justificacion").ToString)
            Return oeDemandaRapida
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una demanda rapida, el cual es consultado por el procedimiento almacenado OPE.Isp_PreDemanda_Listar
    ''' enviando su id de la demanda rapida.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_DemandaRapida.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeDemandaRapida">Recibe una variable oeDemandaRapida de tipo e_DemandaRapida</param>
    ''' <returns>Devuelve una varible oeDemandaRapida de tipo e_DemandaRapida</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeDemandaRapida As e_DemandaRapida) As e_DemandaRapida
        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("OPE.Isp_PreDemanda_Listar", "0", oeDemandaRapida.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeDemandaRapida = Cargar(ds.Tables(0).Rows(0))
            Else
                oeDemandaRapida = New e_DemandaRapida
            End If
            Return oeDemandaRapida
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_DemandaRapida, el cual es consultado por el procedimiento 
    ''' almacenado OPE.Isp_PreDemanda_Listar,enviando sus atributos del tipo de documento.Una vez obtenido los registros son 
    ''' cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeDemandaRapida">Recibe una Variable oeDemandaRapida de tipo e_DemandaRapida </param>
    ''' <returns>Devuelve una lista generica(ldDemandaRapida) de objetos de tipo e_DemandaRapida</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeDemandaRapida As e_DemandaRapida) As List(Of e_DemandaRapida)
        Try
            Dim ldDemandaRapida As New List(Of e_DemandaRapida)
            Dim ds As DataSet
            With oeDemandaRapida
                ds = sqlhelper.ExecuteDataset("OPE.Isp_PreDemanda_Listar", .TipoOperacion _
                                              , .Id _
                                                , .Codigo _
                                                , .IdCliente _
                                                , .IdComisionista _
                                                , .IdRuta _
                                                , .Activo _
                                                , .IdEstado, _
                                                .FechaDesde, _
                                                .FechaHasta)
            End With
            oeDemandaRapida = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDemandaRapida = Cargar(o_Fila)
                    ldDemandaRapida.Add(oeDemandaRapida)
                Next
            Else
                ldDemandaRapida = New List(Of e_DemandaRapida)
            End If
            Return ldDemandaRapida
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Tania
    Public Function ListarDemandaRapida(ByVal oeDemandaRapida As e_DemandaRapida) As List(Of e_DemandaRapida)
        Try
            Dim ldDemandaRapida As New List(Of e_DemandaRapida)
            Dim ds As DataSet
            With oeDemandaRapida
                ds = sqlhelper.ExecuteDataset("OPE.Isp_PreDemandaDemanda_Listar", .TipoOperacion _
                                              , .Id _
                                                , .Codigo _
                                                , .IdRuta _
                                                , .Activo _
                                                , .IdEstado, _
                                                .FechaDesde, _
                                                .FechaHasta)
            End With
            oeDemandaRapida = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDemandaRapida = Cargar(o_Fila)
                    ldDemandaRapida.Add(oeDemandaRapida)
                Next
            Else
                ldDemandaRapida = New List(Of e_DemandaRapida)
            End If
            Return ldDemandaRapida
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los datos de la demanda rapida,a travez del procedimiento almacenado
    ''' OPE.Isp_PreDemanda_IAE,por el cual van a ser enviados y registrados los datos de la demanda rapida y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeDemandaRapida">Recibe una variable oeDemandaRapida de tipo e_DemandaRapida</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro 
    ''' de la demanda rapida es positiva= true sino false 
    '''Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeDemandaRapida As e_DemandaRapida) As Boolean
        Dim d_DatosConfiguracion As New d_DatosConfiguracion
        Try
            With oeDemandaRapida
                sqlhelper.ExecuteNonQuery("OPE.Isp_PreDemanda_IAE", "I", _
                                          d_DatosConfiguracion.PrefijoID, _
                                                .Id _
                                                , "A" _
                                                , .Codigo _
                                                , .Fecha _
                                                , .IdCliente _
                                                , .IdComisionista _
                                                , .IdRuta _
                                                , .IdUsuario _
                                                , .IdEstado _
                                                , .Justificacion _
                                                , .Observacion _
                                                , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro de la demanda rapida,a travez del procedimiento almacenado
    ''' STD.Isp_TipoDocumento_IAE,por el cual va a ser enviado el id de la demanda rapida, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeDemandaRapida">Recibe una variable oeDemandaRapida de tipo objeto e_DemandaRapida</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Eliminar(ByVal oeDemandaRapida As e_DemandaRapida) As Boolean
        Try
            Using transScope As New TransactionScope()
                sqlhelper.ExecuteNonQuery("OPE.Isp_PreDemanda_IAE", "E", _
             "", oeDemandaRapida.Id, "", "", Nothing, Nothing, "", "", oeDemandaRapida.IdUsuario, "", oeDemandaRapida.Justificacion, "", 0, oeDemandaRapida.IdConceptoCancelacionEliminacion)
                odBitacora.VerificarExistenciaDeDetalles(oeDemandaRapida.oeListaBitacora)

                transScope.Complete()
            End Using            
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function



    Public Function Cancelar(ByVal oeDemandaRapida As e_DemandaRapida) As Boolean
        Try
            
            Using transScope As New TransactionScope()

                sqlhelper.ExecuteNonQuery("OPE.Isp_PreDemanda_Cancelar", "CA", oeDemandaRapida.Id, oeDemandaRapida.IdUsuario,
                                          oeDemandaRapida.Justificacion, oeDemandaRapida.Indicador, oeDemandaRapida.IdConceptoCancelacionEliminacion)
                odBitacora.VerificarExistenciaDeDetalles(oeDemandaRapida.oeListaBitacora)
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function CambioDeEstado(ByVal oeDemandaRapida As e_DemandaRapida) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("OPE.Isp_PreDemanda_IAE", "S", "", oeDemandaRapida.Id, "", "", Nothing, "", "", "",
                                      oeDemandaRapida.IdUsuario, "", oeDemandaRapida.Justificacion, "")
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class