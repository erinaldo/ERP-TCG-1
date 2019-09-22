Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient
''' <summary>
''' Clase que gestiona las monedas con las que trabaja la empresa.
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla Moneda,Capa del Sistema: Capa de Acceso a Datos.</remarks>

Public Class d_Moneda
    Private sqlhelper As New SqlHelper

    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_Moneda y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeMoneda) de tipo e_Moneda</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Cargar(ByVal o_fila As DataRow) As e_Moneda
        Try
            Dim oeMoneda = New e_Moneda(o_fila("Id").ToString, o_fila("CodigoSunat").ToString, o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString, o_fila("IdPais").ToString, o_fila("Activo").ToString)
            Return oeMoneda
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene un moneda, el cual es consultado por el procedimiento almacenado STD.Isp_Moneda_Listar
    ''' enviando su id de la moneda.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_Moneda.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeMoneda">Recibe una variable oeMoneda de tipo e_Moneda</param>
    ''' <returns>Devuelve una varible oeMoneda de tipo e_Moneda</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeMoneda As e_Moneda) As e_Moneda

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_Moneda_Listar", "", oeMoneda.Id, oeMoneda.Nombre)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeMoneda = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMoneda
        Catch ex As Exception
            Throw
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_Moneda, el cual es consultado por el procedimiento almacenado STD.Isp_Moneda_Listar
    ''' enviando sus atributos de la moneda.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeMoneda">Recibe una Variable oeMoneda de tipo e_Moneda </param>
    ''' <returns>Devuelve una lista generica(ldMoneda) de objetos de tipo e_Moneda</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeMoneda As e_Moneda) As List(Of e_Moneda)
        Try
            Dim ldMoneda As New List(Of e_Moneda)
            Dim ds As DataSet
            With oeMoneda
                ds = sqlhelper.ExecuteDataset("STD.Isp_Moneda_Listar", .TipoOperacion, .Id, .Nombre, .Codigo, _
                        .Abreviatura, .IdPais, .Activo)
            End With
            oeMoneda = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMoneda = Cargar(o_Fila)
                    ldMoneda.Add(oeMoneda)
                Next
            End If
            Return ldMoneda
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ComboGrilla(ByVal ListaMoneda As List(Of e_Moneda))
        Dim ds = New DataTable
        ds.Columns.Add("Id")
        ds.Columns.Add("Nombre")
        For Each item As e_Moneda In ListaMoneda
            Dim newRow As DataRow = ds.NewRow()
            newRow("Id") = item.Id
            newRow("Nombre") = item.Abreviatura
            ds.Rows.Add(newRow)
        Next
        Return ds
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los datos de la moneda,a travez del procedimiento almacenado
    ''' CON.ISP_XXXXXXXXXXXXXXX_IAE,por el cual van a ser enviados y registrados los datos de la moneda y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeMoneda">Recibe una variable oeMoneda de tipo e_Moneda</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro
    '''  de la moneda es positiva= true sino false,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeMoneda As e_Moneda) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            With oeMoneda
                sqlhelper.ExecuteNonQuery("CON.ISP_XXXXXXXXXXXXXXX_IAE", .TipoOperacion, .PrefijoID, .Id, _
                        .Codigo, .Nombre, .Abreviatura, .IdPais, .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro de la moneda,a travez del procedimiento almacenado
    ''' CON.ISP_XXXXXXXXXXXXXXX_IAE,por el cual va a ser enviado el id de la moneda a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeMoneda">Recibe una variable oeMoneda de tipo objeto e_Moneda</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Eliminar(ByVal oeMoneda As e_Moneda) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("CON.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeMoneda.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
