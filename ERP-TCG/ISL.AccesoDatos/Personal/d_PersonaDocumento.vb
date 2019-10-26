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

Public Class d_PersonaDocumento
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_PersonaDocumento
        Try
            Dim oePersonaDocumento = New e_PersonaDocumento( _
                             o_fila("Id").ToString _
                             , o_fila("IdPersona").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Dni").ToString _
                             , o_fila("IdTipoDocumento").ToString _
                             , o_fila("TipoDocumento").ToString _
                             , o_fila("NumeroDocumento").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("FechaActividad") _
                             , o_fila("FechaVencimiento") _
                             , o_fila("Vigente") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo") _
            )

            oePersonaDocumento.RutaImagen = o_fila("RutaImagen").ToString

            Return oePersonaDocumento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oePersonaDocumento As e_PersonaDocumento) As e_PersonaDocumento

        Try
            Dim ds As DataSet
            With oePersonaDocumento
                ds = sqlhelper.ExecuteDataset("PER.Isp_PersonaDocumento_Listar", .TipoOperacion, .Id)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oePersonaDocumento = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oePersonaDocumento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oePersonaDocumento As e_PersonaDocumento) As List(Of e_PersonaDocumento)
        Try
            Dim ldPersonaDocumento As New List(Of e_PersonaDocumento)
            Dim ds As DataSet
            With oePersonaDocumento
                ds = sqlhelper.ExecuteDataset("PER.Isp_PersonaDocumento_Listar", "" _
                        , .Id _
                        , .IdPersona _
                        , .IdTipoDocumento _
                        , .NumeroDocumento _
                        , .Descripcion _
                        , .FechaActividad _
                        , .FechaVencimiento _
                        , .Vigente _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oePersonaDocumento = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oePersonaDocumento = Cargar(o_Fila)
                ldPersonaDocumento.Add(oePersonaDocumento)
            Next
            Return ldPersonaDocumento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oePersonaDocumento As e_PersonaDocumento) As Boolean
        Try
            With oePersonaDocumento
                sqlhelper.ExecuteNonQuery("PER.Isp_PersonaDocumento_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdPersona _
                        , .IdTipoDocumento _
                        , .NumeroDocumento _
                        , .Descripcion _
                        , .FechaActividad _
                        , .FechaVencimiento _
                        , .Vigente _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .RutaImagen
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarMasivo(ByVal dtPerDoc As DataTable) As Boolean
        Try
            sqlhelper.InsertarMasivo("PER.PersonaDocumento", dtPerDoc)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oePersonaDocumento As e_PersonaDocumento) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_PersonaDocumento_IAE", "E", _
             "", oePersonaDocumento.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "PER.PersonaDocumento", PrefijoID
                                  )
            Return stResultado
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
