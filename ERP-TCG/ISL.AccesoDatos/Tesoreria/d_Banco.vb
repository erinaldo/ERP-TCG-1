Imports ISL.EntidadesWCF

''' <summary>
''' Clase que se encarga de gestionar los bancos asociados a la empresa
''' </summary>
''' <example> Este ejemplo muestra como cargar una clase de tipo d_Banco 
''' <code>
'''    Dim odBanco As New d_Banco
''' </code>
''' </example>
''' <remarks>Esta clase controla los metodos de accesos la tabla Banco<see cref="e_Banco"/><seealso cref="e_Empresa"/></remarks>
Public Class d_Banco
    Private sqlhelper As New SqlHelper

    Private oeBanco As e_Banco

    Private Function Cargar(ByVal o_fila As DataRow) As e_Banco
        Try
            Dim oebanco = New e_Banco( _
            o_fila("Id"), o_fila("Codigo"), o_fila("Nombre"), o_fila("Abreviatura"), o_fila("Activo"))
            Return oebanco
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    ''' <summary>
    ''' El metodo se encarga de obtener un banco específico, a partir de algunos datos cargados en el objeto e_Banco
    ''' que se le pasa como parámetro
    ''' </summary>
    ''' <param name="oeBanco">Recibe una variable oeBanco de tipo e_Banco.</param>
    ''' <returns>Devuelve un objeto de tipo e_Banco
    ''' </returns>
    ''' <example> Este ejemplo muestra como obtener el Id del objeto de tipo <see cref="e_Banco"/>, a partir de su nombre 
    ''' <code>
    ''' 
    ''' Dim odBanco As New d_Banco
    ''' Dim oeBanco as New e_Banco 
    ''' 
    ''' Public Function ObtenerIdBanco(ByVal nombreBanco As String) As String
    '''     Try
    '''         oeBanco.Activo = True
    '''         oeBanco.Nombre = nombreBanco
    '''        oeBanco = odBanco.Obtener(oeBanco)
    '''         Return oeBanco.Id
    '''     Catch ex As Exception
    '''         Throw
    '''     End Try
    '''  End Function
    ''' 
    ''' </code>
    ''' </example>
    ''' <remarks>Clase que controla los metodos de accesos la tabla Banco, a través del objeto <see cref="e_Banco"/><seealso cref="e_Empresa"/></remarks>
    Public Function Obtener(ByVal oeBanco As e_Banco) As e_Banco
        Try
            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_Banco_Listar", "", oeBanco.Id, oeBanco.Nombre, oeBanco.Codigo)
            oeBanco = New e_Banco
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeBanco = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeBanco
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Caso especial para obtener la situación administrativa específica a partir de su Id
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal id As String) As e_Banco
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_Banco_Listar", "", oeBanco.Id)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeBanco = Cargar(ds.Tables(0).Rows(0))
            Else
                oeBanco = New e_Banco
            End If
            Return oeBanco
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Esta función permite generar una lista de Bancos o EntidadesWCF financieras, a partir de algunos datos cargados en el objeto e_Banco
    ''' que se le pasa como parámetro
    ''' </summary>
    ''' <param name="oeBanco">Recibe una variable oeBanco de tipo e_Banco.</param>
    ''' <returns>Devuelve una lista de objetos de tipo e_Banco
    ''' </returns>
    ''' <example> Este ejemplo muestra como obtener una lista de todos los objetos de tipo <see cref="e_Banco"/> se encuentran Activos en el sistema
    ''' <code>
    ''' 
    ''' Public Function ListarBancosActivos(ByVal oeBanco As e_Banco) As List(Of e_Banco)
    '''     Try
    '''         oeBanco.Activo = True
    '''         Dim odBanco As New d_Banco
    '''         Return odBanco.Listar(oeBanco)
    '''     Catch ex As Exception
    '''         Throw
    '''     End Try
    ''' End Function
    ''' 
    ''' </code>
    ''' </example>
    ''' <remarks>Este método genera una lista de Bancos, a partir del objeto <see cref="e_Banco"/><seealso cref="e_Empresa"/> que se pasa como parámetro</remarks>
    Public Function Listar(ByVal oeBanco As e_Banco) As List(Of e_Banco)
        Try
            Dim ldBanco As New List(Of e_Banco)
            Dim ds As DataSet
            With oeBanco
                ds = sqlhelper.ExecuteDataset("TES.Isp_Banco_Listar", "", .Id, .Codigo, _
                        .Nombre, .Abreviatura, .Activo)
            End With
            oeBanco = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeBanco = Cargar(o_Fila)
                    ldBanco.Add(oeBanco)
                Next
                Return ldBanco
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Esta función permite Guardar o Grabar la información de un Banco o EntidadesWCF financiera específico, a partir de algunos datos cargados en el objeto e_Banco
    ''' que se le pasa como parámetro
    ''' </summary>
    ''' <param name="oeBanco">Recibe una variable oeBanco de tipo <see cref="e_Banco"/></param>
    ''' <returns>Devuelve un valor de tipo booleano, True en caso la grabación sea exitosa, False en caso se haya presentado algún tipo de error al momento de grabar
    ''' </returns>
    ''' <example> Este ejemplo muestra como Guardar la información de un banco, habiendo cargado directamente en el objeto los datos de éste
    ''' <code>
    ''' 
    ''' Sub GrabarBanco()
    '''    Try
    '''        Dim oeBanco as new e_Banco
    '''        Dim odBanco As New d_Banco
    '''
    '''        oeBanco.Activo = True
    '''        oeBanco.Codigo = "001"
    '''        oeBanco.Nombre = "Banco de la Nación"
    '''     
    '''        if odBanco.Guardar(oeBanco) Then 
    ''' Thow New Exception("El banco fue grabado exitosamente")
    ''' 
    ''' EndSub
    ''' 
    ''' 
    ''' </code>
    ''' </example>
    ''' <remarks>Este método genera una lista de Bancos, a partir del objeto <see cref="e_Banco"/><seealso cref="e_Empresa"/> que se pasa como parámetro</remarks>
    Public Function Guardar(ByVal oeBanco As e_Banco) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            With oeBanco
                sqlhelper.ExecuteNonQuery("TES.Isp_Banco_IAE", .TipoOperacion, _
                .Id, .Codigo, .Nombre, .Abreviatura, .Activo, .PrefijoID)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro del tipo de documento,a travez del procedimiento almacenado
    ''' STD.Isp_TipoDocumento_IAE,por el cual va a ser enviado el id del tipo de documento a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeBanco">Recibe una variable oeBanco de tipo objeto e_Banco</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Eliminar(ByVal oeBanco As e_Banco) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_Banco_IAE", "E", oeBanco.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
