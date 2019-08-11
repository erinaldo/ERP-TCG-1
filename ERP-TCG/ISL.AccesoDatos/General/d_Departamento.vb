Imports ISL.EntidadesWCF

''' <summary>
''' Clase que permite el acceso de los datos de los Departamentos del Perú, desde la tabla UBIGEO
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla Ubigeo,Capa del Sistema: Capa de Acceso a Datos.</remarks>
Public Class d_Departamento
    Private sqlhelper As New SqlHelper

    Private oeDepartamento As New e_Departamento
    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_Departamento y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeDepartamento) de tipo e_Departamento</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Cargar(ByVal fila As DataRow) As e_Departamento
        Try
            Dim oeDepartamento = New e_Departamento(fila("Id"), fila("CODDPTO"), fila("Nombre"), fila("Activo"))
            Return oeDepartamento
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene un departamento, el cual es consultado por el procedimiento almacenado STD.Isp_Departamento_Listar
    ''' enviando su id del departamento.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_Departamento.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeDepartamento">Recibe una variable oeDepartamento de tipo e_Departamento</param>
    ''' <returns>Devuelve una varible oeDepartamento de tipo e_Departamento</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeDepartamento As e_Departamento) As e_Departamento
        Try
            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_Departamento_Listar", "", oeDepartamento.Id)
            If ds.Tables.Count > 0 Then
                oeDepartamento = Cargar(ds.Tables(0).Rows(0))
                Return oeDepartamento
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_Departamento, el cual es consultado por el procedimiento almacenado Isp_Departamento_Listar
    ''' enviando sus atributos del departamento.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeDepartamento">Recibe una Variable oeDepartamento de tipo e_Departamento </param>
    ''' <returns>Devuelve una lista generica(lista) de objetos de tipo e_Departamento</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeDepartamento As e_Departamento) As List(Of e_Departamento)
        Try
            Dim ds As New DataSet
            Dim lista As New List(Of e_Departamento)
            With oeDepartamento
                ds = sqlhelper.ExecuteDataset("STD.Isp_Departamento_Listar", "", .Id, .Codigo, _
                        .Nombre, .Activo)
                If ds.Tables.Count > 0 Then
                    For Each fila As DataRow In ds.Tables(0).Rows
                        oeDepartamento = Cargar(fila)
                        lista.Add(oeDepartamento)
                    Next
                    Return lista
                Else
                    Return Nothing
                End If
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los datos del departamento,a travez del procedimiento almacenado 
    ''' STD.Isp_Departamento_IAE,por el cual van a ser enviados y registrados los datos del departamento y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeDepartamento">Recibe una variable oeDepartamento de tipo e_Departamento</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro del 
    ''' departamento es positiva= true sino false,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeDepartamento As e_Departamento) As Boolean
        Try
            With oeDepartamento
                sqlhelper.ExecuteNonQuery("STD.Isp_Departamento_IAE", .TipoOperacion, .Id, .Codigo, .Nombre, .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro del departamento,a travez del procedimiento almacenado
    ''' STD.STD.Isp_Departamento_IAE,por el cual va a ser enviado el id del departamento a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeDepartamento">Recibe una variable oeDepartamento de tipo objeto e_Departamento</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Eliminar(ByVal oeDepartamento As e_Departamento) As Boolean
        Try
            With oeDepartamento
                sqlhelper.ExecuteNonQuery("STD.Isp_Departamento_IAE", .TipoOperacion, .Id)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
