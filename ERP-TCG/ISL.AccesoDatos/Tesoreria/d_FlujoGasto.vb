'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient


Public Class d_FlujoGasto
    Private sqlhelper As New SqlHelper

    Private oeFlujoCaja As New e_FlujoCaja
    Private oeItemGasto As New e_ItemGasto
    Private odCuentaFlujoCaja As New d_CuentaFlujoCaja


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
            Using transScope As New TransactionScope()

                With oeFlujoGasto
                    stResultado = sqlhelper.ExecuteScalar("TES.Isp_FlujoCaja_IAE", .TipoOperacion,
                                                .Id,
                                                .Codigo,
                                                .Nombre,
                                                .Abreviatura,
                                                .Activo,
                                                .PrefijoID,
                                                Date.Now,
                                                .UsuarioCreacion,
                                                .IdItemGasto,
                                                .IndMovimiento).ToString.Split("_")
                End With
                For Each CuentaFlujoCaja As e_CuentaFlujoCaja In oeFlujoGasto.ListaCuentaFlujoCaja
                    CuentaFlujoCaja.IdFlujoCaja = stResultado(0)
                    CuentaFlujoCaja.PrefijoID = oeFlujoCaja.PrefijoID '@0001
                    odCuentaFlujoCaja.Guardar(CuentaFlujoCaja)
                Next
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

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
