Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient
''' <summary>
''' Clase que gestiona la ConceptosGenerales 
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla ConceptosGenerales,Capa del Sistema: Capa de Acceso a Datos.</remarks>

Public Class d_ConceptosGenerales
    Private oeConceptosGenerales As e_ConceptosGenerales
    Private sqlhelper As New SqlHelper

    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_ConceptosGenerales y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeConceptosGenerales) de tipo e_ConceptosGenerales</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Private Function Cargar(ByVal o_fila As DataRow) As e_ConceptosGenerales
        Try
            Dim oeConceptosGenerales = New e_ConceptosGenerales(o_fila("Id"), o_fila("IdProcesoNegocio"), o_fila("Codigo"), o_fila("Nombre"), o_fila("Abreviatura"), o_fila("Orden"), o_fila("Activo"), o_fila("Protegido"), o_fila("UsuarioCreacion"))
            Return oeConceptosGenerales
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    ''' <summary>
    ''' Metodo que obtiene una ConceptosGenerales, el cual es consultado por el procedimiento almacenado MAN.Isp_ConceptosGenerales_Listar
    ''' enviando su id de la ConceptosGeneralesj.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_ConceptosGenerales.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeConceptosGenerales">Recibe una variable oeConceptosGenerales de tipo e_ConceptosGenerales</param>
    ''' <returns>Devuelve una varible oeConceptosGenerales de tipo e_ConceptosGenerales</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeConceptosGenerales As e_ConceptosGenerales) As e_ConceptosGenerales
        Try
            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_ConceptosGenerales_Listar", "", oeConceptosGenerales.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeConceptosGenerales = Cargar(ds.Tables(0).Rows(0))
                Return oeConceptosGenerales
            Else
                oeConceptosGenerales = New e_ConceptosGenerales
                Return oeConceptosGenerales
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_ConceptosGenerales, el cual es consultado por el procedimiento almacenado [MAN].[Isp_ConceptosGenerales_Listar]
    ''' enviando sus atributos de la ConceptosGenerales.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeConceptosGenerales">Recibe una Variable oeConceptosGenerales de tipo e_ConceptosGenerales </param>
    ''' <returns>Devuelve una lista generica(ldConceptosGenerales) de objetos de tipo e_ConceptosGenerales</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeConceptosGenerales As e_ConceptosGenerales) As List(Of e_ConceptosGenerales)
        Try
            Dim ldConceptosGenerales As New List(Of e_ConceptosGenerales)
            Dim ds As New DataSet
            With oeConceptosGenerales
                ds = sqlhelper.ExecuteDataset("STD.Isp_ConceptosGenerales_Listar", "", .Id, .IdProcesoNegocio, .Codigo, .Nombre, .Abreviatura)
            End With
            oeConceptosGenerales = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeConceptosGenerales = Cargar(o_Fila)
                    ldConceptosGenerales.Add(oeConceptosGenerales)
                Next
                Return ldConceptosGenerales
            Else
                ldConceptosGenerales = New List(Of e_ConceptosGenerales)
                Return ldConceptosGenerales
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los datos de la ConceptosGenerales,a travez del procedimiento almacenado
    ''' [STD].[ISP_ConceptosGenerales_IAE],por el cual van a ser enviados y registrados los datos de la ConceptosGenerales y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeConceptosGenerales">Recibe una variable oeConceptosGenerales de tipo e_ConceptosGenerales</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del 
    ''' registro de tipo de documento es positiva= true sino false,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeConceptosGenerales As e_ConceptosGenerales) As Boolean
        Dim d_DatosConfiguracion As New d_DatosConfiguracion
        Try
            With oeConceptosGenerales
                sqlhelper.ExecuteNonQuery("STD.ISP_ConceptosGenerales_IAE", .TipoOperacion, _
                d_DatosConfiguracion.PrefijoID, .Id, .IdProcesoNegocio, .Codigo, .Nombre, .Abreviatura, .Orden, .Protegido, .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro de la ConceptosGenerales,a travez del procedimiento almacenado
    ''' [STD].[ISP_ConceptosGenerales_IAE],por el cual va a ser enviado el id de la ConceptosGenerales a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeConceptosGenerales">Recibe una variable oeConceptosGenerales de tipo objeto e_ConceptosGenerales</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Eliminar(ByVal oeConceptosGenerales As e_ConceptosGenerales) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.ISP_ConceptosGenerales_IAE", oeConceptosGenerales.TipoOperacion, "", oeConceptosGenerales.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
