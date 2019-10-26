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


Public Class d_Email

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Email
        Try
            Dim oeEmail = New e_Email( _
                             o_fila("Id") _
                             , o_fila("TipoPersonaEmpresa") _
                             , o_fila("IdPersonaEmpresa") _
                             , o_fila("Nombre") _
                             , o_fila("Principal") _
                             , o_fila("Activo") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion") _
                             , o_fila("NombreCompleto") _
            )
            Return oeEmail
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeEmail As e_Email) As e_Email
        Try
            Dim ds As DataSet
            With oeEmail
                ds = sqlhelper.ExecuteDataset("STD.Isp_Email_Listar", "", .Id, .TipoPersonaEmpresa, .IdPersonaEmpresa, .Principal, .Nombre, .UsuarioCreacion, .Activo)
            End With
            oeEmail = New e_Email
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeEmail = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeEmail
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeEmail As e_Email) As List(Of e_Email)
        Try
            Dim ldEmail As New List(Of e_Email)
            Dim ds As DataSet
            With oeEmail
                ds = sqlhelper.ExecuteDataset("STD.Isp_Email_Listar", .TipoOperacion _
                        , .Id _
                        , .TipoPersonaEmpresa _
                        , .IdPersonaEmpresa _
                        , .Principal _
                        , .Nombre _
                        , .UsuarioCreacion _
                         , .Activo
                        )
            End With
            oeEmail = New e_Email
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeEmail = Cargar(o_Fila)
                    ldEmail.Add(oeEmail)
                Next
                '    Return ldEmail
                'Else
                '    Return Nothing
            End If
            Return ldEmail
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeEmail As e_Email) As Boolean
        Try
            With oeEmail
                sqlhelper.ExecuteNonQuery("STD.Isp_Email_IAE", .TipoOperacion _
                        , .Id _
                        , .TipoPersonaEmpresa _
                        , .IdPersonaEmpresa _
                        , .Principal _
                        , .Nombre _
                         , .UsuarioCreacion _
                        , .Activo _
                       , .PrefijoID
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarLista(leEmail As List(Of e_Email)) As Boolean
        Try
            For Each oeAuxEmail In leEmail
                Guardar(oeAuxEmail)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeEmail As e_Email) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_Email_IAE", "E", oeEmail.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
