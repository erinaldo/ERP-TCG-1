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

Public Class d_CaracteristicaMaterial
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_CaracteristicaMaterial
        Try
            Dim oeCaracteristicaMaterial = New e_CaracteristicaMaterial( _
                             o_fila("Id").ToString _
                             , o_fila("IdCaracteristicaEspecial").ToString _
                             , o_fila("IdMaterial").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("CaracteristicaEspecial").ToString)
            Return oeCaracteristicaMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCaracteristicaMaterial As e_CaracteristicaMaterial) As e_CaracteristicaMaterial

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("ALM.Isp_CaracteristicaMaterial_Listar", "", oeCaracteristicaMaterial.Id)
            If ds.Tables.Count > 0 Then
                oeCaracteristicaMaterial = Cargar(ds.Tables(0).Rows(0))
                Return oeCaracteristicaMaterial
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCaracteristicaMaterial As e_CaracteristicaMaterial) As List(Of e_CaracteristicaMaterial)
        Try
            Dim ldCaracteristicaMaterial As New List(Of e_CaracteristicaMaterial)
            Dim ds As DataSet
            With oeCaracteristicaMaterial
                ds = sqlhelper.ExecuteDataset("ALM.Isp_CaracteristicaMaterial_Listar", "" _
                        , .Id _
                        , .IdCaracteristicaEspecial _
                        , .IdMaterial)
            End With
            oeCaracteristicaMaterial = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCaracteristicaMaterial = Cargar(o_Fila)
                    ldCaracteristicaMaterial.Add(oeCaracteristicaMaterial)
                Next
                Return ldCaracteristicaMaterial
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCaracteristicaMaterial As e_CaracteristicaMaterial) As Boolean
        Try
            With oeCaracteristicaMaterial
                sqlhelper.ExecuteNonQuery("ALM.Isp_CaracteristicaMaterial_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdCaracteristicaEspecial _
                        , .IdMaterial _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeCaracteristicaMaterial As e_CaracteristicaMaterial) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("ALM.Isp_CaracteristicaMaterial_IAE", "E", _
             "", oeCaracteristicaMaterial.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
