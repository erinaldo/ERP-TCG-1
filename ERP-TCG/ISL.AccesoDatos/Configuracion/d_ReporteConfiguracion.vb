Imports ISL.EntidadesWCF
''' <summary>
''' Clase parcial de lo que es ubigeo.
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla Ubigeo,Capa del Sistema: Capa de Acceso a Datos.</remarks>

Public Class d_ReporteConfiguracion
    Private sqlhelper As New SqlHelper

    Private oeReporteConfiguracion As New e_ReporteConfiguracion
    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_ReporteConfiguracion y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:20/01/2012
    ''' </summary>
    ''' <param name="fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeReporteConfiguracion) de tipo e_ReporteConfiguracion</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Cargar(ByVal fila As DataRow) As e_ReporteConfiguracion
        Try
            Dim oeReporteConfiguracion = New e_ReporteConfiguracion(fila("Id"), fila("IdProceso"), fila("Codigo"), fila("Nombre"), fila("Abreviatura"), fila("Activo"), fila("TipoReporte"), fila("Ruta"))
            Return oeReporteConfiguracion
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    ''' <summary>
    ''' Metodo que obtiene un ReporteConfiguracion, el cual es consultado por el procedimiento almacenado STD.Isp_ReporteConfiguracion_Listar
    ''' enviando su id del ReporteConfiguracion.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_ReporteConfiguracion.
    ''' Fecha de Actualizacion:20/01/2012
    ''' </summary>
    ''' <param name="oeReporteConfiguracion">Recibe una variable oeReporteConfiguracion de tipo e_ReporteConfiguracion</param>
    ''' <returns>Devuelve una varible oeReporteConfiguracion de tipo e_ReporteConfiguracion</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeReporteConfiguracion As e_ReporteConfiguracion) As e_ReporteConfiguracion
        Try
            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_ReporteConfiguracion_Listar", "", oeReporteConfiguracion.Id)
            If ds.Tables.Count > 0 Then
                oeReporteConfiguracion = Cargar(ds.Tables(0).Rows(0))
                Return oeReporteConfiguracion
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_ReporteConfiguracion, el cual es consultado por el procedimiento almacenado Isp_ReporteConfiguracion_Listar
    ''' enviando sus atributos del ReporteConfiguracion.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:20/01/2012
    ''' </summary>
    ''' <param name="oeReporteConfiguracion">Recibe una Variable oeReporteConfiguracion de tipo e_ReporteConfiguracion </param>
    ''' <returns>Devuelve una lista generica(lista) de objetos de tipo e_ReporteConfiguracion</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeReporteConfiguracion As e_ReporteConfiguracion) As List(Of e_ReporteConfiguracion)
        Try
            Dim ds As New DataSet
            Dim lista As New List(Of e_ReporteConfiguracion)
            With oeReporteConfiguracion
                ds = sqlhelper.ExecuteDataset("STD.Isp_ReporteConfiguracion_Listar", "", .Id, .Codigo, _
                        .Nombre, .Activo)
                If ds.Tables.Count > 0 Then
                    For Each fila As DataRow In ds.Tables(0).Rows
                        oeReporteConfiguracion = Cargar(fila)
                        lista.Add(oeReporteConfiguracion)
                    Next
                    Return lista
                Else
                    Return Nothing
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los datos del ReporteConfiguracion,a travez del procedimiento almacenado 
    ''' STD.Isp_ReporteConfiguracion_IAE,por el cual van a ser enviados y registrados los datos del ReporteConfiguracion y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:20/01/2012
    ''' </summary>
    ''' <param name="oeReporteConfiguracion">Recibe una variable oeReporteConfiguracion de tipo e_ReporteConfiguracion</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro del 
    ''' ReporteConfiguracion es positiva= true sino false,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeReporteConfiguracion As e_ReporteConfiguracion) As Boolean
        Try
            With oeReporteConfiguracion
                sqlhelper.ExecuteNonQuery("STD.Isp_ReporteConfiguracion_IAE", .TipoOperacion, .Id, .IdProceso, .Codigo, .Nombre, .Abreviatura, .Activo, .TipoReporte, .Ruta)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro del ReporteConfiguracion,a travez del procedimiento almacenado
    ''' STD.Isp_ReporteConfiguracion_IAE,por el cual va a ser enviado el id del ReporteConfiguracion a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:20/01/2012
    ''' </summary>
    ''' <param name="oeReporteConfiguracion">Recibe una variable oeReporteConfiguracion de tipo objeto e_ReporteConfiguracion</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Eliminar(ByVal oeReporteConfiguracion As e_ReporteConfiguracion) As Boolean
        Try
            With oeReporteConfiguracion
                sqlhelper.ExecuteNonQuery("STD.Isp_ReporteConfiguracion_IAE", "E", "", .Id)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class

