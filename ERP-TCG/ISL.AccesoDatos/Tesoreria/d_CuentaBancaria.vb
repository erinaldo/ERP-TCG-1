Imports ISL.EntidadesWCF

Public Class d_CuentaBancaria
    Private sqlhelper As New SqlHelper

    Private oeCuentaBancaria As e_CuentaBancaria

    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_CuentaBancaria y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeCuentaBancaria) de tipo e_CuentaBancaria </returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Cargar(ByVal o_fila As DataRow) As e_CuentaBancaria
        Try
            Dim oeCuentaBancaria = New e_CuentaBancaria(o_fila("Seleccion").ToString, _
            o_fila("Id"), o_fila("IdBanco"), o_fila("NombreBanco"), o_fila("NumeroCuenta"), o_fila("NombreMoneda"), o_fila("IdMoneda"), _
            o_fila("IdCuentaContable"), o_fila("SaldoInicial"), o_fila("Contacto"), o_fila("ContactoTelefono"), _
            o_fila("TasaActiva"), o_fila("TasaPasiva"), o_fila("LineaCredito"), _
            o_fila("NumeroCorrelativo"), o_fila("Activo"))
            Return oeCuentaBancaria
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    ''' <summary>
    ''' Metodo que obtiene una cuenta bancaria, el cual es consultado por el procedimiento almacenado TES.Isp_CuentaBancaria_Listar
    ''' enviando su id de la cuenta bancaria.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_CuentaBancaria.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeCuentaBancaria">Recibe una variable oeCuentaBancaria de tipo e_CuentaBancaria</param>
    ''' <returns>Devuelve una varible oeCuentaBancaria de tipo e_CuentaBancaria</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeCuentaBancaria As e_CuentaBancaria) As e_CuentaBancaria
        Try
            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_CuentaBancaria_Listar", oeCuentaBancaria.TipoOperacion, oeCuentaBancaria.Id, _
                                          oeCuentaBancaria.IdBanco, oeCuentaBancaria.NumeroCuenta, "", True, "", Date.Now.Year)
            oeCuentaBancaria = New e_CuentaBancaria
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeCuentaBancaria = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCuentaBancaria
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_CuentaBancaria, el cual es consultado por el procedimiento almacenado TES.Isp_CuentaBancaria_Listar
    ''' enviando sus atributos de la cuenta bancaria.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeCuentaBancaria">Recibe una Variable oeCuentaBancaria de tipo e_CuentaBancaria </param>
    ''' <returns>Devuelve una lista generica(ldCuentaBancaria) de objetos de tipo e_CuentaBancaria</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    ''' 
    Public Function Listar(ByVal oeCuentaBancaria As e_CuentaBancaria) As List(Of e_CuentaBancaria)
        Try
            Dim ldCuentaBancaria As New List(Of e_CuentaBancaria)
            Dim ds As DataSet
            With oeCuentaBancaria
                ds = sqlhelper.ExecuteDataset("TES.Isp_CuentaBancaria_Listar", _
                                              .TipoOperacion, .Id, _
                                              .IdBanco, .NumeroCuenta, _
                                              .IdMoneda, .Activo, _
                                              .IdCuentaContable, .Ejercicio)
            End With
            oeCuentaBancaria = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCuentaBancaria = Cargar(o_Fila)
                    ldCuentaBancaria.Add(oeCuentaBancaria)
                Next
                Return ldCuentaBancaria
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los datos de la cuenta contable,a travez del procedimiento almacenado
    ''' TES.Isp_CuentaBancaria_IAE,por el cual van a ser enviados y registrados los datos de la cuenta bancaria y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeCuentaBancaria">Recibe una variable oeCuentaBancaria de tipo e_CuentaBancaria </param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro de 
    ''' tipo de documento es positiva= true sino false Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeCuentaBancaria As e_CuentaBancaria) As Boolean

        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            With oeCuentaBancaria
                sqlhelper.ExecuteNonQuery("TES.Isp_CuentaBancaria_IAE", .TipoOperacion, _
                .Id, .IdBanco, .NumeroCuenta, .IdMoneda, .IdCuentaContable, .SaldoInicial, _
                .Contacto, .ContactoTelefono, .TasaActiva, .TasaPasiva, _
                .LineaCredito, .NumeroCorrelativo, .Activo, .PrefijoID)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar una cuenta contable,a travez del procedimiento almacenado
    ''' TES.Isp_CuentaBancaria_IAE,por el cual va a ser enviado el id del tipo de documento a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeCuentaBancaria">Recibe una variable oeCuentaBancaria de tipo objeto e_CuentaBancaria </param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Eliminar(ByVal oeCuentaBancaria As e_CuentaBancaria) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("TES.Isp_CuentaBancaria_IAE", "E", oeCuentaBancaria.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
