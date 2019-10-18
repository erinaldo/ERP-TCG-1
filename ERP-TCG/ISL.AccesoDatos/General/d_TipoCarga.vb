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

Public Class d_TipoCarga

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_TipoCarga
        Try
            Dim oeTipoCarga = New e_TipoCarga( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeTipoCarga
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoCarga As e_TipoCarga) As e_TipoCarga

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[STD].[Isp_TipoCarga_Listar]", "", oeTipoCarga.Id)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeTipoCarga = Cargar(ds.Tables(0).Rows(0))
            Else
                oeTipoCarga = New e_TipoCarga
            End If
            Return oeTipoCarga
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeTipoCarga As e_TipoCarga) As List(Of e_TipoCarga)
        Try
            Dim ldTipoCarga As New List(Of e_TipoCarga)
            Dim ds As DataSet
            With oeTipoCarga
                ds = sqlhelper.ExecuteDataset("[STD].[Isp_TipoCarga_Listar]", "" _
                                            , .Id _
                                            , .Codigo _
                                            , .Nombre _
                                            , .Activo)
            End With
            oeTipoCarga = Nothing
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTipoCarga = Cargar(o_Fila)
                    ldTipoCarga.Add(oeTipoCarga)
                Next
            Else
                ldTipoCarga = New List(Of e_TipoCarga)
            End If
            Return ldTipoCarga
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoCarga As e_TipoCarga) As Boolean
        Try
            With oeTipoCarga
                sqlhelper.ExecuteNonQuery("[STD].[Isp_TipoCarga_IAE]",
                                          .TipoOperacion,
                                          .PrefijoID,
                                        .Id _
                                        , .Codigo _
                                        , .Nombre _
                                        , .Abreviatura _
                                        , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeTipoCarga As e_TipoCarga) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[STD].[Isp_TipoCarga_IAE]", _
                                      "E", _
                                        "", _
                                        oeTipoCarga.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    'Public Function Listar() As List(Of e_TipoCarga)
    '    Try
    '        Dim ldTipoCarga As New List(Of e_TipoCarga)
    '        Dim ds As DataSet
    '        Dim oeTipoCarga As New e_TipoCarga
    '        With oeTipoCarga
    '            ds = sqlhelper.ExecuteDataset("[STD].[Isp_TipoCarga_Listar]")
    '        End With
    '        oeTipoCarga = Nothing
    '        If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
    '            For Each o_Fila As DataRow In ds.Tables(0).Rows
    '                oeTipoCarga = Cargar(o_Fila)
    '                ldTipoCarga.Add(oeTipoCarga)
    '            Next
    '        Else
    '            ldTipoCarga = New List(Of e_TipoCarga)
    '        End If
    '        Return ldTipoCarga
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    Public Function ComboGrilla(ByVal ListaTipoCarga As List(Of e_TipoCarga))
        Dim ds = New DataTable
        ds.Columns.Add("Id")
        ds.Columns.Add("Nombre")
        For Each item As e_TipoCarga In ListaTipoCarga
            Dim newRow As DataRow = ds.NewRow()
            newRow("Id") = item.Id
            newRow("Nombre") = item.Nombre
            ds.Rows.Add(newRow)
        Next
        Return ds
    End Function

End Class
