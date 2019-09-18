Imports ISL.EntidadesWCF
Imports System.Transactions

''' <summary>
''' Clase que controla los metodos de accesos la tabla Tipo de Documento.  
''' Fecha Actualizada:31/10/2011
''' </summary>
''' <remarks>Por ejemplo tipo de documentos como Demanda,Boleta de Venta,etc,Capa del Sistema:Capa de Acceso a Datos</remarks>
Public Class d_TipoDocumento

    Private oetipoDocumento As e_TipoDocumento
    Private oeDocumentoImpuesto As New e_DocumentoImpuesto
    Private odDocumentoImpuesto As New d_DocumentoImpuesto

    Private sqlhelper As New SqlHelper

    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_TipoDocumento y enviada al metodo que lo utilizo.
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeTipoDocumento) de tipo e_TipoDocumento</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Cargar(ByVal o_fila As DataRow) As e_TipoDocumento
        Try
            Dim oeTipoDocumento = New e_TipoDocumento( _
            o_fila("Id"), o_fila("CodigoSunat"), o_fila("Nombre"), o_fila("Abreviatura"), _
             o_fila("Activo"), o_fila("IndIgv"))
            Return oeTipoDocumento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene un tipo de documento, el cual es consultado por el procedimiento almacenado STD.ISP_TipoDocumento_Listar
    ''' enviando su id del tipo de documento.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_TipoDocumento.
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoDocumento">Recibe una variable oeTipoDocumento de tipo e_TipoDocumento</param>
    ''' <returns>Devuelve una varible oeTipoDocumento de tipo e_TipoDocumento</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeTipoDocumento As e_TipoDocumento) As e_TipoDocumento
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.ISP_TipoDocumento_Listar", oeTipoDocumento.TipoOperacion, oeTipoDocumento.Id, "", oeTipoDocumento.Nombre)
            oeTipoDocumento = New e_TipoDocumento
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeTipoDocumento = Cargar(ds.Tables(0).Rows(0))
                oeDocumentoImpuesto.IdTipoDocumento = oeTipoDocumento.Id
                oeTipoDocumento.leDocumentoImpuesto = odDocumentoImpuesto.Listar(oeDocumentoImpuesto)
            End If
            Return oeTipoDocumento
        Catch ex As Exception
            Throw
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_TipoDocumento, el cual es consultado por el procedimiento 
    ''' almacenado STD.Isp_TipoDocumento_Listar enviando sus atributos del tipo de documento.Una vez obtenido los registros 
    ''' son cargados y devueltos en una lista generica.
    ''' </summary>
    ''' <param name="oeTipoDocumento">Recibe una Variable oeTipoDocumento de tipo e_TipoDocumento </param>
    ''' <returns>Devuelve una lista generica(ldTipoMantenimiento) de objetos de tipo e_TipoDocumento</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeTipoDocumento As e_TipoDocumento) As List(Of e_TipoDocumento)
        Try
            Dim ldTipoMantenimiento As New List(Of e_TipoDocumento)
            Dim ds As DataSet
            With oeTipoDocumento
                ds = sqlhelper.ExecuteDataset("STD.Isp_TipoDocumento_Listar", .TipoOperacion, .Id, .Codigo, _
                        .Nombre, .Abreviatura)
            End With
            oeTipoDocumento = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTipoDocumento = Cargar(o_Fila)
                    ldTipoMantenimiento.Add(oeTipoDocumento)
                Next
            Else
                ldTipoMantenimiento = New List(Of e_TipoDocumento)
            End If
            Return ldTipoMantenimiento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ComboGrilla(ByVal TipoDocumento As List(Of e_TipoDocumento))
        Dim ds = New DataTable
        ds.Columns.Add("Id")
        ds.Columns.Add("Nombre")
        For Each item As e_TipoDocumento In TipoDocumento
            Dim newRow As DataRow = ds.NewRow()
            newRow("Id") = item.Id
            newRow("Nombre") = item.Nombre
            ds.Rows.Add(newRow)
        Next
        Return ds
    End Function


    ''' <summary>
    ''' Metodo que se encargara de registrar los datos del tipo de documento,a travez del procedimiento almacenado
    ''' STD.Isp_TipoDocumento_IAE,por el cual van a ser enviados y registrar los datos del tipo de documento y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoDocumento">Recibe una variable oeTipoDocumento de tipo e_TipoDocumento</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro de 
    ''' tipo de documento es positiva= true sino false,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeTipoDocumento As e_TipoDocumento) As Boolean
        Dim d_DatosConfiguracion As New d_DatosConfiguracion
        Try
            Using TransScope As New TransactionScope()
                Dim id As String = ""
                With oeTipoDocumento
                    id = sqlhelper.ExecuteScalar("STD.Isp_TipoDocumento_IAE", .TipoOperacion, _
                    .PrefijoID, .Id, .Codigo, .Nombre, .Abreviatura, _
                     .Activo)
                End With
                If oeTipoDocumento.leDocumentoImpuesto IsNot Nothing Then
                    For Each oeDocumentoImpuesto As e_DocumentoImpuesto In oeTipoDocumento.leDocumentoImpuesto
                        oeDocumentoImpuesto.IdTipoDocumento = id
                        odDocumentoImpuesto.Guardar(oeDocumentoImpuesto)
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
    ''' Metodo que se encargara de desactivar un regitro del tipo de documento,a travez del procedimiento almacenado
    ''' STD.Isp_TipoDocumento_IAE,por el cual va a ser enviado el id del tipo de documento a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha Actualizada:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoDocumento">Recibe una variable oeTipoDocumento de tipo objeto e_TipoDocumento</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Si la confirmacion del registro de tipo de documento es
    '''  positiva= true sino false,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Eliminar(ByVal oeTipoDocumento As e_TipoDocumento) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_TipoDocumento_IAE", "E", "", _
                                      oeTipoDocumento.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
