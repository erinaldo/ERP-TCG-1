Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class d_ItemGasto

    Private sqlhelper As New SqlHelper
    Private odCuentaItemGasto As New d_CuentaItemGasto

    Private Function Cargar(ByVal o_fila As DataRow) As e_ItemGasto
        ' 
        Try
            Dim oeItemGasto = New e_ItemGasto( _
                             o_fila("Id").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("IdCuentaContable").ToString _
                             , o_fila("Activo").ToString _
                              , o_fila("Cuenta").ToString _
                               , o_fila("Ejercicio") _
                               , o_fila("IdTablaContableDet").ToString _
                               , o_fila("UsuarioCrea").ToString _
                               , o_fila("FechaCrea").ToString)
            Return oeItemGasto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeItemGasto As e_ItemGasto) As e_ItemGasto

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.ISP_ItemGasto_Listar", oeItemGasto.TipoOperacion, oeItemGasto.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeItemGasto = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeItemGasto
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Buscar(ByVal oeItemGasto As e_ItemGasto) As Boolean

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.ISP_ItemGasto_Listar", oeItemGasto.TipoOperacion, oeItemGasto.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeItemGasto As e_ItemGasto) As List(Of e_ItemGasto)
        Try
            Dim ldItemGasto As New List(Of e_ItemGasto)
            Dim ds As DataSet
            With oeItemGasto
                ds = sqlhelper.ExecuteDataset("CON.ISP_ItemGasto_Listar", .TipoOperacion _
                        , .Id _
                        , .Nombre _
                        , .IdCuentaContable _
                        , .Activo _
                        , .Ejercicio)
            End With
            oeItemGasto = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeItemGasto = Cargar(o_Fila)
                    ldItemGasto.Add(oeItemGasto)
                Next
            End If
            Return ldItemGasto

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDS(ByVal oeItemGasto As e_ItemGasto) As DataSet
        Try
            Dim ldItemGasto As New List(Of e_ItemGasto)
            Dim ds As DataSet
            With oeItemGasto
                ds = sqlhelper.ExecuteDataset("CON.ISP_ItemGasto_Listar", .TipoOperacion _
                        , .Id _
                        , .Nombre _
                        , .IdCuentaContable _
                        , .Activo _
                        , .Ejercicio)
            End With
            Return ds
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarBind(ByVal oeItemGasto As e_ItemGasto) As BindingList(Of e_ItemGasto)
        Try
            Dim ldItemGasto As New BindingList(Of e_ItemGasto)
            Dim ds As DataSet
            With oeItemGasto
                ds = sqlhelper.ExecuteDataset("CON.ISP_ItemGasto_Listar", .TipoOperacion _
                        , .Id _
                        , .Nombre _
                        , .IdCuentaContable _
                        , .Activo _
                        , .Ejercicio _
                        )
            End With
            oeItemGasto = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeItemGasto = Cargar(o_Fila)
                    ldItemGasto.Add(oeItemGasto)
                Next
            End If
            Return ldItemGasto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeItemGasto As e_ItemGasto) As Boolean
        Dim stResultado() As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Using transScope As New TransactionScope()
                With oeItemGasto
                    stResultado = sqlhelper.ExecuteScalar("CON.ISP_ItemGasto_IAE", _
                                                          .TipoOperacion, _
                                                          d_DatosConfiguracion.PrefijoID, _
                                                          .Id _
                                                          , .Nombre _
                                                          , .IdTablaContableDet _
                                                          , .UsuarioCrea).ToString.Split("_")
                End With
                For Each CuentaItemGasto As e_CuentaItemGasto In oeItemGasto.ListaCuentaItemGasto
                    CuentaItemGasto.IdItemGasto = stResultado(0)
                    odCuentaItemGasto.Guardar(CuentaItemGasto)
                Next
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeItemGasto As e_ItemGasto) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.ISP_ItemGasto_IAE", "E", _
                                        "",
                                        oeItemGasto.Id _
                                        , "" _
                                        , "" _
                                        , oeItemGasto.UsuarioCrea)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
