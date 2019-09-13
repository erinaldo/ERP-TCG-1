Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

''' <summary>
''' Clase que gestiona los procesos de las actividades que se realizan dentro del menu del sistema.
''' Fecha Actualizada:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla Tipo Orden Compra,Capa del Sistema: Capa de Acceso a Datos</remarks>
Public Class d_MenuActividad

    Private sqlhelper As New SqlHelper

    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_MenuActividad y enviada al metodo que lo llamo.
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeTipoDocumento) de tipo e_TipoDocumento</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Cargar(ByVal o_fila As DataRow) As e_MenuActividad
        Try
            Dim oeMenuActividad = New e_MenuActividad( _
                                o_fila("Id") _
                         , o_fila("IdActividadNegocio") _
                        , o_fila("MenuProceso") _
                        , o_fila("IdProcesoNegocio") _
                         , o_fila("IdMenuGrupo") _
                         , o_fila("MenuGrupo") _
                        , o_fila("IdMenuProceso") _
                         , o_fila("Codigo") _
                         , o_fila("Nombre") _
                         , o_fila("Abreviatura") _
                         , o_fila("Orden") _
                         , o_fila("Protegido") _
                         , o_fila("Explorer") _
                         , o_fila("Imagen") _
                         , o_fila("Tamano") _
                         , o_fila("Texto") _
                         , o_fila("Formulario") _
                         , o_fila("Form") _
                         , IIf(o_fila("Menu"), 1, 0) _
                         , o_fila("IdMenuItem") _
                         , IIf(o_fila("Padre"), "SI", "NO") _
                        , o_fila("NombrePadre") _
                        , IIf(o_fila("MultipleInstancia"), "SI", "NO") _
                         , o_fila("UsuarioCreacion") _
                         , o_fila("Activo") _
            )
            Return oeMenuActividad
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene un objeto de tipo e_MenuActividad, el cual es consultado por el procedimiento almacenado SGD.Isp_MenuActividad_Listar
    ''' enviando su id de la actividad del menu.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_MenuActividad.
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="oeMenuActividad">Recibe una variable oeMenuActividad de tipo e_MenuActividad</param>
    ''' <returns>Devuelve una varible oeMenuActividad de tipo e_MenuActividad</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeMenuActividad As e_MenuActividad) As e_MenuActividad
        Try
            Dim ds As DataSet
            With oeMenuActividad
                ds = sqlhelper.ExecuteDataset("SGD.Isp_MenuActividad_Listar", "", .Id, .IdActividadNegocio, .IdMenuGrupo, .IdMenuItem, .Codigo)
            End With
            oeMenuActividad = New e_MenuActividad
            If ds.Tables(0).Rows.Count > 0 Then
                oeMenuActividad = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMenuActividad
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_MenuActividad, el cual es consultado por el procedimiento almacenado SGD.Isp_MenuActividad_Listar
    ''' enviando sus atributos de la actividad del menu.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' </summary>
    ''' <param name="oeMenuActividad">Recibe una Variable oeMenuActividad de tipo e_MenuActividad </param>
    ''' <returns>Devuelve una lista generica(ld) de objetos de tipo e_MenuActividad</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeMenuActividad As e_MenuActividad) As List(Of e_MenuActividad)
        Try
            Dim ld As New List(Of e_MenuActividad)
            Dim ds As DataSet
            With oeMenuActividad
                ds = sqlhelper.ExecuteDataset("SGD.Isp_MenuActividad_Listar", "" _
                        , .Id _
                        , .IdActividadNegocio _
                        , .IdMenuGrupo _
                        , .IdMenuItem _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .Orden _
                        , .Menu _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeMenuActividad = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMenuActividad = Cargar(o_Fila)
                    ld.Add(oeMenuActividad)
                Next
                Return ld
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Metodo que se encargara de registrar los datos de la actividad del menu,a travez del procedimiento almacenado
    ''' SGD.Isp_MenuActividad_IAE,por el cual van a ser enviados y registrados los datos de la actividad del menu y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="oeMenuActividad">Recibe una variable oeMenuActividad de tipo e_MenuActividad</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro de tipo
    '''  de documento es positiva= true sino false Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeMenuActividad As e_MenuActividad) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeMenuActividad
                sqlhelper.ExecuteNonQuery("SGD.Isp_MenuActividad_IAE", .TipoOperacion, _
                        .Id _
                        , .IdActividadNegocio _
                        , .IdMenuGrupo _
                        , .IdMenuItem _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .Orden _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .Protegido _
                        , .Explorer _
                        , .Imagen _
                        , .Tamano _
                        , .Texto _
                        , .Formulario _
                        , .menu _
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
    ''' Metodo que se encargara de desactivar un regitro de la actividad del menu,a travez del procedimiento almacenado
    ''' SGD.Isp_MenuActividad_IAE,por el cual va a ser enviado el id de la actividad del menu a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="oeMenuActividad">Recibe una variable oeMenuActividad de tipo objeto e_MenuActividad</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Eliminar(ByVal oeMenuActividad As e_MenuActividad) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SGD.Isp_MenuActividad_IAE", "E", oeMenuActividad.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function ListarMenu(ByVal idUsuario As String, ByVal idMenuProceso As String, ByVal idMenuGrupo As String) As List(Of e_MenuActividad)
        Try
            Dim leMenuActividad As New List(Of e_MenuActividad)
            Dim oeMenuActividad As New e_MenuActividad
            Dim ds As DataSet = sqlhelper.ExecuteDataset("SGD.Isp_Menu_Listar", "G", idUsuario, idMenuProceso, idMenuGrupo)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMenuActividad = Cargar(o_Fila)
                    If oeMenuActividad.Menu Then oeMenuActividad.leSubMenu = ListarSubMenu(idUsuario, idMenuProceso, idMenuGrupo, oeMenuActividad.Id)
                    leMenuActividad.Add(oeMenuActividad)
                    oeMenuActividad = Nothing
                Next
            End If
            Return leMenuActividad
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ListarSubMenu(ByVal idUsuario As String, ByVal idMenuProceso As String, ByVal idMenuGrupo As String, ByVal idMenuItem As String) As List(Of e_MenuActividad)
        Try
            Dim leItem As New List(Of e_MenuActividad)
            Dim oeItem As New e_MenuActividad
            Dim ds As DataSet = sqlhelper.ExecuteDataset("SGD.Isp_Menu_Listar", "M", idUsuario, idMenuProceso, idMenuGrupo, idMenuItem)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeItem = Cargar(o_Fila)
                    leItem.Add(oeItem)
                    oeItem = Nothing
                Next
            End If
            Return leItem
        Catch ex As Exception
            Throw ex
        End Try
    End Function




End Class
