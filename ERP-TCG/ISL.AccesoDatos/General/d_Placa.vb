Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient
''' <summary>
''' Clase que gestiona las placas que se utiliza en la empresa.
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla Placa,Capa del Sistema: Capa de Acceso a Datos.</remarks>
Public Class d_Placa
    Private sqlhelper As New SqlHelper

    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_Placa y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oePlaca) de tipo e_Placa</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Private Function Cargar(ByVal o_fila As DataRow) As e_Placa
        Try
            Dim oePlaca = New e_Placa( _
                             o_fila("Id").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("FechaInicio").ToString _
                             , o_fila("IdVehiculo").ToString _
                                , o_fila("Actual").ToString)
            Return oePlaca
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una placa, el cual es consultado por el procedimiento almacenado STD.Isp_Placa_Listar
    ''' enviando su id de la placa.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_Placa.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oePlaca">Recibe una variable oePlaca de tipo e_Placa</param>
    ''' <returns>Devuelve una varible oePlaca de tipo e_Placa</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oePlaca As e_Placa) As e_Placa
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_Placa_Listar", _
                                          "", _
                                          oePlaca.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oePlaca = Cargar(ds.Tables(0).Rows(0))
            Else
                oePlaca = New e_Placa
            End If
            Return oePlaca
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_Placa, el cual es consultado por el procedimiento almacenado STD.Isp_Placa_Listar
    ''' enviando sus atributos de la placa.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oePlaca">Recibe una Variable oePlaca de tipo e_Placa </param>
    ''' <returns>Devuelve una lista generica(ldPlaca) de objetos de tipo e_Placa</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oePlaca As e_Placa) As List(Of e_Placa)
        Try
            Dim ldPlaca As New List(Of e_Placa)
            Dim ds As DataSet
            With oePlaca
                ds = sqlhelper.ExecuteDataset("STD.Isp_Placa_Listar", _
                                              .TipoOperacion _
                                            , .Id _
                                            , .Activo _
                                            , .IdVehiculo)
            End With
            oePlaca = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oePlaca = Cargar(o_Fila)
                    ldPlaca.Add(oePlaca)
                Next
            Else
                ldPlaca = New List(Of e_Placa)
            End If
            Return ldPlaca
        Catch ex As Exception
            Throw
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los datos de la placa,a travez del procedimiento almacenado
    ''' STD.Isp_Placa_IAE,por el cual van a ser enviados y registrados los datos de la placa y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oePlaca">Recibe una variable oePlaca de tipo e_Placa</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro
    '''  de tipo de documento es positiva= true sino false,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oePlaca As e_Placa) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oePlaca
                sqlhelper.ExecuteNonQuery("STD.Isp_Placa_IAE", _
                                          .TipoOperacion, _
                                          d_DatosConfiguracion.PrefijoID, _
                                        .Id _
                                        , .Nombre _
                                        , .Activo _
                                        , .FechaInicio _
                                        , .IdVehiculo _
                                        , .Actual)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro de placa,a travez del procedimiento almacenado
    ''' STD.Isp_Placa_IAE,por el cual va a ser enviado el id de la placa a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oePlaca">Recibe una variable oePlaca de tipo objeto e_Placa</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Eliminar(ByVal oePlaca As e_Placa) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_Placa_IAE", "E", _
             "", oePlaca.Id, "", 0, "01/01/1901", oePlaca.IdVehiculo)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class

