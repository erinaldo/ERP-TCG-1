Imports ISL.EntidadesWCF

''' <summary>
''' Clase que gestiona los proceso que se tienen el menu del sistema.
''' Fecha Actualizada:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla MenuProceso,Capa del Sistema:Capa de Acceso a Datos.</remarks>

Public Class d_MenuProceso
    Private sqlhelper As New SqlHelper


    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo  e_MenuProceso y enviada al metodo que lo utilizo.
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeProceso) de tipo e_MenuProceso </returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Private Function Cargar(ByVal o_fila As DataRow) As e_MenuProceso
        Try
            Dim oeProceso = New e_MenuProceso( _
                              o_fila("Id") _
                             , o_fila("Codigo") _
                             , o_fila("Nombre") _
                             , o_fila("Abreviatura") _
                             , o_fila("Protegido") _
                             , o_fila("Explorer") _
                             , CInt(o_fila("Orden")) _
                              , o_fila("Activo") _
                              , o_fila("UsuarioCreacion") _
            )
            Return oeProceso
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene un proceso del menu, el cual es consultado por el procedimiento almacenado SGD.Isp_MenuProceso_Listar
    ''' enviando su id del proceso.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_MenuProceso.
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="oeProceso">Recibe una variable oeProceso de tipo e_MenuProceso</param>
    ''' <returns>Devuelve una varible oeProceso  de tipo e_MenuProceso</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeProceso As e_MenuProceso) As e_MenuProceso

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SGD.Isp_MenuProceso_Listar", "", oeProceso.Id)
            If ds.Tables.Count > 0 Then
                oeProceso = Cargar(ds.Tables(0).Rows(0))
                Return oeProceso
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_MenuProceso, el cual es consultado por el procedimiento almacenado STD.Isp_TipoDocumento_Listar
    ''' enviando sus atributos del proceso de menu.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' </summary>
    ''' <param name="oeProceso">Recibe una Variable oeProceso de tipo e_MenuProceso </param>
    ''' <returns>Devuelve una lista generica(ldProceso) de objetos de tipo e_MenuProceso </returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeProceso As e_MenuProceso) As List(Of e_MenuProceso)
        Try
            Dim ldProceso As New List(Of e_MenuProceso)
            Dim ds As DataSet
            With oeProceso
                ds = sqlhelper.ExecuteDataset("SGD.Isp_MenuProceso_Listar", "" _
                        , .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .Activo _
                        , .Orden _
                        )
            End With
            oeProceso = Nothing
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeProceso = Cargar(o_Fila)
                    ldProceso.Add(oeProceso)
                Next
            End If
            Return ldProceso
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que se encargara de registrar los datos de un proceso del menu,a travez del procedimiento almacenado
    ''' SGD.Isp_MenuProceso_IAE,por el cual van a ser enviados y registrados los datos del proceso del menu y
    ''' obtendremos una respuesta de confirmacion del registro guardado.
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="oeProceso">Recibe una variable oeProceso de tipo e_MenuProceso</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro de tipo
    '''  de documento es positiva= true sino false Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeProceso As e_MenuProceso) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            With oeProceso
                sqlhelper.ExecuteNonQuery("SGD.Isp_MenuProceso_IAE", .TipoOperacion, _
                         .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .Activo _
                        , .Orden _
                          , .Protegido _
                          , .Explorador _
                          , .UsuarioCreacion _
                        , .PrefijoID _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro de proceso del menu,a travez del procedimiento almacenado
    ''' STD.Isp_MenuProceso_IAE,por el cual va a ser enviado el id del proceso del menu a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="oeProceso">Recibe una variable oeProceso de tipo objeto e_MenuProceso</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Eliminar(ByVal oeProceso As e_MenuProceso) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SGD.Isp_MenuProceso_IAE", "E", oeProceso.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function ListarMenu(ByVal idUsuario As String) As List(Of e_MenuProceso)
        Try
            Dim leMenuProceso As New List(Of e_MenuProceso)
            Dim oeMenuProceso As New e_MenuProceso
            Dim odMenuGrupo As New d_MenuGrupo
            Dim ds As DataSet = sqlhelper.ExecuteDataset("SGD.Isp_Menu_Listar", "U", idUsuario)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMenuProceso = Cargar(o_Fila)
                    oeMenuProceso.leMenuGrupo = odMenuGrupo.ListarMenu(idUsuario, oeMenuProceso.Id)
                    leMenuProceso.Add(oeMenuProceso)
                    oeMenuProceso = Nothing
                Next
            End If
            Return leMenuProceso
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
