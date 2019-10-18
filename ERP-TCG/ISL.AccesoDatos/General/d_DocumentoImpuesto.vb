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

Public Class d_DocumentoImpuesto

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_DocumentoImpuesto
        Try
            Dim oeDocumentoImpuesto = New e_DocumentoImpuesto( _
                             o_fila("Id").ToString _
                             , o_fila("IdTipoDocumento").ToString _
                             , o_fila("IdImpuesto").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("Porcentaje") _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeDocumentoImpuesto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDocumentoImpuesto As e_DocumentoImpuesto) As e_DocumentoImpuesto

        Try
            Dim ds As DataSet
            With oeDocumentoImpuesto
                ds = sqlhelper.ExecuteDataset("STD.Isp_DocumentoImpuesto_Listar", "" _
                        , .Id _
                        , .IdTipoDocumento _
                        , .IdImpuesto _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            If ds.Tables(0).rows.Count > 0 Then
                oeDocumentoImpuesto = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDocumentoImpuesto
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDocumentoImpuesto As e_DocumentoImpuesto) As List(Of e_DocumentoImpuesto)
        Try
            Dim ldDocumentoImpuesto As New List(Of e_DocumentoImpuesto)
            Dim ds As DataSet
            With oeDocumentoImpuesto
                ds = sqlhelper.ExecuteDataset("STD.Isp_DocumentoImpuesto_Listar", "" _
                        , .Id _
                        , .IdTipoDocumento _
                        , .IdImpuesto _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeDocumentoImpuesto = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeDocumentoImpuesto = Cargar(o_Fila)
                ldDocumentoImpuesto.Add(oeDocumentoImpuesto)
            Next
            Return ldDocumentoImpuesto
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDocumentoImpuesto As e_DocumentoImpuesto) As Boolean
        Try
            With oeDocumentoImpuesto
                sqlhelper.ExecuteNonQuery("STD.Isp_DocumentoImpuesto_IAE", .TipoOperacion,
                        .Id _
                        , .IdTipoDocumento _
                        , .IdImpuesto _
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

    Public Function Eliminar(ByVal oeDocumentoImpuesto As e_DocumentoImpuesto) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.ISP_DocumentoImpuesto_IAE", "E", oeDocumentoImpuesto.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
