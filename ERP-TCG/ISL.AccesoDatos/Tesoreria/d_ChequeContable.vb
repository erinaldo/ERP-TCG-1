Imports ISL.EntidadesWCF
''' <summary>
''' Clase que gestiona los cheques contables de la empresa.  
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla TES.ChequeContable,Capa del sistema:Capa de Acceso a Datos</remarks>

Public Class d_ChequeContable

    Private sqlhelper As New SqlHelper
    Private oeChequeContable As e_ChequeContable

    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_ChequeContable y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeChequeContable) de tipo e_ChequeContable</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Private Function Cargar(ByVal o_fila As DataRow) As e_ChequeContable
        Try
            Dim oeChequeContable = New e_ChequeContable(o_fila("Id"), o_fila("IdCuentaBancaria"), o_fila("IdBanco"), o_fila("Nombre"), o_fila("NumeroCuenta"), _
            o_fila("NumeroChequera"), o_fila("Fecha"), o_fila("NumeroInicial"), o_fila("NumeroFinal"), o_fila("NumeroEmitir"), _
            o_fila("Activo"))
            Return oeChequeContable
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    ''' <summary>
    ''' Metodo que obtiene un cheque contable, el cual es consultado por el procedimiento almacenado TES.Isp_ChequeContable_Listar
    ''' enviando su id del cheque contable.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo -.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeChequeContable">Recibe una variable oeChequeContable de tipo e_ChequeContable</param>
    ''' <returns>Devuelve una varible oeChequeContable de tipo e_ChequeContable</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeChequeContable As e_ChequeContable) As e_ChequeContable
        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("TES.Isp_ChequeContable_Listar", "", oeChequeContable.Id)
            If ds.Tables.Count > 0 Then
                oeChequeContable = Cargar(ds.Tables(0).Rows(0))
                Return oeChequeContable
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_TipoDocumento, el cual es consultado por el procedimiento almacenado STD.Isp_TipoDocumento_Listar
    ''' enviando sus atributos del tipo de documento.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeChequeContable">Recibe una Variable oeChequeContable de tipo e_ChequeContable </param>
    ''' <returns>Devuelve una lista generica(ldChequeContable) de objetos de tipo e_ChequeContable</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeChequeContable As e_ChequeContable) As List(Of e_ChequeContable)
        Try
            Dim ldChequeContable As New List(Of e_ChequeContable)
            Dim ds As DataSet
            With oeChequeContable
                ds = SqlHelper.ExecuteDataset("TES.Isp_ChequeContable_Listar", "", .Id, .IdCuentaBancaria, .Activo)
            End With
            oeChequeContable = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeChequeContable = Cargar(o_Fila)
                    ldChequeContable.Add(oeChequeContable)
                Next
                Return ldChequeContable
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los datos del cheque contable,a travez del procedimiento almacenado
    ''' TES.Isp_ChequeContable_IAE,por el cual van a ser enviados y registrados los datos del cheque contable y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeChequeContable">Recibe una variable oeChequeContable de tipo e_ChequeContable</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro 
    ''' de tipo de documento es positiva= true sino false Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeChequeContable As e_ChequeContable) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            With oeChequeContable
                sqlhelper.ExecuteNonQuery("TES.Isp_ChequeContable_IAE", .TipoOperacion, _
            .Id, .IdCuentaBancaria, .NumeroChequera, .Fecha, .NumeroInicial, .NumeroFinal, _
            .NumeroEmitir, .Activo, .PrefijoID)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro del cheque contable,a travez del procedimiento almacenado
    ''' TES.Isp_ChequeContable_IAE,por el cual va a ser enviado el id del cheque contable a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeChequeContable">Recibe una variable oeChequeContable de tipo objeto e_ChequeContable</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Eliminar(ByVal oeChequeContable As e_ChequeContable) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("TES.Isp_ChequeContable_IAE", "E", oeChequeContable.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
