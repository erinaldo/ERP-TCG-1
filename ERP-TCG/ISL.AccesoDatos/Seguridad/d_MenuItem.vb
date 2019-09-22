Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient
''' <summary>
''' Clase que gestiona los proceso que se tienen el menu del sistema.
''' Fecha Actualizada:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla MenuItem,Capa del Sistema:Capa de Acceso a Datos</remarks>
Public Class d_MenuItem

    Private sqlhelper As New SqlHelper

    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_MenuItem y enviada al metodo que lo utilizo.
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeTipoDocumento) de tipo e_MenuItem</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Private Function Cargar(ByVal o_fila As DataRow) As e_MenuItem
        Try
            Dim oeMenuItem = New e_MenuItem( _
                             o_fila("Id").ToString _
                             , o_fila("IdMenuGrupo").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Orden").ToString _
                             , o_fila("Protegido").ToString _
            )
            Return oeMenuItem
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene un item del menu, el cual es consultado por el procedimiento almacenado SGD.Isp_MenuItem_Listar
    ''' enviando su id del item menu.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_MenuItem.
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="oeMenuItem">Recibe una variable oeMenuItem de tipo e_MenuItem</param>
    ''' <returns>Devuelve una varible oeMenuItem de tipo e_MenuItem</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeMenuItem As e_MenuItem) As e_MenuItem

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("SGD.Isp_MenuItem_Listar", "", oeMenuItem.Id)
            If ds.Tables.Count > 0 Then
                oeMenuItem = Cargar(ds.Tables(0).Rows(0))
                Return oeMenuItem
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_MenuItem, el cual es consultado por el procedimiento almacenado 
    ''' SGD.Isp_MenuItem_Listar enviando sus atributos del item de menu.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' </summary>
    ''' <param name="oeMenuItem">Recibe una Variable oeMenuItem de tipo e_MenuItem </param>
    ''' <returns>Devuelve una lista generica(ld) de objetos de tipo e_MenuItem</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeMenuItem As e_MenuItem) As List(Of e_MenuItem)
        Try
            Dim ld As New List(Of e_MenuItem)
            Dim ds As DataSet
            With oeMenuItem
                ds = SqlHelper.ExecuteDataset("SGD.Isp_MenuItem_Listar", "" _
                        , .Id _
                        , .IdMenuGrupo _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .Activo _
                        , .Orden _
                        , .Protegido _
                        )
            End With
            oeMenuItem = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMenuItem = Cargar(o_Fila)
                    ld.Add(oeMenuItem)
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
    ''' Metodo que se encargara de registrar los datos del item de menu,a travez del procedimiento almacenado
    ''' SGD.Isp_MenuItem_IAE,por el cual van a ser enviados y registrados los datos del item del menu y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="oeMenuItem">Recibe una variable oeMenuItem de tipo e_MenuItem</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro 
    ''' del item de menu es positiva= true sino false,Capa del sistema:Capa de Acceso a Datos</remarks> 
    Public Function Guardar(ByVal oeMenuItem As e_MenuItem) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            With oeMenuItem
                sqlhelper.ExecuteNonQuery("SGD.Isp_MenuItem_IAE", .TipoOperacion, _
                        .Id _
                        , .IdMenuGrupo _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .Activo _
                        , .Orden _
                        , .Protegido _
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
    ''' Metodo que se encargara de desactivar un regitro de item de menu,a travez del procedimiento almacenado
    ''' SGD.Isp_MenuItem_IAE,por el cual va a ser enviado el id de item de menu a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="oeMenuItem">Recibe una variable oeMenuItem de tipo objeto e_MenuItem</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Eliminar(ByVal oeMenuItem As e_MenuItem) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("SGD.Isp_MenuItem_IAE", "E", _
             "", oeMenuItem.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
