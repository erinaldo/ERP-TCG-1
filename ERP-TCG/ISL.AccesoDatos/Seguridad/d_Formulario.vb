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

Public Class d_Formulario

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Formulario
        Try
            Dim oeFormulario = New e_Formulario( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("Ruta").ToString _
                             , o_fila("Padre") _
                             , o_fila("IdForm").ToString _
                             , o_fila("NombrePadre").ToString _
                             , o_fila("MultipleInstancia") _
                             , o_fila("Activo").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
            )
            Return oeFormulario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeFormulario As e_Formulario) As e_Formulario

        Try
            Dim ds As DataSet
            With oeFormulario
                ds = sqlhelper.ExecuteDataset("SGD.Isp_Formulario_Listar", .TipoOperacion, .Id, .Codigo, .Nombre)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeFormulario = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeFormulario
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeFormulario As e_Formulario) As List(Of e_Formulario)
        Try
            Dim ldFormulario As New List(Of e_Formulario)
            Dim ds As DataSet
            With oeFormulario
                ds = sqlhelper.ExecuteDataset("SGD.Isp_Formulario_Listar", "" _
                        , .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Descripcion _
                        , .Ruta _
                        , .Activo _
                        )
            End With
            oeFormulario = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeFormulario = Cargar(o_Fila)
                ldFormulario.Add(oeFormulario)
            Next
            Return ldFormulario
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarPadre(ByVal oeFormulario As e_Formulario) As List(Of e_Formulario)
        Try
            Dim ldFormulario As New List(Of e_Formulario)
            Dim ds As DataSet
            With oeFormulario
                ds = sqlhelper.ExecuteDataset("SGD.Isp_Formulario_Listar", "" _
                        , .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Descripcion _
                        , .Ruta _
                        , .Activo _
                        , .Padre _
                        )
            End With
            oeFormulario = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeFormulario = Cargar(o_Fila)
                ldFormulario.Add(oeFormulario)
            Next
            Return ldFormulario
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeFormulario As e_Formulario) As Boolean
        Try
            With oeFormulario
                sqlhelper.ExecuteNonQuery("SGD.Isp_Formulario_IAE", .TipoOperacion,
                        .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Descripcion _
                        , .Ruta _
                        , .Padre _
                        , .IdPadre _
                        , .Multiinstancia _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .PrefijoID
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeFormulario As e_Formulario) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SGD.Isp_Formulario_IAE", "E", oeFormulario.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
