Imports ISL.EntidadesWCF
''' <summary>
''' Clase que permite el acceso de los datos de los Distritos del Perú, desde la tabla UBIGEO
''' Fecha de Actualizacion:17/11/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla Ubigeo,Capa del Sistema: Capa de Acceso a Datos.</remarks>

Public Class d_Distrito
    Private sqlhelper As New SqlHelper

    Private oeDistrito As New e_Distrito
    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_Distrito y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:17/11/2011
    ''' </summary>
    ''' <param name="fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeDistrito) de tipo e_Distrito</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Cargar(ByVal fila As DataRow) As e_Distrito
        Try
            Dim oeDistrito = New e_Distrito(fila("Id"), fila("CODDPTO"), fila("CODPROV"), fila("CODDIST"), fila("Nombre"), fila("Activo"))
            Return oeDistrito
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una Distrito, el cual es consultado por el procedimiento almacenado STD.Isp_Distrito_Listar
    ''' enviando su id de la Distrito.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_Distrito.
    ''' Fecha de Actualizacion:17/11/2011
    ''' </summary>
    ''' <param name="oeDistrito">Recibe una variable oeDistrito de tipo e_Distrito</param>
    ''' <returns>Devuelve una varible oeDistrito de tipo e_Distrito</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeDistrito As e_Distrito) As e_Distrito
        Try

            'Dim datos As New 
            'Dim tablita As List(Of e_Tabla) = datos.Obtener_Estructura_Tabla("Direccion", "STD")

            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_Distrito_Listar", "", oeDistrito.Id)
            If ds.Tables.Count > 0 Then
                oeDistrito = Cargar(ds.Tables(0).Rows(0))
                Return oeDistrito
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_Distrito, el cual es consultado por el procedimiento almacenado Isp_Distrito_Listar
    ''' enviando sus atributos del Distrito.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:17/11/2011
    ''' </summary>
    ''' <param name="oeDistrito">Recibe una Variable oeDistrito de tipo e_Distrito </param>
    ''' <returns>Devuelve una lista generica(lista) de objetos de tipo e_Distrito</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeDistrito As e_Distrito) As List(Of e_Distrito)
        Try
            Dim ds As New DataSet
            Dim lista As New List(Of e_Distrito)
            With oeDistrito
                ds = sqlhelper.ExecuteDataset("STD.Isp_Distrito_Listar", "", .Id, .CodigoDepartamento, .CodigoProvincia, .Codigo, _
                        .Nombre, .Activo)
                If ds.Tables.Count > 0 Then
                    For Each fila As DataRow In ds.Tables(0).Rows
                        oeDistrito = Cargar(fila)
                        lista.Add(oeDistrito)
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
    ''' Metodo que se encargara de registrar los datos del Distrito,a travez del procedimiento almacenado 
    ''' STD.Isp_Distrito_IAE,por el cual van a ser enviados y registrados los datos del Distrito y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeDistrito">Recibe una variable oeDistrito de tipo e_Distrito</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro del 
    ''' Distrito es positiva= true sino false,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeDistrito As e_Distrito) As Boolean
        Try
            Dim resultado As Boolean = False
            With oeDistrito
                sqlhelper.ExecuteNonQuery("STD.Isp_Distrito_IAE", .TipoOperacion, .Id, .CodigoDepartamento, .CodigoProvincia, .Codigo, .Nombre, .Activo)
                resultado = True
            End With
            Return resultado
        Catch ex As Exception
            Throw
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro del Distrito,a travez del procedimiento almacenado
    ''' STD.Isp_Distrito_IAE,por el cual va a ser enviado el id del Distrito a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeDistrito">Recibe una variable oeDistrito de tipo objeto e_Distrito</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Eliminar(ByVal oeDistrito As e_Distrito) As Boolean
        Try
            Dim resultado As Boolean = False
            With oeDistrito
                sqlhelper.ExecuteNonQuery("STD.Isp_Distrito_IAE", "E", "", .Id)
                resultado = True
            End With
            Return resultado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
