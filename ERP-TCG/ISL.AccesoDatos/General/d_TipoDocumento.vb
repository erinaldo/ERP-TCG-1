'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions


Public Class d_TipoDocumento

    Private oetipoDocumento As e_TipoDocumento
    Private oeDocumentoImpuesto As New e_DocumentoImpuesto
    Private odDocumentoImpuesto As New d_DocumentoImpuesto

    Private sqlhelper As New SqlHelper

    Public Function Cargar(ByVal o_fila As DataRow) As e_TipoDocumento
        Try
            Dim oeTipoDocumento = New e_TipoDocumento(
            o_fila("Id"), o_fila("CodigoSunat"), o_fila("Nombre"), o_fila("Abreviatura"),
             o_fila("Activo"), o_fila("IndIgv"))
            Return oeTipoDocumento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

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

    Public Function Listar(ByVal oeTipoDocumento As e_TipoDocumento) As List(Of e_TipoDocumento)
        Try
            Dim ldTipoMantenimiento As New List(Of e_TipoDocumento)
            Dim ds As DataSet
            With oeTipoDocumento
                ds = sqlhelper.ExecuteDataset("STD.Isp_TipoDocumento_Listar", .TipoOperacion, .Id, .Codigo,
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

    Public Function Guardar(ByVal oeTipoDocumento As e_TipoDocumento) As Boolean
        Try
            Using TransScope As New TransactionScope()
                Dim id As String = ""
                With oeTipoDocumento
                    id = sqlhelper.ExecuteScalar("STD.Isp_TipoDocumento_IAE", .TipoOperacion,
                    .PrefijoID, .Id, .Codigo, .Nombre, .Abreviatura,
                     .Activo)
                End With
                If oeTipoDocumento.leDocumentoImpuesto IsNot Nothing Then
                    For Each oeDocumentoImpuesto As e_DocumentoImpuesto In oeTipoDocumento.leDocumentoImpuesto
                        oeDocumentoImpuesto.IdTipoDocumento = id
                        oeDocumentoImpuesto.PrefijoID = oeTipoDocumento.PrefijoID '@0001
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


    Public Function Eliminar(ByVal oeTipoDocumento As e_TipoDocumento) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_TipoDocumento_IAE", "E", "",
                                      oeTipoDocumento.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
