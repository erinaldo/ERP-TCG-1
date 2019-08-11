Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient
''' <summary>
''' Clase que gestiona el lugar o ubicacion del territorio.
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla Tipo Orden Compra,Capa del Sistema: Capa de Acceso a Datos.</remarks>

Public Class d_Lugar

    Private sqlhelper As New SqlHelper
    Dim d_DatosConfiguracion As New d_DatosConfiguracion
    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_Lugar y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeLugar) de tipo e_Lugar</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Private Function Cargar(ByVal o_fila As DataRow) As e_Lugar
        Try
            Dim oeLugar = New e_Lugar(o_fila("Id").ToString, _
                                      o_fila("IdUbigeo").ToString, _
                                      o_fila("Nombre").ToString, _
                                      o_fila("NombreCorto").ToString, _
                                      o_fila("Abreviatura").ToString, _
                                      o_fila("Activo").ToString, _
                                      o_fila("Codigo").ToString, _
                                      o_fila("TipoRuta").ToString, _
                                      o_fila("UsuarioCreacion").ToString, _
                                      o_fila("IdReferencia").ToString)
            Return oeLugar
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene un lugar, el cual es consultado por el procedimiento almacenado XXX.ISP_XXXXXX_Listar
    ''' enviando su id del  -.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo -.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeLugar">Recibe una variable oeLugar de tipo e_Lugar</param>
    ''' <returns>Devuelve una varible oeLugar de tipo e_Lugar</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeLugar As e_Lugar) As e_Lugar
        Try
            Dim ds As DataSet
            With oeLugar
                ds = sqlhelper.ExecuteDataset("STD.Isp_Lugar_Listar", _
                                            .TipoOperacion, _
                                            .Id)
            End With

            If ds.Tables(0).Rows.Count > 0 Then
                oeLugar = Cargar(ds.Tables(0).Rows(0))
            Else
                oeLugar = New e_Lugar
            End If
            Return oeLugar
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_Lugar, el cual es consultado por el procedimiento almacenado 
    ''' STD.Isp_Lugar_Listar,enviando sus atributos del lugar.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeLugar">Recibe una Variable oeLugar de tipo e_Lugar </param>
    ''' <returns>Devuelve una lista generica(ldLugar) de objetos de tipo e_Lugar</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeLugar As e_Lugar) As List(Of e_Lugar)
        Try
            Dim ldLugar As New List(Of e_Lugar)
            Dim ds As DataSet
            With oeLugar
                ds = sqlhelper.ExecuteDataset("STD.Isp_Lugar_Listar", _
                                              .TipoOperacion _
                                            , .Id _
                                            , .IdUbigeo _
                                            , .Nombre _
                                            , .Abreviatura _
                                            , .Codigo)
            End With
            oeLugar = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeLugar = Cargar(o_Fila)
                    ldLugar.Add(oeLugar)
                Next
            Else
                ldLugar = New List(Of e_Lugar)
            End If
            Return ldLugar
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los datos del lugar,a travez del procedimiento almacenado
    ''' STD.Isp_Lugar_Listar,por el cual van a ser enviados y registrados los datos del lugar y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeLugar">Recibe una variable oeLugar de tipo e_Lugar</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del 
    ''' registro del lugar es positiva= true sino false 
    '''Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeLugar As e_Lugar) As Boolean

        Dim stResultado() As String
        Try
            Using transScope As New TransactionScope()
                With oeLugar
                    stResultado = sqlhelper.ExecuteScalar("[STD].[Isp_Lugar_IAE]", _
                                              .TipoOperacion, _
                                              d_DatosConfiguracion.PrefijoID, _
                                                .Id, _
                                                .IdUbigeo, _
                                                .Nombre, _
                                                .Abreviatura, _
                                                .Codigo, _
                                                .TipoRuta, _
                                                .UsuarioCreacion, _
                                                .IdReferencia).ToString.Split("_")
                End With
                If oeLugar.ListaClienteLugar.Count > 0 Then
                    For Each oeClienteLugar As e_ClienteLugar In oeLugar.ListaClienteLugar
                        oeClienteLugar.IdLugar = stResultado(0)
                        oeClienteLugar.TipoOperacion = "I"
                        GuardarClienteLugar(oeClienteLugar)
                    Next
                End If
                If oeLugar.ListaVentanaHoraria.Count > 0 Then
                    For Each oeVentanaHoraria As e_VentanaHoraria In oeLugar.ListaVentanaHoraria
                        oeVentanaHoraria.IdLugar = stResultado(0)
                        oeVentanaHoraria.TipoOperacion = "I"
                        GuardarVentanaHoraria(oeVentanaHoraria)
                    Next
                End If
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un lugar,a travez del procedimiento almacenado
    ''' CON.ISP_XXXXXXXXXXXXXXX_IAE,por el cual va a ser enviado el id del lugar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeLugar">Recibe una variable oeLugar de tipo objeto e_Lugar</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Eliminar(ByVal oeLugar As e_Lugar) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[STD].[Isp_Lugar_IAE]", _
                                        "E", _
                                        "", _
                                        oeLugar.Id)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ComboGrilla(ByVal ListaLugar As List(Of e_Lugar))
        Dim ds = New DataTable
        ds.Columns.Add("Id")
        ds.Columns.Add("Nombre")
        For Each item As e_Lugar In ListaLugar
            Dim newRow As DataRow = ds.NewRow()
            newRow("Id") = item.Id
            newRow("Nombre") = item.Nombre
            ds.Rows.Add(newRow)
        Next
        Return ds
    End Function

    Private Function CargarClienteLugar(ByVal o_fila As DataRow) As e_ClienteLugar
        Try
            Dim oeClienteLugar = New e_ClienteLugar( _
                             o_fila("Id").ToString _
                             , o_fila("IdLugar").ToString _
                             , o_fila("IdCliente").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("CentroCosto").ToString _
                             , o_fila("Observacion").ToString _
                             , o_fila("Activo").ToString)
            Return oeClienteLugar
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerClienteLugar(ByVal oeClienteLugar As e_ClienteLugar) As e_ClienteLugar

        Try
            Dim ds As DataSet
            With oeClienteLugar
                ds = sqlhelper.ExecuteDataset("OPE.Isp_ClienteLugar_Listar", _
                                                "", _
                                                .Id)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeClienteLugar = CargarClienteLugar(ds.Tables(0).Rows(0))
            Else
                oeClienteLugar = New e_ClienteLugar
            End If
            Return oeClienteLugar
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarClienteLugar(ByVal oeClienteLugar As e_ClienteLugar) As List(Of e_ClienteLugar)
        Try
            Dim ldClienteLugar As New List(Of e_ClienteLugar)
            Dim ds As DataSet
            With oeClienteLugar
                ds = sqlhelper.ExecuteDataset("OPE.Isp_ClienteLugar_Listar", "" _
                                            , .Id _
                                            , .IdLugar _
                                            , .IdCliente)
            End With
            oeClienteLugar = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeClienteLugar = CargarClienteLugar(o_Fila)
                    ldClienteLugar.Add(oeClienteLugar)
                Next
            Else
                ldClienteLugar = New List(Of e_ClienteLugar)
            End If
            Return ldClienteLugar
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarClienteLugar(ByVal oeClienteLugar As e_ClienteLugar) As Boolean
        Try
            With oeClienteLugar
                sqlhelper.ExecuteNonQuery("OPE.Isp_ClienteLugar_IAE", _
                                          .TipoOperacion, _
                                          d_DatosConfiguracion.PrefijoID, _
                                            .Id _
                                            , .IdLugar _
                                            , .IdCliente _
                                            , .Nombre _
                                            , .Codigo _
                                            , .CentroCosto _
                                            , .Observacion _
                                            , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EliminarClienteLugar(ByVal oeClienteLugar As e_ClienteLugar) As Boolean
        Try
            With oeClienteLugar
                sqlhelper.ExecuteNonQuery("OPE.Isp_ClienteLugar_IAE", _
                                          "E", _
                                         "", _
                                         .Id)
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Function CargarVentanaHoraria(ByVal o_fila As DataRow) As e_VentanaHoraria
        Try
            Dim oeVentanaHoraria = New e_VentanaHoraria( _
                             o_fila("Id").ToString _
                             , o_fila("IdLugar").ToString _
                             , o_fila("IdCliente").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("HoraInicio").ToString _
                             , o_fila("HoraFin").ToString)
            Return oeVentanaHoraria
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerVentanaHoraria(ByVal oeVentanaHoraria As e_VentanaHoraria) As e_VentanaHoraria

        Try
            Dim ds As DataSet
            With oeVentanaHoraria
                ds = sqlhelper.ExecuteDataset("OPE.Isp_VentanaHoraria_Listar", _
                                                "", _
                                                .Id)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeVentanaHoraria = CargarVentanaHoraria(ds.Tables(0).Rows(0))
            Else
                oeVentanaHoraria = New e_VentanaHoraria
            End If
            Return oeVentanaHoraria
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarVentanaHoraria(ByVal oeVentanaHoraria As e_VentanaHoraria) As List(Of e_VentanaHoraria)
        Try
            Dim ldVentanaHoraria As New List(Of e_VentanaHoraria)
            Dim ds As DataSet
            With oeVentanaHoraria
                ds = sqlhelper.ExecuteDataset("OPE.Isp_VentanaHoraria_Listar", "" _
                                            , .Id _
                                            , .IdLugar _
                                            , .IdCliente)
            End With
            oeVentanaHoraria = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeVentanaHoraria = CargarVentanaHoraria(o_Fila)
                    ldVentanaHoraria.Add(oeVentanaHoraria)
                Next
            Else
                ldVentanaHoraria = New List(Of e_VentanaHoraria)
            End If
            Return ldVentanaHoraria
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarVentanaHoraria(ByVal oeVentanaHoraria As e_VentanaHoraria) As Boolean
        Try
            With oeVentanaHoraria
                sqlhelper.ExecuteNonQuery("OPE.Isp_VentanaHoraria_IAE", _
                                          .TipoOperacion, _
                                          d_DatosConfiguracion.PrefijoID, _
                                            .Id _
                                            , .IdLugar _
                                            , .IdCliente _
                                            , .Nombre _
                                            , .Codigo _
                                            , .Activo _
                                            , "01/01/2013" & " " & .HoraInicio.ToShortTimeString _
                                            , "01/01/2013" & " " & .HoraFin.ToShortTimeString)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EliminarVentanaHoraria(ByVal oeVentanaHoraria As e_VentanaHoraria) As Boolean
        Try
            With oeVentanaHoraria
                sqlhelper.ExecuteNonQuery("OPE.Isp_VentanaHoraria_IAE", _
                                          "E", _
                                         "", _
                                         .Id)
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function VerificarAntesEliminar(ByVal oeLugar As e_Lugar) As Integer
        Try
            Dim cant = sqlhelper.ExecuteScalar("[OPE].[Isp_Lugar_Verificar]", _
                                    oeLugar.Id)
            Return cant
        Catch ex As Exception
            Throw ex
            Return 0
        End Try
    End Function

End Class
