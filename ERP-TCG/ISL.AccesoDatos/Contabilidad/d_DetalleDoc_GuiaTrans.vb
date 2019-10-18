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

Public Class d_DetalleDoc_GuiaTrans

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_DetalleDoc_GuiaTrans
        Try
            Dim oeDetalleDoc_GuiaTrans = New e_DetalleDoc_GuiaTrans( _
                             o_Fila("Id").ToString _
                             , o_Fila("IdDetalleDoc").ToString _
                             , o_Fila("IdGuiaTrans").ToString _
                             , o_Fila("IdEstado").ToString _
                             , o_Fila("FechaCreacion").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
                             , o_Fila("Activo").ToString _
            )
            Return oeDetalleDoc_GuiaTrans
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleDoc_GuiaTrans As e_DetalleDoc_GuiaTrans) As e_DetalleDoc_GuiaTrans

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_DetalleDoc_GuiaTrans_Listar ", "", oeDetalleDoc_GuiaTrans.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeDetalleDoc_GuiaTrans = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDetalleDoc_GuiaTrans
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleDoc_GuiaTrans As e_DetalleDoc_GuiaTrans) As List(Of e_DetalleDoc_GuiaTrans)
        Try
            Dim ldDetalleDoc_GuiaTrans As New List(Of e_DetalleDoc_GuiaTrans)
            Dim ds As DataSet
            With oeDetalleDoc_GuiaTrans
                ds = sqlhelper.ExecuteDataset("CON.Isp_DetalleDoc_GuiaTrans_Listar ", "" _
                        , .Id _
                        , .IdDetalleDoc _
                        , .IdGuiaTrans _
                        , .IdEstado _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeDetalleDoc_GuiaTrans = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeDetalleDoc_GuiaTrans = Cargar(o_Fila)
                ldDetalleDoc_GuiaTrans.Add(oeDetalleDoc_GuiaTrans)
            Next
            Return ldDetalleDoc_GuiaTrans
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleDoc_GuiaTrans As e_DetalleDoc_GuiaTrans) As Boolean
        Try
            With oeDetalleDoc_GuiaTrans
                sqlhelper.ExecuteNonQuery("CON.Isp_DetalleDoc_GuiaTrans_IAE ", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdDetalleDoc _
                        , .IdGuiaTrans _
                        , .IdEstado _
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

    Public Function Eliminar(ByVal oeDetalleDoc_GuiaTrans As e_DetalleDoc_GuiaTrans) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_DetalleDoc_GuiaTrans_IAE ", "E", _
             "", oeDetalleDoc_GuiaTrans.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Trae Ultimo id de la tabla CON.MovimientoAnalisis para casos de insercion masiva
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "CON.DetalleDoc_GuiaTrans", PrefijoID
                                  )
            Return stResultado
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarMasivo(ByVal dtDetalleDocGT As DataTable) As Boolean
        Try
            sqlhelper.InsertarMasivo("CON.DetalleDoc_GuiaTrans", dtDetalleDocGT)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
