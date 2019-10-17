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


Public Class d_OCMaterial_OSMaterial
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_OCMaterial_OSMaterial
        Try
            Dim oeOCMaterial_OSMaterial = New e_OCMaterial_OSMaterial( _
                             o_fila("Id").ToString _
                             , o_fila("IdOrden").ToString _
                             , o_fila("IdOrdenAsociada").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("FechaCreacion").ToString _
            )
            Return oeOCMaterial_OSMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeOCMaterial_OSMaterial As e_OCMaterial_OSMaterial) As e_OCMaterial_OSMaterial

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", oeOCMaterial_OSMaterial.Id)
            If ds.Tables.Count > 0 Then
                oeOCMaterial_OSMaterial = Cargar(ds.Tables(0).Rows(0))
                Return oeOCMaterial_OSMaterial
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOCMaterial_OSMaterial As e_OCMaterial_OSMaterial) As List(Of e_OCMaterial_OSMaterial)
        Try
            Dim ldOCMaterial_OSMaterial As New List(Of e_OCMaterial_OSMaterial)
            Dim ds As DataSet
            With oeOCMaterial_OSMaterial
                ds = sqlhelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "" _
                        , .Id _
                        , .IdOrden _
                        , .IdOrdenAsociada _
                        , .Activo _
                        , .FechaCreacion _
                        )
            End With
            oeOCMaterial_OSMaterial = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeOCMaterial_OSMaterial = Cargar(o_Fila)
                    ldOCMaterial_OSMaterial.Add(oeOCMaterial_OSMaterial)
                Next
                Return ldOCMaterial_OSMaterial
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOCMaterial_OSMaterial As e_OCMaterial_OSMaterial) As Boolean
        Try
            With oeOCMaterial_OSMaterial
                sqlhelper.ExecuteNonQuery("CMP.OCMaterial_OSMaterial_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdOrden _
                        , .IdOrdenAsociada _
                        , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeOCMaterial_OSMaterial As e_OCMaterial_OSMaterial) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeOCMaterial_OSMaterial.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
