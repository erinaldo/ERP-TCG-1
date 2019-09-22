Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

''' <summary>
''' Clase que gestiona los flujos de caja, se entiende por ello a los flujos de entradas y salidas de caja o efectivo, en un período dado.  
''' Es la acumulación neta de activos líquidos en un periodo determinado y, por lo tanto, constituye un indicador importante de la liquidez de una empresa.
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla FlujoCaja,Capa del Sistema:Capa de Acceso a Datos.</remarks>
Public Class d_FlujoGasto
    Private sqlhelper As New SqlHelper

    Private oeFlujoCaja As New e_FlujoCaja
    Private oeItemGasto As New e_ItemGasto
    Private odCuentaFlujoCaja As New d_CuentaFlujoCaja

    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo  y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeFlujoGasto) de tipo e_FlujoGasto</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Private Function Cargar(ByVal o_fila As DataRow) As e_FlujoCaja
        Try
            Dim oeFlujoGasto = New e_FlujoCaja( _
            o_fila("Id"), o_fila("Codigo"), o_fila("Nombre"), o_fila("Abreviatura"), o_fila("Activo"), o_fila("FechaCreacion") _
            , o_fila("UsuarioCreacion").ToString, o_fila("IdItemGasto").ToString, o_fila("IdCtaContable").ToString, _
            o_fila("Ejercicio").ToString, o_fila("IdTipoCompra").ToString, o_fila("IndMovimiento"))
            Return oeFlujoGasto
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    ''' <summary>
    ''' Metodo que obtiene un flujo de caja, el cual es consultado por el procedimiento almacenado TES.Isp_FlujoGasto_Listar
    ''' enviando su id del flujo de caja.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_FlujoGasto.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeFlujoCaja">Recibe una variable oeFlujoGasto de tipo e_FlujoGasto</param>
    ''' <returns>Devuelve una varible oeFlujoGasto de tipo e_FlujoGasto</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeFlujoCaja As e_FlujoCaja) As e_FlujoCaja
        Try
            Dim ds As New DataSet
            With oeFlujoCaja
                ds = sqlhelper.ExecuteDataset("TES.Isp_FlujoCaja_Listar", _
                .TipoOperacion, .Id, .Codigo, .Nombre, .Abreviatura, True, .NombProceso, .IdTipoGastoDEtalle, .IdItemGasto)
            End With
            oeFlujoCaja = New e_FlujoCaja
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeFlujoCaja = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeFlujoCaja
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ComboGrilla(ByVal ListaFlujo As List(Of e_FlujoCaja))
        Dim ds = New DataTable
        ds.Columns.Add("Id")
        ds.Columns.Add("Nombre")
        For Each item As e_FlujoCaja In ListaFlujo
            Dim newRow As DataRow = ds.NewRow()
            newRow("Id") = item.Id
            newRow("Nombre") = item.Nombre
            ds.Rows.Add(newRow)
        Next
        Return ds
    End Function

    Public Function Buscar(ByVal oeFlujoCaja As e_FlujoCaja) As Boolean
        Try
            Dim ds As New DataSet
            With oeFlujoCaja
                ds = sqlhelper.ExecuteDataset("TES.Isp_FlujoCaja_Listar", _
                .TipoOperacion, .Id, .Codigo, .Nombre, .Abreviatura, True, .NombProceso, .IdTipoGastoDEtalle, .IdItemGasto)
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_FlujoCaja, el cual es consultado por el procedimiento almacenado TES.Isp_FlujoCaja_Listar
    ''' enviando sus atributos del flujo de caja.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeFlujoCaja">Recibe una Variable oeFlujoCaja de tipo e_FlujoCaja</param>
    ''' <returns>Devuelve una lista generica(ldFlujoCaja) de objetos de tipo e_FlujoCaja</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeFlujoCaja As e_FlujoCaja) As List(Of e_FlujoCaja)
        Try
            Dim ldFlujoGasto As New List(Of e_FlujoCaja)
            Dim ds As DataSet
            With oeFlujoCaja
                ds = sqlhelper.ExecuteDataset("TES.Isp_FlujoCaja_Listar", .TipoOperacion, .Id, .Codigo, _
                        .Nombre, .Abreviatura, .Activo, .NombProceso, .IdTipoGastoDEtalle, .IdItemGasto)
            End With
            oeFlujoCaja = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeFlujoCaja = Cargar(o_Fila)
                    ldFlujoGasto.Add(oeFlujoCaja)
                Next
                Return ldFlujoGasto
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeFlujoGasto As e_FlujoCaja) As Boolean
        Dim stResultado() As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Using transScope As New TransactionScope()

                With oeFlujoGasto
                    stResultado = sqlhelper.ExecuteScalar("TES.Isp_FlujoCaja_IAE", .TipoOperacion, _
                                                .Id, _
                                                .Codigo, _
                                                .Nombre, _
                                                .Abreviatura, _
                                                .Activo, _
                                                .PrefijoID, _
                                                Date.Now, _
                                                .UsuarioCreacion, _
                                                .IdItemGasto, _
                                                .IndMovimiento).ToString.Split("_")
                End With
                For Each CuentaFlujoCaja As e_CuentaFlujoCaja In oeFlujoGasto.ListaCuentaFlujoCaja
                    CuentaFlujoCaja.IdFlujoCaja = stResultado(0)
                    odCuentaFlujoCaja.Guardar(CuentaFlujoCaja)
                Next
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro del tipo de documento,a travez del procedimiento almacenado
    ''' STD.Isp_TipoDocumento_IAE,por el cual va a ser enviado el id del tipo de documento a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeFlujoGasto">Recibe una variable oeFlujoCaja de tipo objeto e_FlujoCaja</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Eliminar(ByVal oeFlujoGasto As e_FlujoCaja) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_FlujoCaja_IAE", "E", oeFlujoGasto.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
