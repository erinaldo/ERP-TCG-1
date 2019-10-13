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

Public Class d_CtaCtbleSubFamiliaMat
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_CtaCtbleSubFamiliaMat
        Try
            Dim oeCtaCtble_SubFamiliaMat = New e_CtaCtbleSubFamiliaMat(o_fila("Id").ToString _
                             , o_fila("IdSubFamilia").ToString _
                             , o_fila("SubFamilia").ToString _
                             , o_fila("IdCtaCtbleExistencias").ToString _
                             , o_fila("Cuenta").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Ejercicio").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("IdCtaCtbleCompras").ToString _
                             , o_fila("CtaCtbleCompras").ToString _
                             , o_fila("NroCtaCtbleCompras").ToString _
                             , o_fila("IdCtaCtbleConsumo").ToString _
                             , o_fila("CtaCtbleConsumo").ToString _
                             , o_fila("NroCtaCtbleConsumo").ToString _
                             , o_fila("IdItemGasto").ToString _
                             , o_fila("ItemGasto").ToString)
            Return oeCtaCtble_SubFamiliaMat
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCtaCtble_SubFamiliaMat As e_CtaCtbleSubFamiliaMat) As e_CtaCtbleSubFamiliaMat
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_CtaCtble_SubFamiliaMat_Listar", oeCtaCtble_SubFamiliaMat.TipoOperacion, oeCtaCtble_SubFamiliaMat.Id)
            oeCtaCtble_SubFamiliaMat = New e_CtaCtbleSubFamiliaMat
            If ds.Tables(0).Rows.Count > 0 Then
                oeCtaCtble_SubFamiliaMat = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCtaCtble_SubFamiliaMat
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCtaCtble_SubFamiliaMat As e_CtaCtbleSubFamiliaMat) As List(Of e_CtaCtbleSubFamiliaMat)
        Try
            Dim ldCtaCtble_SubFamiliaMat As New List(Of e_CtaCtbleSubFamiliaMat)
            Dim ds As DataSet
            With oeCtaCtble_SubFamiliaMat
                ds = sqlhelper.ExecuteDataset("CON.Isp_CtaCtble_SubFamiliaMat_Listar", .TipoOperacion _
                        , .Id _
                        , .IdSubFamilia _
                        , .IdCtaCtbleExistencias)
            End With
            oeCtaCtble_SubFamiliaMat = New e_CtaCtbleSubFamiliaMat
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCtaCtble_SubFamiliaMat = Cargar(o_Fila)
                    ldCtaCtble_SubFamiliaMat.Add(oeCtaCtble_SubFamiliaMat)
                Next
            End If           
            Return ldCtaCtble_SubFamiliaMat
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCtaCtbleSubFamiliaMat As e_CtaCtbleSubFamiliaMat) As Boolean
        Try
            With oeCtaCtbleSubFamiliaMat
                sqlhelper.ExecuteNonQuery("CON.Isp_CtaCtble_SubFamiliaMat_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdSubFamilia _
                        , .IdCtaCtbleExistencias _
                        , .IdCtaCtbleCompras _
                        , .IdCtaCtbleConsumo _
                        , .IdItemGasto _
                        , .Ejercicio _
                        , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

    Public Function Eliminar(ByVal oeCtaCtble_SubFamiliaMat As e_CtaCtbleSubFamiliaMat) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_CtaCtble_SubFamiliaMat_IAE", "E", "", oeCtaCtble_SubFamiliaMat.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
