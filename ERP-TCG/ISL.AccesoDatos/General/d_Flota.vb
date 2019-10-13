Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient
''' <summary>
''' Clase que 
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla Tipo Orden Compra,Capa del Sistema: Capa de Acceso a Datos.</remarks>

Public Class d_Flota
    Private sqlhelper As New SqlHelper

    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo ----- y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeFlota) de tipo e_Flota</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Private Function Cargar(ByVal o_fila As DataRow) As e_Flota
        Try
            Dim oeFlota = New e_Flota(o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("IndZona").ToString _
                             , o_fila("IndFlota").ToString _
                             , o_fila("IndZonaD2").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("IdJefeActual").ToString _
                             , o_fila("CuotaTracto").ToString)
            Return oeFlota
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene un flota, el cual es consultado por el procedimiento almacenado XXX.ISP_XXXXXX_Listar
    ''' enviando su id de la flota .Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_Flota.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeFlota">Recibe una variable oeFlota de tipo e_Flota</param>
    ''' <returns>Devuelve una varible oeFlota de tipo e_Flota</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeFlota As e_Flota) As e_Flota

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[STD].[Isp_Flota_Listar]", "", oeFlota.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeFlota = Cargar(ds.Tables(0).Rows(0))
            Else
                oeFlota = New e_Flota
            End If
            Return oeFlota
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_Flota, el cual es consultado por el procedimiento almacenado XXX.ISP_XXXXXX_Listar
    ''' enviando sus atributos de la flota.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeFlota">Recibe una Variable oeFlota de tipo e_Flota</param>
    ''' <returns>Devuelve una lista generica(ldFlota) de objetos de tipo e_Flota</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeFlota As e_Flota) As List(Of e_Flota)
        Try
            Dim ldFlota As New List(Of e_Flota)
            Dim ds As DataSet
            With oeFlota
                ds = sqlhelper.ExecuteDataset("[STD].[Isp_Flota_Listar]", oeFlota.TipoOperacion _
                        , .Id _
                        , .IndZona _
                        , .IndFlota _
                        , .IndZonaD2 _
                        , .IdJefeActual)
            End With
            oeFlota = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeFlota = Cargar(o_Fila)
                    ldFlota.Add(oeFlota)
                Next
            Else
                ldFlota = New List(Of e_Flota)
            End If
            Return ldFlota
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Metodo que se encargara de registrar los datos de la flota,a travez del procedimiento almacenado
    ''' XXX.ISP_XXXXXXXXXXXXXXX_IAE,por el cual van a ser enviados y registrados los datos de la flota y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeFlota">Recibe una variable oeFlota de tipo e_Flota</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro
    '''  de la flota es positiva= true sino false,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeFlota As e_Flota) As Boolean

        Dim ldFlotaTrabajador As New d_Flota_Trabajador, ldFlotaCuota As New d_Flota_Cuota
        Try
            Using transScope As New TransactionScope()
                Dim strResultado As String = ""
                With oeFlota
                    strResultado = sqlhelper.ExecuteScalar("[STD].[Isp_Flota_IAE]", _
                                              .TipoOperacion, _
                                              .PrefijoID, _
                                            .Id _
                                            , .Codigo _
                                            , .Nombre _
                                            , .Activo _
                                            , .IndZona _
                                            , .IndFlota _
                                            , .IndZonaD2 _
                                            , .Descripcion _
                                            , .IdJefeActual _
                                            , .CuotaTracto)
                    .Id = strResultado
                    For Each Jefe As e_Flota_Trabajador In .ListJefes
                        If Jefe.TipoOperacion = "E" Then
                            ldFlotaTrabajador.Eliminar(Jefe)
                        Else
                            Jefe.TipoOperacion = "I"
                            Jefe.IdFlota = .Id
                            Jefe.PrefijoID = .PrefijoID '@0001
                            ldFlotaTrabajador.Guardar(Jefe)
                        End If
                    Next
                    For Each Cuota As e_Flota_Cuota In .ListCuotas.Where(Function(it) it.TipoOperacion <> "").ToList
                        If Cuota.TipoOperacion = "E" Then
                            ldFlotaCuota.Eliminar(Cuota)
                        Else
                            Cuota.IdFlota = .Id
                            Cuota.PrefijoID = .PrefijoID '@0001
                            ldFlotaCuota.Guardar(Cuota)
                        End If
                    Next
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro de la flota,a travez del procedimiento almacenado
    ''' XXX.ISP_XXXXXXXXXXXXXXX_IAE,por el cual va a ser enviado el id de la flota a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeFlota">Recibe una variable oeFlota de tipo objeto e_Flota</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Eliminar(ByVal oeFlota As e_Flota) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[STD].[Isp_Flota_IAE]", "E", _
                                      "", _
                                      oeFlota.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function ComboGrilla(ByVal ListaFlota As List(Of e_Flota))
        Dim ds = New DataTable
        ds.Columns.Add("Id")
        ds.Columns.Add("Nombre")
        For Each item As e_Flota In ListaFlota
            Dim newRow As DataRow = ds.NewRow()
            newRow("Id") = item.Id
            newRow("Nombre") = item.Nombre
            ds.Rows.Add(newRow)
        Next
        Return ds
    End Function

End Class
