'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions

''' <summary>
''' Clase que se encarga de gestionar los procesos de negocio de la empresa
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla ProcesoNegocio,Capa del Sistema: Capa de Acceso a Datos.</remarks>
Public Class d_ProcesoNegocio

    Private sqlhelper As New SqlHelper

    Private oeProcesoNegocio As New e_ProcesoNegocio
    Private oeActividadNegocio As New e_ActividadNegocio
    Private odActividadNegocio As New d_ActividadNegocio
    Private oeFlujoCaja As New e_FlujoCaja, odFlujoCaja As New d_FlujoGasto

    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_ProcesoNegocio y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeProcesoNegocio) de tipo e_ProcesoNegocio</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Private Function Cargar(ByVal o_fila As DataRow) As e_ProcesoNegocio
        Try
            Dim oeProcesoNegocio = New e_ProcesoNegocio( _
                         o_fila("Id").ToString _
                         , o_fila("Codigo").ToString _
                         , o_fila("Nombre").ToString _
                         , o_fila("Indicador") _
                         , o_fila("Protegido").ToString _
                         , o_fila("IndSeguridad") _
                         , o_fila("Activo").ToString _
                         , o_fila("UsuarioCreacion").ToString _
        )
            Return oeProcesoNegocio
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    ''' <summary>
    ''' Metodo que obtiene un proceso de negocio, el cual es consultado por el procedimiento almacenado STD.ISP_ProcesoNegocio_Listar
    ''' enviando su id del proceso de negocio.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_ProcesoNegocio.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeProcesoNegocio">Recibe una variable oeProcesoNegocio de tipo e_ProcesoNegocio</param>
    ''' <returns>Devuelve una varible oeProcesoNegocio de tipo e_ProcesoNegocio</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeProcesoNegocio As e_ProcesoNegocio) As e_ProcesoNegocio
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.ISP_ProcesoNegocio_Listar", "", oeProcesoNegocio.Id, "", oeProcesoNegocio.Nombre)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeProcesoNegocio = Cargar(ds.Tables(0).Rows(0))
                oeActividadNegocio.IdProcesoNegocio = oeProcesoNegocio.Id
                oeProcesoNegocio.leActividadNegocio = odActividadNegocio.Listar(oeActividadNegocio)
                oeFlujoCaja = New e_FlujoCaja
                oeFlujoCaja.NombProceso = oeProcesoNegocio.Nombre.Trim
                oeFlujoCaja.TipoOperacion = "P"
                oeProcesoNegocio.leFlujoCaja = odFlujoCaja.Listar(oeFlujoCaja)
                Return oeProcesoNegocio
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_ProcesoNegocio, el cual es consultado por el procedimiento 
    ''' almacenado STD.ISP_ProcesoNegocio_Listar,enviando sus atributos del proceso de negocio.Una vez obtenido los registros 
    ''' son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeProcesoNegocio">Recibe una Variable oeProcesoNegocio de tipo e_ProcesoNegocio </param>
    ''' <returns>Devuelve una lista generica(ldTipoMantenimiento) de objetos de tipo e_ProcesoNegocio</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeProcesoNegocio As e_ProcesoNegocio) As List(Of e_ProcesoNegocio)
        Try
            Dim ldProcesoNegocio As New List(Of e_ProcesoNegocio)
            Dim ds As DataSet
            With oeProcesoNegocio
                ds = sqlhelper.ExecuteDataset("STD.ISP_ProcesoNegocio_Listar", .TipoOperacion, .Id, .Codigo, _
                        .Nombre, .Indicador, .Activo)
            End With
            oeProcesoNegocio = Nothing
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeProcesoNegocio = Cargar(o_Fila)
                    ldProcesoNegocio.Add(oeProcesoNegocio)
                Next
            End If
            Return ldProcesoNegocio
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los datos del proceso de negocio,a travez del procedimiento almacenado
    ''' STD.Isp_ProcesoNegocio_IAE,por el cual van a ser enviados y registrados los datos del proceso de negocio y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeProcesoNegocio">Recibe una variable oeProcesoNegocio de tipo e_ProcesoNegocio</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro de
    ''' proceso de negocio es positiva= true sino false 
    ''' Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeProcesoNegocio As e_ProcesoNegocio) As Boolean
        Try
            Dim id As String = ""
            Using TransScope As New TransactionScope()
                With oeProcesoNegocio
                    id = sqlhelper.ExecuteScalar("STD.Isp_ProcesoNegocio_IAE", .TipoOperacion,
                      .Id _
                      , .Codigo _
                      , .Nombre _
                      , .Indicador _
                      , .Protegido _
                      , .Seguridad _
                      , .Activo _
                      , .UsuarioCreacion _
                      , .PrefijoID
                  )
                End With

                If Not oeProcesoNegocio.leActividadNegocio Is Nothing Then
                    For Each oeActividadNegocio As e_ActividadNegocio In oeProcesoNegocio.leActividadNegocio
                        oeActividadNegocio.IdProcesoNegocio = id
                        oeActividadNegocio.PrefijoID = oeProcesoNegocio.PrefijoID '@0001
                        odActividadNegocio.Guardar(oeActividadNegocio)
                    Next
                End If
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro de proceso de negocio,a travez del procedimiento almacenado
    ''' STD.Isp_ProcesoNegocio_IAE,por el cual va a ser enviado el id del proceso de negocio a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeProcesoNegocio">Recibe una variable oeProcesoNegocio de tipo objeto e_ProcesoNegocio</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Eliminar(ByVal oeProcesoNegocio As e_ProcesoNegocio) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_ProcesoNegocio_IAE", "E", oeProcesoNegocio.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function


End Class
