'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient
''' <summary>
''' Clase que 
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla Tipo Orden Compra,Capa del Sistema: Capa de Acceso a Datos.</remarks>

Public Class d_Modelo
    Private sqlhelper As New SqlHelper

    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_Modelo y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeModeloVehiculo) de tipo e_Modelo</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Private Function Cargar(ByVal o_fila As DataRow) As e_Modelo
        Try
            Dim oeModeloVehiculo = New e_Modelo( _
                             o_fila("Seleccion").ToString _
                               , o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("Activo").ToString _
                              , o_fila("IdMarca").ToString _
                             , o_fila("Marca").ToString _
                            , o_fila("MarcaModelo").ToString _
                            , o_fila("IndEmpresa").ToString _
                            , o_fila("IndSunarp").ToString)
            Return oeModeloVehiculo
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene un modelo, el cual es consultado por el procedimiento almacenado STD.Isp_ModeloVehiculo_Listar
    ''' enviando su id del modelo.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_Modelo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeModeloVehiculo">Recibe una variable oeModeloVehiculo de tipo e_Modelo</param>
    ''' <returns>Devuelve una varible oeModeloVehiculo de tipo e_Modelo</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeModeloVehiculo As e_Modelo) As e_Modelo
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_ModeloVehiculo_Listar", _
                                          "", _
                                          oeModeloVehiculo.Id, _
                                          oeModeloVehiculo.Nombre)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeModeloVehiculo = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeModeloVehiculo
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_Modelo, el cual es consultado por el procedimiento almacenado 
    ''' STD.Isp_ModeloVehiculo_Listar,enviando sus atributos del modelo.Una vez obtenido los registros son cargados y 
    ''' devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeModeloVehiculo">Recibe una Variable oeModeloVehiculo de tipo e_Modelo </param>
    ''' <returns>Devuelve una lista generica(ldModeloVehiculo) de objetos de tipo e_Modelo</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeModeloVehiculo As e_Modelo) As List(Of e_Modelo)
        Try
            Dim ldModeloVehiculo As New List(Of e_Modelo)
            Dim ds As DataSet
            With oeModeloVehiculo
                ds = sqlhelper.ExecuteDataset("STD.Isp_ModeloVehiculo_Listar", _
                                              .TipoOperacion _
                                                , .Id _
                                                , .Nombre _
                                                , .Codigo _
                                                , .Abreviatura _
                                                , .IdMarca)
            End With
            oeModeloVehiculo = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeModeloVehiculo = Cargar(o_Fila)
                    ldModeloVehiculo.Add(oeModeloVehiculo)
                Next
            Else
                ldModeloVehiculo = New List(Of e_Modelo)
            End If
            Return ldModeloVehiculo
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los datos del modelo,a travez del procedimiento almacenado
    ''' [STD].[Isp_ModeloVehiculo_IAE],por el cual van a ser enviados y registrados los datos del modelo y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeModeloVehiculo">Recibe una variable oeModeloVehiculo de tipo e_Modelo</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro
    ''' de modelo es positiva= true sino false,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeModeloVehiculo As e_Modelo) As Boolean
        Try
            With oeModeloVehiculo
                sqlhelper.ExecuteNonQuery("[STD].[Isp_ModeloVehiculo_IAE]",
                                          .TipoOperacion,
                                          .PrefijoID _
                                        , .Id _
                                        , .Codigo _
                                        , .Nombre _
                                        , .Abreviatura _
                                        , .IdMarca _
                                        , .IndEmpresa _
                                        , .IndSunarp)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro del modelo,a travez del procedimiento almacenado
    ''' [STD].[Isp_ModeloVehiculo_IAE],por el cual va a ser enviado el id del modelo a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeModeloVehiculo">Recibe una variable oeModeloVehiculo de tipo objeto e_Modelo</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Eliminar(ByVal oeModeloVehiculo As e_Modelo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[STD].[Isp_ModeloVehiculo_IAE]", _
                                      oeModeloVehiculo.TipoOperacion, _
                                        "", _
                                        oeModeloVehiculo.Id)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function ComboGrilla(ByVal loModelo As List(Of e_Modelo))
        Try
            Dim ds = New DataTable
            ds.Columns.Add("Id")
            ds.Columns.Add("Nombre")
            For Each item As e_Modelo In loModelo
                Dim newRow As DataRow = ds.NewRow()
                newRow("Id") = item.Id
                newRow("Nombre") = item.Nombre
                ds.Rows.Add(newRow)
            Next
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class


