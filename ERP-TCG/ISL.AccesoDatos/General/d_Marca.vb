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

Public Class d_Marca
    Private oeMarca As e_Marca
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Marca
        Try
            oeMarca = New e_Marca(
            o_fila("Id"),
            o_fila("Codigo"),
            o_fila("Nombre"),
            o_fila("Abreviatura"),
            o_fila("Activo"),
            o_fila("Tipo"))
            Return oeMarca
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function Obtener(ByVal oeMarca As e_Marca) As e_Marca
        Try
            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_Marca_Listar", "", oeMarca.Id, 9, oeMarca.Nombre)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeMarca = Cargar(ds.Tables(0).Rows(0))
            Else
                oeMarca = Nothing
            End If
            Return oeMarca
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMarca As e_Marca) As List(Of e_Marca)
        Try
            Dim ldMarca As New List(Of e_Marca)
            Dim ds As DataSet
            With oeMarca
                ds = sqlhelper.ExecuteDataset("STD.Isp_Marca_Listar",
                                              .TipoOperacion,
                                              .Id,
                                              .TipoMarca)
            End With
            oeMarca = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMarca = Cargar(o_Fila)
                    ldMarca.Add(oeMarca)
                Next
            Else
                ldMarca = New List(Of e_Marca)
            End If
            Return ldMarca
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMarca As e_Marca) As Boolean
        Try
            With oeMarca
                sqlhelper.ExecuteNonQuery("STD.ISP_Marca_IAE", .TipoOperacion,
                .PrefijoID, .Id, .Codigo, .Nombre, .Abreviatura, .Activo,
                .UsuarioCreacion, .TipoMarca)
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function Eliminar(ByVal oeMarca As e_Marca) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.ISP_Marca_IAE", oeMarca.TipoOperacion, "", oeMarca.Id)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function ComboGrilla(loMarca As List(Of e_Marca))
        Dim ds = New DataTable
        ds.Columns.Add("Id")
        ds.Columns.Add("Nombre")
        For Each item As e_Marca In loMarca
            Dim newRow As DataRow = ds.NewRow()
            newRow("Id") = item.Id
            newRow("Nombre") = item.Nombre
            ds.Rows.Add(newRow)
        Next
        Return ds
    End Function

End Class
