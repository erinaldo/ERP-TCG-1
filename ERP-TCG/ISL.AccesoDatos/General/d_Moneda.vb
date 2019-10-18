'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Moneda
    Private sqlhelper As New SqlHelper


    Public Function Cargar(ByVal o_fila As DataRow) As e_Moneda
        Try
            Dim oeMoneda = New e_Moneda(o_fila("Id").ToString, o_fila("CodigoSunat").ToString, o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString, o_fila("IdPais").ToString, o_fila("Activo").ToString)
            Return oeMoneda
        Catch ex As Exception
            Throw ex
        End Try
    End Function

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

    Public Function Listar(ByVal oeMoneda As e_Moneda) As List(Of e_Moneda)
        Try
            Dim ldMoneda As New List(Of e_Moneda)
            Dim ds As DataSet
            With oeMoneda
                ds = sqlhelper.ExecuteDataset("STD.Isp_Moneda_Listar", .TipoOperacion, .Id, .Nombre, .Codigo,
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

    Public Function Guardar(ByVal oeMoneda As e_Moneda) As Boolean
        Try
            With oeMoneda
                sqlhelper.ExecuteNonQuery("CON.ISP_XXXXXXXXXXXXXXX_IAE", .TipoOperacion, .PrefijoID, .Id,
                        .Codigo, .Nombre, .Abreviatura, .IdPais, .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

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
