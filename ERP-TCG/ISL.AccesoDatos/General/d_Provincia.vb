Imports ISL.EntidadesWCF
''' <summary>
''' Clase que permite el acceso de los datos de las Provincias del Perú, desde la tabla UBIGEO
''' Fecha de Actualizacion:15/11/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla Ubigeo,Capa del Sistema: Capa de Acceso a Datos.</remarks>

Public Class d_Provincia

    Private sqlhelper As New SqlHelper

    Private oeProvincia As New e_Provincia
    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_Provincia y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeProvincia) de tipo e_Provincia</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Cargar(ByVal fila As DataRow) As e_Provincia
        Try
            Dim oeProvincia = New e_Provincia(fila("Id"), fila("CODDPTO"), fila("CODPROV"), fila("Nombre"), fila("Activo"))
            Return oeProvincia
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una Provincia, el cual es consultado por el procedimiento almacenado STD.Isp_Provincia_Listar
    ''' enviando su id de la Provincia.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_Provincia.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeProvincia">Recibe una variable oeProvincia de tipo e_Provincia</param>
    ''' <returns>Devuelve una varible oeProvincia de tipo e_Provincia</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeProvincia As e_Provincia) As e_Provincia
        Try
            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_Provincia_Listar", "", oeProvincia.Id)
            If ds.Tables.Count > 0 Then
                oeProvincia = Cargar(ds.Tables(0).Rows(0))
                Return oeProvincia
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_Provincia, el cual es consultado por el procedimiento almacenado Isp_Provincia_Listar
    ''' enviando sus atributos del Provincia.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeProvincia">Recibe una Variable oeProvincia de tipo e_Provincia </param>
    ''' <returns>Devuelve una lista generica(lista) de objetos de tipo e_Provincia</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeProvincia As e_Provincia) As List(Of e_Provincia)
        Try
            Dim ds As New DataSet
            Dim lista As New List(Of e_Provincia)
            With oeProvincia
                ds = sqlhelper.ExecuteDataset("STD.Isp_Provincia_Listar", "", .Id, .CodigoDepartamento, .Codigo, _
                        .Nombre, .Activo)
                If ds.Tables.Count > 0 Then
                    For Each fila As DataRow In ds.Tables(0).Rows
                        oeProvincia = Cargar(fila)
                        lista.Add(oeProvincia)
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
    ''' Metodo que se encargara de registrar los datos del Provincia,a travez del procedimiento almacenado 
    ''' STD.Isp_Provincia_IAE,por el cual van a ser enviados y registrados los datos del Provincia y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeProvincia">Recibe una variable oeProvincia de tipo e_Provincia</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro del 
    ''' Provincia es positiva= true sino false,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeProvincia As e_Provincia) As Boolean
        Try
            With oeProvincia
                sqlhelper.ExecuteNonQuery("STD.Isp_Provincia_IAE", .TipoOperacion, .Id, .CodigoDepartamento, .Codigo, .Nombre, .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro del Provincia,a travez del procedimiento almacenado
    ''' STD.Isp_Provincia_IAE,por el cual va a ser enviado el id del Provincia a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeProvincia">Recibe una variable oeProvincia de tipo objeto e_Provincia</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Eliminar(ByVal oeProvincia As e_Provincia) As Boolean
        Try
            With oeProvincia
                sqlhelper.ExecuteNonQuery("STD.Isp_Provincia_IAE", "E", "", .Id)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
