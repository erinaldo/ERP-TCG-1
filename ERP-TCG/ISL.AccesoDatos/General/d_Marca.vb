Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient
''' <summary>
''' Clase que gestiona la marca 
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla Marca,Capa del Sistema: Capa de Acceso a Datos.</remarks>

Public Class d_Marca
    Private oeMarca As e_Marca
    Private sqlhelper As New SqlHelper


    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_Marca y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeMarca) de tipo e_Marca</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Private Function Cargar(ByVal o_fila As DataRow) As e_Marca
        Try
            oeMarca = New e_Marca( _
            o_fila("Id"), _
            o_fila("Codigo"), _
            o_fila("Nombre"), _
            o_fila("Abreviatura"), _
            o_fila("Activo"), _
            o_fila("Tipo"))
            Return oeMarca
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    ''' <summary>
    ''' Metodo que obtiene una marca, el cual es consultado por el procedimiento almacenado MAN.Isp_Marca_Listar
    ''' enviando su id de la marcaj.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_Marca.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeMarca">Recibe una variable oeMarca de tipo e_Marca</param>
    ''' <returns>Devuelve una varible oeMarca de tipo e_Marca</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeMarca As e_Marca) As e_Marca
        Try
            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_Marca_Listar", "", oeMarca.Id, 9, oeMarca.Nombre)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeMarca = Cargar(ds.Tables(0).Rows(0))
            Else
                oeMarca = Nothing
            End If
            Return oeMarca
        Catch ex As Exception
            Throw
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_Marca, el cual es consultado por el procedimiento almacenado [MAN].[Isp_Marca_Listar]
    ''' enviando sus atributos de la marca.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeMarca">Recibe una Variable oeMarca de tipo e_Marca </param>
    ''' <returns>Devuelve una lista generica(ldMarca) de objetos de tipo e_Marca</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeMarca As e_Marca) As List(Of e_Marca)
        Try
            Dim ldMarca As New List(Of e_Marca)
            Dim ds As DataSet
            With oeMarca
                ds = sqlhelper.ExecuteDataset("STD.Isp_Marca_Listar", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .TipoMarca)
            End With
            oeMarca = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMarca = Cargar(o_Fila)
                    ldMarca.Add(oeMarca)
                Next
            Else
                ldMarca = New List(Of e_Marca)
            End If
            Return ldMarca
        Catch ex As Exception
            Throw
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los datos de la marca,a travez del procedimiento almacenado
    ''' [STD].[ISP_Marca_IAE],por el cual van a ser enviados y registrados los datos de la marca y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeMarca">Recibe una variable oeMarca de tipo e_Marca</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del 
    ''' registro de tipo de documento es positiva= true sino false,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeMarca As e_Marca) As Boolean
        Dim d_DatosConfiguracion As New d_DatosConfiguracion
        Try
            With oeMarca
                sqlhelper.ExecuteNonQuery("STD.ISP_Marca_IAE", .TipoOperacion, _
                .PrefijoID, .Id, .Codigo, .Nombre, .Abreviatura, .Activo, _
                .UsuarioCreacion, .TipoMarca)
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro de la marca,a travez del procedimiento almacenado
    ''' [STD].[ISP_Marca_IAE],por el cual va a ser enviado el id de la marca a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeMarca">Recibe una variable oeMarca de tipo objeto e_Marca</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Eliminar(ByVal oeMarca As e_Marca) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("STD.ISP_Marca_IAE", oeMarca.TipoOperacion, "", oeMarca.Id)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function ComboGrilla(loMarca As List(Of e_Marca))
        Dim ds = New DataTable
        ds.Columns.Add("Id")
        ds.Columns.Add("Nombre")
        For Each item As e_Marca In loMarca
            Dim newRow As DataRow = ds.NewRow()
            newRow("Id") = item.Id
            newRow("Nombre") = item.Nombre
            ds.Rows.Add(newRow)
        Next
        Return ds
    End Function

End Class
