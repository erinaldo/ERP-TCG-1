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

Public Class d_FondoFijo
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_FondoFijo
        Try
            Dim oeFondoFijo = New e_FondoFijo( _
                             o_fila("Id").ToString _
                             , o_fila("FondoFijo").ToString _
                              , o_fila("Glosa").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion").ToString _
            )
            Return oeFondoFijo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeFondoFijo As e_FondoFijo) As e_FondoFijo

        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_FondoFijo_Listar", "", _
            oeFondoFijo.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeFondoFijo = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeFondoFijo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeFondoFijo As e_FondoFijo) As List(Of e_FondoFijo)
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ldFondoFijo As New List(Of e_FondoFijo)
            Dim ds As DataSet
            With oeFondoFijo
                ds = sqlhelper.ExecuteDataset("STD.Isp_FondoFijo_Listar", "" _
                        , .Id _
                        , .FondoFijo _
                        , .Fecha _
                        , .Activo _
                        , .UsuarioCreacion _
                        )
            End With
            oeFondoFijo = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeFondoFijo = Cargar(o_Fila)
                    ldFondoFijo.Add(oeFondoFijo)
                Next
            End If
            Return ldFondoFijo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeFondoFijo As e_FondoFijo) As Boolean
        Try
            With oeFondoFijo
                sqlhelper.ExecuteNonQuery("STD.Isp_FondoFijo_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .FondoFijo _
                         , .Glosa _
                        , .Fecha _
                        , .Activo _
                        , .UsuarioCreacion
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeFondoFijo As e_FondoFijo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_FondoFijo_IAE", "E", _
             "", oeFondoFijo.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class