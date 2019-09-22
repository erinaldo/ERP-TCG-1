Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Periodo

    Private sqlhelper As New SqlHelper

    ''' <summary>
    ''' Crear el objeto Ejercicio 
    ''' </summary>
    ''' <param name="o_fila"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Cargar(ByVal o_fila As DataRow) As e_Periodo
        Try
            Dim oePeriodo = New e_Periodo( _
            o_fila("Id"), o_fila("Codigo"), o_fila("Ejercicio"), o_fila("Mes"), _
            o_fila("FechaInicio"), o_fila("FechaFin"), o_fila("CierreCompras"), o_fila("CierreVentas"), _
            o_fila("CierreAlmacen"), o_fila("CierrreTesoreria"), o_fila("CierreCajaLiquidacion"), o_fila("CierreContabilidad"), _
            o_fila("CambioCompraCierre"), o_fila("CambioVentaCierre"), o_fila("Activo"), o_fila("CierreCombustible"), _
            o_fila("CierrePlanilla"))
            Return oePeriodo
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    ''' <summary>
    ''' Obtiene un objeto de Ejercicio a partir de su Id
    ''' </summary>
    ''' <param name="oePeriodo ">Objeto de Ejercicio</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal oePeriodo As e_Periodo) As e_Periodo
        Try
            Dim ds As DataSet
            With oePeriodo
                ds = sqlhelper.ExecuteDataset("CON.ISP_Periodo_Listar", .TipoOperacion, .Id, .Codigo, .Ejercicio, .Mes, .Activo)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oePeriodo = Cargar(ds.Tables(0).Rows(0))
            Else
                oePeriodo = New e_Periodo
            End If
            Return oePeriodo
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Crear una lista de objetos de Ejercicio
    ''' </summary>
    ''' <param name="oePeriodo "></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Listar(ByVal oePeriodo As e_Periodo) As List(Of e_Periodo)
        Try
            Dim ldPeriodo As New List(Of e_Periodo)
            Dim ds As DataSet
            With oePeriodo
                ds = sqlhelper.ExecuteDataset("CON.ISP_Periodo_Listar", .TipoOperacion, .Id, .Codigo, _
                .Ejercicio, .Mes, .Activo, .IndCierre)
            End With
            oePeriodo = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oePeriodo = Cargar(o_Fila)
                    ldPeriodo.Add(oePeriodo)
                Next
            End If
            Return ldPeriodo
            
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oePeriodo As e_Periodo) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            With oePeriodo
                sqlhelper.ExecuteNonQuery("CON.ISP_Periodo_IAE", .TipoOperacion, _
                .PrefijoID, .Id, .Codigo, .Ejercicio, .Mes, _
                .FechaInicio, .FechaFin, .CierreCompras, .CierraVentas, .CierreAlmacen, .CierreTesoreria, .CierreContabilidad, _
                .CambioCompra, .CambioVenta, .Activo, .CierreCombustible, .CierrePlanilla, .CierreCajaLiquidacion)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try

    End Function

    Public Function Eliminar(ByVal oePeriodo As e_Periodo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.ISP_Periodo_IAE", "E", "", oePeriodo.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
