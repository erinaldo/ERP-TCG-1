Imports ISL.EntidadesWCF
Imports System.Transactions
''' <summary>
''' Clase que gestiona los ciclos de tiempo en los procesos la empresa
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla TiempoCiclo,Capa del Sistema: Capa de Acceso a Datos.</remarks>
Public Class d_TiempoCiclo

    Private sqlhelper As New SqlHelper

    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_TiempoCiclo y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeTiempoCiclo) de tipo e_TiempoCiclo</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Cargar(ByVal o_fila As DataRow) As e_TiempoCiclo
        Try
            Dim oeTiempoCiclo = New e_TiempoCiclo( _
                             o_fila("Id").ToString _
                             , o_fila("IdRuta").ToString _
                              , o_fila("TipoVehiculo").ToString _
                             , o_fila("Cliente").ToString _
                             , o_fila("HorasCarga").ToString _
                             , o_fila("HorasTraslado").ToString _
                             , o_fila("HorasDescarga").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeTiempoCiclo
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene un tiempo del ciclo, el cual es consultado por el procedimiento almacenado XXX.ISP_XXXXXX_Listar
    ''' enviando su id del tiempo de ciclo.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_TiempoCiclo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTiempoCiclo">Recibe una variable oeTiempoCiclo de tipo e_TiempoCiclo</param>
    ''' <returns>Devuelve una varible oeTiempoCiclo de tipo e_TiempoCiclo</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeTiempoCiclo As e_TiempoCiclo) As e_TiempoCiclo

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[OPE].[Isp_TiempoCiclo_Listar]", _
                                        oeTiempoCiclo.TipoOperacion, _
                                        oeTiempoCiclo.Id, _
                                        oeTiempoCiclo.TipoVehiculo, _
                                        oeTiempoCiclo.IdRuta)
            If ds.Tables(0).Rows.Count > 0 Then
                oeTiempoCiclo = Cargar(ds.Tables(0).Rows(0))
            Else
                oeTiempoCiclo = New e_TiempoCiclo
            End If
            Return oeTiempoCiclo
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_TipoDocumento, el cual es consultado por el procedimiento almacenado STD.Isp_TipoDocumento_Listar
    ''' enviando sus atributos del tipo de documento.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTiempoCiclo">Recibe una Variable oeTiempoCiclo de tipo e_TiempoCiclo </param>
    ''' <returns>Devuelve una lista generica(ldTiempoCiclo) de objetos de tipo e_TiempoCiclo</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeTiempoCiclo As e_TiempoCiclo) As List(Of e_TiempoCiclo)
        Try
            Dim ldTiempoCiclo As New List(Of e_TiempoCiclo)
            Dim ds As DataSet
            With oeTiempoCiclo
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_TiempoCiclo_Listar]", .TipoOperacion _
                                            , .Id _
                                            , .TipoVehiculo _
                                            , .IdRuta _
                                            , .Cliente _
                                            , .Activo)
            End With
            oeTiempoCiclo = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTiempoCiclo = Cargar(o_Fila)
                    ldTiempoCiclo.Add(oeTiempoCiclo)
                Next
            Else
                ldTiempoCiclo = New List(Of e_TiempoCiclo)
            End If
            Return ldTiempoCiclo
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los datos del tiempo de ciclo,a travez del procedimiento almacenado
    ''' XXX.ISP_XXXXXXXXXXXXXXX_IAE,por el cual van a ser enviados y registrados los datos del tiempo de ciclo y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTiempoCiclo">Recibe una variable oeTiempoCiclo de tipo e_TiempoCiclo</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro 
    ''' de tiempo de ciclo es positiva= true sino false 
    '''Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeTiempoCiclo As e_TiempoCiclo) As Boolean
        Dim d_DatosConfiguracion As New d_DatosConfiguracion
        Try
            With oeTiempoCiclo
                sqlhelper.ExecuteNonQuery("[OPE].[Isp_TiempoCiclo_IAE]",
                                          "I",
                                          .PrefijoID,
                                        .Id _
                                        , .IdRuta _
                                        , .TipoVehiculo _
                                        , .Cliente _
                                        , .HorasCarga _
                                        , .HorasTraslado _
                                        , .HorasDescarga _
                                        , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro del tiempo de ciclo,a travez del procedimiento almacenado
    ''' XXX.ISP_XXXXXXXXXXXXXXX_IAE,por el cual va a ser enviado el id del tiempo de ciclo a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTiempoCiclo">Recibe una variable oeTiempoCiclo de tipo objeto e_TiempoCiclo</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Eliminar(ByVal oeTiempoCiclo As e_TiempoCiclo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[OPE].[Isp_TiempoCiclo_IAE]", "E", _
             "", oeTiempoCiclo.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class