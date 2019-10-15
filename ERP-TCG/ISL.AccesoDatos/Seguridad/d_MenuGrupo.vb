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
''' Clase que gestiona los grupos que se realizan dentro del menu del sistema.
''' Fecha Actualizada:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos a la tabla Menu Grupo.
''' Capa del Sistema:Capa de Acceso a Datos</remarks>

Public Class d_MenuGrupo
    Private sqlhelper As New SqlHelper

    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_MenuGrupo y enviada al metodo que lo utilizo.
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeMenuGrupo) de tipo e_MenuGrupo</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Private Function Cargar(ByVal o_fila As DataRow) As e_MenuGrupo
        Try
            Dim oeMenuGrupo = New e_MenuGrupo( _
                             o_fila("Id").ToString _
                             , o_fila("IdMenuProceso").ToString _
                             , o_fila("MenuProceso") _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("Orden").ToString _
                             , o_fila("Protegido").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
            )
            Return oeMenuGrupo
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene un grupo del menu, el cual es consultado por el procedimiento almacenado SGD.Isp_MenuGrupo_Listar
    ''' enviando su id del grupo del menu.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_MenuGrupo.
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="oeMenuGrupo">Recibe una variable oeMenuGrupo de tipo e_MenuGrupo</param>
    ''' <returns>Devuelve una varible oeMenuGrupo de tipo e_MenuGrupo</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeMenuGrupo As e_MenuGrupo) As e_MenuGrupo

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("SGD.Isp_MenuGrupo_Listar", "", oeMenuGrupo.Id)
            If ds.Tables.Count > 0 Then
                oeMenuGrupo = Cargar(ds.Tables(0).Rows(0))
                Return oeMenuGrupo
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_MenuGrupo, el cual es consultado por el procedimiento almacenado SGD.Isp_MenuGrupo_Listar
    ''' enviando sus atributos del grupo del menu.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' </summary>
    ''' <param name="oeMenuGrupo">Recibe una Variable oeMenuGrupo de tipo e_MenuGrupo </param>
    ''' <returns>Devuelve una lista generica(ld) de objetos de tipo e_MenuGrupo</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeMenuGrupo As e_MenuGrupo) As List(Of e_MenuGrupo)
        Try
            Dim ldMenuGrupo As New List(Of e_MenuGrupo)
            Dim ds As DataSet
            With oeMenuGrupo
                ds = sqlhelper.ExecuteDataset("SGD.Isp_MenuGrupo_Listar", "" _
                        , .Id _
                        , .IdMenuProceso _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .Activo _
                        , .Orden _
                        , .Protegido _
                        , .UsuarioCreacion _
                        )
            End With
            oeMenuGrupo = Nothing
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMenuGrupo = Cargar(o_Fila)
                    ldMenuGrupo.Add(oeMenuGrupo)
                Next
            End If
            Return ldMenuGrupo
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los datos de los grupos del menu,a travez del procedimiento almacenado
    ''' SGD.ISP_MenuGrupo_IAE,por el cual van a ser enviados y registrados los datos del grupo del menu y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="oeMenuGrupo">Recibe una variable oeMenuGrupo de tipo e_MenuGrupo</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro 
    ''' de tipo de documento es positiva= true sino false Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeMenuGrupo As e_MenuGrupo) As Boolean
        Try
            With oeMenuGrupo
                sqlhelper.ExecuteNonQuery("SGD.ISP_MenuGrupo_IAE", .TipoOperacion,
                        .Id _
                        , .IdMenuProceso _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .Activo _
                        , .Orden _
                        , .Protegido _
                , .UsuarioCreacion _
                        , .PrefijoID
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un grupo del menu,a travez del procedimiento almacenado
    ''' SGD.Iso_MenuGrupo_IAE,por el cual va a ser enviado el id del grupo del menu, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="oeMenuGrupo">Recibe una variable oeMenuGrupo de tipo objeto e_MenuGrupo</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Eliminar(ByVal oeMenuGrupo As e_MenuGrupo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SGD.Isp_MenuGrupo_IAE", "E", oeMenuGrupo.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function ListarMenu(ByVal idUsuario As String, ByVal idMenuProceso As String) As List(Of e_MenuGrupo)
        Try
            Dim ldMenuGrupo As New List(Of e_MenuGrupo)
            Dim oeMenuGrupo As New e_MenuGrupo
            Dim odMenuActividad As New d_MenuActividad
            Dim ds As DataSet = sqlhelper.ExecuteDataset("SGD.Isp_Menu_Listar", "P", idUsuario, idMenuProceso)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMenuGrupo = Cargar(o_Fila)
                    oeMenuGrupo.leMenuActividad = odMenuActividad.ListarMenu(idUsuario, idMenuProceso, oeMenuGrupo.Id)
                    ldMenuGrupo.Add(oeMenuGrupo)
                    oeMenuGrupo = Nothing
                Next
            End If
            Return ldMenuGrupo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
