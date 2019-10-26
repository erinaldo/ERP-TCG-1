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

Public Class d_ConfiguracionDato

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_ConfiguracionDato
        Try
            Dim oeConfiguracionDato = New e_ConfiguracionDato( _
                             o_fila("Id").ToString _
                             , o_fila("IdColumna").ToString _
                             , o_fila("Columna").ToString _
                             , o_fila("IndClave") _
                             , o_fila("NroFila") _
                             , o_fila("Descripcion").ToString _
                             , o_fila("TipoReferencia").ToString _
                             , o_fila("IdReferencia").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica").ToString _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo") _
            )
            Return oeConfiguracionDato
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeConfiguracionDato As e_ConfiguracionDato) As e_ConfiguracionDato

        Try
            Dim ds As DataSet
            With oeConfiguracionDato
                ds = sqlhelper.ExecuteDataset("STD.Isp_ConfiguracionDato_Listar", .TipoOperacion, .Id)
            End With
            If ds.Tables(0).rows.Count > 0 Then
                oeConfiguracionDato = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeConfiguracionDato
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeConfiguracionDato As e_ConfiguracionDato) As List(Of e_ConfiguracionDato)
        Try
            Dim ldConfiguracionDato As New List(Of e_ConfiguracionDato)
            Dim ds As DataSet
            With oeConfiguracionDato
                ds = sqlhelper.ExecuteDataset("STD.Isp_ConfiguracionDato_Listar", .TipoOperacion _
                        , .Id _
                        , .IdColumna _
                        , .NroFila _
                        , .Descripcion _
                        , .TipoReferencia _
                        , .IdReferencia _
                        , .Activo _
                        )
            End With
            oeConfiguracionDato = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeConfiguracionDato = Cargar(o_Fila)
                ldConfiguracionDato.Add(oeConfiguracionDato)
            Next
            Return ldConfiguracionDato
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeConfiguracionDato As e_ConfiguracionDato) As Boolean
        Try

            With oeConfiguracionDato
                sqlhelper.ExecuteNonQuery("STD.Isp_ConfiguracionDato_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdColumna _
                        , .NroFila _
                        , .Descripcion _
                        , .TipoReferencia _
                        , .IdReferencia _
                        , .UsuarioCreacion _
                        , .UsuarioModifica _
                        , .Activo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarMasivo(ByVal dtConfDato As DataTable) As Boolean
        Try
            sqlhelper.InsertarMasivo("STD.ConfiguracionDato", dtConfDato)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeConfiguracionDato As e_ConfiguracionDato) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_ConfiguracionDato_IAE", "E", _
             "", oeConfiguracionDato.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try

            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "STD.ConfiguracionDato", PrefijoID
                                  )
            Return stResultado
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
